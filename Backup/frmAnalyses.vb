Option Strict Off
Option Explicit On
Friend Class frmAnalyses
	Inherits System.Windows.Forms.Form
	' frmAnalyses           analysis results (quasi-static)
	' Version 2.1
	' 2001, Copyright DTCEL, All Rights Reserved
	
	
	Private SaveLoc As Boolean
	Private CheckingGrid As Boolean
	
	Private MoveLabels(6) As String
	Private TenLabels(7) As String
	Private DirLabels(2) As String
	
	Private NumLines As Short
	Private ShipLoc As ShipGlobal
	Private Movement, LFM, WFM, MaxDM As Motion
	Private SgnY, SgnX, SgnZ As Double
	Private Tension(MaxNumLines) As Double
	Private TSigLF(MaxNumLines) As Double
	Private TSigWF(MaxNumLines) As Double
	Private PreConnect(MaxNumLines) As Boolean
	
	Private Stiff As Force
	Private WFMd, LFMd As Motion
	Dim FrcFactor, LFactor, VelFactor As Double
	Dim LUnit, VelUnit As String
	
	Private Sub btnReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnReport.Click
		On Error GoTo ErrHandler
		
		' assume always perform no env first and save
		Dim InitPos As New Motion
		InitPos.Surge = 0
		InitPos.Sway = 0
		InitPos.Yaw = 0
		
		If LFM Is Nothing Then
			MsgBox("Must perform analysis first.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Error")
			Exit Sub
		End If
		' display report
		Dim ox As New ExcelReporter
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		Call ox.ReportMooringAnalysisResults(txtReportTitle.Text, (txtSubTitle.Text), 1, True, CurVessel, Movement, InitPos, Stiff, LFM, WFM, Tension, TSigLF, TSigWF)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		Exit Sub
ErrHandler: 
		MsgBox("Err creating report...")
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	
	' form load and unload
	
	Private Sub frmAnalyses_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Dim i As Short
		
		Text = Text & " - " & CurProj.Title
		
		NumLines = CurVessel.MoorSystem.MoorLineCount
		
		ShipLoc = New ShipGlobal
		Stiff = New Force
		WFMd = New Motion
		LFMd = New Motion
		MaxDM = New Motion
		
		Cancelled = True
		SaveLoc = False
		
		btnDerp.Enabled = False
		btnReport.Enabled = False
		txtReportTitle.Text = CurVessel.Name & ", Draft " & VB6.Format(CurVessel.ShipDraft, CStr(0)) & " ft, " & CurProj.WellSites.Item(CurProj.WellSites.CurWellNo).NameID
		txtSubTitle.Text = txtEnvironment.Text & ", " & txtPercentDamping(0).Text & "% Damping"
		RefreshData()
	End Sub
	
	Private Sub RefreshData()
		RefreshUnitLabels(Me)
		InitiateGrid()
		LoadData()
	End Sub
	Private Sub frmAnalyses_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object ShipLoc may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		ShipLoc = Nothing
		'UPGRADE_NOTE: Object Stiff may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Stiff = Nothing
		'UPGRADE_NOTE: Object WFMd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		WFMd = Nothing
		'UPGRADE_NOTE: Object LFMd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		LFMd = Nothing
		'UPGRADE_NOTE: Object MaxDM may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		MaxDM = Nothing
		
		With frmMain
			.Enabled = True
			.Activate()
			If SaveLoc Then .LoadData()
		End With
		
	End Sub
	
	' command buttons
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		
		Dim i As Short
		'
		With CurVessel.MoorSystem
			For i = 1 To NumLines
				.MoorLines(i).Connected = PreConnect(i)
			Next i
		End With
		' set back to original ship location?
		
		'
		Me.Close()
		
	End Sub
	
	Private Sub btnAnalysis_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnAnalysis.Click
		
		If System.Math.Abs(Val(txtVslSt(3).Text)) < 5 Then
			MsgBox("Draft too small.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Error")
			Exit Sub
		End If
		
		
		On Error GoTo ErrorHandler
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		Me.Enabled = False
		
		Cancelled = False
		With frmProgress
			.Show()
		End With
		
		With frmProgress
			.Text = "Quasi-static Mooring Analysis"
			.CurrentStage.Text = "Initializing..."
			.Progress = 0
		End With
		
		SaveLC()
		StaticAnalysis()
		
		If Cancelled = False Then
			With frmProgress
				.CurrentStage.Text = "Post-processing..."
				.Progress = 99
			End With
			UpdateData()
			
			With frmProgress
				.CurrentStage.Text = "Completed successfully."
				.Progress = 100
			End With
		End If
		frmProgress.Close()
		Me.Enabled = True
		Me.Visible = True
		Me.Activate()
		btnDerp.Enabled = True
		btnReport.Enabled = True
		Cursor = System.Windows.Forms.Cursors.Default
		Exit Sub
ErrorHandler: 
		Me.Enabled = True
		Cursor = System.Windows.Forms.Cursors.Default
		MsgBox("Error: " & Err.Description & " from Static Analysis: " & Err.Source, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Error")
		
	End Sub
	
	Private Sub btnSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSave.Click
		
		With CurVessel.DampingPercent
			.Surge = Val(txtPercentDamping(0).Text)
			.Sway = Val(txtPercentDamping(1).Text)
			.Yaw = Val(txtPercentDamping(2).Text)
		End With
		
		'    If MsgBox("Are you sure you want to replace the current vessel position?", _
		''                vbOKCancel, "MARS - Change Vessel Position?") = vbOK Then
		
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		With CurVessel.ShipCurGlob
			.Xg = ShipLoc.Xg
			.Yg = ShipLoc.Yg
			.Heading = ShipLoc.Heading
		End With
		SaveLoc = True
		CurProj.Saved = False
		
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		Me.Close()
		'    End If
	End Sub
	
	Private Sub btnEnvironment_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnEnvironment.Click
		
		VB6.ShowForm(frmEnviron, 1, Me)
		txtEnvironment.Text = CurVessel.EnvLoad.EnvCur.Name
		'  RefreshButtonStatus
	End Sub
	
	Private Sub btnDerp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnDerp.Click
		
		If Not DerpData Then
			MsgBox("Data export failure.", MsgBoxStyle.OKOnly, msgTitle)
		Else
			btnDerp.Enabled = False
		End If
		
	End Sub
	
	' grids operation
	
	Private Sub grdTensions_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdTensions.DblClick
		
		With grdTensions
			Select Case .Col
				Case 1
					If .Text = "Yes" Then
						.Text = "No"
					Else
						.Text = "Yes"
					End If
					CurVessel.MoorSystem.MoorLines(.Row).Connected = Not CurVessel.MoorSystem.MoorLines(.Row).Connected
			End Select
		End With
		
	End Sub
	
	'UPGRADE_WARNING: Event txtEnvironment.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtEnvironment_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtEnvironment.TextChanged
		txtSubTitle.Text = txtEnvironment.Text & ", " & txtPercentDamping(0).Text & "% Damping"
	End Sub
	
	
	' text box
	
	Private Sub txtVslSt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVslSt.Leave
		Dim Index As Short = txtVslSt.GetIndex(eventSender)
		
		txtVslSt(Index).Text = CheckData(txtVslSt(Index).Text)
		
	End Sub
	
	' operation subroutines
	' initiating
	
	Private Sub InitiateGrid()
		
		Dim r, c As Short
		Dim ColW As Double
		Dim RShown, RowH, BarSize As Short
		
		CheckingGrid = True
		
		Call SetLabels()
		
		With grdVM
			.WordWrap = True
			
			ColW = VB6.PixelsToTwipsX(.Width) / (.Cols + 0.2) - .GridLineWidth
			RowH = VB6.PixelsToTwipsY(.Height) / (.Rows + 0.5) - .GridLineWidth
			.set_ColWidth(0, VB6.PixelsToTwipsX(.Width) - ColW * (.Cols - 1) - 70)
			.set_RowHeight(0, VB6.PixelsToTwipsY(.Height) - RowH * 3 - 65)
			
			For c = 1 To .Cols - 1
				.set_ColWidth(c, ColW)
			Next c
			For r = .FixedRows To .Rows - 1
				.set_RowHeight(r, RowH)
			Next r
			
			.Col = 0
			For r = .FixedRows To .Rows - 1
				.Row = r
				.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
				.Text = DirLabels(r - 1)
			Next r
			For c = 0 To .Cols - 1
				.Row = 0
				.Col = c
				.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
				.Text = MoveLabels(c)
				For r = 1 To .Rows - 1
					.Row = r
					.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
				Next r
			Next c
			
			.Col = 0
			.Row = 0
		End With
		
		If NumLines > 8 Then
			BarSize = SysInfo1.ScrollBarSize
		Else
			BarSize = 0
		End If
		
		With grdTensions
			.Rows = Max(9, NumLines + 1)
			.WordWrap = True
			
			ColW = (VB6.PixelsToTwipsX(.Width) - BarSize) / .Cols - .GridLineWidth
			RowH = VB6.PixelsToTwipsY(.Height) / 11 - .GridLineWidth
			If BarSize > 0 Then
				.set_ColWidth(0, VB6.PixelsToTwipsX(.Width) - BarSize - ColW * (.Cols - 1) - 110)
			Else
				.set_ColWidth(0, VB6.PixelsToTwipsX(.Width) - ColW * (.Cols - 1) - 80)
			End If
			.set_RowHeight(0, VB6.PixelsToTwipsY(.Height) - RowH * 8 - 90)
			
			For c = 1 To .Cols - 1
				.set_ColWidth(c, ColW)
			Next c
			For r = .FixedRows To .Rows - 1
				.set_RowHeight(r, RowH)
			Next r
			
			.Col = 0
			For r = .FixedRows To .Rows - 1
				.Row = r
				.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
				.Text = "Line " & (r - .FixedRows + 1)
			Next r
			.Row = 0
			For c = 0 To .Cols - 1
				.Row = 0
				.Col = c
				.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
				.Text = TenLabels(c)
				For r = 1 To .Rows - 1
					.Row = r
					.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
					If c = 7 Then .CellForeColor = System.Drawing.Color.Red
				Next r
			Next c
			
			.Col = 0
			.Row = 0
		End With
		
		CheckingGrid = False
		
	End Sub
	
	Private Sub SetLabels()
		
		Dim LUnit, FrcUnit As String
		
		If IsMetricUnit Then
			LUnit = "(m)"
			FrcUnit = "(KN)"
		Else
			LUnit = "(ft)"
			FrcUnit = "(kips)"
		End If
		
		MoveLabels(0) = "Direction"
		MoveLabels(1) = "Mean"
		MoveLabels(2) = "Sig LFM"
		MoveLabels(3) = "Sig WFM"
		MoveLabels(4) = "Max Dyn"
		MoveLabels(5) = "Maximum"
		MoveLabels(6) = "Minimum"
		
		
		DirLabels(0) = "Surge " & LUnit
		DirLabels(1) = "Sway " & LUnit
		DirLabels(2) = "Yaw (deg)"
		
		TenLabels(0) = "Line No."
		TenLabels(1) = "Connected"
		TenLabels(2) = "Mean Tension " & FrcUnit
		TenLabels(3) = "Sig LF Tension " & FrcUnit
		TenLabels(4) = "Sig WF Tension " & FrcUnit
		TenLabels(5) = "Max Tension " & FrcUnit
		TenLabels(6) = "Min Tension " & FrcUnit
		TenLabels(7) = "Min FOS"
		
	End Sub
	
	' operation subroutines
	' load to and update from form
	
	Private Sub LoadData()
		Dim LFactor, FrcFactor As Double
		
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
		Else
			LFactor = 1
			FrcFactor = 1
		End If
		
		Dim r, i As Short
		Dim NumWells As Short
		Dim Bearing, Distance, Depth As Double
		
		With CurVessel
			txtWaterDepth.Text = VB6.Format(.WaterDepth * LFactor, "0.0")
			With .ShipCurGlob
				txtVslSt(0).Text = VB6.Format(.Xg * LFactor, "0.00")
				txtVslSt(1).Text = VB6.Format(.Yg * LFactor, "0.00")
				txtVslSt(2).Text = VB6.Format(.Heading * Radians2Degrees, "0.00")
				ShipLoc.Xg = .Xg
				ShipLoc.Yg = .Yg
				ShipLoc.Heading = .Heading
			End With
			txtVslSt(3).Text = VB6.Format(.ShipDraft * LFactor, "0.00")
			
			If CurVessel.DampingPercent.Surge > 0 Then
				txtPercentDamping(0).Text = VB6.Format(CurVessel.DampingPercent.Surge, "0")
				txtPercentDamping(1).Text = VB6.Format(CurVessel.DampingPercent.Sway, "0")
				txtPercentDamping(2).Text = VB6.Format(CurVessel.DampingPercent.Yaw, "0")
			Else
				txtPercentDamping(0).Text = ""
				txtPercentDamping(1).Text = ""
				txtPercentDamping(2).Text = ""
			End If
		End With
		
		With CurField
			Depth = .Item(.CurWellNo).Depth
		End With
		If Depth <= 0# Then Depth = CurVessel.WaterDepth
		
		Coord2Bear(ShipLoc, Distance, Bearing)
		
		txtMotion(2).Text = VB6.Format(Distance * LFactor, "0.0")
		txtMotion(3).Text = VB6.Format(Distance / Depth * 100, "0.00")
		txtMotion(4).Text = txtVslSt(0).Text
		txtMotion(5).Text = txtVslSt(1).Text
		txtMotion(6).Text = txtVslSt(2).Text
		
		With grdTensions
			For r = 1 To NumLines
				.Row = r
				.Col = 1
				PreConnect(r) = CurVessel.MoorSystem.MoorLines(r).Connected
				If PreConnect(r) Then
					.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
					.Text = "Yes"
				Else
					.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
					.Text = "No"
				End If
			Next r
		End With
		
		With CurField
			txtCurWell.Text = .Item(.CurWellNo).NameID
		End With
		
		txtEnvironment.Text = CurVessel.EnvLoad.EnvCur.Name
		'  RefreshButtonStatus
	End Sub
	
	'Sub RefreshButtonStatus()
	'    Dim i As Integer
	'    If InStr(txtEnvironment.Text, "No Environment") > 0 Then
	'        With txtPercentDamping
	'            For i = 0 To .Count - 1
	'                .Item(i).Enabled = True
	'                .Item(i).BackColor = vbWindowBackground
	'            Next
	'        End With
	'    Else
	'        With txtPercentDamping
	'            For i = 0 To .Count - 1
	'                .Item(i).Enabled = False
	'                .Item(i).BackColor = vbButtonFace
	'            Next
	'        End With
	'    End If
	'End Sub
	
	Private Sub SaveLC()
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
		Else
			LFactor = 1
			FrcFactor = 1
		End If
		
		Dim r As Short
		Dim Distance, Bearing As Double
		
		With grdTensions
			For r = 1 To NumLines
				.Row = r
				.Col = 1
				If .Text = "Yes" Then
					CurVessel.MoorSystem.MoorLines(r).Connected = True
				Else
					CurVessel.MoorSystem.MoorLines(r).Connected = False
				End If
			Next r
		End With
		
		
		With ShipLoc
			.Xg = CDbl(CheckData(txtVslSt(0).Text,  , True)) / LFactor
			.Yg = CDbl(CheckData(txtVslSt(1).Text,  , True)) / LFactor
			.Heading = CDbl(CheckData(txtVslSt(2).Text,  , True)) * Degrees2Radians
		End With
		
		With CurVessel.DampingPercent
			.Surge = Val(txtPercentDamping(0).Text)
			.Sway = Val(txtPercentDamping(1).Text)
			.Yaw = Val(txtPercentDamping(2).Text)
		End With
		
	End Sub
	
	Private Sub UpdateData()
		Dim minFS, Bearing, t As Double
		Dim j As Short
		
		txtPercentDamping(0).Text = VB6.Format(CurVessel.DampingPercent.Surge, "0")
		txtPercentDamping(1).Text = VB6.Format(CurVessel.DampingPercent.Sway, "0")
		txtPercentDamping(2).Text = VB6.Format(CurVessel.DampingPercent.Yaw, "0")
		
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
		Else
			LFactor = 1
			FrcFactor = 1
		End If
		
		Dim r, c As Short
		Dim ToCurWell, ToCurLoc, Depth As Double
		
		With CurField
			Depth = .Item(.CurWellNo).Depth
		End With
		If Depth <= 0# Then Depth = CurVessel.WaterDepth
		
		Call MaxDynMotion(MaxDM)
		MaxDynamicMotion = MaxDM.Move
		Call MaxOffset(ToCurLoc, ToCurWell, Bearing)
		
		txtMotion(0).Text = VB6.Format(ToCurLoc * LFactor, "0.0")
		txtMotion(1).Text = VB6.Format(ToCurLoc / Depth * 100#, "0.00")
		txtMotion(2).Text = VB6.Format(ToCurWell * LFactor, "0.0")
		txtMotion(3).Text = VB6.Format(ToCurWell / Depth * 100#, "0.00")
		txtBearing.Text = VB6.Format(Bearing * Radians2Degrees, "0.0")
		
		With ShipLoc
			txtMotion(4).Text = VB6.Format(.Xg * LFactor, "0.0")
			txtMotion(5).Text = VB6.Format(.Yg * LFactor, "0.0")
			txtMotion(6).Text = VB6.Format(.Heading * Radians2Degrees, "0.00")
		End With
		
		With grdVM
			.Col = 1
			.Row = 1
			.Text = VB6.Format(Movement.Surge * LFactor, "0.00")
			.Row = 2
			.Text = VB6.Format(Movement.Sway * LFactor, "0.00")
			.Row = 3
			.Text = VB6.Format(Movement.Yaw * Radians2Degrees, "0.00")
			
			.Col = 2
			.Row = 1
			.Text = VB6.Format(LFM.Surge * LFactor, "0.00")
			.Row = 2
			.Text = VB6.Format(LFM.Sway * LFactor, "0.00")
			.Row = 3
			.Text = VB6.Format(LFM.Yaw * Radians2Degrees, "0.00")
			
			.Col = 3
			.Row = 1
			.Text = VB6.Format(WFM.Surge * LFactor, "0.00")
			.Row = 2
			.Text = VB6.Format(WFM.Sway * LFactor, "0.00")
			.Row = 3
			.Text = VB6.Format(WFM.Yaw * Radians2Degrees, "0.00")
			
			.Col = 4
			.Row = 1
			.Text = VB6.Format(MaxDM.Surge * LFactor, "0.00")
			.Row = 2
			.Text = VB6.Format(MaxDM.Sway * LFactor, "0.00")
			.Row = 3
			.Text = VB6.Format(MaxDM.Yaw * Radians2Degrees, "0.00")
			
			.Col = 5
			.Row = 1
			.Text = VB6.Format((Movement.Surge + MaxDM.Surge) * LFactor, "0.00")
			.Row = 2
			.Text = VB6.Format((Movement.Sway + MaxDM.Sway) * LFactor, "0.00")
			.Row = 3
			.Text = VB6.Format((Movement.Yaw + MaxDM.Yaw) * Radians2Degrees, "0.00")
			
			.Col = 6
			.Row = 1
			.Text = VB6.Format((Movement.Surge - MaxDM.Surge) * LFactor, "0.00")
			.Row = 2
			.Text = VB6.Format((Movement.Sway - MaxDM.Sway) * LFactor, "0.00")
			.Row = 3
			.Text = VB6.Format((Movement.Yaw - MaxDM.Yaw) * Radians2Degrees, "0.00")
		End With
		
		Dim FrcHor As Double
		
		With grdTensions
			For r = 1 To NumLines
				.Row = r
				.Col = 2
				.Text = VB6.Format(Tension(r) * 0.001 * FrcFactor, "0.0")
				.Col = 3
				.Text = VB6.Format(TSigLF(r) * 0.001 * FrcFactor, "0.0")
				.Col = 4
				.Text = VB6.Format(TSigWF(r) * 0.001 * FrcFactor, "0.0")
				.Col = 5
				.Text = VB6.Format((Tension(r) + MaxDynTen(r)) * 0.001 * FrcFactor, "0.0")
				.Col = 6
				.Text = VB6.Format((Tension(r) - MaxDynTen(r)) * 0.001 * FrcFactor, "0.0")
				.Col = 7
				If Tension(r) + MaxDynTen(r) > 0 Then ' connected and converged
					' jguan 4/22/2004           '  update catenary using top tension
					If CurVessel.MoorSystem.MoorLines(r).ScopeByTopTensionPOL(Tension(r) + MaxDynTen(r), FrcHor, (CurVessel.MoorSystem.MoorLines(r).Payout)) > 0 Then
						minFS = CurVessel.MoorSystem.MoorLines(r).FOS
						'                    ' found converged catenary solution
					Else
						minFS = CurVessel.MoorSystem.MoorLines(r).Segments(1).BS / (Tension(r) + MaxDynTen(r))
					End If
					'   Debug.Print "FS=" & CurVessel.MoorSystem.MoorLines(r).Segments(1).BS / (Tension(r) + MaxDynTen(r)) & ", minFS = " & CurVessel.MoorSystem.MoorLines(r).FOS
					.Text = VB6.Format(minFS, "0.00")
				Else
					.Text = "Damaged"
				End If
			Next r
		End With
		
	End Sub
	
	' operation subroutines
	' analyses
	
	Private Sub StaticAnalysis()
		
		Dim i As Short
		Dim FWv, FEv As Force
		
		If Cancelled Then Exit Sub
		With frmProgress
			.CurrentStage.Text = "Finding equilibrium position..."
			.Progress = 5
		End With
		
		ShipLoc = CurVessel.FindEquilibriumPosition(Cancelled, frmProgress)
		With CurVessel.EnvLoad
			.ShipHead = ShipLoc.Heading
			FEv = .FEnvLocl
			FWv = .FWaveLocl( , False)
			.ShipHead = CurVessel.ShipCurGlob.Heading
		End With
		With FWv
			SgnX = System.Math.Sign(.Fx)
			SgnY = System.Math.Sign(.Fy)
			
			'       SgnZ = Sgn(.MYaw)
			
			'       ShipYaw = CurVessel.ShipCurGlob.Heading - ShipLoc.Heading
			'       If ShipYaw > PI Then ShipYaw = ShipYaw - 2 * PI
			'       If ShipYaw < -PI Then ShipYaw = ShipYaw + 2 * PI
			'       SgnZ = Sgn(ShipYaw)
			
			SgnZ = 0#
			
			If SgnX = 0# Then SgnX = 1#
			If SgnY = 0# Then SgnY = 1#
			'       If SgnZ = 0# Then SgnZ = 1#
		End With
		
		If Cancelled Then Exit Sub
		With frmProgress
			.CurrentStage.Text = "Calculating low frequency motion..."
			.Progress = 45
		End With
		
		Call CurVessel.MoorSystem.MoorStiff(Stiff, ShipLoc, False)
		
		Movement = CurVessel.ShipMotion((CurVessel.ShipCurGlob), ShipLoc)
		LFM = CurVessel.GetSigLFM(Stiff, Cancelled, frmProgress, ShipLoc)
		
		If Cancelled Then Exit Sub
		With frmProgress
			.CurrentStage.Text = "Calculating wave frequency motion..."
			.Progress = 75
		End With
		
		WFM = CurVessel.GetSigWFM(Cancelled, frmProgress, ShipLoc.Heading)
		With LFM
			LFMd.Surge = .Surge * SgnX
			LFMd.Sway = .Sway * SgnY
			LFMd.Yaw = .Yaw * SgnZ
		End With
		With WFM
			WFMd.Surge = .Surge * SgnX
			WFMd.Sway = .Sway * SgnY
			WFMd.Yaw = .Yaw * SgnZ
		End With
		
		If Cancelled Then Exit Sub
		With frmProgress
			.CurrentStage.Text = "Calculating low frequency tensions..."
			.Progress = 90
		End With
		
		Call CurVessel.FindSigDynMLTen(Tension, TSigLF, ShipLoc, LFMd)
		
		If Cancelled Then Exit Sub
		With frmProgress
			.CurrentStage.Text = "Calculating wave frequency tensions..."
			.Progress = 95
		End With
		
		Call CurVessel.FindSigDynMLTen(Tension, TSigWF, ShipLoc, WFMd)
		
		'UPGRADE_NOTE: Object FEv may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		FEv = Nothing
		'UPGRADE_NOTE: Object FWv may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		FWv = Nothing
		
	End Sub
	
	Private Sub MaxDynMotion(ByRef MaxDM As Motion)
		
		Dim Dyn1, Dyn2 As Double
		
		Dyn1 = LFM.Move * 1.5 + WFM.Move
		Dyn2 = WFM.Move * 1.86 + LFM.Move
		
		With MaxDM
			If Dyn1 >= Dyn2 Then
				.Surge = LFM.Surge * 1.5 + WFM.Surge
				.Sway = LFM.Sway * 1.5 + WFM.Sway
				.Yaw = LFM.Yaw * 1.5 + WFM.Yaw
			Else
				.Surge = WFM.Surge * 1.86 + LFM.Surge
				.Sway = WFM.Sway * 1.86 + LFM.Sway
				.Yaw = WFM.Yaw * 1.86 + LFM.Yaw
			End If
		End With
		
	End Sub
	
	Private Function MaxDynTen(ByVal Line As Short) As Double
		
		Dim Dyn1, Dyn2 As Double
		
		Dyn1 = TSigLF(Line) * 1.5 + TSigWF(Line)
		Dyn2 = TSigWF(Line) * 1.86 + TSigLF(Line)
		
		MaxDynTen = Max(Dyn1, Dyn2)
		
	End Function
	
	Private Sub MaxOffset(ByRef ToCurLoc As Double, ByRef ToCurWell As Double, ByRef Bearing As Double)
		
		Dim MaxDMd As New Motion
		Dim Off1L, Off2L As Double
		Dim Off1W, Off2W As Double
		Dim CurWell As Well
		
		With CurField
			CurWell = .Item(.CurWellNo)
		End With
		
		With MaxDM
			MaxDMd.Surge = .Surge * SgnX + Movement.Surge
			MaxDMd.Sway = .Sway * SgnY + Movement.Sway
			MaxDMd.Yaw = .Yaw * SgnZ + Movement.Yaw
		End With
		
		Off1L = MaxDMd.Move
		
		With CurVessel
			Coord2Bear(.NewShipLoc(.ShipCurGlob, MaxDMd), Off1W, Bearing)
		End With
		
		With MaxDM
			MaxDMd.Surge = -.Surge * SgnX + Movement.Surge
			MaxDMd.Sway = -.Sway * SgnY + Movement.Sway
			MaxDMd.Yaw = -.Yaw * SgnZ + Movement.Yaw
		End With
		
		Off2L = MaxDMd.Move
		
		With CurVessel
			Coord2Bear(.NewShipLoc(.ShipCurGlob, MaxDMd), Off2W, Bearing)
		End With
		
		ToCurLoc = Max(Off1L, Off2L)
		ToCurWell = Max(Off1W, Off2W)
		
		'UPGRADE_NOTE: Object MaxDMd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		MaxDMd = Nothing
		
	End Sub
	
	Private Sub Coord2Bear(ByRef ShipGlob As ShipGlobal, ByRef Distance As Double, ByRef Bearing As Double)
		
		Dim dx, dy As Double
		
		With CurField
			dx = ShipGlob.Xg - .Item(.CurWellNo).Xg
			dy = ShipGlob.Yg - .Item(.CurWellNo).Yg
		End With
		
		Distance = System.Math.Sqrt(dx ^ 2 + dy ^ 2)
		Bearing = Atan(dy, dx)
		
	End Sub
	
	Private Function DerpData() As Boolean
		
		'UPGRADE_NOTE: FileOpen was upgraded to FileOpen_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim r As Short
		Dim FileOpen_Renamed As Boolean
		Dim CurLine As MoorLine
		
		DerpData = False
		
		On Error GoTo ErrorHandler
		
		FileOpen_Renamed = False
		FileOpen(FileNumRes, DerpDir & DerpFile, OpenMode.Output)
		FileOpen_Renamed = True
		
		PrintLine(FileNumRes, txtMotion(3).Text & 0#)
		
		FileClose(FileNumRes)
		FileOpen_Renamed = False
		DerpData = True
		
		Exit Function
		
ErrorHandler: 
		If FileOpen_Renamed Then FileClose(FileNumRes)
		Exit Function
		
	End Function
	
	Public Sub ChangeUnit()
		
	End Sub
End Class