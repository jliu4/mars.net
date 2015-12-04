Option Strict Off
Option Explicit On
Friend Class threeDGrapher
	' this class is responsible for maintaining a
	' 3d graph.  It needs to keep track of the current
	' viewing angles.  An object calls the draw object
	' method to draw a particular object.  Note that
	' the object (i.e. a line) to be drawn should give
	' this method the object as viewed at 0 degrees vert.
	' and 0 degrees horizontal.  Use the line class.
	
	Private refX As Integer ' tells us the reference point from
	Private refY As Integer ' which everything is drawn
	Private theGraph As System.Windows.Forms.PictureBox
	Private vertAngle As Short
	Private horAngle As Short
	Private myScale As Double
	Private mvarPyramid As PltPyramid
	
	
	
	
	Public Property Pyramid() As PltPyramid
		Get
			If mvarPyramid Is Nothing Then
				mvarPyramid = New PltPyramid
			End If
			
			
			Pyramid = mvarPyramid
		End Get
		Set(ByVal Value As PltPyramid)
			mvarPyramid = Value
		End Set
	End Property
	'UPGRADE_NOTE: Class_Terminate was upgraded to Class_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Terminate_Renamed()
		'UPGRADE_NOTE: Object mvarPyramid may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		mvarPyramid = Nothing
	End Sub
	Protected Overrides Sub Finalize()
		Class_Terminate_Renamed()
		MyBase.Finalize()
	End Sub
	
	
	
	
	' this method simply tells this class what surface to
	' draw on
	Public Sub setDrawSurface(ByRef surface As System.Windows.Forms.PictureBox, ByRef X As Double, ByRef Y As Double, ByRef Incremental As Boolean)
		theGraph = surface
		'Dim x As Double
		'Dim y As Double
		If X = 0# And Y = 0# Then
			X = VB6.PixelsToTwipsX(theGraph.Width)
			Y = VB6.PixelsToTwipsY(theGraph.Height)
			X = X / 2
			Y = Y / 2
			refX = X
			refY = Y / 2
		ElseIf Not Incremental Then 
			refX = X
			refY = Y
		Else
			refX = refX + X
			refY = refY + Y
		End If
		
	End Sub
	
	' This method draws a line.  It needs to take into
	' acct the viewing angles and all that good stuff
	
	Public Sub drawTheLine(ByVal aline As threeDLine, Optional ByRef scaleIt As Boolean = False)
		
		' need to draw a line given the current view
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(scaleIt) Then
			scaleIt = True
		End If
		
		Dim xt1 As Double
		Dim xt2 As Double
		Dim yt1 As Double
		Dim yt2 As Double
		Dim zt1 As Double
		Dim zt2 As Double
		Dim x1 As Double
		Dim x2 As Double
		Dim y1 As Double
		Dim y2 As Double
		Dim aColor As Integer
		Dim lineLength As Double
		aline.getCoords(xt1, yt1, zt1, xt2, yt2, zt2)
		
		aColor = aline.getColor
		
		'' test added
		'yt1 = -yt1
		'yt2 = -yt2
		' end test added
		' calculate along the "3d x axis first"
		Dim vRads As Double
		Dim hRads As Double
		vRads = vertAngle * 3.1415927 / 180
		hRads = horAngle * 3.1415927 / 180
		
		' we solve for the 3d x coordinates of the start
		' and finish point for the line.
		
		x1 = xt1 * System.Math.Cos(hRads)
		y1 = xt1 * System.Math.Sin(vRads) * System.Math.Sin(hRads) ' - Cos(hRads)
		x2 = xt2 * System.Math.Cos(hRads)
		y2 = xt2 * System.Math.Sin(vRads) * System.Math.Sin(hRads) ' - Cos(hRads)
		
		' we have translated the x coords of the 3d graph
		' onto the 2d graph.  Now we need to account for
		' the y coord.  This will add on to X1 and X2
		
		' x0 and y0 are just intermediate numbers, they will
		' need to be added to X1, Y1, X2, and Y2.  Just for
		' cleanliness
		Dim X0 As Double
		Dim Y0 As Double
		X0 = yt1 * System.Math.Sin(hRads)
		x1 = X0 + x1
		X0 = yt2 * System.Math.Sin(hRads)
		x2 = X0 + x2
		Y0 = yt1 * System.Math.Sin(vRads) * System.Math.Cos(hRads)
		y1 = y1 - Y0
		Y0 = yt2 * System.Math.Sin(vRads) * System.Math.Cos(hRads)
		y2 = y2 - Y0
		
		' we now need to account for the z axis.  This is
		' pretty simply as the z axis will never be tilted
		' at an angle.  It will always be straight up and
		' down.  Of course, you can view it from above and
		' at various angles.  So only affected coordinate
		' will be the y coordinate
		
		Y0 = zt1 * System.Math.Cos(vRads)
		y1 = y1 - Y0
		Y0 = zt2 * System.Math.Cos(vRads)
		y2 = y2 - Y0
		' scales the lines and actually draws the calculated
		' line to the graph
		Dim theScale As Double
		'If scaleIt = True Then
		'    theScale = myScale
		'Else
		'    theScale = 1
		'endif
		x1 = myScale * x1 + refX
		y1 = myScale * y1 + refY
		x2 = myScale * x2 + refX
		y2 = myScale * y2 + refY
        'UPGRADE_ISSUE: PictureBox method theGraph.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'theGraph.Line (x1, y1) - (x2, y2), aColor

    End Sub
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		vertAngle = 0
		horAngle = 0
		myScale = 3
		refX = 0
		refY = 0
		
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	Public Sub newAngles(ByVal H As Short, ByVal V As Short)
		horAngle = H
		vertAngle = V
	End Sub
	
	Public Sub clearGraph()
		'UPGRADE_ISSUE: PictureBox method theGraph.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		theGraph.Cls()
	End Sub
	
	Public Function changeScale(ByVal changeInScale As Double) As Boolean
		Dim newScale As Double
		newScale = myScale * changeInScale
		If (newScale <= 0) Or (newScale > 250) Then
			changeScale = False
		Else
			myScale = newScale
			changeScale = True
		End If
		
	End Function
	
	Public Sub drawRect(ByVal aRect As threeDRect, Optional ByRef Filler As Boolean = False)
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(Filler) Then
			Filler = False
		End If
		
		drawTheLine(aRect.Length1)
		drawTheLine(aRect.Length2)
		drawTheLine(aRect.Width1)
		drawTheLine(aRect.Width2)
		If Filler = True Then
			fillRect(aRect)
		End If
		
	End Sub
	
	Public Sub drawBox(ByVal aBox As PltBox3d)
		drawRect(aBox.Bottom)
		drawRect(aBox.side1)
		drawRect(aBox.side2)
		drawRect(aBox.Top)
		drawTheLine(aBox.Line1)
		drawTheLine(aBox.Line2)
		drawTheLine(aBox.Line4)
		drawTheLine(aBox.Line3)
	End Sub
	
	Public Sub drawOctagon(ByRef anOct As PltOctagon3d, Optional ByRef fillMe As Boolean = False)
		Dim counter As Short
		Dim Line1 As threeDLine
		Dim Line2 As threeDLine
		Dim Line3 As threeDLine
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(fillMe) Then
			fillMe = False
		End If
		Dim oct2 As PltOctagon3d
		Dim L As Double
		If fillMe = True Then
			oct2 = New PltOctagon3d
			L = anOct.theLength
			L = L - 10
			Do While L > 0
				oct2.createOctagon(L, (anOct.theHeight), (anOct.X), (anOct.Y), (anOct.z))
				counter = 1
				Do While counter <= 8
					oct2.getLines(Line1, Line2, Line3, counter)
					Line1.setColor(System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White))
					Line2.setColor(System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White))
					Line3.setColor(System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White))
					drawTheLine(Line1)
					drawTheLine(Line2)
					drawTheLine(Line3)
					counter = counter + 1
				Loop 
				L = L - 10
			Loop 
		End If
		counter = 1
		Do While counter <= 8
			anOct.getLines(Line1, Line2, Line3, counter)
			drawTheLine(Line1)
			drawTheLine(Line2)
			drawTheLine(Line3)
			counter = counter + 1
		Loop 
		
	End Sub
	Public Function zoomPercent() As Double
		
		zoomPercent = myScale / 2 * 100
	End Function
	
	' this method puts the dimensions of the graph it is
	' drawing on into the arguments it is passed
	
	Public Sub getPictureDim(ByRef width As Short, ByRef Length As Short)
		Dim Height As Object
		width = VB6.PixelsToTwipsX(theGraph.Width)
		'UPGRADE_WARNING: Couldn't resolve default property of object Height. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Height = VB6.PixelsToTwipsY(theGraph.Height)
	End Sub
	
	Public Sub fillgraph()
		Dim X As Short
		X = 0
		Do While X < VB6.PixelsToTwipsX(theGraph.Width)
            'UPGRADE_ISSUE: PictureBox method theGraph.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'theGraph.Line (X, 0) - (X, VB6.PixelsToTwipsY(theGraph.Height))
            X = X + 1
			'    Debug.Print X
		Loop 
		
	End Sub
	
	Private Sub fillRect(ByRef aRect As threeDRect)
		Dim X0 As Double
		Dim Y0 As Double
		Dim z0 As Double
		Dim x1 As Double
		Dim y1 As Double
		Dim z1 As Double
		Dim x2 As Double
		Dim y2 As Double
		Dim z2 As Double
		Dim x3 As Double
		Dim y3 As Double
		Dim z3 As Double
		
		aRect.Width1.getCoords(X0, Y0, z0, x1, y1, z1)
		aRect.Width2.getCoords(x2, y2, z2, x3, y3, z3)
		Dim newLine As threeDLine
		newLine = New threeDLine
		
		'x0 = x0 * myScale
		'y0 = y0 * myScale
		'z0 = z0 * myScale
		'x1 = x1 * myScale
		'y1 = y1 * myScale
		'z1 = z1 * myScale
		'x2 = x2 * myScale
		'y2 = y2 * myScale
		'z2 = z2 * myScale
		'x3 = x3 * myScale
		'y3 = y3 * myScale
		'z3 = z3 * myScale
		
		newLine.setColor(System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White))
		Do While X0 < x2
			X0 = X0 + 5
			x1 = x1 + 5
			newLine.setCoords(X0, Y0, z0, x1, y1, z1)
			drawTheLine(newLine) ', False
		Loop 
		
	End Sub
	
	Private Sub fillOctagon(ByRef anOct As PltOctagon3d)
		Dim Line1 As threeDLine
		Dim Line2 As threeDLine
		Dim Line3 As threeDLine
		anOct.getLines(Line1, Line2, Line2, 1)
		anOct.getLines(Line2, Line3, Line3, 2)
		
		Dim X0 As Double
		Dim Y0 As Double
		Dim z0 As Double
		Dim x1 As Double
		Dim y1 As Double
		Dim z1 As Double
		
		Dim x2 As Double
		Dim y2 As Double
		Dim z2 As Double
		
		Dim x3 As Double
		Dim y3 As Double
		Dim z3 As Double
		
		Dim slope As Double
		Dim deltaY As Double
		Dim deltaX As Double
		Dim newX As Double
		Dim newY0 As Double
		Dim newY1 As Double
		
		deltaX = 1
		
		anOct.getLines(Line3, Line1, Line3, 1)
		anOct.getLines(Line3, Line2, Line3, 2)
		
		Line1.getCoords(X0, Y0, z0, x1, y1, z1)
		Line2.getCoords(x2, y2, z2, x3, y3, z3)
		
		slope = System.Math.Abs((y3 - y2) / (x3 - x2))
		
		deltaY = slope * deltaX
		newX = X0 + deltaX
		
		newY0 = Y0 - deltaY
		newY1 = y1 + deltaY
		
		Do While newX < x3
			Line1.setCoords(newX, newY0, z0, newX, newY1, z1)
			Line1.setColor(System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White))
			drawTheLine(Line1)
			
			newX = newX + deltaX
			newY0 = newY0 - deltaY
			newY1 = newY1 + deltaY
			
		Loop 
		
		
		
		
	End Sub
End Class