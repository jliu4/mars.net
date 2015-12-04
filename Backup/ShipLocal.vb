Option Strict Off
Option Explicit On
Friend Class ShipLocal
	
	' ship in local coordinates
	
	' properties
	' Heading:      ship heading (N - clockwise, 0 - 2 pi) (rad)
	' Surge:        surge from well head (fwd) (ft)
	' Sway:         sway from well head (port) (ft)
	' Yaw:          yaw from design heading (count-clockwise) (rad)
	
	Private msngHead As Double
	Private msngSurge As Double
	Private msngSway As Double
	Private msngYaw As Double
	
	
	Public Property Heading() As Double
		Get
			
			Heading = msngHead
			
		End Get
		Set(ByVal Value As Double)
			
			msngHead = Value
			
		End Set
	End Property
	
	
	Public Property Surge() As Double
		Get
			
			Surge = msngSurge
			
		End Get
		Set(ByVal Value As Double)
			
			msngSurge = Value
			
		End Set
	End Property
	
	
	Public Property Sway() As Double
		Get
			
			Sway = msngSway
			
		End Get
		Set(ByVal Value As Double)
			
			msngSway = Value
			
		End Set
	End Property
	
	
	Public Property Yaw() As Double
		Get
			
			Yaw = msngYaw
			
		End Get
		Set(ByVal Value As Double)
			
			msngYaw = Value
			
		End Set
	End Property
End Class