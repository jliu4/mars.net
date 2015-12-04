Option Strict Off
Option Explicit On
Friend Class frmTransientCurves
	Inherits System.Windows.Forms.Form
	
	Private Const NumCaptions As Short = 11
	Private Const InputCol As Short = 10
	Private Const InputBGColor As Short = 14
	
	Private LastPlottedCol As Short
	
	Private PlotX() As Double
	Private PlotY() As Double
	Private Displacement() As Double
	Private PlotYaw() As Double
	Private LUnit, FrcUnit As String
	Private LFactor, FrcFactor As Double
	
	
	Private Sub frmTransientCurves_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim Wf, w, H, Lft As Double
		Dim NumLines As Short
		Dim i As Short
		Dim RowHead() As String
		Dim ColHead() As String
		
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		LastPlottedCol = 0
		
		' Establish the row and column headings
		
		ReDim RowHead(NumTimeSteps + 2)
		RowHead(0) = ""
		For i = 1 To NumTimeSteps
			RowHead(i) = "     " & VB6.Format((i - 1) * TimeStep, "#,##0.0")
		Next i
		
		grdCD.Rows = NumTimeSteps + 2
		
		NumLines = CurVessel.MoorSystem.MoorLineCount
		
		ReDim ColHead(NumLines + 4)
		
		If IsMetricUnit Then
			LUnit = "(m)"
			FrcUnit = "(KN)"
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
		Else
			LUnit = "(ft)"
			FrcUnit = "(kips)"
			LFactor = 1
			FrcFactor = 1
		End If
		
		
		ColHead(0) = "Time (sec)"
		ColHead(1) = "X(E) " & LUnit
		ColHead(2) = "Y(N) " & LUnit
		ColHead(3) = "Offset " & LUnit
		ColHead(4) = "Heading (deg)TN"
		For i = 1 To NumLines
			ColHead(i + 4) = "Line " & CStr(i) & " " & FrcUnit
		Next i
		
		' Put the grid in the appropriate place
		
		Call SetupLineGrid(grdCD, RowHead, ColHead, (VB6.PixelsToTwipsX(picGraph.Left)), VB6.PixelsToTwipsX(picGraph.Left) + VB6.PixelsToTwipsX(picGraph.Width), VB6.PixelsToTwipsY(grdCD.Top), VB6.PixelsToTwipsY(grdCD.Top) + VB6.PixelsToTwipsY(grdCD.Height), NumTimeSteps + 1, sysInf, True, 4, Me)
		
		lblUserNote.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(grdCD.Top) + VB6.PixelsToTwipsY(grdCD.Height) + 20)
		lblUserNote.Left = grdCD.Left
		grdCD.Col = 1
		
		Call UpdateGrid()
		grdCD_ClickEvent(grdCD, New System.EventArgs()) ' plot default line
		
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	'UPGRADE_WARNING: Event frmTransientCurves.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmTransientCurves_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		'    Call ResizeGrid(grdCD, 0, Me.ScaleWidth, 0.5 * Me.ScaleHeight, _
		''                    btnCancel.Top - 50#, NumTimeSteps + 1, _
		''                    sysInf, True, Me)
		'    lblUserNote.Top = grdCD.Top + grdCD.Height + 20
		'  '  Call CenterControlHoriz(grdCD, Me)
		'    btnCancel.Top = Me.Height - 2 * btnCancel.Height - 50#
		'  '  Call CenterControlHoriz(btnCancel, Me)
		'  '  Call ResizePicture(picGraph, 0, Me.width, 0, 0.45 * Me.Height)
		'    If LastPlottedCol <> 0 Then
		'        Call UpdatePlot(LastPlottedCol)
		'    End If
		'  '  Call CenterControlHoriz(picGraph, Me)
	End Sub
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub
	
	Private Sub UpdateGrid()
		Dim i, j As Short
		Dim Temp() As Double
		
		ReDim Temp(NumTimeSteps + 1)
		ReDim PlotYaw(NumTimeSteps + 1)
		ReDim Displacement(NumTimeSteps + 1)
		With grdCD
			
			For i = 1 To NumTimeSteps + 1
				Temp(i) = (i - 1) * TimeStep
			Next i
			Call FillColumn(0, NumTimeSteps, grdCD, Temp)
			Call FillColumn(1, NumTimeSteps, grdCD, TransX)
			Call FillColumn(2, NumTimeSteps, grdCD, TransY)
			For i = 1 To NumTimeSteps + 1
				'UPGRADE_WARNING: Couldn't resolve default property of object TransY(0). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object TransY(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object TransX(0). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object TransX(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Displacement(i) = System.Math.Sqrt((TransX(i) - TransX(0)) ^ 2 + (TransY(i) - TransY(0)) ^ 2)
			Next i
			Call FillColumn(3, NumTimeSteps, grdCD, Displacement)
			For i = 1 To NumTimeSteps + 1
				'UPGRADE_WARNING: Couldn't resolve default property of object TransYaw(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Temp(i) = TransYaw(i) * Radians2Degrees
				PlotYaw(i) = Temp(i)
			Next i
			Call FillColumn(4, NumTimeSteps, grdCD, Temp)
			For i = 1 To CurVessel.MoorSystem.MoorLineCount
				If CurVessel.MoorSystem.MoorLines(i).Connected Then
					For j = 1 To NumTimeSteps + 1
						Temp(j) = TransTension(i, j) / 1000#
					Next j
				Else
					For j = 1 To NumTimeSteps + 1
						Temp(j) = 0#
						TransTension(i, j) = 0#
					Next j
				End If
				Call FillColumn(i + 4, NumTimeSteps, grdCD, Temp)
			Next i
			
		End With
		
	End Sub
	
	Private Sub FillColumn(ByRef c As Short, ByRef N As Short, ByRef Grd As AxMSFlexGridLib.AxMSFlexGrid, ByRef X As Object)
		Dim r As Short
		
		With Grd
			
			.Col = c
			For r = 1 To N
				.Row = r
				Select Case c
					Case 0
						'UPGRADE_WARNING: Couldn't resolve default property of object X(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						.Text = VB6.Format(X(r), "##,##0.0") ' time sec
						'          .CellFontBold = True
					Case 1, 2, 3
						'UPGRADE_WARNING: Couldn't resolve default property of object X(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						.Text = VB6.Format(X(r) * LFactor, "#,##0.0")
					Case 4
						'UPGRADE_WARNING: Couldn't resolve default property of object X(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						.Text = VB6.Format(X(r), "##0.00")
					Case Is > 4
						'UPGRADE_WARNING: Couldn't resolve default property of object X(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						.Text = VB6.Format(X(r) * FrcFactor, "#,##0")
				End Select
			Next r
			
		End With
		
	End Sub
	
	Private Sub CopyArray(ByRef FromArray As Object, ByRef ToArray As Object, ByRef N As Object, ByRef Multiplier As Object)
		Dim i As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object N. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For i = 1 To N
			'UPGRADE_WARNING: Couldn't resolve default property of object Multiplier. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromArray(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ToArray(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ToArray(i) = FromArray(i) * Multiplier
		Next i
	End Sub
	
	Private Sub UpdatePlot(ByRef Cnum As Short)
		Dim Ymin, Xmin, Xmax, Ymax As Double
		Dim r As Short
		
		If IsMetricUnit Then
			LUnit = "(m)"
			FrcUnit = "(KN)"
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
		Else
			LUnit = "(ft)"
			FrcUnit = "(kips)"
			LFactor = 1
			FrcFactor = 1
		End If
		
		picGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		ReDim PlotX(NumTimeSteps + 2)
		ReDim PlotY(NumTimeSteps + 2)
		
		' Make the X-axis (time) array
		
		For r = 1 To NumTimeSteps + 1
			PlotX(r) = (r - 1) * TimeStep
		Next r
		
		' Make the Y-array
		Select Case Cnum
			
			Case 1 ' Surge
				Call CopyArray(TransX, PlotY, NumTimeSteps + 1, LFactor)
			Case 2 ' Sway
				Call CopyArray(TransY, PlotY, NumTimeSteps + 1, LFactor)
			Case 3 ' Total displacement
				Call CopyArray(Displacement, PlotY, NumTimeSteps + 1, LFactor)
			Case 4 ' Yaw
				Call CopyArray(PlotYaw, PlotY, NumTimeSteps + 1, 1#)
			Case Is > 4 ' Line tensions
				For r = 1 To NumTimeSteps + 1
					PlotY(r) = TransTension(Cnum - 4, r) / 1000# * FrcFactor
				Next r
			Case Else
				Exit Sub
				
		End Select
		
		'    Get maxima and minima
		
		Xmax = PlotX(NumTimeSteps)
		Xmin = 0#
		Call MaxAndMin(PlotY, Ymax, Ymin, NumTimeSteps)
		
		' Draw and label axes
		
		Select Case Cnum
			
			Case 1, 2, 3
				Call drawAxis(Xmax, Xmin, Ymax, Ymin, "Time (sec)", "Displacement " & LUnit, picGraph)
			Case 4
				Call drawAxis(Xmax, Xmin, Ymax, Ymin, "Time (sec)", "Displacement (deg)", picGraph)
			Case Is > 4
				Call drawAxis(Xmax, Xmin, Ymax, Ymin, "Time (sec)", "Tension " & FrcUnit, picGraph)
				
		End Select
		
		' Draw the line
		
		Call DrawLine(PlotX, PlotY, NumTimeSteps, DefaultColor, picGraph)
		
	End Sub
	
	Private Sub grdCD_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles grdCD.ClickEvent
		Dim r, c As Short
		
		With grdCD
			c = .Col
			If c = LastPlottedCol Then
				Exit Sub
			Else
				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
				' Keep the grid from flickering during update
				.Redraw = False
				' If we've previously plotted one column of data, that column should be colored red
				' Make it black again
				If LastPlottedCol <> 0 Then
					Call ColorCol(grdCD, LastPlottedCol, DefaultColor)
				End If
				' Color the current column red
				Call ColorCol(grdCD, c, WarningColor)
				' Draw the catenary curve for this row in the picture box on the form
				Call UpdatePlot(c)
				' For some unknown reason, the plot does not display the axes the first time
				' it is drawn; fix this (in a brute force way) by drawing the plot a second
				' time if it has not been drawn before
				If LastPlottedCol = 0 Then Call UpdatePlot(c)
				' Remember the row to avoid pointless redrawing in the future
				LastPlottedCol = c
				' Update the grid on the screen
				.Redraw = True
				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
			End If
		End With
	End Sub
End Class