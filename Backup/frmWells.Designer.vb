<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWells
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
	Public dlgFilesOpen As System.Windows.Forms.OpenFileDialog
	Public dlgFilesSave As System.Windows.Forms.SaveFileDialog
	Public WithEvents SysInfo1 As AxSysInfoLib.AxSysInfo
	Public WithEvents txtEdit As System.Windows.Forms.TextBox
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnOK As System.Windows.Forms.Button
	Public WithEvents grdWS As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents _lblForceUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblVelUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblGenCmt_0 As System.Windows.Forms.Label
	Public WithEvents lblForceUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblGenCmt As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVelUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFileSaveAs As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuLine As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuAddRow As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuDeleteRow As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuGridEdit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmWells))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.dlgFilesOpen = New System.Windows.Forms.OpenFileDialog
		Me.dlgFilesSave = New System.Windows.Forms.SaveFileDialog
		Me.SysInfo1 = New AxSysInfoLib.AxSysInfo
		Me.txtEdit = New System.Windows.Forms.TextBox
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnOK = New System.Windows.Forms.Button
		Me.grdWS = New AxMSFlexGridLib.AxMSFlexGrid
		Me._lblForceUnit_0 = New System.Windows.Forms.Label
		Me._lblVelUnit_0 = New System.Windows.Forms.Label
		Me._lblGenCmt_0 = New System.Windows.Forms.Label
		Me.lblForceUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblGenCmt = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVelUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuLine = New System.Windows.Forms.ToolStripSeparator
		Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuGridEdit = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuAddRow = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuDeleteRow = New System.Windows.Forms.ToolStripMenuItem
		Me.MainMenu1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.SysInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.grdWS, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblGenCmt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = " Well Site Locations"
		Me.ClientSize = New System.Drawing.Size(409, 264)
		Me.Location = New System.Drawing.Point(11, 37)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmWells"
		SysInfo1.OcxState = CType(resources.GetObject("SysInfo1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.SysInfo1.Location = New System.Drawing.Point(144, 152)
		Me.SysInfo1.Name = "SysInfo1"
		Me.txtEdit.AutoSize = False
		Me.txtEdit.Size = New System.Drawing.Size(65, 25)
		Me.txtEdit.Location = New System.Drawing.Point(337, 169)
		Me.txtEdit.TabIndex = 3
		Me.txtEdit.Text = "Text1"
		Me.txtEdit.Visible = False
		Me.txtEdit.AcceptsReturn = True
		Me.txtEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtEdit.BackColor = System.Drawing.SystemColors.Window
		Me.txtEdit.CausesValidation = True
		Me.txtEdit.Enabled = True
		Me.txtEdit.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEdit.HideSelection = True
		Me.txtEdit.ReadOnly = False
		Me.txtEdit.Maxlength = 0
		Me.txtEdit.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEdit.MultiLine = False
		Me.txtEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEdit.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEdit.TabStop = True
		Me.txtEdit.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtEdit.Name = "txtEdit"
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.Size = New System.Drawing.Size(65, 25)
		Me.btnCancel.Location = New System.Drawing.Point(334, 38)
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
		Me.btnOK.Text = "Save"
		Me.btnOK.Size = New System.Drawing.Size(65, 25)
		Me.btnOK.Location = New System.Drawing.Point(334, 10)
		Me.btnOK.TabIndex = 0
		Me.btnOK.BackColor = System.Drawing.SystemColors.Control
		Me.btnOK.CausesValidation = True
		Me.btnOK.Enabled = True
		Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnOK.TabStop = True
		Me.btnOK.Name = "btnOK"
		grdWS.OcxState = CType(resources.GetObject("grdWS.OcxState"), System.Windows.Forms.AxHost.State)
		Me.grdWS.Size = New System.Drawing.Size(309, 214)
		Me.grdWS.Location = New System.Drawing.Point(10, 5)
		Me.grdWS.TabIndex = 2
		Me.grdWS.Name = "grdWS"
		Me._lblForceUnit_0.Text = "kips"
		Me._lblForceUnit_0.Size = New System.Drawing.Size(25, 17)
		Me._lblForceUnit_0.Location = New System.Drawing.Point(1, 16)
		Me._lblForceUnit_0.TabIndex = 6
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
		Me._lblVelUnit_0.TabIndex = 5
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
		Me._lblGenCmt_0.Text = "*  In global coordinate system:        x - East, y - North."
		Me._lblGenCmt_0.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._lblGenCmt_0.Size = New System.Drawing.Size(158, 33)
		Me._lblGenCmt_0.Location = New System.Drawing.Point(11, 228)
		Me._lblGenCmt_0.TabIndex = 4
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
		Me.mnuFileOpen.Name = "mnuFileOpen"
		Me.mnuFileOpen.Text = "&Import..."
		Me.mnuFileOpen.Checked = False
		Me.mnuFileOpen.Enabled = True
		Me.mnuFileOpen.Visible = True
		Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
		Me.mnuFileSaveAs.Text = "&Export..."
		Me.mnuFileSaveAs.Checked = False
		Me.mnuFileSaveAs.Enabled = True
		Me.mnuFileSaveAs.Visible = True
		Me.mnuLine.Enabled = True
		Me.mnuLine.Visible = True
		Me.mnuLine.Name = "mnuLine"
		Me.mnuExit.Name = "mnuExit"
		Me.mnuExit.Text = "Close"
		Me.mnuExit.Checked = False
		Me.mnuExit.Enabled = True
		Me.mnuExit.Visible = True
		Me.mnuGridEdit.Name = "mnuGridEdit"
		Me.mnuGridEdit.Text = ""
		Me.mnuGridEdit.Visible = False
		Me.mnuGridEdit.Checked = False
		Me.mnuGridEdit.Enabled = True
		Me.mnuAddRow.Name = "mnuAddRow"
		Me.mnuAddRow.Text = "Add Row"
		Me.mnuAddRow.Checked = False
		Me.mnuAddRow.Enabled = True
		Me.mnuAddRow.Visible = True
		Me.mnuDeleteRow.Name = "mnuDeleteRow"
		Me.mnuDeleteRow.Text = "Delete Row"
		Me.mnuDeleteRow.Checked = False
		Me.mnuDeleteRow.Enabled = True
		Me.mnuDeleteRow.Visible = True
		Me.Controls.Add(SysInfo1)
		Me.Controls.Add(txtEdit)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(btnOK)
		Me.Controls.Add(grdWS)
		Me.Controls.Add(_lblForceUnit_0)
		Me.Controls.Add(_lblVelUnit_0)
		Me.Controls.Add(_lblGenCmt_0)
		Me.lblForceUnit.SetIndex(_lblForceUnit_0, CType(0, Short))
		Me.lblGenCmt.SetIndex(_lblGenCmt_0, CType(0, Short))
		Me.lblVelUnit.SetIndex(_lblVelUnit_0, CType(0, Short))
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblGenCmt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdWS, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SysInfo1, System.ComponentModel.ISupportInitialize).EndInit()
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuFile, Me.mnuGridEdit})
		mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuFileOpen, Me.mnuFileSaveAs, Me.mnuLine, Me.mnuExit})
		mnuGridEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuAddRow, Me.mnuDeleteRow})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class