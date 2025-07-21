Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: Plant
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

    Public Class [Plant]
    
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

    Private this as Plant = me

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
      Case "Building_"
      Formula_Building_WHENCHANGED
    End Select
    Select Case specName & "_" & context
    
    End Select
    End Sub

    Public Sub OnChanged(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String) Implements RuleStream.IRsPartFormulas.OnChanged
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Select Case specName & "_" & context
    
      Case "BuildingName_"
      Formula_BuildingName_WHENCHANGED(Value, OldValue)
    
      Case "Controller_"
      Formula_Controller_WHENCHANGED(Value, OldValue)
    
      Case "FloorName_"
      Formula_FloorName_WHENCHANGED(Value, OldValue)
    
      Case "button_AddDevice_"
      Formula_button_AddDevice_WHENCHANGED(Value, OldValue)
    
      Case "button_AddPlant_"
      Formula_button_AddPlant_WHENCHANGED(Value, OldValue)
    
    End Select
    End Sub

    Public Function OnChangedStatus(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String)As Boolean Implements RuleStream.IRsPartFormulas.OnChangedStatus
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Dim Status as Boolean = False
    Select Case specName & "_" & context
    
      Case "BuildingName_"
      'Formula_BuildingName_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "Controller_"
      'Formula_Controller_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "FloorName_"
      'Formula_FloorName_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "button_AddDevice_"
      'Formula_button_AddDevice_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "button_AddPlant_"
      'Formula_button_AddPlant_WHENCHANGED(Value, OldValue)
      Status = True
    Case Else
    Status = False
    End Select
    Return Status
    End Function

    #End Region

    #Region " Properties, Subparts, Connections "
    
          Public Property [DevicePartNumber]() As String
      Get
      Return Properties("DevicePartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("DevicePartNumber").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DevicePartNumberList]() As String
      Get
      Return Properties("DevicePartNumberList").Value
      End Get
      Set(ByVal Value As String)
      Properties("DevicePartNumberList").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Filter1]() As String
      Get
      Return Properties("Filter1").Value
      End Get
      Set(ByVal Value As String)
      Properties("Filter1").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Filter1Choices]() As String
      Get
      Return Properties("Filter1Choices").Value
      End Get
      Set(ByVal Value As String)
      Properties("Filter1Choices").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Filter2]() As String
      Get
      Return Properties("Filter2").Value
      End Get
      Set(ByVal Value As String)
      Properties("Filter2").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Filter2Choices]() As String
      Get
      Return Properties("Filter2Choices").Value
      End Get
      Set(ByVal Value As String)
      Properties("Filter2Choices").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Filter3]() As String
      Get
      Return Properties("Filter3").Value
      End Get
      Set(ByVal Value As String)
      Properties("Filter3").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Filter3Choices]() As String
      Get
      Return Properties("Filter3Choices").Value
      End Get
      Set(ByVal Value As String)
      Properties("Filter3Choices").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SearchResults_Column1_Title]() As String
      Get
      Return Properties("SearchResults_Column1_Title").Value
      End Get
      Set(ByVal Value As String)
      Properties("SearchResults_Column1_Title").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SearchResults_Column2_Title]() As String
      Get
      Return Properties("SearchResults_Column2_Title").Value
      End Get
      Set(ByVal Value As String)
      Properties("SearchResults_Column2_Title").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SearchType]() As String
      Get
      Return Properties("SearchType").Value
      End Get
      Set(ByVal Value As String)
      Properties("SearchType").CalculatedValue = Value
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
    
          Public Property [BOMParts]() As String
      Get
      Return Properties("BOMParts").Value
      End Get
      Set(ByVal Value As String)
      Properties("BOMParts").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BuildingName]() As String
      Get
      Return Properties("BuildingName").Value
      End Get
      Set(ByVal Value As String)
      Properties("BuildingName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Controller]() As String
      Get
      Return Properties("Controller").Value
      End Get
      Set(ByVal Value As String)
      Properties("Controller").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerCapacityAO]() As Long
      Get
      Return Properties("ControllerCapacityAO").Value
      End Get
      Set(ByVal Value As Long)
      Properties("ControllerCapacityAO").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerCapacityDI]() As Long
      Get
      Return Properties("ControllerCapacityDI").Value
      End Get
      Set(ByVal Value As Long)
      Properties("ControllerCapacityDI").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerCapacityDO]() As Long
      Get
      Return Properties("ControllerCapacityDO").Value
      End Get
      Set(ByVal Value As Long)
      Properties("ControllerCapacityDO").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerCapacityUI]() As Long
      Get
      Return Properties("ControllerCapacityUI").Value
      End Get
      Set(ByVal Value As Long)
      Properties("ControllerCapacityUI").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerDetail]() As String
      Get
      Return Properties("ControllerDetail").Value
      End Get
      Set(ByVal Value As String)
      Properties("ControllerDetail").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerFamily]() As String
      Get
      Return Properties("ControllerFamily").Value
      End Get
      Set(ByVal Value As String)
      Properties("ControllerFamily").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerPoints]() As String
      Get
      Return Properties("ControllerPoints").Value
      End Get
      Set(ByVal Value As String)
      Properties("ControllerPoints").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerQuantity]() As Long
      Get
      Return Properties("ControllerQuantity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("ControllerQuantity").CalculatedValue = Value
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
    
          Public Property [FacilityDisplayName]() As String
      Get
      Return Properties("FacilityDisplayName").Value
      End Get
      Set(ByVal Value As String)
      Properties("FacilityDisplayName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [FacilityIndex]() As Long
      Get
      Return Properties("FacilityIndex").Value
      End Get
      Set(ByVal Value As Long)
      Properties("FacilityIndex").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [FloorName]() As String
      Get
      Return Properties("FloorName").Value
      End Get
      Set(ByVal Value As String)
      Properties("FloorName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Indentation]() As String
      Get
      Return Properties("Indentation").Value
      End Get
      Set(ByVal Value As String)
      Properties("Indentation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [IndentedDisplayName]() As String
      Get
      Return Properties("IndentedDisplayName").Value
      End Get
      Set(ByVal Value As String)
      Properties("IndentedDisplayName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [IndentLevel]() As Long
      Get
      Return Properties("IndentLevel").Value
      End Get
      Set(ByVal Value As Long)
      Properties("IndentLevel").CalculatedValue = Value
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
    
          Public Property [PlantItemComment]() As String
      Get
      Return Properties("PlantItemComment").Value
      End Get
      Set(ByVal Value As String)
      Properties("PlantItemComment").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PlantItemDescription]() As String
      Get
      Return Properties("PlantItemDescription").Value
      End Get
      Set(ByVal Value As String)
      Properties("PlantItemDescription").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PlantItemLocation]() As String
      Get
      Return Properties("PlantItemLocation").Value
      End Get
      Set(ByVal Value As String)
      Properties("PlantItemLocation").CalculatedValue = Value
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
    
          Public Property [PlantName_Selected]() As String
      Get
      Return Properties("PlantName_Selected").Value
      End Get
      Set(ByVal Value As String)
      Properties("PlantName_Selected").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PlantNameIndented]() As String
      Get
      Return Properties("PlantNameIndented").Value
      End Get
      Set(ByVal Value As String)
      Properties("PlantNameIndented").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PlantType]() As String
      Get
      Return Properties("PlantType").Value
      End Get
      Set(ByVal Value As String)
      Properties("PlantType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerSupplyPick]() As String
      Get
      Return Properties("PowerSupplyPick").Value
      End Get
      Set(ByVal Value As String)
      Properties("PowerSupplyPick").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerSupplySafetyMargin]() As Double
      Get
      Return Properties("PowerSupplySafetyMargin").Value
      End Get
      Set(ByVal Value As Double)
      Properties("PowerSupplySafetyMargin").CalculatedValue = Value
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
    
          Public Property [Search_Default_Library]() As String
      Get
      Return Properties("Search_Default_Library").Value
      End Get
      Set(ByVal Value As String)
      Properties("Search_Default_Library").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Search_Part_Description]() As String
      Get
      Return Properties("Search_Part_Description").Value
      End Get
      Set(ByVal Value As String)
      Properties("Search_Part_Description").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SelectedSearchIndex]() As Long
      Get
      Return Properties("SelectedSearchIndex").Value
      End Get
      Set(ByVal Value As Long)
      Properties("SelectedSearchIndex").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SpareCapacityForControllers]() As String
      Get
      Return Properties("SpareCapacityForControllers").Value
      End Get
      Set(ByVal Value As String)
      Properties("SpareCapacityForControllers").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SpareCapacityForPSSizing]() As String
      Get
      Return Properties("SpareCapacityForPSSizing").Value
      End Get
      Set(ByVal Value As String)
      Properties("SpareCapacityForPSSizing").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SystemName]() As String
      Get
      Return Properties("SystemName").Value
      End Get
      Set(ByVal Value As String)
      Properties("SystemName").CalculatedValue = Value
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
    
          Public Property [button_AddDevice]() As String
      Get
      Return Properties("button_AddDevice").Value
      End Get
      Set(ByVal Value As String)
      Properties("button_AddDevice").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [button_AddPlant]() As String
      Get
      Return Properties("button_AddPlant").Value
      End Get
      Set(ByVal Value As String)
      Properties("button_AddPlant").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PlantNameGroup]() As String
      Get
      Return Properties("PlantNameGroup").Value
      End Get
      Set(ByVal Value As String)
      Properties("PlantNameGroup").CalculatedValue = Value
      End Set
      End Property
    
      Public ReadOnly Property [PartSearchResults]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("PartSearchResults")
      End Get
      End Property
    
      Public ReadOnly Property [Wires]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Wires")
      End Get
      End Property
    
      Public ReadOnly Property [Controllers]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Controllers")
      End Get
      End Property
    
      Public ReadOnly Property [Devices]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Devices")
      End Get
      End Property
    
      Public ReadOnly Property [BOM]() As Rulestream.Kernel.Connection
      Get
      Return Connections("BOM")
      End Get
      End Property
    
      Public ReadOnly Property [AllParts]() As Rulestream.Kernel.Connection
      Get
      Return Connections("AllParts")
      End Get
      End Property
    
      Public ReadOnly Property [Building]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Building")
      End Get
      End Property
    
      Public ReadOnly Property [Floor]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Floor")
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
    InitPart("Plant", <a><![CDATA[Plant]]></a>.Value, 4, "HBS",  "N", "N", True, False, "In Development", "", "", "", "", "",  "GLOBAL\H601421", "07/21/2025 06:49:52")
    AddProperty("61", "DevicePartNumber", <a><![CDATA[Device Part Number]]></a>.Value, "The Search Criteria VV list of Searched for Part_Numbers from the Parts_table that fit the Filter1Choices, Filter2Choices, and Filter3Choices", "String","","Database Lookup","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "4/10/2025 12:13:07 AM")
    AddProperty("267", "DevicePartNumberList", <a><![CDATA[Device Part Number List]]></a>.Value, "This is a comma-delimited list of the DefaultPartNumber VV list", "String","","Database Lookup","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "3/25/2025 6:19:01 AM")
    AddProperty("258", "Filter1", <a><![CDATA[Filter1]]></a>.Value, "Primary Filter choice for Plat Devices", "String","","Database Lookup","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "4/10/2025 8:50:29 PM")
    AddProperty("264", "Filter1Choices", <a><![CDATA[Filter1 Choices]]></a>.Value, "Primary Filter choices for Plant Devices", "String","","Database Lookup","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "4/10/2025 8:49:52 PM")
    AddProperty("259", "Filter2", <a><![CDATA[Filter2]]></a>.Value, "Secondary Filter choice for Plat Devices", "String","","Database Lookup","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "4/10/2025 8:52:55 PM")
    AddProperty("265", "Filter2Choices", <a><![CDATA[Filter2 Choices]]></a>.Value, "Primary Filter choices for Plant Devices", "String","","Database Lookup","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "3/25/2025 3:09:33 AM")
    AddProperty("260", "Filter3", <a><![CDATA[Filter3]]></a>.Value, "Tertiary Filter choice for Plat Devices", "String","","Database Lookup","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "3/25/2025 2:55:17 AM")
    AddProperty("266", "Filter3Choices", <a><![CDATA[Filter3 Choices]]></a>.Value, "Primary Filter choices for Plant Devices", "String","","Database Lookup","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "3/25/2025 3:09:43 AM")
    AddProperty("270", "SearchResults_Column1_Title", <a><![CDATA[Search Results Column1 Title]]></a>.Value, "The title of the first Column of the Search Results Grid", "String","","Database Lookup","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "3/26/2025 10:46:40 PM")
    AddProperty("271", "SearchResults_Column2_Title", <a><![CDATA[Search Results Column2 Title]]></a>.Value, "The title of the @nd Column of the Search Results Grid", "String","","Database Lookup","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "3/26/2025 10:54:05 PM")
    AddProperty("269", "SearchType", <a><![CDATA[Search Type]]></a>.Value, "What type of search, Part or Library?", "String","","Database Lookup","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "4/15/2025 6:18:01 PM")
    AddProperty("60", "ApplicationUse", <a><![CDATA[Application Use]]></a>.Value, "The application use for the device. Used to filter Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("435", "BOMParts", <a><![CDATA[BOM Parts]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("1835", "BuildingName", <a><![CDATA[Building Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/21/2025 6:46:07 AM")
    AddProperty("272", "Controller", <a><![CDATA[Controller]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/19/2025 6:37:51 AM")
    AddProperty("274", "ControllerCapacityAO", <a><![CDATA[Controller Capacity AO]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("276", "ControllerCapacityDI", <a><![CDATA[Controller Capacity DI]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("277", "ControllerCapacityDO", <a><![CDATA[Controller Capacity DO]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("275", "ControllerCapacityUI", <a><![CDATA[Controller Capacity UI]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("602", "ControllerDetail", <a><![CDATA[Controller Detail]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("80", "ControllerFamily", <a><![CDATA[Controller Family]]></a>.Value, "The family for the controller of this Plant.", "String","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("603", "ControllerPoints", <a><![CDATA[Controller Points]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/16/2025 5:15:01 AM")
    AddProperty("81", "ControllerQuantity", <a><![CDATA[Controller Quantity]]></a>.Value, "The number of controllers for this Plant.  Based Doc ABC Page 2", "Long","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\H601421", "6/25/2025 5:01:32 AM")
    AddProperty("428", "DisplayName", <a><![CDATA[Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("1571", "FacilityDisplayName", <a><![CDATA[Facility Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/14/2025 4:14:12 AM")
    AddProperty("1677", "FacilityIndex", <a><![CDATA[Facility Index]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/15/2025 2:30:47 AM")
    AddProperty("585", "FloorName", <a><![CDATA[Floor Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/21/2025 6:45:09 AM")
    AddProperty("189", "Indentation", <a><![CDATA[Indentation]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("198", "IndentedDisplayName", <a><![CDATA[Indented Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("449", "IndentLevel", <a><![CDATA[Indent Level]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("62", "PartType", <a><![CDATA[Part Type]]></a>.Value, "The type of device part. Used to filter the Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("626", "PlantItemComment", <a><![CDATA[Plant Item Comment]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("629", "PlantItemDescription", <a><![CDATA[Plant Item Description]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("624", "PlantItemLocation", <a><![CDATA[Plant Item Location]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("18", "PlantName", <a><![CDATA[Plant Name]]></a>.Value, "The name of the plant.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("547", "PlantName_Selected", <a><![CDATA[PlantName_Selected]]></a>.Value, "This Property is very crucial for drawings to work according to the Plant Name selected.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("190", "PlantNameIndented", <a><![CDATA[Plant Name Indented]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("19", "PlantType", <a><![CDATA[Plant Type]]></a>.Value, "The type of plant.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("352", "PowerSupplyPick", <a><![CDATA[Power Supply Pick]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("365", "PowerSupplySafetyMargin", <a><![CDATA[Power Supply Safety Margin]]></a>.Value, "Percent", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("63", "ProcessVariable", <a><![CDATA[Process Variable]]></a>.Value, "A process variable used to filter the Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("122", "Search_Default_Library", <a><![CDATA[Search_Default_Library]]></a>.Value, "The Master Device Library to Pull  Data From  !!! No Data In System to Demo !!!", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("121", "Search_Part_Description", <a><![CDATA[Search_Part_Description]]></a>.Value, "The application use for the device. Used to filter Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("268", "SelectedSearchIndex", <a><![CDATA[Selected Search Index]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("73", "SpareCapacityForControllers", <a><![CDATA[Spare Capacity for Controllers]]></a>.Value, "The spare capacity of this plant for controllers.", "String","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("71", "SpareCapacityForPSSizing", <a><![CDATA[Spare Capacity for PS Sizing]]></a>.Value, "The spare capacity of this plant for PS sizing.", "String","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("65", "SystemName", <a><![CDATA[System Name]]></a>.Value, "The name of the system.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("4", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/21/2025 6:59:34 PM")
    AddProperty("64", "button_AddDevice", <a><![CDATA[Button - Add Device]]></a>.Value, "Add a Device to the Plant.", "String","","UI Control","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "4/10/2025 2:28:58 AM")
    AddProperty("438", "button_AddPlant", <a><![CDATA[button_AddPlant]]></a>.Value, "Add a Device to the Plant.", "String","","UI Control","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\H599123", "4/25/2025 5:39:34 AM")
    AddProperty("339", "PlantNameGroup", <a><![CDATA[Plant Name Group]]></a>.Value, "The Group Box ame of the plant.", "String","","UI Labels","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "4/1/2025 4:53:31 AM")
    
      AddPropertyExtended(61,"DevicePartNumber", "54", "EXTLABEL", "Label", "Part Number", "GLOBAL\SVRSDevAdmin", "4/10/2025 12:13:07 AM")
    
      AddPropertyExtended(64,"button_AddDevice", "57", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\SVRSDevAdmin", "4/10/2025 2:28:58 AM")
    
      AddPropertyExtended(438,"button_AddPlant", "417", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H599123", "4/25/2025 5:39:34 AM")
    
      AddValidValue("DevicePartNumber")
    
      AddValidValue("Filter1")
    
      AddValidValue("Filter1Choices")
    
      AddValidValue("Filter2")
    
      AddValidValue("Filter2Choices")
    
      AddValidValue("Filter3")
    
      AddValidValue("Filter3Choices")
    
      AddValidValue("SearchType")
    
      AddValidValue("ApplicationUse")
    
      AddValidValue("BOMParts")
    
      AddValidValue("BuildingName")
    
      AddValidValue("Controller")
    
      AddValidValue("ControllerDetail")
    
      AddValidValue("ControllerFamily")
    
      AddValidValue("ControllerPoints")
    
      AddValidValue("ControllerQuantity")
    
      AddValidValue("FloorName")
    
      AddValidValue("PartType")
    
      AddValidValue("PlantType")
    
      AddValidValue("PowerSupplyPick")
    
      AddValidValue("ProcessVariable")
    
      AddValidValue("Search_Default_Library")
    
      oSubpart = AddSubpart(20,"PartSearchResults", <a><![CDATA[Part Search Results]]></a>.Value, "FD", "The PartFamily List of the Filtered Part Search Results", "Database Lookup", 9999, "RuleStream", "GLOBAL\SVRSDevAdmin", "3/26/2025 4:15:40 AM")
      
        oSubpart.AddVPF (20, "PartSearchResult", "Part Search Result")
      
      oSubpart = AddSubpart(21,"Wires", <a><![CDATA[Wires]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oSubpart.AddVPF (21, "Wire", "Wire")
      
      oSubpart = AddSubpart(5,"Controllers", <a><![CDATA[Controllers]]></a>.Value, "FD", "The controllers involved.", "Subparts and Connections", 9999, "RuleStream", "GLOBAL\H601421", "4/9/2025 4:12:39 AM")
      
        oSubpart.AddVPF (6, "Controller", "Controller")
      
      oSubpart = AddSubpart(4,"Devices", <a><![CDATA[Devices]]></a>.Value, "FD", "The devices involved.", "Subparts and Connections", 9999, "RuleStream", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:49:40 AM")
      
        oSubpart.AddVPF (5, "Device", "Device")
      
      oConnection = AddConnection("BOM", <a><![CDATA[BOM]]></a>.Value, "The Collection of Devices and Controllers for this Plant.", "20", "OM", 0, "","BOM Rollup", 9999, "RuleStream", "GLOBAL\SVRSDevAdmin", "4/5/2025 3:24:35 AM")
      
        oConnection.AddVPF(5, "Device")
      
        oConnection.AddVPF(6, "Controller")
      
      oConnection = AddConnection("AllParts", <a><![CDATA[All Parts]]></a>.Value, "", "26", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(5, "Device")
      
        oConnection.AddVPF(6, "Controller")
      
      oConnection = AddConnection("Building", <a><![CDATA[Building]]></a>.Value, "", "46", "OO", 0, "","General", 9999, "", "GLOBAL\H601421", "7/21/2025 6:49:52 AM")
      
        oConnection.AddVPF(45, "Building")
      
      oConnection = AddConnection("Floor", <a><![CDATA[Floor]]></a>.Value, "", "52", "OO", 0, "","General", 9999, "", "GLOBAL\H601421", "7/21/2025 5:44:18 AM")
      
        oConnection.AddVPF(46, "Floor")
      
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
          InitProperty("DevicePartNumber", "54", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "4/10/2025 12:13:07 AM", "", "In Development",  0,77)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DevicePartNumberList", "247", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/25/2025 6:19:01 AM", "", "In Development",  0,613)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Filter1", "239", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "4/10/2025 8:50:29 PM", "", "In Development",  0,566)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Filter1Choices", "244", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "4/10/2025 8:49:52 PM", "", "In Development",  0,589)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Filter2", "240", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "4/10/2025 8:52:55 PM", "", "In Development",  0,567)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Filter2Choices", "245", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/25/2025 3:09:33 AM", "", "In Development",  0,594)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Filter3", "241", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/25/2025 2:51:52 AM", "", "In Development",  0,557)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Filter3Choices", "246", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/25/2025 3:09:43 AM", "", "In Development",  0,592)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SearchResults_Column1_Title", "250", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/26/2025 10:46:40 PM", "", "In Development",  0,628)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SearchResults_Column2_Title", "251", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/26/2025 10:54:05 PM", "", "In Development",  0,633)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SearchType", "249", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "4/15/2025 6:18:01 PM", "", "In Development",  0,1058)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ApplicationUse", "53", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 9:15:58 PM", "", "In Development",  0,76)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BOMParts", "414", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/9/2025 9:54:45 PM", "", "In Development",  0,1003)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BuildingName", "1700", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601421", "7/21/2025 6:46:07 AM", "", "In Development",  0,3491)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Controller", "252", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601421", "7/19/2025 6:37:51 AM", "", "In Development",  0,3401)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerCapacityAO", "254", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/28/2025 5:09:58 AM", "", "In Development",  0,1320)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerCapacityDI", "256", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/28/2025 5:10:19 AM", "", "In Development",  0,1321)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerCapacityDO", "257", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/28/2025 5:10:31 AM", "", "In Development",  0,1322)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerCapacityUI", "255", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/28/2025 5:12:37 AM", "", "In Development",  0,1323)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerDetail", "558", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/28/2025 5:04:08 AM", "", "In Development",  0,1316)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerFamily", "72", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601421", "3/28/2025 3:41:36 AM", "", "In Development",  0,654)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerPoints", "559", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/16/2025 5:15:01 AM", "", "In Development",  0,1318)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerQuantity", "73", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/25/2025 5:01:32 AM", "", "In Development",  0,648)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DisplayName", "407", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/15/2025 2:40:49 AM", "", "In Development",  0,1053)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FacilityDisplayName", "1452", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/14/2025 4:14:12 AM", "", "In Development",  0,2642)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FacilityIndex", "1545", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/15/2025 2:30:47 AM", "", "In Development",  0,2838)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FloorName", "541", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601421", "7/21/2025 6:45:09 AM", "", "In Development",  0,3499)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Indentation", "173", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "3/14/2025 1:39:07 PM", "", "In Development",  0,449)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IndentedDisplayName", "181", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "3/30/2025 5:35:47 AM", "", "In Development",  0,430)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IndentLevel", "428", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/19/2025 4:28:54 AM", "", "In Development",  0,1073)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartType", "55", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/24/2025 12:20:03 PM", "", "In Development",  0,78)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantItemComment", "582", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/5/2025 7:56:19 PM", "", "In Development",  0,1405)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantItemDescription", "585", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/5/2025 9:53:17 PM", "", "In Development",  0,1412)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantItemLocation", "580", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/5/2025 7:55:46 PM", "", "In Development",  0,1403)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantName", "11", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/14/2025 6:51:25 PM", "", "In Development",  0,1032)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantName_Selected", "517", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "4/25/2025 5:23:25 AM", "", "In Development",  0,1275)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantNameIndented", "174", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "3/14/2025 3:46:16 AM", "", "In Development",  0,423)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantType", "12", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/21/2025 2:14:26 AM", "", "In Development",  0,525)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerSupplyPick", "330", "", "", "Y", "","", 1, "-1", 1, "", "N","0",  "GLOBAL\H601421", "4/6/2025 4:39:46 AM", "", "In Development",  0,901)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerSupplySafetyMargin", "343", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/3/2025 9:11:01 PM", "", "In Development",  0,868)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ProcessVariable", "56", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/24/2025 12:21:33 PM", "", "In Development",  0,79)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Search_Default_Library", "112", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/27/2025 12:31:51 AM", "", "In Development",  0,622)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Search_Part_Description", "111", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 6:18:58 PM", "", "In Development",  0,266)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SelectedSearchIndex", "248", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "3/25/2025 6:48:37 PM", "", "In Development",  0,616)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SpareCapacityForControllers", "66", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:38:52 AM", "", "In Development",  0,99)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SpareCapacityForPSSizing", "64", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:38:13 AM", "", "In Development",  0,97)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SystemName", "58", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:51:37 AM", "", "In Development",  0,106)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("button_AddDevice", "57", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "4/10/2025 2:28:58 AM", "", "In Development",  0,80)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("button_AddPlant", "417", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "4/25/2025 5:39:34 AM", "", "In Development",  0,1011)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantNameGroup", "318", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "4/1/2025 4:53:31 AM", "", "In Development",  0,813)
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
          
        InitValidValue("DevicePartNumber_ValidValues", "54", "-1", 1007)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Filter1_ValidValues", "239", "-1", 1025)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Filter1Choices_ValidValues", "244", "-1", 698)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Filter2_ValidValues", "240", "-1", 618)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Filter2Choices_ValidValues", "245", "-1", 599)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Filter3_ValidValues", "241", "-1", 583)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Filter3Choices_ValidValues", "246", "-1", 600)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("SearchType_ValidValues", "249", "-1", 1021)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ApplicationUse_ValidValues", "53", "-1", 189)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BOMParts_ValidValues", "414", "-1", 1004)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BuildingName_ValidValues", "1700", "-1", 3515)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Controller_ValidValues", "252", "-1", 3402)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ControllerDetail_ValidValues", "558", "-1", 1317)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ControllerFamily_ValidValues", "72", "-1", 653)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ControllerPoints_ValidValues", "559", "-1", 2968)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ControllerQuantity_ValidValues", "73", "-1", 1692)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("FloorName_ValidValues", "541", "-1", 3514)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PartType_ValidValues", "55", "-1", 545)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PlantType_ValidValues", "12", "-1", 527)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PowerSupplyPick_ValidValues", "330", "-1", 835)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ProcessVariable_ValidValues", "56", "-1", 546)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Search_Default_Library_ValidValues", "112", "-1", 392)
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
          
        InitSubpart("PartSearchResults", 20, "", "", "Y", 0, "-1", "", "GLOBAL\SVRSDevAdmin", "3/26/2025 4:15:40 AM", "", "In Development", "N",0,43,47)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Wires", 21, "", "", "Y", 0, "-1", "", "GLOBAL\H601421", "5/3/2025 3:27:02 AM", "", "In Development", "N",0,49,153)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Controllers", 5, "", "", "Y", 0, "-1", "", "GLOBAL\H601421", "4/9/2025 4:12:39 AM", "", "In Development", "N",0,10,57)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Devices", 4, "", "", "Y", 0, "-1", "", "GLOBAL\SVRSDevAdmin", "2/21/2025 7:00:47 PM", "", "In Development", "Y",0,8,7)
        
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
          
        InitConnection("BOM", "20", "","", "Y", 0, "-1", "", "GLOBAL\SVRSDevAdmin", "4/5/2025 3:24:35 AM", "", "In Development", "N",37)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("AllParts", "24", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "4/8/2025 6:59:20 PM", "", "In Development", "N",44)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Building", "42", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "7/21/2025 6:49:52 AM", "", "In Development", "Y",189)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Floor", "48", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "7/21/2025 5:44:18 AM", "", "In Development", "Y",191)
        
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
      Public Function Formula_BOM_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:20; TYPE:PF
        Result = Nothing
Dim colController As Rulestream.Kernel.rsCollection

colController = TraverseCollection(Me, "Controller", True)
'Traverse the tree
'	Starting from Me.paret.Parent (Group)
'	Searching for "Controller"
'	Skip Subparts
'	Look through Connections

Dim colDevices = TraverseCollection(Me, "Device", True)

Result = UnionCollections(colDevices, colController)
        'Purpose:       Union two collections.  Combines two collections without regard for the keys.
        '               Assumes their are not identical elements in the two collections
        'Parameters:    col1 - First collection.
        '               col2 - Second collection.
        'Returns:       New unioned collection.
        '   END FORMULA; CON ID:20; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_BOM_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AllParts_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:24; TYPE:PF
        Result = New rsCollection

For Each _obj In Devices
	Result.Add(_obj)
Next

For Each _obj In Controllers
	Result.Add(_obj)
Next
        '   END FORMULA; CON ID:24; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_AllParts_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Building_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:42; TYPE:PF
        Result = Nothing
        '   END FORMULA; CON ID:42; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Building_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Floor_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:48; TYPE:PF
        Result = Nothing
        '   END FORMULA; CON ID:48; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Floor_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
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
      '   BEGIN FORMULA; PROP ID:54; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:54; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_DevicePartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DevicePartNumberList() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DevicePartNumberList").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:247; TYPE:PF
      Result = ""
Dim _Module As String = "Plant.DevicePartNumberList"

Dim _sb As New System.Text.StringBuilder
If (Me.Properties("DevicePartNumber").ValidValues.Count > 0) Then
	For Each _Item As String In Me.Properties("DevicePartNumber").ValidValues.Items
		_sb.Append("" & _Item & "" & ",")
	Next '_Item
	'Don't Trim off the trailing comma
	'_sb.Length = _sb.Length - 1
End If

	Result = _sb.ToString()
 	g_ObjectManager.LogInfo(_Module, String.Format($"Part Number List: <{Result}>"),, True)
      '   END FORMULA; PROP ID:247; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_DevicePartNumberList", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Filter1() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter1").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:239; TYPE:PF
      Result = Me.Properties("Filter1").ValidValues.FirstValue
      '   END FORMULA; PROP ID:239; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Filter1", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Filter1Choices() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter1Choices").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:244; TYPE:PF
      Result = Me.Properties("Filter1Choices").ValidValues.FirstValue
      '   END FORMULA; PROP ID:244; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Filter1Choices", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Filter2() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter2").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:240; TYPE:PF
      Result = Me.Properties("Filter2").ValidValues.FirstValue
      '   END FORMULA; PROP ID:240; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Filter2", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Filter2Choices() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter2Choices").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:245; TYPE:PF
      Result = Me.Properties("Filter2Choices").ValidValues.FirstValue
      '   END FORMULA; PROP ID:245; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Filter2Choices", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Filter3() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter3").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:241; TYPE:PF
      Result = Me.Properties("Filter3").ValidValues.FirstValue
      '   END FORMULA; PROP ID:241; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Filter3", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Filter3Choices() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter3Choices").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:246; TYPE:PF
      Result = Me.Properties("Filter3Choices").ValidValues.FirstValue
      '   END FORMULA; PROP ID:246; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Filter3Choices", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SearchResults_Column1_Title() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SearchResults_Column1_Title").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:250; TYPE:PF
      Result = "Model Tag"
If Me.SearchType = "Search Parts" Then
	Result = "Part Number"
End If
      '   END FORMULA; PROP ID:250; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_SearchResults_Column1_Title", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SearchResults_Column2_Title() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SearchResults_Column2_Title").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:251; TYPE:PF
      Result = "Short Description"
If Me.SearchType = "Search Parts" Then
	Result = "Part Description"
End If
      '   END FORMULA; PROP ID:251; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_SearchResults_Column2_Title", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SearchType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SearchType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:249; TYPE:PF
      Result = Me.Properties("SearchType").ValidValues.FirstValue
      '   END FORMULA; PROP ID:249; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_SearchType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:53; TYPE:PF
      result = ""
'Filter 0
      '   END FORMULA; PROP ID:53; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ApplicationUse", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BOMParts() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BOMParts").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:414; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:414; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_BOMParts", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BuildingName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BuildingName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1700; TYPE:PF
      Result = If(IsConnected(Building), Building(1).BuildingName, String.Empty)
      '   END FORMULA; PROP ID:1700; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_BuildingName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Controller() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Controller").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:252; TYPE:PF
      Result = Parent.Controller
      '   END FORMULA; PROP ID:252; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Controller", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerCapacityAO() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerCapacityAO").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:254; TYPE:PF
      Dim _xPoints As System.Xml.XmlDocument = ValidValues("ControllerPoints")("POINTS")

Result = _xPoints.DocumentElement.SelectNodes("POINT[@Point_Type='AO']").Count
      '   END FORMULA; PROP ID:254; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerCapacityAO", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerCapacityDI() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerCapacityDI").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:256; TYPE:PF
      Dim _xPoints As System.Xml.XmlDocument = ValidValues("ControllerPoints")("POINTS")

Result = _xPoints.DocumentElement.SelectNodes("POINT[@Point_Type='DI']").Count
      '   END FORMULA; PROP ID:256; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerCapacityDI", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerCapacityDO() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerCapacityDO").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:257; TYPE:PF
      Dim _xPoints As System.Xml.XmlDocument = ValidValues("ControllerPoints")("POINTS")

Result = _xPoints.DocumentElement.SelectNodes("POINT[@Point_Type='DO']").Count
      '   END FORMULA; PROP ID:257; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerCapacityDO", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerCapacityUI() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerCapacityUI").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:255; TYPE:PF
      Dim _xPoints As System.Xml.XmlDocument = ValidValues("ControllerPoints")("POINTS")

Result = _xPoints.DocumentElement.SelectNodes("POINT[contains(@Point_Type, 'AI') and contains(@Point_Type, 'DI')]").Count
      '   END FORMULA; PROP ID:255; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerCapacityUI", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerDetail() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerDetail").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:558; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:558; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerDetail", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerFamily() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerFamily").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:72; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:72; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerFamily", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerPoints() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerPoints").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:559; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:559; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerPoints", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerQuantity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerQuantity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:73; TYPE:PF
      Result = ValidValues("ControllerQuantity")("QTY")
      '   END FORMULA; PROP ID:73; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerQuantity", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:407; TYPE:PF
      Result = Parent.DisplayName & "." & PlantName
      '   END FORMULA; PROP ID:407; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_DisplayName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1452; TYPE:PF
      Result = "-			" & PlantName
      '   END FORMULA; PROP ID:1452; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_FacilityDisplayName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_FacilityIndex() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("FacilityIndex").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1545; TYPE:PF
      Result = 9999
      '   END FORMULA; PROP ID:1545; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_FacilityIndex", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_FloorName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("FloorName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:541; TYPE:PF
      Result = If(IsConnected(Floor), Floor(1).FloorName, String.Empty)
      '   END FORMULA; PROP ID:541; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_FloorName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Indentation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Indentation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:173; TYPE:PF
      Result = Parent.Indentation.Replace("-", "-   ")
      '   END FORMULA; PROP ID:173; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Indentation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_IndentedDisplayName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("IndentedDisplayName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:181; TYPE:PF
      Result = PlantNameIndented
      '   END FORMULA; PROP ID:181; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_IndentedDisplayName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_IndentLevel() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("IndentLevel").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:428; TYPE:PF
      Result = Parent.IndentLevel + 1
      '   END FORMULA; PROP ID:428; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_IndentLevel", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:55; TYPE:PF
      result = ""
'Filter 2
      '   END FORMULA; PROP ID:55; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PartType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PlantItemComment() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PlantItemComment").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:582; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:582; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PlantItemComment", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PlantItemDescription() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PlantItemDescription").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:585; TYPE:PF
      Result = "Description for " & PlantName
      '   END FORMULA; PROP ID:585; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PlantItemDescription", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PlantItemLocation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PlantItemLocation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:580; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:580; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PlantItemLocation", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:11; TYPE:PF
      Result = "Plant"
      '   END FORMULA; PROP ID:11; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PlantName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PlantName_Selected() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PlantName_Selected").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:517; TYPE:PF
      'Add Plant Button will pass the selected Plant Name to this property

Return  ""
      '   END FORMULA; PROP ID:517; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PlantName_Selected", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PlantNameIndented() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PlantNameIndented").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:174; TYPE:PF
      Result = Indentation & PlantName
      '   END FORMULA; PROP ID:174; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PlantNameIndented", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PlantType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PlantType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:12; TYPE:PF
      Result = Me.Properties("PlantType").ValidValues.FirstValue
      '   END FORMULA; PROP ID:12; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PlantType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerSupplyPick() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerSupplyPick").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:330; TYPE:PF
      Dim _DependsOn As String = RootPart.CurrentProcessStep
Result = String.Empty
      '   END FORMULA; PROP ID:330; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PowerSupplyPick", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerSupplySafetyMargin() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerSupplySafetyMargin").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:343; TYPE:PF
      Result = 10
      '   END FORMULA; PROP ID:343; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PowerSupplySafetyMargin", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:56; TYPE:PF
      result = ""
'Filter 1
      '   END FORMULA; PROP ID:56; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ProcessVariable", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Search_Default_Library() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Search_Default_Library").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:112; TYPE:PF
      Result = Me.Properties("Search_Default_Library").ValidValues.FirstValue
'Filter 0
      '   END FORMULA; PROP ID:112; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Search_Default_Library", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Search_Part_Description() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Search_Part_Description").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:111; TYPE:PF
      result = ""
'Filter 0
      '   END FORMULA; PROP ID:111; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Search_Part_Description", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SelectedSearchIndex() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SelectedSearchIndex").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:248; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:248; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_SelectedSearchIndex", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SpareCapacityForControllers() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SpareCapacityForControllers").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:66; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:66; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_SpareCapacityForControllers", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SpareCapacityForPSSizing() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SpareCapacityForPSSizing").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:64; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:64; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_SpareCapacityForPSSizing", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SystemName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SystemName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:58; TYPE:PF
      Result = me.Parent.SystemName
'Pull the name from the parent System.
      '   END FORMULA; PROP ID:58; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_SystemName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_button_AddDevice() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_AddDevice").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:57; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:57; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_button_AddDevice", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_button_AddPlant() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_AddPlant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:417; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:417; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_button_AddPlant", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PlantNameGroup() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PlantNameGroup").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:318; TYPE:PF
      Result = "Selected Plant: " & Me.PlantName
      '   END FORMULA; PROP ID:318; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PlantNameGroup", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      Public Function Formula_DevicePartNumberList_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter1_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter1Choices_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter2_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter2Choices_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter3_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter3Choices_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SearchResults_Column1_Title_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SearchResults_Column2_Title_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SearchType_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_BOMParts_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BuildingName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerCapacityAO_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerCapacityDI_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerCapacityDO_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerCapacityUI_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerDetail_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerFamily_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerPoints_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerQuantity_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_FacilityDisplayName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FacilityIndex_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FloorName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Indentation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IndentedDisplayName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IndentLevel_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_PlantItemComment_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantItemDescription_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantItemLocation_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_PlantName_Selected_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantNameIndented_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplyPick_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplySafetyMargin_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Search_Default_Library_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Search_Part_Description_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedSearchIndex_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SpareCapacityForControllers_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SpareCapacityForPSSizing_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SystemName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_AddDevice_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_AddPlant_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantNameGroup_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_DevicePartNumberList_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter1_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter1Choices_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter2_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Filter2").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:240; TYPE:UC
              Result =  Not((Me.Properties("Filter1").Value = "") Or (SearchType =  "Search Library"))
              '   END FORMULA; PROP ID:240; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Filter2_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter2Choices_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter3_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Filter3").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:241; TYPE:UC
              Result = Not(Me.Properties("Filter2").Value = "")
              '   END FORMULA; PROP ID:241; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Filter3_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter3Choices_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SearchResults_Column1_Title_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SearchResults_Column2_Title_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SearchType_USERCHANGE() as Boolean
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
      Public Function Formula_BOMParts_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BuildingName_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerCapacityAO_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerCapacityDI_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerCapacityDO_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerCapacityUI_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerDetail_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerFamily_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerPoints_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerQuantity_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_FacilityDisplayName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FacilityIndex_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FloorName_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Indentation_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IndentedDisplayName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_IndentLevel_USERCHANGE() as Boolean
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
      Public Function Formula_PlantItemComment_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantItemDescription_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantItemLocation_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantName_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantName_Selected_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantNameIndented_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplyPick_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplySafetyMargin_USERCHANGE() as Boolean
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
      Public Function Formula_Search_Default_Library_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Search_Default_Library").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:112; TYPE:UC
              Result = (SearchType = "Search Library")
              '   END FORMULA; PROP ID:112; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Search_Default_Library_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Search_Part_Description_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedSearchIndex_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SpareCapacityForControllers_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SpareCapacityForPSSizing_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SystemName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_AddDevice_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("button_AddDevice").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:57; TYPE:UC
              Result = False

If Me.SearchType = "Search Parts" Then
	Result = True
End If
              '   END FORMULA; PROP ID:57; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_button_AddDevice_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_AddPlant_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("button_AddPlant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:417; TYPE:UC
              Result = (SearchType = "Search Library")
              '   END FORMULA; PROP ID:417; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_button_AddPlant_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantNameGroup_USERCHANGE() as Boolean
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
      '   BEGIN FORMULA; PROP ID:54; TYPE:VV
      Result = Nothing
Dim _searchParts As Boolean = True
Dim _DBTable As String = "[Parts_Table]"
Dim _DBColumn As String = "[Part_Number]"
Dim _Module As String = "Plant.DevicePartNumber.VV"
If SearchType =  "Search Library" Then
	_searchParts = False
	_DBTable = "[Plant_Library_Master]"
	_DBColumn = "[Model_Tag]"
End If
g_ObjectManager.LogInfo(_Module, String.Format($"Entry - SearchType: <{SearchType}>, using _DBTable: <{_DBTable}>, _DBColumn: <{_DBColumn}>. "),, True)

Dim _WhereClause As String = String.Empty
Dim _sb As New System.Text.StringBuilder
If Me.Search_Default_Library.Length > 0

	Dim ColumnName1 As String = ""
	Dim ColumnName2 As String = ""
	Dim ColumnName3 As String = ""
If _searchParts Then
	Select Me.Filter1
		Case "Application Use"
			ColumnName1 = "Part_Application"
		Case "Process Variable"
			ColumnName1 = "Process_Variable"
		Case "Device Type"
			ColumnName1 = "Device_Type"
	'	Case "Description Text"
	'		ColumnName1 = ""
	End Select
Else
	Select Me.Filter1
		Case "Model Category"
			ColumnName1 = "Model_Category"
	End Select
End If

If Not(ColumnName1 = "") Then
	_sb.AppendFormat($" WHERE {ColumnName1} LIKE '{Me.Filter1Choices}'")
End If

	If Not(Me.Filter2 = "") Then
		
		Select Me.Filter2
			Case "Application Use"
				ColumnName2 = "Part_Application"
			Case "Process Variable"
				ColumnName2 = "Process_Variable"
			Case "Device Type"
				ColumnName2 = "Device_Type"
		End Select	

		_sb.AppendFormat($" AND {ColumnName2} LIKE '{Me.Filter2Choices}'")
	End If

		If Not(Me.Filter3 = "") Then
		
		Select Me.Filter3
			Case "Application Use"
				ColumnName3 = "Part_Application"
			Case "Process Variable"
				ColumnName3 = "Process_Variable"
			Case "Device Type"
				ColumnName3 = "Device_Type"
		End Select	

		_sb.AppendFormat($" AND {ColumnName3} LIKE '{Me.Filter3Choices}'")
	End If
 	
	_sb.AppendFormat($" ORDER BY {_DBColumn}")
	_WhereClause = _sb.ToString()
	
 	g_ObjectManager.LogInfo(_Module, String.Format($"Final WHERE Clause: <{_WhereClause}>"),, True)
 
 	Result = MakeValidValuesFromDatabase(_DBTable, _DBColumn, _WhereClause)

	g_ObjectManager.LogInfo(_Module, String.Format($"Result: <{Result}>"),, True)
Else
	g_ObjectManager.LogInfo(_Module, "Me.Search_Default_Library.Length = 0",, True)
	
End If
      '   END FORMULA; PROP ID:54; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_DevicePartNumber_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter1_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter1").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:239; TYPE:VV
      If SearchType = "Search Parts" Then
	'Result = MakeValidValues(Array("Application Use", "Process Variable", "Device Type", "Text"))
	Result = MakeValidValues(Array("Application Use", "Process Variable", "Device Type"))
Else
	Result = MakeValidValues(Array("", "Model Category"))
End If
      '   END FORMULA; PROP ID:239; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Filter1_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter1Choices_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter1Choices").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:244; TYPE:VV
      Dim ColumnName As String = ""
Dim _searchParts As Boolean = True
Dim _Module As String = "Plant.Filter1Choices.VV"
If SearchType =  "Search Library" Then
	_searchParts = False
End If
g_ObjectManager.LogInfo(_Module, String.Format($"Entry - SearchType: <{SearchType}>"),, True)

If _searchParts Then
	Select Me.Filter1
		Case "Application Use"
			ColumnName = "Part_Application"
		Case "Process Variable"
			ColumnName = "Process_Variable"
		Case "Device Type"
			ColumnName = "Device_Type"
	'	Case "Description Text"
	'		ColumnName = ""
	End Select
Else
	Select Me.Filter1
		Case "Model Category"
			ColumnName = "Model_Category"
	End Select
End If

g_ObjectManager.LogInfo(_Module, String.Format($"ColumnName: <{ColumnName}>."),, True)


If ColumnName = "" Then
	Result = MakeValidvalues(Array(""))
Else
	If _searchParts Then
		Result = MakeValidValuesFromDatabase("[Parts_Table]", ColumnName, "", ColumnName)
	Else
		Result = MakeValidValuesFromDatabase("[Plant_Library_Master]", ColumnName, "", ColumnName)
	End If

End If
      '   END FORMULA; PROP ID:244; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Filter1Choices_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter2_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter2").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:240; TYPE:VV
      Dim _Module As String = "Plant.Filter2.VV"
Dim _Logstr As String = "Entry"
g_ObjectManager.LogInfo(_Module, _Logstr,, True)


Dim FilterList As New List(Of String)
FilterList.Add("")
FilterList.Add("Application Use")
FilterList.Add("Process Variable")
FilterList.Add("Device Type")
_Logstr = String.Format($"After FilterList adds, FilterList: <{FilterList.ToString()}>")
g_ObjectManager.LogInfo(_Module, _Logstr,, True)

If Not (Me.Filter1 = "") Then 
	FilterList.Remove(Me.Filter1)
End If
Dim sArray() As String
_Logstr = "Before conversion to sArray"
 	g_ObjectManager.LogInfo(_Module, _Logstr,, True)
sArray = FilterList.ToArray()
Result = MakeValidValues(sArray)
      '   END FORMULA; PROP ID:240; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Filter2_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter2Choices_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter2Choices").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:245; TYPE:VV
      Dim ColumnName As String = ""

Select Me.Filter2
	Case "Application Use"
		ColumnName = "Part_Application"
	Case "Process Variable"
		ColumnName = "Process_Variable"
	Case "Device Type"
		ColumnName = "Device_Type"
End Select

If ColumnName = "" Then
	Result = MakeValidvalues(Array(""))
Else
	Result = MakeValidValuesFromDatabase("[Parts_Table]", ColumnName, "", ColumnName)
End If
      '   END FORMULA; PROP ID:245; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Filter2Choices_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter3_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter3").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:241; TYPE:VV
      Dim FilterList As New List(Of String)
FilterList.Add("")
FilterList.Add("Application Use")
FilterList.Add("Process Variable")
FilterList.Add("Device Type")
If Not (Me.Filter1 = "") Then 
	FilterList.Remove(Me.Filter1)
End If
If Not (Me.Filter2 = "") Then 
	FilterList.Remove(Me.Filter2)
End If

Dim sArray() As String
sArray = FilterList.ToArray()
Result = MakeValidValues(sArray)
      '   END FORMULA; PROP ID:241; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Filter3_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Filter3Choices_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Filter3Choices").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:246; TYPE:VV
      Dim ColumnName As String = ""

Select Me.Filter3
	Case "Application Use"
		ColumnName = "Part_Application"
	Case "Process Variable"
		ColumnName = "Process_Variable"
	Case "Device Type"
		ColumnName = "Device_Type"
End Select

If ColumnName = "" Then
	Result = MakeValidvalues(Array(""))
Else
	Result = MakeValidValuesFromDatabase("[Parts_Table]", ColumnName, "", ColumnName)
End If
      '   END FORMULA; PROP ID:246; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Filter3Choices_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SearchType_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SearchType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:249; TYPE:VV
      If Devices.Quantity = 0 Then
	Result = MakeValidValues(Array("Search Library", "Search Parts"))
Else 'don't allow to add devices from a library if this plant already has devices
	Result = MakeValidValues(Array("Search Parts"))
End If
      '   END FORMULA; PROP ID:249; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_SearchType_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ApplicationUse_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ApplicationUse").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:53; TYPE:VV
      Result = MakeValidValues(Array("Actuator", "Current", "Current","Field", "OSA", "Pressure", "Room"))
      '   END FORMULA; PROP ID:53; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ApplicationUse_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BOMParts_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BOMParts").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:414; TYPE:VV
      Result = New ValidValues
      '   END FORMULA; PROP ID:414; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_BOMParts_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BuildingName_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BuildingName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1700; TYPE:VV
      Result = RootPart.FacilityView(1).ValidValues("BuildingNames")
      '   END FORMULA; PROP ID:1700; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_BuildingName_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Controller").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:252; TYPE:VV
      Result = Parent.ValidValues("Controller")
      '   END FORMULA; PROP ID:252; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Controller_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerDetail_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerDetail").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:558; TYPE:VV
      Dim _sql As String = "SELECT *, '' AS DeviceIndex, '' As DevicePoint FROM CONTROLLER_TERMINAL AS POINT WHERE [Controller_Part_Number] = '" & Controller & "' FOR XML AUTO, ROOT('CONTROLLER')"
Dim _ds As DataSet = g_ComponentData.ExecuteSQL(_sql)
Dim _xDoc As New System.Xml.XmlDocument

If _ds IsNot Nothing AndAlso _ds.Tables.Count > 0 Then
	Dim _xml As String = String.Empty
	For Each _row As DataRow In _ds.Tables(0).Rows
		_xml &= _row.Item(0).ToString()
	Next

	_xDoc.LoadXml(_xml)
Else
	_xDoc.LoadXml("<Controller/>")
End If

Result = New ValidValues
Result.Add("POINTS", _xDoc)
      '   END FORMULA; PROP ID:558; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerDetail_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerFamily_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerFamily").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:72; TYPE:VV
      Result = MakeValidValuesFromDatabase("[Controller]", "[Family]", String.Empty, String.Empty)
      '   END FORMULA; PROP ID:72; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerFamily_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerPoints_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerPoints").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:559; TYPE:VV
      Dim _sql As String = "SELECT *" & _
	", '' AS WireIndex" & _
	", '' AS DeviceIndex" & _
	", '' AS DevicePoint" & _
	", '' AS PointIndex" & _
	", '' AS PointParameter" & _
	", '' AS TBNumber" & _
	", '' AS TBLabel" & _
	", '' AS DefaultWiring" & _
	", '' AS WiringStdDetail" & _
	", '' AS SignalType" & _
	", '' AS SignalRangeMetric" & _
	", '' AS SignalRangeImperial" & _
	", '' AS SignalRangeCustomizable" & _
	", '' AS PowerSupply" & _
	", '' AS PowerConsumption" & _
	" FROM CONTROLLER_TERMINAL AS POINT WHERE [Controller_Part_Number] = '" & Controller & "' FOR XML AUTO, ROOT('CONTROLLER')"

Dim _ds As DataSet = g_ComponentData.ExecuteSQL(_sql)
Dim _xDoc As New System.Xml.XmlDocument
Dim _xml As String = String.Empty

If _ds IsNot Nothing AndAlso _ds.Tables.Count > 0 Then
	For Each _row As DataRow In _ds.Tables(0).Rows
		_xml &= _row.Item(0).ToString()
	Next
End If

If _xml.Length > 0 Then _xDoc.LoadXml(_xml) Else _xDoc.LoadXml("<Controller/>")

Result = New ValidValues
Result.Add("POINTS", _xDoc)
      '   END FORMULA; PROP ID:559; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerPoints_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerQuantity_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerQuantity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:73; TYPE:VV
      Dim _xControllers As New System.Xml.XmlDocument : _xControllers.LoadXml("<Controllers><Devices/></Controllers>")
Dim _xPoints As System.Xml.XmlNode = ValidValues("ControllerPoints")(0).DocumentElement
Dim _xController, _xDevices, _xDevice, _xPoint As System.Xml.XmlNode
Dim _xPointAttributes As System.Xml.XmlAttributeCollection
Dim _devicePoints As String, _controllerIndex As String, _controllerCount As Integer, _controllerPoint As String
Dim _deviceControllerIndex(), _deviceControllerPoint() As String
Dim _pointIndex, _wireIndex As Integer
Dim _xPath As String

'loop through devices that have already been assigned controller points and flag those controller points as occupied
For Each _device As Object In Devices
	_devicePoints = _device.PointType.Trim()

	If _devicePoints.Length > 0 Then
		_deviceControllerIndex = _device.ControllerIndexPreset.Split(";")
		_deviceControllerPoint = _device.ControllerPointPreset.Split(";")
		_pointIndex = 0 'reset for a new device
		For Each _devicePointType As String In _devicePoints.Split(";")
			_devicePointType = _devicePointType.Trim()
			'if this controller doesn't have this given Point Type, so move on to the next Point Type
			If _devicePointType.Length > 0 AndAlso _xPoints.SelectNodes("POINT[contains(@Point_Type,'" & _devicePointType & "')]").Count > 0 Then
				If _deviceControllerIndex.Length >= _pointIndex + 1 AndAlso _deviceControllerIndex(_pointIndex).Length > 0 _
					AndAlso _deviceControllerPoint.Length >= _pointIndex + 1 AndAlso _deviceControllerPoint(_pointIndex).Length > 0 Then 'if controller point already assigned
					_controllerIndex = _deviceControllerIndex(_pointIndex)
					_controllerPoint = _deviceControllerPoint(_pointIndex)

					_xController = _xControllers.DocumentElement.SelectSingleNode("CONTROLLER[@Index='" & _controllerIndex & "']")

					If _xController Is Nothing Then
						_controllerCount += 1
						_xController = _xControllers.DocumentElement.AppendChild(_xControllers.ImportNode(_xPoints, True))
						_xController.Attributes.Append(_xControllers.CreateAttribute("Index")).Value = _controllerIndex
					End If

					'the following search MUST yield a node
					_xPoint = _xController.SelectSingleNode("POINT[@Point_Number='" & _controllerPoint & "']")
					Debug.Assert(_xPoint IsNot Nothing, "Point Number " & _controllerPoint & " Not Found On Controller " & Controller)

					_wireIndex += 1
					_xPoint.Attributes("WireIndex").Value = _wireIndex
					_xPoint.Attributes("DeviceIndex").Value = _device.DeviceIndex
					_xPoint.Attributes("DevicePoint").Value = _devicePointType
					_xPoint.Attributes("PointIndex").Value = _pointIndex
				End If
			End If

			_pointIndex += 1
		Next
	End If
Next

'loop though devices again to find device points that have not been assigned to a controller point
Dim _pointParameter, _tbNumber, _tbLabel, _defaultWiring, _wiringStdDetail As String()
Dim _signalType, _signalRangeMetric, _signalRangeImperial, _signalRangeCustomizable, _powerSupply, _powerConsumption As String()

_xDevices = _xControllers.DocumentElement.SelectSingleNode("Devices")
For Each _device As Object In Devices
	_devicePoints = _device.PointType.Trim()

	If _devicePoints.Length > 0 Then
		_pointParameter = _device.PointParameter.Split(";")
		_tbNumber = _device.TerminalBlockNumber.Split(";")
		_tbLabel = _device.TerminalBlockLabel.Split(";")
		_defaultWiring = _device.DefaultWiring.Split(";")
		_wiringStdDetail = _device.WiringStandardDetail.Split(";")
		_signalType = _device.SignalType.Split(";")
		_signalRangeMetric = _device.SignalRangeMetric.Split(";")
		_signalRangeImperial = _device.SignalRangeImperial.Split(";")
		_signalRangeCustomizable = _device.SignalRangeCustomizable.Split(";")
		_powerSupply = _device.PowerSupplyDB.Split(";")
		_powerConsumption = _device.PowerConsumptionDB.Split(";")

		_deviceControllerIndex = _device.ControllerIndexPreset.Split(";")
		_deviceControllerPoint = _device.ControllerPointPreset.Split(";")
		_pointIndex = 0 'reset for a new device
		For Each _devicePointType As String In _devicePoints.Split(";")
			_devicePointType = _devicePointType.Trim() 'this could be AI, AO, DI or DO
			'if this controller doesn't have this given Point Type, so move on to the next Point Type
			If _devicePointType.Length > 0 AndAlso _xPoints.SelectNodes("POINT[contains(@Point_Type,'" & _devicePointType & "')]").Count > 0 Then
				If (_deviceControllerIndex.Length < _pointIndex + 1 OrElse _deviceControllerIndex(_pointIndex).Length = 0) _
					AndAlso (_deviceControllerPoint.Length < _pointIndex + 1 OrElse _deviceControllerPoint(_pointIndex).Length = 0) Then 'if controller point not already assigned
					_xPath = "CONTROLLER/POINT[@DevicePoint='' and contains(@Point_Type, '" & _devicePointType & "')]"
					_xPoint = _xControllers.DocumentElement.SelectSingleNode(_xPath)

					'if we do not find a point on any controllers that we have, add a new controller
					If _xPoint Is Nothing Then
						_controllerCount += 1
						_xController = _xControllers.DocumentElement.AppendChild(_xControllers.ImportNode(_xPoints, True))
						_xController.Attributes.Append(_xControllers.CreateAttribute("Index")).Value = _controllerCount

						'since we added a new controller, we MUST find an empty point to accomodate this device point
						_xPoint = _xControllers.DocumentElement.SelectSingleNode(_xPath)
					End If

					If _deviceControllerIndex.Length < _pointIndex + 1 Then ReDim Preserve _deviceControllerIndex(_pointIndex)
					If _deviceControllerPoint.Length < _pointIndex + 1 Then ReDim Preserve _deviceControllerPoint(_pointIndex)
					_deviceControllerIndex(_pointIndex) = _controllerCount
					_deviceControllerPoint(_pointIndex) = _xPoint.Attributes("Point_Number").Value

					_wireIndex += 1
					_xPoint.Attributes("WireIndex").Value = _wireIndex
					_xPoint.Attributes("DeviceIndex").Value = _device.DeviceIndex
					_xPoint.Attributes("DevicePoint").Value = _devicePointType
					_xPoint.Attributes("PointIndex").Value = _pointIndex
				Else 'this device point already has been assigned to a controller point, let's find that controller point
					_controllerIndex = _deviceControllerIndex(_pointIndex)
					_controllerPoint = _deviceControllerPoint(_pointIndex)

					'the following search MUST yield a node
					_xPoint = _xControllers.DocumentElement.SelectSingleNode("CONTROLLER[@Index='" & _controllerIndex & "']/POINT[@Point_Number='" & _controllerPoint & "']")
					Debug.Assert(_xPoint IsNot Nothing, "Device Point Assigned to a Non-Existent Controller Point")
				End If

				'at this point, we should have a reference to a POINT node from the above if-then-else block
				'we can parse the other attributes for this point from device properties
				_xPointAttributes = _xPoint.Attributes
				_xPointAttributes("PointParameter").Value = If(_pointParameter.Length >= _pointIndex + 1, _pointParameter(_pointIndex), _pointParameter(0))
				_xPointAttributes("TBNumber").Value = If(_tbNumber.Length >= _pointIndex + 1, _tbNumber(_pointIndex), _tbNumber(0))
				_xPointAttributes("TBLabel").Value = If(_tbLabel.Length >= _pointIndex + 1, _tbLabel(_pointIndex), _tbLabel(0))
				_xPointAttributes("DefaultWiring").Value = If(_defaultWiring.Length >= _pointIndex + 1, _defaultWiring(_pointIndex), _defaultWiring(0))
				_xPointAttributes("WiringStdDetail").Value = If(_wiringStdDetail.Length >= _pointIndex + 1, _wiringStdDetail(_pointIndex), _wiringStdDetail(0))
				_xPointAttributes("SignalType").Value = If(_signalType.Length >= _pointIndex + 1, _signalType(_pointIndex), _signalType(0))
				_xPointAttributes("SignalRangeMetric").Value = If(_signalRangeMetric.Length >= _pointIndex + 1, _signalRangeMetric(_pointIndex), _signalRangeMetric(0))
				_xPointAttributes("SignalRangeImperial").Value = If(_signalRangeImperial.Length >= _pointIndex + 1, _signalRangeImperial(_pointIndex), _signalRangeImperial(0))
				_xPointAttributes("SignalRangeCustomizable").Value = If(_signalRangeCustomizable.Length >= _pointIndex + 1, _signalRangeCustomizable(_pointIndex), _signalRangeCustomizable(0))
				_xPointAttributes("PowerSupply").Value = If(_powerSupply.Length >= _pointIndex + 1, _powerSupply(_pointIndex), _powerSupply(0))
				_xPointAttributes("PowerConsumption").Value = If(_powerConsumption.Length >= _pointIndex + 1, _powerConsumption(_pointIndex), _powerConsumption(0))
			End If

			_pointIndex += 1
		Next 'devicepoint

		_xDevice = _xDevices.AppendChild(_xControllers.CreateElement("Device"))
		_xDevice.Attributes.Append(_xControllers.CreateAttribute("DeviceIndex")).Value = _device.DeviceIndex
		_xDevice.Attributes.Append(_xControllers.CreateAttribute("ControllerIndex")).Value = String.Join(";", _deviceControllerIndex)
		_xDevice.Attributes.Append(_xControllers.CreateAttribute("ControllerPoint")).Value = String.Join(";", _deviceControllerPoint)
	End If
Next 'device

Result = New ValidValues
Result.Add("QTY", _controllerCount)
Result.Add("XML", _xControllers)
Return Result
      '   END FORMULA; PROP ID:73; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerQuantity_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FloorName_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("FloorName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:541; TYPE:VV
      Result = If(IsConnected(Building), Building(1).ValidValues("FloorNames"), Nothing)
      '   END FORMULA; PROP ID:541; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_FloorName_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartType_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PartType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:55; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[Parts_Table]", "[Device_Type]", "[Device_Type]", "WHERE 1 = 1 ORDER BY [Device_Type]")
      '   END FORMULA; PROP ID:55; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PartType_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantType_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PlantType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:12; TYPE:VV
      Result = MakeValidValuesFromExcel("Plant_Type_VV.xlsx",False)
      '   END FORMULA; PROP ID:12; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PlantType_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplyPick_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerSupplyPick").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:330; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[Power_Supply_Vest]", "[Part_Number]", "[Part_Number] + '-' + [Part_Description]", String.Empty)
Result.Add(String.Empty, String.Empty)
      '   END FORMULA; PROP ID:330; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PowerSupplyPick_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ProcessVariable_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ProcessVariable").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:56; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[Parts_Table]", "[Process_Variable]", "[Process_Variable]", "WHERE 1 = 1 ORDER BY [Process_Variable]")
      '   END FORMULA; PROP ID:56; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ProcessVariable_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Search_Default_Library_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Search_Default_Library").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:112; TYPE:VV
      Result = MakeValidValues(Array("Library 1", "Library 2", "Library 3","Microsoft-Like Library"))
      '   END FORMULA; PROP ID:112; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Search_Default_Library_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartSearchResults_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:20; TYPE:PN
      
      '   END FORMULA; SUB ID:20; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PartSearchResults_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartSearchResults_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PartSearchResults").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:20; TYPE:QF
      Dim _Module As String = "Plant.PartSearchResults.VV"
g_ObjectManager.LogInfo(_Module, String.Format($"Entry"),, True)

Dim _ToString = Me.Properties("DevicePartNumber").ValidValues.ToString
g_ObjectManager.LogInfo(_Module, String.Format($"DevicePartNumber.VV.ToString: <{_ToString}>"),, True)

Result = Me.Properties("DevicePartNumber").ValidValues.Count
      '   END FORMULA; SUB ID:20; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PartSearchResults_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartSearchResults_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PartSearchResults").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:20; TYPE:OP
      result = "PartSearchResult"
      '   END FORMULA; SUB ID:20; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PartSearchResults_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Wires_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:21; TYPE:PN
      
      '   END FORMULA; SUB ID:21; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Wires_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Wires_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Wires").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:21; TYPE:QF
      If ControllerQuantity > 0 Then
	Dim _xControllers As System.Xml.XmlDocument = ValidValues("ControllerQuantity")("XML")

	Result = _xControllers.DocumentElement.SelectNodes("CONTROLLER/POINT[@WireIndex!='']").Count
End If
      '   END FORMULA; SUB ID:21; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Wires_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Wires_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Wires").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:21; TYPE:OP
      result = "Wire"
      '   END FORMULA; SUB ID:21; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Wires_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controllers_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:5; TYPE:PN
      
      '   END FORMULA; SUB ID:5; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Controllers_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controllers_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Controllers").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:5; TYPE:QF
      Result = ControllerQuantity
      '   END FORMULA; SUB ID:5; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Controllers_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controllers_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Controllers").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:5; TYPE:OP
      result = "Controller"
      '   END FORMULA; SUB ID:5; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Controllers_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Devices_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:4; TYPE:PN
      
      '   END FORMULA; SUB ID:4; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Devices_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Devices_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Devices").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:4; TYPE:QF
      Result = 0
      '   END FORMULA; SUB ID:4; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Devices_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Devices_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Devices").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:4; TYPE:OP
      result = "Device"
      '   END FORMULA; SUB ID:4; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Devices_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_BuildingName_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BuildingName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1700; TYPE:WC
      Dim _me As Object = Properties("BuildingName")

If Not _me.UseCalculatedValue Then
	Dim _buildingName As String = Value
	
	For Each _building As Object In RootPart.FacilityView(1).Buildings
		If _building.BuildingName = _buildingName Then Building.Connect(_building) : Exit For
	Next

	_me.RevertToCalc()
End If
      '   END FORMULA; PROP ID:1700; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_BuildingName_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_Controller_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Controller").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:252; TYPE:WC
      Dim _newController As String = Value
Dim _oldController As String = OldValue
Dim _controllerName As String

For Each _controller As Object In RootPart.ControllerView(1).Controllers
	_controllerName = _controller.ControllerName
	If _controllerName = _oldController Then
		_controller.Plants.DisConnect(Me)
	ElseIf _controllerName = _newController Then
		_controller.Plants.Connect(Me)
	End If
Next
      '   END FORMULA; PROP ID:252; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Controller_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_FloorName_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("FloorName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:541; TYPE:WC
      Dim _me As Object = Properties("FloorName")

If Not _me.UseCalculatedValue Then
	Dim _floorName As String = Value

	For Each _floor As Object In Building(1).Floors
		If _floor.FloorName = _floorName Then Floor.Connect(_floor) : Exit For
	Next

	_me.RevertToCalc()
End If
      '   END FORMULA; PROP ID:541; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_FloorName_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_button_AddDevice_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_AddDevice").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:57; TYPE:WC
      Dim _searchIndex As Integer = SelectedSearchIndex

If _searchIndex > 0 Then
	Dim _searchDevice As Object = PartSearchResults(_searchIndex)
	Dim _devicePartNumber As String = _searchDevice.SearchPartNumber

	Dim _device As Object = Subparts("Devices").AddPart("Device")
	'Add a new Part and set a local variable to point to it.

	_device.Properties("PartNumber").InputValue = _devicePartNumber
	'Set the Part Number
End If
      '   END FORMULA; PROP ID:57; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_button_AddDevice_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_button_AddPlant_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_AddPlant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:417; TYPE:WC
      Dim _searchIndex As Integer = SelectedSearchIndex
Dim _listOfPartNumbers As String = String.Empty
Dim _module As String = "Plant.button_AddPlant()"
Dim _logstr As String = String.Empty
Dim _dict As New Dictionary(Of String, String)
Dim _newDevice As Object
Dim _deviceQty As Integer

If _searchIndex > 0 Then
	Dim _searchDevice As Object = PartSearchResults(_searchIndex)
	Dim _devicePartNumber As String = _searchDevice.SearchPartNumber
	
	Me.Properties("PlantName_Selected").InputValue = _devicePartNumber
	
	If _devicePartNumber = "AHU-CV1" OrElse _devicePartNumber = "AHU-CV2" Then
		RootPart.Properties("EnableDrawings").InputValue = True
	End If
	
	_dict = get_ComponentPartsList(_devicePartNumber)

	If _dict.Count > 0 Then
		Dim _sp As Subpart = Subparts("Devices")

		For Each _partNumber As String In _dict.Keys
			_deviceQty = _dict.Item(_partNumber)

			For _index As Integer = 1 To _deviceQty
				_newDevice = _sp.AddPart("Device")
				_newDevice.Properties("PartNumber").InputValue = _partNumber
			Next
		Next
	End If
End If
      '   END FORMULA; PROP ID:417; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_button_AddPlant_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_Building_WHENCHANGED()
      
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; CON ID:42; TYPE:WC
      If IsConnected(Floor) Then Floor.DisConnect(Floor(1))
      '   END FORMULA; CON ID:42; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Building_WHENCHANGED", ex.Message)
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

  