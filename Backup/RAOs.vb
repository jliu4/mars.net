Option Strict Off
Option Explicit On
Friend Class RAOs
	
	' r.a.o.s (0 - 180 deg even spacing) in ship local system
	
	' properties
	' Draft:    vessel draft (ft)
	' RAO:      motion RAO
	' RAOsItem: motion RAOs at input frequency
	
	' methods
	' RAOsAdd:  add RAOs
	
	Private msngDraft As Double
	Private mcolRAOs As Collection
	
	' initializing and terminating
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		
		mcolRAOs = New Collection
		
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	'UPGRADE_NOTE: Class_Terminate was upgraded to Class_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Terminate_Renamed()
		
		'UPGRADE_NOTE: Object mcolRAOs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		mcolRAOs = Nothing
		
	End Sub
	Protected Overrides Sub Finalize()
		Class_Terminate_Renamed()
		MyBase.Finalize()
	End Sub
	
	' properties
	
	
	Public Property Draft() As Double
		Get
			
			Draft = msngDraft
			
		End Get
		Set(ByVal Value As Double)
			
			msngDraft = Value
			
		End Set
	End Property
	
	Public ReadOnly Property RAO(ByVal Frequency As Double, ByVal Direction As Double) As Motion
		Get
			
			' Input
			'   Frequency:  look-up wave frequency
			'   Direction:  look-up wave direction in vessel local system
			
			Dim N, i, Ns As Short
			Dim Rf As Double
			Dim Ry1, Rx1, Rr1 As Double
			Dim Ry2, Rx2, Rr2 As Double
			Dim r As New Motion
			
			N = mcolRAOs.Count()
			
			If N = 1 Then
				With r
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					.Surge = mcolRAOs.Item(1).RAOx.ForceCoef(Direction)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOy. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					.Sway = mcolRAOs.Item(1).RAOy.ForceCoef(Direction)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					.Yaw = mcolRAOs.Item(1).RAOr.ForceCoef(Direction)
				End With
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs(1).Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf Frequency <= mcolRAOs.Item(1).Freq Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Rf = Frequency / mcolRAOs.Item(1).Freq
				With mcolRAOs.Item(1)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					r.Surge = .RAOx.ForceCoef(Direction) * Rf
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOy. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					r.Sway = .RAOy.ForceCoef(Direction) * Rf
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					r.Yaw = .RAOr.ForceCoef(Direction) * Rf
				End With
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs(N).Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf Frequency >= mcolRAOs.Item(N).Freq Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Rf = mcolRAOs.Item(N).Freq / Frequency
				With mcolRAOs.Item(N)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					r.Surge = .RAOx.ForceCoef(Direction) * Rf
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOy. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					r.Sway = .RAOy.ForceCoef(Direction) * Rf
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					r.Yaw = .RAOr.ForceCoef(Direction) * Rf
				End With
			Else
				For i = 2 To N
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs(i).Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If Frequency < mcolRAOs.Item(i).Freq Then
						Ns = i
						Exit For
					End If
				Next 
				With mcolRAOs.Item(Ns - 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Rx1 = .RAOx.ForceCoef(Direction)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOy. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Ry1 = .RAOy.ForceCoef(Direction)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Rr1 = .RAOr.ForceCoef(Direction)
				End With
				With mcolRAOs.Item(Ns)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Rx2 = .RAOx.ForceCoef(Direction)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOy. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Ry2 = .RAOy.ForceCoef(Direction)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().RAOr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Rr2 = .RAOr.ForceCoef(Direction)
				End With
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs(Ns - 1).Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs(Ns).Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolRAOs().Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Rf = (Frequency - mcolRAOs.Item(Ns - 1).Freq) / (mcolRAOs.Item(Ns).Freq - mcolRAOs.Item(Ns - 1).Freq)
				With r
					.Surge = Rx1 + (Rx2 - Rx1) * Rf
					.Sway = Ry1 + (Ry2 - Ry1) * Rf
					.Yaw = Rr1 + (Rr2 - Rr1) * Rf
				End With
			End If
			
			RAO = r
			
		End Get
	End Property
	
	Public ReadOnly Property RAOsItem(ByVal vntIndexKey As Object) As RAObyFreq
		Get
			
			RAOsItem = mcolRAOs.Item(vntIndexKey)
			
		End Get
	End Property
	
	' methods
	
	Public Sub RAOsAdd(ByRef Frequency As Double)
		
		' Input
		'   Frequency:  wave frequency of a set of new raos
		
		Dim NewRAOs As New RAObyFreq
		
		NewRAOs.Freq = Frequency
		
		mcolRAOs.Add(NewRAOs)
		
	End Sub
End Class