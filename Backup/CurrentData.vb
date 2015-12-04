Option Strict Off
Option Explicit On
Friend Class CurrentData
	
	' current profile data
	
	' properties
	' Depth:        water depth (ft)
	' Velocity:     current velocity (ft/s)
	
	Private msngDepth As Double
	Private msngVelocity As Double
	
	
	Public Property Depth() As Double
		Get
			
			Depth = msngDepth
			
		End Get
		Set(ByVal Value As Double)
			
			msngDepth = Value
			
		End Set
	End Property
	
	
	Public Property Velocity() As Double
		Get
			
			Velocity = msngVelocity
			
		End Get
		Set(ByVal Value As Double)
			
			msngVelocity = Value
			
		End Set
	End Property
End Class