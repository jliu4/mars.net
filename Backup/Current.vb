Option Strict Off
Option Explicit On
Friend Class Current
	Implements System.Collections.IEnumerable
	
	' current properties
	
	' properties
	' Heading:      current heading (N clock-wise)
	' WaterDepth:   water depth (ft)
	' Profile:      current profile
	' NewEnum:      get id for each profile
	
	' methods
	' ProfileAdd:   add profile
	' ProfileCount: count profile
	' ProfileDelete:delete profile
	
	Private msngHeading As Double
	Private msngWaterDepth As Double
	
	Private mcolProfile As Collection
	
	' initializing and terminating
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		
		mcolProfile = New Collection
		msngHeading = -PI
		
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	'UPGRADE_NOTE: Class_Terminate was upgraded to Class_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Terminate_Renamed()
		
		'UPGRADE_NOTE: Object mcolProfile may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		mcolProfile = Nothing
		
	End Sub
	Protected Overrides Sub Finalize()
		Class_Terminate_Renamed()
		MyBase.Finalize()
	End Sub
	
	' properties
	
	
	Public Property Heading() As Double
		Get
			
			Heading = msngHeading
			
		End Get
		Set(ByVal Value As Double)
			
			msngHeading = Value
			
		End Set
	End Property
	
	
	Public Property WaterDepth() As Double
		Get
			
			WaterDepth = msngWaterDepth
			
		End Get
		Set(ByVal Value As Double)
			
			msngWaterDepth = Value
			
		End Set
	End Property
	
	Public ReadOnly Property Profile(ByVal vntIndexKey As Object) As CurrentData
		Get
			
			Profile = mcolProfile.Item(vntIndexKey)
			
		End Get
	End Property
	
	'UPGRADE_NOTE: NewEnum property was commented out. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B3FC1610-34F3-43F5-86B7-16C984F0E88E"'
	'Public ReadOnly Property NewEnum() As stdole.IUnknown
		'Get
			'
			'NewEnum = mcolProfile._NewEnum
			'
		'End Get
	'End Property
	
	Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
		'UPGRADE_TODO: Uncomment and change the following line to return the collection enumerator. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="95F9AAD0-1319-4921-95F0-B9D3C4FF7F1C"'
		'GetEnumerator = mcolProfile.GetEnumerator
	End Function
	
	Public ReadOnly Property ProfileCount() As Integer
		Get
			
			ProfileCount = mcolProfile.Count()
			
		End Get
	End Property
	
	' methods
	
	Public Sub ProfileAdd(ByRef Depth As Double, ByRef Velocity As Double)
		
		' Input
		'   Depth:      water depth (ft)
		'   Velocity:   current velocity (ft/s)
		
		Dim NewProfile As New CurrentData
		
		With NewProfile
			'       start from water surface
			If mcolProfile.Count() = 0 And Depth <> 0# Then
				.Depth = 0#
				.Velocity = Velocity
				mcolProfile.Add(NewProfile)
			End If
			
			.Depth = Depth
			.Velocity = Velocity
		End With
		
		mcolProfile.Add(NewProfile)
		
	End Sub
	
	Public Sub ProfileDelete(ByRef vntIndexKey As Object)
		
		mcolProfile.Remove(vntIndexKey)
		
	End Sub
End Class