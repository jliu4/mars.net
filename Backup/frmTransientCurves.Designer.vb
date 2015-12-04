<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTransientCurves
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
	Public WithEvents sysInf As AxSysInfoLib.AxSysInfo
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents picGraph As System.Windows.Forms.PictureBox
	Public WithEvents grdCD As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents _lblForceUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblVelUnit_0 As System.Windows.Forms.Label
	Public WithEvents lblUserNote As System.Windows.Forms.Label
	Public WithEvents lblForceUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVelUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTransientCurves))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.sysInf = New AxSysInfoLib.AxSysInfo
		Me.btnCancel = New System.Windows.Forms.Button
		Me.picGraph = New System.Windows.Forms.PictureBox
		Me.grdCD = New AxMSFlexGridLib.AxMSFlexGrid
		Me._lblForceUnit_0 = New System.Windows.Forms.Label
		Me._lblVelUnit_0 = New System.Windows.Forms.Label
		Me.lblUserNote = New System.Windows.Forms.Label
		Me.lblForceUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVelUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.sysInf, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.grdCD, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "MARS - Transient Curves"
		Me.ClientSize = New System.Drawing.Size(772, 564)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.Icon = CType(resources.GetObject("frmTransientCurves.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmTransientCurves"
		sysInf.OcxState = CType(resources.GetObject("sysInf.OcxState"), System.Windows.Forms.AxHost.State)
		Me.sysInf.Location = New System.Drawing.Point(651, 551)
		Me.sysInf.Name = "sysInf"
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCancel.Text = "Close"
		Me.btnCancel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.Size = New System.Drawing.Size(69, 25)
		Me.btnCancel.Location = New System.Drawing.Point(692, 530)
		Me.btnCancel.TabIndex = 0
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.btnCancel.CausesValidation = True
		Me.btnCancel.Enabled = True
		Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCancel.TabStop = True
		Me.btnCancel.Name = "btnCancel"
		Me.picGraph.Size = New System.Drawing.Size(754, 255)
		Me.picGraph.Location = New System.Drawing.Point(7, 7)
		Me.picGraph.TabIndex = 1
		Me.picGraph.TabStop = False
		Me.picGraph.Dock = System.Windows.Forms.DockStyle.None
		Me.picGraph.BackColor = System.Drawing.SystemColors.Control
		Me.picGraph.CausesValidation = True
		Me.picGraph.Enabled = True
		Me.picGraph.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picGraph.Cursor = System.Windows.Forms.Cursors.Default
		Me.picGraph.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picGraph.Visible = True
		Me.picGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picGraph.Name = "picGraph"
		grdCD.OcxState = CType(resources.GetObject("grdCD.OcxState"), System.Windows.Forms.AxHost.State)
		Me.grdCD.Size = New System.Drawing.Size(756, 255)
		Me.grdCD.Location = New System.Drawing.Point(7, 268)
		Me.grdCD.TabIndex = 2
		Me.grdCD.Name = "grdCD"
		Me._lblForceUnit_0.Text = "kips"
		Me._lblForceUnit_0.Size = New System.Drawing.Size(25, 17)
		Me._lblForceUnit_0.Location = New System.Drawing.Point(1, 16)
		Me._lblForceUnit_0.TabIndex = 5
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
		Me._lblVelUnit_0.TabIndex = 4
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
		Me.lblUserNote.Text = "Click a line to display its time history plot"
		Me.lblUserNote.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUserNote.Size = New System.Drawing.Size(450, 17)
		Me.lblUserNote.Location = New System.Drawing.Point(9, 528)
		Me.lblUserNote.TabIndex = 3
		Me.lblUserNote.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUserNote.BackColor = System.Drawing.SystemColors.Control
		Me.lblUserNote.Enabled = True
		Me.lblUserNote.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUserNote.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUserNote.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUserNote.UseMnemonic = True
		Me.lblUserNote.Visible = True
		Me.lblUserNote.AutoSize = False
		Me.lblUserNote.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUserNote.Name = "lblUserNote"
		Me.Controls.Add(sysInf)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(picGraph)
		Me.Controls.Add(grdCD)
		Me.Controls.Add(_lblForceUnit_0)
		Me.Controls.Add(_lblVelUnit_0)
		Me.Controls.Add(lblUserNote)
		Me.lblForceUnit.SetIndex(_lblForceUnit_0, CType(0, Short))
		Me.lblVelUnit.SetIndex(_lblVelUnit_0, CType(0, Short))
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdCD, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.sysInf, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class