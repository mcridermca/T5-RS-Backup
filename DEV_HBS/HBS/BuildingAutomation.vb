Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: BuildingAutomation
'$ GenerateDate: 06/19/2025 19:33:03

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

    Public Class [BuildingAutomation]
    
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

    Private this as BuildingAutomation = me

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
      Case "2"
      Select Case processStep
        Case "8"
        Result = Process_Building_Automation_Create_New__Project_COMMENT()
        
        Case "18"
        Result = Process_Building_Automation_Facility_View_COMMENT()
        
        Case "6"
        Result = Process_Building_Automation_Group_System_Plant_COMMENT()
        
        Case "13"
        Result = Process_Building_Automation_Add_Manage_Devices_COMMENT()
        
        Case "11"
        Result = Process_Building_Automation_Plant_IO_Point_Summary_COMMENT()
        
        Case "12"
        Result = Process_Building_Automation_Power_Supplies_COMMENT()
        
        Case "9"
        Result = Process_Building_Automation_Plant_Devices_COMMENT()
        
        Case "10"
        Result = Process_Building_Automation_Controller_COMMENT()
        
        Case "14"
        Result = Process_Building_Automation_Reports_COMMENT()
        
        Case "17"
        Result = Process_Building_Automation_Drawings_COMMENT()
        End Select
        End Select
      
    Return Result
    End Function

    Public Function GetProcessStepStatus(ByVal processId As String, ByVal processStep As String) As Integer Implements RuleStream.IRsPartFormulas.GetProcessStepStatus
    Dim Result as Integer 'Long
    Select Case processId
      Case "2"
      Select Case processStep
        Case "8"
        Result = Process_Building_Automation_Create_New__Project_STATUS()
        
        Case "18"
        Result = Process_Building_Automation_Facility_View_STATUS()
        
        Case "6"
        Result = Process_Building_Automation_Group_System_Plant_STATUS()
        
        Case "13"
        Result = Process_Building_Automation_Add_Manage_Devices_STATUS()
        
        Case "11"
        Result = Process_Building_Automation_Plant_IO_Point_Summary_STATUS()
        
        Case "12"
        Result = Process_Building_Automation_Power_Supplies_STATUS()
        
        Case "9"
        Result = Process_Building_Automation_Plant_Devices_STATUS()
        
        Case "10"
        Result = Process_Building_Automation_Controller_STATUS()
        
        Case "14"
        Result = Process_Building_Automation_Reports_STATUS()
        
        Case "17"
        Result = Process_Building_Automation_Drawings_STATUS()
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
    
          Public Property [EnableDrawings]() As Boolean
      Get
      Return Properties("EnableDrawings").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("EnableDrawings").CalculatedValue = Value
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
    
          Public Property [CORAInfoNotSavedText]() As String
      Get
      Return Properties("CORAInfoNotSavedText").Value
      End Get
      Set(ByVal Value As String)
      Properties("CORAInfoNotSavedText").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CORAInfoSaved]() As Boolean
      Get
      Return Properties("CORAInfoSaved").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("CORAInfoSaved").CalculatedValue = Value
      End Set
      End Property
    
      Public ReadOnly Property [CORA_Info]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("CORA_Info")
      End Get
      End Property
    
      Public ReadOnly Property [Drawings]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Drawings")
      End Get
      End Property
    
      Public ReadOnly Property [FacilityView]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("FacilityView")
      End Get
      End Property
    
      Public ReadOnly Property [PlantView]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("PlantView")
      End Get
      End Property
    
      Public ReadOnly Property [PowerSupplyView]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("PowerSupplyView")
      End Get
      End Property
    
      Public ReadOnly Property [Project_Info]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Project_Info")
      End Get
      End Property
    
      Public ReadOnly Property [SiteInfo]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("SiteInfo")
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
    InitPart("BuildingAutomation", <a><![CDATA[Building Automation]]></a>.Value, 15, "HBS",  "", "", True, True, "In Development", "", "", "", "", "",  "GLOBAL\H601421", "06/18/2025 17:06:48")
    AddProperty("584", "EnableDrawings", <a><![CDATA[EnableDrawings]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H599123", "4/25/2025 5:34:13 AM")
    AddProperty("170", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601421", "3/14/2025 2:49:31 AM")
    AddProperty("441", "CORAInfoNotSavedText", <a><![CDATA[CORA Info Not Saved Text]]></a>.Value, "Text to display if the CORA Info has not yet been saved.", "String","","UI Control","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "4/14/2025 2:48:47 PM")
    AddProperty("440", "CORAInfoSaved", <a><![CDATA[CORA Info Saved]]></a>.Value, "Has the CORA Project Info been locked-in by a Model Save?", "Boolean","","UI Control","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\SVRSDevAdmin", "4/17/2025 2:20:46 AM")
    
      oSubpart = AddSubpart(18,"CORA_Info", <a><![CDATA[CORA Info]]></a>.Value, "FD", "Data imported from CORA.", "CORA Data", 9999, "CORA", "GLOBAL\H601423", "3/17/2025 1:12:36 PM")
      
        oSubpart.AddVPF (19, "CORA_Project_Information", "CORA Project Information")
      
      oSubpart = AddSubpart(32,"Drawings", <a><![CDATA[Drawings]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H599123", "4/25/2025 5:40:57 AM")
      
        oSubpart.AddVPF (29, "Drawing", "Drawing")
      
      oSubpart = AddSubpart(62,"FacilityView", <a><![CDATA[Facility View]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601421", "4/25/2025 3:13:17 AM")
      
        oSubpart.AddVPF (44, "FacilityModel", "Facility Model")
      
      oSubpart = AddSubpart(26,"PlantView", <a><![CDATA[Plant View]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601421", "4/20/2025 3:30:00 AM")
      
        oSubpart.AddVPF (24, "PlantModel", "Plant Model")
      
      oSubpart = AddSubpart(67,"PowerSupplyView", <a><![CDATA[Power Supply View]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601421", "6/18/2025 5:06:48 PM")
      
        oSubpart.AddVPF (48, "PowerSupplyModel", "Power Supply Model")
      
      oSubpart = AddSubpart(65,"Project_Info", <a><![CDATA[Project_Info]]></a>.Value, "FD", "Subpart for project information that is not imported from CORA.", "Subparts and Connections", 9999, "HBS", "GLOBAL\H601423", "5/6/2025 5:33:43 PM")
      
        oSubpart.AddVPF (47, "Project_Information", "Project_Information")
      
      oSubpart = AddSubpart(12,"SiteInfo", <a><![CDATA[Site Info]]></a>.Value, "FD", "", "Subparts and Connections", 9999, "", "GLOBAL\H601423", "3/17/2025 1:05:30 PM")
      
        oSubpart.AddVPF (16, "Site", "Site")
      
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Sub Initialize_Process(ByVal lngProcessID as Integer) Implements RuleStream.IRsPartFormulas.InitializeProcess
    Select Case lngProcessID
    
      Case 2
      Process = "Building Automation"	
        Initialize_Process_Building_Automation_Create_New__Project()
        Initialize_Process_Building_Automation_Facility_View()
        Initialize_Process_Building_Automation_Group_System_Plant()
        Initialize_Process_Building_Automation_Add_Manage_Devices()
        Initialize_Process_Building_Automation_Plant_IO_Point_Summary()
        Initialize_Process_Building_Automation_Power_Supplies()
        Initialize_Process_Building_Automation_Plant_Devices()
        Initialize_Process_Building_Automation_Controller()
        Initialize_Process_Building_Automation_Reports()
        Initialize_Process_Building_Automation_Drawings()
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
        Private Sub Initialize_Process_Building_Automation_Create_New__Project()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(8, "Create New  Project", "A view of the Project info", 1, 2, 1, 1, 50, 50)
        oProcessStep.AddPath("BuildingAutomation")
        oProcessStep.AddPath("BuildingAutomation.CORA_Info/CORA_Project_Information")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 15, "1", "0", "RsLabel", 0, "", 9, 12, 42, 497, 0, "Project / CORA Info", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.20;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "2", "0", "RsGrid", 0, "", 54, 12, 123, 630, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,18,CORA_Info;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 15, "3", "2", "RsGridColumn", 0, "Project_Code", 0, 0, 0, 120, 0, "Project Number", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 15, "4", "2", "RsGridColumn", 0, "ERP_Project_Description", 0, 0, 0, 270, 0, "Project Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 15, "5", "2", "RsGridColumn", 0, "Customer_Name", 0, 0, 0, 210, 0, "Customer Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 15, "6", "0", "RsSubForm", 0, "", 211, 12, 158, 1145, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,18,CORA_Info")
        oProcessStep.AddCustomLayout(1, 15, "7", "6", "RsLabel", 0, "", 41, 4, 21, 68, 3, "Search Field", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "8", "6", "RsLabel", 0, "", 124, 1003, 21, 53, 4, "Currency", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "9", "6", "RsTextbox", 0, "Revenue_Type_Description_3", 124, 914, 22, 70, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "10", "6", "RsLabel", 0, "", 96, 534, 21, 68, 6, "Booking Date", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "11", "6", "RsLabel", 0, "", 67, 751, 21, 45, 7, "Vertical", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "12", "6", "RsLabel", 0, "", 68, 534, 21, 68, 8, "Project Pole", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "13", "6", "RsTextbox", 0, "Solution", 66, 1007, 22, 125, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "14", "6", "RsLabel", 0, "", 68, 4, 21, 68, 10, "Project Name", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "15", "6", "RsComboBox", 0, "Project_Code", 40, 78, 22, 170, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "16", "6", "RsTextbox", 0, "ERP_Project_Description", 68, 78, 22, 450, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "17", "6", "RsLabel", 0, "", 125, 838, 21, 70, 13, "Ex Rate (USD)", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "18", "6", "RsTextbox", 0, "Currency_Local", 122, 1062, 22, 70, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "19", "6", "RsTextbox", 0, "Project_Status", 29, 1009, 22, 125, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "20", "6", "RsLabel", 0, "", 125, 686, 21, 70, 16, "Rev (Local)", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "21", "6", "RsTextbox", 0, "Revenue_Type_Description_2", 124, 762, 22, 70, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "22", "6", "RsLabel", 0, "", 125, 534, 21, 70, 18, "Rev (USD)", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "23", "6", "RsTextbox", 0, "Revenue_Type_Description_1", 124, 610, 22, 70, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "24", "6", "RsLabel", 0, "", 95, 933, 21, 68, 20, "District", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "25", "6", "RsLabel", 0, "", 95, 751, 21, 45, 21, "Region", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "26", "6", "RsLabel", 0, "", 67, 933, 21, 68, 22, "Solution", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "27", "6", "RsTextbox", 0, "Profit_Center", 94, 1007, 22, 125, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "28", "6", "RsTextbox", 0, "Region", 94, 802, 22, 125, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "29", "6", "RsLabel", 0, "", 30, 935, 21, 68, 25, "Project Status", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "30", "6", "RsTextbox", 0, "", 95, 608, 22, 125, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "31", "6", "RsTextbox", 0, "SubLOB", 66, 802, 22, 125, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "32", "6", "RsTextbox", 0, "Pole", 67, 608, 22, 125, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "33", "6", "RsLabel", 0, "", 30, 753, 21, 45, 29, "LOB", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "34", "6", "RsLabel", 0, "", 31, 536, 21, 68, 30, "Acct Name", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "35", "6", "RsTextbox", 0, "LOB", 29, 804, 22, 125, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "36", "6", "RsPanel", 0, "", 10, 78, 22, 230, 32, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 15, "37", "36", "RsRadioButton", 0, "Info_From_CORA", 3, 8, 18, 117, 33, "Select from CORA", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "38", "36", "RsRadioButton", 0, "Info_From_CORA", 3, 131, 18, 94, 34, "Manual Entry", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "39", "6", "RsTextbox", 0, "Account_Name", 30, 610, 22, 125, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "40", "6", "RsLabel", 0, "", 11, 4, 21, 68, 36, "Project Info", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "41", "6", "RsComboBox", 0, "Project_Code", 96, 78, 22, 170, 37, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "42", "6", "RsLabel", 0, "", 97, 4, 21, 68, 38, "Project #", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "43", "6", "RsLabel", 0, "", 93, 254, 28, 91, 39, "Opportunity Number*", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "44", "6", "RsTextbox", 0, "SFDC_Opportunity_ID", 96, 351, 22, 177, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "45", "0", "RsAddDeleteCopy", 0, "", 183, 12, 22, 158, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,18,CORA_Info;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 15, "46", "0", "RsLabel", 0, "CORAInfoNotSavedText", 54, 652, 74, 482, 42, "", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.14;Font_Style:1.;ForeColor:Red;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "47", "0", "RsActionButton", 0, "", 131, 836, 23, 117, 43, "Save Model", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:HBS_CORAInfo_SaveModel;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 15, "48", "0", "RsGroupBox", 0, "", 375, 12, 640, 1145, 44, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "49", "48", "RsSubForm", 0, "", 349, 139, 29, 324, 45, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,18,CORA_Info")
        oProcessStep.AddCustomLayout(1, 15, "50", "49", "RsTextbox", 0, "Sales_Rep_EID", 6, 188, 22, 130, 46, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "51", "49", "RsTextbox", 0, "Sales_Rep", 6, 3, 22, 150, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "52", "49", "RsLabel", 0, "", 8, 159, 20, 24, 48, "EID", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "53", "48", "RsLabel", 0, "", 440, 11, 21, 125, 49, "Project Type*", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "54", "48", "RsActionButton", 0, "", 589, 381, 23, 115, 50, "Cancel", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 15, "55", "48", "RsLabel", 0, "", 412, 11, 21, 125, 51, "Honeywell Designer*", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "56", "48", "RsLabel", 0, "", 384, 11, 21, 125, 52, "Honeywell Technician", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "57", "48", "RsLabel", 0, "", 356, 11, 21, 125, 53, "Sales Rep", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "58", "48", "RsSubForm", 0, "", 378, 139, 55, 324, 54, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,65,Project_Info")
        oProcessStep.AddCustomLayout(1, 15, "59", "58", "RsTextbox", 0, "Honeywell_Technician_EID", 3, 188, 22, 130, 55, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "60", "58", "RsTextbox", 0, "Honeywell_Technician", 3, 3, 22, 150, 56, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "61", "58", "RsTextbox", 0, "Honeywell_Designer", 31, 3, 22, 150, 57, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "62", "58", "RsTextbox", 0, "Honeywell_Designer_EID", 31, 188, 22, 130, 58, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "63", "58", "RsLabel", 0, "", 6, 159, 20, 24, 59, "EID", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "64", "58", "RsLabel", 0, "", 31, 159, 20, 24, 60, "EID", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "65", "48", "RsSubForm", 0, "", 433, 139, 31, 324, 61, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,18,CORA_Info")
        oProcessStep.AddCustomLayout(1, 15, "66", "65", "RsComboBox", 0, "Project_Type", 6, 3, 22, 150, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "67", "65", "RsTextbox", 0, "Project_Type_Others", 6, 168, 22, 150, 63, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "68", "48", "RsLabel", 0, "", 228, 11, 21, 125, 64, "Honeywell Office", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "69", "48", "RsLabel", 0, "", 200, 11, 21, 125, 65, "Honeywell PM", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "70", "48", "RsLabel", 0, "", 172, 11, 21, 125, 66, "Project Site Plant", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "71", "48", "RsLabel", 0, "", 144, 11, 21, 125, 67, "Project Site Country*", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "72", "48", "RsLabel", 0, "", 72, 11, 21, 125, 68, "Project Site Address", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "73", "48", "RsLabel", 0, "", 44, 11, 21, 125, 69, "Project Site Name", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "74", "48", "RsLabel", 0, "", 589, 38, 21, 175, 70, "Fields Marked with * are Mandatory", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:Red;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "75", "48", "RsActionButton", 0, "", 590, 248, 23, 115, 71, "Create", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 15, "76", "48", "RsLabel", 0, "", 16, 6, 21, 130, 72, "Project Name on Drawing*", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "77", "48", "RsSubForm", 0, "", 8, 139, 158, 324, 73, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,18,CORA_Info")
        oProcessStep.AddCustomLayout(1, 15, "78", "77", "RsComboBox", 0, "Country", 135, 4, 22, 115, 74, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "79", "77", "RsTextbox", 0, "Project_Site_Address", 63, 3, 66, 315, 75, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "80", "77", "RsTextbox", 0, "Project_Site_Name", 35, 4, 22, 315, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "81", "77", "RsTextbox", 0, "Project_Name", 7, 3, 22, 315, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "82", "48", "RsSubForm", 0, "", 9, 610, 627, 414, 78, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,65,Project_Info")
        oProcessStep.AddCustomLayout(1, 15, "83", "82", "RsLabel", 0, "", 531, 30, 43, 60, 79, "Design Inputs", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "84", "82", "RsTextbox", 0, "Contractor_Address", 402, 96, 66, 315, 80, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "85", "82", "RsTextbox", 0, "Contractor_Telephone", 474, 96, 22, 150, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "86", "82", "RsTextbox", 0, "Consultant_Address", 218, 96, 66, 315, 82, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "87", "82", "RsTextbox", 0, "Contractor_Name", 374, 96, 22, 315, 83, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "88", "82", "RsLabel", 0, "Consultant_Type", 163, 3, 21, 87, 84, "", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "89", "82", "RsTextbox", 0, "Design_Inputs", 530, 96, 44, 315, 85, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "90", "82", "RsLabel", 0, "", 581, 30, 43, 60, 86, "Link to Inputs Log", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "91", "82", "RsTextbox", 0, "Inputs_Log_Link", 580, 96, 44, 315, 87, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "92", "82", "RsTextbox", 0, "Consultant_Telephone", 290, 96, 22, 150, 88, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "93", "82", "RsTextbox", 0, "Consultant_Name", 190, 96, 22, 315, 89, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "94", "82", "RsTextbox", 0, "Contractor_Fax", 474, 261, 22, 150, 90, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "95", "82", "RsTextbox", 0, "Architect_Name", 6, 96, 22, 315, 91, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "96", "82", "RsTextbox", 0, "Consultant_Fax", 290, 261, 22, 150, 92, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "97", "82", "RsTextbox", 0, "Contractor_Type", 346, 96, 22, 315, 93, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "98", "82", "RsTextbox", 0, "Contractor_Email", 502, 96, 22, 315, 94, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "99", "82", "RsTextbox", 0, "Consultant_Type", 162, 96, 22, 315, 95, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "100", "82", "RsLabel", 0, "Contractor_Type", 347, 3, 21, 87, 96, "", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "101", "82", "RsTextbox", 0, "Consultant_Email", 318, 96, 22, 315, 97, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "102", "82", "RsTextbox", 0, "Architect_Email", 134, 96, 22, 315, 98, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "103", "82", "RsTextbox", 0, "Architect_Fax", 106, 261, 22, 150, 99, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "104", "82", "RsTextbox", 0, "Architect_Telephone", 106, 96, 22, 150, 100, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "105", "82", "RsTextbox", 0, "Architect_Address", 34, 96, 66, 315, 101, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "106", "82", "RsLabel", 0, "", 7, 15, 21, 75, 102, "Architect", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "107", "48", "RsSubForm", 0, "", 164, 139, 31, 130, 103, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,65,Project_Info")
        oProcessStep.AddCustomLayout(1, 15, "108", "107", "RsComboBox", 0, "Project_Site_Plant", 7, 4, 22, 115, 104, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "109", "48", "RsSubForm", 0, "", 195, 139, 31, 324, 105, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,18,CORA_Info")
        oProcessStep.AddCustomLayout(1, 15, "110", "109", "RsTextbox", 0, "Project_Manager", 4, 3, 22, 150, 106, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "111", "109", "RsTextbox", 0, "Project_Manager_EID", 4, 188, 22, 130, 107, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "112", "109", "RsLabel", 0, "", 5, 159, 20, 24, 108, "EID", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "113", "48", "RsSubForm", 0, "", 226, 139, 123, 324, 109, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,65,Project_Info")
        oProcessStep.AddCustomLayout(1, 15, "114", "113", "RsTextbox", 0, "Honeywell_Office_Fax", 73, 169, 22, 150, 110, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "115", "113", "RsTextbox", 0, "Honeywell_Office_Telephone", 73, 4, 22, 150, 111, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "116", "113", "RsTextbox", 0, "Honeywell_Office", 1, 4, 66, 315, 112, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "117", "113", "RsTextbox", 0, "Honeywell_Office_Email", 101, 4, 22, 315, 113, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 15, "118", "48", "RsSubForm", 0, "", 464, 4, 120, 605, 114, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,65,Project_Info")
        oProcessStep.AddCustomLayout(1, 15, "119", "118", "RsGroupBox", 0, "", 3, 2, 105, 600, 115, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "120", "119", "RsLabel", 0, "", 44, 407, 21, 50, 116, "Weight", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "121", "119", "RsComboBox", 0, "Unit_Length", 71, 273, 22, 125, 117, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "122", "119", "RsComboBox", 0, "Unit_Weight", 43, 463, 22, 125, 118, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "123", "119", "RsLabel", 0, "", 72, 407, 21, 50, 119, "Volume", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "124", "119", "RsComboBox", 0, "Unit_Pressure", 71, 82, 22, 125, 120, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "125", "119", "RsLabel", 0, "", 44, 6, 21, 70, 121, "Temperature", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "126", "119", "RsLabel", 0, "", 72, 6, 21, 70, 122, "Pressure", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "127", "119", "RsComboBox", 0, "Unit_Temperature", 43, 82, 22, 125, 123, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "128", "119", "RsLabel", 0, "", 16, 6, 21, 125, 124, "Engineering Units*", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "129", "119", "RsComboBox", 0, "Engineering_Units", 15, 137, 22, 150, 125, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "130", "119", "RsComboBox", 0, "Unit_Flow", 43, 273, 22, 125, 126, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "131", "119", "RsComboBox", 0, "Unit_Volume", 71, 463, 22, 125, 127, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 15, "132", "119", "RsLabel", 0, "", 72, 213, 21, 50, 128, "Length", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 15, "133", "119", "RsLabel", 0, "", 44, 213, 21, 50, 129, "Flow", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_Building_Automation_Facility_View()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(18, "Facility View", "", 1, 2, 1, 2, 50, 50)
        oProcessStep.AddPath("BuildingAutomation.FacilityView/FacilityModel")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 44, "1", "0", "RsGrid", 0, "", 17, 15, 661, 468, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,48,FacilityTree;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:0,0;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:True;HorizontalScrollbar:0;AllowSorting:False;SelectedPartPropertyName:SelectedTreeIndex")
        oProcessStep.AddCustomLayout(1, 44, "2", "1", "RsGridColumn", 0, "Selected", 0, 0, 0, 30, 0, "", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 44, "3", "1", "RsGridColumn", 0, "FacilityDisplayName", 0, 0, 0, 400, 0, "Facility Display Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 44, "4", "0", "RsButton", 0, "AddFloor", 85, 505, 35, 162, 1, "Add Floor", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 44, "5", "0", "RsButton", 0, "DeleteFacilityItem", 189, 505, 35, 162, 2, "Delete Facility Item", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 44, "6", "0", "RsButton", 0, "AddBuilding", 27, 505, 35, 162, 3, "Add Building", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 44, "7", "0", "RsSubForm", 0, "", 241, 492, 337, 750, 4, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,48,FacilityTree")
        oProcessStep.AddCustomLayout(1, 44, "8", "7", "RsLabel", 0, "", 19, 13, 21, 150, 5, "Name", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 44, "9", "7", "RsTextbox", 0, "FacilityItemName", 45, 13, 21, 190, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_Building_Automation_Group_System_Plant()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(6, "Group System Plant", "This allows you to specify the Groups, Systems, and Plants", 1, 2, 1, 3, 50, 50)
        oProcessStep.AddPath("BuildingAutomation.PlantView/PlantModel")
        oProcessStep.AddFilter(1, 15, "System", 0, "PartNumber", 0)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 24, "1", "0", "RsButton", 0, "AddPlant", 796, 12, 35, 86, 0, "Add Plant", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 24, "2", "0", "RsButton", 0, "PastePlant", 796, 196, 35, 86, 1, "Paste Plant", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 24, "3", "0", "RsButton", 0, "PasteSystem", 744, 196, 35, 86, 2, "Paste System", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 24, "4", "0", "RsButton", 0, "DeleteTreeItem", 691, 379, 35, 197, 3, "Delete Selected Item", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 24, "5", "0", "RsButton", 0, "AddSystem", 744, 12, 35, 86, 4, "Add System", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 24, "6", "0", "RsGrid", 0, "", 37, 12, 639, 564, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,39,GroupTree;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:0,0;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:True;HorizontalScrollbar:0;AllowSorting:False;SelectedPartPropertyName:SelectedTreeIndex")
        oProcessStep.AddCustomLayout(1, 24, "7", "6", "RsGridColumn", 0, "Selected", 0, 0, 0, 30, 0, "", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "8", "6", "RsGridColumn", 0, "IndentedDisplayName", 0, 0, 0, 250, 0, "Group", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "9", "6", "RsGridColumn", 0, "ItemDescription", 0, 0, 0, 250, 0, "Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "10", "0", "RsButton", 0, "AddGroup", 691, 12, 35, 86, 6, "Add Group", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 24, "11", "0", "RsSubForm", 0, "", 9, 582, 117, 771, 7, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,40,SelectedGroupItem")
        oProcessStep.AddCustomLayout(1, 24, "12", "11", "RsLabel", 0, "", 78, 17, 21, 92, 8, "Location", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "13", "11", "RsLabel", 0, "", 12, 275, 21, 150, 9, "Description", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "14", "11", "RsLabel", 0, "", 12, 515, 21, 150, 10, "Comments", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "15", "11", "RsLabel", 0, "", 12, 9, 21, 90, 11, "Group", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "16", "11", "RsTextbox", 0, "PlantItemLocation", 78, 115, 21, 151, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "17", "11", "RsTextbox", 0, "GroupName", 38, 9, 21, 258, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "18", "11", "RsTextbox", 0, "PlantItemDescription", 38, 275, 74, 232, 14, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "19", "11", "RsTextbox", 0, "PlantItemComment", 38, 515, 74, 223, 15, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "20", "0", "RsSubForm", 0, "", 289, 582, 579, 771, 16, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,41,SelectedPlantItem")
        oProcessStep.AddCustomLayout(1, 24, "21", "20", "RsGroupBox", 0, "", 3, 3, 190, 755, 17, "Plant", 0, 0, 0, 5, 0, "", "", "Font:1.Arial;Font_Size:1.12;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "22", "21", "RsLabel", 0, "", 161, 14, 21, 82, 18, "Location", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "23", "21", "RsComboBox", 0, "Controller", 127, 104, 26, 159, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "24", "21", "RsTextbox", 0, "PlantItemLocation", 161, 103, 21, 159, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "25", "21", "RsTextbox", 0, "PlantItemComment", 50, 512, 132, 223, 21, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "26", "21", "RsLabel", 0, "", 24, 512, 21, 150, 22, "Comments", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "27", "21", "RsLabel", 0, "", 131, 14, 21, 83, 23, "Controller", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "28", "21", "RsLabel", 0, "", 91, 14, 21, 83, 24, "Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "29", "21", "RsLabel", 0, "", 56, 14, 21, 83, 25, "Floor", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "30", "21", "RsTextbox", 0, "PlantItemDescription", 50, 272, 132, 232, 26, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "31", "21", "RsComboBox", 0, "PlantType", 91, 104, 26, 159, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "32", "21", "RsLabel", 0, "", 24, 272, 21, 150, 28, "Description", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "33", "21", "RsLabel", 0, "", 25, 14, 21, 83, 29, "Plant", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "34", "21", "RsTextbox", 0, "PlantName", 25, 103, 21, 159, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "35", "21", "RsComboBox", 0, "FloorName", 56, 103, 26, 159, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "36", "20", "RsGroupBox", 0, "", 199, 3, 363, 755, 32, "Plant Devices", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "37", "36", "RsGrid", 0, "", 19, 6, 338, 738, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,4,Devices;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 24, "38", "37", "RsGridColumn", 0, "PartNumber", 0, 0, 0, 100, 0, "Part Number", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "39", "37", "RsGridColumn", 0, "DeviceType", 0, 0, 0, 100, 0, "Device Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "40", "37", "RsGridColumn", 0, "PartShape", 0, 0, 0, 100, 0, "Part Shape", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "41", "37", "RsGridColumn", 0, "PartType", 0, 0, 0, 150, 0, "Part Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "42", "0", "RsButton", 0, "CopyPlant", 796, 104, 35, 86, 34, "Copy Plant", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 24, "43", "0", "RsLabel", 0, "", 9, 26, 19, 464, 35, "Select the Group, System, and Plant", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.14;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "44", "0", "RsButton", 0, "CutSystem", 744, 104, 35, 86, 36, "Cut System", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 24, "45", "0", "RsGroupBox", 0, "", 132, 585, 151, 755, 37, "System", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "46", "45", "RsSubForm", 0, "", 26, 6, 114, 738, 38, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,42,SelectedSystemItem")
        oProcessStep.AddCustomLayout(1, 24, "47", "46", "RsLabel", 0, "", 83, 10, 21, 90, 39, "Location", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "48", "46", "RsTextbox", 0, "PlantItemComment", 29, 515, 80, 214, 40, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "49", "46", "RsLabel", 0, "", 3, 515, 21, 150, 41, "Comments", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "50", "46", "RsLabel", 0, "", 3, 275, 21, 150, 42, "Description", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "51", "46", "RsLabel", 0, "", 3, 10, 21, 89, 43, "System", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "52", "46", "RsTextbox", 0, "SystemName", 3, 106, 21, 159, 44, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "53", "46", "RsLabel", 0, "", 56, 10, 18, 90, 45, "Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "54", "46", "RsComboBox", 0, "SystemType", 55, 107, 23, 159, 46, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "55", "46", "RsTextbox", 0, "PlantItemDescription", 29, 275, 80, 232, 47, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "56", "46", "RsLabel", 0, "", 29, 10, 21, 89, 48, "Building", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "57", "46", "RsTextbox", 0, "PlantItemLocation", 83, 107, 21, 158, 49, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "58", "46", "RsComboBox", 0, "BuildingName", 29, 106, 21, 159, 50, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_Building_Automation_Add_Manage_Devices()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(13, "Add Manage Devices", "This allows you to specify the Plant Devices", 1, 2, 1, 4, 50, 50)
        oProcessStep.AddPath("BuildingAutomation.PlantView/PlantModel")
        oProcessStep.AddFilter(1, 15, "System", 0, "PartNumber", 0)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 24, "1", "0", "RsSubForm", 0, "", 75, 566, 737, 750, 0, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,13,SelectedPlantItem")
        oProcessStep.AddCustomLayout(1, 24, "2", "1", "RsGroupBox", 0, "", 8, 6, 84, 736, 1, "Plant", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "3", "2", "RsComboBox", 0, "Controller", 16, 69, 26, 206, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "4", "2", "RsLabel", 0, "", 21, 12, 21, 51, 3, "Controller", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "5", "2", "RsTextbox", 0, "ItemDescription", 13, 283, 62, 447, 4, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "6", "1", "RsGroupBox", 0, "", 96, 6, 274, 505, 5, "Plant Devices", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "7", "6", "RsGrid", 0, "", 20, 3, 248, 498, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,4,Devices;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 24, "8", "7", "RsGridColumn", 0, "PartNumber", 0, 0, 0, 100, 0, "Part Number", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "9", "7", "RsGridColumn", 0, "DeviceType", 0, 0, 0, 100, 0, "Device Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "10", "7", "RsGridColumn", 0, "PartShape", 0, 0, 0, 100, 0, "Part Shape", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "11", "7", "RsGridColumn", 0, "PartType", 0, 0, 0, 150, 0, "Part Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "12", "1", "RsAddDeleteCopy", 0, "", 166, 517, 34, 237, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,4,Devices;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 24, "13", "1", "RsSubForm", 0, "", 376, 6, 355, 698, 8, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,4,Devices")
        oProcessStep.AddCustomLayout(1, 24, "14", "13", "RsGroupBox", 0, "", 3, 6, 167, 627, 9, "Device Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "15", "14", "RsLabel", 0, "", 20, 9, 21, 72, 10, "Description", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "16", "14", "RsTextbox", 0, "PartDescription", 19, 85, 22, 536, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "17", "14", "RsLabel", 0, "", 44, 9, 21, 71, 12, "Mnemonics", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "18", "14", "RsTextbox", 0, "Mnemonics", 43, 85, 22, 81, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "19", "14", "RsLabel", 0, "", 141, 7, 21, 72, 14, "Power Supply", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "20", "14", "RsTextbox", 0, "PowerSupply", 141, 85, 22, 232, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "21", "14", "RsLabel", 0, "", 72, 200, 21, 86, 16, "Process Variable", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "22", "14", "RsLabel", 0, "", 44, 200, 21, 69, 17, "Device Type", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "23", "14", "RsLabel", 0, "", 120, 8, 21, 71, 18, "Signal Type", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "24", "14", "RsLabel", 0, "", 71, 2, 21, 76, 19, "Application Use", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "25", "14", "RsTextbox", 0, "SequenceText", 61, 423, 102, 198, 20, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "26", "14", "RsTextbox", 0, "ApplicationUse", 68, 85, 22, 108, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "27", "14", "RsLabel", 0, "", 95, 9, 21, 70, 22, "Wiring Type", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "28", "14", "RsTextbox", 0, "ProcessVariable", 68, 292, 22, 125, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "29", "14", "RsTextbox", 0, "DeviceType", 43, 275, 22, 142, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "30", "14", "RsTextbox", 0, "SignalType", 119, 85, 22, 232, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "31", "14", "RsTextbox", 0, "WiringType", 94, 85, 22, 232, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "32", "14", "RsLabel", 0, "", 43, 423, 18, 150, 27, "Sequence of Operations", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "33", "13", "RsGroupBox", 0, "", 176, 6, 161, 317, 28, "Terminal Block", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "34", "33", "RsLabel", 0, "", 20, 11, 21, 85, 29, "Block Label", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "35", "33", "RsTextbox", 0, "TerminalBlockLabel", 19, 102, 22, 184, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "36", "33", "RsLabel", 0, "", 48, 11, 21, 85, 31, "Block Other Label", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "37", "33", "RsTextbox", 0, "TerminalBlockOtherLabel", 47, 102, 22, 184, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "38", "33", "RsLabel", 0, "", 73, 9, 21, 85, 33, "Point Block Link", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "39", "33", "RsTextbox", 0, "PointTerminalBlockLink", 72, 100, 22, 191, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "40", "33", "RsLabel", 0, "", 101, 9, 21, 85, 35, "ACAD Block", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "41", "33", "RsTextbox", 0, "Image_RSE", 101, 100, 22, 191, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "42", "13", "RsGroupBox", 0, "", 172, 329, 178, 230, 37, "Controller Connections", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "43", "42", "RsLabel", 0, "", 16, 11, 21, 82, 38, "Controller", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "44", "42", "RsTextbox", 0, "ControllerPartNumber", 17, 100, 22, 121, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "45", "42", "RsGrid", 0, "", 44, 11, 121, 210, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,56,Wires;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:0,0;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 24, "46", "45", "RsGridColumn", 0, "DevicePoint", 0, 0, 0, 40, 0, "Point", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "47", "45", "RsGridColumn", 0, "ControllerIndex", 0, 0, 0, 40, 0, "CO#", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "48", "45", "RsGridColumn", 0, "ControllerTerminalLabels", 0, 0, 0, 50, 0, "Wire", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "49", "45", "RsGridColumn", 0, "ControllerTerminalNumbers", 0, 0, 0, 50, 0, "Term", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "50", "13", "RsGroupBox", 0, "", 181, 565, 163, 130, 41, "Device Image", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "51", "50", "RsPictureBox", 0, "SymbolImagePath", 19, 6, 100, 100, 42, "", 0, 0, 1, 5, 0, "", "", "Filename:;IsGeneratedImg:False;RsTooltip:;")
        oProcessStep.AddCustomLayout(1, 24, "52", "0", "RsSubForm", 0, "", 12, 509, 57, 401, 43, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,14,SelectedSystemItem")
        oProcessStep.AddCustomLayout(1, 24, "53", "52", "RsTextbox", 0, "SystemName", 3, 99, 22, 299, 44, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 24, "54", "52", "RsTextbox", 0, "SystemUserDefinedName", 28, 99, 22, 299, 45, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 24, "55", "52", "RsLabel", 0, "", 4, 1, 20, 93, 46, "Selected System", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "56", "52", "RsLabel", 0, "", 29, 20, 21, 73, 47, "Building", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "57", "0", "RsSubForm", 0, "", 75, 9, 688, 551, 48, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,13,SelectedPlantItem")
        oProcessStep.AddCustomLayout(1, 24, "58", "57", "RsGroupBox", 0, "", 8, 3, 677, 539, 49, "Library/Part Search", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "59", "58", "RsLabel", 0, "", 54, 37, 21, 42, 50, "Filter 1", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "60", "58", "RsButton", 0, "button_AddDevice", 617, 278, 35, 130, 51, "Add Device", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 24, "61", "58", "RsComboBox", 0, "Filter1Choices", 53, 278, 22, 217, 52, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "62", "58", "RsLabel", 0, "", 82, 37, 21, 42, 53, "Filter 2", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "63", "58", "RsComboBox", 0, "Filter1", 54, 95, 22, 146, 54, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "64", "58", "RsComboBox", 0, "Filter3", 110, 95, 22, 146, 55, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "65", "58", "RsComboBox", 0, "Filter2", 82, 95, 22, 146, 56, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "66", "58", "RsComboBox", 0, "Filter2Choices", 81, 278, 22, 217, 57, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "67", "58", "RsLabel", 0, "", 110, 37, 21, 42, 58, "Filter 3", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "68", "58", "RsComboBox", 0, "Filter3Choices", 109, 278, 22, 217, 59, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "69", "58", "RsGrid", 0, "", 137, 6, 468, 525, 60, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,20,PartSearchResults;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:0,0;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:False;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:SelectedSearchIndex")
        oProcessStep.AddCustomLayout(1, 24, "70", "69", "RsGridColumn", 0, "SearchPartNumber", 0, 0, 0, 100, 0, "Search Part Number", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:SearchResults_Column1_Title;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "71", "69", "RsGridColumn", 0, "SearchPartDescription", 0, 0, 0, 400, 0, "Search Part Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:SearchResults_Column2_Title;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "72", "58", "RsGroupBox", 0, "", 13, 37, 37, 458, 61, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "73", "72", "RsRadioButton", 0, "SearchType", 7, 321, 18, 92, 62, "Search Parts", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "74", "72", "RsRadioButton", 0, "SearchType", 7, 16, 18, 100, 63, "Search Library", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "75", "72", "RsComboBox", 0, "Search_Default_Library", 7, 122, 22, 175, 64, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "76", "58", "RsButton", 0, "button_AddPlant", 617, 111, 35, 130, 65, "Add Plant", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 24, "77", "0", "RsSubForm", 0, "", 12, 916, 57, 392, 66, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,13,SelectedPlantItem")
        oProcessStep.AddCustomLayout(1, 24, "78", "77", "RsTextbox", 0, "PlantUserDefinedName", 28, 94, 22, 294, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 24, "79", "77", "RsTextbox", 0, "PlantNameGroup", 3, 94, 22, 294, 68, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 24, "80", "77", "RsLabel", 0, "", 4, 15, 21, 73, 69, "Selected Plant", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "81", "77", "RsLabel", 0, "", 29, 46, 21, 42, 70, "Floor", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "82", "0", "RsSubForm", 0, "", 12, 12, 57, 491, 71, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,12,SelectedGroupItem")
        oProcessStep.AddCustomLayout(1, 24, "83", "82", "RsTextbox", 0, "GroupName", 29, 85, 22, 403, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 24, "84", "82", "RsLabel", 0, "", 4, 6, 29, 73, 73, "Selected Project", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "85", "82", "RsLabel", 0, "", 33, 1, 17, 78, 74, "Selected Group", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "86", "82", "RsTextbox", 0, "GroupName", 3, 85, 22, 403, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_Building_Automation_Plant_IO_Point_Summary()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(11, "Plant IO Point Summary", "", 1, 2, 1, 5, 50, 50)
        oProcessStep.AddPath("BuildingAutomation.PlantView/PlantModel")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 24, "1", "0", "RsSubForm", 0, "", 79, 9, 520, 1336, 0, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,13,SelectedPlantItem")
        oProcessStep.AddCustomLayout(1, 24, "2", "1", "RsGroupBox", 0, "", 8, 728, 495, 568, 1, "Point Summary", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "3", "2", "RsGrid", 0, "", 19, 6, 466, 545, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,21,Wires;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 24, "4", "3", "RsGridColumn", 0, "DevicePointParameter", 0, 0, 0, 300, 0, "Point Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "5", "3", "RsGridColumn", 0, "XAI", 0, 0, 0, 50, 0, "AI", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "6", "3", "RsGridColumn", 0, "XAO", 0, 0, 0, 50, 0, "AO", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "7", "3", "RsGridColumn", 0, "XDI", 0, 0, 0, 50, 0, "DI", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "8", "3", "RsGridColumn", 0, "XDO", 0, 0, 0, 50, 0, "DO", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "9", "1", "RsGroupBox", 0, "", 8, 3, 495, 709, 3, "Point Connenctions", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "10", "9", "RsGrid", 0, "", 19, 6, 466, 694, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,21,Wires;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 24, "11", "10", "RsGridColumn", 0, "DevicePartNumber", 0, 0, 0, 80, 0, "Device", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "12", "10", "RsGridColumn", 0, "DevicePoint", 0, 0, 0, 40, 0, "Point", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "13", "10", "RsGridColumn", 0, "DevicePointParameter", 0, 0, 0, 160, 0, "Point Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "14", "10", "RsGridColumn", 0, "ControllerIndex", 0, 0, 0, 70, 0, "Controller Number", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 24, "15", "10", "RsGridColumn", 0, "ControllerPointName", 0, 0, 0, 70, 0, "Controller Point", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 24, "16", "10", "RsGridColumn", 0, "ControllerTerminalLabels", 0, 0, 0, 60, 0, "Terminal Labels", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 24, "17", "10", "RsGridColumn", 0, "ControllerTerminalNumbers", 0, 0, 0, 60, 0, "Terminal Numbers", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 24, "18", "10", "RsGridColumn", 0, "DevicePointSignalType", 0, 0, 0, 100, 0, "Signal Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 24, "19", "0", "RsSubForm", 0, "", 12, 448, 57, 401, 5, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,14,SelectedSystemItem")
        oProcessStep.AddCustomLayout(1, 24, "20", "19", "RsTextbox", 0, "SystemName", 3, 106, 22, 278, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "21", "19", "RsTextbox", 0, "SystemUserDefinedName", 28, 106, 22, 278, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "22", "19", "RsLabel", 0, "", 4, 10, 21, 90, 8, "Selected System", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "23", "19", "RsLabel", 0, "", 29, 10, 21, 90, 9, "Building", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "24", "0", "RsSubForm", 0, "", 12, 855, 57, 392, 10, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,13,SelectedPlantItem")
        oProcessStep.AddCustomLayout(1, 24, "25", "24", "RsLabel", 0, "", 30, 6, 21, 90, 11, "Floor", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "26", "24", "RsTextbox", 0, "PlantUserDefinedName", 29, 102, 22, 278, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "27", "24", "RsTextbox", 0, "PlantNameGroup", 4, 102, 22, 278, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "28", "24", "RsLabel", 0, "", 5, 11, 21, 85, 14, "Selected Plant", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "29", "0", "RsSubForm", 0, "", 12, 12, 49, 430, 15, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,12,SelectedGroupItem")
        oProcessStep.AddCustomLayout(1, 24, "30", "29", "RsTextbox", 0, "GroupName", 10, 95, 22, 278, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "31", "29", "RsLabel", 0, "", 10, 7, 21, 78, 17, "Selected Group", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_Building_Automation_Power_Supplies()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(12, "Power Supplies", "", 1, 2, 1, 6, 50, 50)
        oProcessStep.AddPath("BuildingAutomation.PlantView/PlantModel")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 24, "1", "0", "RsSubForm", 0, "", 77, 13, 666, 1352, 0, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,13,SelectedPlantItem")
        oProcessStep.AddCustomLayout(1, 24, "2", "1", "RsGroupBox", 0, "", 323, 601, 327, 745, 1, "All Parts", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "3", "2", "RsGrid", 0, "", 19, 7, 302, 729, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,26,AllParts;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:0,0;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 24, "4", "3", "RsGridColumn", 0, "SelectedForPowerSupply", 0, 0, 0, 30, 0, "", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "5", "3", "RsGridColumn", 0, "PartNumber", 0, 0, 0, 90, 0, "Part Number", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "6", "3", "RsGridColumn", 0, "PartDescription", 0, 0, 0, 320, 0, "Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 24, "7", "3", "RsGridColumn", 0, "PowerSupply", 0, 0, 0, 100, 0, "Power Supply", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 24, "8", "3", "RsGridColumn", 0, "PowerConsumption", 0, 0, 0, 60, 0, "Power [VA]", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 24, "9", "3", "RsGridColumn", 0, "CurrentRating", 0, 0, 0, 60, 0, "Current [mA]", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 24, "10", "1", "RsGroupBox", 0, "", 14, 12, 636, 590, 3, "Available Power Supplies", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "11", "10", "RsListBox", 0, "PowerSupplyPick", 19, 6, 571, 576, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "12", "10", "RsButton", 0, "button_AddPowerSupply", 596, 214, 23, 180, 5, "Add Power Supply", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 24, "13", "1", "RsGrid", 0, "", 14, 608, 252, 729, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,25,Circuits;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:0,0;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:SelectedPowerSupplyIndex")
        oProcessStep.AddCustomLayout(1, 24, "14", "13", "RsGridColumn", 0, "PartNumber", 0, 0, 0, 100, 0, "Part Number", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "15", "13", "RsGridColumn", 0, "CircuitDescription", 0, 0, 0, 270, 0, "Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "16", "13", "RsGridColumn", 0, "InputVoltage", 0, 0, 0, 100, 0, "Input Voltage", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "17", "13", "RsGridColumn", 0, "OutputVoltage", 0, 0, 0, 100, 0, "Output Voltage", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "18", "13", "RsGridColumn", 0, "DevicePower", 0, 0, 0, 60, 0, "Device Power [VA/mA]]", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 24, "19", "13", "RsGridColumn", 0, "PowerRating", 0, 0, 0, 70, 0, "Power Rating", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 24, "20", "1", "RsButton", 0, "button_DeletePowerSupply", 289, 608, 23, 180, 7, "Delete Power Supply", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 24, "21", "1", "RsSubForm", 0, "", 277, 831, 49, 506, 8, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,25,Circuits")
        oProcessStep.AddCustomLayout(1, 24, "22", "21", "RsButton", 0, "button_AssignPower", 12, 3, 23, 194, 9, "Assign Devices", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 24, "23", "21", "RsLabel", 0, "", 14, 256, 21, 150, 10, "Safety Margin", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "24", "21", "RsTextbox", 0, "SafetyMargin", 14, 413, 21, 58, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "25", "21", "RsLabel", 0, "", 13, 478, 22, 25, 12, "%", 0, 0, 1, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "26", "0", "RsSubForm", 0, "", 12, 461, 57, 401, 13, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,14,SelectedSystemItem")
        oProcessStep.AddCustomLayout(1, 24, "27", "26", "RsTextbox", 0, "SystemName", 3, 106, 22, 278, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "28", "26", "RsTextbox", 0, "SystemUserDefinedName", 28, 106, 22, 278, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "29", "26", "RsLabel", 0, "", 4, 10, 21, 90, 16, "Selected System", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "30", "26", "RsLabel", 0, "", 29, 10, 21, 90, 17, "Building", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "31", "0", "RsSubForm", 0, "", 12, 868, 57, 392, 18, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,13,SelectedPlantItem")
        oProcessStep.AddCustomLayout(1, 24, "32", "31", "RsLabel", 0, "", 30, 6, 21, 90, 19, "Floor", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "33", "31", "RsTextbox", 0, "PlantUserDefinedName", 29, 102, 22, 278, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "34", "31", "RsTextbox", 0, "PlantNameGroup", 4, 102, 22, 278, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "35", "31", "RsLabel", 0, "", 5, 11, 21, 85, 22, "Selected Plant", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "36", "0", "RsSubForm", 0, "", 12, 25, 49, 430, 23, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,12,SelectedGroupItem")
        oProcessStep.AddCustomLayout(1, 24, "37", "36", "RsTextbox", 0, "GroupName", 10, 95, 22, 278, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "38", "36", "RsLabel", 0, "", 10, 7, 21, 78, 25, "Selected Group", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_Building_Automation_Plant_Devices()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(9, "Plant Devices", "The Plant Devices for the project.", 1, 2, 1, 7, 50, 50)
        oProcessStep.AddPath("BuildingAutomation.PlantView/PlantModel")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 24, "1", "0", "RsSubForm", 0, "", 1, -7, 840, 1664, 0, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,27,Groups")
        oProcessStep.AddCustomLayout(1, 24, "2", "1", "RsGroupBox", 0, "", 43, 19, 397, 1250, 1, "Plants", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "3", "2", "RsGrid", 0, "", 25, 7, 223, 623, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,1,AllPlants;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 24, "4", "3", "RsGridColumn", 0, "PlantName", 0, 0, 0, 200, 0, "Plant Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "5", "3", "RsGridColumn", 0, "SystemName", 0, 0, 0, 200, 0, "System Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "6", "3", "RsGridColumn", 0, "PlantType", 0, 0, 0, 200, 0, "Plant Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "7", "2", "RsSubForm", 0, "", 14, 636, 377, 600, 3, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,1,AllPlants")
        oProcessStep.AddCustomLayout(1, 24, "8", "7", "RsGroupBox", 0, "", 3, 8, 335, 580, 4, "Default Library", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "9", "8", "RsLabel", 0, "", 20, 182, 21, 90, 5, "Library", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "10", "8", "RsComboBox", 0, "Search_Default_Library", 20, 278, 22, 175, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "11", "8", "RsLabel", 0, "", 48, 74, 21, 42, 7, "Filter 1", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "12", "8", "RsComboBox", 0, "Filter1Choices", 48, 278, 22, 175, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "13", "8", "RsLabel", 0, "", 76, 74, 21, 42, 9, "Filter 2", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "14", "8", "RsComboBox", 0, "Filter1", 48, 132, 22, 109, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "15", "8", "RsComboBox", 0, "Filter3", 104, 132, 22, 109, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "16", "8", "RsComboBox", 0, "Filter2", 76, 132, 22, 109, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "17", "8", "RsComboBox", 0, "Filter2Choices", 76, 278, 22, 175, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "18", "8", "RsLabel", 0, "", 104, 74, 21, 42, 14, "Filter 3", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "19", "8", "RsComboBox", 0, "Filter3Choices", 104, 278, 22, 175, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "20", "8", "RsGrid", 0, "", 132, 6, 197, 563, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,20,PartSearchResults;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:False;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 24, "21", "20", "RsGridColumn", 0, "SearchPartNumber", 0, 0, 0, 100, 0, "Search Part Number", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "22", "20", "RsGridColumn", 0, "SearchPartDescription", 0, 0, 0, 400, 0, "Search Part Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "23", "7", "RsButton", 0, "button_AddDevice", 344, 456, 30, 130, 17, "Add Device", 1, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;IsNavigation:False;IsURL:False;")
        oProcessStep.AddCustomLayout(1, 24, "24", "1", "RsGroupBox", 0, "", 446, 19, 313, 1250, 18, "Devices", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "25", "24", "RsSubForm", 0, "", 19, 3, 339, 1240, 19, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,1,AllPlants")
        oProcessStep.AddCustomLayout(1, 24, "26", "25", "RsGrid", 0, "", 13, 0, 262, 623, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,4,Devices;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 24, "27", "26", "RsGridColumn", 0, "DevicePartNumber", 0, 0, 0, 250, 0, "Part Number", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "28", "26", "RsGridColumn", 0, "DeviceType", 0, 0, 0, 100, 0, "Device Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "29", "26", "RsGridColumn", 0, "PartShape", 0, 0, 0, 100, 0, "Part Shape", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "30", "26", "RsGridColumn", 0, "PartType", 0, 0, 0, 150, 0, "Part Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "31", "25", "RsSubForm", 0, "", 13, 632, 276, 590, 21, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,4,Devices")
        oProcessStep.AddCustomLayout(1, 24, "32", "31", "RsGroupBox", 0, "", 0, 6, 269, 343, 22, "Device Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "33", "32", "RsLabel", 0, "", 16, 6, 21, 86, 23, "Description", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "34", "32", "RsTextbox", 0, "PartDescription", 15, 98, 22, 232, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "35", "32", "RsLabel", 0, "", 44, 6, 21, 86, 25, "Mnemonics", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "36", "32", "RsTextbox", 0, "Mnemonics", 43, 98, 22, 232, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "37", "32", "RsLabel", 0, "", 72, 6, 21, 86, 27, "Power Supply", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "38", "32", "RsTextbox", 0, "PowerSupply", 71, 98, 22, 232, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "39", "32", "RsLabel", 0, "", 190, 6, 21, 86, 29, "Process Variable", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "40", "32", "RsLabel", 0, "", 128, 6, 21, 86, 30, "Device Type", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "41", "32", "RsLabel", 0, "", 159, 6, 21, 86, 31, "Signal Type", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "42", "32", "RsLabel", 0, "", 100, 6, 21, 86, 32, "Wiring Type", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "43", "32", "RsTextbox", 0, "ProcessVariable", 189, 98, 22, 232, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "44", "32", "RsTextbox", 0, "DeviceType", 127, 98, 22, 232, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "45", "32", "RsTextbox", 0, "SignalType", 158, 98, 22, 232, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "46", "32", "RsTextbox", 0, "WiringType", 99, 98, 22, 232, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "47", "31", "RsGroupBox", 0, "", 3, 355, 115, 232, 37, "Terminal Block", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "48", "47", "RsLabel", 0, "", 25, 6, 21, 110, 38, "Block Label", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "49", "47", "RsTextbox", 0, "TerminalBlockLabel", 24, 122, 22, 100, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "50", "47", "RsLabel", 0, "", 53, 6, 21, 110, 40, "Block Other Label", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "51", "47", "RsTextbox", 0, "TerminalBlockOtherLabel", 52, 122, 22, 100, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "52", "47", "RsLabel", 0, "", 81, 6, 21, 110, 42, "Point Block Link", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 24, "53", "47", "RsTextbox", 0, "PointTerminalBlockLink", 80, 122, 22, 100, 43, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "54", "31", "RsPictureBox", 0, "Image_RSE", 124, 355, 145, 232, 44, "", 0, 0, 0, 5, 0, "", "", "Filename:Device_Image.png;IsGeneratedImg:False;RsTooltip:;")
        oProcessStep.AddCustomLayout(1, 24, "55", "1", "RsPrevStepActionButton", 0, "", 765, 25, 23, 75, 45, "Prev", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 24, "56", "1", "RsNextStepActionButton", 0, "", 765, 559, 23, 75, 46, "Next", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 24, "57", "1", "RsGroupBox", 0, "", 794, 19, 116, 629, 47, "User Stories", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "58", "57", "RsTextbox", 0, "Story_Point_Data_3", 24, 7, 83, 608, 48, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 24, "59", "1", "RsLabel", 0, "", 8, 19, 32, 540, 49, "Plant Devices", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.15;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_Building_Automation_Controller()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(10, "Controller", "A controller for this system.", 1, 2, 1, 8, 50, 50)
        oProcessStep.AddPath("BuildingAutomation.PlantView/PlantModel")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 24, "1", "0", "RsSubForm", 0, "", 12, 12, 783, 1565, 0, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,27,Groups")
        oProcessStep.AddCustomLayout(1, 24, "2", "1", "RsGroupBox", 0, "", 48, 32, 376, 1254, 1, "Controllers", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 24, "3", "2", "RsGrid", 0, "", 22, 6, 245, 1228, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,11,AllControllers;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 24, "4", "3", "RsGridColumn", 0, "ParentGroupName", 0, 0, 0, 100, 0, "Group Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "5", "3", "RsGridColumn", 0, "ParentPlantName", 0, 0, 0, 100, 0, "Plant Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "6", "3", "RsGridColumn", 0, "ParentSystemName", 0, 0, 0, 125, 0, "System Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "7", "3", "RsGridColumn", 0, "ParentPlantType", 0, 0, 0, 120, 0, "Plant Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "8", "3", "RsGridColumn", 0, "ControllerLocation", 0, 0, 0, 100, 0, "Controller Location", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "9", "3", "RsGridColumn", 0, "ControllerName", 0, 0, 0, 100, 0, "Controller Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "10", "3", "RsGridColumn", 0, "ControllerPartNumber", 0, 0, 0, 100, 0, "Controller Part Number", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "11", "3", "RsGridColumn", 0, "IO_Capacity", 0, 0, 0, 70, 0, "IO Capacity", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "12", "3", "RsGridColumn", 0, "AI_UI_Capacity", 0, 0, 0, 70, 0, "AI_UI Capacity", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "13", "3", "RsGridColumn", 0, "AO_Capacity", 0, 0, 0, 70, 0, "AO Capacity", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "14", "3", "RsGridColumn", 0, "DI_Capacity", 0, 0, 0, 70, 0, "DI Capacity", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "15", "3", "RsGridColumn", 0, "DO_Capacity", 0, 0, 0, 70, 0, "DO Capacity", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 24, "16", "2", "RsSubForm", 0, "", 288, 3, 76, 511, 3, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,1,AllPlants")
        oProcessStep.AddCustomLayout(1, 24, "17", "1", "RsPrevStepActionButton", 0, "", 444, 32, 23, 75, 4, "Prev", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 24, "18", "1", "RsLabel", 0, "", 13, 20, 32, 540, 5, "Controller", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.15;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_Building_Automation_Reports()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(14, "Reports", "", 3, 2, 1, 9, 50, 50)
        oProcessStep.AddPath("BuildingAutomation")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 15, "1", "0", "RsActionButton", 0, "", 12, 12, 103, 239, 0, "Generate Excel BOM", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:CreateExcelBOM;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 15, "2", "0", "RsActionButton", 0, "", 12, 257, 103, 239, 1, "Generate CSV Blocks for DWG Import", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:CreateExcelPlantBlocks;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_Building_Automation_Drawings()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(17, "Drawings", "", 4, 2, 1, 10, 50, 50)
        oProcessStep.AddPath("BuildingAutomation.Drawings/Drawing")
        oProcessStep.AddLayout(1, 23, "DWGSpec")
        
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
          InitProperty("EnableDrawings", "540", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H599123", "4/25/2025 5:34:13 AM", "", "In Development",  0,1277)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CORAInfoNotSavedText", "420", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "4/14/2025 2:48:47 PM", "", "In Development",  0,1028)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CORAInfoSaved", "419", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "4/17/2025 2:20:46 AM", "", "In Development",  0,1027)
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
          
        InitSubpart("CORA_Info", 18, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "3/17/2025 1:12:36 PM", "", "In Development", "Y",0,39,38)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Drawings", 32, "", "", "Y", 0, "-1", "", "GLOBAL\H599123", "4/25/2025 5:40:57 AM", "", "In Development", "N",0,75,148)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("FacilityView", 62, "", "", "Y", 0, "-1", "", "GLOBAL\H601421", "4/25/2025 3:13:17 AM", "", "In Development", "N",0,143,142)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("PlantView", 26, "", "", "Y", 0, "-1", "", "GLOBAL\H601421", "4/20/2025 3:30:00 AM", "", "In Development", "N",0,63,62)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("PowerSupplyView", 67, "", "", "Y", 0, "-1", "", "GLOBAL\H601421", "6/18/2025 5:06:48 PM", "", "In Development", "N",0,160,159)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Project_Info", 65, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "5/6/2025 5:33:43 PM", "", "In Development", "Y",0,156,155)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("SiteInfo", 12, "", "", "Y", 0, "-1", "", "GLOBAL\H601421", "3/14/2025 2:50:36 AM", "", "In Development", "N",0,26,25)
        
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
      Public Function Process_Building_Automation_Create_New__Project_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:8; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

If Me.CORAInfoSaved Then
	Result = STATUS_COMPLETED = 2
Else
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:8; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Create_New__Project_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Create_New__Project_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:8; TYPE:CO
      result = String.Empty

If Me.CORAInfoSaved Then
	Result = ""
Else
	Result = "Choose the Project ID and then Save the model 
To move To the Next Process Step"
End If
      '   END FORMULA; PROC ID:8; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Create_New__Project_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Facility_View_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:18; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_ENABLED

If Not(CORAInfoSaved) Then
	Result = STATUS_DISABLED
End If
      '   END FORMULA; PROC ID:18; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Facility_View_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Facility_View_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:18; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:18; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Facility_View_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Group_System_Plant_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:6; TYPE:ST
      result = STATUS_ENABLED

If Not(Me.CORAInfoSaved) Then
	Result = STATUS_DISABLED
End If
      '   END FORMULA; PROC ID:6; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Group_System_Plant_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Group_System_Plant_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:6; TYPE:CO
      result = ""

If Not (Me.CORAInfoSaved) Then
	Result = "This Process Step can not be edited until the CORA ProjectID has been selected and the Model saved."
End If
      '   END FORMULA; PROC ID:6; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Group_System_Plant_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Add_Manage_Devices_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:13; TYPE:ST
      result = STATUS_ENABLED


If Not (Me.CORAInfoSaved) Then
	Result = STATUS_DISABLED
End If
      '   END FORMULA; PROC ID:13; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Add_Manage_Devices_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Add_Manage_Devices_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:13; TYPE:CO
      result = ""

If Not (Me.CORAInfoSaved) Then
	Result = "This Process Step can not be edited until the CORA ProjectID has been selected and the Model saved."
End If
      '   END FORMULA; PROC ID:13; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Add_Manage_Devices_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Plant_IO_Point_Summary_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:11; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED


If Not (Me.CORAInfoSaved) Then
	Result = STATUS_DISABLED
End If
      '   END FORMULA; PROC ID:11; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Plant_IO_Point_Summary_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Plant_IO_Point_Summary_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:11; TYPE:CO
      result = String.Empty


If Not (Me.CORAInfoSaved) Then
	Result = "This Process Step can not be edited until the CORA ProjectID has been selected and the Model saved."
End If
      '   END FORMULA; PROC ID:11; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Plant_IO_Point_Summary_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Power_Supplies_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:12; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED


If Not (Me.CORAInfoSaved) Then
	Result = STATUS_DISABLED
End If
      '   END FORMULA; PROC ID:12; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Power_Supplies_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Power_Supplies_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:12; TYPE:CO
      result = String.Empty


If Not (Me.CORAInfoSaved) Then
	Result = "This Process Step can not be edited until the CORA ProjectID has been selected and the Model saved."
End If
      '   END FORMULA; PROC ID:12; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Power_Supplies_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Plant_Devices_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:9; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN


If Not (Me.CORAInfoSaved) Then
	Result = STATUS_DISABLED
End If
      '   END FORMULA; PROC ID:9; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Plant_Devices_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Plant_Devices_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:9; TYPE:CO
      result = String.Empty


If Not (Me.CORAInfoSaved) Then
	Result = "This Process Step can not be edited until the CORA ProjectID has been selected and the Model saved."
End If
      '   END FORMULA; PROC ID:9; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Plant_Devices_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Controller_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:10; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED


If Not (Me.CORAInfoSaved) Then
	Result = STATUS_DISABLED
End If
      '   END FORMULA; PROC ID:10; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Controller_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Controller_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:10; TYPE:CO
      result = String.Empty


If Not (Me.CORAInfoSaved) Then
	Result = "This Process Step can not be edited until the CORA ProjectID has been selected and the Model saved."
End If
      '   END FORMULA; PROC ID:10; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Controller_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Reports_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:14; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_ENABLED


If Not (Me.CORAInfoSaved) Then
	Result = STATUS_DISABLED
End If
      '   END FORMULA; PROC ID:14; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Reports_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Reports_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:14; TYPE:CO
      Result = String.Empty


If Not (Me.CORAInfoSaved) Then
	Result = "This Process Step can not be edited until the CORA ProjectID has been selected and the Model saved."
End If
      '   END FORMULA; PROC ID:14; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Reports_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Drawings_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:17; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_ENABLED

If Not(Me.CORAInfoSaved) Then
	Result = STATUS_DISABLED
End If

If Not(Me.EnableDrawings) Then 
	Result = STATUS_DISABLED
End If
      '   END FORMULA; PROC ID:17; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Drawings_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_Building_Automation_Drawings_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:17; TYPE:CO
      Result = ""

If Not (Me.CORAInfoSaved) Then
	Result = "This Process Step can not be edited until the CORA ProjectID has been selected and the Model saved."
End If
      '   END FORMULA; PROC ID:17; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Process_Building_Automation_Drawings_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EnableDrawings() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EnableDrawings").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:540; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:540; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_EnableDrawings", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CORAInfoNotSavedText() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CORAInfoNotSavedText").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:420; TYPE:PF
      Result = "Save the Model to Lock-In the CORA Project ID and move to the next Process Steps"

If Me.CORAInfoSaved Then
	Result = ""
End If
      '   END FORMULA; PROP ID:420; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_CORAInfoNotSavedText", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CORAInfoSaved() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CORAInfoSaved").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:419; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:419; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_CORAInfoSaved", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EnableDrawings_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CORAInfoNotSavedText_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CORAInfoSaved_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EnableDrawings_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CORAInfoNotSavedText_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CORAInfoSaved_USERCHANGE() as Boolean
      Return True
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
      '   BEGIN FORMULA; SUB ID:18; TYPE:PN
      
      '   END FORMULA; SUB ID:18; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_CORA_Info_PARTNAMES", ex.Message)
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
      '   BEGIN FORMULA; SUB ID:18; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:18; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_CORA_Info_QUANTITY", ex.Message)
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
      '   BEGIN FORMULA; SUB ID:18; TYPE:OP
      result = "CORA_Project_Information"
      '   END FORMULA; SUB ID:18; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_CORA_Info_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drawings_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:32; TYPE:PN
      
      '   END FORMULA; SUB ID:32; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_Drawings_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drawings_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Drawings").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:32; TYPE:QF
      If Rootpart.EnableDrawings Then Result = 1
      '   END FORMULA; SUB ID:32; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_Drawings_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drawings_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Drawings").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:32; TYPE:OP
      result = "Drawing"
      '   END FORMULA; SUB ID:32; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_Drawings_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FacilityView_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:62; TYPE:PN
      
      '   END FORMULA; SUB ID:62; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_FacilityView_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FacilityView_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("FacilityView").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:62; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:62; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_FacilityView_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FacilityView_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("FacilityView").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:62; TYPE:OP
      Result = "FacilityModel"
      '   END FORMULA; SUB ID:62; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_FacilityView_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantView_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:26; TYPE:PN
      
      '   END FORMULA; SUB ID:26; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_PlantView_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantView_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PlantView").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:26; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:26; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_PlantView_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantView_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PlantView").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:26; TYPE:OP
      result = "PlantModel"
      '   END FORMULA; SUB ID:26; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_PlantView_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplyView_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:67; TYPE:PN
      
      '   END FORMULA; SUB ID:67; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_PowerSupplyView_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplyView_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PowerSupplyView").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:67; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:67; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_PowerSupplyView_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplyView_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PowerSupplyView").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:67; TYPE:OP
      result = "PowerSupplyModel"
      '   END FORMULA; SUB ID:67; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_PowerSupplyView_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Info_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:65; TYPE:PN
      
      '   END FORMULA; SUB ID:65; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_Project_Info_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Info_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Project_Info").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:65; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:65; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_Project_Info_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Info_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Project_Info").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:65; TYPE:OP
      result = "Project_Information"
      '   END FORMULA; SUB ID:65; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_Project_Info_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SiteInfo_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:12; TYPE:PN
      
      '   END FORMULA; SUB ID:12; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_SiteInfo_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SiteInfo_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("SiteInfo").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:12; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:12; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_SiteInfo_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SiteInfo_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("SiteInfo").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:12; TYPE:OP
      result = "Site"
      '   END FORMULA; SUB ID:12; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " BuildingAutomation.Formula_SiteInfo_OPTIMALPARTFAMILY", ex.Message)
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
    
      AddHandler ObjectManager.RsEngineer.RsActionButtonClick, AddressOf g_rsEngineer_RsActionButtonClick
      AddHandler ObjectManager.RsEngineer.RsAfterSave, AddressOf g_RsEngineer_AfterSave
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Overrides Sub RemoveRsEventHandlerMappings()
    
      RemoveHandler ObjectManager.RsEngineer.RsActionButtonClick, AddressOf g_rsEngineer_RsActionButtonClick
      RemoveHandler ObjectManager.RsEngineer.RsAfterSave, AddressOf g_RsEngineer_AfterSave
    End Sub
    #End Region

    End Class

  