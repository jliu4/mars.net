<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMoorLines
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
	Public WithEvents _txtVslSt_3 As System.Windows.Forms.TextBox
	Public WithEvents cboDraft As System.Windows.Forms.ComboBox
	Public WithEvents _lblLengthUnit_2 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents txtWD As System.Windows.Forms.TextBox
	Public WithEvents _txtVslSt_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtVslSt_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtVslSt_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblVslSt_3 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_11 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_1 As System.Windows.Forms.Label
	Public WithEvents _lblAngleUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblVslSt_2 As System.Windows.Forms.Label
	Public WithEvents _lblVslSt_1 As System.Windows.Forms.Label
	Public WithEvents _lblVslSt_0 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_0 As System.Windows.Forms.Label
	Public WithEvents fraVesselLoc As System.Windows.Forms.GroupBox
	Public WithEvents btnCatenary As System.Windows.Forms.Button
	Public WithEvents cboSegType As System.Windows.Forms.ComboBox
	Public WithEvents txtSegEdit As System.Windows.Forms.TextBox
	Public WithEvents txtAnchEdit As System.Windows.Forms.TextBox
	Public WithEvents grdSegments As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents grdAnchor As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents _lblSegCmt_0 As System.Windows.Forms.Label
	Public WithEvents _lblSegCmt_1 As System.Windows.Forms.Label
	Public WithEvents fraSegments As System.Windows.Forms.GroupBox
	Public WithEvents btnPayout As System.Windows.Forms.Button
	Public WithEvents btnScope As System.Windows.Forms.Button
	Public WithEvents _txtGeneral_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtGeneral_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtGeneral_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblAngleUnit_1 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_4 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_3 As System.Windows.Forms.Label
	Public WithEvents _lblGenCmt_0 As System.Windows.Forms.Label
	Public WithEvents _lblGenCmt_1 As System.Windows.Forms.Label
	Public WithEvents _lblGeneral_2 As System.Windows.Forms.Label
	Public WithEvents _lblGeneral_1 As System.Windows.Forms.Label
	Public WithEvents _lblGeneral_0 As System.Windows.Forms.Label
	Public WithEvents fraGeneral As System.Windows.Forms.GroupBox
	Public WithEvents chkBatch As System.Windows.Forms.CheckBox
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnNew As System.Windows.Forms.Button
	Public WithEvents btnRemove As System.Windows.Forms.Button
	Public WithEvents btnSave As System.Windows.Forms.Button
	Public WithEvents btnTopTension As System.Windows.Forms.Button
	Public WithEvents btnPreten As System.Windows.Forms.Button
	Public WithEvents _txtPreTen_1 As System.Windows.Forms.TextBox
	Public WithEvents txtTopTen As System.Windows.Forms.TextBox
	Public WithEvents _txtPreTen_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblForceUnit_2 As System.Windows.Forms.Label
	Public WithEvents _lblForceUnit_1 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents _lblPreTen_1 As System.Windows.Forms.Label
	Public WithEvents lblTopTen As System.Windows.Forms.Label
	Public WithEvents _lblForceUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblPreTen_0 As System.Windows.Forms.Label
	Public WithEvents fraTopTen As System.Windows.Forms.GroupBox
	Public WithEvents btnAnchor As System.Windows.Forms.Button
	Public WithEvents _txtAnchor_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtAnchor_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtAnchor_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtAnchor_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblAnchorCmt_3 As System.Windows.Forms.Label
	Public WithEvents _lblAnchorCmt_2 As System.Windows.Forms.Label
	Public WithEvents _lblAngleUnit_2 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_10 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_9 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_8 As System.Windows.Forms.Label
	Public WithEvents _lblAnchor_3 As System.Windows.Forms.Label
	Public WithEvents _lblAnchorCmt_1 As System.Windows.Forms.Label
	Public WithEvents _lblAnchorCmt_0 As System.Windows.Forms.Label
	Public WithEvents _lblAnchor_2 As System.Windows.Forms.Label
	Public WithEvents _lblAnchor_1 As System.Windows.Forms.Label
	Public WithEvents _lblAnchor_0 As System.Windows.Forms.Label
	Public WithEvents fraAnchor As System.Windows.Forms.GroupBox
	Public WithEvents _txtFL_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtFL_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtFL_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblLengthUnit_7 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_6 As System.Windows.Forms.Label
	Public WithEvents _lblLengthUnit_5 As System.Windows.Forms.Label
	Public WithEvents _lblFL_2 As System.Windows.Forms.Label
	Public WithEvents _lblFLUnit_2 As System.Windows.Forms.Label
	Public WithEvents _lblFLCmt_1 As System.Windows.Forms.Label
	Public WithEvents _lblFLCmt_0 As System.Windows.Forms.Label
	Public WithEvents _lblFLUnit_1 As System.Windows.Forms.Label
	Public WithEvents _lblFL_1 As System.Windows.Forms.Label
	Public WithEvents _lblFLUnit_0 As System.Windows.Forms.Label
	Public WithEvents _lblFL_0 As System.Windows.Forms.Label
	Public WithEvents fraFairLead As System.Windows.Forms.GroupBox
	Public WithEvents tabMoorLines As AxMSComctlLib.AxTabStrip
	Public WithEvents SysInfo1 As AxSysInfoLib.AxSysInfo
	Public dlgFileOpen As System.Windows.Forms.OpenFileDialog
	Public dlgFileSave As System.Windows.Forms.SaveFileDialog
	Public WithEvents _lblVelUnit_0 As System.Windows.Forms.Label
	Public WithEvents lblAnchor As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblAnchorCmt As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblAngleUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblFL As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblFLCmt As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblFLUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblForceUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblGenCmt As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblGeneral As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblLengthUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblPreTen As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblSegCmt As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVelUnit As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblVslSt As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents txtAnchor As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtFL As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtGeneral As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtPreTen As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtVslSt As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuDum As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuInsert As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuGridEdit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMoorLines))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._txtVslSt_3 = New System.Windows.Forms.TextBox
		Me.cboDraft = New System.Windows.Forms.ComboBox
		Me._lblLengthUnit_2 = New System.Windows.Forms.Label
		Me.fraVesselLoc = New System.Windows.Forms.GroupBox
		Me.txtWD = New System.Windows.Forms.TextBox
		Me._txtVslSt_2 = New System.Windows.Forms.TextBox
		Me._txtVslSt_1 = New System.Windows.Forms.TextBox
		Me._txtVslSt_0 = New System.Windows.Forms.TextBox
		Me._lblVslSt_3 = New System.Windows.Forms.Label
		Me._lblLengthUnit_11 = New System.Windows.Forms.Label
		Me._lblLengthUnit_1 = New System.Windows.Forms.Label
		Me._lblAngleUnit_0 = New System.Windows.Forms.Label
		Me._lblVslSt_2 = New System.Windows.Forms.Label
		Me._lblVslSt_1 = New System.Windows.Forms.Label
		Me._lblVslSt_0 = New System.Windows.Forms.Label
		Me._lblLengthUnit_0 = New System.Windows.Forms.Label
		Me.btnCatenary = New System.Windows.Forms.Button
		Me.fraSegments = New System.Windows.Forms.GroupBox
		Me.cboSegType = New System.Windows.Forms.ComboBox
		Me.txtSegEdit = New System.Windows.Forms.TextBox
		Me.txtAnchEdit = New System.Windows.Forms.TextBox
		Me.grdSegments = New AxMSFlexGridLib.AxMSFlexGrid
		Me.grdAnchor = New AxMSFlexGridLib.AxMSFlexGrid
		Me._lblSegCmt_0 = New System.Windows.Forms.Label
		Me._lblSegCmt_1 = New System.Windows.Forms.Label
		Me.fraGeneral = New System.Windows.Forms.GroupBox
		Me.btnPayout = New System.Windows.Forms.Button
		Me.btnScope = New System.Windows.Forms.Button
		Me._txtGeneral_2 = New System.Windows.Forms.TextBox
		Me._txtGeneral_1 = New System.Windows.Forms.TextBox
		Me._txtGeneral_0 = New System.Windows.Forms.TextBox
		Me._lblAngleUnit_1 = New System.Windows.Forms.Label
		Me._lblLengthUnit_4 = New System.Windows.Forms.Label
		Me._lblLengthUnit_3 = New System.Windows.Forms.Label
		Me._lblGenCmt_0 = New System.Windows.Forms.Label
		Me._lblGenCmt_1 = New System.Windows.Forms.Label
		Me._lblGeneral_2 = New System.Windows.Forms.Label
		Me._lblGeneral_1 = New System.Windows.Forms.Label
		Me._lblGeneral_0 = New System.Windows.Forms.Label
		Me.chkBatch = New System.Windows.Forms.CheckBox
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnNew = New System.Windows.Forms.Button
		Me.btnRemove = New System.Windows.Forms.Button
		Me.btnSave = New System.Windows.Forms.Button
		Me.fraTopTen = New System.Windows.Forms.GroupBox
		Me.btnTopTension = New System.Windows.Forms.Button
		Me.btnPreten = New System.Windows.Forms.Button
		Me._txtPreTen_1 = New System.Windows.Forms.TextBox
		Me.txtTopTen = New System.Windows.Forms.TextBox
		Me._txtPreTen_0 = New System.Windows.Forms.TextBox
		Me._lblForceUnit_2 = New System.Windows.Forms.Label
		Me._lblForceUnit_1 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me._lblPreTen_1 = New System.Windows.Forms.Label
		Me.lblTopTen = New System.Windows.Forms.Label
		Me._lblForceUnit_0 = New System.Windows.Forms.Label
		Me._lblPreTen_0 = New System.Windows.Forms.Label
		Me.fraAnchor = New System.Windows.Forms.GroupBox
		Me.btnAnchor = New System.Windows.Forms.Button
		Me._txtAnchor_3 = New System.Windows.Forms.TextBox
		Me._txtAnchor_2 = New System.Windows.Forms.TextBox
		Me._txtAnchor_1 = New System.Windows.Forms.TextBox
		Me._txtAnchor_0 = New System.Windows.Forms.TextBox
		Me._lblAnchorCmt_3 = New System.Windows.Forms.Label
		Me._lblAnchorCmt_2 = New System.Windows.Forms.Label
		Me._lblAngleUnit_2 = New System.Windows.Forms.Label
		Me._lblLengthUnit_10 = New System.Windows.Forms.Label
		Me._lblLengthUnit_9 = New System.Windows.Forms.Label
		Me._lblLengthUnit_8 = New System.Windows.Forms.Label
		Me._lblAnchor_3 = New System.Windows.Forms.Label
		Me._lblAnchorCmt_1 = New System.Windows.Forms.Label
		Me._lblAnchorCmt_0 = New System.Windows.Forms.Label
		Me._lblAnchor_2 = New System.Windows.Forms.Label
		Me._lblAnchor_1 = New System.Windows.Forms.Label
		Me._lblAnchor_0 = New System.Windows.Forms.Label
		Me.fraFairLead = New System.Windows.Forms.GroupBox
		Me._txtFL_2 = New System.Windows.Forms.TextBox
		Me._txtFL_1 = New System.Windows.Forms.TextBox
		Me._txtFL_0 = New System.Windows.Forms.TextBox
		Me._lblLengthUnit_7 = New System.Windows.Forms.Label
		Me._lblLengthUnit_6 = New System.Windows.Forms.Label
		Me._lblLengthUnit_5 = New System.Windows.Forms.Label
		Me._lblFL_2 = New System.Windows.Forms.Label
		Me._lblFLUnit_2 = New System.Windows.Forms.Label
		Me._lblFLCmt_1 = New System.Windows.Forms.Label
		Me._lblFLCmt_0 = New System.Windows.Forms.Label
		Me._lblFLUnit_1 = New System.Windows.Forms.Label
		Me._lblFL_1 = New System.Windows.Forms.Label
		Me._lblFLUnit_0 = New System.Windows.Forms.Label
		Me._lblFL_0 = New System.Windows.Forms.Label
		Me.tabMoorLines = New AxMSComctlLib.AxTabStrip
		Me.SysInfo1 = New AxSysInfoLib.AxSysInfo
		Me.dlgFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.dlgFileSave = New System.Windows.Forms.SaveFileDialog
		Me._lblVelUnit_0 = New System.Windows.Forms.Label
		Me.lblAnchor = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblAnchorCmt = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblAngleUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblFL = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblFLCmt = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblFLUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblForceUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblGenCmt = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblGeneral = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblLengthUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblPreTen = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblSegCmt = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVelUnit = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblVslSt = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.txtAnchor = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtFL = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtGeneral = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtPreTen = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtVslSt = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuDum = New System.Windows.Forms.ToolStripSeparator
		Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuGridEdit = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuInsert = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem
		Me.Frame1.SuspendLayout()
		Me.fraVesselLoc.SuspendLayout()
		Me.fraSegments.SuspendLayout()
		Me.fraGeneral.SuspendLayout()
		Me.fraTopTen.SuspendLayout()
		Me.fraAnchor.SuspendLayout()
		Me.fraFairLead.SuspendLayout()
		Me.MainMenu1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.grdSegments, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.grdAnchor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tabMoorLines, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SysInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblAnchor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblAnchorCmt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblAngleUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblFL, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblFLCmt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblFLUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblGenCmt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblLengthUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblPreTen, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblSegCmt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblVslSt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtAnchor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtFL, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPreTen, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtVslSt, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = " Properties of Moorling Lines"
		Me.ClientSize = New System.Drawing.Size(846, 615)
		Me.Location = New System.Drawing.Point(10, 29)
		Me.Icon = CType(resources.GetObject("frmMoorLines.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmMoorLines"
		Me.Frame1.Text = "Design Vessel Draft"
		Me.Frame1.Size = New System.Drawing.Size(190, 100)
		Me.Frame1.Location = New System.Drawing.Point(21, 15)
		Me.Frame1.TabIndex = 89
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me._txtVslSt_3.AutoSize = False
		Me._txtVslSt_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtVslSt_3.BackColor = System.Drawing.SystemColors.Control
		Me._txtVslSt_3.Size = New System.Drawing.Size(55, 20)
		Me._txtVslSt_3.Location = New System.Drawing.Point(75, 56)
		Me._txtVslSt_3.ReadOnly = True
		Me._txtVslSt_3.TabIndex = 91
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
		Me.cboDraft.Size = New System.Drawing.Size(116, 21)
		Me.cboDraft.Location = New System.Drawing.Point(40, 31)
		Me.cboDraft.Items.AddRange(New Object(){"Current Draft", "Survival Draft", "Operating Draft"})
		Me.cboDraft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboDraft.TabIndex = 90
		Me.cboDraft.BackColor = System.Drawing.SystemColors.Window
		Me.cboDraft.CausesValidation = True
		Me.cboDraft.Enabled = True
		Me.cboDraft.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDraft.IntegralHeight = True
		Me.cboDraft.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDraft.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDraft.Sorted = False
		Me.cboDraft.TabStop = True
		Me.cboDraft.Visible = True
		Me.cboDraft.Name = "cboDraft"
		Me._lblLengthUnit_2.Text = "ft"
		Me._lblLengthUnit_2.Size = New System.Drawing.Size(17, 17)
		Me._lblLengthUnit_2.Location = New System.Drawing.Point(136, 57)
		Me._lblLengthUnit_2.TabIndex = 92
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
		Me.fraVesselLoc.Text = "Design Vessel Station :"
		Me.fraVesselLoc.Size = New System.Drawing.Size(468, 101)
		Me.fraVesselLoc.Location = New System.Drawing.Point(228, 14)
		Me.fraVesselLoc.TabIndex = 3
		Me.fraVesselLoc.BackColor = System.Drawing.SystemColors.Control
		Me.fraVesselLoc.Enabled = True
		Me.fraVesselLoc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraVesselLoc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraVesselLoc.Visible = True
		Me.fraVesselLoc.Name = "fraVesselLoc"
		Me.txtWD.AutoSize = False
		Me.txtWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtWD.BackColor = System.Drawing.SystemColors.Control
		Me.txtWD.Size = New System.Drawing.Size(59, 19)
		Me.txtWD.Location = New System.Drawing.Point(297, 55)
		Me.txtWD.ReadOnly = True
		Me.txtWD.TabIndex = 83
		Me.txtWD.TabStop = False
		Me.txtWD.AcceptsReturn = True
		Me.txtWD.CausesValidation = True
		Me.txtWD.Enabled = True
		Me.txtWD.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWD.HideSelection = True
		Me.txtWD.Maxlength = 0
		Me.txtWD.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWD.MultiLine = False
		Me.txtWD.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWD.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWD.Visible = True
		Me.txtWD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWD.Name = "txtWD"
		Me._txtVslSt_2.AutoSize = False
		Me._txtVslSt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtVslSt_2.Size = New System.Drawing.Size(58, 19)
		Me._txtVslSt_2.Location = New System.Drawing.Point(297, 30)
		Me._txtVslSt_2.TabIndex = 10
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
		Me._txtVslSt_1.Size = New System.Drawing.Size(121, 19)
		Me._txtVslSt_1.Location = New System.Drawing.Point(78, 55)
		Me._txtVslSt_1.TabIndex = 8
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
		Me._txtVslSt_0.Size = New System.Drawing.Size(123, 19)
		Me._txtVslSt_0.Location = New System.Drawing.Point(77, 30)
		Me._txtVslSt_0.TabIndex = 5
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
		Me._lblVslSt_3.Text = "Depth"
		Me._lblVslSt_3.Size = New System.Drawing.Size(37, 17)
		Me._lblVslSt_3.Location = New System.Drawing.Point(251, 56)
		Me._lblVslSt_3.TabIndex = 85
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
		Me._lblLengthUnit_11.Text = "ft"
		Me._lblLengthUnit_11.Size = New System.Drawing.Size(17, 17)
		Me._lblLengthUnit_11.Location = New System.Drawing.Point(361, 56)
		Me._lblLengthUnit_11.TabIndex = 84
		Me._lblLengthUnit_11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLengthUnit_11.BackColor = System.Drawing.SystemColors.Control
		Me._lblLengthUnit_11.Enabled = True
		Me._lblLengthUnit_11.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLengthUnit_11.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLengthUnit_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLengthUnit_11.UseMnemonic = True
		Me._lblLengthUnit_11.Visible = True
		Me._lblLengthUnit_11.AutoSize = False
		Me._lblLengthUnit_11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLengthUnit_11.Name = "_lblLengthUnit_11"
		Me._lblLengthUnit_1.Text = "ft"
		Me._lblLengthUnit_1.Size = New System.Drawing.Size(17, 17)
		Me._lblLengthUnit_1.Location = New System.Drawing.Point(202, 61)
		Me._lblLengthUnit_1.TabIndex = 69
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
		Me._lblAngleUnit_0.Text = "Invalid_string_refer_to_original_code"
		Me._lblAngleUnit_0.Size = New System.Drawing.Size(17, 17)
		Me._lblAngleUnit_0.Location = New System.Drawing.Point(360, 26)
		Me._lblAngleUnit_0.TabIndex = 11
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
		Me._lblVslSt_2.Size = New System.Drawing.Size(41, 17)
		Me._lblVslSt_2.Location = New System.Drawing.Point(251, 32)
		Me._lblVslSt_2.TabIndex = 9
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
		Me._lblVslSt_1.Location = New System.Drawing.Point(48, 55)
		Me._lblVslSt_1.TabIndex = 7
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
		Me._lblVslSt_0.Location = New System.Drawing.Point(48, 32)
		Me._lblVslSt_0.TabIndex = 4
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
		Me._lblLengthUnit_0.Location = New System.Drawing.Point(202, 36)
		Me._lblLengthUnit_0.TabIndex = 6
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
		Me.btnCatenary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCatenary.Text = "&Catenary"
		Me.btnCatenary.Size = New System.Drawing.Size(74, 25)
		Me.btnCatenary.Location = New System.Drawing.Point(106, 163)
		Me.btnCatenary.TabIndex = 82
		Me.btnCatenary.BackColor = System.Drawing.SystemColors.Control
		Me.btnCatenary.CausesValidation = True
		Me.btnCatenary.Enabled = True
		Me.btnCatenary.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCatenary.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCatenary.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCatenary.TabStop = True
		Me.btnCatenary.Name = "btnCatenary"
		Me.fraSegments.Text = "Properties of Line Segments :"
		Me.fraSegments.Size = New System.Drawing.Size(789, 185)
		Me.fraSegments.Location = New System.Drawing.Point(18, 412)
		Me.fraSegments.TabIndex = 61
		Me.fraSegments.BackColor = System.Drawing.SystemColors.Control
		Me.fraSegments.Enabled = True
		Me.fraSegments.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSegments.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSegments.Visible = True
		Me.fraSegments.Name = "fraSegments"
		Me.cboSegType.Size = New System.Drawing.Size(65, 21)
		Me.cboSegType.Location = New System.Drawing.Point(74, 52)
		Me.cboSegType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboSegType.TabIndex = 68
		Me.cboSegType.Visible = False
		Me.cboSegType.BackColor = System.Drawing.SystemColors.Window
		Me.cboSegType.CausesValidation = True
		Me.cboSegType.Enabled = True
		Me.cboSegType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboSegType.IntegralHeight = True
		Me.cboSegType.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboSegType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboSegType.Sorted = False
		Me.cboSegType.TabStop = True
		Me.cboSegType.Name = "cboSegType"
		Me.txtSegEdit.AutoSize = False
		Me.txtSegEdit.Size = New System.Drawing.Size(81, 19)
		Me.txtSegEdit.Location = New System.Drawing.Point(300, 76)
		Me.txtSegEdit.TabIndex = 63
		Me.txtSegEdit.Visible = False
		Me.txtSegEdit.AcceptsReturn = True
		Me.txtSegEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSegEdit.BackColor = System.Drawing.SystemColors.Window
		Me.txtSegEdit.CausesValidation = True
		Me.txtSegEdit.Enabled = True
		Me.txtSegEdit.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSegEdit.HideSelection = True
		Me.txtSegEdit.ReadOnly = False
		Me.txtSegEdit.Maxlength = 0
		Me.txtSegEdit.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSegEdit.MultiLine = False
		Me.txtSegEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSegEdit.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSegEdit.TabStop = True
		Me.txtSegEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSegEdit.Name = "txtSegEdit"
		Me.txtAnchEdit.AutoSize = False
		Me.txtAnchEdit.Size = New System.Drawing.Size(81, 19)
		Me.txtAnchEdit.Location = New System.Drawing.Point(300, 140)
		Me.txtAnchEdit.TabIndex = 62
		Me.txtAnchEdit.Visible = False
		Me.txtAnchEdit.AcceptsReturn = True
		Me.txtAnchEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAnchEdit.BackColor = System.Drawing.SystemColors.Window
		Me.txtAnchEdit.CausesValidation = True
		Me.txtAnchEdit.Enabled = True
		Me.txtAnchEdit.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAnchEdit.HideSelection = True
		Me.txtAnchEdit.ReadOnly = False
		Me.txtAnchEdit.Maxlength = 0
		Me.txtAnchEdit.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAnchEdit.MultiLine = False
		Me.txtAnchEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAnchEdit.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAnchEdit.TabStop = True
		Me.txtAnchEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAnchEdit.Name = "txtAnchEdit"
		grdSegments.OcxState = CType(resources.GetObject("grdSegments.OcxState"), System.Windows.Forms.AxHost.State)
		Me.grdSegments.Size = New System.Drawing.Size(767, 125)
		Me.grdSegments.Location = New System.Drawing.Point(8, 15)
		Me.grdSegments.TabIndex = 64
		Me.grdSegments.Name = "grdSegments"
		grdAnchor.OcxState = CType(resources.GetObject("grdAnchor.OcxState"), System.Windows.Forms.AxHost.State)
		Me.grdAnchor.Size = New System.Drawing.Size(767, 23)
		Me.grdAnchor.Location = New System.Drawing.Point(8, 140)
		Me.grdAnchor.TabIndex = 65
		Me.grdAnchor.Name = "grdAnchor"
		Me._lblSegCmt_0.Text = "Input started from top of the mooring line, i.e. the fair lead"
		Me._lblSegCmt_0.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._lblSegCmt_0.Size = New System.Drawing.Size(281, 17)
		Me._lblSegCmt_0.Location = New System.Drawing.Point(32, 164)
		Me._lblSegCmt_0.TabIndex = 67
		Me._lblSegCmt_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblSegCmt_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblSegCmt_0.Enabled = True
		Me._lblSegCmt_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblSegCmt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblSegCmt_0.UseMnemonic = True
		Me._lblSegCmt_0.Visible = True
		Me._lblSegCmt_0.AutoSize = False
		Me._lblSegCmt_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblSegCmt_0.Name = "_lblSegCmt_0"
		Me._lblSegCmt_1.Text = "*"
		Me._lblSegCmt_1.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._lblSegCmt_1.Size = New System.Drawing.Size(9, 17)
		Me._lblSegCmt_1.Location = New System.Drawing.Point(16, 164)
		Me._lblSegCmt_1.TabIndex = 66
		Me._lblSegCmt_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblSegCmt_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblSegCmt_1.Enabled = True
		Me._lblSegCmt_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblSegCmt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblSegCmt_1.UseMnemonic = True
		Me._lblSegCmt_1.Visible = True
		Me._lblSegCmt_1.AutoSize = False
		Me._lblSegCmt_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblSegCmt_1.Name = "_lblSegCmt_1"
		Me.fraGeneral.Text = "General Data :"
		Me.fraGeneral.Size = New System.Drawing.Size(185, 217)
		Me.fraGeneral.Location = New System.Drawing.Point(20, 192)
		Me.fraGeneral.TabIndex = 15
		Me.fraGeneral.BackColor = System.Drawing.SystemColors.Control
		Me.fraGeneral.Enabled = True
		Me.fraGeneral.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraGeneral.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraGeneral.Visible = True
		Me.fraGeneral.Name = "fraGeneral"
		Me.btnPayout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnPayout.Text = "Com&pute "
		Me.btnPayout.Size = New System.Drawing.Size(63, 25)
		Me.btnPayout.Location = New System.Drawing.Point(86, 134)
		Me.btnPayout.TabIndex = 23
		Me.ToolTip1.SetToolTip(Me.btnPayout, "Compute Payout & Scope")
		Me.btnPayout.BackColor = System.Drawing.SystemColors.Control
		Me.btnPayout.CausesValidation = True
		Me.btnPayout.Enabled = True
		Me.btnPayout.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnPayout.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnPayout.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnPayout.TabStop = True
		Me.btnPayout.Name = "btnPayout"
		Me.btnScope.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnScope.Text = "C&ompute Scope, Spread"
		Me.btnScope.Size = New System.Drawing.Size(139, 25)
		Me.btnScope.Location = New System.Drawing.Point(12, 72)
		Me.btnScope.TabIndex = 20
		Me.ToolTip1.SetToolTip(Me.btnScope, "Compute Scope & Spread Angle")
		Me.btnScope.BackColor = System.Drawing.SystemColors.Control
		Me.btnScope.CausesValidation = True
		Me.btnScope.Enabled = True
		Me.btnScope.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnScope.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnScope.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnScope.TabStop = True
		Me.btnScope.Name = "btnScope"
		Me._txtGeneral_2.AutoSize = False
		Me._txtGeneral_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtGeneral_2.Size = New System.Drawing.Size(57, 19)
		Me._txtGeneral_2.Location = New System.Drawing.Point(88, 112)
		Me._txtGeneral_2.TabIndex = 22
		Me._txtGeneral_2.Text = "0"
		Me.ToolTip1.SetToolTip(Me._txtGeneral_2, "First Segment Length from Fairlead.")
		Me._txtGeneral_2.AcceptsReturn = True
		Me._txtGeneral_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtGeneral_2.CausesValidation = True
		Me._txtGeneral_2.Enabled = True
		Me._txtGeneral_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtGeneral_2.HideSelection = True
		Me._txtGeneral_2.ReadOnly = False
		Me._txtGeneral_2.Maxlength = 0
		Me._txtGeneral_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtGeneral_2.MultiLine = False
		Me._txtGeneral_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtGeneral_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtGeneral_2.TabStop = True
		Me._txtGeneral_2.Visible = True
		Me._txtGeneral_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtGeneral_2.Name = "_txtGeneral_2"
		Me._txtGeneral_1.AutoSize = False
		Me._txtGeneral_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtGeneral_1.Size = New System.Drawing.Size(57, 19)
		Me._txtGeneral_1.Location = New System.Drawing.Point(88, 48)
		Me._txtGeneral_1.TabIndex = 19
		Me._txtGeneral_1.Text = "0"
		Me._txtGeneral_1.AcceptsReturn = True
		Me._txtGeneral_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtGeneral_1.CausesValidation = True
		Me._txtGeneral_1.Enabled = True
		Me._txtGeneral_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtGeneral_1.HideSelection = True
		Me._txtGeneral_1.ReadOnly = False
		Me._txtGeneral_1.Maxlength = 0
		Me._txtGeneral_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtGeneral_1.MultiLine = False
		Me._txtGeneral_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtGeneral_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtGeneral_1.TabStop = True
		Me._txtGeneral_1.Visible = True
		Me._txtGeneral_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtGeneral_1.Name = "_txtGeneral_1"
		Me._txtGeneral_0.AutoSize = False
		Me._txtGeneral_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtGeneral_0.Size = New System.Drawing.Size(57, 19)
		Me._txtGeneral_0.Location = New System.Drawing.Point(88, 24)
		Me._txtGeneral_0.TabIndex = 17
		Me._txtGeneral_0.Text = "0"
		Me._txtGeneral_0.AcceptsReturn = True
		Me._txtGeneral_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtGeneral_0.CausesValidation = True
		Me._txtGeneral_0.Enabled = True
		Me._txtGeneral_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtGeneral_0.HideSelection = True
		Me._txtGeneral_0.ReadOnly = False
		Me._txtGeneral_0.Maxlength = 0
		Me._txtGeneral_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtGeneral_0.MultiLine = False
		Me._txtGeneral_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtGeneral_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtGeneral_0.TabStop = True
		Me._txtGeneral_0.Visible = True
		Me._txtGeneral_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtGeneral_0.Name = "_txtGeneral_0"
		Me._lblAngleUnit_1.Text = "Invalid_string_refer_to_original_code"
		Me._lblAngleUnit_1.Size = New System.Drawing.Size(17, 17)
		Me._lblAngleUnit_1.Location = New System.Drawing.Point(147, 25)
		Me._lblAngleUnit_1.TabIndex = 78
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
		Me._lblLengthUnit_4.Text = "ft"
		Me._lblLengthUnit_4.Size = New System.Drawing.Size(17, 17)
		Me._lblLengthUnit_4.Location = New System.Drawing.Point(148, 115)
		Me._lblLengthUnit_4.TabIndex = 71
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
		Me._lblLengthUnit_3.Size = New System.Drawing.Size(17, 17)
		Me._lblLengthUnit_3.Location = New System.Drawing.Point(149, 51)
		Me._lblLengthUnit_3.TabIndex = 70
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
		Me._lblGenCmt_0.Text = "Spread Angle measured clockwise from the x-axis of the vessel local system (bow)"
		Me._lblGenCmt_0.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._lblGenCmt_0.Size = New System.Drawing.Size(137, 41)
		Me._lblGenCmt_0.Location = New System.Drawing.Point(32, 168)
		Me._lblGenCmt_0.TabIndex = 25
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
		Me._lblGenCmt_1.Location = New System.Drawing.Point(16, 168)
		Me._lblGenCmt_1.TabIndex = 24
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
		Me._lblGeneral_2.Text = "Payout"
		Me._lblGeneral_2.Size = New System.Drawing.Size(65, 17)
		Me._lblGeneral_2.Location = New System.Drawing.Point(16, 112)
		Me._lblGeneral_2.TabIndex = 21
		Me._lblGeneral_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblGeneral_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblGeneral_2.Enabled = True
		Me._lblGeneral_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblGeneral_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblGeneral_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblGeneral_2.UseMnemonic = True
		Me._lblGeneral_2.Visible = True
		Me._lblGeneral_2.AutoSize = False
		Me._lblGeneral_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblGeneral_2.Name = "_lblGeneral_2"
		Me._lblGeneral_1.Text = "Scope"
		Me._lblGeneral_1.Size = New System.Drawing.Size(65, 17)
		Me._lblGeneral_1.Location = New System.Drawing.Point(16, 48)
		Me._lblGeneral_1.TabIndex = 18
		Me._lblGeneral_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblGeneral_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblGeneral_1.Enabled = True
		Me._lblGeneral_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblGeneral_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblGeneral_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblGeneral_1.UseMnemonic = True
		Me._lblGeneral_1.Visible = True
		Me._lblGeneral_1.AutoSize = False
		Me._lblGeneral_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblGeneral_1.Name = "_lblGeneral_1"
		Me._lblGeneral_0.Text = "Spread Angle"
		Me._lblGeneral_0.Size = New System.Drawing.Size(65, 17)
		Me._lblGeneral_0.Location = New System.Drawing.Point(16, 24)
		Me._lblGeneral_0.TabIndex = 16
		Me._lblGeneral_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblGeneral_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblGeneral_0.Enabled = True
		Me._lblGeneral_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblGeneral_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblGeneral_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblGeneral_0.UseMnemonic = True
		Me._lblGeneral_0.Visible = True
		Me._lblGeneral_0.AutoSize = False
		Me._lblGeneral_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblGeneral_0.Name = "_lblGeneral_0"
		Me.chkBatch.Text = "Edit all mooring lines at same time"
		Me.chkBatch.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.chkBatch.Size = New System.Drawing.Size(177, 17)
		Me.chkBatch.Location = New System.Drawing.Point(618, 169)
		Me.chkBatch.TabIndex = 14
		Me.chkBatch.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkBatch.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkBatch.BackColor = System.Drawing.SystemColors.Control
		Me.chkBatch.CausesValidation = True
		Me.chkBatch.Enabled = True
		Me.chkBatch.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkBatch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkBatch.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkBatch.TabStop = True
		Me.chkBatch.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkBatch.Visible = True
		Me.chkBatch.Name = "chkBatch"
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.Size = New System.Drawing.Size(73, 25)
		Me.btnCancel.Location = New System.Drawing.Point(756, 40)
		Me.btnCancel.TabIndex = 1
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.btnCancel.CausesValidation = True
		Me.btnCancel.Enabled = True
		Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCancel.TabStop = True
		Me.btnCancel.Name = "btnCancel"
		Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnNew.Text = "&New Line"
		Me.btnNew.Size = New System.Drawing.Size(73, 25)
		Me.btnNew.Location = New System.Drawing.Point(756, 83)
		Me.btnNew.TabIndex = 2
		Me.btnNew.BackColor = System.Drawing.SystemColors.Control
		Me.btnNew.CausesValidation = True
		Me.btnNew.Enabled = True
		Me.btnNew.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnNew.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnNew.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnNew.TabStop = True
		Me.btnNew.Name = "btnNew"
		Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnRemove.Text = "&Remove"
		Me.btnRemove.Size = New System.Drawing.Size(73, 25)
		Me.btnRemove.Location = New System.Drawing.Point(22, 162)
		Me.btnRemove.TabIndex = 13
		Me.btnRemove.BackColor = System.Drawing.SystemColors.Control
		Me.btnRemove.CausesValidation = True
		Me.btnRemove.Enabled = True
		Me.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnRemove.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnRemove.TabStop = True
		Me.btnRemove.Name = "btnRemove"
		Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnSave.Text = "Sa&ve"
		Me.btnSave.Size = New System.Drawing.Size(73, 25)
		Me.btnSave.Location = New System.Drawing.Point(756, 12)
		Me.btnSave.TabIndex = 0
		Me.btnSave.BackColor = System.Drawing.SystemColors.Control
		Me.btnSave.CausesValidation = True
		Me.btnSave.Enabled = True
		Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSave.TabStop = True
		Me.btnSave.Name = "btnSave"
		Me.fraTopTen.Text = "Top Tensions :"
		Me.fraTopTen.Size = New System.Drawing.Size(185, 217)
		Me.fraTopTen.Location = New System.Drawing.Point(213, 192)
		Me.fraTopTen.TabIndex = 26
		Me.fraTopTen.BackColor = System.Drawing.SystemColors.Control
		Me.fraTopTen.Enabled = True
		Me.fraTopTen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraTopTen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraTopTen.Visible = True
		Me.fraTopTen.Name = "fraTopTen"
		Me.btnTopTension.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnTopTension.Text = "Compu&te"
		Me.btnTopTension.Size = New System.Drawing.Size(73, 25)
		Me.btnTopTension.Location = New System.Drawing.Point(87, 47)
		Me.btnTopTension.TabIndex = 30
		Me.ToolTip1.SetToolTip(Me.btnTopTension, "Compute Top Tension")
		Me.btnTopTension.BackColor = System.Drawing.SystemColors.Control
		Me.btnTopTension.CausesValidation = True
		Me.btnTopTension.Enabled = True
		Me.btnTopTension.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTopTension.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnTopTension.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnTopTension.TabStop = True
		Me.btnTopTension.Name = "btnTopTension"
		Me.btnPreten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnPreten.Text = "&Set To Top Tension"
		Me.btnPreten.Size = New System.Drawing.Size(124, 25)
		Me.btnPreten.Location = New System.Drawing.Point(21, 175)
		Me.btnPreten.TabIndex = 36
		Me.ToolTip1.SetToolTip(Me.btnPreten, "Set Pretension")
		Me.btnPreten.BackColor = System.Drawing.SystemColors.Control
		Me.btnPreten.CausesValidation = True
		Me.btnPreten.Enabled = True
		Me.btnPreten.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnPreten.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnPreten.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnPreten.TabStop = True
		Me.btnPreten.Name = "btnPreten"
		Me._txtPreTen_1.AutoSize = False
		Me._txtPreTen_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtPreTen_1.BackColor = System.Drawing.SystemColors.Control
		Me._txtPreTen_1.Size = New System.Drawing.Size(57, 19)
		Me._txtPreTen_1.Location = New System.Drawing.Point(88, 152)
		Me._txtPreTen_1.ReadOnly = True
		Me._txtPreTen_1.TabIndex = 35
		Me._txtPreTen_1.TabStop = False
		Me._txtPreTen_1.Text = "0"
		Me._txtPreTen_1.AcceptsReturn = True
		Me._txtPreTen_1.CausesValidation = True
		Me._txtPreTen_1.Enabled = True
		Me._txtPreTen_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPreTen_1.HideSelection = True
		Me._txtPreTen_1.Maxlength = 0
		Me._txtPreTen_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPreTen_1.MultiLine = False
		Me._txtPreTen_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPreTen_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPreTen_1.Visible = True
		Me._txtPreTen_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPreTen_1.Name = "_txtPreTen_1"
		Me.txtTopTen.AutoSize = False
		Me.txtTopTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtTopTen.Size = New System.Drawing.Size(57, 19)
		Me.txtTopTen.Location = New System.Drawing.Point(88, 24)
		Me.txtTopTen.TabIndex = 28
		Me.txtTopTen.Text = "0"
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
		Me.txtTopTen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTopTen.Name = "txtTopTen"
		Me._txtPreTen_0.AutoSize = False
		Me._txtPreTen_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtPreTen_0.BackColor = System.Drawing.SystemColors.Control
		Me._txtPreTen_0.Size = New System.Drawing.Size(57, 19)
		Me._txtPreTen_0.Location = New System.Drawing.Point(88, 128)
		Me._txtPreTen_0.ReadOnly = True
		Me._txtPreTen_0.TabIndex = 33
		Me._txtPreTen_0.TabStop = False
		Me._txtPreTen_0.Text = "0"
		Me._txtPreTen_0.AcceptsReturn = True
		Me._txtPreTen_0.CausesValidation = True
		Me._txtPreTen_0.Enabled = True
		Me._txtPreTen_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPreTen_0.HideSelection = True
		Me._txtPreTen_0.Maxlength = 0
		Me._txtPreTen_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPreTen_0.MultiLine = False
		Me._txtPreTen_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPreTen_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPreTen_0.Visible = True
		Me._txtPreTen_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPreTen_0.Name = "_txtPreTen_0"
		Me._lblForceUnit_2.Text = "kips"
		Me._lblForceUnit_2.Size = New System.Drawing.Size(25, 17)
		Me._lblForceUnit_2.Location = New System.Drawing.Point(151, 153)
		Me._lblForceUnit_2.TabIndex = 81
		Me._lblForceUnit_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblForceUnit_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblForceUnit_2.Enabled = True
		Me._lblForceUnit_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblForceUnit_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblForceUnit_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblForceUnit_2.UseMnemonic = True
		Me._lblForceUnit_2.Visible = True
		Me._lblForceUnit_2.AutoSize = False
		Me._lblForceUnit_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblForceUnit_2.Name = "_lblForceUnit_2"
		Me._lblForceUnit_1.Text = "kips"
		Me._lblForceUnit_1.Size = New System.Drawing.Size(25, 17)
		Me._lblForceUnit_1.Location = New System.Drawing.Point(151, 129)
		Me._lblForceUnit_1.TabIndex = 80
		Me._lblForceUnit_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblForceUnit_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblForceUnit_1.Enabled = True
		Me._lblForceUnit_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblForceUnit_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblForceUnit_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblForceUnit_1.UseMnemonic = True
		Me._lblForceUnit_1.Visible = True
		Me._lblForceUnit_1.AutoSize = False
		Me._lblForceUnit_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblForceUnit_1.Name = "_lblForceUnit_1"
		Me.Label1.Text = "Pretensions"
		Me.Label1.Size = New System.Drawing.Size(65, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 107)
		Me.Label1.TabIndex = 31
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me._lblPreTen_1.Text = "Operating"
		Me._lblPreTen_1.Size = New System.Drawing.Size(57, 17)
		Me._lblPreTen_1.Location = New System.Drawing.Point(24, 152)
		Me._lblPreTen_1.TabIndex = 34
		Me._lblPreTen_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblPreTen_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblPreTen_1.Enabled = True
		Me._lblPreTen_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPreTen_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPreTen_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPreTen_1.UseMnemonic = True
		Me._lblPreTen_1.Visible = True
		Me._lblPreTen_1.AutoSize = False
		Me._lblPreTen_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPreTen_1.Name = "_lblPreTen_1"
		Me.lblTopTen.Text = "Top Tension"
		Me.lblTopTen.Size = New System.Drawing.Size(65, 17)
		Me.lblTopTen.Location = New System.Drawing.Point(16, 24)
		Me.lblTopTen.TabIndex = 27
		Me.lblTopTen.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTopTen.BackColor = System.Drawing.SystemColors.Control
		Me.lblTopTen.Enabled = True
		Me.lblTopTen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTopTen.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTopTen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTopTen.UseMnemonic = True
		Me.lblTopTen.Visible = True
		Me.lblTopTen.AutoSize = False
		Me.lblTopTen.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTopTen.Name = "lblTopTen"
		Me._lblForceUnit_0.Text = "kips"
		Me._lblForceUnit_0.Size = New System.Drawing.Size(25, 17)
		Me._lblForceUnit_0.Location = New System.Drawing.Point(152, 24)
		Me._lblForceUnit_0.TabIndex = 29
		Me._lblForceUnit_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblForceUnit_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblForceUnit_0.Enabled = True
		Me._lblForceUnit_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblForceUnit_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblForceUnit_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblForceUnit_0.UseMnemonic = True
		Me._lblForceUnit_0.Visible = True
		Me._lblForceUnit_0.AutoSize = False
		Me._lblForceUnit_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblForceUnit_0.Name = "_lblForceUnit_0"
		Me._lblPreTen_0.Text = "Survival"
		Me._lblPreTen_0.Size = New System.Drawing.Size(57, 17)
		Me._lblPreTen_0.Location = New System.Drawing.Point(24, 130)
		Me._lblPreTen_0.TabIndex = 32
		Me._lblPreTen_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblPreTen_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblPreTen_0.Enabled = True
		Me._lblPreTen_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblPreTen_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblPreTen_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblPreTen_0.UseMnemonic = True
		Me._lblPreTen_0.Visible = True
		Me._lblPreTen_0.AutoSize = False
		Me._lblPreTen_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblPreTen_0.Name = "_lblPreTen_0"
		Me.fraAnchor.Text = "Anchor Location :"
		Me.fraAnchor.Size = New System.Drawing.Size(192, 217)
		Me.fraAnchor.Location = New System.Drawing.Point(616, 192)
		Me.fraAnchor.TabIndex = 49
		Me.fraAnchor.BackColor = System.Drawing.SystemColors.Control
		Me.fraAnchor.Enabled = True
		Me.fraAnchor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraAnchor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraAnchor.Visible = True
		Me.fraAnchor.Name = "fraAnchor"
		Me.btnAnchor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnAnchor.Text = "Comp&ute"
		Me.btnAnchor.Size = New System.Drawing.Size(75, 28)
		Me.btnAnchor.Location = New System.Drawing.Point(74, 118)
		Me.btnAnchor.TabIndex = 58
		Me.ToolTip1.SetToolTip(Me.btnAnchor, "Compute Anchor (x,y)")
		Me.btnAnchor.BackColor = System.Drawing.SystemColors.Control
		Me.btnAnchor.CausesValidation = True
		Me.btnAnchor.Enabled = True
		Me.btnAnchor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnAnchor.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnAnchor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnAnchor.TabStop = True
		Me.btnAnchor.Name = "btnAnchor"
		Me._txtAnchor_3.AutoSize = False
		Me._txtAnchor_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtAnchor_3.Size = New System.Drawing.Size(57, 19)
		Me._txtAnchor_3.Location = New System.Drawing.Point(74, 95)
		Me._txtAnchor_3.TabIndex = 57
		Me._txtAnchor_3.Text = "0"
		Me.ToolTip1.SetToolTip(Me._txtAnchor_3, "Local slope: default to average.")
		Me._txtAnchor_3.AcceptsReturn = True
		Me._txtAnchor_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtAnchor_3.CausesValidation = True
		Me._txtAnchor_3.Enabled = True
		Me._txtAnchor_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtAnchor_3.HideSelection = True
		Me._txtAnchor_3.ReadOnly = False
		Me._txtAnchor_3.Maxlength = 0
		Me._txtAnchor_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtAnchor_3.MultiLine = False
		Me._txtAnchor_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtAnchor_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtAnchor_3.TabStop = True
		Me._txtAnchor_3.Visible = True
		Me._txtAnchor_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtAnchor_3.Name = "_txtAnchor_3"
		Me._txtAnchor_2.AutoSize = False
		Me._txtAnchor_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtAnchor_2.Size = New System.Drawing.Size(75, 19)
		Me._txtAnchor_2.Location = New System.Drawing.Point(73, 66)
		Me._txtAnchor_2.TabIndex = 55
		Me._txtAnchor_2.Text = "0"
		Me._txtAnchor_2.AcceptsReturn = True
		Me._txtAnchor_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtAnchor_2.CausesValidation = True
		Me._txtAnchor_2.Enabled = True
		Me._txtAnchor_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtAnchor_2.HideSelection = True
		Me._txtAnchor_2.ReadOnly = False
		Me._txtAnchor_2.Maxlength = 0
		Me._txtAnchor_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtAnchor_2.MultiLine = False
		Me._txtAnchor_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtAnchor_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtAnchor_2.TabStop = True
		Me._txtAnchor_2.Visible = True
		Me._txtAnchor_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtAnchor_2.Name = "_txtAnchor_2"
		Me._txtAnchor_1.AutoSize = False
		Me._txtAnchor_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtAnchor_1.Size = New System.Drawing.Size(75, 19)
		Me._txtAnchor_1.Location = New System.Drawing.Point(73, 44)
		Me._txtAnchor_1.TabIndex = 53
		Me._txtAnchor_1.Text = "0"
		Me._txtAnchor_1.AcceptsReturn = True
		Me._txtAnchor_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtAnchor_1.CausesValidation = True
		Me._txtAnchor_1.Enabled = True
		Me._txtAnchor_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtAnchor_1.HideSelection = True
		Me._txtAnchor_1.ReadOnly = False
		Me._txtAnchor_1.Maxlength = 0
		Me._txtAnchor_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtAnchor_1.MultiLine = False
		Me._txtAnchor_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtAnchor_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtAnchor_1.TabStop = True
		Me._txtAnchor_1.Visible = True
		Me._txtAnchor_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtAnchor_1.Name = "_txtAnchor_1"
		Me._txtAnchor_0.AutoSize = False
		Me._txtAnchor_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtAnchor_0.Size = New System.Drawing.Size(76, 19)
		Me._txtAnchor_0.Location = New System.Drawing.Point(73, 22)
		Me._txtAnchor_0.TabIndex = 51
		Me._txtAnchor_0.Text = "0"
		Me._txtAnchor_0.AcceptsReturn = True
		Me._txtAnchor_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtAnchor_0.CausesValidation = True
		Me._txtAnchor_0.Enabled = True
		Me._txtAnchor_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtAnchor_0.HideSelection = True
		Me._txtAnchor_0.ReadOnly = False
		Me._txtAnchor_0.Maxlength = 0
		Me._txtAnchor_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtAnchor_0.MultiLine = False
		Me._txtAnchor_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtAnchor_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtAnchor_0.TabStop = True
		Me._txtAnchor_0.Visible = True
		Me._txtAnchor_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtAnchor_0.Name = "_txtAnchor_0"
		Me._lblAnchorCmt_3.Text = "*"
		Me._lblAnchorCmt_3.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._lblAnchorCmt_3.Size = New System.Drawing.Size(9, 17)
		Me._lblAnchorCmt_3.Location = New System.Drawing.Point(18, 190)
		Me._lblAnchorCmt_3.TabIndex = 87
		Me._lblAnchorCmt_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblAnchorCmt_3.BackColor = System.Drawing.SystemColors.Control
		Me._lblAnchorCmt_3.Enabled = True
		Me._lblAnchorCmt_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblAnchorCmt_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblAnchorCmt_3.UseMnemonic = True
		Me._lblAnchorCmt_3.Visible = True
		Me._lblAnchorCmt_3.AutoSize = False
		Me._lblAnchorCmt_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblAnchorCmt_3.Name = "_lblAnchorCmt_3"
		Me._lblAnchorCmt_2.Text = "Positive Slope: up towards well"
		Me._lblAnchorCmt_2.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._lblAnchorCmt_2.Size = New System.Drawing.Size(148, 15)
		Me._lblAnchorCmt_2.Location = New System.Drawing.Point(32, 189)
		Me._lblAnchorCmt_2.TabIndex = 86
		Me._lblAnchorCmt_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblAnchorCmt_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblAnchorCmt_2.Enabled = True
		Me._lblAnchorCmt_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblAnchorCmt_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblAnchorCmt_2.UseMnemonic = True
		Me._lblAnchorCmt_2.Visible = True
		Me._lblAnchorCmt_2.AutoSize = False
		Me._lblAnchorCmt_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblAnchorCmt_2.Name = "_lblAnchorCmt_2"
		Me._lblAngleUnit_2.Text = "Invalid_string_refer_to_original_code"
		Me._lblAngleUnit_2.Size = New System.Drawing.Size(17, 17)
		Me._lblAngleUnit_2.Location = New System.Drawing.Point(136, 96)
		Me._lblAngleUnit_2.TabIndex = 79
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
		Me._lblLengthUnit_10.Text = "ft"
		Me._lblLengthUnit_10.Size = New System.Drawing.Size(17, 17)
		Me._lblLengthUnit_10.Location = New System.Drawing.Point(153, 77)
		Me._lblLengthUnit_10.TabIndex = 77
		Me._lblLengthUnit_10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLengthUnit_10.BackColor = System.Drawing.SystemColors.Control
		Me._lblLengthUnit_10.Enabled = True
		Me._lblLengthUnit_10.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLengthUnit_10.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLengthUnit_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLengthUnit_10.UseMnemonic = True
		Me._lblLengthUnit_10.Visible = True
		Me._lblLengthUnit_10.AutoSize = False
		Me._lblLengthUnit_10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLengthUnit_10.Name = "_lblLengthUnit_10"
		Me._lblLengthUnit_9.Text = "ft"
		Me._lblLengthUnit_9.Size = New System.Drawing.Size(17, 17)
		Me._lblLengthUnit_9.Location = New System.Drawing.Point(154, 51)
		Me._lblLengthUnit_9.TabIndex = 76
		Me._lblLengthUnit_9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLengthUnit_9.BackColor = System.Drawing.SystemColors.Control
		Me._lblLengthUnit_9.Enabled = True
		Me._lblLengthUnit_9.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLengthUnit_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLengthUnit_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLengthUnit_9.UseMnemonic = True
		Me._lblLengthUnit_9.Visible = True
		Me._lblLengthUnit_9.AutoSize = False
		Me._lblLengthUnit_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLengthUnit_9.Name = "_lblLengthUnit_9"
		Me._lblLengthUnit_8.Text = "ft"
		Me._lblLengthUnit_8.Size = New System.Drawing.Size(15, 17)
		Me._lblLengthUnit_8.Location = New System.Drawing.Point(154, 26)
		Me._lblLengthUnit_8.TabIndex = 75
		Me._lblLengthUnit_8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLengthUnit_8.BackColor = System.Drawing.SystemColors.Control
		Me._lblLengthUnit_8.Enabled = True
		Me._lblLengthUnit_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLengthUnit_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLengthUnit_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLengthUnit_8.UseMnemonic = True
		Me._lblLengthUnit_8.Visible = True
		Me._lblLengthUnit_8.AutoSize = False
		Me._lblLengthUnit_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLengthUnit_8.Name = "_lblLengthUnit_8"
		Me._lblAnchor_3.Text = "Slope"
		Me._lblAnchor_3.Size = New System.Drawing.Size(33, 17)
		Me._lblAnchor_3.Location = New System.Drawing.Point(36, 96)
		Me._lblAnchor_3.TabIndex = 56
		Me._lblAnchor_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblAnchor_3.BackColor = System.Drawing.SystemColors.Control
		Me._lblAnchor_3.Enabled = True
		Me._lblAnchor_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblAnchor_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblAnchor_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblAnchor_3.UseMnemonic = True
		Me._lblAnchor_3.Visible = True
		Me._lblAnchor_3.AutoSize = False
		Me._lblAnchor_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblAnchor_3.Name = "_lblAnchor_3"
		Me._lblAnchorCmt_1.Text = "*"
		Me._lblAnchorCmt_1.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._lblAnchorCmt_1.Size = New System.Drawing.Size(9, 17)
		Me._lblAnchorCmt_1.Location = New System.Drawing.Point(17, 159)
		Me._lblAnchorCmt_1.TabIndex = 59
		Me._lblAnchorCmt_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblAnchorCmt_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblAnchorCmt_1.Enabled = True
		Me._lblAnchorCmt_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblAnchorCmt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblAnchorCmt_1.UseMnemonic = True
		Me._lblAnchorCmt_1.Visible = True
		Me._lblAnchorCmt_1.AutoSize = False
		Me._lblAnchorCmt_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblAnchorCmt_1.Name = "_lblAnchorCmt_1"
		Me._lblAnchorCmt_0.Text = "x,y are in global coordinate system (E-N system)"
		Me._lblAnchorCmt_0.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._lblAnchorCmt_0.Size = New System.Drawing.Size(148, 29)
		Me._lblAnchorCmt_0.Location = New System.Drawing.Point(32, 155)
		Me._lblAnchorCmt_0.TabIndex = 60
		Me._lblAnchorCmt_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblAnchorCmt_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblAnchorCmt_0.Enabled = True
		Me._lblAnchorCmt_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblAnchorCmt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblAnchorCmt_0.UseMnemonic = True
		Me._lblAnchorCmt_0.Visible = True
		Me._lblAnchorCmt_0.AutoSize = False
		Me._lblAnchorCmt_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblAnchorCmt_0.Name = "_lblAnchorCmt_0"
		Me._lblAnchor_2.Text = "Depth"
		Me._lblAnchor_2.Size = New System.Drawing.Size(33, 17)
		Me._lblAnchor_2.Location = New System.Drawing.Point(36, 72)
		Me._lblAnchor_2.TabIndex = 54
		Me._lblAnchor_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblAnchor_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblAnchor_2.Enabled = True
		Me._lblAnchor_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblAnchor_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblAnchor_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblAnchor_2.UseMnemonic = True
		Me._lblAnchor_2.Visible = True
		Me._lblAnchor_2.AutoSize = False
		Me._lblAnchor_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblAnchor_2.Name = "_lblAnchor_2"
		Me._lblAnchor_1.Text = "y (N)"
		Me._lblAnchor_1.Size = New System.Drawing.Size(33, 17)
		Me._lblAnchor_1.Location = New System.Drawing.Point(36, 48)
		Me._lblAnchor_1.TabIndex = 52
		Me._lblAnchor_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblAnchor_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblAnchor_1.Enabled = True
		Me._lblAnchor_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblAnchor_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblAnchor_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblAnchor_1.UseMnemonic = True
		Me._lblAnchor_1.Visible = True
		Me._lblAnchor_1.AutoSize = False
		Me._lblAnchor_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblAnchor_1.Name = "_lblAnchor_1"
		Me._lblAnchor_0.Text = "x (E)"
		Me._lblAnchor_0.Size = New System.Drawing.Size(33, 17)
		Me._lblAnchor_0.Location = New System.Drawing.Point(36, 24)
		Me._lblAnchor_0.TabIndex = 50
		Me._lblAnchor_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblAnchor_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblAnchor_0.Enabled = True
		Me._lblAnchor_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblAnchor_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblAnchor_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblAnchor_0.UseMnemonic = True
		Me._lblAnchor_0.Visible = True
		Me._lblAnchor_0.AutoSize = False
		Me._lblAnchor_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblAnchor_0.Name = "_lblAnchor_0"
		Me.fraFairLead.Text = "Fair Lead Location :"
		Me.fraFairLead.Size = New System.Drawing.Size(201, 217)
		Me.fraFairLead.Location = New System.Drawing.Point(406, 192)
		Me.fraFairLead.TabIndex = 37
		Me.fraFairLead.BackColor = System.Drawing.SystemColors.Control
		Me.fraFairLead.Enabled = True
		Me.fraFairLead.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraFairLead.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraFairLead.Visible = True
		Me.fraFairLead.Name = "fraFairLead"
		Me._txtFL_2.AutoSize = False
		Me._txtFL_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtFL_2.Size = New System.Drawing.Size(49, 19)
		Me._txtFL_2.Location = New System.Drawing.Point(57, 73)
		Me._txtFL_2.TabIndex = 45
		Me._txtFL_2.Text = "0"
		Me._txtFL_2.AcceptsReturn = True
		Me._txtFL_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtFL_2.CausesValidation = True
		Me._txtFL_2.Enabled = True
		Me._txtFL_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFL_2.HideSelection = True
		Me._txtFL_2.ReadOnly = False
		Me._txtFL_2.Maxlength = 0
		Me._txtFL_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFL_2.MultiLine = False
		Me._txtFL_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFL_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFL_2.TabStop = True
		Me._txtFL_2.Visible = True
		Me._txtFL_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFL_2.Name = "_txtFL_2"
		Me._txtFL_1.AutoSize = False
		Me._txtFL_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtFL_1.Size = New System.Drawing.Size(49, 19)
		Me._txtFL_1.Location = New System.Drawing.Point(57, 49)
		Me._txtFL_1.TabIndex = 42
		Me._txtFL_1.Text = "0"
		Me._txtFL_1.AcceptsReturn = True
		Me._txtFL_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtFL_1.CausesValidation = True
		Me._txtFL_1.Enabled = True
		Me._txtFL_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFL_1.HideSelection = True
		Me._txtFL_1.ReadOnly = False
		Me._txtFL_1.Maxlength = 0
		Me._txtFL_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFL_1.MultiLine = False
		Me._txtFL_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFL_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFL_1.TabStop = True
		Me._txtFL_1.Visible = True
		Me._txtFL_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFL_1.Name = "_txtFL_1"
		Me._txtFL_0.AutoSize = False
		Me._txtFL_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me._txtFL_0.Size = New System.Drawing.Size(49, 19)
		Me._txtFL_0.Location = New System.Drawing.Point(57, 25)
		Me._txtFL_0.TabIndex = 39
		Me._txtFL_0.Text = "0"
		Me._txtFL_0.AcceptsReturn = True
		Me._txtFL_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtFL_0.CausesValidation = True
		Me._txtFL_0.Enabled = True
		Me._txtFL_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFL_0.HideSelection = True
		Me._txtFL_0.ReadOnly = False
		Me._txtFL_0.Maxlength = 0
		Me._txtFL_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFL_0.MultiLine = False
		Me._txtFL_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFL_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFL_0.TabStop = True
		Me._txtFL_0.Visible = True
		Me._txtFL_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFL_0.Name = "_txtFL_0"
		Me._lblLengthUnit_7.Text = "ft"
		Me._lblLengthUnit_7.Size = New System.Drawing.Size(17, 17)
		Me._lblLengthUnit_7.Location = New System.Drawing.Point(109, 76)
		Me._lblLengthUnit_7.TabIndex = 74
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
		Me._lblLengthUnit_6.Text = "ft"
		Me._lblLengthUnit_6.Size = New System.Drawing.Size(17, 17)
		Me._lblLengthUnit_6.Location = New System.Drawing.Point(110, 51)
		Me._lblLengthUnit_6.TabIndex = 73
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
		Me._lblLengthUnit_5.Location = New System.Drawing.Point(110, 27)
		Me._lblLengthUnit_5.TabIndex = 72
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
		Me._lblFL_2.Text = "z"
		Me._lblFL_2.Size = New System.Drawing.Size(17, 17)
		Me._lblFL_2.Location = New System.Drawing.Point(41, 73)
		Me._lblFL_2.TabIndex = 44
		Me._lblFL_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFL_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblFL_2.Enabled = True
		Me._lblFL_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFL_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFL_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFL_2.UseMnemonic = True
		Me._lblFL_2.Visible = True
		Me._lblFL_2.AutoSize = False
		Me._lblFL_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFL_2.Name = "_lblFL_2"
		Me._lblFLUnit_2.Text = " (abv BL)"
		Me._lblFLUnit_2.Size = New System.Drawing.Size(48, 17)
		Me._lblFLUnit_2.Location = New System.Drawing.Point(128, 75)
		Me._lblFLUnit_2.TabIndex = 46
		Me._lblFLUnit_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFLUnit_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblFLUnit_2.Enabled = True
		Me._lblFLUnit_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFLUnit_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFLUnit_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFLUnit_2.UseMnemonic = True
		Me._lblFLUnit_2.Visible = True
		Me._lblFLUnit_2.AutoSize = False
		Me._lblFLUnit_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFLUnit_2.Name = "_lblFLUnit_2"
		Me._lblFLCmt_1.Text = "*"
		Me._lblFLCmt_1.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._lblFLCmt_1.Size = New System.Drawing.Size(9, 17)
		Me._lblFLCmt_1.Location = New System.Drawing.Point(37, 164)
		Me._lblFLCmt_1.TabIndex = 47
		Me._lblFLCmt_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFLCmt_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblFLCmt_1.Enabled = True
		Me._lblFLCmt_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFLCmt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFLCmt_1.UseMnemonic = True
		Me._lblFLCmt_1.Visible = True
		Me._lblFLCmt_1.AutoSize = False
		Me._lblFLCmt_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFLCmt_1.Name = "_lblFLCmt_1"
		Me._lblFLCmt_0.Text = "Defined in the vessel local coordinate system"
		Me._lblFLCmt_0.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._lblFLCmt_0.Size = New System.Drawing.Size(105, 41)
		Me._lblFLCmt_0.Location = New System.Drawing.Point(53, 164)
		Me._lblFLCmt_0.TabIndex = 48
		Me._lblFLCmt_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFLCmt_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblFLCmt_0.Enabled = True
		Me._lblFLCmt_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFLCmt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFLCmt_0.UseMnemonic = True
		Me._lblFLCmt_0.Visible = True
		Me._lblFLCmt_0.AutoSize = False
		Me._lblFLCmt_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFLCmt_0.Name = "_lblFLCmt_0"
		Me._lblFLUnit_1.Text = " (+, port)"
		Me._lblFLUnit_1.Size = New System.Drawing.Size(41, 17)
		Me._lblFLUnit_1.Location = New System.Drawing.Point(129, 51)
		Me._lblFLUnit_1.TabIndex = 43
		Me._lblFLUnit_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFLUnit_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblFLUnit_1.Enabled = True
		Me._lblFLUnit_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFLUnit_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFLUnit_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFLUnit_1.UseMnemonic = True
		Me._lblFLUnit_1.Visible = True
		Me._lblFLUnit_1.AutoSize = False
		Me._lblFLUnit_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFLUnit_1.Name = "_lblFLUnit_1"
		Me._lblFL_1.Text = "y"
		Me._lblFL_1.Size = New System.Drawing.Size(17, 17)
		Me._lblFL_1.Location = New System.Drawing.Point(41, 49)
		Me._lblFL_1.TabIndex = 41
		Me._lblFL_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFL_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblFL_1.Enabled = True
		Me._lblFL_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFL_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFL_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFL_1.UseMnemonic = True
		Me._lblFL_1.Visible = True
		Me._lblFL_1.AutoSize = False
		Me._lblFL_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFL_1.Name = "_lblFL_1"
		Me._lblFLUnit_0.Text = " (+, fwd)"
		Me._lblFLUnit_0.Size = New System.Drawing.Size(43, 17)
		Me._lblFLUnit_0.Location = New System.Drawing.Point(128, 26)
		Me._lblFLUnit_0.TabIndex = 40
		Me._lblFLUnit_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFLUnit_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblFLUnit_0.Enabled = True
		Me._lblFLUnit_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFLUnit_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFLUnit_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFLUnit_0.UseMnemonic = True
		Me._lblFLUnit_0.Visible = True
		Me._lblFLUnit_0.AutoSize = False
		Me._lblFLUnit_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFLUnit_0.Name = "_lblFLUnit_0"
		Me._lblFL_0.Text = "x"
		Me._lblFL_0.Size = New System.Drawing.Size(17, 17)
		Me._lblFL_0.Location = New System.Drawing.Point(41, 25)
		Me._lblFL_0.TabIndex = 38
		Me._lblFL_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFL_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblFL_0.Enabled = True
		Me._lblFL_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFL_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFL_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFL_0.UseMnemonic = True
		Me._lblFL_0.Visible = True
		Me._lblFL_0.AutoSize = False
		Me._lblFL_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFL_0.Name = "_lblFL_0"
		tabMoorLines.OcxState = CType(resources.GetObject("tabMoorLines.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabMoorLines.Size = New System.Drawing.Size(818, 480)
		Me.tabMoorLines.Location = New System.Drawing.Point(8, 126)
		Me.tabMoorLines.TabIndex = 12
		Me.tabMoorLines.Name = "tabMoorLines"
		SysInfo1.OcxState = CType(resources.GetObject("SysInfo1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.SysInfo1.Location = New System.Drawing.Point(16, 88)
		Me.SysInfo1.Name = "SysInfo1"
		Me._lblVelUnit_0.Text = "kn"
		Me._lblVelUnit_0.Size = New System.Drawing.Size(25, 17)
		Me._lblVelUnit_0.Location = New System.Drawing.Point(0, 0)
		Me._lblVelUnit_0.TabIndex = 88
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
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Text = "&File"
		Me.mnuFile.Enabled = False
		Me.mnuFile.Visible = False
		Me.mnuFile.Checked = False
		Me.mnuOpen.Name = "mnuOpen"
		Me.mnuOpen.Text = "&Import..."
		Me.mnuOpen.Checked = False
		Me.mnuOpen.Enabled = True
		Me.mnuOpen.Visible = True
		Me.mnuSave.Name = "mnuSave"
		Me.mnuSave.Text = "&Export..."
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
		Me.mnuGridEdit.Name = "mnuGridEdit"
		Me.mnuGridEdit.Text = ""
		Me.mnuGridEdit.Visible = False
		Me.mnuGridEdit.Checked = False
		Me.mnuGridEdit.Enabled = True
		Me.mnuInsert.Name = "mnuInsert"
		Me.mnuInsert.Text = "&Insert Segment"
		Me.mnuInsert.Checked = False
		Me.mnuInsert.Enabled = True
		Me.mnuInsert.Visible = True
		Me.mnuDelete.Name = "mnuDelete"
		Me.mnuDelete.Text = "&Delete Segment"
		Me.mnuDelete.Checked = False
		Me.mnuDelete.Enabled = True
		Me.mnuDelete.Visible = True
		Me.Controls.Add(Frame1)
		Me.Controls.Add(fraVesselLoc)
		Me.Controls.Add(btnCatenary)
		Me.Controls.Add(fraSegments)
		Me.Controls.Add(fraGeneral)
		Me.Controls.Add(chkBatch)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(btnNew)
		Me.Controls.Add(btnRemove)
		Me.Controls.Add(btnSave)
		Me.Controls.Add(fraTopTen)
		Me.Controls.Add(fraAnchor)
		Me.Controls.Add(fraFairLead)
		Me.Controls.Add(tabMoorLines)
		Me.Controls.Add(SysInfo1)
		Me.Controls.Add(_lblVelUnit_0)
		Me.Frame1.Controls.Add(_txtVslSt_3)
		Me.Frame1.Controls.Add(cboDraft)
		Me.Frame1.Controls.Add(_lblLengthUnit_2)
		Me.fraVesselLoc.Controls.Add(txtWD)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_2)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_1)
		Me.fraVesselLoc.Controls.Add(_txtVslSt_0)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_3)
		Me.fraVesselLoc.Controls.Add(_lblLengthUnit_11)
		Me.fraVesselLoc.Controls.Add(_lblLengthUnit_1)
		Me.fraVesselLoc.Controls.Add(_lblAngleUnit_0)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_2)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_1)
		Me.fraVesselLoc.Controls.Add(_lblVslSt_0)
		Me.fraVesselLoc.Controls.Add(_lblLengthUnit_0)
		Me.fraSegments.Controls.Add(cboSegType)
		Me.fraSegments.Controls.Add(txtSegEdit)
		Me.fraSegments.Controls.Add(txtAnchEdit)
		Me.fraSegments.Controls.Add(grdSegments)
		Me.fraSegments.Controls.Add(grdAnchor)
		Me.fraSegments.Controls.Add(_lblSegCmt_0)
		Me.fraSegments.Controls.Add(_lblSegCmt_1)
		Me.fraGeneral.Controls.Add(btnPayout)
		Me.fraGeneral.Controls.Add(btnScope)
		Me.fraGeneral.Controls.Add(_txtGeneral_2)
		Me.fraGeneral.Controls.Add(_txtGeneral_1)
		Me.fraGeneral.Controls.Add(_txtGeneral_0)
		Me.fraGeneral.Controls.Add(_lblAngleUnit_1)
		Me.fraGeneral.Controls.Add(_lblLengthUnit_4)
		Me.fraGeneral.Controls.Add(_lblLengthUnit_3)
		Me.fraGeneral.Controls.Add(_lblGenCmt_0)
		Me.fraGeneral.Controls.Add(_lblGenCmt_1)
		Me.fraGeneral.Controls.Add(_lblGeneral_2)
		Me.fraGeneral.Controls.Add(_lblGeneral_1)
		Me.fraGeneral.Controls.Add(_lblGeneral_0)
		Me.fraTopTen.Controls.Add(btnTopTension)
		Me.fraTopTen.Controls.Add(btnPreten)
		Me.fraTopTen.Controls.Add(_txtPreTen_1)
		Me.fraTopTen.Controls.Add(txtTopTen)
		Me.fraTopTen.Controls.Add(_txtPreTen_0)
		Me.fraTopTen.Controls.Add(_lblForceUnit_2)
		Me.fraTopTen.Controls.Add(_lblForceUnit_1)
		Me.fraTopTen.Controls.Add(Label1)
		Me.fraTopTen.Controls.Add(_lblPreTen_1)
		Me.fraTopTen.Controls.Add(lblTopTen)
		Me.fraTopTen.Controls.Add(_lblForceUnit_0)
		Me.fraTopTen.Controls.Add(_lblPreTen_0)
		Me.fraAnchor.Controls.Add(btnAnchor)
		Me.fraAnchor.Controls.Add(_txtAnchor_3)
		Me.fraAnchor.Controls.Add(_txtAnchor_2)
		Me.fraAnchor.Controls.Add(_txtAnchor_1)
		Me.fraAnchor.Controls.Add(_txtAnchor_0)
		Me.fraAnchor.Controls.Add(_lblAnchorCmt_3)
		Me.fraAnchor.Controls.Add(_lblAnchorCmt_2)
		Me.fraAnchor.Controls.Add(_lblAngleUnit_2)
		Me.fraAnchor.Controls.Add(_lblLengthUnit_10)
		Me.fraAnchor.Controls.Add(_lblLengthUnit_9)
		Me.fraAnchor.Controls.Add(_lblLengthUnit_8)
		Me.fraAnchor.Controls.Add(_lblAnchor_3)
		Me.fraAnchor.Controls.Add(_lblAnchorCmt_1)
		Me.fraAnchor.Controls.Add(_lblAnchorCmt_0)
		Me.fraAnchor.Controls.Add(_lblAnchor_2)
		Me.fraAnchor.Controls.Add(_lblAnchor_1)
		Me.fraAnchor.Controls.Add(_lblAnchor_0)
		Me.fraFairLead.Controls.Add(_txtFL_2)
		Me.fraFairLead.Controls.Add(_txtFL_1)
		Me.fraFairLead.Controls.Add(_txtFL_0)
		Me.fraFairLead.Controls.Add(_lblLengthUnit_7)
		Me.fraFairLead.Controls.Add(_lblLengthUnit_6)
		Me.fraFairLead.Controls.Add(_lblLengthUnit_5)
		Me.fraFairLead.Controls.Add(_lblFL_2)
		Me.fraFairLead.Controls.Add(_lblFLUnit_2)
		Me.fraFairLead.Controls.Add(_lblFLCmt_1)
		Me.fraFairLead.Controls.Add(_lblFLCmt_0)
		Me.fraFairLead.Controls.Add(_lblFLUnit_1)
		Me.fraFairLead.Controls.Add(_lblFL_1)
		Me.fraFairLead.Controls.Add(_lblFLUnit_0)
		Me.fraFairLead.Controls.Add(_lblFL_0)
		Me.lblAnchor.SetIndex(_lblAnchor_3, CType(3, Short))
		Me.lblAnchor.SetIndex(_lblAnchor_2, CType(2, Short))
		Me.lblAnchor.SetIndex(_lblAnchor_1, CType(1, Short))
		Me.lblAnchor.SetIndex(_lblAnchor_0, CType(0, Short))
		Me.lblAnchorCmt.SetIndex(_lblAnchorCmt_3, CType(3, Short))
		Me.lblAnchorCmt.SetIndex(_lblAnchorCmt_2, CType(2, Short))
		Me.lblAnchorCmt.SetIndex(_lblAnchorCmt_1, CType(1, Short))
		Me.lblAnchorCmt.SetIndex(_lblAnchorCmt_0, CType(0, Short))
		Me.lblAngleUnit.SetIndex(_lblAngleUnit_0, CType(0, Short))
		Me.lblAngleUnit.SetIndex(_lblAngleUnit_1, CType(1, Short))
		Me.lblAngleUnit.SetIndex(_lblAngleUnit_2, CType(2, Short))
		Me.lblFL.SetIndex(_lblFL_2, CType(2, Short))
		Me.lblFL.SetIndex(_lblFL_1, CType(1, Short))
		Me.lblFL.SetIndex(_lblFL_0, CType(0, Short))
		Me.lblFLCmt.SetIndex(_lblFLCmt_1, CType(1, Short))
		Me.lblFLCmt.SetIndex(_lblFLCmt_0, CType(0, Short))
		Me.lblFLUnit.SetIndex(_lblFLUnit_2, CType(2, Short))
		Me.lblFLUnit.SetIndex(_lblFLUnit_1, CType(1, Short))
		Me.lblFLUnit.SetIndex(_lblFLUnit_0, CType(0, Short))
		Me.lblForceUnit.SetIndex(_lblForceUnit_2, CType(2, Short))
		Me.lblForceUnit.SetIndex(_lblForceUnit_1, CType(1, Short))
		Me.lblForceUnit.SetIndex(_lblForceUnit_0, CType(0, Short))
		Me.lblGenCmt.SetIndex(_lblGenCmt_0, CType(0, Short))
		Me.lblGenCmt.SetIndex(_lblGenCmt_1, CType(1, Short))
		Me.lblGeneral.SetIndex(_lblGeneral_2, CType(2, Short))
		Me.lblGeneral.SetIndex(_lblGeneral_1, CType(1, Short))
		Me.lblGeneral.SetIndex(_lblGeneral_0, CType(0, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_2, CType(2, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_11, CType(11, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_1, CType(1, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_0, CType(0, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_4, CType(4, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_3, CType(3, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_10, CType(10, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_9, CType(9, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_8, CType(8, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_7, CType(7, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_6, CType(6, Short))
		Me.lblLengthUnit.SetIndex(_lblLengthUnit_5, CType(5, Short))
		Me.lblPreTen.SetIndex(_lblPreTen_1, CType(1, Short))
		Me.lblPreTen.SetIndex(_lblPreTen_0, CType(0, Short))
		Me.lblSegCmt.SetIndex(_lblSegCmt_0, CType(0, Short))
		Me.lblSegCmt.SetIndex(_lblSegCmt_1, CType(1, Short))
		Me.lblVelUnit.SetIndex(_lblVelUnit_0, CType(0, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_3, CType(3, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_2, CType(2, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_1, CType(1, Short))
		Me.lblVslSt.SetIndex(_lblVslSt_0, CType(0, Short))
		Me.txtAnchor.SetIndex(_txtAnchor_3, CType(3, Short))
		Me.txtAnchor.SetIndex(_txtAnchor_2, CType(2, Short))
		Me.txtAnchor.SetIndex(_txtAnchor_1, CType(1, Short))
		Me.txtAnchor.SetIndex(_txtAnchor_0, CType(0, Short))
		Me.txtFL.SetIndex(_txtFL_2, CType(2, Short))
		Me.txtFL.SetIndex(_txtFL_1, CType(1, Short))
		Me.txtFL.SetIndex(_txtFL_0, CType(0, Short))
		Me.txtGeneral.SetIndex(_txtGeneral_2, CType(2, Short))
		Me.txtGeneral.SetIndex(_txtGeneral_1, CType(1, Short))
		Me.txtGeneral.SetIndex(_txtGeneral_0, CType(0, Short))
		Me.txtPreTen.SetIndex(_txtPreTen_1, CType(1, Short))
		Me.txtPreTen.SetIndex(_txtPreTen_0, CType(0, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_3, CType(3, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_2, CType(2, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_1, CType(1, Short))
		Me.txtVslSt.SetIndex(_txtVslSt_0, CType(0, Short))
		CType(Me.txtVslSt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPreTen, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtGeneral, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtFL, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtAnchor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblVslSt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblVelUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblSegCmt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblPreTen, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblLengthUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblGeneral, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblGenCmt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblForceUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblFLUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblFLCmt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblFL, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblAngleUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblAnchorCmt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblAnchor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SysInfo1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabMoorLines, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdAnchor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdSegments, System.ComponentModel.ISupportInitialize).EndInit()
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuFile, Me.mnuGridEdit})
		mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuOpen, Me.mnuSave, Me.mnuDum, Me.mnuClose})
		mnuGridEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuInsert, Me.mnuDelete})
		Me.Controls.Add(MainMenu1)
		Me.Frame1.ResumeLayout(False)
		Me.fraVesselLoc.ResumeLayout(False)
		Me.fraSegments.ResumeLayout(False)
		Me.fraGeneral.ResumeLayout(False)
		Me.fraTopTen.ResumeLayout(False)
		Me.fraAnchor.ResumeLayout(False)
		Me.fraFairLead.ResumeLayout(False)
		Me.MainMenu1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class