Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: Device_DBDetail
'$ GenerateDate: 06/27/2025 20:11:04

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

    Public Class [Device_DBDetail]
    
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

    Private this as Device_DBDetail = me

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
    
          Public Property [SequenceText]() As String
      Get
      Return Properties("SequenceText").Value
      End Get
      Set(ByVal Value As String)
      Properties("SequenceText").CalculatedValue = Value
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
    
          Public Property [WiringType]() As String
      Get
      Return Properties("WiringType").Value
      End Get
      Set(ByVal Value As String)
      Properties("WiringType").CalculatedValue = Value
      End Set
      End Property
    
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
    InitPart("Device_DBDetail", <a><![CDATA[Device_DBDetail]]></a>.Value, 10, "HBS",  "N", "N", True, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "06/19/2025 19:41:00")
    AddProperty("95", "PartType", <a><![CDATA[Part Type]]></a>.Value, "The type of device part. Used to filter the Device Part Numbers.", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:26:23 AM")
    AddProperty("96", "PlantName", <a><![CDATA[Plant Name]]></a>.Value, "The name of the plant.", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:26:33 AM")
    AddProperty("97", "Point1", <a><![CDATA[Point 1]]></a>.Value, "A point on this Device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:26:43 AM")
    AddProperty("98", "Point2", <a><![CDATA[Point 2]]></a>.Value, "A point on this Device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:26:51 AM")
    AddProperty("99", "Point3", <a><![CDATA[Point 3]]></a>.Value, "A point on this Device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:27:00 AM")
    AddProperty("100", "Point4", <a><![CDATA[Point 4]]></a>.Value, "A point on this Device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:27:08 AM")
    AddProperty("101", "Point5", <a><![CDATA[Point 5]]></a>.Value, "A point on this Device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:27:17 AM")
    AddProperty("102", "PointParameters", <a><![CDATA[Point Parameters]]></a>.Value, "The parameteres for the point for this device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:27:24 AM")
    AddProperty("103", "PointTerminalBlockLink", <a><![CDATA[Point Terminal Block Link]]></a>.Value, "Terminal block link designations for this device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:27:33 AM")
    AddProperty("104", "PointType", <a><![CDATA[Point Type]]></a>.Value, "The type of point for this device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:27:41 AM")
    AddProperty("105", "Pole", <a><![CDATA[Pole]]></a>.Value, "The super-region this device belongs to.", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:27:49 AM")
    AddProperty("106", "PowerConsumptionCurrentRating", <a><![CDATA[Power Consumption - Current Rating]]></a>.Value, "The current rating of the power consumption of this device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:27:57 AM")
    AddProperty("107", "PowerSupply", <a><![CDATA[Power Supply]]></a>.Value, "The power supply for this device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:28:04 AM")
    AddProperty("108", "ProcessVariable", <a><![CDATA[Process Variable]]></a>.Value, "A process variable used to filter the Device Part Numbers.", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:28:11 AM")
    AddProperty("337", "SequenceText", <a><![CDATA[SequenceText]]></a>.Value, "The Sequence Of Operations Text for this Part", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 3:13:05 AM")
    AddProperty("109", "SignalType", <a><![CDATA[Signal Type]]></a>.Value, "The type of signal used by this device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:28:19 AM")
    AddProperty("110", "StandardWiringLegendForPoints", <a><![CDATA[Standard Wiring Legend for Points]]></a>.Value, "The standard wiring legend used for the points of this device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:28:28 AM")
    AddProperty("111", "TerminalBlockLabel", <a><![CDATA[Terminal Block Label]]></a>.Value, "The label of a terminal block of this device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:38:19 AM")
    AddProperty("112", "TerminalBlockOtherLabel", <a><![CDATA[Terminal Block Other Label]]></a>.Value, "Another label for a terminal block of this device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:38:27 AM")
    AddProperty("113", "TerminalBlocks", <a><![CDATA[Terminal Blocks]]></a>.Value, "The number of terminal blocks for this device.", "Long","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:38:36 AM")
    AddProperty("114", "WiringType", <a><![CDATA[Wiring Type]]></a>.Value, "The type of wiring for this device.", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 2:38:44 AM")
    AddProperty("85", "ApplicationUse", <a><![CDATA[Application Use]]></a>.Value, "The application use for the device. Used to filter Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("86", "Classification", <a><![CDATA[Classification]]></a>.Value, "The classification of this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("87", "DefaultPartNumber", <a><![CDATA[Default Part Number?]]></a>.Value, "Use the default part number?", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("88", "DefaultQuantity", <a><![CDATA[Default Quantity]]></a>.Value, "The default quantity of this device.", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("89", "DevicePartNumber", <a><![CDATA[Device Part Number]]></a>.Value, "The identifying number or code for the device part.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("90", "DeviceType", <a><![CDATA[Device Type]]></a>.Value, "The type of device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("92", "Mnemonics", <a><![CDATA[Mnemonics]]></a>.Value, "The mnemonic for this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("93", "PartDescription", <a><![CDATA[Part Description]]></a>.Value, "A description of this device part.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("94", "PartShape", <a><![CDATA[Part Shape]]></a>.Value, "The shape of the device part.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("84", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:10 PM")
    
      AddPropertyExtended(89,"DevicePartNumber", "79", "EXTLABEL", "Label", "Part Number", "GLOBAL\H602502", "4/23/2025 7:57:44 PM")
    
      AddDBConstraint(1, "dbPartsTable", <a><![CDATA[dbPartsTable]]></a>.Value,"Database Lookup", 9999)
    
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
          InitProperty("PartType", "85", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,143)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantName", "86", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,144)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Point1", "87", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,145)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Point2", "88", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,146)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Point3", "89", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,147)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Point4", "90", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,148)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Point5", "91", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,149)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PointParameters", "92", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,150)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PointTerminalBlockLink", "93", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,151)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PointType", "94", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,152)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pole", "95", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/18/2025 7:36:52 PM", "", "In Development",  0,503)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerConsumptionCurrentRating", "96", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,155)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerSupply", "97", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,156)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ProcessVariable", "98", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,157)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SequenceText", "316", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "4/1/2025 3:13:05 AM", "", "In Development",  0,787)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SignalType", "99", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,158)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("StandardWiringLegendForPoints", "100", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,159)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlockLabel", "101", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,160)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlockOtherLabel", "102", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,161)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlocks", "103", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,162)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("WiringType", "104", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,163)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ApplicationUse", "75", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:10 PM", "", "In Development",  0,133)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Classification", "76", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,134)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DefaultPartNumber", "77", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,135)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DefaultQuantity", "78", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,136)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DevicePartNumber", "79", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 7:57:40 PM", "", "In Development",  0,1231)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DeviceType", "80", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,138)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Mnemonics", "82", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,140)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartDescription", "83", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,141)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartShape", "84", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 7:37:11 PM", "", "In Development",  0,142)
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
            If Incontext("-1", ctx) Then
          
        InitDBConstraint("dbPartsTable", 1,"", "Y","", "", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "ApplicationUse",1, "Part_Application", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "Classification",1, "Part_Classification", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "DefaultPartNumber",1, "Default_Part_Number", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "DefaultQuantity",1, "Default_Part_Qty", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "DevicePartNumber",1, "Part_Number", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "DeviceType",1, "Device_Type", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "Mnemonics",1, "Mnemonics", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "PartDescription",1, "Part_Description", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "PartShape",1, "Part_Shape", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "PartType",1, "Part_Type", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "PointParameters",1, "Point_Parameter", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "PointTerminalBlockLink",1, "Point_Terminal_Block_Link", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "PointType",1, "Point_Type", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "Pole",1, "Pole", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "PowerConsumptionCurrentRating",1, "Power_Consumption_Current_Rating", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "PowerSupply",1, "Power_Supply", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "ProcessVariable",1, "Process_Variable", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "SequenceText",1, "Sequence_Text", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "SignalType",1, "Signal_Type", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "StandardWiringLegendForPoints",1, "Std_Wiring_Legend_For_Points", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "TerminalBlockLabel",1, "TB_Label", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "TerminalBlocks",1, "Num_Of_TBs", "vw_Parts_Sequence_Table")
        
          InitDBproperty("dbPartsTable", "WiringType",1, "Wiring_Type", "vw_Parts_Sequence_Table")
        
          End If
        
    End Sub

    #End Region

    #Region " Formulas "

    
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
      '   BEGIN FORMULA; PROP ID:85; TYPE:PF
      result = ""
'Filter 2
      '   END FORMULA; PROP ID:85; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_PartType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:86; TYPE:PF
      Result = Me.Parent.PlantName
'Pulls name from the parent Plant.
      '   END FORMULA; PROP ID:86; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_PlantName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:87; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:87; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_Point1", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:88; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:88; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_Point2", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:89; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:89; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_Point3", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:90; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:90; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_Point4", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:91; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:91; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_Point5", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:92; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:92; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_PointParameters", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:93; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:93; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_PointTerminalBlockLink", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:94; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:94; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_PointType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:95; TYPE:PF
      Result = Rootpart.CORA_Info(1).Pole
      '   END FORMULA; PROP ID:95; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_Pole", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:96; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:96; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_PowerConsumptionCurrentRating", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:97; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:97; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_PowerSupply", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:98; TYPE:PF
      result = ""
'Filter 1
      '   END FORMULA; PROP ID:98; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_ProcessVariable", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SequenceText() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SequenceText").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:316; TYPE:PF
      result = ""
'Filter 1
      '   END FORMULA; PROP ID:316; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_SequenceText", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:99; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:99; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_SignalType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:100; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:100; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_StandardWiringLegendForPoints", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:101; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:101; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_TerminalBlockLabel", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:102; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:102; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_TerminalBlockOtherLabel", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:103; TYPE:PF
      Result = 1
'Default to 1
      '   END FORMULA; PROP ID:103; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_TerminalBlocks", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:104; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:104; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_WiringType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      '   BEGIN FORMULA; PROP ID:75; TYPE:PF
      result = ""
'Filter 0
      '   END FORMULA; PROP ID:75; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_ApplicationUse", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:76; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:76; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_Classification", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:77; TYPE:PF
      result = True
      '   END FORMULA; PROP ID:77; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_DefaultPartNumber", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:78; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:78; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_DefaultQuantity", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:79; TYPE:PF
      Result = Me.Parent.DevicePartNumber
      '   END FORMULA; PROP ID:79; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_DevicePartNumber", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:80; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:80; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_DeviceType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:82; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:82; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_Mnemonics", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:83; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:83; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_PartDescription", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:84; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:84; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.Formula_PartShape", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      Public Function Formula_SequenceText_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_WiringType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
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
      Public Function Formula_SequenceText_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_WiringType_USERCHANGE() as Boolean
      Return True
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
      Return True
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
      
        Case 1
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "Part_Application" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Part_Classification" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Default_Part_Number" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Default_Part_Qty" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Part_Number" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Device_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Mnemonics" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Part_Description" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Part_Shape" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Part_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Point_Parameter" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Point_Terminal_Block_Link" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Point_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Pole" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Power_Consumption_Current_Rating" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Power_Supply" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Process_Variable" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Sequence_Text" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Signal_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Std_Wiring_Legend_For_Points" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "TB_Label" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Num_Of_TBs" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Wiring_Type" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
                  varPropSpecVal = me.DevicePartNumber
              BuildWhereClause(strWhereClause, "0", "0", "  ", "[Part_Number]", "=", varPropSpecVal, "")
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("vw_Parts_Sequence_Table"), strWhereClause, leftDelimiter & "Default_Part_Number" & rightDelimiter, "DESC")
          
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " Device_DBDetail.GetRecordset", strError)
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

  