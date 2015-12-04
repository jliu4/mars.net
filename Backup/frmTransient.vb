Option Strict Off
Option Explicit On
Friend Class frmTransient
	Inherits System.Windows.Forms.Form
	
	Private Const NumLCCaptions As Short = 2
	Private SegLabels(11, 1) As String
	Private CurLine As Short
	Private NumLines As Short
	Private ShipDesLoc As ShipGlobal
	Private MoorLines As MoorSystem
	Private CurDraft As Double
	Private SurDraft As Double
	Private OprDraft As Double
	
	Dim Yaw, X, Y, Head As Double
	
	Dim PlotX() As Double
	Dim PlotY() As Double
	Dim PlotHead() As Double
	Dim PlotIndex As Short
	Dim MaxOffset As Double ' use to save max offset distance
	Dim MaxTransY, MaxTransX, MaxTransTime As Double
	
	Dim LCColHead(NumLCCaptions - 1) As String
	Dim TMColHead(3) As String
	Dim TMRowHead() As String
	Dim LCRowHead() As String
	
	Dim TransientComputed As Boolean
	
	
	Private Sub LoadMoorLines()
		' This routine makes a copy of the mooring data into MoorLines object
		
		'UPGRADE_NOTE: Segment was upgraded to Segment_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Segment_Renamed As Segment
		'UPGRADE_NOTE: MoorLine was upgraded to MoorLine_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim MoorLine_Renamed As MoorLine
		Dim i As Short
		
		Dim SegTp As String
		Dim TLg, Lg, dia As Double
		Dim E1, BS, E2 As Double
		Dim Buoy, DryWt, WetWt, BuoyL As Double
		Dim FrCoef As Double
		
		MoorLines = New MoorSystem
		
		With CurVessel
			NumLines = .MoorSystem.MoorLineCount
			CurDraft = .ShipDraft
			SurDraft = .ShipDraftSur
			OprDraft = .ShipDraftOpr
		End With
		
		MoorLines.ShipDraft = CurDraft
		ShipDesLoc = MoorLines.ShipGlob
		
		With CurVessel.ShipDesGlob
			ShipDesLoc.Xg = .Xg
			ShipDesLoc.Yg = .Yg
			ShipDesLoc.Heading = .Heading
		End With
		
		For i = 1 To NumLines Step 1
			MoorLines.MoorLineAdd()
			MoorLine_Renamed = CurVessel.MoorSystem.MoorLines(i)
			
			With MoorLines.MoorLines(i)
				.BottomSlope = MoorLine_Renamed.BottomSlope
				.Connected = True
				.DesScope = MoorLine_Renamed.DesScope
				
				.Payout = MoorLine_Renamed.Payout
				.PayoutSur = MoorLine_Renamed.PayoutSur
				.PayoutOpr = MoorLine_Renamed.PayoutOpr
				.PretensionSur = MoorLine_Renamed.PretensionSur
				.PretensionOpr = MoorLine_Renamed.PretensionOpr
				
				.FairLead.SprdAngle = MoorLine_Renamed.FairLead.SprdAngle
				.FairLead.Xs = MoorLine_Renamed.FairLead.Xs
				.FairLead.Ys = MoorLine_Renamed.FairLead.Ys
				.FairLead.z = MoorLine_Renamed.FairLead.z
				
				.Anchor.Xg = MoorLine_Renamed.Anchor.Xg
				.Anchor.Yg = MoorLine_Renamed.Anchor.Yg
				.WaterDepth = MoorLine_Renamed.WaterDepth
			End With
			
			For	Each Segment_Renamed In MoorLine_Renamed
				With Segment_Renamed
					SegTp = .SegType
					Lg = .Length
					TLg = .TotalLength
					dia = .Diameter
					BS = .BS
					E1 = .E1
					E2 = .E2
					DryWt = .UnitDryWeight
					WetWt = .UnitWetWeight
					Buoy = .Buoy
					BuoyL = .BuoyLength
					FrCoef = .FrictionCoef
				End With
				Call MoorLines.MoorLines(i).SegmentAdd(SegTp, Lg, TLg, dia, BS, E1, E2, DryWt, WetWt, Buoy, BuoyL, FrCoef)
			Next Segment_Renamed
		Next 
		
		If NumLines < 1 Then
			NumLines = 1
			MoorLines.MoorLineAdd()
		End If
		
	End Sub
	
	Private Sub btnEnvironment_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnEnvironment.Click
		VB6.ShowForm(frmEnviron, 1, Me)
		txtEnvironment.Text = CurVessel.EnvLoad.EnvCur.Name
	End Sub
	
	Private Sub btnReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnReport.Click
		
		If Not TransientComputed Then
			MsgBox("Must perform analysis first.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Error")
			Exit Sub
		End If
		' display report
		Dim oxr As New ExcelReporter
		'     oxr.ReportMooringAnalysisResults "Transient Analysis", "Test", 1, Not IsMetricUnit, CurVessel
		Exit Sub
ErrHandler: 
		MsgBox("Err creating report...")
		
	End Sub
	
	Private Sub frmTransient_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		LoadMoorLines()
		Dim Hf, Wf, w, H, H0 As Double
		Dim i As Short
		Dim NumLinesIsZero As Boolean
		
		Dim NumLines As Short
		NumTimeSteps = 80
		TimeStep = 5 ' sec
		MaxTimeSteps = 10000
		
		
		NumLines = CurProj.Vessel.MoorSystem.MoorLineCount
		
		If NumLines = 0 Then
			NumLinesIsZero = True
			NumLines = 8
		Else
			NumLinesIsZero = False
		End If
		ReDim LCRowHead(NumLines)
		
		' Set up row and column headings for the Conditions grid
		
		LCRowHead(0) = ""
		ReDim LCRowHead(NumLines)
		For i = 1 To NumLines
			LCRowHead(i) = CStr(i)
		Next i
		
		LCColHead(0) = "Line"
		LCColHead(1) = "Connected"
		
		Call SetupLineGrid(grdLC, LCRowHead, LCColHead, 0, VB6.PixelsToTwipsX(fraMoorLineStatus.Width) + VB6.PixelsToTwipsX(fraMoorLineStatus.Left), 300, VB6.PixelsToTwipsY(fraMoorLineStatus.Height), NumLines, SysInfo1, True, 1#, Me)
		With grdLC
			.Col = 0
			For i = 1 To NumLines
				.Row = i
				.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
			Next i
		End With
		
		
		' Initialize the Conditions grid from the global arrays
		
		For i = 1 To NumLines
			' Line column
			grdLC.Row = i
			grdLC.Col = 1
			grdLC.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
			
			If MoorLines.MoorLines(i).Connected Then
				grdLC.Text = "Yes"
			Else
				grdLC.Text = "No"
			End If
		Next i
		
		' Intialize the text boxes
		
		txtDuration.Text = VB6.Format(TimeStep * NumTimeSteps, "##,##0.0")
		txtInterval.Text = VB6.Format(TimeStep, "##0.00")
		
		If NumLinesIsZero Then NumLines = 0
		TransientComputed = False
		
		RefreshData()
		txtEnvironment.Text = CurVessel.EnvLoad.EnvCur.Name
	End Sub
	
	Private Sub InitGrid()
		Dim i As Short
		' Set up the transient grid
		
		ReDim TMRowHead(NumTimeSteps + 2)
		For i = 0 To NumTimeSteps + 1
			TMRowHead(i) = VB6.Format((i - 1) * TimeStep, "#,##0.0")
		Next i
		
		Dim LUnit As String
		If IsMetricUnit Then
			LUnit = "(m)"
		Else
			LUnit = "(ft)"
		End If
		
		TMColHead(0) = "Time (sec)"
		TMColHead(1) = "X (E) " & LUnit
		TMColHead(2) = "Y (N) " & LUnit
		TMColHead(3) = "Heading (deg) TN"
		
		Call SetupLineGrid(grdTM, TMRowHead, TMColHead, 0, VB6.PixelsToTwipsX(fraTransientMotion.Width) - 50, 300, VB6.PixelsToTwipsY(fraTransientMotion.Height) - SysInfo1.ScrollBarSize - 1200, NumTimeSteps + 1, SysInfo1, True, 2#, Me)
		With grdTM
			.Col = 0
			For i = 1 To NumTimeSteps
				.Row = i
				.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
			Next i
		End With
	End Sub
	
	Private Sub RefreshData()
		RefreshUnitLabels(Me)
		InitGrid()
	End Sub
	
	
	Private Sub ChangeCurEnv(ByRef EnvID As Short)
		
		Dim i As Short
		'UPGRADE_NOTE: Wave was upgraded to Wave_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		'UPGRADE_NOTE: Wind was upgraded to Wind_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Wind_Renamed As Wind
		Dim Wave_Renamed As Wave
		Dim Curr As Current
		Dim SelEnv As Metocean
		
		SelEnv = CurVessel.EnvLoad.Environments(EnvID)
		
		CurVessel.EnvLoad.EnvCur.Name = SelEnv.Name
		
	End Sub
	
	
	Private Sub frmTransient_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		' Restore the Mooring System to the intact condition
		Dim i As Short
		For i = 1 To CurProj.Vessel.MoorSystem.MoorLineCount
			CurProj.Vessel.MoorSystem.MoorLines(i).Connected = True
		Next i
		eventArgs.Cancel = Cancel
	End Sub
	
	
	'UPGRADE_WARNING: Event frmTransient.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmTransient_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		'UPGRADE_ISSUE: Form property frmTransient.ScaleTop was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		ResizePicture(picPolar, VB6.PixelsToTwipsX(fraTransientMotion.Left) + VB6.PixelsToTwipsX(fraTransientMotion.Width) + 150, VB6.PixelsToTwipsX(Me.ClientRectangle.Width) - 350, Me.ScaleTop - 150, VB6.PixelsToTwipsY(Me.ClientRectangle.Height) - 150)
	End Sub
	
	Private Sub grdLC_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdLC.DblClick
		
		If grdLC.Col = 0 Then
			Exit Sub
		ElseIf grdLC.Col = 1 Then 
			If grdLC.Text = "Yes" Then
				grdLC.Text = "No"
			ElseIf grdLC.Text = "No" Then 
				grdLC.Text = "Yes"
			End If
			
			With CurVessel.MoorSystem.MoorLines((grdLC.Row))
				.Connected = Not .Connected
			End With
			
		End If
		
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub
	
	
	Private Sub btnSetVesselCoords_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSetVesselCoords.Click
		If Not TransientComputed Then
			MsgBox("You have not yet calculated a new position to save", MsgBoxStyle.OKOnly, "MARS - No New Position")
			Exit Sub
		End If
		
		If MsgBox("Are you sure you want to replace the current vessel position?", MsgBoxStyle.OKCancel, "MARS - Change Vessel Position?") = MsgBoxResult.OK Then
			
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
			
			With CurVessel.ShipCurGlob
				.Xg = X
				.Yg = Y
				.Heading = Head
			End With
			
			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
			Me.Close()
			
		End If
	End Sub
	
	Private Sub btnTransient_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnTransient.Click
		
		Dim LFactor, FrcFactor As Double
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
		Else
			LFactor = 1
			FrcFactor = 1
		End If
		
		Dim i, r, c, j As Short
		Dim Dist, PWD As Double
		
		
		'UPGRADE_WARNING: Arrays can't be declared with New. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC9D3AE5-6B95-4B43-91C7-28276302A5E8"'
		Dim Pos(2) As New ShipGlobal
		Dim Exx As Double
		'UPGRADE_WARNING: Arrays can't be declared with New. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC9D3AE5-6B95-4B43-91C7-28276302A5E8"'
		Dim Vel(2) As New Motion
		'UPGRADE_WARNING: Arrays can't be declared with New. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC9D3AE5-6B95-4B43-91C7-28276302A5E8"'
		Dim Acc(2) As New Motion
		Dim sMass As New Motion
		Dim sDamp As New Motion
		Dim FMoor As New Force
		Dim FEnv As New Force
		
		Dim NLines As Short
		
		NLines = CurProj.Vessel.MoorSystem.MoorLineCount
		
		'UPGRADE_WARNING: Lower bound of array LineConnected was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		Dim LineConnected(NLines) As Boolean
		ReDim PlotX(NumTimeSteps + 1)
		ReDim PlotY(NumTimeSteps + 1)
		ReDim PlotHead(NumTimeSteps + 1)
		ReDim TransX(NumTimeSteps + 1)
		ReDim TransY(NumTimeSteps + 1)
		ReDim TransYaw(NumTimeSteps + 1)
		'UPGRADE_WARNING: Lower bound of array TransTension was changed from 1,1 to 0,0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim TransTension(NLines, NumTimeSteps + 1)
		
		' Either environment or broken lines or both
		' can cause vessel to overshoot when happen suddenly
		
		On Error GoTo ErrHandler
		
		Me.Enabled = False
		Cancelled = False
		With frmProgress
			.Text = "Transient Analysis"
			.CurrentStage.Text = "Initializing..."
			.Progress = 0
			VB6.ShowForm(frmProgress, 0, Me)
		End With
		
		
		If Cancelled Then GoTo ExitSub
		With frmProgress
			.CurrentStage.Text = "Finding intact equilibrium position..."
			.Progress = 0
		End With
		
		'-----------------------------------------------------------------------------------
		' Compute vessel position before any line breaks
		'-----------------------------------------------------------------------------------
		
		For i = 1 To NLines
			' remember user-defined broken lines
			LineConnected(i) = CurProj.Vessel.MoorSystem.MoorLines(i).Connected
			' temporarily set all lines intact for initial position analysis
			CurProj.Vessel.MoorSystem.MoorLines(i).Connected = True
		Next i
		'------------------------------------------------------------------------------
		' calculate mooring force in local coordinate system
		'------------------------------------------------------------------------------
		
		Call CurVessel.FindEquilibriumPosition(False, frmProgress)
		
		'  calculate mooring system stiffness using given mooring forces
		Call CurVessel.MoorSystem.MoorStiff(FMoor, Pos(1), False)
		
		'------------------------------------------------------------------
		' Draw vessel position on polar plot
		'  parameters:  vessel initial location, vessel final location
		'  are all global system
		'------------------------------------------------------------------
		'UPGRADE_WARNING: Couldn't resolve default property of object TransX(1). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TransX(1) = CurVessel.ShipCurGlob.Xg
		'UPGRADE_WARNING: Couldn't resolve default property of object TransY(1). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TransY(1) = CurVessel.ShipCurGlob.Yg
		'UPGRADE_WARNING: Couldn't resolve default property of object TransYaw(1). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TransYaw(1) = CurVessel.ShipCurGlob.Heading
		'UPGRADE_WARNING: Couldn't resolve default property of object TransX(0). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TransX(0) = CurField.Item(CurField.CurWellNo).Xg
		'UPGRADE_WARNING: Couldn't resolve default property of object TransY(0). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TransY(0) = CurField.Item(CurField.CurWellNo).Yg
		
		
		Dim ZWD As Double
		ZWD = CurVessel.WaterDepth
		
		' first two argument are well locations
		
		'UPGRADE_WARNING: Couldn't resolve default property of object TransYaw(1). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object TransY(1). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object TransX(1). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object TransY(0). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object TransX(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call DrawPolarPlot(TransX(0), TransY(0), ZWD, TransX(1), TransY(1), TransYaw(1), picPolar, False)
		picPolar.Refresh()
		
		'------------------------------------------------------------------------------
		' Now breaking the broken lines
		'------------------------------------------------------------------------------
		For i = 1 To NLines
			CurProj.Vessel.MoorSystem.MoorLines(i).Connected = LineConnected(i)
		Next i
		
		' Compute the motion and make the plot
		
		'   initializing
		sMass = CurVessel.ShipMass(CurVessel.ShipDraft)
		sDamp = CurVessel.ShipDamp(CurVessel.ShipDraft)
		For i = 0 To 2
			Acc(i).Surge = 0
			Vel(i).Surge = 0
			Acc(i).Sway = 0
			Vel(i).Sway = 0
			Acc(i).Yaw = 0
			Vel(i).Yaw = 0
			With CurVessel.ShipCurGlob
				Pos(i).Xg = .Xg
				Pos(i).Yg = .Yg
				Pos(i).Heading = .Heading
			End With
		Next i
		
		Dim PlotIndex As Short
		
		For i = 1 To NumTimeSteps + 1
			PlotX(i) = 0
			PlotY(i) = 0
			PlotHead(i) = 0
			'    TransX(i) = 0
			'    TransY(i) = 0
			'    TransYaw(i) = CurVessel.ShipCurGlob.Heading
			For j = 1 To NLines
				TransTension(j, i) = 0
			Next j
		Next 
		
		MaxOffset = 0
		PlotIndex = 1
		'UPGRADE_WARNING: Couldn't resolve default property of object TransX(1). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PlotX(PlotIndex) = TransX(1)
		'UPGRADE_WARNING: Couldn't resolve default property of object TransY(1). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PlotY(PlotIndex) = TransY(1)
		'UPGRADE_WARNING: Couldn't resolve default property of object TransYaw(1). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PlotHead(PlotIndex) = TransYaw(1)
		
		For i = 1 To NumTimeSteps
			If Cancelled Then GoTo ExitSub
			With frmProgress
				.CurrentStage.Text = "Transient Analysis for Time = " & i * TimeStep & " sec"
				.Progress = ((i) / (NumTimeSteps)) * 75 + 15 '  Intact calc took 15% time
			End With
			
			
			FEnv = CurVessel.EnvLoad.FEnvLocl(Pos(1).Heading)
			Call CurVessel.MoorSystem.MoorForce(FMoor, Pos(1), False)
			
			Call CurVessel.NextPosnVel(TimeStep, Acc, Vel, Pos)
			Acc(2).Surge = (FMoor.Fx - sDamp.Surge * Vel(2).Surge + FEnv.Fx) / sMass.Surge
			Acc(2).Sway = (FMoor.Fy - sDamp.Sway * Vel(2).Sway + FEnv.Fy) / sMass.Sway
			Acc(2).Yaw = (FMoor.MYaw - sDamp.Yaw * Vel(2).Yaw + FEnv.MYaw) / sMass.Yaw
			
			'--------------------------------------------------------------
			' Update the current location
			'--------------------------------------------------------------
			
			Call CurVessel.UpdatePosVelnAcc(Acc, Vel, Pos)
			
			' save current transient data into arrays for display in tables / plot
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransX(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TransX(i) = Pos(2).Xg
			'UPGRADE_WARNING: Couldn't resolve default property of object TransY(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TransY(i) = Pos(2).Yg
			'UPGRADE_WARNING: Couldn't resolve default property of object TransYaw(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TransYaw(i) = Pos(2).Heading
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransY(0). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object TransY(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object TransX(0). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object TransX(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Dist = System.Math.Sqrt((TransX(i) - TransX(0)) ^ 2 + (TransY(i) - TransY(0)) ^ 2)
			If Dist > MaxOffset Then
				MaxOffset = Dist ' Max Transient Offset
				'UPGRADE_WARNING: Couldn't resolve default property of object TransX(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MaxTransX = TransX(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object TransY(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MaxTransY = TransY(i)
				MaxTransTime = TimeStep * (i - 1)
			End If
			
			For j = 1 To NumLines
				TransTension(j, i) = CurVessel.MoorSystem.MoorLines(j).MaxTension
			Next j
			
			If (i Mod 20 = 0) Then
				PlotIndex = PlotIndex + 1
				'UPGRADE_WARNING: Couldn't resolve default property of object TransX(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				PlotX(PlotIndex) = TransX(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object TransY(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				PlotY(PlotIndex) = TransY(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object TransYaw(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				PlotHead(PlotIndex) = TransYaw(i)
			End If
			
		Next i
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object TransY(0). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object TransX(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call DrawTransientPlot(TransX(0), TransY(0), PlotIndex, PlotX, PlotY, PlotHead, MaxTransX, MaxTransY, picPolar)
		
		With frmProgress
			.CurrentStage.Text = "Transient Analysis completed."
			.Progress = 100
		End With
		frmProgress.Close()
		
		
		'----------------------------------------------------------------
		' Update the text boxes
		Dim dy, dx, Bearing As Double
		'UPGRADE_WARNING: Couldn't resolve default property of object TransX(0). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object TransX(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dx = TransX(NumTimeSteps) - TransX(0)
		'UPGRADE_WARNING: Couldn't resolve default property of object TransY(0). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object TransY(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dy = TransY(NumTimeSteps) - TransY(0)
		
		Dist = System.Math.Sqrt(dx ^ 2 + dy ^ 2)
		PWD = Dist / CurVessel.WaterDepth
		
		txtOffset.Text = VB6.Format(Dist * LFactor, "##,##0") '  final offset
		txtOffsetPWD.Text = VB6.Format(PWD * 100#, "#0.0") ' final offset percent WD
		
		If dx = 0 And dy = 0 Then
			Bearing = 0#
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Atn2(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Bearing = Atn2(dx, dy)
			Bearing = PI / 2# - Bearing
		End If
		
		txtOffsetBearing.Text = VB6.Format(RadTo360(Bearing), "#0") '  Bearing is the angle of final position measured clockwise from TN ???
		
		PWD = MaxOffset / CurVessel.WaterDepth
		
		txtMaxOffset.Text = VB6.Format(MaxOffset * LFactor, "##,##0") ' Max Transient Offset
		txtMaxOffsetPWD.Text = VB6.Format(PWD * 100#, "#0.0") ' Max Transient Offset Percent WD
		txtMaxOffsetTime.Text = CStr(MaxTransTime)
		
		' Update the data table
		
		With grdTM
			.Rows = NumTimeSteps + 1
			For r = 1 To NumTimeSteps
				.Row = r
				.Col = 0
				.Text = VB6.Format(r * TimeStep, "#,##0.0")
				.Col = 1
				'UPGRADE_WARNING: Couldn't resolve default property of object TransX(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Text = VB6.Format(TransX(r) * LFactor, "#,##0.00")
				.Col = 2
				'UPGRADE_WARNING: Couldn't resolve default property of object TransY(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Text = VB6.Format(TransY(r) * LFactor, "#,##0.00")
				.Col = 3
				'UPGRADE_WARNING: Couldn't resolve default property of object TransYaw(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Text = VB6.Format(RadTo360(Val(TransYaw(r))), "##0.0")
			Next r
		End With
		
		TransientComputed = True
		
ExitSub: 
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		Me.Enabled = True
		
		Exit Sub
ErrHandler: 
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		MsgBox("Error: " & Err.Description & ", Source: " & Err.Source, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Error")
		Me.Enabled = True
		
	End Sub
	
	Private Sub btnDisplayCurves_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnDisplayCurves.Click
		If TransientComputed Then
			frmTransientCurves.Show()
		Else
			MsgBox("You have not yet computed any transient time histories to display!", MsgBoxStyle.OKOnly, "MARS - No Data To Display")
			Exit Sub
		End If
	End Sub
	
	Private Sub txtInterval_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtInterval.Leave
		Dim TS As Double
		If txtInterval.Text = "" Then
			Exit Sub
		Else
			TS = CDbl(txtInterval.Text)
			If TS <= 0 Then
				MsgBox("Time interval must be > 0!", MsgBoxStyle.OKOnly, "MARS - Invalid Value Entered")
				Exit Sub
			ElseIf Fix((CDbl(txtDuration.Text) / TS) + 0.5) > MaxTimeSteps Then 
				MsgBox("Duration / Time Interval must be less than " & CStr(MaxTimeSteps), MsgBoxStyle.OKOnly, "MARS - Too Many Time Steps")
				Exit Sub
			Else
				TimeStep = TS
				NumTimeSteps = Fix((CDbl(txtDuration.Text) / TimeStep) + 0.5)
			End If
		End If
	End Sub
	
	Private Sub txtDuration_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDuration.Leave
		Dim i As Short
		Dim Dur As Double
		If txtDuration.Text = "" Then
			Exit Sub
		Else
			Dur = CDbl(txtDuration.Text)
			If Dur <= 0 Then
				MsgBox("Duration must be >0!", MsgBoxStyle.OKOnly, "MARS - Invalid Value Entered")
				Exit Sub
			ElseIf Fix((Dur / TimeStep) + 0.5) > MaxTimeSteps Then 
				MsgBox("Duration / Time Interval must be less than " & CStr(MaxTimeSteps), MsgBoxStyle.OKOnly, "MARS - Too Many Time Steps")
				Exit Sub
			Else
				NumTimeSteps = Fix((Dur / TimeStep) + 0.5)
				ReDim TMRowHead(NumTimeSteps + 1)
				For i = 0 To NumTimeSteps + 1
					TMRowHead(i) = VB6.Format((i - 1) * TimeStep, "#,##0.0")
				Next i
				grdTM.Rows = NumTimeSteps + 2
				With grdTM
					.Col = 0
					For i = 1 To NumTimeSteps + 1
						.Row = i
						.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
						.Text = TMRowHead(i)
					Next i
				End With
			End If
		End If
	End Sub
End Class