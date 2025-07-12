Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS_Demo
'$ PartFamily: HBS_Demo_TLP
'$ GenerateDate: 07/12/2025 14:07:29

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

    Public Class [HBS_Demo_TLP]
    
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

    Private this as HBS_Demo_TLP = me

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
    Select Case processId
      Case "1"
      Select Case processStep
        Case "1"
        Result = Process_DefaultProcess_Project_COMMENT()
        
        Case "2"
        Result = Process_DefaultProcess_System_COMMENT()
        
        Case "3"
        Result = Process_DefaultProcess_Plant_Devices_COMMENT()
        
        Case "4"
        Result = Process_DefaultProcess_Point_Summary_COMMENT()
        
        Case "5"
        Result = Process_DefaultProcess_Controller_COMMENT()
        End Select
        End Select
      
    Return Result
    End Function

    Public Function GetProcessStepStatus(ByVal processId As String, ByVal processStep As String) As Integer Implements RuleStream.IRsPartFormulas.GetProcessStepStatus
    Dim Result as Integer 'Long
    Select Case processId
      Case "1"
      Select Case processStep
        Case "1"
        Result = Process_DefaultProcess_Project_STATUS()
        
        Case "2"
        Result = Process_DefaultProcess_System_STATUS()
        
        Case "3"
        Result = Process_DefaultProcess_Plant_Devices_STATUS()
        
        Case "4"
        Result = Process_DefaultProcess_Point_Summary_STATUS()
        
        Case "5"
        Result = Process_DefaultProcess_Controller_STATUS()
        End Select
        End Select
      
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
    
          Public Property [PartNumber]() As String
      Get
      Return Properties("PartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartNumber").CalculatedValue = Value
      End Set
      End Property
    
      Public ReadOnly Property [CORA_Info]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("CORA_Info")
      End Get
      End Property
    
      Public ReadOnly Property [HBS_Projects]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("HBS_Projects")
      End Get
      End Property
    
      Public ReadOnly Property CreationDate() As Date
      Get
      If Properties.ContainsKey("CreationDate") Then
      Return Properties("CreationDate").Value
      Else
      Return "12:00:00 AM"
      End If
      End Get
      End Property

      Public ReadOnly Property CustomerName() As String
      Get
      If Properties.ContainsKey("CustomerName") Then
      Return Properties("CustomerName").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      Public ReadOnly Property UserID() As String
      Get
      If Properties.ContainsKey("UserID") Then
      Return Properties("UserID").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      Public ReadOnly Property UserEmail() As String
      Get
      If Properties.ContainsKey("UserEmail") Then
      Return Properties("UserEmail").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      Public ReadOnly Property UserName() As String
      Get
      If Properties.ContainsKey("UserName") Then
      Return Properties("UserName").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      Public ReadOnly Property ProjectID() As String
      Get
      If Properties.ContainsKey("ProjectID") Then
      Return Properties("ProjectID").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      Public ReadOnly Property LineItem() As Integer
      Get
      If Properties.ContainsKey("LineItem") Then
      Return Properties("LineItem").Value
      Else
      Return 0
      End If
      End Get
      End Property

      Public ReadOnly Property Release() As Integer
      Get
      If Properties.ContainsKey("Release") Then
      Return Properties("Release").Value
      Else
      Return 0
      End If
      End Get
      End Property

      Public ReadOnly Property NumberOfParts() As Integer
      Get
      If Properties.ContainsKey("NumberOfParts") Then
      Return Properties("NumberOfParts").Value
      Else
      Return 0
      End If
      End Get
      End Property

      Public ReadOnly Property CurrentDateTime() As Date
      Get
      If Properties.ContainsKey("CurrentDateTime") Then
      Return Properties("CurrentDateTime").Value
      Else
      Return "12:00:00 AM"
      End If
      End Get
      End Property

      Public ReadOnly Property CurrentProcessStep() As String
      Get
      If Properties.ContainsKey("CurrentProcessStep") Then
      Return Properties("CurrentProcessStep").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      Public ReadOnly Property CurrentProcess() As String
      Get
      If Properties.ContainsKey("CurrentProcess") Then
      Return Properties("CurrentProcess").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      Public ReadOnly Property CurrentDrawing() As String
      Get
      If Properties.ContainsKey("CurrentDrawing") Then
      Return Properties("CurrentDrawing").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      'This is added to handle update Rules error coming for __RSLocale
      Public ReadOnly Property __RSLocale() As String
      Get
      If Properties.ContainsKey("__RSLocale") Then
      Return Properties("__RSLocale").Value
      Else
      Return "en-US"
      End If
      End Get
      End Property

      Public ReadOnly Property __TimeZone() As String
      Get
      If Properties.ContainsKey("__TimeZone") Then
      Return Properties("__TimeZone").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      'how to get the UDFs?
    
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
    InitPart("HBS_Demo_TLP", <a><![CDATA[HBS Demo]]></a>.Value, 1, "HBS_Demo",  "", "", False, True, "In Development", "RuleStream", "Top-level part for the HBS Demo application.", "", "", "",  "GLOBAL\H601423", "03/18/2025 19:28:31")
    AddProperty("1", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/21/2025 6:51:35 PM")
    
      oSubpart = AddSubpart(19,"CORA_Info", <a><![CDATA[CORA Info]]></a>.Value, "FD", "Subpart with the CORA data.", "CORA Data", 9999, "CORA", "GLOBAL\H601423", "3/18/2025 7:28:31 PM")
      
        oSubpart.AddVPF (19, "CORA_Project_Information", "CORA Project Information")
      
      oSubpart = AddSubpart(1,"HBS_Projects", <a><![CDATA[HBS Projects]]></a>.Value, "FD", "Projects subpart with RS-friendly name.", "Subparts and Connections", 9999, "RuleStream", "GLOBAL\SVRSDevAdmin", "2/21/2025 6:56:01 PM")
      
        oSubpart.AddVPF (2, "HBS_Project", "HBS Project")
      
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Sub Initialize_Process(ByVal lngProcessID as Integer) Implements RuleStream.IRsPartFormulas.InitializeProcess
    Select Case lngProcessID
    
      Case 1
      Process = "DefaultProcess"	
        Initialize_Process_DefaultProcess_Project()
        Initialize_Process_DefaultProcess_System()
        Initialize_Process_DefaultProcess_Plant_Devices()
        Initialize_Process_DefaultProcess_Point_Summary()
        Initialize_Process_DefaultProcess_Controller()
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
        Private Sub Initialize_Process_DefaultProcess_Project()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(1, "Project", "", 1, 1, 1, 1, 50, 50)
        oProcessStep.AddPath("HBS_Demo_TLP.HBS_Projects/HBS_Project")
        oProcessStep.AddFilter(1, 1, "System", 0, "PartNumber", 0)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 2, "1", "0", "RsLabel", 0, "", 9, 12, 32, 357, 0, "Project", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.15;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "2", "0", "RsNextStepActionButton", 0, "", 294, 347, 23, 75, 1, "Next", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 2, "3", "0", "RsGroupBox", 0, "", 335, 16, 200, 424, 2, "User Stories", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "4", "3", "RsTextbox", 0, "Story_Point_Data_1", 19, 7, 138, 399, 3, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "5", "0", "RsGroupBox", 0, "", 54, 12, 225, 428, 4, "Project Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "6", "5", "RsLabel", 0, "", 25, 28, 21, 110, 5, "Pole", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "7", "5", "RsComboBox", 0, "Pole", 24, 144, 22, 266, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "8", "5", "RsLabel", 0, "", 53, 28, 21, 110, 7, "Region", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "9", "5", "RsComboBox", 0, "Region", 52, 144, 22, 266, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "10", "5", "RsLabel", 0, "", 81, 28, 21, 110, 9, "District", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "11", "5", "RsComboBox", 0, "District", 80, 144, 22, 266, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "12", "5", "RsLabel", 0, "", 109, 28, 21, 110, 11, "Project Number", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "13", "5", "RsTextbox", 0, "ProjectNumber", 108, 144, 22, 266, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "14", "5", "RsLabel", 0, "", 137, 28, 21, 110, 13, "Project Name", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "15", "5", "RsTextbox", 0, "ProjectName", 136, 144, 22, 266, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "16", "5", "RsLabel", 0, "", 165, 2, 21, 136, 15, "Honeywell Engineer", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "17", "5", "RsTextbox", 0, "HoneywellEngineer", 164, 144, 22, 266, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "18", "5", "RsLabel", 0, "", 193, 28, 21, 110, 17, "Site Address", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "19", "5", "RsTextbox", 0, "SiteAddress", 192, 144, 22, 266, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_System()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(2, "System", "The Systems in the Project.", 1, 1, 1, 2, 50, 50)
        oProcessStep.AddPath("HBS_Demo_TLP.HBS_Projects/HBS_Project")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 2, "1", "0", "RsSubForm", 0, "", 2, 576, 464, 571, 0, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,2,HBS_Systems")
        oProcessStep.AddCustomLayout(1, 2, "2", "1", "RsSubForm", 0, "", 272, 15, 189, 467, 1, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,3,Plants")
        oProcessStep.AddCustomLayout(1, 2, "3", "2", "RsGroupBox", 0, "", 3, 3, 165, 402, 2, "Plant Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "4", "3", "RsLabel", 0, "", 20, 6, 21, 180, 3, "Plant Name", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "5", "3", "RsTextbox", 0, "PlantName", 19, 193, 22, 200, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "6", "3", "RsLabel", 0, "", 49, 6, 21, 180, 5, "Plant Type", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "7", "3", "RsTextbox", 0, "PlantType", 48, 193, 22, 200, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "8", "3", "RsLabel", 0, "", 77, 6, 21, 180, 7, "Spare Capacity for PS Sizing", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "9", "3", "RsTextbox", 0, "SpareCapacityForPSSizing", 76, 193, 22, 200, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "10", "3", "RsLabel", 0, "", 105, 6, 21, 180, 9, "Spare Capacity for Controller", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "11", "3", "RsTextbox", 0, "SpareCapacityForControllers", 104, 193, 22, 200, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "12", "1", "RsLabel", 0, "", 1, 15, 32, 396, 11, "Plants", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.15;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "13", "1", "RsGrid", 0, "", 35, 15, 188, 405, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,3,Plants;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 2, "14", "13", "RsGridColumn", 0, "PlantName", 0, 0, 0, 150, 0, "Plant Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "15", "13", "RsGridColumn", 0, "PlantType", 0, 0, 0, 200, 0, "Plant Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "16", "1", "RsAddDeleteCopy", 0, "", 229, 15, 27, 211, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,3,Plants;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 2, "17", "0", "RsSubForm", 0, "", 274, 3, 192, 555, 14, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,2,HBS_Systems")
        oProcessStep.AddCustomLayout(1, 2, "18", "17", "RsGroupBox", 0, "", 3, 9, 165, 540, 15, "System Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "19", "18", "RsLabel", 0, "", 20, 6, 21, 174, 16, "System Name", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "20", "18", "RsTextbox", 0, "SystemName", 19, 186, 22, 200, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "21", "18", "RsLabel", 0, "", 48, 6, 21, 174, 18, "System Description", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "22", "18", "RsTextbox", 0, "SystemDescription", 47, 186, 22, 200, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "23", "18", "RsLabel", 0, "", 76, 6, 21, 174, 20, "Target Hardware", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "24", "18", "RsTextbox", 0, "TargetHardware", 75, 186, 22, 200, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "25", "18", "RsLabel", 0, "", 104, 6, 21, 174, 22, "Spare Capacity for PS Sizing", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "26", "18", "RsTextbox", 0, "SpareCapacityForPSSizing", 103, 186, 22, 200, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "27", "18", "RsLabel", 0, "", 132, 6, 21, 174, 24, "Spare Capacity for Controller", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "28", "18", "RsTextbox", 0, "SpareCapacityForControllers", 131, 186, 22, 200, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "29", "0", "RsLabel", 0, "", 2, 12, 32, 540, 26, "System", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.15;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "30", "0", "RsGroupBox", 0, "", 524, 3, 200, 555, 27, "User Stories", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "31", "30", "RsTextbox", 0, "Story_Point_Data_2", 19, 9, 164, 529, 28, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "32", "0", "RsGrid", 0, "", 37, 12, 188, 540, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,2,HBS_Systems;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 2, "33", "32", "RsGridColumn", 0, "SystemName", 0, 0, 0, 150, 0, "System Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "34", "32", "RsGridColumn", 0, "SystemDescription", 0, 0, 0, 200, 0, "System Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "35", "32", "RsGridColumn", 0, "TargetHardware", 0, 0, 0, 150, 0, "Target Hardware", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "36", "0", "RsAddDeleteCopy", 0, "", 231, 12, 27, 211, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,2,HBS_Systems;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 2, "37", "0", "RsPrevStepActionButton", 0, "", 472, 12, 23, 75, 31, "Prev", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 2, "38", "0", "RsNextStepActionButton", 0, "", 472, 477, 23, 75, 32, "Next", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Plant_Devices()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(3, "Plant Devices", "The Plant Devices for the Project.", 1, 1, 1, 3, 50, 50)
        oProcessStep.AddPath("HBS_Demo_TLP.HBS_Projects/HBS_Project")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 2, "1", "0", "RsGroupBox", 0, "", 35, 7, 272, 1250, 0, "Plants", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "2", "1", "RsGrid", 0, "", 25, 7, 223, 623, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,1,AllPlants;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 2, "3", "2", "RsGridColumn", 0, "PlantName", 0, 0, 0, 200, 0, "Plant Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "4", "2", "RsGridColumn", 0, "SystemName", 0, 0, 0, 200, 0, "System Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "5", "2", "RsGridColumn", 0, "PlantType", 0, 0, 0, 200, 0, "Plant Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "6", "1", "RsSubForm", 0, "", 14, 636, 242, 600, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,1,AllPlants")
        oProcessStep.AddCustomLayout(1, 2, "7", "6", "RsGroupBox", 0, "", 3, 8, 192, 580, 3, "Default Library", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "8", "7", "RsLabel", 0, "", 20, 122, 21, 90, 4, "Library", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "9", "7", "RsComboBox", 0, "Search_Default_Library", 19, 218, 22, 175, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "10", "7", "RsLabel", 0, "", 48, 74, 21, 42, 6, "Filter 1", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "11", "7", "RsLabel", 0, "", 48, 122, 21, 90, 7, "Application Use", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "12", "7", "RsComboBox", 0, "ApplicationUse", 47, 218, 22, 175, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "13", "7", "RsLabel", 0, "", 76, 74, 21, 42, 9, "Filter 2", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "14", "7", "RsLabel", 0, "", 76, 123, 21, 90, 10, "Process Variable", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "15", "7", "RsComboBox", 0, "ProcessVariable", 75, 218, 22, 175, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "16", "7", "RsLabel", 0, "", 104, 74, 21, 42, 12, "Filter 3", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "17", "7", "RsLabel", 0, "", 104, 122, 21, 90, 13, "Part Type", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "18", "7", "RsComboBox", 0, "PartType", 103, 218, 22, 175, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "19", "7", "RsLabel", 0, "", 132, 6, 21, 110, 15, "Part Description", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "20", "7", "RsTextbox", 0, "Search_Part_Description", 131, 122, 22, 447, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "21", "7", "RsLabel", 0, "", 159, 6, 21, 110, 17, "Part Number", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "22", "7", "RsComboBox", 0, "DevicePartNumber", 159, 122, 22, 447, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "23", "6", "RsButton", 0, "button_AddDevice", 206, 8, 30, 130, 19, "Add Device", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 2, "24", "0", "RsGroupBox", 0, "", 313, 7, 371, 1250, 20, "Devices", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "25", "24", "RsSubForm", 0, "", 19, 3, 339, 1240, 21, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,1,AllPlants")
        oProcessStep.AddCustomLayout(1, 2, "26", "25", "RsGrid", 0, "", 3, 3, 319, 623, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,4,Devices;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 2, "27", "26", "RsGridColumn", 0, "DevicePartNumber", 0, 0, 0, 250, 0, "Part Number", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "28", "26", "RsGridColumn", 0, "DeviceType", 0, 0, 0, 100, 0, "Device Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "29", "26", "RsGridColumn", 0, "PartShape", 0, 0, 0, 100, 0, "Part Shape", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "30", "26", "RsGridColumn", 0, "PartType", 0, 0, 0, 150, 0, "Part Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "31", "25", "RsSubForm", 0, "", 3, 635, 333, 590, 23, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,4,Devices")
        oProcessStep.AddCustomLayout(1, 2, "32", "31", "RsGroupBox", 0, "", 0, 6, 327, 343, 24, "Device Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "33", "32", "RsLabel", 0, "", 16, 6, 21, 86, 25, "Description", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "34", "32", "RsTextbox", 0, "PartDescription", 15, 98, 22, 232, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "35", "32", "RsLabel", 0, "", 44, 6, 21, 86, 27, "Mnemonics", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "36", "32", "RsTextbox", 0, "Mnemonics", 43, 98, 22, 232, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "37", "32", "RsLabel", 0, "", 72, 6, 21, 86, 29, "Power Supply", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "38", "32", "RsTextbox", 0, "PowerSupply", 71, 98, 22, 232, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "39", "32", "RsLabel", 0, "", 190, 6, 21, 86, 31, "Process Variable", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "40", "32", "RsLabel", 0, "", 128, 6, 21, 86, 32, "Device Type", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "41", "32", "RsLabel", 0, "", 159, 6, 21, 86, 33, "Signal Type", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "42", "32", "RsLabel", 0, "", 100, 6, 21, 86, 34, "Wiring Type", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "43", "32", "RsTextbox", 0, "ProcessVariable", 189, 98, 22, 232, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "44", "32", "RsTextbox", 0, "DeviceType", 127, 98, 22, 232, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "45", "32", "RsTextbox", 0, "SignalType", 158, 98, 22, 232, 37, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "46", "32", "RsTextbox", 0, "WiringType", 99, 98, 22, 232, 38, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "47", "31", "RsGroupBox", 0, "", 3, 355, 115, 232, 39, "Terminal Block", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "48", "47", "RsLabel", 0, "", 25, 6, 21, 110, 40, "Block Label", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "49", "47", "RsTextbox", 0, "TerminalBlockLabel", 24, 122, 22, 100, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "50", "47", "RsLabel", 0, "", 53, 6, 21, 110, 42, "Block Other Label", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "51", "47", "RsTextbox", 0, "TerminalBlockOtherLabel", 52, 122, 22, 100, 43, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "52", "47", "RsLabel", 0, "", 81, 6, 21, 110, 44, "Point Block Link", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "53", "47", "RsTextbox", 0, "PointTerminalBlockLink", 80, 122, 22, 100, 45, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "54", "31", "RsPictureBox", 0, "Image_RSE", 124, 355, 145, 232, 46, "", 0, 0, 0, 5, 0, "", "", "Filename:Device_Image.png;IsGeneratedImg:False;RsTooltip:;")
        oProcessStep.AddCustomLayout(1, 2, "55", "0", "RsPrevStepActionButton", 0, "", 690, 13, 23, 75, 47, "Prev", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 2, "56", "0", "RsNextStepActionButton", 0, "", 690, 547, 23, 75, 48, "Next", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 2, "57", "0", "RsGroupBox", 0, "", 719, 7, 200, 629, 49, "User Stories", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "58", "57", "RsTextbox", 0, "Story_Point_Data_3", 24, 7, 164, 529, 50, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "59", "0", "RsLabel", 0, "", 0, 7, 32, 540, 51, "Plant Devices", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.15;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Point_Summary()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(4, "Point Summary", "A summary of the Points on the System.", 1, 1, 1, 4, 50, 50)
        oProcessStep.AddPath("HBS_Demo_TLP.HBS_Projects/HBS_Project")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 2, "1", "0", "RsGroupBox", 0, "", 32, 12, 850, 987, 0, "Systems", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "2", "1", "RsGrid", 0, "", 17, 17, 200, 450, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,2,HBS_Systems;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 2, "3", "2", "RsGridColumn", 0, "SystemName", 0, 0, 0, 100, 0, "System Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "4", "2", "RsGridColumn", 0, "SystemDescription", 0, 0, 0, 200, 0, "System Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "5", "2", "RsGridColumn", 0, "TargetHardware", 0, 0, 0, 100, 0, "Target Hardware", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "6", "1", "RsSubForm", 0, "", 225, 6, 619, 961, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,2,HBS_Systems")
        oProcessStep.AddCustomLayout(1, 2, "7", "6", "RsGroupBox", 0, "", 310, 3, 299, 946, 3, "Point Summary (&amp;apos;X&amp;apos; View)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "8", "7", "RsGrid", 0, "", 20, 8, 270, 930, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,2,AllDevices;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 2, "9", "8", "RsGridColumn", 0, "PartNumber", 0, 0, 0, 100, 0, "Part Number", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "10", "8", "RsGridColumn", 0, "PartDescription", 0, 0, 0, 225, 0, "Part Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "11", "8", "RsGridColumn", 0, "PointType", 0, 0, 0, 60, 0, "Point Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "12", "8", "RsGridColumn", 0, "PointParameters", 0, 0, 0, 150, 0, "Point Parameters", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "13", "8", "RsGridColumn", 0, "Summary_AI_XView", 0, 0, 0, 40, 0, "AI", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "14", "8", "RsGridColumn", 0, "Summary_AO_XView", 0, 0, 0, 40, 0, "AO", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "15", "8", "RsGridColumn", 0, "Summary_DI_XView", 0, 0, 0, 40, 0, "DI", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "16", "8", "RsGridColumn", 0, "Summary_DO_XView", 0, 0, 0, 40, 0, "DO", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "17", "8", "RsGridColumn", 0, "PointTerminalBlockLink", 0, 0, 0, 140, 0, "Pt Block Link", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "18", "6", "RsGroupBox", 0, "", 6, 3, 298, 946, 5, "Point Summary (Qty View)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "19", "18", "RsGrid", 0, "", 19, 6, 270, 930, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,2,AllDevices;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 2, "20", "19", "RsGridColumn", 0, "PartNumber", 0, 0, 0, 100, 0, "Part Number", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "21", "19", "RsGridColumn", 0, "PartDescription", 0, 0, 0, 225, 0, "Part Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "22", "19", "RsGridColumn", 0, "PointType", 0, 0, 0, 60, 0, "Point Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "23", "19", "RsGridColumn", 0, "PointParameters", 0, 0, 0, 150, 0, "Point Parameters", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "24", "19", "RsGridColumn", 0, "Summary_AI_Qty", 0, 0, 0, 40, 0, "AI", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "25", "19", "RsGridColumn", 0, "Summary_AO_Qty", 0, 0, 0, 40, 0, "AO", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "26", "19", "RsGridColumn", 0, "Summary_DI_Qty", 0, 0, 0, 40, 0, "DI", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "27", "19", "RsGridColumn", 0, "Summary_DO_Qty", 0, 0, 0, 40, 0, "DO", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "28", "19", "RsGridColumn", 0, "PointTerminalBlockLink", 0, 0, 0, 140, 0, "Pt Block Link", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "29", "0", "RsPrevStepActionButton", 0, "", 888, 24, 23, 75, 7, "Prev", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 2, "30", "0", "RsNextStepActionButton", 0, "", 888, 404, 23, 75, 8, "Next", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 2, "31", "0", "RsGroupBox", 0, "", 32, 1026, 219, 555, 9, "User Stories", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "32", "31", "RsTextbox", 0, "Story_Point_Data_4", 19, 6, 186, 533, 10, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "33", "0", "RsLabel", 0, "", -3, 12, 32, 540, 11, "Point Summary", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.15;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Controller()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(5, "Controller", "A controller for the System.", 1, 1, 1, 5, 50, 50)
        oProcessStep.AddPath("HBS_Demo_TLP.HBS_Projects/HBS_Project")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 2, "1", "0", "RsGroupBox", 0, "", 44, 12, 376, 530, 0, "Plants", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "2", "1", "RsGrid", 0, "", 22, 6, 211, 500, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,1,AllPlants;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 2, "3", "2", "RsGridColumn", 0, "PlantName", 0, 0, 0, 100, 0, "Plant Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "4", "2", "RsGridColumn", 0, "SystemName", 0, 0, 0, 125, 0, "System Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "5", "2", "RsGridColumn", 0, "PlantType", 0, 0, 0, 120, 0, "Plant Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "6", "2", "RsGridColumn", 0, "PointSummary", 0, 0, 0, 120, 0, "Points (AI,AO,DI,DO)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 2, "7", "1", "RsSubForm", 0, "", 243, 3, 121, 511, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,1,AllPlants")
        oProcessStep.AddCustomLayout(1, 2, "8", "7", "RsGroupBox", 0, "", 3, 6, 102, 497, 3, "Plant Controller Preferences", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "9", "8", "RsComboBox", 0, "ControllerDefaultPartNumber", 24, 143, 22, 347, 4, "", 4, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "10", "8", "RsLabel", 0, "", 24, 6, 21, 130, 5, "Default Controller PN", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "11", "8", "RsLabel", 0, "", 55, 6, 21, 131, 6, "Controller Point Capacities", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "12", "8", "RsTextbox", 0, "ControllerPointCapacities", 54, 143, 22, 61, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "13", "8", "RsLabel", 0, "", 55, 210, 21, 70, 8, "AI,AO,DI,DO", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "14", "8", "RsLabel", 0, "", 75, 6, 21, 131, 9, "Controller Qty Req&amp;apos;d", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 2, "15", "8", "RsTextbox", 0, "ControllerQuantity", 74, 143, 22, 61, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "16", "0", "RsPrevStepActionButton", 0, "", 426, 12, 23, 75, 11, "Prev", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 2, "17", "0", "RsGroupBox", 0, "", 512, 12, 233, 555, 12, "User Stories", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 2, "18", "17", "RsTextbox", 0, "Story_Point_Data_5", 19, 6, 200, 529, 13, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 2, "19", "0", "RsLabel", 0, "", 9, 12, 32, 540, 14, "Controller", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.15;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
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
          
        InitSubpart("CORA_Info", 19, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "3/18/2025 7:28:31 PM", "", "In Development", "N",0,41,40)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("HBS_Projects", 1, "", "", "Y", 0, "-1", "", "GLOBAL\SVRSDevAdmin", "2/21/2025 6:54:10 PM", "", "In Development", "Y",0,2,1)
        
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
      Public Function Process_DefaultProcess_Project_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:1; TYPE:ST
      Result = STATUS_ENABLED
      '   END FORMULA; PROC ID:1; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Process_DefaultProcess_Project_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Project_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:1; TYPE:CO
      Result = ""

Dim SB As New System.Text.Stringbuilder()

SB.Appendline("User Stories")
SB.Appendline("-------------------------------------------------")
SB.AppendLine("Story X123")
SB.AppendLine("-  Story X123 Notes")
SB.AppendLine("Story Y345")
SB.AppendLine("-  Story Y345 Notes")

SB.Appendline(Me.HBS_Projects(1).Story_Point_Data_2)

Result = SB.ToString()
      '   END FORMULA; PROC ID:1; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Process_DefaultProcess_Project_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_System_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:2; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:2; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Process_DefaultProcess_System_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_System_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:2; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:2; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Process_DefaultProcess_System_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Plant_Devices_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:3; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:3; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Process_DefaultProcess_Plant_Devices_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Plant_Devices_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:3; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:3; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Process_DefaultProcess_Plant_Devices_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Point_Summary_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:4; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:4; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Process_DefaultProcess_Point_Summary_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Point_Summary_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:4; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:4; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Process_DefaultProcess_Point_Summary_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Controller_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:5; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:5; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Process_DefaultProcess_Controller_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Controller_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:5; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:5; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Process_DefaultProcess_Controller_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CORA_Info_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:19; TYPE:PN
      
      '   END FORMULA; SUB ID:19; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Formula_CORA_Info_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CORA_Info_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("CORA_Info").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:19; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:19; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Formula_CORA_Info_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CORA_Info_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("CORA_Info").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:19; TYPE:OP
      result = "CORA_Project_Information"
      '   END FORMULA; SUB ID:19; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Formula_CORA_Info_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HBS_Projects_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:1; TYPE:PN
      
      '   END FORMULA; SUB ID:1; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Formula_HBS_Projects_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HBS_Projects_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("HBS_Projects").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:1; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:1; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Formula_HBS_Projects_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HBS_Projects_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("HBS_Projects").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:1; TYPE:OP
      result = "HBS_Project"
      '   END FORMULA; SUB ID:1; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_Demo_TLP.Formula_HBS_Projects_OPTIMALPARTFAMILY", ex.Message)
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

  