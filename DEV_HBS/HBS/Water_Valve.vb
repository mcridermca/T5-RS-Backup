Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: Water_Valve
'$ GenerateDate: 07/21/2025 12:30:00

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
    Imports HBS.swMateType_e
    Imports HBS.swMateAlign_e
    Imports HBS.severity

    Public Class [Water_Valve]
    
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

    Private this as Water_Valve = me

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
    
      Case "CloseOff_"
      Formula_CloseOff_WHENCHANGED(Value, OldValue)
    
      Case "DesignFlowGPM_"
      Formula_DesignFlowGPM_WHENCHANGED(Value, OldValue)
    
      Case "DesignFlowLS_"
      Formula_DesignFlowLS_WHENCHANGED(Value, OldValue)
    
      Case "DesignPressureDropkPa_"
      Formula_DesignPressureDropkPa_WHENCHANGED(Value, OldValue)
    
      Case "DesignPressureDropPSI_"
      Formula_DesignPressureDropPSI_WHENCHANGED(Value, OldValue)
    
      Case "RadiantHeatBTUHr_"
      Formula_RadiantHeatBTUHr_WHENCHANGED(Value, OldValue)
    
      Case "RadiantHeatKW_"
      Formula_RadiantHeatKW_WHENCHANGED(Value, OldValue)
    
      Case "RadiantWaterC_"
      Formula_RadiantWaterC_WHENCHANGED(Value, OldValue)
    
      Case "RadiantWaterF_"
      Formula_RadiantWaterF_WHENCHANGED(Value, OldValue)
    
      Case "ValveDropAtDesignFlowkPa_"
      Formula_ValveDropAtDesignFlowkPa_WHENCHANGED(Value, OldValue)
    
      Case "ValveDropAtDesignFlowPSI_"
      Formula_ValveDropAtDesignFlowPSI_WHENCHANGED(Value, OldValue)
    
    End Select
    End Sub

    Public Function OnChangedStatus(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String)As Boolean Implements RuleStream.IRsPartFormulas.OnChangedStatus
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Dim Status as Boolean = False
    Select Case specName & "_" & context
    
      Case "CloseOff_"
      'Formula_CloseOff_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "DesignFlowGPM_"
      'Formula_DesignFlowGPM_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "DesignFlowLS_"
      'Formula_DesignFlowLS_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "DesignPressureDropkPa_"
      'Formula_DesignPressureDropkPa_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "DesignPressureDropPSI_"
      'Formula_DesignPressureDropPSI_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "RadiantHeatBTUHr_"
      'Formula_RadiantHeatBTUHr_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "RadiantHeatKW_"
      'Formula_RadiantHeatKW_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "RadiantWaterC_"
      'Formula_RadiantWaterC_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "RadiantWaterF_"
      'Formula_RadiantWaterF_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "ValveDropAtDesignFlowkPa_"
      'Formula_ValveDropAtDesignFlowkPa_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "ValveDropAtDesignFlowPSI_"
      'Formula_ValveDropAtDesignFlowPSI_WHENCHANGED(Value, OldValue)
      Status = True
    Case Else
    Status = False
    End Select
    Return Status
    End Function

    #End Region

    #Region " Properties, Subparts, Connections "
    
          Public Property [IsWaterHiddenPro_Enabled]() As Boolean
      Get
      Return Properties("IsWaterHiddenPro_Enabled").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("IsWaterHiddenPro_Enabled").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Cv_DB]() As String
      Get
      Return Properties("Cv_DB").Value
      End Get
      Set(ByVal Value As String)
      Properties("Cv_DB").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Max_Size_Available]() As String
      Get
      Return Properties("Max_Size_Available").Value
      End Get
      Set(ByVal Value As String)
      Properties("Max_Size_Available").CalculatedValue = Value
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
    
          Public Property [ActuatorPartNumber]() As String
      Get
      Return Properties("ActuatorPartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("ActuatorPartNumber").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ActuatorType]() As String
      Get
      Return Properties("ActuatorType").Value
      End Get
      Set(ByVal Value As String)
      Properties("ActuatorType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Auto_Cv]() As Boolean
      Get
      Return Properties("Auto_Cv").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Auto_Cv").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BodyRating]() As String
      Get
      Return Properties("BodyRating").Value
      End Get
      Set(ByVal Value As String)
      Properties("BodyRating").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CloseOff]() As String
      Get
      Return Properties("CloseOff").Value
      End Get
      Set(ByVal Value As String)
      Properties("CloseOff").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conn]() As String
      Get
      Return Properties("Conn").Value
      End Get
      Set(ByVal Value As String)
      Properties("Conn").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControlType]() As String
      Get
      Return Properties("ControlType").Value
      End Get
      Set(ByVal Value As String)
      Properties("ControlType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Cv]() As String
      Get
      Return Properties("Cv").Value
      End Get
      Set(ByVal Value As String)
      Properties("Cv").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DesignFlowGPM]() As String
      Get
      Return Properties("DesignFlowGPM").Value
      End Get
      Set(ByVal Value As String)
      Properties("DesignFlowGPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DesignFlowLS]() As String
      Get
      Return Properties("DesignFlowLS").Value
      End Get
      Set(ByVal Value As String)
      Properties("DesignFlowLS").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DesignFlowParameters]() As String
      Get
      Return Properties("DesignFlowParameters").Value
      End Get
      Set(ByVal Value As String)
      Properties("DesignFlowParameters").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DesignPressureDrop]() As String
      Get
      Return Properties("DesignPressureDrop").Value
      End Get
      Set(ByVal Value As String)
      Properties("DesignPressureDrop").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DesignPressureDropkPa]() As String
      Get
      Return Properties("DesignPressureDropkPa").Value
      End Get
      Set(ByVal Value As String)
      Properties("DesignPressureDropkPa").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DesignPressureDropPSI]() As String
      Get
      Return Properties("DesignPressureDropPSI").Value
      End Get
      Set(ByVal Value As String)
      Properties("DesignPressureDropPSI").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EquipmentLocation]() As String
      Get
      Return Properties("EquipmentLocation").Value
      End Get
      Set(ByVal Value As String)
      Properties("EquipmentLocation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [FailPos]() As String
      Get
      Return Properties("FailPos").Value
      End Get
      Set(ByVal Value As String)
      Properties("FailPos").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [FlowCharacterstics]() As String
      Get
      Return Properties("FlowCharacterstics").Value
      End Get
      Set(ByVal Value As String)
      Properties("FlowCharacterstics").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LineSize]() As String
      Get
      Return Properties("LineSize").Value
      End Get
      Set(ByVal Value As String)
      Properties("LineSize").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LinkagePartNumber]() As String
      Get
      Return Properties("LinkagePartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("LinkagePartNumber").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ManufacturerType]() As String
      Get
      Return Properties("ManufacturerType").Value
      End Get
      Set(ByVal Value As String)
      Properties("ManufacturerType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [OtherParameters]() As String
      Get
      Return Properties("OtherParameters").Value
      End Get
      Set(ByVal Value As String)
      Properties("OtherParameters").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Pattern]() As String
      Get
      Return Properties("Pattern").Value
      End Get
      Set(ByVal Value As String)
      Properties("Pattern").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [RadiantHeatBTUHr]() As String
      Get
      Return Properties("RadiantHeatBTUHr").Value
      End Get
      Set(ByVal Value As String)
      Properties("RadiantHeatBTUHr").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [RadiantHeatKW]() As String
      Get
      Return Properties("RadiantHeatKW").Value
      End Get
      Set(ByVal Value As String)
      Properties("RadiantHeatKW").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [RadiantWaterC]() As String
      Get
      Return Properties("RadiantWaterC").Value
      End Get
      Set(ByVal Value As String)
      Properties("RadiantWaterC").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [RadiantWaterF]() As String
      Get
      Return Properties("RadiantWaterF").Value
      End Get
      Set(ByVal Value As String)
      Properties("RadiantWaterF").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Remarks]() As String
      Get
      Return Properties("Remarks").Value
      End Get
      Set(ByVal Value As String)
      Properties("Remarks").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Service_Application]() As String
      Get
      Return Properties("Service_Application").Value
      End Get
      Set(ByVal Value As String)
      Properties("Service_Application").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Signal]() As String
      Get
      Return Properties("Signal").Value
      End Get
      Set(ByVal Value As String)
      Properties("Signal").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SizeIn]() As String
      Get
      Return Properties("SizeIn").Value
      End Get
      Set(ByVal Value As String)
      Properties("SizeIn").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Valve_Data_Master_ID]() As Long
      Get
      Return Properties("Valve_Data_Master_ID").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Valve_Data_Master_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ValveDropAtDesignFlowkPa]() As String
      Get
      Return Properties("ValveDropAtDesignFlowkPa").Value
      End Get
      Set(ByVal Value As String)
      Properties("ValveDropAtDesignFlowkPa").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ValveDropAtDesignFlowPSI]() As String
      Get
      Return Properties("ValveDropAtDesignFlowPSI").Value
      End Get
      Set(ByVal Value As String)
      Properties("ValveDropAtDesignFlowPSI").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ValvePartNumber]() As String
      Get
      Return Properties("ValvePartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("ValvePartNumber").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ValvePressureDrop]() As String
      Get
      Return Properties("ValvePressureDrop").Value
      End Get
      Set(ByVal Value As String)
      Properties("ValvePressureDrop").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ValveTag]() As String
      Get
      Return Properties("ValveTag").Value
      End Get
      Set(ByVal Value As String)
      Properties("ValveTag").CalculatedValue = Value
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
    InitPart("Water_Valve", <a><![CDATA[Water_Valve]]></a>.Value, 124, "HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H599123", "07/17/2025 11:45:31")
    AddProperty("1591", "IsWaterHiddenPro_Enabled", <a><![CDATA[IsWaterHiddenPro_Enabled]]></a>.Value, "", "Boolean","","Analysis","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/14/2025 9:15:16 AM")
    AddProperty("1685", "Cv_DB", <a><![CDATA[Cv_DB]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/15/2025 5:04:44 AM")
    AddProperty("1795", "Max_Size_Available", <a><![CDATA[Max_Size_Available]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/17/2025 10:37:14 AM")
    AddProperty("1574", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/14/2025 9:15:16 AM")
    AddProperty("1575", "ActuatorPartNumber", <a><![CDATA[Actuator Part Number]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 7:48:29 AM")
    AddProperty("1576", "ActuatorType", <a><![CDATA[Type]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/14/2025 9:15:15 AM")
    AddProperty("1679", "Auto_Cv", <a><![CDATA[Auto_Cv]]></a>.Value, "", "Boolean","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/15/2025 4:24:34 AM")
    AddProperty("1577", "BodyRating", <a><![CDATA[Body Rating]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/15/2025 5:20:52 AM")
    AddProperty("1579", "CloseOff", <a><![CDATA[Close Off]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 4:09:39 PM")
    AddProperty("1580", "Conn", <a><![CDATA[Conn.]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/15/2025 5:06:06 AM")
    AddProperty("1581", "ControlType", <a><![CDATA[Control Type]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/14/2025 9:15:16 AM")
    AddProperty("1582", "Cv", <a><![CDATA[Cv]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 7:35:02 AM")
    AddProperty("1690", "DesignFlowGPM", <a><![CDATA[Design Flow GPM]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 4:05:46 PM")
    AddProperty("1691", "DesignFlowLS", <a><![CDATA[Design Flow LS]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 4:06:03 PM")
    AddProperty("1686", "DesignFlowParameters", <a><![CDATA[Design Flow Parameters]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/15/2025 10:12:34 AM")
    AddProperty("1688", "DesignPressureDrop", <a><![CDATA[Design Press Drop]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:01:15 AM")
    AddProperty("1695", "DesignPressureDropkPa", <a><![CDATA[Design Pressure Drop kPa]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 4:08:10 PM")
    AddProperty("1694", "DesignPressureDropPSI", <a><![CDATA[Design Pressure Drop PSI]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 4:08:36 PM")
    AddProperty("1586", "EquipmentLocation", <a><![CDATA[Equipment Location]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/14/2025 9:15:16 AM")
    AddProperty("1587", "FailPos", <a><![CDATA[Fail Pos]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/14/2025 9:15:16 AM")
    AddProperty("1588", "FlowCharacterstics", <a><![CDATA[Flow Characterstics]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/15/2025 5:22:43 AM")
    AddProperty("1595", "LineSize", <a><![CDATA[Line Size]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/14/2025 9:15:16 AM")
    AddProperty("1596", "LinkagePartNumber", <a><![CDATA[Linkage Part Number]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/14/2025 9:15:16 AM")
    AddProperty("1598", "ManufacturerType", <a><![CDATA[Manufacturer Type]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/14/2025 12:41:07 PM")
    AddProperty("1687", "OtherParameters", <a><![CDATA[Other Parameters]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/15/2025 10:48:55 AM")
    AddProperty("1599", "Pattern", <a><![CDATA[Pattern]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/14/2025 9:15:16 AM")
    AddProperty("1692", "RadiantHeatBTUHr", <a><![CDATA[Radiant Heat BTU Hr]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 4:07:05 PM")
    AddProperty("1693", "RadiantHeatKW", <a><![CDATA[Radiant Heat KW]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 4:07:45 PM")
    AddProperty("1604", "RadiantWaterC", <a><![CDATA[Radiant Water (C)]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 4:07:29 PM")
    AddProperty("1605", "RadiantWaterF", <a><![CDATA[Radiant Water (F)]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 4:06:45 PM")
    AddProperty("1606", "Remarks", <a><![CDATA[Remarks]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/14/2025 9:15:16 AM")
    AddProperty("1607", "Service_Application", <a><![CDATA[Service_Application]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/14/2025 9:15:16 AM")
    AddProperty("1608", "Signal", <a><![CDATA[Signal]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/14/2025 9:25:34 AM")
    AddProperty("1609", "SizeIn", <a><![CDATA[Size (In)]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/17/2025 11:45:31 AM")
    AddProperty("1611", "Valve_Data_Master_ID", <a><![CDATA[Valve_Data_Master_ID]]></a>.Value, "", "Long","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 7:54:25 AM")
    AddProperty("1697", "ValveDropAtDesignFlowkPa", <a><![CDATA[Valve Drop At Design Flow kPa]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 4:09:01 PM")
    AddProperty("1696", "ValveDropAtDesignFlowPSI", <a><![CDATA[Valve Drop At Design Flow PSI]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 4:09:21 PM")
    AddProperty("1612", "ValvePartNumber", <a><![CDATA[Valve Part Number]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/15/2025 5:23:50 AM")
    AddProperty("1689", "ValvePressureDrop", <a><![CDATA[Valve Pressure Drop]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:01:30 AM")
    AddProperty("1613", "ValveTag", <a><![CDATA[Valve Tag]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/14/2025 9:15:16 AM")
    
      AddValidValue("ActuatorPartNumber")
    
      AddValidValue("ControlType")
    
      AddValidValue("Cv")
    
      AddValidValue("DesignFlowParameters")
    
      AddValidValue("DesignPressureDrop")
    
      AddValidValue("FailPos")
    
      AddValidValue("LineSize")
    
      AddValidValue("ManufacturerType")
    
      AddValidValue("OtherParameters")
    
      AddValidValue("Pattern")
    
      AddValidValue("Signal")
    
      AddValidValue("SizeIn")
    
      AddValidValue("ValvePressureDrop")
    
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
          InitProperty("IsWaterHiddenPro_Enabled", "1471", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/14/2025 9:15:16 AM", "", "In Development",  0,2690)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cv_DB", "1553", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/15/2025 5:04:44 AM", "", "In Development",  0,2857)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Max_Size_Available", "1660", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/17/2025 10:37:14 AM", "", "In Development",  0,3218)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorPartNumber", "1455", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/16/2025 7:48:29 AM", "", "In Development",  0,2669)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorType", "1456", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/14/2025 9:15:16 AM", "", "In Development",  0,2671)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Auto_Cv", "1547", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/15/2025 4:24:34 AM", "", "In Development",  0,2842)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BodyRating", "1457", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/15/2025 5:20:38 AM", "", "In Development",  0,2859)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CloseOff", "1459", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 4:09:39 PM", "", "In Development",  0,2674)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conn", "1460", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/15/2025 5:06:06 AM", "", "In Development",  0,2858)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControlType", "1461", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/14/2025 9:15:16 AM", "", "In Development",  0,2676)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cv", "1462", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/16/2025 7:35:02 AM", "", "In Development",  0,2834)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignFlowGPM", "1558", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 4:05:46 PM", "", "In Development",  0,2957)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignFlowLS", "1559", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 4:06:03 PM", "", "In Development",  0,2958)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignFlowParameters", "1554", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/15/2025 10:06:03 AM", "", "In Development",  0,2871)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignPressureDrop", "1556", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:01:15 AM", "", "In Development",  0,2878)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignPressureDropkPa", "1563", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 4:08:10 PM", "", "In Development",  0,2961)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignPressureDropPSI", "1562", "", "", "Y", "","", 0, "-1", 0, "", "N","1",  "GLOBAL\H599123", "7/16/2025 4:08:36 PM", "", "In Development",  0,2960)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EquipmentLocation", "1466", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/14/2025 9:15:16 AM", "", "In Development",  0,2683)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FailPos", "1467", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/14/2025 9:15:16 AM", "", "In Development",  0,2684)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FlowCharacterstics", "1468", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/15/2025 5:22:43 AM", "", "In Development",  0,2860)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LineSize", "1475", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/14/2025 9:15:16 AM", "", "In Development",  0,2694)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LinkagePartNumber", "1476", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/14/2025 9:15:16 AM", "", "In Development",  0,2696)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ManufacturerType", "1478", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/14/2025 12:41:07 PM", "", "In Development",  0,2698)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("OtherParameters", "1555", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/15/2025 10:48:55 AM", "", "In Development",  0,2909)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pattern", "1479", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/14/2025 9:15:16 AM", "", "In Development",  0,2700)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("RadiantHeatBTUHr", "1560", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 4:07:05 PM", "", "In Development",  1,2889)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("RadiantHeatKW", "1561", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 4:07:45 PM", "", "In Development",  1,2891)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("RadiantWaterC", "1484", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 4:07:29 PM", "", "In Development",  0,2814)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("RadiantWaterF", "1485", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 4:06:45 PM", "", "In Development",  0,2710)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Remarks", "1486", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/14/2025 9:15:16 AM", "", "In Development",  0,2712)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Service_Application", "1487", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/14/2025 9:15:16 AM", "", "In Development",  0,2713)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Signal", "1488", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/14/2025 9:25:34 AM", "", "In Development",  0,2714)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SizeIn", "1489", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/17/2025 11:45:31 AM", "", "In Development",  0,3300)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Valve_Data_Master_ID", "1491", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 7:54:25 AM", "", "In Development",  0,3060)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ValveDropAtDesignFlowkPa", "1565", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 4:09:01 PM", "", "In Development",  0,2950)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ValveDropAtDesignFlowPSI", "1564", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 4:09:21 PM", "", "In Development",  0,2947)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ValvePartNumber", "1492", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/15/2025 5:23:50 AM", "", "In Development",  0,2861)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ValvePressureDrop", "1557", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:01:30 AM", "", "In Development",  0,2910)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ValveTag", "1493", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/14/2025 9:15:16 AM", "", "In Development",  0,2720)
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
          
        InitValidValue("ActuatorPartNumber_ValidValues", "1455", "-1", 3058)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ControlType_ValidValues", "1461", "-1", 2677)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Cv_ValidValues", "1462", "-1", 3056)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("DesignFlowParameters_ValidValues", "1554", "-1", 2876)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("DesignPressureDrop_ValidValues", "1556", "-1", 2966)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("FailPos_ValidValues", "1467", "-1", 2685)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("LineSize_ValidValues", "1475", "-1", 2695)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ManufacturerType_ValidValues", "1478", "-1", 2775)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("OtherParameters_ValidValues", "1555", "-1", 2877)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Pattern_ValidValues", "1479", "-1", 2701)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Signal_ValidValues", "1488", "-1", 2715)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("SizeIn_ValidValues", "1489", "-1", 3301)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ValvePressureDrop_ValidValues", "1557", "-1", 2967)
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
          Public Function Formula_IsWaterHiddenPro_Enabled() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("IsWaterHiddenPro_Enabled").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1471; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:1471; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_IsWaterHiddenPro_Enabled", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cv_DB() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cv_DB").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1553; TYPE:PF
      If Me.Auto_Cv = False Then
	Return Me.Cv.Split("-")(0)
End if
      '   END FORMULA; PROP ID:1553; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_Cv_DB", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Max_Size_Available() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Max_Size_Available").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1660; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1660; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_Max_Size_Available", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ActuatorPartNumber() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorPartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1455; TYPE:PF
      Return "Please Select..."
      '   END FORMULA; PROP ID:1455; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ActuatorPartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ActuatorType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1456; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Actuator_Type from Actuator_Data_Master  Where Valve_Data_Master_Ref = " & "'" & Me.Valve_Data_Master_ID & "' AND Actuator = " & "'" & Me.ActuatorPartNumber & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If
        Next
    End If

Catch ex As Exception
    g_ObjectManager.LogError("ActuatorType", ex.ToString)
End Try

Return displayValue
      '   END FORMULA; PROP ID:1456; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ActuatorType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Auto_Cv() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Auto_Cv").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1547; TYPE:PF
      result = True
      '   END FORMULA; PROP ID:1547; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_Auto_Cv", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BodyRating() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BodyRating").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1457; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

If Me.Auto_CV = False Then
	SQLToExecute = "select Body_Rating from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv_DB & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
Else
	SQLToExecute = "select Body_Rating from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
End If

ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If
        Next
    Else
        Throw New Exception("[BodyRating] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("BodyRating", ex.ToString)
End Try

Return displayValue
      '   END FORMULA; PROP ID:1457; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_BodyRating", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CloseOff() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CloseOff").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1459; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Close_Off from Actuator_Data_Master  Where Valve_Data_Master_Ref = " & "'" & Me.Valve_Data_Master_ID & "' AND Actuator = " & "'" & Me.ActuatorPartNumber & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If
        Next
    Else
        Throw New Exception("[CloseOff] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("CloseOff", ex.ToString)
End Try

Return displayValue
      '   END FORMULA; PROP ID:1459; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_CloseOff", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conn() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conn").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1460; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue, Max_ValveData_Master_ID As String

If Me.Auto_CV = False Then
	SQLToExecute = "Select Connection from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "' And Cv = " & "'" & Me.Cv_DB & "'"
Else
	SQLToExecute = "Select Connection from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "' And Cv = " & "'" & Me.Cv & "'"
End If

ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If
        Next
    Else
        Throw New Exception("[Conn] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Conn", ex.ToString)
End Try

Return displayValue
      '   END FORMULA; PROP ID:1460; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_Conn", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControlType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControlType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1461; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1461; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ControlType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Cv() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cv").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1462; TYPE:PF
      Return FirstValidValue(Me,"Cv")
      '   END FORMULA; PROP ID:1462; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_Cv", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DesignFlowGPM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignFlowGPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1558; TYPE:PF
      Return ""
      '   END FORMULA; PROP ID:1558; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignFlowGPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DesignFlowLS() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignFlowLS").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1559; TYPE:PF
      Return ""
      '   END FORMULA; PROP ID:1559; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignFlowLS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DesignFlowParameters() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignFlowParameters").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1554; TYPE:PF
      Result = 1
      '   END FORMULA; PROP ID:1554; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignFlowParameters", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DesignPressureDrop() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignPressureDrop").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1556; TYPE:PF
      Result = 1
      '   END FORMULA; PROP ID:1556; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignPressureDrop", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DesignPressureDropkPa() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignPressureDropkPa").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1563; TYPE:PF
      Return ""
      '   END FORMULA; PROP ID:1563; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignPressureDropkPa", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DesignPressureDropPSI() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignPressureDropPSI").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1562; TYPE:PF
      Return ""
      '   END FORMULA; PROP ID:1562; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignPressureDropPSI", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EquipmentLocation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EquipmentLocation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1466; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1466; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_EquipmentLocation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_FailPos() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("FailPos").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1467; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1467; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_FailPos", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_FlowCharacterstics() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("FlowCharacterstics").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1468; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

If Me.Auto_CV = False Then
	 SQLToExecute = "select Flow_Characteristic from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv_DB & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"

Else
	SQLToExecute = "select Flow_Characteristic from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
End If

ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If
        Next
    Else
        Throw New Exception("[FlowCharacterstics] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("FlowCharacterstics", ex.ToString)
End Try

Return displayValue
      '   END FORMULA; PROP ID:1468; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_FlowCharacterstics", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LineSize() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LineSize").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1475; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1475; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_LineSize", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LinkagePartNumber() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LinkagePartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1476; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Linkage from Actuator_Data_Master  Where Valve_Data_Master_Ref = " & "'" & Me.Valve_Data_Master_ID & "' AND Actuator = " & "'" & Me.ActuatorPartNumber & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If
        Next
    Else
        Throw New Exception("[LinkagePartNumber] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("LinkagePartNumber", ex.ToString)
End Try

Return displayValue
      '   END FORMULA; PROP ID:1476; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_LinkagePartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ManufacturerType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ManufacturerType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1478; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1478; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ManufacturerType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_OtherParameters() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("OtherParameters").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1555; TYPE:PF
      Result = 3
      '   END FORMULA; PROP ID:1555; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_OtherParameters", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Pattern() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Pattern").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1479; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1479; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_Pattern", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_RadiantHeatBTUHr() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("RadiantHeatBTUHr").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1560; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1560; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_RadiantHeatBTUHr", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_RadiantHeatKW() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("RadiantHeatKW").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1561; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1561; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_RadiantHeatKW", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_RadiantWaterC() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("RadiantWaterC").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1484; TYPE:PF
      Return ""
      '   END FORMULA; PROP ID:1484; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_RadiantWaterC", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_RadiantWaterF() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("RadiantWaterF").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1485; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1485; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_RadiantWaterF", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Remarks() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Remarks").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1486; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Remarks from Actuator_Data_Master  Where Valve_Data_Master_Ref = " & "'" & Me.Valve_Data_Master_ID & "' AND Actuator = " & "'" & Me.ActuatorPartNumber & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If
        Next
    Else
        Throw New Exception("[Remarks] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Remarks", ex.ToString)
End Try

Return displayValue
      '   END FORMULA; PROP ID:1486; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_Remarks", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Service_Application() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Service_Application").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1487; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1487; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_Service_Application", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Signal() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Signal").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1488; TYPE:PF
      Return "Please Select..."
      '   END FORMULA; PROP ID:1488; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_Signal", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SizeIn() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SizeIn").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1489; TYPE:PF
      Dim defaultSize = Me.LineSize
Dim Match_Found As Boolean = False

If Me.Auto_Cv Then
	Return FirstValidValue(Me,"SizeIn")
Else
	
	If Me.Cv.Contains("0.5") Then
		Return "1/2"
	ElseIf Me.Cv.Contains("0.75") Then
		Return "3/4"
	ElseIf Me.Cv.Contains("1.25") Then
		Return "1 1/4"
	ElseIf Me.Cv.Contains("1.5") Then
		Return "1 1/2"	
	ElseIf Me.Cv.Contains("2.5") Then
		Return "2 1/2"
	Else
		Return (Me.Cv.Split("- (")(1)).Split(")")(0).Split("(")(1).Split("in")(0)
	End If
End If
      '   END FORMULA; PROP ID:1489; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_SizeIn", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Valve_Data_Master_ID() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Valve_Data_Master_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1491; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

If Me.Auto_Cv = False Then
	SQLToExecute = "select Valve_Data_Master_ID from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv_DB & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
Else
	SQLToExecute = "select Valve_Data_Master_ID from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"	
End If
	
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If
        Next
    Else
        Throw New Exception("[Valve_Data_Master_ID] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Valve_Data_Master_ID", ex.ToString)
End Try

Return displayValue
      '   END FORMULA; PROP ID:1491; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_Valve_Data_Master_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ValveDropAtDesignFlowkPa() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ValveDropAtDesignFlowkPa").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1565; TYPE:PF
      Return ""
      '   END FORMULA; PROP ID:1565; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ValveDropAtDesignFlowkPa", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ValveDropAtDesignFlowPSI() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ValveDropAtDesignFlowPSI").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1564; TYPE:PF
      Return ""
      '   END FORMULA; PROP ID:1564; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ValveDropAtDesignFlowPSI", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ValvePartNumber() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ValvePartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1492; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

If Me.Auto_CV = False Then
	SQLToExecute = "select Part_Number from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv_DB & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"

Else
	SQLToExecute = "select Part_Number from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
End If

ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If
        Next
    Else
        Throw New Exception("[ValvePartNumber] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("ValvePartNumber", ex.ToString)
End Try

Return displayValue
      '   END FORMULA; PROP ID:1492; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ValvePartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ValvePressureDrop() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ValvePressureDrop").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1557; TYPE:PF
      Result = 3
      '   END FORMULA; PROP ID:1557; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ValvePressureDrop", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ValveTag() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ValveTag").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1493; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1493; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ValveTag", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IsWaterHiddenPro_Enabled_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cv_DB_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Max_Size_Available_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorPartNumber_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Auto_Cv_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BodyRating_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CloseOff_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conn_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControlType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cv_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DesignFlowGPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DesignFlowLS_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DesignFlowParameters_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DesignPressureDrop_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DesignPressureDropkPa_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DesignPressureDropPSI_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EquipmentLocation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FailPos_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FlowCharacterstics_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LineSize_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LinkagePartNumber_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ManufacturerType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_OtherParameters_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pattern_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RadiantHeatBTUHr_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RadiantHeatKW_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RadiantWaterC_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RadiantWaterF_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Remarks_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Service_Application_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Signal_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SizeIn_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Valve_Data_Master_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ValveDropAtDesignFlowkPa_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ValveDropAtDesignFlowPSI_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ValvePartNumber_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ValvePressureDrop_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ValveTag_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IsWaterHiddenPro_Enabled_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cv_DB_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Max_Size_Available_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorPartNumber_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Auto_Cv_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BodyRating_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CloseOff_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conn_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControlType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cv_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DesignFlowGPM_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("DesignFlowGPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1558; TYPE:UC
              If Me.DesignFlowParameters = 1 Then
	Return True
End If
              '   END FORMULA; PROP ID:1558; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignFlowGPM_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DesignFlowLS_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("DesignFlowLS").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1559; TYPE:UC
              If Me.DesignFlowParameters = 2 Then
	Return True
End If
              '   END FORMULA; PROP ID:1559; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignFlowLS_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DesignFlowParameters_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DesignPressureDrop_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DesignPressureDropkPa_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("DesignPressureDropkPa").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1563; TYPE:UC
              If Me.DesignPressureDrop = 2 Then
	Return True
End If
              '   END FORMULA; PROP ID:1563; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignPressureDropkPa_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DesignPressureDropPSI_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("DesignPressureDropPSI").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1562; TYPE:UC
              If Me.DesignPressureDrop = 1 Then
	Return True
End If
              '   END FORMULA; PROP ID:1562; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignPressureDropPSI_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EquipmentLocation_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FailPos_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FlowCharacterstics_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LineSize_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LinkagePartNumber_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ManufacturerType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_OtherParameters_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pattern_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RadiantHeatBTUHr_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("RadiantHeatBTUHr").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1560; TYPE:UC
              If Me.OtherParameters = 1 Then
	Return True
End If
              '   END FORMULA; PROP ID:1560; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_RadiantHeatBTUHr_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RadiantHeatKW_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("RadiantHeatKW").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1561; TYPE:UC
              If Me.OtherParameters = 2 Then
	Return True
End If
              '   END FORMULA; PROP ID:1561; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_RadiantHeatKW_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RadiantWaterC_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("RadiantWaterC").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1484; TYPE:UC
              If Me.OtherParameters = 2 Then
	Return True
End If
              '   END FORMULA; PROP ID:1484; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_RadiantWaterC_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RadiantWaterF_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("RadiantWaterF").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1485; TYPE:UC
              If Me.OtherParameters = 1 Then
	Return True
End If
              '   END FORMULA; PROP ID:1485; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_RadiantWaterF_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Remarks_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Service_Application_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Signal_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SizeIn_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Valve_Data_Master_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ValveDropAtDesignFlowkPa_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("ValveDropAtDesignFlowkPa").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1565; TYPE:UC
              If Me.ValvePressureDrop = 2 Then
	Return True
End If
              '   END FORMULA; PROP ID:1565; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ValveDropAtDesignFlowkPa_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ValveDropAtDesignFlowPSI_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("ValveDropAtDesignFlowPSI").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1564; TYPE:UC
              If Me.ValvePressureDrop = 1 Then
	Return True
End If
              '   END FORMULA; PROP ID:1564; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ValveDropAtDesignFlowPSI_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ValvePartNumber_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ValvePressureDrop_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ValveTag_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ActuatorPartNumber_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ActuatorPartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1455; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select distinct  Actuator from Actuator_Data_Master where Valve_Data_Master_Ref = " & "'" & Me.Valve_Data_Master_ID & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    Else
        Throw New Exception("[Valve_Data_Master_ID] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Valve_Data_Master_ID", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1455; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ActuatorPartNumber_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControlType_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControlType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1461; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Control_Type from [dbo].[Control_Type_Master]"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    'Else
        'Throw New Exception("[ControlType] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("ControlType", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1461; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ControlType_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cv_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Cv").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1462; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim SQlWhereClause As String = ""
Dim ds As DataSet
Dim displayValue As String
Dim keyValue As String

If Me.Auto_Cv Then
	SQlWhereClause = "select min(Size) from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"

	SQLToExecute = "Select Cv from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Size = " & "(" & SQlWhereClause & ") AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
	ds = g_ComponentData.ExecuteSQL(SQLToExecute)

	Try
    	If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        	For Each dr As DataRow In ds.Tables(0).Rows
            	If IsDBNull(dr.Item(0)) Then
                	keyValue = String.Empty
            	Else
                	keyValue = dr.Item(0).ToString.Trim
            	End If
				
				If Not validValuesCollection.Contains(keyValue) Then
					If keyValue = "0.5" Then
						displayValue = "1/2"
					ElseIf 	keyValue = "0.75" Then
						displayValue = "3/4"
					ElseIf 	keyValue = "1.25" Then
						displayValue = "1 1/4"
					ElseIf 	keyValue = "1.5" Then
						displayValue = "1 1/2"
					ElseIf 	keyValue = "2.5" Then
						displayValue = "2 1/2"
					Else
						displayValue = keyValue
					End If
					If Not validValuesCollection.Contains(keyValue) Then
    					validValuesCollection.Add(keyValue, displayValue)
					End If
            	End If
				Exit For
        	Next
    	Else
        	Throw New Exception("[Cv] Unable to create valid values; no data was returned.")
    	End If

	Catch ex As Exception
    	g_ObjectManager.LogError("Cv", ex.ToString)
	End Try
Else
	SQLToExecute = "Select (Cv + ' - ' + '('+ Size + 'in)') as size  from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "' Order By Valve_Data_Master_ID DESC"
	ds = g_ComponentData.ExecuteSQL(SQLToExecute)

	Try
    	If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        	For Each dr As DataRow In ds.Tables(0).Rows
            	If IsDBNull(dr.Item(0)) Then
                	keyValue = String.Empty
            	Else
                	keyValue = dr.Item(0).ToString.Trim
            	End If
				
				If Not validValuesCollection.Contains(keyValue) Then
					If keyValue = "0.5" Then
						displayValue = "1/2"
					ElseIf 	keyValue = "0.75" Then
						displayValue = "3/4"
					ElseIf 	keyValue = "1.25" Then
						displayValue = "1 1/4"
					ElseIf 	keyValue = "1.5" Then
						displayValue = "1 1/2"
					ElseIf 	keyValue = "2.5" Then
						displayValue = "2 1/2"
					Else
						displayValue = keyValue
					End If
					If Not validValuesCollection.Contains(keyValue) Then
    					validValuesCollection.Add(keyValue, displayValue)
					End If
				End If
        	Next
    	Else
        	Throw New Exception("[Cv] Unable to create valid values; no data was returned.")
    	End If

	Catch ex As Exception
    	g_ObjectManager.LogError("Cv", ex.ToString)
	End Try	
End If

Return validValuesCollection
      '   END FORMULA; PROP ID:1462; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_Cv_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DesignFlowParameters_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignFlowParameters").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1554; TYPE:VV
      Result = MakeValidKeyValues(Array("1", "2", "3"), Array("Gallons Per Minute (GPM)", "Litres Per Second (L/S)", " --- "))
      '   END FORMULA; PROP ID:1554; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignFlowParameters_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DesignPressureDrop_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignPressureDrop").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1556; TYPE:VV
      Result = MakeValidKeyValues(Array("1", "2", "3"), Array("Pound Per Inch (PSI)", "Kilo Pascals (kPa)", " --- "))
      '   END FORMULA; PROP ID:1556; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignPressureDrop_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FailPos_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("FailPos").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1467; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Fail_Pos_1 from Actuator_Data_Master Where Valve_Data_Master_Ref = " & "'" & Me.Valve_Data_Master_ID & "' AND Actuator = " & "'" & Me.ActuatorPartNumber & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    Else
        Throw New Exception("[FailPos] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("FailPos", ex.ToString)
End Try

SQLToExecute = "select Fail_Pos_2 from Actuator_Data_Master Where Valve_Data_Master_Ref = " & "'" & Me.Valve_Data_Master_ID & "' AND Actuator = " & "'" & Me.ActuatorPartNumber & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    Else
        Throw New Exception("[FailPos] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("FailPos", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1467; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_FailPos_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LineSize_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LineSize").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1475; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Line_Size from [dbo].[Line_Size_Master] order by [Sort_Order] ASC "
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    Else
        Throw New Exception("[LineSize] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("LineSize", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1475; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_LineSize_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ManufacturerType_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ManufacturerType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1478; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Manufacturer_Type from [dbo].[Manufacturer_Type_Master] where Media = 'WATER' order by [Sort_Order] ASC"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    Else
        Throw New Exception("[ManufacturerType] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("ManufacturerType", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1478; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ManufacturerType_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_OtherParameters_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("OtherParameters").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1555; TYPE:VV
      Result = MakeValidKeyValues(Array("1", "2", "3"), Array("BTU Hour (BTU - Hr.) * Radiant Heats", "KiloWatts (KW) * Radiant Heats", " --- "))
      '   END FORMULA; PROP ID:1555; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_OtherParameters_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pattern_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Pattern").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1479; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Valve_Type from [dbo].[Valve_Type_Master]"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    Else
        Throw New Exception("[Pattern] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Pattern", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1479; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_Pattern_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Signal_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Signal").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1488; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select signal_1 from Actuator_Data_Master Where Valve_Data_Master_Ref = " & "'" & Me.Valve_Data_Master_ID & "' AND Actuator = " & "'" & Me.ActuatorPartNumber & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    Else
        Throw New Exception("[Signal] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Signal", ex.ToString)
End Try

SQLToExecute = "select signal_2 from Actuator_Data_Master Where Valve_Data_Master_Ref = " & "'" & Me.Valve_Data_Master_ID & "' AND Actuator = " & "'" & Me.ActuatorPartNumber & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    Else
        Throw New Exception("[Signal] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Signal", ex.ToString)
End Try

SQLToExecute = "select signal_3 from Actuator_Data_Master Where Valve_Data_Master_Ref = " & "'" & Me.Valve_Data_Master_ID & "' AND Actuator = " & "'" & Me.ActuatorPartNumber & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    Else
        Throw New Exception("[Signal] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Signal", ex.ToString)
End Try

SQLToExecute = "select signal_4 from Actuator_Data_Master Where Valve_Data_Master_Ref = " & "'" & Me.Valve_Data_Master_ID & "' AND Actuator = " & "'" & Me.ActuatorPartNumber & "'"
ds = g_ComponentData.ExecuteSQL(SQLToExecute)

Try
    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        For Each dr As DataRow In ds.Tables(0).Rows
            If IsDBNull(dr.Item(0)) Then
                displayValue = String.Empty
            Else
                displayValue = dr.Item(0).ToString.Trim
            End If

            If Not validValuesCollection.Contains(displayValue) Then
                validValuesCollection.Add(displayValue)
            End If
        Next
    Else
        Throw New Exception("[Signal] Unable to create valid values; no data was returned.")
    End If

Catch ex As Exception
    g_ObjectManager.LogError("Signal", ex.ToString)
End Try

Return validValuesCollection
      '   END FORMULA; PROP ID:1488; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_Signal_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SizeIn_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SizeIn").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1489; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim SQlWhereClause As String = ""
Dim ds As DataSet
Dim displayValue, keyValue As String
Dim Match_Found As Boolean = False
Dim defaultSize = Me.LineSize

If Me.Auto_Cv Then
	For Each _size As String In Schedule_Size_List(Me.ManufacturerType,Me.Pattern)
		If defaultSize = _size Then
			Match_Found = True
		End If
	Next
	
	If Match_Found Then
		If Not validValuesCollection.Contains(defaultSize) Then
    		validValuesCollection.Add(defaultSize, defaultSize)
		End If
	Else
		SQlWhereClause = "select min(Size) from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"

		SQLToExecute = "Select size from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Size = " & "(" & SQlWhereClause & ") AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
		ds = g_ComponentData.ExecuteSQL(SQLToExecute)

		Try
    		If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        		For Each dr As DataRow In ds.Tables(0).Rows
            		If IsDBNull(dr.Item(0)) Then
                		keyValue = String.Empty
            		Else
                		keyValue = dr.Item(0).ToString.Trim
            		End If
					
					If Not validValuesCollection.Contains(keyValue) Then
						If keyValue = "0.5" Then
							displayValue = "1/2"
						ElseIf 	keyValue = "0.75" Then
							displayValue = "3/4"
						ElseIf 	keyValue = "1.25" Then
							displayValue = "1 1/4"
						ElseIf 	keyValue = "1.5" Then
							displayValue = "1 1/2"
						ElseIf 	keyValue = "2.5" Then
							displayValue = "2 1/2"
						Else
							displayValue = keyValue
						End If
						If Not validValuesCollection.Contains(keyValue) Then
    						validValuesCollection.Add(keyValue, displayValue)
						End If
            		End If
        		Next
    		Else
        		Throw New Exception("[SizeIn] Unable to create valid values; no data was returned.")
    		End If
			Catch ex As Exception
    		g_ObjectManager.LogError("SizeIn", ex.ToString)
		End Try
	End If
Else
	SQLToExecute = "Select size  from Valve_Data_Master where Media = 'WATER' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "' Order By Valve_Data_Master_ID DESC"
	ds = g_ComponentData.ExecuteSQL(SQLToExecute)

	Try
    	If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
        	For Each dr As DataRow In ds.Tables(0).Rows
            	If IsDBNull(dr.Item(0)) Then
                	keyValue = String.Empty
            	Else
                	keyValue = dr.Item(0).ToString.Trim
            	End If
				
				If Not validValuesCollection.Contains(keyValue) Then
					If keyValue = "0.5" Then
						displayValue = "1/2"
					ElseIf 	keyValue = "0.75" Then
						displayValue = "3/4"
					ElseIf 	keyValue = "1.25" Then
						displayValue = "1 1/4"
					ElseIf 	keyValue = "1.5" Then
						displayValue = "1 1/2"
					ElseIf 	keyValue = "2.5" Then
						displayValue = "2 1/2"
					Else
						displayValue = keyValue
					End If
					If Not validValuesCollection.Contains(keyValue) Then
    					validValuesCollection.Add(keyValue, displayValue)
					End If
            	End If
        	Next
    	Else
        	Throw New Exception("[SizeIn] Unable to create valid values; no data was returned.")
    	End If

	Catch ex As Exception
    	g_ObjectManager.LogError("SizeIn", ex.ToString)
	End Try	
End If

Return validValuesCollection
      '   END FORMULA; PROP ID:1489; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_SizeIn_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ValvePressureDrop_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ValvePressureDrop").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1557; TYPE:VV
      Result = MakeValidKeyValues(Array("1", "2", "3"), Array("Pound Per Inch (PSI)", "Kilo Pascals (kPa)", " --- "))
      '   END FORMULA; PROP ID:1557; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ValvePressureDrop_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_CloseOff_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CloseOff").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1459; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Close Off",MessageBoxButtons.OkCancel,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1459; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_CloseOff_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_DesignFlowGPM_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignFlowGPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1558; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Design Flow GPM",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1558; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignFlowGPM_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_DesignFlowLS_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignFlowLS").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1559; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Design Flow LS",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1559; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignFlowLS_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_DesignPressureDropkPa_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignPressureDropkPa").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1563; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Design Pressure Drop kPa",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1563; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignPressureDropkPa_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_DesignPressureDropPSI_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignPressureDropPSI").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1562; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Design Pressure Drop PSI",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1562; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_DesignPressureDropPSI_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_RadiantHeatBTUHr_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("RadiantHeatBTUHr").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1560; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Radiant Heat BTU Hr",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1560; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_RadiantHeatBTUHr_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_RadiantHeatKW_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("RadiantHeatKW").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1561; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Radiant Heat KW",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1561; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_RadiantHeatKW_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_RadiantWaterC_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("RadiantWaterC").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1484; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Radiant Water(C)",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1484; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_RadiantWaterC_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_RadiantWaterF_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("RadiantWaterF").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1485; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Radiant Water(F)",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1485; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_RadiantWaterF_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_ValveDropAtDesignFlowkPa_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ValveDropAtDesignFlowkPa").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1565; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Valve Drop At Design Flow kPa",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1565; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ValveDropAtDesignFlowkPa_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_ValveDropAtDesignFlowPSI_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ValveDropAtDesignFlowPSI").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1564; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Valve Drop At Design Flow PSI",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1564; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Water_Valve.Formula_ValveDropAtDesignFlowPSI_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    

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

  