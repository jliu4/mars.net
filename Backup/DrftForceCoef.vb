Option Strict Off
Option Explicit On
Friend Class DrftForceCoef
	
	' drift force coefficient (0 - 180 deg even spacing) in ship local system
	
	' properties
	' Draft:        vessel draft (ft)
	' DrftFC:       drift force coefficient
	' DrftFCItem:   drift force coefficients at input frequency
	
	' methods
	' DrftFCAdd:    add drift force coefficients
	
	Private msngDraft As Double
	Private mcolDrftFC As Collection
	
	' initializing and terminating
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		
		mcolDrftFC = New Collection
		
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	'UPGRADE_NOTE: Class_Terminate was upgraded to Class_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Terminate_Renamed()
		
		'UPGRADE_NOTE: Object mcolDrftFC may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		mcolDrftFC = Nothing
		
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
	
	Public ReadOnly Property DrftFC(ByVal Frequency As Double, ByVal Direction As Double) As Force
		Get
			
			' Input
			'   Frequency:  look-up wave frequency
			'   Direction:  look-up wave direction in vessel local system (rad)
			
			Dim N, i, Ns As Short
			Dim Rf As Double
			Dim Fy1, Fx1, Fm1 As Double
			Dim Fy2, Fx2, Fm2 As Double
			Dim FC As Force
			FC = New Force
			
			N = mcolDrftFC.Count()
			
			If N = 1 Then
				With FC
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					.Fx = mcolDrftFC.Item(1).FCx.ForceCoef(Direction)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCy. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					.Fy = mcolDrftFC.Item(1).FCy.ForceCoef(Direction)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCm. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					.MYaw = mcolDrftFC.Item(1).FCm.ForceCoef(Direction)
				End With
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC(1).Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf Frequency <= mcolDrftFC.Item(1).Freq Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Rf = Frequency / mcolDrftFC.Item(1).Freq
				With mcolDrftFC.Item(1)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					FC.Fx = .FCx.ForceCoef(Direction) * Rf
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCy. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					FC.Fy = .FCy.ForceCoef(Direction) * Rf
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCm. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					FC.MYaw = .FCm.ForceCoef(Direction) * Rf
				End With
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC(N).Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf Frequency >= mcolDrftFC.Item(N).Freq Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Rf = mcolDrftFC.Item(N).Freq / Frequency
				With mcolDrftFC.Item(N)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					FC.Fx = .FCx.ForceCoef(Direction) * Rf
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCy. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					FC.Fy = .FCy.ForceCoef(Direction) * Rf
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCm. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					FC.MYaw = .FCm.ForceCoef(Direction) * Rf
				End With
			Else
				For i = 2 To N
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC(i).Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If Frequency < mcolDrftFC.Item(i).Freq Then
						Ns = i
						Exit For
					End If
				Next 
				With mcolDrftFC.Item(Ns - 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Fx1 = .FCx.ForceCoef(Direction)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCy. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Fy1 = .FCy.ForceCoef(Direction)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCm. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Fm1 = .FCm.ForceCoef(Direction)
				End With
				With mcolDrftFC.Item(Ns)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Fx2 = .FCx.ForceCoef(Direction)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCy. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Fy2 = .FCy.ForceCoef(Direction)
					'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().FCm. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Fm2 = .FCm.ForceCoef(Direction)
				End With
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC(Ns - 1).Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC(Ns).Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolDrftFC().Freq. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Rf = (Frequency - mcolDrftFC.Item(Ns - 1).Freq) / (mcolDrftFC.Item(Ns).Freq - mcolDrftFC.Item(Ns - 1).Freq)
				With FC
					.Fx = Fx1 + (Fx2 - Fx1) * Rf
					.Fy = Fy1 + (Fy2 - Fy1) * Rf
					.MYaw = Fm1 + (Fm2 - Fm1) * Rf
				End With
			End If
			
			DrftFC = FC
			
		End Get
	End Property
	
	Public ReadOnly Property DrftFCItem(ByVal vntIndexKey As Object) As DrftFCbyFreq
		Get
			
			DrftFCItem = mcolDrftFC.Item(vntIndexKey)
			
		End Get
	End Property
	
	' methods
	
	Public Sub DrftFCAdd(ByRef Frequency As Double)
		
		' Input
		'   Frequency:  wave frequency of new set of drift coefficients
		
		Dim NewDrftFC As New DrftFCbyFreq
		
		NewDrftFC.Freq = Frequency
		
		mcolDrftFC.Add(NewDrftFC)
		
	End Sub
End Class