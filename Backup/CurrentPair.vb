Option Strict Off
Option Explicit On
Friend Class CurrentPair
	' Properties of the class
	Private msngDepth As Double
	Private msngVelocity As Double
	Private mintPairNum As Short
	
	
	Public Property PairNum() As Short
		Get
			PairNum = mintPairNum
		End Get
		Set(ByVal Value As Short)
			Static blnAlreadySet As Boolean
			If Not blnAlreadySet Then
				blnAlreadySet = True
				mintPairNum = Value
			Else
				Err.Raise(Number:=vbObjectError + 32107, Description:="Depth/Velocity" & CStr(Value) & " already defined.")
			End If
		End Set
	End Property
	
	
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