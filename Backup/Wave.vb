Option Strict Off
Option Explicit On
Friend Class Wave
	
	' wave properties
	
	' properties
	' Heading:      wave heading (N clockwise) (rad)
	' Height:       wave height (significant) (ft)
	' Period:       wave period (peak) (sec)
	' Frequency:    wave frequency (peak)
	' Spectrum:     wave spectrum value
	
	' functions
	' ISSC:         calculations of spectrum
	
	Private msngHeading As Double
	Private msngHeight As Double
	Private msngPeriod As Double
	Private msngFrequency As Double
	
	
	Public Property Heading() As Double
		Get
			
			Heading = msngHeading
			
		End Get
		Set(ByVal Value As Double)
			
			msngHeading = Value
			
		End Set
	End Property
	
	
	Public Property Height() As Double
		Get
			
			Height = msngHeight
			
		End Get
		Set(ByVal Value As Double)
			
			msngHeight = Value
			
		End Set
	End Property
	
	
	Public Property Period() As Double
		Get
			
			Period = msngPeriod
			
		End Get
		Set(ByVal Value As Double)
			
			msngPeriod = Value
			If msngPeriod = 0# Then
				msngFrequency = 10000000000#
			Else
				msngFrequency = 2# * PI / msngPeriod
			End If
			
		End Set
	End Property
	
	Public ReadOnly Property Frequency() As Double
		Get
			
			Frequency = msngFrequency
			
		End Get
	End Property
	
	Public ReadOnly Property Spectrum(ByVal Frequency As Double) As Double
		Get
			
			' Input
			'   Frequency:  look-up wave frequency
			
			Spectrum = ISSC(Frequency)
			
		End Get
	End Property
	
	' functions
	
	'wave spectrum ISSC
	Private Function ISSC(ByRef w As Double) As Double
		
		' Input
		'   w:          wave frequency
		
		Dim B1, A1, wp As Double
		
		If w = 0# Then
			ISSC = 0#
		Else
			wp = msngFrequency
			If wp = 0# Then
				A1 = 0#
			Else
				A1 = ((0.3125 * msngHeight ^ 2) / wp)
			End If
			If w = 0# Then
				B1 = 0#
			Else
				B1 = wp / w
			End If
			
			ISSC = A1 * B1 ^ 5 * System.Math.Exp(-1.25 * B1 ^ 4)
		End If
		
	End Function
End Class