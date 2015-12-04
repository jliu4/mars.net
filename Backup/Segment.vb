Option Strict Off
Option Explicit On
Friend Class Segment
	
	' mooring line segment data
	
	' properties
	' (input)
	' SegType:      CHAIN, WIRE, POLYESTER, SPRING
	' Length:       segment length (ft)
	' Diameter:     segment diameter (in)
	' TotalLength:  total available length (ft)
	' BS:           breaking strength (lbs)
	' E1:           elastic modulus (1st) (psi)
	' E2:           elastic modulus (2nd, for nolinear segment) (psi)
	' UnitDryWeight:weight in air (lbs/ft)
	' UnitWetWeight:Weight in water (lbs/ft)
	' Buoy:         net buoyancy of buoy at the end of segment (lbs)
	' BuoyLength:   buoy length (ft)
	' FrictionCoef: friction coefficient of segment to the sea bottom
	
	' (calculated)
	'Invalid_string_refer_to_original_code
	' TotalWeight:  total wet weight of the segment (lbs)
	' LengthStr:    stretched length due to tension (ft)
	' XLow:         lower end scope (ft)
	' YLow:         lower end depth (ft)
	' AngUpp:       upper end angle (to horizon) (rad)
	' AngLow:       lower end angle (to horizon) (rad)
	' TenUpp:       upper end tension (lbs)
	
	Private mstrSegType As String
	Private msngLength As Double
	Private msngTotalLength As Double
	Private msngDiameter As Double
	Private msngBS As Double
	Private msngE1 As Double
	Private msngE2 As Double
	Private msngUnitDryWeight As Double
	Private msngUnitWetWeight As Double
	Private msngBuoy As Double
	Private msngBuoyLength As Double
	Private msngFrictionCoef As Double
	
	Private msngLengthStr As Double
	Private msngXLow As Double
	Private msngYLow As Double
	Private msngAngUpp As Double
	Private msngAngLow As Double
	Private msngTenUpp As Double
	
	' properties as input
	
	
	Public Property SegType() As String
		Get
			
			SegType = mstrSegType
			
		End Get
		Set(ByVal Value As String)
			
			mstrSegType = Value
			
		End Set
	End Property
	
	
	Public Property Length() As Double
		Get
			
			Length = msngLength
			
		End Get
		Set(ByVal Value As Double)
			
			msngLength = Value
			msngLengthStr = Value
			
		End Set
	End Property
	
	
	Public Property TotalLength() As Double
		Get
			
			If msngTotalLength = 0# Then msngTotalLength = msngLength
			TotalLength = msngTotalLength
			
		End Get
		Set(ByVal Value As Double)
			
			msngTotalLength = Value
			
		End Set
	End Property
	
	
	Public Property Diameter() As Double
		Get
			
			Diameter = msngDiameter
			
		End Get
		Set(ByVal Value As Double)
			
			msngDiameter = Value
			
		End Set
	End Property
	
	
	Public Property BS() As Double
		Get
			
			BS = msngBS
			
		End Get
		Set(ByVal Value As Double)
			
			msngBS = Value
			
		End Set
	End Property
	
	
	Public Property E1() As Double
		Get
			
			E1 = msngE1
			
		End Get
		Set(ByVal Value As Double)
			
			msngE1 = Value
			
		End Set
	End Property
	
	
	Public Property E2() As Double
		Get
			
			E2 = msngE2
			
		End Get
		Set(ByVal Value As Double)
			
			msngE2 = Value
			
		End Set
	End Property
	
	
	Public Property UnitDryWeight() As Double
		Get
			
			UnitDryWeight = msngUnitDryWeight
			
		End Get
		Set(ByVal Value As Double)
			
			msngUnitDryWeight = Value
			
		End Set
	End Property
	
	
	Public Property UnitWetWeight() As Double
		Get
			
			UnitWetWeight = msngUnitWetWeight
			
		End Get
		Set(ByVal Value As Double)
			
			msngUnitWetWeight = Value
			
		End Set
	End Property
	
	
	Public Property Buoy() As Double
		Get
			
			Buoy = msngBuoy
			
		End Get
		Set(ByVal Value As Double)
			
			msngBuoy = Value
			
		End Set
	End Property
	
	
	Public Property BuoyLength() As Double
		Get
			
			BuoyLength = msngBuoyLength
			
		End Get
		Set(ByVal Value As Double)
			
			msngBuoyLength = Value
			
		End Set
	End Property
	
	
	Public Property FrictionCoef() As Double
		Get
			
			FrictionCoef = msngFrictionCoef
			
		End Get
		Set(ByVal Value As Double)
			
			msngFrictionCoef = Value
			
		End Set
	End Property
	
	' properties as calculated
	
	Public ReadOnly Property XArea() As Double
		Get
			
			XArea = PI * msngDiameter ^ 2 / 4#
			
		End Get
	End Property
	
	Public ReadOnly Property TotalWeight() As Double
		Get
			
			TotalWeight = msngLength * msngUnitWetWeight
			
		End Get
	End Property
	
	
	Public Property LengthStr() As Double
		Get
			
			LengthStr = msngLengthStr
			
		End Get
		Set(ByVal Value As Double)
			
			msngLengthStr = Value
			'    If msngLengthStr < msngLength Then msngLengthStr = msngLength
			
		End Set
	End Property
	
	
	Public Property XLow() As Double
		Get
			
			XLow = msngXLow
			
		End Get
		Set(ByVal Value As Double)
			
			msngXLow = Value
			
		End Set
	End Property
	
	
	Public Property YLow() As Double
		Get
			
			YLow = msngYLow
			
		End Get
		Set(ByVal Value As Double)
			
			msngYLow = Value
			
		End Set
	End Property
	
	
	Public Property AngUpp() As Double
		Get
			
			AngUpp = msngAngUpp
			
		End Get
		Set(ByVal Value As Double)
			
			msngAngUpp = Value
			
		End Set
	End Property
	
	
	Public Property AngLow() As Double
		Get
			
			AngLow = msngAngLow
			
		End Get
		Set(ByVal Value As Double)
			
			msngAngLow = Value
			
		End Set
	End Property
	
	
	Public Property TenUpp() As Double
		Get
			
			TenUpp = msngTenUpp
			
		End Get
		Set(ByVal Value As Double)
			
			msngTenUpp = Value
			
		End Set
	End Property
End Class