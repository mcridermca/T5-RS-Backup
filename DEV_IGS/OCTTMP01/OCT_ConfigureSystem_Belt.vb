Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: OCTTMP01
'$ PartFamily: OCT_ConfigureSystem_Belt
'$ GenerateDate: 04/02/2025 17:03:39

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

    Public Class [OCT_ConfigureSystem_Belt]
    
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

    Private this as OCT_ConfigureSystem_Belt = me

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
    
          Public Property [Add_One_Support]() As Boolean
      Get
      Return Properties("Add_One_Support").Value
      End Get
      Set(ByVal Value As Boolean)
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
    
          Public Property [BF_Intermediate]() As String
      Get
      Return Properties("BF_Intermediate").Value
      End Get
      Set(ByVal Value As String)
      Properties("BF_Intermediate").CalculatedValue = Value
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
    
          Public Property [Drive_Location]() As String
      Get
      Return Properties("Drive_Location").Value
      End Get
      Set(ByVal Value As String)
      Properties("Drive_Location").CalculatedValue = Value
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
    
          Public Property [Encoder_Roller]() As Boolean
      Get
      Return Properties("Encoder_Roller").Value
      End Get
      Set(ByVal Value As Boolean)
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
    
          Public Property [JSONObjectName]() As String
      Get
      Return Properties("JSONObjectName").Value
      End Get
      Set(ByVal Value As String)
      Properties("JSONObjectName").CalculatedValue = Value
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
    
          Public Property [Lower_Transition]() As String
      Get
      Return Properties("Lower_Transition").Value
      End Get
      Set(ByVal Value As String)
      Properties("Lower_Transition").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Lower_Transition_Angle]() As Double
      Get
      Return Properties("Lower_Transition_Angle").Value
      End Get
      Set(ByVal Value As Double)
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
    
          Public Property [Lower_Transition_Extension_Feet]() As Double
      Get
      Return Properties("Lower_Transition_Extension_Feet").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Lower_Transition_Extension_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Lower_Transition_Extension_Inches]() As Double
      Get
      Return Properties("Lower_Transition_Extension_Inches").Value
      End Get
      Set(ByVal Value As Double)
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
    
          Public Property [Motor_Class]() As String
      Get
      Return Properties("Motor_Class").Value
      End Get
      Set(ByVal Value As String)
      Properties("Motor_Class").CalculatedValue = Value
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
    
          Public Property [Paint_Color]() As String
      Get
      Return Properties("Paint_Color").Value
      End Get
      Set(ByVal Value As String)
      Properties("Paint_Color").CalculatedValue = Value
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
    
          Public Property [Pulley_Bearing]() As String
      Get
      Return Properties("Pulley_Bearing").Value
      End Get
      Set(ByVal Value As String)
      Properties("Pulley_Bearing").CalculatedValue = Value
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
    
          Public Property [Roller]() As String
      Get
      Return Properties("Roller").Value
      End Get
      Set(ByVal Value As String)
      Properties("Roller").CalculatedValue = Value
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
    
          Public Property [Speed]() As String
      Get
      Return Properties("Speed").Value
      End Get
      Set(ByVal Value As String)
      Properties("Speed").CalculatedValue = Value
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
    
          Public Property [Support_Paint_Elevation]() As Double
      Get
      Return Properties("Support_Paint_Elevation").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Support_Paint_Elevation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Support_Paint_Option]() As Boolean
      Get
      Return Properties("Support_Paint_Option").Value
      End Get
      Set(ByVal Value As Boolean)
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
    
          Public Property [Upper_Transition]() As String
      Get
      Return Properties("Upper_Transition").Value
      End Get
      Set(ByVal Value As String)
      Properties("Upper_Transition").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Upper_Transition_Angle]() As Double
      Get
      Return Properties("Upper_Transition_Angle").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Upper_Transition_Angle").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Upper_Transition_Extension_Feet]() As Double
      Get
      Return Properties("Upper_Transition_Extension_Feet").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Upper_Transition_Extension_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Upper_Transition_Extension_Inches]() As Double
      Get
      Return Properties("Upper_Transition_Extension_Inches").Value
      End Get
      Set(ByVal Value As Double)
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
    
          Public Property [Width]() As String
      Get
      Return Properties("Width").Value
      End Get
      Set(ByVal Value As String)
      Properties("Width").CalculatedValue = Value
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
    InitPart("OCT_ConfigureSystem_Belt", <a><![CDATA[OCT_ConfigureSystem_Belt]]></a>.Value, 32, "OCTTMP01",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "03/20/2025 16:34:59")
    AddProperty("440", "Add_One_Support", <a><![CDATA[Add_One_Support]]></a>.Value, "", "Boolean","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:59 PM")
    AddProperty("418", "Belt_Width_Offset", <a><![CDATA[Belt_Width_Offset]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("416", "Belting_Type", <a><![CDATA[Belting_Type]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("448", "BF_Freeze_Intermediates", <a><![CDATA[BF_Freeze_Intermediates]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:59 PM")
    AddProperty("446", "BF_Freeze_Supports", <a><![CDATA[BF_Freeze_Supports]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:59 PM")
    AddProperty("447", "BF_Intermediate", <a><![CDATA[BF_Intermediate]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:59 PM")
    AddProperty("445", "BF_Support", <a><![CDATA[BF_Support]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:59 PM")
    AddProperty("424", "Brake_Motor", <a><![CDATA[Brake_Motor]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("387", "Conveyor_Number", <a><![CDATA[Conveyor_Number]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("392", "Discharge_End_Idler", <a><![CDATA[Discharge_End_Idler]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("423", "Drive_Location", <a><![CDATA[Drive_Location]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("421", "Drive_Style", <a><![CDATA[Drive_Style]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("426", "Drive_Type", <a><![CDATA[Drive_Type]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("399", "Elevation_Entry", <a><![CDATA[Elevation_Entry]]></a>.Value, "string <-> double", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("400", "Elevation_Exit", <a><![CDATA[Elevation_Exit]]></a>.Value, "string <-> double", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("419", "Encoder_Roller", <a><![CDATA[Encoder_Roller]]></a>.Value, "", "Boolean","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("420", "Fill_Brush", <a><![CDATA[Fill_Brush]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("434", "HP_Override", <a><![CDATA[HP_Override]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("388", "IBTYPE", <a><![CDATA[IBTYPE]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("391", "Infeed_End_Idler", <a><![CDATA[Infeed_End_Idler]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("401", "Int_Bottom_Cover", <a><![CDATA[Int_Bottom_Cover]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("404", "Int_Bottom_Cover_Qty", <a><![CDATA[Int_Bottom_Cover_Qty]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("402", "Int_Bottom_Cover_Type", <a><![CDATA[Int_Bottom_Cover_Type]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("386", "JSONObjectName", <a><![CDATA[JSONObjectName]]></a>.Value, "RuleStream to Oracle Extract Only", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("397", "Length_Feet", <a><![CDATA[Length_Feet]]></a>.Value, "string <-> double", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("398", "Length_Inches", <a><![CDATA[Length_Inches]]></a>.Value, "string <-> double", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("433", "Live_Load", <a><![CDATA[Live_Load]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("403", "Lock_Bottom_Cover_Qty", <a><![CDATA[Lock_Bottom_Cover_Qty]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("405", "Lower_Transition", <a><![CDATA[Lower_Transition]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("406", "Lower_Transition_Angle", <a><![CDATA[Lower_Transition_Angle]]></a>.Value, "", "Double","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("417", "Lower_Transition_Belting_Type", <a><![CDATA[Lower_Transition_Belting_Type]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("407", "Lower_Transition_Extension_Feet", <a><![CDATA[Lower_Transition_Extension_Feet]]></a>.Value, "string <-> double", "Double","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("408", "Lower_Transition_Extension_Inches", <a><![CDATA[Lower_Transition_Extension_Inches]]></a>.Value, "string <-> double", "Double","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("409", "Lower_Transition_Ratio", <a><![CDATA[Lower_Transition_Ratio]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("429", "Motor_Class", <a><![CDATA[Motor_Class]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("427", "Motor_MFG", <a><![CDATA[Motor_MFG]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("422", "Motor_Mount", <a><![CDATA[Motor_Mount]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("428", "Motor_Voltage", <a><![CDATA[Motor_Voltage]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("441", "Paint_Color", <a><![CDATA[Paint_Color]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:59 PM")
    AddProperty("425", "Power_Unit_Hand", <a><![CDATA[Power_Unit_Hand]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("389", "Product", <a><![CDATA[Product]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("431", "Pulley_Bearing", <a><![CDATA[Pulley_Bearing]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("393", "Rail_Type", <a><![CDATA[Rail_Type]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("430", "Reducer_MFG", <a><![CDATA[Reducer_MFG]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("414", "Roller", <a><![CDATA[Roller]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("415", "Roller_Center", <a><![CDATA[Roller_Center]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("394", "Roller_Position", <a><![CDATA[Roller_Position]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("435", "Side_Guide_Left", <a><![CDATA[Side_Guide_Left]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("437", "Side_Guide_Mount", <a><![CDATA[Side_Guide_Mount]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("436", "Side_Guide_Right", <a><![CDATA[Side_Guide_Right]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("396", "Speed", <a><![CDATA[Speed]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("390", "Style", <a><![CDATA[Style]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("439", "Support_Hardware", <a><![CDATA[Support_Hardware]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:59 PM")
    AddProperty("443", "Support_Paint_Elevation", <a><![CDATA[Support_Paint_Elevation]]></a>.Value, "", "Double","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:59 PM")
    AddProperty("442", "Support_Paint_Option", <a><![CDATA[Support_Paint_Option]]></a>.Value, "", "Boolean","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:59 PM")
    AddProperty("438", "Support_Type", <a><![CDATA[Support_Type]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("432", "Takeup_Type", <a><![CDATA[Takeup_Type]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("410", "Upper_Transition", <a><![CDATA[Upper_Transition]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("411", "Upper_Transition_Angle", <a><![CDATA[Upper_Transition_Angle]]></a>.Value, "", "Double","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("412", "Upper_Transition_Extension_Feet", <a><![CDATA[Upper_Transition_Extension_Feet]]></a>.Value, "string <-> double", "Double","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("413", "Upper_Transition_Extension_Inches", <a><![CDATA[Upper_Transition_Extension_Inches]]></a>.Value, "string <-> double", "Double","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:58 PM")
    AddProperty("444", "Upstream_Conv_Connection", <a><![CDATA[Upstream_Conv_Connection]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:59 PM")
    AddProperty("395", "Width", <a><![CDATA[Width]]></a>.Value, "", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    AddProperty("385", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/20/2025 4:34:57 PM")
    
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
          InitProperty("Add_One_Support", "408", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:59 PM", "", "In Development",  0,501)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Belt_Width_Offset", "386", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,479)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Belting_Type", "384", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,477)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BF_Freeze_Intermediates", "416", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:59 PM", "", "In Development",  0,509)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BF_Freeze_Supports", "414", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:59 PM", "", "In Development",  0,507)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BF_Intermediate", "415", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:59 PM", "", "In Development",  0,508)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BF_Support", "413", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:59 PM", "", "In Development",  0,506)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Brake_Motor", "392", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,485)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_Number", "355", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "", "In Development",  0,448)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Discharge_End_Idler", "360", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "", "In Development",  0,453)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Location", "391", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,484)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Style", "389", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,482)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drive_Type", "394", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,487)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Elevation_Entry", "367", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "string <-> double", "In Development",  0,460)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Elevation_Exit", "368", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "string <-> double", "In Development",  0,461)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Encoder_Roller", "387", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,480)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Fill_Brush", "388", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,481)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("HP_Override", "402", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,495)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IBTYPE", "356", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "", "In Development",  0,449)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Infeed_End_Idler", "359", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "", "In Development",  0,452)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Int_Bottom_Cover", "369", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "", "In Development",  0,462)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Int_Bottom_Cover_Qty", "372", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "", "In Development",  0,465)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Int_Bottom_Cover_Type", "370", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "", "In Development",  0,463)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("JSONObjectName", "354", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "RuleStream to Oracle Extract Only", "In Development",  0,447)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Length_Feet", "365", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "string <-> double", "In Development",  0,458)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Length_Inches", "366", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "string <-> double", "In Development",  0,459)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Live_Load", "401", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,494)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lock_Bottom_Cover_Qty", "371", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "", "In Development",  0,464)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition", "373", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,466)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Angle", "374", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,467)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Belting_Type", "385", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,478)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Extension_Feet", "375", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "string <-> double", "In Development",  0,468)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Extension_Inches", "376", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "string <-> double", "In Development",  0,469)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lower_Transition_Ratio", "377", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,470)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Class", "397", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,490)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_MFG", "395", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,488)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Mount", "390", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,483)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Motor_Voltage", "396", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,489)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Paint_Color", "409", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:59 PM", "", "In Development",  0,502)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Power_Unit_Hand", "393", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,486)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product", "357", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "", "In Development",  0,450)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pulley_Bearing", "399", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,492)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Rail_Type", "361", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "", "In Development",  0,454)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reducer_MFG", "398", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,491)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Roller", "382", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,475)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Roller_Center", "383", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,476)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Roller_Position", "362", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "", "In Development",  0,455)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Side_Guide_Left", "403", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,496)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Side_Guide_Mount", "405", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,498)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Side_Guide_Right", "404", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,497)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed", "364", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "", "In Development",  0,457)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Style", "358", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "", "In Development",  0,451)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Support_Hardware", "407", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:59 PM", "", "In Development",  0,500)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Support_Paint_Elevation", "411", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:59 PM", "", "In Development",  0,504)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Support_Paint_Option", "410", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:59 PM", "", "In Development",  0,503)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Support_Type", "406", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,499)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Takeup_Type", "400", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,493)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upper_Transition", "378", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,471)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upper_Transition_Angle", "379", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "", "In Development",  0,472)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upper_Transition_Extension_Feet", "380", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "string <-> double", "In Development",  0,473)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upper_Transition_Extension_Inches", "381", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:58 PM", "string <-> double", "In Development",  0,474)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Upstream_Conv_Connection", "412", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:59 PM", "", "In Development",  0,505)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Width", "363", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/20/2025 4:34:57 PM", "", "In Development",  0,456)
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
          Public Function Formula_Add_One_Support() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Add_One_Support").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:408; TYPE:PF
      result=False
      '   END FORMULA; PROP ID:408; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Add_One_Support", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:386; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:386; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Belt_Width_Offset", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:384; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:384; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Belting_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:416; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:416; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_BF_Freeze_Intermediates", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:414; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:414; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_BF_Freeze_Supports", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BF_Intermediate() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BF_Intermediate").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:415; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:415; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_BF_Intermediate", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:413; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:413; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_BF_Support", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:392; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:392; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Brake_Motor", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:355; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:355; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Conveyor_Number", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:360; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:360; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Discharge_End_Idler", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:391; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:391; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Drive_Location", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:389; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:389; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Drive_Style", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:394; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:394; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Drive_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:367; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:367; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Elevation_Entry", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:368; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:368; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Elevation_Exit", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Encoder_Roller() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Encoder_Roller").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:387; TYPE:PF
      result=False
      '   END FORMULA; PROP ID:387; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Encoder_Roller", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:388; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:388; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Fill_Brush", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:402; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:402; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_HP_Override", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:356; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:356; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_IBTYPE", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:359; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:359; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Infeed_End_Idler", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:369; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:369; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Int_Bottom_Cover", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:372; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:372; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Int_Bottom_Cover_Qty", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:370; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:370; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Int_Bottom_Cover_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:354; TYPE:PF
      result = "ConfigureSystem"
      '   END FORMULA; PROP ID:354; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_JSONObjectName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:365; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:365; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Length_Feet", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:366; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:366; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Length_Inches", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:401; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:401; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Live_Load", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:371; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:371; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Lock_Bottom_Cover_Qty", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:373; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:373; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Lower_Transition", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Lower_Transition_Angle() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Lower_Transition_Angle").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:374; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:374; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Lower_Transition_Angle", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:385; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:385; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Lower_Transition_Belting_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Lower_Transition_Extension_Feet() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Lower_Transition_Extension_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:375; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:375; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Lower_Transition_Extension_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Lower_Transition_Extension_Inches() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Lower_Transition_Extension_Inches").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:376; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:376; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Lower_Transition_Extension_Inches", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:377; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:377; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Lower_Transition_Ratio", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:397; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:397; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Motor_Class", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:395; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:395; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Motor_MFG", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:390; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:390; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Motor_Mount", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:396; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:396; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Motor_Voltage", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:409; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:409; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Paint_Color", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:393; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:393; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Power_Unit_Hand", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:357; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:357; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Product", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:399; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:399; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Pulley_Bearing", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:361; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:361; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Rail_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:398; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:398; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Reducer_MFG", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:382; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:382; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Roller", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:383; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:383; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Roller_Center", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:362; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:362; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Roller_Position", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:403; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:403; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Side_Guide_Left", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:405; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:405; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Side_Guide_Mount", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:404; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:404; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Side_Guide_Right", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:364; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:364; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Speed", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:358; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:358; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Style", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:407; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:407; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Support_Hardware", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Support_Paint_Elevation() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Support_Paint_Elevation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:411; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:411; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Support_Paint_Elevation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Support_Paint_Option() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Support_Paint_Option").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:410; TYPE:PF
      result=False
      '   END FORMULA; PROP ID:410; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Support_Paint_Option", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:406; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:406; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Support_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:400; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:400; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Takeup_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:378; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:378; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Upper_Transition", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Upper_Transition_Angle() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Upper_Transition_Angle").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:379; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:379; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Upper_Transition_Angle", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Upper_Transition_Extension_Feet() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Upper_Transition_Extension_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:380; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:380; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Upper_Transition_Extension_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Upper_Transition_Extension_Inches() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Upper_Transition_Extension_Inches").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:381; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:381; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Upper_Transition_Extension_Inches", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:412; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:412; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Upstream_Conv_Connection", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:363; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:363; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " OCT_ConfigureSystem_Belt.Formula_Width", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      Public Function Formula_BF_Intermediate_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Drive_Location_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_JSONObjectName_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Motor_Class_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Paint_Color_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Pulley_Bearing_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Roller_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Speed_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Width_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Add_One_Support_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Width_Offset_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belting_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BF_Freeze_Intermediates_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BF_Freeze_Supports_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BF_Intermediate_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BF_Support_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Brake_Motor_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Number_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Discharge_End_Idler_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Location_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Style_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drive_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elevation_Entry_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elevation_Exit_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Encoder_Roller_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Fill_Brush_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HP_Override_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IBTYPE_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Infeed_End_Idler_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Int_Bottom_Cover_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Int_Bottom_Cover_Qty_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Int_Bottom_Cover_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_JSONObjectName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_Feet_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_Inches_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Live_Load_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lock_Bottom_Cover_Qty_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Angle_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Belting_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Extension_Feet_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Extension_Inches_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lower_Transition_Ratio_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Class_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_MFG_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Mount_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Motor_Voltage_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Paint_Color_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Power_Unit_Hand_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pulley_Bearing_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Rail_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reducer_MFG_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_Center_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Roller_Position_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Side_Guide_Left_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Side_Guide_Mount_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Side_Guide_Right_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Style_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Hardware_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Paint_Elevation_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Paint_Option_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Support_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Takeup_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upper_Transition_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upper_Transition_Angle_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upper_Transition_Extension_Feet_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upper_Transition_Extension_Inches_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Upstream_Conv_Connection_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Width_USERCHANGE() as Boolean
      Return False
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

  