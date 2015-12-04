Option Strict Off
Option Explicit On
Friend Class ShipDamp
	
	' ship linear damping of LFM
	
	' properties
	' Draft:        ship draft (ft)
	' DampSurge:    damping in surge direction (lbs/(ft/s))
	' DampSway:     damping in sway direction (lbs/(ft/s))
	' DampYaw:      damping in yaw direction (lbs/(ft/s))
	
	Private msngDraft As Double
	
	Private msngDampSurge As Double
	Private msngDampSway As Double
	Private msngDampYaw As Double
	
	
	Public Property Draft() As Double
		Get
			
			Draft = msngDraft
			
		End Get
		Set(ByVal Value As Double)
			
			msngDraft = Value
			
		End Set
	End Property
	
	
	Public Property DampSurge() As Double
		Get
			
			DampSurge = msngDampSurge
			
		End Get
		Set(ByVal Value As Double)
			
			msngDampSurge = Value
			
		End Set
	End Property
	
	
	Public Property DampSway() As Double
		Get
			
			DampSway = msngDampSway
			
		End Get
		Set(ByVal Value As Double)
			
			msngDampSway = Value
			
		End Set
	End Property
	
	
	Public Property DampYaw() As Double
		Get
			
			DampYaw = msngDampYaw
			
		End Get
		Set(ByVal Value As Double)
			
			msngDampYaw = Value
			
		End Set
	End Property
End Class