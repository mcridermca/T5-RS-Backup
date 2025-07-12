Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: Valve
'$ GenerateDate: 07/12/2025 14:09:33

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

    Public Class [Valve]
    
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

    Private this as Valve = me

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
    
      Case "EnableHiddenData_"
      Formula_EnableHiddenData_WHENCHANGED(Value, OldValue)
    
      Case "DisableHiddenData_"
      Formula_DisableHiddenData_WHENCHANGED(Value, OldValue)
    
    End Select
    End Sub

    Public Function OnChangedStatus(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String)As Boolean Implements RuleStream.IRsPartFormulas.OnChangedStatus
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Dim Status as Boolean = False
    Select Case specName & "_" & context
    
      Case "EnableHiddenData_"
      'Formula_EnableHiddenData_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "DisableHiddenData_"
      'Formula_DisableHiddenData_WHENCHANGED(Value, OldValue)
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
    
          Public Property [PartNumber]() As String
      Get
      Return Properties("PartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartNumber").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EnableHiddenData]() As String
      Get
      Return Properties("EnableHiddenData").Value
      End Get
      Set(ByVal Value As String)
      Properties("EnableHiddenData").CalculatedValue = Value
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
    
          Public Property [BodyRating]() As String
      Get
      Return Properties("BodyRating").Value
      End Get
      Set(ByVal Value As String)
      Properties("BodyRating").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BTU_Hour]() As Boolean
      Get
      Return Properties("BTU_Hour").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("BTU_Hour").CalculatedValue = Value
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
    
          Public Property [DesignPressureDropPSI]() As String
      Get
      Return Properties("DesignPressureDropPSI").Value
      End Get
      Set(ByVal Value As String)
      Properties("DesignPressureDropPSI").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DisableHiddenData]() As String
      Get
      Return Properties("DisableHiddenData").Value
      End Get
      Set(ByVal Value As String)
      Properties("DisableHiddenData").CalculatedValue = Value
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
    
          Public Property [GallonsPerMin]() As Boolean
      Get
      Return Properties("GallonsPerMin").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("GallonsPerMin").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [KiloWatts]() As Boolean
      Get
      Return Properties("KiloWatts").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("KiloWatts").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [kPa_Design]() As Boolean
      Get
      Return Properties("kPa_Design").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("kPa_Design").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [kPa_Valve]() As Boolean
      Get
      Return Properties("kPa_Valve").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("kPa_Valve").CalculatedValue = Value
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
    
          Public Property [LitresPerSec]() As Boolean
      Get
      Return Properties("LitresPerSec").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("LitresPerSec").CalculatedValue = Value
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
    
          Public Property [Pattern]() As String
      Get
      Return Properties("Pattern").Value
      End Get
      Set(ByVal Value As String)
      Properties("Pattern").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PSI_Design]() As Boolean
      Get
      Return Properties("PSI_Design").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("PSI_Design").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PSI_Valve]() As Boolean
      Get
      Return Properties("PSI_Valve").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("PSI_Valve").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [RadiantHeatBTUHR]() As String
      Get
      Return Properties("RadiantHeatBTUHR").Value
      End Get
      Set(ByVal Value As String)
      Properties("RadiantHeatBTUHR").CalculatedValue = Value
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
    
          Public Property [ValvePartNumber]() As String
      Get
      Return Properties("ValvePartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("ValvePartNumber").CalculatedValue = Value
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
    
      Public ReadOnly Property [WaterValveCol]() As Rulestream.Kernel.Connection
      Get
      Return Connections("WaterValveCol")
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
    InitPart("Valve", <a><![CDATA[Valve]]></a>.Value, 121, "HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H599123", "07/11/2025 09:45:12")
    AddProperty("1533", "IsWaterHiddenPro_Enabled", <a><![CDATA[IsWaterHiddenPro_Enabled]]></a>.Value, "", "Boolean","","Analysis","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 5:25:35 AM")
    AddProperty("1492", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/9/2025 1:24:03 PM")
    AddProperty("1545", "EnableHiddenData", <a><![CDATA[Enable Water Data]]></a>.Value, "", "String","","UI Control","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 10:21:55 AM")
    AddProperty("1493", "ActuatorPartNumber", <a><![CDATA[Actuator Part Number]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/11/2025 5:29:07 AM")
    AddProperty("1494", "ActuatorType", <a><![CDATA[Type]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 11:23:14 AM")
    AddProperty("1495", "BodyRating", <a><![CDATA[Body Rating]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 9:59:59 AM")
    AddProperty("1538", "BTU_Hour", <a><![CDATA[BTU_Hour]]></a>.Value, "", "Boolean","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 6:56:30 AM")
    AddProperty("1496", "CloseOff", <a><![CDATA[Close Off]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 10:46:08 AM")
    AddProperty("1497", "Conn", <a><![CDATA[Conn.]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 9:57:49 AM")
    AddProperty("1498", "ControlType", <a><![CDATA[Control Type]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/11/2025 5:24:29 AM")
    AddProperty("1499", "Cv", <a><![CDATA[Cv]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/9/2025 1:28:32 PM")
    AddProperty("1500", "DesignFlowGPM", <a><![CDATA[Design Flow (GPM)]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/9/2025 1:28:57 PM")
    AddProperty("1529", "DesignFlowLS", <a><![CDATA[Design Flow (L/S)]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 5:27:00 AM")
    AddProperty("1550", "DesignPressureDropPSI", <a><![CDATA[Design Pressure Drop (PSI)]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/11/2025 5:54:33 AM")
    AddProperty("1546", "DisableHiddenData", <a><![CDATA[Disable Hidden Data]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 10:30:22 AM")
    AddProperty("1502", "EquipmentLocation", <a><![CDATA[Equipment Location]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/9/2025 1:29:51 PM")
    AddProperty("1503", "FailPos", <a><![CDATA[Fail Pos]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/11/2025 5:26:09 AM")
    AddProperty("1504", "FlowCharacterstics", <a><![CDATA[Flow Characterstics]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 9:56:33 AM")
    AddProperty("1535", "GallonsPerMin", <a><![CDATA[GallonsPerMin]]></a>.Value, "", "Boolean","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 6:53:47 AM")
    AddProperty("1539", "KiloWatts", <a><![CDATA[KiloWatts]]></a>.Value, "", "Boolean","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 6:57:01 AM")
    AddProperty("1543", "kPa_Design", <a><![CDATA[kPa_Design]]></a>.Value, "", "Boolean","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 7:02:18 AM")
    AddProperty("1544", "kPa_Valve", <a><![CDATA[kPa_Valve]]></a>.Value, "", "Boolean","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 7:02:46 AM")
    AddProperty("1505", "LineSize", <a><![CDATA[Line Size]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/11/2025 9:19:46 AM")
    AddProperty("1506", "LinkagePartNumber", <a><![CDATA[Linkage Part Number]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 10:46:24 AM")
    AddProperty("1537", "LitresPerSec", <a><![CDATA[LitresPerSec]]></a>.Value, "", "Boolean","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 6:55:55 AM")
    AddProperty("1507", "ManufacturerType", <a><![CDATA[Manufacturer Type]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/11/2025 9:19:59 AM")
    AddProperty("1508", "Pattern", <a><![CDATA[Pattern]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/11/2025 5:26:41 AM")
    AddProperty("1542", "PSI_Design", <a><![CDATA[PSI_Design]]></a>.Value, "", "Boolean","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 10:31:32 AM")
    AddProperty("1541", "PSI_Valve", <a><![CDATA[PSI_Valve]]></a>.Value, "", "Boolean","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 6:59:01 AM")
    AddProperty("1531", "RadiantHeatBTUHR", <a><![CDATA[Radiant Heat (BTU-HR)]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 5:26:44 AM")
    AddProperty("1534", "RadiantHeatKW", <a><![CDATA[Radiant Heat (KW)]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 5:30:08 AM")
    AddProperty("1532", "RadiantWaterC", <a><![CDATA[Radiant Water (C)]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 5:26:38 AM")
    AddProperty("1530", "RadiantWaterF", <a><![CDATA[Radiant Water (F)]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 5:26:50 AM")
    AddProperty("1509", "Remarks", <a><![CDATA[Remarks]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 10:47:08 AM")
    AddProperty("1510", "Service_Application", <a><![CDATA[Service_Application]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/9/2025 1:36:29 PM")
    AddProperty("1511", "Signal", <a><![CDATA[Signal]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/11/2025 5:26:54 AM")
    AddProperty("1512", "SizeIn", <a><![CDATA[Size (In)]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/9/2025 1:37:24 PM")
    AddProperty("1547", "Valve_Data_Master_ID", <a><![CDATA[Valve_Data_Master_ID]]></a>.Value, "", "Long","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 10:37:46 AM")
    AddProperty("1513", "ValvePartNumber", <a><![CDATA[Valve Part Number]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/10/2025 9:52:44 AM")
    AddProperty("1514", "ValveTag", <a><![CDATA[Valve Tag]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/9/2025 1:38:12 PM")
    
      AddPropertyExtended(1545,"EnableHiddenData", "1426", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H599123", "7/10/2025 10:21:55 AM")
    
      AddValidValue("ActuatorPartNumber")
    
      AddValidValue("ControlType")
    
      AddValidValue("FailPos")
    
      AddValidValue("LineSize")
    
      AddValidValue("ManufacturerType")
    
      AddValidValue("Pattern")
    
      AddValidValue("Signal")
    
      oConnection = AddConnection("WaterValveCol", <a><![CDATA[WaterValveCol]]></a>.Value, "", "81", "OM", 0, "","General", 9999, "", "GLOBAL\H599123", "7/10/2025 12:07:28 PM")
      
        oConnection.AddVPF(121, "Valve")
      
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
          InitProperty("IsWaterHiddenPro_Enabled", "1414", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 5:25:35 AM", "", "In Development",  0,2532)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EnableHiddenData", "1426", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 10:21:55 AM", "", "In Development",  0,2549)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorPartNumber", "1374", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/11/2025 5:29:07 AM", "", "In Development",  0,2576)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorType", "1375", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 11:23:14 AM", "", "In Development",  0,2584)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BodyRating", "1376", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 9:59:57 AM", "", "In Development",  0,2557)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BTU_Hour", "1419", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 6:56:30 AM", "", "In Development",  0,2542)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CloseOff", "1377", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 10:46:08 AM", "", "In Development",  0,2569)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conn", "1378", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 9:57:49 AM", "", "In Development",  0,2556)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControlType", "1379", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/11/2025 5:24:29 AM", "", "In Development",  0,2593)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cv", "1380", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/9/2025 1:28:32 PM", "", "In Development",  0,2481)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignFlowGPM", "1381", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/9/2025 1:28:57 PM", "", "In Development",  0,2482)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignFlowLS", "1410", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 5:27:00 AM", "", "In Development",  0,2528)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignPressureDropPSI", "1431", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/11/2025 5:54:33 AM", "", "In Development",  0,2596)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DisableHiddenData", "1427", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 10:30:22 AM", "", "In Development",  0,2559)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EquipmentLocation", "1383", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/9/2025 1:29:51 PM", "", "In Development",  0,2484)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FailPos", "1384", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/11/2025 5:26:09 AM", "", "In Development",  0,2586)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FlowCharacterstics", "1385", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 9:56:33 AM", "", "In Development",  0,2555)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("GallonsPerMin", "1416", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 6:53:47 AM", "", "In Development",  0,2539)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("KiloWatts", "1420", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 6:57:01 AM", "", "In Development",  0,2543)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("kPa_Design", "1424", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 7:02:18 AM", "", "In Development",  0,2547)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("kPa_Valve", "1425", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 7:02:46 AM", "", "In Development",  0,2548)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LineSize", "1386", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/11/2025 9:19:46 AM", "", "In Development",  0,2582)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LinkagePartNumber", "1387", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 10:46:24 AM", "", "In Development",  0,2570)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LitresPerSec", "1418", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 6:55:55 AM", "", "In Development",  0,2541)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ManufacturerType", "1388", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/11/2025 9:19:59 AM", "", "In Development",  0,2579)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pattern", "1389", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/11/2025 5:26:41 AM", "", "In Development",  0,2580)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PSI_Design", "1423", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 10:31:32 AM", "", "In Development",  0,2563)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PSI_Valve", "1422", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 6:59:01 AM", "", "In Development",  0,2545)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("RadiantHeatBTUHR", "1412", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 5:26:44 AM", "", "In Development",  0,2530)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("RadiantHeatKW", "1415", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 5:30:08 AM", "", "In Development",  0,2537)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("RadiantWaterC", "1413", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 5:26:38 AM", "", "In Development",  0,2531)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("RadiantWaterF", "1411", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 5:26:50 AM", "", "In Development",  0,2529)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Remarks", "1390", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 10:47:08 AM", "", "In Development",  0,2571)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Service_Application", "1391", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/9/2025 1:36:29 PM", "", "In Development",  0,2492)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Signal", "1392", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/11/2025 5:26:54 AM", "", "In Development",  0,2574)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SizeIn", "1393", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/9/2025 1:37:24 PM", "", "In Development",  0,2494)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Valve_Data_Master_ID", "1428", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 10:37:46 AM", "", "In Development",  0,2564)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ValvePartNumber", "1394", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/10/2025 9:52:44 AM", "", "In Development",  0,2554)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ValveTag", "1395", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/9/2025 1:38:12 PM", "", "In Development",  0,2496)
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
          
        InitValidValue("ActuatorPartNumber_ValidValues", "1374", "-1", 2581)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ControlType_ValidValues", "1379", "-1", 2591)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("FailPos_ValidValues", "1384", "-1", 2587)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("LineSize_ValidValues", "1386", "-1", 2599)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ManufacturerType_ValidValues", "1388", "-1", 2600)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Pattern_ValidValues", "1389", "-1", 2499)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Signal_ValidValues", "1392", "-1", 2585)
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
          
        InitConnection("WaterValveCol", "73", "","", "Y", 0, "-1", "", "GLOBAL\H599123", "7/10/2025 12:07:28 PM", "", "In Development", "N",144)
        
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
      Public Function Formula_WaterValveCol_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:73; TYPE:PF
        Result = New rsCollection

For Each _sch As Object In Me.Parent.Valves
	If Not IsConnected(_sch.HBSSystem) Then Result.Add(_sch)
Next
        '   END FORMULA; CON ID:73; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_WaterValveCol_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
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
      '   BEGIN FORMULA; PROP ID:1414; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:1414; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_IsWaterHiddenPro_Enabled", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EnableHiddenData() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EnableHiddenData").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1426; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1426; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_EnableHiddenData", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1374; TYPE:PF
      Return "Please Select..."
      '   END FORMULA; PROP ID:1374; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_ActuatorPartNumber", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1375; TYPE:PF
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
      '   END FORMULA; PROP ID:1375; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_ActuatorType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1376; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Body_Rating from Valve_Data_Master Where Manufacturer_Type_Ref = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
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
      '   END FORMULA; PROP ID:1376; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_BodyRating", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BTU_Hour() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BTU_Hour").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1419; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:1419; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_BTU_Hour", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1377; TYPE:PF
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
      '   END FORMULA; PROP ID:1377; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_CloseOff", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1378; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Connection from Valve_Data_Master Where Manufacturer_Type_Ref = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
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
      '   END FORMULA; PROP ID:1378; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_Conn", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1379; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1379; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_ControlType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1380; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1380; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_Cv", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1381; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1381; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_DesignFlowGPM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1410; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1410; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_DesignFlowLS", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1431; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1431; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_DesignPressureDropPSI", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DisableHiddenData() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DisableHiddenData").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1427; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1427; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_DisableHiddenData", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1383; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1383; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_EquipmentLocation", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1384; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1384; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_FailPos", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1385; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Flow_Characteristic from Valve_Data_Master Where Manufacturer_Type_Ref = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
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
      '   END FORMULA; PROP ID:1385; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_FlowCharacterstics", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_GallonsPerMin() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("GallonsPerMin").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1416; TYPE:PF
      result = True
      '   END FORMULA; PROP ID:1416; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_GallonsPerMin", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_KiloWatts() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("KiloWatts").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1420; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:1420; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_KiloWatts", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_kPa_Design() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("kPa_Design").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1424; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:1424; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_kPa_Design", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_kPa_Valve() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("kPa_Valve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1425; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:1425; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_kPa_Valve", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1386; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1386; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_LineSize", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1387; TYPE:PF
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
      '   END FORMULA; PROP ID:1387; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_LinkagePartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LitresPerSec() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LitresPerSec").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1418; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:1418; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_LitresPerSec", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1388; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1388; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_ManufacturerType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1389; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1389; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_Pattern", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PSI_Design() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PSI_Design").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1423; TYPE:PF
      Result = True
      '   END FORMULA; PROP ID:1423; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_PSI_Design", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PSI_Valve() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PSI_Valve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1422; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:1422; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_PSI_Valve", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_RadiantHeatBTUHR() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("RadiantHeatBTUHR").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1412; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1412; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_RadiantHeatBTUHR", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1415; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1415; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_RadiantHeatKW", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1413; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1413; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_RadiantWaterC", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1411; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1411; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_RadiantWaterF", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1390; TYPE:PF
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
      '   END FORMULA; PROP ID:1390; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_Remarks", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1391; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1391; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_Service_Application", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1392; TYPE:PF
      Return "Please Select..."
      '   END FORMULA; PROP ID:1392; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_Signal", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1393; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1393; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_SizeIn", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1428; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Valve_Data_Master_ID from Valve_Data_Master Where Manufacturer_Type_Ref = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
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
      '   END FORMULA; PROP ID:1428; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_Valve_Data_Master_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1394; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Part_Number from Valve_Data_Master Where Manufacturer_Type_Ref = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
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
      '   END FORMULA; PROP ID:1394; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_ValvePartNumber", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1395; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1395; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_ValveTag", ex.Message)
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
      Public Function Formula_EnableHiddenData_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_BodyRating_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BTU_Hour_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_DesignPressureDropPSI_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DisableHiddenData_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_GallonsPerMin_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_KiloWatts_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_kPa_Design_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_kPa_Valve_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_LitresPerSec_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Pattern_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PSI_Design_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PSI_Valve_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RadiantHeatBTUHR_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_ValvePartNumber_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_EnableHiddenData_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("EnableHiddenData").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1426; TYPE:UC
              If Me.IsWaterHiddenPro_Enabled = False Then Return True
              '   END FORMULA; PROP ID:1426; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_EnableHiddenData_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
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
      Public Function Formula_BodyRating_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BTU_Hour_USERCHANGE() as Boolean
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
      Return True
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
              '   BEGIN FORMULA; PROP ID:1410; TYPE:UC
              Return Me.IsWaterHiddenPro_Enabled
              '   END FORMULA; PROP ID:1410; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_DesignFlowLS_USERCHANGE", ex.Message)
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
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DisableHiddenData_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("DisableHiddenData").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1427; TYPE:UC
              If Me.IsWaterHiddenPro_Enabled = True Then Return True
              '   END FORMULA; PROP ID:1427; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_DisableHiddenData_USERCHANGE", ex.Message)
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
      Public Function Formula_GallonsPerMin_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_KiloWatts_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_kPa_Design_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_kPa_Valve_USERCHANGE() as Boolean
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
      Public Function Formula_LitresPerSec_USERCHANGE() as Boolean
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
      Public Function Formula_Pattern_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PSI_Design_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PSI_Valve_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RadiantHeatBTUHR_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("RadiantHeatBTUHR").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1412; TYPE:UC
              Return Me.IsWaterHiddenPro_Enabled
              '   END FORMULA; PROP ID:1412; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_RadiantHeatBTUHR_USERCHANGE", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:1415; TYPE:UC
              Return Me.IsWaterHiddenPro_Enabled
              '   END FORMULA; PROP ID:1415; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_RadiantHeatKW_USERCHANGE", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:1413; TYPE:UC
              Return Me.IsWaterHiddenPro_Enabled
              '   END FORMULA; PROP ID:1413; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_RadiantWaterC_USERCHANGE", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:1411; TYPE:UC
              Return Me.IsWaterHiddenPro_Enabled
              '   END FORMULA; PROP ID:1411; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_RadiantWaterF_USERCHANGE", ex.Message)
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
      Public Function Formula_ValvePartNumber_USERCHANGE() as Boolean
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
      '   BEGIN FORMULA; PROP ID:1374; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select distinct  Actuator from Actuator_Data_Master Where Valve_Data_Master_Ref = " & "'" & Me.Valve_Data_Master_ID & "'"
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
      '   END FORMULA; PROP ID:1374; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_ActuatorPartNumber_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1379; TYPE:VV
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
      '   END FORMULA; PROP ID:1379; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_ControlType_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1384; TYPE:VV
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
      '   END FORMULA; PROP ID:1384; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_FailPos_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1386; TYPE:VV
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
      '   END FORMULA; PROP ID:1386; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_LineSize_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1388; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Manufacturer_Type from [dbo].[Manufacturer_Type_Master] order by [Sort_Order] ASC"
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
      '   END FORMULA; PROP ID:1388; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_ManufacturerType_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1389; TYPE:VV
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
      '   END FORMULA; PROP ID:1389; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_Pattern_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1392; TYPE:VV
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
      '   END FORMULA; PROP ID:1392; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_Signal_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_EnableHiddenData_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EnableHiddenData").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1426; TYPE:WC
      Me.LitresPerSec = True
Me.BTU_Hour = True
Me.KiloWatts = True
Me.IsWaterHiddenPro_Enabled = True
      '   END FORMULA; PROP ID:1426; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_EnableHiddenData_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_DisableHiddenData_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DisableHiddenData").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1427; TYPE:WC
      Me.LitresPerSec = False
Me.BTU_Hour = False
Me.KiloWatts = False
Me.IsWaterHiddenPro_Enabled = False
      '   END FORMULA; PROP ID:1427; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Valve.Formula_DisableHiddenData_WHENCHANGED", ex.Message)
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

  