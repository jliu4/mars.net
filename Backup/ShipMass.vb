Option Strict Off
Option Explicit On
Friend Class ShipMass
	
	' ship mass and added mass
	
	' properties
	' Draft:        ship draft (ft)
	
	' MassSurge:    mass in surge direction (slug)
	' MassSway:     mass in sway direction (slug)
	'Invalid_string_refer_to_original_code
	
	' AddMassSurge: added mass in surge direction (slug)
	' AddMassSway:  added mass in sway direction (slug)
	'Invalid_string_refer_to_original_code
	
	' VirMassSurge: virtual mass in surge direction (slug)
	' VirMassSway:  virtual mass in sway direction (slug)
	'Invalid_string_refer_to_original_code
	
	Private msngDraft As Double
	
	Private msngMassSurge As Double
	Private msngMassSway As Double
	Private msngMassYaw As Double
	
	Private msngAddMassSurge As Double
	Private msngAddMassSway As Double
	Private msngAddMassYaw As Double
	
	
	Public Property Draft() As Double
		Get
			
			Draft = msngDraft
			
		End Get
		Set(ByVal Value As Double)
			
			msngDraft = Value
			
		End Set
	End Property
	
	
	Public Property MassSurge() As Double
		Get
			
			MassSurge = msngMassSurge
			
		End Get
		Set(ByVal Value As Double)
			
			msngMassSurge = Value
			
		End Set
	End Property
	
	
	Public Property MassSway() As Double
		Get
			
			MassSway = msngMassSway
			
		End Get
		Set(ByVal Value As Double)
			
			msngMassSway = Value
			
		End Set
	End Property
	
	
	Public Property MassYaw() As Double
		Get
			
			MassYaw = msngMassYaw
			
		End Get
		Set(ByVal Value As Double)
			
			msngMassYaw = Value
			
		End Set
	End Property
	
	
	
	Public Property AddMassSurge() As Double
		Get
			
			AddMassSurge = msngAddMassSurge
			
		End Get
		Set(ByVal Value As Double)
			
			msngAddMassSurge = Value
			
		End Set
	End Property
	
	
	Public Property AddMassSway() As Double
		Get
			
			AddMassSway = msngAddMassSway
			
		End Get
		Set(ByVal Value As Double)
			
			msngAddMassSway = Value
			
		End Set
	End Property
	
	
	Public Property AddMassYaw() As Double
		Get
			
			AddMassYaw = msngAddMassYaw
			
		End Get
		Set(ByVal Value As Double)
			
			msngAddMassYaw = Value
			
		End Set
	End Property
	
	Public ReadOnly Property VirMassSurge() As Double
		Get
			
			VirMassSurge = msngMassSurge + msngAddMassSurge
			
		End Get
	End Property
	
	Public ReadOnly Property VirMassSway() As Double
		Get
			
			VirMassSway = msngMassSway + msngAddMassSway
			
		End Get
	End Property
	
	Public ReadOnly Property VirMassYaw() As Double
		Get
			
			VirMassYaw = msngMassYaw + msngAddMassYaw
			
		End Get
	End Property
End Class