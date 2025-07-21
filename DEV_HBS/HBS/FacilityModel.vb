Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: FacilityModel
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

    Public Class [FacilityModel]
    
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

    Private this as FacilityModel = me

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
    
      Case "AddBuilding_"
      Formula_AddBuilding_WHENCHANGED(Value, OldValue)
    
      Case "AddFloor_"
      Formula_AddFloor_WHENCHANGED(Value, OldValue)
    
      Case "button_AddToClipboard_"
      Formula_button_AddToClipboard_WHENCHANGED(Value, OldValue)
    
      Case "button_MoveFacilityItem_"
      Formula_button_MoveFacilityItem_WHENCHANGED(Value, OldValue)
    
      Case "DeleteFacilityItem_"
      Formula_DeleteFacilityItem_WHENCHANGED(Value, OldValue)
    
      Case "SelectedTreeIndex_"
      Formula_SelectedTreeIndex_WHENCHANGED(Value, OldValue)
    
    End Select
    End Sub

    Public Function OnChangedStatus(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String)As Boolean Implements RuleStream.IRsPartFormulas.OnChangedStatus
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Dim Status as Boolean = False
    Select Case specName & "_" & context
    
      Case "AddBuilding_"
      'Formula_AddBuilding_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "AddFloor_"
      'Formula_AddFloor_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "button_AddToClipboard_"
      'Formula_button_AddToClipboard_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "button_MoveFacilityItem_"
      'Formula_button_MoveFacilityItem_WHENCHANGED(Value, OldValue)
      Status = True
    
      Case "DeleteFacilityItem_"
      'Formula_DeleteFacilityItem_WHENCHANGED(Value, OldValue)
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
    
          Public Property [AddBuilding]() As String
      Get
      Return Properties("AddBuilding").Value
      End Get
      Set(ByVal Value As String)
      Properties("AddBuilding").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [AddFloor]() As String
      Get
      Return Properties("AddFloor").Value
      End Get
      Set(ByVal Value As String)
      Properties("AddFloor").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BuildingNames]() As String
      Get
      Return Properties("BuildingNames").Value
      End Get
      Set(ByVal Value As String)
      Properties("BuildingNames").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [button_AddToClipboard]() As String
      Get
      Return Properties("button_AddToClipboard").Value
      End Get
      Set(ByVal Value As String)
      Properties("button_AddToClipboard").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [button_MoveFacilityItem]() As String
      Get
      Return Properties("button_MoveFacilityItem").Value
      End Get
      Set(ByVal Value As String)
      Properties("button_MoveFacilityItem").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DeleteFacilityItem]() As String
      Get
      Return Properties("DeleteFacilityItem").Value
      End Get
      Set(ByVal Value As String)
      Properties("DeleteFacilityItem").CalculatedValue = Value
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
    
          Public Property [FacilityItemName]() As String
      Get
      Return Properties("FacilityItemName").Value
      End Get
      Set(ByVal Value As String)
      Properties("FacilityItemName").CalculatedValue = Value
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
    
      Public ReadOnly Property [Buildings]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Buildings")
      End Get
      End Property
    
      Public ReadOnly Property [FacilityClipboard]() As Rulestream.Kernel.Connection
      Get
      Return Connections("FacilityClipboard")
      End Get
      End Property
    
      Public ReadOnly Property [FacilityTree]() As Rulestream.Kernel.Connection
      Get
      Return Connections("FacilityTree")
      End Get
      End Property
    
      Public ReadOnly Property [FacilityViewNodes]() As Rulestream.Kernel.Connection
      Get
      Return Connections("FacilityViewNodes")
      End Get
      End Property
    
      Public ReadOnly Property [SelectedBuilding]() As Rulestream.Kernel.Connection
      Get
      Return Connections("SelectedBuilding")
      End Get
      End Property
    
      Public ReadOnly Property [SelectedFacilityItem]() As Rulestream.Kernel.Connection
      Get
      Return Connections("SelectedFacilityItem")
      End Get
      End Property
    
      Public ReadOnly Property [SelectedFloor]() As Rulestream.Kernel.Connection
      Get
      Return Connections("SelectedFloor")
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
    InitPart("FacilityModel", <a><![CDATA[Facility Model]]></a>.Value, 44, "HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601421", "07/20/2025 03:42:17")
    AddProperty("588", "AddBuilding", <a><![CDATA[Add Building]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("589", "AddFloor", <a><![CDATA[Add Floor]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/14/2025 2:30:46 AM")
    AddProperty("580", "BuildingNames", <a><![CDATA[Building Names]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("1678", "button_AddToClipboard", <a><![CDATA[button_Add To Clipboard]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/15/2025 3:19:59 AM")
    AddProperty("1680", "button_MoveFacilityItem", <a><![CDATA[button_Move Facility Item]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/15/2025 4:28:30 AM")
    AddProperty("620", "DeleteFacilityItem", <a><![CDATA[Delete Facility Item]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("592", "DisplayName", <a><![CDATA[Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("572", "FacilityDisplayName", <a><![CDATA[Facility Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("606", "FacilityItemName", <a><![CDATA[Facility Item Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("600", "Selected", <a><![CDATA[Selected]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("587", "SelectedTreeIndex", <a><![CDATA[Selected Tree Index]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("568", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601421", "4/25/2025 3:12:58 AM")
    
      AddPropertyExtended(588,"AddBuilding", "544", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "4/25/2025 7:16:31 PM")
    
      AddPropertyExtended(589,"AddFloor", "545", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "7/14/2025 2:30:46 AM")
    
      AddPropertyExtended(1678,"button_AddToClipboard", "1546", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "7/15/2025 3:19:59 AM")
    
      AddPropertyExtended(1680,"button_MoveFacilityItem", "1548", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "7/15/2025 4:28:30 AM")
    
      AddPropertyExtended(620,"DeleteFacilityItem", "576", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "5/5/2025 8:59:12 PM")
    
      AddValidValue("BuildingNames")
    
      oSubpart = AddSubpart(63,"Buildings", <a><![CDATA[Buildings]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oSubpart.AddVPF (45, "Building", "Building")
      
      oConnection = AddConnection("FacilityClipboard", <a><![CDATA[Facility Clipboard]]></a>.Value, "", "92", "OO", 0, "","General", 9999, "", "GLOBAL\H601421", "7/15/2025 3:03:31 AM")
      
        oConnection.AddVPF(4, "Plant")
      
        oConnection.AddVPF(6, "Controller")
      
        oConnection.AddVPF(45, "Building")
      
        oConnection.AddVPF(46, "Floor")
      
      oConnection = AddConnection("FacilityTree", <a><![CDATA[Facility Tree]]></a>.Value, "", "48", "OM", 0, "","General", 9999, "", "GLOBAL\H601421", "7/11/2025 6:19:15 PM")
      
        oConnection.AddVPF(44, "FacilityModel")
      
        oConnection.AddVPF(45, "Building")
      
        oConnection.AddVPF(46, "Floor")
      
      oConnection = AddConnection("FacilityViewNodes", <a><![CDATA[Facility View Nodes]]></a>.Value, "", "85", "OM", 0, "","General", 9999, "", "GLOBAL\H601421", "7/14/2025 3:33:22 AM")
      
        oConnection.AddVPF(45, "Building")
      
        oConnection.AddVPF(46, "Floor")
      
      oConnection = AddConnection("SelectedBuilding", <a><![CDATA[Selected Building]]></a>.Value, "", "51", "OO", 0, "","General", 9999, "", "GLOBAL\H601421", "7/20/2025 3:10:49 AM")
      
        oConnection.AddVPF(45, "Building")
      
      oConnection = AddConnection("SelectedFacilityItem", <a><![CDATA[Selected Facility Item]]></a>.Value, "", "49", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(44, "FacilityModel")
      
        oConnection.AddVPF(45, "Building")
      
        oConnection.AddVPF(46, "Floor")
      
      oConnection = AddConnection("SelectedFloor", <a><![CDATA[Selected Floor]]></a>.Value, "", "50", "OO", 0, "","General", 9999, "", "GLOBAL\H601421", "7/20/2025 3:42:17 AM")
      
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
          InitProperty("AddBuilding", "544", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/25/2025 7:16:31 PM", "", "In Development",  0,1285)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("AddFloor", "545", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/14/2025 2:30:46 AM", "", "In Development",  0,1287)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BuildingNames", "536", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/25/2025 4:55:16 AM", "", "In Development",  0,1266)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("button_AddToClipboard", "1546", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/15/2025 3:19:59 AM", "", "In Development",  0,2839)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("button_MoveFacilityItem", "1548", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/15/2025 4:28:30 AM", "", "In Development",  0,2843)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DeleteFacilityItem", "576", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/5/2025 8:59:12 PM", "", "In Development",  0,1397)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DisplayName", "548", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/25/2025 9:11:59 PM", "", "In Development",  0,1295)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FacilityDisplayName", "528", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/29/2025 4:56:06 AM", "", "In Development",  0,1329)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FacilityItemName", "562", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "5/9/2025 4:59:28 PM", "", "In Development",  0,1514)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Selected", "556", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/26/2025 5:14:18 AM", "", "In Development",  0,1312)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SelectedTreeIndex", "543", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/25/2025 8:53:21 PM", "", "In Development",  0,1284)
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
          
        InitValidValue("BuildingNames_ValidValues", "536", "-1", 1267)
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
          
        InitSubpart("Buildings", 63, "", "", "Y", 0, "-1", "", "GLOBAL\H601421", "4/25/2025 3:53:27 AM", "", "In Development", "Y",0,145,144)
        
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
          
        InitConnection("FacilityClipboard", "84", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "7/15/2025 3:03:31 AM", "", "In Development", "Y",166)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("FacilityTree", "44", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "7/11/2025 6:19:15 PM", "", "In Development", "N",149)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("FacilityViewNodes", "77", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "7/14/2025 3:33:22 AM", "", "In Development", "N",157)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("SelectedBuilding", "47", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "7/20/2025 3:10:49 AM", "", "In Development", "N",177)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("SelectedFacilityItem", "45", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "4/25/2025 6:50:39 PM", "", "In Development", "N",78)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("SelectedFloor", "46", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "7/20/2025 3:42:17 AM", "", "In Development", "N",179)
        
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
      Public Function Formula_FacilityClipboard_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:84; TYPE:PF
        Result = Nothing
        '   END FORMULA; CON ID:84; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_FacilityClipboard_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FacilityTree_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:44; TYPE:PF
        Result = New rsCollection

Result.Add(Me)

For Each _building As Object In FacilityViewNodes
	Result.Add(_building)

	If _building.Selected Then
		For Each _floor As Object In _building.FacilityViewNodes
			Result.Add(_floor)

			If _floor.Selected Then
				For Each _part As Object In _floor.FacilityViewNodes
					Result.Add(_part)
				Next
			End If
		Next
	End If
Next
        '   END FORMULA; CON ID:44; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_FacilityTree_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FacilityViewNodes_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:77; TYPE:PF
        Dim _buildingsSorted As New SortedList(Of Integer, Object)

For Each _building As Object In Buildings
	_buildingsSorted.Add(_building.BuildingIndex, _building)
Next

Result = New rsCollection
For Each _buildingIndex As Integer In _buildingsSorted.Keys
	Result.Add(_buildingsSorted(_buildingIndex))
Next
        '   END FORMULA; CON ID:77; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_FacilityViewNodes_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedBuilding_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:47; TYPE:PF
        If IsConnected(SelectedFacilityItem) Then
	Dim _selectedPart As Object = SelectedFacilityItem(1)

	Select Case _selectedPart.PartFamily
		Case "Building" : Result = _selectedPart
		Case "Floor" : Result = _selectedPart.Parent
		Case "Plant" : Result = _selectedPart.Building(1)
		Case "Controller" : Result = _selectedPart.Building(1)
		Case Else : Result = Nothing
	End Select
End If
        '   END FORMULA; CON ID:47; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_SelectedBuilding_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedFacilityItem_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:45; TYPE:PF
        Dim _index As Integer = SelectedTreeIndex
Result = If(_index > 0, FacilityTree(_index), Nothing)
        '   END FORMULA; CON ID:45; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_SelectedFacilityItem_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedFloor_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:46; TYPE:PF
        If IsConnected(SelectedFacilityItem) Then
	Dim _selectedPart As Object = SelectedFacilityItem(1)

	Select Case _selectedPart.PartFamily
		Case "Floor" : Result = _selectedPart
		Case "Controller" : Result = _selectedPart.Floor(1)
		Case Else : Result = Nothing
	End Select
End If
        '   END FORMULA; CON ID:46; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_SelectedFloor_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_AddBuilding() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AddBuilding").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:544; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:544; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_AddBuilding", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_AddFloor() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AddFloor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:545; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:545; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_AddFloor", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BuildingNames() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BuildingNames").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:536; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:536; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_BuildingNames", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_button_AddToClipboard() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_AddToClipboard").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1546; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:1546; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_button_AddToClipboard", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_button_MoveFacilityItem() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_MoveFacilityItem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1548; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:1548; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_button_MoveFacilityItem", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DeleteFacilityItem() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DeleteFacilityItem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:576; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:576; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_DeleteFacilityItem", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:548; TYPE:PF
      Result = "Facility View"
      '   END FORMULA; PROP ID:548; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_DisplayName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:528; TYPE:PF
      Result = FacilityItemName
      '   END FORMULA; PROP ID:528; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_FacilityDisplayName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_FacilityItemName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("FacilityItemName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:562; TYPE:PF
      Result = RootPart.CORA_Info(1).ERP_Project_Description
      '   END FORMULA; PROP ID:562; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_FacilityItemName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:556; TYPE:PF
      Result = True
      '   END FORMULA; PROP ID:556; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_Selected", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:543; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:543; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_SelectedTreeIndex", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AddBuilding_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AddFloor_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BuildingNames_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_AddToClipboard_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_MoveFacilityItem_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DeleteFacilityItem_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_FacilityItemName_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_AddBuilding_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AddFloor_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("AddFloor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:545; TYPE:UC
              Result = IsConnected(SelectedBuilding) OrElse IsConnected(SelectedFloor)
              '   END FORMULA; PROP ID:545; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_AddFloor_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BuildingNames_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_AddToClipboard_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("button_AddToClipboard").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1546; TYPE:UC
              Result = SelectedTreeIndex > 1 'cannot move the root node
              '   END FORMULA; PROP ID:1546; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_button_AddToClipboard_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_MoveFacilityItem_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("button_MoveFacilityItem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1548; TYPE:UC
              If IsConnected(FacilityClipboard) AndAlso IsConnected(SelectedFacilityItem) Then
	Dim _clipboardItem As Object = FacilityClipboard(1)
	Dim _targetItem As Object = SelectedFacilityItem(1)

	If _clipboardItem.PartFamily = _targetItem.PartFamily Then
		Select Case _clipboardItem.PartFamily
			Case "Building" : Result = True
			Case "Floor" : Result = _targetItem.Parent Is _clipboardItem.Parent 'within same building
			Case Else : Result = False
		End Select
	End If
End If
              '   END FORMULA; PROP ID:1548; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_button_MoveFacilityItem_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DeleteFacilityItem_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("DeleteFacilityItem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:576; TYPE:UC
              Result = IsConnected(SelectedBuilding) OrElse IsConnected(SelectedFloor)
              '   END FORMULA; PROP ID:576; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_DeleteFacilityItem_USERCHANGE", ex.Message)
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
      Public Function Formula_FacilityDisplayName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FacilityItemName_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_BuildingNames_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BuildingNames").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:536; TYPE:VV
      Result = New ValidValues

For Each _building As Object In Buildings
	Result.Add(_building.BuildingName)
Next
      '   END FORMULA; PROP ID:536; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_BuildingNames_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Buildings_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:63; TYPE:PN
      
      '   END FORMULA; SUB ID:63; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_Buildings_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Buildings_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Buildings").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:63; TYPE:QF
      Result = 0
      '   END FORMULA; SUB ID:63; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_Buildings_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Buildings_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Buildings").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:63; TYPE:OP
      Result = "Building"
      '   END FORMULA; SUB ID:63; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_Buildings_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_AddBuilding_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AddBuilding").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:544; TYPE:WC
      Subparts("Buildings").AddPart("Building")
      '   END FORMULA; PROP ID:544; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_AddBuilding_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_AddFloor_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AddFloor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:545; TYPE:WC
      If IsConnected(SelectedBuilding) Then SelectedBuilding(1).Subparts("Floors").AddPart("Floor")
      '   END FORMULA; PROP ID:545; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_AddFloor_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_button_AddToClipboard_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_AddToClipboard").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1546; TYPE:WC
      FacilityClipboard.Connect(SelectedFacilityItem(1))
      '   END FORMULA; PROP ID:1546; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_button_AddToClipboard_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_button_MoveFacilityItem_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_MoveFacilityItem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1548; TYPE:WC
      Dim _clipboardItem As Object = FacilityClipboard(1)
Dim _targetItem As Object = SelectedFacilityItem(1)
Dim _targetIndex As Integer = _targetItem.FacilityIndex
Dim _index As Integer = 1
Dim _sp As Subpart = _targetItem.Owner

For Each _facilityItem As Object In _sp
	If _facilityItem IsNot _clipboardItem Then
		If _targetIndex > _index Then
			_facilityItem.Properties("FacilityIndex").InputValue = _index
		Else
			_facilityItem.Properties("FacilityIndex").InputValue += _facilityItem.FacilityIndex
		End If
	Else
		_clipboardItem.Properties("FacilityIndex").InputValue = _targetIndex
	End If

	_index += 1
Next
      '   END FORMULA; PROP ID:1548; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_button_MoveFacilityItem_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_DeleteFacilityItem_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DeleteFacilityItem").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:576; TYPE:WC
      If MessageBox.Show("Are you sure you want to delete the facility item permanently?", "Delete Facility Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
	Dim _treeItem As Object = If(IsConnected(SelectedFacilityItem), SelectedFacilityItem(1), Nothing)

	If  _treeItem IsNot Nothing AndAlso _treeItem.PartFamily <> "FacilityModel" Then
		If _treeItem.PartFamily = "Building" Then
			Dim _floors As New List(Of Object)

			For Each _floor As Object In _treeItem.Floors
				_floors.Add(_floor)
			Next

			For Each _floor As Object In _floors
				_floor.Owner.Remove(_floor.Name)
			Next
		End If

		_treeItem.Owner.Remove(_treeItem.Name)
	End If
End If
      '   END FORMULA; PROP ID:576; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_DeleteFacilityItem_WHENCHANGED", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:543; TYPE:WC
      g_RsEngineer.RefreshModelViews(0)
      '   END FORMULA; PROP ID:543; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " FacilityModel.Formula_SelectedTreeIndex_WHENCHANGED", ex.Message)
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

  