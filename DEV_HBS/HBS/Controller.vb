Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: Controller
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

    Public Class [Controller]
    
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

    Private this as Controller = me

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
    
          Public Property [AI_UI_Capacity]() As Long
      Get
      Return Properties("AI_UI_Capacity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("AI_UI_Capacity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [AO_Capacity]() As Long
      Get
      Return Properties("AO_Capacity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("AO_Capacity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DI_Capacity]() As Long
      Get
      Return Properties("DI_Capacity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("DI_Capacity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DO_Capacity]() As Long
      Get
      Return Properties("DO_Capacity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("DO_Capacity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [IO_Capacity]() As Long
      Get
      Return Properties("IO_Capacity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("IO_Capacity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [AssignedPowerSupply]() As String
      Get
      Return Properties("AssignedPowerSupply").Value
      End Get
      Set(ByVal Value As String)
      Properties("AssignedPowerSupply").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ConfigurablePortQuantity]() As Long
      Get
      Return Properties("ConfigurablePortQuantity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("ConfigurablePortQuantity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ConfigurablePortsOptions]() As String
      Get
      Return Properties("ConfigurablePortsOptions").Value
      End Get
      Set(ByVal Value As String)
      Properties("ConfigurablePortsOptions").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ConfigurablePortType]() As String
      Get
      Return Properties("ConfigurablePortType").Value
      End Get
      Set(ByVal Value As String)
      Properties("ConfigurablePortType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ConfigurablePortTypeLimits]() As String
      Get
      Return Properties("ConfigurablePortTypeLimits").Value
      End Get
      Set(ByVal Value As String)
      Properties("ConfigurablePortTypeLimits").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ConfigurablePortTypeNames]() As String
      Get
      Return Properties("ConfigurablePortTypeNames").Value
      End Get
      Set(ByVal Value As String)
      Properties("ConfigurablePortTypeNames").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerLocation]() As String
      Get
      Return Properties("ControllerLocation").Value
      End Get
      Set(ByVal Value As String)
      Properties("ControllerLocation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerName]() As String
      Get
      Return Properties("ControllerName").Value
      End Get
      Set(ByVal Value As String)
      Properties("ControllerName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerPartNumber]() As String
      Get
      Return Properties("ControllerPartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("ControllerPartNumber").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CPU_IOType]() As String
      Get
      Return Properties("CPU_IOType").Value
      End Get
      Set(ByVal Value As String)
      Properties("CPU_IOType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CurrentRating]() As Double
      Get
      Return Properties("CurrentRating").Value
      End Get
      Set(ByVal Value As Double)
      Properties("CurrentRating").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DefaultQuantity]() As Long
      Get
      Return Properties("DefaultQuantity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("DefaultQuantity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DynamicSQLQuery]() As String
      Get
      Return Properties("DynamicSQLQuery").Value
      End Get
      Set(ByVal Value As String)
      Properties("DynamicSQLQuery").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [FacilityDisplayName]() As String
      Get
      Return Properties("FacilityDisplayName").Value
      End Get
      Set(ByVal Value As String)
      Properties("FacilityDisplayName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Family]() As String
      Get
      Return Properties("Family").Value
      End Get
      Set(ByVal Value As String)
      Properties("Family").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Mnemonic]() As String
      Get
      Return Properties("Mnemonic").Value
      End Get
      Set(ByVal Value As String)
      Properties("Mnemonic").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Mount]() As String
      Get
      Return Properties("Mount").Value
      End Get
      Set(ByVal Value As String)
      Properties("Mount").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PartDescription]() As String
      Get
      Return Properties("PartDescription").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartDescription").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Pole]() As String
      Get
      Return Properties("Pole").Value
      End Get
      Set(ByVal Value As String)
      Properties("Pole").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerConsumption]() As Double
      Get
      Return Properties("PowerConsumption").Value
      End Get
      Set(ByVal Value As Double)
      Properties("PowerConsumption").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerSupply]() As String
      Get
      Return Properties("PowerSupply").Value
      End Get
      Set(ByVal Value As String)
      Properties("PowerSupply").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [UplinkPortQuantity]() As Long
      Get
      Return Properties("UplinkPortQuantity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("UplinkPortQuantity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [UplinkPortType]() As String
      Get
      Return Properties("UplinkPortType").Value
      End Get
      Set(ByVal Value As String)
      Properties("UplinkPortType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [UplinkPortTypeLimits]() As String
      Get
      Return Properties("UplinkPortTypeLimits").Value
      End Get
      Set(ByVal Value As String)
      Properties("UplinkPortTypeLimits").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [UplinkPortTypeNames]() As String
      Get
      Return Properties("UplinkPortTypeNames").Value
      End Get
      Set(ByVal Value As String)
      Properties("UplinkPortTypeNames").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [VA_mA]() As String
      Get
      Return Properties("VA_mA").Value
      End Get
      Set(ByVal Value As String)
      Properties("VA_mA").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ParentGroupName]() As String
      Get
      Return Properties("ParentGroupName").Value
      End Get
      Set(ByVal Value As String)
      Properties("ParentGroupName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ParentPlantName]() As String
      Get
      Return Properties("ParentPlantName").Value
      End Get
      Set(ByVal Value As String)
      Properties("ParentPlantName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ParentPlantType]() As String
      Get
      Return Properties("ParentPlantType").Value
      End Get
      Set(ByVal Value As String)
      Properties("ParentPlantType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ParentSystemName]() As String
      Get
      Return Properties("ParentSystemName").Value
      End Get
      Set(ByVal Value As String)
      Properties("ParentSystemName").CalculatedValue = Value
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
    
      Public ReadOnly Property [Physical]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Physical")
      End Get
      End Property
    
      Public ReadOnly Property [Devices]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Devices")
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
    InitPart("Controller", <a><![CDATA[Controller]]></a>.Value, 6, "HBS",  "N", "N", True, False, "In Development", "", "", "", "", "",  "GLOBAL\H601421", "07/10/2025 04:35:28")
    AddProperty("329", "AI_UI_Capacity", <a><![CDATA[AI_UI Capacity]]></a>.Value, "The Controller AI_UI Capacity", "Long","","Database Lookup","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "3/31/2025 3:20:07 AM")
    AddProperty("330", "AO_Capacity", <a><![CDATA[AO Capacity]]></a>.Value, "The Controller AO Capacity", "Long","","Database Lookup","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "3/31/2025 3:20:14 AM")
    AddProperty("331", "DI_Capacity", <a><![CDATA[DI Capacity]]></a>.Value, "The Controller DI Capacity", "Long","","Database Lookup","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "3/31/2025 3:20:27 AM")
    AddProperty("332", "DO_Capacity", <a><![CDATA[DO Capacity]]></a>.Value, "The Controller DO Capacity", "Long","","Database Lookup","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "3/31/2025 3:20:35 AM")
    AddProperty("333", "IO_Capacity", <a><![CDATA[IO Capacity]]></a>.Value, "The Controller IO Capacity", "Long","","Database Lookup","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "3/31/2025 3:20:47 AM")
    AddProperty("378", "AssignedPowerSupply", <a><![CDATA[Assigned Power Supply]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/26/2025 8:13:41 PM")
    AddProperty("56", "ConfigurablePortQuantity", <a><![CDATA[Configurable Port Quantity]]></a>.Value, "The number of configurable ports on this controller.", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("59", "ConfigurablePortsOptions", <a><![CDATA[Configurable Ports Options]]></a>.Value, "The options for the configurable port(s) on this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("55", "ConfigurablePortType", <a><![CDATA[Configurable Port Type]]></a>.Value, "The type of configurable port(s) on this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("158", "ConfigurablePortTypeLimits", <a><![CDATA[Configurable Port Type Limits]]></a>.Value, "The type names of the configurable port(s) on this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("57", "ConfigurablePortTypeNames", <a><![CDATA[Configurable Port Type Names]]></a>.Value, "The type names of the configurable port(s) on this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("248", "ControllerLocation", <a><![CDATA[Controller Location]]></a>.Value, "The Location of the Controller", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("247", "ControllerName", <a><![CDATA[Controller Name]]></a>.Value, "The Name of the Controller", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("43", "ControllerPartNumber", <a><![CDATA[Controller Part Number]]></a>.Value, "The part number or code for this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("49", "CPU_IOType", <a><![CDATA[CPU IO Type]]></a>.Value, "The IO type for the controller's CPU.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("402", "CurrentRating", <a><![CDATA[Current Rating]]></a>.Value, "milliAmps", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("46", "DefaultQuantity", <a><![CDATA[Default Quantity]]></a>.Value, "The default quantity for this controller.", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("334", "DynamicSQLQuery", <a><![CDATA[Dynamic SQL Query]]></a>.Value, "The options for the configurable port(s) on this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("595", "FacilityDisplayName", <a><![CDATA[Facility Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("42", "Family", <a><![CDATA[Family]]></a>.Value, "The family this controller belongs to.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("47", "Mnemonic", <a><![CDATA[Mnemonic]]></a>.Value, "The mnemonic for this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("48", "Mount", <a><![CDATA[Mount]]></a>.Value, "Where this controller is mounted.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("45", "PartDescription", <a><![CDATA[Part Description]]></a>.Value, "Description of the part for this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("44", "Pole", <a><![CDATA[Pole]]></a>.Value, "The super-region or collection of regions this controller belongs to.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("377", "PowerConsumption", <a><![CDATA[Power Consumption]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("375", "PowerSupply", <a><![CDATA[Power Supply]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("51", "UplinkPortQuantity", <a><![CDATA[Uplink Port Quantity]]></a>.Value, "The quantity of uplink ports for this controller.", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("50", "UplinkPortType", <a><![CDATA[Uplink Port Type]]></a>.Value, "The type of uplink port for this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("160", "UplinkPortTypeLimits", <a><![CDATA[Uplink Port Type Limits]]></a>.Value, "The names of the uplink ports of this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("52", "UplinkPortTypeNames", <a><![CDATA[Uplink Port Type Names]]></a>.Value, "The names of the uplink ports of this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("376", "VA_mA", <a><![CDATA[VA_mA]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("323", "ParentGroupName", <a><![CDATA[Parent Group Name]]></a>.Value, "My Parent Group", "String","","System","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601421", "4/15/2025 5:11:23 AM")
    AddProperty("249", "ParentPlantName", <a><![CDATA[Parent Plant Name]]></a>.Value, "My Parent Plant", "String","","System","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "3/21/2025 2:56:03 PM")
    AddProperty("250", "ParentPlantType", <a><![CDATA[Parent Plant Type]]></a>.Value, "My Parent Plant Type", "String","","System","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "3/21/2025 3:00:18 PM")
    AddProperty("251", "ParentSystemName", <a><![CDATA[Parent System Name]]></a>.Value, "My Parent System Name", "String","","System","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "3/31/2025 2:36:40 AM")
    AddProperty("6", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "4/7/2025 12:17:53 AM")
    
      AddPropertyExtended(59,"ConfigurablePortsOptions", "52", "EXTLABEL", "Label", "Options for Configurable Ports", "GLOBAL\SVRSDevAdmin", "3/31/2025 3:32:41 AM")
    
      AddPropertyExtended(334,"DynamicSQLQuery", "313", "EXTLABEL", "Label", "Options for Configurable Ports", "GLOBAL\H601421", "4/7/2025 1:03:29 AM")
    
      oSubpart = AddSubpart(135,"Physical", <a><![CDATA[Physical]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601421", "7/10/2025 4:09:35 AM")
      
        oSubpart.AddVPF (123, "ControllerPhysical", "Controller Physical")
      
      oConnection = AddConnection("Devices", <a><![CDATA[Devices]]></a>.Value, "", "27", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(5, "Device")
      
      AddDBConstraint(10, "dbControllersTable", <a><![CDATA[dbControllersTable]]></a>.Value,"Database Lookup", 9999)
    
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
          InitProperty("AI_UI_Capacity", "308", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 3:20:07 AM", "", "In Development",  0,752)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("AO_Capacity", "309", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 3:20:14 AM", "", "In Development",  0,753)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DI_Capacity", "310", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 3:20:27 AM", "", "In Development",  0,754)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DO_Capacity", "311", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 3:20:35 AM", "", "In Development",  0,755)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IO_Capacity", "312", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 3:20:47 AM", "", "In Development",  0,757)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("AssignedPowerSupply", "357", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/26/2025 8:13:41 PM", "", "In Development",  0,910)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ConfigurablePortQuantity", "49", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 2:30:05 AM", "", "In Development",  0,765)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ConfigurablePortsOptions", "52", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 3:32:41 AM", "", "In Development",  0,780)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ConfigurablePortType", "48", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 2:29:40 AM", "", "In Development",  0,763)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ConfigurablePortTypeLimits", "132", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 2:30:18 AM", "", "In Development",  0,766)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ConfigurablePortTypeNames", "50", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 2:30:28 AM", "", "In Development",  0,767)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerLocation", "229", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/20/2025 3:50:31 PM", "", "In Development",  0,524)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerName", "228", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/26/2025 4:06:39 AM", "", "In Development",  0,1300)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerPartNumber", "36", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 12:09:58 AM", "", "In Development",  0,652)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CPU_IOType", "42", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 2:33:48 AM", "", "In Development",  0,774)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CurrentRating", "392", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/9/2025 1:52:14 AM", "", "In Development",  0,990)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DefaultQuantity", "39", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 2:33:29 AM", "", "In Development",  0,773)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DynamicSQLQuery", "313", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/7/2025 1:03:29 AM", "", "In Development",  0,909)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FacilityDisplayName", "551", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/26/2025 4:06:05 AM", "", "In Development",  0,1299)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Family", "35", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 2:25:38 AM", "", "In Development",  0,756)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Mnemonic", "40", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 3:20:57 AM", "", "In Development",  0,758)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Mount", "41", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 2:25:38 AM", "", "In Development",  0,759)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartDescription", "38", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 3:21:21 AM", "", "In Development",  0,761)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pole", "37", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 3:21:40 AM", "", "In Development",  0,762)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerConsumption", "356", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/9/2025 1:52:58 AM", "", "In Development",  0,991)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerSupply", "354", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/7/2025 12:53:52 AM", "", "In Development",  0,906)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UplinkPortQuantity", "44", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 2:32:54 AM", "", "In Development",  0,768)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UplinkPortType", "43", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 2:31:41 AM", "", "In Development",  0,769)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UplinkPortTypeLimits", "149", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 2:31:57 AM", "", "In Development",  0,770)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UplinkPortTypeNames", "45", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 2:32:07 AM", "", "In Development",  0,771)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("VA_mA", "355", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/7/2025 12:54:46 AM", "", "In Development",  0,907)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ParentGroupName", "302", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/15/2025 5:11:23 AM", "", "In Development",  0,1055)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ParentPlantName", "230", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/21/2025 2:56:03 PM", "", "In Development",  0,528)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ParentPlantType", "231", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/21/2025 3:00:18 PM", "", "In Development",  0,530)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ParentSystemName", "232", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/31/2025 2:36:26 AM", "", "In Development",  0,776)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartNumber", "351", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/7/2025 12:17:53 AM", "", "In Development",  0,903)
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
            If Incontext("-1", ctx) Then
          
        InitSubpart("Physical", 115, "", "", "Y", 0, "-1", "", "GLOBAL\H601421", "7/10/2025 4:09:35 AM", "", "In Development", "N",0,261,260)
        
          End If
        
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
          
        InitConnection("Devices", "25", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "4/14/2025 8:06:57 PM", "", "In Development", "N",47)
        
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
            If Incontext("-1", ctx) Then
          
        InitDBConstraint("dbControllersTable", 10,"", "Y","", "", "me.DynamicSQLQuery")
        
          InitDBproperty("dbControllersTable", "AI_UI_Capacity",10, "AI_UI", "me.DynamicSQLQuery")
        
          InitDBproperty("dbControllersTable", "AO_Capacity",10, "AO", "me.DynamicSQLQuery")
        
          InitDBproperty("dbControllersTable", "DI_Capacity",10, "DI", "me.DynamicSQLQuery")
        
          InitDBproperty("dbControllersTable", "DO_Capacity",10, "DO", "me.DynamicSQLQuery")
        
          InitDBproperty("dbControllersTable", "Family",10, "Family", "me.DynamicSQLQuery")
        
          InitDBproperty("dbControllersTable", "IO_Capacity",10, "IO_Capacity", "me.DynamicSQLQuery")
        
          InitDBproperty("dbControllersTable", "Mnemonic",10, "Contoroller_Mnemonic", "me.DynamicSQLQuery")
        
          InitDBproperty("dbControllersTable", "PartDescription",10, "Description", "me.DynamicSQLQuery")
        
          InitDBproperty("dbControllersTable", "Pole",10, "Pole", "me.DynamicSQLQuery")
        
          InitDBproperty("dbControllersTable", "PowerSupply",10, "Input_Power", "me.DynamicSQLQuery")
        
          InitDBproperty("dbControllersTable", "VA_mA",10, "VA_mA", "me.DynamicSQLQuery")
        
          End If
        
    End Sub

    #End Region

    #Region " Formulas "

    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Devices_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:25; TYPE:PF
        Result = New rsCollection

Dim _myIndex As Integer = SubpartId

For Each _device As Object In Parent.Devices
	If _device.ControllerIndexAI = _myIndex OrElse _device.ControllerIndexAO = _myIndex OrElse _device.ControllerIndexDI = _myIndex OrElse _device.ControllerIndexDO = _myIndex Then
		Result.Add(_device)
	End If
Next
        '   END FORMULA; CON ID:25; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Devices_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_AI_UI_Capacity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AI_UI_Capacity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:308; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:308; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_AI_UI_Capacity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_AO_Capacity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AO_Capacity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:309; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:309; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_AO_Capacity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DI_Capacity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DI_Capacity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:310; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:310; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_DI_Capacity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DO_Capacity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DO_Capacity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:311; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:311; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_DO_Capacity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_IO_Capacity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("IO_Capacity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:312; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:312; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_IO_Capacity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_AssignedPowerSupply() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AssignedPowerSupply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:357; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:357; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_AssignedPowerSupply", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ConfigurablePortQuantity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ConfigurablePortQuantity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:49; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:49; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ConfigurablePortQuantity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ConfigurablePortsOptions() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ConfigurablePortsOptions").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:52; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:52; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ConfigurablePortsOptions", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ConfigurablePortType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ConfigurablePortType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:48; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:48; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ConfigurablePortType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ConfigurablePortTypeLimits() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ConfigurablePortTypeLimits").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:132; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:132; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ConfigurablePortTypeLimits", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ConfigurablePortTypeNames() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ConfigurablePortTypeNames").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:50; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:50; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ConfigurablePortTypeNames", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerLocation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerLocation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:229; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:229; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ControllerLocation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:228; TYPE:PF
      Result = "CO" & SubpartId
      '   END FORMULA; PROP ID:228; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ControllerName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerPartNumber() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerPartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:36; TYPE:PF
      Result = Parent.Controller
      '   END FORMULA; PROP ID:36; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ControllerPartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CPU_IOType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CPU_IOType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:42; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:42; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_CPU_IOType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CurrentRating() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CurrentRating").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:392; TYPE:PF
      Result = If(PowerSupply.ToUpper().Contains("DC"), Val(VA_ma), 0.0)
      '   END FORMULA; PROP ID:392; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_CurrentRating", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DefaultQuantity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DefaultQuantity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:39; TYPE:PF
      Result = 1
      '   END FORMULA; PROP ID:39; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_DefaultQuantity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DynamicSQLQuery() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DynamicSQLQuery").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:313; TYPE:PF
      Result = String.Format($"SELECT [AI_UI],[AO],[DI],[DO],[Pole],[Input_Power],[VA_mA],[Contoroller_Mnemonic],[IO_Capacity],[Family],[Part_Number],[Description] FROM [dbo].[Controller] WHERE Part_Number = N'{Me.ControllerPartNumber}' AND (IO_Capacity <> 0 AND IO_Capacity <> '-' AND IO_Capacity <> ' ')")
Dim _Module As String = "Controller.DynamicSQLQuery"
g_ObjectManager.LogInfo(_Module, Result,, True)
      '   END FORMULA; PROP ID:313; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_DynamicSQLQuery", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_FacilityDisplayName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("FacilityDisplayName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:551; TYPE:PF
      Result = "-			" & ControllerName
      '   END FORMULA; PROP ID:551; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_FacilityDisplayName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Family() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Family").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:35; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:35; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Family", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Mnemonic() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Mnemonic").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:40; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:40; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Mnemonic", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Mount() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Mount").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:41; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:41; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Mount", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PartDescription() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PartDescription").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:38; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:38; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_PartDescription", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Pole() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Pole").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:37; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:37; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Pole", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerConsumption() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerConsumption").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:356; TYPE:PF
      Result = If(PowerSupply.ToUpper().Contains("AC"), Val(VA_ma), 0.0)
      '   END FORMULA; PROP ID:356; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_PowerConsumption", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerSupply() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerSupply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:354; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:354; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_PowerSupply", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_UplinkPortQuantity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("UplinkPortQuantity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:44; TYPE:PF
      Result = 1
'Always 1
      '   END FORMULA; PROP ID:44; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_UplinkPortQuantity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_UplinkPortType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("UplinkPortType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:43; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:43; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_UplinkPortType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_UplinkPortTypeLimits() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("UplinkPortTypeLimits").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:149; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:149; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_UplinkPortTypeLimits", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_UplinkPortTypeNames() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("UplinkPortTypeNames").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:45; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:45; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_UplinkPortTypeNames", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_VA_mA() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("VA_mA").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:355; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:355; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_VA_mA", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ParentGroupName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ParentGroupName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:302; TYPE:PF
      Result = Parent.Parent.Group(1).GroupName
      '   END FORMULA; PROP ID:302; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ParentGroupName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ParentPlantName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ParentPlantName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:230; TYPE:PF
      Result = Me.Parent.PlantName
      '   END FORMULA; PROP ID:230; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ParentPlantName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ParentPlantType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ParentPlantType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:231; TYPE:PF
      Result = Me.Parent.PlantType
      '   END FORMULA; PROP ID:231; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ParentPlantType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ParentSystemName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ParentSystemName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:232; TYPE:PF
      Result = me.Parent.Parent.SystemName
      '   END FORMULA; PROP ID:232; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ParentSystemName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PartNumber() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:351; TYPE:PF
      Result = ControllerPartNumber
      '   END FORMULA; PROP ID:351; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_PartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AI_UI_Capacity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AO_Capacity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DI_Capacity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DO_Capacity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IO_Capacity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AssignedPowerSupply_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortQuantity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortsOptions_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortTypeLimits_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortTypeNames_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerLocation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerPartNumber_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CPU_IOType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CurrentRating_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DefaultQuantity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DynamicSQLQuery_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FacilityDisplayName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Family_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mnemonic_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mount_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartDescription_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pole_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerConsumption_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupply_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortQuantity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortTypeLimits_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortTypeNames_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VA_mA_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ParentGroupName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ParentPlantName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ParentPlantType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ParentSystemName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartNumber_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AI_UI_Capacity_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AO_Capacity_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DI_Capacity_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DO_Capacity_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IO_Capacity_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AssignedPowerSupply_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortQuantity_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortsOptions_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortTypeLimits_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortTypeNames_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerLocation_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerName_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerPartNumber_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CPU_IOType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CurrentRating_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DefaultQuantity_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DynamicSQLQuery_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FacilityDisplayName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Family_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mnemonic_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mount_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartDescription_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pole_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerConsumption_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupply_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortQuantity_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortTypeLimits_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortTypeNames_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_VA_mA_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ParentGroupName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ParentPlantName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ParentPlantType_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ParentSystemName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartNumber_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Physical_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:115; TYPE:PN
      
      '   END FORMULA; SUB ID:115; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Physical_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Physical_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Physical").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:115; TYPE:QF
      Result = DefaultQuantity
      '   END FORMULA; SUB ID:115; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Physical_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Physical_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Physical").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:115; TYPE:OP
      Result = "ControllerPhysical"
      '   END FORMULA; SUB ID:115; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Physical_OPTIMALPARTFAMILY", ex.Message)
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
    
      Dim strWhereClause as String = ""
      Dim strSelectList as String = ""
      Dim varPropSpecVal As Object
      Dim ctx As Object
      Dim leftDelimiter As String = String.Empty
      Dim rightDelimiter As String = String.Empty
      Try
      Select Case g_rsUser.UserSettings.ActiveProfile.ComponentsDatabaseType
      Case RuleStream.DataService.PublicEnumerations.DatabaseTypes.MSAccess, RuleStream.DataService.PublicEnumerations.DatabaseTypes.SQLServer
      leftDelimiter = "["
      rightDelimiter = "]"
      Case RuleStream.DataService.PublicEnumerations.DatabaseTypes.Oracle
      leftDelimiter = """"
      rightDelimiter = """"
      End Select
      ObjectManager.UnitConversion = False
      'Used to set the parameters results
      Select Case lngDBConID
      
        Case 10
        ctx = this
            strSelectStmt = me.DynamicSQLQuery
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " Controller.GetRecordset", strError)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      ObjectManager.UnitConversion = True
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

  