Option Strict Off
Option Explicit On
Friend Class frmPlot
	Inherits System.Windows.Forms.Form
	
	Private anObj2 As PltVessel
	Private anRiser As Riser
	Private anSeaBed As PltSeabed
	Private anPipeLines As PltPipeLines
	Private anSurface As PltWaterSurface
	Private MDown As Boolean
	Private MX0, MY0 As Double
	Private H, V As Short
	
	Public PlotIn3D As Boolean
	
	
	Private Sub frmPlot_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Dim Hmax, Vmax As Short
		
		'   Set up the graphics
		'UPGRADE_ISSUE: PictureBox property ThreeD.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		ThreeD.AutoRedraw = True
		
		anObj2 = New PltVessel
		anRiser = New Riser
		anSeaBed = New PltSeabed
		anPipeLines = New PltPipeLines
		anSurface = New PltWaterSurface
		anSeaBed.WaterDepth = CurVessel.WaterDepth
		lblVessel.Text = CurVessel.Name
		
		H = 0
		V = 0
		
		txtPicControls(0).Text = VB6.Format(H, "##0")
		txtPicControls(1).Text = VB6.Format(V, "##0")
		
		frmMain.PlotShow = True
		
	End Sub
	
	Private Sub frmPlot_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		frmMain.PlotShow = False
		'UPGRADE_NOTE: Object anObj2 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		anObj2 = Nothing
		'UPGRADE_NOTE: Object anRiser may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		anRiser = Nothing
		'UPGRADE_NOTE: Object anSeaBed may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		anSeaBed = Nothing
		'UPGRADE_NOTE: Object anPipeLines may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		anPipeLines = Nothing
		'UPGRADE_NOTE: Object anSurface may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		anSurface = Nothing
		
	End Sub
	
	' buttons
	
	Private Sub btnClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnClose.Click
		
		Me.Close()
		
	End Sub
	
	Private Sub btnPlot_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPlot.Click
		Dim Index As Short = btnPlot.GetIndex(eventSender)
		
		Select Case Index
			Case 0
				PlotIn3D = True
			Case 1
				PlotIn3D = False
		End Select
		UpdatePicture(True)
		
	End Sub
	
	Private Sub btnZoom_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnZoom.Click
		Dim Index As Short = btnZoom.GetIndex(eventSender)
		
		Dim ZoomRatio As Double
		Dim RetVal As Boolean
		
		btnZoom(1 - Index).Enabled = True
		Select Case Index
			Case 0
				ZoomRatio = 1.25
			Case 1
				ZoomRatio = 0.75
		End Select
		
		If Not Zoom(ZoomRatio) Then btnZoom(Index).Enabled = False
		AddNorthIndicator((-hScroll_Renamed.Value * Degrees2Radians))
		
	End Sub
	
	' picture box
	
	Private Sub ThreeD_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles ThreeD.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		If Not PlotIn3D Then Exit Sub
		MDown = True
		
	End Sub
	
	Private Sub ThreeD_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles ThreeD.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Dim V, Vmax As Short
		Dim H, Hmax As Short
		
		If Not PlotIn3D Then Exit Sub
		
		If MDown Then
			Hmax = (hPan.Maximum - hPan.LargeChange + 1)
			Vmax = (vPan.Maximum - vPan.LargeChange + 1)
			H = hPan.Value
			V = vPan.Value
			
			With ThreeD
				H = H + (X - VB6.PixelsToTwipsX(.Width) / 2) * Hmax / VB6.PixelsToTwipsX(.Width)
				V = V + (Y - VB6.PixelsToTwipsY(.Height) / 2) * Vmax / VB6.PixelsToTwipsY(.Height)
			End With
			
			If H > Hmax Then H = Hmax
			If H < 0 Then H = 0
			
			If V > Vmax Then V = Vmax
			If V < 0 Then V = 0
			
			hPan.Value = H
			vPan.Value = V
			
			MDown = False
		End If
		
	End Sub
	
	' scroll bars
	
	'UPGRADE_NOTE: hScroll.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: HScrollBar event hScroll.Change has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub hScroll_Change(ByVal newScrollValue As Integer)
		
		Dim CurWell As Well
		
		H = hScroll_Renamed.Value
		With CurField
			CurWell = .Item(.CurWellNo)
		End With
		
		anObj2.angleChange(H, V)
		anObj2.drawBoat()
		With CurVessel
			anRiser.angleChange(H, V)
			anRiser.drawRiser(CurWell, .ShipCurGlob, .ShipDraft)
			
			anSeaBed.angleChange(H - .ShipCurGlob.Heading * Radians2Degrees, V)
			anSeaBed.drawSeabed(.ShipCurGlob, .ShipDraft)
			
			anPipeLines.angleChange(H - .ShipCurGlob.Heading * Radians2Degrees, V)
			anPipeLines.drawPipeLines(.ShipCurGlob, .ShipDraft)
			
			anSurface.angleChange(H - .ShipCurGlob.Heading * Radians2Degrees, V)
			anSurface.drawSurface(.ShipDraft)
		End With
		
		txtPicControls(0).Text = VB6.Format(H, "##0")
		AddNorthIndicator((-H * Degrees2Radians))
		
	End Sub
	
	'UPGRADE_NOTE: vScroll.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: VScrollBar event vScroll.Change has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub vScroll_Change(ByVal newScrollValue As Integer)
		
		Dim CurWell As Well
		
		V = 90 - vScroll_Renamed.Value
		With CurField
			CurWell = .Item(.CurWellNo)
		End With
		
		anObj2.angleChange(H, V)
		anObj2.drawBoat()
		With CurVessel
			anRiser.angleChange(H, V)
			anRiser.drawRiser(CurWell, .ShipCurGlob, .ShipDraft)
			
			anSeaBed.angleChange(H - .ShipCurGlob.Heading * Radians2Degrees, V)
			anSeaBed.drawSeabed(.ShipCurGlob, .ShipDraft)
			
			anPipeLines.angleChange(H - .ShipCurGlob.Heading * Radians2Degrees, V)
			anPipeLines.drawPipeLines(.ShipCurGlob, .ShipDraft)
			
			anSurface.angleChange(H - .ShipCurGlob.Heading * Radians2Degrees, V)
			anSurface.drawSurface(.ShipDraft)
		End With
		
		txtPicControls(1).Text = VB6.Format(V, "##0")
		AddNorthIndicator((-H * Degrees2Radians))
		
	End Sub
	
	'UPGRADE_NOTE: vPan.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: VScrollBar event vPan.Change has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub vPan_Change(ByVal newScrollValue As Integer)
		
		PanChange()
		
	End Sub
	
	'UPGRADE_NOTE: hPan.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: HScrollBar event hPan.Change has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub hPan_Change(ByVal newScrollValue As Integer)
		
		PanChange()
		
	End Sub
	
	' text boxes
	
	Private Sub txtPicControls_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtPicControls.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Dim Index As Short = txtPicControls.GetIndex(eventSender)
		
		Select Case KeyCode
			Case System.Windows.Forms.Keys.Return
				txtPicControls_Leave(txtPicControls.Item(Index), New System.EventArgs())
		End Select
		
	End Sub
	
	Private Sub txtPicControls_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPicControls.Leave
		Dim Index As Short = txtPicControls.GetIndex(eventSender)
		
		Dim SAng As Short
		
		SAng = CShort(CheckData(txtPicControls(Index).Text))
		Select Case Index
			Case 0
				With hScroll_Renamed
					If SAng > (.Maximum - .LargeChange + 1) Then
						SAng = (.Maximum - .LargeChange + 1)
					ElseIf SAng < .Minimum Then 
						SAng = .Minimum
					End If
					.Value = SAng
				End With
			Case 1
				With vScroll_Renamed
					If SAng > (.Maximum - .LargeChange + 1) Then
						SAng = (.Maximum - .LargeChange + 1)
					ElseIf SAng < .Minimum Then 
						SAng = .Minimum
					End If
					.Value = 90 - SAng
				End With
		End Select
		txtPicControls(Index).Text = CStr(SAng)
		
	End Sub
	
	' operations
	
	'UPGRADE_NOTE: Refresh was upgraded to Refresh_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub UpdatePicture(Optional ByVal Refresh_Renamed As Boolean = False)
		
		Dim Y, X, Heading As Double
		Dim Bearing, Dist, CompAngle As Double
		Dim i As Double
		Dim CatFile As String
		
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		
		'   Based upon which mode we're in (decided by which value was last changed),
		'   set the new position in Earth Global coordinates
		
		'   Compute the tensions, etc.
		
		'   Fill in the remaining values for the textboxes & grid of results
		
		If Not Refresh_Renamed Then
			CatFile = MarsDir & CatenaryFile
			If Not CurVessel.MoorSystem.GenCatenaryFile(CatFile) Then
				If PlotIn3D Then Exit Sub
			Else
				anObj2.UpdateCatenary(CatFile)
			End If
		End If
		If PlotIn3D Then
			Plot3D()
		Else
			PlotRadar()
		End If
		
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub AddNorthIndicator(ByVal NorthAngle As Double)
		
		NorthAngle = NorthAngle + CurVessel.ShipCurGlob.Heading
		Call DrawNorthArrow(NorthAngle, ThreeD)
		
	End Sub
	
	Private Sub Plot3D()
		
		Dim i As Short
		
		UpdateControls(True)
		
		With CurField
			With .Item(.CurWellNo)
				If .Depth <= 0# Then .Depth = CurVessel.WaterDepth
			End With
		End With
		
		vPan.Value = (vPan.Maximum - vPan.LargeChange + 1) / 2
		hPan.Value = (hPan.Maximum - hPan.LargeChange + 1) / 2
		
		'UPGRADE_ISSUE: PictureBox property ThreeD.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		ThreeD.AutoRedraw = True
		PanChange()
		
		anObj2.angleChange(H, V)
		With CurVessel
			anRiser.angleChange(H, V)
			anSeaBed.angleChange(H - .ShipCurGlob.Heading * Radians2Degrees, V)
			anPipeLines.angleChange(H - .ShipCurGlob.Heading * Radians2Degrees, V)
			anSurface.angleChange(H - .ShipCurGlob.Heading * Radians2Degrees, V)
		End With
		
		AddNorthIndicator((-H * Degrees2Radians))
		
	End Sub
	
	Private Sub PlotRadar()
		
		Dim i As Short
		Dim Y0, X0, Head0 As Double
		Dim WY, WX, WD As Double
		
		UpdateControls(False)
		
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		
		With CurVessel.ShipCurGlob
			X0 = .Xg
			Y0 = .Yg
			Head0 = .Heading
		End With
		
		With CurField
			WX = .Item(.CurWellNo).Xg
			WY = .Item(.CurWellNo).Yg
			WD = .Item(.CurWellNo).Depth
			If WD = 0# Then WD = CurVessel.WaterDepth
		End With
		
		Call DrawPolarPlot(WX, WY, WD, X0, Y0, Head0, ThreeD)
		
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub PanChange()
		
		Dim V, Vmax As Short
		Dim H, Hmax As Short
		Dim CurWell As Well
		
		With CurField
			CurWell = .Item(.CurWellNo)
		End With
		
		H = hPan.Value
		V = vPan.Value
		Hmax = (hPan.Maximum - hPan.LargeChange + 1)
		Vmax = (vPan.Maximum - vPan.LargeChange + 1)
		
		anObj2.setGraph(ThreeD, VB6.PixelsToTwipsX(ThreeD.Width) * (Hmax - H) / Hmax, VB6.PixelsToTwipsY(ThreeD.Height) * (Vmax - V) / Vmax, False)
		
		anRiser.setGraph(ThreeD, VB6.PixelsToTwipsX(ThreeD.Width) * (Hmax - H) / Hmax, VB6.PixelsToTwipsY(ThreeD.Height) * (Vmax - V) / Vmax, False)
		anSeaBed.setGraph(ThreeD, VB6.PixelsToTwipsX(ThreeD.Width) * (Hmax - H) / Hmax, VB6.PixelsToTwipsY(ThreeD.Height) * (Vmax - V) / Vmax, False)
		anPipeLines.setGraph(ThreeD, VB6.PixelsToTwipsX(ThreeD.Width) * (Hmax - H) / Hmax, VB6.PixelsToTwipsY(ThreeD.Height) * (Vmax - V) / Vmax, False)
		anSurface.setGraph(ThreeD, VB6.PixelsToTwipsX(ThreeD.Width) * (Hmax - H) / Hmax, VB6.PixelsToTwipsY(ThreeD.Height) * (Vmax - V) / Vmax, False)
		anObj2.drawBoat()
		
		With CurVessel
			anRiser.drawRiser(CurWell, .ShipCurGlob, .ShipDraft)
			anSeaBed.drawSeabed(.ShipCurGlob, .ShipDraft)
			anPipeLines.drawPipeLines(.ShipCurGlob, .ShipDraft)
			anSurface.drawSurface(.ShipDraft)
		End With
		
		AddNorthIndicator((-hScroll_Renamed.Value * Degrees2Radians))
		
	End Sub
	
	Private Sub UpdateControls(ByVal SetVal As Boolean)
		
		btnZoom(0).Visible = SetVal
		btnZoom(1).Visible = SetVal
		
		hScroll_Renamed.Visible = SetVal
		vScroll_Renamed.Visible = SetVal
		
		hPan.Enabled = SetVal
		vPan.Enabled = SetVal
		
		txtPicControls(0).Visible = SetVal
		txtPicControls(1).Visible = SetVal
		
		lblUnit(0).Visible = SetVal
		lblUnit(1).Visible = SetVal
		
		btnPlot(0).Enabled = Not SetVal
		btnPlot(1).Enabled = SetVal
		
	End Sub
	
	Private Function Zoom(ByVal ZoomRatio As Double) As Boolean
		
		Dim Zoom1 As Boolean
		Dim CurWell As Well
		
		With CurField
			CurWell = .Item(.CurWellNo)
		End With
		
		'UPGRADE_WARNING: Couldn't resolve default property of object anObj2.ZoomGraph(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Zoom = anObj2.ZoomGraph(ZoomRatio)
		With CurVessel
			'UPGRADE_WARNING: Couldn't resolve default property of object anRiser.ZoomGraph(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Zoom1 = anRiser.ZoomGraph(ZoomRatio, CurWell, .ShipCurGlob, .ShipDraft)
			'UPGRADE_WARNING: Couldn't resolve default property of object anSeaBed.ZoomGraph(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Zoom1 = anSeaBed.ZoomGraph(ZoomRatio, .ShipCurGlob, .ShipDraft)
			Zoom1 = anPipeLines.ZoomGraph(ZoomRatio, .ShipCurGlob, .ShipDraft)
			'UPGRADE_WARNING: Couldn't resolve default property of object anSurface.ZoomGraph(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Zoom1 = anSurface.ZoomGraph(ZoomRatio, .ShipDraft)
		End With
		
	End Function
	Private Sub hScroll_Renamed_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles hScroll_Renamed.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.EndScroll
				hScroll_Change(eventArgs.newValue)
		End Select
	End Sub
	Private Sub vScroll_Renamed_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles vScroll_Renamed.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.EndScroll
				vScroll_Change(eventArgs.newValue)
		End Select
	End Sub
	Private Sub vPan_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles vPan.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.EndScroll
				vPan_Change(eventArgs.newValue)
		End Select
	End Sub
	Private Sub hPan_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles hPan.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.EndScroll
				hPan_Change(eventArgs.newValue)
		End Select
	End Sub
End Class