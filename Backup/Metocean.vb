Option Strict Off
Option Explicit On
Friend Class Metocean
	
	' metocean criteria
	
	' properties
	' Name:         name
	' Heading:      set uniform enviroment heading to wind wave and current
	' Current:      current
	' Wave:         wave
	' Wind:         wind
	
	Private mstrName As String
	Private mclsCurrent As Current
	Private mclsWave As Wave
	Private mclsWind As Wind
	
	' initializing and terminating
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		
		mclsWind = New Wind
		mclsWave = New Wave
		mclsCurrent = New Current
		
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	'UPGRADE_NOTE: Class_Terminate was upgraded to Class_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Terminate_Renamed()
		
		'UPGRADE_NOTE: Object mclsWind may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		mclsWind = Nothing
		'UPGRADE_NOTE: Object mclsWave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		mclsWave = Nothing
		'UPGRADE_NOTE: Object mclsCurrent may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		mclsCurrent = Nothing
		
	End Sub
	Protected Overrides Sub Finalize()
		Class_Terminate_Renamed()
		MyBase.Finalize()
	End Sub
	
	' properties
	
	
	Public Property Name() As String
		Get
			
			Name = mstrName
			
		End Get
		Set(ByVal Value As String)
			
			mstrName = Value
			
		End Set
	End Property
	
	Public WriteOnly Property Heading() As Double
		Set(ByVal Value As Double)
			
			mclsWind.Heading = Value
			mclsCurrent.Heading = Value
			mclsWave.Heading = Value
			
		End Set
	End Property
	
	Public ReadOnly Property Current() As Current
		Get
			
			Current = mclsCurrent
			
		End Get
	End Property
	
	Public ReadOnly Property Wave() As Wave
		Get
			
			Wave = mclsWave
			
		End Get
	End Property
	
	Public ReadOnly Property Wind() As Wind
		Get
			
			Wind = mclsWind
			
		End Get
	End Property
End Class