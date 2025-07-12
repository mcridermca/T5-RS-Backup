Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: OCTTMP01
'$ PartFamily: OCT_ConfigureSystem
'$ GenerateDate: 07/07/2025 15:25:25

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

    Public Class [OCT_ConfigureSystem]
    
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

    Private this as OCT_ConfigureSystem = me

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
    
          Public Property [Debug_Mode]() As Boolean
      Get
      Return Properties("Debug_Mode").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Debug_Mode").CalculatedValue = Value
      End Set
      End Property
    
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
    
          Public Property [BF_Freeze_Intermediates]() As String
      Get
      Return Properties("BF_Freeze_Intermediates").Value
      End Get
      Set(ByVal Value As String)
      Properties("BF_Freeze_Intermediates").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BF_Freeze_Supports]() As String
      Get
      Return Properties("BF_Freeze_Supports").Value
      End Get
      Set(ByVal Value As String)
      Properties("BF_Freeze_Supports").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BF_Support]() As String
      Get
      Return Properties("BF_Support").Value
      End Get
      Set(ByVal Value As String)
      Properties("BF_Support").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Brake_Motor]() As String
      Get
      Return Properties("Brake_Motor").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [Drip_Pan]() As String
      Get
      Return Properties("Drip_Pan").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [Elevation_Entry]() As String
      Get
      Return Properties("Elevation_Entry").Value
      End Get
      Set(ByVal Value As String)
      Properties("Elevation_Entry").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Elevation_Exit]() As String
      Get
      Return Properties("Elevation_Exit").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [Filter_Regulator_Qty]() As String
      Get
      Return Properties("Filter_Regulator_Qty").Value
      End Get
      Set(ByVal Value As String)
      Properties("Filter_Regulator_Qty").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Floor_Length_Feet]() As String
      Get
      Return Properties("Floor_Length_Feet").Value
      End Get
      Set(ByVal Value As String)
      Properties("Floor_Length_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [High_Volume_Acceptance]() As String
      Get
      Return Properties("High_Volume_Acceptance").Value
      End Get
      Set(ByVal Value As String)
      Properties("High_Volume_Acceptance").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [High_Volume_Discharge]() As String
      Get
      Return Properties("High_Volume_Discharge").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [IQZF_Belt_Length]() As String
      Get
      Return Properties("IQZF_Belt_Length").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [JSONObjectValue]() As String
      Get
      Return Properties("JSONObjectValue").Value
      End Get
      Set(ByVal Value As String)
      Properties("JSONObjectValue").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Length]() As String
      Get
      Return Properties("Length").Value
      End Get
      Set(ByVal Value As String)
      Properties("Length").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Length_Feet]() As String
      Get
      Return Properties("Length_Feet").Value
      End Get
      Set(ByVal Value As String)
      Properties("Length_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Length_Inches]() As String
      Get
      Return Properties("Length_Inches").Value
      End Get
      Set(ByVal Value As String)
      Properties("Length_Inches").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Live_Load]() As String
      Get
      Return Properties("Live_Load").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [Motor_HP]() As String
      Get
      Return Properties("Motor_HP").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [Motor_Voltage]() As String
      Get
      Return Properties("Motor_Voltage").Value
      End Get
      Set(ByVal Value As String)
      Properties("Motor_Voltage").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Number_of_6ft_IntermediatesNumber_of_9ft_Intermed]() As String
      Get
      Return Properties("Number_of_6ft_IntermediatesNumber_of_9ft_Intermed").Value
      End Get
      Set(ByVal Value As String)
      Properties("Number_of_6ft_IntermediatesNumber_of_9ft_Intermed").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Number_of_Modules]() As String
      Get
      Return Properties("Number_of_Modules").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [Power_Supply_Qty]() As String
      Get
      Return Properties("Power_Supply_Qty").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [Qty_5_Roller_Skew]() As String
      Get
      Return Properties("Qty_5_Roller_Skew").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [Roller_Center]() As String
      Get
      Return Properties("Roller_Center").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [Skew_Feet]() As String
      Get
      Return Properties("Skew_Feet").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [Slug_Acceptance]() As String
      Get
      Return Properties("Slug_Acceptance").Value
      End Get
      Set(ByVal Value As String)
      Properties("Slug_Acceptance").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Slug_Discharge]() As String
      Get
      Return Properties("Slug_Discharge").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [Speed]() As String
      Get
      Return Properties("Speed").Value
      End Get
      Set(ByVal Value As String)
      Properties("Speed").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_FPM]() As String
      Get
      Return Properties("Speed_FPM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Speed_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_FPM_Actual]() As String
      Get
      Return Properties("Speed_FPM_Actual").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [Throughput_CFPM]() As String
      Get
      Return Properties("Throughput_CFPM").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [XMLObjectValue]() As String
      Get
      Return Properties("XMLObjectValue").Value
      End Get
      Set(ByVal Value As String)
      Properties("XMLObjectValue").CalculatedValue = Value
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
    
      Public ReadOnly Property [MySource]() As Rulestream.Kernel.Connection
      Get
      Return Connections("MySource")
      End Get
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
    InitPart("OCT_ConfigureSystem", <a><![CDATA[OCT_ConfigureSystem]]></a>.Value, 322, "OCTTMP01",  "N", "N", False, False, "In Development", "", "Oracle Transfer ConfigureSystem Object", "", "", "",  "GLOBAL\H601424", "07/07/2025 15:25:06")
    AddProperty("2145", "Debug_Mode", <a><![CDATA[Debug_Mode]]></a>.Value, "True = Debug On / False = Debug Off", "Boolean","","Debugging","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1842", "Actuation_Type", <a><![CDATA[Actuation_Type]]></a>.Value, "Actuation Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1843", "Add_One_Support", <a><![CDATA[Add_One_Support]]></a>.Value, "Add One Support", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "7/7/2025 3:25:06 PM")
    AddProperty("1844", "Belt_Width_Offset", <a><![CDATA[Belt_Width_Offset]]></a>.Value, "Belt Width Offset", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1845", "Belting_Type", <a><![CDATA[Belting_Type]]></a>.Value, "Belting Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1846", "BF_Freeze_Intermediates", <a><![CDATA[BF_Freeze_Intermediates]]></a>.Value, "BF Freeze Intermediates", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1847", "BF_Freeze_Supports", <a><![CDATA[BF_Freeze_Supports]]></a>.Value, "BF Freeze Supports", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1848", "BF_Support", <a><![CDATA[BF_Support]]></a>.Value, "BF Support", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1849", "Brake_Motor", <a><![CDATA[Brake_Motor]]></a>.Value, "Brake Motor", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1850", "Controls_Hand", <a><![CDATA[Controls_Hand]]></a>.Value, "Controls Hand", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1851", "Conveyor_Number", <a><![CDATA[Conveyor_Number]]></a>.Value, "Conveyor Number", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1852", "Discharge_End_Idler", <a><![CDATA[Discharge_End_Idler]]></a>.Value, "Discharge End Idler", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1853", "Discharge_Idler", <a><![CDATA[Discharge_Idler]]></a>.Value, "Discharge Idler", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1854", "Drip_Pan", <a><![CDATA[Drip_Pan]]></a>.Value, "Drip Pan", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1855", "Drive_Belt", <a><![CDATA[Drive_Belt]]></a>.Value, "Drive Belt", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1856", "Drive_Hand", <a><![CDATA[Drive_Hand]]></a>.Value, "Drive Hand", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1857", "Drive_Location", <a><![CDATA[Drive_Location]]></a>.Value, "Drive Location", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("2162", "Drive_Rating", <a><![CDATA[Drive_Rating]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("1858", "Drive_Style", <a><![CDATA[Drive_Style]]></a>.Value, "Drive Style", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1859", "Drive_Type", <a><![CDATA[Drive_Type]]></a>.Value, "Drive Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1860", "Dynamic_Auto_Slug", <a><![CDATA[Dynamic_Auto_Slug]]></a>.Value, "Dynamic Auto Slug", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1861", "Elevation_Entry", <a><![CDATA[Elevation_Entry]]></a>.Value, "Elevation Entry", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1862", "Elevation_Exit", <a><![CDATA[Elevation_Exit]]></a>.Value, "Elevation Exit", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1863", "Encoder_Roller", <a><![CDATA[Encoder_Roller]]></a>.Value, "Encoder Roller", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1864", "Fill_Brush", <a><![CDATA[Fill_Brush]]></a>.Value, "Fill Brush", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1865", "Filter_Regulator_Assy_Kit", <a><![CDATA[Filter_Regulator_Assy_Kit]]></a>.Value, "Filter Regulator Assy Kit", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("2163", "Filter_Regulator_Qty", <a><![CDATA[Filter_Regulator_Qty]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("1866", "Floor_Length_Feet", <a><![CDATA[Floor_Length_Feet]]></a>.Value, "Floor Length Feet", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1867", "High_Volume_Acceptance", <a><![CDATA[High_Volume_Acceptance]]></a>.Value, "High Volume Acceptance", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1868", "High_Volume_Discharge", <a><![CDATA[High_Volume_Discharge]]></a>.Value, "High Volume Discharge", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1869", "HP_Override", <a><![CDATA[HP_Override]]></a>.Value, "HP Override", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1870", "IBTYPE", <a><![CDATA[IBTYPE]]></a>.Value, "IBTYPE", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:24 AM")
    AddProperty("1871", "Idler_Blade_Stop", <a><![CDATA[Idler_Blade_Stop]]></a>.Value, "Idler Blade Stop", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1872", "Idler_Brake_Module", <a><![CDATA[Idler_Brake_Module]]></a>.Value, "Idler Brake Module", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("2164", "Idler_Type", <a><![CDATA[Idler_Type]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("1873", "Infeed_End_Idler", <a><![CDATA[Infeed_End_Idler]]></a>.Value, "Infeed End Idler", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1874", "Int_Bottom_Cover", <a><![CDATA[Int_Bottom_Cover]]></a>.Value, "Int Bottom Cover", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("2165", "Int_Bottom_Cover_calculation", <a><![CDATA[Int_Bottom_Cover_calculation]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("1875", "Int_Bottom_Cover_Qty", <a><![CDATA[Int_Bottom_Cover_Qty]]></a>.Value, "Int Bottom Cover Qty", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1876", "Int_Bottom_Cover_Type", <a><![CDATA[Int_Bottom_Cover_Type]]></a>.Value, "Int Bottom Cover Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("2166", "Intermediate_Sensor_Location", <a><![CDATA[Intermediate_Sensor_Location]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("2167", "IQZF_Belt_Length", <a><![CDATA[IQZF_Belt_Length]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("1877", "JSONObjectName", <a><![CDATA[JSONObjectName]]></a>.Value, "JSON Export Object Name", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1878", "JSONObjectType", <a><![CDATA[JSONObjectType]]></a>.Value, "JSON Export Object Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("2150", "JSONObjectValue", <a><![CDATA[JSONObjectValue]]></a>.Value, "JSON Export Object Value", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1881", "Length", <a><![CDATA[Length]]></a>.Value, "Length", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1882", "Length_Feet", <a><![CDATA[Length_Feet]]></a>.Value, "Length Feet", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1883", "Length_Inches", <a><![CDATA[Length_Inches]]></a>.Value, "Length Inches", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1884", "Live_Load", <a><![CDATA[Live_Load]]></a>.Value, "Live Load", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1885", "Lock_Bottom_Cover_Qty", <a><![CDATA[Lock_Bottom_Cover_Qty]]></a>.Value, "Lock Bottom Cover Qty", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1886", "Logic_Mode", <a><![CDATA[Logic_Mode]]></a>.Value, "Logic Mode", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1887", "Lower_Transition", <a><![CDATA[Lower_Transition]]></a>.Value, "Lower Transition", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1888", "Lower_Transition_Angle", <a><![CDATA[Lower_Transition_Angle]]></a>.Value, "Lower Transition Angle", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1889", "Lower_Transition_Belting_Type", <a><![CDATA[Lower_Transition_Belting_Type]]></a>.Value, "Lower Transition Belting Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1890", "Lower_Transition_Extension_Feet", <a><![CDATA[Lower_Transition_Extension_Feet]]></a>.Value, "Lower Transition Extension Feet", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1891", "Lower_Transition_Extension_Inches", <a><![CDATA[Lower_Transition_Extension_Inches]]></a>.Value, "Lower Transition Extension Inches", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1892", "Lower_Transition_Ratio", <a><![CDATA[Lower_Transition_Ratio]]></a>.Value, "Lower Transition Ratio", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1893", "Module_Placement", <a><![CDATA[Module_Placement]]></a>.Value, "Module Placement", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1894", "Motor_Class", <a><![CDATA[Motor_Class]]></a>.Value, "Motor Class", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("2168", "Motor_HP", <a><![CDATA[Motor_HP]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("1895", "Motor_MFG", <a><![CDATA[Motor_MFG]]></a>.Value, "Motor MFG", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1896", "Motor_Mount", <a><![CDATA[Motor_Mount]]></a>.Value, "Motor Mount", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1897", "Motor_Voltage", <a><![CDATA[Motor_Voltage]]></a>.Value, "Motor Voltage", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("2169", "Number_of_6ft_IntermediatesNumber_of_9ft_Intermed", <a><![CDATA[Number_of_6ft_Intermediates
Number_of_9ft_Intermediates
Number_of_12ft_Intermediates]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("2170", "Number_of_Modules", <a><![CDATA[Number_of_Modules]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("1898", "Paint_Color", <a><![CDATA[Paint_Color]]></a>.Value, "Paint Color", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1899", "Power_Supply", <a><![CDATA[Power_Supply]]></a>.Value, "Power Supply", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("2171", "Power_Supply_Qty", <a><![CDATA[Power_Supply_Qty]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("1900", "Power_Unit_Hand", <a><![CDATA[Power_Unit_Hand]]></a>.Value, "Power Unit Hand", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1901", "Product", <a><![CDATA[Product]]></a>.Value, "Product", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("2172", "Pull", <a><![CDATA[Pull]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("1902", "Pulley_Bearing", <a><![CDATA[Pulley_Bearing]]></a>.Value, "Pulley Bearing", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("2173", "Qty_5_Roller_Skew", <a><![CDATA[Qty_5_Roller_Skew]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("1903", "Rail_Type", <a><![CDATA[Rail_Type]]></a>.Value, "Rail Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1904", "Reducer_MFG", <a><![CDATA[Reducer_MFG]]></a>.Value, "Reducer MFG", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1905", "Reducer_Motor_Mount", <a><![CDATA[Reducer_Motor_Mount]]></a>.Value, "Reducer Motor Mount", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1906", "Reflector_Offset", <a><![CDATA[Reflector_Offset]]></a>.Value, "Reflector Offset", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:25 AM")
    AddProperty("1907", "Roller", <a><![CDATA[Roller]]></a>.Value, "Roller", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1908", "Roller_Bearings", <a><![CDATA[Roller_Bearings]]></a>.Value, "Roller Bearings", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1909", "Roller_Center", <a><![CDATA[Roller_Center]]></a>.Value, "Roller Center", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1910", "Roller_Position", <a><![CDATA[Roller_Position]]></a>.Value, "Roller Position", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1911", "Roller_Type", <a><![CDATA[Roller_Type]]></a>.Value, "Roller Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1912", "Section_Length", <a><![CDATA[Section_Length]]></a>.Value, "Section Length", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1913", "Sensor_Type", <a><![CDATA[Sensor_Type]]></a>.Value, "Sensor Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1914", "Side_Guide_Left", <a><![CDATA[Side_Guide_Left]]></a>.Value, "Side Guide Left", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1915", "Side_Guide_Mount", <a><![CDATA[Side_Guide_Mount]]></a>.Value, "Side Guide Mount", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1916", "Side_Guide_Right", <a><![CDATA[Side_Guide_Right]]></a>.Value, "Side Guide Right", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1917", "Skatewheel_Side_Guide", <a><![CDATA[Skatewheel_Side_Guide]]></a>.Value, "Skatewheel Side Guide", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1918", "Skew_Feet", <a><![CDATA[Skew_Feet]]></a>.Value, "Skew Feet", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1919", "Skew_Hand", <a><![CDATA[Skew_Hand]]></a>.Value, "Skew Hand", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1920", "Slug_Acceptance", <a><![CDATA[Slug_Acceptance]]></a>.Value, "Slug Acceptance", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1921", "Slug_Discharge", <a><![CDATA[Slug_Discharge]]></a>.Value, "Slug Discharge", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("2174", "Soft_Start", <a><![CDATA[Soft_Start]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("1922", "Speed", <a><![CDATA[Speed]]></a>.Value, "Speed", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1923", "Speed_FPM", <a><![CDATA[Speed_FPM]]></a>.Value, "Speed FPM", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("2175", "Speed_FPM_Actual", <a><![CDATA[Speed_FPM_Actual]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("2176", "Speed_ISC", <a><![CDATA[Speed_ISC]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("1924", "Style", <a><![CDATA[Style]]></a>.Value, "Style", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1925", "Support_Hardware", <a><![CDATA[Support_Hardware]]></a>.Value, "Support Hardware", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1926", "Support_Paint_Elevation", <a><![CDATA[Support_Paint_Elevation]]></a>.Value, "Support Paint Elevation", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1927", "Support_Paint_Option", <a><![CDATA[Support_Paint_Option]]></a>.Value, "Support Paint Option", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1928", "Support_Type", <a><![CDATA[Support_Type]]></a>.Value, "Support Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1929", "Takeup_Type", <a><![CDATA[Takeup_Type]]></a>.Value, "Takeup Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("2177", "Throughput_CFPM", <a><![CDATA[Throughput_CFPM]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("1930", "Time_Delay_PE", <a><![CDATA[Time_Delay_PE]]></a>.Value, "Time Delay PE", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1931", "TU_Prox_Sensor", <a><![CDATA[TU_Prox_Sensor]]></a>.Value, "TU Prox Sensor", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1932", "Upper_Transition", <a><![CDATA[Upper_Transition]]></a>.Value, "Upper Transition", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1933", "Upper_Transition_Angle", <a><![CDATA[Upper_Transition_Angle]]></a>.Value, "Upper Transition Angle", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1934", "Upper_Transition_Extension_Feet", <a><![CDATA[Upper_Transition_Extension_Feet]]></a>.Value, "Upper Transition Extension Feet", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1935", "Upper_Transition_Extension_Inches", <a><![CDATA[Upper_Transition_Extension_Inches]]></a>.Value, "Upper Transition Extension Inches", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1936", "Upstream_Conv_Connection", <a><![CDATA[Upstream_Conv_Connection]]></a>.Value, "Upstream Conv Connection", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("2178", "VFD", <a><![CDATA[VFD]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/16/2025 1:36:11 AM")
    AddProperty("1937", "Width", <a><![CDATA[Width]]></a>.Value, "Width", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("2155", "XMLObjectName", <a><![CDATA[XMLObjectName]]></a>.Value, "XML Export Object Name", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1880", "XMLObjectType", <a><![CDATA[XMLObjectType]]></a>.Value, "XML Export Object Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1879", "XMLObjectValue", <a><![CDATA[XMLObjectValue]]></a>.Value, "XML Export Object Value", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:26 AM")
    AddProperty("1938", "Zone_Control", <a><![CDATA[Zone_Control]]></a>.Value, "Zone Control", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:27 AM")
    AddProperty("1939", "Zone_Length", <a><![CDATA[Zone_Length]]></a>.Value, "Zone Length", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:27 AM")
    AddProperty("1940", "Zoneflex_Manager", <a><![CDATA[Zoneflex_Manager]]></a>.Value, "Zoneflex Manager", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "4/15/2025 1:55:27 AM")
    AddProperty("1810", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/2/2025 10:56:35 PM")
    
      AddValidValue("Int_Bottom_Cover_calculation")
    
      oConnection = AddConnection("MySource", <a><![CDATA[My Source Part Family]]></a>.Value, "Connection to the Value Provider Part Family Instance", "54", "OO", 0, "","Oracle Config XML", 9999, "Oracle Configurator Transfer", "GLOBAL\H601424", "4/15/2025 1:55:27 AM")
      
        oConnection.AddVPF(322, "OCT_ConfigureSystem")
      
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
          InitProperty("Debug_Mode", "1813", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "True = Debug On / False = Debug Off", "In Development",  0,2243)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Actuation_Type", "1519", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Actuation Type", "In Development",  0,2234)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Add_One_Support", "1520", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/7/2025 3:25:06 PM", "Add One Support", "In Development",  0,13678)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Belt_Width_Offset", "1521", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Belt Width Offset", "In Development",  0,2236)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Belting_Type", "1522", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Belting Type", "In Development",  0,2237)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BF_Freeze_Intermediates", "1523", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "BF Freeze Intermediates", "In Development",  0,2238)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BF_Freeze_Supports", "1524", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "BF Freeze Supports", "In Development",  0,2239)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BF_Support", "1525", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "BF Support", "In Development",  0,2240)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Brake_Motor", "1526", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Brake Motor", "In Development",  0,2241)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Controls_Hand", "1527", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Controls Hand", "In Development",  0,1633)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_Number", "1528", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Conveyor Number", "In Development",  0,2242)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Discharge_End_Idler", "1529", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Discharge End Idler", "In Development",  0,2244)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Discharge_Idler", "1530", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Discharge Idler", "In Development",  0,2245)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drip_Pan", "1531", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Drip Pan", "In Development",  0,2246)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Belt", "1532", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Drive Belt", "In Development",  0,2247)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Hand", "1533", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Drive Hand", "In Development",  0,2248)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Location", "1534", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Drive Location", "In Development",  0,2249)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Rating", "1830", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2369)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Style", "1535", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Drive Style", "In Development",  0,2250)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Type", "1536", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Drive Type", "In Development",  0,2251)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Dynamic_Auto_Slug", "1537", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Dynamic Auto Slug", "In Development",  0,2252)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Elevation_Entry", "1538", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Elevation Entry", "In Development",  0,2253)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Elevation_Exit", "1539", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Elevation Exit", "In Development",  0,2254)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Encoder_Roller", "1540", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Encoder Roller", "In Development",  0,2255)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Fill_Brush", "1541", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Fill Brush", "In Development",  0,2256)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Filter_Regulator_Assy_Kit", "1542", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Filter Regulator Assy Kit", "In Development",  0,2257)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Filter_Regulator_Qty", "1831", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2370)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Floor_Length_Feet", "1543", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "Floor Length Feet", "In Development",  0,2258)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("High_Volume_Acceptance", "1544", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "High Volume Acceptance", "In Development",  0,2259)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("High_Volume_Discharge", "1545", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "High Volume Discharge", "In Development",  0,2260)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("HP_Override", "1546", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "HP Override", "In Development",  0,2261)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IBTYPE", "1547", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:24 AM", "IBTYPE", "In Development",  0,2262)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Idler_Blade_Stop", "1548", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Idler Blade Stop", "In Development",  0,2263)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Idler_Brake_Module", "1549", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Idler Brake Module", "In Development",  0,2264)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Idler_Type", "1832", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2371)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Infeed_End_Idler", "1550", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Infeed End Idler", "In Development",  0,2265)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Int_Bottom_Cover", "1551", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Int Bottom Cover", "In Development",  0,2266)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Int_Bottom_Cover_calculation", "1833", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2372)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Int_Bottom_Cover_Qty", "1552", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Int Bottom Cover Qty", "In Development",  0,2267)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Int_Bottom_Cover_Type", "1553", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Int Bottom Cover Type", "In Development",  0,2268)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Intermediate_Sensor_Location", "1834", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2374)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IQZF_Belt_Length", "1835", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2375)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("JSONObjectName", "1554", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "JSON Export Object Name", "In Development",  0,1660)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("JSONObjectType", "1555", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "JSON Export Object Type", "In Development",  0,1661)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("JSONObjectValue", "1818", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "JSON Export Object Value", "In Development",  0,2133)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Length", "1558", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Length", "In Development",  0,2269)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Length_Feet", "1559", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Length Feet", "In Development",  0,2270)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Length_Inches", "1560", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Length Inches", "In Development",  0,2271)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Live_Load", "1561", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Live Load", "In Development",  0,2272)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lock_Bottom_Cover_Qty", "1562", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Lock Bottom Cover Qty", "In Development",  0,2273)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Logic_Mode", "1563", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Logic Mode", "In Development",  0,2274)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition", "1564", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Lower Transition", "In Development",  0,2275)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Angle", "1565", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Lower Transition Angle", "In Development",  0,2276)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Belting_Type", "1566", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Lower Transition Belting Type", "In Development",  0,2277)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Extension_Feet", "1567", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Lower Transition Extension Feet", "In Development",  0,2278)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Extension_Inches", "1568", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Lower Transition Extension Inches", "In Development",  0,2279)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Ratio", "1569", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Lower Transition Ratio", "In Development",  0,2280)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Module_Placement", "1570", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Module Placement", "In Development",  0,2281)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Class", "1571", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Motor Class", "In Development",  0,2282)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_HP", "1836", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2376)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_MFG", "1572", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Motor MFG", "In Development",  0,2283)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Mount", "1573", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Motor Mount", "In Development",  0,2284)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Voltage", "1574", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Motor Voltage", "In Development",  0,2285)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Number_of_6ft_IntermediatesNumber_of_9ft_Intermed", "1837", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2377)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Number_of_Modules", "1838", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2378)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Paint_Color", "1575", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Paint Color", "In Development",  0,2286)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Power_Supply", "1576", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Power Supply", "In Development",  0,2287)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Power_Supply_Qty", "1839", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2379)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Power_Unit_Hand", "1577", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Power Unit Hand", "In Development",  0,2288)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product", "1578", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Product", "In Development",  0,2289)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pull", "1840", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2380)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pulley_Bearing", "1579", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Pulley Bearing", "In Development",  0,2290)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Qty_5_Roller_Skew", "1841", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2381)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Rail_Type", "1580", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Rail Type", "In Development",  0,2291)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reducer_MFG", "1581", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Reducer MFG", "In Development",  0,2292)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reducer_Motor_Mount", "1582", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Reducer Motor Mount", "In Development",  0,2293)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reflector_Offset", "1583", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:25 AM", "Reflector Offset", "In Development",  0,2294)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Roller", "1584", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Roller", "In Development",  0,2295)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Roller_Bearings", "1585", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Roller Bearings", "In Development",  0,2296)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Roller_Center", "1586", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Roller Center", "In Development",  0,2297)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Roller_Position", "1587", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Roller Position", "In Development",  0,2298)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Roller_Type", "1588", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Roller Type", "In Development",  0,2299)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Section_Length", "1589", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Section Length", "In Development",  0,2300)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sensor_Type", "1590", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Sensor Type", "In Development",  0,2301)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Side_Guide_Left", "1591", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Side Guide Left", "In Development",  0,2302)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Side_Guide_Mount", "1592", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Side Guide Mount", "In Development",  0,2303)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Side_Guide_Right", "1593", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Side Guide Right", "In Development",  0,2304)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Skatewheel_Side_Guide", "1594", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Skatewheel Side Guide", "In Development",  0,2305)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Skew_Feet", "1595", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Skew Feet", "In Development",  0,2306)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Skew_Hand", "1596", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Skew Hand", "In Development",  0,2307)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Slug_Acceptance", "1597", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Slug Acceptance", "In Development",  0,2308)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Slug_Discharge", "1598", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Slug Discharge", "In Development",  0,2309)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Soft_Start", "1842", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2382)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed", "1599", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Speed", "In Development",  0,2310)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_FPM", "1600", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Speed FPM", "In Development",  0,2311)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_FPM_Actual", "1843", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2383)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_ISC", "1844", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2384)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Style", "1601", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Style", "In Development",  0,2312)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Support_Hardware", "1602", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Support Hardware", "In Development",  0,2313)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Support_Paint_Elevation", "1603", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Support Paint Elevation", "In Development",  0,2314)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Support_Paint_Option", "1604", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Support Paint Option", "In Development",  0,2315)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Support_Type", "1605", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Support Type", "In Development",  0,2316)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Takeup_Type", "1606", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Takeup Type", "In Development",  0,2317)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Throughput_CFPM", "1845", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2385)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Time_Delay_PE", "1607", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Time Delay PE", "In Development",  0,2318)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TU_Prox_Sensor", "1608", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "TU Prox Sensor", "In Development",  0,2319)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upper_Transition", "1609", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Upper Transition", "In Development",  0,2320)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upper_Transition_Angle", "1610", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Upper Transition Angle", "In Development",  0,2321)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upper_Transition_Extension_Feet", "1611", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Upper Transition Extension Feet", "In Development",  0,2322)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upper_Transition_Extension_Inches", "1612", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Upper Transition Extension Inches", "In Development",  0,2323)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upstream_Conv_Connection", "1613", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Upstream Conv Connection", "In Development",  0,2324)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("VFD", "1846", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/16/2025 1:36:11 AM", "", "In Development",  0,2386)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Width", "1614", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "Width", "In Development",  0,2325)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectName", "1823", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "XML Export Object Name", "In Development",  0,2144)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectType", "1557", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "XML Export Object Type", "In Development",  0,1663)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectValue", "1556", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:26 AM", "XML Export Object Value", "In Development",  0,2326)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Zone_Control", "1615", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:27 AM", "Zone Control", "In Development",  0,2327)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Zone_Length", "1616", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:27 AM", "Zone Length", "In Development",  0,2328)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Zoneflex_Manager", "1617", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "4/15/2025 1:55:27 AM", "Zoneflex Manager", "In Development",  0,2329)
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
          
        InitValidValue("Int_Bottom_Cover_calculation_ValidValues", "1833", "-1", 2373)
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
            If Incontext("-1", ctx) Then
          
        InitConnection("MySource", "34", "N","N", "N", 0, "-1", "", "GLOBAL\H601424", "4/15/2025 1:55:27 AM", "Connection to the Value Provider Part Family Instance", "In Development", "Y",57)
        
          End If
        
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
      Public Function Formula_MySource_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:34; TYPE:PF
        Result = Nothing
If Me.Debug_Mode Then
	Result = Me.Parent.MySource(1).ConfigureSystem(Me.SubPartID)
End If
        '   END FORMULA; CON ID:34; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_MySource_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
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
      '   BEGIN FORMULA; PROP ID:1813; TYPE:PF
      Result = False
If Not Me.Parent Is Nothing AndAlso Me.Parent.Properties.ContainsKey("Debug_Mode") Then
		Result = Me.Parent.Debug_Mode
End If
      '   END FORMULA; PROP ID:1813; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Debug_Mode", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
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
      '   BEGIN FORMULA; PROP ID:1519; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1519; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Actuation_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1520; TYPE:PF
      Result = "NO"

Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result = Me.MySource(1).Properties(MyPropName).Value
End If
      '   END FORMULA; PROP ID:1520; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Add_One_Support", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1521; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1521; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Belt_Width_Offset", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1522; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1522; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Belting_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BF_Freeze_Intermediates() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BF_Freeze_Intermediates").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1523; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1523; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_BF_Freeze_Intermediates", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BF_Freeze_Supports() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BF_Freeze_Supports").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1524; TYPE:PF
      Result = "NO"

Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	If Me.MySource(1).Properties(MyPropName).Value = True Then
		Result = "YES"
	End If
End If
      '   END FORMULA; PROP ID:1524; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_BF_Freeze_Supports", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BF_Support() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BF_Support").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1525; TYPE:PF
      Result = "NO"

Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	If Me.MySource(1).Properties(MyPropName).Value = True Then
		Result = "YES"
	End If
End If
      '   END FORMULA; PROP ID:1525; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_BF_Support", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Brake_Motor() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Brake_Motor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1526; TYPE:PF
      Result = "NO"

Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	If Me.MySource(1).Properties(MyPropName).Value = True Then
		Result = "YES"
	End If
End If
      '   END FORMULA; PROP ID:1526; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Brake_Motor", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1527; TYPE:PF
      result = "Left"
      '   END FORMULA; PROP ID:1527; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Controls_Hand", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1528; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1528; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Conveyor_Number", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1529; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1529; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Discharge_End_Idler", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1530; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1530; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Discharge_Idler", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Drip_Pan() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drip_Pan").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1531; TYPE:PF
      Result = "NO"

Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	If Me.MySource(1).Properties(MyPropName).Value = True Then
Result = "YES"
End If
End If
      '   END FORMULA; PROP ID:1531; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Drip_Pan", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1532; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1532; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Drive_Belt", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1533; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1533; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Drive_Hand", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1534; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1534; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Drive_Location", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1830; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1830; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Drive_Rating", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1535; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1535; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Drive_Style", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1536; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1536; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Drive_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1537; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1537; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Dynamic_Auto_Slug", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Elevation_Entry() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Elevation_Entry").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1538; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F2}"
End If
      '   END FORMULA; PROP ID:1538; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Elevation_Entry", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Elevation_Exit() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Elevation_Exit").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1539; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1539; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Elevation_Exit", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1540; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1540; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Encoder_Roller", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1541; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1541; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Fill_Brush", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1542; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1542; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Filter_Regulator_Assy_Kit", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Filter_Regulator_Qty() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter_Regulator_Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1831; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1831; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Filter_Regulator_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Floor_Length_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Floor_Length_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1543; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1543; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Floor_Length_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_High_Volume_Acceptance() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("High_Volume_Acceptance").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1544; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F2}"
End If
      '   END FORMULA; PROP ID:1544; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_High_Volume_Acceptance", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_High_Volume_Discharge() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("High_Volume_Discharge").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1545; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F2}"
End If
      '   END FORMULA; PROP ID:1545; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_High_Volume_Discharge", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1546; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1546; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_HP_Override", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1547; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1547; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_IBTYPE", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1548; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1548; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Idler_Blade_Stop", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1549; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1549; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Idler_Brake_Module", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1832; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1832; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Idler_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1550; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1550; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Infeed_End_Idler", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1551; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1551; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Int_Bottom_Cover", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1833; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1833; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Int_Bottom_Cover_calculation", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1552; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1552; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Int_Bottom_Cover_Qty", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1553; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1553; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Int_Bottom_Cover_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1834; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1834; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Intermediate_Sensor_Location", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_IQZF_Belt_Length() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("IQZF_Belt_Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1835; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1835; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_IQZF_Belt_Length", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1554; TYPE:PF
      result = "ConfigureSystem"
      '   END FORMULA; PROP ID:1554; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_JSONObjectName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1555; TYPE:PF
      result = "Element"
      '   END FORMULA; PROP ID:1555; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_JSONObjectType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_JSONObjectValue() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("JSONObjectValue").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1818; TYPE:PF
      result = "{'X':'1'}"
      '   END FORMULA; PROP ID:1818; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_JSONObjectValue", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Length() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1558; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1558; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Length", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Length_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Length_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1559; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1559; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Length_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Length_Inches() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Length_Inches").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1560; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1560; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Length_Inches", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Live_Load() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Live_Load").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1561; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1561; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Live_Load", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1562; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1562; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Lock_Bottom_Cover_Qty", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1563; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1563; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Logic_Mode", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1564; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1564; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Lower_Transition", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1565; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1565; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Lower_Transition_Angle", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1566; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1566; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Lower_Transition_Belting_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1567; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1567; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Lower_Transition_Extension_Feet", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1568; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1568; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Lower_Transition_Extension_Inches", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1569; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1569; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Lower_Transition_Ratio", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1570; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1570; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Module_Placement", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1571; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1571; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Motor_Class", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_HP() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_HP").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1836; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1836; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Motor_HP", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1572; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1572; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Motor_MFG", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1573; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1573; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Motor_Mount", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Motor_Voltage() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Motor_Voltage").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1574; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1574; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Motor_Voltage", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Number_of_6ft_IntermediatesNumber_of_9ft_Intermed() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Number_of_6ft_IntermediatesNumber_of_9ft_Intermed").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1837; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1837; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Number_of_6ft_IntermediatesNumber_of_9ft_Intermed", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Number_of_Modules() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Number_of_Modules").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1838; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1838; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Number_of_Modules", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1575; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1575; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Paint_Color", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1576; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1576; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Power_Supply", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Power_Supply_Qty() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Power_Supply_Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1839; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1839; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Power_Supply_Qty", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1577; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1577; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Power_Unit_Hand", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1578; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1578; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Product", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1840; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1840; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Pull", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1579; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1579; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Pulley_Bearing", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Qty_5_Roller_Skew() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Qty_5_Roller_Skew").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1841; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1841; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Qty_5_Roller_Skew", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1580; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1580; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Rail_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1581; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1581; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Reducer_MFG", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1582; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1582; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Reducer_Motor_Mount", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1583; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1583; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Reflector_Offset", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1584; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1584; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Roller", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1585; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1585; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Roller_Bearings", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Roller_Center() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Roller_Center").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1586; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1586; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Roller_Center", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1587; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1587; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Roller_Position", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1588; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1588; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Roller_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1589; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1589; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Section_Length", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1590; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1590; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Sensor_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1591; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1591; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Side_Guide_Left", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1592; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1592; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Side_Guide_Mount", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1593; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1593; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Side_Guide_Right", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1594; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1594; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Skatewheel_Side_Guide", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Skew_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Skew_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1595; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1595; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Skew_Feet", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1596; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1596; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Skew_Hand", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Slug_Acceptance() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Slug_Acceptance").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1597; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1597; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Slug_Acceptance", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Slug_Discharge() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Slug_Discharge").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1598; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1598; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Slug_Discharge", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1842; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1842; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Soft_Start", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1599; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1599; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Speed", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_FPM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1600; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1600; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Speed_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_FPM_Actual() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_FPM_Actual").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1843; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1843; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Speed_FPM_Actual", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1844; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1844; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Speed_ISC", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1601; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1601; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Style", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1602; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1602; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Support_Hardware", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1603; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1603; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Support_Paint_Elevation", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1604; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1604; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Support_Paint_Option", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1605; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1605; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Support_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1606; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1606; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Takeup_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Throughput_CFPM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Throughput_CFPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1845; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1845; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Throughput_CFPM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1607; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1607; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Time_Delay_PE", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1608; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1608; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_TU_Prox_Sensor", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1609; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1609; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Upper_Transition", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1610; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1610; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Upper_Transition_Angle", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1611; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1611; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Upper_Transition_Extension_Feet", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1612; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1612; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Upper_Transition_Extension_Inches", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1613; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1613; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Upstream_Conv_Connection", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1846; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1846; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_VFD", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1614; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1614; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Width", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1823; TYPE:PF
      result = "ConfigureSystem"
      '   END FORMULA; PROP ID:1823; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_XMLObjectName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1557; TYPE:PF
      result = "Element"
      '   END FORMULA; PROP ID:1557; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_XMLObjectType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_XMLObjectValue() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("XMLObjectValue").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1556; TYPE:PF
      Dim Prop As PropertySF = Me.CurrentProperty
Result = Custom.GetPFXMLRepresentation(Prop)
      '   END FORMULA; PROP ID:1556; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_XMLObjectValue", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1615; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1615; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Zone_Control", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1616; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1616; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Zone_Length", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1617; TYPE:PF
      Result = ""
Dim MyPropName As String = Me.CurrentProperty.Name
If Me.MySource(1).Properties.ContainsKey(MyPropName) Then
	Result =$"{Me.MySource(1).Properties(MyPropName).DisplayValue:F0}"
End If
      '   END FORMULA; PROP ID:1617; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Zoneflex_Manager", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      Public Function Formula_JSONObjectValue_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_XMLObjectValue_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Debug_Mode_USERCHANGE() as Boolean
      Return True
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
      Public Function Formula_JSONObjectValue_USERCHANGE() as Boolean
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
      Public Function Formula_XMLObjectValue_USERCHANGE() as Boolean
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
      Public Function Formula_Int_Bottom_Cover_calculation_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Int_Bottom_Cover_calculation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1833; TYPE:VV
      result = MakeValidValues(Array("Side Guide Flare Ends 2.5","Side Guide Flare Ends 6.5","Side Guide Flare Ends 10","Side Guide Flare Ends 3.5","Side Guide Flare Ends 4","Side Guide Flare Ends 7.5","SG Width Transition LH","SG Width Transition RH","SG Width Trans Length","SG Width Trans OffSet","SG Width Trans Spacer","SG Width Trans Height","SG Width Trans Connection","FK BM Intermediate Assembly","FK Trans Air Drop Single Valve 120V","FK Trans Air Drop Single Valve 24V","FK Trans Air Drop Dual Valve 120V","FK Trans Air Drop Dual Valve 24V"))
      '   END FORMULA; PROP ID:1833; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem.Formula_Int_Bottom_Cover_calculation_ValidValues", ex.Message)
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

  