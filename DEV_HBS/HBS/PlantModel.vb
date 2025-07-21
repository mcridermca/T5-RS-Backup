Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: PlantModel
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

    Public Class [PlantModel]
    
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

    Private this as PlantModel = me

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
    
      Case "AddGroup_"
      Formula_AddGroup_WHENCHANGED(Value, OldValue)
    
      Case "AddPlant_"
      Formula_AddPlant_WHENCHANGED(Value, OldValue)
    
      Case "AddSystem_"
      Formula_AddSystem_WHENCHANGED(Value, OldValue)
    
      Case "CopyPlant_"
      Formula_CopyPlant_WHENCHANGED(Value, OldValue)
    
      Case "CutSystem_"
      Formula_CutSystem_WHENCHANGED(Value, OldValue)
    
      Case "DeleteTreeItem_"
      Formula_DeleteTreeItem_WHENCHANGED(Value, OldValue)
    
      Case "PastePlant_"
      Formula_PastePlant_WHENCHANGED(Value, OldValue)
    
      Case "PasteSystem_"
      Formula_PasteSystem_WHENCHANGED(Value, OldValue)
    
      Case "SelectedTreeIndex_"
      Formula_SelectedTreeIndex_WHENCHANGED(Value, OldValue)
    
    End Select
    End Sub

    Public Function OnChangedStatus(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String)As Boolean Implements RuleStream.IRsPartFormulas.OnChangedStatus
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Dim Status as Boolean = False
    Select Case specName & "_" & context
    
      Case "AddGroup_"
      'Formula_AddGroup_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "AddPlant_"
      'Formula_AddPlant_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "AddSystem_"
      'Formula_AddSystem_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "CopyPlant_"
      'Formula_CopyPlant_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "CutSystem_"
      'Formula_CutSystem_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "DeleteTreeItem_"
      'Formula_DeleteTreeItem_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "PastePlant_"
      'Formula_PastePlant_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "PasteSystem_"
      'Formula_PasteSystem_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "SelectedTreeIndex_"
      'Formula_SelectedTreeIndex_WHENCHANGED(Value, OldValue)
      Status = True
    Case Else
    Status = False
    End Select
    Return Status
    End Function

    #End Region

    #Region " Properties, Subparts, Connections "
    
          Public Property [AddGroup]() As String
      Get
      Return Properties("AddGroup").Value
      End Get
      Set(ByVal Value As String)
      Properties("AddGroup").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [AddPlant]() As String
      Get
      Return Properties("AddPlant").Value
      End Get
      Set(ByVal Value As String)
      Properties("AddPlant").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [AddSystem]() As String
      Get
      Return Properties("AddSystem").Value
      End Get
      Set(ByVal Value As String)
      Properties("AddSystem").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CopyPlant]() As String
      Get
      Return Properties("CopyPlant").Value
      End Get
      Set(ByVal Value As String)
      Properties("CopyPlant").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CutSystem]() As String
      Get
      Return Properties("CutSystem").Value
      End Get
      Set(ByVal Value As String)
      Properties("CutSystem").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DeleteTreeItem]() As String
      Get
      Return Properties("DeleteTreeItem").Value
      End Get
      Set(ByVal Value As String)
      Properties("DeleteTreeItem").CalculatedValue = Value
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
    
          Public Property [PasteSystem]() As String
      Get
      Return Properties("PasteSystem").Value
      End Get
      Set(ByVal Value As String)
      Properties("PasteSystem").CalculatedValue = Value
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
    
          Public Property [SelectedTreeIndex]() As Long
      Get
      Return Properties("SelectedTreeIndex").Value
      End Get
      Set(ByVal Value As Long)
      Properties("SelectedTreeIndex").CalculatedValue = Value
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
    
          Public Property [NumberOfLevels]() As Long
      Get
      Return Properties("NumberOfLevels").Value
      End Get
      Set(ByVal Value As Long)
      Properties("NumberOfLevels").CalculatedValue = Value
      End Set
      End Property
    
      Public ReadOnly Property [Groups]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Groups")
      End Get
      End Property
    
      Public ReadOnly Property [Systems]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Systems")
      End Get
      End Property
    
      Public ReadOnly Property [CopyPlantSource]() As Rulestream.Kernel.Connection
      Get
      Return Connections("CopyPlantSource")
      End Get
      End Property
    
      Public ReadOnly Property [MoveSystemSource]() As Rulestream.Kernel.Connection
      Get
      Return Connections("MoveSystemSource")
      End Get
      End Property
    
      Public ReadOnly Property [PlantViewNodes]() As Rulestream.Kernel.Connection
      Get
      Return Connections("PlantViewNodes")
      End Get
      End Property
    
      Public ReadOnly Property [SelectedGroupItem]() As Rulestream.Kernel.Connection
      Get
      Return Connections("SelectedGroupItem")
      End Get
      End Property
    
      Public ReadOnly Property [SelectedPlantItem]() As Rulestream.Kernel.Connection
      Get
      Return Connections("SelectedPlantItem")
      End Get
      End Property
    
      Public ReadOnly Property [SelectedSystemItem]() As Rulestream.Kernel.Connection
      Get
      Return Connections("SelectedSystemItem")
      End Get
      End Property
    
      Public ReadOnly Property [UnassginedFacilityPlants]() As Rulestream.Kernel.Connection
      Get
      Return Connections("UnassginedFacilityPlants")
      End Get
      End Property
    
      Public ReadOnly Property [GroupTree]() As Rulestream.Kernel.Connection
      Get
      Return Connections("GroupTree")
      End Get
      End Property
    
      Public ReadOnly Property [SelectedTreeItem]() As Rulestream.Kernel.Connection
      Get
      Return Connections("SelectedTreeItem")
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
    InitPart("PlantModel", <a><![CDATA[Plant Model]]></a>.Value, 24, "HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601421", "07/21/2025 06:56:48")
    AddProperty("451", "AddGroup", <a><![CDATA[Add Group]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/5/2025 6:16:00 AM")
    AddProperty("452", "AddPlant", <a><![CDATA[Add Plant]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("453", "AddSystem", <a><![CDATA[Add System]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/21/2025 6:56:48 AM")
    AddProperty("454", "CopyPlant", <a><![CDATA[Copy Plant]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("618", "CutSystem", <a><![CDATA[Cut System]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("455", "DeleteTreeItem", <a><![CDATA[Delete Tree Item]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("593", "DisplayName", <a><![CDATA[Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("596", "IndentedDisplayName", <a><![CDATA[Indented Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("679", "IndentLevel", <a><![CDATA[Indent Level]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("457", "PastePlant", <a><![CDATA[Paste Plant]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("619", "PasteSystem", <a><![CDATA[Paste System]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("597", "Selected", <a><![CDATA[Selected]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("458", "SelectedTreeIndex", <a><![CDATA[Selected Tree Index]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("450", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601421", "4/20/2025 3:29:47 AM")
    AddProperty("456", "NumberOfLevels", <a><![CDATA[Number Of Levels]]></a>.Value, "How many levels down we support.", "Long","","UI Control","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601421", "4/20/2025 3:32:57 AM")
    
      AddPropertyExtended(451,"AddGroup", "429", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "7/5/2025 6:16:00 AM")
    
      AddPropertyExtended(452,"AddPlant", "430", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "5/5/2025 4:53:51 PM")
    
      AddPropertyExtended(453,"AddSystem", "431", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "7/21/2025 6:56:48 AM")
    
      AddPropertyExtended(454,"CopyPlant", "432", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "4/20/2025 3:32:57 AM")
    
      AddPropertyExtended(618,"CutSystem", "574", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "5/5/2025 5:49:41 PM")
    
      AddPropertyExtended(455,"DeleteTreeItem", "433", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "5/5/2025 9:02:51 PM")
    
      AddPropertyExtended(457,"PastePlant", "435", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "4/20/2025 3:32:57 AM")
    
      AddPropertyExtended(619,"PasteSystem", "575", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "5/9/2025 1:55:45 AM")
    
      oSubpart = AddSubpart(27,"Groups", <a><![CDATA[Groups]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oSubpart.AddVPF (13, "Group", "Group")
      
      oSubpart = AddSubpart(28,"Systems", <a><![CDATA[Systems]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oSubpart.AddVPF (17, "HBSSystem", "HBS System")
      
      oConnection = AddConnection("CopyPlantSource", <a><![CDATA[Copy Plant Source]]></a>.Value, "", "38", "MO", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(4, "Plant")
      
      oConnection = AddConnection("MoveSystemSource", <a><![CDATA[Move System Source]]></a>.Value, "", "55", "MO", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(17, "HBSSystem")
      
      oConnection = AddConnection("PlantViewNodes", <a><![CDATA[Plant View Nodes]]></a>.Value, "", "72", "MM", 0, "","General", 9999, "", "GLOBAL\H601421", "7/5/2025 3:10:30 AM")
      
        oConnection.AddVPF(13, "Group")
      
      oConnection = AddConnection("SelectedGroupItem", <a><![CDATA[Selected Group Item]]></a>.Value, "", "40", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(13, "Group")
      
      oConnection = AddConnection("SelectedPlantItem", <a><![CDATA[Selected Plant Item]]></a>.Value, "", "41", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(4, "Plant")
      
      oConnection = AddConnection("SelectedSystemItem", <a><![CDATA[Selected System Item]]></a>.Value, "", "42", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(17, "HBSSystem")
      
      oConnection = AddConnection("UnassginedFacilityPlants", <a><![CDATA[Unassgined Facility Plants]]></a>.Value, "", "100", "OM", 0, "","General", 9999, "", "GLOBAL\H601421", "7/20/2025 4:36:47 AM")
      
        oConnection.AddVPF(4, "Plant")
      
      oConnection = AddConnection("GroupTree", <a><![CDATA[Group Tree]]></a>.Value, "", "39", "OM", 0, "","Subparts and Connections", 9999, "", "GLOBAL\H601421", "7/7/2025 9:06:58 PM")
      
        oConnection.AddVPF(4, "Plant")
      
        oConnection.AddVPF(13, "Group")
      
        oConnection.AddVPF(17, "HBSSystem")
      
        oConnection.AddVPF(24, "PlantModel")
      
      oConnection = AddConnection("SelectedTreeItem", <a><![CDATA[Selected Tree Item]]></a>.Value, "", "43", "OO", 0, "","Subparts and Connections", 9999, "", "GLOBAL\H601421", "4/20/2025 3:32:57 AM")
      
        oConnection.AddVPF(4, "Plant")
      
        oConnection.AddVPF(13, "Group")
      
        oConnection.AddVPF(17, "HBSSystem")
      
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
          InitProperty("AddGroup", "429", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/5/2025 6:16:00 AM", "", "In Development",  0,1078)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("AddPlant", "430", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/5/2025 4:53:51 PM", "", "In Development",  0,1390)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("AddSystem", "431", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/21/2025 6:56:48 AM", "", "In Development",  0,1084)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CopyPlant", "432", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/20/2025 3:32:57 AM", "", "In Development",  0,1087)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CutSystem", "574", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/5/2025 5:49:41 PM", "", "In Development",  0,1391)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DeleteTreeItem", "433", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/5/2025 9:02:51 PM", "", "In Development",  0,1090)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DisplayName", "549", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/25/2025 9:12:38 PM", "", "In Development",  0,1296)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IndentedDisplayName", "552", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/9/2025 4:59:10 PM", "", "In Development",  0,1513)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IndentLevel", "634", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/7/2025 4:14:56 AM", "", "In Development",  0,1504)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PastePlant", "435", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/20/2025 3:32:57 AM", "", "In Development",  0,1094)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PasteSystem", "575", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/9/2025 1:55:45 AM", "", "In Development",  0,1394)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Selected", "553", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/26/2025 5:08:37 AM", "", "In Development",  0,1309)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SelectedTreeIndex", "436", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/20/2025 3:32:57 AM", "", "In Development",  0,1097)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("NumberOfLevels", "434", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/20/2025 3:32:57 AM", "", "In Development",  0,1093)
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
          
        InitSubpart("Groups", 27, "", "", "Y", 0, "-1", "", "GLOBAL\H601421", "5/6/2025 3:48:09 PM", "", "In Development", "Y",0,65,154)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Systems", 28, "", "", "Y", 0, "-1", "", "GLOBAL\H601421", "4/20/2025 4:11:09 AM", "", "In Development", "Y",0,67,66)
        
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
          
        InitConnection("SelectedGroupItem", "36", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "4/20/2025 3:32:57 AM", "", "In Development", "N",66)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("SelectedPlantItem", "37", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "4/20/2025 3:32:57 AM", "", "In Development", "N",67)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("SelectedSystemItem", "38", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "4/20/2025 3:32:57 AM", "", "In Development", "N",68)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("UnassginedFacilityPlants", "92", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "7/20/2025 4:36:47 AM", "", "In Development", "N",181)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("GroupTree", "35", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "7/7/2025 9:06:58 PM", "", "In Development", "N",133)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("SelectedTreeItem", "39", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "4/20/2025 3:32:57 AM", "", "In Development", "N",69)
        
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
      Public Function Formula_SelectedGroupItem_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:36; TYPE:PF
        Dim _selectedItem As Object = If(IsConnected(SelectedTreeItem), SelectedTreeItem(1), Nothing)

Select Case If(_selectedItem IsNot Nothing, _selectedItem.PartFamily, String.Empty)
	Case "Group" : Result = _selectedItem
	Case "HBSSystem" : Result = _selectedItem.Group(1)
	Case "Plant" : Result = _selectedItem.Parent.Group(1)
	Case Else : Result = Nothing
End Select
        '   END FORMULA; CON ID:36; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_SelectedGroupItem_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedPlantItem_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:37; TYPE:PF
        Dim _selectedItem As Object = If(IsConnected(SelectedTreeItem), SelectedTreeItem(1), Nothing)

Select Case If(_selectedItem IsNot Nothing, _selectedItem.PartFamily, String.Empty)
	Case "Group" : Result = Nothing
	Case "HBSSystem" : Result = Nothing
	Case "Plant" : Result = _selectedItem
	Case Else : Result = Nothing
End Select
        '   END FORMULA; CON ID:37; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_SelectedPlantItem_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedSystemItem_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:38; TYPE:PF
        Dim _selectedItem As Object = If(IsConnected(SelectedTreeItem), SelectedTreeItem(1), Nothing)

Select Case If(_selectedItem IsNot Nothing, _selectedItem.PartFamily, String.Empty)
	Case "Group" : Result = Nothing
	Case "HBSSystem" : Result = _selectedItem
	Case "Plant" : Result = _selectedItem.Parent
	Case Else : Result = Nothing
End Select
        '   END FORMULA; CON ID:38; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_SelectedSystemItem_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UnassginedFacilityPlants_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:92; TYPE:PF
        Result = New rsCollection

For Each _system As Object In Systems
	For Each _plant As Object In _system.Plants
		If Not IsConnected(_plant.Floor) Then Result.Add(_plant)
	Next
Next
        '   END FORMULA; CON ID:92; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_UnassginedFacilityPlants_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_GroupTree_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:35; TYPE:PF
        Result = New rsCollection

Result.Add(Me)

For Each _group As Object In Groups
	If _group.IndentLevel = 1 Then
		CollectTreeItems(Result, _group, Nothing)
	End If
Next
        '   END FORMULA; CON ID:35; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_GroupTree_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedTreeItem_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:39; TYPE:PF
        Result = If(SelectedTreeIndex > 0, GroupTree(SelectedTreeIndex), Nothing)
        '   END FORMULA; CON ID:39; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_SelectedTreeItem_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_AddGroup() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AddGroup").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:429; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:429; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_AddGroup", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_AddPlant() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AddPlant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:430; TYPE:PF
      Result = "ADD PLANT"
      '   END FORMULA; PROP ID:430; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_AddPlant", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_AddSystem() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AddSystem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:431; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:431; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_AddSystem", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CopyPlant() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CopyPlant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:432; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:432; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_CopyPlant", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CutSystem() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CutSystem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:574; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:574; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_CutSystem", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DeleteTreeItem() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DeleteTreeItem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:433; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:433; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_DeleteTreeItem", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:549; TYPE:PF
      Result = "Plant View"
      '   END FORMULA; PROP ID:549; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_DisplayName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:552; TYPE:PF
      Result = RootPart.CORA_Info(1).ERP_Project_Description
      '   END FORMULA; PROP ID:552; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_IndentedDisplayName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:634; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:634; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_IndentLevel", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:435; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:435; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_PastePlant", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PasteSystem() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PasteSystem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:575; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:575; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_PasteSystem", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:553; TYPE:PF
      Result = True
      '   END FORMULA; PROP ID:553; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_Selected", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SelectedTreeIndex() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SelectedTreeIndex").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:436; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:436; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_SelectedTreeIndex", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_NumberOfLevels() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("NumberOfLevels").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:434; TYPE:PF
      Result = 5
      '   END FORMULA; PROP ID:434; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_NumberOfLevels", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AddGroup_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AddPlant_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AddSystem_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CopyPlant_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CutSystem_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DeleteTreeItem_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_PasteSystem_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_SelectedTreeIndex_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_NumberOfLevels_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AddGroup_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("AddGroup").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:429; TYPE:UC
              Result = False

If IsConnected(SelectedGroupItem) Then
	Dim _group As Object = SelectedGroupItem(1)

	Result =  _group.CanAddChild
Else 'this MUST be the root
	Result = True
End If
              '   END FORMULA; PROP ID:429; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_AddGroup_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AddPlant_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("AddPlant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:430; TYPE:UC
              Result = IsConnected(SelectedSystemItem) OrElse IsConnected(SelectedPlantItem)
              '   END FORMULA; PROP ID:430; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_AddPlant_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AddSystem_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("AddSystem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:431; TYPE:UC
              If IsConnected(SelectedGroupItem) Then
	Dim _group As Object = SelectedGroupItem(1)

	Result = _group.CanAddSystem
ElseIf IsConnected(SelectedTreeItem) AndAlso SelectedTreeItem(1) Is RootPart.PlantView(1) Then
	Result = True
End If
              '   END FORMULA; PROP ID:431; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_AddSystem_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CopyPlant_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("CopyPlant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:432; TYPE:UC
              Result = IsConnected(SelectedPlantItem)
              '   END FORMULA; PROP ID:432; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_CopyPlant_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CutSystem_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("CutSystem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:574; TYPE:UC
              Result = IsConnected(SelectedSystemItem)
              '   END FORMULA; PROP ID:574; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_CutSystem_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DeleteTreeItem_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("DeleteTreeItem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:433; TYPE:UC
              Result = IsConnected(SelectedGroupItem) OrElse IsConnected(SelectedSystemItem) OrElse IsConnected(SelectedPlantItem)
              '   END FORMULA; PROP ID:433; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_DeleteTreeItem_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
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
              '   BEGIN FORMULA; PROP ID:435; TYPE:UC
              Result = IsConnected(SelectedSystemItem) AndAlso IsConnected(CopyPlantSource)
              '   END FORMULA; PROP ID:435; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_PastePlant_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PasteSystem_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("PasteSystem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:575; TYPE:UC
              Result = IsConnected(SelectedGroupItem) AndAlso IsConnected(MoveSystemSource)
              '   END FORMULA; PROP ID:575; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_PasteSystem_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selected_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedTreeIndex_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_NumberOfLevels_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Groups_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:27; TYPE:PN
      
      '   END FORMULA; SUB ID:27; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_Groups_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Groups_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Groups").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:27; TYPE:QF
      Result = 0
      '   END FORMULA; SUB ID:27; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_Groups_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Groups_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Groups").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:27; TYPE:OP
      Result = "Group"
      '   END FORMULA; SUB ID:27; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_Groups_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Systems_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:28; TYPE:PN
      
      '   END FORMULA; SUB ID:28; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_Systems_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Systems_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Systems").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:28; TYPE:QF
      Result = 0
      '   END FORMULA; SUB ID:28; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_Systems_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Systems_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Systems").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:28; TYPE:OP
      Result = "HBSSystem"
      '   END FORMULA; SUB ID:28; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_Systems_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_AddGroup_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AddGroup").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:429; TYPE:WC
      Dim _newGroup As Object = Subparts("Groups").AddPart("Group") 'added as level 1 by default

If IsConnected(SelectedGroupItem) Then
	Dim _group As Object = SelectedGroupItem(1)

	'add the new group as a child to selected group
	_group.PlantViewNodes.Connect(_newGroup)
Else
	PlantViewNodes.Connect(_newGroup)
End If
      '   END FORMULA; PROP ID:429; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_AddGroup_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_AddPlant_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AddPlant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:430; TYPE:WC
      If IsConnected(SelectedTreeItem) Then
	Dim _treeItem As Object = SelectedTreeItem(1)

	Select Case _treeItem.PartFamily
		Case "Group"
		Case "HBSSystem" : _treeItem.Subparts("Plants").AddPart("Plant")
		Case "Plant" : _treeItem.Parent.Subparts("Plants").AddPart("Plant")
	End Select
End If
      '   END FORMULA; PROP ID:430; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_AddPlant_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_AddSystem_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AddSystem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:431; TYPE:WC
      If IsConnected(SelectedTreeItem) Then
	Dim _treeItem As Object = SelectedTreeItem(1)
	Dim _system As Object = Subparts("Systems").AddPart("HBSSystem")

	Select Case _treeItem.PartFamily
		Case "Group"
			_treeItem.PlantViewNodes.Connect(_system)
		Case "HBSSystem"
			_treeItem.ParentItem(1).PlantViewNodes.Connect(_system)
		Case "Plant"
			_treeItem.Parent.ParentItem(1).PlantViewNodes.Connect(_system)
	End Select
End If
      '   END FORMULA; PROP ID:431; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_AddSystem_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_CopyPlant_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CopyPlant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:432; TYPE:WC
      Rootpart.CopyPlantSource.Connect(SelectedPlantItem(1))
      '   END FORMULA; PROP ID:432; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_CopyPlant_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_CutSystem_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CutSystem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:574; TYPE:WC
      Dim _system As Object = If(IsConnected(SelectedSystemItem), SelectedSystemItem(1), Nothing)

If _system IsNot Nothing Then MoveSystemSource.Connect(_system)
      '   END FORMULA; PROP ID:574; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_CutSystem_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_DeleteTreeItem_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DeleteTreeItem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:433; TYPE:WC
      If IsConnected(SelectedTreeItem) Then
	If MessageBox.Show("Are you sure you want to delete the element level permanently? Deleting an element level is allowed only when there are no system or plants under it", "Delete Element", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
		Dim _treeItem As Object = SelectedTreeItem(1)

		If _treeItem.PartFamily = "Group" Then
			DeleteGroup(_treeItem)
		ElseIf _treeItem.PartFamily <> "PlantModel" Then
			_treeItem.Owner.Remove(_treeItem.Name)
		End If
	End If
End If
      '   END FORMULA; PROP ID:433; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_DeleteTreeItem_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
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
      '   BEGIN FORMULA; PROP ID:435; TYPE:WC
      Dim _fromPlant As Object = CopyPlantSource(1)
Dim _toPlant As Object = _fromPlant.Duplicate(SelectedSystemItem(1).Plants, True)
For Each _device As Object In _toPlant.Devices
	_device.Device_DBDetails(1).RefreshDatabaseValues()
Next
CopyPlantSource.DisConnect(_fromPlant)
      '   END FORMULA; PROP ID:435; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_PastePlant_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_PasteSystem_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PasteSystem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:575; TYPE:WC
      Dim _system As Object = MoveSystemSource(1)
Dim _toGroup As Object = SelectedGroupItem(1)

'remove this system from its current group
_system.Group(1).Systems.Disconnect(_system)

'add this system to the new group
_toGroup.Systems.Connect(_system)

'remove this system from clipboard
MoveSystemSource.Disconnect(_system)
      '   END FORMULA; PROP ID:575; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_PasteSystem_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_SelectedTreeIndex_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SelectedTreeIndex").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:436; TYPE:WC
      g_RsEngineer.RefreshModelViews(0)
      '   END FORMULA; PROP ID:436; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PlantModel.Formula_SelectedTreeIndex_WHENCHANGED", ex.Message)
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

  