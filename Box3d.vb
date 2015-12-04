Option Strict Off
Option Explicit On
Friend Class PltBox3d
	
	' this class creates a three dimensional box out of
	' four rectangles
	
	Public Top As threeDRect
	Public Bottom As threeDRect
	Public side1 As threeDRect
	Public side2 As threeDRect
	Public Line1 As threeDLine
	Public Line2 As threeDLine
	Public Line3 As threeDLine
	Public Line4 As threeDLine
	
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		Top = New threeDRect
		Bottom = New threeDRect
		side1 = New threeDRect
		side2 = New threeDRect
		Line1 = New threeDLine
		Line2 = New threeDLine
		Line3 = New threeDLine
		Line4 = New threeDLine
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	' this method accepts data to create a box.  Length is
	' considered parallel to the x axis and perpendicular to
	' the y axis.  Width is parallel to the y axis and
	' perpendicular to the x axis.  Height is perpendicular
	' to the xy plane
	
	Public Sub createBox(ByRef Length As Single, ByRef width As Single, ByRef Height As Single, ByRef xCenter As Single, ByRef ycenter As Single, ByRef zCenter As Single, Optional ByRef rcol As Integer = 0)
		
		Dim X As Single
		Dim Y As Single
		Dim z As Single
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(rcol) Then
			rcol = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
		End If
		
		
		
		' create the top portion of the box
		X = xCenter
		Y = ycenter
		z = zCenter + Height / 2
		
		Top.createHorizontalRect(Length, width, X, Y, z, rcol)
		
		' create the bottom portion of the box
		X = xCenter
		Y = ycenter
		z = zCenter - Height / 2
		
		Bottom.createHorizontalRect(Length, width, X, Y, z, rcol)
		
		' create side1
		X = xCenter + Length / 2
		Y = ycenter
		z = zCenter
		
		side1.createVerticalRect(width, Height, X, Y, z, 90, rcol)
		
		' create side2
		X = xCenter - Length / 2
		Y = ycenter
		z = zCenter
		
		side2.createVerticalRect(width, Height, X, Y, z, 90, rcol)
		
		
	End Sub
	
	' this method creates a pyramidal box.  If you specify
	' zero for lTop and wTop, a square pyramid will be created
	
	Public Sub PyramidBox(ByRef lBottom As Single, ByRef wBottom As Single, ByRef lTop As Single, ByRef wTop As Single, ByRef theHeight As Single, ByRef xCenter As Object, ByRef ycenter As Object, ByRef zCenter As Object)
		
		Dim x1 As Single
		Dim y1 As Single
		Dim z1 As Single
		Dim x2 As Single
		Dim y2 As Single
		Dim z2 As Single
		
		' create the bottom box
		'UPGRADE_WARNING: Couldn't resolve default property of object xCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x1 = xCenter
		'UPGRADE_WARNING: Couldn't resolve default property of object ycenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		y1 = ycenter
		'UPGRADE_WARNING: Couldn't resolve default property of object zCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		z1 = zCenter - theHeight / 2
		
		Bottom.createHorizontalRect(lBottom, wBottom, x1, y1, z1, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black))
		
		' create the top box
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x1 = xCenter
		'UPGRADE_WARNING: Couldn't resolve default property of object ycenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		y1 = ycenter
		'UPGRADE_WARNING: Couldn't resolve default property of object zCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		z1 = zCenter + theHeight / 2
		
		Top.createHorizontalRect(lTop, wTop, x1, y1, z1, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black))
		
		' we now need to calculate the connecting lines reggin
		
		' line1
		'UPGRADE_WARNING: Couldn't resolve default property of object xCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x1 = xCenter - lBottom / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object ycenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		y1 = ycenter - wBottom / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object zCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		z1 = zCenter - theHeight / 2
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x2 = xCenter - lTop / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object ycenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		y2 = ycenter - wTop / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object zCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		z2 = zCenter + theHeight / 2
		
		Line1.setCoords(x1, y1, z1, x2, y2, z2)
		
		'line 2
		'UPGRADE_WARNING: Couldn't resolve default property of object xCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x1 = xCenter + lBottom / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object ycenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		y1 = ycenter - wBottom / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object zCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		z1 = zCenter - theHeight / 2
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x2 = xCenter + lTop / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object ycenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		y2 = ycenter - wTop / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object zCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		z2 = zCenter + theHeight / 2
		
		Line2.setCoords(x1, y1, z1, x2, y2, z2)
		
		'line 3
		'UPGRADE_WARNING: Couldn't resolve default property of object xCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x1 = xCenter + lBottom / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object ycenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		y1 = ycenter + wBottom / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object zCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		z1 = zCenter - theHeight / 2
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x2 = xCenter + lTop / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object ycenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		y2 = ycenter + lTop / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object zCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		z2 = zCenter + theHeight / 2
		
		Line3.setCoords(x1, y1, z1, x2, y2, z2)
		
		' line 4
		'UPGRADE_WARNING: Couldn't resolve default property of object xCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x1 = xCenter - lBottom / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object ycenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		y1 = ycenter + wBottom / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object zCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		z1 = zCenter - theHeight / 2
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x2 = xCenter - lTop / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object ycenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		y2 = ycenter + lTop / 2
		'UPGRADE_WARNING: Couldn't resolve default property of object zCenter. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		z2 = zCenter + theHeight / 2
		
		Line4.setCoords(x1, y1, z1, x2, y2, z2)
		
	End Sub
End Class