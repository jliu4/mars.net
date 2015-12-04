Option Strict Off
Option Explicit On
Friend Class PltSeabed
	
	Public WaterDepth As Double
	
	Public seaGrapher As threeDGrapher
	Private Grid As threeDLine
	
	Private X As Double '...the min. x coords data (GPS data)
	Private Y As Double '...the min. y coords data (GPS data)
	Private z(MaxNumGrids - 1, MaxNumGrids - 1) As Double '...the seabed z(x grid points, y grid points) coords data
	Private xlength As Double '...x direct total length
	Private ylength As Double '...y direct total length
	Private xgridpt As Short '...x direct total grid points
	Private ygridpt As Short '...y direct total grid points
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		
		Grid = New threeDLine
		Grid.setColor(&H40C0) 'RGB(0, 60, 60)
		seaGrapher = New threeDGrapher
		
		ReadFile()
		
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	Public Sub ReadFile()
		
		Dim i, j As Short
		'UPGRADE_NOTE: FileOpen was upgraded to FileOpen_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim FileOpen_Renamed As Boolean
		
		On Error GoTo ExitErr '...if not find data file then don't draw pipelines
		FileOpen_Renamed = False
		
		FileOpen(FileNumRes, MarsDir & SeaBedFile, OpenMode.Input) ' Open file for input.
		FileOpen_Renamed = True
		
		Input(FileNumRes, xlength)
		Input(FileNumRes, ylength)
		Input(FileNumRes, xgridpt)
		Input(FileNumRes, ygridpt)
		Input(FileNumRes, X)
		Input(FileNumRes, Y) ' Read data into two variables.
		
		If xgridpt > MaxNumGrids Then xgridpt = MaxNumGrids
		If ygridpt > MaxNumGrids Then ygridpt = MaxNumGrids
		
		For i = 0 To xgridpt - 1
			For j = 0 To ygridpt - 1
				Input(FileNumRes, z(i, j)) '...read z data
			Next j
		Next i
		FileClose(FileNumRes) ' Close file.
		FileOpen_Renamed = False
		
		Exit Sub
		
ExitErr: 
		If FileOpen_Renamed Then FileClose(FileNumRes)
		
		For i = 0 To xgridpt - 1
			For j = 0 To ygridpt - 1
				If z(i, j) >= 0# Then z(i, j) = -WaterDepth
			Next j
		Next i
		Exit Sub
		
	End Sub
	
	Public Sub drawSeabed(ByRef ShipGlob As ShipGlobal, ByVal ShipDraft As Double)
		
		Dim i, j As Short
		Dim X0 As Double '...the min. x coords data (reference ship location data)
		Dim Y0 As Double '...the min. y coords data (reference ship location data)
		Dim x1 As Double '...the start point x coords data (reference ship location data)
		Dim y1 As Double '...the start point y coords data (reference ship location data)
		Dim x2 As Double '...the end point x coords data (reference ship location data)
		Dim y2 As Double '...the end point x coords data (reference ship location data)
		Dim dx As Double '...x direct spacing
		Dim dy As Double '...y direct spacing
		
		'   ...defined dx,dy,x1,y1,x2,y2
		dx = xlength / (xgridpt - 1)
		dy = ylength / (ygridpt - 1)
		With ShipGlob
			X0 = X - .Xg '...reference to ship sys. coords
			Y0 = Y - .Yg
		End With
		
		'   ...draw y direction grid
		x1 = X0
		For i = 0 To xgridpt - 1
			y1 = Y0
			For j = 1 To ygridpt - 1
				y2 = y1 + dy
				If z(i, j - 1) < 0# And z(i, j) < 0# Then
					Grid.setCoords(x1, y1, z(i, j - 1) + ShipDraft, x1, y2, z(i, j) + ShipDraft)
					seaGrapher.drawTheLine(Grid)
				End If
				y1 = y2
			Next j
			x1 = x1 + dx
		Next i
		
		'   ...draw x direction grid
		y1 = Y0
		For j = 0 To ygridpt - 1
			x1 = X0
			For i = 1 To xgridpt - 1
				x2 = x1 + dx
				If z(i - 1, j) < 0# And z(i, j) < 0# Then
					Grid.setCoords(x1, y1, z(i - 1, j) + ShipDraft, x2, y1, z(i, j) + ShipDraft)
					seaGrapher.drawTheLine(Grid)
				End If
				x1 = x2
			Next i
			y1 = y1 + dy
		Next j
		
	End Sub
	
	Public Sub angleChange(ByVal hChange As Short, ByRef vChange As Short)
		
		seaGrapher.newAngles(hChange, vChange)
		
	End Sub
	
	Public Sub setGraph(ByRef aGrapher As System.Windows.Forms.PictureBox, ByRef X As Double, ByRef Y As Double, ByRef Incremental As Boolean)
		
		seaGrapher.setDrawSurface(aGrapher, X, Y, Incremental)
		
	End Sub
	
	Public Function ZoomGraph(ByVal aChange As Double, ByRef ShipGlob As ShipGlobal, ByVal ShipDraft As Double) As Object
		
		Dim zoomVar As Boolean
		
		zoomVar = seaGrapher.changeScale(aChange)
		If zoomVar = True Then
			drawSeabed(ShipGlob, ShipDraft)
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ZoomGraph. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ZoomGraph = zoomVar
		
	End Function
End Class