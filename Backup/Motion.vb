Option Strict Off
Option Explicit On
Friend Class Motion
	
	' motion components
	
	' properties
	' Move:         total movement (ft)
	' Surge:        move in surge direction (ft)
	' Sway:         move in sway direction (ft)
	' Yaw:          yaw movement (rad)
	
	Private msngSurge As Double
	Private msngSway As Double
	Private msngYaw As Double
	
	Public ReadOnly Property Move() As Double
		Get
			
			Move = System.Math.Sqrt(msngSurge ^ 2 + msngSway ^ 2)
			
		End Get
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