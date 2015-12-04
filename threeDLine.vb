Option Strict Off
Option Explicit On
Friend Class threeDLine
	Private x1 As Single
	Private x2 As Single
	Private y1 As Single
	Private y2 As Single
	Private z1 As Single
	Private z2 As Single
	Private lColor As Integer
	
	Public Sub setCoords(ByRef xc1 As Single, ByRef yc1 As Single, ByRef zc1 As Single, ByRef xc2 As Single, ByRef yc2 As Single, ByRef zc2 As Single)
		x1 = xc1
		x2 = xc2
		y1 = yc1
		y2 = yc2
		z1 = zc1
		z2 = zc2
	End Sub
	
	Public Sub setColor(ByRef Col As Integer)
		lColor = Col
	End Sub
	
	Public Function getColor() As Integer
		getColor = lColor
	End Function
	
	Public Sub getCoords(ByRef xc1 As Single, ByRef yc1 As Single, ByRef zc1 As Single, ByRef xc2 As Single, ByRef yc2 As Single, ByRef zc2 As Single)
		xc1 = x1
		xc2 = x2
		yc1 = y1
		yc2 = y2
		zc1 = z1
		zc2 = z2
	End Sub
	
	
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		lColor = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
End Class