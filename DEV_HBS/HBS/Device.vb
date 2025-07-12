Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: Device
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
    
      Case "PartType_"
      Formula_PartType_WHENCHANGED(Value, OldValue)
    
      Case "SelectedForPowerSupply_"
      Formula_SelectedForPowerSupply_WHENCHANGED(Value, OldValue)
    
    End Select
    End Sub

    Public Function OnChangedStatus(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String)As Boolean Implements RuleStream.IRsPartFormulas.OnChangedStatus
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Dim Status as Boolean = False
    Select Case specName & "_" & context
    
      Case "PartType_"
      'Formula_PartType_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "SelectedForPowerSupply_"
      'Formula_SelectedForPowerSupply_WHENCHANGED(Value, OldValue)
      Status = True
    Case Else
    Status = False
    End Select
    Return Status
    End Function

    #End Region

    #Region " Properties, Subparts, Connections "
    
          Public Property [SequenceText]() As String
      Get
      Return Properties("SequenceText").Value
      End Get
      Set(ByVal Value As String)
      Properties("SequenceText").CalculatedValue = Value
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
    
          Public Property [AssignedPowerSupply]() As String
      Get
      Return Properties("AssignedPowerSupply").Value
      End Get
      Set(ByVal Value As String)
      Properties("AssignedPowerSupply").CalculatedValue = Value
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
    
          Public Property [ControllerIndex]() As String
      Get
      Return Properties("ControllerIndex").Value
      End Get
      Set(ByVal Value As String)
      Properties("ControllerIndex").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerIndexPreset]() As String
      Get
      Return Properties("ControllerIndexPreset").Value
      End Get
      Set(ByVal Value As String)
      Properties("ControllerIndexPreset").CalculatedValue = Value
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
    
          Public Property [ControllerPoint]() As String
      Get
      Return Properties("ControllerPoint").Value
      End Get
      Set(ByVal Value As String)
      Properties("ControllerPoint").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerPointPreset]() As String
      Get
      Return Properties("ControllerPointPreset").Value
      End Get
      Set(ByVal Value As String)
      Properties("ControllerPointPreset").CalculatedValue = Value
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
    
          Public Property [DefaultWiring]() As String
      Get
      Return Properties("DefaultWiring").Value
      End Get
      Set(ByVal Value As String)
      Properties("DefaultWiring").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DeviceIndex]() As Long
      Get
      Return Properties("DeviceIndex").Value
      End Get
      Set(ByVal Value As Long)
      Properties("DeviceIndex").CalculatedValue = Value
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
    
          Public Shadows Property [DisplayName]() As String
      Get
      Return Properties("DisplayName").Value
      End Get
      Set(ByVal Value As String)
      Properties("DisplayName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DOType]() As String
      Get
      Return Properties("DOType").Value
      End Get
      Set(ByVal Value As String)
      Properties("DOType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ElementName]() As String
      Get
      Return Properties("ElementName").Value
      End Get
      Set(ByVal Value As String)
      Properties("ElementName").CalculatedValue = Value
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
    
          Public Property [Indicator_OriginalOrDelta]() As String
      Get
      Return Properties("Indicator_OriginalOrDelta").Value
      End Get
      Set(ByVal Value As String)
      Properties("Indicator_OriginalOrDelta").CalculatedValue = Value
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
    
          Public Property [LocationX]() As Double
      Get
      Return Properties("LocationX").Value
      End Get
      Set(ByVal Value As Double)
      Properties("LocationX").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LocationY]() As Double
      Get
      Return Properties("LocationY").Value
      End Get
      Set(ByVal Value As Double)
      Properties("LocationY").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LocationZ]() As Double
      Get
      Return Properties("LocationZ").Value
      End Get
      Set(ByVal Value As Double)
      Properties("LocationZ").CalculatedValue = Value
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
    
          Public Property [PartShape_DWG]() As String
      Get
      Return Properties("PartShape_DWG").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartShape_DWG").CalculatedValue = Value
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
    
          Public Property [PointParameter]() As String
      Get
      Return Properties("PointParameter").Value
      End Get
      Set(ByVal Value As String)
      Properties("PointParameter").CalculatedValue = Value
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
    
          Public Property [PowerConsumption]() As String
      Get
      Return Properties("PowerConsumption").Value
      End Get
      Set(ByVal Value As String)
      Properties("PowerConsumption").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerConsumptionDB]() As String
      Get
      Return Properties("PowerConsumptionDB").Value
      End Get
      Set(ByVal Value As String)
      Properties("PowerConsumptionDB").CalculatedValue = Value
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
    
          Public Property [PowerSupplyDB]() As String
      Get
      Return Properties("PowerSupplyDB").Value
      End Get
      Set(ByVal Value As String)
      Properties("PowerSupplyDB").CalculatedValue = Value
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
    
          Public Property [ScaleX]() As Double
      Get
      Return Properties("ScaleX").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ScaleX").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ScaleY]() As Double
      Get
      Return Properties("ScaleY").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ScaleY").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ScaleZ]() As Double
      Get
      Return Properties("ScaleZ").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ScaleZ").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SelectedForPowerSupply]() As Boolean
      Get
      Return Properties("SelectedForPowerSupply").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("SelectedForPowerSupply").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SignalRangeCustomizable]() As String
      Get
      Return Properties("SignalRangeCustomizable").Value
      End Get
      Set(ByVal Value As String)
      Properties("SignalRangeCustomizable").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SignalRangeImperial]() As String
      Get
      Return Properties("SignalRangeImperial").Value
      End Get
      Set(ByVal Value As String)
      Properties("SignalRangeImperial").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SignalRangeMetric]() As String
      Get
      Return Properties("SignalRangeMetric").Value
      End Get
      Set(ByVal Value As String)
      Properties("SignalRangeMetric").CalculatedValue = Value
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
    
          Public Property [Summary_AI_XView]() As String
      Get
      Return Properties("Summary_AI_XView").Value
      End Get
      Set(ByVal Value As String)
      Properties("Summary_AI_XView").CalculatedValue = Value
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
    
          Public Property [Summary_DI_XView]() As String
      Get
      Return Properties("Summary_DI_XView").Value
      End Get
      Set(ByVal Value As String)
      Properties("Summary_DI_XView").CalculatedValue = Value
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
    
          Public Property [SymbolImagePath]() As String
      Get
      Return Properties("SymbolImagePath").Value
      End Get
      Set(ByVal Value As String)
      Properties("SymbolImagePath").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Tag]() As String
      Get
      Return Properties("Tag").Value
      End Get
      Set(ByVal Value As String)
      Properties("Tag").CalculatedValue = Value
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
    
          Public Property [TerminalBlockNumber]() As String
      Get
      Return Properties("TerminalBlockNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("TerminalBlockNumber").CalculatedValue = Value
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
    
          Public Property [WiringStandardDetail]() As String
      Get
      Return Properties("WiringStandardDetail").Value
      End Get
      Set(ByVal Value As String)
      Properties("WiringStandardDetail").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [WiringStandardIndex]() As Long
      Get
      Return Properties("WiringStandardIndex").Value
      End Get
      Set(ByVal Value As Long)
      Properties("WiringStandardIndex").CalculatedValue = Value
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
    
      Public ReadOnly Property [Circuit]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Circuit")
      End Get
      End Property
    
      Public ReadOnly Property [Wires]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Wires")
      End Get
      End Property
    
      Public ReadOnly Property [conn_CORA_Info]() As Rulestream.Kernel.Connection
      Get
      Return Connections("conn_CORA_Info")
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
    InitPart("Device", <a><![CDATA[Device]]></a>.Value, 5, "HBS",  "N", "N", True, False, "In Development", "", "", "", "", "",  "GLOBAL\H601421", "06/27/2025 05:35:11")
    AddProperty("338", "SequenceText", <a><![CDATA[SequenceText]]></a>.Value, "The Sequence Of Operations Text for this Part", "String","","Database View Mapper","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "5/2/2025 6:01:26 AM")
    AddProperty("28", "ApplicationUse", <a><![CDATA[Application Use]]></a>.Value, "The application use for the device. Used to filter Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("359", "AssignedPowerSupply", <a><![CDATA[Assigned Power Supply]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/26/2025 8:13:29 PM")
    AddProperty("23", "Classification", <a><![CDATA[Classification]]></a>.Value, "The classification of this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("614", "ControllerIndex", <a><![CDATA[Controller Index]]></a>.Value, "Semicolon delimited, to match Point Type data", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("617", "ControllerIndexPreset", <a><![CDATA[Controller Index Preset]]></a>.Value, "If Controller and its Point is manually assigned after an import from a library, this is where the pre-assigned value is stored", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("289", "ControllerPartNumber", <a><![CDATA[Controller Part Number]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("605", "ControllerPoint", <a><![CDATA[Controller Point]]></a>.Value, "Semicolon delimited, to match Point Type data", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("616", "ControllerPointPreset", <a><![CDATA[Controller Point Preset]]></a>.Value, "If Controller and its Point is manually assigned after an import from a library, this is where the pre-assigned value is stored", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("30", "DefaultPartNumber", <a><![CDATA[Default Part Number?]]></a>.Value, "Use the default part number?", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("24", "DefaultQuantity", <a><![CDATA[Default Quantity]]></a>.Value, "The default quantity of this device.", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("608", "DefaultWiring", <a><![CDATA[Default Wiring]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("356", "DeviceIndex", <a><![CDATA[Device Index]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("20", "DevicePartNumber", <a><![CDATA[Device Part Number]]></a>.Value, "The identifying number or code for the device part.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("29", "DeviceType", <a><![CDATA[Device Type]]></a>.Value, "The type of device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("427", "DisplayName", <a><![CDATA[Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("615", "DOType", <a><![CDATA[DO Type]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("811", "ElementName", <a><![CDATA[Element Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/26/2025 4:04:20 AM")
    AddProperty("82", "Image_RSE", <a><![CDATA[Image_RSE]]></a>.Value, "Rich Client Device Image", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("531", "Indicator_OriginalOrDelta", <a><![CDATA[Indicator_OriginalOrDelta]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("115", "IsStandardPart", <a><![CDATA[IsStandardPart]]></a>.Value, "Determines if the part number is a standard part number, or an ad-hoc part number", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("524", "LocationX", <a><![CDATA[Location X]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("526", "LocationY", <a><![CDATA[Location Y]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("528", "LocationZ", <a><![CDATA[Location Z]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("26", "Mnemonics", <a><![CDATA[Mnemonics]]></a>.Value, "The mnemonic for this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("22", "PartDescription", <a><![CDATA[Part Description]]></a>.Value, "A description of this device part.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("31", "PartShape", <a><![CDATA[Part Shape]]></a>.Value, "The shape of the device part.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("530", "PartShape_DWG", <a><![CDATA[Part Shape_DWG]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("116", "PartShape_PNG", <a><![CDATA[PartShape_PNG]]></a>.Value, "The shape of the device part.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("25", "PartType", <a><![CDATA[Part Type]]></a>.Value, "The type of device part. Used to filter the Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("613", "PointParameter", <a><![CDATA[Point Parameter]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("32", "PointType", <a><![CDATA[Point Type]]></a>.Value, "The type of point for this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("21", "Pole", <a><![CDATA[Pole]]></a>.Value, "The super-region this device belongs to.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("769", "PowerConsumption", <a><![CDATA[Power Consumption]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/24/2025 8:56:19 PM")
    AddProperty("768", "PowerConsumptionDB", <a><![CDATA[Power Consumption DB]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/24/2025 7:53:36 PM")
    AddProperty("40", "PowerSupply", <a><![CDATA[Power Supply]]></a>.Value, "The power supply for this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/24/2025 8:58:43 PM")
    AddProperty("766", "PowerSupplyDB", <a><![CDATA[Power Supply DB]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/24/2025 4:04:53 AM")
    AddProperty("27", "ProcessVariable", <a><![CDATA[Process Variable]]></a>.Value, "A process variable used to filter the Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("525", "ScaleX", <a><![CDATA[Scale X]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("527", "ScaleY", <a><![CDATA[Scale Y]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("529", "ScaleZ", <a><![CDATA[Scale Z]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("360", "SelectedForPowerSupply", <a><![CDATA[Selected For Power Supply]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/25/2025 4:12:00 AM")
    AddProperty("612", "SignalRangeCustomizable", <a><![CDATA[Signal Range Customizable]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("611", "SignalRangeImperial", <a><![CDATA[Signal Range Imperial]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("610", "SignalRangeMetric", <a><![CDATA[Signal Range Metric]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("34", "SignalType", <a><![CDATA[Signal Type]]></a>.Value, "The type of signal used by this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("129", "Summary_AI_XView", <a><![CDATA[Summary_AI_XView]]></a>.Value, "Point Summary X View Value", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("130", "Summary_AO_XView", <a><![CDATA[Summary_AO_XView]]></a>.Value, "Point Summary X View Value", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("131", "Summary_DI_XView", <a><![CDATA[Summary_DI_XView]]></a>.Value, "Point Summary X View Value", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("132", "Summary_DO_XView", <a><![CDATA[Summary_DO_XView]]></a>.Value, "Point Summary X View Value", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("380", "SymbolImagePath", <a><![CDATA[Symbol Image Path]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("687", "Tag", <a><![CDATA[Tag]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("36", "TerminalBlockLabel", <a><![CDATA[Terminal Block Label]]></a>.Value, "The label of a terminal block of this device.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("607", "TerminalBlockNumber", <a><![CDATA[Terminal Block Number]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("35", "TerminalBlocks", <a><![CDATA[Terminal Blocks]]></a>.Value, "The number of terminal blocks for this device.", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("609", "WiringStandardDetail", <a><![CDATA[Wiring Standard Detail]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("767", "WiringStandardIndex", <a><![CDATA[Wiring Standard Index]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/24/2025 7:22:35 PM")
    AddProperty("5", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/21/2025 7:00:40 PM")
    
      AddPropertyExtended(20,"DevicePartNumber", "13", "EXTLABEL", "Label", "Part Number", "GLOBAL\SVRSDevAdmin", "3/19/2025 9:32:03 PM")
    
      AddValidValue("DevicePartNumber")
    
      AddValidValue("Pole")
    
      AddValidValue("PowerConsumption")
    
      oSubpart = AddSubpart(8,"Device_DBDetails", <a><![CDATA[Device_DBDetails]]></a>.Value, "FD", "", "Subparts and Connections", 9999, "", "GLOBAL\H601421", "5/2/2025 5:30:19 AM")
      
        oSubpart.AddVPF (10, "Device_DBDetail", "Device_DBDetail")
      
      oConnection = AddConnection("Circuit", <a><![CDATA[Circuit]]></a>.Value, "", "70", "OO", 0, "","General", 9999, "", "GLOBAL\H601421", "6/27/2025 5:35:11 AM")
      
        oConnection.AddVPF(23, "Circuit")
      
      oConnection = AddConnection("Wires", <a><![CDATA[Wires]]></a>.Value, "", "56", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(21, "Wire")
      
      oConnection = AddConnection("conn_CORA_Info", <a><![CDATA[Connection: CORA Info]]></a>.Value, "A connection to the CORA info.", "10", "OM", 0, "","Subparts and Connections", 9999, "CORA", "GLOBAL\H601421", "5/2/2025 5:40:24 AM")
      
        oConnection.AddVPF(19, "CORA_Project_Information")
      
      AddDBConstraint(17, "DeviceData", <a><![CDATA[Device Data]]></a>.Value,"General", 9999)
    
      AddDBConstraint(18, "SequenceData", <a><![CDATA[Sequence Data]]></a>.Value,"General", 9999)
    
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
          InitProperty("SequenceText", "317", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 6:01:26 AM", "", "In Development",  0,1376)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ApplicationUse", "21", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 5:57:47 AM", "", "In Development",  0,1364)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("AssignedPowerSupply", "337", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/26/2025 8:13:29 PM", "", "In Development",  0,843)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Classification", "16", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 5:57:56 AM", "", "In Development",  0,1365)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerIndex", "570", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/3/2025 2:55:28 AM", "", "In Development",  0,1385)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerIndexPreset", "573", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/3/2025 3:15:44 AM", "", "In Development",  0,1387)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerPartNumber", "269", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "3/28/2025 9:33:14 PM", "", "In Development",  0,704)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerPoint", "561", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/3/2025 2:55:16 AM", "", "In Development",  0,1384)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerPointPreset", "572", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/3/2025 3:13:43 AM", "", "In Development",  0,1386)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DefaultPartNumber", "23", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 5:58:33 AM", "", "In Development",  0,1366)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DefaultQuantity", "17", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 5:59:19 AM", "", "In Development",  0,1367)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DefaultWiring", "564", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/30/2025 5:01:10 AM", "", "In Development",  0,1334)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DeviceIndex", "334", "", "", "Y", "","", 3, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/6/2025 4:05:58 AM", "", "In Development",  0,896)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DevicePartNumber", "13", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/19/2025 9:32:03 PM", "", "In Development",  0,122)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DeviceType", "22", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 5:59:42 AM", "", "In Development",  0,1368)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DisplayName", "406", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/8/2025 8:03:22 PM", "", "In Development",  0,977)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DOType", "571", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 5:10:19 AM", "", "In Development",  0,1362)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ElementName", "751", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/26/2025 4:04:20 AM", "", "In Development",  0,1718)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Image_RSE", "74", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 6:47:13 PM", "", "In Development",  0,391)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Indicator_OriginalOrDelta", "505", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 3:51:57 PM", "", "In Development",  0,1217)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IsStandardPart", "105", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 4:50:07 AM", "", "In Development",  0,1361)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LocationX", "498", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 3:43:28 PM", "", "In Development",  0,1210)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LocationY", "500", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 3:44:07 PM", "", "In Development",  0,1212)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LocationZ", "502", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 3:46:20 PM", "", "In Development",  0,1214)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Mnemonics", "19", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 6:00:14 AM", "", "In Development",  0,1369)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartDescription", "15", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 6:00:21 AM", "", "In Development",  0,1370)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartShape", "24", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 5:30:51 AM", "", "In Development",  0,1363)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartShape_DWG", "504", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 3:49:05 PM", "", "In Development",  0,1216)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartShape_PNG", "106", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 1:58:54 PM", "", "In Development",  0,219)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartType", "18", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 6:00:34 AM", "", "In Development",  0,1371)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PointParameter", "569", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 4:08:26 AM", "", "In Development",  0,1358)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PointType", "25", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 6:00:42 AM", "", "In Development",  0,1372)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pole", "14", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/18/2025 7:32:50 PM", "", "In Development",  0,500)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerConsumption", "713", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601421", "6/24/2025 8:56:19 PM", "", "In Development",  0,1654)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerConsumptionDB", "712", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/24/2025 7:53:36 PM", "", "In Development",  0,1650)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerSupply", "33", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/24/2025 8:58:43 PM", "", "In Development",  0,1656)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerSupplyDB", "710", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/24/2025 4:04:53 AM", "", "In Development",  0,1647)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ProcessVariable", "20", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 6:01:18 AM", "", "In Development",  0,1375)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ScaleX", "499", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 3:42:56 PM", "", "In Development",  0,1211)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ScaleY", "501", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 3:45:36 PM", "", "In Development",  0,1213)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ScaleZ", "503", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/23/2025 3:47:10 PM", "", "In Development",  0,1215)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SelectedForPowerSupply", "338", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/25/2025 4:12:00 AM", "", "In Development",  0,1688)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SignalRangeCustomizable", "568", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/30/2025 5:03:19 AM", "", "In Development",  0,1338)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SignalRangeImperial", "567", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/30/2025 5:02:58 AM", "", "In Development",  0,1337)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SignalRangeMetric", "566", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/30/2025 5:02:41 AM", "", "In Development",  0,1336)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SignalType", "27", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:46:53 PM", "", "In Development",  0,304)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_AI_XView", "119", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 10:12:46 PM", "", "In Development",  0,330)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_AO_XView", "120", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 10:12:31 PM", "", "In Development",  0,329)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_DI_XView", "121", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 10:12:25 PM", "", "In Development",  0,328)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Summary_DO_XView", "122", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 10:12:14 PM", "", "In Development",  0,327)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SymbolImagePath", "359", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "4/16/2025 8:02:07 PM", "", "In Development",  0,1060)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Tag", "641", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/19/2025 7:23:38 PM", "", "In Development",  0,1526)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlockLabel", "29", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 6:01:48 AM", "", "In Development",  0,1377)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlockNumber", "563", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/30/2025 5:00:36 AM", "", "In Development",  0,1333)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TerminalBlocks", "28", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/2/2025 6:02:09 AM", "", "In Development",  0,1378)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("WiringStandardDetail", "565", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/30/2025 5:01:43 AM", "", "In Development",  0,1335)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("WiringStandardIndex", "711", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/24/2025 7:22:35 PM", "", "In Development",  0,1649)
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
          
        InitValidValue("DevicePartNumber_ValidValues", "13", "-1", 522)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Pole_ValidValues", "14", "-1", 499)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PowerConsumption_ValidValues", "713", "-1", 1655)
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
          
        InitSubpart("Device_DBDetails", 8, "", "", "Y", 0, "-1", "", "GLOBAL\H601421", "5/2/2025 5:30:19 AM", "", "In Development", "N",0,17,150)
        
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
          
        InitConnection("Circuit", "63", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "6/27/2025 5:35:11 AM", "", "In Development", "N",116)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Wires", "51", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "5/6/2025 10:10:36 PM", "", "In Development", "N",94)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("conn_CORA_Info", "10", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "5/2/2025 5:40:24 AM", "", "In Development", "N",90)
        
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
          
        InitDBConstraint("DeviceData", 17,"", "Y","", "", "Parts_Table")
        
          InitDBproperty("DeviceData", "ApplicationUse",17, "Part_Application", "Parts_Table")
        
          InitDBproperty("DeviceData", "Classification",17, "Part_Classification", "Parts_Table")
        
          InitDBproperty("DeviceData", "DefaultPartNumber",17, "Default_Part_Number", "Parts_Table")
        
          InitDBproperty("DeviceData", "DefaultQuantity",17, "Default_Part_Qty", "Parts_Table")
        
          InitDBproperty("DeviceData", "DefaultWiring",17, "Default_Wiring", "Parts_Table")
        
          InitDBproperty("DeviceData", "DeviceType",17, "Device_Type", "Parts_Table")
        
          InitDBproperty("DeviceData", "DOType",17, "Do_Type", "Parts_Table")
        
          InitDBproperty("DeviceData", "Mnemonics",17, "Mnemonics", "Parts_Table")
        
          InitDBproperty("DeviceData", "PartDescription",17, "Part_Description", "Parts_Table")
        
          InitDBproperty("DeviceData", "PartType",17, "Part_Type", "Parts_Table")
        
          InitDBproperty("DeviceData", "PointParameter",17, "Parameter_Name", "Parts_Table")
        
          InitDBproperty("DeviceData", "PointType",17, "Point_Type", "Parts_Table")
        
          InitDBproperty("DeviceData", "Pole",17, "Pole", "Parts_Table")
        
          InitDBproperty("DeviceData", "PowerConsumptionDB",17, "Power_Consumption", "Parts_Table")
        
          InitDBproperty("DeviceData", "PowerSupplyDB",17, "Power_Supply", "Parts_Table")
        
          InitDBproperty("DeviceData", "ProcessVariable",17, "Process_Variable", "Parts_Table")
        
          InitDBproperty("DeviceData", "SignalRangeCustomizable",17, "Signal_Range_Customizable", "Parts_Table")
        
          InitDBproperty("DeviceData", "SignalRangeImperial",17, "Signal_Range_Imperial", "Parts_Table")
        
          InitDBproperty("DeviceData", "SignalRangeMetric",17, "Signal_Range_Metric", "Parts_Table")
        
          InitDBproperty("DeviceData", "SignalType",17, "Signal_Type", "Parts_Table")
        
          InitDBproperty("DeviceData", "TerminalBlockLabel",17, "Tb_Label", "Parts_Table")
        
          InitDBproperty("DeviceData", "TerminalBlockNumber",17, "Tb_Number", "Parts_Table")
        
          InitDBproperty("DeviceData", "TerminalBlocks",17, "Num_Of_TBs", "Parts_Table")
        
          InitDBproperty("DeviceData", "WiringStandardDetail",17, "Wiring_Standard_Detail", "Parts_Table")
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitDBConstraint("SequenceData", 18,"", "Y","", "", "PartType_Sequence_Table")
        
          InitDBproperty("SequenceData", "SequenceText",18, "Sequence_Text", "PartType_Sequence_Table")
        
          End If
        
    End Sub

    #End Region

    #Region " Formulas "

    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Circuit_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:63; TYPE:PF
        Dim _cktTag As String = AssignedPowerSupply

If _cktTag.Length > 0 Then
	Dim _con As rsCollection = RootPart.PowerSupplyView(1).AllCircuits.Parts

	If _con.ContainsKey(_cktTag) Then Result = _con.Item(_cktTag)
End If
        '   END FORMULA; CON ID:63; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Circuit_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Wires_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:51; TYPE:PF
        Dim _myIndex As Integer = DeviceIndex

Result = New rsCollection

For Each _wire As Object In Parent.Wires
	If _wire.DeviceIndex = _myIndex Then Result.Add(_wire)
Next
        '   END FORMULA; CON ID:51; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Wires_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_conn_CORA_Info_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:10; TYPE:PF
        Result = Rootpart.CORA_Info(1)
        '   END FORMULA; CON ID:10; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_conn_CORA_Info_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
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
      '   BEGIN FORMULA; PROP ID:317; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:317; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_SequenceText", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:21; TYPE:PF
      Result = String.Empty
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
          Public Function Formula_AssignedPowerSupply() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AssignedPowerSupply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:337; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:337; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_AssignedPowerSupply", ex.Message)
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
      Result = String.Empty
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
          Public Function Formula_ControllerIndex() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerIndex").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:570; TYPE:PF
      Dim _xControllers As System.Xml.XmlDocument = Parent.ValidValues("ControllerQuantity")("XML")
Dim _attribute As String = "ControllerIndex"
Dim _xPath As String = "Devices/Device[@DeviceIndex='" & DeviceIndex & "']"
Dim _xDevice As System.Xml.XmlNode = _xControllers.DocumentElement.SelectSingleNode(_xPath)
Result = If(_xDevice IsNot Nothing, _xDevice.Attributes(_attribute).Value, String.Empty)
      '   END FORMULA; PROP ID:570; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_ControllerIndex", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerIndexPreset() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerIndexPreset").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:573; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:573; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_ControllerIndexPreset", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:269; TYPE:PF
      Result = Parent.ValidValues("Controller")(Parent.Controller)
      '   END FORMULA; PROP ID:269; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_ControllerPartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerPoint() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerPoint").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:561; TYPE:PF
      Dim _xControllers As System.Xml.XmlDocument = Parent.ValidValues("ControllerQuantity")("XML")
Dim _attribute As String = "ControllerPoint"
Dim _xPath As String = "Devices/Device[@DeviceIndex='" & DeviceIndex & "']"
Dim _xDevice As System.Xml.XmlNode = _xControllers.DocumentElement.SelectSingleNode(_xPath)
Result = If(_xDevice IsNot Nothing, _xDevice.Attributes(_attribute).Value, String.Empty)
      '   END FORMULA; PROP ID:561; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_ControllerPoint", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerPointPreset() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerPointPreset").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:572; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:572; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_ControllerPointPreset", ex.Message)
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
      Result = False
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
      Result = 1
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
          Public Function Formula_DefaultWiring() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DefaultWiring").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:564; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:564; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_DefaultWiring", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DeviceIndex() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DeviceIndex").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:334; TYPE:PF
      Result = If(SubpartId = 1, 1, Owner(SubpartId - 1).DeviceIndex + 1)
      '   END FORMULA; PROP ID:334; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_DeviceIndex", ex.Message)
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
      Result = String.Empty
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
          Public Function Formula_DisplayName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DisplayName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:406; TYPE:PF
      Result = PartNumber
      '   END FORMULA; PROP ID:406; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_DisplayName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DOType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DOType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:571; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:571; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_DOType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ElementName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ElementName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:751; TYPE:PF
      Result = PartNumber
      '   END FORMULA; PROP ID:751; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_ElementName", ex.Message)
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
          Public Function Formula_Indicator_OriginalOrDelta() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Indicator_OriginalOrDelta").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:505; TYPE:PF
      Result = "Original"

If Me.LocationX = 0 AndAlso Me.LocationY = 0 AndAlso Me.LocationZ = 0 Then
	Result = "Delta"
End If
      '   END FORMULA; PROP ID:505; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Indicator_OriginalOrDelta", ex.Message)
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
      Result = Properties("DevicePartNumber").InValidValues
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
          Public Function Formula_LocationX() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LocationX").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:498; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:498; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_LocationX", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LocationY() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LocationY").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:500; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:500; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_LocationY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LocationZ() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LocationZ").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:502; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:502; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_LocationZ", ex.Message)
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
      Result = String.Empty
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
      Result = String.Empty
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
      Result = String.Empty
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
          Public Function Formula_PartShape_DWG() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PartShape_DWG").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:504; TYPE:PF
      Result = Me.PartShape.Replace(".svg",".dwg")
      '   END FORMULA; PROP ID:504; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PartShape_DWG", ex.Message)
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
      Result = String.Empty
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
          Public Function Formula_PointParameter() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PointParameter").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:569; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:569; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PointParameter", ex.Message)
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
      Result = String.Empty
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
      Result = Me.conn_CORA_Info(1).Pole
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
          Public Function Formula_PowerConsumption() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerConsumption").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:713; TYPE:PF
      Result = ValidValues("PowerConsumption").FirstValue
      '   END FORMULA; PROP ID:713; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PowerConsumption", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerConsumptionDB() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerConsumptionDB").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:712; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:712; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PowerConsumptionDB", ex.Message)
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
      Dim _pc As String = PowerConsumption

Result = If(_pc.Length > 0, ValidValues("PowerConsumption").GetDisplayValueByKey(_pc), String.Empty)
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
          Public Function Formula_PowerSupplyDB() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerSupplyDB").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:710; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:710; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PowerSupplyDB", ex.Message)
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
      Result = String.Empty
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
          Public Function Formula_ScaleX() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ScaleX").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:499; TYPE:PF
      Result = 1.0
      '   END FORMULA; PROP ID:499; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_ScaleX", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ScaleY() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ScaleY").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:501; TYPE:PF
      Result = 1.0
      '   END FORMULA; PROP ID:501; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_ScaleY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ScaleZ() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ScaleZ").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:503; TYPE:PF
      Result = 1.0
      '   END FORMULA; PROP ID:503; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_ScaleZ", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SelectedForPowerSupply() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SelectedForPowerSupply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:338; TYPE:PF
      Dim _ckt As Object = If(IsConnected(RootPart.PowerSupplyView(1).SelectedCircuit), RootPart.PowerSupplyView(1).SelectedCircuit(1), Nothing)

Result = _ckt IsNot Nothing AndAlso (_ckt.Tag = AssignedPowerSupply)
      '   END FORMULA; PROP ID:338; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_SelectedForPowerSupply", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SignalRangeCustomizable() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SignalRangeCustomizable").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:568; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:568; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_SignalRangeCustomizable", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SignalRangeImperial() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SignalRangeImperial").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:567; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:567; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_SignalRangeImperial", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SignalRangeMetric() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SignalRangeMetric").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:566; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:566; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_SignalRangeMetric", ex.Message)
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
          Public Function Formula_SymbolImagePath() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SymbolImagePath").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:359; TYPE:PF
      Result = ""

If Me.PartType <> "" Then
'	Dim path = "\\HIC044413\RSShared\HBS\MasterDocs\" & Me.PartType
	Dim path = system.io.path.Combine(g_DocAccess.MasterDocumentsFolder, Me.PartType)
	
	If file.Exists(path & ".svg") Then
		Custom.ConvertSVG(path & ".svg")
		Result = path & ".png"
	End If
End If
      '   END FORMULA; PROP ID:359; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_SymbolImagePath", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Tag() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Tag").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:641; TYPE:PF
      Result = PartNumber & "-" & DeviceIndex
      '   END FORMULA; PROP ID:641; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_Tag", ex.Message)
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
      Result = String.Empty
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
          Public Function Formula_TerminalBlockNumber() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TerminalBlockNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:563; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:563; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_TerminalBlockNumber", ex.Message)
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
          Public Function Formula_WiringStandardDetail() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("WiringStandardDetail").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:565; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:565; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_WiringStandardDetail", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_WiringStandardIndex() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("WiringStandardIndex").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:711; TYPE:PF
      Result = 1
      '   END FORMULA; PROP ID:711; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_WiringStandardIndex", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      Public Function Formula_ApplicationUse_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Classification_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerIndex_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerIndexPreset_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_ControllerPoint_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerPointPreset_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_DefaultWiring_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DeviceIndex_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_DisplayName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DOType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ElementName_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Indicator_OriginalOrDelta_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_LocationX_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LocationY_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LocationZ_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_PartShape_DWG_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_PointParameter_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_PowerConsumption_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerConsumptionDB_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_PowerSupplyDB_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_ScaleX_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ScaleY_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ScaleZ_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedForPowerSupply_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SignalRangeCustomizable_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SignalRangeImperial_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SignalRangeMetric_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Summary_AI_XView_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Summary_DI_XView_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_SymbolImagePath_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Tag_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_TerminalBlockNumber_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_WiringStandardDetail_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_WiringStandardIndex_HIDE_CALCULATED_VALUE() as Boolean
      Return False
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
      Public Function Formula_ApplicationUse_USERCHANGE() as Boolean
      Return True
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
      Public Function Formula_Classification_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerIndex_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerIndexPreset_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerPartNumber_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerPoint_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerPointPreset_USERCHANGE() as Boolean
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
      Public Function Formula_DefaultWiring_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DeviceIndex_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_DisplayName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DOType_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ElementName_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_Indicator_OriginalOrDelta_USERCHANGE() as Boolean
      Return True
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
      Public Function Formula_LocationX_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LocationY_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LocationZ_USERCHANGE() as Boolean
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
      Public Function Formula_PartShape_DWG_USERCHANGE() as Boolean
      Return True
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
      Public Function Formula_PointParameter_USERCHANGE() as Boolean
      Return False
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
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerConsumption_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerConsumptionDB_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_PowerSupplyDB_USERCHANGE() as Boolean
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
      Public Function Formula_ScaleX_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ScaleY_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ScaleZ_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedForPowerSupply_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("SelectedForPowerSupply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:338; TYPE:UC
              Dim _ps As Object = PowerSupply.ToUpper().Trim()

If _ps = "N/A" Then
	Result = False
Else
	Dim _poweredBy As String = AssignedPowerSupply
	Result = (_poweredBy.Length = 0) OrElse (IsConnected(RootPart.PowerSupplyView(1).SelectedCircuit) AndAlso (RootPart.PowerSupplyView(1).SelectedCircuit(1).Tag = _poweredBy))
End If
              '   END FORMULA; PROP ID:338; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_SelectedForPowerSupply_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SignalRangeCustomizable_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SignalRangeImperial_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SignalRangeMetric_USERCHANGE() as Boolean
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
      Public Function Formula_Summary_AI_XView_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_Summary_DI_XView_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_SymbolImagePath_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Tag_USERCHANGE() as Boolean
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
      Public Function Formula_TerminalBlockNumber_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_WiringStandardDetail_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_WiringStandardIndex_USERCHANGE() as Boolean
      Return False
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
      Result = MakeValidValueKeyFromDatabase("[vw_Parts_Table]", "[Part_Number]", "[Display_1]", "WHERE 1 = " & FormatCriteria(1) & " ORDER BY [Part_Number]")
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
      Public Function Formula_PowerConsumption_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerConsumption").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:713; TYPE:VV
      Dim _psDB As String = PowerSupplyDB.Split(";")(0) 'power supply - always the first item in the list from DB
Dim _pcDB As String = PowerConsumptionDB.Split(";")(0) 'power consumption - always the first item in the list from DB
Dim _psByWiringType As String = _psDB.Split(",")(WiringStandardIndex - 1) 'this would get us a '?' delimited list
Dim _pcByWiringType As String = _psDB.Split(",")(WiringStandardIndex - 1) 'this would get us a '?' delimited list

Result = MakeValidKeyValues(_pcByWiringType.Split("?"), _psByWiringType.Split("?"))
      '   END FORMULA; PROP ID:713; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PowerConsumption_ValidValues", ex.Message)
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
      Result = 0
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
      Public Sub Formula_PartType_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PartType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:18; TYPE:WC
      Me.Properties("SymbolImagePath").RevertToCalc
      '   END FORMULA; PROP ID:18; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_PartType_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_SelectedForPowerSupply_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SelectedForPowerSupply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:338; TYPE:WC
      Dim _me As Object = Properties("SelectedForPowerSupply")

If Not _me.UseCalculatedValue Then
	If Value Then
		If IsConnected(RootPart.PowerSupplyView(1).SelectedCircuit) Then
			Properties("AssignedPowerSupply").InputValue = RootPart.PowerSupplyView(1).SelectedCircuit(1).Tag
		End If
	Else
		Properties("AssignedPowerSupply").RevertToCalc()
	End If

	_me.RevertToCalc()
End If
      '   END FORMULA; PROP ID:338; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Device.Formula_SelectedForPowerSupply_WHENCHANGED", ex.Message)
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
      
        Case 17
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "Part_Application" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Part_Classification" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Default_Part_Number" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Default_Part_Qty" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Default_Wiring" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Device_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Do_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Mnemonics" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Part_Description" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Part_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Parameter_Name" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Point_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Pole" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Power_Consumption" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Power_Supply" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Process_Variable" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Signal_Range_Customizable" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Signal_Range_Imperial" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Signal_Range_Metric" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Signal_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Tb_Label" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Tb_Number" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Num_Of_TBs" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Wiring_Standard_Detail" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
                  varPropSpecVal = me.DevicePartNumber
              BuildWhereClause(strWhereClause, "0", "0", "  ", "[Part_Number]", "=", varPropSpecVal, "")
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("Parts_Table"), strWhereClause, leftDelimiter & "" & rightDelimiter, "")
          
        Case 18
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "Sequence_Text" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
                  varPropSpecVal = PartType
              BuildWhereClause(strWhereClause, "0", "0", "  ", "[Part_Type]", "=", varPropSpecVal, "")
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("PartType_Sequence_Table"), strWhereClause, leftDelimiter & "" & rightDelimiter, "")
          
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " Device.GetRecordset", strError)
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

  