<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPlot
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
	Public WithEvents _txtPicControls_1 As System.Windows.Forms.TextBox
	Public WithEvents btnClose As System.Windows.Forms.Button
	Public WithEvents _btnPlot_0 As System.Windows.Forms.Button
	Public WithEvents _btnPlot_1 As System.Windows.Forms.Button
	Public WithEvents _txtPicControls_0 As System.Windows.Forms.TextBox
	Public WithEvents _btnZoom_1 As System.Windows.Forms.Button
	Public WithEvents _btnZoom_0 As System.Windows.Forms.Button
	Public WithEvents hPan As System.Windows.Forms.HScrollBar
	Public WithEvents hScroll_Renamed As System.Windows.Forms.HScrollBar
	Public WithEvents vPan As System.Windows.Forms.VScrollBar
	Public WithEvents vScroll_Renamed As System.Windows.Forms.VScrollBar
	Public WithEvents ThreeD As System.Windows.Forms.PictureBox
	Public WithEvents _lblForceUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblVelUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblUnit_1 As System.Windows.Forms.Label
	Public WithEvents _lblUnit_0 As System.Windows.Forms.Label
	Public WithEvents lblVessel As System.Windows.Forms.Label
	Public WithEvents btnPlot As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents btnZoom As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents lblForceUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVelUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents txtPicControls As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPlot))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._txtPicControls_1 = New System.Windows.Forms.TextBox
		Me.btnClose = New System.Windows.Forms.Button
		Me._btnPlot_0 = New System.Windows.Forms.Button
		Me._btnPlot_1 = New System.Windows.Forms.Button
		Me._txtPicControls_0 = New System.Windows.Forms.TextBox
		Me._btnZoom_1 = New System.Windows.Forms.Button
		Me._btnZoom_0 = New System.Windows.Forms.Button
		Me.hPan = New System.Windows.Forms.HScrollBar
		Me.hScroll_Renamed = New System.Windows.Forms.HScrollBar
		Me.vPan = New System.Windows.Forms.VScrollBar
		Me.vScroll_Renamed = New System.Windows.Forms.VScrollBar
		Me.ThreeD = New System.Windows.Forms.PictureBox
		Me._lblForceUnit_0 = New System.Windows.Forms.Label
		Me._lblVelUnit_0 = New System.Windows.Forms.Label
		Me._lblUnit_1 = New System.Windows.Forms.Label
		Me._lblUnit_0 = New System.Windows.Forms.Label
		Me.lblVessel = New System.Windows.Forms.Label
		Me.btnPlot = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.btnZoom = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.lblForceUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVelUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.txtPicControls = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.btnPlot, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.btnZoom, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPicControls, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = " MARS - Plot"
		Me.ClientSize = New System.Drawing.Size(509, 571)
		Me.Location = New System.Drawing.Point(128, 48)
		Me.Icon = CType(resources.GetObject("frmPlot.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmPlot"
		Me._txtPicControls_1.AutoSize = False
		Me._txtPicControls_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtPicControls_1.Size = New System.Drawing.Size(33, 21)
		Me._txtPicControls_1.Location = New System.Drawing.Point(272, 536)
		Me._txtPicControls_1.TabIndex = 12
		Me._txtPicControls_1.TabStop = False
		Me._txtPicControls_1.Text = "0"
		Me._txtPicControls_1.AcceptsReturn = True
		Me._txtPicControls_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtPicControls_1.CausesValidation = True
		Me._txtPicControls_1.Enabled = True
		Me._txtPicControls_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPicControls_1.HideSelection = True
		Me._txtPicControls_1.ReadOnly = False
		Me._txtPicControls_1.Maxlength = 0
		Me._txtPicControls_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPicControls_1.MultiLine = False
		Me._txtPicControls_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPicControls_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPicControls_1.Visible = True
		Me._txtPicControls_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPicControls_1.Name = "_txtPicControls_1"
		Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnClose.Text = "Close"
		Me.btnClose.Size = New System.Drawing.Size(65, 25)
		Me.btnClose.Location = New System.Drawing.Point(432, 8)
		Me.btnClose.TabIndex = 0
		Me.btnClose.BackColor = System.Drawing.SystemColors.Control
		Me.btnClose.CausesValidation = True
		Me.btnClose.Enabled = True
		Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnClose.TabStop = True
		Me.btnClose.Name = "btnClose"
		Me._btnPlot_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._btnPlot_0.Text = "3D Plot"
		Me._btnPlot_0.Size = New System.Drawing.Size(57, 25)
		Me._btnPlot_0.Location = New System.Drawing.Point(376, 536)
		Me._btnPlot_0.TabIndex = 5
		Me.ToolTip1.SetToolTip(Me._btnPlot_0, "Show 3D plot")
		Me._btnPlot_0.BackColor = System.Drawing.SystemColors.Control
		Me._btnPlot_0.CausesValidation = True
		Me._btnPlot_0.Enabled = True
		Me._btnPlot_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnPlot_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._btnPlot_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._btnPlot_0.TabStop = True
		Me._btnPlot_0.Name = "_btnPlot_0"
		Me._btnPlot_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._btnPlot_1.Text = "Radar Plot"
		Me._btnPlot_1.Size = New System.Drawing.Size(65, 25)
		Me._btnPlot_1.Location = New System.Drawing.Point(432, 536)
		Me._btnPlot_1.TabIndex = 6
		Me.ToolTip1.SetToolTip(Me._btnPlot_1, "Show radar plot")
		Me._btnPlot_1.BackColor = System.Drawing.SystemColors.Control
		Me._btnPlot_1.CausesValidation = True
		Me._btnPlot_1.Enabled = True
		Me._btnPlot_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnPlot_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._btnPlot_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._btnPlot_1.TabStop = True
		Me._btnPlot_1.Name = "_btnPlot_1"
		Me._txtPicControls_0.AutoSize = False
		Me._txtPicControls_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtPicControls_0.Size = New System.Drawing.Size(33, 21)
		Me._txtPicControls_0.Location = New System.Drawing.Point(192, 536)
		Me._txtPicControls_0.TabIndex = 10
		Me._txtPicControls_0.TabStop = False
		Me._txtPicControls_0.Text = "0"
		Me._txtPicControls_0.AcceptsReturn = True
		Me._txtPicControls_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtPicControls_0.CausesValidation = True
		Me._txtPicControls_0.Enabled = True
		Me._txtPicControls_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPicControls_0.HideSelection = True
		Me._txtPicControls_0.ReadOnly = False
		Me._txtPicControls_0.Maxlength = 0
		Me._txtPicControls_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPicControls_0.MultiLine = False
		Me._txtPicControls_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPicControls_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPicControls_0.Visible = True
		Me._txtPicControls_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPicControls_0.Name = "_txtPicControls_0"
		Me._btnZoom_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._btnZoom_1.Text = "Zoom Out"
		Me._btnZoom_1.Size = New System.Drawing.Size(57, 25)
		Me._btnZoom_1.Location = New System.Drawing.Point(64, 536)
		Me._btnZoom_1.TabIndex = 8
		Me._btnZoom_1.BackColor = System.Drawing.SystemColors.Control
		Me._btnZoom_1.CausesValidation = True
		Me._btnZoom_1.Enabled = True
		Me._btnZoom_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnZoom_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._btnZoom_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._btnZoom_1.TabStop = True
		Me._btnZoom_1.Name = "_btnZoom_1"
		Me._btnZoom_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._btnZoom_0.Text = "Zoom In"
		Me._btnZoom_0.Size = New System.Drawing.Size(57, 25)
		Me._btnZoom_0.Location = New System.Drawing.Point(8, 536)
		Me._btnZoom_0.TabIndex = 7
		Me._btnZoom_0.BackColor = System.Drawing.SystemColors.Control
		Me._btnZoom_0.CausesValidation = True
		Me._btnZoom_0.Enabled = True
		Me._btnZoom_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._btnZoom_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._btnZoom_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._btnZoom_0.TabStop = True
		Me._btnZoom_0.Name = "_btnZoom_0"
		Me.hPan.Size = New System.Drawing.Size(473, 17)
		Me.hPan.LargeChange = 10
		Me.hPan.Location = New System.Drawing.Point(8, 512)
		Me.hPan.Maximum = 109
		Me.hPan.TabIndex = 4
		Me.hPan.TabStop = False
		Me.hPan.CausesValidation = True
		Me.hPan.Enabled = True
		Me.hPan.Minimum = 0
		Me.hPan.Cursor = System.Windows.Forms.Cursors.Default
		Me.hPan.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.hPan.SmallChange = 1
		Me.hPan.Value = 0
		Me.hPan.Visible = True
		Me.hPan.Name = "hPan"
		Me.hScroll_Renamed.Size = New System.Drawing.Size(25, 25)
		Me.hScroll_Renamed.LargeChange = 10
		Me.hScroll_Renamed.Location = New System.Drawing.Point(168, 534)
		Me.hScroll_Renamed.Maximum = 189
		Me.hScroll_Renamed.Minimum = -180
		Me.hScroll_Renamed.TabIndex = 9
		Me.hScroll_Renamed.TabStop = False
		Me.hScroll_Renamed.CausesValidation = True
		Me.hScroll_Renamed.Enabled = True
		Me.hScroll_Renamed.Cursor = System.Windows.Forms.Cursors.Default
		Me.hScroll_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.hScroll_Renamed.SmallChange = 1
		Me.hScroll_Renamed.Value = 0
		Me.hScroll_Renamed.Visible = True
		Me.hScroll_Renamed.Name = "hScroll_Renamed"
		Me.vPan.Size = New System.Drawing.Size(17, 472)
		Me.vPan.LargeChange = 10
		Me.vPan.Location = New System.Drawing.Point(480, 40)
		Me.vPan.Maximum = 109
		Me.vPan.TabIndex = 3
		Me.vPan.TabStop = False
		Me.vPan.CausesValidation = True
		Me.vPan.Enabled = True
		Me.vPan.Minimum = 0
		Me.vPan.Cursor = System.Windows.Forms.Cursors.Default
		Me.vPan.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.vPan.SmallChange = 1
		Me.vPan.Value = 0
		Me.vPan.Visible = True
		Me.vPan.Name = "vPan"
		Me.vScroll_Renamed.Size = New System.Drawing.Size(25, 25)
		Me.vScroll_Renamed.LargeChange = 10
		Me.vScroll_Renamed.Location = New System.Drawing.Point(248, 534)
		Me.vScroll_Renamed.Maximum = 99
		Me.vScroll_Renamed.TabIndex = 11
		Me.vScroll_Renamed.TabStop = False
		Me.vScroll_Renamed.Value = 90
		Me.vScroll_Renamed.CausesValidation = True
		Me.vScroll_Renamed.Enabled = True
		Me.vScroll_Renamed.Minimum = 0
		Me.vScroll_Renamed.Cursor = System.Windows.Forms.Cursors.Default
		Me.vScroll_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.vScroll_Renamed.SmallChange = 1
		Me.vScroll_Renamed.Visible = True
		Me.vScroll_Renamed.Name = "vScroll_Renamed"
		Me.ThreeD.Size = New System.Drawing.Size(473, 473)
		Me.ThreeD.Location = New System.Drawing.Point(8, 40)
		Me.ThreeD.TabIndex = 2
		Me.ThreeD.TabStop = False
		Me.ThreeD.Dock = System.Windows.Forms.DockStyle.None
		Me.ThreeD.BackColor = System.Drawing.SystemColors.Control
		Me.ThreeD.CausesValidation = True
		Me.ThreeD.Enabled = True
		Me.ThreeD.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ThreeD.Cursor = System.Windows.Forms.Cursors.Default
		Me.ThreeD.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ThreeD.Visible = True
		Me.ThreeD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.ThreeD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.ThreeD.Name = "ThreeD"
		Me._lblForceUnit_0.Text = "kips"
		Me._lblForceUnit_0.Size = New System.Drawing.Size(25, 17)
		Me._lblForceUnit_0.Location = New System.Drawing.Point(1, 16)
		Me._lblForceUnit_0.TabIndex = 16
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
		Me._lblVelUnit_0.TabIndex = 15
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
		Me._lblUnit_1.Text = "Invalid_string_refer_to_original_code"
		Me._lblUnit_1.Size = New System.Drawing.Size(17, 17)
		Me._lblUnit_1.Location = New System.Drawing.Point(308, 536)
		Me._lblUnit_1.TabIndex = 14
		Me._lblUnit_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblUnit_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblUnit_1.Enabled = True
		Me._lblUnit_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblUnit_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblUnit_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblUnit_1.UseMnemonic = True
		Me._lblUnit_1.Visible = True
		Me._lblUnit_1.AutoSize = False
		Me._lblUnit_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblUnit_1.Name = "_lblUnit_1"
		Me._lblUnit_0.Text = "Invalid_string_refer_to_original_code"
		Me._lblUnit_0.Size = New System.Drawing.Size(17, 17)
		Me._lblUnit_0.Location = New System.Drawing.Point(227, 536)
		Me._lblUnit_0.TabIndex = 13
		Me._lblUnit_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblUnit_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblUnit_0.Enabled = True
		Me._lblUnit_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblUnit_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblUnit_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblUnit_0.UseMnemonic = True
		Me._lblUnit_0.Visible = True
		Me._lblUnit_0.AutoSize = False
		Me._lblUnit_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblUnit_0.Name = "_lblUnit_0"
		Me.lblVessel.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblVessel.Text = "GlobalSantaFe"
		Me.lblVessel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVessel.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.lblVessel.Size = New System.Drawing.Size(209, 25)
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
		Me.Controls.Add(_txtPicControls_1)
		Me.Controls.Add(btnClose)
		Me.Controls.Add(_btnPlot_0)
		Me.Controls.Add(_btnPlot_1)
		Me.Controls.Add(_txtPicControls_0)
		Me.Controls.Add(_btnZoom_1)
		Me.Controls.Add(_btnZoom_0)
		Me.Controls.Add(hPan)
		Me.Controls.Add(hScroll_Renamed)
		Me.Controls.Add(vPan)
		Me.Controls.Add(vScroll_Renamed)
		Me.Controls.Add(ThreeD)
		Me.Controls.Add(_lblForceUnit_0)
		Me.Controls.Add(_lblVelUnit_0)
		Me.Controls.Add(_lblUnit_1)
		Me.Controls.Add(_lblUnit_0)
		Me.Controls.Add(lblVessel)
		Me.btnPlot.SetIndex(_btnPlot_0, CType(0, Short))
		Me.btnPlot.SetIndex(_btnPlot_1, CType(1, Short))
		Me.btnZoom.SetIndex(_btnZoom_1, CType(1, Short))
		Me.btnZoom.SetIndex(_btnZoom_0, CType(0, Short))
		Me.lblForceUnit.SetIndex(_lblForceUnit_0, CType(0, Short))
		Me.lblUnit.SetIndex(_lblUnit_1, CType(1, Short))
		Me.lblUnit.SetIndex(_lblUnit_0, CType(0, Short))
		Me.lblVelUnit.SetIndex(_lblVelUnit_0, CType(0, Short))
		Me.txtPicControls.SetIndex(_txtPicControls_1, CType(1, Short))
		Me.txtPicControls.SetIndex(_txtPicControls_0, CType(0, Short))
		CType(Me.txtPicControls, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.btnZoom, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.btnPlot, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class