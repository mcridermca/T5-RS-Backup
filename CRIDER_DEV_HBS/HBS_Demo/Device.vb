Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS_Demo
'$ PartFamily: Device
'$ GenerateDate: 03/03/2025 14:37:41

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
    Imports HBS_Demo.swMateType_e
    Imports HBS_Demo.swMateAlign_e
    Imports HBS_Demo.severity

    Public Class [Device]
    
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

    Private this as Device = me

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
    
          Public Property [ApplicationUse]() As String
      Get
      Return Properties("ApplicationUse").Value
      End Get
      Set(ByVal Value As String)
      Properties("ApplicationUse").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Classification]() As String
      Get
      Return Properties("Classification").Value
      End Get
      Set(ByVal Value As String)
      Properties("Classification").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DefaultPartNumber]() As Boolean
      Get
      Return Properties("DefaultPartNumber").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("DefaultPartNumber").CalculatedValue = Value
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
    
          Public Property [DevicePartNumber]() As String
      Get
      Return Properties("DevicePartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("DevicePartNumber").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DeviceType]() As String
      Get
      Return Properties("DeviceType").Value
      End Get
      Set(ByVal Value As String)
      Properties("DeviceType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Image_RSE]() As String
      Get
      Return Properties("Image_RSE").Value
      End Get
      Set(ByVal Value As String)
      Properties("Image_RSE").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [IsStandardPart]() As Boolean
      Get
      Return Properties("IsStandardPart").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("IsStandardPart").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Mnemonics]() As String
      Get
      Return Properties("Mnemonics").Value
      End Get
      Set(ByVal Value As String)
      Properties("Mnemonics").CalculatedValue = Value
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
    
          Public Property [PartShape]() As String
      Get
      Return Properties("PartShape").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartShape").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PartShape_PNG]() As String
      Get
      Return Properties("PartShape_PNG").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartShape_PNG").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PartType]() As String
      Get
      Return Properties("PartType").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PlantName]() As String
      Get
      Return Properties("PlantName").Value
      End Get
      Set(ByVal Value As String)
      Properties("PlantName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Point1]() As String
      Get
      Return Properties("Point1").Value
      End Get
      Set(ByVal Value As String)
      Properties("Point1").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Point2]() As String
      Get
      Return Properties("Point2").Value
      End Get
      Set(ByVal Value As String)
      Properties("Point2").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Point3]() As String
      Get
      Return Properties("Point3").Value
      End Get
      Set(ByVal Value As String)
      Properties("Point3").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Point4]() As String
      Get
      Return Properties("Point4").Value
      End Get
      Set(ByVal Value As String)
      Properties("Point4").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Point5]() As String
      Get
      Return Properties("Point5").Value
      End Get
      Set(ByVal Value As String)
      Properties("Point5").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PointParameters]() As String
      Get
      Return Properties("PointParameters").Value
      End Get
      Set(ByVal Value As String)
      Properties("PointParameters").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PointTerminalBlockLink]() As String
      Get
      Return Properties("PointTerminalBlockLink").Value
      End Get
      Set(ByVal Value As String)
      Properties("PointTerminalBlockLink").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PointType]() As String
      Get
      Return Properties("PointType").Value
      End Get
      Set(ByVal Value As String)
      Properties("PointType").CalculatedValue = Value
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
    
          Public Property [PowerConsumptionCurrentRating]() As String
      Get
      Return Properties("PowerConsumptionCurrentRating").Value
      End Get
      Set(ByVal Value As String)
      Properties("PowerConsumptionCurrentRating").CalculatedValue = Value
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
    
          Public Property [ProcessVariable]() As String
      Get
      Return Properties("ProcessVariable").Value
      End Get
      Set(ByVal Value As String)
      Properties("ProcessVariable").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SignalType]() As String
      Get
      Return Properties("SignalType").Value
      End Get
      Set(ByVal Value As String)
      Properties("SignalType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [StandardWiringLegendForPoints]() As String
      Get
      Return Properties("StandardWiringLegendForPoints").Value
      End Get
      Set(ByVal Value As String)
      Properties("StandardWiringLegendForPoints").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_AI_Qty]() As Long
      Get
      Return Properties("Summary_AI_Qty").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Summary_AI_Qty").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_AI_XView]() As String
      Get
      Return Properties("Summary_AI_XView").Value
      End Get
      Set(ByVal Value As String)
      Properties("Summary_AI_XView").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_AO_Qty]() As Long
      Get
      Return Properties("Summary_AO_Qty").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Summary_AO_Qty").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_AO_XView]() As String
      Get
      Return Properties("Summary_AO_XView").Value
      End Get
      Set(ByVal Value As String)
      Properties("Summary_AO_XView").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_DI_Qty]() As Long
      Get
      Return Properties("Summary_DI_Qty").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Summary_DI_Qty").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_DI_XView]() As String
      Get
      Return Properties("Summary_DI_XView").Value
      End Get
      Set(ByVal Value As String)
      Properties("Summary_DI_XView").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_DO_Qty]() As Long
      Get
      Return Properties("Summary_DO_Qty").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Summary_DO_Qty").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Summary_DO_XView]() As String
      Get
      Return Properties("Summary_DO_XView").Value
      End Get
      Set(ByVal Value As String)
      Properties("Summary_DO_XView").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TerminalBlockLabel]() As String
      Get
      Return Properties("TerminalBlockLabel").Value
      End Get
      Set(ByVal Value As String)
      Properties("TerminalBlockLabel").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TerminalBlockOtherLabel]() As String
      Get
      Return Properties("TerminalBlockOtherLabel").Value
      End Get
      Set(ByVal Value As String)
      Properties("TerminalBlockOtherLabel").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TerminalBlocks]() As Long
      Get
      Return Properties("TerminalBlocks").Value
      End Get
      Set(ByVal Value As Long)
      Properties("TerminalBlocks").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TestPropertyName]() As String
      Get
      Return Properties("TestPropertyName").Value
      End Get
      Set(ByVal Value As String)
      Properties("TestPropertyName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [WiringType]() As String
      Get
      Return Properties("WiringType").Value
      End Get
      Set(ByVal Value As String)
      Properties("WiringType").CalculatedValue = Value
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
    
      Public ReadOnly Property [Device_DBDetails]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Device_DBDetails")
      End Get
      End Property
    
      Public ReadOnly Property [Terminal_Blocks]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Terminal_Blocks")
      End Get
      End Property
    
      Public ReadOnly Property [Controller]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Controller")
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
    InitPart("Device", <a><![CDATA[Device]]></a>.Value, 5, "HBS_Demo",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\SVRSDevAdmin", "02/28/2025 18:47:13")
    AddProperty("28", "ApplicationUse", <a><![CDATA[Application Use]]></a>.Value, "The application use for the device. Used to filter Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 4:15:05 PM")
    AddProperty("23", "Classification", <a><![CDATA[Classification]]></a>.Value, "The classification of this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 4:14:52 PM")
    AddProperty("30", "DefaultPartNumber", <a><![CDATA[Default Part Number?]]></a>.Value, "Use the default part number?", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 4:15:40 PM")
    AddProperty("24", "DefaultQuantity", <a><![CDATA[Default Quantity]]></a>.Value, "The default quantity of this device.", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 4:20:22 PM")
    AddProperty("20", "DevicePartNumber", <a><![CDATA[Device Part Number]]></a>.Value, "The identifying number or code for the device part.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 8:07:40 PM")
    AddProperty("29", "DeviceType", <a><![CDATA[Device Type]]></a>.Value, "The type of device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 4:14:33 PM")
    AddProperty("82", "Image_RSE", <a><![CDATA[Image_RSE]]></a>.Value, "Rich Client Device Image", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 6:47:13 PM")
    AddProperty("115", "IsStandardPart", <a><![CDATA[IsStandardPart]]></a>.Value, "Determines if the part number is a standard part number, or an ad-hoc part number", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 3:04:23 PM")
    AddProperty("26", "Mnemonics", <a><![CDATA[Mnemonics]]></a>.Value, "The mnemonic for this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:45:00 PM")
    AddProperty("22", "PartDescription", <a><![CDATA[Part Description]]></a>.Value, "A description of this device part.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 5:14:00 PM")
    AddProperty("31", "PartShape", <a><![CDATA[Part Shape]]></a>.Value, "The shape of the device part.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:45:26 PM")
    AddProperty("116", "PartShape_PNG", <a><![CDATA[PartShape_PNG]]></a>.Value, "The shape of the device part.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 1:58:54 PM")
    AddProperty("25", "PartType", <a><![CDATA[Part Type]]></a>.Value, "The type of device part. Used to filter the Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:45:34 PM")
    AddProperty("66", "PlantName", <a><![CDATA[Plant Name]]></a>.Value, "The name of the plant.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 5:03:22 PM")
    AddProperty("74", "Point1", <a><![CDATA[Point 1]]></a>.Value, "A point on this Device.", "String","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:40:25 AM")
    AddProperty("75", "Point2", <a><![CDATA[Point 2]]></a>.Value, "A point on this Device.", "String","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:40:32 AM")
    AddProperty("76", "Point3", <a><![CDATA[Point 3]]></a>.Value, "A point on this Device.", "String","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:44:33 AM")
    AddProperty("77", "Point4", <a><![CDATA[Point 4]]></a>.Value, "A point on this Device.", "String","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:44:40 AM")
    AddProperty("78", "Point5", <a><![CDATA[Point 5]]></a>.Value, "A point on this Device.", "String","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:44:49 AM")
    AddProperty("33", "PointParameters", <a><![CDATA[Point Parameters]]></a>.Value, "The parameteres for the point for this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 12:57:04 AM")
    AddProperty("38", "PointTerminalBlockLink", <a><![CDATA[Point Terminal Block Link]]></a>.Value, "Terminal block link designations for this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:45:54 PM")
    AddProperty("32", "PointType", <a><![CDATA[Point Type]]></a>.Value, "The type of point for this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:46:00 PM")
    AddProperty("21", "Pole", <a><![CDATA[Pole]]></a>.Value, "The super-region this device belongs to.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:58:23 AM")
    AddProperty("53", "PowerConsumptionCurrentRating", <a><![CDATA[Power Consumption - Current Rating]]></a>.Value, "The current rating of the power consumption of this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:46:34 PM")
    AddProperty("40", "PowerSupply", <a><![CDATA[Power Supply]]></a>.Value, "The power supply for this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:46:40 PM")
    AddProperty("27", "ProcessVariable", <a><![CDATA[Process Variable]]></a>.Value, "A process variable used to filter the Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:46:48 PM")
    AddProperty("34", "SignalType", <a><![CDATA[Signal Type]]></a>.Value, "The type of signal used by this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:46:53 PM")
    AddProperty("41", "StandardWiringLegendForPoints", <a><![CDATA[Standard Wiring Legend for Points]]></a>.Value, "The standard wiring legend used for the points of this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:47:00 PM")
    AddProperty("125", "Summary_AI_Qty", <a><![CDATA[Summary_AI_Qty]]></a>.Value, "Summary Value for PointType", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 10:11:39 PM")
    AddProperty("129", "Summary_AI_XView", <a><![CDATA[Summary_AI_XView]]></a>.Value, "Point Summary X View Value", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 10:12:46 PM")
    AddProperty("126", "Summary_AO_Qty", <a><![CDATA[Summary_AO_Qty]]></a>.Value, "Summary Value for PointType", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 10:10:52 PM")
    AddProperty("130", "Summary_AO_XView", <a><![CDATA[Summary_AO_XView]]></a>.Value, "Point Summary X View Value", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 10:12:31 PM")
    AddProperty("127", "Summary_DI_Qty", <a><![CDATA[Summary_DI_Qty]]></a>.Value, "Summary Value for PointType", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 10:11:51 PM")
    AddProperty("131", "Summary_DI_XView", <a><![CDATA[Summary_DI_XView]]></a>.Value, "Point Summary X View Value", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 10:12:25 PM")
    AddProperty("128", "Summary_DO_Qty", <a><![CDATA[Summary_DO_Qty]]></a>.Value, "Summary Value for PointType", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 10:11:56 PM")
    AddProperty("132", "Summary_DO_XView", <a><![CDATA[Summary_DO_XView]]></a>.Value, "Point Summary X View Value", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 10:12:14 PM")
    AddProperty("36", "TerminalBlockLabel", <a><![CDATA[Terminal Block Label]]></a>.Value, "The label of a terminal block of this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:47:09 PM")
    AddProperty("37", "TerminalBlockOtherLabel", <a><![CDATA[Terminal Block Other Label]]></a>.Value, "Another label for a terminal block of this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:47:16 PM")
    AddProperty("35", "TerminalBlocks", <a><![CDATA[Terminal Blocks]]></a>.Value, "The number of terminal blocks for this device.", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:48:51 PM")
    AddProperty("117", "TestPropertyName", <a><![CDATA[TestPropertyName]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 1:20:26 PM")
    AddProperty("39", "WiringType", <a><![CDATA[Wiring Type]]></a>.Value, "The type of wiring for this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:47:47 PM")
    AddProperty("5", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/21/2025 7:00:40 PM")
    
      AddPropertyExtended(20,"DevicePartNumber", "13", "EXTLABEL", "Label", "Part Number", "GLOBAL\SVRSDevAdmin", "2/26/2025 8:07:40 PM")
    
      AddValidValue("DevicePartNumber")
    
      AddValidValue("Pole")
    
      oSubpart = AddSubpart(8,"Device_DBDetails", <a><![CDATA[Device_DBDetails]]></a>.Value, "FD", "", "Subparts and Connections", 9999, "", "GLOBAL\SVRSDevAdmin", "2/27/2025 5:02:53 PM")
      
        oSubpart.AddVPF (10, "Device_DBDetail", "Device_DBDetail")
      
      oSubpart = AddSubpart(6,"Terminal_Blocks", <a><![CDATA[Terminal Blocks]]></a>.Value, "FD", "The terminal blocks.", "Subparts and Connections", 9999, "RuleStream", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:35:19 PM")
      
        oSubpart.AddVPF (7, "Terminal_Block", "Terminal Block")
      
      oConnection = AddConnection("Controller", <a><![CDATA[Controller]]></a>.Value, "Direct Connection to the Controller that handles this device.", "3", "OO", 0, "","Subparts and Connections", 9999, "", "GLOBAL\SVRSDevAdmin", "2/27/2025 5:03:36 PM")
      
        oConnection.AddVPF(6, "Controller")
      
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
          InitProperty("ApplicationUse", "21", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 4:15:05 PM", "", "In Development",  0,251)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Classification", "16", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 4:14:52 PM", "", "In Development",  0,250)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DefaultPartNumber", "23", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 4:15:32 PM", "", "In Development",  0,253)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DefaultQuantity", "17", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 4:20:22 PM", "", "In Development",  0,254)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DevicePartNumber", "13", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 8:07:22 PM", "", "In Development",  0,122)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DeviceType", "22", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 4:14:33 PM", "", "In Development",  0,248)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Image_RSE", "74", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 6:47:13 PM", "", "In Development",  0,391)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IsStandardPart", "105", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 3:04:11 PM", "", "In Development",  0,220)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Mnemonics", "19", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:45:00 PM", "", "In Development",  0,295)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartDescription", "15", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 5:14:00 PM", "", "In Development",  0,270)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartShape", "24", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:45:18 PM", "", "In Development",  0,296)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartShape_PNG", "106", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 1:58:54 PM", "", "In Development",  0,219)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartType", "18", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:45:34 PM", "", "In Development",  0,297)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantName", "59", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 5:03:22 PM", "", "In Development",  0,269)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Point1", "67", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:40:25 AM", "", "In Development",  0,100)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Point2", "68", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:40:32 AM", "", "In Development",  0,101)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Point3", "69", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:44:33 AM", "", "In Development",  0,102)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Point4", "70", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:44:40 AM", "", "In Development",  0,103)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Point5", "71", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:44:49 AM", "", "In Development",  0,104)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PointParameters", "26", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 12:57:04 AM", "", "In Development",  0,298)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PointTerminalBlockLink", "31", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:45:54 PM", "", "In Development",  0,299)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PointType", "25", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:46:00 PM", "", "In Development",  0,300)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pole", "14", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:58:23 AM", "", "In Development",  0,121)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerConsumptionCurrentRating", "46", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:46:34 PM", "", "In Development",  0,301)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerSupply", "33", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:46:40 PM", "", "In Development",  0,302)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ProcessVariable", "20", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:46:48 PM", "", "In Development",  0,303)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SignalType", "27", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:46:53 PM", "", "In Development",  0,304)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("StandardWiringLegendForPoints", "34", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:47:00 PM", "", "In Development",  0,305)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_AI_Qty", "115", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 10:11:39 PM", "", "In Development",  0,324)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_AI_XView", "119", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 10:12:46 PM", "", "In Development",  0,330)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_AO_Qty", "116", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 10:10:52 PM", "", "In Development",  0,323)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_AO_XView", "120", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 10:12:31 PM", "", "In Development",  0,329)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_DI_Qty", "117", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 10:11:51 PM", "", "In Development",  0,325)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_DI_XView", "121", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 10:12:25 PM", "", "In Development",  0,328)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_DO_Qty", "118", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 10:11:56 PM", "", "In Development",  0,326)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_DO_XView", "122", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 10:12:14 PM", "", "In Development",  0,327)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlockLabel", "29", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:47:09 PM", "", "In Development",  0,306)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlockOtherLabel", "30", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:47:16 PM", "", "In Development",  0,307)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlocks", "28", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:48:51 PM", "", "In Development",  0,310)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TestPropertyName", "107", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 1:20:26 PM", "", "In Development",  0,204)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("WiringType", "32", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:47:47 PM", "", "In Development",  0,309)
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
          
        InitValidValue("DevicePartNumber_ValidValues", "13", "-1", 170)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Pole_ValidValues", "14", "-1", 120)
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
            If Incontext("-1", ctx) Then
          
        InitSubpart("Device_DBDetails", 8, "", "", "Y", 0, "-1", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 7:36:06 PM", "", "In Development", "N",0,17,16)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Terminal_Blocks", 6, "", "", "Y", 0, "-1", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:35:19 PM", "", "In Development", "Y",0,12,18)
        
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
          
        InitConnection("Controller", "3", "","", "Y", 0, "-1", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 4:25:27 PM", "", "In Development", "N",7)
        
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
      Public Function Formula_Controller_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:3; TYPE:PF
        Result = Me.Parent.Controllers(1)
        '   END FORMULA; CON ID:3; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Controller_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ApplicationUse() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ApplicationUse").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:21; TYPE:PF
      'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Result = ""

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Device_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Device_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:21; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_ApplicationUse", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Classification() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Classification").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:16; TYPE:PF
      'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Result = ""

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Device_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Device_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:16; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Classification", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DefaultPartNumber() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DefaultPartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:23; TYPE:PF
      'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Result = False

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Device_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Device_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:23; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_DefaultPartNumber", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:17; TYPE:PF
      'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Result = 1

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Device_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Device_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:17; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_DefaultQuantity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DevicePartNumber() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DevicePartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:13; TYPE:PF
      Result = Me.PartNumber
'Set Calculated from PartNumber
'If this gets changed, this turns blue.
      '   END FORMULA; PROP ID:13; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_DevicePartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DeviceType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DeviceType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:22; TYPE:PF
      'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Result = ""

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Device_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Device_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:22; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_DeviceType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Image_RSE() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Image_RSE").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:74; TYPE:PF
      Result = Me.PartShape_PNG
      '   END FORMULA; PROP ID:74; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Image_RSE", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_IsStandardPart() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("IsStandardPart").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:105; TYPE:PF
      Result = False

If Me.Device_DBDetails.Quantity > 0 Then
	'If The Part number exists in a database spec / lookup, then it is a standard part for this demo
	If Me.Device_DBDetails(1).DevicePartNumber.Trim().ToLower() = Me.DevicePartNumber.Trim().ToLower()
		Result = True
	End If
End If
      '   END FORMULA; PROP ID:105; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_IsStandardPart", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Mnemonics() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Mnemonics").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:19; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:19; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Mnemonics", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:15; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Device_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Device_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:15; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PartDescription", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PartShape() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PartShape").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:24; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:24; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PartShape", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PartShape_PNG() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PartShape_PNG").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:106; TYPE:PF
      Result = "Device_Image.png"
Dim Separator As String = "."
If Me.IsStandardPart Then
	'Alternate Image in PNG Format for Demo
	If Me.PartShape.Length > 0 Then
		Result = "Device_Image_" & Split( Me.PartShape, Separator)(0) & ".png"
	End If
End If
      '   END FORMULA; PROP ID:106; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PartShape_PNG", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PartType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PartType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:18; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:18; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PartType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PlantName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PlantName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:59; TYPE:PF
      Result = ""

Result = Me.Parent.PlantName
      '   END FORMULA; PROP ID:59; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PlantName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Point1() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Point1").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:67; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:67; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Point1", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Point2() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Point2").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:68; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:68; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Point2", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Point3() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Point3").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:69; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:69; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Point3", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Point4() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Point4").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:70; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:70; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Point4", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Point5() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Point5").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:71; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:71; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Point5", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PointParameters() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PointParameters").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:26; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:26; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PointParameters", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PointTerminalBlockLink() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PointTerminalBlockLink").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:31; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:31; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PointTerminalBlockLink", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PointType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PointType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:25; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:25; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PointType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:14; TYPE:PF
      Result = Me.ValidValues("Pole").FirstValue
'Default to first ValidValue.
      '   END FORMULA; PROP ID:14; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Pole", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerConsumptionCurrentRating() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerConsumptionCurrentRating").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:46; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:46; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PowerConsumptionCurrentRating", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:33; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:33; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PowerSupply", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ProcessVariable() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ProcessVariable").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:20; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:20; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_ProcessVariable", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SignalType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SignalType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:27; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:27; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_SignalType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_StandardWiringLegendForPoints() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("StandardWiringLegendForPoints").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:34; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:34; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_StandardWiringLegendForPoints", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_AI_Qty() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_AI_Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:115; TYPE:PF
      Result = 0
Dim PointSummaryType As String = Mid(Me.CurrentProperty.Name,9,2) ' Read The Point Type from the Property Name
If PointType.Contains(PointSummaryType) Then
	Result = 1
End If
      '   END FORMULA; PROP ID:115; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Summary_AI_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_AI_XView() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_AI_XView").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:119; TYPE:PF
      Result = ""
Dim PointSummaryType As String = Mid(Me.CurrentProperty.Name,9,2) ' Read The Point Type from the Property Name
If PointType.Contains(PointSummaryType) Then
	Result = "X"
End If
      '   END FORMULA; PROP ID:119; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Summary_AI_XView", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_AO_Qty() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_AO_Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:116; TYPE:PF
      Result = 0
Dim PointSummaryType As String = Mid(Me.CurrentProperty.Name,9,2) ' Read The Point Type from the Property Name
If PointType.Contains(PointSummaryType) Then
	Result = 1
End If
      '   END FORMULA; PROP ID:116; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Summary_AO_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_AO_XView() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_AO_XView").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:120; TYPE:PF
      Result = ""
Dim PointSummaryType As String = Mid(Me.CurrentProperty.Name,9,2) ' Read The Point Type from the Property Name
If PointType.Contains(PointSummaryType) Then
	Result = "X"
End If
      '   END FORMULA; PROP ID:120; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Summary_AO_XView", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_DI_Qty() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_DI_Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:117; TYPE:PF
      Result = 0
Dim PointSummaryType As String = Mid(Me.CurrentProperty.Name,9,2) ' Read The Point Type from the Property Name
If PointType.Contains(PointSummaryType) Then
	Result = 1
End If
      '   END FORMULA; PROP ID:117; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Summary_DI_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_DI_XView() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_DI_XView").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:121; TYPE:PF
      Result = ""
Dim PointSummaryType As String = Mid(Me.CurrentProperty.Name,9,2) ' Read The Point Type from the Property Name
If PointType.Contains(PointSummaryType) Then
	Result = "X"
End If
      '   END FORMULA; PROP ID:121; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Summary_DI_XView", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_DO_Qty() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_DO_Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:118; TYPE:PF
      Result = 0
Dim PointSummaryType As String = Mid(Me.CurrentProperty.Name,9,2) ' Read The Point Type from the Property Name
If PointType.Contains(PointSummaryType) Then
	Result = 1
End If
      '   END FORMULA; PROP ID:118; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Summary_DO_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Summary_DO_XView() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Summary_DO_XView").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:122; TYPE:PF
      Result = ""
Dim PointSummaryType As String = Mid(Me.CurrentProperty.Name,9,2) ' Read The Point Type from the Property Name
If PointType.Contains(PointSummaryType) Then
	Result = "X"
End If
      '   END FORMULA; PROP ID:122; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Summary_DO_XView", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TerminalBlockLabel() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TerminalBlockLabel").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:29; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:29; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_TerminalBlockLabel", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TerminalBlockOtherLabel() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TerminalBlockOtherLabel").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:30; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:30; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_TerminalBlockOtherLabel", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TerminalBlocks() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TerminalBlocks").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:28; TYPE:PF
      Result = 1

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:28; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_TerminalBlocks", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TestPropertyName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TestPropertyName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:107; TYPE:PF
      Result = Me.CurrentProperty.Name
      '   END FORMULA; PROP ID:107; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_TestPropertyName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_WiringType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("WiringType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:32; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Device_DBDetails.Quantity >= 1 Then
	If Debug Then
		Dim Debug_Output As String = "DB #: " & Me.Device_DBDetails.Quantity & vbcrlf & "DB # Name: " & Me.Device_DBDetails(1).Name & vbcrlf & "Property Name: " & MyPropertyName
		If Me.Device_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			Debug_Output = Debug_Output  & vbcrlf & "Found Property: " &  MyPropertyName & vbcrlf & "Value: " & Me.Device_DBDetails(1).Properties(MyPropertyName).Value
		Else
			Debug_Output = Debug_Output  & vbcrlf & "Property Missing: " &  MyPropertyName
	    End If
		MessageBox.Show(Debug_Output)
	End If
	
	'Production Code
	If Me.Device_DBDetails.Quantity >= 1 Then
		Result = Me.Device_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:32; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_WiringType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ApplicationUse_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Classification_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DefaultPartNumber_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_DevicePartNumber_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DeviceType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Image_RSE_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IsStandardPart_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mnemonics_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_PartShape_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartShape_PNG_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point1_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point2_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point3_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point4_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point5_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PointParameters_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PointTerminalBlockLink_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PointType_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_PowerConsumptionCurrentRating_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_ProcessVariable_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SignalType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_StandardWiringLegendForPoints_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_AI_Qty_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_AI_XView_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_AO_Qty_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_AO_XView_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_DI_Qty_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_DI_XView_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_DO_Qty_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_DO_XView_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlockLabel_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlockOtherLabel_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlocks_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TestPropertyName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_WiringType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ApplicationUse_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Classification_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DefaultPartNumber_USERCHANGE() as Boolean
      Return True
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
      Public Function Formula_DevicePartNumber_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DeviceType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Image_RSE_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IsStandardPart_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mnemonics_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartDescription_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartShape_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("PartShape").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:24; TYPE:UC
              Result = True
If Me.IsStandardPart Then
	Result = False
	
End If
              '   END FORMULA; PROP ID:24; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PartShape_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartShape_PNG_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("PartShape_PNG").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:106; TYPE:UC
              Result = True
If Me.IsStandardPart Then
	Result = False
End If

Result = True
              '   END FORMULA; PROP ID:106; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PartShape_PNG_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point1_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point2_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point3_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point4_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point5_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PointParameters_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PointTerminalBlockLink_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PointType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pole_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerConsumptionCurrentRating_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupply_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ProcessVariable_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SignalType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_StandardWiringLegendForPoints_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_AI_Qty_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_AI_XView_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_AO_Qty_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_AO_XView_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_DI_Qty_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_DI_XView_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_DO_Qty_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Summary_DO_XView_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlockLabel_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlockOtherLabel_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TerminalBlocks_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TestPropertyName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_WiringType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DevicePartNumber_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DevicePartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:13; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_PartsTable_Demo]", "[Part Number]", "[Display_1]", "WHERE 1 = " & FormatCriteria(1) & " ORDER BY [Part Number]")
      '   END FORMULA; PROP ID:13; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_DevicePartNumber_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pole_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Pole").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:14; TYPE:VV
      Result = Rootpart.HBS_Projects(1).ValidValues("Pole")
'Pulls ValidValues from the highest-level Part (HBS_Projects) that has the property.
      '   END FORMULA; PROP ID:14; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Pole_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Device_DBDetails_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:8; TYPE:PN
      
      '   END FORMULA; SUB ID:8; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Device_DBDetails_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Device_DBDetails_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Device_DBDetails").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:8; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:8; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Device_DBDetails_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Device_DBDetails_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Device_DBDetails").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:8; TYPE:OP
      Result = "Device_DBDetail"
      '   END FORMULA; SUB ID:8; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Device_DBDetails_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Terminal_Blocks_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:6; TYPE:PN
      
      '   END FORMULA; SUB ID:6; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Terminal_Blocks_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Terminal_Blocks_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Terminal_Blocks").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:6; TYPE:QF
      Result = Me.TerminalBlocks
'CHANGE ME LATER
      '   END FORMULA; SUB ID:6; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Terminal_Blocks_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Terminal_Blocks_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Terminal_Blocks").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:6; TYPE:OP
      result = "Terminal_Block"
      '   END FORMULA; SUB ID:6; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Terminal_Blocks_OPTIMALPARTFAMILY", ex.Message)
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

  