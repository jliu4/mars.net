<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmEnviron
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
	Public WithEvents _stbStatus_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents stbStatus As System.Windows.Forms.StatusStrip
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnOK As System.Windows.Forms.Button
	Public WithEvents btnForce As System.Windows.Forms.Button
	Public WithEvents picEnviron As System.Windows.Forms.PictureBox
	Public WithEvents grdForce As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents fraForce As System.Windows.Forms.GroupBox
	Public WithEvents _txtVslSt_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtVslSt_1 As System.Windows.Forms.TextBox
	Public WithEvents _lblVslSt_0 As System.Windows.Forms.Label
	Public WithEvents _lblAngleUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblVslSt_1 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_0 As System.Windows.Forms.Label
	Public WithEvents fraVesselLoc As System.Windows.Forms.GroupBox
	Public WithEvents btnProfile As System.Windows.Forms.Button
	Public WithEvents _txtCurr_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtCurr_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblAngleUnit_3 As System.Windows.Forms.Label
	Public WithEvents _lblVelUnit_1 As System.Windows.Forms.Label
	Public WithEvents _lblCurr_1 As System.Windows.Forms.Label
	Public WithEvents _lblCurr_0 As System.Windows.Forms.Label
	Public WithEvents fraCurrent As System.Windows.Forms.GroupBox
	Public WithEvents _txtWave_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtWave_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtWave_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblAngleUnit_2 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_2 As System.Windows.Forms.Label
	Public WithEvents _lblWave_2 As System.Windows.Forms.Label
	Public WithEvents _lblWave_1 As System.Windows.Forms.Label
	Public WithEvents _lblWaveUnit_1 As System.Windows.Forms.Label
	Public WithEvents _lblWave_0 As System.Windows.Forms.Label
	Public WithEvents fraWave As System.Windows.Forms.GroupBox
	Public WithEvents _btrDuration_2 As System.Windows.Forms.RadioButton
	Public WithEvents _btrDuration_1 As System.Windows.Forms.RadioButton
	Public WithEvents _btrDuration_0 As System.Windows.Forms.RadioButton
	Public WithEvents _txtWind_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtWind_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtWind_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblAngleUnit_1 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_1 As System.Windows.Forms.Label
	Public WithEvents _lblWind_2 As System.Windows.Forms.Label
	Public WithEvents _lblWind_1 As System.Windows.Forms.Label
	Public WithEvents _lblWindUnit_1 As System.Windows.Forms.Label
	Public WithEvents _lblWind_0 As System.Windows.Forms.Label
	Public WithEvents _lblVelUnit_0 As System.Windows.Forms.Label
	Public WithEvents fraWind As System.Windows.Forms.GroupBox
	Public WithEvents btnAdd As System.Windows.Forms.Button
	Public WithEvents cboCurEnv As System.Windows.Forms.ComboBox
	Public WithEvents fraCurEnv As System.Windows.Forms.GroupBox
	Public dlgFileOpen As System.Windows.Forms.OpenFileDialog
	Public dlgFileSave As System.Windows.Forms.SaveFileDialog
	Public WithEvents _lblForceUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblVelUnit_2 As System.Windows.Forms.Label
	Public WithEvents _lblGenCmt_0 As System.Windows.Forms.Label
	Public WithEvents btrDuration As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents lblAngleUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblCurr As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblForceUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblGenCmt As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblLengthUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVelUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVslSt As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblWave As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblWaveUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblWind As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblWindUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents txtCurr As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtVslSt As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtWave As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtWind As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuDum As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEnviron))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.stbStatus = New System.Windows.Forms.StatusStrip
		Me._stbStatus_Panel1 = New System.Windows.Forms.ToolStripStatusLabel
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnOK = New System.Windows.Forms.Button
		Me.fraForce = New System.Windows.Forms.GroupBox
		Me.btnForce = New System.Windows.Forms.Button
		Me.picEnviron = New System.Windows.Forms.PictureBox
		Me.grdForce = New AxMSFlexGridLib.AxMSFlexGrid
		Me.fraVesselLoc = New System.Windows.Forms.GroupBox
		Me._txtVslSt_0 = New System.Windows.Forms.TextBox
		Me._txtVslSt_1 = New System.Windows.Forms.TextBox
		Me._lblVslSt_0 = New System.Windows.Forms.Label
		Me._lblAngleUnit_0 = New System.Windows.Forms.Label
		Me._lblVslSt_1 = New System.Windows.Forms.Label
		Me._lblLengthUnit_0 = New System.Windows.Forms.Label
		Me.fraCurrent = New System.Windows.Forms.GroupBox
		Me.btnProfile = New System.Windows.Forms.Button
		Me._txtCurr_1 = New System.Windows.Forms.TextBox
		Me._txtCurr_0 = New System.Windows.Forms.TextBox
		Me._lblAngleUnit_3 = New System.Windows.Forms.Label
		Me._lblVelUnit_1 = New System.Windows.Forms.Label
		Me._lblCurr_1 = New System.Windows.Forms.Label
		Me._lblCurr_0 = New System.Windows.Forms.Label
		Me.fraWave = New System.Windows.Forms.GroupBox
		Me._txtWave_2 = New System.Windows.Forms.TextBox
		Me._txtWave_1 = New System.Windows.Forms.TextBox
		Me._txtWave_0 = New System.Windows.Forms.TextBox
		Me._lblAngleUnit_2 = New System.Windows.Forms.Label
		Me._lblLengthUnit_2 = New System.Windows.Forms.Label
		Me._lblWave_2 = New System.Windows.Forms.Label
		Me._lblWave_1 = New System.Windows.Forms.Label
		Me._lblWaveUnit_1 = New System.Windows.Forms.Label
		Me._lblWave_0 = New System.Windows.Forms.Label
		Me.fraWind = New System.Windows.Forms.GroupBox
		Me._btrDuration_2 = New System.Windows.Forms.RadioButton
		Me._btrDuration_1 = New System.Windows.Forms.RadioButton
		Me._btrDuration_0 = New System.Windows.Forms.RadioButton
		Me._txtWind_2 = New System.Windows.Forms.TextBox
		Me._txtWind_1 = New System.Windows.Forms.TextBox
		Me._txtWind_0 = New System.Windows.Forms.TextBox
		Me._lblAngleUnit_1 = New System.Windows.Forms.Label
		Me._lblLengthUnit_1 = New System.Windows.Forms.Label
		Me._lblWind_2 = New System.Windows.Forms.Label
		Me._lblWind_1 = New System.Windows.Forms.Label
		Me._lblWindUnit_1 = New System.Windows.Forms.Label
		Me._lblWind_0 = New System.Windows.Forms.Label
		Me._lblVelUnit_0 = New System.Windows.Forms.Label
		Me.fraCurEnv = New System.Windows.Forms.GroupBox
		Me.btnAdd = New System.Windows.Forms.Button
		Me.cboCurEnv = New System.Windows.Forms.ComboBox
		Me.dlgFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.dlgFileSave = New System.Windows.Forms.SaveFileDialog
		Me._lblForceUnit_0 = New System.Windows.Forms.Label
		Me._lblVelUnit_2 = New System.Windows.Forms.Label
		Me._lblGenCmt_0 = New System.Windows.Forms.Label
		Me.btrDuration = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.lblAngleUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblCurr = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblForceUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblGenCmt = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblLengthUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVelUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVslSt = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblWave = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblWaveUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblWind = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblWindUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.txtCurr = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtVslSt = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtWave = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtWind = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuDum = New System.Windows.Forms.ToolStripSeparator
		Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem
		Me.stbStatus.SuspendLayout()
		Me.fraForce.SuspendLayout()
		Me.fraVesselLoc.SuspendLayout()
		Me.fraCurrent.SuspendLayout()
		Me.fraWave.SuspendLayout()
		Me.fraWind.SuspendLayout()
		Me.fraCurEnv.SuspendLayout()
		Me.MainMenu1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.grdForce, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.btrDuration, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblAngleUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblCurr, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblGenCmt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblLengthUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVslSt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblWave, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblWaveUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblWind, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblWindUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCurr, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtVslSt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtWave, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtWind, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = " Environment Condition"
		Me.ClientSize = New System.Drawing.Size(595, 528)
		Me.Location = New System.Drawing.Point(10, 36)
		Me.Icon = CType(resources.GetObject("frmEnviron.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmEnviron"
		Me.stbStatus.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.stbStatus.Size = New System.Drawing.Size(595, 25)
		Me.stbStatus.Location = New System.Drawing.Point(0, 503)
		Me.stbStatus.TabIndex = 42
		Me.stbStatus.Name = "stbStatus"
		Me._stbStatus_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me._stbStatus_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me._stbStatus_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._stbStatus_Panel1.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me._stbStatus_Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me._stbStatus_Panel1.Size = New System.Drawing.Size(96, 25)
		Me._stbStatus_Panel1.AutoSize = False
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.btnCancel
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.Size = New System.Drawing.Size(73, 25)
		Me.btnCancel.Location = New System.Drawing.Point(514, 33)
		Me.btnCancel.TabIndex = 1
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.btnCancel.CausesValidation = True
		Me.btnCancel.Enabled = True
		Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCancel.TabStop = True
		Me.btnCancel.Name = "btnCancel"
		Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnOK.Text = "OK"
		Me.btnOK.Size = New System.Drawing.Size(73, 25)
		Me.btnOK.Location = New System.Drawing.Point(514, 5)
		Me.btnOK.TabIndex = 0
		Me.btnOK.BackColor = System.Drawing.SystemColors.Control
		Me.btnOK.CausesValidation = True
		Me.btnOK.Enabled = True
		Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnOK.TabStop = True
		Me.btnOK.Name = "btnOK"
		Me.fraForce.Text = "Environmental Forces :"
		Me.fraForce.Size = New System.Drawing.Size(348, 369)
		Me.fraForce.Location = New System.Drawing.Point(240, 64)
		Me.fraForce.TabIndex = 38
		Me.fraForce.BackColor = System.Drawing.SystemColors.Control
		Me.fraForce.Enabled = True
		Me.fraForce.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraForce.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraForce.Visible = True
		Me.fraForce.Name = "fraForce"
		Me.btnForce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnForce.Text = "Refresh"
		Me.btnForce.Size = New System.Drawing.Size(72, 25)
		Me.btnForce.Location = New System.Drawing.Point(265, 339)
		Me.btnForce.TabIndex = 43
		Me.btnForce.BackColor = System.Drawing.SystemColors.Control
		Me.btnForce.CausesValidation = True
		Me.btnForce.Enabled = True
		Me.btnForce.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnForce.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnForce.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnForce.TabStop = True
		Me.btnForce.Name = "btnForce"
		Me.picEnviron.Size = New System.Drawing.Size(325, 172)
		Me.picEnviron.Location = New System.Drawing.Point(12, 20)
		Me.picEnviron.TabIndex = 39
		Me.picEnviron.TabStop = False
		Me.picEnviron.Dock = System.Windows.Forms.DockStyle.None
		Me.picEnviron.BackColor = System.Drawing.SystemColors.Control
		Me.picEnviron.CausesValidation = True
		Me.picEnviron.Enabled = True
		Me.picEnviron.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picEnviron.Cursor = System.Windows.Forms.Cursors.Default
		Me.picEnviron.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picEnviron.Visible = True
		Me.picEnviron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picEnviron.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picEnviron.Name = "picEnviron"
		grdForce.OcxState = CType(resources.GetObject("grdForce.OcxState"), System.Windows.Forms.AxHost.State)
		Me.grdForce.Size = New System.Drawing.Size(328, 137)
		Me.grdForce.Location = New System.Drawing.Point(8, 200)
		Me.grdForce.TabIndex = 40
		Me.grdForce.Name = "grdForce"
		Me.fraVesselLoc.Text = "Current Vessel Orientation :"
		Me.fraVesselLoc.Size = New System.Drawing.Size(265, 57)
		Me.fraVesselLoc.Location = New System.Drawing.Point(240, 0)
		Me.fraVesselLoc.TabIndex = 5
		Me.fraVesselLoc.BackColor = System.Drawing.SystemColors.Control
		Me.fraVesselLoc.Enabled = True
		Me.fraVesselLoc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraVesselLoc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraVesselLoc.Visible = True
		Me.fraVesselLoc.Name = "fraVesselLoc"
		Me._txtVslSt_0.AutoSize = False
		Me._txtVslSt_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtVslSt_0.BackColor = System.Drawing.SystemColors.Control
		Me._txtVslSt_0.Size = New System.Drawing.Size(49, 19)
		Me._txtVslSt_0.Location = New System.Drawing.Point(72, 24)
		Me._txtVslSt_0.ReadOnly = True
		Me._txtVslSt_0.TabIndex = 7
		Me._txtVslSt_0.Text = "0"
		Me._txtVslSt_0.AcceptsReturn = True
		Me._txtVslSt_0.CausesValidation = True
		Me._txtVslSt_0.Enabled = True
		Me._txtVslSt_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVslSt_0.HideSelection = True
		Me._txtVslSt_0.Maxlength = 0
		Me._txtVslSt_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtVslSt_0.MultiLine = False
		Me._txtVslSt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtVslSt_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtVslSt_0.TabStop = True
		Me._txtVslSt_0.Visible = True
		Me._txtVslSt_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtVslSt_0.Name = "_txtVslSt_0"
		Me._txtVslSt_1.AutoSize = False
		Me._txtVslSt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtVslSt_1.BackColor = System.Drawing.SystemColors.Control
		Me._txtVslSt_1.Size = New System.Drawing.Size(49, 19)
		Me._txtVslSt_1.Location = New System.Drawing.Point(172, 24)
		Me._txtVslSt_1.ReadOnly = True
		Me._txtVslSt_1.TabIndex = 10
		Me._txtVslSt_1.Text = "0"
		Me._txtVslSt_1.AcceptsReturn = True
		Me._txtVslSt_1.CausesValidation = True
		Me._txtVslSt_1.Enabled = True
		Me._txtVslSt_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtVslSt_1.HideSelection = True
		Me._txtVslSt_1.Maxlength = 0
		Me._txtVslSt_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtVslSt_1.MultiLine = False
		Me._txtVslSt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtVslSt_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtVslSt_1.TabStop = True
		Me._txtVslSt_1.Visible = True
		Me._txtVslSt_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtVslSt_1.Name = "_txtVslSt_1"
		Me._lblVslSt_0.Text = "Heading"
		Me._lblVslSt_0.Size = New System.Drawing.Size(41, 17)
		Me._lblVslSt_0.Location = New System.Drawing.Point(24, 24)
		Me._lblVslSt_0.TabIndex = 6
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
		Me._lblAngleUnit_0.Text = "Invalid_string_refer_to_original_code"
		Me._lblAngleUnit_0.Size = New System.Drawing.Size(17, 17)
		Me._lblAngleUnit_0.Location = New System.Drawing.Point(124, 24)
		Me._lblAngleUnit_0.TabIndex = 8
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
		Me._lblVslSt_1.Text = "Draft"
		Me._lblVslSt_1.Size = New System.Drawing.Size(33, 17)
		Me._lblVslSt_1.Location = New System.Drawing.Point(144, 24)
		Me._lblVslSt_1.TabIndex = 9
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
		Me._lblLengthUnit_0.Text = "ft"
		Me._lblLengthUnit_0.Size = New System.Drawing.Size(9, 17)
		Me._lblLengthUnit_0.Location = New System.Drawing.Point(224, 24)
		Me._lblLengthUnit_0.TabIndex = 11
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
		Me.fraCurrent.Text = "Current :"
		Me.fraCurrent.Size = New System.Drawing.Size(225, 113)
		Me.fraCurrent.Location = New System.Drawing.Point(8, 320)
		Me.fraCurrent.TabIndex = 32
		Me.fraCurrent.BackColor = System.Drawing.SystemColors.Control
		Me.fraCurrent.Enabled = True
		Me.fraCurrent.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraCurrent.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraCurrent.Visible = True
		Me.fraCurrent.Name = "fraCurrent"
		Me.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnProfile.Text = "&Profile"
		Me.btnProfile.Enabled = False
		Me.btnProfile.Size = New System.Drawing.Size(63, 25)
		Me.btnProfile.Location = New System.Drawing.Point(113, 73)
		Me.btnProfile.TabIndex = 37
		Me.btnProfile.BackColor = System.Drawing.SystemColors.Control
		Me.btnProfile.CausesValidation = True
		Me.btnProfile.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnProfile.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnProfile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnProfile.TabStop = True
		Me.btnProfile.Name = "btnProfile"
		Me._txtCurr_1.AutoSize = False
		Me._txtCurr_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtCurr_1.Size = New System.Drawing.Size(57, 19)
		Me._txtCurr_1.Location = New System.Drawing.Point(114, 48)
		Me._txtCurr_1.TabIndex = 36
		Me._txtCurr_1.Text = "0"
		Me._txtCurr_1.AcceptsReturn = True
		Me._txtCurr_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtCurr_1.CausesValidation = True
		Me._txtCurr_1.Enabled = True
		Me._txtCurr_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtCurr_1.HideSelection = True
		Me._txtCurr_1.ReadOnly = False
		Me._txtCurr_1.Maxlength = 0
		Me._txtCurr_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtCurr_1.MultiLine = False
		Me._txtCurr_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtCurr_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtCurr_1.TabStop = True
		Me._txtCurr_1.Visible = True
		Me._txtCurr_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtCurr_1.Name = "_txtCurr_1"
		Me._txtCurr_0.AutoSize = False
		Me._txtCurr_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtCurr_0.Size = New System.Drawing.Size(57, 19)
		Me._txtCurr_0.Location = New System.Drawing.Point(114, 24)
		Me._txtCurr_0.TabIndex = 34
		Me._txtCurr_0.Text = "0"
		Me._txtCurr_0.AcceptsReturn = True
		Me._txtCurr_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtCurr_0.CausesValidation = True
		Me._txtCurr_0.Enabled = True
		Me._txtCurr_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtCurr_0.HideSelection = True
		Me._txtCurr_0.ReadOnly = False
		Me._txtCurr_0.Maxlength = 0
		Me._txtCurr_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtCurr_0.MultiLine = False
		Me._txtCurr_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtCurr_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtCurr_0.TabStop = True
		Me._txtCurr_0.Visible = True
		Me._txtCurr_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtCurr_0.Name = "_txtCurr_0"
		Me._lblAngleUnit_3.Text = "Invalid_string_refer_to_original_code"
		Me._lblAngleUnit_3.Size = New System.Drawing.Size(17, 17)
		Me._lblAngleUnit_3.Location = New System.Drawing.Point(173, 49)
		Me._lblAngleUnit_3.TabIndex = 49
		Me._lblAngleUnit_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblAngleUnit_3.BackColor = System.Drawing.SystemColors.Control
		Me._lblAngleUnit_3.Enabled = True
		Me._lblAngleUnit_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblAngleUnit_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblAngleUnit_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblAngleUnit_3.UseMnemonic = True
		Me._lblAngleUnit_3.Visible = True
		Me._lblAngleUnit_3.AutoSize = False
		Me._lblAngleUnit_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblAngleUnit_3.Name = "_lblAngleUnit_3"
		Me._lblVelUnit_1.Text = "kn"
		Me._lblVelUnit_1.Size = New System.Drawing.Size(34, 17)
		Me._lblVelUnit_1.Location = New System.Drawing.Point(175, 27)
		Me._lblVelUnit_1.TabIndex = 46
		Me._lblVelUnit_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVelUnit_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblVelUnit_1.Enabled = True
		Me._lblVelUnit_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVelUnit_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVelUnit_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVelUnit_1.UseMnemonic = True
		Me._lblVelUnit_1.Visible = True
		Me._lblVelUnit_1.AutoSize = False
		Me._lblVelUnit_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVelUnit_1.Name = "_lblVelUnit_1"
		Me._lblCurr_1.Text = "Heading"
		Me._lblCurr_1.Size = New System.Drawing.Size(65, 17)
		Me._lblCurr_1.Location = New System.Drawing.Point(16, 48)
		Me._lblCurr_1.TabIndex = 35
		Me._lblCurr_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblCurr_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblCurr_1.Enabled = True
		Me._lblCurr_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblCurr_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCurr_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCurr_1.UseMnemonic = True
		Me._lblCurr_1.Visible = True
		Me._lblCurr_1.AutoSize = False
		Me._lblCurr_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblCurr_1.Name = "_lblCurr_1"
		Me._lblCurr_0.Text = "Surface Velocity"
		Me._lblCurr_0.Size = New System.Drawing.Size(89, 17)
		Me._lblCurr_0.Location = New System.Drawing.Point(16, 24)
		Me._lblCurr_0.TabIndex = 33
		Me._lblCurr_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblCurr_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblCurr_0.Enabled = True
		Me._lblCurr_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblCurr_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCurr_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCurr_0.UseMnemonic = True
		Me._lblCurr_0.Visible = True
		Me._lblCurr_0.AutoSize = False
		Me._lblCurr_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblCurr_0.Name = "_lblCurr_0"
		Me.fraWave.Text = "Wave :"
		Me.fraWave.Size = New System.Drawing.Size(225, 105)
		Me.fraWave.Location = New System.Drawing.Point(8, 207)
		Me.fraWave.TabIndex = 24
		Me.fraWave.BackColor = System.Drawing.SystemColors.Control
		Me.fraWave.Enabled = True
		Me.fraWave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraWave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraWave.Visible = True
		Me.fraWave.Name = "fraWave"
		Me._txtWave_2.AutoSize = False
		Me._txtWave_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtWave_2.Size = New System.Drawing.Size(57, 19)
		Me._txtWave_2.Location = New System.Drawing.Point(80, 72)
		Me._txtWave_2.TabIndex = 31
		Me._txtWave_2.Text = "0"
		Me._txtWave_2.AcceptsReturn = True
		Me._txtWave_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtWave_2.CausesValidation = True
		Me._txtWave_2.Enabled = True
		Me._txtWave_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtWave_2.HideSelection = True
		Me._txtWave_2.ReadOnly = False
		Me._txtWave_2.Maxlength = 0
		Me._txtWave_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtWave_2.MultiLine = False
		Me._txtWave_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtWave_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtWave_2.TabStop = True
		Me._txtWave_2.Visible = True
		Me._txtWave_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtWave_2.Name = "_txtWave_2"
		Me._txtWave_1.AutoSize = False
		Me._txtWave_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtWave_1.Size = New System.Drawing.Size(57, 19)
		Me._txtWave_1.Location = New System.Drawing.Point(80, 48)
		Me._txtWave_1.TabIndex = 28
		Me._txtWave_1.Text = "0"
		Me._txtWave_1.AcceptsReturn = True
		Me._txtWave_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtWave_1.CausesValidation = True
		Me._txtWave_1.Enabled = True
		Me._txtWave_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtWave_1.HideSelection = True
		Me._txtWave_1.ReadOnly = False
		Me._txtWave_1.Maxlength = 0
		Me._txtWave_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtWave_1.MultiLine = False
		Me._txtWave_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtWave_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtWave_1.TabStop = True
		Me._txtWave_1.Visible = True
		Me._txtWave_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtWave_1.Name = "_txtWave_1"
		Me._txtWave_0.AutoSize = False
		Me._txtWave_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtWave_0.Size = New System.Drawing.Size(57, 19)
		Me._txtWave_0.Location = New System.Drawing.Point(80, 24)
		Me._txtWave_0.TabIndex = 26
		Me._txtWave_0.Text = "0"
		Me._txtWave_0.AcceptsReturn = True
		Me._txtWave_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtWave_0.CausesValidation = True
		Me._txtWave_0.Enabled = True
		Me._txtWave_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtWave_0.HideSelection = True
		Me._txtWave_0.ReadOnly = False
		Me._txtWave_0.Maxlength = 0
		Me._txtWave_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtWave_0.MultiLine = False
		Me._txtWave_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtWave_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtWave_0.TabStop = True
		Me._txtWave_0.Visible = True
		Me._txtWave_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtWave_0.Name = "_txtWave_0"
		Me._lblAngleUnit_2.Text = "Invalid_string_refer_to_original_code"
		Me._lblAngleUnit_2.Size = New System.Drawing.Size(17, 17)
		Me._lblAngleUnit_2.Location = New System.Drawing.Point(140, 72)
		Me._lblAngleUnit_2.TabIndex = 48
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
		Me._lblLengthUnit_2.Text = "ft"
		Me._lblLengthUnit_2.Size = New System.Drawing.Size(9, 17)
		Me._lblLengthUnit_2.Location = New System.Drawing.Point(143, 26)
		Me._lblLengthUnit_2.TabIndex = 45
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
		Me._lblWave_2.Text = "Heading"
		Me._lblWave_2.Size = New System.Drawing.Size(65, 17)
		Me._lblWave_2.Location = New System.Drawing.Point(16, 72)
		Me._lblWave_2.TabIndex = 30
		Me._lblWave_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWave_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblWave_2.Enabled = True
		Me._lblWave_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWave_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWave_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWave_2.UseMnemonic = True
		Me._lblWave_2.Visible = True
		Me._lblWave_2.AutoSize = False
		Me._lblWave_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWave_2.Name = "_lblWave_2"
		Me._lblWave_1.Text = "Peak Period"
		Me._lblWave_1.Size = New System.Drawing.Size(65, 17)
		Me._lblWave_1.Location = New System.Drawing.Point(16, 48)
		Me._lblWave_1.TabIndex = 27
		Me._lblWave_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWave_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblWave_1.Enabled = True
		Me._lblWave_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWave_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWave_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWave_1.UseMnemonic = True
		Me._lblWave_1.Visible = True
		Me._lblWave_1.AutoSize = False
		Me._lblWave_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWave_1.Name = "_lblWave_1"
		Me._lblWaveUnit_1.Text = "sec"
		Me._lblWaveUnit_1.Size = New System.Drawing.Size(25, 17)
		Me._lblWaveUnit_1.Location = New System.Drawing.Point(142, 47)
		Me._lblWaveUnit_1.TabIndex = 29
		Me._lblWaveUnit_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWaveUnit_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblWaveUnit_1.Enabled = True
		Me._lblWaveUnit_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWaveUnit_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWaveUnit_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWaveUnit_1.UseMnemonic = True
		Me._lblWaveUnit_1.Visible = True
		Me._lblWaveUnit_1.AutoSize = False
		Me._lblWaveUnit_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWaveUnit_1.Name = "_lblWaveUnit_1"
		Me._lblWave_0.Text = "Sig. Height"
		Me._lblWave_0.Size = New System.Drawing.Size(65, 17)
		Me._lblWave_0.Location = New System.Drawing.Point(16, 24)
		Me._lblWave_0.TabIndex = 25
		Me._lblWave_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWave_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblWave_0.Enabled = True
		Me._lblWave_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWave_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWave_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWave_0.UseMnemonic = True
		Me._lblWave_0.Visible = True
		Me._lblWave_0.AutoSize = False
		Me._lblWave_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWave_0.Name = "_lblWave_0"
		Me.fraWind.Text = "Wind :"
		Me.fraWind.Size = New System.Drawing.Size(225, 137)
		Me.fraWind.Location = New System.Drawing.Point(8, 64)
		Me.fraWind.TabIndex = 12
		Me.fraWind.BackColor = System.Drawing.SystemColors.Control
		Me.fraWind.Enabled = True
		Me.fraWind.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraWind.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraWind.Visible = True
		Me.fraWind.Name = "fraWind"
		Me._btrDuration_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._btrDuration_2.Text = "3 seconds"
		Me._btrDuration_2.Size = New System.Drawing.Size(73, 17)
		Me._btrDuration_2.Location = New System.Drawing.Point(136, 72)
		Me._btrDuration_2.TabIndex = 21
		Me._btrDuration_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._btrDuration_2.BackColor = System.Drawing.SystemColors.Control
		Me._btrDuration_2.CausesValidation = True
		Me._btrDuration_2.Enabled = True
		Me._btrDuration_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btrDuration_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._btrDuration_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._btrDuration_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._btrDuration_2.TabStop = True
		Me._btrDuration_2.Checked = False
		Me._btrDuration_2.Visible = True
		Me._btrDuration_2.Name = "_btrDuration_2"
		Me._btrDuration_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._btrDuration_1.Text = "1 minute"
		Me._btrDuration_1.Size = New System.Drawing.Size(65, 17)
		Me._btrDuration_1.Location = New System.Drawing.Point(72, 72)
		Me._btrDuration_1.TabIndex = 20
		Me._btrDuration_1.Checked = True
		Me._btrDuration_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._btrDuration_1.BackColor = System.Drawing.SystemColors.Control
		Me._btrDuration_1.CausesValidation = True
		Me._btrDuration_1.Enabled = True
		Me._btrDuration_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btrDuration_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._btrDuration_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._btrDuration_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._btrDuration_1.TabStop = True
		Me._btrDuration_1.Visible = True
		Me._btrDuration_1.Name = "_btrDuration_1"
		Me._btrDuration_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._btrDuration_0.Text = "1 hour"
		Me._btrDuration_0.Size = New System.Drawing.Size(65, 17)
		Me._btrDuration_0.Location = New System.Drawing.Point(16, 72)
		Me._btrDuration_0.TabIndex = 19
		Me._btrDuration_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._btrDuration_0.BackColor = System.Drawing.SystemColors.Control
		Me._btrDuration_0.CausesValidation = True
		Me._btrDuration_0.Enabled = True
		Me._btrDuration_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btrDuration_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._btrDuration_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._btrDuration_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._btrDuration_0.TabStop = True
		Me._btrDuration_0.Checked = False
		Me._btrDuration_0.Visible = True
		Me._btrDuration_0.Name = "_btrDuration_0"
		Me._txtWind_2.AutoSize = False
		Me._txtWind_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtWind_2.Size = New System.Drawing.Size(57, 19)
		Me._txtWind_2.Location = New System.Drawing.Point(80, 104)
		Me._txtWind_2.TabIndex = 23
		Me._txtWind_2.Text = "0"
		Me._txtWind_2.AcceptsReturn = True
		Me._txtWind_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtWind_2.CausesValidation = True
		Me._txtWind_2.Enabled = True
		Me._txtWind_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtWind_2.HideSelection = True
		Me._txtWind_2.ReadOnly = False
		Me._txtWind_2.Maxlength = 0
		Me._txtWind_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtWind_2.MultiLine = False
		Me._txtWind_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtWind_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtWind_2.TabStop = True
		Me._txtWind_2.Visible = True
		Me._txtWind_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtWind_2.Name = "_txtWind_2"
		Me._txtWind_1.AutoSize = False
		Me._txtWind_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtWind_1.Size = New System.Drawing.Size(57, 19)
		Me._txtWind_1.Location = New System.Drawing.Point(80, 48)
		Me._txtWind_1.TabIndex = 17
		Me._txtWind_1.Text = "0"
		Me._txtWind_1.AcceptsReturn = True
		Me._txtWind_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtWind_1.CausesValidation = True
		Me._txtWind_1.Enabled = True
		Me._txtWind_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtWind_1.HideSelection = True
		Me._txtWind_1.ReadOnly = False
		Me._txtWind_1.Maxlength = 0
		Me._txtWind_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtWind_1.MultiLine = False
		Me._txtWind_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtWind_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtWind_1.TabStop = True
		Me._txtWind_1.Visible = True
		Me._txtWind_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtWind_1.Name = "_txtWind_1"
		Me._txtWind_0.AutoSize = False
		Me._txtWind_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtWind_0.Size = New System.Drawing.Size(57, 19)
		Me._txtWind_0.Location = New System.Drawing.Point(80, 24)
		Me._txtWind_0.TabIndex = 14
		Me._txtWind_0.Text = "0"
		Me._txtWind_0.AcceptsReturn = True
		Me._txtWind_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtWind_0.CausesValidation = True
		Me._txtWind_0.Enabled = True
		Me._txtWind_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtWind_0.HideSelection = True
		Me._txtWind_0.ReadOnly = False
		Me._txtWind_0.Maxlength = 0
		Me._txtWind_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtWind_0.MultiLine = False
		Me._txtWind_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtWind_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtWind_0.TabStop = True
		Me._txtWind_0.Visible = True
		Me._txtWind_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtWind_0.Name = "_txtWind_0"
		Me._lblAngleUnit_1.Text = "Invalid_string_refer_to_original_code"
		Me._lblAngleUnit_1.Size = New System.Drawing.Size(17, 17)
		Me._lblAngleUnit_1.Location = New System.Drawing.Point(140, 104)
		Me._lblAngleUnit_1.TabIndex = 47
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
		Me._lblLengthUnit_1.Text = "ft"
		Me._lblLengthUnit_1.Size = New System.Drawing.Size(9, 17)
		Me._lblLengthUnit_1.Location = New System.Drawing.Point(142, 51)
		Me._lblLengthUnit_1.TabIndex = 44
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
		Me._lblWind_2.Text = "Heading"
		Me._lblWind_2.Size = New System.Drawing.Size(65, 17)
		Me._lblWind_2.Location = New System.Drawing.Point(16, 104)
		Me._lblWind_2.TabIndex = 22
		Me._lblWind_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWind_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblWind_2.Enabled = True
		Me._lblWind_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWind_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWind_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWind_2.UseMnemonic = True
		Me._lblWind_2.Visible = True
		Me._lblWind_2.AutoSize = False
		Me._lblWind_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWind_2.Name = "_lblWind_2"
		Me._lblWind_1.Text = "measured at"
		Me._lblWind_1.Size = New System.Drawing.Size(65, 17)
		Me._lblWind_1.Location = New System.Drawing.Point(16, 48)
		Me._lblWind_1.TabIndex = 16
		Me._lblWind_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWind_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblWind_1.Enabled = True
		Me._lblWind_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWind_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWind_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWind_1.UseMnemonic = True
		Me._lblWind_1.Visible = True
		Me._lblWind_1.AutoSize = False
		Me._lblWind_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWind_1.Name = "_lblWind_1"
		Me._lblWindUnit_1.Text = "above WL"
		Me._lblWindUnit_1.Size = New System.Drawing.Size(53, 17)
		Me._lblWindUnit_1.Location = New System.Drawing.Point(156, 51)
		Me._lblWindUnit_1.TabIndex = 18
		Me._lblWindUnit_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWindUnit_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblWindUnit_1.Enabled = True
		Me._lblWindUnit_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWindUnit_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWindUnit_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWindUnit_1.UseMnemonic = True
		Me._lblWindUnit_1.Visible = True
		Me._lblWindUnit_1.AutoSize = False
		Me._lblWindUnit_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWindUnit_1.Name = "_lblWindUnit_1"
		Me._lblWind_0.Text = "Velocity"
		Me._lblWind_0.Size = New System.Drawing.Size(65, 17)
		Me._lblWind_0.Location = New System.Drawing.Point(16, 24)
		Me._lblWind_0.TabIndex = 13
		Me._lblWind_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblWind_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblWind_0.Enabled = True
		Me._lblWind_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblWind_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblWind_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblWind_0.UseMnemonic = True
		Me._lblWind_0.Visible = True
		Me._lblWind_0.AutoSize = False
		Me._lblWind_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblWind_0.Name = "_lblWind_0"
		Me._lblVelUnit_0.Text = "kn"
		Me._lblVelUnit_0.Size = New System.Drawing.Size(25, 17)
		Me._lblVelUnit_0.Location = New System.Drawing.Point(144, 24)
		Me._lblVelUnit_0.TabIndex = 15
		Me._lblVelUnit_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVelUnit_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblVelUnit_0.Enabled = True
		Me._lblVelUnit_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVelUnit_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVelUnit_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVelUnit_0.UseMnemonic = True
		Me._lblVelUnit_0.Visible = True
		Me._lblVelUnit_0.AutoSize = False
		Me._lblVelUnit_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVelUnit_0.Name = "_lblVelUnit_0"
		Me.fraCurEnv.Text = "Current Environment :"
		Me.fraCurEnv.Size = New System.Drawing.Size(225, 57)
		Me.fraCurEnv.Location = New System.Drawing.Point(8, 0)
		Me.fraCurEnv.TabIndex = 2
		Me.fraCurEnv.BackColor = System.Drawing.SystemColors.Control
		Me.fraCurEnv.Enabled = True
		Me.fraCurEnv.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraCurEnv.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraCurEnv.Visible = True
		Me.fraCurEnv.Name = "fraCurEnv"
		Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnAdd.Text = "&Add/Update"
		Me.btnAdd.Size = New System.Drawing.Size(73, 25)
		Me.btnAdd.Location = New System.Drawing.Point(144, 20)
		Me.btnAdd.TabIndex = 4
		Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
		Me.btnAdd.CausesValidation = True
		Me.btnAdd.Enabled = True
		Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnAdd.TabStop = True
		Me.btnAdd.Name = "btnAdd"
		Me.cboCurEnv.Size = New System.Drawing.Size(121, 21)
		Me.cboCurEnv.Location = New System.Drawing.Point(16, 24)
		Me.cboCurEnv.TabIndex = 3
		Me.cboCurEnv.Text = "Current Environment"
		Me.cboCurEnv.BackColor = System.Drawing.SystemColors.Window
		Me.cboCurEnv.CausesValidation = True
		Me.cboCurEnv.Enabled = True
		Me.cboCurEnv.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCurEnv.IntegralHeight = True
		Me.cboCurEnv.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCurEnv.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCurEnv.Sorted = False
		Me.cboCurEnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCurEnv.TabStop = True
		Me.cboCurEnv.Visible = True
		Me.cboCurEnv.Name = "cboCurEnv"
		Me._lblForceUnit_0.Text = "kips"
		Me._lblForceUnit_0.Size = New System.Drawing.Size(25, 17)
		Me._lblForceUnit_0.Location = New System.Drawing.Point(1, 16)
		Me._lblForceUnit_0.TabIndex = 51
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
		Me._lblVelUnit_2.Text = "kn"
		Me._lblVelUnit_2.Size = New System.Drawing.Size(25, 17)
		Me._lblVelUnit_2.Location = New System.Drawing.Point(0, 0)
		Me._lblVelUnit_2.TabIndex = 50
		Me._lblVelUnit_2.Visible = False
		Me._lblVelUnit_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVelUnit_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblVelUnit_2.Enabled = True
		Me._lblVelUnit_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVelUnit_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVelUnit_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVelUnit_2.UseMnemonic = True
		Me._lblVelUnit_2.AutoSize = False
		Me._lblVelUnit_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVelUnit_2.Name = "_lblVelUnit_2"
		Me._lblGenCmt_0.Text = "1. Environmental Headings indicate the FLOW-TO directions measured              clockwise from the North.                                                                             2. Vessel Heading is measured clockwise from the North.                               3. Force Directions are measured in the local coordinate system as Yaw."
		Me._lblGenCmt_0.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._lblGenCmt_0.Size = New System.Drawing.Size(365, 65)
		Me._lblGenCmt_0.Location = New System.Drawing.Point(24, 440)
		Me._lblGenCmt_0.TabIndex = 41
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
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Text = "&File"
		Me.mnuFile.Checked = False
		Me.mnuFile.Enabled = True
		Me.mnuFile.Visible = True
		Me.mnuOpen.Name = "mnuOpen"
		Me.mnuOpen.Text = "&Import ..."
		Me.mnuOpen.Checked = False
		Me.mnuOpen.Enabled = True
		Me.mnuOpen.Visible = True
		Me.mnuSave.Name = "mnuSave"
		Me.mnuSave.Text = "&Export ..."
		Me.mnuSave.Checked = False
		Me.mnuSave.Enabled = True
		Me.mnuSave.Visible = True
		Me.mnuDum.Enabled = True
		Me.mnuDum.Visible = True
		Me.mnuDum.Name = "mnuDum"
		Me.mnuClose.Name = "mnuClose"
		Me.mnuClose.Text = "&Close"
		Me.mnuClose.Checked = False
		Me.mnuClose.Enabled = True
		Me.mnuClose.Visible = True
		Me.Controls.Add(stbStatus)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(btnOK)
		Me.Controls.Add(fraForce)
		Me.Controls.Add(fraVesselLoc)
		Me.Controls.Add(fraCurrent)
		Me.Controls.Add(fraWave)
		Me.Controls.Add(fraWind)
		Me.Controls.Add(fraCurEnv)
		Me.Controls.Add(_lblForceUnit_0)
		Me.Controls.Add(_lblVelUnit_2)
		Me.Controls.Add(_lblGenCmt_0)
		Me.stbStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me._stbStatus_Panel1})
		Me.fraForce.Controls.Add(btnForce)
		Me.fraForce.Controls.Add(picEnviron)
		Me.fraForce.Controls.Add(grdForce)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_0)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_1)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_0)
		Me.fraVesselLoc.Controls.Add(_lblAngleUnit_0)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_1)
		Me.fraVesselLoc.Controls.Add(_lblLengthUnit_0)
		Me.fraCurrent.Controls.Add(btnProfile)
		Me.fraCurrent.Controls.Add(_txtCurr_1)
		Me.fraCurrent.Controls.Add(_txtCurr_0)
		Me.fraCurrent.Controls.Add(_lblAngleUnit_3)
		Me.fraCurrent.Controls.Add(_lblVelUnit_1)
		Me.fraCurrent.Controls.Add(_lblCurr_1)
		Me.fraCurrent.Controls.Add(_lblCurr_0)
		Me.fraWave.Controls.Add(_txtWave_2)
		Me.fraWave.Controls.Add(_txtWave_1)
		Me.fraWave.Controls.Add(_txtWave_0)
		Me.fraWave.Controls.Add(_lblAngleUnit_2)
		Me.fraWave.Controls.Add(_lblLengthUnit_2)
		Me.fraWave.Controls.Add(_lblWave_2)
		Me.fraWave.Controls.Add(_lblWave_1)
		Me.fraWave.Controls.Add(_lblWaveUnit_1)
		Me.fraWave.Controls.Add(_lblWave_0)
		Me.fraWind.Controls.Add(_btrDuration_2)
		Me.fraWind.Controls.Add(_btrDuration_1)
		Me.fraWind.Controls.Add(_btrDuration_0)
		Me.fraWind.Controls.Add(_txtWind_2)
		Me.fraWind.Controls.Add(_txtWind_1)
		Me.fraWind.Controls.Add(_txtWind_0)
		Me.fraWind.Controls.Add(_lblAngleUnit_1)
		Me.fraWind.Controls.Add(_lblLengthUnit_1)
		Me.fraWind.Controls.Add(_lblWind_2)
		Me.fraWind.Controls.Add(_lblWind_1)
		Me.fraWind.Controls.Add(_lblWindUnit_1)
		Me.fraWind.Controls.Add(_lblWind_0)
		Me.fraWind.Controls.Add(_lblVelUnit_0)
		Me.fraCurEnv.Controls.Add(btnAdd)
		Me.fraCurEnv.Controls.Add(cboCurEnv)
		Me.btrDuration.SetIndex(_btrDuration_2, CType(2, Short))
		Me.btrDuration.SetIndex(_btrDuration_1, CType(1, Short))
		Me.btrDuration.SetIndex(_btrDuration_0, CType(0, Short))
		Me.lblAngleUnit.SetIndex(_lblAngleUnit_0, CType(0, Short))
		Me.lblAngleUnit.SetIndex(_lblAngleUnit_3, CType(3, Short))
		Me.lblAngleUnit.SetIndex(_lblAngleUnit_2, CType(2, Short))
		Me.lblAngleUnit.SetIndex(_lblAngleUnit_1, CType(1, Short))
		Me.lblCurr.SetIndex(_lblCurr_1, CType(1, Short))
		Me.lblCurr.SetIndex(_lblCurr_0, CType(0, Short))
		Me.lblForceUnit.SetIndex(_lblForceUnit_0, CType(0, Short))
		Me.lblGenCmt.SetIndex(_lblGenCmt_0, CType(0, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_0, CType(0, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_2, CType(2, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_1, CType(1, Short))
		Me.lblVelUnit.SetIndex(_lblVelUnit_1, CType(1, Short))
		Me.lblVelUnit.SetIndex(_lblVelUnit_0, CType(0, Short))
		Me.lblVelUnit.SetIndex(_lblVelUnit_2, CType(2, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_0, CType(0, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_1, CType(1, Short))
		Me.lblWave.SetIndex(_lblWave_2, CType(2, Short))
		Me.lblWave.SetIndex(_lblWave_1, CType(1, Short))
		Me.lblWave.SetIndex(_lblWave_0, CType(0, Short))
		Me.lblWaveUnit.SetIndex(_lblWaveUnit_1, CType(1, Short))
		Me.lblWind.SetIndex(_lblWind_2, CType(2, Short))
		Me.lblWind.SetIndex(_lblWind_1, CType(1, Short))
		Me.lblWind.SetIndex(_lblWind_0, CType(0, Short))
		Me.lblWindUnit.SetIndex(_lblWindUnit_1, CType(1, Short))
		Me.txtCurr.SetIndex(_txtCurr_1, CType(1, Short))
		Me.txtCurr.SetIndex(_txtCurr_0, CType(0, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_0, CType(0, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_1, CType(1, Short))
		Me.txtWave.SetIndex(_txtWave_2, CType(2, Short))
		Me.txtWave.SetIndex(_txtWave_1, CType(1, Short))
		Me.txtWave.SetIndex(_txtWave_0, CType(0, Short))
		Me.txtWind.SetIndex(_txtWind_2, CType(2, Short))
		Me.txtWind.SetIndex(_txtWind_1, CType(1, Short))
		Me.txtWind.SetIndex(_txtWind_0, CType(0, Short))
		CType(Me.txtWind, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtWave, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtVslSt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCurr, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblWindUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblWind, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblWaveUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblWave, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblVslSt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblLengthUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblGenCmt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblCurr, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblAngleUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.btrDuration, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdForce, System.ComponentModel.ISupportInitialize).EndInit()
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuFile})
		mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuOpen, Me.mnuSave, Me.mnuDum, Me.mnuClose})
		Me.Controls.Add(MainMenu1)
		Me.stbStatus.ResumeLayout(False)
		Me.fraForce.ResumeLayout(False)
		Me.fraVesselLoc.ResumeLayout(False)
		Me.fraCurrent.ResumeLayout(False)
		Me.fraWave.ResumeLayout(False)
		Me.fraWind.ResumeLayout(False)
		Me.fraCurEnv.ResumeLayout(False)
		Me.MainMenu1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class