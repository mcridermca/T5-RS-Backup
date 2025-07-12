Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: HBSSystem
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

    Public Class [HBSSystem]
    
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

    Private this as HBSSystem = me

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
    
      Case "PastePlant_"
      Formula_PastePlant_WHENCHANGED(Value, OldValue)
    
    End Select
    End Sub

    Public Function OnChangedStatus(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String)As Boolean Implements RuleStream.IRsPartFormulas.OnChangedStatus
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Dim Status as Boolean = False
    Select Case specName & "_" & context
    
      Case "PastePlant_"
      'Formula_PastePlant_WHENCHANGED(Value, OldValue)
      Status = True
    Case Else
    Status = False
    End Select
    Return Status
    End Function

    #End Region

    #Region " Properties, Subparts, Connections "
    
          Public Property [BuildingName]() As String
      Get
      Return Properties("BuildingName").Value
      End Get
      Set(ByVal Value As String)
      Properties("BuildingName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CanAddChild]() As Boolean
      Get
      Return Properties("CanAddChild").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("CanAddChild").CalculatedValue = Value
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
    
          Public Property [ElementName]() As String
      Get
      Return Properties("ElementName").Value
      End Get
      Set(ByVal Value As String)
      Properties("ElementName").CalculatedValue = Value
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
    
          Public Property [PastePlant]() As String
      Get
      Return Properties("PastePlant").Value
      End Get
      Set(ByVal Value As String)
      Properties("PastePlant").CalculatedValue = Value
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
    
          Public Property [SafetyMargin]() As Double
      Get
      Return Properties("SafetyMargin").Value
      End Get
      Set(ByVal Value As Double)
      Properties("SafetyMargin").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Selected]() As Boolean
      Get
      Return Properties("Selected").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Selected").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SelectedTransformerIndex]() As Long
      Get
      Return Properties("SelectedTransformerIndex").Value
      End Get
      Set(ByVal Value As Long)
      Properties("SelectedTransformerIndex").CalculatedValue = Value
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
    
          Public Property [SystemNameIndented]() As String
      Get
      Return Properties("SystemNameIndented").Value
      End Get
      Set(ByVal Value As String)
      Properties("SystemNameIndented").CalculatedValue = Value
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
    
          Public Property [SystemType]() As String
      Get
      Return Properties("SystemType").Value
      End Get
      Set(ByVal Value As String)
      Properties("SystemType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SystemUserDefinedName]() As String
      Get
      Return Properties("SystemUserDefinedName").Value
      End Get
      Set(ByVal Value As String)
      Properties("SystemUserDefinedName").CalculatedValue = Value
      End Set
      End Property
    
      Public ReadOnly Property [Plants]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Plants")
      End Get
      End Property
    
      Public ReadOnly Property [AllControllers]() As Rulestream.Kernel.Connection
      Get
      Return Connections("AllControllers")
      End Get
      End Property
    
      Public ReadOnly Property [AllParts]() As Rulestream.Kernel.Connection
      Get
      Return Connections("AllParts")
      End Get
      End Property
    
      Public ReadOnly Property [AllPlants]() As Rulestream.Kernel.Connection
      Get
      Return Connections("AllPlants")
      End Get
      End Property
    
      Public ReadOnly Property [Building]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Building")
      End Get
      End Property
    
      Public ReadOnly Property [Group]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Group")
      End Get
      End Property
    
      Public ReadOnly Property [ParentItem]() As Rulestream.Kernel.Connection
      Get
      Return Connections("ParentItem")
      End Get
      End Property
    
      Public ReadOnly Property [PlantViewNodes]() As Rulestream.Kernel.Connection
      Get
      Return Connections("PlantViewNodes")
      End Get
      End Property
    
      Public ReadOnly Property [PowerSupplies]() As Rulestream.Kernel.Connection
      Get
      Return Connections("PowerSupplies")
      End Get
      End Property
    
      Public ReadOnly Property [Systems]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Systems")
      End Get
      End Property
    
      Public ReadOnly Property [Transformers]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Transformers")
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
    InitPart("HBSSystem", <a><![CDATA[HBS System]]></a>.Value, 17, "HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601421", "07/05/2025 03:58:46")
    AddProperty("586", "BuildingName", <a><![CDATA[Building Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("446", "CanAddChild", <a><![CDATA[Can Add Child]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("429", "DisplayName", <a><![CDATA[Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("806", "ElementName", <a><![CDATA[Element Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/25/2025 8:38:13 PM")
    AddProperty("192", "Indentation", <a><![CDATA[Indentation]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("197", "IndentedDisplayName", <a><![CDATA[Indented Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("445", "IndentLevel", <a><![CDATA[Indent Level]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("371", "PastePlant", <a><![CDATA[Paste Plant]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("625", "PlantItemComment", <a><![CDATA[Plant Item Comment]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("628", "PlantItemDescription", <a><![CDATA[Plant Item Description]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("623", "PlantItemLocation", <a><![CDATA[Plant Item Location]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("1268", "SafetyMargin", <a><![CDATA[Safety Margin]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/1/2025 3:11:47 AM")
    AddProperty("447", "Selected", <a><![CDATA[Selected]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("774", "SelectedTransformerIndex", <a><![CDATA[Selected Transformer Index]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/24/2025 10:19:52 PM")
    AddProperty("194", "SystemName", <a><![CDATA[System Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("195", "SystemNameIndented", <a><![CDATA[System Name Indented]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("191", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601421", "3/14/2025 4:04:14 AM")
    AddProperty("346", "SystemType", <a><![CDATA[System Type]]></a>.Value, "The System Type for this System.", "String","","UI Inputs","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "4/2/2025 4:22:22 PM")
    AddProperty("345", "SystemUserDefinedName", <a><![CDATA[System User Defined Name]]></a>.Value, "The User Defined System Name for this System.", "String","","UI Inputs","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "4/2/2025 4:20:46 PM")
    
      AddPropertyExtended(371,"PastePlant", "349", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "4/6/2025 3:15:45 AM")
    
      AddValidValue("BuildingName")
    
      oSubpart = AddSubpart(16,"Plants", <a><![CDATA[Plants]]></a>.Value, "FD", "", "Subparts and Connections", 9999, "", "GLOBAL\H601421", "4/14/2025 6:50:17 PM")
      
        oSubpart.AddVPF (4, "Plant", "Plant")
      
      oConnection = AddConnection("AllControllers", <a><![CDATA[All Controllers]]></a>.Value, "", "59", "OM", 0, "","General", 9999, "", "GLOBAL\H601421", "6/26/2025 3:18:43 AM")
      
        oConnection.AddVPF(6, "Controller")
      
      oConnection = AddConnection("AllParts", <a><![CDATA[All Parts]]></a>.Value, "", "60", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(5, "Device")
      
        oConnection.AddVPF(6, "Controller")
      
      oConnection = AddConnection("AllPlants", <a><![CDATA[All Plants]]></a>.Value, "", "36", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(4, "Plant")
      
      oConnection = AddConnection("Building", <a><![CDATA[Building]]></a>.Value, "", "47", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(45, "Building")
      
      oConnection = AddConnection("Group", <a><![CDATA[Group]]></a>.Value, "", "33", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(13, "Group")
      
      oConnection = AddConnection("ParentItem", <a><![CDATA[Parent Item]]></a>.Value, "", "31", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(13, "Group")
      
        oConnection.AddVPF(17, "HBSSystem")
      
      oConnection = AddConnection("PlantViewNodes", <a><![CDATA[Plant View Nodes]]></a>.Value, "", "74", "OO", 0, "","General", 9999, "", "GLOBAL\H601421", "7/5/2025 3:58:46 AM")
      
        oConnection.AddVPF(4, "Plant")
      
      oConnection = AddConnection("PowerSupplies", <a><![CDATA[Power Supplies]]></a>.Value, "", "57", "OM", 0, "","General", 9999, "", "GLOBAL\H601421", "6/23/2025 9:20:22 PM")
      
        oConnection.AddVPF(22, "PowerSupply")
      
      oConnection = AddConnection("Systems", <a><![CDATA[Systems]]></a>.Value, "", "32", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(17, "HBSSystem")
      
      oConnection = AddConnection("Transformers", <a><![CDATA[Transformers]]></a>.Value, "", "64", "OM", 0, "","General", 9999, "", "GLOBAL\H601421", "6/24/2025 1:08:35 AM")
      
        oConnection.AddVPF(22, "PowerSupply")
      
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
          InitProperty("BuildingName", "542", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601421", "4/25/2025 9:16:18 PM", "", "In Development",  0,1282)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CanAddChild", "425", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/19/2025 3:07:32 AM", "", "In Development",  0,1065)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DisplayName", "408", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/15/2025 2:20:27 AM", "", "In Development",  0,1052)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ElementName", "746", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/25/2025 8:38:13 PM", "", "In Development",  0,1707)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Indentation", "175", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/19/2025 4:10:16 AM", "", "In Development",  0,1069)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IndentedDisplayName", "180", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "3/30/2025 5:35:31 AM", "", "In Development",  0,429)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IndentLevel", "424", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/7/2025 4:24:14 AM", "", "In Development",  1,1506)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PastePlant", "349", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/6/2025 3:15:45 AM", "", "In Development",  0,885)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantItemComment", "581", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/5/2025 7:56:12 PM", "", "In Development",  0,1404)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantItemDescription", "584", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/5/2025 9:52:53 PM", "", "In Development",  0,1411)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantItemLocation", "579", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/5/2025 7:55:27 PM", "", "In Development",  0,1402)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SafetyMargin", "1170", "5", "100", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601421", "7/1/2025 3:11:47 AM", "", "In Development",  0,2201)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Selected", "426", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/7/2025 4:06:39 PM", "", "In Development",  0,1511)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SelectedTransformerIndex", "718", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/24/2025 10:19:52 PM", "", "In Development",  0,1661)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SystemName", "177", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/14/2025 6:53:01 PM", "", "In Development",  0,1033)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SystemNameIndented", "178", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "3/14/2025 4:19:05 AM", "", "In Development",  0,427)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SystemType", "325", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "4/2/2025 4:21:27 PM", "", "In Development",  0,821)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SystemUserDefinedName", "324", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "4/2/2025 4:20:46 PM", "", "In Development",  0,820)
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
          
        InitValidValue("BuildingName_ValidValues", "542", "-1", 1297)
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
          
        InitSubpart("Plants", 16, "", "", "Y", 0, "-1", "", "GLOBAL\H601421", "4/14/2025 6:50:17 PM", "", "In Development", "Y",0,34,59)
        
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
          
        InitConnection("AllControllers", "53", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "6/26/2025 3:18:43 AM", "", "In Development", "N",113)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("AllParts", "54", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "6/18/2025 3:53:08 PM", "", "In Development", "N",99)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("AllPlants", "33", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "4/15/2025 4:46:55 AM", "", "In Development", "N",62)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Building", "43", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "4/25/2025 5:59:05 PM", "", "In Development", "N",75)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Group", "30", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "4/20/2025 3:55:58 AM", "", "In Development", "N",71)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("ParentItem", "28", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "4/20/2025 3:50:45 AM", "", "In Development", "N",70)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("PlantViewNodes", "65", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "7/5/2025 3:58:46 AM", "", "In Development", "N",129)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("PowerSupplies", "52", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "6/23/2025 9:20:22 PM", "", "In Development", "N",106)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Systems", "29", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "4/15/2025 1:01:59 AM", "", "In Development", "N",51)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Transformers", "58", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "6/24/2025 1:08:35 AM", "", "In Development", "N",107)
        
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
      Public Function Formula_AllControllers_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:53; TYPE:PF
        Result = New rsCollection

For Each _plant As Object In AllPlants
	For Each _co As Object In _plant.Controllers
		Result.Add(_co)
	Next
Next
        '   END FORMULA; CON ID:53; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_AllControllers_PARTS", ex.Message)
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
        '   BEGIN FORMULA; CON ID:54; TYPE:PF
        Result = New rsCollection

For Each _plant As Object In AllPlants
	For Each _device As Object In _plant.Devices
		Result.Add(_device)
	Next
Next

For Each _co As Object In AllControllers
	Result.Add(_co)
Next
        '   END FORMULA; CON ID:54; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_AllParts_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AllPlants_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:33; TYPE:PF
        Result = New rsCollection

CollectPlants(Result, Me)
        '   END FORMULA; CON ID:33; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_AllPlants_PARTS", ex.Message)
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
        '   BEGIN FORMULA; CON ID:43; TYPE:PF
        Dim _myBuildingName As String = BuildingName

For Each _building As Object In RootPart.FacilityView(1).Buildings
	If _building.BuildingName = _myBuildingName Then Result = _building : Exit For
Next
        '   END FORMULA; CON ID:43; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_Building_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Group_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:30; TYPE:PF
        Result = ParentItem(1)
        '   END FORMULA; CON ID:30; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_Group_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ParentItem_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:28; TYPE:PF
        Result = Nothing

For Each _group As Object In Parent.Groups 'check if a group is my parent
	For Each _system As Object In _group.Systems
		If _system Is Me Then Result = _group : Exit For
	Next

	If Result IsNot Nothing Then Exit For 'found the parent
Next
        '   END FORMULA; CON ID:28; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_ParentItem_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantViewNodes_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:65; TYPE:PF
        Result = Subparts("Plants").Parts
        '   END FORMULA; CON ID:65; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_PlantViewNodes_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplies_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:52; TYPE:PF
        Result = New rsCollection

For Each _ps As Object In RootPart.PowerSupplyView(1).PowerSupplies
	For Each _system As Object In _ps.HBSSystem
		If IsConnected(_ps.HBSSystem) AndAlso _ps.HBSSystem(1) Is Me Then Result.Add(_ps) : Exit For
	Next
Next
        '   END FORMULA; CON ID:52; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_PowerSupplies_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Systems_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:29; TYPE:PF
        Result = Nothing
        '   END FORMULA; CON ID:29; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_Systems_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Transformers_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:58; TYPE:PF
        Result = New rsCollection

For Each _ps As Object In RootPart.PowerSupplyView(1).PowerSupplies
	If IsConnected(_ps.HBSSystem) AndAlso _ps.HBSSystem(1) Is Me Then Result.Add(_ps)
Next
        '   END FORMULA; CON ID:58; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_Transformers_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
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
      '   BEGIN FORMULA; PROP ID:542; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:542; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_BuildingName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CanAddChild() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CanAddChild").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:425; TYPE:PF
      Result = False 'cannot add a sub-system to a system
      '   END FORMULA; PROP ID:425; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_CanAddChild", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:408; TYPE:PF
      Result = ParentItem(1).DisplayName & "." & SystemName
      '   END FORMULA; PROP ID:408; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_DisplayName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:746; TYPE:PF
      Result = SystemName
      '   END FORMULA; PROP ID:746; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_ElementName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:175; TYPE:PF
      Dim _sb As New Text.StringBuilder
_sb.Append("-").Append(" ", IndentLevel * 6)

Result = _sb.ToString()
      '   END FORMULA; PROP ID:175; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_Indentation", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:180; TYPE:PF
      Result = SystemNameIndented
      '   END FORMULA; PROP ID:180; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_IndentedDisplayName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:424; TYPE:PF
      Result = ParentItem(1).IndentLevel + 1
      '   END FORMULA; PROP ID:424; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_IndentLevel", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PastePlant() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PastePlant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:349; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:349; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_PastePlant", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:581; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:581; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_PlantItemComment", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:584; TYPE:PF
      Result = "Description for " & SystemName
      '   END FORMULA; PROP ID:584; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_PlantItemDescription", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:579; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:579; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_PlantItemLocation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SafetyMargin() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SafetyMargin").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1170; TYPE:PF
      Result = 15.0
      '   END FORMULA; PROP ID:1170; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_SafetyMargin", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Selected() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Selected").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:426; TYPE:PF
      Result = True
      '   END FORMULA; PROP ID:426; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_Selected", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SelectedTransformerIndex() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SelectedTransformerIndex").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:718; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:718; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_SelectedTransformerIndex", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:177; TYPE:PF
      Result = "System"
      '   END FORMULA; PROP ID:177; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_SystemName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SystemNameIndented() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SystemNameIndented").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:178; TYPE:PF
      Result = Indentation & SystemName
      '   END FORMULA; PROP ID:178; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_SystemNameIndented", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SystemType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SystemType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:325; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:325; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_SystemType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SystemUserDefinedName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SystemUserDefinedName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:324; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:324; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_SystemUserDefinedName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      Public Function Formula_CanAddChild_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_ElementName_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_PastePlant_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_SafetyMargin_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selected_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedTransformerIndex_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_SystemNameIndented_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SystemType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SystemUserDefinedName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
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
      Public Function Formula_CanAddChild_USERCHANGE() as Boolean
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
      Public Function Formula_ElementName_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_PastePlant_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("PastePlant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:349; TYPE:UC
              Result = IsConnected(RootPart.CopyPlantSource)
              '   END FORMULA; PROP ID:349; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_PastePlant_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
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
      Public Function Formula_SafetyMargin_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selected_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedTransformerIndex_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SystemName_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SystemNameIndented_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SystemType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SystemUserDefinedName_USERCHANGE() as Boolean
      Return True
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
      '   BEGIN FORMULA; PROP ID:542; TYPE:VV
      Result = RootPart.FacilityView(1).ValidValues("BuildingNames")
      '   END FORMULA; PROP ID:542; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_BuildingName_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Plants_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:16; TYPE:PN
      
      '   END FORMULA; SUB ID:16; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_Plants_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Plants_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Plants").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:16; TYPE:QF
      Result = 0
      '   END FORMULA; SUB ID:16; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_Plants_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Plants_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Plants").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:16; TYPE:OP
      Result = "Plant"
      '   END FORMULA; SUB ID:16; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_Plants_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_PastePlant_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PastePlant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:349; TYPE:WC
      Dim _fromPlant As Object = RootPart.CopyPlantSource(1)
Dim _toPlant As Object = _fromPlant.Duplicate(Plants, True)
RootPart.CopyPlantSource.DisConnect(_fromPlant)
      '   END FORMULA; PROP ID:349; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBSSystem.Formula_PastePlant_WHENCHANGED", ex.Message)
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

  