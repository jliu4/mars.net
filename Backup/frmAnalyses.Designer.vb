<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAnalyses
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
	Public WithEvents _txtPercentDamping_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtPercentDamping_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtPercentDamping_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblMotion_7 As System.Windows.Forms.Label
	Public WithEvents _lblPercentDamping_3 As System.Windows.Forms.Label
	Public WithEvents _lblPercentDamping_2 As System.Windows.Forms.Label
	Public WithEvents _lblPercentDamping_1 As System.Windows.Forms.Label
	Public WithEvents fraDamping As System.Windows.Forms.GroupBox
	Public WithEvents btnSave As System.Windows.Forms.Button
	Public WithEvents btnReport As System.Windows.Forms.Button
	Public WithEvents txtReportTitle As System.Windows.Forms.TextBox
	Public WithEvents txtSubTitle As System.Windows.Forms.TextBox
	Public WithEvents lblClientName As System.Windows.Forms.Label
	Public WithEvents lblLocation As System.Windows.Forms.Label
	Public WithEvents fraReport As System.Windows.Forms.GroupBox
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnAnalysis As System.Windows.Forms.Button
	Public WithEvents txtWaterDepth As System.Windows.Forms.TextBox
	Public WithEvents _txtVslSt_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtVslSt_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtVslSt_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtVslSt_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblLengthUnit_7 As System.Windows.Forms.Label
	Public WithEvents _lblWell_2 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_2 As System.Windows.Forms.Label
	Public WithEvents _lblAngleUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblVslSt_2 As System.Windows.Forms.Label
	Public WithEvents _lblVslSt_1 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_1 As System.Windows.Forms.Label
	Public WithEvents _lblVslSt_0 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblVslSt_3 As System.Windows.Forms.Label
	Public WithEvents fraVesselLoc As System.Windows.Forms.GroupBox
	Public WithEvents txtBearing As System.Windows.Forms.TextBox
	Public WithEvents btnDerp As System.Windows.Forms.Button
	Public WithEvents txtCurWell As System.Windows.Forms.TextBox
	Public WithEvents _txtMotion_6 As System.Windows.Forms.TextBox
	Public WithEvents _txtMotion_5 As System.Windows.Forms.TextBox
	Public WithEvents _txtMotion_4 As System.Windows.Forms.TextBox
	Public WithEvents _txtMotion_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtMotion_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtMotion_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtMotion_0 As System.Windows.Forms.TextBox
	Public WithEvents grdVM As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents _lblMotion_8 As System.Windows.Forms.Label
	Public WithEvents _lblAngleUnit_2 As System.Windows.Forms.Label
	Public WithEvents _lblAngleUnit_1 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_6 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_5 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_4 As System.Windows.Forms.Label
	Public WithEvents _lblMotion_6 As System.Windows.Forms.Label
	Public WithEvents _lblMotion_5 As System.Windows.Forms.Label
	Public WithEvents _lblMotion_4 As System.Windows.Forms.Label
	Public WithEvents _lblMotion_3 As System.Windows.Forms.Label
	Public WithEvents _lblMotion_2 As System.Windows.Forms.Label
	Public WithEvents _lblPercentUnit_1 As System.Windows.Forms.Label
	Public WithEvents _lblMotion_1 As System.Windows.Forms.Label
	Public WithEvents _lblPercentUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_3 As System.Windows.Forms.Label
	Public WithEvents _lblMotion_0 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents grdTensions As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents _lblGenCmt_0 As System.Windows.Forms.Label
	Public WithEvents _lblGenCmt_1 As System.Windows.Forms.Label
	Public WithEvents fraConditions As System.Windows.Forms.GroupBox
	Public WithEvents btnEnvironment As System.Windows.Forms.Button
	Public WithEvents txtEnvironment As System.Windows.Forms.TextBox
	Public WithEvents fraEnvironment As System.Windows.Forms.GroupBox
	Public WithEvents SysInfo1 As AxSysInfoLib.AxSysInfo
	Public WithEvents _lblForceUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblVelUnit_0 As System.Windows.Forms.Label
	Public WithEvents lblAngleUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblForceUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblGenCmt As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblLengthUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblMotion As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblPercentDamping As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblPercentUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVelUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVslSt As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblWell As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents txtMotion As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtPercentDamping As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtVslSt As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAnalyses))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.fraDamping = New System.Windows.Forms.GroupBox
		Me._txtPercentDamping_2 = New System.Windows.Forms.TextBox
		Me._txtPercentDamping_1 = New System.Windows.Forms.TextBox
		Me._txtPercentDamping_0 = New System.Windows.Forms.TextBox
		Me._lblMotion_7 = New System.Windows.Forms.Label
		Me._lblPercentDamping_3 = New System.Windows.Forms.Label
		Me._lblPercentDamping_2 = New System.Windows.Forms.Label
		Me._lblPercentDamping_1 = New System.Windows.Forms.Label
		Me.btnSave = New System.Windows.Forms.Button
		Me.fraReport = New System.Windows.Forms.GroupBox
		Me.btnReport = New System.Windows.Forms.Button
		Me.txtReportTitle = New System.Windows.Forms.TextBox
		Me.txtSubTitle = New System.Windows.Forms.TextBox
		Me.lblClientName = New System.Windows.Forms.Label
		Me.lblLocation = New System.Windows.Forms.Label
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnAnalysis = New System.Windows.Forms.Button
		Me.fraVesselLoc = New System.Windows.Forms.GroupBox
		Me.txtWaterDepth = New System.Windows.Forms.TextBox
		Me._txtVslSt_3 = New System.Windows.Forms.TextBox
		Me._txtVslSt_2 = New System.Windows.Forms.TextBox
		Me._txtVslSt_1 = New System.Windows.Forms.TextBox
		Me._txtVslSt_0 = New System.Windows.Forms.TextBox
		Me._lblLengthUnit_7 = New System.Windows.Forms.Label
		Me._lblWell_2 = New System.Windows.Forms.Label
		Me._lblLengthUnit_2 = New System.Windows.Forms.Label
		Me._lblAngleUnit_0 = New System.Windows.Forms.Label
		Me._lblVslSt_2 = New System.Windows.Forms.Label
		Me._lblVslSt_1 = New System.Windows.Forms.Label
		Me._lblLengthUnit_1 = New System.Windows.Forms.Label
		Me._lblVslSt_0 = New System.Windows.Forms.Label
		Me._lblLengthUnit_0 = New System.Windows.Forms.Label
		Me._lblVslSt_3 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.txtBearing = New System.Windows.Forms.TextBox
		Me.btnDerp = New System.Windows.Forms.Button
		Me.txtCurWell = New System.Windows.Forms.TextBox
		Me._txtMotion_6 = New System.Windows.Forms.TextBox
		Me._txtMotion_5 = New System.Windows.Forms.TextBox
		Me._txtMotion_4 = New System.Windows.Forms.TextBox
		Me._txtMotion_3 = New System.Windows.Forms.TextBox
		Me._txtMotion_2 = New System.Windows.Forms.TextBox
		Me._txtMotion_1 = New System.Windows.Forms.TextBox
		Me._txtMotion_0 = New System.Windows.Forms.TextBox
		Me.grdVM = New AxMSFlexGridLib.AxMSFlexGrid
		Me._lblMotion_8 = New System.Windows.Forms.Label
		Me._lblAngleUnit_2 = New System.Windows.Forms.Label
		Me._lblAngleUnit_1 = New System.Windows.Forms.Label
		Me._lblLengthUnit_6 = New System.Windows.Forms.Label
		Me._lblLengthUnit_5 = New System.Windows.Forms.Label
		Me._lblLengthUnit_4 = New System.Windows.Forms.Label
		Me._lblMotion_6 = New System.Windows.Forms.Label
		Me._lblMotion_5 = New System.Windows.Forms.Label
		Me._lblMotion_4 = New System.Windows.Forms.Label
		Me._lblMotion_3 = New System.Windows.Forms.Label
		Me._lblMotion_2 = New System.Windows.Forms.Label
		Me._lblPercentUnit_1 = New System.Windows.Forms.Label
		Me._lblMotion_1 = New System.Windows.Forms.Label
		Me._lblPercentUnit_0 = New System.Windows.Forms.Label
		Me._lblLengthUnit_3 = New System.Windows.Forms.Label
		Me._lblMotion_0 = New System.Windows.Forms.Label
		Me.fraConditions = New System.Windows.Forms.GroupBox
		Me.grdTensions = New AxMSFlexGridLib.AxMSFlexGrid
		Me._lblGenCmt_0 = New System.Windows.Forms.Label
		Me._lblGenCmt_1 = New System.Windows.Forms.Label
		Me.fraEnvironment = New System.Windows.Forms.GroupBox
		Me.btnEnvironment = New System.Windows.Forms.Button
		Me.txtEnvironment = New System.Windows.Forms.TextBox
		Me.SysInfo1 = New AxSysInfoLib.AxSysInfo
		Me._lblForceUnit_0 = New System.Windows.Forms.Label
		Me._lblVelUnit_0 = New System.Windows.Forms.Label
		Me.lblAngleUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblForceUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblGenCmt = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblLengthUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblMotion = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblPercentDamping = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblPercentUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVelUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVslSt = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblWell = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.txtMotion = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtPercentDamping = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtVslSt = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.fraDamping.SuspendLayout()
		Me.fraReport.SuspendLayout()
		Me.fraVesselLoc.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.fraConditions.SuspendLayout()
		Me.fraEnvironment.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.grdVM, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.grdTensions, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SysInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblAngleUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblGenCmt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblLengthUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblMotion, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblPercentDamping, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblPercentUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVslSt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblWell, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtMotion, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPercentDamping, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtVslSt, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = " Mooring Analysis"
		Me.ClientSize = New System.Drawing.Size(612, 668)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.Icon = CType(resources.GetObject("frmAnalyses.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
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
		Me.Name = "frmAnalyses"
		Me.fraDamping.Text = "Mooring System Damping (% Critical)"
		Me.fraDamping.Size = New System.Drawing.Size(286, 85)
		Me.fraDamping.Location = New System.Drawing.Point(239, 121)
		Me.fraDamping.TabIndex = 53
		Me.fraDamping.BackColor = System.Drawing.SystemColors.Control
		Me.fraDamping.Enabled = True
		Me.fraDamping.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDamping.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDamping.Visible = True
		Me.fraDamping.Name = "fraDamping"
		Me._txtPercentDamping_2.AutoSize = False
		Me._txtPercentDamping_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtPercentDamping_2.Size = New System.Drawing.Size(29, 19)
		Me._txtPercentDamping_2.Location = New System.Drawing.Point(214, 24)
		Me._txtPercentDamping_2.TabIndex = 56
		Me._txtPercentDamping_2.AcceptsReturn = True
		Me._txtPercentDamping_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtPercentDamping_2.CausesValidation = True
		Me._txtPercentDamping_2.Enabled = True
		Me._txtPercentDamping_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPercentDamping_2.HideSelection = True
		Me._txtPercentDamping_2.ReadOnly = False
		Me._txtPercentDamping_2.Maxlength = 0
		Me._txtPercentDamping_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPercentDamping_2.MultiLine = False
		Me._txtPercentDamping_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPercentDamping_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPercentDamping_2.TabStop = True
		Me._txtPercentDamping_2.Visible = True
		Me._txtPercentDamping_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPercentDamping_2.Name = "_txtPercentDamping_2"
		Me._txtPercentDamping_1.AutoSize = False
		Me._txtPercentDamping_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtPercentDamping_1.Size = New System.Drawing.Size(29, 19)
		Me._txtPercentDamping_1.Location = New System.Drawing.Point(147, 24)
		Me._txtPercentDamping_1.TabIndex = 55
		Me._txtPercentDamping_1.AcceptsReturn = True
		Me._txtPercentDamping_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtPercentDamping_1.CausesValidation = True
		Me._txtPercentDamping_1.Enabled = True
		Me._txtPercentDamping_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPercentDamping_1.HideSelection = True
		Me._txtPercentDamping_1.ReadOnly = False
		Me._txtPercentDamping_1.Maxlength = 0
		Me._txtPercentDamping_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPercentDamping_1.MultiLine = False
		Me._txtPercentDamping_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPercentDamping_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPercentDamping_1.TabStop = True
		Me._txtPercentDamping_1.Visible = True
		Me._txtPercentDamping_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPercentDamping_1.Name = "_txtPercentDamping_1"
		Me._txtPercentDamping_0.AutoSize = False
		Me._txtPercentDamping_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtPercentDamping_0.Size = New System.Drawing.Size(29, 19)
		Me._txtPercentDamping_0.Location = New System.Drawing.Point(76, 24)
		Me._txtPercentDamping_0.TabIndex = 54
		Me._txtPercentDamping_0.AcceptsReturn = True
		Me._txtPercentDamping_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtPercentDamping_0.CausesValidation = True
		Me._txtPercentDamping_0.Enabled = True
		Me._txtPercentDamping_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPercentDamping_0.HideSelection = True
		Me._txtPercentDamping_0.ReadOnly = False
		Me._txtPercentDamping_0.Maxlength = 0
		Me._txtPercentDamping_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPercentDamping_0.MultiLine = False
		Me._txtPercentDamping_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPercentDamping_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPercentDamping_0.TabStop = True
		Me._txtPercentDamping_0.Visible = True
		Me._txtPercentDamping_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPercentDamping_0.Name = "_txtPercentDamping_0"
		Me._lblMotion_7.Text = "Must run No Env Case First to Get System Critical Damping "
		Me._lblMotion_7.ForeColor = System.Drawing.Color.Red
		Me._lblMotion_7.Size = New System.Drawing.Size(202, 30)
		Me._lblMotion_7.Location = New System.Drawing.Point(41, 51)
		Me._lblMotion_7.TabIndex = 63
		Me._lblMotion_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblMotion_7.BackColor = System.Drawing.SystemColors.Control
		Me._lblMotion_7.Enabled = True
		Me._lblMotion_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblMotion_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblMotion_7.UseMnemonic = True
		Me._lblMotion_7.Visible = True
		Me._lblMotion_7.AutoSize = False
		Me._lblMotion_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblMotion_7.Name = "_lblMotion_7"
		Me._lblPercentDamping_3.Text = "Yaw"
		Me._lblPercentDamping_3.Size = New System.Drawing.Size(29, 17)
		Me._lblPercentDamping_3.Location = New System.Drawing.Point(186, 26)
		Me._lblPercentDamping_3.TabIndex = 59
		Me._lblPercentDamping_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblPercentDamping_3.BackColor = System.Drawing.SystemColors.Control
		Me._lblPercentDamping_3.Enabled = True
		Me._lblPercentDamping_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPercentDamping_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPercentDamping_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPercentDamping_3.UseMnemonic = True
		Me._lblPercentDamping_3.Visible = True
		Me._lblPercentDamping_3.AutoSize = False
		Me._lblPercentDamping_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPercentDamping_3.Name = "_lblPercentDamping_3"
		Me._lblPercentDamping_2.Text = "Sway"
		Me._lblPercentDamping_2.Size = New System.Drawing.Size(34, 17)
		Me._lblPercentDamping_2.Location = New System.Drawing.Point(116, 26)
		Me._lblPercentDamping_2.TabIndex = 58
		Me._lblPercentDamping_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblPercentDamping_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblPercentDamping_2.Enabled = True
		Me._lblPercentDamping_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPercentDamping_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPercentDamping_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPercentDamping_2.UseMnemonic = True
		Me._lblPercentDamping_2.Visible = True
		Me._lblPercentDamping_2.AutoSize = False
		Me._lblPercentDamping_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPercentDamping_2.Name = "_lblPercentDamping_2"
		Me._lblPercentDamping_1.Text = "Surge"
		Me._lblPercentDamping_1.Size = New System.Drawing.Size(37, 17)
		Me._lblPercentDamping_1.Location = New System.Drawing.Point(40, 26)
		Me._lblPercentDamping_1.TabIndex = 57
		Me._lblPercentDamping_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblPercentDamping_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblPercentDamping_1.Enabled = True
		Me._lblPercentDamping_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPercentDamping_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPercentDamping_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPercentDamping_1.UseMnemonic = True
		Me._lblPercentDamping_1.Visible = True
		Me._lblPercentDamping_1.AutoSize = False
		Me._lblPercentDamping_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPercentDamping_1.Name = "_lblPercentDamping_1"
		Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnSave.Text = "&Save Mean "
		Me.btnSave.Size = New System.Drawing.Size(70, 25)
		Me.btnSave.Location = New System.Drawing.Point(535, 74)
		Me.btnSave.TabIndex = 52
		Me.ToolTip1.SetToolTip(Me.btnSave, "Save Final Mean Position As Current Vessel Station")
		Me.btnSave.BackColor = System.Drawing.SystemColors.Control
		Me.btnSave.CausesValidation = True
		Me.btnSave.Enabled = True
		Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSave.TabStop = True
		Me.btnSave.Name = "btnSave"
		Me.fraReport.Text = "Reporting"
		Me.fraReport.Size = New System.Drawing.Size(284, 104)
		Me.fraReport.Location = New System.Drawing.Point(240, 10)
		Me.fraReport.TabIndex = 46
		Me.fraReport.BackColor = System.Drawing.SystemColors.Control
		Me.fraReport.Enabled = True
		Me.fraReport.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraReport.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraReport.Visible = True
		Me.fraReport.Name = "fraReport"
		Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnReport.Text = "&Report"
		Me.btnReport.Size = New System.Drawing.Size(70, 25)
		Me.btnReport.Location = New System.Drawing.Point(198, 70)
		Me.btnReport.TabIndex = 51
		Me.btnReport.BackColor = System.Drawing.SystemColors.Control
		Me.btnReport.CausesValidation = True
		Me.btnReport.Enabled = True
		Me.btnReport.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnReport.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnReport.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnReport.TabStop = True
		Me.btnReport.Name = "btnReport"
		Me.txtReportTitle.AutoSize = False
		Me.txtReportTitle.Size = New System.Drawing.Size(194, 19)
		Me.txtReportTitle.Location = New System.Drawing.Point(73, 19)
		Me.txtReportTitle.TabIndex = 48
		Me.txtReportTitle.TabStop = False
		Me.txtReportTitle.Text = "Mooring Analysis Results"
		Me.txtReportTitle.AcceptsReturn = True
		Me.txtReportTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtReportTitle.BackColor = System.Drawing.SystemColors.Window
		Me.txtReportTitle.CausesValidation = True
		Me.txtReportTitle.Enabled = True
		Me.txtReportTitle.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtReportTitle.HideSelection = True
		Me.txtReportTitle.ReadOnly = False
		Me.txtReportTitle.Maxlength = 0
		Me.txtReportTitle.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtReportTitle.MultiLine = False
		Me.txtReportTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtReportTitle.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtReportTitle.Visible = True
		Me.txtReportTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtReportTitle.Name = "txtReportTitle"
		Me.txtSubTitle.AutoSize = False
		Me.txtSubTitle.Size = New System.Drawing.Size(194, 19)
		Me.txtSubTitle.Location = New System.Drawing.Point(73, 44)
		Me.txtSubTitle.TabIndex = 47
		Me.txtSubTitle.TabStop = False
		Me.txtSubTitle.AcceptsReturn = True
		Me.txtSubTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSubTitle.BackColor = System.Drawing.SystemColors.Window
		Me.txtSubTitle.CausesValidation = True
		Me.txtSubTitle.Enabled = True
		Me.txtSubTitle.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSubTitle.HideSelection = True
		Me.txtSubTitle.ReadOnly = False
		Me.txtSubTitle.Maxlength = 0
		Me.txtSubTitle.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSubTitle.MultiLine = False
		Me.txtSubTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSubTitle.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSubTitle.Visible = True
		Me.txtSubTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSubTitle.Name = "txtSubTitle"
		Me.lblClientName.Text = "Main Title:"
		Me.lblClientName.Size = New System.Drawing.Size(73, 17)
		Me.lblClientName.Location = New System.Drawing.Point(13, 22)
		Me.lblClientName.TabIndex = 50
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
		Me.lblLocation.Text = "Metocean:"
		Me.lblLocation.Size = New System.Drawing.Size(62, 17)
		Me.lblLocation.Location = New System.Drawing.Point(13, 46)
		Me.lblLocation.TabIndex = 49
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
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.Size = New System.Drawing.Size(70, 25)
		Me.btnCancel.Location = New System.Drawing.Point(535, 15)
		Me.btnCancel.TabIndex = 41
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.btnCancel.CausesValidation = True
		Me.btnCancel.Enabled = True
		Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCancel.TabStop = True
		Me.btnCancel.Name = "btnCancel"
		Me.btnAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnAnalysis.Text = "St&art"
		Me.btnAnalysis.Size = New System.Drawing.Size(70, 25)
		Me.btnAnalysis.Location = New System.Drawing.Point(535, 45)
		Me.btnAnalysis.TabIndex = 0
		Me.btnAnalysis.BackColor = System.Drawing.SystemColors.Control
		Me.btnAnalysis.CausesValidation = True
		Me.btnAnalysis.Enabled = True
		Me.btnAnalysis.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnAnalysis.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnAnalysis.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnAnalysis.TabStop = True
		Me.btnAnalysis.Name = "btnAnalysis"
		Me.fraVesselLoc.Text = "Current Vessel Station :"
		Me.fraVesselLoc.ForeColor = System.Drawing.Color.Black
		Me.fraVesselLoc.Size = New System.Drawing.Size(215, 133)
		Me.fraVesselLoc.Location = New System.Drawing.Point(12, 73)
		Me.fraVesselLoc.TabIndex = 4
		Me.fraVesselLoc.BackColor = System.Drawing.SystemColors.Control
		Me.fraVesselLoc.Enabled = True
		Me.fraVesselLoc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraVesselLoc.Visible = True
		Me.fraVesselLoc.Name = "fraVesselLoc"
		Me.txtWaterDepth.AutoSize = False
		Me.txtWaterDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtWaterDepth.BackColor = System.Drawing.SystemColors.Control
		Me.txtWaterDepth.Size = New System.Drawing.Size(65, 19)
		Me.txtWaterDepth.Location = New System.Drawing.Point(111, 85)
		Me.txtWaterDepth.ReadOnly = True
		Me.txtWaterDepth.TabIndex = 60
		Me.txtWaterDepth.TabStop = False
		Me.txtWaterDepth.Text = "0"
		Me.txtWaterDepth.AcceptsReturn = True
		Me.txtWaterDepth.CausesValidation = True
		Me.txtWaterDepth.Enabled = True
		Me.txtWaterDepth.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWaterDepth.HideSelection = True
		Me.txtWaterDepth.Maxlength = 0
		Me.txtWaterDepth.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWaterDepth.MultiLine = False
		Me.txtWaterDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWaterDepth.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWaterDepth.Visible = True
		Me.txtWaterDepth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWaterDepth.Name = "txtWaterDepth"
		Me._txtVslSt_3.AutoSize = False
		Me._txtVslSt_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtVslSt_3.BackColor = System.Drawing.SystemColors.Control
		Me._txtVslSt_3.Size = New System.Drawing.Size(37, 19)
		Me._txtVslSt_3.Location = New System.Drawing.Point(139, 107)
		Me._txtVslSt_3.ReadOnly = True
		Me._txtVslSt_3.TabIndex = 15
		Me._txtVslSt_3.TabStop = False
		Me._txtVslSt_3.Text = "0"
		Me._txtVslSt_3.AcceptsReturn = True
		Me._txtVslSt_3.CausesValidation = True
		Me._txtVslSt_3.Enabled = True
		Me._txtVslSt_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVslSt_3.HideSelection = True
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
		Me._txtVslSt_2.Size = New System.Drawing.Size(69, 19)
		Me._txtVslSt_2.Location = New System.Drawing.Point(107, 63)
		Me._txtVslSt_2.TabIndex = 12
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
		Me._txtVslSt_1.AutoSize = False
		Me._txtVslSt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtVslSt_1.Size = New System.Drawing.Size(96, 19)
		Me._txtVslSt_1.Location = New System.Drawing.Point(80, 41)
		Me._txtVslSt_1.TabIndex = 9
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
		Me._txtVslSt_0.Size = New System.Drawing.Size(97, 19)
		Me._txtVslSt_0.Location = New System.Drawing.Point(79, 19)
		Me._txtVslSt_0.TabIndex = 6
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
		Me._lblLengthUnit_7.Text = "ft"
		Me._lblLengthUnit_7.Size = New System.Drawing.Size(9, 17)
		Me._lblLengthUnit_7.Location = New System.Drawing.Point(182, 87)
		Me._lblLengthUnit_7.TabIndex = 62
		Me._lblLengthUnit_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLengthUnit_7.BackColor = System.Drawing.SystemColors.Control
		Me._lblLengthUnit_7.Enabled = True
		Me._lblLengthUnit_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLengthUnit_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLengthUnit_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLengthUnit_7.UseMnemonic = True
		Me._lblLengthUnit_7.Visible = True
		Me._lblLengthUnit_7.AutoSize = False
		Me._lblLengthUnit_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLengthUnit_7.Name = "_lblLengthUnit_7"
		Me._lblWell_2.Text = "Water Depth"
		Me._lblWell_2.Size = New System.Drawing.Size(67, 17)
		Me._lblWell_2.Location = New System.Drawing.Point(38, 88)
		Me._lblWell_2.TabIndex = 61
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
		Me._lblLengthUnit_2.Text = "ft"
		Me._lblLengthUnit_2.Size = New System.Drawing.Size(9, 17)
		Me._lblLengthUnit_2.Location = New System.Drawing.Point(182, 108)
		Me._lblLengthUnit_2.TabIndex = 16
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
		Me._lblAngleUnit_0.Text = "Invalid_string_refer_to_original_code"
		Me._lblAngleUnit_0.Size = New System.Drawing.Size(17, 17)
		Me._lblAngleUnit_0.Location = New System.Drawing.Point(182, 65)
		Me._lblAngleUnit_0.TabIndex = 13
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
		Me._lblVslSt_2.Text = "Heading"
		Me._lblVslSt_2.Size = New System.Drawing.Size(49, 17)
		Me._lblVslSt_2.Location = New System.Drawing.Point(38, 66)
		Me._lblVslSt_2.TabIndex = 11
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
		Me._lblVslSt_1.Text = "y (N)"
		Me._lblVslSt_1.Size = New System.Drawing.Size(33, 17)
		Me._lblVslSt_1.Location = New System.Drawing.Point(38, 44)
		Me._lblVslSt_1.TabIndex = 8
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
		Me._lblLengthUnit_1.Text = "ft"
		Me._lblLengthUnit_1.Size = New System.Drawing.Size(9, 17)
		Me._lblLengthUnit_1.Location = New System.Drawing.Point(182, 44)
		Me._lblLengthUnit_1.TabIndex = 10
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
		Me._lblVslSt_0.Text = "x (E)"
		Me._lblVslSt_0.Size = New System.Drawing.Size(33, 17)
		Me._lblVslSt_0.Location = New System.Drawing.Point(38, 21)
		Me._lblVslSt_0.TabIndex = 5
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
		Me._lblLengthUnit_0.Text = "ft"
		Me._lblLengthUnit_0.Size = New System.Drawing.Size(17, 17)
		Me._lblLengthUnit_0.Location = New System.Drawing.Point(182, 22)
		Me._lblLengthUnit_0.TabIndex = 7
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
		Me._lblVslSt_3.Text = "Draft"
		Me._lblVslSt_3.Size = New System.Drawing.Size(25, 17)
		Me._lblVslSt_3.Location = New System.Drawing.Point(38, 110)
		Me._lblVslSt_3.TabIndex = 14
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
		Me.Frame1.Text = "Vessel Movement"
		Me.Frame1.Size = New System.Drawing.Size(513, 209)
		Me.Frame1.Location = New System.Drawing.Point(12, 211)
		Me.Frame1.TabIndex = 17
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.txtBearing.AutoSize = False
		Me.txtBearing.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtBearing.BackColor = System.Drawing.SystemColors.Control
		Me.txtBearing.Size = New System.Drawing.Size(47, 19)
		Me.txtBearing.Location = New System.Drawing.Point(433, 143)
		Me.txtBearing.ReadOnly = True
		Me.txtBearing.TabIndex = 65
		Me.txtBearing.Text = "0"
		Me.txtBearing.AcceptsReturn = True
		Me.txtBearing.CausesValidation = True
		Me.txtBearing.Enabled = True
		Me.txtBearing.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtBearing.HideSelection = True
		Me.txtBearing.Maxlength = 0
		Me.txtBearing.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtBearing.MultiLine = False
		Me.txtBearing.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtBearing.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtBearing.TabStop = True
		Me.txtBearing.Visible = True
		Me.txtBearing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtBearing.Name = "txtBearing"
		Me.btnDerp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnDerp.Text = "Update DERP Data"
		Me.btnDerp.Size = New System.Drawing.Size(73, 37)
		Me.btnDerp.Location = New System.Drawing.Point(13, 141)
		Me.btnDerp.TabIndex = 64
		Me.ToolTip1.SetToolTip(Me.btnDerp, "Export to RIGDERP for riser analysis")
		Me.btnDerp.BackColor = System.Drawing.SystemColors.Control
		Me.btnDerp.CausesValidation = True
		Me.btnDerp.Enabled = True
		Me.btnDerp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDerp.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDerp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDerp.TabStop = True
		Me.btnDerp.Name = "btnDerp"
		Me.txtCurWell.AutoSize = False
		Me.txtCurWell.BackColor = System.Drawing.SystemColors.Control
		Me.txtCurWell.Size = New System.Drawing.Size(81, 19)
		Me.txtCurWell.Location = New System.Drawing.Point(128, 144)
		Me.txtCurWell.ReadOnly = True
		Me.txtCurWell.TabIndex = 26
		Me.txtCurWell.Text = "Current Well"
		Me.txtCurWell.AcceptsReturn = True
		Me.txtCurWell.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCurWell.CausesValidation = True
		Me.txtCurWell.Enabled = True
		Me.txtCurWell.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCurWell.HideSelection = True
		Me.txtCurWell.Maxlength = 0
		Me.txtCurWell.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCurWell.MultiLine = False
		Me.txtCurWell.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCurWell.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCurWell.TabStop = True
		Me.txtCurWell.Visible = True
		Me.txtCurWell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCurWell.Name = "txtCurWell"
		Me._txtMotion_6.AutoSize = False
		Me._txtMotion_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtMotion_6.BackColor = System.Drawing.SystemColors.Control
		Me._txtMotion_6.Size = New System.Drawing.Size(48, 19)
		Me._txtMotion_6.Location = New System.Drawing.Point(434, 179)
		Me._txtMotion_6.ReadOnly = True
		Me._txtMotion_6.TabIndex = 36
		Me._txtMotion_6.Text = "0"
		Me._txtMotion_6.AcceptsReturn = True
		Me._txtMotion_6.CausesValidation = True
		Me._txtMotion_6.Enabled = True
		Me._txtMotion_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtMotion_6.HideSelection = True
		Me._txtMotion_6.Maxlength = 0
		Me._txtMotion_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtMotion_6.MultiLine = False
		Me._txtMotion_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtMotion_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtMotion_6.TabStop = True
		Me._txtMotion_6.Visible = True
		Me._txtMotion_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtMotion_6.Name = "_txtMotion_6"
		Me._txtMotion_5.AutoSize = False
		Me._txtMotion_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtMotion_5.BackColor = System.Drawing.SystemColors.Control
		Me._txtMotion_5.Size = New System.Drawing.Size(86, 19)
		Me._txtMotion_5.Location = New System.Drawing.Point(275, 179)
		Me._txtMotion_5.ReadOnly = True
		Me._txtMotion_5.TabIndex = 34
		Me._txtMotion_5.Text = "0"
		Me._txtMotion_5.AcceptsReturn = True
		Me._txtMotion_5.CausesValidation = True
		Me._txtMotion_5.Enabled = True
		Me._txtMotion_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtMotion_5.HideSelection = True
		Me._txtMotion_5.Maxlength = 0
		Me._txtMotion_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtMotion_5.MultiLine = False
		Me._txtMotion_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtMotion_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtMotion_5.TabStop = True
		Me._txtMotion_5.Visible = True
		Me._txtMotion_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtMotion_5.Name = "_txtMotion_5"
		Me._txtMotion_4.AutoSize = False
		Me._txtMotion_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtMotion_4.BackColor = System.Drawing.SystemColors.Control
		Me._txtMotion_4.Size = New System.Drawing.Size(86, 19)
		Me._txtMotion_4.Location = New System.Drawing.Point(127, 179)
		Me._txtMotion_4.ReadOnly = True
		Me._txtMotion_4.TabIndex = 32
		Me._txtMotion_4.Text = "0"
		Me._txtMotion_4.AcceptsReturn = True
		Me._txtMotion_4.CausesValidation = True
		Me._txtMotion_4.Enabled = True
		Me._txtMotion_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtMotion_4.HideSelection = True
		Me._txtMotion_4.Maxlength = 0
		Me._txtMotion_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtMotion_4.MultiLine = False
		Me._txtMotion_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtMotion_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtMotion_4.TabStop = True
		Me._txtMotion_4.Visible = True
		Me._txtMotion_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtMotion_4.Name = "_txtMotion_4"
		Me._txtMotion_3.AutoSize = False
		Me._txtMotion_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtMotion_3.BackColor = System.Drawing.SystemColors.Control
		Me._txtMotion_3.Size = New System.Drawing.Size(57, 19)
		Me._txtMotion_3.Location = New System.Drawing.Point(320, 144)
		Me._txtMotion_3.ReadOnly = True
		Me._txtMotion_3.TabIndex = 28
		Me._txtMotion_3.Text = "0"
		Me._txtMotion_3.AcceptsReturn = True
		Me._txtMotion_3.CausesValidation = True
		Me._txtMotion_3.Enabled = True
		Me._txtMotion_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtMotion_3.HideSelection = True
		Me._txtMotion_3.Maxlength = 0
		Me._txtMotion_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtMotion_3.MultiLine = False
		Me._txtMotion_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtMotion_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtMotion_3.TabStop = True
		Me._txtMotion_3.Visible = True
		Me._txtMotion_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtMotion_3.Name = "_txtMotion_3"
		Me._txtMotion_2.AutoSize = False
		Me._txtMotion_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtMotion_2.BackColor = System.Drawing.SystemColors.Control
		Me._txtMotion_2.Size = New System.Drawing.Size(57, 19)
		Me._txtMotion_2.Location = New System.Drawing.Point(224, 144)
		Me._txtMotion_2.ReadOnly = True
		Me._txtMotion_2.TabIndex = 27
		Me._txtMotion_2.Text = "0"
		Me._txtMotion_2.AcceptsReturn = True
		Me._txtMotion_2.CausesValidation = True
		Me._txtMotion_2.Enabled = True
		Me._txtMotion_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtMotion_2.HideSelection = True
		Me._txtMotion_2.Maxlength = 0
		Me._txtMotion_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtMotion_2.MultiLine = False
		Me._txtMotion_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtMotion_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtMotion_2.TabStop = True
		Me._txtMotion_2.Visible = True
		Me._txtMotion_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtMotion_2.Name = "_txtMotion_2"
		Me._txtMotion_1.AutoSize = False
		Me._txtMotion_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtMotion_1.BackColor = System.Drawing.SystemColors.Control
		Me._txtMotion_1.Size = New System.Drawing.Size(57, 19)
		Me._txtMotion_1.Location = New System.Drawing.Point(320, 120)
		Me._txtMotion_1.ReadOnly = True
		Me._txtMotion_1.TabIndex = 23
		Me._txtMotion_1.Text = "0"
		Me._txtMotion_1.AcceptsReturn = True
		Me._txtMotion_1.CausesValidation = True
		Me._txtMotion_1.Enabled = True
		Me._txtMotion_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtMotion_1.HideSelection = True
		Me._txtMotion_1.Maxlength = 0
		Me._txtMotion_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtMotion_1.MultiLine = False
		Me._txtMotion_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtMotion_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtMotion_1.TabStop = True
		Me._txtMotion_1.Visible = True
		Me._txtMotion_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtMotion_1.Name = "_txtMotion_1"
		Me._txtMotion_0.AutoSize = False
		Me._txtMotion_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtMotion_0.BackColor = System.Drawing.SystemColors.Control
		Me._txtMotion_0.Size = New System.Drawing.Size(57, 19)
		Me._txtMotion_0.Location = New System.Drawing.Point(224, 119)
		Me._txtMotion_0.ReadOnly = True
		Me._txtMotion_0.TabIndex = 21
		Me._txtMotion_0.Text = "0"
		Me._txtMotion_0.AcceptsReturn = True
		Me._txtMotion_0.CausesValidation = True
		Me._txtMotion_0.Enabled = True
		Me._txtMotion_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtMotion_0.HideSelection = True
		Me._txtMotion_0.Maxlength = 0
		Me._txtMotion_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtMotion_0.MultiLine = False
		Me._txtMotion_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtMotion_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtMotion_0.TabStop = True
		Me._txtMotion_0.Visible = True
		Me._txtMotion_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtMotion_0.Name = "_txtMotion_0"
		grdVM.OcxState = CType(resources.GetObject("grdVM.OcxState"), System.Windows.Forms.AxHost.State)
		Me.grdVM.Size = New System.Drawing.Size(482, 83)
		Me.grdVM.Location = New System.Drawing.Point(14, 23)
		Me.grdVM.TabIndex = 18
		Me.grdVM.Name = "grdVM"
		Me._lblMotion_8.Text = "Bearing:"
		Me._lblMotion_8.Size = New System.Drawing.Size(63, 17)
		Me._lblMotion_8.Location = New System.Drawing.Point(432, 120)
		Me._lblMotion_8.TabIndex = 67
		Me._lblMotion_8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblMotion_8.BackColor = System.Drawing.SystemColors.Control
		Me._lblMotion_8.Enabled = True
		Me._lblMotion_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblMotion_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblMotion_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblMotion_8.UseMnemonic = True
		Me._lblMotion_8.Visible = True
		Me._lblMotion_8.AutoSize = False
		Me._lblMotion_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblMotion_8.Name = "_lblMotion_8"
		Me._lblAngleUnit_2.Text = "Invalid_string_refer_to_original_code"
		Me._lblAngleUnit_2.Size = New System.Drawing.Size(17, 17)
		Me._lblAngleUnit_2.Location = New System.Drawing.Point(487, 143)
		Me._lblAngleUnit_2.TabIndex = 66
		Me._lblAngleUnit_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblAngleUnit_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblAngleUnit_2.Enabled = True
		Me._lblAngleUnit_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblAngleUnit_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblAngleUnit_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblAngleUnit_2.UseMnemonic = True
		Me._lblAngleUnit_2.Visible = True
		Me._lblAngleUnit_2.AutoSize = False
		Me._lblAngleUnit_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblAngleUnit_2.Name = "_lblAngleUnit_2"
		Me._lblAngleUnit_1.Text = "Invalid_string_refer_to_original_code"
		Me._lblAngleUnit_1.Size = New System.Drawing.Size(17, 17)
		Me._lblAngleUnit_1.Location = New System.Drawing.Point(486, 175)
		Me._lblAngleUnit_1.TabIndex = 45
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
		Me._lblLengthUnit_6.Size = New System.Drawing.Size(17, 17)
		Me._lblLengthUnit_6.Location = New System.Drawing.Point(364, 183)
		Me._lblLengthUnit_6.TabIndex = 44
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
		Me._lblLengthUnit_5.Size = New System.Drawing.Size(17, 17)
		Me._lblLengthUnit_5.Location = New System.Drawing.Point(220, 182)
		Me._lblLengthUnit_5.TabIndex = 43
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
		Me._lblLengthUnit_4.Size = New System.Drawing.Size(17, 17)
		Me._lblLengthUnit_4.Location = New System.Drawing.Point(287, 144)
		Me._lblLengthUnit_4.TabIndex = 42
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
		Me._lblMotion_6.Text = "Heading"
		Me._lblMotion_6.Size = New System.Drawing.Size(49, 17)
		Me._lblMotion_6.Location = New System.Drawing.Point(387, 180)
		Me._lblMotion_6.TabIndex = 35
		Me._lblMotion_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblMotion_6.BackColor = System.Drawing.SystemColors.Control
		Me._lblMotion_6.Enabled = True
		Me._lblMotion_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblMotion_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblMotion_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblMotion_6.UseMnemonic = True
		Me._lblMotion_6.Visible = True
		Me._lblMotion_6.AutoSize = False
		Me._lblMotion_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblMotion_6.Name = "_lblMotion_6"
		Me._lblMotion_5.Text = "y (N)"
		Me._lblMotion_5.Size = New System.Drawing.Size(33, 17)
		Me._lblMotion_5.Location = New System.Drawing.Point(249, 181)
		Me._lblMotion_5.TabIndex = 33
		Me._lblMotion_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblMotion_5.BackColor = System.Drawing.SystemColors.Control
		Me._lblMotion_5.Enabled = True
		Me._lblMotion_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblMotion_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblMotion_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblMotion_5.UseMnemonic = True
		Me._lblMotion_5.Visible = True
		Me._lblMotion_5.AutoSize = False
		Me._lblMotion_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblMotion_5.Name = "_lblMotion_5"
		Me._lblMotion_4.Text = "x (E)"
		Me._lblMotion_4.Size = New System.Drawing.Size(33, 17)
		Me._lblMotion_4.Location = New System.Drawing.Point(101, 181)
		Me._lblMotion_4.TabIndex = 31
		Me._lblMotion_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblMotion_4.BackColor = System.Drawing.SystemColors.Control
		Me._lblMotion_4.Enabled = True
		Me._lblMotion_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblMotion_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblMotion_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblMotion_4.UseMnemonic = True
		Me._lblMotion_4.Visible = True
		Me._lblMotion_4.AutoSize = False
		Me._lblMotion_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblMotion_4.Name = "_lblMotion_4"
		Me._lblMotion_3.Text = "Mean Position:"
		Me._lblMotion_3.Size = New System.Drawing.Size(77, 17)
		Me._lblMotion_3.Location = New System.Drawing.Point(16, 181)
		Me._lblMotion_3.TabIndex = 30
		Me._lblMotion_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblMotion_3.BackColor = System.Drawing.SystemColors.Control
		Me._lblMotion_3.Enabled = True
		Me._lblMotion_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblMotion_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblMotion_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblMotion_3.UseMnemonic = True
		Me._lblMotion_3.Visible = True
		Me._lblMotion_3.AutoSize = False
		Me._lblMotion_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblMotion_3.Name = "_lblMotion_3"
		Me._lblMotion_2.Text = "from"
		Me._lblMotion_2.Size = New System.Drawing.Size(25, 17)
		Me._lblMotion_2.Location = New System.Drawing.Point(104, 146)
		Me._lblMotion_2.TabIndex = 25
		Me._lblMotion_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblMotion_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblMotion_2.Enabled = True
		Me._lblMotion_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblMotion_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblMotion_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblMotion_2.UseMnemonic = True
		Me._lblMotion_2.Visible = True
		Me._lblMotion_2.AutoSize = False
		Me._lblMotion_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblMotion_2.Name = "_lblMotion_2"
		Me._lblPercentUnit_1.Text = "% WD"
		Me._lblPercentUnit_1.Size = New System.Drawing.Size(33, 17)
		Me._lblPercentUnit_1.Location = New System.Drawing.Point(384, 146)
		Me._lblPercentUnit_1.TabIndex = 29
		Me._lblPercentUnit_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblPercentUnit_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblPercentUnit_1.Enabled = True
		Me._lblPercentUnit_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPercentUnit_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPercentUnit_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPercentUnit_1.UseMnemonic = True
		Me._lblPercentUnit_1.Visible = True
		Me._lblPercentUnit_1.AutoSize = False
		Me._lblPercentUnit_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPercentUnit_1.Name = "_lblPercentUnit_1"
		Me._lblMotion_1.Text = "from Current Location"
		Me._lblMotion_1.Size = New System.Drawing.Size(113, 17)
		Me._lblMotion_1.Location = New System.Drawing.Point(104, 120)
		Me._lblMotion_1.TabIndex = 20
		Me._lblMotion_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblMotion_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblMotion_1.Enabled = True
		Me._lblMotion_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblMotion_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblMotion_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblMotion_1.UseMnemonic = True
		Me._lblMotion_1.Visible = True
		Me._lblMotion_1.AutoSize = False
		Me._lblMotion_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblMotion_1.Name = "_lblMotion_1"
		Me._lblPercentUnit_0.Text = "% WD"
		Me._lblPercentUnit_0.Size = New System.Drawing.Size(33, 17)
		Me._lblPercentUnit_0.Location = New System.Drawing.Point(384, 122)
		Me._lblPercentUnit_0.TabIndex = 24
		Me._lblPercentUnit_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblPercentUnit_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblPercentUnit_0.Enabled = True
		Me._lblPercentUnit_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPercentUnit_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPercentUnit_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPercentUnit_0.UseMnemonic = True
		Me._lblPercentUnit_0.Visible = True
		Me._lblPercentUnit_0.AutoSize = False
		Me._lblPercentUnit_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPercentUnit_0.Name = "_lblPercentUnit_0"
		Me._lblLengthUnit_3.Text = "ft"
		Me._lblLengthUnit_3.Size = New System.Drawing.Size(17, 17)
		Me._lblLengthUnit_3.Location = New System.Drawing.Point(288, 120)
		Me._lblLengthUnit_3.TabIndex = 22
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
		Me._lblMotion_0.Text = "Maximum Offset:"
		Me._lblMotion_0.Size = New System.Drawing.Size(81, 17)
		Me._lblMotion_0.Location = New System.Drawing.Point(16, 120)
		Me._lblMotion_0.TabIndex = 19
		Me._lblMotion_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblMotion_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblMotion_0.Enabled = True
		Me._lblMotion_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblMotion_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblMotion_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblMotion_0.UseMnemonic = True
		Me._lblMotion_0.Visible = True
		Me._lblMotion_0.AutoSize = False
		Me._lblMotion_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblMotion_0.Name = "_lblMotion_0"
		Me.fraConditions.Text = "Mooring Line Status"
		Me.fraConditions.ForeColor = System.Drawing.Color.Black
		Me.fraConditions.Size = New System.Drawing.Size(513, 233)
		Me.fraConditions.Location = New System.Drawing.Point(12, 425)
		Me.fraConditions.TabIndex = 37
		Me.fraConditions.BackColor = System.Drawing.SystemColors.Control
		Me.fraConditions.Enabled = True
		Me.fraConditions.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraConditions.Visible = True
		Me.fraConditions.Name = "fraConditions"
		grdTensions.OcxState = CType(resources.GetObject("grdTensions.OcxState"), System.Windows.Forms.AxHost.State)
		Me.grdTensions.Size = New System.Drawing.Size(486, 177)
		Me.grdTensions.Location = New System.Drawing.Point(16, 24)
		Me.grdTensions.TabIndex = 38
		Me.grdTensions.Name = "grdTensions"
		Me._lblGenCmt_0.Text = "The above maximum tension and FOS are of the top segment of each line."
		Me._lblGenCmt_0.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._lblGenCmt_0.Size = New System.Drawing.Size(361, 17)
		Me._lblGenCmt_0.Location = New System.Drawing.Point(32, 208)
		Me._lblGenCmt_0.TabIndex = 40
		Me._lblGenCmt_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblGenCmt_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblGenCmt_0.Enabled = True
		Me._lblGenCmt_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblGenCmt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblGenCmt_0.UseMnemonic = True
		Me._lblGenCmt_0.Visible = True
		Me._lblGenCmt_0.AutoSize = False
		Me._lblGenCmt_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblGenCmt_0.Name = "_lblGenCmt_0"
		Me._lblGenCmt_1.Text = "*"
		Me._lblGenCmt_1.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._lblGenCmt_1.Size = New System.Drawing.Size(9, 17)
		Me._lblGenCmt_1.Location = New System.Drawing.Point(16, 208)
		Me._lblGenCmt_1.TabIndex = 39
		Me._lblGenCmt_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblGenCmt_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblGenCmt_1.Enabled = True
		Me._lblGenCmt_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblGenCmt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblGenCmt_1.UseMnemonic = True
		Me._lblGenCmt_1.Visible = True
		Me._lblGenCmt_1.AutoSize = False
		Me._lblGenCmt_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblGenCmt_1.Name = "_lblGenCmt_1"
		Me.fraEnvironment.Text = "Environment Condition"
		Me.fraEnvironment.ForeColor = System.Drawing.Color.Black
		Me.fraEnvironment.Size = New System.Drawing.Size(214, 58)
		Me.fraEnvironment.Location = New System.Drawing.Point(13, 8)
		Me.fraEnvironment.TabIndex = 1
		Me.fraEnvironment.BackColor = System.Drawing.SystemColors.Control
		Me.fraEnvironment.Enabled = True
		Me.fraEnvironment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraEnvironment.Visible = True
		Me.fraEnvironment.Name = "fraEnvironment"
		Me.btnEnvironment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnEnvironment.Text = "Edit..."
		Me.btnEnvironment.Size = New System.Drawing.Size(52, 25)
		Me.btnEnvironment.Location = New System.Drawing.Point(149, 19)
		Me.btnEnvironment.TabIndex = 3
		Me.btnEnvironment.BackColor = System.Drawing.SystemColors.Control
		Me.btnEnvironment.CausesValidation = True
		Me.btnEnvironment.Enabled = True
		Me.btnEnvironment.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnEnvironment.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnEnvironment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnEnvironment.TabStop = True
		Me.btnEnvironment.Name = "btnEnvironment"
		Me.txtEnvironment.AutoSize = False
		Me.txtEnvironment.BackColor = System.Drawing.SystemColors.Control
		Me.txtEnvironment.Size = New System.Drawing.Size(126, 19)
		Me.txtEnvironment.Location = New System.Drawing.Point(16, 24)
		Me.txtEnvironment.ReadOnly = True
		Me.txtEnvironment.TabIndex = 2
		Me.txtEnvironment.Text = "Current Environment"
		Me.txtEnvironment.AcceptsReturn = True
		Me.txtEnvironment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtEnvironment.CausesValidation = True
		Me.txtEnvironment.Enabled = True
		Me.txtEnvironment.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEnvironment.HideSelection = True
		Me.txtEnvironment.Maxlength = 0
		Me.txtEnvironment.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEnvironment.MultiLine = False
		Me.txtEnvironment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEnvironment.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEnvironment.TabStop = True
		Me.txtEnvironment.Visible = True
		Me.txtEnvironment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtEnvironment.Name = "txtEnvironment"
		SysInfo1.OcxState = CType(resources.GetObject("SysInfo1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.SysInfo1.Location = New System.Drawing.Point(2, 335)
		Me.SysInfo1.Name = "SysInfo1"
		Me._lblForceUnit_0.Text = "kips"
		Me._lblForceUnit_0.Size = New System.Drawing.Size(25, 17)
		Me._lblForceUnit_0.Location = New System.Drawing.Point(1, 16)
		Me._lblForceUnit_0.TabIndex = 69
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
		Me._lblVelUnit_0.TabIndex = 68
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
		Me.Controls.Add(fraDamping)
		Me.Controls.Add(btnSave)
		Me.Controls.Add(fraReport)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(btnAnalysis)
		Me.Controls.Add(fraVesselLoc)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(fraConditions)
		Me.Controls.Add(fraEnvironment)
		Me.Controls.Add(SysInfo1)
		Me.Controls.Add(_lblForceUnit_0)
		Me.Controls.Add(_lblVelUnit_0)
		Me.fraDamping.Controls.Add(_txtPercentDamping_2)
		Me.fraDamping.Controls.Add(_txtPercentDamping_1)
		Me.fraDamping.Controls.Add(_txtPercentDamping_0)
		Me.fraDamping.Controls.Add(_lblMotion_7)
		Me.fraDamping.Controls.Add(_lblPercentDamping_3)
		Me.fraDamping.Controls.Add(_lblPercentDamping_2)
		Me.fraDamping.Controls.Add(_lblPercentDamping_1)
		Me.fraReport.Controls.Add(btnReport)
		Me.fraReport.Controls.Add(txtReportTitle)
		Me.fraReport.Controls.Add(txtSubTitle)
		Me.fraReport.Controls.Add(lblClientName)
		Me.fraReport.Controls.Add(lblLocation)
		Me.fraVesselLoc.Controls.Add(txtWaterDepth)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_3)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_2)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_1)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_0)
		Me.fraVesselLoc.Controls.Add(_lblLengthUnit_7)
		Me.fraVesselLoc.Controls.Add(_lblWell_2)
		Me.fraVesselLoc.Controls.Add(_lblLengthUnit_2)
		Me.fraVesselLoc.Controls.Add(_lblAngleUnit_0)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_2)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_1)
		Me.fraVesselLoc.Controls.Add(_lblLengthUnit_1)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_0)
		Me.fraVesselLoc.Controls.Add(_lblLengthUnit_0)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_3)
		Me.Frame1.Controls.Add(txtBearing)
		Me.Frame1.Controls.Add(btnDerp)
		Me.Frame1.Controls.Add(txtCurWell)
		Me.Frame1.Controls.Add(_txtMotion_6)
		Me.Frame1.Controls.Add(_txtMotion_5)
		Me.Frame1.Controls.Add(_txtMotion_4)
		Me.Frame1.Controls.Add(_txtMotion_3)
		Me.Frame1.Controls.Add(_txtMotion_2)
		Me.Frame1.Controls.Add(_txtMotion_1)
		Me.Frame1.Controls.Add(_txtMotion_0)
		Me.Frame1.Controls.Add(grdVM)
		Me.Frame1.Controls.Add(_lblMotion_8)
		Me.Frame1.Controls.Add(_lblAngleUnit_2)
		Me.Frame1.Controls.Add(_lblAngleUnit_1)
		Me.Frame1.Controls.Add(_lblLengthUnit_6)
		Me.Frame1.Controls.Add(_lblLengthUnit_5)
		Me.Frame1.Controls.Add(_lblLengthUnit_4)
		Me.Frame1.Controls.Add(_lblMotion_6)
		Me.Frame1.Controls.Add(_lblMotion_5)
		Me.Frame1.Controls.Add(_lblMotion_4)
		Me.Frame1.Controls.Add(_lblMotion_3)
		Me.Frame1.Controls.Add(_lblMotion_2)
		Me.Frame1.Controls.Add(_lblPercentUnit_1)
		Me.Frame1.Controls.Add(_lblMotion_1)
		Me.Frame1.Controls.Add(_lblPercentUnit_0)
		Me.Frame1.Controls.Add(_lblLengthUnit_3)
		Me.Frame1.Controls.Add(_lblMotion_0)
		Me.fraConditions.Controls.Add(grdTensions)
		Me.fraConditions.Controls.Add(_lblGenCmt_0)
		Me.fraConditions.Controls.Add(_lblGenCmt_1)
		Me.fraEnvironment.Controls.Add(btnEnvironment)
		Me.fraEnvironment.Controls.Add(txtEnvironment)
		Me.lblAngleUnit.SetIndex(_lblAngleUnit_0, CType(0, Short))
		Me.lblAngleUnit.SetIndex(_lblAngleUnit_2, CType(2, Short))
		Me.lblAngleUnit.SetIndex(_lblAngleUnit_1, CType(1, Short))
		Me.lblForceUnit.SetIndex(_lblForceUnit_0, CType(0, Short))
		Me.lblGenCmt.SetIndex(_lblGenCmt_0, CType(0, Short))
		Me.lblGenCmt.SetIndex(_lblGenCmt_1, CType(1, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_7, CType(7, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_2, CType(2, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_1, CType(1, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_0, CType(0, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_6, CType(6, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_5, CType(5, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_4, CType(4, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_3, CType(3, Short))
		Me.lblMotion.SetIndex(_lblMotion_7, CType(7, Short))
		Me.lblMotion.SetIndex(_lblMotion_8, CType(8, Short))
		Me.lblMotion.SetIndex(_lblMotion_6, CType(6, Short))
		Me.lblMotion.SetIndex(_lblMotion_5, CType(5, Short))
		Me.lblMotion.SetIndex(_lblMotion_4, CType(4, Short))
		Me.lblMotion.SetIndex(_lblMotion_3, CType(3, Short))
		Me.lblMotion.SetIndex(_lblMotion_2, CType(2, Short))
		Me.lblMotion.SetIndex(_lblMotion_1, CType(1, Short))
		Me.lblMotion.SetIndex(_lblMotion_0, CType(0, Short))
		Me.lblPercentDamping.SetIndex(_lblPercentDamping_3, CType(3, Short))
		Me.lblPercentDamping.SetIndex(_lblPercentDamping_2, CType(2, Short))
		Me.lblPercentDamping.SetIndex(_lblPercentDamping_1, CType(1, Short))
		Me.lblPercentUnit.SetIndex(_lblPercentUnit_1, CType(1, Short))
		Me.lblPercentUnit.SetIndex(_lblPercentUnit_0, CType(0, Short))
		Me.lblVelUnit.SetIndex(_lblVelUnit_0, CType(0, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_2, CType(2, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_1, CType(1, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_0, CType(0, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_3, CType(3, Short))
		Me.lblWell.SetIndex(_lblWell_2, CType(2, Short))
		Me.txtMotion.SetIndex(_txtMotion_6, CType(6, Short))
		Me.txtMotion.SetIndex(_txtMotion_5, CType(5, Short))
		Me.txtMotion.SetIndex(_txtMotion_4, CType(4, Short))
		Me.txtMotion.SetIndex(_txtMotion_3, CType(3, Short))
		Me.txtMotion.SetIndex(_txtMotion_2, CType(2, Short))
		Me.txtMotion.SetIndex(_txtMotion_1, CType(1, Short))
		Me.txtMotion.SetIndex(_txtMotion_0, CType(0, Short))
		Me.txtPercentDamping.SetIndex(_txtPercentDamping_2, CType(2, Short))
		Me.txtPercentDamping.SetIndex(_txtPercentDamping_1, CType(1, Short))
		Me.txtPercentDamping.SetIndex(_txtPercentDamping_0, CType(0, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_3, CType(3, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_2, CType(2, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_1, CType(1, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_0, CType(0, Short))
		CType(Me.txtVslSt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPercentDamping, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtMotion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblWell, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblVslSt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblPercentUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblPercentDamping, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblMotion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblLengthUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblGenCmt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblAngleUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SysInfo1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdTensions, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdVM, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraDamping.ResumeLayout(False)
		Me.fraReport.ResumeLayout(False)
		Me.fraVesselLoc.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.fraConditions.ResumeLayout(False)
		Me.fraEnvironment.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class