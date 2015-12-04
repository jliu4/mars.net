Option Strict Off
Option Explicit On
Friend Class Riser
	
	' ...Modify by neil
	' this class creats Riser line from Rig to well.
	
	'Private i As Integer
	'Private j As Integer
	
	Public RiserGrapher As threeDGrapher
	
	Private theRiser As threeDLine
	
	
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		
		theRiser = New threeDLine
		theRiser.setColor(System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red))
		
		RiserGrapher = New threeDGrapher
		
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	Public Sub drawRiser(ByRef WellSite As Well, ByRef ShipGlob As ShipGlobal, ByVal ShipDraft As Double)
		
		Dim x1 As Double
		Dim y1 As Double
		Dim z1 As Double
		Dim x2 As Double
		Dim y2 As Double
		Dim z2 As Double
		
		x1 = 0 '...ship water center x coords sys.
		y1 = 0 '...ship water center y coords sys.
		z1 = DeckElev
		
		With WellSite
			x2 = .Xg - ShipGlob.Xg '...referencr to ship sys. coords
			y2 = .Yg - ShipGlob.Yg '...referencr to ship sys. coords
			z2 = ShipDraft - .Depth
		End With
		
		theRiser.setCoords(x1, y1, z1, x2, y2, z2)
		RiserGrapher.drawTheLine(theRiser)
		
	End Sub
	
	Public Sub angleChange(ByVal hChange As Short, ByRef vChange As Short)
		RiserGrapher.newAngles(hChange, vChange)
	End Sub
	
	Public Sub setGraph(ByRef aGrapher As System.Windows.Forms.PictureBox, ByRef X As Double, ByRef Y As Double, ByRef Incremental As Boolean)
		RiserGrapher.setDrawSurface(aGrapher, X, Y, Incremental)
	End Sub
	
	Public Function ZoomGraph(ByVal aChange As Double, ByRef WellSite As Well, ByRef ShipGlob As ShipGlobal, ByVal ShipDraft As Double) As Object
		
		Dim zoomVar As Boolean
		
		zoomVar = RiserGrapher.changeScale(aChange)
		If zoomVar = True Then
			drawRiser(WellSite, ShipGlob, ShipDraft)
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ZoomGraph. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ZoomGraph = zoomVar
		
	End Function
End Class