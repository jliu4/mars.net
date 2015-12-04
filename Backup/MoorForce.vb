Option Strict Off
Option Explicit On
Friend Class Force
	
	' force components
	
	' properties
	' Ft:           total horizontal force (lbs)
	' Fx:           force in x direction (lbs)
	' Fy:           force in y direction (lbs)
	' MYaw:         yaw moment (count-clockwise) (lbs-ft)
	
	Private msngFx As Double
	Private msngFy As Double
	Private msngMYaw As Double
	
	Public ReadOnly Property Ft() As Double
		Get
			
			Ft = System.Math.Sqrt(msngFx ^ 2 + msngFy ^ 2)
			
		End Get
	End Property
	
	
	Public Property Fx() As Double
		Get
			
			Fx = msngFx
			
		End Get
		Set(ByVal Value As Double)
			
			msngFx = Value
			
		End Set
	End Property
	
	
	Public Property Fy() As Double
		Get
			
			Fy = msngFy
			
		End Get
		Set(ByVal Value As Double)
			
			msngFy = Value
			
		End Set
	End Property
	
	
	Public Property MYaw() As Double
		Get
			
			MYaw = msngMYaw
			
		End Get
		Set(ByVal Value As Double)
			
			msngMYaw = Value
			
		End Set
	End Property
End Class