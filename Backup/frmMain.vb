Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMain
	Inherits System.Windows.Forms.Form
	' frmMain           form of main window
	' Version 2.0
	' 2001, Copyright DTCEL, All Rights Reserved
	
	
	' for messages
	Private msgNotSavedWarning As String
	Private Const msgInputWarning As String = "The input file has not been read properly. " & " It may be corrupted. Please check data closely."
	Private Const msgNoFileWarning As String = "Cannot find the specifiied input file."
	Private msgOutputWarning As String
	
	' for form operations
	Private NumProj As Short
	
	Private CheckingGrid As Boolean
	Private FirstLoad As Boolean
	Public PlotShow As Boolean
	
	' summary
	' for grid
	Private LDLabels(11, 1) As String
	Private ELLabels(4) As String
	
	Private NumLines As Short
	Private FMGlob As Force
	
	Private Sub btnEnv_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnEnv.Click
		mnuInpEnviron_Click(mnuInpEnviron, New System.EventArgs())
	End Sub
	
	
	
	' form load and unload
	
	Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		IsMetricUnit = False
		
		'UPGRADE_NOTE: FileOpen was upgraded to FileOpen_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim i As Short
		Dim FileOpen_Renamed As Boolean
		
		On Error GoTo ErrorHandler
		
		InitProject()
		FileOpen_Renamed = False
		
		NumProj = 1
		With CurProj
			CurVessel = .Vessel
			CurField = .WellSites
			CurVessel.Name = .Vessel.Name
			lblVessel.Text = UCase(CurVessel.Name)
			
			.Title = "Project" & NumProj
			Text = " MARS Console - " & .Title
			.Saved = True
			'        If Not .VesselParticular Then
			'            MsgBox "MARS is unable to load vessel particulars. Press OK to quit!", _
			''                vbOKOnly, msgTitle
			'            GoTo ErrorHandler
			'        End If
		End With
		
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Len(Dir(MarsDir & IniFile)) > 0 Then
			FileOpen(10, MarsDir & IniFile, OpenMode.Input, OpenAccess.Read)
			FileOpen_Renamed = True
			If Defaults.InputData(10) Then
				UpdateFileMenu()
				UpdateMenu()
				CurProj.Directory = Defaults.WorkDir
			End If
			FileClose(10)
			FileOpen_Renamed = False
		End If
		
		FMGlob = New Force
		NumLines = CurVessel.MoorSystem.MoorLineCount
		
		PlotShow = False
		InitSummary()
		UpdateFileMenu()
		UpdateMenu()
		LoadData(True)
		RefreshUnitLabels(Me)
		Exit Sub
		
ErrorHandler: 
		If FileOpen_Renamed Then FileClose(10)
		Cursor = System.Windows.Forms.Cursors.Default
		Me.Close()
		
	End Sub
	
	Private Sub frmMain_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		
		Dim i As Short
		
		If CurProj.Saved = False Then
			If CurProj.Title = "" Then
				msgNotSavedWarning = "Do you want to save changes made to " & " the current project ?"
			Else
				msgNotSavedWarning = "Do you want to save changes made to " & CurProj.Title & " ?"
			End If
			
			Select Case MsgBox(msgNotSavedWarning, MsgBoxStyle.YesNoCancel, msgTitle)
				Case MsgBoxResult.Yes
					'           save
					mnuFileSave_Click(mnuFileSave, New System.EventArgs())
					Defaults.AddPreFile(CurProj.Directory & CurProj.FileName)
				Case MsgBoxResult.No
					If CurProj.FileName <> "" Then Defaults.AddPreFile(CurProj.Directory & CurProj.FileName)
				Case MsgBoxResult.Cancel
					'           do nothing
					Cancel = True
			End Select
		Else
			With CurProj
				If .FileName <> "" Then Defaults.AddPreFile(.Directory & .FileName)
			End With
		End If
		
		' Loop through the forms collection and unload
		' each form.
		If Not Cancel Then
			On Error Resume Next
			For i = My.Application.OpenForms.Count - 1 To 0 Step -1
				'UPGRADE_ISSUE: Unload Forms() was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
				Unload(My.Application.OpenForms(i))
			Next 
			
			Defaults.WorkDir = CurProj.Directory
			FileOpen(20, MarsDir & IniFile, OpenMode.Output)
			If Not Defaults.OutputData(20) Then
				
			End If
			FileClose(20)
			
			'Destroy existing case and leave
			'UPGRADE_NOTE: Object CurProj may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			CurProj = Nothing
			'UPGRADE_NOTE: Object FMGlob may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			FMGlob = Nothing
		End If
		
		eventArgs.Cancel = Cancel
	End Sub
	
	' buttons
	
	Private Sub btnPlot_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPlot.Click
		Dim Index As Short = btnPlot.GetIndex(eventSender)
		
		With frmPlot
			Select Case Index
				Case 0
					If Not PlotShow Then .Show()
					.PlotIn3D = True
				Case 1
					If Not PlotShow Then .Show()
					.PlotIn3D = False
			End Select
			.UpdatePicture()
		End With
		
	End Sub
	
	Private Sub btnMooring_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnMooring.Click
		
		VB6.ShowForm(frmMoorLines, 1, Me)
		NumLines = CurVessel.MoorSystem.MoorLineCount
		UpdateMenu()
		RefreshData()
		
	End Sub
	
	Private Sub btnWell_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnWell.Click
		
		Dim NumWells As Short
		Dim i As Short
		
		VB6.ShowForm(frmWells, 1, Me)
		
		NumWells = CurField.Count
		With CurField
			cboWells.Items.Clear()
			For i = 1 To NumWells
				cboWells.Items.Add(.Item(i).NameID)
			Next i
			cboWells.SelectedIndex = .CurWellNo - 1
			With .Item(.CurWellNo)
				txtWell(0).Text = VB6.Format(.Xg * LFactor, "0.0")
				txtWell(1).Text = VB6.Format(.Yg * LFactor, "0.0")
				If .Depth > 0# Then CurVessel.WaterDepth = .Depth
				txtWell(2).Text = VB6.Format(CurVessel.WaterDepth * LFactor, "0.0")
			End With
		End With
		
	End Sub
	
	Private Sub btnUpdate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnUpdate.Click
		SaveLC()
		InitSummary()
		LoadData(False)
	End Sub
	
	Private Sub frmMain_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		' make sure all forms are unloaded first
		' any referenced form would remain in memory even if invisible
		Dim frm As System.Windows.Forms.Form
		For	Each frm In My.Application.OpenForms
			If Not frm Is Me Then frm.Close()
		Next frm
		End
	End Sub
	
	
	Public Sub mnu3DPlot_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu3DPlot.Click
		Call btnPlot_Click(btnPlot.Item(0), New System.EventArgs())
	End Sub
	
	' menus
	
	Public Sub mnuFileNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileNew.Click
		
		If CurProj.Saved = False Then
			If CurProj.Title = "" Then
				msgNotSavedWarning = "Do you want to save changes made to " & " the current project ?"
			Else
				msgNotSavedWarning = "Do you want to save changes made to " & CurProj.Title & " ?"
			End If
			
			Select Case MsgBox(msgNotSavedWarning, MsgBoxStyle.YesNoCancel, msgTitle)
				Case MsgBoxResult.Yes
					'           save
					mnuFileSave_Click(mnuFileSave, New System.EventArgs())
					If CurProj.FileName <> "" Then Defaults.AddPreFile(CurProj.Directory & CurProj.FileName)
				Case MsgBoxResult.No
					If CurProj.FileName <> "" Then Defaults.AddPreFile(CurProj.Directory & CurProj.FileName)
				Case MsgBoxResult.Cancel
					'           do nothing
					Exit Sub
			End Select
		Else
			With CurProj
				If .FileName <> "" Then Defaults.AddPreFile(.Directory & .FileName)
			End With
		End If
		UpdateFileMenu()
		
		'UPGRADE_NOTE: Object CurProj may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		CurProj = Nothing
		ClearScreenData()
		frmMain_Load(Me, New System.EventArgs())
		
		VB6.ShowForm(frmProjDesc, 1, Me)
		
	End Sub
	
	Public Sub mnuFileOpen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileOpen.Click
		
		'UPGRADE_NOTE: FileOpen was upgraded to FileOpen_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim FileOpen_Renamed As Boolean
		
		
		'   should the user cancel the dialog box, exit
		On Error GoTo ErrHandler
		
		FileOpen_Renamed = False
		
		'   save the current project
		If CurProj.Saved = False Then
			If CurProj.Title = "" Then
				msgNotSavedWarning = "Do you want to save changes made to " & " the current project ?"
			Else
				msgNotSavedWarning = "Do you want to save changes made to " & CurProj.Title & " ?"
			End If
			
			Select Case MsgBox(msgNotSavedWarning, MsgBoxStyle.YesNoCancel, msgTitle)
				Case MsgBoxResult.Yes
					'           save
					mnuFileSave_Click(mnuFileSave, New System.EventArgs())
					If CurProj.FileName <> "" Then Defaults.AddPreFile(CurProj.Directory & CurProj.FileName)
				Case MsgBoxResult.No
					If CurProj.FileName <> "" Then Defaults.AddPreFile(CurProj.Directory & CurProj.FileName)
				Case MsgBoxResult.Cancel
					'           do nothing
					Exit Sub
			End Select
		Else
			With CurProj
				If .FileName <> "" Then Defaults.AddPreFile(.Directory & .FileName)
			End With
		End If
		UpdateFileMenu()
		
		'   get input file name
		Dim CatFile As String
		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
		With dlgFile
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			.CancelError = True
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			.Filter = "All Files (*.*)|*.*|MARS Files (*.mrs)|*.mrs"
			.FilterIndex = 2
			If CurProj.Directory = "" Then
				.InitialDirectory = MarsDir
			Else
				.InitialDirectory = CurProj.Directory
			End If
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			.ShowReadOnly = False
			'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			.CheckFileExists = True
			.CheckPathExists = True
			.CheckPathExists = True
			.ShowDialog()
			
			Cursor = System.Windows.Forms.Cursors.WaitCursor
			'UPGRADE_NOTE: Object CurProj may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			CurProj = Nothing
			CurProj = New Project
			
			ClearScreenData()
			
			With CurProj
				CurVessel = .Vessel
				CurField = .WellSites
				
				.GetDirNFileName(dlgFileOpen.FileName)
				Text = " MARS Console - " & .Title & " (" & .FileName & ")"
				
				If .ImportData(dlgFileOpen.FileName) Then
					CurVessel.Name = .Vessel.Name
					lblVessel.Text = .Vessel.Name
					.Saved = True
					If Not .VesselParticular Then
						MsgBox("MARS is unable to load vessel particulars.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, msgTitle)
						'   Unload Me
					End If
				Else
					MsgBox(msgInputWarning, MsgBoxStyle.OKOnly, msgTitle)
					.Saved = False
				End If
			End With
			FileOpen_Renamed = False
			
			NumLines = CurVessel.MoorSystem.MoorLineCount
			UpdateMenu()
			LoadData(True)
			
			CatFile = MarsDir & CatenaryFile
			Call CurVessel.MoorSystem.GenCatenaryFile(CatFile)
			
			Cursor = System.Windows.Forms.Cursors.Default
		End With
		
		Exit Sub
		
ErrHandler: 
		'   User pressed Cancel button
		UpdateMenu()
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Public Sub mnuFileSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileSave.Click
		SaveLC()
		
		'UPGRADE_NOTE: FileOpen was upgraded to FileOpen_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim FileOpen_Renamed As Boolean
		Dim FileNum As Integer
		
		On Error GoTo ErrorHandler
		
		FileOpen_Renamed = False
		FileNum = FreeFile
		
		With CurProj
			If .FileName = "" Then
				mnuFileSaveAs_Click(mnuFileSaveAs, New System.EventArgs())
			Else
				FileOpen(FileNum, .Directory & .FileName, OpenMode.Output)
				FileOpen_Renamed = True
				Cursor = System.Windows.Forms.Cursors.WaitCursor
				If Not .ExportData(FileNum) Then
				End If
				Cursor = System.Windows.Forms.Cursors.Default
				FileClose(FileNum)
				FileOpen_Renamed = False
				.Saved = True
			End If
		End With
		
		Exit Sub
		
ErrorHandler: 
		FileClose(FileNum)
		Cursor = System.Windows.Forms.Cursors.Default
		Exit Sub
		
	End Sub
	
	Public Sub mnuFileSaveAs_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileSaveAs.Click
		SaveLC()
		'UPGRADE_NOTE: FileOpen was upgraded to FileOpen_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim FileOpen_Renamed As Boolean
		
		'   should the user cancel the dialog box, exit
		On Error GoTo ErrHandler
		
		FileOpen_Renamed = False
		
		'   get file name
		Dim fnum As Integer
		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
		With dlgFile
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			.CancelError = True
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			.Filter = "All Files (*.*)|*.*|MARS Files (*.mrs)|*.mrs"
			.FilterIndex = 2
			If CurProj.Directory = "" Then
				.InitialDirectory = MarsDir
			Else
				.InitialDirectory = CurProj.Directory
			End If
			If CurProj.FileName <> "" Then
				.FileName = CurProj.FileName
			Else
				.FileName = CurProj.Title & ".mrs"
			End If
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileSave.OverwritePrompt which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			.OverwritePrompt = True
			'UPGRADE_WARNING: MSComDlg.CommonDialog property dlgFile.Flags was upgraded to dlgFileOpen.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			'UPGRADE_WARNING: FileOpenConstants constant FileOpenConstants.cdlOFNHideReadOnly was upgraded to OpenFileDialog.ShowReadOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			.ShowReadOnly = False
			.ShowDialog()
			
			'       save data
			fnum = FreeFile
			FileOpen(fnum, .FileName, OpenMode.Output)
			FileOpen_Renamed = True
			
			Cursor = System.Windows.Forms.Cursors.WaitCursor
			With CurProj
				If .FileName <> "" Then
					Defaults.AddPreFile(.Directory & .FileName)
					UpdateFileMenu()
				End If
				
				.GetDirNFileName(dlgFileOpen.FileName)
				Text = " MARS Console - " & .Title & " (" & .FileName & ")"
				
				If Not .ExportData(fnum) Then
				End If
				Cursor = System.Windows.Forms.Cursors.Default
				.Saved = True
			End With
			FileClose(fnum)
			FileOpen_Renamed = False
		End With
		
		Exit Sub
		
ErrHandler: 
		'   User pressed Cancel button
		If FileOpen_Renamed Then FileClose(fnum)
		Cursor = System.Windows.Forms.Cursors.Default
		If Err.Number <> 32755 Then ' don't report cancel dialog error
			MsgBox("Error " & Err.Description & ",  Source: " & Err.Source, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Error")
		End If
	End Sub
	
	Public Sub mnuFilePrintSetup_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFilePrintSetup.Click
		
		'UPGRADE_ISSUE: Constant cdlPDPrintSetup was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: MSComDlg.CommonDialog property dlgFile.Flags was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		dlgFile.Flags = MSComDlg.PrinterConstants.cdlPDPrintSetup
		dlgFilePrint.ShowDialog()
		
	End Sub
	
	Public Sub mnuFilePre_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFilePre.Click
		Dim Index As Short = mnuFilePre.GetIndex(eventSender)
		
		'UPGRADE_NOTE: FileOpen was upgraded to FileOpen_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim InputFile As String
		Dim FileOpen_Renamed As Boolean
		
		'   should the user cancel the dialog box, exit
		On Error GoTo ErrHandler
		
		FileOpen_Renamed = False
		
		'   save the current project
		If CurProj.Saved = False Then
			If CurProj.Title = "" Then
				msgNotSavedWarning = "Do you want to save changes made to " & " the current project ?"
			Else
				msgNotSavedWarning = "Do you want to save changes made to " & CurProj.Title & " ?"
			End If
			
			Select Case MsgBox(msgNotSavedWarning, MsgBoxStyle.YesNoCancel, msgTitle)
				Case MsgBoxResult.Yes
					'           save
					mnuFileSave_Click(mnuFileSave, New System.EventArgs())
					If CurProj.FileName <> "" Then Defaults.AddPreFile(CurProj.Directory & CurProj.FileName)
				Case MsgBoxResult.No
					If CurProj.FileName <> "" Then Defaults.AddPreFile(CurProj.Directory & CurProj.FileName)
					'           do nothing
				Case MsgBoxResult.Cancel
					Exit Sub
			End Select
		Else
			With CurProj
				If .FileName <> "" Then Defaults.AddPreFile(.Directory & .FileName)
			End With
		End If
		
		'   input from file
		'  InputFile = Defaults.PreFile(Index + 1)
		InputFile = VB.Right(mnuFilePre(Index).Text, Len(mnuFilePre(Index).Text) - 3)
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Len(Dir(InputFile)) <= 0 Then
			MsgBox(msgNoFileWarning, MsgBoxStyle.OKOnly, msgTitle)
			Defaults.DelPreFile(Index + 1)
			UpdateFileMenu()
			Exit Sub
		End If
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		'UPGRADE_NOTE: Object CurProj may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		CurProj = Nothing
		CurProj = New Project
		ClearScreenData()
		
		With CurProj
			.GetDirNFileName(InputFile)
			Text = " MARS Console - " & .Title & " (" & .FileName & ")"
			
			If .ImportData(InputFile) Then
				.Saved = True
				CurVessel = .Vessel
				CurField = .WellSites
				lblVessel.Text = .Vessel.Name
				CurVessel.Name = .Vessel.Name
				lblVessel.Text = CurVessel.Name
				If Not .VesselParticular Then
					MsgBox("MARS is unable to load vessel particulars.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, msgTitle)
					'  Unload Me
				End If
			Else
				MsgBox(msgInputWarning, MsgBoxStyle.OKOnly, msgTitle)
				.Saved = False
			End If
		End With
		Cursor = System.Windows.Forms.Cursors.Default
		
		NumLines = CurVessel.MoorSystem.MoorLineCount
		UpdateMenu()
		LoadData(True)
		' force catenary output
		Dim CatFile As String
		CatFile = MarsDir & CatenaryFile
		Call CurVessel.MoorSystem.GenCatenaryFile(CatFile)
		Exit Sub
		
ErrHandler: 
		'   User pressed Cancel button
		Cursor = System.Windows.Forms.Cursors.Default
		MsgBox("mnuFilePre: " & Err.Description & ", Source: " & Err.Source, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Error")
	End Sub
	
	Public Sub mnuFileExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileExit.Click
		
		Me.Close()
		
	End Sub
	
	Public Sub mnuInpEnviron_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuInpEnviron.Click
		
		VB6.ShowForm(frmEnviron, 1, Me)
		
	End Sub
	
	Public Sub mnuInpMoor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuInpMoor.Click
		
		btnMooring_Click(btnMooring, New System.EventArgs())
		
	End Sub
	
	Public Sub mnuInpProjDes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuInpProjDes.Click
		
		VB6.ShowForm(frmProjDesc, 1, Me)
		
	End Sub
	
	Public Sub mnuMoor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuMoor.Click
		
		Me.Enabled = False
		SaveLC()
		VB6.ShowForm(frmAnalyses,  , Me)
		
	End Sub
	
	Public Sub mnuAnalysesB_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAnalysesB.Click
		
		Me.Enabled = False
		VB6.ShowForm(frmAnalysesB,  , Me)
		
	End Sub
	
	Public Sub mnuMoorLayoutReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuMoorLayoutReport.Click
		' check if has data
		If CurVessel.MoorSystem.MoorLineCount = 0 Then
			MsgBox("Mooring system is not yet defined.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Error")
			Exit Sub
		End If
		
		Dim ox As New ExcelReporter
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		ox.ReportMooringLayout(txtClientName.Text, txtLocationName.Text, CurVessel)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Public Sub mnuMove_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuMove.Click
		
		VB6.ShowForm(frmMove, 1, Me)
		
	End Sub
	
	Public Sub mnuOnBoard_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOnBoard.Click
		
		If Not OnBoardData Then MsgBox("Data export failure.", MsgBoxStyle.OKOnly, msgTitle)
		
	End Sub
	
	Public Sub mnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Click
		
		VB6.ShowForm(frmAbout, 1, Me)
		
	End Sub
	
	' combo box
	
	'UPGRADE_WARNING: Event cboWells.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboWells_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWells.SelectedIndexChanged
		
		Dim Distance, Bearing As Double
		Dim ShipLoc As New ShipGlobal
		
		With CurField
			.CurWellNo = cboWells.SelectedIndex + 1
			With .Item(.CurWellNo)
				txtWell(0).Text = VB6.Format(.Xg * LFactor, "0.0")
				txtWell(1).Text = VB6.Format(.Yg * LFactor, "0.0")
				If .Depth > 0# Then CurVessel.WaterDepth = .Depth
				txtWell(2).Text = VB6.Format(CurVessel.WaterDepth * LFactor, "0.0")
			End With
		End With
		
		With CurVessel
			If optInputSystem(0).Checked Then
				With ShipLoc
					.Xg = CDbl(VB6.Format(CDbl(CheckData(CStr(Val(txtVslSt(0).Text)),  , True)) / LFactor, "0.00"))
					.Yg = CDbl(VB6.Format(CDbl(CheckData(CStr(Val(txtVslSt(1).Text)),  , True)) / LFactor, "0.00"))
					.Heading = CDbl(CheckData(CStr(Val(txtVslSt(4).Text)),  , True)) * Degrees2Radians
				End With
				Coord2Bear(ShipLoc, Distance, Bearing)
				txtVslSt(2).Text = VB6.Format(Distance * LFactor, "0.0")
				txtVslSt(3).Text = VB6.Format(Bearing * Radians2Degrees, "0.00")
			Else
				Distance = CDbl(CheckData(CStr(Val(txtVslSt(2).Text) / LFactor),  , True))
				Bearing = CDbl(CheckData(CStr(Val(txtVslSt(3).Text)),  , True)) * Degrees2Radians
				Bear2Coord(ShipLoc, Distance, Bearing)
				With ShipLoc
					txtVslSt(0).Text = VB6.Format(.Xg * LFactor, "0.0")
					txtVslSt(1).Text = VB6.Format(.Yg * LFactor, "0.0")
					.Heading = CDbl(CheckData(txtVslSt(4).Text,  , True)) * Degrees2Radians
				End With
			End If
		End With
		
		txtLocationName.Text = cboWells.Text
		'UPGRADE_NOTE: Object ShipLoc may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		ShipLoc = Nothing
		If Not FirstLoad Then CurProj.Saved = False
		
	End Sub
	
	Function GetDampingPercent(ByVal WaterDepth As Double) As Object
		
		' by experience on chain-rig wire system
		Dim Val2, Val1, BaseVal As Double
		
		If WaterDepth < 1000 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object GetDampingPercent. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetDampingPercent = 10
			Exit Function
		ElseIf WaterDepth >= 1000 And WaterDepth < 2000 Then 
			Val1 = 1000
			Val2 = 2000
			BaseVal = 10
		ElseIf WaterDepth >= 2000 And WaterDepth < 3000 Then 
			Val1 = 2000
			Val2 = 3000
			BaseVal = 20
		ElseIf WaterDepth >= 3000 And WaterDepth < 4000 Then 
			Val1 = 3000
			Val2 = 4000
			BaseVal = 30
		ElseIf WaterDepth >= 4000 And WaterDepth < 5000 Then 
			Val1 = 4000
			Val2 = 5000
			BaseVal = 40
		ElseIf WaterDepth >= 5000 Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object GetDampingPercent. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetDampingPercent = 50
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object GetDampingPercent. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetDampingPercent = (WaterDepth - Val1) / (Val2 - Val1) * 10 + BaseVal
	End Function
	
	
	Private Sub SetLblSummary()
		
		LDLabels(0, 0) = "Line No."
		LDLabels(1, 0) = "Top Tension"
		LDLabels(2, 0) = "Line FOS"
		LDLabels(3, 0) = "Payout"
		LDLabels(4, 0) = "Top Angle"
		LDLabels(5, 0) = "Local Spread Angle"
		LDLabels(6, 0) = "Grounded Length"
		LDLabels(7, 0) = "Anchor Tension"
		LDLabels(8, 0) = "Anchor FOS"
		'    LDLabels(9, 0) = "Horizontal Distance"
		LDLabels(9, 0) = "Scope"
		LDLabels(10, 0) = "Connected"
		LDLabels(11, 0) = "Winch Functional"
		
		LDLabels(0, 1) = ""
		LDLabels(2, 1) = ""
		LDLabels(8, 1) = ""
		LDLabels(10, 1) = ""
		LDLabels(11, 1) = ""
		LDLabels(4, 1) = "(deg)"
		LDLabels(5, 1) = "(deg)"
		
		If IsMetricUnit Then
			LDLabels(1, 1) = "(KN)"
			LDLabels(3, 1) = "(m)"
			LDLabels(6, 1) = "(m)"
			LDLabels(7, 1) = "(KN)"
			LDLabels(9, 1) = "(m)"
		Else
			LDLabels(1, 1) = "(kips)"
			LDLabels(3, 1) = "(ft)"
			LDLabels(6, 1) = "(ft)"
			LDLabels(7, 1) = "(kips)"
			LDLabels(9, 1) = "(ft)"
		End If
	End Sub
	
	Private Sub ClearScreenData()
		Dim i, j As Short
		With grdLD
			For i = .FixedRows To .Rows - 1
				For j = .FixedCols To .Cols - 1
					.set_TextMatrix(i, j, "")
				Next j
			Next i
		End With
		With grdEL
			For i = .FixedRows To .Rows - 1
				For j = .FixedCols To .Cols - 1
					.set_TextMatrix(i, j, "")
				Next j
			Next i
		End With
		txtWell(0).Text = "0"
		txtWell(1).Text = "0"
		txtWell(2).Text = "0"
		txtVslSt(0).Text = "0"
		txtVslSt(1).Text = "0"
		txtVslSt(4).Text = "0"
		txtVslSt(5).Text = "0"
		txtVslSt(2).Text = "0"
		txtVslSt(3).Text = "0"
		cboWells.Items.Clear()
		cboWells.Items.Add("DEFAULT")
		cboWells.SelectedIndex = 0
	End Sub
	
	Private Sub InitSummary()
		
		Dim r, c As Short
		Dim ColW As Double
		Dim RShown, RowH, BarSize As Short
		Dim WAdj, WAdj0 As Short
		
		CheckingGrid = True
		
		Call SetLblSummary()
		If NumLines > 8 Then
			BarSize = SysInfo1.ScrollBarSize
			WAdj0 = 1
			WAdj = 10
		Else
			BarSize = 0
			WAdj0 = 15
			WAdj = 100
		End If
		
		With grdLD
			.Clear()
			.Rows = Max(10, NumLines + 2)
			.WordWrap = True
			.Cols = UBound(LDLabels) + 1
			ColW = (VB6.PixelsToTwipsX(.Width) - BarSize) / (.Cols - 0.5) - WAdj0
			RowH = VB6.PixelsToTwipsY(.Height) / 11 - .GridLineWidth
			.set_ColWidth(0, VB6.PixelsToTwipsX(.Width) - BarSize - ColW * (.Cols - 1) - WAdj)
			.set_RowHeight(0, VB6.PixelsToTwipsY(.Height) - RowH * 8.9 - 100)
			.set_RowHeight(1, RowH * 0.9)
			
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
					.Text = LDLabels(c, r)
				Next c
			Next r
			For r = .FixedRows To .Rows - 1
				.Row = r
				For c = .FixedCols To .Cols - 1
					.Col = c
					.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
				Next c
			Next r
			
			.Col = 0
			.Row = 0
		End With
		
		'' ---------  Initialize Mooring Forces Grid ---------------
		
		SetLblMoorForce()
		
		With grdEL
			.WordWrap = True
			
			ColW = VB6.PixelsToTwipsX(.Width) / (.Cols + 0.2) - .GridLineWidth
			RowH = VB6.PixelsToTwipsY(.Height) / 2.5 - .GridLineWidth
			.set_ColWidth(0, VB6.PixelsToTwipsX(.Width) - ColW * (.Cols - 1) - 110)
			.set_RowHeight(0, VB6.PixelsToTwipsY(.Height) - RowH - 90)
			
			For c = 1 To .Cols - 1
				.set_ColWidth(c, ColW)
			Next c
			For r = .FixedRows To .Rows - 1
				.set_RowHeight(r, RowH)
			Next r
			
			.Col = 0
			.Row = 1
			.Text = ELLabels(4)
			.Row = 0
			For c = 0 To .Cols - 1
				.Col = c
				.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
				.Text = ELLabels(c)
			Next c
			
			.Col = 0
			.Row = 0
		End With
		
		CheckingGrid = False
		
	End Sub
	
	Private Sub SetLblMoorForce()
		ELLabels(0) = "Direction"
		If IsMetricUnit Then
			ELLabels(1) = "x (E) (KN)"
			ELLabels(2) = "y (N) (KN)"
			ELLabels(3) = "Yaw (KN-m)"
		Else
			ELLabels(1) = "x (E) (kips)"
			ELLabels(2) = "y (N) (kips)"
			ELLabels(3) = "Yaw (Kips-ft)"
		End If
		ELLabels(4) = "Mooring Forces"
	End Sub
	
	' update menu
	
	Private Sub UpdateMenu()
		
		With CurVessel.MoorSystem
			If .MoorLineCount < 1 Then
				btnUpdate.Enabled = False
				'      btnOnBoard.Enabled = False
				mnuOnBoard.Enabled = False
				mnuMoor.Enabled = False
				mnuTransient.Enabled = False
				mnuAnalysesB.Enabled = False
				mnuMove.Enabled = False
				'    btnAnalyze.Enabled = False
			Else
				btnUpdate.Enabled = True
				mnuMoor.Enabled = True
				mnuAnalysesB.Enabled = True
				mnuTransient.Enabled = True
				mnuMove.Enabled = True
				'       btnAnalyze.Enabled = True
				If .MoorLineCount < 2 Then
					mnuMove.Enabled = False
				Else
					mnuMove.Enabled = True
				End If
			End If
		End With
		
	End Sub
	
	Private Sub UpdateFileMenu()
		
		Dim i, NumPreFiles As Short
		
		NumPreFiles = Defaults.CountPreFile
		
		If NumPreFiles > 0 Then mnuLinePreFile.Visible = True
		For i = 1 To NumPreFiles Step 1
			With mnuFilePre(i - 1)
				.Text = i & ". " & Defaults.PreFile(i)
				.Enabled = True
				.Visible = True
			End With
		Next i
		For i = NumPreFiles + 1 To MaxNumPreFiles Step 1
			With mnuFilePre(i - 1)
				.Text = ""
				.Enabled = False
				.Visible = False
			End With
		Next i
		
	End Sub
	
	Public Sub LoadData(Optional ByRef FirstTime As Boolean = False)
		
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
		Else
			LFactor = 1
			FrcFactor = 1
		End If
		
		Dim c, r, i As Short
		Dim NumWells As Short
		Dim Distance, Bearing As Double
		'UPGRADE_NOTE: Dir was upgraded to Dir_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim HD, Dir_Renamed As Double
		Dim ShipCurLoc As ShipGlobal
		
		Dim CurLine As MoorLine
		
		NumWells = CurField.Count
		If FirstTime Then FirstLoad = True
		With CurField
			cboWells.Items.Clear()
			For i = 1 To NumWells
				cboWells.Items.Add(.Item(i).NameID)
			Next i
			cboWells.SelectedIndex = .CurWellNo - 1
			With .Item(.CurWellNo)
				txtWell(0).Text = VB6.Format(.Xg * LFactor, "0.0")
				txtWell(1).Text = VB6.Format(.Yg * LFactor, "0.0")
				If .Depth > 0# Then CurVessel.WaterDepth = .Depth
				txtWell(2).Text = VB6.Format(CurVessel.WaterDepth * LFactor, "0.0")
			End With
		End With
		
		With CurVessel
			With .ShipCurGlob
				txtVslSt(0).Text = VB6.Format(.Xg * LFactor, "0.00")
				txtVslSt(1).Text = VB6.Format(.Yg * LFactor, "0.00")
				txtVslSt(4).Text = VB6.Format(RadTo360(.Heading), "0.00")
			End With
			
			'        With .ShipDesGlob
			'            Debug.Print Format(.Xg * LFactor, "0.00")
			'            Debug.Print Format(.Yg * LFactor, "0.00")
			'            Debug.Print Format(.Heading * Radians2Degrees, "0.00")
			'        End With
			
			txtVslSt(5).Text = VB6.Format(.ShipDraft * LFactor, "0.00")
			
			Coord2Bear(.ShipCurGlob, Distance, Bearing)
			txtVslSt(2).Text = VB6.Format(Distance * LFactor, "0.0")
			txtVslSt(3).Text = VB6.Format(Bearing * Radians2Degrees, "0.00")
			
			.MoorSystem.MoorForce(FMGlob, (CurVessel.ShipCurGlob))
		End With
		
		Dim HorForce As Double ' output
		Dim Scope As Double
		
		InitSummary()
		With grdLD
			For r = 1 To NumLines
				CurLine = CurVessel.MoorSystem.MoorLines(r)
				.Row = r + 1
				If CurLine.Connected Then
					'                With CurLine
					'                    GetHorDist HD, Dir, .Scope(ShipCurLoc), .SprdAngle(ShipCurLoc), _
					''                        .FairLead.Xs, .FairLead.Ys
					'                End With
					.Col = 3
					.Text = VB6.Format(CurLine.Payout * LFactor, "0.0")
					.Col = 9
					'                .Text = Format(HD * LFactor, "0.0")
					Scope = CurLine.ScopeByVesselLocation((CurVessel.ShipCurGlob))
					.Text = VB6.Format(Scope * LFactor, "0.0")
					.Col = 1
					.Text = VB6.Format(CurLine.TensionByScopePOL(Scope, HorForce, (CurLine.Payout)) * 0.001 * FrcFactor, "0.00")
					.Col = 2
					.Text = VB6.Format(CurLine.FOS, "0.00")
					.Col = 4
					.Text = VB6.Format(CurLine.FLAngle * Radians2Degrees, "0.00")
					.Col = 5
					.Text = VB6.Format(CurLine.SprdAngle(ShipCurLoc) * Radians2Degrees, "0.00")
					'                .Text = Format(Dir * Radians2Degrees, "0.00")
					.Col = 6
					.Text = VB6.Format(CurLine.GrdLen * LFactor, "0.0")
					.Col = 7
					.Text = VB6.Format(CurLine.AnchPull * 0.001 * FrcFactor, "0.0")
					.Col = 8
					.Text = CurLine.AnchorFOS
					.Col = 10
					.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
					.Text = "Yes"
					.Col = 11
					.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
					If CurLine.Winched Then
						.Text = "Yes"
					Else
						.Text = "No"
					End If
					
				Else
					.Col = 1
					.Text = "--"
					.Col = 2
					.Text = "--"
					.Col = 3
					.Text = "--"
					.Col = 4
					.Text = "--"
					.Col = 5
					.Text = "--"
					.Col = 6
					.Text = "--"
					.Col = 7
					.Text = "--"
					.Col = 8
					.Text = "--"
					.Col = 9
					.Text = "--"
					.Col = 10
					.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
					.Text = "No"
					.Col = 11
					.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
					If CurLine.Winched Then
						.Text = "Yes"
					Else
						.Text = "No"
					End If
				End If
			Next r
		End With
		
		
		With grdEL
			.Row = 1
			.Col = 1
			.Text = VB6.Format(FMGlob.Fx * 0.001 * FrcFactor, "0.0")
			.Col = 2
			.Text = VB6.Format(FMGlob.Fy * 0.001 * FrcFactor, "0.0")
			.Col = 3
			.Text = VB6.Format(FMGlob.MYaw * 0.001 * FrcFactor * LFactor, "0.0")
		End With
		
		'   btnOnBoard.Enabled = True
		mnuOnBoard.Enabled = True
		
		' Update Catenary file
		CurVessel.MoorSystem.GenCatenaryFile(MarsDir & CatenaryFile)
		
		If PlotShow Then frmPlot.UpdatePicture()
		
	End Sub
	
	Public Sub SaveLC()
		
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
		Else
			LFactor = 1
			FrcFactor = 1
		End If
		
		
		Dim r As Short
		Dim Distance, Bearing As Double
		
		With CurVessel
			If optInputSystem(0).Checked Then
				With .ShipCurGlob
					.Xg = CDbl(VB6.Format(CDbl(CheckData(CStr(Val(txtVslSt(0).Text)),  , True)) / LFactor, "0.00"))
					.Yg = CDbl(VB6.Format(CDbl(CheckData(CStr(Val(txtVslSt(1).Text)),  , True)) / LFactor, "0.00"))
					.Heading = CDbl(CheckData(CStr(Val(txtVslSt(4).Text)),  , True)) * Degrees2Radians
				End With
				Coord2Bear(.ShipCurGlob, Distance, Bearing)
				txtVslSt(2).Text = VB6.Format(Distance * LFactor, "0.0")
				txtVslSt(3).Text = VB6.Format(Bearing * Radians2Degrees, "0.00")
			Else
				Distance = CDbl(CheckData(CStr(Val(txtVslSt(2).Text) / LFactor),  , True))
				Bearing = CDbl(CheckData(CStr(Val(txtVslSt(3).Text)),  , True)) * Degrees2Radians
				Bear2Coord(.ShipCurGlob, Distance, Bearing)
				With .ShipCurGlob
					txtVslSt(0).Text = VB6.Format(.Xg * LFactor, "0.0")
					txtVslSt(1).Text = VB6.Format(.Yg * LFactor, "0.0")
					.Heading = CDbl(CheckData(txtVslSt(4).Text,  , True)) * Degrees2Radians
				End With
			End If
			.ShipDraft = CDbl(CheckData(CStr(Val(txtVslSt(5).Text) / LFactor),  , True))
		End With
		
	End Sub
	
	Private Function OnBoardData() As Boolean
		
		'UPGRADE_NOTE: FileOpen was upgraded to FileOpen_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim r As Short
		Dim FileOpen_Renamed As Boolean
		Dim CurLine As MoorLine
		
		OnBoardData = False
		
		On Error GoTo ErrorHandler
		FileOpen_Renamed = False
		FileOpen(FileNumRes, MarsDir & OnBoardFile, OpenMode.Output)
		FileOpen_Renamed = True
		
		For r = 1 To NumLines
			With CurVessel.MoorSystem.MoorLines(r)
				If .Connected Then
					PrintLine(FileNumRes, r, .Payout, .TopTension * 0.001, .FLAngle * Radians2Degrees, .SprdAngle((CurVessel.ShipCurGlob)) * Radians2Degrees)
				Else
					PrintLine(FileNumRes, r, 0#, 0#, 0#, 0#)
				End If
			End With
		Next r
		
		FileClose(FileNumRes)
		FileOpen_Renamed = False
		OnBoardData = True
		Exit Function
		
ErrorHandler: 
		If FileOpen_Renamed Then FileClose(FileNumRes)
		Exit Function
		
	End Function
	
	Private Sub Coord2Bear(ByRef ShipGlob As ShipGlobal, ByRef Distance As Double, ByRef Bearing As Double)
		
		Dim dx, dy As Double
		
		With CurField
			dx = ShipGlob.Xg - .Item(.CurWellNo).Xg
			dy = ShipGlob.Yg - .Item(.CurWellNo).Yg
		End With
		
		Distance = System.Math.Sqrt(dx ^ 2 + dy ^ 2)
		Bearing = Atan(dy, dx)
		
	End Sub
	
	Private Sub Bear2Coord(ByRef ShipGlob As ShipGlobal, ByRef Distance As Double, ByRef Bearing As Double)
		
		Dim dx, dy As Double
		
		dx = Distance * System.Math.Sin(Bearing)
		dy = Distance * System.Math.Cos(Bearing)
		
		With CurField
			ShipGlob.Xg = .Item(.CurWellNo).Xg + dx
			ShipGlob.Yg = .Item(.CurWellNo).Yg + dy
		End With
		
	End Sub
	
	Public Sub mnuOptions_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOptions.Click
		VB6.ShowForm(frmOptions, 1, Me)
		RefreshData()
	End Sub
	
	Public Sub mnuRadarPlot_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuRadarPlot.Click
		Call btnPlot_Click(btnPlot.Item(1), New System.EventArgs())
	End Sub
	
	Public Sub mnuTransient_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuTransient.Click
		VB6.ShowForm(frmTransient, 0, Me) ' can't show non-modal progressbar when modal is displayed
	End Sub
	
	Private Sub RefreshData()
		RefreshUnitLabels(Me)
		LoadData(False)
	End Sub
	
	'UPGRADE_WARNING: Event txtVslSt.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtVslSt_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVslSt.TextChanged
		Dim Index As Short = txtVslSt.GetIndex(eventSender)
		cboWells_SelectedIndexChanged(cboWells, New System.EventArgs())
		If Not FirstLoad Then CurProj.Saved = False
	End Sub
End Class