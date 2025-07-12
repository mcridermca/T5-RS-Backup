Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: OCTTMP01
'$ PartFamily: OCT_DBG_ConfigureSystem
'$ GenerateDate: 04/17/2025 23:15:25

    Imports Microsoft.VisualBasic
    Imports System
    Imports System.IO
    Imports System.Data
    Imports System.Windows.Forms
    Imports System.Collections
    Imports System.Diagnostics
    Imports System.Math
    Imports System.Xml
    Imports System.Xml.Linq
    Imports RuleStream
    Imports RuleStream.Kernel
    Imports System.Collections.Generic
    Imports RulestreamTCUtilities
    Imports OCTTMP01.swMateType_e
    Imports OCTTMP01.swMateAlign_e
    Imports OCTTMP01.severity

    Public Class [OCT_DBG_ConfigureSystem]
    
    Inherits RuleStream.Kernel.Part
    Implements RuleStream.IRsPartFormulas

    '*************************************************************************
    '*                                                                       *
    '*   This source code, together with any object or execution files       *
    '*   generated herefrom (whether by compiling, translating, or linking   *
    '*   this source file to any header files, resource files, library       *
    '*   files, other source files or object files) are confidential and     *
    '*   proprietary to Siemens Product Lifecycle Management Software Inc.   *
    '*   No person may sell, offer for sale, copy, use, compile, translate   *
    '*   or link this source                                                 *
    '*   file without the written prior approval of Siemens Product          *
    '*   Lifecycle Management Software Inc.                                  *
    '*                                                                       *
    '*   Copyright (C) 2024 Siemens. All rights reserved.                    *
    '*                                                                       *
    '*************************************************************************

    Private this as OCT_DBG_ConfigureSystem = me

    #Region " IRsPartFormulas Implementation "

    Public Function GetNormalValue(ByVal Value as Object, ByVal propertyName As String, ByVal context As String) As Double Implements RuleStream.IRsPartFormulas.GetNormalValue
    Dim MethodName as String = string.format("Formula_{0}_NORMALVALUE{1}", propertyName, context)
    Return CallByName(Me, MethodName, CallType.Method, Value)
    End Function

    Public Function GetOptimalPartFamily(ByVal subpartSpecName As String, ByVal context As String) As String Implements RuleStream.IRsPartFormulas.GetOptimalPartFamily
    Dim MethodName as String = string.format("Formula_{0}_OPTIMALPARTFAMILY{1}", subpartSpecName, context)
    Return CallByName(Me, MethodName, CallType.Method)
    End Function

    Public Function GetPartNames(ByVal subpartSpecName As String, ByVal context As String) As Object Implements RuleStream.IRsPartFormulas.GetPartNames
    Dim MethodName as String = string.format("Formula_{0}_PARTNAMES{1}", subpartSpecName, context)
    Return CallByName(Me, MethodName, CallType.Method)
    End Function

    Public Function GetParts(ByVal specName As String, ByVal context As String) As Object Implements RuleStream.IRsPartFormulas.GetParts
    Dim MethodName as String = string.format("Formula_{0}_PARTS{1}", specName, context)
    Return CallByName(Me, MethodName, CallType.Method)
    End Function

    Public Function GetProcessStepComment(ByVal processId As String, ByVal processStep As String) As String Implements RuleStream.IRsPartFormulas.GetProcessStepComment
    Dim Result as String = ""
    
    Return Result
    End Function

    Public Function GetProcessStepStatus(ByVal processId As String, ByVal processStep As String) As Integer Implements RuleStream.IRsPartFormulas.GetProcessStepStatus
    Dim Result as Integer 'Long
    
    Return Result
    End Function

    Public Function GetQuantity(ByVal subpartSpecName As String, ByVal context As String) As Integer Implements RuleStream.IRsPartFormulas.GetQuantity
    Dim MethodName as String = string.format("Formula_{0}_QUANTITY{1}",subpartSpecName, context)
    Return CallByName(Me, MethodName, CallType.Method)
    End Function

    Public Function GetResult(ByVal propertyName As String, ByVal context As String) As Object Implements RuleStream.IRsPartFormulas.GetResult
    Dim MethodName as String = string.format("Formula_{0}{1}",propertyName, context)
    Return CallByName(Me, MethodName, CallType.Method)
    End Function

    Public Function GetResultCustomCheckDependancy(ByVal propertyName As String, ByVal context As String) As Boolean Implements RuleStream.IRsPartFormulas.GetResultCustomCheckDependancy
    Dim MethodName as String = string.format("Formula_{0}{1}",propertyName, context)
    Return CallByName(Me, MethodName, CallType.Method)
    End Function

    Public Function GetUserChange(ByVal specName As String, ByVal context As String) As Boolean Implements RuleStream.IRsPartFormulas.GetUserChange
    Dim MethodName as String = string.format("Formula_{0}_USERCHANGE{1}", specName, context)
    Return CallByName(Me, MethodName, CallType.Method)
    End Function

    Public Function GetHideCalculatedValue(ByVal propertyName As String, ByVal context As String) As Boolean Implements RuleStream.IRsPartFormulas.GetHideCalculatedValue
    Dim MethodName as String = string.format("Formula_{0}_HIDE_CALCULATED_VALUE{1}",propertyName, context)
    Return CallByName(Me, MethodName, CallType.Method)
    End Function

    Public Sub NewContextInit() Implements RuleStream.IRsPartFormulas.NewContextInit
    NewContextInit_Properties()
    NewContextInit_ValidValues()
    NewContextInit_Subparts()
    NewContextInit_Connections()
    NewContextInit_DB()
    End Sub

    Public Sub OnChanged(ByVal specName As String, ByVal context As String) Implements RuleStream.IRsPartFormulas.OnChanged
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method)
    Select Case specName & "_" & context
    End Select
    Select Case specName & "_" & context
    
    End Select
    End Sub

    Public Sub OnChanged(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String) Implements RuleStream.IRsPartFormulas.OnChanged
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Select Case specName & "_" & context
    
    End Select
    End Sub

    Public Function OnChangedStatus(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String)As Boolean Implements RuleStream.IRsPartFormulas.OnChangedStatus
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Dim Status as Boolean = False
    Select Case specName & "_" & context
    Case Else
    Status = False
    End Select
    Return Status
    End Function

    #End Region

    #Region " Properties, Subparts, Connections "
    
          Public Property [Actuation_Type]() As String
      Get
      Return Properties("Actuation_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Actuation_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Add_One_Support]() As String
      Get
      Return Properties("Add_One_Support").Value
      End Get
      Set(ByVal Value As String)
      Properties("Add_One_Support").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Belt_Width_Offset]() As String
      Get
      Return Properties("Belt_Width_Offset").Value
      End Get
      Set(ByVal Value As String)
      Properties("Belt_Width_Offset").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Belting_Type]() As String
      Get
      Return Properties("Belting_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Belting_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BF_Freeze_Intermediates]() As Boolean
      Get
      Return Properties("BF_Freeze_Intermediates").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("BF_Freeze_Intermediates").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BF_Freeze_Supports]() As Boolean
      Get
      Return Properties("BF_Freeze_Supports").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("BF_Freeze_Supports").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BF_Support]() As Boolean
      Get
      Return Properties("BF_Support").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("BF_Support").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Brake_Motor]() As Boolean
      Get
      Return Properties("Brake_Motor").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Brake_Motor").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Controls_Hand]() As String
      Get
      Return Properties("Controls_Hand").Value
      End Get
      Set(ByVal Value As String)
      Properties("Controls_Hand").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_Number]() As String
      Get
      Return Properties("Conveyor_Number").Value
      End Get
      Set(ByVal Value As String)
      Properties("Conveyor_Number").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Debug_Mode]() As Boolean
      Get
      Return Properties("Debug_Mode").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Debug_Mode").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Discharge_End_Idler]() As String
      Get
      Return Properties("Discharge_End_Idler").Value
      End Get
      Set(ByVal Value As String)
      Properties("Discharge_End_Idler").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Discharge_Idler]() As String
      Get
      Return Properties("Discharge_Idler").Value
      End Get
      Set(ByVal Value As String)
      Properties("Discharge_Idler").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Drip_Pan]() As Boolean
      Get
      Return Properties("Drip_Pan").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Drip_Pan").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Drive_Belt]() As String
      Get
      Return Properties("Drive_Belt").Value
      End Get
      Set(ByVal Value As String)
      Properties("Drive_Belt").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Drive_Hand]() As String
      Get
      Return Properties("Drive_Hand").Value
      End Get
      Set(ByVal Value As String)
      Properties("Drive_Hand").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Drive_Location]() As String
      Get
      Return Properties("Drive_Location").Value
      End Get
      Set(ByVal Value As String)
      Properties("Drive_Location").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Drive_Rating]() As String
      Get
      Return Properties("Drive_Rating").Value
      End Get
      Set(ByVal Value As String)
      Properties("Drive_Rating").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Drive_Style]() As String
      Get
      Return Properties("Drive_Style").Value
      End Get
      Set(ByVal Value As String)
      Properties("Drive_Style").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Drive_Type]() As String
      Get
      Return Properties("Drive_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Drive_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Dynamic_Auto_Slug]() As String
      Get
      Return Properties("Dynamic_Auto_Slug").Value
      End Get
      Set(ByVal Value As String)
      Properties("Dynamic_Auto_Slug").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Elevation_Entry]() As Double
      Get
      Return Properties("Elevation_Entry").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Elevation_Entry").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Elevation_Exit]() As Double
      Get
      Return Properties("Elevation_Exit").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Elevation_Exit").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Encoder_Roller]() As String
      Get
      Return Properties("Encoder_Roller").Value
      End Get
      Set(ByVal Value As String)
      Properties("Encoder_Roller").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Fill_Brush]() As String
      Get
      Return Properties("Fill_Brush").Value
      End Get
      Set(ByVal Value As String)
      Properties("Fill_Brush").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Filter_Regulator_Assy_Kit]() As String
      Get
      Return Properties("Filter_Regulator_Assy_Kit").Value
      End Get
      Set(ByVal Value As String)
      Properties("Filter_Regulator_Assy_Kit").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Filter_Regulator_Qty]() As Long
      Get
      Return Properties("Filter_Regulator_Qty").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Filter_Regulator_Qty").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Floor_Length_Feet]() As Double
      Get
      Return Properties("Floor_Length_Feet").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Floor_Length_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [High_Volume_Acceptance]() As Double
      Get
      Return Properties("High_Volume_Acceptance").Value
      End Get
      Set(ByVal Value As Double)
      Properties("High_Volume_Acceptance").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [High_Volume_Discharge]() As Double
      Get
      Return Properties("High_Volume_Discharge").Value
      End Get
      Set(ByVal Value As Double)
      Properties("High_Volume_Discharge").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [HP_Override]() As String
      Get
      Return Properties("HP_Override").Value
      End Get
      Set(ByVal Value As String)
      Properties("HP_Override").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [IBTYPE]() As String
      Get
      Return Properties("IBTYPE").Value
      End Get
      Set(ByVal Value As String)
      Properties("IBTYPE").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Idler_Blade_Stop]() As String
      Get
      Return Properties("Idler_Blade_Stop").Value
      End Get
      Set(ByVal Value As String)
      Properties("Idler_Blade_Stop").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Idler_Brake_Module]() As String
      Get
      Return Properties("Idler_Brake_Module").Value
      End Get
      Set(ByVal Value As String)
      Properties("Idler_Brake_Module").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Idler_Type]() As String
      Get
      Return Properties("Idler_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Idler_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Infeed_End_Idler]() As String
      Get
      Return Properties("Infeed_End_Idler").Value
      End Get
      Set(ByVal Value As String)
      Properties("Infeed_End_Idler").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Int_Bottom_Cover]() As String
      Get
      Return Properties("Int_Bottom_Cover").Value
      End Get
      Set(ByVal Value As String)
      Properties("Int_Bottom_Cover").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Int_Bottom_Cover_calculation]() As String
      Get
      Return Properties("Int_Bottom_Cover_calculation").Value
      End Get
      Set(ByVal Value As String)
      Properties("Int_Bottom_Cover_calculation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Int_Bottom_Cover_Qty]() As String
      Get
      Return Properties("Int_Bottom_Cover_Qty").Value
      End Get
      Set(ByVal Value As String)
      Properties("Int_Bottom_Cover_Qty").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Int_Bottom_Cover_Type]() As String
      Get
      Return Properties("Int_Bottom_Cover_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Int_Bottom_Cover_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Intermediate_Sensor_Location]() As String
      Get
      Return Properties("Intermediate_Sensor_Location").Value
      End Get
      Set(ByVal Value As String)
      Properties("Intermediate_Sensor_Location").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [IQZF_Belt_Length]() As Double
      Get
      Return Properties("IQZF_Belt_Length").Value
      End Get
      Set(ByVal Value As Double)
      Properties("IQZF_Belt_Length").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [JSONObjectName]() As String
      Get
      Return Properties("JSONObjectName").Value
      End Get
      Set(ByVal Value As String)
      Properties("JSONObjectName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [JSONObjectType]() As String
      Get
      Return Properties("JSONObjectType").Value
      End Get
      Set(ByVal Value As String)
      Properties("JSONObjectType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Length]() As Double
      Get
      Return Properties("Length").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Length").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Length_Feet]() As Double
      Get
      Return Properties("Length_Feet").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Length_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Length_Inches]() As Double
      Get
      Return Properties("Length_Inches").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Length_Inches").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Live_Load]() As Double
      Get
      Return Properties("Live_Load").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Live_Load").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Lock_Bottom_Cover_Qty]() As String
      Get
      Return Properties("Lock_Bottom_Cover_Qty").Value
      End Get
      Set(ByVal Value As String)
      Properties("Lock_Bottom_Cover_Qty").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Logic_Mode]() As String
      Get
      Return Properties("Logic_Mode").Value
      End Get
      Set(ByVal Value As String)
      Properties("Logic_Mode").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Lower_Transition]() As String
      Get
      Return Properties("Lower_Transition").Value
      End Get
      Set(ByVal Value As String)
      Properties("Lower_Transition").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Lower_Transition_Angle]() As String
      Get
      Return Properties("Lower_Transition_Angle").Value
      End Get
      Set(ByVal Value As String)
      Properties("Lower_Transition_Angle").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Lower_Transition_Belting_Type]() As String
      Get
      Return Properties("Lower_Transition_Belting_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Lower_Transition_Belting_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Lower_Transition_Extension_Feet]() As String
      Get
      Return Properties("Lower_Transition_Extension_Feet").Value
      End Get
      Set(ByVal Value As String)
      Properties("Lower_Transition_Extension_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Lower_Transition_Extension_Inches]() As String
      Get
      Return Properties("Lower_Transition_Extension_Inches").Value
      End Get
      Set(ByVal Value As String)
      Properties("Lower_Transition_Extension_Inches").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Lower_Transition_Ratio]() As String
      Get
      Return Properties("Lower_Transition_Ratio").Value
      End Get
      Set(ByVal Value As String)
      Properties("Lower_Transition_Ratio").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Module_Placement]() As String
      Get
      Return Properties("Module_Placement").Value
      End Get
      Set(ByVal Value As String)
      Properties("Module_Placement").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Motor_Class]() As String
      Get
      Return Properties("Motor_Class").Value
      End Get
      Set(ByVal Value As String)
      Properties("Motor_Class").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Motor_HP]() As Double
      Get
      Return Properties("Motor_HP").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Motor_HP").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Motor_MFG]() As String
      Get
      Return Properties("Motor_MFG").Value
      End Get
      Set(ByVal Value As String)
      Properties("Motor_MFG").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Motor_Mount]() As String
      Get
      Return Properties("Motor_Mount").Value
      End Get
      Set(ByVal Value As String)
      Properties("Motor_Mount").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Motor_Voltage]() As Double
      Get
      Return Properties("Motor_Voltage").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Motor_Voltage").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Number_of_6ft_IntermediatesNumber_of_9ft_Intermed]() As Long
      Get
      Return Properties("Number_of_6ft_IntermediatesNumber_of_9ft_Intermed").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Number_of_6ft_IntermediatesNumber_of_9ft_Intermed").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Number_of_Modules]() As Long
      Get
      Return Properties("Number_of_Modules").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Number_of_Modules").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Paint_Color]() As String
      Get
      Return Properties("Paint_Color").Value
      End Get
      Set(ByVal Value As String)
      Properties("Paint_Color").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Power_Supply]() As String
      Get
      Return Properties("Power_Supply").Value
      End Get
      Set(ByVal Value As String)
      Properties("Power_Supply").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Power_Supply_Qty]() As Long
      Get
      Return Properties("Power_Supply_Qty").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Power_Supply_Qty").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Power_Unit_Hand]() As String
      Get
      Return Properties("Power_Unit_Hand").Value
      End Get
      Set(ByVal Value As String)
      Properties("Power_Unit_Hand").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Product]() As String
      Get
      Return Properties("Product").Value
      End Get
      Set(ByVal Value As String)
      Properties("Product").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Pull]() As String
      Get
      Return Properties("Pull").Value
      End Get
      Set(ByVal Value As String)
      Properties("Pull").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Pulley_Bearing]() As String
      Get
      Return Properties("Pulley_Bearing").Value
      End Get
      Set(ByVal Value As String)
      Properties("Pulley_Bearing").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Qty_5_Roller_Skew]() As Long
      Get
      Return Properties("Qty_5_Roller_Skew").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Qty_5_Roller_Skew").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Rail_Type]() As String
      Get
      Return Properties("Rail_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Rail_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Reducer_MFG]() As String
      Get
      Return Properties("Reducer_MFG").Value
      End Get
      Set(ByVal Value As String)
      Properties("Reducer_MFG").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Reducer_Motor_Mount]() As String
      Get
      Return Properties("Reducer_Motor_Mount").Value
      End Get
      Set(ByVal Value As String)
      Properties("Reducer_Motor_Mount").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Reflector_Offset]() As String
      Get
      Return Properties("Reflector_Offset").Value
      End Get
      Set(ByVal Value As String)
      Properties("Reflector_Offset").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Roller]() As String
      Get
      Return Properties("Roller").Value
      End Get
      Set(ByVal Value As String)
      Properties("Roller").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Roller_Bearings]() As String
      Get
      Return Properties("Roller_Bearings").Value
      End Get
      Set(ByVal Value As String)
      Properties("Roller_Bearings").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Roller_Center]() As Double
      Get
      Return Properties("Roller_Center").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Roller_Center").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Roller_Position]() As String
      Get
      Return Properties("Roller_Position").Value
      End Get
      Set(ByVal Value As String)
      Properties("Roller_Position").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Roller_Type]() As String
      Get
      Return Properties("Roller_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Roller_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Section_Length]() As String
      Get
      Return Properties("Section_Length").Value
      End Get
      Set(ByVal Value As String)
      Properties("Section_Length").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sensor_Type]() As String
      Get
      Return Properties("Sensor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sensor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Side_Guide_Left]() As String
      Get
      Return Properties("Side_Guide_Left").Value
      End Get
      Set(ByVal Value As String)
      Properties("Side_Guide_Left").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Side_Guide_Mount]() As String
      Get
      Return Properties("Side_Guide_Mount").Value
      End Get
      Set(ByVal Value As String)
      Properties("Side_Guide_Mount").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Side_Guide_Right]() As String
      Get
      Return Properties("Side_Guide_Right").Value
      End Get
      Set(ByVal Value As String)
      Properties("Side_Guide_Right").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Skatewheel_Side_Guide]() As String
      Get
      Return Properties("Skatewheel_Side_Guide").Value
      End Get
      Set(ByVal Value As String)
      Properties("Skatewheel_Side_Guide").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Skew_Feet]() As Double
      Get
      Return Properties("Skew_Feet").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Skew_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Skew_Hand]() As String
      Get
      Return Properties("Skew_Hand").Value
      End Get
      Set(ByVal Value As String)
      Properties("Skew_Hand").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Slug_Acceptance]() As Double
      Get
      Return Properties("Slug_Acceptance").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Slug_Acceptance").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Slug_Discharge]() As Double
      Get
      Return Properties("Slug_Discharge").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Slug_Discharge").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Soft_Start]() As String
      Get
      Return Properties("Soft_Start").Value
      End Get
      Set(ByVal Value As String)
      Properties("Soft_Start").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed]() As Double
      Get
      Return Properties("Speed").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Speed").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_FPM]() As Double
      Get
      Return Properties("Speed_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Speed_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_FPM_Actual]() As Double
      Get
      Return Properties("Speed_FPM_Actual").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Speed_FPM_Actual").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_ISC]() As String
      Get
      Return Properties("Speed_ISC").Value
      End Get
      Set(ByVal Value As String)
      Properties("Speed_ISC").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Style]() As String
      Get
      Return Properties("Style").Value
      End Get
      Set(ByVal Value As String)
      Properties("Style").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Support_Hardware]() As String
      Get
      Return Properties("Support_Hardware").Value
      End Get
      Set(ByVal Value As String)
      Properties("Support_Hardware").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Support_Paint_Elevation]() As String
      Get
      Return Properties("Support_Paint_Elevation").Value
      End Get
      Set(ByVal Value As String)
      Properties("Support_Paint_Elevation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Support_Paint_Option]() As String
      Get
      Return Properties("Support_Paint_Option").Value
      End Get
      Set(ByVal Value As String)
      Properties("Support_Paint_Option").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Support_Type]() As String
      Get
      Return Properties("Support_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Support_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Takeup_Type]() As String
      Get
      Return Properties("Takeup_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Takeup_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Throughput_CFPM]() As Double
      Get
      Return Properties("Throughput_CFPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Throughput_CFPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Time_Delay_PE]() As String
      Get
      Return Properties("Time_Delay_PE").Value
      End Get
      Set(ByVal Value As String)
      Properties("Time_Delay_PE").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TU_Prox_Sensor]() As String
      Get
      Return Properties("TU_Prox_Sensor").Value
      End Get
      Set(ByVal Value As String)
      Properties("TU_Prox_Sensor").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Upper_Transition]() As String
      Get
      Return Properties("Upper_Transition").Value
      End Get
      Set(ByVal Value As String)
      Properties("Upper_Transition").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Upper_Transition_Angle]() As String
      Get
      Return Properties("Upper_Transition_Angle").Value
      End Get
      Set(ByVal Value As String)
      Properties("Upper_Transition_Angle").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Upper_Transition_Extension_Feet]() As String
      Get
      Return Properties("Upper_Transition_Extension_Feet").Value
      End Get
      Set(ByVal Value As String)
      Properties("Upper_Transition_Extension_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Upper_Transition_Extension_Inches]() As String
      Get
      Return Properties("Upper_Transition_Extension_Inches").Value
      End Get
      Set(ByVal Value As String)
      Properties("Upper_Transition_Extension_Inches").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Upstream_Conv_Connection]() As String
      Get
      Return Properties("Upstream_Conv_Connection").Value
      End Get
      Set(ByVal Value As String)
      Properties("Upstream_Conv_Connection").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [VFD]() As String
      Get
      Return Properties("VFD").Value
      End Get
      Set(ByVal Value As String)
      Properties("VFD").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Width]() As String
      Get
      Return Properties("Width").Value
      End Get
      Set(ByVal Value As String)
      Properties("Width").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [XMLObjectName]() As String
      Get
      Return Properties("XMLObjectName").Value
      End Get
      Set(ByVal Value As String)
      Properties("XMLObjectName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [XMLObjectType]() As String
      Get
      Return Properties("XMLObjectType").Value
      End Get
      Set(ByVal Value As String)
      Properties("XMLObjectType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Zone_Control]() As String
      Get
      Return Properties("Zone_Control").Value
      End Get
      Set(ByVal Value As String)
      Properties("Zone_Control").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Zone_Length]() As String
      Get
      Return Properties("Zone_Length").Value
      End Get
      Set(ByVal Value As String)
      Properties("Zone_Length").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Zoneflex_Manager]() As String
      Get
      Return Properties("Zoneflex_Manager").Value
      End Get
      Set(ByVal Value As String)
      Properties("Zoneflex_Manager").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PartNumber]() As String
      Get
      Return Properties("PartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartNumber").CalculatedValue = Value
      End Set
      End Property
    
    #End Region

    #Region " Initialization "
    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Sub Initialize() Implements RuleStream.IRsPartFormulas.Initialize
    Dim oSpec As Rulestream.Kernel.Spec = Nothing
    Dim oConnection as Rulestream.Kernel.Connection = Nothing
    Dim oSubpart as Rulestream.Kernel.Subpart = Nothing
    dim oMasterDoc as Rulestream.Kernel.MasterDoc = Nothing
    InitPart("OCT_DBG_ConfigureSystem", <a><![CDATA[OCT_DBG_ConfigureSystem]]></a>.Value, 330, "OCTTMP01",  "N", "N", False, False, "In Development", "", "Debug/Test Stub for Oracle Transfer DBG_ConfigureSystem Object", "", "", "",  "GLOBAL\H601424", "04/16/2025 01:50:10")
    AddProperty("2016", "Actuation_Type", <a><![CDATA[Actuation_Type]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("2017", "Add_One_Support", <a><![CDATA[Add_One_Support]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("2018", "Belt_Width_Offset", <a><![CDATA[Belt_Width_Offset]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2019", "Belting_Type", <a><![CDATA[Belting_Type]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2020", "BF_Freeze_Intermediates", <a><![CDATA[BF_Freeze_Intermediates]]></a>.Value, "", "Boolean","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2021", "BF_Freeze_Supports", <a><![CDATA[BF_Freeze_Supports]]></a>.Value, "", "Boolean","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2022", "BF_Support", <a><![CDATA[BF_Support]]></a>.Value, "", "Boolean","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2023", "Brake_Motor", <a><![CDATA[Brake_Motor]]></a>.Value, "", "Boolean","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2024", "Controls_Hand", <a><![CDATA[Controls_Hand]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2025", "Conveyor_Number", <a><![CDATA[Conveyor_Number]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2138", "Debug_Mode", <a><![CDATA[Debug_Mode]]></a>.Value, "", "Boolean","","Debugging","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2026", "Discharge_End_Idler", <a><![CDATA[Discharge_End_Idler]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2027", "Discharge_Idler", <a><![CDATA[Discharge_Idler]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2028", "Drip_Pan", <a><![CDATA[Drip_Pan]]></a>.Value, "", "Boolean","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2029", "Drive_Belt", <a><![CDATA[Drive_Belt]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2030", "Drive_Hand", <a><![CDATA[Drive_Hand]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2031", "Drive_Location", <a><![CDATA[Drive_Location]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2179", "Drive_Rating", <a><![CDATA[Drive_Rating]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2032", "Drive_Style", <a><![CDATA[Drive_Style]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2033", "Drive_Type", <a><![CDATA[Drive_Type]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2034", "Dynamic_Auto_Slug", <a><![CDATA[Dynamic_Auto_Slug]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2035", "Elevation_Entry", <a><![CDATA[Elevation_Entry]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2036", "Elevation_Exit", <a><![CDATA[Elevation_Exit]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2037", "Encoder_Roller", <a><![CDATA[Encoder_Roller]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2038", "Fill_Brush", <a><![CDATA[Fill_Brush]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2039", "Filter_Regulator_Assy_Kit", <a><![CDATA[Filter_Regulator_Assy_Kit]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2180", "Filter_Regulator_Qty", <a><![CDATA[Filter_Regulator_Qty]]></a>.Value, "", "Long","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2040", "Floor_Length_Feet", <a><![CDATA[Floor_Length_Feet]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2041", "High_Volume_Acceptance", <a><![CDATA[High_Volume_Acceptance]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2042", "High_Volume_Discharge", <a><![CDATA[High_Volume_Discharge]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2043", "HP_Override", <a><![CDATA[HP_Override]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2044", "IBTYPE", <a><![CDATA[IBTYPE]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2045", "Idler_Blade_Stop", <a><![CDATA[Idler_Blade_Stop]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2046", "Idler_Brake_Module", <a><![CDATA[Idler_Brake_Module]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2181", "Idler_Type", <a><![CDATA[Idler_Type]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2047", "Infeed_End_Idler", <a><![CDATA[Infeed_End_Idler]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2048", "Int_Bottom_Cover", <a><![CDATA[Int_Bottom_Cover]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2182", "Int_Bottom_Cover_calculation", <a><![CDATA[Int_Bottom_Cover_calculation]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2049", "Int_Bottom_Cover_Qty", <a><![CDATA[Int_Bottom_Cover_Qty]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2050", "Int_Bottom_Cover_Type", <a><![CDATA[Int_Bottom_Cover_Type]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2183", "Intermediate_Sensor_Location", <a><![CDATA[Intermediate_Sensor_Location]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2184", "IQZF_Belt_Length", <a><![CDATA[IQZF_Belt_Length]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2051", "JSONObjectName", <a><![CDATA[JSONObjectName]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2052", "JSONObjectType", <a><![CDATA[JSONObjectType]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2055", "Length", <a><![CDATA[Length]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2056", "Length_Feet", <a><![CDATA[Length_Feet]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2057", "Length_Inches", <a><![CDATA[Length_Inches]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2058", "Live_Load", <a><![CDATA[Live_Load]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2059", "Lock_Bottom_Cover_Qty", <a><![CDATA[Lock_Bottom_Cover_Qty]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2060", "Logic_Mode", <a><![CDATA[Logic_Mode]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2061", "Lower_Transition", <a><![CDATA[Lower_Transition]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2062", "Lower_Transition_Angle", <a><![CDATA[Lower_Transition_Angle]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2063", "Lower_Transition_Belting_Type", <a><![CDATA[Lower_Transition_Belting_Type]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2064", "Lower_Transition_Extension_Feet", <a><![CDATA[Lower_Transition_Extension_Feet]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2065", "Lower_Transition_Extension_Inches", <a><![CDATA[Lower_Transition_Extension_Inches]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2066", "Lower_Transition_Ratio", <a><![CDATA[Lower_Transition_Ratio]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2067", "Module_Placement", <a><![CDATA[Module_Placement]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2068", "Motor_Class", <a><![CDATA[Motor_Class]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2185", "Motor_HP", <a><![CDATA[Motor_HP]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2069", "Motor_MFG", <a><![CDATA[Motor_MFG]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2070", "Motor_Mount", <a><![CDATA[Motor_Mount]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2071", "Motor_Voltage", <a><![CDATA[Motor_Voltage]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2186", "Number_of_6ft_IntermediatesNumber_of_9ft_Intermed", <a><![CDATA[Number_of_6ft_Intermediates
Number_of_9ft_Intermediates
Number_of_12ft_Intermediates]]></a>.Value, "", "Long","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2187", "Number_of_Modules", <a><![CDATA[Number_of_Modules]]></a>.Value, "", "Long","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2072", "Paint_Color", <a><![CDATA[Paint_Color]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2073", "Power_Supply", <a><![CDATA[Power_Supply]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2188", "Power_Supply_Qty", <a><![CDATA[Power_Supply_Qty]]></a>.Value, "", "Long","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2074", "Power_Unit_Hand", <a><![CDATA[Power_Unit_Hand]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2075", "Product", <a><![CDATA[Product]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2189", "Pull", <a><![CDATA[Pull]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2076", "Pulley_Bearing", <a><![CDATA[Pulley_Bearing]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2190", "Qty_5_Roller_Skew", <a><![CDATA[Qty_5_Roller_Skew]]></a>.Value, "", "Long","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2077", "Rail_Type", <a><![CDATA[Rail_Type]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2078", "Reducer_MFG", <a><![CDATA[Reducer_MFG]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2079", "Reducer_Motor_Mount", <a><![CDATA[Reducer_Motor_Mount]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2080", "Reflector_Offset", <a><![CDATA[Reflector_Offset]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2081", "Roller", <a><![CDATA[Roller]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:22 AM")
    AddProperty("2082", "Roller_Bearings", <a><![CDATA[Roller_Bearings]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2083", "Roller_Center", <a><![CDATA[Roller_Center]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2084", "Roller_Position", <a><![CDATA[Roller_Position]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2085", "Roller_Type", <a><![CDATA[Roller_Type]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2086", "Section_Length", <a><![CDATA[Section_Length]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2087", "Sensor_Type", <a><![CDATA[Sensor_Type]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2088", "Side_Guide_Left", <a><![CDATA[Side_Guide_Left]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2089", "Side_Guide_Mount", <a><![CDATA[Side_Guide_Mount]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2090", "Side_Guide_Right", <a><![CDATA[Side_Guide_Right]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2091", "Skatewheel_Side_Guide", <a><![CDATA[Skatewheel_Side_Guide]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:12 AM")
    AddProperty("2092", "Skew_Feet", <a><![CDATA[Skew_Feet]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2093", "Skew_Hand", <a><![CDATA[Skew_Hand]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2094", "Slug_Acceptance", <a><![CDATA[Slug_Acceptance]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2095", "Slug_Discharge", <a><![CDATA[Slug_Discharge]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2191", "Soft_Start", <a><![CDATA[Soft_Start]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2096", "Speed", <a><![CDATA[Speed]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2097", "Speed_FPM", <a><![CDATA[Speed_FPM]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2192", "Speed_FPM_Actual", <a><![CDATA[Speed_FPM_Actual]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2193", "Speed_ISC", <a><![CDATA[Speed_ISC]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2098", "Style", <a><![CDATA[Style]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2099", "Support_Hardware", <a><![CDATA[Support_Hardware]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2100", "Support_Paint_Elevation", <a><![CDATA[Support_Paint_Elevation]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2101", "Support_Paint_Option", <a><![CDATA[Support_Paint_Option]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2102", "Support_Type", <a><![CDATA[Support_Type]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2103", "Takeup_Type", <a><![CDATA[Takeup_Type]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2194", "Throughput_CFPM", <a><![CDATA[Throughput_CFPM]]></a>.Value, "", "Double","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:14 AM")
    AddProperty("2104", "Time_Delay_PE", <a><![CDATA[Time_Delay_PE]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2105", "TU_Prox_Sensor", <a><![CDATA[TU_Prox_Sensor]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2106", "Upper_Transition", <a><![CDATA[Upper_Transition]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2107", "Upper_Transition_Angle", <a><![CDATA[Upper_Transition_Angle]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2108", "Upper_Transition_Extension_Feet", <a><![CDATA[Upper_Transition_Extension_Feet]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2109", "Upper_Transition_Extension_Inches", <a><![CDATA[Upper_Transition_Extension_Inches]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2110", "Upstream_Conv_Connection", <a><![CDATA[Upstream_Conv_Connection]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2195", "VFD", <a><![CDATA[VFD]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:14 AM")
    AddProperty("2111", "Width", <a><![CDATA[Width]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2053", "XMLObjectName", <a><![CDATA[XMLObjectName]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2054", "XMLObjectType", <a><![CDATA[XMLObjectType]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/14/2025 2:01:23 AM")
    AddProperty("2112", "Zone_Control", <a><![CDATA[Zone_Control]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2113", "Zone_Length", <a><![CDATA[Zone_Length]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("2114", "Zoneflex_Manager", <a><![CDATA[Zoneflex_Manager]]></a>.Value, "", "String","","Debugging","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:13 AM")
    AddProperty("1976", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/9/2025 1:07:11 AM")
    
      AddValidValue("Actuation_Type")
    
      AddValidValue("Add_One_Support")
    
      AddValidValue("Controls_Hand")
    
      AddValidValue("Discharge_Idler")
    
      AddValidValue("Drip_Pan")
    
      AddValidValue("Drive_Belt")
    
      AddValidValue("Drive_Hand")
    
      AddValidValue("Drive_Rating")
    
      AddValidValue("Drive_Type")
    
      AddValidValue("Elevation_Entry")
    
      AddValidValue("Elevation_Exit")
    
      AddValidValue("HP_Override")
    
      AddValidValue("Idler_Blade_Stop")
    
      AddValidValue("Idler_Brake_Module")
    
      AddValidValue("Idler_Type")
    
      AddValidValue("Int_Bottom_Cover_Type")
    
      AddValidValue("Intermediate_Sensor_Location")
    
      AddValidValue("Logic_Mode")
    
      AddValidValue("Module_Placement")
    
      AddValidValue("Motor_Class")
    
      AddValidValue("Motor_MFG")
    
      AddValidValue("Motor_Voltage")
    
      AddValidValue("Number_of_Modules")
    
      AddValidValue("Power_Supply")
    
      AddValidValue("Power_Supply_Qty")
    
      AddValidValue("Product")
    
      AddValidValue("Pulley_Bearing")
    
      AddValidValue("Qty_5_Roller_Skew")
    
      AddValidValue("Reducer_MFG")
    
      AddValidValue("Reducer_Motor_Mount")
    
      AddValidValue("Reflector_Offset")
    
      AddValidValue("Roller_Bearings")
    
      AddValidValue("Roller_Center")
    
      AddValidValue("Section_Length")
    
      AddValidValue("Sensor_Type")
    
      AddValidValue("Side_Guide_Left")
    
      AddValidValue("Side_Guide_Mount")
    
      AddValidValue("Side_Guide_Right")
    
      AddValidValue("Skatewheel_Side_Guide")
    
      AddValidValue("Skew_Hand")
    
      AddValidValue("Soft_Start")
    
      AddValidValue("Speed_FPM")
    
      AddValidValue("Speed_FPM_Actual")
    
      AddValidValue("Style")
    
      AddValidValue("Support_Hardware")
    
      AddValidValue("Support_Paint_Elevation")
    
      AddValidValue("Support_Paint_Option")
    
      AddValidValue("Support_Type")
    
      AddValidValue("Time_Delay_PE")
    
      AddValidValue("TU_Prox_Sensor")
    
      AddValidValue("Upstream_Conv_Connection")
    
      AddValidValue("VFD")
    
      AddValidValue("Width")
    
      AddValidValue("Zone_Control")
    
      AddValidValue("Zone_Length")
    
      AddValidValue("Zoneflex_Manager")
    
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Sub Initialize_Process(ByVal lngProcessID as Integer) Implements RuleStream.IRsPartFormulas.InitializeProcess
    Select Case lngProcessID
    
    Case Else
    Process = "DefaultProcess"
    End Select
    End Sub

    

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Private Sub NewContextInit_Properties()
    Dim ctx as String
    ctx = ContextId
    
            If Incontext("-1", ctx) Then
          InitProperty("Actuation_Type", "1684", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,1838)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Add_One_Support", "1685", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2388)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Belt_Width_Offset", "1686", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1840)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Belting_Type", "1687", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1841)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BF_Freeze_Intermediates", "1688", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,2149)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BF_Freeze_Supports", "1689", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,2150)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BF_Support", "1690", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,2151)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Brake_Motor", "1691", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,2158)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Controls_Hand", "1692", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1846)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_Number", "1693", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1847)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Debug_Mode", "1806", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1997)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Discharge_End_Idler", "1694", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1848)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Discharge_Idler", "1695", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1849)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drip_Pan", "1696", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,2159)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Belt", "1697", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1851)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Hand", "1698", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1852)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Location", "1699", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1853)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Rating", "1847", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2436)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Style", "1700", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1854)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Type", "1701", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1855)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Dynamic_Auto_Slug", "1702", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1856)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Elevation_Entry", "1703", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1857)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Elevation_Exit", "1704", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1858)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Encoder_Roller", "1705", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1859)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Fill_Brush", "1706", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1860)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Filter_Regulator_Assy_Kit", "1707", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1861)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Filter_Regulator_Qty", "1848", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2438)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Floor_Length_Feet", "1708", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1862)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("High_Volume_Acceptance", "1709", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1863)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("High_Volume_Discharge", "1710", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1864)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("HP_Override", "1711", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1865)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IBTYPE", "1712", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1866)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Idler_Blade_Stop", "1713", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1867)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Idler_Brake_Module", "1714", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1868)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Idler_Type", "1849", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2439)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Infeed_End_Idler", "1715", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1869)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Int_Bottom_Cover", "1716", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1870)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Int_Bottom_Cover_calculation", "1850", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2441)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Int_Bottom_Cover_Qty", "1717", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1871)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Int_Bottom_Cover_Type", "1718", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1872)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Intermediate_Sensor_Location", "1851", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2442)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IQZF_Belt_Length", "1852", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2444)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("JSONObjectName", "1719", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1873)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("JSONObjectType", "1720", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1874)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Length", "1723", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1877)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Length_Feet", "1724", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1878)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Length_Inches", "1725", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1879)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Live_Load", "1726", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1880)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lock_Bottom_Cover_Qty", "1727", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1881)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Logic_Mode", "1728", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1882)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition", "1729", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1883)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Angle", "1730", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1884)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Belting_Type", "1731", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1885)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Extension_Feet", "1732", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1886)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Extension_Inches", "1733", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1887)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Ratio", "1734", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1888)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Module_Placement", "1735", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1889)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Class", "1736", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1890)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_HP", "1853", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2445)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_MFG", "1737", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1891)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Mount", "1738", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1892)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Voltage", "1739", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1893)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Number_of_6ft_IntermediatesNumber_of_9ft_Intermed", "1854", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2446)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Number_of_Modules", "1855", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2447)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Paint_Color", "1740", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1894)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Power_Supply", "1741", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1895)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Power_Supply_Qty", "1856", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2449)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Power_Unit_Hand", "1742", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1896)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product", "1743", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1897)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pull", "1857", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2451)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pulley_Bearing", "1744", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1898)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Qty_5_Roller_Skew", "1858", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2452)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Rail_Type", "1745", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1899)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reducer_MFG", "1746", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1900)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reducer_Motor_Mount", "1747", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1901)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reflector_Offset", "1748", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1902)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Roller", "1749", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:22 AM", "", "In Development",  0,1903)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Roller_Bearings", "1750", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1904)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Roller_Center", "1751", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1905)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Roller_Position", "1752", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1906)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Roller_Type", "1753", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1907)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Section_Length", "1754", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1908)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sensor_Type", "1755", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1909)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Side_Guide_Left", "1756", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1910)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Side_Guide_Mount", "1757", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1911)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Side_Guide_Right", "1758", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1912)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Skatewheel_Side_Guide", "1759", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:12 AM", "", "In Development",  0,1913)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Skew_Feet", "1760", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1914)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Skew_Hand", "1761", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,1915)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Slug_Acceptance", "1762", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1916)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Slug_Discharge", "1763", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1917)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Soft_Start", "1859", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2454)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed", "1764", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1918)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_FPM", "1765", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,1919)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_FPM_Actual", "1860", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2456)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_ISC", "1861", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2458)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Style", "1766", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,1920)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Support_Hardware", "1767", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,1921)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Support_Paint_Elevation", "1768", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,1922)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Support_Paint_Option", "1769", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,1923)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Support_Type", "1770", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,1924)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Takeup_Type", "1771", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,1925)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Throughput_CFPM", "1862", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:14 AM", "", "In Development",  0,2459)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Time_Delay_PE", "1772", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,1926)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TU_Prox_Sensor", "1773", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,1927)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upper_Transition", "1774", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1928)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upper_Transition_Angle", "1775", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1929)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upper_Transition_Extension_Feet", "1776", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1930)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upper_Transition_Extension_Inches", "1777", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1931)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upstream_Conv_Connection", "1778", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,1932)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("VFD", "1863", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:14 AM", "", "In Development",  0,2460)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Width", "1779", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,2431)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectName", "1721", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1875)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectType", "1722", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/14/2025 2:01:23 AM", "", "In Development",  0,1876)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Zone_Control", "1780", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,1934)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Zone_Length", "1781", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,1935)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Zoneflex_Manager", "1782", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:13 AM", "", "In Development",  0,1936)
        End If
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Private Sub NewContextInit_ValidValues()
    Dim ctx as String
    ctx = ContextId
            If Incontext("-1", ctx) Then
          
        InitValidValue("Actuation_Type_ValidValues", "1684", "-1", 2387)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Add_One_Support_ValidValues", "1685", "-1", 2389)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Controls_Hand_ValidValues", "1692", "-1", 2390)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Discharge_Idler_ValidValues", "1695", "-1", 2391)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Drip_Pan_ValidValues", "1696", "-1", 2392)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Drive_Belt_ValidValues", "1697", "-1", 2393)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Drive_Hand_ValidValues", "1698", "-1", 2394)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Drive_Rating_ValidValues", "1847", "-1", 2437)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Drive_Type_ValidValues", "1701", "-1", 2395)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Elevation_Entry_ValidValues", "1703", "-1", 2396)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Elevation_Exit_ValidValues", "1704", "-1", 2397)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("HP_Override_ValidValues", "1711", "-1", 2398)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Idler_Blade_Stop_ValidValues", "1713", "-1", 2399)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Idler_Brake_Module_ValidValues", "1714", "-1", 2400)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Idler_Type_ValidValues", "1849", "-1", 2440)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Int_Bottom_Cover_Type_ValidValues", "1718", "-1", 2401)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Intermediate_Sensor_Location_ValidValues", "1851", "-1", 2443)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Logic_Mode_ValidValues", "1728", "-1", 2402)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Module_Placement_ValidValues", "1735", "-1", 2403)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Motor_Class_ValidValues", "1736", "-1", 2404)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Motor_MFG_ValidValues", "1737", "-1", 2405)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Motor_Voltage_ValidValues", "1739", "-1", 2406)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Number_of_Modules_ValidValues", "1855", "-1", 2448)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Power_Supply_ValidValues", "1741", "-1", 2407)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Power_Supply_Qty_ValidValues", "1856", "-1", 2450)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Product_ValidValues", "1743", "-1", 2408)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Pulley_Bearing_ValidValues", "1744", "-1", 2409)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Qty_5_Roller_Skew_ValidValues", "1858", "-1", 2453)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Reducer_MFG_ValidValues", "1746", "-1", 2410)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Reducer_Motor_Mount_ValidValues", "1747", "-1", 2411)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Reflector_Offset_ValidValues", "1748", "-1", 2412)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Roller_Bearings_ValidValues", "1750", "-1", 2413)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Roller_Center_ValidValues", "1751", "-1", 2414)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Section_Length_ValidValues", "1754", "-1", 2415)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Sensor_Type_ValidValues", "1755", "-1", 2416)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Side_Guide_Left_ValidValues", "1756", "-1", 2417)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Side_Guide_Mount_ValidValues", "1757", "-1", 2418)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Side_Guide_Right_ValidValues", "1758", "-1", 2419)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Skatewheel_Side_Guide_ValidValues", "1759", "-1", 2420)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Skew_Hand_ValidValues", "1761", "-1", 2421)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Soft_Start_ValidValues", "1859", "-1", 2455)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Speed_FPM_ValidValues", "1765", "-1", 2422)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Speed_FPM_Actual_ValidValues", "1860", "-1", 2457)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Style_ValidValues", "1766", "-1", 2423)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Support_Hardware_ValidValues", "1767", "-1", 2424)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Support_Paint_Elevation_ValidValues", "1768", "-1", 2425)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Support_Paint_Option_ValidValues", "1769", "-1", 2426)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Support_Type_ValidValues", "1770", "-1", 2427)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Time_Delay_PE_ValidValues", "1772", "-1", 2428)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("TU_Prox_Sensor_ValidValues", "1773", "-1", 2429)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Upstream_Conv_Connection_ValidValues", "1778", "-1", 2430)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("VFD_ValidValues", "1863", "-1", 2461)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Width_ValidValues", "1779", "-1", 2432)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Zone_Control_ValidValues", "1780", "-1", 2433)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Zone_Length_ValidValues", "1781", "-1", 2434)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Zoneflex_Manager_ValidValues", "1782", "-1", 2435)
        End If
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Private Sub NewContextInit_Subparts()
    Dim ctx as String
    ctx = ContextId
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Private Sub NewContextInit_Connections()
    Dim ctx as String
    ctx = ContextId
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Private Sub NewContextInit_DB()
    Dim ctx as String
    ctx = ContextId
    End Sub

    #End Region

    #Region " Formulas "

    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Actuation_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Actuation_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1684; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1684; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Actuation_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Add_One_Support() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Add_One_Support").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1685; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1685; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Add_One_Support", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Belt_Width_Offset() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Belt_Width_Offset").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1686; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1686; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Belt_Width_Offset", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Belting_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Belting_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1687; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1687; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Belting_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BF_Freeze_Intermediates() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BF_Freeze_Intermediates").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1688; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:1688; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_BF_Freeze_Intermediates", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BF_Freeze_Supports() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BF_Freeze_Supports").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1689; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:1689; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_BF_Freeze_Supports", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BF_Support() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BF_Support").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1690; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:1690; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_BF_Support", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Brake_Motor() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Brake_Motor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1691; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:1691; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Brake_Motor", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Controls_Hand() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Controls_Hand").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1692; TYPE:PF
      result = "Left"
      '   END FORMULA; PROP ID:1692; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Controls_Hand", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_Number() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Number").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1693; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1693; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Conveyor_Number", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Debug_Mode() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Debug_Mode").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1806; TYPE:PF
      Result = False
If Not Me.Parent Is Nothing AndAlso Me.Parent.Properties.ContainsKey("Debug_Mode") Then
		Result = Me.Parent.Debug_Mode
End If
      '   END FORMULA; PROP ID:1806; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Debug_Mode", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Discharge_End_Idler() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Discharge_End_Idler").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1694; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1694; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Discharge_End_Idler", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Discharge_Idler() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Discharge_Idler").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1695; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1695; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Discharge_Idler", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Drip_Pan() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drip_Pan").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1696; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:1696; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Drip_Pan", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Drive_Belt() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drive_Belt").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1697; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1697; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Drive_Belt", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Drive_Hand() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drive_Hand").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1698; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1698; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Drive_Hand", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Drive_Location() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drive_Location").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1699; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1699; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Drive_Location", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Drive_Rating() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drive_Rating").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1847; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1847; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Drive_Rating", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Drive_Style() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drive_Style").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1700; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1700; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Drive_Style", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Drive_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drive_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1701; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1701; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Drive_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Dynamic_Auto_Slug() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Dynamic_Auto_Slug").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1702; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1702; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Dynamic_Auto_Slug", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Elevation_Entry() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Elevation_Entry").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1703; TYPE:PF
      result = 33.50
      '   END FORMULA; PROP ID:1703; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Elevation_Entry", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Elevation_Exit() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Elevation_Exit").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1704; TYPE:PF
      result = 33.50
      '   END FORMULA; PROP ID:1704; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Elevation_Exit", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Encoder_Roller() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Encoder_Roller").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1705; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1705; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Encoder_Roller", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Fill_Brush() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Fill_Brush").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1706; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1706; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Fill_Brush", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Filter_Regulator_Assy_Kit() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter_Regulator_Assy_Kit").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1707; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1707; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Filter_Regulator_Assy_Kit", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Filter_Regulator_Qty() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter_Regulator_Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1848; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:1848; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Filter_Regulator_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Floor_Length_Feet() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Floor_Length_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1708; TYPE:PF
      result = 33.50
      '   END FORMULA; PROP ID:1708; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Floor_Length_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_High_Volume_Acceptance() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("High_Volume_Acceptance").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1709; TYPE:PF
      result = 33.50
      '   END FORMULA; PROP ID:1709; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_High_Volume_Acceptance", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_High_Volume_Discharge() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("High_Volume_Discharge").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1710; TYPE:PF
      result = 33.50
      '   END FORMULA; PROP ID:1710; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_High_Volume_Discharge", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_HP_Override() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("HP_Override").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1711; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1711; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_HP_Override", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_IBTYPE() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("IBTYPE").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1712; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1712; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_IBTYPE", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Idler_Blade_Stop() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Idler_Blade_Stop").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1713; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1713; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Idler_Blade_Stop", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Idler_Brake_Module() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Idler_Brake_Module").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1714; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1714; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Idler_Brake_Module", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Idler_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Idler_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1849; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1849; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Idler_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Infeed_End_Idler() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Infeed_End_Idler").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1715; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1715; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Infeed_End_Idler", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Int_Bottom_Cover() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Int_Bottom_Cover").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1716; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1716; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Int_Bottom_Cover", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Int_Bottom_Cover_calculation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Int_Bottom_Cover_calculation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1850; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1850; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Int_Bottom_Cover_calculation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Int_Bottom_Cover_Qty() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Int_Bottom_Cover_Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1717; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1717; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Int_Bottom_Cover_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Int_Bottom_Cover_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Int_Bottom_Cover_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1718; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1718; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Int_Bottom_Cover_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Intermediate_Sensor_Location() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Intermediate_Sensor_Location").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1851; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1851; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Intermediate_Sensor_Location", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_IQZF_Belt_Length() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("IQZF_Belt_Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1852; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:1852; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_IQZF_Belt_Length", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_JSONObjectName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("JSONObjectName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1719; TYPE:PF
      result = "ConfigureSystem"
      '   END FORMULA; PROP ID:1719; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_JSONObjectName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_JSONObjectType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("JSONObjectType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1720; TYPE:PF
      result = "Element"
      '   END FORMULA; PROP ID:1720; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_JSONObjectType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Length() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1723; TYPE:PF
      result = 33.50
      '   END FORMULA; PROP ID:1723; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Length", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Length_Feet() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Length_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1724; TYPE:PF
      result = 30
      '   END FORMULA; PROP ID:1724; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Length_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Length_Inches() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Length_Inches").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1725; TYPE:PF
      result = 320
      '   END FORMULA; PROP ID:1725; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Length_Inches", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Live_Load() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Live_Load").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1726; TYPE:PF
      result = 17.75
      '   END FORMULA; PROP ID:1726; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Live_Load", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Lock_Bottom_Cover_Qty() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Lock_Bottom_Cover_Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1727; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1727; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Lock_Bottom_Cover_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Logic_Mode() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Logic_Mode").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1728; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1728; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Logic_Mode", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Lower_Transition() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Lower_Transition").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1729; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1729; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Lower_Transition", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Lower_Transition_Angle() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Lower_Transition_Angle").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1730; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1730; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Lower_Transition_Angle", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Lower_Transition_Belting_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Lower_Transition_Belting_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1731; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1731; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Lower_Transition_Belting_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Lower_Transition_Extension_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Lower_Transition_Extension_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1732; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1732; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Lower_Transition_Extension_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Lower_Transition_Extension_Inches() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Lower_Transition_Extension_Inches").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1733; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1733; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Lower_Transition_Extension_Inches", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Lower_Transition_Ratio() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Lower_Transition_Ratio").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1734; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1734; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Lower_Transition_Ratio", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Module_Placement() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Module_Placement").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1735; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1735; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Module_Placement", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_Class() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Class").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1736; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1736; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Motor_Class", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_HP() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1853; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:1853; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Motor_HP", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_MFG() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_MFG").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1737; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1737; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Motor_MFG", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_Mount() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Mount").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1738; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1738; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Motor_Mount", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_Voltage() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Voltage").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1739; TYPE:PF
      result = 460
      '   END FORMULA; PROP ID:1739; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Motor_Voltage", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Number_of_6ft_IntermediatesNumber_of_9ft_Intermed() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Number_of_6ft_IntermediatesNumber_of_9ft_Intermed").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1854; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:1854; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Number_of_6ft_IntermediatesNumber_of_9ft_Intermed", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Number_of_Modules() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Number_of_Modules").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1855; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:1855; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Number_of_Modules", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Paint_Color() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Paint_Color").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1740; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1740; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Paint_Color", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Power_Supply() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Power_Supply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1741; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1741; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Power_Supply", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Power_Supply_Qty() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Power_Supply_Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1856; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:1856; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Power_Supply_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Power_Unit_Hand() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Power_Unit_Hand").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1742; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1742; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Power_Unit_Hand", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Product() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1743; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1743; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Product", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Pull() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Pull").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1857; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1857; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Pull", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Pulley_Bearing() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Pulley_Bearing").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1744; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1744; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Pulley_Bearing", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Qty_5_Roller_Skew() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Qty_5_Roller_Skew").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1858; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:1858; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Qty_5_Roller_Skew", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Rail_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Rail_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1745; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1745; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Rail_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Reducer_MFG() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reducer_MFG").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1746; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1746; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Reducer_MFG", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Reducer_Motor_Mount() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reducer_Motor_Mount").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1747; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1747; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Reducer_Motor_Mount", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Reflector_Offset() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reflector_Offset").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1748; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1748; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Reflector_Offset", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Roller() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Roller").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1749; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1749; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Roller", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Roller_Bearings() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Roller_Bearings").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1750; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1750; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Roller_Bearings", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Roller_Center() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Roller_Center").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1751; TYPE:PF
      result = 17.75
      '   END FORMULA; PROP ID:1751; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Roller_Center", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Roller_Position() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Roller_Position").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1752; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1752; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Roller_Position", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Roller_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Roller_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1753; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1753; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Roller_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Section_Length() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Section_Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1754; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1754; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Section_Length", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sensor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sensor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1755; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1755; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Sensor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Side_Guide_Left() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Side_Guide_Left").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1756; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1756; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Side_Guide_Left", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Side_Guide_Mount() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Side_Guide_Mount").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1757; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1757; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Side_Guide_Mount", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Side_Guide_Right() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Side_Guide_Right").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1758; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1758; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Side_Guide_Right", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Skatewheel_Side_Guide() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Skatewheel_Side_Guide").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1759; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1759; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Skatewheel_Side_Guide", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Skew_Feet() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Skew_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1760; TYPE:PF
      result = 1.5
      '   END FORMULA; PROP ID:1760; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Skew_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Skew_Hand() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Skew_Hand").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1761; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1761; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Skew_Hand", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Slug_Acceptance() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Slug_Acceptance").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1762; TYPE:PF
      result = 7.5
      '   END FORMULA; PROP ID:1762; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Slug_Acceptance", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Slug_Discharge() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Slug_Discharge").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1763; TYPE:PF
      result = 3.75
      '   END FORMULA; PROP ID:1763; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Slug_Discharge", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Soft_Start() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Soft_Start").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1859; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1859; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Soft_Start", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1764; TYPE:PF
      result = 32
      '   END FORMULA; PROP ID:1764; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Speed", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1765; TYPE:PF
      result = 432
      '   END FORMULA; PROP ID:1765; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Speed_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_FPM_Actual() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_FPM_Actual").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1860; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:1860; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Speed_FPM_Actual", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_ISC() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_ISC").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1861; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1861; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Speed_ISC", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Style() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Style").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1766; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1766; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Style", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Support_Hardware() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Support_Hardware").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1767; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1767; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Support_Hardware", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Support_Paint_Elevation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Support_Paint_Elevation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1768; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1768; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Support_Paint_Elevation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Support_Paint_Option() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Support_Paint_Option").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1769; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1769; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Support_Paint_Option", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Support_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Support_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1770; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1770; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Support_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Takeup_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Takeup_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1771; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1771; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Takeup_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Throughput_CFPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Throughput_CFPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1862; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:1862; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Throughput_CFPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Time_Delay_PE() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Time_Delay_PE").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1772; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1772; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Time_Delay_PE", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TU_Prox_Sensor() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TU_Prox_Sensor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1773; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1773; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_TU_Prox_Sensor", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Upper_Transition() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Upper_Transition").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1774; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1774; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Upper_Transition", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Upper_Transition_Angle() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Upper_Transition_Angle").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1775; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1775; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Upper_Transition_Angle", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Upper_Transition_Extension_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Upper_Transition_Extension_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1776; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1776; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Upper_Transition_Extension_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Upper_Transition_Extension_Inches() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Upper_Transition_Extension_Inches").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1777; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1777; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Upper_Transition_Extension_Inches", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Upstream_Conv_Connection() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Upstream_Conv_Connection").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1778; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1778; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Upstream_Conv_Connection", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_VFD() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("VFD").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1863; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1863; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_VFD", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Width() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Width").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1779; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1779; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Width", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_XMLObjectName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("XMLObjectName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1721; TYPE:PF
      result = "ConfigureSystem"
      '   END FORMULA; PROP ID:1721; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_XMLObjectName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_XMLObjectType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("XMLObjectType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1722; TYPE:PF
      result = "Element"
      '   END FORMULA; PROP ID:1722; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_XMLObjectType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Zone_Control() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Zone_Control").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1780; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1780; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Zone_Control", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Zone_Length() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Zone_Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1781; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1781; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Zone_Length", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Zoneflex_Manager() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Zoneflex_Manager").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1782; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1782; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Zoneflex_Manager", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Actuation_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Add_One_Support_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Width_Offset_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belting_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BF_Freeze_Intermediates_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BF_Freeze_Supports_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BF_Support_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Brake_Motor_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controls_Hand_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Number_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Debug_Mode_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Discharge_End_Idler_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Discharge_Idler_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drip_Pan_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Belt_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Hand_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Location_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Rating_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Style_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Dynamic_Auto_Slug_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elevation_Entry_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elevation_Exit_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Encoder_Roller_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Fill_Brush_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter_Regulator_Assy_Kit_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter_Regulator_Qty_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Floor_Length_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_High_Volume_Acceptance_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_High_Volume_Discharge_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HP_Override_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IBTYPE_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Idler_Blade_Stop_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Idler_Brake_Module_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Idler_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Infeed_End_Idler_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Int_Bottom_Cover_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Int_Bottom_Cover_calculation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Int_Bottom_Cover_Qty_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Int_Bottom_Cover_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Intermediate_Sensor_Location_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IQZF_Belt_Length_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_JSONObjectName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_JSONObjectType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_Inches_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Live_Load_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lock_Bottom_Cover_Qty_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Logic_Mode_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Angle_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Belting_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Extension_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Extension_Inches_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Ratio_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Module_Placement_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Class_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_HP_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_MFG_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Mount_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Voltage_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Number_of_6ft_IntermediatesNumber_of_9ft_Intermed_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Number_of_Modules_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Paint_Color_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Power_Supply_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Power_Supply_Qty_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Power_Unit_Hand_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pull_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pulley_Bearing_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_5_Roller_Skew_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Rail_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reducer_MFG_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reducer_Motor_Mount_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reflector_Offset_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_Bearings_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_Center_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_Position_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Section_Length_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sensor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Side_Guide_Left_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Side_Guide_Mount_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Side_Guide_Right_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Skatewheel_Side_Guide_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Skew_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Skew_Hand_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Slug_Acceptance_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Slug_Discharge_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Soft_Start_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_FPM_Actual_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_ISC_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Style_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Hardware_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Paint_Elevation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Paint_Option_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Takeup_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Throughput_CFPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Time_Delay_PE_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TU_Prox_Sensor_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upper_Transition_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upper_Transition_Angle_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upper_Transition_Extension_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upper_Transition_Extension_Inches_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upstream_Conv_Connection_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VFD_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Width_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zone_Control_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zone_Length_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zoneflex_Manager_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Actuation_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Add_One_Support_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Width_Offset_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belting_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BF_Freeze_Intermediates_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BF_Freeze_Supports_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BF_Support_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Brake_Motor_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controls_Hand_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Number_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Debug_Mode_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Discharge_End_Idler_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Discharge_Idler_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drip_Pan_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Belt_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Hand_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Location_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Rating_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Style_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Dynamic_Auto_Slug_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elevation_Entry_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elevation_Exit_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Encoder_Roller_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Fill_Brush_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter_Regulator_Assy_Kit_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter_Regulator_Qty_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Floor_Length_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_High_Volume_Acceptance_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_High_Volume_Discharge_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HP_Override_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IBTYPE_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Idler_Blade_Stop_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Idler_Brake_Module_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Idler_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Infeed_End_Idler_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Int_Bottom_Cover_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Int_Bottom_Cover_calculation_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Int_Bottom_Cover_Qty_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Int_Bottom_Cover_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Intermediate_Sensor_Location_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IQZF_Belt_Length_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_JSONObjectName_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_JSONObjectType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_Inches_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Live_Load_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lock_Bottom_Cover_Qty_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Logic_Mode_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Angle_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Belting_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Extension_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Extension_Inches_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Ratio_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Module_Placement_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Class_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_HP_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_MFG_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Mount_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Voltage_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Number_of_6ft_IntermediatesNumber_of_9ft_Intermed_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Number_of_Modules_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Paint_Color_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Power_Supply_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Power_Supply_Qty_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Power_Unit_Hand_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pull_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pulley_Bearing_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_5_Roller_Skew_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Rail_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reducer_MFG_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reducer_Motor_Mount_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reflector_Offset_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_Bearings_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_Center_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_Position_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Section_Length_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sensor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Side_Guide_Left_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Side_Guide_Mount_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Side_Guide_Right_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Skatewheel_Side_Guide_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Skew_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Skew_Hand_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Slug_Acceptance_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Slug_Discharge_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Soft_Start_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_FPM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_FPM_Actual_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_ISC_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Style_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Hardware_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Paint_Elevation_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Paint_Option_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Takeup_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Throughput_CFPM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Time_Delay_PE_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TU_Prox_Sensor_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upper_Transition_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upper_Transition_Angle_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upper_Transition_Extension_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upper_Transition_Extension_Inches_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upstream_Conv_Connection_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VFD_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Width_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectName_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zone_Control_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zone_Length_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zoneflex_Manager_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Actuation_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Actuation_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1684; TYPE:VV
      result = MakeValidValues(Array("24v","120v"))
      '   END FORMULA; PROP ID:1684; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Actuation_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Add_One_Support_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Add_One_Support").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1685; TYPE:VV
      result = MakeValidValues(Array("Yes","No"))
      '   END FORMULA; PROP ID:1685; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Add_One_Support_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controls_Hand_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Controls_Hand").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1692; TYPE:VV
      result = MakeValidValues(Array("Left","Right"))
      '   END FORMULA; PROP ID:1692; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Controls_Hand_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Discharge_Idler_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Discharge_Idler").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1695; TYPE:VV
      result = MakeValidValues(Array("3ft-Zone","6ft-Zone"))
      '   END FORMULA; PROP ID:1695; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Discharge_Idler_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drip_Pan_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drip_Pan").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1696; TYPE:VV
      result = MakeValidValues(Array("Yes","No"))
      '   END FORMULA; PROP ID:1696; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Drip_Pan_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Belt_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drive_Belt").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1697; TYPE:VV
      result = MakeValidValues(Array("Standard","Heavy Duty"))
      '   END FORMULA; PROP ID:1697; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Drive_Belt_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Hand_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drive_Hand").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1698; TYPE:VV
      result = MakeValidValues(Array("Left","Right"))
      '   END FORMULA; PROP ID:1698; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Drive_Hand_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Rating_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drive_Rating").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1847; TYPE:VV
      result = MakeValidValues(Array("300","600"))
      '   END FORMULA; PROP ID:1847; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Drive_Rating_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drive_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1701; TYPE:VV
      result = MakeValidValues(Array("Belt","Chain"))
      '   END FORMULA; PROP ID:1701; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Drive_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elevation_Entry_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Elevation_Entry").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1703; TYPE:VV
      result = MakeValidValues(Array("Decimal number (no limitation)"))
      '   END FORMULA; PROP ID:1703; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Elevation_Entry_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elevation_Exit_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Elevation_Exit").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1704; TYPE:VV
      result = MakeValidValues(Array("Decimal number (no limitation)"))
      '   END FORMULA; PROP ID:1704; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Elevation_Exit_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HP_Override_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("HP_Override").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1711; TYPE:VV
      result = MakeValidValues(Array("0.75","1","1.5","2","3","5","7.5"))
      '   END FORMULA; PROP ID:1711; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_HP_Override_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Idler_Blade_Stop_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Idler_Blade_Stop").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1713; TYPE:VV
      result = MakeValidValues(Array("No","Yes"))
      '   END FORMULA; PROP ID:1713; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Idler_Blade_Stop_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Idler_Brake_Module_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Idler_Brake_Module").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1714; TYPE:VV
      result = MakeValidValues(Array("No","Yes"))
      '   END FORMULA; PROP ID:1714; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Idler_Brake_Module_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Idler_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Idler_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1849; TYPE:VV
      result = MakeValidValues(Array("Standard","PTO"))
      '   END FORMULA; PROP ID:1849; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Idler_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Int_Bottom_Cover_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Int_Bottom_Cover_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1718; TYPE:VV
      result = MakeValidValues(Array("Molded J Leg-ClipScrew","Molded ClipScrew BothSides"))
      '   END FORMULA; PROP ID:1718; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Int_Bottom_Cover_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Intermediate_Sensor_Location_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Intermediate_Sensor_Location").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1851; TYPE:VV
      result = MakeValidValues(Array("12 inches","24 inches"))
      '   END FORMULA; PROP ID:1851; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Intermediate_Sensor_Location_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Logic_Mode_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Logic_Mode").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1728; TYPE:VV
      result = MakeValidValues(Array("1 and 2 Zone Accumulation","1 Zone Accumulation","0 and 1 Zone Accumulation","2 Zone Accumulation"))
      '   END FORMULA; PROP ID:1728; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Logic_Mode_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Module_Placement_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Module_Placement").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1735; TYPE:VV
      result = MakeValidValues(Array("Inside Frame","Outside Frame"))
      '   END FORMULA; PROP ID:1735; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Module_Placement_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Class_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Class").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1736; TYPE:VV
      result = MakeValidValues(Array("Premium"))
      '   END FORMULA; PROP ID:1736; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Motor_Class_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_MFG_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_MFG").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1737; TYPE:VV
      result = MakeValidValues(Array("Baldor-Reliance","Honeywell"))
      '   END FORMULA; PROP ID:1737; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Motor_MFG_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Voltage_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Voltage").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1739; TYPE:VV
      result = MakeValidValues(Array("","460","575","380-60","380-50"))
      '   END FORMULA; PROP ID:1739; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Motor_Voltage_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Number_of_Modules_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Number_of_Modules").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1855; TYPE:VV
      result = MakeValidValues(Array("Integer "))
      '   END FORMULA; PROP ID:1855; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Number_of_Modules_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Power_Supply_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Power_Supply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1741; TYPE:VV
      result = MakeValidValues(Array("None","NEMA 12 enclosure"))
      '   END FORMULA; PROP ID:1741; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Power_Supply_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Power_Supply_Qty_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Power_Supply_Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1856; TYPE:VV
      result = MakeValidValues(Array("1","2"))
      '   END FORMULA; PROP ID:1856; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Power_Supply_Qty_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1743; TYPE:VV
      result = MakeValidValues(Array("Complete Conveyor","Infeed Idler Section","Drive Section","Intermediate Section","Discharge Idler Section"))
      '   END FORMULA; PROP ID:1743; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Product_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pulley_Bearing_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Pulley_Bearing").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1744; TYPE:VV
      result = MakeValidValues(Array("Standard","D-Lok"))
      '   END FORMULA; PROP ID:1744; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Pulley_Bearing_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_5_Roller_Skew_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Qty_5_Roller_Skew").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1858; TYPE:VV
      result = MakeValidValues(Array("default 0"))
      '   END FORMULA; PROP ID:1858; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Qty_5_Roller_Skew_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reducer_MFG_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reducer_MFG").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1746; TYPE:VV
      result = MakeValidValues(Array("Dodge","Boston"))
      '   END FORMULA; PROP ID:1746; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Reducer_MFG_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reducer_Motor_Mount_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reducer_Motor_Mount").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1747; TYPE:VV
      result = MakeValidValues(Array("Standard","Low Profile","Low Profile Direct Drive","Top Mount Direct Drive"))
      '   END FORMULA; PROP ID:1747; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Reducer_Motor_Mount_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reflector_Offset_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reflector_Offset").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1748; TYPE:VV
      result = MakeValidValues(Array("0 inch","3 inch","6 inch"))
      '   END FORMULA; PROP ID:1748; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Reflector_Offset_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_Bearings_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Roller_Bearings").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1750; TYPE:VV
      result = MakeValidValues(Array("Abec BK","Abec","Premium HS","Abec BK CT","Premium HS CT"))
      '   END FORMULA; PROP ID:1750; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Roller_Bearings_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_Center_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Roller_Center").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1751; TYPE:VV
      result = MakeValidValues(Array("2","3"))
      '   END FORMULA; PROP ID:1751; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Roller_Center_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Section_Length_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Section_Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1754; TYPE:VV
      result = MakeValidValues(Array("6-0","9-0","12-0"))
      '   END FORMULA; PROP ID:1754; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Section_Length_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sensor_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sensor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1755; TYPE:VV
      result = MakeValidValues(Array("Retro Reflective Side Guide Mount","Retro Reflective Frame Mount Factory","Under Roller Sensor Mount Factory","Adjustable Under Roller Sensor","Dual Under Roller Sensor"))
      '   END FORMULA; PROP ID:1755; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Sensor_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Side_Guide_Left_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Side_Guide_Left").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1756; TYPE:VV
      result = MakeValidValues(Array("None","2.5 Channel","2.5 Channel PE-Refl","6.5 Channel","6.5 Channel PE-Refl","10 Channel","10 Channel PE-Refl","1 UHMW"))
      '   END FORMULA; PROP ID:1756; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Side_Guide_Left_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Side_Guide_Mount_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Side_Guide_Mount").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1757; TYPE:VV
      result = MakeValidValues(Array("Bolted","Offset","Offset Spacer","None"))
      '   END FORMULA; PROP ID:1757; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Side_Guide_Mount_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Side_Guide_Right_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Side_Guide_Right").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1758; TYPE:VV
      result = MakeValidValues(Array("None","2.5 Channel","2.5 Channel PE-Refl","6.5 Channel","6.5 Channel PE-Refl","10 Channel","10 Channel PE-Refl","1 UHMW"))
      '   END FORMULA; PROP ID:1758; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Side_Guide_Right_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Skatewheel_Side_Guide_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Skatewheel_Side_Guide").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1759; TYPE:VV
      result = MakeValidValues(Array("None","Photo Eye","Reflector","Without PE or Reflector"))
      '   END FORMULA; PROP ID:1759; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Skatewheel_Side_Guide_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Skew_Hand_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Skew_Hand").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1761; TYPE:VV
      result = MakeValidValues(Array("Left","Right"))
      '   END FORMULA; PROP ID:1761; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Skew_Hand_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Soft_Start_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Soft_Start").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1859; TYPE:VV
      result = MakeValidValues(Array("Yes","No"))
      '   END FORMULA; PROP ID:1859; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Soft_Start_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_FPM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1765; TYPE:VV
      result = MakeValidValues(Array("60","90","120","150","180","210","240","270","300","350","400","450","500"))
      '   END FORMULA; PROP ID:1765; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Speed_FPM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_FPM_Actual_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_FPM_Actual").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1860; TYPE:VV
      result = MakeValidValues(Array("70","100","135","170","205","240","270","305","340","400","450"))
      '   END FORMULA; PROP ID:1860; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Speed_FPM_Actual_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Style_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Style").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1766; TYPE:VV
      result = MakeValidValues(Array("Straight"))
      '   END FORMULA; PROP ID:1766; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Style_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Hardware_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Support_Hardware").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1767; TYPE:VV
      result = MakeValidValues(Array("Grade 5","None","GR5 IsoPad"))
      '   END FORMULA; PROP ID:1767; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Support_Hardware_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Paint_Elevation_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Support_Paint_Elevation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1768; TYPE:VV
      result = MakeValidValues(Array("0 to 256"))
      '   END FORMULA; PROP ID:1768; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Support_Paint_Elevation_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Paint_Option_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Support_Paint_Option").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1769; TYPE:VV
      result = MakeValidValues(Array("Yes","No"))
      '   END FORMULA; PROP ID:1769; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Support_Paint_Option_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Support_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1770; TYPE:VV
      result = MakeValidValues(Array("Ceiling Hanger","Floor Support","None"))
      '   END FORMULA; PROP ID:1770; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Support_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Time_Delay_PE_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Time_Delay_PE").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1772; TYPE:VV
      result = MakeValidValues(Array("No","Yes"))
      '   END FORMULA; PROP ID:1772; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Time_Delay_PE_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TU_Prox_Sensor_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TU_Prox_Sensor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1773; TYPE:VV
      result = MakeValidValues(Array("No","Yes"))
      '   END FORMULA; PROP ID:1773; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_TU_Prox_Sensor_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upstream_Conv_Connection_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Upstream_Conv_Connection").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1778; TYPE:VV
      result = MakeValidValues(Array("FK-2","FK-3","FK-4","FK-5","FK-8","FK-10","FK-12","FK-15","FK-22","FK-26","FK-40","FK-44","FK-46","None"))
      '   END FORMULA; PROP ID:1778; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Upstream_Conv_Connection_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VFD_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("VFD").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1863; TYPE:VV
      result = MakeValidValues(Array("Yes","No"))
      '   END FORMULA; PROP ID:1863; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_VFD_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Width_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Width").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1779; TYPE:VV
      result = MakeValidValues(Array("16","22","28","34","40"))
      '   END FORMULA; PROP ID:1779; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Width_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zone_Control_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Zone_Control").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1780; TYPE:VV
      result = MakeValidValues(Array("Standard","Advanced","Transportation"))
      '   END FORMULA; PROP ID:1780; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Zone_Control_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zone_Length_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Zone_Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1781; TYPE:VV
      result = MakeValidValues(Array("3 ft zones","6 ft zones"))
      '   END FORMULA; PROP ID:1781; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Zone_Length_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zoneflex_Manager_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Zoneflex_Manager").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1782; TYPE:VV
      result = MakeValidValues(Array("Profibus","DeviceNet","Ethernet/IP","USB","None","EtherCAT","Profinet"))
      '   END FORMULA; PROP ID:1782; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_DBG_ConfigureSystem.Formula_Zoneflex_Manager_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Function GetRecordsetSQL(ByVal lngDBConID as Long) as String Implements RuleStream.IRsPartFormulas.GetRecordsetSQL
    Dim strSelectStmt As String = ""
    Return strSelectStmt
    End Function
    #End Region

    #Region "Event Handling "
    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Overrides Sub AddRsEventHandlerMappings()
    
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Overrides Sub RemoveRsEventHandlerMappings()
    
    End Sub
    #End Region

    End Class

  