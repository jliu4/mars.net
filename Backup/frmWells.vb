Option Strict Off
Option Explicit On
Friend Class frmWells
	Inherits System.Windows.Forms.Form
	' frmWells          form to input/edit well site information
	' Version 1.0
	' 2001, Copyright DTCEL, All Rights Reserved
	
	
	' for grid operation
	Private NumWells As Short
	
	Private Changed As Boolean
	Private ExistingTxt As String
	Private CheckingGrid As Boolean
	Private JustEnterCell As Boolean
	Dim LFactor, FrcFactor As Double
	' load form
	
	Private Sub frmWells_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim LUnit, FrcUnit As String
		If IsMetricUnit Then
			LUnit = "(m)"
			FrcUnit = "(KN)"
		Else
			LUnit = "(ft)"
			FrcUnit = "(kips)"
		End If
		
		Dim i As Short
		Dim ColW, RowH As Short
		Dim WSLabels(4) As String
		
		CheckingGrid = True
		
		WSLabels(0) = "No."
		WSLabels(1) = "Name/ID"
		WSLabels(2) = "X (E) " & LUnit
		WSLabels(3) = "Y (N) " & LUnit
		WSLabels(4) = "Depth " & LUnit
		
		NumWells = CurField.Count
		
		With grdWS
			'       initiate grid
			.Rows = MaxNumWells + 1
			.WordWrap = True
			RowH = VB6.PixelsToTwipsY(.Height) / 11 - 20
			.set_ColWidth(0, SysInfo1.ScrollBarSize * 2)
			ColW = (VB6.PixelsToTwipsX(.Width) - SysInfo1.ScrollBarSize - .get_ColWidth(0)) / (.Cols - .FixedCols) - 20
			.set_RowHeight(0, RowH + 120)
			
			.Col = 0
			For i = 1 To .Rows - 1
				.set_RowHeight(i, RowH)
				.Row = i
				.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
				.Text = CStr(i)
			Next i
			For i = 1 To .Cols - 1
				.set_ColWidth(i, ColW)
			Next i
			
			.Row = 0
			For i = 0 To .Cols - 1
				.Col = i
				.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
				.Text = WSLabels(i)
			Next 
			.Row = 1
			.Col = 1
			
			'       load data
			If CurField.Count <> 0 Then LoadData()
		End With
		
		CheckingGrid = False
		Changed = False
		
	End Sub
	
	' command buttons
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		
		Me.Close()
		
	End Sub
	
	Private Sub btnOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOK.Click
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		If Not SaveData Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		Cursor = System.Windows.Forms.Cursors.Default
		CurProj.Saved = False
		Changed = False
		Me.Close()
		
	End Sub
	
	Private Sub frmWells_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		If Changed Then
			If MsgBox("Data changed. Save?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
				SaveData()
			End If
		End If
		eventArgs.Cancel = Cancel
	End Sub
	
	' grid
	
	Private Sub grdWS_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseDownEvent) Handles grdWS.MouseDownEvent
		
		If eventArgs.Button = VB6.MouseButtonConstants.RightButton Then
			'UPGRADE_ISSUE: Form method frmWells.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			PopupMenu(mnuGridEdit)
		End If
		
	End Sub
	
	Public Sub mnuAddRow_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAddRow.Click
		
		AddRow(grdWS, CheckingGrid)
		
	End Sub
	
	Public Sub mnuDeleteRow_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDeleteRow.Click
		
		DeleteRow(grdWS, CheckingGrid)
		
	End Sub
	
	Private Sub grdWS_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdWS.DblClick
		
		MSFlexGridEdit(grdWS, txtEdit, System.Windows.Forms.Keys.F10)
		
	End Sub
	
	Private Sub grdWS_EnterCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdWS.EnterCell
		
		ExistingTxt = grdWS.Text
		JustEnterCell = True
		
	End Sub
	
	Private Sub grdWS_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_KeyDownEvent) Handles grdWS.KeyDownEvent
		
		KeyHandler(grdWS, txtEdit, eventArgs.KeyCode, eventArgs.Shift, JustEnterCell, ExistingTxt)
		
	End Sub
	
	Private Sub grdWS_LeaveCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdWS.LeaveCell
		
		If txtEdit.Visible = True Then
			grdWS.Text = txtEdit.Text
			txtEdit.Visible = False
		End If
		
		If Not CheckingGrid Then
			With grdWS
				If Trim(.Text) <> ExistingTxt And .Col > 1 Then
					If Trim(.Text) <> "" Then .Text = CheckData(.Text)
					Changed = True
				End If
			End With
		End If
		
	End Sub
	
	Private Sub txtEdit_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtEdit.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		EditKeyCode(grdWS, txtEdit, KeyCode, Shift)
		Changed = True
	End Sub
	
	Private Sub txtEdit_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtEdit.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		If KeyAscii = Asc(vbCr) Then KeyAscii = 0
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	' menus
	
	Public Sub mnuExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuExit.Click
		
		Me.Close()
		
	End Sub
	
	Public Sub mnuFileOpen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileOpen.Click
		
		'UPGRADE_NOTE: FileOpen was upgraded to FileOpen_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim FileOpen_Renamed As Boolean
		
		'   should the user cancel the dialog box, exit
		On Error GoTo ErrHandler
		
		FileOpen_Renamed = False
		
		'   set filters to allow selection of all files or just .WSL
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		dlgFilesOpen.Filter = "All Files (*.*)|*.*|Current Files (*.wsl)|*.wsl"
		dlgFilesSave.Filter = "All Files (*.*)|*.*|Current Files (*.wsl)|*.wsl"
		'   specify default filter as *.WSL
		dlgFilesOpen.FilterIndex = 2
		dlgFilesSave.FilterIndex = 2
		dlgFilesOpen.InitialDirectory = CurProj.Directory
		dlgFilesSave.InitialDirectory = CurProj.Directory
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFiles.Flags was upgraded to dlgFilesOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFilesOpen.ShowReadOnly = False
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFiles.Flags was upgraded to dlgFilesOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFilesOpen.CheckFileExists = True
		dlgFilesOpen.CheckPathExists = True
		dlgFilesSave.CheckPathExists = True
		'   display the Open dialog box
		dlgFilesOpen.ShowDialog()
		dlgFilesSave.FileName = dlgFilesOpen.FileName
		'   open the file
		FileOpen(1, dlgFilesOpen.FileName, OpenMode.Input, OpenAccess.Read)
		FileOpen_Renamed = True
		
		'   build the object from the input data
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		CheckingGrid = True
		ImportData((1))
		CheckingGrid = False
		Cursor = System.Windows.Forms.Cursors.Default
		
		'   close the input file and return
		FileClose(1)
		FileOpen_Renamed = False
		
		Exit Sub
		
ErrHandler: 
		'   user pressed Cancel button
		If FileOpen_Renamed Then FileClose(1)
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Public Sub mnuFileSaveAs_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileSaveAs.Click
		
		'UPGRADE_NOTE: FileOpen was upgraded to FileOpen_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim FileOpen_Renamed As Boolean
		
		'   should the user cancel the dialog box, exit
		On Error GoTo ErrHandler
		
		FileOpen_Renamed = False
		
		'   set filters to allow selection of all files or just .WSL
		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		dlgFilesOpen.Filter = "All Files (*.*)|*.*|Current Files (*.wsl)|*.wsl"
		dlgFilesSave.Filter = "All Files (*.*)|*.*|Current Files (*.wsl)|*.wsl"
		'   specify default filter as *.WSL
		dlgFilesOpen.FilterIndex = 2
		dlgFilesSave.FilterIndex = 2
		'   specify the current filename
		dlgFilesOpen.FileName = "*.wsl"
		dlgFilesSave.FileName = "*.wsl"
		dlgFilesOpen.InitialDirectory = CurProj.Directory
		dlgFilesSave.InitialDirectory = CurProj.Directory
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFiles.Flags was upgraded to dlgFilesOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFilesOpen.ShowReadOnly = False
		'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFiles.Flags was upgraded to dlgFilesSave.OverwritePrompt which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		dlgFilesSave.OverwritePrompt = True
		'   display the Open dialog box
		dlgFilesSave.ShowDialog()
		dlgFilesOpen.FileName = dlgFilesSave.FileName
		'   open the file for output
		Dim fnum As Integer
		fnum = FreeFile
		FileOpen(fnum, dlgFilesOpen.FileName, OpenMode.Output)
		FileOpen_Renamed = True
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		'   output
		CheckingGrid = True
		ExportData((fnum))
		CheckingGrid = False
		Cursor = System.Windows.Forms.Cursors.Default
		'   close the output file
		FileClose(fnum)
		FileOpen_Renamed = False
		
		Exit Sub
		
ErrHandler: 
		'   user pressed Cancel button
		If FileOpen_Renamed Then FileClose(fnum)
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	' project data operations
	
	Private Sub LoadData()
		
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
		Else
			LFactor = 1
			FrcFactor = 1
		End If
		
		Dim WSD As Well
		Dim r As Short
		
		With grdWS
			For r = 1 To CurField.Count
				WSD = CurField.Item(r)
				If r > MaxNumWells Then Exit For
				.Row = r
				.Col = 1
				.Text = WSD.NameID
				.Col = 2
				.Text = VB6.Format(WSD.Xg * LFactor, "0.00")
				.Col = 3
				.Text = VB6.Format(WSD.Yg * LFactor, "0.00")
				.Col = 4
				.Text = VB6.Format(WSD.Depth * LFactor, "0.00")
			Next 
			.Row = 1
			.Col = 1
		End With
		
	End Sub
	
	Private Function SaveData() As Boolean
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
		Else
			LFactor = 1
			FrcFactor = 1
		End If
		
		Dim i As Short
		Dim Y, Depth, X, DampPercent As Double
		Dim NameID As String
		
		grdWS.Row = 0
		
		'   If Changed Then        '  make sure save when user clicks save no matter what
		'       delete previous input
		CurField.Clear()
		
		'       avoid triggering the "Leave Cell" event
		CheckingGrid = True
		'       insert current input
		With grdWS
			For i = 1 To .Rows - 1
				.Row = i
				'               quit if you hit a blank depth
				.Col = 1
				If .Text = "" Then Exit For
				NameID = .Text
				.Col = 2
				If .Text = "" Then
					X = 0#
				Else
					X = CDbl(.Text) / LFactor
				End If
				.Col = 3
				If .Text = "" Then
					Y = 0#
				Else
					Y = CDbl(.Text) / LFactor
				End If
				.Col = 4
				If .Text = "" Then Exit For
				Depth = CDbl(.Text) / LFactor
				
				CurField.Add(NameID, X, Y, Depth)
			Next i
		End With
		'       reset the "Leaving Cell" trigger
		CheckingGrid = False
		'  End If
		
		SaveData = True
		
	End Function
	
	Private Sub ImportData(ByRef FileNum As Short)
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
		Else
			LFactor = 1
			FrcFactor = 1
		End If
		
		Dim r, c As Short
		Dim X, Depth, Y As Double
		Dim NameID As String
		
		Changed = True
		
		With grdWS
			
			For r = .FixedRows To .Rows - 1
				For c = .FixedCols To .Cols - 1
					.set_TextMatrix(r, c, "")
				Next c
			Next r
			r = 1
			Do While Not EOF(FileNum)
				Input(FileNum, NameID)
				Input(FileNum, X)
				Input(FileNum, Y)
				Input(FileNum, Depth)
				If r > MaxNumWells Then Exit Do
				.Row = r
				.Col = 1
				.Text = NameID
				.Col = 2
				.Text = CStr(X * LFactor)
				.Col = 3
				.Text = CStr(Y * LFactor)
				.Col = 4
				.Text = CStr(Depth * LFactor)
				r = r + 1
			Loop 
		End With
		
	End Sub
	
	Private Sub ExportData(ByRef FileNum As Short)
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
		Else
			LFactor = 1
			FrcFactor = 1
		End If
		
		Dim i As Short
		Dim X, Depth, Y As Double
		Dim NameID As String
		
		With grdWS
			For i = 1 To .Rows - 1
				.Row = i
				'           quit if you hit a blank depth
				.Col = 1
				If .Text = "" Then Exit For
				NameID = .Text
				.Col = 2
				If .Text = "" Then
					X = 0#
				Else
					X = CDbl(.Text) / LFactor
				End If
				.Col = 3
				If .Text = "" Then
					Y = 0#
				Else
					Y = CDbl(.Text) / LFactor
				End If
				.Col = 4
				If .Text = "" Then Exit For
				Depth = CDbl(.Text) / LFactor
				WriteLine(FileNum, NameID, X, Y, Depth)
			Next i
		End With
		
	End Sub
End Class