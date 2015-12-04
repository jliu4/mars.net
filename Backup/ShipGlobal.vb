Option Strict Off
Option Explicit On
Friend Class ShipGlobal
	
	' ship in global coordinates
	
	' properties
	' Heading:      ship heading (N - clockwise, 0 - 2 pi) (rad)
	' Xg:           x coordinate in global system (E) (ft)
	' Yg:           y coordinate in global system (N) (ft)
	
	Private msngHead As Double
	Private msngXg As Double
	Private msngYg As Double
	
	
	Public Property Heading() As Double
		Get
			
			Heading = msngHead
			
		End Get
		Set(ByVal Value As Double)
			
			msngHead = Value
			msngHead = msngHead - Fix(msngHead / (PI * 2)) * PI * 2
			
			'    Do While msngHead >= PI * 2
			'        msngHead = msngHead + PI * 2
			'    Loop
			'    Do While msngHead < 0#
			'        msngHead = msngHead + PI * 2
			'    Loop
			
		End Set
	End Property
	
	
	Public Property Xg() As Double
		Get
			
			Xg = msngXg
			
		End Get
		Set(ByVal Value As Double)
			
			msngXg = Value
			
		End Set
	End Property
	
	
	Public Property Yg() As Double
		Get
			
			Yg = msngYg
			
		End Get
		Set(ByVal Value As Double)
			
			msngYg = Value
			
		End Set
	End Property
End Class