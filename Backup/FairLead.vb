Option Strict Off
Option Explicit On
Friend Class FairLead
	
	' fairlead locations
	
	' properties
	' NeedUpdate:   coordinates changed
	' SprdAngle:    designed spreading angle (0 - 2 pi) (rad)
	' Xg:           x coordinate in global system (ft)
	' Xs:           x coordinate in ship system (ft)
	' Yg:           y coordinate in global system (ft)
	' Ys:           y coordinate in ship system (ft)
	' Z:            z coordinate (above bl of ship) (ft)
	
	Private mblnNeedUpdate As Boolean
	Private msngSprdAngle As Double
	Private msngXs As Double
	Private msngYs As Double
	Private msngZ As Double
	
	
	Friend Property NeedUpdate() As Boolean
		Get
			
			NeedUpdate = mblnNeedUpdate
			
		End Get
		Set(ByVal Value As Boolean)
			
			mblnNeedUpdate = Value
			
		End Set
	End Property
	
	
	Public Property SprdAngle() As Double
		Get
			
			SprdAngle = msngSprdAngle
			
		End Get
		Set(ByVal Value As Double)
			
			msngSprdAngle = Value
			
		End Set
	End Property
	
	Public ReadOnly Property Xg(ByVal ShipGlob As ShipGlobal) As Double
		Get
			If ShipGlob Is Nothing Then Exit Sub
			
			' Input
			'   ShipGlob:   ship coordinates and heading in global system (N-E)
			
			Dim Alpha As Double
			
			Alpha = PI / 2# - ShipGlob.Heading
			
			Xg = System.Math.Cos(Alpha) * msngXs - System.Math.Sin(Alpha) * msngYs + ShipGlob.Xg
			
		End Get
	End Property
	
	
	Public Property Xs() As Double
		Get
			
			Xs = msngXs
			
		End Get
		Set(ByVal Value As Double)
			
			msngXs = Value
			mblnNeedUpdate = True
			
		End Set
	End Property
	
	Public ReadOnly Property Yg(ByVal ShipGlob As ShipGlobal) As Double
		Get
			If ShipGlob Is Nothing Then Exit Sub
			
			' Input
			'   ShipGlob:   ship coordinates and heading in global system (N-E)
			
			Dim Alpha As Double
			
			Alpha = PI / 2# - ShipGlob.Heading
			
			Yg = System.Math.Sin(Alpha) * msngXs + System.Math.Cos(Alpha) * msngYs + ShipGlob.Yg
			
		End Get
	End Property
	
	
	Public Property Ys() As Double
		Get
			
			Ys = msngYs
			
		End Get
		Set(ByVal Value As Double)
			
			msngYs = Value
			mblnNeedUpdate = True
			
		End Set
	End Property
	
	
	Public Property z() As Double
		Get
			
			z = msngZ
			
		End Get
		Set(ByVal Value As Double)
			
			msngZ = Value
			
		End Set
	End Property
End Class