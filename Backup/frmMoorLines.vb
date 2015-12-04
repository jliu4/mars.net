Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMoorLines
	Inherits System.Windows.Forms.Form
	
	Private Const InFile As Short = 1
	Private Const OutFile As Short = 2
	
	Private Const DraftStr1 As String = "Current Draft"
	Private Const DraftStr2 As String = "Survival Draft"
	Private Const DraftStr3 As String = "Operating Draft"
	
	Private ExistingTxt As String
	Private Changed As Boolean
	Private CheckingGrid As Boolean
	Private JEC As Boolean
	
	Private SegLabels(13, 1) As String
	Private CurLine As Short
	Private NumLines As Short
	Private ShipDesLoc As ShipGlobal
	Private MoorLines As MoorSystem
	
	Private CurDraft As Double
	Private SurDraft As Double
	Private OprDraft As Double
	
	Private Updated As Boolean
	Private TenCalc As Boolean
	Private LocChanged As Boolean
	
	Public ChangeInCat As Boolean
	
	Private LUnit, FrcUnit As String
	Dim FrcFactor, LFactor, StressFactor As Double
	Dim DiameterFactor As Object
	
	Private Sub RefreshData()
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
			StressFactor = 6.894757 ' ksi -> MPa
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 2.54 ' in -> cm
			LUnit = "m"
			FrcUnit = "KN"
		Else
			LFactor = 1
			FrcFactor = 1
			StressFactor = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 1
			LUnit = "ft"
			FrcUnit = "kips"
		End If
		IniSegments()
		RefreshUnitLabels(Me)
		LoadMoorData(True)
	End Sub
	
	
	'UPGRADE_WARNING: Event cboSegType.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	'UPGRADE_WARNING: ComboBox event cboSegType.Change was upgraded to cboSegType.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
	Private Sub cboSegType_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboSegType.TextChanged
		grdSegments_LeaveCell(grdSegments, New System.EventArgs())
	End Sub
	
	' form load and unload
	
	Private Sub frmMoorLines_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Dim i As Short
		
		Text = Text & " - " & CurProj.Title
		CheckingGrid = False
		ChangeInCat = False
		
		LoadMoorLines()
		
		If CurLine = 0 Or CurLine > NumLines Then CurLine = 1
		
		Updated = True
		InitiateTabs()
		
		RefreshData()
		
	End Sub
	
	Private Sub frmMoorLines_GotFocus(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.GotFocus
		
		If ChangeInCat Then btnTopTension_Click(btnTopTension, New System.EventArgs())
		ChangeInCat = False
		
	End Sub
	
	Private Sub frmMoorLines_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object MoorLines may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		MoorLines = Nothing
		
	End Sub
	
	' command buttons
	' form level
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		
		Me.Close()
		
	End Sub
	
	Private Sub btnSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSave.Click
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
			StressFactor = 6.894757 ' ksi -> MPa
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 2.54 ' in -> cm
			LUnit = "m"
			FrcUnit = "KN"
		Else
			LFactor = 1
			FrcFactor = 1
			StressFactor = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 1
			LUnit = "ft"
			FrcUnit = "kips"
		End If
		
		With ShipDesLoc
			.Xg = CDbl(txtVslSt(0).Text) / LFactor
			.Yg = CDbl(txtVslSt(1).Text) / LFactor
			.Heading = CDbl(txtVslSt(2).Text) * Degrees2Radians
		End With
		
		With CurVessel.ShipDesGlob
			.Xg = ShipDesLoc.Xg
			.Yg = ShipDesLoc.Yg
			.Heading = ShipDesLoc.Heading
		End With
		
		If btnAnchor.Enabled Then btnAnchor_Click(btnAnchor, New System.EventArgs())
		If btnScope.Enabled Then btnScope_Click(btnScope, New System.EventArgs())
		
		If Not Updated Then UpdateMoorData()
		Dim i As Short
		fraSegments.Visible = False
		For i = MoorLines.MoorLineCount To 1 Step -1
			Updated = False
			tabMoorLines.Tabs(i).Selected = True
		Next i
		Updated = True
		tabMoorLines.Tabs(CurLine).Selected = True
		fraSegments.Visible = True
		
		SaveMoorLines()

        '    ' save desShipLoc as curShipLoc
        '    CurVessel.ShipCurGlob.Xg = CurVessel.ShipDesGlob.Xg 
        '    CurVessel.ShipCurGlob.Yg = CurVessel.ShipDesGlob.Yg
        '    CurVessel.ShipCurGlob.Heading = CurVessel.ShipDesGlob.Heading
        '    CurVessel.ShipDraft = txtVslSt(3).Text / LFactor

        CurProj.Saved = False
		Me.Close()
		
	End Sub
	
	Private Sub grdAnchor_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdAnchor.DblClick
		
		If grdAnchor.Row = 0 Then
			Select Case grdAnchor.Col
				Case 2, 4, 5, 7
					MSFlexGridEdit(grdAnchor, txtAnchEdit, System.Windows.Forms.Keys.F2)
			End Select
		End If
		
	End Sub
	
	Private Sub grdAnchor_EnterCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdAnchor.EnterCell
		
		If grdAnchor.Row = 0 Then
			Select Case grdAnchor.Col
				Case 2, 4, 5, 7
					ExistingTxt = Trim(grdAnchor.Text)
					JEC = True
			End Select
		End If
		
	End Sub
	
	Private Sub grdAnchor_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_KeyDownEvent) Handles grdAnchor.KeyDownEvent
		
		If grdAnchor.Row = 0 Then
			Select Case grdAnchor.Col
				Case 2, 4, 5, 7
					KeyHandler(grdAnchor, txtAnchEdit, eventArgs.KeyCode, eventArgs.Shift, JEC, ExistingTxt)
			End Select
		End If
		
	End Sub
	
	Private Sub grdAnchor_LeaveCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdAnchor.LeaveCell
		
		Dim Changed As Boolean
		
		If txtAnchEdit.Visible = True Then
			grdAnchor.Text = txtAnchEdit.Text
			txtAnchEdit.Visible = False
		End If
		
		Changed = False
		If Not CheckingGrid Then
			If grdAnchor.Row = 0 Then
				Select Case grdAnchor.Col
					Case 2, 5
						If Trim(grdAnchor.Text) <> ExistingTxt Then Changed = True
					Case 4, 7
						If Trim(grdAnchor.Text) <> ExistingTxt Then
							grdAnchor.Text = CheckData(grdAnchor.Text)
							Changed = True
						End If
				End Select
			End If
		End If
		
		If Changed Then Updated = False
		
	End Sub
	
	Private Sub grdAnchor_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdAnchor.Leave
		
		Dim Changed As Boolean
		
		Changed = False
		If Not CheckingGrid Then
			If grdAnchor.Row = 0 Then
				Select Case grdAnchor.Col
					Case 2, 5
						If Trim(grdAnchor.Text) <> ExistingTxt Then Changed = True
					Case 4, 7
						If Trim(grdAnchor.Text) <> ExistingTxt Then
							grdAnchor.Text = CheckData(grdAnchor.Text)
							Changed = True
						End If
				End Select
			End If
		End If
		
		If Changed Then Updated = False
		
	End Sub
	
	Private Sub SetSegTypeCbo(ByRef SegType As String)
		
		Dim i As Short
		
		For i = 1 To cboSegType.Items.Count
			If SegType = VB6.GetItemString(cboSegType, i - 1) Then Exit For
		Next 
		If i > cboSegType.Items.Count Then i = 1
		cboSegType.SelectedIndex = i - 1
		
	End Sub
	
	Private Sub grdSegments_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdSegments.ClickEvent
		If grdSegments.Col = 1 Then
			If cboSegType.Visible = False Then
				ExistingTxt = grdSegments.Text
				SetSegTypeCbo((grdSegments.Text))
				MSFlexGridCombo(grdSegments, cboSegType, True)
			End If
		End If
	End Sub
	
	Private Sub grdSegments_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdSegments.Scroll
		cboSegType.Visible = False
		txtSegEdit.Visible = False
	End Sub
	
	' menus
	
	Public Sub mnuClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuClose.Click
		
		btnCancel_Click(btnCancel, New System.EventArgs())
		
	End Sub
	
	Public Sub mnuOpen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOpen.Click
		
		'UPGRADE_NOTE: FileOpen was upgraded to FileOpen_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim ReadFile, FileOpen_Renamed As Boolean
		Dim msg As String
		
		FileOpen_Renamed = False
		
		'   should the user cancel the dialog box, exit
		On Error GoTo Errhandler
		
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		dlgFileOpen.Filter = "All Files (*.*)|*.*|Mln Files (*.mln)|*.mln"
		dlgFileSave.Filter = "All Files (*.*)|*.*|Mln Files (*.mln)|*.mln"
		dlgFileOpen.FilterIndex = 2
		dlgFileSave.FilterIndex = 2
		dlgFileOpen.InitialDirectory = CurProj.Directory
		dlgFileSave.InitialDirectory = CurProj.Directory
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFileOpen.CheckFileExists = True
		dlgFileOpen.CheckPathExists = True
		dlgFileSave.CheckPathExists = True
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFileOpen.ShowReadOnly = False
		dlgFileOpen.ShowDialog()
		dlgFileSave.FileName = dlgFileOpen.FileName
		
		'   open the file
		FileOpen(InFile, dlgFileOpen.FileName, OpenMode.Input, OpenAccess.Read)
		FileOpen_Renamed = True
		
		On Error GoTo 0
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		ReadFile = MoorLines.InputML(InFile)
		'   close the input file and return
		FileClose(InFile)
		FileOpen_Renamed = False
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		
		If Not ReadFile Then
			msg = dlgFileOpen.FileName & " appears to be corrupted. " & "The original mooring system has been reloaded."
			MsgBox(msg, MsgBoxStyle.OKOnly, Me.Text)
			LoadMoorLines()
		End If
		LoadMoorData()
		
		Exit Sub
		
Errhandler: 
		'   User pressed Cancel button, or some tragedy occurred
		If FileOpen_Renamed Then FileClose(InFile)
		Exit Sub
		
	End Sub
	
	Public Sub mnuSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSave.Click
		
		'UPGRADE_NOTE: FileOpen was upgraded to FileOpen_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim WriteFile, FileOpen_Renamed As Boolean
		
		FileOpen_Renamed = False
		
		On Error GoTo Errhandler
		
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		dlgFileOpen.Filter = "All Files (*.*)|*.*|Mln Files (*.mln)|*.mln"
		dlgFileSave.Filter = "All Files (*.*)|*.*|Mln Files (*.mln)|*.mln"
		dlgFileOpen.FilterIndex = 2
		dlgFileSave.FilterIndex = 2
		dlgFileOpen.FileName = "*.mln"
		dlgFileSave.FileName = "*.mln"
		dlgFileOpen.InitialDirectory = CurProj.Directory
		dlgFileSave.InitialDirectory = CurProj.Directory
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileSave.OverwritePrompt which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFileSave.OverwritePrompt = True
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFileOpen.ShowReadOnly = False
		dlgFileSave.ShowDialog()
		dlgFileOpen.FileName = dlgFileSave.FileName
		
		'   open the file for output
		FileOpen(OutFile, dlgFileOpen.FileName, OpenMode.Output)
		FileOpen_Renamed = True
		
		On Error GoTo 0
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		
		WriteFile = MoorLines.OutputML(OutFile)
		'   Close the output file
		FileClose(OutFile)
		FileOpen_Renamed = False
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		Exit Sub
		
Errhandler: 
		'   User pressed Cancel button, or some tragedy occurred
		If FileOpen_Renamed Then FileClose(OutFile)
		MsgBox("Error saving: " & Err.Description, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Error")
	End Sub
	
	Private Sub tabMoorLines_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabMoorLines.ClickEvent
		
		Dim SelLine As Short
		
		If Not Updated Then UpdateMoorData()
		
		SelLine = tabMoorLines.SelectedItem.Index
		If SelLine <> CurLine Then
			CurLine = SelLine
			LoadMoorData()
		End If
		
	End Sub
	
	' command buttons
	' tab level
	
	Private Sub btnAnchor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnAnchor.Click
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
			StressFactor = 6.894757 ' ksi -> MPa
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 2.54 ' in -> cm
			LUnit = "m"
			FrcUnit = "KN"
		Else
			LFactor = 1
			FrcFactor = 1
			StressFactor = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 1
			LUnit = "ft"
			FrcUnit = "kips"
		End If
		
		Dim SprdAngle, Scope, Alpha As Double
		Dim FLXs, FLYs As Double
		Dim AnchXg, AnchXs, AnchYs, AnchYg As Double
		
		Dim FL As New FairLead
		
		If LocChanged Then
			With ShipDesLoc
				.Xg = CDbl(txtVslSt(0).Text) / LFactor
				.Yg = CDbl(txtVslSt(1).Text) / LFactor
				.Heading = CDbl(txtVslSt(2).Text) * Degrees2Radians
			End With
		End If
		
		SprdAngle = CDbl(-txtGeneral(0).Text) * Degrees2Radians
		Scope = CDbl(txtGeneral(1).Text) / LFactor
		
		FLXs = CDbl(txtFL(0).Text) / LFactor
		FLYs = CDbl(txtFL(1).Text) / LFactor
		
		FL.Xs = FLXs
		FL.Ys = FLYs
		
		AnchXs = Scope * System.Math.Cos(SprdAngle) + FLXs
		AnchYs = Scope * System.Math.Sin(SprdAngle) + FLYs
		
		Alpha = PI / 2# - ShipDesLoc.Heading
		AnchXg = System.Math.Cos(Alpha) * AnchXs - System.Math.Sin(Alpha) * AnchYs + ShipDesLoc.Xg
		AnchYg = System.Math.Sin(Alpha) * AnchXs + System.Math.Cos(Alpha) * AnchYs + ShipDesLoc.Yg
		
		txtAnchor(0).Text = VB6.Format(AnchXg * LFactor, "0.00")
		txtAnchor(1).Text = VB6.Format(AnchYg * LFactor, "0.00")
		
		btnAnchor.Enabled = False
		btnScope.Enabled = False
		
	End Sub
	
	Private Sub btnCatenary_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCatenary.Click
		
		Dim i, NumSeg As Short
		
		Dim Length, LenStr As Double
		
		Dim SegLength(MaxNumSeg) As Double
		Dim SegTension(MaxNumSeg) As Double
		Dim SegAngle(MaxNumSeg) As Double
		Dim SegPosition(MaxNumSeg) As Double
		Dim CatX(MaxNumSubSeg * MaxNumSeg + 1) As Double
		Dim CatY(MaxNumSubSeg * MaxNumSeg + 1) As Double
		Dim Connector(MaxNumSeg + 1) As Short
		
		If Not TenCalc Then btnTopTension_Click(btnTopTension, New System.EventArgs())
		
		With MoorLines.MoorLines(CurLine)
			NumSeg = .SegmentCount
			If NumSeg > MaxNumSeg Then NumSeg = MaxNumSeg
			For i = 1 To NumSeg Step 1
				With .Segments(i)
					SegLength(i) = .Length
					SegTension(i) = .TenUpp
					SegAngle(i) = .AngUpp
					If i < NumSeg Then SegPosition(i + 1) = .YLow
				End With
			Next i
			SegLength(1) = .Payout
			SegPosition(1) = .Draft - .FairLead.z
			
			Length = .LineLen
			LenStr = .LineLenStr
			
			If Not .CatenaryPoints(CatX, CatY, Connector) Then Exit Sub
			
			frmCatenary.UpdateForm(NumLines, CurLine, NumSeg, .DesScope, Length, LenStr - .GrdLen, .GrdLen, LenStr - Length, .Payout, .TopTension, .AnchPull, .FLAngle, .BtmAngle, SegPosition(1), SegLength, SegTension, SegAngle, SegPosition, CatX, CatY, Connector)
		End With
		
		Call VB6.ShowForm(frmCatenary, 1, Me)
		
	End Sub
	
	Private Sub btnNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnNew.Click
		
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
		
		MoorLines.MoorLineAdd()
		NumLines = NumLines + 1
		InitiateTabs()
		
		MoorLine_Renamed = MoorLines.MoorLines(CurLine)
		
		With MoorLines.MoorLines(NumLines)
			.BottomSlope = MoorLine_Renamed.BottomSlope
			.Connected = MoorLine_Renamed.Connected
			.DesScope = MoorLine_Renamed.DesScope
			
			.Payout = MoorLine_Renamed.Payout
			.PayoutSur = MoorLine_Renamed.PayoutSur
			.PayoutOpr = MoorLine_Renamed.PayoutOpr
			.PretensionSur = MoorLine_Renamed.PretensionSur
			.PretensionOpr = MoorLine_Renamed.PretensionOpr
			
			.FairLead.Xs = MoorLine_Renamed.FairLead.Xs
			.FairLead.Ys = MoorLine_Renamed.FairLead.Ys
			.FairLead.z = MoorLine_Renamed.FairLead.z
			
			.Anchor.Xg = MoorLine_Renamed.Anchor.Xg
			.Anchor.Yg = MoorLine_Renamed.Anchor.Yg
			.WaterDepth = MoorLine_Renamed.WaterDepth
			
			.Anchor.HoldCap = MoorLine_Renamed.Anchor.HoldCap
			.Anchor.Model = MoorLine_Renamed.Anchor.Model
			.Anchor.Remark = MoorLine_Renamed.Anchor.Remark
			.WinchCap = MoorLine_Renamed.WinchCap
			
			.SegmentClear()
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
			Call MoorLines.MoorLines(NumLines).SegmentAdd(SegTp, Lg, TLg, dia, BS, E1, E2, DryWt, WetWt, Buoy, BuoyL, FrCoef)
		Next Segment_Renamed
	End Sub
	
	Private Sub btnPayout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPayout.Click
		
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
			StressFactor = 6.894757 ' ksi -> MPa
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 2.54 ' in -> cm
			LUnit = "m"
			FrcUnit = "KN"
		Else
			LFactor = 1
			FrcFactor = 1
			StressFactor = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 1
			LUnit = "ft"
			FrcUnit = "kips"
		End If
		
		Dim TopTension As Double
		Dim Scope, POL As Double
		'
		'    If btnAnchor.Enabled Then btnAnchor_Click
		'    If btnScope.Enabled Then btnScope_Click
		'
		If Not Updated Then
			If Not UpdateMoorData Then Exit Sub
		End If
		''
		'    With MoorLines.MoorLines(CurLine)
		Scope = CDbl(txtGeneral(1).Text) / LFactor
		TopTension = CDbl(txtTopTen.Text) * 1000# / FrcFactor
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		'      POL = MoorLines.MoorLines(CurLine).POLByScopeTension(Scope, TopTension)
		POL = MoorLines.MoorLines(CurLine).PayoutByScopeTopTension(Scope, TopTension)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		If POL <= 0# Then
			MsgBox("Program may not find wire payout for the given top tension and scope!", MsgBoxStyle.OKOnly, "MARS - Warning")
			If POL = -1# Then
				txtGeneral(2).Text = "0.000"
			Else
				txtGeneral(2).Text = VB6.Format(-POL * LFactor, "0.000")
			End If
			TenCalc = False
		Else
			txtGeneral(2).Text = VB6.Format(POL * LFactor, "0.000")
			TenCalc = True
		End If
		'    End With
		
		btnPayout.Enabled = False
		
	End Sub
	
	Private Sub btnPreten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPreten.Click
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
			StressFactor = 6.894757 ' ksi -> MPa
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 2.54 ' in -> cm
			LUnit = "m"
			FrcUnit = "KN"
		Else
			LFactor = 1
			FrcFactor = 1
			StressFactor = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 1
			LUnit = "ft"
			FrcUnit = "kips"
		End If
		
		'UPGRADE_NOTE: MoorLine was upgraded to MoorLine_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim MoorLine_Renamed As MoorLine
		Dim i As Short
		
		If Not TenCalc Then btnTopTension_Click(btnTopTension, New System.EventArgs())
		
		With MoorLines.MoorLines(CurLine)
			Select Case cboDraft.SelectedIndex
				Case 1
					.PretensionSur = CDbl(txtTopTen.Text) * 1000# / FrcFactor
					.PayoutSur = CDbl(txtGeneral(2).Text) / LFactor
					txtPreTen(0).Text = txtTopTen.Text
					
					If chkBatch.CheckState Then
						For i = 1 To NumLines
							If i <> CurLine Then
								MoorLine_Renamed = MoorLines.MoorLines(i)
								
								MoorLine_Renamed.PretensionSur = .PretensionSur
								MoorLine_Renamed.PayoutSur = .PayoutSur
							End If
						Next 
					End If
					
				Case 2
					.PretensionOpr = CDbl(txtTopTen.Text) * 1000# / FrcFactor
					.PayoutOpr = CDbl(txtGeneral(2).Text) / LFactor
					txtPreTen(1).Text = txtTopTen.Text
					
					If chkBatch.CheckState Then
						For i = 1 To NumLines
							If i <> CurLine Then
								MoorLine_Renamed = MoorLines.MoorLines(i)
								
								MoorLine_Renamed.PretensionOpr = .PretensionOpr
								MoorLine_Renamed.PayoutOpr = .PayoutOpr
							End If
						Next 
					End If
			End Select
			
		End With
		
	End Sub
	
	Private Sub btnRemove_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnRemove.Click
		
		MoorLines.MoorLineDelete((CurLine))
		RemoveTabs()
		
		If NumLines = 1 Then
			MoorLines.MoorLineAdd()
		Else
			NumLines = NumLines - 1
			If CurLine > NumLines Then CurLine = 1
		End If
		LoadMoorData()
	End Sub
	
	Private Sub btnScope_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnScope.Click
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
			StressFactor = 6.894757 ' ksi -> MPa
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 2.54 ' in -> cm
			LUnit = "m"
			FrcUnit = "KN"
		Else
			LFactor = 1
			FrcFactor = 1
			StressFactor = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 1
			LUnit = "ft"
			FrcUnit = "kips"
		End If
		
		With ShipDesLoc
			.Xg = CDbl(txtVslSt(0).Text) / LFactor
			.Yg = CDbl(txtVslSt(1).Text) / LFactor
			.Heading = CDbl(txtVslSt(2).Text) * Degrees2Radians
		End With
		
		With MoorLines.MoorLines(CurLine)
			.Anchor.Xg = CDbl(txtAnchor(0).Text) / LFactor
			.Anchor.Yg = CDbl(txtAnchor(1).Text) / LFactor
			.FairLead.Xs = CDbl(txtFL(0).Text) / LFactor
			.FairLead.Ys = CDbl(txtFL(1).Text) / LFactor
			
			txtGeneral(1).Text = VB6.Format(.ScopeByVesselLocation(ShipDesLoc, True) * LFactor, "0.000")
			txtGeneral(0).Text = VB6.Format(.SprdAngle(ShipDesLoc, True) * Radians2Degrees, "0.000")
		End With
		
		btnAnchor.Enabled = False
		btnScope.Enabled = False
		
	End Sub
	
	Private Sub btnTopTension_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnTopTension.Click
		
		Dim TopTension, HorForce As Double
		Dim Scope, POL As Double
		
		If btnAnchor.Enabled Then btnAnchor_Click(btnAnchor, New System.EventArgs())
		If btnScope.Enabled Then btnScope_Click(btnScope, New System.EventArgs())
		
		If Not Updated Then
			If Not UpdateMoorData Then Exit Sub
		End If
		
		With MoorLines.MoorLines(CurLine)
			Scope = .DesScope
			POL = .Payout
			Cursor = System.Windows.Forms.Cursors.WaitCursor
			TopTension = .TensionByScopePOL(Scope, HorForce, POL)
			Cursor = System.Windows.Forms.Cursors.Default
			txtTopTen.Text = VB6.Format(TopTension * 0.001 * FrcFactor, "0.000")
		End With
		
		TenCalc = True
		
	End Sub
	
	' combobox operation
	
	'UPGRADE_WARNING: Event cboDraft.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboDraft_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDraft.SelectedIndexChanged
		
		Dim i As Short
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
			StressFactor = 6.894757 ' ksi -> MPa
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 2.54 ' in -> cm
			LUnit = "m"
			FrcUnit = "KN"
		Else
			LFactor = 1
			FrcFactor = 1
			StressFactor = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 1
			LUnit = "ft"
			FrcUnit = "kips"
		End If
		
		
		With MoorLines
			Select Case cboDraft.SelectedIndex
				Case 0
					.ShipDraft = CurDraft
				Case 1
					.ShipDraft = SurDraft
				Case 2
					.ShipDraft = OprDraft
			End Select
			txtVslSt(3).Text = VB6.Format(.ShipDraft * LFactor, "0.000")
			'      If MsgBox("Automatically Change Payouts and Top Tensions?", vbQuestion + vbYesNo, "Warning") = vbYes Then
			Select Case cboDraft.SelectedIndex
				Case 0
					txtTopTen.Text = VB6.Format(.MoorLines(CurLine).TopTension * 0.001 * FrcFactor, "0.000")
				Case 1
					For i = 1 To NumLines
						If .MoorLines(i).PayoutSur > 0# Then .MoorLines(i).Payout = .MoorLines(i).PayoutSur
					Next 
					txtTopTen.Text = VB6.Format(.MoorLines(CurLine).PretensionSur * 0.001 * FrcFactor, "0.000")
				Case 2
					For i = 1 To NumLines
						If .MoorLines(i).PayoutOpr > 0# Then .MoorLines(i).Payout = .MoorLines(i).PayoutOpr
					Next 
					txtTopTen.Text = VB6.Format(.MoorLines(CurLine).PretensionOpr * 0.001 * FrcFactor, "0.000")
			End Select
			txtGeneral(2).Text = VB6.Format(.MoorLines(CurLine).Payout * LFactor, "0.000")
			'   End If
		End With
		
	End Sub
	
	'grid operation
	
	Private Sub grdSegments_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdSegments.DblClick
		If grdSegments.Col = 1 Then '2.1.4
			If cboSegType.Visible = False Then '2.1.4
				ExistingTxt = grdSegments.Text
				SetSegTypeCbo((grdSegments.Text))
				MSFlexGridCombo(grdSegments, cboSegType, True)
			End If
		Else
			MSFlexGridEdit(grdSegments, txtSegEdit, System.Windows.Forms.Keys.F2)
		End If
	End Sub
	
	Private Sub grdSegments_EnterCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdSegments.EnterCell
		
		ExistingTxt = grdSegments.Text
		JEC = True
		
	End Sub
	
	Private Sub grdSegments_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_KeyDownEvent) Handles grdSegments.KeyDownEvent
		
		KeyHandler(grdSegments, txtSegEdit, eventArgs.KeyCode, eventArgs.Shift, JEC, ExistingTxt)
		
	End Sub
	
	Private Sub grdSegments_LeaveCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdSegments.LeaveCell
		
		If txtSegEdit.Visible = True Then
			grdSegments.Text = txtSegEdit.Text
			txtSegEdit.Visible = False
		End If
		
		If Not CheckingGrid Then
			With grdSegments
				If txtSegEdit.Visible = True Then '2.1.4
					.Text = txtSegEdit.Text
					txtSegEdit.Visible = False
				End If
				If .Col = 1 Then '2.1.4
					If cboSegType.Visible Then
						.Text = cboSegType.Text
						cboSegType.Visible = False
					End If
					If .Text <> ExistingTxt Then Changed = True
				Else
					If Trim(.Text) <> ExistingTxt Then
						If Trim(.Text) <> "" Then .Text = CheckData(.Text)
						Changed = True
					End If
				End If
			End With
			
			If Changed Then '2.1.4
				Updated = False
				TenCalc = False
				btnPayout.Enabled = True
			End If
		End If
		
	End Sub
	
	Private Sub grdSegments_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseDownEvent) Handles grdSegments.MouseDownEvent
		
		If eventArgs.Button = VB6.MouseButtonConstants.RightButton Then
			With grdSegments
				.Row = .FixedRows
				.Col = .FixedCols
				
				CheckingGrid = True
				
				.Row = .MouseRow
				.Col = .MouseCol
				If .Row < .FixedRows Then .Row = .FixedRows
				If .Col < .FixedCols Then .Col = .FixedCols
				.Focus()
				
				CheckingGrid = False
			End With
			'UPGRADE_ISSUE: Form method frmMoorLines.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			PopupMenu(mnuGridEdit)
		End If
		
	End Sub
	
	Public Sub mnuInsert_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuInsert.Click
		
		AddRow(grdSegments, CheckingGrid)
		Updated = False
		TenCalc = False
		Changed = True
		
	End Sub
	
	Public Sub mnuDelete_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDelete.Click
		
		DeleteRow(grdSegments, CheckingGrid)
		Updated = False
		TenCalc = False
		Changed = True
		
	End Sub
	
	Private Sub txtSegEdit_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtSegEdit.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		EditKeyCode(grdSegments, txtSegEdit, KeyCode, Shift)
		
	End Sub
	
	Private Sub txtSegEdit_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSegEdit.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		'   delete returns to get rid of beep.
		If KeyAscii = Asc(vbCr) Then KeyAscii = 0
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Function CheckEntries(ByVal Entry As String, ByVal Column As Short) As String
		
		Dim StrLen As Short
		Dim msg As String
		
		StrLen = Len(Entry)
		Do While StrLen > 0
			If VB.Left(Entry, 1) = " " Then
				StrLen = StrLen - 1
				Entry = VB.Right(Entry, StrLen)
			ElseIf VB.Right(Entry, 1) = " " Then 
				StrLen = StrLen - 1
				Entry = VB.Left(Entry, StrLen)
			Else
				Exit Do
			End If
		Loop 
		
		If StrLen > 0 And Column > 1 Then
			Do While Not IsNumeric(Entry) And Entry <> ""
				msg = "'" & Entry & "' is not a valid numberic input. Please re-enter here:"
				Entry = InputBox(msg)
			Loop 
		End If
		
		CheckEntries = Entry
		
	End Function
	
	' text boxes
	
	'UPGRADE_WARNING: Event txtVslSt.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtVslSt_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVslSt.TextChanged
		Dim Index As Short = txtVslSt.GetIndex(eventSender)
		
		Select Case Index
			Case 0, 1, 2
				LocChanged = True
				btnAnchor.Enabled = True
				btnScope.Enabled = True
				btnPayout.Enabled = True
		End Select
		
	End Sub
	
	Private Sub txtVslSt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVslSt.Leave
		Dim Index As Short = txtVslSt.GetIndex(eventSender)
		
		txtVslSt(Index).Text = CheckData(txtVslSt(Index).Text)
		
	End Sub
	
	'UPGRADE_WARNING: Event txtAnchor.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtAnchor_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAnchor.TextChanged
		Dim Index As Short = txtAnchor.GetIndex(eventSender)
		On Error GoTo Errhandler
		Select Case Index
			Case 0, 1 ' Anchor X, Y
				btnAnchor.Enabled = False
				btnScope.Enabled = True
				btnPayout.Enabled = True
			Case 2 ' Anchor WD
				If Len(Trim(txtWD.Text)) > 0 And Val(txtWD.Text) <> 0 Then
					' calc average slope as default
					If Val(txtWD.Text) > CDbl(txtAnchor(2).Text) Then
						txtAnchor(3).Text = -VB6.Format(Atan(Val(txtGeneral(1).Text), Val(txtWD.Text) - Val(txtAnchor(2).Text), True) * 180 / PI, "#0.00")
					Else
						txtAnchor(3).Text = VB6.Format(Atan(Val(txtGeneral(1).Text), Val(txtAnchor(2).Text) - Val(txtWD.Text), True) * 180 / PI, "#0.00")
					End If
				End If
		End Select
		Updated = False
		TenCalc = False
		Exit Sub
Errhandler: 
		MsgBox("Error " & Err.Description, MsgBoxStyle.Critical, "Error")
		
	End Sub
	
	Private Sub txtAnchor_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAnchor.Leave
		Dim Index As Short = txtAnchor.GetIndex(eventSender)
		
		txtAnchor(Index).Text = CheckData(txtAnchor(Index).Text)
		
	End Sub
	
	'UPGRADE_WARNING: Event txtFL.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtFL_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFL.TextChanged
		Dim Index As Short = txtFL.GetIndex(eventSender)
		
		Select Case Index
			Case 0, 1
				btnAnchor.Enabled = True
				btnScope.Enabled = True
				btnPayout.Enabled = True
		End Select
		Updated = False
		TenCalc = False
		
	End Sub
	
	Private Sub txtFL_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFL.Leave
		Dim Index As Short = txtFL.GetIndex(eventSender)
		
		txtFL(Index).Text = CheckData(txtFL(Index).Text)
		
	End Sub
	
	'UPGRADE_WARNING: Event txtGeneral.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtGeneral_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGeneral.TextChanged
		Dim Index As Short = txtGeneral.GetIndex(eventSender)
		
		Select Case Index
			Case 0, 1
				btnAnchor.Enabled = True
				btnScope.Enabled = False
				btnPayout.Enabled = True
		End Select
		Updated = False
		TenCalc = False
		
	End Sub
	
	Private Sub txtGeneral_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGeneral.Leave
		Dim Index As Short = txtGeneral.GetIndex(eventSender)
		
		txtGeneral(Index).Text = CheckData(txtGeneral(Index).Text)
		
	End Sub
	
	'UPGRADE_WARNING: Event txtTopTen.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtTopTen_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTopTen.TextChanged
		
		btnPayout.Enabled = True
		Updated = False
		TenCalc = False
		
		If TenCalc = False Then
			If cboDraft.Text = VB6.GetItemString(cboDraft, 1) Or cboDraft.Text = VB6.GetItemString(cboDraft, 2) Then
				btnPreten.Enabled = True
			End If
		End If
	End Sub
	
	Private Sub txtTopTen_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTopTen.Leave
		
		txtTopTen.Text = CheckData(txtTopTen.Text)
		
	End Sub
	
	Private Sub IniSegments()
		
		Dim r, c As Short
		Dim ColW As Double
		Dim RowH As Short
		
		CheckingGrid = True
		
		Call SetLblSegments()
		
		With grdSegments
			.Rows = MaxNumSeg + 2
			.WordWrap = True
			
			ColW = (VB6.PixelsToTwipsX(.Width) - SysInfo1.ScrollBarSize) / (.Cols - 0.5) - 15
			RowH = VB6.PixelsToTwipsY(.Height) / 6.5 - .GridLineWidth
			.set_ColWidth(0, VB6.PixelsToTwipsX(.Width) - SysInfo1.ScrollBarSize - ColW * (.Cols - 1) - 50)
			.set_RowHeight(0, VB6.PixelsToTwipsY(.Height) - RowH * 4.8 - 70)
			.set_RowHeight(1, RowH * 0.8)
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
				.Text = CStr(r - .FixedRows + 1)
			Next r
			For r = 0 To .FixedRows - 1
				.Row = r
				For c = 0 To .Cols - 1
					.Col = c
					.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
					.Text = SegLabels(c, r)
				Next c
			Next r
			
			.Col = .FixedCols
			.Row = .FixedRows
		End With
		
		With grdAnchor
			.WordWrap = False
			.set_RowHeight(0, VB6.PixelsToTwipsY(.Height) - 90)
			.set_ColWidth(0, grdSegments.get_ColWidth(0) - 5)
			.set_ColWidth(1, ColW - 5)
			.set_ColWidth(2, ColW * 2 - 10)
			.set_ColWidth(3, ColW * 2 - 10)
			.set_ColWidth(4, ColW - 5)
			.set_ColWidth(5, ColW - 5)
			.set_ColWidth(7, ColW - 5)
			.set_ColWidth(6, VB6.PixelsToTwipsX(.Width) - ColW * 8 - .get_ColWidth(0) - 50)
			.Row = 0
			.Col = 0
			.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
			.Text = "Ends"
			.Col = 1
			.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter
			.CellBackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
			.Text = "ANCHOR"
			.Col = 2
			.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter
			.Col = 3
			.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
			.Text = "Holding Capacity " & "(" & FrcUnit & "):"
			.CellBackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
			.Col = 4
			.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
			.Col = 5
			.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter
			.Col = 6
			.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
			.Text = "WINCH Capacity (" & FrcUnit & "):"
			.CellBackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
			.Col = 7
			.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
			.Col = 0
		End With
		
		'   segment type
		With cboSegType '2.1.4
			.Items.Add("WIRE")
			.Items.Add("CHAIN")
			.Items.Add("WIRE-P")
			.Items.Add("CHAIN-P")
			.Items.Add("POLY-P")
			.Items.Add("BUOY-P")
			.Items.Add("SPRING") '2.2.1
		End With
		
		CheckingGrid = False
		
	End Sub
	' operation subroutines
	' initiating
	
	Private Sub SetLblSegments()
		
		SegLabels(0, 0) = "No"
		SegLabels(1, 0) = "Type"
		SegLabels(2, 0) = "Deployed Length"
		SegLabels(3, 0) = "Total Length"
		SegLabels(4, 0) = "Diameter"
		SegLabels(5, 0) = "B.S."
		SegLabels(6, 0) = "E1"
		SegLabels(7, 0) = "E2"
		SegLabels(8, 0) = "Unit Dry Weight"
		SegLabels(9, 0) = "Unit Wet Weight"
		SegLabels(10, 0) = "Friction Coeff"
		SegLabels(11, 0) = "Buoy Net Buoyancy"
		SegLabels(12, 0) = "Vertical Distance"
		
		SegLabels(0, 1) = " "
		SegLabels(1, 1) = " "
		SegLabels(10, 1) = " "
		
		If IsMetricUnit Then
			SegLabels(2, 1) = "(m)"
			SegLabels(3, 1) = "(m)"
			SegLabels(4, 1) = "(cm)"
			SegLabels(5, 1) = "(KN)"
			SegLabels(6, 1) = "(MPa)"
			SegLabels(7, 1) = "(MPa)"
			SegLabels(8, 1) = "(N/m)"
			SegLabels(9, 1) = "(N/m)"
			SegLabels(11, 1) = "(KN)"
			SegLabels(12, 1) = "(m)"
		Else
			SegLabels(2, 1) = "(ft)"
			SegLabels(3, 1) = "(ft)"
			SegLabels(4, 1) = "(in)"
			SegLabels(5, 1) = "(kips)"
			SegLabels(6, 1) = "(ksi)"
			SegLabels(7, 1) = "(ksi)"
			SegLabels(8, 1) = "(lb/ft)"
			SegLabels(9, 1) = "(lb/ft)"
			SegLabels(11, 1) = "(kips)"
			SegLabels(12, 1) = "(ft)"
		End If
	End Sub
	
	Private Sub InitiateTabs()
		
		Dim i, NumTab As Short
		
		NumTab = tabMoorLines.Tabs.Count
		If NumLines > NumTab Then
			For i = NumTab + 1 To NumLines
				tabMoorLines.Tabs.Add(i,  , "Line " & i)
			Next 
		End If
		
		tabMoorLines.SelectedItem = tabMoorLines.Tabs(CurLine)
		
	End Sub
	
	Private Sub RemoveTabs()
		
		Dim i As Short
		
		If NumLines > 1 Then
			tabMoorLines.Tabs.Remove((CurLine))
			For i = CurLine To NumLines - 1
				tabMoorLines.Tabs(i).Caption = "Line " & i
			Next 
		End If
		
	End Sub
	
	
	' operation subroutines
	' load to and update from form
	Private Sub LoadMoorData(Optional ByVal FirstTime As Boolean = False)
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
			StressFactor = 6.894757 ' ksi -> MPa
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 2.54 ' in -> cm
			LUnit = "m"
			FrcUnit = "KN"
		Else
			LFactor = 1
			FrcFactor = 1
			StressFactor = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 1
			LUnit = "ft"
			FrcUnit = "kips"
		End If
		
		Dim r, c As Short
		'UPGRADE_NOTE: Dir was upgraded to Dir_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Scope, HD, Dir_Renamed, SprdAng As Double
		Dim NumSeg As Short
		
		
		
		'   set ship location at first time
		If FirstTime Then
			With CurVessel
				txtVslSt(0).Text = VB6.Format(.ShipDesGlob.Xg * LFactor, "0.000")
				txtVslSt(1).Text = VB6.Format(.ShipDesGlob.Yg * LFactor, "0.000")
				txtWD.Text = VB6.Format(.WaterDepth * LFactor, "0.000")
				txtVslSt(2).Text = VB6.Format(.ShipDesGlob.Heading * Radians2Degrees, "0.000")
				txtVslSt(3).Text = VB6.Format(.ShipDraft * LFactor, "0.000")
			End With
			
			'       initiate form appearance
			cboDraft.Text = VB6.GetItemString(cboDraft, 0)
			btnPreten.Enabled = False
			'    chkBatch.Value = False
		End If
		
		'   clear grid
		With grdSegments
			For r = .FixedRows To .Rows - 1
				.Row = r
				For c = 1 To .Cols - 1
					.Col = c
					.Text = ""
				Next 
			Next 
		End With
		
		With MoorLines.MoorLines(CurLine)
			'       anchor
			txtAnchor(0).Text = VB6.Format(.Anchor.Xg * LFactor, "0.000")
			txtAnchor(1).Text = VB6.Format(.Anchor.Yg * LFactor, "0.000")
			txtAnchor(2).Text = VB6.Format(.WaterDepth * LFactor, "0.000")
			txtAnchor(3).Text = VB6.Format(.BottomSlope * Radians2Degrees, "0.000")
			
			'       fairlead
			txtFL(0).Text = VB6.Format(.FairLead.Xs * LFactor, "0.000")
			txtFL(1).Text = VB6.Format(.FairLead.Ys * LFactor, "0.000")
			txtFL(2).Text = VB6.Format(.FairLead.z * LFactor, "0.000")
			
			'       general
			' ????? .FairLead.SprdAngle = 0 will cause actual 0 deg angle to be changed to 180 deg ??????
			If .FairLead.SprdAngle = 0# Then
				SprdAng = .SprdAngle(ShipDesLoc) ' calc SpreadAngle from Anchor and FL pts
			Else
				SprdAng = .FairLead.SprdAngle
			End If
			If .DesScope = 0# Then
				Scope = .ScopeByVesselLocation(ShipDesLoc)
			Else
				Scope = .DesScope
			End If
			
			' This assumes HD from vessel center, both HD & angle will be affected
			'        GetHorDist HD, Dir, Scope, SprdAng, .FairLead.Xs, .FairLead.Ys
			'        txtGeneral(0) = Format(Dir * Radians2Degrees, "0.00")
			'        txtGeneral(1) = Format(HD * LFactor, "0.0")
			
			' This assumes scope from fairlead
			txtGeneral(0).Text = VB6.Format(SprdAng * Radians2Degrees, "0.000")
			txtGeneral(1).Text = VB6.Format(Scope * LFactor, "0.000")
			If .FairLead.SprdAngle = 0# And .DesScope = 0# Then
				btnAnchor.Enabled = False
				btnScope.Enabled = False
				
				.FairLead.SprdAngle = SprdAng
				.DesScope = Scope
			Else
				btnAnchor.Enabled = True
				btnScope.Enabled = False
			End If
			
			txtGeneral(2).Text = VB6.Format(.Payout * LFactor, "0.000")
			
			'       top tensions
			txtTopTen.Text = VB6.Format(.TopTension * 0.001 * FrcFactor, "0.000")
			txtPreTen(0).Text = VB6.Format(.PretensionSur * 0.001 * FrcFactor, "0.000")
			txtPreTen(1).Text = VB6.Format(.PretensionOpr * 0.001 * FrcFactor, "0.000")
			btnPayout.Enabled = False
			
			'       segments
			CheckingGrid = True
			
			NumSeg = .SegmentCount
			
			For r = 1 To NumSeg
				grdSegments.Row = r + grdSegments.FixedRows - 1
				
				grdSegments.Col = 1
				grdSegments.Text = .Segments(r).SegType
				
				grdSegments.Col = 2
				grdSegments.Text = VB6.Format(.Segments(r).Length * LFactor, "0.0")
				
				grdSegments.Col = 3
				grdSegments.Text = VB6.Format(.Segments(r).TotalLength * LFactor, "0.0")
				
				grdSegments.Col = 4
				'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				grdSegments.Text = VB6.Format(.Segments(r).Diameter * DiameterFactor, "0.000")
				
				grdSegments.Col = 5
				grdSegments.Text = VB6.Format(.Segments(r).BS * 0.001 * FrcFactor, "0.0")
				
				grdSegments.Col = 6
				grdSegments.Text = VB6.Format(.Segments(r).E1 * 0.001 * StressFactor, "0.0")
				
				grdSegments.Col = 7
				grdSegments.Text = VB6.Format(.Segments(r).E2 * 0.001 * StressFactor, "0.0")
				
				grdSegments.Col = 8
				grdSegments.Text = VB6.Format(.Segments(r).UnitDryWeight * (FrcFactor / LFactor), "0.00")
				
				grdSegments.Col = 9
				grdSegments.Text = VB6.Format(.Segments(r).UnitWetWeight * (FrcFactor / LFactor), "0.00")
				
				grdSegments.Col = 10
				grdSegments.Text = VB6.Format(.Segments(r).FrictionCoef, "0.00")
				
				grdSegments.Col = 11
				grdSegments.Text = VB6.Format(.Segments(r).Buoy / 1000 * FrcFactor, "0.0")
				
				grdSegments.Col = 12
				grdSegments.Text = VB6.Format(.Segments(r).BuoyLength * LFactor, "0.0")
			Next 
			grdSegments.Col = 1
			grdSegments.Row = 1
			
			grdAnchor.Row = 0
			grdAnchor.Col = 2
			grdAnchor.Text = .Anchor.Model
			
			grdAnchor.Col = 4
			grdAnchor.Text = VB6.Format(.Anchor.HoldCap * 0.001 * FrcFactor, "0.0")
			
			grdAnchor.Col = 5
			grdAnchor.Text = .Anchor.Remark
			
			grdAnchor.Col = 7
			grdAnchor.Text = VB6.Format(.WinchCap * 0.001 * FrcFactor, "0.0")
			grdAnchor.Col = 2
			
			CheckingGrid = False
		End With
		
		Updated = True
		TenCalc = False
		
		'   If Val(txtTopTen.Text) < 0.9 Then btnTopTension_Click
		
	End Sub
	
	
	Private Sub UpdateBatchLines()
		
		'UPGRADE_NOTE: Segment was upgraded to Segment_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Segment_Renamed As Segment
		'UPGRADE_NOTE: MoorLine was upgraded to MoorLine_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim MoorLine_Renamed As MoorLine
		Dim j, i, NumSeg As Short
		
		Dim SegTp As String
		Dim TLg, Lg, dia As Double
		Dim E1, BS, E2 As Double
		Dim Buoy, DryWt, WetWt, BuoyL As Double
		Dim FrCoef As Double
		
		'UPGRADE_NOTE: Dir was upgraded to Dir_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Dir_Renamed, HD, Scope As Double
		
		MoorLine_Renamed = MoorLines.MoorLines(CurLine)
		'    With MoorLine
		'        GetHorDist HD, Dir, .DesScope, .FairLead.SprdAngle, .FairLead.Xs, .FairLead.Ys
		'    End With
		
		For i = 1 To NumLines
			If i <> CurLine Then
				With MoorLines.MoorLines(i)
					.BottomSlope = MoorLine_Renamed.BottomSlope
					.DesScope = MoorLine_Renamed.DesScope
					'            .DesScope = ScopeByHD(HD, .FairLead.SprdAngle, .FairLead.Xs, .FairLead.Ys)
					.Payout = MoorLine_Renamed.Payout
					.WaterDepth = MoorLine_Renamed.WaterDepth
					.FairLead.z = MoorLine_Renamed.FairLead.z
					
					.Anchor.HoldCap = MoorLine_Renamed.Anchor.HoldCap
					.Anchor.Model = MoorLine_Renamed.Anchor.Model
					.Anchor.Remark = MoorLine_Renamed.Anchor.Remark
					.WinchCap = MoorLine_Renamed.WinchCap
					
					If Changed Then
						NumSeg = .SegmentCount
						For j = 1 To NumSeg
							.SegmentDelete((1))
						Next j
					End If
				End With
				
				If Changed Then
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
				End If
			End If
		Next i
		
	End Sub
	
	Private Function UpdateMoorData() As Boolean
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
			StressFactor = 6.894757 ' ksi -> MPa
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 2.54 ' in -> cm
			LUnit = "m"
			FrcUnit = "KN"
		Else
			LFactor = 1
			FrcFactor = 1
			StressFactor = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DiameterFactor = 1
			LUnit = "ft"
			FrcUnit = "kips"
		End If
		
		Dim r, c As Short
		Dim NumRows, NumBlank, NumSegments As Short
		
		Dim SegTp As String
		Dim TLg, Lg, dia As Double
		Dim E1, BS, E2 As Double
		Dim Buoy, DryWt, WetWt, BuoyL As Double
		Dim FrCoef As Double
		'UPGRADE_NOTE: Dir was upgraded to Dir_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Scope, HD, Dir_Renamed, SprdAng As Double
		
		UpdateMoorData = True
		
		If LocChanged Then
			With ShipDesLoc
				.Xg = CDbl(txtVslSt(0).Text) / LFactor
				.Yg = CDbl(txtVslSt(1).Text) / LFactor
				.Heading = CDbl(txtVslSt(2).Text) * Degrees2Radians
			End With
		End If
		
		
		With MoorLines.MoorLines(CurLine)
			
			'       general
			
			'        HD, Dir are in reference to vessel center for scope and Spread Angle
			'        Dir = txtGeneral(0) * Degrees2Radians
			'        HD = txtGeneral(1)
			SprdAng = CDbl(txtGeneral(0).Text) * Degrees2Radians
			.DesScope = CDbl(txtGeneral(1).Text) / LFactor ' This assume scope is referenced from fairlead
			.Payout = CDbl(txtGeneral(2).Text) / LFactor '       top tension
			.TopTension = CDbl(txtTopTen.Text) * 1000# / FrcFactor
			
			'       fairlead
			.FairLead.Xs = CDbl(txtFL(0).Text) / LFactor
			.FairLead.Ys = CDbl(txtFL(1).Text) / LFactor
			.FairLead.z = CDbl(txtFL(2).Text) / LFactor
			'     GetScopeSprd Scope, SprdAng, HD, Dir, .FairLead.Xs, .FairLead.Ys
			.FairLead.SprdAngle = SprdAng
			
			'       anchor
			.Anchor.Xg = CDbl(txtAnchor(0).Text) / LFactor
			.Anchor.Yg = CDbl(txtAnchor(1).Text) / LFactor
			.WaterDepth = CDbl(txtAnchor(2).Text) / LFactor
			.BottomSlope = CDbl(txtAnchor(3).Text) * Degrees2Radians
			
			grdAnchor.Row = 0
			grdAnchor.Col = 2
			.Anchor.Model = grdAnchor.Text
			grdAnchor.Col = 4
			.Anchor.HoldCap = CDbl(grdAnchor.Text) * 1000# / FrcFactor
			grdAnchor.Col = 5
			.Anchor.Remark = grdAnchor.Text
			grdAnchor.Col = 7
			.WinchCap = CDbl(grdAnchor.Text) * 1000# / FrcFactor
		End With
		
		'   segments
		'   avoid triggering the "Leave Cell" event
		If Not Changed Then
			Updated = True
			If chkBatch.CheckState Then UpdateBatchLines()
			
			Exit Function
		End If
		
		CheckingGrid = True
		
		With grdSegments
			'       scan for a blank cell in this row; if one is found, bail out
			NumRows = .Rows
			For r = .FixedRows To .Rows - 1
				.Row = r
				'           Count the number of blank cells in the row; if they are all blank,
				'           or if none are blank, fine.  Otherwise, issue a warning to the user
				'           and don't save the values
				NumBlank = 0
				For c = 1 To .Cols - 1
					.Col = c
					.Text = CheckEntries(.Text, c)
					If Not IsNumeric(.Text) Then
						If c = 1 Then
							If .Text = "" Then NumBlank = NumBlank + 1
						Else
							NumBlank = NumBlank + 1
						End If
					End If
				Next c
				
				Select Case NumBlank
					Case .Cols - 1
						'                   totally blank row; assume this is end-of-data
						NumRows = r
						Exit For
					Case 0
						'                   no blank cells in the row; forge on
					Case Else
						'                   one or more blanks, fill up with 0
						For c = 2 To .Cols - 1
							.Col = c
							If .Text = "" Then .Text = CStr(0)
						Next c
				End Select
			Next r
			
			'       delete the old input
			NumSegments = MoorLines.MoorLines(CurLine).SegmentCount
			For r = 1 To NumSegments
				MoorLines.MoorLines(CurLine).SegmentDelete((1))
			Next r
			
			'       insert the updated input
			For r = .FixedRows To NumRows - 1
				.Row = r
				'           store the data from this row in the new segment
				For c = 1 To .Cols - 1
					.Col = c
					Select Case c
						Case 1
							SegTp = .Text
						Case 2
							Lg = CDbl(.Text) / LFactor
						Case 3
							TLg = CDbl(.Text) / LFactor
						Case 4
							'UPGRADE_WARNING: Couldn't resolve default property of object DiameterFactor. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							dia = CDbl(.Text) / DiameterFactor
						Case 5
							BS = CDbl(.Text) * 1000# / FrcFactor
						Case 6
							E1 = CDbl(.Text) * 1000# / StressFactor
						Case 7
							E2 = CDbl(.Text) * 1000# / StressFactor
						Case 8
							DryWt = CDbl(.Text) / (FrcFactor / LFactor)
						Case 9
							WetWt = CDbl(.Text) / (FrcFactor / LFactor)
						Case 10
							FrCoef = CDbl(.Text)
						Case 11
							Buoy = CDbl(.Text) * 1000 / FrcFactor
						Case 12
							BuoyL = CDbl(.Text) / LFactor
					End Select
				Next c
				
				Call MoorLines.MoorLines(CurLine).SegmentAdd(SegTp, Lg, TLg, dia, BS, E1, E2, DryWt, WetWt, Buoy, BuoyL, FrCoef)
			Next r
		End With
		
		'   reset the "Leaving Cell" trigger
		CheckingGrid = False
		
		If chkBatch.CheckState Then UpdateBatchLines()
		
		Updated = True
		
	End Function
	
	'Private Function UpdateMoorData1() As Boolean
	' This routine assumes Scope from fairlead
	'
	'
	'' get data from screen to save in MoorLines object
	'
	'    Dim r As Integer, C As Integer
	'    Dim NumBlank As Integer, NumRows As Integer, NumSegments As Integer
	'
	'    Dim SegTp As String, Lg as double, TLg as double, dia as double
	'    Dim BS as double, E1 as double, E2 as double
	'    Dim DryWt as double, WetWt as double, Buoy as double, BuoyL as double
	'    Dim FrCoef as double
	'
	'    UpdateMoorData = True
	'
	'    With MoorLines.MoorLines(CurLine)
	''       general
	'        .FairLead.SprdAngle = txtGeneral(0) * Degrees2Radians
	'        .DesScope = txtGeneral(1)
	'        .Payout = txtGeneral(2)
	'
	''       top tension
	'        .TopTension = txtTopTen * 1000#
	'
	''       fairlead
	'        .FairLead.Xs = txtFL(0)
	'        .FairLead.Ys = txtFL(1)
	'        .FairLead.z = txtFL(2)
	'
	''       anchor
	'        .Anchor.Xg = txtAnchor(0)
	'        .Anchor.Yg = txtAnchor(1)
	'        .WaterDepth = txtAnchor(2)
	'        .BottomSlope = txtAnchor(3) * Degrees2Radians
	'    End With
	'
	''   segments
	''   avoid triggering the "Leave Cell" event
	'    If Not Changed Then
	'        Updated = True
	'        If chkBatch.Value = 1 Then UpdateBatchLines
	'
	'        Exit Function
	'    End If
	'
	'    CheckingGrid = True
	'
	'    With grdSegments
	''       scan for a blank cell in this row; if one is found, bail out
	'        NumRows = .Rows
	'        For r = .FixedRows To .Rows - 1
	'            .Row = r
	''           Count the number of blank cells in the row; if they are all blank,
	''           or if none are blank, fine.  Otherwise, issue a warning to the user
	''           and don't save the values
	'            NumBlank = 0
	'            For C = 1 To .Cols - 1
	'                .Col = C
	'                .Text = CheckEntries(.Text, C)
	'                If Not IsNumeric(.Text) Then
	'                    If C = 1 Then
	'                        If .Text = "" Then NumBlank = NumBlank + 1
	'                    Else
	'                        NumBlank = NumBlank + 1
	'                    End If
	'                End If
	'            Next C
	'
	'            Select Case NumBlank
	'                Case .Cols - 1
	''                   totally blank row; assume this is end-of-data
	'                    NumRows = r
	'                    Exit For
	'                Case 0
	''                   no blank cells in the row; forge on
	'                Case Else
	''                   one or more blanks, fill up with 0
	'                    For C = 2 To .Cols - 1
	'                        .Col = C
	'                        If .Text = "" Then .Text = 0
	'                    Next C
	'            End Select
	'        Next r
	'
	''       delete the old input
	'        NumSegments = MoorLines.MoorLines(CurLine).SegmentCount
	'        For r = 1 To NumSegments
	'            MoorLines.MoorLines(CurLine).SegmentDelete (1)
	'        Next r
	'
	''       insert the updated input
	'        For r = .FixedRows To NumRows - 1
	'            .Row = r
	''           store the data from this row in the new segment
	'            For C = 1 To .Cols - 1
	'                .Col = C
	'                Select Case C
	'                    Case 1
	'                        SegTp = .Text
	'                    Case 2
	'                        Lg = CSng(.Text)
	'                    Case 3
	'                        TLg = CSng(.Text)
	'                    Case 4
	'                        dia = CSng(.Text)
	'                    Case 5
	'                        BS = CSng(.Text) * 1000#
	'                    Case 6
	'                        E1 = CSng(.Text) * 1000#
	'                    Case 7
	'                        E2 = CSng(.Text) * 1000#
	'                    Case 8
	'                        DryWt = CSng(.Text)
	'                    Case 9
	'                        WetWt = CSng(.Text)
	'                    Case 10
	'                        FrCoef = CSng(.Text)
	'                End Select
	'            Next C
	'            Buoy = 0#
	'            BuoyL = 0#
	'
	'            Call MoorLines.MoorLines(CurLine).SegmentAdd(SegTp, Lg, TLg, dia, _
	''                BS, E1, E2, DryWt, WetWt, Buoy, BuoyL, FrCoef)
	'        Next r
	'    End With
	'
	''   reset the "Leaving Cell" trigger
	'    CheckingGrid = False
	'
	'    If chkBatch.Value = 1 Then UpdateBatchLines
	'
	'    Updated = True
	'
	'End Function
	
	' operation subroutines
	' load form and save to project
	
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
				
				.Anchor.HoldCap = MoorLine_Renamed.Anchor.HoldCap
				.Anchor.Model = MoorLine_Renamed.Anchor.Model
				.Anchor.Remark = MoorLine_Renamed.Anchor.Remark
				.WinchCap = MoorLine_Renamed.WinchCap
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
	
	
	Private Sub SaveMoorLines()
		
		'UPGRADE_NOTE: Segment was upgraded to Segment_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Segment_Renamed As Segment
		'UPGRADE_NOTE: MoorLine was upgraded to MoorLine_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim MoorLine_Renamed As MoorLine
		Dim DLine, i, j, NumSeg As Short
		
		Dim SegTp As String
		Dim TLg, Lg, dia As Double
		Dim E1, BS, E2 As Double
		Dim Buoy, DryWt, WetWt, BuoyL As Double
		Dim FrCoef As Double
		
		With CurVessel.MoorSystem
			DLine = NumLines - .MoorLineCount
			If DLine > 0 Then
				For i = 1 To DLine
					.MoorLineAdd()
				Next i
			ElseIf DLine < 0 Then 
				For i = NumLines - DLine To NumLines + 1 Step -1
					.MoorLineDelete((i))
				Next i
			End If
		End With
		
		Dim outTh As Double
		
		For i = 1 To NumLines Step 1
			MoorLine_Renamed = MoorLines.MoorLines(i)
			
			With CurVessel.MoorSystem.MoorLines(i)
				
				NumSeg = .SegmentCount
				For j = 1 To NumSeg
					.SegmentDelete((1))
				Next j
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
					Call CurVessel.MoorSystem.MoorLines(i).SegmentAdd(SegTp, Lg, TLg, dia, BS, E1, E2, DryWt, WetWt, Buoy, BuoyL, FrCoef)
				Next Segment_Renamed
				
				.BottomSlope = MoorLine_Renamed.BottomSlope
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
				
				.Anchor.HoldCap = MoorLine_Renamed.Anchor.HoldCap
				.Anchor.Model = MoorLine_Renamed.Anchor.Model
				.Anchor.Remark = MoorLine_Renamed.Anchor.Remark
				.WinchCap = MoorLine_Renamed.WinchCap
			End With
			
			With CurVessel.MoorSystem.MoorLines(i)
				If MoorLine_Renamed.TopTension = 0 Then
					.TopTension = MoorLine_Renamed.TensionByScopePOL(.DesScope, outTh, .Payout)
				Else
					.TopTension = MoorLine_Renamed.TopTension
				End If
			End With
		Next i
		
	End Sub
	
	'Private Sub SaveMoorLines1()
	'
	'    Dim Segment As Segment
	'    Dim MoorLine As MoorLine
	'    Dim i As Integer, j As Integer, DLine As Integer, NumSeg As Integer
	'
	'    Dim SegTp As String, Lg as double, TLg as double, dia as double
	'    Dim BS as double, E1 as double, E2 as double
	'    Dim DryWt as double, WetWt as double, Buoy as double, BuoyL as double
	'    Dim FrCoef as double
	'
	'    With CurVessel.ShipDesGlob
	'        .Xg = ShipDesLoc.Xg
	'        .Yg = ShipDesLoc.Yg
	'        .Heading = ShipDesLoc.Heading
	'    End With
	'
	'    With CurVessel.MoorSystem
	'        DLine = NumLines - .MoorLineCount
	'        If DLine > 0 Then
	'            For i = 1 To DLine
	'                .MoorLineAdd
	'            Next i
	'        ElseIf DLine < 0 Then
	'            For i = NumLines - DLine To NumLines + 1 Step -1
	'                .MoorLineDelete (i)
	'            Next i
	'        End If
	'    End With
	'
	'    For i = 1 To NumLines Step 1
	'        Set MoorLine = MoorLines.MoorLines(i)
	'
	'        With CurVessel.MoorSystem.MoorLines(i)
	'            .BottomSlope = MoorLine.BottomSlope
	'            .DesScope = MoorLine.DesScope
	'
	'            .Payout = MoorLine.Payout
	'            .PayoutSur = MoorLine.PayoutSur
	'            .PayoutOpr = MoorLine.PayoutOpr
	'            .PretensionSur = MoorLine.PretensionSur
	'            .PretensionOpr = MoorLine.PretensionOpr
	'
	'            .FairLead.SprdAngle = MoorLine.FairLead.SprdAngle
	'            .FairLead.Xs = MoorLine.FairLead.Xs
	'            .FairLead.Ys = MoorLine.FairLead.Ys
	'            .FairLead.z = MoorLine.FairLead.z
	'
	'            .Anchor.Xg = MoorLine.Anchor.Xg
	'            .Anchor.Yg = MoorLine.Anchor.Yg
	'            .WaterDepth = MoorLine.WaterDepth
	'
	'            NumSeg = .SegmentCount
	'            For j = 1 To NumSeg
	'                .SegmentDelete (1)
	'            Next j
	'        End With
	'
	'        For Each Segment In MoorLine
	'            With Segment
	'                SegTp = .SegType
	'                Lg = .Length
	'                TLg = .TotalLength
	'                dia = .Diameter
	'                BS = .BS
	'                E1 = .E1
	'                E2 = .E2
	'                DryWt = .UnitDryWeight
	'                WetWt = .UnitWetWeight
	'                Buoy = .Buoy
	'                BuoyL = .BuoyLength
	'                FrCoef = .FrictionCoef
	'            End With
	'            Call CurVessel.MoorSystem.MoorLines(i).SegmentAdd(SegTp, Lg, TLg, dia, _
	''                BS, E1, E2, DryWt, WetWt, Buoy, BuoyL, FrCoef)
	'        Next
	'
	'    Next i
	'
	'
	'End Sub
	
	' programs involves catenary forms
	
	Friend Sub UpdateCat(Optional ByRef TopTension As Double = 0#, Optional ByRef HorForce As Double = 0#)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		
		Dim i, NumSeg As Short
		
		Dim Scope, FrcHor As Double
		
		Dim Length, LenStr As Double
		
		Dim SegLength(MaxNumSeg) As Double
		Dim SegTension(MaxNumSeg) As Double
		Dim SegAngle(MaxNumSeg) As Double
		Dim SegPosition(MaxNumSeg) As Double
		Dim CatX(MaxNumSubSeg * MaxNumSeg + 1) As Double
		Dim CatY(MaxNumSubSeg * MaxNumSeg + 1) As Double
		Dim Connector(MaxNumSeg + 1) As Short
		
		With MoorLines.MoorLines(CurLine)
			If TopTension = 0# Then
				If HorForce = 0# Then
					If Not TenCalc Then btnTopTension_Click(btnTopTension, New System.EventArgs())
					Scope = .DesScope
				Else
					Scope = .ScopeByFrcHorPOL(HorForce, TopTension, .Payout)
				End If
			Else
				Scope = .ScopeByTopTensionPOL(TopTension, FrcHor, .Payout)
			End If
			
			Length = .LineLen
			LenStr = .LineLenStr
			
			NumSeg = .SegmentCount
			If NumSeg > MaxNumSeg Then NumSeg = MaxNumSeg
			For i = 1 To NumSeg Step 1
				With .Segments(i)
					SegLength(i) = .Length
					SegTension(i) = .TenUpp
					SegAngle(i) = .AngUpp
					If i < NumSeg Then SegPosition(i + 1) = .YLow
				End With
			Next i
			SegLength(1) = .Payout
			SegPosition(1) = .Draft - .FairLead.z
			
			If Not .CatenaryPoints(CatX, CatY, Connector) Then
				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
				If frmCatenary.Visible Then
					MsgBox("Catenary Calculation failed.")
				End If
				Exit Sub
			End If
			
			frmCatenary.UpdateForm(NumLines, CurLine, NumSeg, Scope, Length, LenStr - .GrdLen, .GrdLen, LenStr - Length, .Payout, .TopTension, .AnchPull, .FLAngle, .BtmAngle, SegPosition(1), SegLength, SegTension, SegAngle, SegPosition, CatX, CatY, Connector)
		End With
		
		TenCalc = False
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		
	End Sub
End Class