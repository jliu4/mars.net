<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCatenary
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
	Public WithEvents txtHorFrc As System.Windows.Forms.TextBox
	Public WithEvents cboLines As System.Windows.Forms.ComboBox
	Public WithEvents picCatenary As System.Windows.Forms.PictureBox
	Public WithEvents cboSegment As System.Windows.Forms.ComboBox
	Public WithEvents txtTopTen As System.Windows.Forms.TextBox
	Public WithEvents btnOK As System.Windows.Forms.Button
	Public WithEvents grdDetails As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents grdLength As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents _lblForceUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblVelUnit_0 As System.Windows.Forms.Label
	Public WithEvents lblForceUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVelUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCatenary))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtHorFrc = New System.Windows.Forms.TextBox
		Me.cboLines = New System.Windows.Forms.ComboBox
		Me.picCatenary = New System.Windows.Forms.PictureBox
		Me.cboSegment = New System.Windows.Forms.ComboBox
		Me.txtTopTen = New System.Windows.Forms.TextBox
		Me.btnOK = New System.Windows.Forms.Button
		Me.grdDetails = New AxMSFlexGridLib.AxMSFlexGrid
		Me.grdLength = New AxMSFlexGridLib.AxMSFlexGrid
		Me._lblForceUnit_0 = New System.Windows.Forms.Label
		Me._lblVelUnit_0 = New System.Windows.Forms.Label
		Me.lblForceUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVelUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.grdDetails, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.grdLength, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = " Catenary"
		Me.ClientSize = New System.Drawing.Size(401, 457)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmCatenary"
		Me.txtHorFrc.AutoSize = False
		Me.txtHorFrc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtHorFrc.Size = New System.Drawing.Size(73, 19)
		Me.txtHorFrc.Location = New System.Drawing.Point(80, 368)
		Me.txtHorFrc.TabIndex = 6
		Me.txtHorFrc.AcceptsReturn = True
		Me.txtHorFrc.BackColor = System.Drawing.SystemColors.Window
		Me.txtHorFrc.CausesValidation = True
		Me.txtHorFrc.Enabled = True
		Me.txtHorFrc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtHorFrc.HideSelection = True
		Me.txtHorFrc.ReadOnly = False
		Me.txtHorFrc.Maxlength = 0
		Me.txtHorFrc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtHorFrc.MultiLine = False
		Me.txtHorFrc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHorFrc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtHorFrc.TabStop = True
		Me.txtHorFrc.Visible = True
		Me.txtHorFrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtHorFrc.Name = "txtHorFrc"
		Me.cboLines.Size = New System.Drawing.Size(113, 21)
		Me.cboLines.Location = New System.Drawing.Point(16, 424)
		Me.cboLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboLines.TabIndex = 1
		Me.cboLines.BackColor = System.Drawing.SystemColors.Window
		Me.cboLines.CausesValidation = True
		Me.cboLines.Enabled = True
		Me.cboLines.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboLines.IntegralHeight = True
		Me.cboLines.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboLines.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboLines.Sorted = False
		Me.cboLines.TabStop = True
		Me.cboLines.Visible = True
		Me.cboLines.Name = "cboLines"
		Me.picCatenary.Size = New System.Drawing.Size(369, 201)
		Me.picCatenary.Location = New System.Drawing.Point(16, 16)
		Me.picCatenary.TabIndex = 7
		Me.picCatenary.Dock = System.Windows.Forms.DockStyle.None
		Me.picCatenary.BackColor = System.Drawing.SystemColors.Control
		Me.picCatenary.CausesValidation = True
		Me.picCatenary.Enabled = True
		Me.picCatenary.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picCatenary.Cursor = System.Windows.Forms.Cursors.Default
		Me.picCatenary.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picCatenary.TabStop = True
		Me.picCatenary.Visible = True
		Me.picCatenary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picCatenary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picCatenary.Name = "picCatenary"
		Me.cboSegment.Size = New System.Drawing.Size(73, 21)
		Me.cboSegment.Location = New System.Drawing.Point(144, 288)
		Me.cboSegment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboSegment.TabIndex = 4
		Me.cboSegment.BackColor = System.Drawing.SystemColors.Window
		Me.cboSegment.CausesValidation = True
		Me.cboSegment.Enabled = True
		Me.cboSegment.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboSegment.IntegralHeight = True
		Me.cboSegment.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboSegment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboSegment.Sorted = False
		Me.cboSegment.TabStop = True
		Me.cboSegment.Visible = True
		Me.cboSegment.Name = "cboSegment"
		Me.txtTopTen.AutoSize = False
		Me.txtTopTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtTopTen.Size = New System.Drawing.Size(73, 19)
		Me.txtTopTen.Location = New System.Drawing.Point(80, 328)
		Me.txtTopTen.TabIndex = 5
		Me.txtTopTen.AcceptsReturn = True
		Me.txtTopTen.BackColor = System.Drawing.SystemColors.Window
		Me.txtTopTen.CausesValidation = True
		Me.txtTopTen.Enabled = True
		Me.txtTopTen.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTopTen.HideSelection = True
		Me.txtTopTen.ReadOnly = False
		Me.txtTopTen.Maxlength = 0
		Me.txtTopTen.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTopTen.MultiLine = False
		Me.txtTopTen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTopTen.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTopTen.TabStop = True
		Me.txtTopTen.Visible = True
		Me.txtTopTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtTopTen.Name = "txtTopTen"
		Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.btnOK
		Me.btnOK.Text = "Close"
		Me.btnOK.Size = New System.Drawing.Size(65, 25)
		Me.btnOK.Location = New System.Drawing.Point(320, 424)
		Me.btnOK.TabIndex = 0
		Me.btnOK.BackColor = System.Drawing.SystemColors.Control
		Me.btnOK.CausesValidation = True
		Me.btnOK.Enabled = True
		Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnOK.TabStop = True
		Me.btnOK.Name = "btnOK"
		grdDetails.OcxState = CType(resources.GetObject("grdDetails.OcxState"), System.Windows.Forms.AxHost.State)
		Me.grdDetails.Size = New System.Drawing.Size(371, 128)
		Me.grdDetails.Location = New System.Drawing.Point(16, 288)
		Me.grdDetails.TabIndex = 3
		Me.grdDetails.Name = "grdDetails"
		grdLength.OcxState = CType(resources.GetObject("grdLength.OcxState"), System.Windows.Forms.AxHost.State)
		Me.grdLength.Size = New System.Drawing.Size(371, 57)
		Me.grdLength.Location = New System.Drawing.Point(16, 224)
		Me.grdLength.TabIndex = 2
		Me.grdLength.Name = "grdLength"
		Me._lblForceUnit_0.Text = "kips"
		Me._lblForceUnit_0.Size = New System.Drawing.Size(25, 17)
		Me._lblForceUnit_0.Location = New System.Drawing.Point(1, 16)
		Me._lblForceUnit_0.TabIndex = 9
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
		Me._lblVelUnit_0.TabIndex = 8
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
		Me.Controls.Add(txtHorFrc)
		Me.Controls.Add(cboLines)
		Me.Controls.Add(picCatenary)
		Me.Controls.Add(cboSegment)
		Me.Controls.Add(txtTopTen)
		Me.Controls.Add(btnOK)
		Me.Controls.Add(grdDetails)
		Me.Controls.Add(grdLength)
		Me.Controls.Add(_lblForceUnit_0)
		Me.Controls.Add(_lblVelUnit_0)
		Me.lblForceUnit.SetIndex(_lblForceUnit_0, CType(0, Short))
		Me.lblVelUnit.SetIndex(_lblVelUnit_0, CType(0, Short))
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdLength, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdDetails, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class