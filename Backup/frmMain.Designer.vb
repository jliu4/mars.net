<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents txtLocationName As System.Windows.Forms.TextBox
	Public WithEvents txtClientName As System.Windows.Forms.TextBox
	Public WithEvents lblLocation As System.Windows.Forms.Label
	Public WithEvents lblClientName As System.Windows.Forms.Label
	Public WithEvents fraReport As System.Windows.Forms.GroupBox
	Public WithEvents btnMooring As System.Windows.Forms.Button
	Public WithEvents btnEnv As System.Windows.Forms.Button
	Public dlgFileOpen As System.Windows.Forms.OpenFileDialog
	Public dlgFileSave As System.Windows.Forms.SaveFileDialog
	Public dlgFilePrint As System.Windows.Forms.PrintDialog
	Public WithEvents btnUpdate As System.Windows.Forms.Button
	Public WithEvents grdEL As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents SysInfo1 As AxSysInfoLib.AxSysInfo
	Public WithEvents grdLD As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents fraMooring As System.Windows.Forms.GroupBox
	Public WithEvents _btnPlot_1 As System.Windows.Forms.Button
	Public WithEvents _btnPlot_0 As System.Windows.Forms.Button
	Public WithEvents btnWell As System.Windows.Forms.Button
	Public WithEvents _txtWell_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtWell_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtWell_0 As System.Windows.Forms.TextBox
	Public WithEvents cboWells As System.Windows.Forms.ComboBox
	Public WithEvents _lblLengthUnit_2 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_1 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblWell_2 As System.Windows.Forms.Label
	Public WithEvents _lblWell_1 As System.Windows.Forms.Label
	Public WithEvents _lblWell_0 As System.Windows.Forms.Label
	Public WithEvents fraWell As System.Windows.Forms.GroupBox
	Public WithEvents _optInputSystem_1 As System.Windows.Forms.RadioButton
	Public WithEvents _txtVslSt_5 As System.Windows.Forms.TextBox
	Public WithEvents _txtVslSt_4 As System.Windows.Forms.TextBox
	Public WithEvents _txtVslSt_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtVslSt_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtVslSt_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtVslSt_2 As System.Windows.Forms.TextBox
	Public WithEvents _optInputSystem_0 As System.Windows.Forms.RadioButton
	Public WithEvents _lblAngleUnit_1 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_6 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_5 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_4 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_3 As System.Windows.Forms.Label
	Public WithEvents _lblVslSt_2 As System.Windows.Forms.Label
	Public WithEvents _lblAngleUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblVslSt_4 As System.Windows.Forms.Label
	Public WithEvents _lblVslSt_1 As System.Windows.Forms.Label
	Public WithEvents _lblVslSt_0 As System.Windows.Forms.Label
	Public WithEvents _lblVslSt_5 As System.Windows.Forms.Label
	Public WithEvents _lblVslSt_3 As System.Windows.Forms.Label
	Public WithEvents fraVesselLoc As System.Windows.Forms.GroupBox
	Public WithEvents _lblForceUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblVelUnit_0 As System.Windows.Forms.Label
	Public WithEvents lblVessel As System.Windows.Forms.Label
	Public WithEvents btnPlot As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents lblAngleUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblForceUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblLengthUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVelUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVslSt As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblWell As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents mnuFilePre As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	Public WithEvents optInputSystem As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents txtVslSt As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtWell As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents mnuFileNew As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuLine1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFileSaveAs As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuLine2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFilePrintSetup As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuLine3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _mnuFilePre_0 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuFilePre_1 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuFilePre_2 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuFilePre_3 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuLinePreFile As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuInpProjDes As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuLineInp As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuInpEnviron As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuInpMoor As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuInpFC As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuInput As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnu3DPlot As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuRadarPlot As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuMoorLayoutReport As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuPlots As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuMoor As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuTransient As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuMove As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuSep As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuAnalysesB As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuLinTools As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuOnBoard As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuTools As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.fraReport = New System.Windows.Forms.GroupBox
		Me.txtLocationName = New System.Windows.Forms.TextBox
		Me.txtClientName = New System.Windows.Forms.TextBox
		Me.lblLocation = New System.Windows.Forms.Label
		Me.lblClientName = New System.Windows.Forms.Label
		Me.fraMooring = New System.Windows.Forms.GroupBox
		Me.btnMooring = New System.Windows.Forms.Button
		Me.btnEnv = New System.Windows.Forms.Button
		Me.dlgFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.dlgFileSave = New System.Windows.Forms.SaveFileDialog
		Me.dlgFilePrint = New System.Windows.Forms.PrintDialog
		Me.dlgFilePrint.PrinterSettings = New System.Drawing.Printing.PrinterSettings
		Me.btnUpdate = New System.Windows.Forms.Button
		Me.grdEL = New AxMSFlexGridLib.AxMSFlexGrid
		Me.SysInfo1 = New AxSysInfoLib.AxSysInfo
		Me.grdLD = New AxMSFlexGridLib.AxMSFlexGrid
		Me._btnPlot_1 = New System.Windows.Forms.Button
		Me._btnPlot_0 = New System.Windows.Forms.Button
		Me.fraWell = New System.Windows.Forms.GroupBox
		Me.btnWell = New System.Windows.Forms.Button
		Me._txtWell_2 = New System.Windows.Forms.TextBox
		Me._txtWell_1 = New System.Windows.Forms.TextBox
		Me._txtWell_0 = New System.Windows.Forms.TextBox
		Me.cboWells = New System.Windows.Forms.ComboBox
		Me._lblLengthUnit_2 = New System.Windows.Forms.Label
		Me._lblLengthUnit_1 = New System.Windows.Forms.Label
		Me._lblLengthUnit_0 = New System.Windows.Forms.Label
		Me._lblWell_2 = New System.Windows.Forms.Label
		Me._lblWell_1 = New System.Windows.Forms.Label
		Me._lblWell_0 = New System.Windows.Forms.Label
		Me.fraVesselLoc = New System.Windows.Forms.GroupBox
		Me._optInputSystem_1 = New System.Windows.Forms.RadioButton
		Me._txtVslSt_5 = New System.Windows.Forms.TextBox
		Me._txtVslSt_4 = New System.Windows.Forms.TextBox
		Me._txtVslSt_1 = New System.Windows.Forms.TextBox
		Me._txtVslSt_0 = New System.Windows.Forms.TextBox
		Me._txtVslSt_3 = New System.Windows.Forms.TextBox
		Me._txtVslSt_2 = New System.Windows.Forms.TextBox
		Me._optInputSystem_0 = New System.Windows.Forms.RadioButton
		Me._lblAngleUnit_1 = New System.Windows.Forms.Label
		Me._lblLengthUnit_6 = New System.Windows.Forms.Label
		Me._lblLengthUnit_5 = New System.Windows.Forms.Label
		Me._lblLengthUnit_4 = New System.Windows.Forms.Label
		Me._lblLengthUnit_3 = New System.Windows.Forms.Label
		Me._lblVslSt_2 = New System.Windows.Forms.Label
		Me._lblAngleUnit_0 = New System.Windows.Forms.Label
		Me._lblVslSt_4 = New System.Windows.Forms.Label
		Me._lblVslSt_1 = New System.Windows.Forms.Label
		Me._lblVslSt_0 = New System.Windows.Forms.Label
		Me._lblVslSt_5 = New System.Windows.Forms.Label
		Me._lblVslSt_3 = New System.Windows.Forms.Label
		Me._lblForceUnit_0 = New System.Windows.Forms.Label
		Me._lblVelUnit_0 = New System.Windows.Forms.Label
		Me.lblVessel = New System.Windows.Forms.Label
		Me.btnPlot = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.lblAngleUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblForceUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblLengthUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVelUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVslSt = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblWell = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.mnuFilePre = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(components)
		Me.optInputSystem = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.txtVslSt = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtWell = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuLine1 = New System.Windows.Forms.ToolStripSeparator
		Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuLine2 = New System.Windows.Forms.ToolStripSeparator
		Me.mnuFilePrintSetup = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuLine3 = New System.Windows.Forms.ToolStripSeparator
		Me._mnuFilePre_0 = New System.Windows.Forms.ToolStripMenuItem
		Me._mnuFilePre_1 = New System.Windows.Forms.ToolStripMenuItem
		Me._mnuFilePre_2 = New System.Windows.Forms.ToolStripMenuItem
		Me._mnuFilePre_3 = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuLinePreFile = New System.Windows.Forms.ToolStripSeparator
		Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuInput = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuInpProjDes = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuLineInp = New System.Windows.Forms.ToolStripSeparator
		Me.mnuInpEnviron = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuInpMoor = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuInpFC = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuPlots = New System.Windows.Forms.ToolStripMenuItem
		Me.mnu3DPlot = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuRadarPlot = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuMoorLayoutReport = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuMoor = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuTransient = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuMove = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuSep = New System.Windows.Forms.ToolStripSeparator
		Me.mnuAnalysesB = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuLinTools = New System.Windows.Forms.ToolStripSeparator
		Me.mnuOnBoard = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem
		Me.fraReport.SuspendLayout()
		Me.fraMooring.SuspendLayout()
		Me.fraWell.SuspendLayout()
		Me.fraVesselLoc.SuspendLayout()
		Me.MainMenu1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.grdEL, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SysInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.grdLD, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.btnPlot, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblAngleUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblLengthUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVslSt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblWell, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuFilePre, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optInputSystem, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtVslSt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtWell, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = " MARS Console"
		Me.ClientSize = New System.Drawing.Size(747, 556)
		Me.Location = New System.Drawing.Point(10, 29)
		Me.Icon = CType(resources.GetObject("frmMain.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmMain"
		Me.fraReport.Text = "Mooring Layout Report Titles"
		Me.fraReport.Size = New System.Drawing.Size(727, 57)
		Me.fraReport.Location = New System.Drawing.Point(11, 480)
		Me.fraReport.TabIndex = 40
		Me.fraReport.BackColor = System.Drawing.SystemColors.Control
		Me.fraReport.Enabled = True
		Me.fraReport.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraReport.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraReport.Visible = True
		Me.fraReport.Name = "fraReport"
		Me.txtLocationName.AutoSize = False
		Me.txtLocationName.Size = New System.Drawing.Size(242, 19)
		Me.txtLocationName.Location = New System.Drawing.Point(467, 23)
		Me.txtLocationName.TabIndex = 42
		Me.txtLocationName.TabStop = False
		Me.txtLocationName.Text = "Location"
		Me.txtLocationName.AcceptsReturn = True
		Me.txtLocationName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLocationName.BackColor = System.Drawing.SystemColors.Window
		Me.txtLocationName.CausesValidation = True
		Me.txtLocationName.Enabled = True
		Me.txtLocationName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLocationName.HideSelection = True
		Me.txtLocationName.ReadOnly = False
		Me.txtLocationName.Maxlength = 0
		Me.txtLocationName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLocationName.MultiLine = False
		Me.txtLocationName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLocationName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLocationName.Visible = True
		Me.txtLocationName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLocationName.Name = "txtLocationName"
		Me.txtClientName.AutoSize = False
		Me.txtClientName.Size = New System.Drawing.Size(270, 19)
		Me.txtClientName.Location = New System.Drawing.Point(98, 24)
		Me.txtClientName.TabIndex = 41
		Me.txtClientName.TabStop = False
		Me.txtClientName.Text = "Noble Drilling Services"
		Me.txtClientName.AcceptsReturn = True
		Me.txtClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtClientName.BackColor = System.Drawing.SystemColors.Window
		Me.txtClientName.CausesValidation = True
		Me.txtClientName.Enabled = True
		Me.txtClientName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtClientName.HideSelection = True
		Me.txtClientName.ReadOnly = False
		Me.txtClientName.Maxlength = 0
		Me.txtClientName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtClientName.MultiLine = False
		Me.txtClientName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtClientName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtClientName.Visible = True
		Me.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtClientName.Name = "txtClientName"
		Me.lblLocation.Text = "Location Name:"
		Me.lblLocation.Size = New System.Drawing.Size(87, 17)
		Me.lblLocation.Location = New System.Drawing.Point(386, 26)
		Me.lblLocation.TabIndex = 44
		Me.lblLocation.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLocation.BackColor = System.Drawing.SystemColors.Control
		Me.lblLocation.Enabled = True
		Me.lblLocation.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLocation.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLocation.UseMnemonic = True
		Me.lblLocation.Visible = True
		Me.lblLocation.AutoSize = False
		Me.lblLocation.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLocation.Name = "lblLocation"
		Me.lblClientName.Text = "Prepared for"
		Me.lblClientName.Size = New System.Drawing.Size(73, 17)
		Me.lblClientName.Location = New System.Drawing.Point(29, 27)
		Me.lblClientName.TabIndex = 43
		Me.lblClientName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblClientName.BackColor = System.Drawing.SystemColors.Control
		Me.lblClientName.Enabled = True
		Me.lblClientName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblClientName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblClientName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblClientName.UseMnemonic = True
		Me.lblClientName.Visible = True
		Me.lblClientName.AutoSize = False
		Me.lblClientName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblClientName.Name = "lblClientName"
		Me.fraMooring.Text = "Mooring System Summary"
		Me.fraMooring.Size = New System.Drawing.Size(731, 336)
		Me.fraMooring.Location = New System.Drawing.Point(8, 134)
		Me.fraMooring.TabIndex = 29
		Me.fraMooring.BackColor = System.Drawing.SystemColors.Control
		Me.fraMooring.Enabled = True
		Me.fraMooring.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraMooring.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraMooring.Visible = True
		Me.fraMooring.Name = "fraMooring"
		Me.btnMooring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnMooring.Text = "Mooring..."
		Me.btnMooring.Size = New System.Drawing.Size(79, 25)
		Me.btnMooring.Location = New System.Drawing.Point(551, 292)
		Me.btnMooring.TabIndex = 46
		Me.btnMooring.BackColor = System.Drawing.SystemColors.Control
		Me.btnMooring.CausesValidation = True
		Me.btnMooring.Enabled = True
		Me.btnMooring.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnMooring.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnMooring.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnMooring.TabStop = True
		Me.btnMooring.Name = "btnMooring"
		Me.btnEnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnEnv.Text = "Enviroment..."
		Me.btnEnv.Size = New System.Drawing.Size(79, 25)
		Me.btnEnv.Location = New System.Drawing.Point(458, 292)
		Me.btnEnv.TabIndex = 45
		Me.btnEnv.BackColor = System.Drawing.SystemColors.Control
		Me.btnEnv.CausesValidation = True
		Me.btnEnv.Enabled = True
		Me.btnEnv.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnEnv.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnEnv.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnEnv.TabStop = True
		Me.btnEnv.Name = "btnEnv"
		Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnUpdate.Text = "Refresh"
		Me.btnUpdate.Size = New System.Drawing.Size(79, 25)
		Me.btnUpdate.Location = New System.Drawing.Point(643, 292)
		Me.btnUpdate.TabIndex = 0
		Me.btnUpdate.BackColor = System.Drawing.SystemColors.Control
		Me.btnUpdate.CausesValidation = True
		Me.btnUpdate.Enabled = True
		Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnUpdate.TabStop = True
		Me.btnUpdate.Name = "btnUpdate"
		grdEL.OcxState = CType(resources.GetObject("grdEL.OcxState"), System.Windows.Forms.AxHost.State)
		Me.grdEL.Size = New System.Drawing.Size(352, 41)
		Me.grdEL.Location = New System.Drawing.Point(9, 284)
		Me.grdEL.TabIndex = 30
		Me.grdEL.Name = "grdEL"
		SysInfo1.OcxState = CType(resources.GetObject("SysInfo1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.SysInfo1.Location = New System.Drawing.Point(184, 240)
		Me.SysInfo1.Name = "SysInfo1"
		grdLD.OcxState = CType(resources.GetObject("grdLD.OcxState"), System.Windows.Forms.AxHost.State)
		Me.grdLD.Size = New System.Drawing.Size(708, 254)
		Me.grdLD.Location = New System.Drawing.Point(9, 20)
		Me.grdLD.TabIndex = 31
		Me.grdLD.Name = "grdLD"
		Me._btnPlot_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._btnPlot_1.Text = "Radar Plot"
		Me._btnPlot_1.Size = New System.Drawing.Size(65, 25)
		Me._btnPlot_1.Location = New System.Drawing.Point(294, 9)
		Me._btnPlot_1.TabIndex = 3
		Me._btnPlot_1.BackColor = System.Drawing.SystemColors.Control
		Me._btnPlot_1.CausesValidation = True
		Me._btnPlot_1.Enabled = True
		Me._btnPlot_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnPlot_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._btnPlot_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._btnPlot_1.TabStop = True
		Me._btnPlot_1.Name = "_btnPlot_1"
		Me._btnPlot_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._btnPlot_0.Text = "3D Plot"
		Me._btnPlot_0.Size = New System.Drawing.Size(61, 25)
		Me._btnPlot_0.Location = New System.Drawing.Point(226, 9)
		Me._btnPlot_0.TabIndex = 2
		Me._btnPlot_0.BackColor = System.Drawing.SystemColors.Control
		Me._btnPlot_0.CausesValidation = True
		Me._btnPlot_0.Enabled = True
		Me._btnPlot_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnPlot_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._btnPlot_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._btnPlot_0.TabStop = True
		Me._btnPlot_0.Name = "_btnPlot_0"
		Me.fraWell.Text = "Current Well Site"
		Me.fraWell.Size = New System.Drawing.Size(352, 89)
		Me.fraWell.Location = New System.Drawing.Point(8, 38)
		Me.fraWell.TabIndex = 4
		Me.fraWell.BackColor = System.Drawing.SystemColors.Control
		Me.fraWell.Enabled = True
		Me.fraWell.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraWell.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraWell.Visible = True
		Me.fraWell.Name = "fraWell"
		Me.btnWell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnWell.Text = "Edit..."
		Me.btnWell.Size = New System.Drawing.Size(46, 25)
		Me.btnWell.Location = New System.Drawing.Point(121, 50)
		Me.btnWell.TabIndex = 6
		Me.btnWell.BackColor = System.Drawing.SystemColors.Control
		Me.btnWell.CausesValidation = True
		Me.btnWell.Enabled = True
		Me.btnWell.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnWell.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnWell.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnWell.TabStop = True
		Me.btnWell.Name = "btnWell"
		Me._txtWell_2.AutoSize = False
		Me._txtWell_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtWell_2.BackColor = System.Drawing.SystemColors.Control
		Me._txtWell_2.Size = New System.Drawing.Size(64, 19)
		Me._txtWell_2.Location = New System.Drawing.Point(252, 63)
		Me._txtWell_2.ReadOnly = True
		Me._txtWell_2.TabIndex = 12
		Me._txtWell_2.TabStop = False
		Me._txtWell_2.Text = "0"
		Me._txtWell_2.AcceptsReturn = True
		Me._txtWell_2.CausesValidation = True
		Me._txtWell_2.Enabled = True
		Me._txtWell_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtWell_2.HideSelection = True
		Me._txtWell_2.Maxlength = 0
		Me._txtWell_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtWell_2.MultiLine = False
		Me._txtWell_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtWell_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtWell_2.Visible = True
		Me._txtWell_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtWell_2.Name = "_txtWell_2"
		Me._txtWell_1.AutoSize = False
		Me._txtWell_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtWell_1.BackColor = System.Drawing.SystemColors.Control
		Me._txtWell_1.Size = New System.Drawing.Size(101, 19)
		Me._txtWell_1.Location = New System.Drawing.Point(215, 39)
		Me._txtWell_1.ReadOnly = True
		Me._txtWell_1.TabIndex = 10
		Me._txtWell_1.TabStop = False
		Me._txtWell_1.Text = "0"
		Me._txtWell_1.AcceptsReturn = True
		Me._txtWell_1.CausesValidation = True
		Me._txtWell_1.Enabled = True
		Me._txtWell_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtWell_1.HideSelection = True
		Me._txtWell_1.Maxlength = 0
		Me._txtWell_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtWell_1.MultiLine = False
		Me._txtWell_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtWell_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtWell_1.Visible = True
		Me._txtWell_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtWell_1.Name = "_txtWell_1"
		Me._txtWell_0.AutoSize = False
		Me._txtWell_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtWell_0.BackColor = System.Drawing.SystemColors.Control
		Me._txtWell_0.Size = New System.Drawing.Size(101, 19)
		Me._txtWell_0.Location = New System.Drawing.Point(215, 15)
		Me._txtWell_0.ReadOnly = True
		Me._txtWell_0.TabIndex = 8
		Me._txtWell_0.TabStop = False
		Me._txtWell_0.Text = "0"
		Me._txtWell_0.AcceptsReturn = True
		Me._txtWell_0.CausesValidation = True
		Me._txtWell_0.Enabled = True
		Me._txtWell_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtWell_0.HideSelection = True
		Me._txtWell_0.Maxlength = 0
		Me._txtWell_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtWell_0.MultiLine = False
		Me._txtWell_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtWell_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtWell_0.Visible = True
		Me._txtWell_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtWell_0.Name = "_txtWell_0"
		Me.cboWells.Size = New System.Drawing.Size(154, 21)
		Me.cboWells.Location = New System.Drawing.Point(13, 24)
		Me.cboWells.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboWells.TabIndex = 5
		Me.cboWells.BackColor = System.Drawing.SystemColors.Window
		Me.cboWells.CausesValidation = True
		Me.cboWells.Enabled = True
		Me.cboWells.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWells.IntegralHeight = True
		Me.cboWells.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWells.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWells.Sorted = False
		Me.cboWells.TabStop = True
		Me.cboWells.Visible = True
		Me.cboWells.Name = "cboWells"
		Me._lblLengthUnit_2.Text = "ft"
		Me._lblLengthUnit_2.Size = New System.Drawing.Size(9, 17)
		Me._lblLengthUnit_2.Location = New System.Drawing.Point(325, 65)
		Me._lblLengthUnit_2.TabIndex = 34
		Me._lblLengthUnit_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLengthUnit_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblLengthUnit_2.Enabled = True
		Me._lblLengthUnit_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLengthUnit_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLengthUnit_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLengthUnit_2.UseMnemonic = True
		Me._lblLengthUnit_2.Visible = True
		Me._lblLengthUnit_2.AutoSize = False
		Me._lblLengthUnit_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLengthUnit_2.Name = "_lblLengthUnit_2"
		Me._lblLengthUnit_1.Text = "ft"
		Me._lblLengthUnit_1.Size = New System.Drawing.Size(9, 17)
		Me._lblLengthUnit_1.Location = New System.Drawing.Point(325, 41)
		Me._lblLengthUnit_1.TabIndex = 33
		Me._lblLengthUnit_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLengthUnit_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblLengthUnit_1.Enabled = True
		Me._lblLengthUnit_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLengthUnit_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLengthUnit_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLengthUnit_1.UseMnemonic = True
		Me._lblLengthUnit_1.Visible = True
		Me._lblLengthUnit_1.AutoSize = False
		Me._lblLengthUnit_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLengthUnit_1.Name = "_lblLengthUnit_1"
		Me._lblLengthUnit_0.Text = "ft"
		Me._lblLengthUnit_0.Size = New System.Drawing.Size(9, 17)
		Me._lblLengthUnit_0.Location = New System.Drawing.Point(325, 16)
		Me._lblLengthUnit_0.TabIndex = 32
		Me._lblLengthUnit_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLengthUnit_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblLengthUnit_0.Enabled = True
		Me._lblLengthUnit_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLengthUnit_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLengthUnit_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLengthUnit_0.UseMnemonic = True
		Me._lblLengthUnit_0.Visible = True
		Me._lblLengthUnit_0.AutoSize = False
		Me._lblLengthUnit_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLengthUnit_0.Name = "_lblLengthUnit_0"
		Me._lblWell_2.Text = "Water Depth"
		Me._lblWell_2.Size = New System.Drawing.Size(85, 17)
		Me._lblWell_2.Location = New System.Drawing.Point(187, 64)
		Me._lblWell_2.TabIndex = 11
		Me._lblWell_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWell_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblWell_2.Enabled = True
		Me._lblWell_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWell_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWell_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWell_2.UseMnemonic = True
		Me._lblWell_2.Visible = True
		Me._lblWell_2.AutoSize = False
		Me._lblWell_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWell_2.Name = "_lblWell_2"
		Me._lblWell_1.Text = "y (N)"
		Me._lblWell_1.Size = New System.Drawing.Size(33, 17)
		Me._lblWell_1.Location = New System.Drawing.Point(187, 39)
		Me._lblWell_1.TabIndex = 9
		Me._lblWell_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWell_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblWell_1.Enabled = True
		Me._lblWell_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWell_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWell_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWell_1.UseMnemonic = True
		Me._lblWell_1.Visible = True
		Me._lblWell_1.AutoSize = False
		Me._lblWell_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWell_1.Name = "_lblWell_1"
		Me._lblWell_0.Text = "x (E)"
		Me._lblWell_0.Size = New System.Drawing.Size(33, 17)
		Me._lblWell_0.Location = New System.Drawing.Point(189, 17)
		Me._lblWell_0.TabIndex = 7
		Me._lblWell_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWell_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblWell_0.Enabled = True
		Me._lblWell_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWell_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWell_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWell_0.UseMnemonic = True
		Me._lblWell_0.Visible = True
		Me._lblWell_0.AutoSize = False
		Me._lblWell_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWell_0.Name = "_lblWell_0"
		Me.fraVesselLoc.Text = "Current Vessel Station :"
		Me.fraVesselLoc.Size = New System.Drawing.Size(364, 121)
		Me.fraVesselLoc.Location = New System.Drawing.Point(374, 7)
		Me.fraVesselLoc.TabIndex = 13
		Me.fraVesselLoc.BackColor = System.Drawing.SystemColors.Control
		Me.fraVesselLoc.Enabled = True
		Me.fraVesselLoc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraVesselLoc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraVesselLoc.Visible = True
		Me.fraVesselLoc.Name = "fraVesselLoc"
		Me._optInputSystem_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optInputSystem_1.Text = "To Well:"
		Me._optInputSystem_1.Size = New System.Drawing.Size(65, 17)
		Me._optInputSystem_1.Location = New System.Drawing.Point(16, 56)
		Me._optInputSystem_1.TabIndex = 19
		Me._optInputSystem_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optInputSystem_1.BackColor = System.Drawing.SystemColors.Control
		Me._optInputSystem_1.CausesValidation = True
		Me._optInputSystem_1.Enabled = True
		Me._optInputSystem_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optInputSystem_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optInputSystem_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optInputSystem_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optInputSystem_1.TabStop = True
		Me._optInputSystem_1.Checked = False
		Me._optInputSystem_1.Visible = True
		Me._optInputSystem_1.Name = "_optInputSystem_1"
		Me._txtVslSt_5.AutoSize = False
		Me._txtVslSt_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtVslSt_5.Size = New System.Drawing.Size(49, 19)
		Me._txtVslSt_5.Location = New System.Drawing.Point(289, 85)
		Me._txtVslSt_5.TabIndex = 28
		Me._txtVslSt_5.TabStop = False
		Me._txtVslSt_5.Text = "0"
		Me._txtVslSt_5.AcceptsReturn = True
		Me._txtVslSt_5.BackColor = System.Drawing.SystemColors.Window
		Me._txtVslSt_5.CausesValidation = True
		Me._txtVslSt_5.Enabled = True
		Me._txtVslSt_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVslSt_5.HideSelection = True
		Me._txtVslSt_5.ReadOnly = False
		Me._txtVslSt_5.Maxlength = 0
		Me._txtVslSt_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtVslSt_5.MultiLine = False
		Me._txtVslSt_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtVslSt_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtVslSt_5.Visible = True
		Me._txtVslSt_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtVslSt_5.Name = "_txtVslSt_5"
		Me._txtVslSt_4.AutoSize = False
		Me._txtVslSt_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtVslSt_4.Size = New System.Drawing.Size(71, 19)
		Me._txtVslSt_4.Location = New System.Drawing.Point(141, 84)
		Me._txtVslSt_4.TabIndex = 25
		Me._txtVslSt_4.TabStop = False
		Me._txtVslSt_4.Text = "0"
		Me._txtVslSt_4.AcceptsReturn = True
		Me._txtVslSt_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtVslSt_4.CausesValidation = True
		Me._txtVslSt_4.Enabled = True
		Me._txtVslSt_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVslSt_4.HideSelection = True
		Me._txtVslSt_4.ReadOnly = False
		Me._txtVslSt_4.Maxlength = 0
		Me._txtVslSt_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtVslSt_4.MultiLine = False
		Me._txtVslSt_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtVslSt_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtVslSt_4.Visible = True
		Me._txtVslSt_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtVslSt_4.Name = "_txtVslSt_4"
		Me._txtVslSt_1.AutoSize = False
		Me._txtVslSt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtVslSt_1.Size = New System.Drawing.Size(79, 19)
		Me._txtVslSt_1.Location = New System.Drawing.Point(259, 23)
		Me._txtVslSt_1.TabIndex = 18
		Me._txtVslSt_1.TabStop = False
		Me._txtVslSt_1.Text = "0"
		Me._txtVslSt_1.AcceptsReturn = True
		Me._txtVslSt_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtVslSt_1.CausesValidation = True
		Me._txtVslSt_1.Enabled = True
		Me._txtVslSt_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVslSt_1.HideSelection = True
		Me._txtVslSt_1.ReadOnly = False
		Me._txtVslSt_1.Maxlength = 0
		Me._txtVslSt_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtVslSt_1.MultiLine = False
		Me._txtVslSt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtVslSt_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtVslSt_1.Visible = True
		Me._txtVslSt_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtVslSt_1.Name = "_txtVslSt_1"
		Me._txtVslSt_0.AutoSize = False
		Me._txtVslSt_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtVslSt_0.Size = New System.Drawing.Size(71, 19)
		Me._txtVslSt_0.Location = New System.Drawing.Point(141, 24)
		Me._txtVslSt_0.TabIndex = 16
		Me._txtVslSt_0.TabStop = False
		Me._txtVslSt_0.Text = "0"
		Me._txtVslSt_0.AcceptsReturn = True
		Me._txtVslSt_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtVslSt_0.CausesValidation = True
		Me._txtVslSt_0.Enabled = True
		Me._txtVslSt_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVslSt_0.HideSelection = True
		Me._txtVslSt_0.ReadOnly = False
		Me._txtVslSt_0.Maxlength = 0
		Me._txtVslSt_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtVslSt_0.MultiLine = False
		Me._txtVslSt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtVslSt_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtVslSt_0.Visible = True
		Me._txtVslSt_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtVslSt_0.Name = "_txtVslSt_0"
		Me._txtVslSt_3.AutoSize = False
		Me._txtVslSt_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtVslSt_3.Size = New System.Drawing.Size(49, 19)
		Me._txtVslSt_3.Location = New System.Drawing.Point(289, 54)
		Me._txtVslSt_3.TabIndex = 23
		Me._txtVslSt_3.TabStop = False
		Me._txtVslSt_3.Text = "0"
		Me._txtVslSt_3.AcceptsReturn = True
		Me._txtVslSt_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtVslSt_3.CausesValidation = True
		Me._txtVslSt_3.Enabled = True
		Me._txtVslSt_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVslSt_3.HideSelection = True
		Me._txtVslSt_3.ReadOnly = False
		Me._txtVslSt_3.Maxlength = 0
		Me._txtVslSt_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtVslSt_3.MultiLine = False
		Me._txtVslSt_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtVslSt_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtVslSt_3.Visible = True
		Me._txtVslSt_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtVslSt_3.Name = "_txtVslSt_3"
		Me._txtVslSt_2.AutoSize = False
		Me._txtVslSt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtVslSt_2.Size = New System.Drawing.Size(71, 19)
		Me._txtVslSt_2.Location = New System.Drawing.Point(141, 54)
		Me._txtVslSt_2.TabIndex = 21
		Me._txtVslSt_2.TabStop = False
		Me._txtVslSt_2.Text = "0"
		Me._txtVslSt_2.AcceptsReturn = True
		Me._txtVslSt_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtVslSt_2.CausesValidation = True
		Me._txtVslSt_2.Enabled = True
		Me._txtVslSt_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVslSt_2.HideSelection = True
		Me._txtVslSt_2.ReadOnly = False
		Me._txtVslSt_2.Maxlength = 0
		Me._txtVslSt_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtVslSt_2.MultiLine = False
		Me._txtVslSt_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtVslSt_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtVslSt_2.Visible = True
		Me._txtVslSt_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtVslSt_2.Name = "_txtVslSt_2"
		Me._optInputSystem_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optInputSystem_0.Text = "At Coordinate:"
		Me._optInputSystem_0.Size = New System.Drawing.Size(92, 17)
		Me._optInputSystem_0.Location = New System.Drawing.Point(16, 24)
		Me._optInputSystem_0.TabIndex = 14
		Me._optInputSystem_0.Checked = True
		Me._optInputSystem_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optInputSystem_0.BackColor = System.Drawing.SystemColors.Control
		Me._optInputSystem_0.CausesValidation = True
		Me._optInputSystem_0.Enabled = True
		Me._optInputSystem_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optInputSystem_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optInputSystem_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optInputSystem_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optInputSystem_0.TabStop = True
		Me._optInputSystem_0.Visible = True
		Me._optInputSystem_0.Name = "_optInputSystem_0"
		Me._lblAngleUnit_1.Text = "Invalid_string_refer_to_original_code"
		Me._lblAngleUnit_1.Size = New System.Drawing.Size(17, 17)
		Me._lblAngleUnit_1.Location = New System.Drawing.Point(341, 51)
		Me._lblAngleUnit_1.TabIndex = 39
		Me._lblAngleUnit_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblAngleUnit_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblAngleUnit_1.Enabled = True
		Me._lblAngleUnit_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblAngleUnit_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblAngleUnit_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblAngleUnit_1.UseMnemonic = True
		Me._lblAngleUnit_1.Visible = True
		Me._lblAngleUnit_1.AutoSize = False
		Me._lblAngleUnit_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblAngleUnit_1.Name = "_lblAngleUnit_1"
		Me._lblLengthUnit_6.Text = "ft"
		Me._lblLengthUnit_6.Size = New System.Drawing.Size(9, 17)
		Me._lblLengthUnit_6.Location = New System.Drawing.Point(342, 86)
		Me._lblLengthUnit_6.TabIndex = 38
		Me._lblLengthUnit_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLengthUnit_6.BackColor = System.Drawing.SystemColors.Control
		Me._lblLengthUnit_6.Enabled = True
		Me._lblLengthUnit_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLengthUnit_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLengthUnit_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLengthUnit_6.UseMnemonic = True
		Me._lblLengthUnit_6.Visible = True
		Me._lblLengthUnit_6.AutoSize = False
		Me._lblLengthUnit_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLengthUnit_6.Name = "_lblLengthUnit_6"
		Me._lblLengthUnit_5.Text = "ft"
		Me._lblLengthUnit_5.Size = New System.Drawing.Size(9, 17)
		Me._lblLengthUnit_5.Location = New System.Drawing.Point(216, 55)
		Me._lblLengthUnit_5.TabIndex = 37
		Me._lblLengthUnit_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLengthUnit_5.BackColor = System.Drawing.SystemColors.Control
		Me._lblLengthUnit_5.Enabled = True
		Me._lblLengthUnit_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLengthUnit_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLengthUnit_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLengthUnit_5.UseMnemonic = True
		Me._lblLengthUnit_5.Visible = True
		Me._lblLengthUnit_5.AutoSize = False
		Me._lblLengthUnit_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLengthUnit_5.Name = "_lblLengthUnit_5"
		Me._lblLengthUnit_4.Text = "ft"
		Me._lblLengthUnit_4.Size = New System.Drawing.Size(9, 17)
		Me._lblLengthUnit_4.Location = New System.Drawing.Point(342, 26)
		Me._lblLengthUnit_4.TabIndex = 36
		Me._lblLengthUnit_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLengthUnit_4.BackColor = System.Drawing.SystemColors.Control
		Me._lblLengthUnit_4.Enabled = True
		Me._lblLengthUnit_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLengthUnit_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLengthUnit_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLengthUnit_4.UseMnemonic = True
		Me._lblLengthUnit_4.Visible = True
		Me._lblLengthUnit_4.AutoSize = False
		Me._lblLengthUnit_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLengthUnit_4.Name = "_lblLengthUnit_4"
		Me._lblLengthUnit_3.Text = "ft"
		Me._lblLengthUnit_3.Size = New System.Drawing.Size(9, 17)
		Me._lblLengthUnit_3.Location = New System.Drawing.Point(217, 26)
		Me._lblLengthUnit_3.TabIndex = 35
		Me._lblLengthUnit_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLengthUnit_3.BackColor = System.Drawing.SystemColors.Control
		Me._lblLengthUnit_3.Enabled = True
		Me._lblLengthUnit_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLengthUnit_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLengthUnit_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLengthUnit_3.UseMnemonic = True
		Me._lblLengthUnit_3.Visible = True
		Me._lblLengthUnit_3.AutoSize = False
		Me._lblLengthUnit_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLengthUnit_3.Name = "_lblLengthUnit_3"
		Me._lblVslSt_2.Text = "Distance "
		Me._lblVslSt_2.Size = New System.Drawing.Size(49, 17)
		Me._lblVslSt_2.Location = New System.Drawing.Point(93, 56)
		Me._lblVslSt_2.TabIndex = 20
		Me._lblVslSt_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVslSt_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblVslSt_2.Enabled = True
		Me._lblVslSt_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVslSt_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVslSt_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVslSt_2.UseMnemonic = True
		Me._lblVslSt_2.Visible = True
		Me._lblVslSt_2.AutoSize = False
		Me._lblVslSt_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVslSt_2.Name = "_lblVslSt_2"
		Me._lblAngleUnit_0.Text = "Invalid_string_refer_to_original_code"
		Me._lblAngleUnit_0.Size = New System.Drawing.Size(17, 17)
		Me._lblAngleUnit_0.Location = New System.Drawing.Point(216, 83)
		Me._lblAngleUnit_0.TabIndex = 26
		Me._lblAngleUnit_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblAngleUnit_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblAngleUnit_0.Enabled = True
		Me._lblAngleUnit_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblAngleUnit_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblAngleUnit_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblAngleUnit_0.UseMnemonic = True
		Me._lblAngleUnit_0.Visible = True
		Me._lblAngleUnit_0.AutoSize = False
		Me._lblAngleUnit_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblAngleUnit_0.Name = "_lblAngleUnit_0"
		Me._lblVslSt_4.Text = "With Vessel Heading"
		Me._lblVslSt_4.Size = New System.Drawing.Size(105, 17)
		Me._lblVslSt_4.Location = New System.Drawing.Point(16, 88)
		Me._lblVslSt_4.TabIndex = 24
		Me._lblVslSt_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVslSt_4.BackColor = System.Drawing.SystemColors.Control
		Me._lblVslSt_4.Enabled = True
		Me._lblVslSt_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVslSt_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVslSt_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVslSt_4.UseMnemonic = True
		Me._lblVslSt_4.Visible = True
		Me._lblVslSt_4.AutoSize = False
		Me._lblVslSt_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVslSt_4.Name = "_lblVslSt_4"
		Me._lblVslSt_1.Text = "y (N)"
		Me._lblVslSt_1.Size = New System.Drawing.Size(33, 17)
		Me._lblVslSt_1.Location = New System.Drawing.Point(234, 24)
		Me._lblVslSt_1.TabIndex = 17
		Me._lblVslSt_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVslSt_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblVslSt_1.Enabled = True
		Me._lblVslSt_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVslSt_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVslSt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVslSt_1.UseMnemonic = True
		Me._lblVslSt_1.Visible = True
		Me._lblVslSt_1.AutoSize = False
		Me._lblVslSt_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVslSt_1.Name = "_lblVslSt_1"
		Me._lblVslSt_0.Text = "x (E)"
		Me._lblVslSt_0.Size = New System.Drawing.Size(33, 17)
		Me._lblVslSt_0.Location = New System.Drawing.Point(117, 24)
		Me._lblVslSt_0.TabIndex = 15
		Me._lblVslSt_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVslSt_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblVslSt_0.Enabled = True
		Me._lblVslSt_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVslSt_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVslSt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVslSt_0.UseMnemonic = True
		Me._lblVslSt_0.Visible = True
		Me._lblVslSt_0.AutoSize = False
		Me._lblVslSt_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVslSt_0.Name = "_lblVslSt_0"
		Me._lblVslSt_5.Text = "Draft"
		Me._lblVslSt_5.Size = New System.Drawing.Size(41, 17)
		Me._lblVslSt_5.Location = New System.Drawing.Point(257, 86)
		Me._lblVslSt_5.TabIndex = 27
		Me._lblVslSt_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVslSt_5.BackColor = System.Drawing.SystemColors.Control
		Me._lblVslSt_5.Enabled = True
		Me._lblVslSt_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVslSt_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVslSt_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVslSt_5.UseMnemonic = True
		Me._lblVslSt_5.Visible = True
		Me._lblVslSt_5.AutoSize = False
		Me._lblVslSt_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVslSt_5.Name = "_lblVslSt_5"
		Me._lblVslSt_3.Text = "Bearing"
		Me._lblVslSt_3.Size = New System.Drawing.Size(41, 17)
		Me._lblVslSt_3.Location = New System.Drawing.Point(248, 55)
		Me._lblVslSt_3.TabIndex = 22
		Me._lblVslSt_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVslSt_3.BackColor = System.Drawing.SystemColors.Control
		Me._lblVslSt_3.Enabled = True
		Me._lblVslSt_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVslSt_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVslSt_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVslSt_3.UseMnemonic = True
		Me._lblVslSt_3.Visible = True
		Me._lblVslSt_3.AutoSize = False
		Me._lblVslSt_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVslSt_3.Name = "_lblVslSt_3"
		Me._lblForceUnit_0.Text = "kips"
		Me._lblForceUnit_0.Size = New System.Drawing.Size(25, 17)
		Me._lblForceUnit_0.Location = New System.Drawing.Point(1, 16)
		Me._lblForceUnit_0.TabIndex = 48
		Me._lblForceUnit_0.Visible = False
		Me._lblForceUnit_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblForceUnit_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblForceUnit_0.Enabled = True
		Me._lblForceUnit_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblForceUnit_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblForceUnit_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblForceUnit_0.UseMnemonic = True
		Me._lblForceUnit_0.AutoSize = False
		Me._lblForceUnit_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblForceUnit_0.Name = "_lblForceUnit_0"
		Me._lblVelUnit_0.Text = "kn"
		Me._lblVelUnit_0.Size = New System.Drawing.Size(25, 17)
		Me._lblVelUnit_0.Location = New System.Drawing.Point(0, 0)
		Me._lblVelUnit_0.TabIndex = 47
		Me._lblVelUnit_0.Visible = False
		Me._lblVelUnit_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVelUnit_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblVelUnit_0.Enabled = True
		Me._lblVelUnit_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVelUnit_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVelUnit_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVelUnit_0.UseMnemonic = True
		Me._lblVelUnit_0.AutoSize = False
		Me._lblVelUnit_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVelUnit_0.Name = "_lblVelUnit_0"
		Me.lblVessel.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblVessel.Text = "Diamond Baroness"
		Me.lblVessel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVessel.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.lblVessel.Size = New System.Drawing.Size(203, 25)
		Me.lblVessel.Location = New System.Drawing.Point(8, 8)
		Me.lblVessel.TabIndex = 1
		Me.lblVessel.BackColor = System.Drawing.SystemColors.Control
		Me.lblVessel.Enabled = True
		Me.lblVessel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVessel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVessel.UseMnemonic = True
		Me.lblVessel.Visible = True
		Me.lblVessel.AutoSize = False
		Me.lblVessel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblVessel.Name = "lblVessel"
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Text = "&Project"
		Me.mnuFile.Checked = False
		Me.mnuFile.Enabled = True
		Me.mnuFile.Visible = True
		Me.mnuFileNew.Name = "mnuFileNew"
		Me.mnuFileNew.Text = "&New"
		Me.mnuFileNew.Checked = False
		Me.mnuFileNew.Enabled = True
		Me.mnuFileNew.Visible = True
		Me.mnuFileOpen.Name = "mnuFileOpen"
		Me.mnuFileOpen.Text = "&Open ..."
		Me.mnuFileOpen.Checked = False
		Me.mnuFileOpen.Enabled = True
		Me.mnuFileOpen.Visible = True
		Me.mnuLine1.Enabled = True
		Me.mnuLine1.Visible = True
		Me.mnuLine1.Name = "mnuLine1"
		Me.mnuFileSave.Name = "mnuFileSave"
		Me.mnuFileSave.Text = "&Save"
		Me.mnuFileSave.Checked = False
		Me.mnuFileSave.Enabled = True
		Me.mnuFileSave.Visible = True
		Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
		Me.mnuFileSaveAs.Text = "Save &As..."
		Me.mnuFileSaveAs.Checked = False
		Me.mnuFileSaveAs.Enabled = True
		Me.mnuFileSaveAs.Visible = True
		Me.mnuLine2.Enabled = True
		Me.mnuLine2.Visible = True
		Me.mnuLine2.Name = "mnuLine2"
		Me.mnuFilePrintSetup.Name = "mnuFilePrintSetup"
		Me.mnuFilePrintSetup.Text = "&Printer Setup ..."
		Me.mnuFilePrintSetup.Checked = False
		Me.mnuFilePrintSetup.Enabled = True
		Me.mnuFilePrintSetup.Visible = True
		Me.mnuLine3.Enabled = True
		Me.mnuLine3.Visible = True
		Me.mnuLine3.Name = "mnuLine3"
		Me._mnuFilePre_0.Name = "_mnuFilePre_0"
		Me._mnuFilePre_0.Text = ""
		Me._mnuFilePre_0.Enabled = False
		Me._mnuFilePre_0.Visible = False
		Me._mnuFilePre_0.Checked = False
		Me._mnuFilePre_1.Name = "_mnuFilePre_1"
		Me._mnuFilePre_1.Text = ""
		Me._mnuFilePre_1.Enabled = False
		Me._mnuFilePre_1.Visible = False
		Me._mnuFilePre_1.Checked = False
		Me._mnuFilePre_2.Name = "_mnuFilePre_2"
		Me._mnuFilePre_2.Text = ""
		Me._mnuFilePre_2.Enabled = False
		Me._mnuFilePre_2.Visible = False
		Me._mnuFilePre_2.Checked = False
		Me._mnuFilePre_3.Name = "_mnuFilePre_3"
		Me._mnuFilePre_3.Text = ""
		Me._mnuFilePre_3.Enabled = False
		Me._mnuFilePre_3.Visible = False
		Me._mnuFilePre_3.Checked = False
		Me.mnuLinePreFile.Visible = False
		Me.mnuLinePreFile.Enabled = True
		Me.mnuLinePreFile.Name = "mnuLinePreFile"
		Me.mnuFileExit.Name = "mnuFileExit"
		Me.mnuFileExit.Text = "E&xit"
		Me.mnuFileExit.Checked = False
		Me.mnuFileExit.Enabled = True
		Me.mnuFileExit.Visible = True
		Me.mnuInput.Name = "mnuInput"
		Me.mnuInput.Text = "&Edit"
		Me.mnuInput.Checked = False
		Me.mnuInput.Enabled = True
		Me.mnuInput.Visible = True
		Me.mnuInpProjDes.Name = "mnuInpProjDes"
		Me.mnuInpProjDes.Text = "Vessel..."
		Me.mnuInpProjDes.Checked = False
		Me.mnuInpProjDes.Enabled = True
		Me.mnuInpProjDes.Visible = True
		Me.mnuLineInp.Enabled = True
		Me.mnuLineInp.Visible = True
		Me.mnuLineInp.Name = "mnuLineInp"
		Me.mnuInpEnviron.Name = "mnuInpEnviron"
		Me.mnuInpEnviron.Text = "&Environment..."
		Me.mnuInpEnviron.Checked = False
		Me.mnuInpEnviron.Enabled = True
		Me.mnuInpEnviron.Visible = True
		Me.mnuInpMoor.Name = "mnuInpMoor"
		Me.mnuInpMoor.Text = "&Mooring System..."
		Me.mnuInpMoor.Checked = False
		Me.mnuInpMoor.Enabled = True
		Me.mnuInpMoor.Visible = True
		Me.mnuInpFC.Name = "mnuInpFC"
		Me.mnuInpFC.Text = "&Vessel Force Coefficients..."
		Me.mnuInpFC.Enabled = False
		Me.mnuInpFC.Visible = False
		Me.mnuInpFC.Checked = False
		Me.mnuPlots.Name = "mnuPlots"
		Me.mnuPlots.Text = "&View"
		Me.mnuPlots.Checked = False
		Me.mnuPlots.Enabled = True
		Me.mnuPlots.Visible = True
		Me.mnu3DPlot.Name = "mnu3DPlot"
		Me.mnu3DPlot.Text = "&3D View..."
		Me.mnu3DPlot.Checked = False
		Me.mnu3DPlot.Enabled = True
		Me.mnu3DPlot.Visible = True
		Me.mnuRadarPlot.Name = "mnuRadarPlot"
		Me.mnuRadarPlot.Text = "&Radar View..."
		Me.mnuRadarPlot.Checked = False
		Me.mnuRadarPlot.Enabled = True
		Me.mnuRadarPlot.Visible = True
		Me.mnuMoorLayoutReport.Name = "mnuMoorLayoutReport"
		Me.mnuMoorLayoutReport.Text = "Mooring Layout Report..."
		Me.mnuMoorLayoutReport.Checked = False
		Me.mnuMoorLayoutReport.Enabled = True
		Me.mnuMoorLayoutReport.Visible = True
		Me.mnuTools.Name = "mnuTools"
		Me.mnuTools.Text = "&Analyses"
		Me.mnuTools.Checked = False
		Me.mnuTools.Enabled = True
		Me.mnuTools.Visible = True
		Me.mnuMoor.Name = "mnuMoor"
		Me.mnuMoor.Text = "Mooring &Analysis..."
		Me.mnuMoor.Checked = False
		Me.mnuMoor.Enabled = True
		Me.mnuMoor.Visible = True
		Me.mnuTransient.Name = "mnuTransient"
		Me.mnuTransient.Text = "&Transient Analysis..."
		Me.mnuTransient.Checked = False
		Me.mnuTransient.Enabled = True
		Me.mnuTransient.Visible = True
		Me.mnuMove.Name = "mnuMove"
		Me.mnuMove.Text = "Vessel &Moving Around..."
		Me.mnuMove.Checked = False
		Me.mnuMove.Enabled = True
		Me.mnuMove.Visible = True
		Me.mnuSep.Enabled = True
		Me.mnuSep.Visible = True
		Me.mnuSep.Name = "mnuSep"
		Me.mnuAnalysesB.Name = "mnuAnalysesB"
		Me.mnuAnalysesB.Text = "&Collinear Multi-heading Analyses..."
		Me.mnuAnalysesB.Checked = False
		Me.mnuAnalysesB.Enabled = True
		Me.mnuAnalysesB.Visible = True
		Me.mnuLinTools.Enabled = True
		Me.mnuLinTools.Visible = True
		Me.mnuLinTools.Name = "mnuLinTools"
		Me.mnuOnBoard.Name = "mnuOnBoard"
		Me.mnuOnBoard.Text = "Export for &OnBoard Stability Analysis"
		Me.mnuOnBoard.Checked = False
		Me.mnuOnBoard.Enabled = True
		Me.mnuOnBoard.Visible = True
		Me.mnuOptions.Name = "mnuOptions"
		Me.mnuOptions.Text = "&Options"
		Me.mnuOptions.Checked = False
		Me.mnuOptions.Enabled = True
		Me.mnuOptions.Visible = True
		Me.mnuHelp.Name = "mnuHelp"
		Me.mnuHelp.Text = "&Help"
		Me.mnuHelp.Checked = False
		Me.mnuHelp.Enabled = True
		Me.mnuHelp.Visible = True
		Me.mnuHelpAbout.Name = "mnuHelpAbout"
		Me.mnuHelpAbout.Text = "&About MARS..."
		Me.mnuHelpAbout.Checked = False
		Me.mnuHelpAbout.Enabled = True
		Me.mnuHelpAbout.Visible = True
		Me.Controls.Add(fraReport)
		Me.Controls.Add(fraMooring)
		Me.Controls.Add(_btnPlot_1)
		Me.Controls.Add(_btnPlot_0)
		Me.Controls.Add(fraWell)
		Me.Controls.Add(fraVesselLoc)
		Me.Controls.Add(_lblForceUnit_0)
		Me.Controls.Add(_lblVelUnit_0)
		Me.Controls.Add(lblVessel)
		Me.fraReport.Controls.Add(txtLocationName)
		Me.fraReport.Controls.Add(txtClientName)
		Me.fraReport.Controls.Add(lblLocation)
		Me.fraReport.Controls.Add(lblClientName)
		Me.fraMooring.Controls.Add(btnMooring)
		Me.fraMooring.Controls.Add(btnEnv)
		Me.fraMooring.Controls.Add(btnUpdate)
		Me.fraMooring.Controls.Add(grdEL)
		Me.fraMooring.Controls.Add(SysInfo1)
		Me.fraMooring.Controls.Add(grdLD)
		Me.fraWell.Controls.Add(btnWell)
		Me.fraWell.Controls.Add(_txtWell_2)
		Me.fraWell.Controls.Add(_txtWell_1)
		Me.fraWell.Controls.Add(_txtWell_0)
		Me.fraWell.Controls.Add(cboWells)
		Me.fraWell.Controls.Add(_lblLengthUnit_2)
		Me.fraWell.Controls.Add(_lblLengthUnit_1)
		Me.fraWell.Controls.Add(_lblLengthUnit_0)
		Me.fraWell.Controls.Add(_lblWell_2)
		Me.fraWell.Controls.Add(_lblWell_1)
		Me.fraWell.Controls.Add(_lblWell_0)
		Me.fraVesselLoc.Controls.Add(_optInputSystem_1)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_5)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_4)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_1)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_0)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_3)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_2)
		Me.fraVesselLoc.Controls.Add(_optInputSystem_0)
		Me.fraVesselLoc.Controls.Add(_lblAngleUnit_1)
		Me.fraVesselLoc.Controls.Add(_lblLengthUnit_6)
		Me.fraVesselLoc.Controls.Add(_lblLengthUnit_5)
		Me.fraVesselLoc.Controls.Add(_lblLengthUnit_4)
		Me.fraVesselLoc.Controls.Add(_lblLengthUnit_3)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_2)
		Me.fraVesselLoc.Controls.Add(_lblAngleUnit_0)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_4)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_1)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_0)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_5)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_3)
		Me.btnPlot.SetIndex(_btnPlot_1, CType(1, Short))
		Me.btnPlot.SetIndex(_btnPlot_0, CType(0, Short))
		Me.lblAngleUnit.SetIndex(_lblAngleUnit_1, CType(1, Short))
		Me.lblAngleUnit.SetIndex(_lblAngleUnit_0, CType(0, Short))
		Me.lblForceUnit.SetIndex(_lblForceUnit_0, CType(0, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_2, CType(2, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_1, CType(1, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_0, CType(0, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_6, CType(6, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_5, CType(5, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_4, CType(4, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_3, CType(3, Short))
		Me.lblVelUnit.SetIndex(_lblVelUnit_0, CType(0, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_2, CType(2, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_4, CType(4, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_1, CType(1, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_0, CType(0, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_5, CType(5, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_3, CType(3, Short))
		Me.lblWell.SetIndex(_lblWell_2, CType(2, Short))
		Me.lblWell.SetIndex(_lblWell_1, CType(1, Short))
		Me.lblWell.SetIndex(_lblWell_0, CType(0, Short))
		Me.mnuFilePre.SetIndex(_mnuFilePre_0, CType(0, Short))
		Me.mnuFilePre.SetIndex(_mnuFilePre_1, CType(1, Short))
		Me.mnuFilePre.SetIndex(_mnuFilePre_2, CType(2, Short))
		Me.mnuFilePre.SetIndex(_mnuFilePre_3, CType(3, Short))
		Me.optInputSystem.SetIndex(_optInputSystem_1, CType(1, Short))
		Me.optInputSystem.SetIndex(_optInputSystem_0, CType(0, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_5, CType(5, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_4, CType(4, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_1, CType(1, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_0, CType(0, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_3, CType(3, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_2, CType(2, Short))
		Me.txtWell.SetIndex(_txtWell_2, CType(2, Short))
		Me.txtWell.SetIndex(_txtWell_1, CType(1, Short))
		Me.txtWell.SetIndex(_txtWell_0, CType(0, Short))
		CType(Me.txtWell, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtVslSt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optInputSystem, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.mnuFilePre, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblWell, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblVslSt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblLengthUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblAngleUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.btnPlot, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdLD, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SysInfo1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdEL, System.ComponentModel.ISupportInitialize).EndInit()
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuFile, Me.mnuInput, Me.mnuPlots, Me.mnuTools, Me.mnuOptions, Me.mnuHelp})
		mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuFileNew, Me.mnuFileOpen, Me.mnuLine1, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuLine2, Me.mnuFilePrintSetup, Me.mnuLine3, Me._mnuFilePre_0, Me._mnuFilePre_1, Me._mnuFilePre_2, Me._mnuFilePre_3, Me.mnuLinePreFile, Me.mnuFileExit})
		mnuInput.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuInpProjDes, Me.mnuLineInp, Me.mnuInpEnviron, Me.mnuInpMoor, Me.mnuInpFC})
		mnuPlots.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnu3DPlot, Me.mnuRadarPlot, Me.mnuMoorLayoutReport})
		mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuMoor, Me.mnuTransient, Me.mnuMove, Me.mnuSep, Me.mnuAnalysesB, Me.mnuLinTools, Me.mnuOnBoard})
		mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuHelpAbout})
		Me.Controls.Add(MainMenu1)
		Me.fraReport.ResumeLayout(False)
		Me.fraMooring.ResumeLayout(False)
		Me.fraWell.ResumeLayout(False)
		Me.fraVesselLoc.ResumeLayout(False)
		Me.MainMenu1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class