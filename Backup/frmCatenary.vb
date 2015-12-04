Option Strict Off
Option Explicit On
Friend Class frmCatenary
	Inherits System.Windows.Forms.Form
	
	Private SegLength(MaxNumSeg) As Double
	Private SegTension(MaxNumSeg) As Double
	Private SegAngle(MaxNumSeg) As Double
	Private SegPosition(MaxNumSeg) As Double
	Private JustEnter As Boolean
	Private ExistingTxt As String
	Private LastChanged As Short '1 - topten; 2 - horfrc
	Private InitiateCbo As Boolean
	
	Private LUnit, FrcUnit As String
	Private LFactor, FrcFactor As Double
	
	' form load and unload
	
	Private Sub frmCatenary_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		If IsMetricUnit Then
			LUnit = " (m)"
			FrcUnit = " (KN)"
		Else
			LUnit = " (ft)"
			FrcUnit = " (kips)"
		End If
		
		Dim r, c As Short
		Dim ColW, RowH As Short
		Dim LengthLabel(4) As String
		Dim DetailLabelC(3) As String
		Dim DetailLabelR(5) As String
		
		LengthLabel(0) = "Scope" & LUnit
		LengthLabel(1) = "Total Length" & LUnit
		LengthLabel(2) = "Suspended Length" & LUnit
		LengthLabel(3) = "Grounded Length" & LUnit
		LengthLabel(4) = "Stretched Length" & LUnit
		
		DetailLabelC(1) = "Top"
		DetailLabelC(2) = "Seg.i"
		DetailLabelC(3) = "Bottom"
		DetailLabelR(1) = "Payout" & LUnit
		DetailLabelR(2) = "Tension" & FrcUnit
		DetailLabelR(3) = "Hor. Force" & FrcUnit
		DetailLabelR(4) = "Angle (deg)"
		DetailLabelR(5) = "Depth at Top" & LUnit
		
		With grdLength
			.Clear()
			.WordWrap = True
			
			ColW = VB6.PixelsToTwipsX(.Width) / .Cols - .GridLineWidth
			RowH = VB6.PixelsToTwipsY(.Height) / (.Rows + 0.75) - 50
			.set_RowHeight(0, VB6.PixelsToTwipsY(.Height) - RowH - 80)
			.set_RowHeight(1, RowH)
			.Row = 0
			For c = 0 To .Cols - 1
				If c = 0 Then
					.set_ColWidth(c, ColW - 70)
				Else
					.set_ColWidth(c, ColW)
				End If
				.Col = c
				.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
				.Text = LengthLabel(c)
			Next c
			.Row = 1
			For c = 0 To .Cols - 1
				.Col = c
				.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
			Next c
		End With
		
		With grdDetails
			.Clear()
			.WordWrap = True
			
			ColW = VB6.PixelsToTwipsX(.Width) / (.Cols + 0.3) - .GridLineWidth
			RowH = (VB6.PixelsToTwipsY(.Height) - VB6.PixelsToTwipsY(cboSegment.Height)) / (.Rows - 1) - .GridLineWidth - 20
			.set_ColWidth(0, ColW * 1.3 - 80)
			.set_RowHeight(0, VB6.PixelsToTwipsY(cboSegment.Height) + 20)
			
			.Row = 0
			For c = 1 To .Cols - 1
				.set_ColWidth(c, ColW)
				.Col = c
				.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
				.Text = DetailLabelC(c)
				
				If c = 2 Then
					cboSegment.Left = VB6.TwipsToPixelsX(.CellLeft + VB6.PixelsToTwipsX(.Left) + .GridLineWidth)
					cboSegment.Top = VB6.TwipsToPixelsY(.CellTop + VB6.PixelsToTwipsY(.Top) + .GridLineWidth)
					cboSegment.Width = VB6.TwipsToPixelsX(.CellWidth)
				End If
			Next c
			
			.Col = 0
			For r = 1 To .Rows - 1
				.set_RowHeight(r, RowH)
				.Row = r
				.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
				.Text = DetailLabelR(r)
			Next r
			For r = 1 To .Rows - 1
				.Row = r
				For c = 1 To .Cols - 1
					.Col = c
					.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
					If (r = 1 Or r = 5) And c = 3 Then .Text = "---"
					If r = 2 And c = 1 Then
						txtTopTen.Left = VB6.TwipsToPixelsX(.CellLeft + VB6.PixelsToTwipsX(.Left) + .GridLineWidth)
						txtTopTen.Top = VB6.TwipsToPixelsY(.CellTop + VB6.PixelsToTwipsY(.Top) + .GridLineWidth)
						txtTopTen.Width = VB6.TwipsToPixelsX(.CellWidth)
					End If
					If r = 3 And c = 1 Then
						txtHorFrc.Left = VB6.TwipsToPixelsX(.CellLeft + VB6.PixelsToTwipsX(.Left) + .GridLineWidth)
						txtHorFrc.Top = VB6.TwipsToPixelsY(.CellTop + VB6.PixelsToTwipsY(.Top) + .GridLineWidth)
						txtHorFrc.Width = VB6.TwipsToPixelsX(.CellWidth)
					End If
				Next c
			Next r
		End With
		
		JustEnter = True
		
	End Sub
	
	' buttons
	
	Private Sub btnOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOK.Click
		
		Me.Close()
		
	End Sub
	
	Private Sub btnRefresh_Click()
		
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
			LUnit = " (m)"
			FrcUnit = " (KN)"
		Else
			LFactor = 1
			FrcFactor = 1
			LUnit = " (ft)"
			FrcUnit = " (kips)"
		End If
		
		
		Dim TopTension, HorForce As Double
		
		Select Case LastChanged
			Case 1
				txtTopTen.Text = VB6.Format(CheckData(txtTopTen.Text), "0.00")
				TopTension = CDbl(txtTopTen.Text) * 1000# / FrcFactor
				
				Call frmMoorLines.UpdateCat(TopTension)
				frmMoorLines.ChangeInCat = True
			Case 2
				txtHorFrc.Text = VB6.Format(CheckData(txtHorFrc.Text), "0.00")
				TopTension = 0#
				HorForce = CDbl(txtHorFrc.Text) * 1000# / FrcFactor
				
				Call frmMoorLines.UpdateCat(TopTension, HorForce)
				frmMoorLines.ChangeInCat = True
		End Select
		
	End Sub
	
	' combo box
	
	'UPGRADE_WARNING: Event cboLines.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboLines_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLines.SelectedIndexChanged
		
		If InitiateCbo Then Exit Sub
		With frmMoorLines
			.tabMoorLines.Tabs(cboLines.SelectedIndex + 1).Selected = True
			Call .UpdateCat()
		End With
		
	End Sub
	
	'UPGRADE_WARNING: Event cboSegment.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboSegment_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboSegment.SelectedIndexChanged
		
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
			LUnit = " (m)"
			FrcUnit = " (KN)"
		Else
			LFactor = 1
			FrcFactor = 1
			LUnit = " (ft)"
			FrcUnit = " (kips)"
		End If
		
		
		Dim ID As Short
		
		ID = cboSegment.SelectedIndex
		
		With grdDetails
			.Col = 2
			.Row = 1
			.Text = VB6.Format(SegLength(ID + 1) * LFactor, "0.0")
			.Row = 2
			.Text = VB6.Format(SegTension(ID + 1) * 0.001 * FrcFactor, "0.00")
			.Row = 3
			.Text = VB6.Format(SegTension(ID + 1) * 0.001 * System.Math.Cos(SegAngle(ID + 1)) * FrcFactor, "0.00")
			.Row = 4
			.Text = VB6.Format(SegAngle(ID + 1) * Radians2Degrees, "0.00")
			.Row = 5
			.Text = VB6.Format(SegPosition(ID + 1) * LFactor, "0.0")
		End With
		
	End Sub
	
	' text box
	
	Private Sub txtTopTen_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtTopTen.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		If JustEnter Then
			JustEnter = False
			ExistingTxt = txtTopTen.Text
			VB6.SetCancel(btnOK, False)
		End If
		
		Select Case KeyCode
			
			Case System.Windows.Forms.Keys.Return
				LastChanged = 1
				btnRefresh_Click()
				
			Case System.Windows.Forms.Keys.Escape
				txtTopTen.Text = ExistingTxt
				
		End Select
		
	End Sub
	
	Private Sub txtTopTen_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTopTen.Leave
		
		JustEnter = True
		VB6.SetCancel(btnOK, True)
		LastChanged = 1
		
	End Sub
	
	Private Sub txtHorFrc_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtHorFrc.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		If JustEnter Then
			JustEnter = False
			ExistingTxt = txtTopTen.Text
			VB6.SetCancel(btnOK, False)
		End If
		
		Select Case KeyCode
			
			Case System.Windows.Forms.Keys.Return
				LastChanged = 2
				btnRefresh_Click()
				
			Case System.Windows.Forms.Keys.Escape
				txtHorFrc.Text = ExistingTxt
				
		End Select
		
	End Sub
	
	Private Sub txtHorFrc_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHorFrc.Leave
		
		JustEnter = True
		VB6.SetCancel(btnOK, True)
		LastChanged = 2
		
	End Sub
	
	' update data
	
	Public Sub UpdateForm(ByVal NumLines As Short, ByVal CurLine As Short, ByVal NumSegment As Short, ByVal Scope As Double, ByVal lineLength As Double, ByVal SuspendLength As Double, ByVal GroundedLength As Double, ByVal StretchLength As Double, ByVal TopLength As Double, ByVal TopTension As Double, ByVal BottomTension As Double, ByVal TopAngle As Double, ByVal BottomAngle As Double, ByVal TopPosition As Double, ByRef SegmentLength() As Double, ByRef SegmentTension() As Double, ByRef SegmentAngle() As Double, ByRef SegmentPosition() As Double, ByRef CatX() As Double, ByRef CatY() As Double, ByRef Connector() As Short)
		
		Dim SegMaxTen, i, j, NumPoints As Short
		Dim MaxTen As Double
		
		Dim Xmin, Xmax, Ymax, Ymin As Double
		Dim Color(3) As Integer
		Dim X(MaxNumSubSeg + 1) As Double
		Dim Y(MaxNumSubSeg + 1) As Double
		
		If IsMetricUnit Then
			LFactor = 0.3048 ' ft -> m
			FrcFactor = 4.448222 ' kips -> KN
			LUnit = " (m)"
			FrcUnit = " (KN)"
		Else
			LFactor = 1
			FrcFactor = 1
			LUnit = " (ft)"
			FrcUnit = " (kips)"
		End If
		
		MaxTen = 0#
		For i = 1 To NumSegment
			If i > MaxNumSeg Then Exit For
			SegLength(i) = SegmentLength(i)
			SegTension(i) = SegmentTension(i)
			SegAngle(i) = SegmentAngle(i)
			SegPosition(i) = SegmentPosition(i)
			
			If SegmentTension(i) > MaxTen Then
				MaxTen = SegmentTension(i)
				SegMaxTen = i
			End If
		Next i
		
		InitiateCbo = True
		With cboLines
			.Items.Clear()
			For i = 1 To NumLines
				.Items.Add("Line " & i)
			Next i
			.SelectedIndex = CurLine - 1
		End With
		InitiateCbo = False
		
		With cboSegment
			.Items.Clear()
			For i = 1 To NumSegment
				If i > MaxNumSeg Then Exit For
				.Items.Add("Segment " & i)
			Next 
			.SelectedIndex = SegMaxTen - 1
		End With
		
		With grdLength
			.Row = 1
			.Col = 0
			.Text = VB6.Format(Scope * LFactor, "0.0")
			.Col = 1
			.Text = VB6.Format(lineLength * LFactor, "0.0")
			.Col = 2
			.Text = VB6.Format(SuspendLength * LFactor, "0.0")
			.Col = 3
			.Text = VB6.Format(GroundedLength * LFactor, "0.0")
			.Col = 4
			.Text = VB6.Format(StretchLength * LFactor, "0.0")
		End With
		
		With grdDetails
			.Col = 1
			.Row = 1
			.Text = VB6.Format(TopLength * LFactor, "0.0")
			.Row = 2
			.Text = VB6.Format(TopTension * 0.001 * FrcFactor, "0.00")
			txtTopTen.Text = .Text
			.Row = 3
			.Text = VB6.Format(TopTension * 0.001 * System.Math.Cos(TopAngle) * FrcFactor, "0.00")
			txtHorFrc.Text = .Text
			.Row = 4
			.Text = VB6.Format(TopAngle * Radians2Degrees, "0.00")
			.Row = 5
			.Text = VB6.Format(TopPosition * LFactor, "0.0")
			.Col = 3
			.Row = 2
			.Text = VB6.Format(BottomTension * 0.001 * FrcFactor, "0.00")
			.Row = 3
			.Text = VB6.Format(BottomTension * 0.001 * System.Math.Cos(BottomAngle) * FrcFactor, "0.00")
			.Row = 4
			.Text = VB6.Format(BottomAngle * Radians2Degrees, "0.00")
		End With
		
		Xmax = CatX(1) * LFactor
		Xmin = 0#
		Ymax = Max(CatY(1) * LFactor, 0#)
		Ymin = 0#
		Color(1) = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
		Color(2) = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
		Color(3) = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Lime)
		Color(0) = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)
		
		Call drawAxis(Xmax, Xmin, Ymax, Ymin, "Distance" & LUnit, "Depth" & LUnit, picCatenary, False)
		
		FileClose(FileNumRes)
		'    Open MarsDir & "catenary.dat" For Output Access Write As #FileNumRes
		FileOpen(FileNumRes, MarsDir & CurLine & "catenary.dat", OpenMode.Output, OpenAccess.Write)
		For i = 1 To NumSegment
			NumPoints = Connector(i) - Connector(i + 1) + 1
			For j = 1 To NumPoints
				X(j) = CatX(Connector(i) - j + 1) * LFactor
				Y(j) = CatY(Connector(i) - j + 1) * LFactor
				
				If j = NumPoints Then
					WriteLine(FileNumRes, X(j), Y(j), "<-End Segment " & i)
				Else
					WriteLine(FileNumRes, X(j), Y(j))
				End If
			Next j
			Call DrawLine(X, Y, NumPoints, Color(i Mod 4), picCatenary)
		Next i
		
		FileClose(FileNumRes)
		
	End Sub
End Class