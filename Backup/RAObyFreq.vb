Option Strict Off
Option Explicit On
Friend Class RAObyFreq
	
	' r.a.o.s (0 - 180 deg even spacing) in ship local system
	' by frequency
	
	' properties
	' Freq:         wave frequency
	' RAOx:         r.a.o.s in x direction (surge) (ft/ft)
	' RAOy:         r.a.o.s in y direction (sway) (ft/ft)
	' RAOr:         r.a.o.s in yaw direction (rad/ft)
	
	Private msngFreq As Double
	Private mclsRAOx As ForceCoef
	Private mclsRAOy As ForceCoef
	Private mclsRAOr As ForceCoef
	
	' initializing and terminating
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		
		mclsRAOx = New ForceCoef
		mclsRAOy = New ForceCoef
		mclsRAOr = New ForceCoef
		
		mclsRAOx.ClampedEnd = True
		mclsRAOy.ClampedEnd = False
		mclsRAOr.ClampedEnd = False
		
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	'UPGRADE_NOTE: Class_Terminate was upgraded to Class_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Terminate_Renamed()
		
		'UPGRADE_NOTE: Object mclsRAOx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		mclsRAOx = Nothing
		'UPGRADE_NOTE: Object mclsRAOy may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		mclsRAOy = Nothing
		'UPGRADE_NOTE: Object mclsRAOr may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		mclsRAOr = Nothing
		
	End Sub
	Protected Overrides Sub Finalize()
		Class_Terminate_Renamed()
		MyBase.Finalize()
	End Sub
	
	' properties
	
	
	Public Property Freq() As Double
		Get
			
			Freq = msngFreq
			
		End Get
		Set(ByVal Value As Double)
			
			msngFreq = Value
			
		End Set
	End Property
	
	Public ReadOnly Property RAOx() As ForceCoef
		Get
			
			RAOx = mclsRAOx
			
		End Get
	End Property
	
	Public ReadOnly Property RAOy() As ForceCoef
		Get
			
			RAOy = mclsRAOy
			
		End Get
	End Property
	
	Public ReadOnly Property RAOr() As ForceCoef
		Get
			
			RAOr = mclsRAOr
			
		End Get
	End Property
End Class