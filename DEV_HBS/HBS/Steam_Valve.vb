Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: Steam_Valve
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

    Public Class [Steam_Valve]
    
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

    Private this as Steam_Valve = me

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
    
      Case "DesignFlow_KgHr_"
      Formula_DesignFlow_KgHr_WHENCHANGED(Value, OldValue)
    
      Case "DesignFlowLbs_Hr_"
      Formula_DesignFlowLbs_Hr_WHENCHANGED(Value, OldValue)
    
      Case "DesignPressureDropkPa_"
      Formula_DesignPressureDropkPa_WHENCHANGED(Value, OldValue)
    
      Case "DesignPressureDropPSI_"
      Formula_DesignPressureDropPSI_WHENCHANGED(Value, OldValue)
    
      Case "SteamSupplyPressKPA_"
      Formula_SteamSupplyPressKPA_WHENCHANGED(Value, OldValue)
    
      Case "SteamSupplyPressPSI_"
      Formula_SteamSupplyPressPSI_WHENCHANGED(Value, OldValue)
    
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
    
      Case "DesignFlow_KgHr_"
      'Formula_DesignFlow_KgHr_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "DesignFlowLbs_Hr_"
      'Formula_DesignFlowLbs_Hr_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "DesignPressureDropkPa_"
      'Formula_DesignPressureDropkPa_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "DesignPressureDropPSI_"
      'Formula_DesignPressureDropPSI_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "SteamSupplyPressKPA_"
      'Formula_SteamSupplyPressKPA_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "SteamSupplyPressPSI_"
      'Formula_SteamSupplyPressPSI_WHENCHANGED(Value, OldValue)
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
    
          Public Property [CritPressDrop]() As Double
      Get
      Return Properties("CritPressDrop").Value
      End Get
      Set(ByVal Value As Double)
      Properties("CritPressDrop").CalculatedValue = Value
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
    
          Public Property [DesignFlow_KgHr]() As String
      Get
      Return Properties("DesignFlow_KgHr").Value
      End Get
      Set(ByVal Value As String)
      Properties("DesignFlow_KgHr").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SqrtV]() As String
      Get
      Return Properties("SqrtV").Value
      End Get
      Set(ByVal Value As String)
      Properties("SqrtV").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SteamVlvCv]() As Double
      Get
      Return Properties("SteamVlvCv").Value
      End Get
      Set(ByVal Value As Double)
      Properties("SteamVlvCv").CalculatedValue = Value
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
    
          Public Property [DesignFlowLbs_Hr]() As String
      Get
      Return Properties("DesignFlowLbs_Hr").Value
      End Get
      Set(ByVal Value As String)
      Properties("DesignFlowLbs_Hr").CalculatedValue = Value
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
    
          Public Property [SteamSupplyPressKPA]() As String
      Get
      Return Properties("SteamSupplyPressKPA").Value
      End Get
      Set(ByVal Value As String)
      Properties("SteamSupplyPressKPA").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SteamSupplyPressPSI]() As String
      Get
      Return Properties("SteamSupplyPressPSI").Value
      End Get
      Set(ByVal Value As String)
      Properties("SteamSupplyPressPSI").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SteamSupplyPressure]() As String
      Get
      Return Properties("SteamSupplyPressure").Value
      End Get
      Set(ByVal Value As String)
      Properties("SteamSupplyPressure").CalculatedValue = Value
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
    InitPart("Steam_Valve", <a><![CDATA[Steam_Valve]]></a>.Value, 125, "HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H599123", "07/21/2025 11:23:00")
    AddProperty("1726", "IsWaterHiddenPro_Enabled", <a><![CDATA[IsWaterHiddenPro_Enabled]]></a>.Value, "", "Boolean","","Analysis","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1871", "CritPressDrop", <a><![CDATA[CritPressDrop]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/21/2025 7:09:07 AM")
    AddProperty("1716", "Cv_DB", <a><![CDATA[Cv_DB]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1874", "DesignFlow_KgHr", <a><![CDATA[DesignFlow_KgHr]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/21/2025 11:13:08 AM")
    AddProperty("1873", "SqrtV", <a><![CDATA[SqrtV]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/21/2025 10:45:43 AM")
    AddProperty("1872", "SteamVlvCv", <a><![CDATA[SteamVlvCv]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/21/2025 10:50:21 AM")
    AddProperty("1614", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1708", "ActuatorPartNumber", <a><![CDATA[Actuator Part Number]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1709", "ActuatorType", <a><![CDATA[Type]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1710", "Auto_Cv", <a><![CDATA[Auto_Cv]]></a>.Value, "", "Boolean","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1711", "BodyRating", <a><![CDATA[Body Rating]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 6:58:40 AM")
    AddProperty("1712", "CloseOff", <a><![CDATA[Close Off]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1713", "Conn", <a><![CDATA[Conn.]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 6:58:58 AM")
    AddProperty("1714", "ControlType", <a><![CDATA[Control Type]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1715", "Cv", <a><![CDATA[Cv]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/21/2025 10:16:25 AM")
    AddProperty("1750", "DesignFlowLbs_Hr", <a><![CDATA[Design Flow Lbs_Hr]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/21/2025 10:52:44 AM")
    AddProperty("1719", "DesignFlowParameters", <a><![CDATA[Design Flow Parameters]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:35:30 AM")
    AddProperty("1746", "DesignPressureDrop", <a><![CDATA[Design Press Drop]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:37:14 AM")
    AddProperty("1752", "DesignPressureDropkPa", <a><![CDATA[Design Pressure Drop kPa]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/21/2025 11:23:00 AM")
    AddProperty("1753", "DesignPressureDropPSI", <a><![CDATA[Design Pressure Drop PSI]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/21/2025 6:35:41 AM")
    AddProperty("1723", "EquipmentLocation", <a><![CDATA[Equipment Location]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1724", "FailPos", <a><![CDATA[Fail Pos]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1725", "FlowCharacterstics", <a><![CDATA[Flow Characterstics]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 6:59:21 AM")
    AddProperty("1727", "LineSize", <a><![CDATA[Line Size]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1728", "LinkagePartNumber", <a><![CDATA[Linkage Part Number]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1729", "ManufacturerType", <a><![CDATA[Manufacturer Type]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 6:55:57 AM")
    AddProperty("1730", "OtherParameters", <a><![CDATA[Other Parameters]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1731", "Pattern", <a><![CDATA[Pattern]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 9:47:58 AM")
    AddProperty("1736", "Remarks", <a><![CDATA[Remarks]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1737", "Service_Application", <a><![CDATA[Service_Application]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1738", "Signal", <a><![CDATA[Signal]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    AddProperty("1739", "SizeIn", <a><![CDATA[Size (In)]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/21/2025 10:18:54 AM")
    AddProperty("1749", "SteamSupplyPressKPA", <a><![CDATA[Steam Supply Press KPA]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/21/2025 10:42:37 AM")
    AddProperty("1748", "SteamSupplyPressPSI", <a><![CDATA[Steam Supply Press PSI]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/21/2025 10:42:22 AM")
    AddProperty("1747", "SteamSupplyPressure", <a><![CDATA[Steam Supply Pressure]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:39:10 AM")
    AddProperty("1740", "Valve_Data_Master_ID", <a><![CDATA[Valve_Data_Master_ID]]></a>.Value, "", "Long","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 9:52:12 AM")
    AddProperty("1741", "ValveDropAtDesignFlowkPa", <a><![CDATA[Valve Drop At Design Flow kPa]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/21/2025 10:59:40 AM")
    AddProperty("1742", "ValveDropAtDesignFlowPSI", <a><![CDATA[Valve Drop At Design Flow PSI]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/21/2025 10:47:20 AM")
    AddProperty("1743", "ValvePartNumber", <a><![CDATA[Valve Part Number]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 6:59:53 AM")
    AddProperty("1744", "ValvePressureDrop", <a><![CDATA[Valve Pressure Drop]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:39:27 AM")
    AddProperty("1745", "ValveTag", <a><![CDATA[Valve Tag]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "7/16/2025 5:25:34 AM")
    
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
    
      AddValidValue("SteamSupplyPressure")
    
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
          InitProperty("IsWaterHiddenPro_Enabled", "1592", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:34 AM", "", "In Development",  0,2997)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CritPressDrop", "1736", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/21/2025 7:09:07 AM", "", "In Development",  0,3518)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cv_DB", "1582", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:34 AM", "", "In Development",  0,2980)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignFlow_KgHr", "1739", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/21/2025 11:12:57 AM", "", "In Development",  0,3542)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SqrtV", "1738", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/21/2025 10:45:43 AM", "", "In Development",  0,3535)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SteamVlvCv", "1737", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/21/2025 10:50:21 AM", "", "In Development",  0,3537)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorPartNumber", "1574", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:34 AM", "", "In Development",  0,2969)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ActuatorType", "1575", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:34 AM", "", "In Development",  0,2971)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Auto_Cv", "1576", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:34 AM", "", "In Development",  0,2972)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BodyRating", "1577", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 6:58:40 AM", "", "In Development",  0,3045)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CloseOff", "1578", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:34 AM", "", "In Development",  0,2974)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conn", "1579", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 6:58:58 AM", "", "In Development",  0,3046)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControlType", "1580", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:34 AM", "", "In Development",  0,2976)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Cv", "1581", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/21/2025 10:16:25 AM", "", "In Development",  0,2978)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignFlowLbs_Hr", "1616", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/21/2025 10:52:34 AM", "", "In Development",  0,3038)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignFlowParameters", "1585", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:35:30 AM", "", "In Development",  0,2985)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignPressureDrop", "1612", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:37:14 AM", "", "In Development",  0,3031)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignPressureDropkPa", "1618", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/21/2025 11:22:52 AM", "", "In Development",  0,3547)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DesignPressureDropPSI", "1619", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/21/2025 6:35:41 AM", "", "In Development",  0,3512)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EquipmentLocation", "1589", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:34 AM", "", "In Development",  0,2993)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FailPos", "1590", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:34 AM", "", "In Development",  0,2994)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FlowCharacterstics", "1591", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 6:59:21 AM", "", "In Development",  0,3047)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LineSize", "1593", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:34 AM", "", "In Development",  0,2998)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LinkagePartNumber", "1594", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:34 AM", "", "In Development",  0,3000)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ManufacturerType", "1595", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 6:55:57 AM", "", "In Development",  0,3001)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("OtherParameters", "1596", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:34 AM", "", "In Development",  0,3003)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pattern", "1597", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/16/2025 9:47:58 AM", "", "In Development",  0,3061)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Remarks", "1602", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:35 AM", "", "In Development",  0,3015)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Service_Application", "1603", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:35 AM", "", "In Development",  0,3016)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Signal", "1604", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:35 AM", "", "In Development",  0,3017)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SizeIn", "1605", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/21/2025 10:18:54 AM", "", "In Development",  0,3019)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SteamSupplyPressKPA", "1615", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/21/2025 10:42:37 AM", "", "In Development",  0,3037)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SteamSupplyPressPSI", "1614", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/21/2025 10:42:22 AM", "", "In Development",  0,3036)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SteamSupplyPressure", "1613", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:39:10 AM", "", "In Development",  0,3033)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Valve_Data_Master_ID", "1606", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 9:52:12 AM", "", "In Development",  0,3068)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ValveDropAtDesignFlowkPa", "1607", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/21/2025 10:59:40 AM", "", "In Development",  0,3540)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ValveDropAtDesignFlowPSI", "1608", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/21/2025 10:47:20 AM", "", "In Development",  0,3536)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ValvePartNumber", "1609", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 6:59:53 AM", "", "In Development",  0,3048)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ValvePressureDrop", "1610", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:39:27 AM", "", "In Development",  0,3035)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ValveTag", "1611", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "7/16/2025 5:25:35 AM", "", "In Development",  0,3029)
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
          
        InitValidValue("ActuatorPartNumber_ValidValues", "1574", "-1", 2970)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ControlType_ValidValues", "1580", "-1", 2977)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Cv_ValidValues", "1581", "-1", 3528)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("DesignFlowParameters_ValidValues", "1585", "-1", 3030)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("DesignPressureDrop_ValidValues", "1612", "-1", 3032)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("FailPos_ValidValues", "1590", "-1", 2995)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("LineSize_ValidValues", "1593", "-1", 2999)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ManufacturerType_ValidValues", "1595", "-1", 3044)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("OtherParameters_ValidValues", "1596", "-1", 3004)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Pattern_ValidValues", "1597", "-1", 3064)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Signal_ValidValues", "1604", "-1", 3018)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("SizeIn_ValidValues", "1605", "-1", 3529)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("SteamSupplyPressure_ValidValues", "1613", "-1", 3034)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ValvePressureDrop_ValidValues", "1610", "-1", 3028)
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
      '   BEGIN FORMULA; PROP ID:1592; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:1592; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_IsWaterHiddenPro_Enabled", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CritPressDrop() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CritPressDrop").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1736; TYPE:PF
      If Me.SteamSupplyPressPSI <> "" Then Return (0.5 * (Double.Parse(Me.SteamSupplyPressPSI) + 14.7))
      '   END FORMULA; PROP ID:1736; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_CritPressDrop", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1582; TYPE:PF
      If Me.Auto_Cv = False Then
	Return Me.Cv.Split("-")(0)
End if
      '   END FORMULA; PROP ID:1582; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_Cv_DB", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DesignFlow_KgHr() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignFlow_KgHr").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1739; TYPE:PF
      If Me.DesignFlowLbs_Hr <> "" Then Return Math.Round ((Me.DesignFlowLbs_Hr * 0.4535924),1)
      '   END FORMULA; PROP ID:1739; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignFlow_KgHr", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SqrtV() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SqrtV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1738; TYPE:PF
      If Me.SteamSupplyPressPSI <> "" Then Result = SqrtV_Calc(Me.SteamSupplyPressPSI)
      '   END FORMULA; PROP ID:1738; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_SqrtV", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SteamVlvCv() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SteamVlvCv").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1737; TYPE:PF
      Dim PressDropCalc As Double 

If Me.DesignPressureDropPSI <> "" AndAlso Me.DesignFlowLbs_Hr <> "" Then
	If Me.CritPressDrop < (Me.DesignPressureDropPSI + 0.5) Then
        	PressDropCalc = Me.CritPressDrop
    	Else
        	PressDropCalc = (Me.DesignPressureDropPSI + 0.5)
    	End If

	Result = ((Me.DesignFlowLbs_Hr * (Double.Parse(Me.SqrtV)))/(63.5 * Math.Sqrt(PressDropCalc)))
End If
      '   END FORMULA; PROP ID:1737; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_SteamVlvCv", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1574; TYPE:PF
      Return "Please Select..."
      '   END FORMULA; PROP ID:1574; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ActuatorPartNumber", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1575; TYPE:PF
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
      '   END FORMULA; PROP ID:1575; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ActuatorType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1576; TYPE:PF
      result = True
      '   END FORMULA; PROP ID:1576; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_Auto_Cv", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1577; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

If Me.Auto_CV = False Then
	SQLToExecute = "select Body_Rating from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv_DB & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
Else
	SQLToExecute = "select Body_Rating from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
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
      '   END FORMULA; PROP ID:1577; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_BodyRating", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1578; TYPE:PF
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
      '   END FORMULA; PROP ID:1578; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_CloseOff", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1579; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue, Max_ValveData_Master_ID As String

If Me.Auto_CV = False Then
	SQLToExecute = "Select Connection from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "' And Cv = " & "'" & Me.Cv_DB & "'"
Else
	SQLToExecute = "Select Connection from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "' And Cv = " & "'" & Me.Cv & "'"
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
      '   END FORMULA; PROP ID:1579; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_Conn", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1580; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1580; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ControlType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1581; TYPE:PF
      Return FirstValidValue(Me,"Cv")
      '   END FORMULA; PROP ID:1581; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_Cv", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DesignFlowLbs_Hr() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignFlowLbs_Hr").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1616; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1616; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignFlowLbs_Hr", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1585; TYPE:PF
      Result = 1
      '   END FORMULA; PROP ID:1585; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignFlowParameters", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1612; TYPE:PF
      Result = 1
      '   END FORMULA; PROP ID:1612; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignPressureDrop", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1618; TYPE:PF
      If Me.SteamSupplyPressKPA <> "" Then 
	If Double.Parse(Me.SteamSupplyPressKPA) < 110 Then
		Return Math.Round ((Me.SteamSupplyPressKPA * 0.7),1) 
	Else
		Return Math.Round ((Me.SteamSupplyPressKPA * 0.5),1) 
	End If
End If
      '   END FORMULA; PROP ID:1618; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignPressureDropkPa", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1619; TYPE:PF
      If Me.SteamSupplyPressPSI = "" Then
	Return ""
Else
	If Me.SteamSupplyPressPSI <> "" AndAlso	Integer.Parse(Me.SteamSupplyPressPSI) < 16 Then
		Return (Me.SteamSupplyPressPSI * 0.7)
	Else
		Return (Me.SteamSupplyPressPSI * 0.5)
	End If
End If
      '   END FORMULA; PROP ID:1619; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignPressureDropPSI", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1589; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1589; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_EquipmentLocation", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1590; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1590; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_FailPos", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1591; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

If Me.Auto_CV = False Then
	 SQLToExecute = "select Flow_Characteristic from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv_DB & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"

Else
	SQLToExecute = "select Flow_Characteristic from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
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
      '   END FORMULA; PROP ID:1591; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_FlowCharacterstics", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1593; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1593; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_LineSize", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1594; TYPE:PF
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
      '   END FORMULA; PROP ID:1594; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_LinkagePartNumber", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1595; TYPE:PF
      Result = "Please Select..."
      '   END FORMULA; PROP ID:1595; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ManufacturerType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1596; TYPE:PF
      Result = 3
      '   END FORMULA; PROP ID:1596; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_OtherParameters", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1597; TYPE:PF
      Return FirstValidValue(Me,"Pattern")
      '   END FORMULA; PROP ID:1597; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_Pattern", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1602; TYPE:PF
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
      '   END FORMULA; PROP ID:1602; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_Remarks", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1603; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1603; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_Service_Application", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1604; TYPE:PF
      Return "Please Select..."
      '   END FORMULA; PROP ID:1604; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_Signal", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1605; TYPE:PF
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
      '   END FORMULA; PROP ID:1605; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_SizeIn", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SteamSupplyPressKPA() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SteamSupplyPressKPA").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1615; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1615; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_SteamSupplyPressKPA", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SteamSupplyPressPSI() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SteamSupplyPressPSI").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1614; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1614; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_SteamSupplyPressPSI", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SteamSupplyPressure() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SteamSupplyPressure").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1613; TYPE:PF
      Return 1
      '   END FORMULA; PROP ID:1613; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_SteamSupplyPressure", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1606; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

If Me.Auto_Cv = False Then
	SQLToExecute = "select Valve_Data_Master_ID from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv_DB & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
Else
	SQLToExecute = "select Valve_Data_Master_ID from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"	
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
      '   END FORMULA; PROP ID:1606; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_Valve_Data_Master_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1607; TYPE:PF
      If Me.ValveDropAtDesignFlowPSI <> "" Then Return Math.Round ((Me.ValveDropAtDesignFlowPSI * 6.894757),1)
      '   END FORMULA; PROP ID:1607; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ValveDropAtDesignFlowkPa", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1608; TYPE:PF
      If Me.DesignFlowLbs_Hr <> "" AndAlso Me.SqrtV <> "" AndAlso Me.Cv <>"" Then
	Result = (((Me.DesignFlowLbs_Hr * (Double.Parse(Me.SqrtV)))/(63.5 * Me.Cv)))^2

	Return Round(Double.Parse(Result),1)
End If
      '   END FORMULA; PROP ID:1608; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ValveDropAtDesignFlowPSI", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1609; TYPE:PF
      Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

If Me.Auto_CV = False Then
	SQLToExecute = "select Part_Number from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv_DB & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"

Else
	SQLToExecute = "select Part_Number from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Cv = " & "'" & Me.Cv & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
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
      '   END FORMULA; PROP ID:1609; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ValvePartNumber", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1610; TYPE:PF
      Result = 1
      '   END FORMULA; PROP ID:1610; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ValvePressureDrop", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1611; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1611; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ValveTag", ex.Message)
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
      Public Function Formula_CritPressDrop_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_DesignFlow_KgHr_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SqrtV_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SteamVlvCv_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_DesignFlowLbs_Hr_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_SteamSupplyPressKPA_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SteamSupplyPressPSI_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SteamSupplyPressure_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_CritPressDrop_USERCHANGE() as Boolean
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
      Public Function Formula_DesignFlow_KgHr_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("DesignFlow_KgHr").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1739; TYPE:UC
              If Me.DesignFlowParameters = 2 Then
	Return True
End If
              '   END FORMULA; PROP ID:1739; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignFlow_KgHr_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SqrtV_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SteamVlvCv_USERCHANGE() as Boolean
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
      Public Function Formula_DesignFlowLbs_Hr_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("DesignFlowLbs_Hr").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1616; TYPE:UC
              If Me.DesignFlowParameters = 1 Then
	Return True
End If
              '   END FORMULA; PROP ID:1616; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignFlowLbs_Hr_USERCHANGE", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:1618; TYPE:UC
              If Me.DesignPressureDrop = 2 Then
	Return True
End If
              '   END FORMULA; PROP ID:1618; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignPressureDropkPa_USERCHANGE", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:1619; TYPE:UC
              If Me.DesignPressureDrop = 1 Then
	Return True
End If
              '   END FORMULA; PROP ID:1619; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignPressureDropPSI_USERCHANGE", ex.Message)
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
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Pattern").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1597; TYPE:UC
              Return False
              '   END FORMULA; PROP ID:1597; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_Pattern_USERCHANGE", ex.Message)
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
      Public Function Formula_SteamSupplyPressKPA_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("SteamSupplyPressKPA").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1615; TYPE:UC
              If Me.SteamSupplyPressure = 2 Then
	Return True
End If
              '   END FORMULA; PROP ID:1615; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_SteamSupplyPressKPA_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SteamSupplyPressPSI_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("SteamSupplyPressPSI").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1614; TYPE:UC
              If Me.SteamSupplyPressure = 1 Then
	Return True
End If
              '   END FORMULA; PROP ID:1614; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_SteamSupplyPressPSI_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SteamSupplyPressure_USERCHANGE() as Boolean
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
              '   BEGIN FORMULA; PROP ID:1607; TYPE:UC
              If Me.ValvePressureDrop = 2 Then
	Return True
End If
              '   END FORMULA; PROP ID:1607; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ValveDropAtDesignFlowkPa_USERCHANGE", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:1608; TYPE:UC
              If Me.ValvePressureDrop = 1 Then
	Return True
End If
              '   END FORMULA; PROP ID:1608; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ValveDropAtDesignFlowPSI_USERCHANGE", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1574; TYPE:VV
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
      '   END FORMULA; PROP ID:1574; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ActuatorPartNumber_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1580; TYPE:VV
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
      '   END FORMULA; PROP ID:1580; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ControlType_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1581; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim SQlWhereClause As String = ""
Dim ds As DataSet
Dim displayValue As String
Dim keyValue As String

If Me.Auto_Cv Then
	SQlWhereClause = "select min(Size) from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "' And Cv >= (SELECT CONVERT(float, " & Me.SteamVlvCv & "))"

	SQLToExecute = "Select Cv from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Size = " & "(" & SQlWhereClause & ") AND Valve_Type_Ref = "& "'" & Me.Pattern & "' order by Valve_Data_Master_ID DESC"
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
	SQLToExecute = "Select (Cv + ' - ' + '('+ Size + 'in)') as size  from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "' Order By Valve_Data_Master_ID DESC"
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
      '   END FORMULA; PROP ID:1581; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_Cv_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1585; TYPE:VV
      Result = MakeValidKeyValues(Array("1", "2", "3"), Array("Pounds Per Hour (lbs/Hr)", "Kilogram Per Hour (Kg/Hr)", " --- "))
      '   END FORMULA; PROP ID:1585; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignFlowParameters_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1612; TYPE:VV
      Result = MakeValidKeyValues(Array("1", "2", "3"), Array("Pound Per Inch (PSI)", "Kilo Pascals (kPa)", " --- "))
      '   END FORMULA; PROP ID:1612; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignPressureDrop_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1590; TYPE:VV
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
      '   END FORMULA; PROP ID:1590; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_FailPos_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1593; TYPE:VV
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
      '   END FORMULA; PROP ID:1593; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_LineSize_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1595; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim ds As DataSet
Dim displayValue As String

SQLToExecute = "select Manufacturer_Type from [dbo].[Manufacturer_Type_Master] where Media = 'STEAM' order by [Sort_Order] ASC"
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
      '   END FORMULA; PROP ID:1595; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ManufacturerType_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1596; TYPE:VV
      Result = MakeValidKeyValues(Array("1", "2", "3"), Array("BTU Hour (BTU - Hr.) * Radiant Heats", "KiloWatts (KW) * Radiant Heats", " --- "))
      '   END FORMULA; PROP ID:1596; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_OtherParameters_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1597; TYPE:VV
      Result = MakeValidValues(Array("2-Way"))
      '   END FORMULA; PROP ID:1597; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_Pattern_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1604; TYPE:VV
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
      '   END FORMULA; PROP ID:1604; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_Signal_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1605; TYPE:VV
      Dim validValuesCollection As New RuleStream.Kernel.ValidValues 'Hashtable
Dim SQLToExecute As String = ""
Dim SQlWhereClause As String = ""
Dim ds As DataSet
Dim displayValue, keyValue As String

If Me.Auto_Cv Then
	SQlWhereClause = "select min(Size) from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "' And Cv >= (SELECT CONVERT(float, " & Me.SteamVlvCv & "))"

	SQLToExecute = "Select size from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Size = " & "(" & SQlWhereClause & ") AND Valve_Type_Ref = "& "'" & Me.Pattern & "'"
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
Else
	SQLToExecute = "Select size  from Valve_Data_Master where Media = 'STEAM' AND Manufacturer_Type = " & "'" & Me.ManufacturerType & "' AND Valve_Type_Ref = "& "'" & Me.Pattern & "' Order By Valve_Data_Master_ID DESC"
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
      '   END FORMULA; PROP ID:1605; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_SizeIn_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SteamSupplyPressure_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SteamSupplyPressure").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1613; TYPE:VV
      Result = MakeValidKeyValues(Array("1", "2", "3"), Array("Pound Per Inch (PSI)", "Kilo Pascals (kPa)", " --- "))
      '   END FORMULA; PROP ID:1613; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_SteamSupplyPressure_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1610; TYPE:VV
      Result = MakeValidKeyValues(Array("1", "2", "3"), Array("Pound Per Inch (PSI)", "Kilo Pascals (kPa)", " --- "))
      '   END FORMULA; PROP ID:1610; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ValvePressureDrop_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_DesignFlow_KgHr_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignFlow_KgHr").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1739; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Design Flow Kg_Hr",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1739; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignFlow_KgHr_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_DesignFlowLbs_Hr_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DesignFlowLbs_Hr").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1616; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Design Flow Lbs_Hr",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1616; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignFlowLbs_Hr_WHENCHANGED", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1618; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Design Pressure Drop KPA",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1618; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignPressureDropkPa_WHENCHANGED", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1619; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Design Pressure Drop PSI",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1619; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_DesignPressureDropPSI_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_SteamSupplyPressKPA_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SteamSupplyPressKPA").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1615; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Steam Supply Press. KPA",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1615; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_SteamSupplyPressKPA_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_SteamSupplyPressPSI_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SteamSupplyPressPSI").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1614; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Steam Supply Press. PSI",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1614; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_SteamSupplyPressPSI_WHENCHANGED", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1607; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Valve Drop At Design Flow kPa",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1607; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ValveDropAtDesignFlowkPa_WHENCHANGED", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1608; TYPE:WC
      If Value <> "" AndAlso Not IsInputNumeric(Value) Then
	 MessageBox.Show("Please enter only Numeric Value?","Valve Drop At Design Flow PSI",MessageBoxButtons.Ok,MessageBoxIcon.Stop)
	 Value = ""
End If
      '   END FORMULA; PROP ID:1608; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Steam_Valve.Formula_ValveDropAtDesignFlowPSI_WHENCHANGED", ex.Message)
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

  