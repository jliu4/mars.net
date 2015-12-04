<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTransient
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
	Public WithEvents btnDisplayCurves As System.Windows.Forms.Button
	Public WithEvents btnReport As System.Windows.Forms.Button
	Public WithEvents btnSetVesselCoords As System.Windows.Forms.Button
	Public WithEvents txtEnvironment As System.Windows.Forms.TextBox
	Public WithEvents btnEnvironment As System.Windows.Forms.Button
	Public WithEvents fraEnvironment As System.Windows.Forms.GroupBox
	Public WithEvents txtDuration As System.Windows.Forms.TextBox
	Public WithEvents txtInterval As System.Windows.Forms.TextBox
	Public WithEvents lblDuration As System.Windows.Forms.Label
	Public WithEvents lblInterval As System.Windows.Forms.Label
	Public WithEvents fraTransientTime As System.Windows.Forms.GroupBox
	Public WithEvents txtMaxOffsetTime As System.Windows.Forms.TextBox
	Public WithEvents txtOffset As System.Windows.Forms.TextBox
	Public WithEvents txtOffsetPWD As System.Windows.Forms.TextBox
	Public WithEvents txtMaxOffset As System.Windows.Forms.TextBox
	Public WithEvents txtMaxOffsetPWD As System.Windows.Forms.TextBox
	Public WithEvents txtOffsetBearing As System.Windows.Forms.TextBox
	Public WithEvents grdTM As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents _lblPercent_2 As System.Windows.Forms.Label
	Public WithEvents _lblVslStUnit_4 As System.Windows.Forms.Label
	Public WithEvents _lblPercent_1 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_0 As System.Windows.Forms.Label
	Public WithEvents lblOffset As System.Windows.Forms.Label
	Public WithEvents lblMaxOffset As System.Windows.Forms.Label
	Public WithEvents _lblPercent_0 As System.Windows.Forms.Label
	Public WithEvents lblBearing As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_1 As System.Windows.Forms.Label
	Public WithEvents fraTransientMotion As System.Windows.Forms.GroupBox
	Public WithEvents grdLC As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents fraMoorLineStatus As System.Windows.Forms.GroupBox
	Public WithEvents btnTransient As System.Windows.Forms.Button
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents picPolar As System.Windows.Forms.PictureBox
	Public WithEvents SysInfo1 As AxSysInfoLib.AxSysInfo
	Public WithEvents _lblForceUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblVelUnit_0 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblForceUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblLengthUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblPercent As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVelUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVslStUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTransient))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.btnDisplayCurves = New System.Windows.Forms.Button
		Me.btnReport = New System.Windows.Forms.Button
		Me.btnSetVesselCoords = New System.Windows.Forms.Button
		Me.fraEnvironment = New System.Windows.Forms.GroupBox
		Me.txtEnvironment = New System.Windows.Forms.TextBox
		Me.btnEnvironment = New System.Windows.Forms.Button
		Me.fraTransientTime = New System.Windows.Forms.GroupBox
		Me.txtDuration = New System.Windows.Forms.TextBox
		Me.txtInterval = New System.Windows.Forms.TextBox
		Me.lblDuration = New System.Windows.Forms.Label
		Me.lblInterval = New System.Windows.Forms.Label
		Me.fraTransientMotion = New System.Windows.Forms.GroupBox
		Me.txtMaxOffsetTime = New System.Windows.Forms.TextBox
		Me.txtOffset = New System.Windows.Forms.TextBox
		Me.txtOffsetPWD = New System.Windows.Forms.TextBox
		Me.txtMaxOffset = New System.Windows.Forms.TextBox
		Me.txtMaxOffsetPWD = New System.Windows.Forms.TextBox
		Me.txtOffsetBearing = New System.Windows.Forms.TextBox
		Me.grdTM = New AxMSFlexGridLib.AxMSFlexGrid
		Me._lblPercent_2 = New System.Windows.Forms.Label
		Me._lblVslStUnit_4 = New System.Windows.Forms.Label
		Me._lblPercent_1 = New System.Windows.Forms.Label
		Me._lblLengthUnit_0 = New System.Windows.Forms.Label
		Me.lblOffset = New System.Windows.Forms.Label
		Me.lblMaxOffset = New System.Windows.Forms.Label
		Me._lblPercent_0 = New System.Windows.Forms.Label
		Me.lblBearing = New System.Windows.Forms.Label
		Me._lblLengthUnit_1 = New System.Windows.Forms.Label
		Me.fraMoorLineStatus = New System.Windows.Forms.GroupBox
		Me.grdLC = New AxMSFlexGridLib.AxMSFlexGrid
		Me.btnTransient = New System.Windows.Forms.Button
		Me.btnCancel = New System.Windows.Forms.Button
		Me.picPolar = New System.Windows.Forms.PictureBox
		Me.SysInfo1 = New AxSysInfoLib.AxSysInfo
		Me._lblForceUnit_0 = New System.Windows.Forms.Label
		Me._lblVelUnit_0 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblForceUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblLengthUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblPercent = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVelUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVslStUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.fraEnvironment.SuspendLayout()
		Me.fraTransientTime.SuspendLayout()
		Me.fraTransientMotion.SuspendLayout()
		Me.fraMoorLineStatus.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.grdTM, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.grdLC, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SysInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblLengthUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblPercent, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVslStUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Transient Analysis"
		Me.ClientSize = New System.Drawing.Size(885, 560)
		Me.Location = New System.Drawing.Point(155, 286)
		Me.Icon = CType(resources.GetObject("frmTransient.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmTransient"
		Me.btnDisplayCurves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnDisplayCurves.Text = "Time History Plots..."
		Me.btnDisplayCurves.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDisplayCurves.Size = New System.Drawing.Size(130, 25)
		Me.btnDisplayCurves.Location = New System.Drawing.Point(206, 234)
		Me.btnDisplayCurves.TabIndex = 33
		Me.ToolTip1.SetToolTip(Me.btnDisplayCurves, "View Transient Line Tension Time History")
		Me.btnDisplayCurves.BackColor = System.Drawing.SystemColors.Control
		Me.btnDisplayCurves.CausesValidation = True
		Me.btnDisplayCurves.Enabled = True
		Me.btnDisplayCurves.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDisplayCurves.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDisplayCurves.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDisplayCurves.TabStop = True
		Me.btnDisplayCurves.Name = "btnDisplayCurves"
		Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnReport.Text = "&Report"
		Me.btnReport.Enabled = False
		Me.btnReport.Size = New System.Drawing.Size(61, 25)
		Me.btnReport.Location = New System.Drawing.Point(213, 45)
		Me.btnReport.TabIndex = 32
		Me.btnReport.BackColor = System.Drawing.SystemColors.Control
		Me.btnReport.CausesValidation = True
		Me.btnReport.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnReport.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnReport.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnReport.TabStop = True
		Me.btnReport.Name = "btnReport"
		Me.btnSetVesselCoords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnSetVesselCoords.Text = "Save"
		Me.btnSetVesselCoords.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSetVesselCoords.Size = New System.Drawing.Size(61, 25)
		Me.btnSetVesselCoords.Location = New System.Drawing.Point(280, 45)
		Me.btnSetVesselCoords.TabIndex = 31
		Me.ToolTip1.SetToolTip(Me.btnSetVesselCoords, "Save Final Vessel Position As Current Vessel Station")
		Me.btnSetVesselCoords.BackColor = System.Drawing.SystemColors.Control
		Me.btnSetVesselCoords.CausesValidation = True
		Me.btnSetVesselCoords.Enabled = True
		Me.btnSetVesselCoords.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSetVesselCoords.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSetVesselCoords.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSetVesselCoords.TabStop = True
		Me.btnSetVesselCoords.Name = "btnSetVesselCoords"
		Me.fraEnvironment.Text = "Environment Condition"
		Me.fraEnvironment.ForeColor = System.Drawing.Color.Black
		Me.fraEnvironment.Size = New System.Drawing.Size(202, 57)
		Me.fraEnvironment.Location = New System.Drawing.Point(7, 8)
		Me.fraEnvironment.TabIndex = 28
		Me.fraEnvironment.BackColor = System.Drawing.SystemColors.Control
		Me.fraEnvironment.Enabled = True
		Me.fraEnvironment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraEnvironment.Visible = True
		Me.fraEnvironment.Name = "fraEnvironment"
		Me.txtEnvironment.AutoSize = False
		Me.txtEnvironment.BackColor = System.Drawing.SystemColors.Control
		Me.txtEnvironment.Size = New System.Drawing.Size(116, 19)
		Me.txtEnvironment.Location = New System.Drawing.Point(16, 25)
		Me.txtEnvironment.ReadOnly = True
		Me.txtEnvironment.TabIndex = 30
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
		Me.btnEnvironment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnEnvironment.Text = "Edit..."
		Me.btnEnvironment.Size = New System.Drawing.Size(48, 25)
		Me.btnEnvironment.Location = New System.Drawing.Point(139, 21)
		Me.btnEnvironment.TabIndex = 29
		Me.btnEnvironment.BackColor = System.Drawing.SystemColors.Control
		Me.btnEnvironment.CausesValidation = True
		Me.btnEnvironment.Enabled = True
		Me.btnEnvironment.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnEnvironment.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnEnvironment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnEnvironment.TabStop = True
		Me.btnEnvironment.Name = "btnEnvironment"
		Me.fraTransientTime.Text = "Time (sec)"
		Me.fraTransientTime.Size = New System.Drawing.Size(134, 79)
		Me.fraTransientTime.Location = New System.Drawing.Point(203, 87)
		Me.fraTransientTime.TabIndex = 7
		Me.fraTransientTime.BackColor = System.Drawing.SystemColors.Control
		Me.fraTransientTime.Enabled = True
		Me.fraTransientTime.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraTransientTime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraTransientTime.Visible = True
		Me.fraTransientTime.Name = "fraTransientTime"
		Me.txtDuration.AutoSize = False
		Me.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtDuration.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDuration.Size = New System.Drawing.Size(49, 21)
		Me.txtDuration.Location = New System.Drawing.Point(69, 22)
		Me.txtDuration.TabIndex = 9
		Me.txtDuration.Text = "200"
		Me.txtDuration.AcceptsReturn = True
		Me.txtDuration.BackColor = System.Drawing.SystemColors.Window
		Me.txtDuration.CausesValidation = True
		Me.txtDuration.Enabled = True
		Me.txtDuration.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDuration.HideSelection = True
		Me.txtDuration.ReadOnly = False
		Me.txtDuration.Maxlength = 0
		Me.txtDuration.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDuration.MultiLine = False
		Me.txtDuration.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDuration.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDuration.TabStop = True
		Me.txtDuration.Visible = True
		Me.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDuration.Name = "txtDuration"
		Me.txtInterval.AutoSize = False
		Me.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtInterval.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtInterval.Size = New System.Drawing.Size(49, 21)
		Me.txtInterval.Location = New System.Drawing.Point(69, 47)
		Me.txtInterval.TabIndex = 8
		Me.txtInterval.Text = "200"
		Me.txtInterval.AcceptsReturn = True
		Me.txtInterval.BackColor = System.Drawing.SystemColors.Window
		Me.txtInterval.CausesValidation = True
		Me.txtInterval.Enabled = True
		Me.txtInterval.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtInterval.HideSelection = True
		Me.txtInterval.ReadOnly = False
		Me.txtInterval.Maxlength = 0
		Me.txtInterval.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtInterval.MultiLine = False
		Me.txtInterval.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtInterval.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtInterval.TabStop = True
		Me.txtInterval.Visible = True
		Me.txtInterval.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtInterval.Name = "txtInterval"
		Me.lblDuration.Text = "Duration"
		Me.lblDuration.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDuration.Size = New System.Drawing.Size(52, 15)
		Me.lblDuration.Location = New System.Drawing.Point(23, 25)
		Me.lblDuration.TabIndex = 11
		Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDuration.BackColor = System.Drawing.SystemColors.Control
		Me.lblDuration.Enabled = True
		Me.lblDuration.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDuration.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDuration.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDuration.UseMnemonic = True
		Me.lblDuration.Visible = True
		Me.lblDuration.AutoSize = False
		Me.lblDuration.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDuration.Name = "lblDuration"
		Me.lblInterval.Text = "Interval"
		Me.lblInterval.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInterval.Size = New System.Drawing.Size(50, 15)
		Me.lblInterval.Location = New System.Drawing.Point(23, 48)
		Me.lblInterval.TabIndex = 10
		Me.lblInterval.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblInterval.BackColor = System.Drawing.SystemColors.Control
		Me.lblInterval.Enabled = True
		Me.lblInterval.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblInterval.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblInterval.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblInterval.UseMnemonic = True
		Me.lblInterval.Visible = True
		Me.lblInterval.AutoSize = False
		Me.lblInterval.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblInterval.Name = "lblInterval"
		Me.fraTransientMotion.Text = "Transient Motion"
		Me.fraTransientMotion.Size = New System.Drawing.Size(327, 287)
		Me.fraTransientMotion.Location = New System.Drawing.Point(7, 265)
		Me.fraTransientMotion.TabIndex = 5
		Me.fraTransientMotion.BackColor = System.Drawing.SystemColors.Control
		Me.fraTransientMotion.Enabled = True
		Me.fraTransientMotion.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraTransientMotion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraTransientMotion.Visible = True
		Me.fraTransientMotion.Name = "fraTransientMotion"
		Me.txtMaxOffsetTime.AutoSize = False
		Me.txtMaxOffsetTime.Size = New System.Drawing.Size(41, 21)
		Me.txtMaxOffsetTime.Location = New System.Drawing.Point(243, 203)
		Me.txtMaxOffsetTime.TabIndex = 26
		Me.txtMaxOffsetTime.AcceptsReturn = True
		Me.txtMaxOffsetTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMaxOffsetTime.BackColor = System.Drawing.SystemColors.Window
		Me.txtMaxOffsetTime.CausesValidation = True
		Me.txtMaxOffsetTime.Enabled = True
		Me.txtMaxOffsetTime.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMaxOffsetTime.HideSelection = True
		Me.txtMaxOffsetTime.ReadOnly = False
		Me.txtMaxOffsetTime.Maxlength = 0
		Me.txtMaxOffsetTime.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMaxOffsetTime.MultiLine = False
		Me.txtMaxOffsetTime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMaxOffsetTime.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaxOffsetTime.TabStop = True
		Me.txtMaxOffsetTime.Visible = True
		Me.txtMaxOffsetTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMaxOffsetTime.Name = "txtMaxOffsetTime"
		Me.txtOffset.AutoSize = False
		Me.txtOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtOffset.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtOffset.Size = New System.Drawing.Size(45, 21)
		Me.txtOffset.Location = New System.Drawing.Point(80, 227)
		Me.txtOffset.TabIndex = 16
		Me.txtOffset.TabStop = False
		Me.txtOffset.Text = "0"
		Me.txtOffset.AcceptsReturn = True
		Me.txtOffset.BackColor = System.Drawing.SystemColors.Window
		Me.txtOffset.CausesValidation = True
		Me.txtOffset.Enabled = True
		Me.txtOffset.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtOffset.HideSelection = True
		Me.txtOffset.ReadOnly = False
		Me.txtOffset.Maxlength = 0
		Me.txtOffset.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtOffset.MultiLine = False
		Me.txtOffset.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtOffset.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtOffset.Visible = True
		Me.txtOffset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtOffset.Name = "txtOffset"
		Me.txtOffsetPWD.AutoSize = False
		Me.txtOffsetPWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtOffsetPWD.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtOffsetPWD.Size = New System.Drawing.Size(40, 21)
		Me.txtOffsetPWD.Location = New System.Drawing.Point(148, 228)
		Me.txtOffsetPWD.TabIndex = 15
		Me.txtOffsetPWD.TabStop = False
		Me.txtOffsetPWD.Text = "0"
		Me.txtOffsetPWD.AcceptsReturn = True
		Me.txtOffsetPWD.BackColor = System.Drawing.SystemColors.Window
		Me.txtOffsetPWD.CausesValidation = True
		Me.txtOffsetPWD.Enabled = True
		Me.txtOffsetPWD.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtOffsetPWD.HideSelection = True
		Me.txtOffsetPWD.ReadOnly = False
		Me.txtOffsetPWD.Maxlength = 0
		Me.txtOffsetPWD.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtOffsetPWD.MultiLine = False
		Me.txtOffsetPWD.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtOffsetPWD.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtOffsetPWD.Visible = True
		Me.txtOffsetPWD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtOffsetPWD.Name = "txtOffsetPWD"
		Me.txtMaxOffset.AutoSize = False
		Me.txtMaxOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtMaxOffset.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMaxOffset.Size = New System.Drawing.Size(45, 21)
		Me.txtMaxOffset.Location = New System.Drawing.Point(80, 202)
		Me.txtMaxOffset.TabIndex = 14
		Me.txtMaxOffset.TabStop = False
		Me.txtMaxOffset.Text = "0"
		Me.txtMaxOffset.AcceptsReturn = True
		Me.txtMaxOffset.BackColor = System.Drawing.SystemColors.Window
		Me.txtMaxOffset.CausesValidation = True
		Me.txtMaxOffset.Enabled = True
		Me.txtMaxOffset.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMaxOffset.HideSelection = True
		Me.txtMaxOffset.ReadOnly = False
		Me.txtMaxOffset.Maxlength = 0
		Me.txtMaxOffset.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMaxOffset.MultiLine = False
		Me.txtMaxOffset.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMaxOffset.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaxOffset.Visible = True
		Me.txtMaxOffset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMaxOffset.Name = "txtMaxOffset"
		Me.txtMaxOffsetPWD.AutoSize = False
		Me.txtMaxOffsetPWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtMaxOffsetPWD.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMaxOffsetPWD.Size = New System.Drawing.Size(40, 21)
		Me.txtMaxOffsetPWD.Location = New System.Drawing.Point(148, 202)
		Me.txtMaxOffsetPWD.TabIndex = 13
		Me.txtMaxOffsetPWD.TabStop = False
		Me.txtMaxOffsetPWD.Text = "0"
		Me.txtMaxOffsetPWD.AcceptsReturn = True
		Me.txtMaxOffsetPWD.BackColor = System.Drawing.SystemColors.Window
		Me.txtMaxOffsetPWD.CausesValidation = True
		Me.txtMaxOffsetPWD.Enabled = True
		Me.txtMaxOffsetPWD.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMaxOffsetPWD.HideSelection = True
		Me.txtMaxOffsetPWD.ReadOnly = False
		Me.txtMaxOffsetPWD.Maxlength = 0
		Me.txtMaxOffsetPWD.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMaxOffsetPWD.MultiLine = False
		Me.txtMaxOffsetPWD.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMaxOffsetPWD.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaxOffsetPWD.Visible = True
		Me.txtMaxOffsetPWD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMaxOffsetPWD.Name = "txtMaxOffsetPWD"
		Me.txtOffsetBearing.AutoSize = False
		Me.txtOffsetBearing.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtOffsetBearing.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtOffsetBearing.Size = New System.Drawing.Size(45, 21)
		Me.txtOffsetBearing.Location = New System.Drawing.Point(80, 252)
		Me.txtOffsetBearing.TabIndex = 12
		Me.txtOffsetBearing.TabStop = False
		Me.txtOffsetBearing.Text = "0"
		Me.txtOffsetBearing.AcceptsReturn = True
		Me.txtOffsetBearing.BackColor = System.Drawing.SystemColors.Window
		Me.txtOffsetBearing.CausesValidation = True
		Me.txtOffsetBearing.Enabled = True
		Me.txtOffsetBearing.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtOffsetBearing.HideSelection = True
		Me.txtOffsetBearing.ReadOnly = False
		Me.txtOffsetBearing.Maxlength = 0
		Me.txtOffsetBearing.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtOffsetBearing.MultiLine = False
		Me.txtOffsetBearing.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtOffsetBearing.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtOffsetBearing.Visible = True
		Me.txtOffsetBearing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtOffsetBearing.Name = "txtOffsetBearing"
		grdTM.OcxState = CType(resources.GetObject("grdTM.OcxState"), System.Windows.Forms.AxHost.State)
		Me.grdTM.Size = New System.Drawing.Size(295, 173)
		Me.grdTM.Location = New System.Drawing.Point(13, 18)
		Me.grdTM.TabIndex = 6
		Me.grdTM.Name = "grdTM"
		Me._lblPercent_2.Text = "sec"
		Me._lblPercent_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblPercent_2.Size = New System.Drawing.Size(24, 13)
		Me._lblPercent_2.Location = New System.Drawing.Point(287, 207)
		Me._lblPercent_2.TabIndex = 27
		Me._lblPercent_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblPercent_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblPercent_2.Enabled = True
		Me._lblPercent_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPercent_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPercent_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPercent_2.UseMnemonic = True
		Me._lblPercent_2.Visible = True
		Me._lblPercent_2.AutoSize = False
		Me._lblPercent_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPercent_2.Name = "_lblPercent_2"
		Me._lblVslStUnit_4.Text = "Invalid_string_refer_to_original_code"
		Me._lblVslStUnit_4.Size = New System.Drawing.Size(17, 17)
		Me._lblVslStUnit_4.Location = New System.Drawing.Point(127, 253)
		Me._lblVslStUnit_4.TabIndex = 24
		Me._lblVslStUnit_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblVslStUnit_4.BackColor = System.Drawing.SystemColors.Control
		Me._lblVslStUnit_4.Enabled = True
		Me._lblVslStUnit_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblVslStUnit_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblVslStUnit_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblVslStUnit_4.UseMnemonic = True
		Me._lblVslStUnit_4.Visible = True
		Me._lblVslStUnit_4.AutoSize = False
		Me._lblVslStUnit_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblVslStUnit_4.Name = "_lblVslStUnit_4"
		Me._lblPercent_1.Text = "% WD"
		Me._lblPercent_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblPercent_1.Size = New System.Drawing.Size(36, 13)
		Me._lblPercent_1.Location = New System.Drawing.Point(192, 232)
		Me._lblPercent_1.TabIndex = 23
		Me._lblPercent_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblPercent_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblPercent_1.Enabled = True
		Me._lblPercent_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPercent_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPercent_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPercent_1.UseMnemonic = True
		Me._lblPercent_1.Visible = True
		Me._lblPercent_1.AutoSize = False
		Me._lblPercent_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPercent_1.Name = "_lblPercent_1"
		Me._lblLengthUnit_0.Text = "ft"
		Me._lblLengthUnit_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblLengthUnit_0.Size = New System.Drawing.Size(15, 17)
		Me._lblLengthUnit_0.Location = New System.Drawing.Point(130, 204)
		Me._lblLengthUnit_0.TabIndex = 22
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
		Me.lblOffset.Text = "Offset"
		Me.lblOffset.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOffset.Size = New System.Drawing.Size(47, 13)
		Me.lblOffset.Location = New System.Drawing.Point(19, 230)
		Me.lblOffset.TabIndex = 21
		Me.lblOffset.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblOffset.BackColor = System.Drawing.SystemColors.Control
		Me.lblOffset.Enabled = True
		Me.lblOffset.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblOffset.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblOffset.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblOffset.UseMnemonic = True
		Me.lblOffset.Visible = True
		Me.lblOffset.AutoSize = False
		Me.lblOffset.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblOffset.Name = "lblOffset"
		Me.lblMaxOffset.Text = "Max Offset"
		Me.lblMaxOffset.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMaxOffset.Size = New System.Drawing.Size(63, 13)
		Me.lblMaxOffset.Location = New System.Drawing.Point(19, 206)
		Me.lblMaxOffset.TabIndex = 20
		Me.lblMaxOffset.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMaxOffset.BackColor = System.Drawing.SystemColors.Control
		Me.lblMaxOffset.Enabled = True
		Me.lblMaxOffset.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMaxOffset.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMaxOffset.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMaxOffset.UseMnemonic = True
		Me.lblMaxOffset.Visible = True
		Me.lblMaxOffset.AutoSize = False
		Me.lblMaxOffset.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMaxOffset.Name = "lblMaxOffset"
		Me._lblPercent_0.Text = "% WD  @"
		Me._lblPercent_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblPercent_0.Size = New System.Drawing.Size(52, 13)
		Me._lblPercent_0.Location = New System.Drawing.Point(192, 206)
		Me._lblPercent_0.TabIndex = 19
		Me._lblPercent_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblPercent_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblPercent_0.Enabled = True
		Me._lblPercent_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPercent_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPercent_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPercent_0.UseMnemonic = True
		Me._lblPercent_0.Visible = True
		Me._lblPercent_0.AutoSize = False
		Me._lblPercent_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPercent_0.Name = "_lblPercent_0"
		Me.lblBearing.Text = "Bearing"
		Me.lblBearing.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBearing.Size = New System.Drawing.Size(59, 17)
		Me.lblBearing.Location = New System.Drawing.Point(19, 254)
		Me.lblBearing.TabIndex = 18
		Me.lblBearing.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblBearing.BackColor = System.Drawing.SystemColors.Control
		Me.lblBearing.Enabled = True
		Me.lblBearing.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblBearing.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblBearing.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblBearing.UseMnemonic = True
		Me.lblBearing.Visible = True
		Me.lblBearing.AutoSize = False
		Me.lblBearing.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblBearing.Name = "lblBearing"
		Me._lblLengthUnit_1.Text = "ft"
		Me._lblLengthUnit_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblLengthUnit_1.Size = New System.Drawing.Size(15, 17)
		Me._lblLengthUnit_1.Location = New System.Drawing.Point(129, 230)
		Me._lblLengthUnit_1.TabIndex = 17
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
		Me.fraMoorLineStatus.Text = "Mooring Line Status"
		Me.fraMoorLineStatus.Size = New System.Drawing.Size(181, 182)
		Me.fraMoorLineStatus.Location = New System.Drawing.Point(7, 78)
		Me.fraMoorLineStatus.TabIndex = 3
		Me.fraMoorLineStatus.BackColor = System.Drawing.SystemColors.Control
		Me.fraMoorLineStatus.Enabled = True
		Me.fraMoorLineStatus.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraMoorLineStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraMoorLineStatus.Visible = True
		Me.fraMoorLineStatus.Name = "fraMoorLineStatus"
		grdLC.OcxState = CType(resources.GetObject("grdLC.OcxState"), System.Windows.Forms.AxHost.State)
		Me.grdLC.Size = New System.Drawing.Size(116, 143)
		Me.grdLC.Location = New System.Drawing.Point(17, 23)
		Me.grdLC.TabIndex = 4
		Me.grdLC.Name = "grdLC"
		Me.btnTransient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnTransient.Text = "Start"
		Me.btnTransient.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTransient.Size = New System.Drawing.Size(61, 25)
		Me.btnTransient.Location = New System.Drawing.Point(213, 14)
		Me.btnTransient.TabIndex = 2
		Me.btnTransient.BackColor = System.Drawing.SystemColors.Control
		Me.btnTransient.CausesValidation = True
		Me.btnTransient.Enabled = True
		Me.btnTransient.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTransient.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTransient.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTransient.TabStop = True
		Me.btnTransient.Name = "btnTransient"
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.btnCancel
		Me.btnCancel.Text = "Cancel"
		Me.AcceptButton = Me.btnCancel
		Me.btnCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.Size = New System.Drawing.Size(61, 25)
		Me.btnCancel.Location = New System.Drawing.Point(279, 14)
		Me.btnCancel.TabIndex = 1
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.btnCancel.CausesValidation = True
		Me.btnCancel.Enabled = True
		Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCancel.TabStop = True
		Me.btnCancel.Name = "btnCancel"
		Me.picPolar.Size = New System.Drawing.Size(526, 544)
		Me.picPolar.Location = New System.Drawing.Point(348, 7)
		Me.picPolar.TabIndex = 0
		Me.picPolar.TabStop = False
		Me.picPolar.Dock = System.Windows.Forms.DockStyle.None
		Me.picPolar.BackColor = System.Drawing.SystemColors.Control
		Me.picPolar.CausesValidation = True
		Me.picPolar.Enabled = True
		Me.picPolar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picPolar.Cursor = System.Windows.Forms.Cursors.Default
		Me.picPolar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picPolar.Visible = True
		Me.picPolar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picPolar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picPolar.Name = "picPolar"
		SysInfo1.OcxState = CType(resources.GetObject("SysInfo1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.SysInfo1.Location = New System.Drawing.Point(346, 15)
		Me.SysInfo1.Name = "SysInfo1"
		Me._lblForceUnit_0.Text = "kips"
		Me._lblForceUnit_0.Size = New System.Drawing.Size(25, 17)
		Me._lblForceUnit_0.Location = New System.Drawing.Point(1, 16)
		Me._lblForceUnit_0.TabIndex = 35
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
		Me._lblVelUnit_0.TabIndex = 34
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
		Me.Label1.Text = "Headings are clockwise from True North"
		Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
		Me.Label1.Size = New System.Drawing.Size(126, 29)
		Me.Label1.Location = New System.Drawing.Point(206, 182)
		Me.Label1.TabIndex = 25
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(btnDisplayCurves)
		Me.Controls.Add(btnReport)
		Me.Controls.Add(btnSetVesselCoords)
		Me.Controls.Add(fraEnvironment)
		Me.Controls.Add(fraTransientTime)
		Me.Controls.Add(fraTransientMotion)
		Me.Controls.Add(fraMoorLineStatus)
		Me.Controls.Add(btnTransient)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(picPolar)
		Me.Controls.Add(SysInfo1)
		Me.Controls.Add(_lblForceUnit_0)
		Me.Controls.Add(_lblVelUnit_0)
		Me.Controls.Add(Label1)
		Me.fraEnvironment.Controls.Add(txtEnvironment)
		Me.fraEnvironment.Controls.Add(btnEnvironment)
		Me.fraTransientTime.Controls.Add(txtDuration)
		Me.fraTransientTime.Controls.Add(txtInterval)
		Me.fraTransientTime.Controls.Add(lblDuration)
		Me.fraTransientTime.Controls.Add(lblInterval)
		Me.fraTransientMotion.Controls.Add(txtMaxOffsetTime)
		Me.fraTransientMotion.Controls.Add(txtOffset)
		Me.fraTransientMotion.Controls.Add(txtOffsetPWD)
		Me.fraTransientMotion.Controls.Add(txtMaxOffset)
		Me.fraTransientMotion.Controls.Add(txtMaxOffsetPWD)
		Me.fraTransientMotion.Controls.Add(txtOffsetBearing)
		Me.fraTransientMotion.Controls.Add(grdTM)
		Me.fraTransientMotion.Controls.Add(_lblPercent_2)
		Me.fraTransientMotion.Controls.Add(_lblVslStUnit_4)
		Me.fraTransientMotion.Controls.Add(_lblPercent_1)
		Me.fraTransientMotion.Controls.Add(_lblLengthUnit_0)
		Me.fraTransientMotion.Controls.Add(lblOffset)
		Me.fraTransientMotion.Controls.Add(lblMaxOffset)
		Me.fraTransientMotion.Controls.Add(_lblPercent_0)
		Me.fraTransientMotion.Controls.Add(lblBearing)
		Me.fraTransientMotion.Controls.Add(_lblLengthUnit_1)
		Me.fraMoorLineStatus.Controls.Add(grdLC)
		Me.lblForceUnit.SetIndex(_lblForceUnit_0, CType(0, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_0, CType(0, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_1, CType(1, Short))
		Me.lblPercent.SetIndex(_lblPercent_2, CType(2, Short))
		Me.lblPercent.SetIndex(_lblPercent_1, CType(1, Short))
		Me.lblPercent.SetIndex(_lblPercent_0, CType(0, Short))
		Me.lblVelUnit.SetIndex(_lblVelUnit_0, CType(0, Short))
		Me.lblVslStUnit.SetIndex(_lblVslStUnit_4, CType(4, Short))
		CType(Me.lblVslStUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblPercent, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblLengthUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SysInfo1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdLC, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdTM, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraEnvironment.ResumeLayout(False)
		Me.fraTransientTime.ResumeLayout(False)
		Me.fraTransientMotion.ResumeLayout(False)
		Me.fraMoorLineStatus.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class