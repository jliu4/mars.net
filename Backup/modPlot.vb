Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Module modPlot
	'Option Explicit
	
	Private Const NumVesselPoints As Short = 16
	Private Const NumArrowPoints As Short = 8
	Private Const NumNorthLetterPoints As Short = 4
	Private Const NumNorthArrowPoints As Short = 7
	
	Private Const MarginPercent As Double = 0.2
	Private Const TimerInterval As Double = 0.25
	Private Const Fuzz As Double = 0.1
	
	'UPGRADE_WARNING: Lower bound of array VesselDiagram was changed from 1,1 to 0,0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
	Private VesselDiagram(NumVesselPoints, 2) As Double
	'UPGRADE_WARNING: Lower bound of array CompassArrow was changed from 1,1 to 0,0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
	Private CompassArrow(NumArrowPoints, 2) As Double
	'UPGRADE_WARNING: Lower bound of array NorthArrow was changed from 1,1 to 0,0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
	Private NorthArrow(NumNorthArrowPoints, 2) As Double
	'UPGRADE_WARNING: Lower bound of array NorthLetter was changed from 1,1 to 0,0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
	Private NorthLetter(NumNorthLetterPoints, 2) As Double
	
	' data preparation
	
	Public Sub MaxAndMin(ByRef X As Object, ByRef Xmax As Object, ByRef Xmin As Object, ByRef NumPoints As Short, Optional ByRef ReverseY As Boolean = True, Optional ByRef ShowZero As Boolean = True)
		
		Dim LastPoint, Base As Short
		Dim i As Short
		
		'   Determine maxima and minima
		'UPGRADE_WARNING: Couldn't resolve default property of object Xmax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Xmax = -3.402823E+38
		'UPGRADE_WARNING: Couldn't resolve default property of object Xmin. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Xmin = 3.402823E+38
		
		'   If there's only one point, bracket around it a bit to make a plot have some width
		If NumPoints = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object X(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Xmax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Xmax = X(1) * (1 + Fuzz)
			'UPGRADE_WARNING: Couldn't resolve default property of object X(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Xmin. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Xmin = X(1) * (1 - Fuzz)
			
			If ShowZero Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Xmax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Xmax < 0# Then Xmax = 0#
				'UPGRADE_WARNING: Couldn't resolve default property of object Xmin. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Xmin > 0# Then Xmin = 0#
			End If
			
		Else
			'       If there are several points in the arrays (usual case)
			For i = 1 To NumPoints
				'UPGRADE_WARNING: Couldn't resolve default property of object Xmax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object X(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object X(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Xmax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If X(i) > Xmax Then Xmax = X(i)
				'UPGRADE_WARNING: Couldn't resolve default property of object Xmin. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object X(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object X(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Xmin. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If X(i) < Xmin Then Xmin = X(i)
			Next i
			
			'       If the minimum and maximum are the same, bracket as in the one-point case
			'UPGRADE_WARNING: Couldn't resolve default property of object Xmin. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Xmax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Xmax = Xmin Then
				If Xmax = 0# Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Xmax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Xmax = 1#
					'UPGRADE_WARNING: Couldn't resolve default property of object Xmin. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Xmin = -1#
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object Xmax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Xmax = Xmax * (1 + Fuzz)
					'UPGRADE_WARNING: Couldn't resolve default property of object Xmin. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Xmin = Xmin * (1 - Fuzz)
				End If
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object Xmin. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Xmax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If (Xmax - Xmin) < 1# Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Xmax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Xmax = CInt(Xmax + 1#)
				'UPGRADE_WARNING: Couldn't resolve default property of object Xmax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Xmin. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Xmin = Xmax - 2#
			End If
			
			For i = 1 To NumPoints
				If ReverseY Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Xmin. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object X(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Xmax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					X(i) = Xmax - X(i) + Xmin
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object Xmin. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object X(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					X(i) = X(i) - Xmin
				End If
			Next i
			
		End If
		
	End Sub
	
	' function called by FormatPlot to space out grid lines
	' and set max and min on axes
	Public Function Divisions(ByVal Min As Double, ByVal Max As Double) As Short
		
		Dim Factor As Double
		Dim Inc As Double
		Dim Divisor As Double
		Dim Multiplier As Double
		
		Dim num As Integer
		If Max = Min Then
			Inc = 1#
			If Not (Max = 0#) Then
				Divisor = 2#
				Do While Max / Inc <= 1#
					Inc = Inc / Divisor
					If Divisor = 5# Then
						Divisor = 2#
					Else
						Divisor = 5#
					End If
				Loop 
			End If
			Max = Max + Inc
			Min = Min - Inc
			Divisions = 2#
		Else
			Inc = Max - Min
			Factor = 1#
			Divisor = 2#
			Do While Inc > 10#
				Inc = Inc / Divisor
				Factor = Factor * Divisor
				If Divisor = 5# Then
					Divisor = 2#
				Else
					Divisor = 5#
				End If
			Loop 
			Multiplier = 2#
			Do While Inc <= 2#
				Inc = Inc * Multiplier
				Factor = Factor / Multiplier
				If Multiplier = 5# Then
					Multiplier = 2#
				Else
					Multiplier = 5#
				End If
			Loop 
			num = CInt(Min / Factor)
			If num * Factor > Min Then
				num = num - 1
			End If
			Min = num * Factor
			num = CInt(Max / Factor)
			If num * Factor < Max Then
				num = num + 1
			End If
			Max = num * Factor
			Divisions = (Max - Min) / Factor
		End If
		
	End Function
	
	' basic plots
	' axis
	Public Sub drawAxis(ByVal Xmax As Double, ByVal Xmin As Double, ByVal Ymax As Double, ByVal Ymin As Double, ByVal XLabel As String, ByVal YLabel As String, ByRef picGraph As System.Windows.Forms.PictureBox, Optional ByRef ReverseY As Boolean = True)
		Dim deltaX, deltaY As Double
		Dim LabelX, LabelY As Double
		Dim NumTix As Short
		Dim TicInt, TicLoc As Double
		Dim TicLab As String
		Dim TicW, TicY As Double
		Dim i As Short
		' Coordinate system is reversed:  Bottom-Left-Hand corner is (0,0);
		' Positive X is to the right, Positive Y is up
		'
		' Initialize (in case this is a replot)
		'UPGRADE_ISSUE: PictureBox method picGraph.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.Cls()
		'UPGRADE_ISSUE: PictureBox property picGraph.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.AutoRedraw = True
		' Set the font
		picGraph.Font = VB6.FontChangeName(picGraph.Font, "Arial")
		picGraph.Font = VB6.FontChangeBold(picGraph.Font, True)
		' Set the line weight
		'UPGRADE_ISSUE: PictureBox property picGraph.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.DrawWidth = 2
		' Establish the scale
		deltaX = Xmax - Xmin
		If deltaX < 0.01 Then deltaX = 0.01
		deltaY = Ymax - Ymin
		If deltaY < 0.01 Then deltaY = 0.01
		'UPGRADE_ISSUE: PictureBox property picGraph.ScaleWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.ScaleWidth = deltaX * (1 + 2 * MarginPercent)
		'UPGRADE_ISSUE: PictureBox property picGraph.ScaleHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.ScaleHeight = deltaY * (1 + 2 * MarginPercent)
		' Establish the origin
		'UPGRADE_ISSUE: PictureBox property picGraph.ScaleLeft was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.ScaleLeft = -MarginPercent * deltaX + Xmin
		'UPGRADE_ISSUE: PictureBox property picGraph.ScaleTop was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.ScaleTop = -MarginPercent * deltaY + Ymin
		' Draw the axes
		'UPGRADE_ISSUE: PictureBox method picGraph.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.Line (Xmin, Ymax) - (Xmax, Ymax)
		'UPGRADE_ISSUE: PictureBox method picGraph.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.Line (Xmin, Ymin) - (Xmin, Ymax)
		' Label them; X-label goes below the axis
		LabelX = Xmin + deltaX / 2
		LabelY = Ymax
		'UPGRADE_ISSUE: PictureBox method picGraph.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picGraph.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.CurrentX = LabelX - picGraph.TextWidth(XLabel) / 2
		'UPGRADE_ISSUE: PictureBox method picGraph.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picGraph.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.CurrentY = LabelY + picGraph.TextHeight(XLabel) * 1.1
		'UPGRADE_ISSUE: PictureBox method picGraph.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.Print(XLabel)
		' Y-label goes at the top of the y-axis
		LabelX = Xmin
		LabelY = Ymin
		'UPGRADE_ISSUE: PictureBox method picGraph.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picGraph.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.CurrentX = LabelX - picGraph.TextWidth(YLabel) / 2
		'UPGRADE_ISSUE: PictureBox method picGraph.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: PictureBox property picGraph.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.CurrentY = LabelY - picGraph.TextHeight(YLabel) * 1.8
		'UPGRADE_ISSUE: PictureBox method picGraph.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.Print(YLabel)
		' Set parameters
		'UPGRADE_ISSUE: PictureBox property picGraph.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.DrawWidth = 1
		picGraph.Font = VB6.FontChangeBold(picGraph.Font, False)
		' Establish tick marks and label them; X-axis first
		'UPGRADE_ISSUE: PictureBox method picGraph.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		TicY = Ymax + picGraph.TextHeight("0.123456789") * 0.1
		NumTix = Divisions(Xmin, Xmax)
		TicInt = deltaX / NumTix
		' Close "the box"
		For i = 0 To NumTix
			TicLoc = i * TicInt + Xmin
			If TicLoc > Xmax Then TicLoc = Xmax
			'UPGRADE_ISSUE: PictureBox method picGraph.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picGraph.Line (TicLoc, Ymin) - (TicLoc, Ymax)
			TicLab = VB6.Format(TicLoc, "#####")
			'UPGRADE_ISSUE: PictureBox method picGraph.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			'UPGRADE_ISSUE: PictureBox property picGraph.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picGraph.CurrentX = TicLoc - picGraph.TextWidth(TicLab) / 2
			'UPGRADE_ISSUE: PictureBox property picGraph.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picGraph.CurrentY = TicY
			'UPGRADE_ISSUE: PictureBox method picGraph.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picGraph.Print(TicLab)
		Next i
		' Y-axis
		'UPGRADE_ISSUE: PictureBox method picGraph.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		TicY = picGraph.TextHeight("0.123456789") / 2
		NumTix = Divisions(Ymin, Ymax)
		TicInt = deltaY / NumTix
		For i = 0 To NumTix
			'        TicLoc = (NumTix - i) * TicInt + Ymin
			TicLoc = i * TicInt + Ymin
			If TicLoc > Ymax Then TicLoc = Ymax
			'UPGRADE_ISSUE: PictureBox method picGraph.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picGraph.Line (Xmin, TicLoc) - (Xmax, TicLoc)
			If ReverseY Then
				TicLab = VB6.Format(Ymax - TicLoc + Ymin, "####0")
			Else
				TicLab = VB6.Format(TicLoc, "####0")
			End If
			'UPGRADE_ISSUE: PictureBox method picGraph.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			'UPGRADE_ISSUE: PictureBox property picGraph.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picGraph.CurrentX = Xmin - picGraph.TextWidth(TicLab) * 1.1
			'UPGRADE_ISSUE: PictureBox property picGraph.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picGraph.CurrentY = TicLoc - TicY
			'UPGRADE_ISSUE: PictureBox method picGraph.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picGraph.Print(TicLab)
		Next i
		'UPGRADE_ISSUE: PictureBox property picGraph.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picGraph.AutoRedraw = True
		picGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
	End Sub
	
	' line (like mooring lines)
	Public Sub DrawLine(ByRef X() As Double, ByRef Y() As Double, ByRef NumPoints As Short, ByRef LineColor As Integer, ByRef picGraph As System.Windows.Forms.PictureBox)
		
		Dim LastPoint, Base, i As Short
		
		If NumPoints = 1 Then
			'       If there's only one point, plot it
			'UPGRADE_ISSUE: PictureBox method picGraph.PSet was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picGraph.PSet (X(1), Y(1))
		Else
			'       More than one point is a line
			'UPGRADE_ISSUE: PictureBox property picGraph.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picGraph.DrawWidth = 2
			For i = 1 To NumPoints - 1
				'UPGRADE_ISSUE: PictureBox method picGraph.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				picGraph.Line (X(i), Y(i)) - (X(i + 1), Y(i + 1)), LineColor
			Next i
			'UPGRADE_ISSUE: PictureBox property picGraph.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picGraph.DrawWidth = 1
		End If
		
	End Sub
	
	Public Sub ResizePicture(ByRef pic As System.Windows.Forms.PictureBox, ByRef LeftLimit As Double, ByRef RightLimit As Double, ByRef TopLimit As Double, ByRef BottomLimit As Double)
		Dim Margin As Double
		
		'UPGRADE_WARNING: Control property pic.Parent was upgraded to pic.FindForm which has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
		If pic.FindForm.WindowState <> System.Windows.Forms.FormWindowState.Minimized Then
			
			Margin = 400#
			
			With pic
				.Left = VB6.TwipsToPixelsX(LeftLimit + Margin)
				.Width = VB6.TwipsToPixelsX(RightLimit - LeftLimit - Margin)
				.Top = VB6.TwipsToPixelsY(TopLimit + Margin)
				.Height = VB6.TwipsToPixelsY(BottomLimit - TopLimit - Margin)
			End With
			
		End If
		
	End Sub
	
	' make rig nodes
	Public Sub MakeVesselPoints(ByRef ScaleFactor As Double)
		
		Dim i As Short
		
		VesselDiagram(1, mX) = 175.5
		VesselDiagram(2, mX) = 195.2
		VesselDiagram(3, mX) = VesselDiagram(1, mX)
		VesselDiagram(4, mX) = 146#
		VesselDiagram(5, mX) = VesselDiagram(4, mX)
		VesselDiagram(6, mX) = VesselDiagram(1, mX)
		VesselDiagram(7, mX) = VesselDiagram(2, mX)
		VesselDiagram(8, mX) = VesselDiagram(1, mX)
		VesselDiagram(9, mX) = -VesselDiagram(1, mX)
		VesselDiagram(10, mX) = -VesselDiagram(2, mX)
		VesselDiagram(11, mX) = -VesselDiagram(1, mX)
		VesselDiagram(12, mX) = -VesselDiagram(4, mX)
		VesselDiagram(13, mX) = -VesselDiagram(4, mX)
		VesselDiagram(14, mX) = -VesselDiagram(1, mX)
		VesselDiagram(15, mX) = -VesselDiagram(2, mX)
		VesselDiagram(16, mX) = -VesselDiagram(1, mX)
		
		
		VesselDiagram(1, MY_Renamed) = 110#
		VesselDiagram(2, MY_Renamed) = 90.3
		VesselDiagram(3, MY_Renamed) = 70.6
		VesselDiagram(4, MY_Renamed) = VesselDiagram(3, MY_Renamed)
		VesselDiagram(5, MY_Renamed) = -VesselDiagram(3, MY_Renamed)
		VesselDiagram(6, MY_Renamed) = -VesselDiagram(3, MY_Renamed)
		VesselDiagram(7, MY_Renamed) = -VesselDiagram(2, MY_Renamed)
		VesselDiagram(8, MY_Renamed) = -VesselDiagram(1, MY_Renamed)
		VesselDiagram(9, MY_Renamed) = -VesselDiagram(1, MY_Renamed)
		VesselDiagram(10, MY_Renamed) = -VesselDiagram(2, MY_Renamed)
		VesselDiagram(11, MY_Renamed) = -VesselDiagram(3, MY_Renamed)
		VesselDiagram(12, MY_Renamed) = -VesselDiagram(3, MY_Renamed)
		VesselDiagram(13, MY_Renamed) = VesselDiagram(3, MY_Renamed)
		VesselDiagram(14, MY_Renamed) = VesselDiagram(3, MY_Renamed)
		VesselDiagram(15, MY_Renamed) = VesselDiagram(2, MY_Renamed)
		VesselDiagram(16, MY_Renamed) = VesselDiagram(1, MY_Renamed)
		
		If ScaleFactor <> 1# Then
			For i = 1 To NumVesselPoints
				VesselDiagram(i, mX) = ScaleFactor * VesselDiagram(i, mX)
				VesselDiagram(i, MY_Renamed) = ScaleFactor * VesselDiagram(i, MY_Renamed)
			Next i
		End If
		
	End Sub
	
	' generate compass arrow points
	Private Sub MakeCompassArrowPoints(ByRef ScaleFactor As Double)
		
		' input
		'   ScaleFactor -- scale factor of the arrow
		
		Dim i As Short
		
		CompassArrow(1, mX) = -10#
		CompassArrow(2, mX) = -4#
		CompassArrow(3, mX) = 10#
		CompassArrow(4, mX) = 2#
		CompassArrow(5, mX) = 2#
		CompassArrow(6, mX) = 10#
		CompassArrow(7, mX) = -4#
		CompassArrow(8, mX) = -10#
		
		CompassArrow(1, MY_Renamed) = 3#
		CompassArrow(2, MY_Renamed) = 0#
		CompassArrow(3, MY_Renamed) = 0#
		CompassArrow(4, MY_Renamed) = 3#
		CompassArrow(5, MY_Renamed) = -3#
		CompassArrow(6, MY_Renamed) = 0#
		CompassArrow(7, MY_Renamed) = 0#
		CompassArrow(8, MY_Renamed) = -3#
		
		If ScaleFactor <> 1# Then
			For i = 1 To NumArrowPoints
				CompassArrow(i, mX) = ScaleFactor * CompassArrow(i, mX)
				CompassArrow(i, MY_Renamed) = ScaleFactor * CompassArrow(i, MY_Renamed)
			Next i
		End If
		
	End Sub
	
	' generate north pointer points
	Public Sub MakeNorthPoints(ByRef ArrowScaleFactor As Double, ByRef LetterScaleFactor As Double)
		
		Dim i As Short
		
		NorthArrow(1, mX) = -2#
		NorthArrow(2, mX) = 0#
		NorthArrow(3, mX) = 0#
		
		NorthArrow(1, MY_Renamed) = -8#
		NorthArrow(2, MY_Renamed) = -10#
		NorthArrow(3, MY_Renamed) = 10#
		
		If ArrowScaleFactor <> 1# Then
			For i = 1 To NumNorthArrowPoints
				NorthArrow(i, mX) = ArrowScaleFactor * NorthArrow(i, mX)
				NorthArrow(i, MY_Renamed) = ArrowScaleFactor * NorthArrow(i, MY_Renamed)
			Next i
		End If
		
		NorthLetter(1, mX) = -5#
		NorthLetter(2, mX) = -5#
		NorthLetter(3, mX) = 5#
		NorthLetter(4, mX) = 5#
		
		NorthLetter(1, MY_Renamed) = 5#
		NorthLetter(2, MY_Renamed) = -5#
		NorthLetter(3, MY_Renamed) = 5#
		NorthLetter(4, MY_Renamed) = -5#
		
		If LetterScaleFactor <> 1# Then
			For i = 1 To NumNorthLetterPoints
				NorthLetter(i, mX) = LetterScaleFactor * NorthLetter(i, mX)
				NorthLetter(i, MY_Renamed) = LetterScaleFactor * NorthLetter(i, MY_Renamed)
			Next i
		End If
		
	End Sub
	
	' draw the basic vessel shape
	Public Sub DrawVessel(ByRef X0 As Double, ByRef Y0 As Double, ByRef Head0 As Double, ByRef ScaleFactor As Double, ByRef pic As System.Windows.Forms.PictureBox, Optional ByRef LineColor As Short = 0)
		
		Dim i As Short
		
		Call MakeVesselPoints(ScaleFactor)
		Call RotatePoints(VesselDiagram, -Head0)
		
		'UPGRADE_ISSUE: PictureBox property pic.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		pic.AutoRedraw = True
		
		For i = 1 To NumVesselPoints - 1
			'UPGRADE_ISSUE: PictureBox method pic.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			pic.Line (X0 + VesselDiagram(i, mX), Y0 + VesselDiagram(i, MY_Renamed)) - (X0 + VesselDiagram(i + 1, mX), Y0 + VesselDiagram(i + 1, MY_Renamed)), QBColor(LineColor)
		Next i
		
		'UPGRADE_ISSUE: PictureBox method pic.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		pic.Line (X0 + VesselDiagram(NumVesselPoints, mX), Y0 + VesselDiagram(NumVesselPoints, MY_Renamed)) - (X0 + VesselDiagram(1, mX), Y0 + VesselDiagram(1, MY_Renamed)), QBColor(LineColor)
		
	End Sub
	
	' draw compass
	Public Sub DrawCompassArrow(ByRef X0 As Double, ByRef Y0 As Double, ByRef ScaleFactor As Double, ByRef angle As Double, ByRef pic As System.Windows.Forms.PictureBox, ByRef Color As Short)
		Dim i As Object
		
		Dim LineWidth As Short
		
		Call MakeCompassArrowPoints(ScaleFactor)
		Call RotatePoints(CompassArrow, -angle)
		
		'UPGRADE_ISSUE: PictureBox property pic.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		LineWidth = pic.DrawWidth
		'UPGRADE_ISSUE: PictureBox property pic.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		pic.DrawWidth = 1
		
		For i = 1 To NumArrowPoints - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: PictureBox method pic.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			pic.Line (X0 + CompassArrow(i, mX), Y0 + CompassArrow(i, MY_Renamed)) - (X0 + CompassArrow(i + 1, mX), Y0 + CompassArrow(i + 1, MY_Renamed)), QBColor(Color)
		Next i
		
		'UPGRADE_ISSUE: PictureBox property pic.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		pic.DrawWidth = LineWidth
		
	End Sub
	
	' draw north arrow
	Public Sub DrawNorthArrow(ByRef angle As Double, ByRef pic As System.Windows.Forms.PictureBox)
		Dim i As Object
		
		Dim X0, Y0 As Double
		Dim MinBoxDim, MaxNorthDim As Double
		Dim ScaleFactor As Double
		Dim Ymin, Xmin, Xmax, Ymax As Double
		
		MinBoxDim = Min((VB6.PixelsToTwipsY(pic.ClientRectangle.Height)), (VB6.PixelsToTwipsX(pic.ClientRectangle.Width)))
		Call MakeNorthPoints(1#, 1#)
		Call ExtremePoints(NorthArrow, Xmax, Xmin, Ymax, Ymin)
		MaxNorthDim = Max(Xmax, Ymax)
		Call ExtremePoints(NorthLetter, Xmax, Xmin, Ymax, Ymin)
		MaxNorthDim = Max(MaxNorthDim, Max(Xmax, Ymax))
		ScaleFactor = 0.025 * MinBoxDim / MaxNorthDim
		
		X0 = 2# * MaxNorthDim * ScaleFactor
		Y0 = X0
		
		MakeNorthPoints(ScaleFactor, 0.8 * ScaleFactor)
		RotatePoints(NorthArrow, -angle)
		
		'UPGRADE_ISSUE: PictureBox property pic.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		pic.AutoRedraw = True
		'UPGRADE_ISSUE: PictureBox property pic.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		pic.DrawWidth = 2
		
		For i = 1 To NumNorthArrowPoints - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: PictureBox method pic.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			pic.Line (X0 + NorthArrow(i, mX), Y0 + NorthArrow(i, MY_Renamed)) - (X0 + NorthArrow(i + 1, mX), Y0 + NorthArrow(i + 1, MY_Renamed))
		Next i
		
		For i = 1 To NumNorthLetterPoints - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: PictureBox method pic.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			pic.Line (X0 + NorthLetter(i, mX), Y0 + NorthLetter(i, MY_Renamed)) - (X0 + NorthLetter(i + 1, mX), Y0 + NorthLetter(i + 1, MY_Renamed))
		Next i
		
		'UPGRADE_ISSUE: PictureBox property pic.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		pic.DrawWidth = 1
		
	End Sub
	
	' plot environment directions
	Public Sub DrawEnvPlot(ByVal WindDir As Double, ByVal WaveDir As Double, ByVal CurrDir As Double, ByVal VslHead As Double, ByRef picEnviron As System.Windows.Forms.PictureBox)
		
		' Input
		'   WindDir -- wind force direction (local)
		'   WaveDir -- wind force direction (local)
		'   CurrDir -- current force direction (local)
		'   VslHead -- vessel heading (clockwise from North)
		'   picEnviron -- reference to output picture box
		' Output
		'   picEnviron -- output picture
		
		Dim i As Short
		
		Dim Margin, ScaleFactor, ArrowSpacing As Double
		Dim Theight, Twidth, ALWidth As Double
		
		Dim BoxHeight, BoxWidth, BoxSize As Double
		Dim Cx, Px, Py, Cy As Double
		Dim Ymax, Xmax, Xmin, Ymin As Double
		Dim VScale, Vmax, Amax, Ascale As Double
		Dim Rwave, Rcc, Rwind, Rcurrent As Double
		
		BoxWidth = VB6.PixelsToTwipsX(picEnviron.ClientRectangle.Width)
		BoxHeight = VB6.PixelsToTwipsY(picEnviron.ClientRectangle.Height)
		If BoxWidth < BoxHeight Then
			BoxSize = BoxWidth
		Else
			BoxSize = BoxHeight
		End If
		
		With picEnviron
			'UPGRADE_ISSUE: PictureBox property picEnviron.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.AutoRedraw = True
			.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
			'UPGRADE_ISSUE: PictureBox method picEnviron.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.Cls()
		End With
		
		'   Center the graphics in the picture box
		Px = BoxWidth / 2#
		Py = BoxHeight / 2#
		
		'   Adjust the force directions to E-N system
		VslHead = PI / 2 - VslHead
		WindDir = VslHead + WindDir
		WaveDir = VslHead + WaveDir
		CurrDir = VslHead + CurrDir
		
		'   Find the limits of the vessel, for use in sizing the circle that will
		'   encompass it
		Call MakeVesselPoints(1#)
		Call ExtremePoints(VesselDiagram, Xmax, Xmin, Ymax, Ymin)
		
		If Xmax > Ymax Then
			Vmax = Xmax
		Else
			Vmax = Ymax
		End If
		
		VScale = 0.15 * BoxSize / Vmax
		
		'   Draw the vessel itself at the center
		Call DrawVessel(Px, Py, VslHead, VScale, picEnviron)
		
		With picEnviron
			'       Draw the circle around the vessel, leaving some room
			Rcc = VScale * Vmax * 1.2
			Margin = Rcc / 10
			'UPGRADE_ISSUE: PictureBox method picEnviron.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picEnviron.Circle (Px, Py), Rcc
			
			'       Annotate the compass points on the circle
			.Font = VB6.FontChangeBold(.Font, True)
			'UPGRADE_ISSUE: PictureBox method picEnviron.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			'UPGRADE_ISSUE: PictureBox property picEnviron.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentX = Px - .TextWidth("N") / 2#
			'UPGRADE_ISSUE: PictureBox method picEnviron.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			'UPGRADE_ISSUE: PictureBox property picEnviron.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentY = Py - Rcc - .TextHeight("N") - Margin
			'UPGRADE_ISSUE: PictureBox method picEnviron.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picEnviron.Print("N")
			'UPGRADE_ISSUE: PictureBox method picEnviron.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			'UPGRADE_ISSUE: PictureBox property picEnviron.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentX = Px - .TextWidth("S") / 2#
			'UPGRADE_ISSUE: PictureBox property picEnviron.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentY = Py + Rcc + Margin
			'UPGRADE_ISSUE: PictureBox method picEnviron.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picEnviron.Print("S")
			'UPGRADE_ISSUE: PictureBox method picEnviron.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			'UPGRADE_ISSUE: PictureBox property picEnviron.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentX = Px - Rcc - .TextHeight("W") - Margin
			'UPGRADE_ISSUE: PictureBox method picEnviron.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			'UPGRADE_ISSUE: PictureBox property picEnviron.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentY = Py - .TextHeight("W") / 2#
			'UPGRADE_ISSUE: PictureBox method picEnviron.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picEnviron.Print("W")
			'UPGRADE_ISSUE: PictureBox property picEnviron.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentX = Px + Rcc + Margin
			'UPGRADE_ISSUE: PictureBox method picEnviron.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			'UPGRADE_ISSUE: PictureBox property picEnviron.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentY = Py - .TextHeight("E") / 2#
			'UPGRADE_ISSUE: PictureBox method picEnviron.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picEnviron.Print("E")
		End With
		
		'   Find the maximum dimension of the arrow
		Call MakeCompassArrowPoints(1#)
		Call ExtremePoints(CompassArrow, Xmax, Xmin, Ymax, Ymin)
		
		If Xmax > Ymax Then
			Amax = Xmax
		Else
			Amax = Ymax
		End If
		
		Ascale = 0.2 * VScale * Vmax / Amax
		ArrowSpacing = Amax * Ascale / 1#
		
		'   Compute the radii for the three arrows representing wind, wave and current
		'UPGRADE_ISSUE: PictureBox method picEnviron.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Rwind = Rcc + ArrowSpacing + picEnviron.TextHeight("N") + Margin
		Rwave = Rwind + ArrowSpacing
		Rcurrent = Rwave + ArrowSpacing
		
		'   For each arrow, compute the position of its center, then draw it
		Cx = Px + Rwind * System.Math.Cos(WindDir)
		Cy = Py - Rwind * System.Math.Sin(WindDir)
		
		Call DrawCompassArrow(Cx, Cy, Ascale, WindDir, picEnviron, 9)
		
		Cx = Px + Rwave * System.Math.Cos(WaveDir)
		Cy = Py - Rwave * System.Math.Sin(WaveDir)
		
		Call DrawCompassArrow(Cx, Cy, Ascale, WaveDir, picEnviron, 2)
		
		Cx = Px + Rcurrent * System.Math.Cos(CurrDir)
		Cy = Py - Rcurrent * System.Math.Sin(CurrDir)
		
		Call DrawCompassArrow(Cx, Cy, Ascale, CurrDir, picEnviron, 12)
		
		'   Annotate the plot
		With picEnviron
			.Font = VB6.FontChangeBold(.Font, False)
			'UPGRADE_ISSUE: PictureBox method picEnviron.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Twidth = .TextWidth("Wind  Wave  Current")
			'UPGRADE_ISSUE: PictureBox method picEnviron.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Theight = .TextHeight("Wind  Wave  Current")
			ALWidth = (BoxWidth - Twidth - 4 * Margin) / 3 - 2 * Margin
			
			Px = 3 * Margin
			Py = Py + Rcurrent + Amax * Ascale + Theight / 2
			'UPGRADE_ISSUE: PictureBox method picEnviron.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picEnviron.Line (Px, Py) - (Px + ALWidth, Py), QBColor(9)
			Px = Px + ALWidth + Margin
			Py = Py - Theight / 2
			'UPGRADE_ISSUE: PictureBox property picEnviron.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentX = Px
			'UPGRADE_ISSUE: PictureBox property picEnviron.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentY = Py
			'UPGRADE_ISSUE: PictureBox method picEnviron.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picEnviron.Print("Wind")
			
			'UPGRADE_ISSUE: PictureBox method picEnviron.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Px = Px + .TextWidth("Wind") + 3 * Margin
			Py = Py + Theight / 2
			'UPGRADE_ISSUE: PictureBox method picEnviron.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picEnviron.Line (Px, Py) - (Px + ALWidth, Py), QBColor(2)
			Px = Px + ALWidth + Margin
			Py = Py - Theight / 2
			'UPGRADE_ISSUE: PictureBox property picEnviron.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentX = Px
			'UPGRADE_ISSUE: PictureBox property picEnviron.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentY = Py
			'UPGRADE_ISSUE: PictureBox method picEnviron.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picEnviron.Print("Wave")
			
			'UPGRADE_ISSUE: PictureBox method picEnviron.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Px = Px + .TextWidth("Wave") + 3 * Margin
			Py = Py + Theight / 2
			'UPGRADE_ISSUE: PictureBox method picEnviron.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picEnviron.Line (Px, Py) - (Px + ALWidth, Py), QBColor(12)
			'UPGRADE_ISSUE: PictureBox property picEnviron.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentX = Px + ALWidth + Margin
			'UPGRADE_ISSUE: PictureBox property picEnviron.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentY = Py - Theight / 2
			'UPGRADE_ISSUE: PictureBox method picEnviron.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picEnviron.Print("Current")
		End With
		
	End Sub
	
	' draw polar(radar) plot in global system
	Public Sub DrawPolarPlot(ByVal Xw As Double, ByVal Yw As Double, ByVal WD As Double, ByVal Xv As Double, ByVal Yv As Double, ByVal Headv As Double, ByRef picPG As System.Windows.Forms.PictureBox, Optional ByVal AddVessel As Boolean = False)
		
		' Xw, Yw well center global coordinates
		' Xv, Yv vessel global coordinates, Headv - Vessel heading in deg TN
		
		Dim i As Short
		
		Dim tX, Twidth, Theight, tY As Double
		Dim Ymin, Xmin, Xmax, Ymax, Vmax As Double
		Dim HalfSquare, Dist As Double
		Dim BoxHeight, BoxWidth, BoxSize As Double
		'UPGRADE_WARNING: Lower bound of array Rsc was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		Dim Rsc(20) As Double
		
		Static Px, X0, Y0, Py As Double
		Static VScale, BoxScale As Double
		
		If Not AddVessel Then
			
			X0 = Xw
			Y0 = Yw
			
			'       How big is the picture box we're using?  Find the smaller of the width and
			'       height, and we'll use it to compute the plot scale a little later on...
			
			BoxWidth = VB6.PixelsToTwipsX(picPG.ClientRectangle.Width)
			BoxHeight = VB6.PixelsToTwipsY(picPG.ClientRectangle.Height)
			If BoxWidth < BoxHeight Then
				BoxSize = BoxWidth
			Else
				BoxSize = BoxHeight
			End If
			
			'UPGRADE_ISSUE: PictureBox property picPG.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picPG.AutoRedraw = True
			picPG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
			'UPGRADE_ISSUE: PictureBox method picPG.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picPG.Cls()
			
			'       Center the graphics in the picture box
			
			Px = BoxWidth / 2#
			Py = BoxHeight / 2#
			
			'       Draw a square there (the well)
			
			HalfSquare = 0.01 * BoxSize
			
			'UPGRADE_ISSUE: PictureBox method picPG.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picPG.Line (Px + HalfSquare, Py + HalfSquare) - (Px - HalfSquare, Py + HalfSquare)
			'UPGRADE_ISSUE: PictureBox method picPG.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picPG.Line (Px - HalfSquare, Py + HalfSquare) - (Px - HalfSquare, Py - HalfSquare)
			'UPGRADE_ISSUE: PictureBox method picPG.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picPG.Line (Px - HalfSquare, Py - HalfSquare) - (Px + HalfSquare, Py - HalfSquare)
			'UPGRADE_ISSUE: PictureBox method picPG.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picPG.Line (Px + HalfSquare, Py - HalfSquare) - (Px + HalfSquare, Py + HalfSquare)
			
			
			'       Compensate for the fact that, in our plot, North, which is zero degrees,
			'       is along the Y-axis of the picture box, not the X-axis
			
			Headv = -Headv + PI * 0.5
			
			'       Compute the distance through which the vessel has moved
			
			Dist = System.Math.Sqrt((Xv - X0) ^ 2 + (Yv - Y0) ^ 2)
			
			'       For very small offsets, this is confusing; make sure we don't make the
			'       plot scale too big
			
			If Dist < 0.02 * WD Then Dist = 0.02 * WD
			
			'       Build and scale the vessel sketch
			
			Call MakeVesselPoints(1#)
			Call ExtremePoints(VesselDiagram, Xmax, Xmin, Ymax, Ymin)
			
			If Xmax > Ymax Then
				Vmax = Xmax
			Else
				Vmax = Ymax
			End If
			
			VScale = 0.05 * BoxSize / Vmax
			
			'       And use it and the maximum distance to compute a scaling factor for the plot
			BoxScale = 0.45 * BoxSize / (Dist + Vmax / 2#)
			
			'       Draw the vessel itself, at the appropriate location
			'UPGRADE_ISSUE: PictureBox property picPG.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picPG.DrawWidth = 3
			Call DrawVessel(Px + BoxScale * (Xv - X0), Py - BoxScale * (Yv - Y0), Headv, VScale, picPG)
			'UPGRADE_ISSUE: PictureBox property picPG.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picPG.DrawWidth = 1
			
			'       Put a small circle in the middle of it
			'UPGRADE_ISSUE: PictureBox method picPG.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picPG.Circle (Px + BoxScale * (Xv - X0), Py - BoxScale * (Yv - Y0)), 0.2 * Vmax * VScale
			
			'       And another circle to indicate the range of the dynamic motion
			'UPGRADE_ISSUE: PictureBox method picPG.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picPG.Circle (Px + BoxScale * (Xv - X0), Py - BoxScale * (Yv - Y0)), MaxDynamicMotion * BoxScale, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Cyan)
			
			'       Draw a series of circles indicating fractions of the water depth
			'       While we're at it, annotate each
			With picPG
				.Font = VB6.FontChangeSize(.Font, 4)
				.Font = VB6.FontChangeBold(.Font, False)
				'UPGRADE_ISSUE: PictureBox method picPG.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Twidth = .TextWidth("99%")
				'UPGRADE_ISSUE: PictureBox method picPG.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Theight = .TextHeight("99%")
				
				
				If WD > 0# Then
					For i = 1 To 20
						If Dist > 0.32 * WD Then
							If i <= 10 Then
								Rsc(i) = 0.05 * i
							Else
								Rsc(i) = Rsc(i - 1) + 0.1
							End If
						ElseIf Dist > 0.16 * WD Then 
							If i <= 10 Then
								Rsc(i) = 0.02 * i
							Else
								Rsc(i) = Rsc(i - 1) + 0.05
							End If
						ElseIf Dist > 0.08 * WD Then 
							If i <= 10 Then
								Rsc(i) = 0.01 * i
							Else
								Rsc(i) = Rsc(i - 1) + 0.02
							End If
						Else
							If i <= 4 Then
								Rsc(i) = 0.005 * i
							Else
								Rsc(i) = Rsc(i - 1) + 0.01
							End If
						End If
						If Rsc(i) = 0.01 Then
							'UPGRADE_ISSUE: PictureBox method picPG.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
							picPG.Circle (Px, Py), Rsc(i) * WD * BoxScale, QBColor(12)
						ElseIf Rsc(i) = 0.02 Then 
							'UPGRADE_ISSUE: PictureBox method picPG.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
							picPG.Circle (Px, Py), Rsc(i) * WD * BoxScale, QBColor(9)
						Else
							'UPGRADE_ISSUE: PictureBox method picPG.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
							picPG.Circle (Px, Py), Rsc(i) * WD * BoxScale
						End If
						tX = Px + Twidth * 0.2
						tY = Py + Rsc(i) * WD * BoxScale - Theight
						'UPGRADE_ISSUE: PictureBox property picPG.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
						.CurrentX = tX
						'UPGRADE_ISSUE: PictureBox property picPG.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
						.CurrentY = tY
						'UPGRADE_ISSUE: PictureBox method picPG.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
						picPG.Print(VB6.Format(Rsc(i), "#0.0%"))
					Next i
					
				End If
				
				.Font = VB6.FontChangeSize(.Font, 15)
				.Font = VB6.FontChangeBold(.Font, True)
				'UPGRADE_ISSUE: PictureBox method picPG.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Twidth = .TextWidth("99%")
				'UPGRADE_ISSUE: PictureBox method picPG.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				Theight = .TextHeight("99%")
				'UPGRADE_ISSUE: PictureBox property picPG.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				.CurrentX = Px - Twidth / 2#
				'UPGRADE_ISSUE: PictureBox property picPG.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				.CurrentY = Theight * 0.1
				'UPGRADE_ISSUE: PictureBox method picPG.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				picPG.Print("N")
				'UPGRADE_ISSUE: PictureBox method picPG.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				picPG.Line (Px, 0) - (Px, BoxHeight)
				'UPGRADE_ISSUE: PictureBox method picPG.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				picPG.Line (0, Py) - (BoxWidth, Py)
			End With
		Else
			
			'       Compensate for the fact that, in our plot, North, which is zero degrees,
			'       is along the Y-axis of the picture box, not the X-axis
			Headv = -Headv + PI / 2#
			
			'       Draw the vessel itself, at the appropriate location
			
			'UPGRADE_ISSUE: PictureBox property picPG.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picPG.DrawWidth = 1
			Call DrawVessel(Px + BoxScale * (Xv - X0), Py - BoxScale * (Yv - Y0), Headv, VScale, picPG)
			
		End If
		
	End Sub
	
	' rotate plot points
	Private Sub RotatePoints(ByRef X As Object, ByRef angle As Double)
		
		' input
		'   X -- point coordinates
		'   Angle -- rotating angle
		' output
		'   X -- point coordinates after rotating
		
		Dim i As Short
		Dim Ax, c, S, Ay As Double
		
		c = System.Math.Cos(angle)
		S = System.Math.Sin(angle)
		
		For i = 1 To UBound(X)
			'UPGRADE_WARNING: Couldn't resolve default property of object X(i, MY_Renamed). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object X(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Ax = c * X(i, mX) - S * X(i, MY_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object X(i, MY_Renamed). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object X(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Ay = S * X(i, mX) + c * X(i, MY_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object X(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X(i, mX) = Ax
			'UPGRADE_WARNING: Couldn't resolve default property of object X(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X(i, MY_Renamed) = Ay
		Next i
		
	End Sub
	
	Public Sub ExtremePoints(ByRef GraphicArray As Object, ByRef Xmax As Double, ByRef Xmin As Double, ByRef Ymax As Double, ByRef Ymin As Double)
		
		Dim i As Short
		
		Xmax = 1E-38
		Ymax = Xmax
		Xmin = 1E+38
		Ymin = Xmin
		
		For i = 1 To UBound(GraphicArray)
			'UPGRADE_WARNING: Couldn't resolve default property of object GraphicArray(i, mX). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GraphicArray(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If GraphicArray(i, mX) > Xmax Then Xmax = GraphicArray(i, mX)
			'UPGRADE_WARNING: Couldn't resolve default property of object GraphicArray(i, mX). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GraphicArray(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If GraphicArray(i, mX) < Xmin Then Xmin = GraphicArray(i, mX)
			'UPGRADE_WARNING: Couldn't resolve default property of object GraphicArray(i, MY_Renamed). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GraphicArray(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If GraphicArray(i, MY_Renamed) > Ymax Then Ymax = GraphicArray(i, MY_Renamed)
			'UPGRADE_WARNING: Couldn't resolve default property of object GraphicArray(i, MY_Renamed). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GraphicArray(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If GraphicArray(i, MY_Renamed) < Ymin Then Ymin = GraphicArray(i, MY_Renamed)
		Next i
		
	End Sub
	
	Public Sub DrawTransientPlot(ByVal X0 As Double, ByVal Y0 As Double, ByRef NumPlotPoints As Short, ByRef Xv As Object, ByRef Yv As Object, ByRef Headv As Object, ByVal MaxTransX As Double, ByVal MaxTransY As Double, ByRef picPG As System.Windows.Forms.PictureBox)
		Dim MaxDynMotion As Object
		Dim ZWD As Object
		Dim i As Short
		Dim Margin, ScaleFactor, ArrowSpacing As Double
		Dim Px, Cx, Cy, Py As Double
		Dim tX, Twidth, Theight, tY As Double
		Dim Ymax, Xmax, Xmin, Ymin As Double
		Dim BoxScale, Vmax, BoxSize, VScale As Double
		Dim HalfSquare, Dist As Double
		Dim BoxWidth, BoxHeight As Double
		'UPGRADE_WARNING: Lower bound of array Rsc was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		Dim Rwd As Double
		Dim Rsc(20) As Double
		Dim StartTime As Double
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ZWD. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ZWD = CurVessel.WaterDepth
		
		' How big is the picture box we're using?  Find the smaller of the width and
		' height, and we'll use it to compute the plot scale a little later on...
		
		BoxWidth = VB6.PixelsToTwipsX(picPG.ClientRectangle.Width)
		BoxHeight = VB6.PixelsToTwipsY(picPG.ClientRectangle.Height)
		If BoxWidth < BoxHeight Then
			BoxSize = BoxWidth
		Else
			BoxSize = BoxHeight
		End If
		
		'UPGRADE_ISSUE: PictureBox property picPG.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picPG.AutoRedraw = True
		picPG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		'UPGRADE_ISSUE: PictureBox method picPG.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picPG.Cls()
		
		' Center the graphics in the picture box
		
		Px = BoxWidth / 2#
		Py = BoxHeight / 2#
		
		' Draw a square there (the well)
		
		HalfSquare = 0.01 * BoxSize
		
		'UPGRADE_ISSUE: PictureBox method picPG.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picPG.Line (Px + HalfSquare, Py + HalfSquare) - (Px - HalfSquare, Py + HalfSquare)
		'UPGRADE_ISSUE: PictureBox method picPG.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picPG.Line (Px - HalfSquare, Py + HalfSquare) - (Px - HalfSquare, Py - HalfSquare)
		'UPGRADE_ISSUE: PictureBox method picPG.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picPG.Line (Px - HalfSquare, Py - HalfSquare) - (Px + HalfSquare, Py - HalfSquare)
		'UPGRADE_ISSUE: PictureBox method picPG.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picPG.Line (Px + HalfSquare, Py - HalfSquare) - (Px + HalfSquare, Py + HalfSquare)
		
		' Compute the distance through which the vessel has moved
		
		
		Dist = System.Math.Sqrt((MaxTransX - X0) ^ 2 + (MaxTransY - Y0) ^ 2)
		
		' For very small offsets, this is confusing; make sure we don't make the
		' plot scale too big
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ZWD. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Dist < 0.02 * ZWD Then Dist = 0.02 * ZWD
		
		' And use it to compute a scaling factor for the plot
		'    BoxScale = 0.5 * BoxSize / Dist
		
		' Build and scale the vessel sketch
		
		Call MakeVesselPoints(1#)
		Call ExtremePoints(VesselDiagram, Xmax, Xmin, Ymax, Ymin)
		If Xmax > Ymax Then
			Vmax = Xmax
		Else
			Vmax = Ymax
		End If
		VScale = 0.05 * BoxSize / Vmax
		' And use it and the maximum distance to compute a scaling factor for the plot
		BoxScale = 0.45 * BoxSize / (Dist + Vmax / 2#)
		
		' Draw a series of circles indicating fractions of the water depth
		' While we're at it, annotate each
		
		
		With picPG
			.Font = VB6.FontChangeSize(.Font, 4)
			.Font = VB6.FontChangeBold(.Font, False)
			'UPGRADE_ISSUE: PictureBox method picPG.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Twidth = .TextWidth("99%")
			'UPGRADE_ISSUE: PictureBox method picPG.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Theight = .TextHeight("99%")
			
			For i = 1 To 20
				'UPGRADE_WARNING: Couldn't resolve default property of object ZWD. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Dist > 0.4 * ZWD Then
					If i <= 10 Then
						Rsc(i) = 0.05 * i
					Else
						Rsc(i) = Rsc(i - 1) + 0.1
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object ZWD. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ElseIf Dist > 0.2 * ZWD Then 
					If i <= 10 Then
						Rsc(i) = 0.02 * i
					Else
						Rsc(i) = Rsc(i - 1) + 0.05
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object ZWD. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ElseIf Dist > 0.1 * ZWD Then 
					If i <= 10 Then
						Rsc(i) = 0.01 * i
					Else
						Rsc(i) = Rsc(i - 1) + 0.02
					End If
				Else
					If i <= 4 Then
						Rsc(i) = 0.005 * i
					Else
						Rsc(i) = Rsc(i - 1) + 0.01
					End If
				End If
				If Rsc(i) = 0.01 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ZWD. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_ISSUE: PictureBox method picPG.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					picPG.Circle (Px, Py), Rsc(i) * ZWD * BoxScale, QBColor(12)
				ElseIf Rsc(i) = 0.02 Then 
					'UPGRADE_WARNING: Couldn't resolve default property of object ZWD. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_ISSUE: PictureBox method picPG.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					picPG.Circle (Px, Py), Rsc(i) * ZWD * BoxScale, QBColor(9)
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object ZWD. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_ISSUE: PictureBox method picPG.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
					picPG.Circle (Px, Py), Rsc(i) * ZWD * BoxScale
				End If
				tX = Px + Twidth * 0.2
				'UPGRADE_WARNING: Couldn't resolve default property of object ZWD. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				tY = Py + Rsc(i) * ZWD * BoxScale - Theight
				'UPGRADE_ISSUE: PictureBox property picPG.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				.CurrentX = tX
				'UPGRADE_ISSUE: PictureBox property picPG.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				.CurrentY = tY
				'UPGRADE_ISSUE: PictureBox method picPG.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				picPG.Print(VB6.Format(Rsc(i), "#0.0%"))
			Next i
			
			.Font = VB6.FontChangeSize(.Font, 15)
			.Font = VB6.FontChangeBold(.Font, True)
			'UPGRADE_ISSUE: PictureBox method picPG.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Twidth = .TextWidth("99%")
			'UPGRADE_ISSUE: PictureBox method picPG.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			Theight = .TextHeight("99%")
			'UPGRADE_ISSUE: PictureBox property picPG.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentX = Px - Twidth / 2#
			'UPGRADE_ISSUE: PictureBox property picPG.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.CurrentY = Theight * 0.1
			'UPGRADE_ISSUE: PictureBox method picPG.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picPG.Print("N")
			'UPGRADE_ISSUE: PictureBox method picPG.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picPG.Line (Px, 0) - (Px, BoxHeight)
			'UPGRADE_ISSUE: PictureBox method picPG.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			picPG.Line (0, Py) - (BoxWidth, Py)
		End With
		
		' Draw the vessel itself, at the appropriate location
		
		' Compensate for the fact that, in our plot, North, which is zero degrees,
		' is along the Y-axis of the picture box, not the X-axis
		'UPGRADE_WARNING: Couldn't resolve default property of object Headv(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Headv(1) = -Headv(1) + PI / 2#
		'UPGRADE_ISSUE: PictureBox property picPG.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picPG.DrawWidth = 3 '  draw thick black initial position
		'UPGRADE_WARNING: Couldn't resolve default property of object Yv(1). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Xv(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call DrawVessel(Px + BoxScale * (Xv(1) - X0), Py - BoxScale * (Yv(1) - Y0), (Headv(1)), VScale, picPG)
		'UPGRADE_ISSUE: PictureBox property picPG.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picPG.DrawWidth = 1
		StartTime = VB.Timer()
		For i = 2 To NumPlotPoints - 1
			Do While VB.Timer() < StartTime + TimerInterval
			Loop 
			'UPGRADE_WARNING: Couldn't resolve default property of object Headv(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Headv(i) = -Headv(i) + PI / 2# '  heading in radius
			'UPGRADE_WARNING: Couldn't resolve default property of object Yv(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Xv(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Call DrawVessel(Px + BoxScale * (Xv(i) - X0), Py - BoxScale * (Yv(i) - Y0), (Headv(i)), VScale, picPG)
			frmTransient.Refresh()
			StartTime = VB.Timer()
		Next i
		'UPGRADE_ISSUE: PictureBox property picPG.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picPG.DrawWidth = 3 '  draw red color for final position
		'UPGRADE_WARNING: Couldn't resolve default property of object Headv(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Headv(NumPlotPoints) = -Headv(NumPlotPoints) + PI / 2#
		'UPGRADE_WARNING: Couldn't resolve default property of object Yv(NumPlotPoints). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Xv(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call DrawVessel(Px + BoxScale * (Xv(NumPlotPoints) - X0), Py - BoxScale * (Yv(NumPlotPoints) - Y0), (Headv(NumPlotPoints)), VScale, picPG, 12)
		'UPGRADE_ISSUE: PictureBox property picPG.DrawWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picPG.DrawWidth = 1
		
		' Put a small circle in the middle of it
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Yv(1). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Xv(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: PictureBox method picPG.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picPG.Circle (Px + BoxScale * (Xv(1) - X0), Py - BoxScale * (Yv(1) - Y0)), 0.2 * Vmax * VScale
		
		' And another circle to indicate the range of the dynamic motion
		
		'UPGRADE_WARNING: Couldn't resolve default property of object MaxDynMotion. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Yv(1). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Xv(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_ISSUE: PictureBox method picPG.Circle was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		picPG.Circle (Px + BoxScale * (Xv(1) - X0), Py - BoxScale * (Yv(1) - Y0)), MaxDynMotion * VScale, QBColor(2)
		
	End Sub
End Module