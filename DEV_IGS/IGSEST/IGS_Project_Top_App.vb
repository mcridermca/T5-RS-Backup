Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: IGS_Project_Top_App
'$ GenerateDate: 07/15/2025 16:14:05

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
    Imports IGSEST.swMateType_e
    Imports IGSEST.swMateAlign_e
    Imports IGSEST.severity

    Public Class [IGS_Project_Top_App]
    
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

    Private this as IGS_Project_Top_App = me

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
      Case "51"
      Select Case processStep
        Case "66"
        Result = Process_DefaultProcess_Opportunity_COMMENT()
        
        Case "69"
        Result = Process_DefaultProcess_Salesforce_Instructions_COMMENT()
        
        Case "70"
        Result = Process_DefaultProcess_Salesforce_PRD_Import_COMMENT()
        
        Case "71"
        Result = Process_DefaultProcess_Tools_COMMENT()
        
        Case "103"
        Result = Process_DefaultProcess_Setup_And_Global_MTBF_COMMENT()
        
        Case "105"
        Result = Process_DefaultProcess_Sortation_COMMENT()
        
        Case "104"
        Result = Process_DefaultProcess_Scanner_Configurations_COMMENT()
        
        Case "79"
        Result = Process_DefaultProcess_Print_And_Apply_COMMENT()
        
        Case "78"
        Result = Process_DefaultProcess_Header_Hanger_Import_COMMENT()
        
        Case "76"
        Result = Process_DefaultProcess_EQS_Import_COMMENT()
        
        Case "85"
        Result = Process_DefaultProcess_Conveyer_Electrical_Installation_COMMENT()
        
        Case "86"
        Result = Process_DefaultProcess_Conveyor_Electrical_Installation_IGS_Personnel_COMMENT()
        
        Case "87"
        Result = Process_DefaultProcess_Base_Options_Alternates_Elec_Delta_COMMENT()
        
        Case "89"
        Result = Process_DefaultProcess_Power_Feeds_COMMENT()
        
        Case "90"
        Result = Process_DefaultProcess_Shuttle_Elec_COMMENT()
        
        Case "93"
        Result = Process_DefaultProcess_TTCB_Costing_Elec_COMMENT()
        
        Case "88"
        Result = Process_DefaultProcess_Output_Elec_COMMENT()
        
        Case "72"
        Result = Process_DefaultProcess_HCAD_Import_COMMENT()
        
        Case "80"
        Result = Process_DefaultProcess_Conveyor_Mechanical_Installation_COMMENT()
        
        Case "75"
        Result = Process_DefaultProcess_Structures_Platforms_COMMENT()
        
        Case "82"
        Result = Process_DefaultProcess_Air_Piping_COMMENT()
        
        Case "94"
        Result = Process_DefaultProcess_Chutes_COMMENT()
        
        Case "91"
        Result = Process_DefaultProcess_Shuttle_Mech_COMMENT()
        
        Case "92"
        Result = Process_DefaultProcess_TTCB_Costing_Mech_COMMENT()
        
        Case "83"
        Result = Process_DefaultProcess_Base_Options_Alternates_Mech_Delta_COMMENT()
        
        Case "84"
        Result = Process_DefaultProcess_Output_Mech_COMMENT()
        
        Case "101"
        Result = Process_DefaultProcess_Chutes_test_COMMENT()
        End Select
        End Select
      
    Return Result
    End Function

    Public Function GetProcessStepStatus(ByVal processId As String, ByVal processStep As String) As Integer Implements RuleStream.IRsPartFormulas.GetProcessStepStatus
    Dim Result as Integer 'Long
    Select Case processId
      Case "51"
      Select Case processStep
        Case "66"
        Result = Process_DefaultProcess_Opportunity_STATUS()
        
        Case "69"
        Result = Process_DefaultProcess_Salesforce_Instructions_STATUS()
        
        Case "70"
        Result = Process_DefaultProcess_Salesforce_PRD_Import_STATUS()
        
        Case "71"
        Result = Process_DefaultProcess_Tools_STATUS()
        
        Case "103"
        Result = Process_DefaultProcess_Setup_And_Global_MTBF_STATUS()
        
        Case "105"
        Result = Process_DefaultProcess_Sortation_STATUS()
        
        Case "104"
        Result = Process_DefaultProcess_Scanner_Configurations_STATUS()
        
        Case "79"
        Result = Process_DefaultProcess_Print_And_Apply_STATUS()
        
        Case "78"
        Result = Process_DefaultProcess_Header_Hanger_Import_STATUS()
        
        Case "76"
        Result = Process_DefaultProcess_EQS_Import_STATUS()
        
        Case "85"
        Result = Process_DefaultProcess_Conveyer_Electrical_Installation_STATUS()
        
        Case "86"
        Result = Process_DefaultProcess_Conveyor_Electrical_Installation_IGS_Personnel_STATUS()
        
        Case "87"
        Result = Process_DefaultProcess_Base_Options_Alternates_Elec_Delta_STATUS()
        
        Case "89"
        Result = Process_DefaultProcess_Power_Feeds_STATUS()
        
        Case "90"
        Result = Process_DefaultProcess_Shuttle_Elec_STATUS()
        
        Case "93"
        Result = Process_DefaultProcess_TTCB_Costing_Elec_STATUS()
        
        Case "88"
        Result = Process_DefaultProcess_Output_Elec_STATUS()
        
        Case "72"
        Result = Process_DefaultProcess_HCAD_Import_STATUS()
        
        Case "80"
        Result = Process_DefaultProcess_Conveyor_Mechanical_Installation_STATUS()
        
        Case "75"
        Result = Process_DefaultProcess_Structures_Platforms_STATUS()
        
        Case "82"
        Result = Process_DefaultProcess_Air_Piping_STATUS()
        
        Case "94"
        Result = Process_DefaultProcess_Chutes_STATUS()
        
        Case "91"
        Result = Process_DefaultProcess_Shuttle_Mech_STATUS()
        
        Case "92"
        Result = Process_DefaultProcess_TTCB_Costing_Mech_STATUS()
        
        Case "83"
        Result = Process_DefaultProcess_Base_Options_Alternates_Mech_Delta_STATUS()
        
        Case "84"
        Result = Process_DefaultProcess_Output_Mech_STATUS()
        
        Case "101"
        Result = Process_DefaultProcess_Chutes_test_STATUS()
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
    
      Public ReadOnly Property [Project_Information]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Project_Information")
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
    InitPart("IGS_Project_Top_App", <a><![CDATA[IGS_Project_Top_App]]></a>.Value, 376, "IGSEST",  "", "", True, True, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/15/2025 13:56:05")
    AddProperty("4821", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/23/2025 1:10:55 PM")
    
      oSubpart = AddSubpart(255,"Project_Information", <a><![CDATA[Project_Information]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "6/23/2025 1:12:18 PM")
      
        oSubpart.AddVPF (374, "IGS_Opportunity", "IGS_Opportunity")
      
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Sub Initialize_Process(ByVal lngProcessID as Integer) Implements RuleStream.IRsPartFormulas.InitializeProcess
    Select Case lngProcessID
    
      Case 51
      Process = "DefaultProcess"	
        Initialize_Process_DefaultProcess_Opportunity()
        Initialize_Process_DefaultProcess_Salesforce_Instructions()
        Initialize_Process_DefaultProcess_Salesforce_PRD_Import()
        Initialize_Process_DefaultProcess_Tools()
        Initialize_Process_DefaultProcess_Setup_And_Global_MTBF()
        Initialize_Process_DefaultProcess_Sortation()
        Initialize_Process_DefaultProcess_Scanner_Configurations()
        Initialize_Process_DefaultProcess_Print_And_Apply()
        Initialize_Process_DefaultProcess_Header_Hanger_Import()
        Initialize_Process_DefaultProcess_EQS_Import()
        Initialize_Process_DefaultProcess_Conveyer_Electrical_Installation()
        Initialize_Process_DefaultProcess_Conveyor_Electrical_Installation_IGS_Personnel()
        Initialize_Process_DefaultProcess_Base_Options_Alternates_Elec_Delta()
        Initialize_Process_DefaultProcess_Power_Feeds()
        Initialize_Process_DefaultProcess_Shuttle_Elec()
        Initialize_Process_DefaultProcess_TTCB_Costing_Elec()
        Initialize_Process_DefaultProcess_Output_Elec()
        Initialize_Process_DefaultProcess_HCAD_Import()
        Initialize_Process_DefaultProcess_Conveyor_Mechanical_Installation()
        Initialize_Process_DefaultProcess_Structures_Platforms()
        Initialize_Process_DefaultProcess_Air_Piping()
        Initialize_Process_DefaultProcess_Chutes()
        Initialize_Process_DefaultProcess_Shuttle_Mech()
        Initialize_Process_DefaultProcess_TTCB_Costing_Mech()
        Initialize_Process_DefaultProcess_Base_Options_Alternates_Mech_Delta()
        Initialize_Process_DefaultProcess_Output_Mech()
        Initialize_Process_DefaultProcess_Chutes_test()
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
        Private Sub Initialize_Process_DefaultProcess_Opportunity()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(66, "Opportunity", "Proposal and PRD selection screen", 1, 51, 1, 1, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity")
        oProcessStep.AddFilter(1, 376, "System", 0, "PartNumber", 0)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 374, "1", "0", "RsGrid", 0, "", 168, 12, 319, 497, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,253,Proposal_Information;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 374, "2", "1", "RsGridColumn", 0, "Proposal_Name", 0, 0, 0, 150, 0, "Proposal", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 374, "3", "0", "RsLabel", 0, "", 0, 0, 34, 458, 1, "IGS Integrated Applications Example", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 374, "4", "0", "RsAddDeleteCopy", 0, "", 493, 351, 22, 158, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,253,Proposal_Information;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 374, "5", "0", "RsLabel", 0, "", 92, 22, 73, 354, 3, "TBA ..... Instructions to be updated to reflect business process and data sources", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.11;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 374, "6", "0", "RsSubForm", 0, "", 132, 542, 412, 712, 4, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,253,Proposal_Information")
        oProcessStep.AddCustomLayout(1, 374, "7", "6", "RsGrid", 0, "", 36, 95, 319, 497, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,256,PRD_Document;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 374, "8", "7", "RsGridColumn", 0, "PRD_Name", 0, 0, 0, 150, 0, "PRD", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 374, "9", "6", "RsAddDeleteCopy", 0, "", 361, 434, 22, 158, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,256,PRD_Document;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 374, "10", "0", "RsLabel", 0, "", 50, 22, 27, 354, 7, "Instructions", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.14;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Salesforce_Instructions()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(69, "Salesforce Instructions", "", 103, 51, 1, 2, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 163, "1", "0", "RsLabel", 0, "", 0, 0, 34, 458, 0, "IGS Integrated Applications Example", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "2", "0", "RsLabel", 0, "", 92, 22, 73, 354, 1, "TBA ..... Instructions to be updated to reflect business process and data sources", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.11;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "3", "0", "RsLabel", 0, "", 175, 22, 27, 408, 2, "Select Opportunity Data Source To Continue", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "4", "0", "RsLabel", 0, "", 50, 22, 27, 354, 3, "Instructions", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.14;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "5", "0", "RsGroupBox", 0, "", 205, 22, 212, 436, 4, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 163, "6", "5", "RsRadioButton", 0, "Opportunity_Data_Source_Type", 23, 20, 18, 72, 5, "Manual", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 163, "7", "5", "RsLabel", 0, "", 86, 38, 21, 370, 6, "- Copy and Paste Products &amp;amp; Weights from Salesforce PRD Document", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "8", "5", "RsRadioButton", 0, "Opportunity_Data_Source_Type", 65, 20, 18, 116, 7, "Salesforce PRD", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 163, "9", "5", "RsLabel", 0, "", 41, 38, 21, 230, 8, "- Manually Enter Product Details and Weights", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "10", "5", "RsLabel", 0, "", 131, 38, 21, 370, 9, "- TBA (Not Available / Coming Soon)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "11", "5", "RsLabel", 0, "", 176, 38, 21, 370, 10, "- TBA (Not Available / Coming Soon)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "12", "5", "RsLabel", 0, "", 65, 138, 21, 130, 11, "(Copy/Paste Method)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "13", "5", "RsRadioButton", 0, "Opportunity_Data_Source_Type", 155, 20, 18, 293, 12, "CORA Project        (Direct Import  By Project #)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 163, "14", "5", "RsRadioButton", 0, "Opportunity_Data_Source_Type", 110, 20, 18, 294, 13, "Salesforce PRD     (Direct Import  By Project #)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Salesforce_PRD_Import()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(70, "Salesforce PRD Import", "", 103, 51, 1, 3, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 163, "1", "0", "RsTextbox", 0, "PRD_Input_Text_Tab_Formatted", 131, 0, 630, 577, 0, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "2", "0", "RsTextbox", 0, "PRD_TOTAL_DEBUG", 131, 583, 304, 677, 1, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "3", "0", "RsLabel", 0, "", 0, 583, 35, 342, 2, "PRD Item Import", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.20;Font_Style:1.;ForeColor:ActiveCaption;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "4", "0", "RsLabel", 0, "", 0, 0, 35, 520, 3, "Salesforce PRD Product Import", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.20;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "5", "0", "RsLabel", 0, "", 35, 583, 29, 520, 4, "Step 2: Review &amp;amp; Import PRD", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.14;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "6", "0", "RsLabel", 0, "", 64, 22, 40, 520, 5, "(Please Note, you may have to paste and copy from MS Excel to capture HTML Formatting Properly)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "7", "0", "RsLabel", 0, "", 35, 0, 29, 520, 6, "Step 1: Copy &amp;amp; Paste PRD Information Below", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.14;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "8", "0", "RsActionButton", 0, "", 441, 1090, 50, 170, 7, "Import Items", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:FRT_Import_Items;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Tools()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(71, "Tools", "", 104, 51, 1, 4, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 377, "1", "0", "RsCheckbox", 0, "HasHeaderHanger", 227, 81, 18, 105, 0, "Header Hanger", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 377, "2", "0", "RsCheckbox", 0, "HasMechInstall", 275, 81, 18, 89, 1, "Mech Install", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 377, "3", "0", "RsLabel", 0, "", 0, 0, 34, 494, 2, "IGS Integrated Applications Example", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 377, "4", "0", "RsLabel", 0, "", 92, 22, 73, 354, 3, "Select the tool(s) to be included in this PRD", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.11;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 377, "5", "0", "RsLabel", 0, "", 50, 22, 27, 354, 4, "Instructions", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.14;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 377, "6", "0", "RsCheckbox", 0, "HasAppCalc", 203, 81, 18, 74, 5, "App Calc", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 377, "7", "0", "RsCheckbox", 0, "HasElecInstall", 251, 81, 18, 83, 6, "Elec Install", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 377, "8", "0", "RsGrid", 0, "", 50, 618, 319, 497, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,116,ToolRollup;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 377, "9", "8", "RsGridColumn", 0, "Tool_Name", 0, 0, 0, 150, 0, "Tool", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 377, "10", "8", "RsGridColumn", 0, "Tool_Status", 0, 0, 0, 150, 0, "Status", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Setup_And_Global_MTBF()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(103, "Setup And Global MTBF", "Setup And Global MTBF", 106, 51, 1, 5, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.App_Calc/CAE_App_Calc.Setup/APC_Setup")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 119, "1", "0", "RsLabel", 0, "", 9, 12, 36, 384, 0, "Setup", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "2", "0", "RsGroupBox", 0, "", 48, 12, 130, 744, 1, "Site / Customer Information", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 119, "3", "2", "RsTextbox", 0, "Customer_Name", 32, 127, 26, 528, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "4", "2", "RsTextbox", 0, "Customer_Location_CityState", 64, 127, 26, 528, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "5", "2", "RsTextbox", 0, "Proposal_No", 92, 127, 26, 264, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "6", "2", "RsLabel", 0, "", 92, 393, 30, 58, 5, "Date:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "7", "2", "RsSingleDatePicker", 0, "Proposal_Date", 92, 457, 20, 198, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 119, "8", "2", "RsLabel", 0, "", 92, 35, 30, 86, 7, "Proposal #:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "9", "2", "RsLabel", 0, "", 64, 6, 30, 115, 8, "Location (City, St):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "10", "2", "RsLabel", 0, "", 34, 35, 30, 86, 9, "Customer Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "11", "0", "RsGroupBox", 0, "", 184, 12, 106, 744, 10, "Instructions / Notes", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "12", "11", "RsLabel", 0, "", 28, 22, 68, 706, 11, "Use this sheet to setup the General &amp;quot;Material to be Handled&amp;quot; parameters to be used globally throughout the remaining worksheets. Some of the worksheets have the option to use locally defined &amp;quot;Material to be Handled&amp;quot; parameters instead of these &amp;quot;Global&amp;quot; parameters defined on this sheet.  This feature is provided where there is a possibility that these material parameters could be more restrictive than the system as a whole.", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "13", "0", "RsGroupBox", 0, "", 296, 12, 192, 744, 12, "Material Size", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "14", "13", "RsComboBox", 0, "User_UOM_System", 28, 127, 22, 172, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "15", "13", "RsTextbox", 0, "BoxSize_Length_Min_User", 95, 127, 21, 60, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "16", "13", "RsComboBox", 0, "BoxSize_Length_Min_User_UOM", 94, 187, 22, 60, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "17", "13", "RsLabel", 0, "", 127, 40, 16, 78, 16, "Maximum", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "18", "13", "RsTextbox", 0, "BoxSize_Width_Min_User", 95, 253, 21, 60, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "19", "13", "RsComboBox", 0, "BoxSize_Length_Min_User_UOM", 94, 318, 22, 60, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "20", "13", "RsTextbox", 0, "BoxSize_Height_Min_User", 95, 384, 21, 60, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "21", "13", "RsComboBox", 0, "BoxSize_Height_Min_User_UOM", 94, 444, 22, 60, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "22", "13", "RsTextbox", 0, "BoxSize_Weight_Min_User", 95, 510, 21, 60, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "23", "13", "RsComboBox", 0, "BoxSize_Weight_Min_User_UOM", 94, 570, 22, 60, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "24", "13", "RsLabel", 0, "", 28, 34, 16, 78, 23, "Default UOM", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "25", "13", "RsTextbox", 0, "BoxSize_Length_Max_User", 122, 127, 21, 60, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "26", "13", "RsComboBox", 0, "BoxSize_Length_Max_User_UOM", 121, 187, 22, 60, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "27", "13", "RsTextbox", 0, "BoxSize_Width_Max_User", 122, 253, 21, 60, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "28", "13", "RsComboBox", 0, "BoxSize_Length_Max_User_UOM", 121, 318, 22, 60, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "29", "13", "RsTextbox", 0, "BoxSize_Height_Max_User", 122, 384, 21, 60, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "30", "13", "RsComboBox", 0, "BoxSize_Height_Max_User_UOM", 121, 444, 22, 60, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "31", "13", "RsTextbox", 0, "BoxSize_Weight_Max_User", 122, 510, 21, 60, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "32", "13", "RsComboBox", 0, "BoxSize_Weight_Max_User_UOM", 121, 570, 22, 60, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "33", "13", "RsTextbox", 0, "BoxSize_Length_Avg_User", 149, 127, 21, 60, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "34", "13", "RsComboBox", 0, "BoxSize_Length_Avg_User_UOM", 148, 187, 22, 60, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "35", "13", "RsTextbox", 0, "BoxSize_Width_Avg_User", 149, 253, 21, 60, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "36", "13", "RsComboBox", 0, "BoxSize_Length_Avg_User_UOM", 148, 318, 22, 60, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "37", "13", "RsTextbox", 0, "BoxSize_Height_Avg_User", 149, 384, 21, 60, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "38", "13", "RsLabel", 0, "", 75, 384, 16, 134, 37, "Height", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "39", "13", "RsComboBox", 0, "BoxSize_Height_Avg_User_UOM", 148, 444, 22, 60, 38, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "40", "13", "RsTextbox", 0, "BoxSize_Weight_Avg_User", 149, 510, 21, 60, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "41", "13", "RsComboBox", 0, "BoxSize_Weight_Max_User_UOM", 148, 570, 22, 60, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "42", "13", "RsLabel", 0, "", 154, 40, 16, 78, 41, "Average", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "43", "13", "RsLabel", 0, "", 100, 40, 16, 78, 42, "Minimum", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "44", "13", "RsLabel", 0, "", 75, 510, 16, 106, 43, "Weight", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "45", "13", "RsLabel", 0, "", 75, 245, 16, 100, 44, "Width", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "46", "13", "RsLabel", 0, "", 75, 127, 16, 78, 45, "Length", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "47", "0", "RsGroupBox", 0, "", 494, 12, 155, 744, 46, "MTBH Factors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "48", "47", "RsTextbox", 0, "Live_Load_Avg_User", 21, 128, 21, 60, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "49", "47", "RsLabel", 0, "", 20, 44, 16, 78, 48, "Live Load:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "50", "47", "RsComboBox", 0, "Live_Load_Avg_User_UOM", 20, 197, 22, 60, 49, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "51", "47", "RsCheckbox", 0, "Totes_Plastic", 48, 128, 18, 129, 50, "Plastic Totes in Use?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "52", "47", "RsCheckbox", 0, "BoxSize_Height_GRTR_Len_Possible", 72, 128, 18, 298, 51, "Within MTBH Range, Can Product Heights be &amp;gt; Length?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "53", "47", "RsCheckbox", 0, "BoxSize_Other_Known_Issues", 96, 128, 18, 175, 52, "Other Known Stability Issues?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "54", "47", "RsComboBox", 0, "Selected_Sortation_Controls", 120, 128, 22, 140, 53, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "55", "47", "RsLabel", 0, "", 95, 398, 22, 114, 54, "Worst Case H/L Ratio:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "56", "47", "RsTextbox", 0, "Temp_Sort_Operating_Min_User", 18, 518, 21, 74, 55, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "57", "47", "RsComboBox", 0, "Temp_Sort_Operating_Min_User_UOM", 17, 598, 22, 60, 56, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "58", "47", "RsLabel", 0, "", 122, 398, 16, 114, 57, "Max Incline / Decline:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "59", "47", "RsTextbox", 0, "Temp_System_Operating_Min_User", 45, 518, 21, 74, 58, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "60", "47", "RsLabel", 0, "", 122, 584, 22, 60, 59, "Degrees", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "61", "47", "RsComboBox", 0, "Temp_System_Operating_Min_UOM", 44, 598, 22, 60, 60, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "62", "47", "RsTextbox", 0, "BoxSize_Worst_Case_HL_Ratio", 96, 518, 21, 60, 61, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "63", "47", "RsTextbox", 0, "Belt_InclineDecline_Max_Deg", 123, 518, 21, 60, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "64", "47", "RsLabel", 0, "", 120, 44, 16, 78, 63, "Control System:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "65", "47", "RsLabel", 0, "", 17, 346, 18, 166, 64, "Operating Temp Min ( Sorter ):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "66", "47", "RsLabel", 0, "", 48, 346, 18, 166, 65, "Operating Temp Min ( System ):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "67", "47", "RsTextbox", 0, "Temp_Sort_Operating_Min_F", 18, 664, 25, 74, 66, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "68", "47", "RsTextbox", 0, "Temp_System_Operating_Min_F", 44, 664, 25, 74, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "69", "0", "RsGroupBox", 0, "", 655, 12, 200, 744, 68, "General Application Factors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "70", "69", "RsLabel", 0, "", 29, 43, 16, 78, 69, "Product Line:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "71", "69", "RsComboBox", 0, "Conveyor_Product_Line_Used", 29, 127, 22, 140, 70, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "72", "69", "RsLabel", 0, "", 142, 346, 22, 177, 71, "Target Case Length per Minute:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "73", "69", "RsTextbox", 0, "Conveyor_Width_Min_IN", 61, 127, 21, 74, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "74", "69", "RsLabel", 0, "", 29, 282, 18, 316, 73, "Total Skew Length Required for Selected MTBH Width and BF", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "75", "69", "RsTextbox", 0, "Conveyor_Curve_BF_Calc_Min_In", 88, 128, 21, 74, 74, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "76", "69", "RsTextbox", 0, "Conveyor_Curve_BF_Calc_Rcmd_In", 115, 127, 21, 74, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "77", "69", "RsComboBox", 0, "Conveyor_BF_Selected_Min_User", 142, 127, 22, 140, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "78", "69", "RsTextbox", 0, "Material_Gap_Override_User", 167, 529, 21, 60, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "79", "69", "RsComboBox", 0, "Conveyor_BF_Selected_Min_User_UOM", 142, 267, 22, 60, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "80", "69", "RsLabel", 0, "", 64, 6, 18, 115, 79, "Min Converyor Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "81", "69", "RsTextbox", 0, "Conveyor_Skew_Total_Length_MTBH_Width_IN", 26, 604, 21, 74, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "82", "69", "RsTextbox", 0, "Conveyor_Skew_Bed_Length_Min_Reqd_IN", 53, 604, 21, 74, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "83", "69", "RsLabel", 0, "", 114, 346, 22, 177, 82, "Target Sort Rate:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "84", "69", "RsCheckbox", 0, "Sort_Dual_Sided", 80, 584, 18, 129, 83, "Dual Sided Sortation", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "85", "69", "RsLabel", 0, "", 145, 684, 18, 22, 84, "M", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "86", "69", "RsTextbox", 0, "Sort_Rate_Required_CPM", 114, 529, 21, 60, 85, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "87", "69", "RsLabel", 0, "", 166, 418, 22, 105, 86, "Design Gap Override:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "88", "69", "RsLabel", 0, "", 117, 590, 18, 116, 87, "CPM (Cases Per Min)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "89", "69", "RsTextbox", 0, "Case_Length_Per_Minute_Target_FT", 142, 529, 21, 60, 88, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "90", "69", "RsLabel", 0, "", 145, 590, 18, 22, 89, "Ft.", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "91", "69", "RsTextbox", 0, "Case_Length_Per_Minute_Target_M", 142, 618, 21, 60, 90, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "92", "69", "RsLabel", 0, "", 91, 7, 18, 115, 91, "Min Calc Curve Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "93", "69", "RsComboBox", 0, "Material_Gap_Override_User_UOM", 166, 595, 22, 60, 92, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "94", "69", "RsLabel", 0, "", 56, 253, 18, 345, 93, "Minimum Required Skew Bed Length for Selected MTBH Width and BF", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "95", "69", "RsLabel", 0, "", 118, 6, 18, 115, 94, "Min Rcmd Curve Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "96", "69", "RsLabel", 0, "", 29, 684, 18, 22, 95, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "97", "69", "RsLabel", 0, "", 56, 684, 18, 22, 96, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "98", "69", "RsLabel", 0, "", 142, 16, 22, 105, 97, "Selected Min Wdith:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "99", "69", "RsLabel", 0, "", 91, 207, 18, 22, 98, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "100", "69", "RsLabel", 0, "", 64, 207, 18, 22, 99, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "101", "69", "RsLabel", 0, "", 118, 207, 18, 22, 100, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "102", "0", "RsPrevActionButton", 0, "", 861, 12, 38, 94, 101, "Previous", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 119, "103", "0", "RsNextActionButton", 0, "", 861, 634, 38, 116, 102, "Next", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Sortation()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(105, "Sortation", "Sortation", 106, 51, 1, 6, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.App_Calc/CAE_App_Calc.Sortation/APC_Sortation")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 120, "1", "0", "RsLabel", 0, "", 0, 12, 26, 384, 0, "Sortation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 120, "2", "0", "RsLabel", 0, "", 73, 812, 36, 384, 1, "Warnings And Errors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:Firebrick;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 120, "3", "0", "RsGroupBox", 0, "", 234, 12, 155, 732, 2, "Ingore this box, Nothing to see here.. Pleae Move along", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 120, "4", "3", "RsLabel", 0, "", 20, 44, 16, 78, 3, "Conveyor Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 120, "5", "3", "RsComboBox", 0, "", 18, 128, 22, 60, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 120, "6", "3", "RsCheckbox", 0, "", 48, 128, 18, 129, 5, "Plastic Totes in Use?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 120, "7", "3", "RsLabel", 0, "", 19, 194, 16, 34, 6, "(In)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 120, "8", "3", "RsCheckbox", 0, "", 72, 128, 18, 298, 7, "Within MTBH Range, Can Product Heights be &amp;gt; Length?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 120, "9", "3", "RsPanel", 0, "", 17, 33, 127, 687, 8, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 120, "10", "3", "RsCheckbox", 0, "", 96, 128, 18, 175, 9, "Other Known Stability Issues?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 120, "11", "3", "RsComboBox", 0, "", 120, 128, 22, 140, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 120, "12", "3", "RsLabel", 0, "", 95, 398, 22, 114, 11, "Worst Case H/L Ratio:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 120, "13", "3", "RsTextbox", 0, "", 18, 518, 21, 74, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 120, "14", "3", "RsComboBox", 0, "", 17, 598, 22, 60, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 120, "15", "3", "RsLabel", 0, "", 122, 398, 16, 114, 14, "Max Incline / Decline:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 120, "16", "3", "RsTextbox", 0, "", 45, 518, 21, 74, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 120, "17", "3", "RsLabel", 0, "", 122, 584, 22, 60, 16, "Degrees", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 120, "18", "3", "RsComboBox", 0, "", 44, 598, 22, 60, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 120, "19", "3", "RsTextbox", 0, "", 96, 518, 21, 60, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 120, "20", "3", "RsTextbox", 0, "", 123, 518, 21, 60, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 120, "21", "3", "RsLabel", 0, "", 120, 44, 16, 78, 20, "Control System:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 120, "22", "3", "RsLabel", 0, "", 17, 346, 18, 166, 21, "Operating Temp Min ( Sorter ):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 120, "23", "3", "RsLabel", 0, "", 48, 346, 18, 166, 22, "Operating Temp Min ( System ):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 120, "24", "3", "RsTextbox", 0, "", 18, 664, 25, 74, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 120, "25", "3", "RsTextbox", 0, "", 44, 664, 25, 74, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 120, "26", "0", "RsGroupBox", 0, "", 73, 12, 155, 732, 25, "TBD", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 120, "27", "26", "RsLabel", 0, "", 20, 12, 16, 110, 26, "Conveyor Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 120, "28", "26", "RsLabel", 0, "", 19, 194, 16, 34, 27, "(In)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 120, "29", "26", "RsComboBox", 0, "Sorter_Selected_Width_IN", 18, 128, 22, 60, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 120, "30", "26", "RsTextbox", 0, "", 18, 518, 21, 74, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 120, "31", "26", "RsComboBox", 0, "", 17, 598, 22, 60, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 120, "32", "0", "RsTextbox", 0, "", 121, 812, 519, 788, 31, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Scanner_Configurations()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(104, "Scanner Configurations", "", 106, 51, 1, 7, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.App_Calc/CAE_App_Calc")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 411, "1", "0", "RsLabel", 0, "", 9, 28, 33, 294, 0, "Scanner Configuration", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "2", "0", "RsGrid", 0, "", 45, 28, 120, 900, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,335,Scan_Configurations;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 411, "3", "2", "RsGridColumn", 0, "Configuration_Name", 0, 0, 0, 120, 0, "Configuration_Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "4", "2", "RsGridColumn", 0, "AppType", 0, 0, 0, 100, 0, "AppType", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "5", "0", "RsSubForm", 0, "", 226, 12, 638, 1000, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,335,Scan_Configurations")
        oProcessStep.AddCustomLayout(1, 411, "6", "5", "RsGroupBox", 0, "", 22, 25, 355, 468, 3, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "7", "6", "RsTextbox", 0, "MinGapForScan_IN", 38, 202, 20, 78, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 411, "8", "6", "RsLabel", 0, "", 245, 60, 18, 136, 5, "Minimum Gap Required:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "9", "6", "RsComboBox", 0, "GapControlMethod", 14, 202, 24, 153, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "10", "6", "RsLabel", 0, "", 194, 60, 18, 136, 7, "Primary Application Type:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "11", "6", "RsLabel", 0, "", 16, 6, 22, 190, 8, "Gap Control (From Soratation):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "12", "6", "RsTextbox", 0, "BoxPanelsScanned", 166, 202, 20, 148, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 411, "13", "6", "RsCheckbox", 0, "ShadowingPotential", 88, 202, 18, 125, 10, "Shadowing Possible", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "14", "6", "RsLabel", 0, "", 168, 88, 18, 108, 11, "Qty Panels Scanned:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "15", "6", "RsCheckbox", 0, "UsePandAMTBH", 64, 202, 18, 114, 12, "Use PandA MTBH", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "16", "6", "RsLabel", 0, "", 324, 60, 18, 136, 13, "Vendor Read Window Size", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "17", "6", "RsComboBox", 0, "CartonPresentation", 136, 202, 24, 153, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "18", "6", "RsComboBox", 0, "ShadowingStatus", 106, 202, 24, 153, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "19", "6", "RsComboBox", 0, "User_UOM_System", 218, 202, 24, 153, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "20", "6", "RsLabel", 0, "", 38, 313, 18, 30, 17, "IN", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "21", "6", "RsTextbox", 0, "AppType", 192, 202, 20, 148, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 411, "22", "6", "RsLabel", 0, "", 142, 82, 18, 114, 19, "Carton Presentation:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "23", "6", "RsTextbox", 0, "MinGapRequired_User", 245, 202, 20, 88, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 411, "24", "6", "RsLabel", 0, "", 112, 82, 18, 114, 21, "Shadowing Allowed?", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "25", "6", "RsTextbox", 0, "MinGapOverride_Vendor_Provider_User", 271, 202, 20, 88, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 411, "26", "6", "RsLabel", 0, "", 38, 40, 18, 156, 23, "Min Gap Allowed:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "27", "6", "RsLabel", 0, "", 273, 34, 18, 162, 24, "Min Gap Reqd (Vendor) Overide:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "28", "6", "RsTextbox", 0, "ReadWindowSize_Vendor_Supplied_USER", 324, 202, 20, 88, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 411, "29", "6", "RsTextbox", 0, "ReadWindowSize_USER", 294, 202, 20, 148, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 411, "30", "6", "RsLabel", 0, "", 296, 20, 18, 176, 27, "Read Window Size (Estimated)", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "31", "6", "RsLabel", 0, "", 218, 54, 18, 142, 28, "System (Global Setup):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "32", "6", "RsLabel", 0, "MinGapRequired_User_UOM", 273, 296, 18, 31, 29, "", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "33", "6", "RsLabel", 0, "MinGapRequired_User_UOM", 326, 296, 18, 31, 30, "", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "34", "6", "RsLabel", 0, "MinGapRequired_User_UOM", 245, 296, 18, 31, 31, "", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "35", "5", "RsGroupBox", 0, "", 402, 25, 236, 968, 32, "Panel Configuration", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "36", "35", "RsGrid", 0, "", 21, 6, 209, 953, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,333,Panel_Configs;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 411, "37", "36", "RsGridColumn", 0, "Panel_ID", 0, 0, 0, 100, 0, "Panel_ID", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "38", "36", "RsGridColumn", 0, "Is_Scanned", 0, 0, 0, 100, 0, "Is_Scanned", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "39", "36", "RsGridColumn", 0, "Scanner_Selected", 0, 0, 0, 150, 0, "Scanner_Selected", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "40", "36", "RsGridColumn", 0, "Scan_Type", 0, 0, 0, 100, 0, "Scan_Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "41", "36", "RsGridColumn", 0, "Scanner_CCD_Position", 0, 0, 0, 100, 0, "Scanner_CCD_Position", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "42", "36", "RsGridColumn", 0, "Scan_Angle_Degrees", 0, 0, 0, 100, 0, "Scan Angle Degrees", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "43", "36", "RsGridColumn", 0, "Scan_Head_Location", 0, 0, 0, 100, 0, "Scan Head Location", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "44", "36", "RsGridColumn", 0, "Product_Spacing_Category", 0, 0, 0, 100, 0, "Spacing Category", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "45", "36", "RsGridColumn", 0, "Min_Gap_Required", 0, 0, 0, 100, 0, "Min_Gap_Reqd", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "46", "0", "RsAddDeleteCopy", 0, "", 182, 704, 38, 224, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,335,Scan_Configurations;CanDelete:;AddPrompt:False;ShowCopy:True")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Print_And_Apply()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(79, "Print And Apply", "", 106, 51, 1, 8, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.App_Calc/CAE_App_Calc.Print_And_Apply/CAE_App_Calc_Print_And_Apply")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 416, "1", "0", "RsGroupBox", 0, "", 67, 393, 162, 584, 0, "Material To Be Handled", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "2", "1", "RsTextbox", 0, "MTBH_Width_Average_User", 130, 207, 22, 48, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "3", "1", "RsTextbox", 0, "MTBH_Length_Average_User", 131, 81, 22, 48, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "4", "1", "RsComboBox", 0, "MTBH_Height_Minimum_User_UOM", 74, 384, 22, 52, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "5", "1", "RsTextbox", 0, "MTBH_Length_Maximum_User", 103, 81, 22, 48, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "6", "1", "RsComboBox", 0, "MTBH_Width_Average_User_UOM", 130, 261, 22, 52, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "7", "1", "RsComboBox", 0, "MTBH_Weight_Maximum_User_UOM", 102, 509, 22, 52, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "8", "1", "RsComboBox", 0, "MTBH_Weight_Minimum_User_UOM", 74, 509, 22, 52, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "9", "1", "RsComboBox", 0, "MTBH_Height_Maximum_User_UOM", 102, 384, 22, 52, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "10", "1", "RsTextbox", 0, "MTBH_Weight_Average_User", 130, 455, 22, 48, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "11", "1", "RsTextbox", 0, "MTBH_Height_Average_User", 130, 330, 22, 48, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "12", "1", "RsComboBox", 0, "MTBH_Weight_Average_User_UOM", 130, 509, 22, 52, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "13", "1", "RsTextbox", 0, "MTBH_Weight_Minimum_User", 74, 455, 22, 48, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "14", "1", "RsComboBox", 0, "MTBH_Width_Maximum_User_UOM", 102, 261, 22, 52, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "15", "1", "RsComboBox", 0, "MTBH_Height_Average_User_UOM", 130, 384, 22, 52, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "16", "1", "RsTextbox", 0, "MTBH_Weight_Maximum_User", 102, 455, 22, 48, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "17", "1", "RsComboBox", 0, "MTBH_Length_Average_User_UOM", 131, 135, 22, 52, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "18", "1", "RsComboBox", 0, "MTBH_Length_Maximum_User_UOM", 103, 135, 22, 52, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "19", "1", "RsTextbox", 0, "MTBH_Height_Maximum_User", 102, 330, 22, 48, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "20", "1", "RsTextbox", 0, "MTBH_Height_Minimum_User", 74, 330, 22, 48, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "21", "1", "RsLabel", 0, "", 132, 6, 21, 69, 20, "Average", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "22", "1", "RsTextbox", 0, "MTBH_Width_Maximum_User", 102, 207, 22, 48, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "23", "1", "RsComboBox", 0, "MTBH_Width_Minimum_User_UOM", 74, 261, 22, 52, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "24", "1", "RsTextbox", 0, "MTBH_Width_Minimum_User", 74, 207, 22, 48, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "25", "1", "RsComboBox", 0, "MTBH_Length_Minimum_User_UOM", 75, 135, 22, 52, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "26", "1", "RsTextbox", 0, "MTBH_Length_Minimum_User", 75, 81, 22, 48, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "27", "1", "RsLabel", 0, "", 51, 455, 21, 69, 26, "Weight", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "28", "1", "RsLabel", 0, "", 51, 330, 21, 69, 27, "Height", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "29", "1", "RsLabel", 0, "", 75, 6, 21, 69, 28, "Minimum", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "30", "1", "RsLabel", 0, "", 51, 207, 21, 69, 29, "Width", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "31", "1", "RsLabel", 0, "", 51, 81, 21, 69, 30, "Length", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "32", "1", "RsComboBox", 0, "MTBH_Use_Local", 15, 81, 22, 73, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "33", "1", "RsLabel", 0, "", 16, 6, 21, 69, 32, "Use Local?", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "34", "1", "RsLabel", 0, "", 104, 6, 21, 69, 33, "Maximum", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "35", "0", "RsGroupBox", 0, "", 12, 12, 49, 166, 34, "Global Units", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "36", "35", "RsLabel", 0, "", 16, 12, 21, 39, 35, "Units", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "37", "35", "RsComboBox", 0, "User_UOM_System", 15, 57, 22, 95, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "38", "0", "RsGroupBox", 0, "", 67, 12, 357, 375, 37, "General Application Specific Selections", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "39", "38", "RsLabel", 0, "", 299, 6, 21, 219, 38, "B/M Belt Input Speed", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "40", "38", "RsComboBox", 0, "Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM", 242, 285, 22, 76, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "41", "38", "RsLabel", 0, "", 243, 6, 21, 219, 40, "B/M Belt Gap Required to Stop (Min. Carton)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "42", "38", "RsTextbox", 0, "Gen_BM_Belt_Acc_Dec_Rate_User", 186, 231, 22, 48, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "43", "38", "RsLabel", 0, "", 215, 6, 21, 219, 42, "Pre-PandA Accumulation Conveyor Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "44", "38", "RsComboBox", 0, "Gen_MDR_Min_Gap_Throughput_Limit_User_UOM", 326, 285, 22, 76, 43, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "45", "38", "RsTextbox", 0, "Gen_BM_Belt_PTO_Ratio", 270, 231, 22, 48, 44, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "46", "38", "RsLabel", 0, "", 187, 6, 21, 219, 45, "B/M Belt Acc/Dec Rate", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "47", "38", "RsTextbox", 0, "Gen_MDR_Min_Gap_Throughput_Limit_User", 326, 231, 22, 48, 46, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "48", "38", "RsTextbox", 0, "Gen_BM_Belt_Input_Speed_User", 298, 231, 22, 48, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "49", "38", "RsLabel", 0, "", 327, 6, 21, 219, 48, "Min Gap Throughout Limit (MDR Spacing)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "50", "38", "RsComboBox", 0, "Gen_BM_Belt_Input_Speed_User_UOM", 298, 285, 22, 76, 49, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "51", "38", "RsLabel", 0, "", 159, 6, 21, 219, 50, "Carton Spacing Conveyor Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "52", "38", "RsLabel", 0, "", 271, 6, 21, 219, 51, "Spacing B/M Belt PTO Ratio", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "53", "38", "RsLabel", 0, "", 131, 6, 21, 219, 52, "Pre-PandA Accumulation Zone Length", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "54", "38", "RsTextbox", 0, "Gen_BM_Belt_Gap_Stop_Min_Carton_User", 242, 231, 22, 48, 53, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "55", "38", "RsComboBox", 0, "Gen_Accumulation_Convey_Type_Pre_Panda", 214, 231, 22, 130, 54, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "56", "38", "RsLabel", 0, "", 47, 6, 21, 219, 55, "Choose Applicator Belt Speed", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "57", "38", "RsComboBox", 0, "Gen_BM_Belt_Acc_Dec_Rate_User_UOM", 186, 285, 22, 76, 56, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "58", "38", "RsComboBox", 0, "Gen_Conveyor_Type", 158, 231, 22, 130, 57, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "59", "38", "RsComboBox", 0, "Gen_Conveyor_Width_User_UOM", 74, 285, 22, 76, 58, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "60", "38", "RsLabel", 0, "", 103, 6, 21, 219, 59, "Pre-PandA Accumulation Zones", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "61", "38", "RsLabel", 0, "", 19, 6, 21, 219, 60, "Throughput Rate in CPM (Optional)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "62", "38", "RsTextbox", 0, "Gen_Accumulation_Zone_Length_User", 130, 231, 22, 48, 61, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "63", "38", "RsComboBox", 0, "Gen_Accumulation_Zone_Length_User_UOM", 130, 285, 22, 76, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "64", "38", "RsComboBox", 0, "Gen_Belt_Speed_User_UOM", 46, 285, 22, 76, 63, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "65", "38", "RsLabel", 0, "", 75, 6, 21, 219, 64, "Define Conveyor Width (B/F)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "66", "38", "RsTextbox", 0, "Gen_Accumulation_Zone_Quantity", 102, 231, 22, 48, 65, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "67", "38", "RsTextbox", 0, "Gen_Conveyor_Width_User", 74, 231, 22, 48, 66, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "68", "38", "RsTextbox", 0, "Gen_Belt_Speed_User", 46, 231, 22, 48, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "69", "38", "RsTextbox", 0, "Gen_Throughput_Rate", 18, 231, 22, 48, 68, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "70", "0", "RsGroupBox", 0, "", 430, 12, 397, 375, 69, "Induction Scanning Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "71", "70", "RsLabel", 0, "", 271, 6, 21, 219, 70, "% of Max Carton Length Scanned (Xmit)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "72", "70", "RsComboBox", 0, "Ind_Scan_Label_Orientation", 74, 231, 22, 130, 71, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "73", "70", "RsTextbox", 0, "Ind_Scan_Scan_Window_Length_Req_User", 214, 231, 22, 48, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "74", "70", "RsLabel", 0, "", 19, 6, 21, 219, 73, "Pre-defined Scanner Configuration", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "75", "70", "RsTextbox", 0, "Ind_Scan_Scan_App_Min_Gap_User", 186, 231, 22, 48, 74, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "76", "70", "RsLabel", 0, "", 159, 6, 21, 219, 75, "Shadowing Allowed", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "77", "70", "RsTextbox", 0, "Ind_Scan_Carton_Panels_Scanned_Quantity", 46, 231, 22, 48, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "78", "70", "RsComboBox", 0, "Ind_Scan_Scanner_Min_Xmit_Point_User_UOM", 354, 285, 22, 76, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "79", "70", "RsComboBox", 0, "Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM", 326, 285, 22, 76, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "80", "70", "RsLabel", 0, "", 103, 6, 21, 219, 79, "Carton Presentation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "81", "70", "RsTextbox", 0, "Ind_Scan_Scanner_Min_Xmit_Point_User", 354, 231, 22, 48, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "82", "70", "RsComboBox", 0, "Ind_Scan_Tracking_Photocell_Distance_User_UOM", 298, 285, 22, 76, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "83", "70", "RsLabel", 0, "", 355, 6, 21, 219, 82, "Scanner Min Xmit Point Downstream of Scan Window", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "84", "70", "RsTextbox", 0, "Ind_Scan_Carton_Scanned_Max_Lin_Length_User", 326, 231, 22, 48, 83, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "85", "70", "RsLabel", 0, "", 47, 6, 21, 219, 84, "Number of Carton Panels Scanned", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "86", "70", "RsLabel", 0, "", 327, 6, 21, 219, 85, "Max Linear Length of Carton Scanned", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "87", "70", "RsTextbox", 0, "Ind_Scan_Carton_Percent_Max_Length_Scanned_User", 270, 231, 22, 48, 86, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "88", "70", "RsTextbox", 0, "Ind_Scan_Tracking_Photocell_Distance_User", 298, 231, 22, 48, 87, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "89", "70", "RsLabel", 0, "", 299, 6, 21, 219, 88, "Tracking Photocell Distance From Scanner Xmit Point", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "90", "70", "RsComboBox", 0, "Ind_Scan_Scanner_Data_Transmit_Mode", 242, 231, 22, 130, 89, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "91", "70", "RsLabel", 0, "", 243, 6, 21, 219, 90, "Scanner Data Transmit Mode", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "92", "70", "RsComboBox", 0, "Ind_Scan_Scanner_Config", 18, 231, 22, 130, 91, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "93", "70", "RsComboBox", 0, "Ind_Scan_Scan_Window_Length_Req_User_UOM", 214, 285, 22, 76, 92, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "94", "70", "RsComboBox", 0, "Ind_Scan_Scan_App_Min_Gap_User_UOM", 186, 285, 22, 76, 93, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "95", "70", "RsLabel", 0, "", 215, 6, 21, 219, 94, "Scan Window Length Required (Linear)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "96", "70", "RsComboBox", 0, "Ind_Scan_Shadowing_Allowed", 158, 231, 22, 130, 95, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "97", "70", "RsLabel", 0, "", 187, 6, 21, 219, 96, "Min Gap for this Scanning Application", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "98", "70", "RsComboBox", 0, "Ind_Scan_Carton_Presentation", 102, 231, 22, 130, 97, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "99", "70", "RsComboBox", 0, "Ind_Scan_Shadowing_Potential", 130, 231, 22, 130, 98, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "100", "70", "RsLabel", 0, "", 131, 6, 21, 219, 99, "Shadowing Potential", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "101", "70", "RsLabel", 0, "", 75, 6, 21, 219, 100, "Label Orientation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "102", "0", "RsGroupBox", 0, "", 235, 396, 133, 375, 101, "Printed Label Data Acquisition Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "103", "102", "RsLabel", 0, "", 19, 6, 21, 219, 102, "Label Data Acquisition Method", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "104", "102", "RsTextbox", 0, "Acq_Label_Data_Acquisition_Travel_User", 102, 231, 22, 48, 103, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "105", "102", "RsTextbox", 0, "Acq_Max_Local_Lookup_Time_Secs", 74, 231, 22, 48, 104, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "106", "102", "RsLabel", 0, "", 75, 6, 21, 219, 105, "Max Local Lookup Time (secs)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "107", "102", "RsTextbox", 0, "Acq_Max_Host_Resp_Time_Secs", 46, 231, 22, 48, 106, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "108", "102", "RsLabel", 0, "", 47, 6, 21, 219, 107, "Max Host Response Time (secs)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "109", "102", "RsComboBox", 0, "Acq_Label_Data_Acquisition_Method", 18, 231, 22, 130, 108, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "110", "102", "RsComboBox", 0, "Acq_Label_Data_Acquisition_Travel_User_UOM", 102, 285, 22, 76, 109, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "111", "102", "RsLabel", 0, "", 103, 6, 21, 219, 110, "Label Data Acquisition Travel (in)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "112", "0", "RsGroupBox", 0, "", 67, 983, 167, 375, 111, "Reject Diverter Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "113", "112", "RsComboBox", 0, "Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM", 102, 285, 22, 76, 112, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "114", "112", "RsLabel", 0, "", 131, 6, 21, 219, 113, "Min H-to-H Spacing for Continuous Flow / Avg Carton", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "115", "112", "RsTextbox", 0, "Reject_Diverter_Min_Gap_Required_User", 74, 231, 22, 48, 114, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "116", "112", "RsComboBox", 0, "Reject_Diverter_Type", 46, 231, 22, 130, 115, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "117", "112", "RsLabel", 0, "", 47, 6, 21, 219, 116, "Reject Diverter Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "118", "112", "RsComboBox", 0, "Reject_Diverter_Min_Gap_Required_User_UOM", 74, 285, 22, 76, 117, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "119", "112", "RsLabel", 0, "", 75, 6, 21, 219, 118, "Minimum Diverter Gap Requirement", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "120", "112", "RsTextbox", 0, "Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User", 130, 231, 22, 48, 119, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "121", "112", "RsComboBox", 0, "Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM", 130, 285, 22, 76, 120, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "122", "112", "RsTextbox", 0, "Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User", 102, 231, 22, 48, 121, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "123", "112", "RsLabel", 0, "", 103, 6, 21, 219, 122, "Min H-to-H Spacing for Continuous Flow / Max Carton", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "124", "112", "RsLabel", 0, "", 19, 6, 21, 219, 123, "Reject Diverter Required", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "125", "112", "RsComboBox", 0, "Reject_Diverter_Required", 18, 231, 22, 130, 124, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "126", "0", "RsGroupBox", 0, "", 240, 983, 160, 259, 125, "Transnorm TS4800", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "127", "126", "RsTextbox", 0, "Transnorm_TS4800_Divert_Angle", 19, 195, 22, 48, 126, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "128", "126", "RsLabel", 0, "", 20, 6, 21, 183, 127, "Divert Angle (deg)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "129", "126", "RsTextbox", 0, "Transnorm_TS4800_Divert_Shifting_Distance_IN", 47, 195, 22, 48, 128, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "130", "126", "RsLabel", 0, "", 48, 6, 21, 183, 129, "Divert Shifting Distance (in)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "131", "126", "RsTextbox", 0, "Transnorm_TS4800_Control_Reaction_Time_Distance_IN", 75, 195, 22, 48, 130, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "132", "126", "RsLabel", 0, "", 76, 6, 21, 183, 131, "Control Reaction Time Distance (in)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "133", "126", "RsTextbox", 0, "Transnorm_TS4800_Encoder_Resolution_IN", 103, 195, 22, 48, 132, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "134", "126", "RsTextbox", 0, "Transnorm_TS4800_Required_Gap_Max_Box", 131, 195, 22, 48, 133, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "135", "126", "RsLabel", 0, "", 104, 6, 21, 183, 134, "Encoder Resolution (in)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "136", "126", "RsLabel", 0, "", 132, 6, 21, 183, 135, "Required Gap (Max Box) (in)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "137", "0", "RsGroupBox", 0, "", 712, 989, 115, 358, 136, "Conveyor Requirements Output", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "138", "137", "RsTextbox", 0, "Conv_Total_App_Belt_Length_Req_IN_User", 19, 219, 22, 48, 137, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "139", "137", "RsLabel", 0, "", 20, 6, 21, 207, 138, "Total Applicator Belt Length Required (in)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "140", "137", "RsTextbox", 0, "Conv_Total_App_Belt_Length_Req_FT_User", 47, 219, 22, 48, 139, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "141", "137", "RsLabel", 0, "", 48, 6, 21, 207, 140, "Total Applicator Belt Length Required (ft)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "142", "137", "RsTextbox", 0, "Conv_Total_Solution_Length_FT_User", 75, 219, 22, 48, 141, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "143", "137", "RsLabel", 0, "", 76, 6, 21, 207, 142, "Total Solution Length (ft)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "144", "137", "RsComboBox", 0, "Conv_Total_Solution_Length_FT_User_UOM", 75, 273, 22, 76, 143, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "145", "137", "RsComboBox", 0, "Conv_Total_App_Belt_Length_Req_FT_User_UOM", 47, 273, 22, 76, 144, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "146", "137", "RsComboBox", 0, "Conv_Total_App_Belt_Length_Req_IN_User_UOM", 19, 273, 22, 76, 145, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Header_Hanger_Import()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(78, "Header Hanger Import", "", 105, 51, 1, 9, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr")
        oProcessStep.AddLayout(1, 1, "1;2;0")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_EQS_Import()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(76, "EQS Import", "", 102, 51, 1, 10, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Elec_Install_Estimator/CAE_Elec_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 361, "1", "0", "RsTabControl", 0, "", 411, 12, 421, 1192, 0, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 361, "2", "1", "RsTabPage", 0, "", 0, 0, 395, 1184, 0, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 361, "3", "2", "RsLabel", 0, "", 45, 44, 25, 218, 1, "Control Panel Breakout tab UI properties", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 361, "4", "0", "RsGrid", 0, "", 12, 12, 393, 580, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,241,Control_Panels;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 361, "5", "4", "RsGridColumn", 0, "DisplayName", 0, 0, 0, 150, 0, "Display Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 361, "6", "0", "RsGroupBox", 0, "", 12, 743, 92, 457, 3, "EQS Import", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 361, "7", "6", "RsActionButton", 0, "", 43, 367, 27, 83, 4, "Import", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ImportEQSData;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 361, "8", "6", "RsFileImporter", 0, "", 19, 6, 51, 355, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;SpecName:EQS_File_Import")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Conveyer_Electrical_Installation()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(85, "Conveyer Electrical Installation", "", 102, 51, 1, 11, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Elec_Install_Estimator/CAE_Elec_Install_App.Conveyor_Costing_Elec/CAE_Conveyor_Installs_Elec.Conveyor_Costing_Electrical_Installation/CAE_Conveyor_Costing_Elec")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 394, "1", "0", "RsGroupBox", 0, "", 12, 479, 518, 1005, 0, "Inputs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 394, "2", "1", "RsLabel", 0, "", 208, 110, 21, 150, 1, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 394, "3", "0", "RsGroupBox", 0, "", 12, 12, 518, 461, 2, "Total Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 394, "4", "3", "RsLabel", 0, "", 208, 128, 21, 150, 3, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Conveyor_Electrical_Installation_IGS_Personnel()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(86, "Conveyor Electrical Installation IGS Personnel", "", 102, 51, 1, 12, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Elec_Install_Estimator/CAE_Elec_Install_App.Conveyor_Costing_Elec/CAE_Conveyor_Installs_Elec.Conveyor_Costing_Electrical_Installation_IGS_Perso/CAE_Conveyor_Costing_Elec")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 394, "1", "0", "RsGroupBox", 0, "", 12, 479, 518, 1005, 0, "Inputs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 394, "2", "1", "RsLabel", 0, "", 208, 110, 21, 150, 1, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 394, "3", "0", "RsGroupBox", 0, "", 12, 12, 518, 461, 2, "Total Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 394, "4", "3", "RsLabel", 0, "", 208, 128, 21, 150, 3, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Base_Options_Alternates_Elec_Delta()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(87, "Base_Options_Alternates Elec Delta", "", 102, 51, 1, 13, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Elec_Install_Estimator/CAE_Elec_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 361, "1", "0", "RsGroupBox", 0, "", 337, 559, 466, 541, 0, "Delta", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 361, "2", "1", "RsLabel", 0, "", 177, 147, 21, 150, 1, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 361, "3", "0", "RsGrid", 0, "", 12, 12, 319, 497, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,285,Base_Options_Alternates;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 361, "4", "3", "RsGridColumn", 0, "DATA_CPNumber", 0, 0, 0, 100, 0, "CP Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 361, "5", "0", "RsGroupBox", 0, "", 337, 12, 466, 541, 3, "Original", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 361, "6", "5", "RsLabel", 0, "", 177, 147, 21, 150, 4, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 361, "7", "0", "RsLabel", 0, "", 310, 700, 21, 95, 5, "Delta Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 361, "8", "0", "RsComboBox", 0, "", 309, 801, 22, 125, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Power_Feeds()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(89, "Power Feeds", "", 102, 51, 1, 14, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Elec_Install_Estimator/CAE_Elec_Install_App.PowerFeeds/CAE_Power_Feeds")
        oProcessStep.AddFilter(1, 0, "Elec Install", 1, "Amps", 1)
        oProcessStep.AddFilter(1, 0, "Elec Install", 1, "Distance", 2)
        oProcessStep.AddFilter(1, 0, "Elec Install", 1, "Selection_Single_Or_Parallel", 3)
        oProcessStep.AddLayout(1, 8, "0;PowerFeed_Control_Panel")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Shuttle_Elec()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(90, "Shuttle Elec", "", 102, 51, 1, 15, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Elec_Install_Estimator/CAE_Elec_Install_App.Shuttle_Elec/CAE_Shuttle_Elec")
        oProcessStep.AddLayout(1, 11, "")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_TTCB_Costing_Elec()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(93, "TTCB Costing Elec", "", 102, 51, 1, 16, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Elec_Install_Estimator/CAE_Elec_Install_App.TTCB_Costing_Elec/CAE_TTCB_Costing_Elec")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 402, "1", "0", "RsGroupBox", 0, "", 12, 479, 518, 1005, 0, "Inputs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 402, "2", "1", "RsLabel", 0, "", 208, 110, 21, 150, 1, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 402, "3", "0", "RsGroupBox", 0, "", 12, 12, 518, 461, 2, "Total Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 402, "4", "3", "RsLabel", 0, "", 208, 128, 21, 150, 3, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Output_Elec()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(88, "Output Elec", "", 102, 51, 1, 17, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Elec_Install_Estimator/CAE_Elec_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 361, "1", "0", "RsGroupBox", 0, "", 337, 559, 466, 541, 0, "PRD", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 361, "2", "1", "RsLabel", 0, "", 177, 147, 21, 150, 1, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 361, "3", "0", "RsGrid", 0, "", 12, 12, 319, 497, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,285,Base_Options_Alternates;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 361, "4", "0", "RsGroupBox", 0, "", 337, 12, 466, 541, 3, "Total Electrical Installation Sub Estimate", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 361, "5", "4", "RsLabel", 0, "", 177, 147, 21, 150, 4, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 361, "6", "0", "RsActionButton", 0, "", 12, 945, 82, 155, 5, "Sourcing Inputs", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_HCAD_Import()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(72, "HCAD Import", "", 101, 51, 1, 18, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsGrid", 0, "", 12, 12, 393, 580, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,252,Control_Panels;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 360, "2", "1", "RsGridColumn", 0, "DATA_CPNumber", 0, 0, 0, 150, 0, "CP Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "3", "1", "RsGridColumn", 0, "bool_Include_In_Subsystem", 0, 0, 0, 150, 0, "Include In System", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "4", "0", "RsAddDeleteCopy", 0, "", 411, 434, 22, 158, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,252,Control_Panels;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 360, "5", "0", "RsSubForm", 0, "", 439, 12, 484, 1192, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,252,Control_Panels")
        oProcessStep.AddCustomLayout(1, 360, "6", "5", "RsTabControl", 0, "", 3, 3, 481, 1189, 3, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "7", "6", "RsTabPage", 0, "", 0, 0, 455, 1181, 0, "Models", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "8", "7", "RsLabel", 0, "", 319, 3, 21, 131, 4, "Spiral Curve Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "9", "7", "RsGroupBox", 0, "", 3, 539, 49, 219, 5, "Misc", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "10", "9", "RsTextbox", 0, "HCAD_Misc_Hours", 15, 95, 22, 109, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "11", "9", "RsLabel", 0, "", 16, 6, 21, 83, 7, "Misc Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "12", "7", "RsTextbox", 0, "HCAD_ECCTrashBelt_Total_Units", 151, 392, 22, 109, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "13", "7", "RsTextbox", 0, "HCAD_IntelliFlow_Total_Footage", 234, 140, 22, 109, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "14", "7", "RsTextbox", 0, "HCAD_IntelliQAccuglide_Total_Footage", 10, 140, 22, 109, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "15", "7", "RsTextbox", 0, "HCAD_FlatBeltCurves_Total_Footage", 178, 140, 22, 109, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "16", "7", "RsTextbox", 0, "HCAD_IntelliFlow_Total_Units", 235, 392, 22, 109, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "17", "7", "RsLabel", 0, "", 151, 269, 21, 117, 13, "ECC Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "18", "7", "RsLabel", 0, "", 235, 269, 21, 117, 14, "Intelliflow Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "19", "7", "RsTextbox", 0, "HCAD_WheelDivert_Total_Footage", 374, 140, 22, 109, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "20", "7", "RsTextbox", 0, "HCAD_SpiralCurvessets_Total_Footage", 318, 140, 22, 109, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "21", "7", "RsTextbox", 0, "HCAD_Chutes_Total_Footage", 122, 140, 22, 109, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "22", "7", "RsLabel", 0, "", 375, 3, 21, 131, 18, "Wheel Sorter Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "23", "7", "RsTextbox", 0, "HCAD_ShoeSorter_Total_Footage", 290, 140, 22, 109, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "24", "7", "RsLabel", 0, "", 95, 3, 21, 131, 20, "Belt Staging Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "25", "7", "RsTextbox", 0, "HCAD_WheelDivert_Total_Units", 375, 392, 22, 109, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "26", "7", "RsTextbox", 0, "HCAD_SpiralCurvessets_Total_Units", 319, 392, 22, 109, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "27", "7", "RsLabel", 0, "", 291, 3, 21, 131, 23, "Shoe Sorter Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "28", "7", "RsLabel", 0, "", 123, 3, 21, 131, 24, "Chutes Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "29", "7", "RsLabel", 0, "", 375, 269, 21, 117, 25, "Wheel Sorter Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "30", "7", "RsLabel", 0, "", 319, 269, 21, 117, 26, "Spiral Curve Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "31", "7", "RsLabel", 0, "", 11, 269, 21, 117, 27, "Accuglide/IQZF Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "32", "7", "RsTextbox", 0, "HCAD_ShoeSorter_Total_Units", 291, 392, 22, 109, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "33", "7", "RsTextbox", 0, "HCAD_IntelliMerge_Total_Footage", 262, 140, 22, 109, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "34", "7", "RsLabel", 0, "", 291, 269, 21, 117, 30, "Shoe Sorter Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "35", "7", "RsLabel", 0, "", 179, 3, 21, 131, 31, "Flat Belt Curve Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "36", "7", "RsLabel", 0, "", 263, 3, 21, 131, 32, "Intellimerge Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "37", "7", "RsLabel", 0, "", 67, 3, 21, 131, 33, "Brake Belt/Meter Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "38", "7", "RsLabel", 0, "", 95, 269, 21, 117, 34, "Belt Staging Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "39", "7", "RsTextbox", 0, "HCAD_IntelliMerge_Total_Units", 263, 392, 22, 109, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "40", "7", "RsLabel", 0, "", 235, 3, 21, 131, 36, "Intelliflow Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "41", "7", "RsTextbox", 0, "HCAD_BeltonRoller_Total_Units", 39, 392, 22, 109, 37, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "42", "7", "RsLabel", 0, "", 263, 269, 21, 117, 38, "Intellimerge Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "43", "7", "RsTextbox", 0, "HCAD_IntelliQAccuglide_Total_Units", 11, 392, 22, 109, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "44", "7", "RsTextbox", 0, "HCAD_ECCTrashBelt_Total_Footage", 150, 140, 22, 109, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "45", "7", "RsTextbox", 0, "HCAD_FlatBeltCurves_Total_Units", 179, 392, 22, 109, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "46", "7", "RsTextbox", 0, "HCAD_VBelt_Total_Footage", 346, 140, 22, 109, 42, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "47", "7", "RsLabel", 0, "", 151, 3, 21, 131, 43, "ECC Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "48", "7", "RsLabel", 0, "", 11, 3, 21, 131, 44, "Accuglide/IQZF Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "49", "7", "RsLabel", 0, "", 179, 269, 21, 117, 45, "Flat Belt Curve Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "50", "7", "RsTextbox", 0, "HCAD_BeltStaging_Total_Footage", 94, 140, 22, 109, 46, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "51", "7", "RsTextbox", 0, "HCAD_Chutes_Total_Units", 123, 392, 22, 109, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "52", "7", "RsLabel", 0, "", 346, 36, 21, 97, 48, "V Belt Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "53", "7", "RsLabel", 0, "", 123, 269, 21, 117, 49, "Chutes Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "54", "7", "RsTextbox", 0, "HCAD_VBelt_Total_Units", 346, 392, 22, 109, 50, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "55", "7", "RsTextbox", 0, "HCAD_BeltBrakeMeter_Total_Footage", 66, 140, 22, 109, 51, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "56", "7", "RsLabel", 0, "", 346, 297, 21, 88, 52, "V Belt Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "57", "7", "RsTextbox", 0, "HCAD_BeltStaging_Total_Units", 95, 392, 22, 109, 53, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "58", "7", "RsTextbox", 0, "HCAD_BeltonRoller_Total_Footage", 38, 140, 22, 109, 54, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "59", "7", "RsTextbox", 0, "HCAD_BeltBrakeMeter_Total_Units", 67, 392, 22, 109, 55, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "60", "7", "RsLabel", 0, "", 39, 3, 21, 131, 56, "Belt Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "61", "7", "RsLabel", 0, "", 67, 269, 21, 117, 57, "Brake Belt/Meter Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "62", "7", "RsLabel", 0, "", 39, 269, 21, 117, 58, "Belt Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "63", "7", "RsTextbox", 0, "HCAD_Gravity_Total_Footage", 206, 140, 22, 109, 59, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "64", "7", "RsLabel", 0, "", 206, 36, 21, 97, 60, "Gravity Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "65", "7", "RsTextbox", 0, "HCAD_Gravity_Total_Units", 205, 392, 22, 109, 61, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "66", "7", "RsLabel", 0, "", 205, 297, 21, 88, 62, "Gravity Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "67", "7", "RsGroupBox", 0, "", 3, 764, 105, 414, 63, "MDR", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "68", "67", "RsTextbox", 0, "HCAD_MDR_Gates", 70, 291, 22, 109, 64, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "69", "67", "RsTextbox", 0, "HCAD_MDR_Total_Footage", 15, 95, 22, 109, 65, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "70", "67", "RsLabel", 0, "", 16, 6, 21, 83, 66, "MDR Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "71", "67", "RsTextbox", 0, "HCAD_MDR_Total_Units", 43, 95, 22, 109, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "72", "67", "RsTextbox", 0, "HCAD_MDR_Total_Hours", 71, 95, 22, 109, 68, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "73", "67", "RsLabel", 0, "", 43, 25, 21, 64, 69, "MDR Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "74", "67", "RsLabel", 0, "", 71, 25, 21, 64, 70, "MDR Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "75", "67", "RsTextbox", 0, "HCAD_MDR_Pneumatic_Transfers", 14, 291, 22, 109, 71, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "76", "67", "RsLabel", 0, "", 15, 220, 21, 65, 72, "Transfers", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "77", "67", "RsTextbox", 0, "HCAD_MDR_Pneumatic_Diverts", 42, 291, 22, 109, 73, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "78", "67", "RsLabel", 0, "", 70, 220, 21, 65, 74, "Gates", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "79", "67", "RsLabel", 0, "", 42, 220, 21, 65, 75, "Diverts", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "80", "0", "RsGroupBox", 0, "", 127, 727, 95, 477, 76, "HCAD Import", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "81", "80", "RsActionButton", 0, "", 43, 367, 27, 83, 77, "Import", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ImportHCADPricingSheetData;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 360, "82", "80", "RsFileImporter", 0, "", 19, 6, 51, 355, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;SpecName:HCAD_Import_File_Import")
        oProcessStep.AddCustomLayout(1, 360, "83", "0", "RsGroupBox", 0, "", 228, 727, 77, 477, 79, "Base/Option/Alternate Construction", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "84", "83", "RsLabel", 0, "", 31, 6, 21, 55, 80, "Name", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "85", "83", "RsTextbox", 0, "Base_Option_Alternate_Name", 30, 67, 22, 194, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "86", "83", "RsActionButton", 0, "", 25, 367, 27, 83, 82, "Build", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:bool_Unique_System_Name;FunctionToCall:MechBuildOption;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 360, "87", "0", "RsGroupBox", 0, "", 311, 963, 47, 241, 83, "Mech Install Properties", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "88", "87", "RsLabel", 0, "", 16, 6, 21, 101, 84, "Air Piping Factor", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "89", "87", "RsComboBox", 0, "AirPipingFactor", 15, 113, 22, 125, 85, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "90", "0", "RsGroupBox", 0, "", 12, 939, 109, 265, 86, "Customer Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "91", "90", "RsLabel", 0, "", 58, 6, 21, 107, 87, "Location", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "92", "90", "RsLabel", 0, "", 16, 6, 21, 107, 88, "Project Number", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "93", "90", "RsTextbox", 0, "CAE_Quote_Date", 78, 119, 22, 125, 89, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "94", "90", "RsTextbox", 0, "CAE_Customer_Location", 58, 119, 22, 125, 90, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "95", "90", "RsTextbox", 0, "CAE_Customer", 36, 119, 22, 125, 91, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "96", "90", "RsTextbox", 0, "CAE_Customer_Project_Number", 15, 119, 22, 125, 92, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "97", "90", "RsLabel", 0, "", 79, 6, 21, 107, 93, "Quote Date", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "98", "90", "RsLabel", 0, "", 37, 6, 21, 107, 94, "Customer", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Conveyor_Mechanical_Installation()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(80, "Conveyor Mechanical Installation", "", 101, 51, 1, 19, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsLabel", 0, "", 9, 12, 21, 67, 0, "Subsystem", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "2", "0", "RsSubForm", 0, "", 36, 807, 808, 789, 1, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,130,My_Conveyor_Intelligrated")
        oProcessStep.AddCustomLayout(1, 360, "3", "2", "RsGroupBox", 0, "", 3, 6, 805, 783, 2, "Intelligrated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "4", "3", "RsTextbox", 0, "DisplayName", 215, 258, 22, 125, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "5", "0", "RsComboBox", 0, "Selection_System", 8, 85, 22, 125, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "6", "0", "RsSubForm", 0, "", 36, 12, 808, 789, 5, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,129,My_Conveyor_Sub_Contractor")
        oProcessStep.AddCustomLayout(1, 360, "7", "6", "RsGroupBox", 0, "", 3, 3, 805, 783, 6, "Sub Contractor", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "8", "7", "RsTextbox", 0, "DisplayName", 215, 285, 22, 125, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Structures_Platforms()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(75, "Structures Platforms", "", 101, 51, 2, 20, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App.Structures_Platforms/CAE_Structures_Platforms")
        oProcessStep.AddFilter(2, 0, "Mech Install", 1, "BarGratingFootage", 4)
        oProcessStep.AddFilter(2, 0, "Mech Install", 1, "BarGratingHours", 3)
        oProcessStep.AddFilter(2, 0, "Mech Install", 1, "CatwalkHours", 7)
        oProcessStep.AddFilter(2, 0, "Mech Install", 1, "CatwalkLinearFeet", 8)
        oProcessStep.AddFilter(2, 0, "Mech Install", 1, "GridStructureFootage", 6)
        oProcessStep.AddFilter(2, 0, "Mech Install", 1, "GridStructureHours", 5)
        oProcessStep.AddFilter(2, 0, "Mech Install", 1, "LadderHours", 10)
        oProcessStep.AddFilter(2, 0, "Mech Install", 1, "ResindeckFootage", 2)
        oProcessStep.AddFilter(2, 0, "Mech Install", 1, "ResindeckHours", 1)
        oProcessStep.AddFilter(2, 0, "Mech Install", 1, "StairHours", 9)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddLayout(2, 8, "1;Control_Panels")
        oProcessStep.AddCustomLayout(1, 386, "1", "0", "RsGrid", 0, "", 0, 0, 352, 1512, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,272,Structure_Platform;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 386, "2", "1", "RsGridColumn", 0, "Structure_Platform_Name", 0, 0, 0, 100, 0, "Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 386, "3", "1", "RsGridColumn", 0, "Structure_Sq_Ft_Catwalk_Linear", 0, 0, 0, 100, 0, "Sq Ft/Linear", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 386, "4", "1", "RsGridColumn", 0, "Structure_Platform_Catwalk_Type", 0, 0, 0, 100, 0, "Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 386, "5", "1", "RsGridColumn", 0, "Subsystem", 0, 0, 0, 100, 0, "Control Panel", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 386, "6", "1", "RsGridColumn", 0, "Staircase_Large", 0, 0, 0, 100, 0, "Staircase Large", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 386, "7", "1", "RsGridColumn", 0, "Staircase_Medium", 0, 0, 0, 100, 0, "Staircase Medium", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 386, "8", "1", "RsGridColumn", 0, "Staircase_Small", 0, 0, 0, 100, 0, "Staircase Small", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 386, "9", "1", "RsGridColumn", 0, "Landing", 0, 0, 0, 100, 0, "Landing", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 386, "10", "1", "RsGridColumn", 0, "Ladder_Large", 0, 0, 0, 100, 0, "Ladder Large", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 386, "11", "1", "RsGridColumn", 0, "Ladder_Medium", 0, 0, 0, 100, 0, "Ladder Medium", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 386, "12", "1", "RsGridColumn", 0, "Ladder_Small", 0, 0, 0, 100, 0, "Ladder Small", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 386, "13", "1", "RsGridColumn", 0, "Hours_Stairs", 0, 0, 0, 100, 0, "Hours Stairs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 386, "14", "1", "RsGridColumn", 0, "Hours_Ladders", 0, 0, 0, 100, 0, "Hours Ladders", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 386, "15", "1", "RsGridColumn", 0, "Hours_Platform_Structure_Catwalk", 0, 0, 0, 180, 0, "Hours Platform, Structure, Catwalk", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 386, "16", "0", "RsAddDeleteCopy", 0, "", 358, 0, 22, 158, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,272,Structure_Platform;CanDelete:;AddPrompt:False;ShowCopy:True")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Air_Piping()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(82, "Air Piping", "", 101, 51, 1, 21, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsSubForm", 0, "", 31, 12, 291, 385, 0, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,132,My_Air_Piping")
        oProcessStep.AddCustomLayout(1, 360, "2", "1", "RsGroupBox", 0, "", 4, 3, 281, 376, 1, "Control Panel", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "3", "2", "RsLabel", 0, "", 177, 147, 21, 150, 2, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "4", "2", "RsTextbox", 0, "DisplayName", 95, 196, 22, 125, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "5", "2", "RsTextbox", 0, "MEI_AP_TotalHours", 123, 196, 22, 125, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "6", "0", "RsActionButton", 0, "", 97, 1287, 60, 114, 5, "Reset Delta", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:MechResetAirPipingDelta;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 360, "7", "0", "RsSubForm", 0, "", 31, 849, 291, 385, 6, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,133,My_Air_Piping_Delta")
        oProcessStep.AddCustomLayout(1, 360, "8", "7", "RsGroupBox", 0, "", 4, 3, 281, 376, 7, "Delta", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "9", "8", "RsLabel", 0, "", 177, 147, 21, 150, 8, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "10", "8", "RsTextbox", 0, "DisplayName", 95, 196, 22, 125, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "11", "8", "RsTextbox", 0, "MEI_AP_TotalHours", 123, 196, 22, 125, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "12", "0", "RsSubForm", 0, "", 31, 431, 291, 385, 11, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,134,My_Air_Piping_2")
        oProcessStep.AddCustomLayout(1, 360, "13", "12", "RsGroupBox", 0, "", 4, 3, 281, 376, 12, "Control Panel", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "14", "13", "RsLabel", 0, "", 177, 147, 21, 150, 13, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "15", "13", "RsTextbox", 0, "DisplayName", 95, 196, 22, 125, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "16", "13", "RsTextbox", 0, "MEI_AP_TotalHours", 123, 196, 22, 125, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "17", "0", "RsLabel", 0, "", 8, 490, 21, 124, 16, "Control Panel Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "18", "0", "RsComboBox", 0, "Selection_System_Delta", 7, 620, 22, 125, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "19", "0", "RsLabel", 0, "", 8, 83, 21, 122, 18, "Control Panel Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "20", "0", "RsComboBox", 0, "Selection_System", 7, 211, 22, 125, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "21", "0", "RsActionButton", 0, "", 31, 1287, 60, 114, 20, "Compare Delta", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:MechCompareAirPipingDelta;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Chutes()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(94, "Chutes", "", 101, 51, 1, 22, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsSubForm", 0, "", 29, 12, 574, 814, 0, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,135,My_Chute")
        oProcessStep.AddCustomLayout(1, 360, "2", "1", "RsGroupBox", 0, "", 4, 3, 567, 808, 1, "Subsystem", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "3", "2", "RsLabel", 0, "", 177, 147, 21, 150, 2, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "4", "2", "RsTextbox", 0, "DisplayName", 95, 196, 22, 125, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "5", "0", "RsLabel", 0, "", 6, 83, 21, 122, 4, "Subsystem Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "6", "0", "RsComboBox", 0, "Selection_System", 5, 211, 22, 125, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Shuttle_Mech()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(91, "Shuttle Mech", "", 101, 51, 1, 23, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App.Shuttle_Mech/CAE_Shuttle_Mech")
        oProcessStep.AddLayout(1, 11, "")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_TTCB_Costing_Mech()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(92, "TTCB Costing Mech", "", 101, 51, 1, 24, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App.TTCB_Costing_Mech/CAE_TTCB_Costing_Mech")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 401, "1", "0", "RsGroupBox", 0, "", 12, 479, 518, 1005, 0, "Inputs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "2", "1", "RsLabel", 0, "", 208, 110, 21, 150, 1, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "3", "0", "RsGroupBox", 0, "", 12, 12, 518, 461, 2, "Total Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "4", "3", "RsLabel", 0, "", 208, 128, 21, 150, 3, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Base_Options_Alternates_Mech_Delta()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(83, "Base_Options_Alternates Mech Delta", "", 101, 51, 1, 25, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsSubForm", 0, "", 38, 12, 291, 385, 0, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,119,My_Base_Options_Alternates")
        oProcessStep.AddCustomLayout(1, 360, "2", "1", "RsGroupBox", 0, "", 4, 3, 281, 376, 1, "Subsystem 1", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "3", "2", "RsLabel", 0, "", 177, 147, 21, 150, 2, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "4", "2", "RsTextbox", 0, "DisplayName", 95, 196, 22, 125, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "5", "2", "RsTextbox", 0, "HCAD_VBelt_Total_Units", 123, 196, 22, 125, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "6", "0", "RsActionButton", 0, "", 104, 1287, 60, 114, 5, "Reset Delta", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:MechResetDelta;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 360, "7", "0", "RsSubForm", 0, "", 38, 849, 291, 385, 6, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,120,My_Base_Options_Alternates_Delta")
        oProcessStep.AddCustomLayout(1, 360, "8", "7", "RsGroupBox", 0, "", 4, 3, 281, 376, 7, "Delta", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "9", "8", "RsLabel", 0, "", 177, 147, 21, 150, 8, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "10", "8", "RsTextbox", 0, "DisplayName", 95, 196, 22, 125, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "11", "8", "RsTextbox", 0, "HCAD_VBelt_Total_Units", 123, 196, 22, 125, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "12", "0", "RsSubForm", 0, "", 38, 431, 291, 385, 11, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,121,My_Base_Options_Alternates_2")
        oProcessStep.AddCustomLayout(1, 360, "13", "12", "RsGroupBox", 0, "", 4, 3, 281, 376, 12, "Subsystem 2", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "14", "13", "RsLabel", 0, "", 177, 147, 21, 150, 13, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "15", "13", "RsTextbox", 0, "DisplayName", 95, 196, 22, 125, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "16", "13", "RsTextbox", 0, "HCAD_VBelt_Total_Units", 123, 196, 22, 125, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "17", "0", "RsLabel", 0, "", 15, 490, 21, 124, 16, "Subsystem 2 Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "18", "0", "RsComboBox", 0, "Selection_System_Delta", 14, 620, 22, 125, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "19", "0", "RsLabel", 0, "", 15, 83, 21, 122, 18, "Subsystem 1 Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "20", "0", "RsComboBox", 0, "Selection_System", 14, 211, 22, 125, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "21", "0", "RsActionButton", 0, "", 38, 1287, 60, 114, 20, "Compare Delta", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:MechCompareDelta;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Output_Mech()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(84, "Output Mech", "", 101, 51, 1, 26, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsLabel", 0, "", 9, 12, 21, 57, 0, "System", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "2", "0", "RsActionButton", 0, "", 8, 1266, 82, 155, 1, "Sourcing Inputs", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 360, "3", "0", "RsComboBox", 0, "Selection_System", 8, 75, 22, 125, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "4", "0", "RsSubForm", 0, "", 36, 12, 855, 1248, 3, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,119,My_Base_Options_Alternates")
        oProcessStep.AddCustomLayout(1, 360, "5", "4", "RsGroupBox", 0, "", 3, 704, 466, 541, 4, "PRD", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "6", "5", "RsLabel", 0, "", 65, 128, 21, 150, 5, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "7", "4", "RsGroupBox", 0, "", 3, 3, 804, 680, 6, "Total Mechanical Installation Sub Estimate", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "8", "7", "RsGroupBox", 0, "", 19, 6, 109, 265, 7, "Customer Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "9", "8", "RsTextbox", 0, "CAE_Quote_Date", 78, 119, 22, 125, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "10", "8", "RsTextbox", 0, "CAE_Customer", 36, 119, 22, 125, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "11", "8", "RsTextbox", 0, "CAE_Customer_Location", 58, 119, 22, 125, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "12", "8", "RsTextbox", 0, "CAE_Customer_Project_Number", 15, 119, 22, 125, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "13", "8", "RsLabel", 0, "", 58, 6, 21, 107, 12, "Location", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "14", "8", "RsLabel", 0, "", 16, 6, 21, 107, 13, "Project Number", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "15", "8", "RsLabel", 0, "", 79, 6, 21, 107, 14, "Quote Date", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "16", "8", "RsLabel", 0, "", 37, 6, 21, 107, 15, "Customer", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "17", "7", "RsGroupBox", 0, "", 134, 6, 437, 668, 16, "Mechanical Install", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "18", "17", "RsLabel", 0, "", 407, 73, 21, 171, 17, "Mechanical Install Total", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "19", "17", "RsLabel", 0, "", 16, 547, 21, 72, 18, "Std. Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "20", "17", "RsTextbox", 0, "Rollup_Conv_Intelligrated_Installers_HRS", 126, 381, 22, 125, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "21", "17", "RsLabel", 0, "", 127, 73, 21, 171, 20, "Conv - Intelligrated Installers", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "22", "17", "RsTextbox", 0, "Rollup_Superintendent_HRS", 42, 381, 22, 125, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "23", "17", "RsTextbox", 0, "Rollup__Mech_Install_Total_HRS", 406, 381, 22, 125, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "24", "17", "RsTextbox", 0, "Rollup__Mech_Install_Total_COST", 406, 512, 22, 125, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "25", "17", "RsLabel", 0, "", 407, 6, 21, 72, 24, "16.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "26", "17", "RsTextbox", 0, "Rollup_Miscellanious_COST", 378, 512, 22, 125, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "27", "17", "RsTextbox", 0, "Rollup_Superintendent_COST", 42, 512, 22, 125, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "28", "17", "RsLabel", 0, "", 379, 73, 21, 171, 27, "Miscellanious", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "29", "17", "RsTextbox", 0, "Rollup_Conv_Intelligrated_Installers_UOM", 126, 250, 22, 125, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "30", "17", "RsLabel", 0, "", 379, 6, 21, 72, 29, "16.01.99", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "31", "17", "RsTextbox", 0, "Rollup_Intelligrated_Installer_HRS", 70, 381, 22, 125, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "32", "17", "RsTextbox", 0, "Rollup_Superintendent_UOM", 42, 250, 22, 125, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "33", "17", "RsTextbox", 0, "Rollup_Additional_Subcontractor_Services_COST", 350, 512, 22, 125, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "34", "17", "RsTextbox", 0, "Rollup_SuppliesConsumables_COST", 238, 512, 22, 125, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "35", "17", "RsTextbox", 0, "Rollup_Travel_Expenses_COST", 294, 512, 22, 125, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "36", "17", "RsTextbox", 0, "Rollup_Conv_Intelligrated_Installers_COST", 126, 512, 22, 125, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "37", "17", "RsLabel", 0, "", 16, 423, 21, 72, 36, "Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "38", "17", "RsTextbox", 0, "Rollup_TTCB_Intelligrated_Installers_COST", 182, 512, 22, 125, 37, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "39", "17", "RsTextbox", 0, "Rollup_Permits_COST", 322, 512, 22, 125, 38, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "40", "17", "RsTextbox", 0, "Rollup_Intelligrated_Installer_COST", 70, 512, 22, 125, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "41", "17", "RsTextbox", 0, "Rollup_Prototype_COST", 266, 512, 22, 125, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "42", "17", "RsTextbox", 0, "Rollup_Intelligrated_Installer_UOM", 70, 250, 22, 125, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "43", "17", "RsLabel", 0, "", 16, 292, 21, 72, 42, "$/UOM", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "44", "17", "RsTextbox", 0, "Rollup_TTCB_Intelligrated_Installers_UOM", 182, 250, 22, 125, 43, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "45", "17", "RsTextbox", 0, "Rollup_Equipment_Rental_COST", 210, 512, 22, 125, 44, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "46", "17", "RsTextbox", 0, "Rollup_TTCB_Lead_Men_COST", 154, 512, 22, 125, 45, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "47", "17", "RsTextbox", 0, "Rollup_Conv_Lead_Men_COST", 98, 512, 22, 125, 46, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "48", "17", "RsTextbox", 0, "Rollup_Conv_Lead_Men_UOM", 98, 250, 22, 125, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "49", "17", "RsLabel", 0, "", 71, 73, 21, 171, 48, "Intelligrated Installer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "50", "17", "RsTextbox", 0, "Rollup_Conv_Lead_Men_HRS", 98, 381, 22, 125, 49, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "51", "17", "RsLabel", 0, "", 71, 6, 21, 72, 50, "16.01.02", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "52", "17", "RsLabel", 0, "", 43, 73, 21, 171, 51, "Superintendent", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "53", "17", "RsTextbox", 0, "Rollup_TTCB_Intelligrated_Installers_HRS", 182, 381, 22, 125, 52, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "54", "17", "RsLabel", 0, "", 127, 6, 21, 72, 53, "16.01.02.02", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "55", "17", "RsLabel", 0, "", 99, 73, 21, 171, 54, "Conv - Lead Men", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "56", "17", "RsLabel", 0, "", 43, 6, 21, 72, 55, "16.01.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "57", "17", "RsLabel", 0, "", 351, 73, 21, 171, 56, "Additional Subcontractor Services", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "58", "17", "RsLabel", 0, "", 239, 73, 21, 171, 57, "Supplies/Consumables", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "59", "17", "RsTextbox", 0, "Rollup_TTCB_Lead_Men_HRS", 154, 381, 22, 125, 58, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "60", "17", "RsLabel", 0, "", 295, 73, 21, 171, 59, "Travel Expenses", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "61", "17", "RsLabel", 0, "", 183, 73, 21, 171, 60, "TT/CB - Intelligrated Installers", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "62", "17", "RsTextbox", 0, "Rollup_TTCB_Lead_Men_UOM", 154, 250, 22, 125, 61, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "63", "17", "RsLabel", 0, "", 323, 73, 21, 171, 62, "Permits", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "64", "17", "RsLabel", 0, "", 211, 73, 21, 171, 63, "Equipment Rental", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "65", "17", "RsLabel", 0, "", 99, 6, 21, 72, 64, "16.01.02.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "66", "17", "RsLabel", 0, "", 267, 73, 21, 171, 65, "Prototype", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "67", "17", "RsLabel", 0, "", 155, 73, 21, 171, 66, "TT/CB - Lead Men", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "68", "17", "RsLabel", 0, "", 351, 6, 21, 72, 67, "16.01.98", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "69", "17", "RsLabel", 0, "", 239, 6, 21, 72, 68, "16.01.05", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "70", "17", "RsLabel", 0, "", 295, 6, 21, 72, 69, "16.01.07", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "71", "17", "RsLabel", 0, "", 183, 6, 21, 72, 70, "16.01.02.04", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "72", "17", "RsLabel", 0, "", 323, 6, 21, 72, 71, "16.01.08", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "73", "17", "RsLabel", 0, "", 211, 6, 21, 72, 72, "16.01.04", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "74", "17", "RsLabel", 0, "", 267, 6, 21, 72, 73, "16.01.06", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "75", "17", "RsLabel", 0, "", 155, 6, 21, 72, 74, "16.01.02.03", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "76", "7", "RsGroupBox", 0, "", 577, 6, 224, 668, 75, "Additional Metrics", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "77", "76", "RsComboBox", 0, "Rollup__Work_Week_Type", 165, 370, 22, 125, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "78", "76", "RsTextbox", 0, "Rollup_Tariff_Adder_COST", 138, 109, 22, 125, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "79", "76", "RsLabel", 0, "", 111, 14, 21, 89, 78, "Tariff Adder (%)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "80", "76", "RsLabel", 0, "", 24, 406, 21, 72, 79, "Cost / Feet", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "81", "76", "RsTextbox", 0, "Rollup__Total_Conveyor_COST_per_Footage", 50, 371, 22, 125, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "82", "76", "RsTextbox", 0, "Rollup__Total_Conveyor_HRS_per_Footage", 50, 240, 22, 125, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "83", "76", "RsLabel", 0, "", 193, 14, 21, 89, 82, "Comm Weeks", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "84", "76", "RsLabel", 0, "", 138, 14, 21, 89, 83, "Tariff Cost ($)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "85", "76", "RsTextbox", 0, "Rollup__Weeks_Comm", 193, 109, 22, 125, 84, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "86", "76", "RsTextbox", 0, "Rollup__Work_Week_HRS_per_Week", 194, 370, 22, 125, 85, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "87", "76", "RsTextbox", 0, "Rollup__Weeks_Install", 165, 109, 22, 125, 86, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "88", "76", "RsTextbox", 0, "Rollup_Tariff_Adder_Pecentage_UI", 110, 109, 22, 125, 87, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "89", "76", "RsLabel", 0, "", 166, 14, 21, 89, 88, "Install Weeks", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "90", "76", "RsLabel", 0, "", 24, 151, 21, 72, 89, "Feet", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "91", "76", "RsLabel", 0, "", 194, 275, 21, 89, 90, "Hours / Week", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "92", "76", "RsLabel", 0, "", 138, 275, 21, 89, 91, "Labor Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "93", "76", "RsTextbox", 0, "Rollup__Total_Conveyor_Footage", 50, 109, 22, 125, 92, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "94", "76", "RsLabel", 0, "", 167, 275, 21, 89, 93, "Work Week", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "95", "76", "RsCheckbox", 0, "Rollup__Include_Stagnant_HRS", 110, 370, 18, 137, 94, "Include Stagnant HRS", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "96", "76", "RsComboBox", 0, "Rollup__Labor_Type", 137, 370, 22, 125, 95, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "97", "76", "RsLabel", 0, "", 24, 266, 21, 72, 96, "Hours / Feet", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "98", "76", "RsLabel", 0, "", 51, 14, 21, 89, 97, "Metrics", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Chutes_test()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(101, "Chutes_test", "", 101, 51, 1, 27, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App.Chutes/CAE_Chutes")
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_1_Angle_hrs", 1)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_1_Angle_of_Curve", 2)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_10_Angle_hrs", 3)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_10_Angle_of_Curve", 4)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_2_Angle_hrs", 5)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_2_Angle_of_Curve", 6)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_3_Angle_hrs", 7)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_3_Angle_of_Curve", 8)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_4_Angle_hrs", 9)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_4_Angle_of_Curve", 10)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_5_Angle_hrs", 11)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_5_Angle_of_Curve", 12)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_6_Angle_hrs", 13)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_6_Angle_of_Curve", 14)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_7_Angle_hrs", 15)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_7_Angle_of_Curve", 16)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_8_Angle_hrs", 17)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_8_Angle_of_Curve", 18)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_9_Angle_hrs", 19)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_9_Angle_of_Curve", 20)
        oProcessStep.AddLayout(1, 1, "1;2;0")
        
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
          
        InitSubpart("Project_Information", 189, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "6/23/2025 1:12:18 PM", "", "In Development", "N",0,524,523)
        
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
      Public Function Process_DefaultProcess_Opportunity_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:66; TYPE:ST
      result = STATUS_ENABLED
      '   END FORMULA; PROC ID:66; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Opportunity_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Opportunity_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:66; TYPE:CO
      result = ""
      '   END FORMULA; PROC ID:66; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Opportunity_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Salesforce_Instructions_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:69; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:69; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Salesforce_Instructions_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Salesforce_Instructions_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:69; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:69; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Salesforce_Instructions_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Salesforce_PRD_Import_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:70; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Opportunity_Data_Source_Type = "Salesforce PRD" Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:70; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Salesforce_PRD_Import_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Salesforce_PRD_Import_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:70; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:70; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Salesforce_PRD_Import_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Tools_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:71; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:71; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Tools_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Tools_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:71; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:71; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Tools_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Setup_And_Global_MTBF_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:103; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:103; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Setup_And_Global_MTBF_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Setup_And_Global_MTBF_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:103; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:103; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Setup_And_Global_MTBF_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Sortation_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:105; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:105; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Sortation_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Sortation_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:105; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:105; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Sortation_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Scanner_Configurations_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:104; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:104; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Scanner_Configurations_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Scanner_Configurations_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:104; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:104; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Scanner_Configurations_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Print_And_Apply_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:79; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasAppCalc Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:79; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Print_And_Apply_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Print_And_Apply_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:79; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:79; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Print_And_Apply_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Header_Hanger_Import_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:78; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasHeaderHanger Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:78; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Header_Hanger_Import_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Header_Hanger_Import_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:78; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:78; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Header_Hanger_Import_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_EQS_Import_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:76; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasElecInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:76; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_EQS_Import_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_EQS_Import_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:76; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:76; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_EQS_Import_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Conveyer_Electrical_Installation_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:85; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasElecInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:85; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Conveyer_Electrical_Installation_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Conveyer_Electrical_Installation_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:85; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:85; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Conveyer_Electrical_Installation_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Conveyor_Electrical_Installation_IGS_Personnel_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:86; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasElecInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:86; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Conveyor_Electrical_Installation_IGS_Personnel_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Conveyor_Electrical_Installation_IGS_Personnel_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:86; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:86; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Conveyor_Electrical_Installation_IGS_Personnel_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Base_Options_Alternates_Elec_Delta_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:87; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasElecInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:87; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Base_Options_Alternates_Elec_Delta_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Base_Options_Alternates_Elec_Delta_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:87; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:87; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Base_Options_Alternates_Elec_Delta_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Power_Feeds_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:89; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasElecInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:89; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Power_Feeds_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Power_Feeds_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:89; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:89; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Power_Feeds_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Shuttle_Elec_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:90; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasElecInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:90; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Shuttle_Elec_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Shuttle_Elec_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:90; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:90; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Shuttle_Elec_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_TTCB_Costing_Elec_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:93; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasElecInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:93; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_TTCB_Costing_Elec_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_TTCB_Costing_Elec_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:93; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:93; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_TTCB_Costing_Elec_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Output_Elec_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:88; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasElecInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:88; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Output_Elec_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Output_Elec_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:88; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:88; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Output_Elec_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_HCAD_Import_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:72; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasMechInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:72; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_HCAD_Import_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_HCAD_Import_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:72; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:72; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_HCAD_Import_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Conveyor_Mechanical_Installation_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:80; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasMechInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:80; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Conveyor_Mechanical_Installation_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Conveyor_Mechanical_Installation_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:80; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:80; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Conveyor_Mechanical_Installation_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Structures_Platforms_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:75; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasMechInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:75; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Structures_Platforms_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Structures_Platforms_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:75; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:75; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Structures_Platforms_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Air_Piping_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:82; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasMechInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:82; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Air_Piping_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Air_Piping_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:82; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:82; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Air_Piping_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Chutes_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:94; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasMechInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:94; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Chutes_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Chutes_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:94; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:94; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Chutes_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Shuttle_Mech_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:91; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasMechInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:91; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Shuttle_Mech_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Shuttle_Mech_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:91; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:91; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Shuttle_Mech_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_TTCB_Costing_Mech_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:92; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasMechInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:92; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_TTCB_Costing_Mech_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_TTCB_Costing_Mech_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:92; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:92; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_TTCB_Costing_Mech_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Base_Options_Alternates_Mech_Delta_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:83; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasMechInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:83; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Base_Options_Alternates_Mech_Delta_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Base_Options_Alternates_Mech_Delta_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:83; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:83; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Base_Options_Alternates_Mech_Delta_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Output_Mech_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:84; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasMechInstall Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:84; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Output_Mech_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Output_Mech_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:84; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:84; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Output_Mech_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Chutes_test_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:101; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:101; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Chutes_test_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Chutes_test_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:101; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:101; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Chutes_test_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Information_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:189; TYPE:PN
      
      '   END FORMULA; SUB ID:189; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Formula_Project_Information_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Information_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Project_Information").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:189; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:189; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Formula_Project_Information_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Information_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Project_Information").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:189; TYPE:OP
      result = "IGS_Opportunity"
      '   END FORMULA; SUB ID:189; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Formula_Project_Information_OPTIMALPARTFAMILY", ex.Message)
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
      AddHandler ObjectManager.RsEngineer.RsAfterSave, AddressOf g_rsEngineer_RsAfterSave
      AddHandler ObjectManager.RsEngineer.RsAfterRelease, AddressOf g_rsEngineer_RsAfterRelease
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Overrides Sub RemoveRsEventHandlerMappings()
    
      RemoveHandler ObjectManager.RsEngineer.RsActionButtonClick, AddressOf g_rsEngineer_RsActionButtonClick
      RemoveHandler ObjectManager.RsEngineer.RsAfterSave, AddressOf g_rsEngineer_RsAfterSave
      RemoveHandler ObjectManager.RsEngineer.RsAfterRelease, AddressOf g_rsEngineer_RsAfterRelease
    End Sub
    #End Region

    End Class

  