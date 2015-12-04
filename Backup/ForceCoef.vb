Option Strict Off
Option Explicit On
Friend Class ForceCoef
	
	' force coefficient (0 - 180 deg even spacing) in ship local system
	'Invalid_string_refer_to_original_code
	
	' properties
	' ClampedEnd:   end type of force coeficients curve
	' ForceCoef:    get force coefficient by interpolation
	
	' methods
	' ForceCoefAdd: add force coefficient
	
	Private mblnClamped As Boolean
	Private mcolForceCoef As Collection
	
	Private Const MaxCoefNum As Short = 37
	
	' initializing and terminating
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		
		mcolForceCoef = New Collection
		
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	'UPGRADE_NOTE: Class_Terminate was upgraded to Class_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Terminate_Renamed()
		
		'UPGRADE_NOTE: Object mcolForceCoef may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		mcolForceCoef = Nothing
		
	End Sub
	Protected Overrides Sub Finalize()
		Class_Terminate_Renamed()
		MyBase.Finalize()
	End Sub
	
	' properties
	
	Public WriteOnly Property ClampedEnd() As Boolean
		Set(ByVal Value As Boolean)
			
			mblnClamped = Value
			
		End Set
	End Property
	
	Public ReadOnly Property ForceCoef_Renamed(ByVal Direction As Double) As Double
		Get
			
			' Input
			'   Direction:  look-up direction in vessel local system
			
			Dim N, i, Ns As Short
			Dim DFc, FS, dx As Double
			
			Dim X(MaxCoefNum) As Double
			Dim A(MaxCoefNum) As Double
			Dim B(MaxCoefNum) As Double
			Dim C(MaxCoefNum) As Double
			Dim D(MaxCoefNum) As Double
			
			'   direction in 0 - 2 pi range
			Do While Direction < 0#
				Direction = 2# * PI + Direction
			Loop 
			
			Do While Direction > 2# * PI
				Direction = Direction - 2# * PI
			Loop 
			
			'   if direction > pi, make mirror
			FS = 1#
			If Direction > PI Then
				Direction = 2# * PI - Direction
				If Not mblnClamped Then FS = -1#
			End If
			
			'   initiate array
			N = mcolForceCoef.Count()
			Ns = 0
			For i = N To 1 Step -1
				X(i) = (i - 1#) * PI / (N - 1#)
				'UPGRADE_WARNING: Couldn't resolve default property of object mcolForceCoef(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				A(i) = mcolForceCoef.Item(i)
				If Direction >= X(i) And Ns = 0 Then Ns = i
			Next 
			If FS = -1# Then
				DFc = A(1) + (A(N) - A(1)) * Direction / PI
			Else
				DFc = 0#
			End If
			
			'   interpolate by spline
			dx = Direction - X(Ns)
			If dx = 0# Then
				ForceCoef = FS * (A(Ns) - DFc) + DFc
			Else
				Call Spline3(N - 1, X, A, B, C, D, mblnClamped)
				ForceCoef = FS * (A(Ns) + B(Ns) * dx + C(Ns) * dx ^ 2 + D(Ns) * dx ^ 3 - DFc) + DFc
			End If
			
		End Get
	End Property
	
	' methodes
	
	Public Sub ForceCoefAdd(ByVal FC As Double)
		
		' Input
		'   FC:         force coefficient
		
		mcolForceCoef.Add(FC)
		
	End Sub
End Class