Option Strict Off
Option Explicit On
Module modUtilities
	
	' input handling
	Private Const DelimiterList As String = " ,=/;~!@#$%^&*()_+{}[]|\:<>?/" & vbTab
	Private Const MaxDelimiters As Short = 32
	
	' maximum points in spline fitting
	Private Const MaxPtNum As Short = 100
	
	Public Sub MatMul(ByRef A As Object, ByRef B As Object, ByRef c As Object)
		
		Dim i, j As Short
		Dim sum As Double
		
		For i = 1 To UBound(A)
			sum = 0#
			For j = 1 To UBound(A)
				'UPGRADE_WARNING: Couldn't resolve default property of object B(j). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				sum = A(i, j) * B(j) + sum
			Next j
			'UPGRADE_WARNING: Couldn't resolve default property of object c(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			c(i) = sum
		Next i
		
	End Sub
	
	Public Sub Invert(ByRef A As Object)
		
		Dim j, i, k As Short
		Dim Temp As Double
		Dim L, U As Short
		
		L = LBound(A)
		U = UBound(A)
		For k = L To U
			'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Temp = A(k, k)
			'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			A(k, k) = 1#
			For j = L To U
				'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				A(k, j) = A(j, k) / Temp
			Next j
			For i = L To U
				If i <> k Then
					'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Temp = A(i, k)
					'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					A(i, k) = 0#
					For j = L To U
						'UPGRADE_WARNING: Couldn't resolve default property of object A(k, j). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						A(i, j) = A(i, j) - Temp * A(k, j)
					Next j
				End If
			Next i
		Next k
		
	End Sub
	
	Public Sub SqMatMul(ByVal A As Object, ByVal B As Object, ByRef c As Object)
		
		Dim k, i, j, N As Short
		Dim sum As Double
		
		N = UBound(A)
		For i = 1 To N
			For j = 1 To N
				sum = 0#
				For k = 1 To N
					'UPGRADE_WARNING: Couldn't resolve default property of object B(k, j). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sum = A(i, k) * B(k, j) + sum
				Next k
				'UPGRADE_WARNING: Couldn't resolve default property of object c(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				c(i, j) = sum
			Next j
		Next i
		
	End Sub
	
	' Public Sub GaussJordan(ByRef A, ByVal N As Integer, ByRef B, ByVal M As Integer)
	Public Sub GaussJordan(ByRef A As Object, ByRef N As Object, ByRef B As Object, ByRef M As Object)
		
		Dim L, j, i, k, ll As Short
		'UPGRADE_WARNING: Lower bound of array Rindex was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		Dim c, r As Short
		Dim Rindex(50) As Short
		'UPGRADE_WARNING: Lower bound of array Pivot was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		Dim Pivot(50) As Double
		'UPGRADE_WARNING: Lower bound of array Cindex was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		Dim Cindex(50) As Short
		Dim Dummy, Big, Pinverse As Double
		
		'UPGRADE_WARNING: Couldn't resolve default property of object N. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For j = 1 To N
			Pivot(j) = 0
		Next j
		'UPGRADE_WARNING: Couldn't resolve default property of object N. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For i = 1 To N
			Big = 0#
			'UPGRADE_WARNING: Couldn't resolve default property of object N. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			For j = 1 To N
				If Pivot(j) <> 1 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object N. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For k = 1 To N
						If Pivot(k) = 0 Then
							'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							If System.Math.Abs(A(j, k)) >= Big Then
								'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								Big = System.Math.Abs(A(j, k))
								r = j
								c = k
							End If
						ElseIf Pivot(k) > 1 Then 
							Call MsgBox("Singular matrix inversion attempted", MsgBoxStyle.OKOnly, "MARS - Calculation Failure")
							Exit Sub
						End If
					Next k
				End If
			Next j
			Pivot(c) = Pivot(c) + 1
			If r <> c Then
				'UPGRADE_WARNING: Couldn't resolve default property of object N. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For L = 1 To N
					'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dummy = A(r, L)
					'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					A(r, L) = A(c, L)
					'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					A(c, L) = Dummy
				Next L
				'UPGRADE_WARNING: Couldn't resolve default property of object M. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For L = 1 To M
					'UPGRADE_WARNING: Couldn't resolve default property of object B(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dummy = B(r, L)
					'UPGRADE_WARNING: Couldn't resolve default property of object B(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					B(r, L) = B(c, L)
					'UPGRADE_WARNING: Couldn't resolve default property of object B(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					B(c, L) = Dummy
				Next L
			End If
			Rindex(i) = r
			Cindex(i) = c
			'UPGRADE_WARNING: Couldn't resolve default property of object A(c, c). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If A(c, c) = 0 Then
				MsgBox("Singular matrix inversion attempted", MsgBoxStyle.OKOnly, "MARS - Calculation Failure")
				Exit Sub
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Pinverse = 1# / A(c, c)
			'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			A(c, c) = 1#
			'UPGRADE_WARNING: Couldn't resolve default property of object N. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			For L = 1 To N
				'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				A(c, L) = A(c, L) * Pinverse
			Next L
			'UPGRADE_WARNING: Couldn't resolve default property of object M. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			For L = 1 To M
				'UPGRADE_WARNING: Couldn't resolve default property of object B(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				B(c, L) = B(c, L) * Pinverse
			Next L
			'UPGRADE_WARNING: Couldn't resolve default property of object N. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			For ll = 1 To N
				If ll <> c Then
					'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dummy = A(ll, c)
					'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					A(ll, c) = 0#
					'UPGRADE_WARNING: Couldn't resolve default property of object N. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For L = 1 To N
						'UPGRADE_WARNING: Couldn't resolve default property of object A(c, L). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						A(ll, L) = A(ll, L) - A(c, L) * Dummy
					Next L
					'UPGRADE_WARNING: Couldn't resolve default property of object M. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For L = 1 To M
						'UPGRADE_WARNING: Couldn't resolve default property of object B(c, L). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object B(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						B(ll, L) = B(ll, L) - B(c, L) * Dummy
					Next L
				End If
			Next ll
		Next i
		'UPGRADE_WARNING: Couldn't resolve default property of object N. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For L = N To 1 Step -1
			If Rindex(L) <> Cindex(L) Then
				'UPGRADE_WARNING: Couldn't resolve default property of object N. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				For k = 1 To N
					'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dummy = A(k, Rindex(L))
					'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					A(k, Rindex(L)) = A(k, Cindex(L))
					'UPGRADE_WARNING: Couldn't resolve default property of object A(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					A(k, Cindex(L)) = Dummy
				Next k
			End If
		Next L
		
		Exit Sub
		
	End Sub
	
	Public Function CountNumerics(ByRef St As String) As Short
		Dim i, j As Integer
		Dim num, StLen, DLen, StartCh As Short
		Dim Ch, TempSt As String
		Dim DelimiterFound, EOL As Boolean
		
		' "DelimiterList" is a string containing all allowable delimiters
		
		DLen = Len(DelimiterList)
		StLen = Len(St)
		StartCh = 1
		num = 0
		TempSt = ""
		DelimiterFound = False
		EOL = False
		
		Do While Not EOL
			
			' See if we have found a delimiter by comparing every character in the input
			' string to every one in the delimiter list; set the "found" flag if we find
			' a match
			
			For i = StartCh To StLen
				For j = 1 To DLen
					If Mid(St, i, 1) = Mid(DelimiterList, j, 1) Then
						DelimiterFound = True
						Exit For
					End If
				Next j
				
				' If a match has been found, remember where to start looking again, and then
				' temporarily leave the outer loop (the one working through the input string)
				
				If DelimiterFound Then
					If i < StLen Then
						StartCh = i + 1
					Else
						EOL = True
					End If
					Exit For
					
					' If no match was found, append this character to those found following the
					' last delimiter.  In this way we build up the strings between the delimiters
					
				Else
					TempSt = TempSt & Mid(St, i, 1)
				End If
				
				' Make sure we recognize the end of the input string
				
				If i >= StLen Then
					DelimiterFound = True
					EOL = True
					Exit For
				End If
			Next i
			
			' See if the string found is numeric; if not, do not count it
			
			If Len(TempSt) > 0 And IsNumeric(TempSt) Then
				num = num + 1
			End If
			
			' Reset the flag and temporary string
			
			DelimiterFound = False
			TempSt = ""
			
			' Keep going until we find the end of the input string
			
		Loop 
		
		' Report our result
		
		CountNumerics = num
		
	End Function
	
	Public Function CountLeadingStrings(ByRef St As String) As Short
		Dim i, j As Integer
		Dim num, StLen, DLen, StartCh As Short
		Dim Ch, TempSt As String
		Dim DelimiterFound, EOL As Boolean
		
		' "DelimiterList" is a string containing all allowable delimiters
		
		DLen = Len(DelimiterList)
		StLen = Len(St)
		StartCh = 1
		num = 0
		TempSt = ""
		DelimiterFound = False
		EOL = False
		
		Do While Not EOL
			
			' See if we have found a delimiter by comparing every character in the input
			' string to every one in the delimiter list; set the "found" flag if we find
			' a match
			
			For i = StartCh To StLen
				For j = 1 To DLen
					If Mid(St, i, 1) = Mid(DelimiterList, j, 1) Then
						DelimiterFound = True
						Exit For
					End If
				Next j
				
				' If a match has been found, remember where to start looking again, and then
				' temporarily leave the outer loop (the one working through the input string)
				
				If DelimiterFound Then
					If i < StLen Then
						StartCh = i + 1
					Else
						EOL = True
					End If
					Exit For
					
					' If no match was found, append this character to those found following the
					' last delimiter.  In this way we build up the strings between the delimiters
					
				Else
					TempSt = TempSt & Mid(St, i, 1)
				End If
				
				' Make sure we recognize the end of the input string
				
				If i >= StLen Then
					DelimiterFound = True
					EOL = True
					Exit For
				End If
			Next i
			
			' See if the string found is numeric; if so, do not count it
			
			If Len(TempSt) > 0 And (Not IsNumeric(TempSt)) Then
				num = num + 1
				
				' Once we find a numeric string, it's all over
				
			ElseIf Len(TempSt) > 0 And IsNumeric(TempSt) Then 
				EOL = True
			End If
			
			' Reset the flag and temporary string
			
			DelimiterFound = False
			TempSt = ""
			
			' Keep going until we find the end of the input string
			
		Loop 
		
		' Report our result
		
		CountLeadingStrings = num
		
	End Function
	
	Public Function GetNumericString(ByRef St As String, ByRef StNum As Short) As Double
		Dim i, j As Integer
		Dim num, StLen, DLen, StartCh As Short
		Dim Ch, TempSt As String
		Dim EOL, DelimiterFound, EnoughNumbers As Boolean
		
		' "DelimiterList" is a string containing all allowable delimiters
		
		DLen = Len(DelimiterList)
		StLen = Len(St)
		StartCh = 1
		num = 0
		TempSt = ""
		DelimiterFound = False
		EOL = False
		EnoughNumbers = False
		
		Do While Not EOL
			
			' See if we have found a delimiter by comparing every character in the input
			' string to every one in the delimiter list; set the "found" flag if we find
			' a match
			
			For i = StartCh To StLen
				For j = 1 To DLen
					If Mid(St, i, 1) = Mid(DelimiterList, j, 1) Then
						DelimiterFound = True
						Exit For
					End If
				Next j
				
				' If a match has been found, remember where to start looking again, and then
				' temporarily leave the outer loop (the one working through the input string)
				
				If DelimiterFound Then
					If i < StLen Then
						StartCh = i + 1
					Else
						EOL = True
					End If
					Exit For
					
					' If no match was found, append this character to those found following the
					' last delimiter.  In this way we build up the strings between the delimiters
					
				Else
					TempSt = TempSt & Mid(St, i, 1)
				End If
				
				' Make sure we recognize the end of the input string
				
				If i >= StLen Then
					DelimiterFound = True
					EOL = True
					Exit For
				End If
			Next i
			
			' See if the string found is numeric; if not, do not count it
			
			If Len(TempSt) > 0 And IsNumeric(TempSt) Then
				num = num + 1
				If num = StNum Then
					EOL = True
					EnoughNumbers = True
					Exit Do
				End If
			End If
			
			' Reset the flag and temporary string
			
			DelimiterFound = False
			TempSt = ""
			
			' Keep going until we find the end of the input string
			
		Loop 
		
		' Report our result
		
		If EnoughNumbers Then
			GetNumericString = CDbl(TempSt)
		Else
			GetNumericString = 0#
		End If
		
	End Function
	
	Public Function GetFirstString(ByRef St As String) As String
		Dim i, j As Integer
		Dim num, StLen, DLen, StartCh As Short
		Dim Ch, TempSt As String
		Dim EOL, DelimiterFound, EnoughNumbers As Boolean
		
		' "DelimiterList" is a string containing all allowable delimiters
		
		DLen = Len(DelimiterList)
		StLen = Len(St)
		StartCh = 1
		num = 0
		TempSt = ""
		DelimiterFound = False
		EOL = False
		EnoughNumbers = False
		
		' Let's not go through all this for nothing
		
		If Len(St) = 0 Then
			GetFirstString = ""
			Exit Function
		End If
		
		' On the other hand, if something IS there, deal with it
		
		Do While Not EOL
			
			' See if we have found a delimiter by comparing every character in the input
			' string to every one in the delimiter list; set the "found" flag if we find
			' a match
			
			For i = StartCh To StLen
				For j = 1 To DLen
					If Mid(St, i, 1) = Mid(DelimiterList, j, 1) Then
						DelimiterFound = True
						Exit For
					End If
				Next j
				
				' If a match has been found, remember where to start looking again, and then
				' temporarily leave the outer loop (the one working through the input string)
				
				If DelimiterFound Then
					If i < StLen Then
						StartCh = i + 1
					Else
						EOL = True
					End If
					Exit For
					
					' If no match was found, append this character to those found following the
					' last delimiter.  In this way we build up the strings between the delimiters
					
				Else
					TempSt = TempSt & Mid(St, i, 1)
				End If
				
				' Make sure we recognize the end of the input string
				
				If i >= StLen Then
					DelimiterFound = True
					EOL = True
					Exit For
				End If
			Next i
			
			' Once we find a string, return it if if is non-numeric, or return an empty
			' string if it is numeric (no leading string)
			
			If Len(TempSt) > 0 Then
				If IsNumeric(TempSt) Then
					GetFirstString = ""
				Else
					GetFirstString = TempSt
				End If
				Exit Function
			End If
			
			' Keep going until we find the end of the input string
			
		Loop 
		
	End Function
	
	Public Function GetSecondString(ByRef St As String) As String
		Dim RemSt As String
		
		' The idea is to use GetFirstString to find out the length of the first
		' string; remove it; remove any leading blanks that remain; call
		' GetFirst String again; return its product as the second string
		
		RemSt = Trim(Right(St, Len(St) - Len(GetFirstString(St))))
		GetSecondString = GetFirstString(RemSt)
		
	End Function
	'UPGRADE_NOTE: Split was upgraded to Split_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Function Split_Renamed(ByVal InputText As String, Optional ByVal Delimiter As String = "") As Object
		
		' This function splits the sentence in InputText into
		' words and returns a string array of the words. Each
		' element of the array contains one word.
		
		' This constant contains punctuation and characters
		' that should be filtered from the input string.
		Const CHARS As String = "!?,;:""'()[]{}" ' removed period dot from this
		Dim strReplacedText As String
		Dim intIndex As Short
		
		' Replace tab characters with space characters.
		strReplacedText = Trim(Replace(InputText, vbTab, " "))
		
		' Filter all specified characters from the string.
		For intIndex = 1 To Len(CHARS)
			strReplacedText = Trim(Replace(strReplacedText, Mid(CHARS, intIndex, 1), " "))
		Next intIndex
		
		' Loop until all consecutive space characters are
		' replaced by a single space character.
		Do While InStr(strReplacedText, "  ")
			strReplacedText = Replace(strReplacedText, "  ", " ")
		Loop 
		
		' Split the sentence into an array of words and return
		' the array. If a delimiter is specified, use it.
		'MsgBox "String:" & strReplacedText
		If Len(Delimiter) = 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Split_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Split_Renamed = Split(strReplacedText)
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Split_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Split_Renamed = Split(strReplacedText, Delimiter)
		End If
	End Function
	
	
	Public Function ParseNumericString(ByRef St As String, ByRef OutArray() As Double) As Short
		Dim i, j As Integer
		Dim num, StLen, DLen, StartCh As Short
		Dim Ch, TempSt As String
		Dim DelimiterFound, EOL As Boolean
		
		' "DelimiterList" is a string containing all allowable delimiters
		
		DLen = Len(DelimiterList)
		StLen = Len(St)
		StartCh = 1
		num = 0
		TempSt = ""
		DelimiterFound = False
		EOL = False
		
		Do While Not EOL
			
			' See if we have found a delimiter by comparing every character in the input
			' string to every one in the delimiter list; set the "found" flag if we find
			' a match
			
			For i = StartCh To StLen
				For j = 1 To DLen
					If Mid(St, i, 1) = Mid(DelimiterList, j, 1) Then
						DelimiterFound = True
						Exit For
					End If
				Next j
				
				' If a match has been found, remember where to start looking again, and then
				' temporarily leave the outer loop (the one working through the input string)
				
				If DelimiterFound Then
					If i < StLen Then
						StartCh = i + 1
					Else
						EOL = True
					End If
					Exit For
					
					' If no match was found, append this character to those found following the
					' last delimiter.  In this way we build up the strings between the delimiters
					
				Else
					TempSt = TempSt & Mid(St, i, 1)
				End If
				
				' Make sure we recognize the end of the input string
				
				If i >= StLen Then
					DelimiterFound = True
					EOL = True
					Exit For
				End If
			Next i
			
			' See if the string found is numeric; if not, do not count it
			
			If Len(TempSt) > 0 And IsNumeric(TempSt) Then
				num = num + 1
				If TempSt = "" Then TempSt = "0."
				OutArray(num) = CDbl(TempSt)
			End If
			
			' Reset the flag and temporary string
			
			DelimiterFound = False
			TempSt = ""
			
			' Keep going until we find the end of the input string
			
		Loop 
		
		' Report our result
		
		ParseNumericString = num
		
	End Function
	
	' integer part with round-up
	Public Function Round(ByRef X As Object) As Short
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Round = Fix(X + 0.5 * System.Math.Sign(X))
		
	End Function
	
	' minimum of two number
	Public Function Min(ByRef A As Object, ByRef B As Object) As Double
		
		'UPGRADE_WARNING: Couldn't resolve default property of object B. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object A. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If (A < B) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object A. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Min = A
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object B. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Min = B
		End If
		
	End Function
	
	' maximum of two number
	Public Function Max(ByRef A As Object, ByRef B As Object) As Double
		
		'UPGRADE_WARNING: Couldn't resolve default property of object B. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object A. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If (A < B) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object B. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Max = B
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object A. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Max = A
		End If
		
	End Function
	
	' arcsine (-pi/2 to pi/2)
	Public Function Asin(ByRef X As Object) As Double
		
		If X = 1# Then
			Asin = PI / 2#
		ElseIf X = -1# Then 
			Asin = -PI / 2#
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Asin = System.Math.Atan(X / System.Math.Sqrt(-X * X + 1))
		End If
		
	End Function
	
	' arccosine (0 to pi)
	Public Function Acos(ByRef X As Object) As Double
		
		If X = 1# Then
			Acos = 0#
		ElseIf X = -1# Then 
			Acos = PI
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Acos = System.Math.Atan(-X / System.Math.Sqrt(-X * X + 1)) + PI / 2#
		End If
		
	End Function
	
	' angle determined by coordinate x and y (0 to 2pi) or (-pi to pi)
	Public Function Atan(ByRef X As Object, ByRef Y As Object, Optional ByRef NPi2Pi As Boolean = False) As Double
		
		If X > 0# Then
			If Y >= 0# Then
				'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Atan = System.Math.Atan(Y / X)
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Atan = 2# * PI + System.Math.Atan(Y / X)
			End If
		ElseIf X < 0# Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Atan = PI + System.Math.Atan(Y / X)
		Else
			If Y > 0# Then
				Atan = PI * 0.5
			ElseIf Y < 0# Then 
				Atan = PI * 1.5
			Else
				Atan = 0#
			End If
		End If
		
		If NPi2Pi And Atan > PI Then Atan = Atan - 2 * PI
		
	End Function
	
	' determine coefficients of cubic spline
	'Invalid_string_refer_to_original_code
	Public Sub Spline3(ByRef N As Short, ByRef X() As Double, ByRef A() As Double, ByRef B() As Double, ByRef c() As Double, ByRef D() As Double, ByRef Clamped As Boolean)
		
		' Input
		'   n -- number of spline segments
		'   x -- series of x value
		'   a -- series of a value (=f(x))
		'   clamped -  flag clamped end
		' Output
		'   b -- series of b value
		'   c -- series of c value
		'   d -- series of d value
		
		Dim i As Short
		Dim H(MaxPtNum) As Double
		Dim L(MaxPtNum) As Double
		Dim Al(MaxPtNum) As Double
		Dim Mu(MaxPtNum) As Double
		Dim z(MaxPtNum) As Double
		Dim Fpo, Fpn As Double
		
		For i = 1 To N
			H(i) = X(i + 1) - X(i)
		Next 
		
		If Clamped Then
			Fpo = 0#
			Fpn = 0#
			Al(1) = 3# * ((A(2) - A(1)) / H(1) - Fpo)
			Al(N + 1) = 3# * (Fpn - (A(N + 1) - A(N)) / H(N))
			
			L(1) = 2# * H(1)
			Mu(1) = 0.5
			z(1) = Al(1) / L(1)
		Else
			L(1) = 1#
			Mu(1) = 0#
			z(1) = 0#
		End If
		
		For i = 2 To N
			Al(i) = 3# * ((A(i + 1) - A(i)) / H(i) - (A(i) - A(i - 1)) / H(i - 1))
		Next 
		
		For i = 2 To N
			L(i) = 2# * (H(i) + H(i - 1)) - H(i - 1) * Mu(i - 1)
			Mu(i) = H(i) / L(i)
			z(i) = (Al(i) - H(i - 1) * z(i - 1)) / L(i)
		Next 
		
		If Clamped Then
			L(N + 1) = H(N) * (2# - Mu(N))
			z(N + 1) = (Al(N + 1) - H(N) * z(N)) / L(N + 1)
			c(N + 1) = z(N + 1)
			B(N + 1) = 0#
			D(N + 1) = 0#
		Else
			L(N + 1) = 1#
			z(N + 1) = 0#
			c(N + 1) = z(N + 1)
			B(N + 1) = 0#
			D(N + 1) = 0#
		End If
		
		For i = N To 1 Step -1
			c(i) = z(i) - Mu(i) * c(i + 1)
			B(i) = (A(i + 1) - A(i)) / H(i) - H(i) * (c(i + 1) + 2# * c(i)) / 3#
			D(i) = (c(i + 1) - c(i)) / (3# * H(i))
		Next 
		
	End Sub
	
	Public Sub GetDirNFileName(ByVal NewFullName As String, ByRef NewDir As String, ByRef NewFile As String)
		
		Dim DirChrPos, Pos, NameLen As Short
		Dim Valid As Boolean
		
		NameLen = Len(NewFullName)
		DirChrPos = NameLen
		Valid = True
		For Pos = NameLen To 1 Step -1
			Select Case Mid(NewFullName, Pos, 1)
				Case "\"
					DirChrPos = Pos
					Exit For
				Case "/", ":", "*", "?", "<", ">", "|", Chr(34)
					Valid = False
			End Select
		Next Pos
		
		If Valid Then
			NewFile = Right(NewFullName, NameLen - DirChrPos)
		Else
			NewFile = ""
		End If
		NewDir = Left(NewFullName, DirChrPos)
		
	End Sub
	
	Public Function getNoExtFileName(ByVal fname As String) As Object
		Dim Pos As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object Pos. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Pos = InStr(1, fname, ".")
		'UPGRADE_WARNING: Couldn't resolve default property of object Pos. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		getNoExtFileName = Left(fname, Pos - 1)
	End Function
	
	Public Function ScopeByHD(ByVal HD As Double, ByVal SprdAng As Double, ByVal FLX As Double, ByVal FLY As Double) As Double
		
		Dim Sc, Sb, Sa, Aa, Ab, Ac As Double
		
		Sb = HD
		If Sb = 0# Then
			Sc = Sa
		Else
			Sa = System.Math.Sqrt(FLX * FLX + FLY * FLY)
			Ab = PI - Atan(FLX, FLY) - SprdAng
			Aa = Asin(Sa / Sb * System.Math.Sin(Ab))
			If System.Math.Sin(Aa) = 0# Then
				Sc = Sa + Sb
			Else
				Ac = PI - Ab - Aa
				Sc = Sa * System.Math.Sin(Ac) / System.Math.Sin(Aa)
			End If
		End If
		ScopeByHD = Sc
		
	End Function
	
	Public Sub GetScopeSprd(ByRef Scope As Double, ByRef SprdAng As Double, ByVal HorDist As Double, ByVal SprdDir As Double, ByVal FLX As Double, ByVal FLY As Double)
		
		Dim Ax, Ay As Double
		
		Ax = HorDist * System.Math.Cos(-SprdDir) - FLX
		Ay = HorDist * System.Math.Sin(-SprdDir) - FLY
		
		Scope = System.Math.Sqrt(Ax ^ 2 + Ay ^ 2)
		If Scope > 0# Then
			SprdAng = PI * 2 - Atan(Ax, Ay)
		Else
			SprdAng = 0#
		End If
		
	End Sub
	
	Public Sub GetHorDist(ByRef HorDist As Double, ByRef SprdDir As Double, ByVal Scope As Double, ByVal SprdAng As Double, ByVal FLX As Double, ByVal FLY As Double)
		
		Dim Ax, Ay As Double
		
		Ax = Scope * System.Math.Cos(-SprdAng) + FLX
		Ay = Scope * System.Math.Sin(-SprdAng) + FLY
		
		HorDist = System.Math.Sqrt(Ax ^ 2 + Ay ^ 2)
		If HorDist > 0# Then
			SprdDir = PI * 2 - Atan(Ax, Ay)
		Else
			SprdDir = 0#
		End If
		
	End Sub
	
	'Public Sub TransformPoint(ByRef X As Double, ByRef Y As Double, _
	''                          Transformation As Integer)
	'Dim Alpha As Double, Rotation(1 To 2, 1 To 2) As Double
	'Dim V(1 To 2) As Double
	'Dim i As Integer
	'
	'    If Transformation = EarthToShip Then
	'
	'        Alpha = (PI / 2#) - XVessel(mHeading)
	'        Rotation(1, 1) = Cos(Alpha)
	'        Rotation(1, 2) = Sin(Alpha)
	'        Rotation(2, 1) = -Rotation(1, 2)
	'        Rotation(2, 2) = Rotation(1, 1)
	'
	'        V(mX) = X                       '- WellGlob(mX)
	'        V(MY) = Y                       '- WellGlob(mY)
	'
	'        X = Rotation(1, 1) * V(mX) + Rotation(1, 2) * V(MY)
	'        Y = Rotation(2, 1) * V(mX) + Rotation(2, 2) * V(MY)
	'
	'    ElseIf Transformation = ShipToEarth Then
	'
	'        Alpha = -((PI / 2#) - XVessel(mHeading))
	'        Rotation(1, 1) = Cos(Alpha)
	'        Rotation(1, 2) = Sin(Alpha)
	'        Rotation(2, 1) = -Rotation(1, 2)
	'        Rotation(2, 2) = Rotation(1, 1)
	'
	'        V(mX) = X
	'        V(MY) = Y
	'
	'        X = Rotation(1, 1) * V(mX) + Rotation(1, 2) * V(MY)     ' + WellGlob(mX)
	'        Y = Rotation(2, 1) * V(mX) + Rotation(2, 2) * V(MY)     ' + WellGlob(mY)
	'
	'    Else
	'        MsgBox "Internal Transformation Coordinate Code Error; Please report this error", _
	''                vbOKOnly, "MARS - Internal Program Error"
	'    End If
	'
	'End Sub
	
	Public Function Atn2(ByRef X As Object, ByRef Y As Object) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If X = 0 Then ' On Y-axis
			'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Y > 0 Then ' Positive Y-axis
				'UPGRADE_WARNING: Couldn't resolve default property of object Atn2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Atn2 = PI / 2#
				'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf Y < 0 Then  ' Negative Y-axis
				'UPGRADE_WARNING: Couldn't resolve default property of object Atn2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Atn2 = -PI / 2#
			Else ' (0,0) Point
				'UPGRADE_WARNING: Couldn't resolve default property of object Atn2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Atn2 = 0#
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ElseIf X > 0 And Y >= 0 Then  ' First quadrant
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Atn2 = System.Math.Atan(Y / X)
			'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ElseIf X < 0 And Y >= 0 Then  ' Second quadrant
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Atn2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Atn2 = PI - System.Math.Atan(-Y / X)
			'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ElseIf X < 0 And Y <= 0 Then  ' Third quadrant
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Atn2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Atn2 = System.Math.Atan(Y / X) + PI
		Else ' Fourth quadrant
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Atn2. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Atn2 = 2# * PI - System.Math.Atan(-Y / X)
		End If
	End Function
	
	Public Function RadTo360(ByRef X As Double) As Double
		Dim A As Double
		Dim t As Short
		A = X * 180 / PI
		t = A \ 360#
		A = A - (360 * t)
		If A < 0 Then
			A = A + 360#
		End If
		If System.Math.Abs(System.Math.Abs(A) - 360#) < 0.01 Then
			A = 0#
		End If
		RadTo360 = A
	End Function
	Public Function ZeroToTwoPi(ByRef X As Double) As Double
		' Reduce an angle to the range 0-2*Pi (no negatives allowed!)
		Dim A As Double
		Dim t As Short
		If X < 0 And X > -2# * PI Then
			A = X + 2# * PI
		Else
			t = X \ (2# * PI)
			A = X - (2# * PI * t)
			If A < 0 Then A = A + 2 * PI
		End If
		ZeroToTwoPi = A
	End Function
	
	Public Sub GetArrayElemRange(ByRef v1DArray() As Double, ByRef MaxElemVal As Double, ByRef MinElemVal As Double)
		' this sub loop thru input 1 dimensional array v1DArray, find and return its max and min element values
		Dim i As Integer
		Dim tmpMax, tmpMin As Double
		tmpMax = 0
		tmpMin = 1000000000
		For i = LBound(v1DArray) To UBound(v1DArray)
			If v1DArray(i) > tmpMax Then
				tmpMax = v1DArray(i)
			End If
			If v1DArray(i) < tmpMin Then
				tmpMin = v1DArray(i)
			End If
		Next i
		' return the range values
		MaxElemVal = tmpMax
		MinElemVal = tmpMin
	End Sub
End Module