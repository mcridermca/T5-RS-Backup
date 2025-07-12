Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: IGS_Project_Top_App
'$ GenerateDate: 07/07/2025 19:41:21

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
        
        Case "79"
        Result = Process_DefaultProcess_App_Calc_COMMENT()
        
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
        Result = Process_DefaultProcess_Conveyor_Subcontractor_Mechanical_Installation_COMMENT()
        
        Case "81"
        Result = Process_DefaultProcess_Conveyor_Intelligrated_Support_Mechanical_Installa_COMMENT()
        
        Case "75"
        Result = Process_DefaultProcess_Structures_Platforms_COMMENT()
        
        Case "82"
        Result = Process_DefaultProcess_Air_Piping_COMMENT()
        
        Case "91"
        Result = Process_DefaultProcess_Shuttle_Mech_COMMENT()
        
        Case "92"
        Result = Process_DefaultProcess_TTCB_Costing_Mech_COMMENT()
        
        Case "83"
        Result = Process_DefaultProcess_Base_Options_Alternates_Mech_Delta_COMMENT()
        
        Case "84"
        Result = Process_DefaultProcess_Output_Mech_COMMENT()
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
        
        Case "79"
        Result = Process_DefaultProcess_App_Calc_STATUS()
        
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
        Result = Process_DefaultProcess_Conveyor_Subcontractor_Mechanical_Installation_STATUS()
        
        Case "81"
        Result = Process_DefaultProcess_Conveyor_Intelligrated_Support_Mechanical_Installa_STATUS()
        
        Case "75"
        Result = Process_DefaultProcess_Structures_Platforms_STATUS()
        
        Case "82"
        Result = Process_DefaultProcess_Air_Piping_STATUS()
        
        Case "91"
        Result = Process_DefaultProcess_Shuttle_Mech_STATUS()
        
        Case "92"
        Result = Process_DefaultProcess_TTCB_Costing_Mech_STATUS()
        
        Case "83"
        Result = Process_DefaultProcess_Base_Options_Alternates_Mech_Delta_STATUS()
        
        Case "84"
        Result = Process_DefaultProcess_Output_Mech_STATUS()
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
    InitPart("IGS_Project_Top_App", <a><![CDATA[IGS_Project_Top_App]]></a>.Value, 376, "IGSEST",  "", "", True, True, "In Development", "", "", "", "", "",  "GLOBAL\H602502", "07/07/2025 19:17:57")
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
        Initialize_Process_DefaultProcess_App_Calc()
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
        Initialize_Process_DefaultProcess_Conveyor_Subcontractor_Mechanical_Installation()
        Initialize_Process_DefaultProcess_Conveyor_Intelligrated_Support_Mechanical_Installa()
        Initialize_Process_DefaultProcess_Structures_Platforms()
        Initialize_Process_DefaultProcess_Air_Piping()
        Initialize_Process_DefaultProcess_Shuttle_Mech()
        Initialize_Process_DefaultProcess_TTCB_Costing_Mech()
        Initialize_Process_DefaultProcess_Base_Options_Alternates_Mech_Delta()
        Initialize_Process_DefaultProcess_Output_Mech()
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
        Private Sub Initialize_Process_DefaultProcess_App_Calc()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(79, "App Calc", "", 106, 51, 1, 5, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr")
        oProcessStep.AddLayout(1, 1, "1;2;0")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Header_Hanger_Import()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(78, "Header Hanger Import", "", 105, 51, 1, 6, 50, 50)
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
        oProcessStep = AddProcessStep(76, "EQS Import", "", 102, 51, 1, 7, 50, 50)
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
        oProcessStep = AddProcessStep(85, "Conveyer Electrical Installation", "", 102, 51, 1, 8, 50, 50)
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
        oProcessStep = AddProcessStep(86, "Conveyor Electrical Installation IGS Personnel", "", 102, 51, 1, 9, 50, 50)
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
        oProcessStep = AddProcessStep(87, "Base_Options_Alternates Elec Delta", "", 102, 51, 1, 10, 50, 50)
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
        oProcessStep = AddProcessStep(89, "Power Feeds", "", 102, 51, 1, 11, 50, 50)
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
        oProcessStep = AddProcessStep(90, "Shuttle Elec", "", 102, 51, 1, 12, 50, 50)
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
        oProcessStep = AddProcessStep(93, "TTCB Costing Elec", "", 102, 51, 1, 13, 50, 50)
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
        oProcessStep = AddProcessStep(88, "Output Elec", "", 102, 51, 1, 14, 50, 50)
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
        oProcessStep = AddProcessStep(72, "HCAD Import", "", 101, 51, 1, 15, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsGrid", 0, "", 12, 12, 393, 580, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,252,Control_Panels;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 360, "2", "1", "RsGridColumn", 0, "DATA_CPNumber", 0, 0, 0, 150, 0, "CP Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "3", "1", "RsGridColumn", 0, "bool_Include_In_Subsystem", 0, 0, 0, 150, 0, "Include In System", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "4", "0", "RsAddDeleteCopy", 0, "", 411, 434, 22, 158, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,252,Control_Panels;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 360, "5", "0", "RsSubForm", 0, "", 439, 12, 484, 1192, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,252,Control_Panels")
        oProcessStep.AddCustomLayout(1, 360, "6", "5", "RsTabControl", 0, "", 3, 3, 481, 1189, 3, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "7", "6", "RsTabPage", 0, "", 0, 0, 0, 0, 0, "Models", 0, 0, 0, 5, 0, "", "", "")
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
        oProcessStep.AddCustomLayout(1, 360, "80", "0", "RsGroupBox", 0, "", 12, 727, 95, 477, 76, "HCAD Import", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "81", "80", "RsActionButton", 0, "", 43, 367, 27, 83, 77, "Import", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ImportHCADPricingSheetData;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 360, "82", "80", "RsFileImporter", 0, "", 19, 6, 51, 355, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;SpecName:HCAD_Import_File_Import")
        oProcessStep.AddCustomLayout(1, 360, "83", "0", "RsGroupBox", 0, "", 148, 727, 77, 477, 79, "Base/Option/Alternate Construction", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "84", "83", "RsLabel", 0, "", 31, 6, 21, 55, 80, "Name", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "85", "83", "RsTextbox", 0, "Base_Option_Alternate_Name", 30, 67, 22, 194, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "86", "83", "RsActionButton", 0, "", 25, 367, 27, 83, 82, "Build", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:bool_Unique_System_Name;FunctionToCall:MechBuildOption;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Conveyor_Subcontractor_Mechanical_Installation()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(80, "Conveyor Subcontractor Mechanical Installation", "", 101, 51, 1, 16, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App.Conveyor_Costing/CAE_Conveyor_Installs.Conveyor_Costing_SC_Mech_Install/CAE_Conveyor_Costing")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 389, "1", "0", "RsGroupBox", 0, "", 12, 12, 518, 461, 0, "Total Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 389, "2", "1", "RsLabel", 0, "", 208, 128, 21, 150, 1, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 389, "3", "0", "RsGroupBox", 0, "", 536, 12, 274, 461, 2, "Metrics", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 389, "4", "3", "RsLabel", 0, "", 126, 115, 21, 150, 3, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 389, "5", "0", "RsGroupBox", 0, "", 12, 479, 798, 1005, 4, "Inputs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 389, "6", "5", "RsLabel", 0, "", 208, 110, 21, 150, 5, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Conveyor_Intelligrated_Support_Mechanical_Installa()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(81, "Conveyor Intelligrated Support Mechanical Installa", "", 101, 51, 1, 17, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App.Conveyor_Costing/CAE_Conveyor_Installs.Conveyor_Costing_SC_Mech_Install/CAE_Conveyor_Costing")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 389, "1", "0", "RsGroupBox", 0, "", 12, 479, 518, 1005, 0, "Inputs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 389, "2", "1", "RsLabel", 0, "", 208, 110, 21, 150, 1, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 389, "3", "0", "RsGroupBox", 0, "", 12, 12, 518, 461, 2, "Total Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 389, "4", "3", "RsLabel", 0, "", 208, 128, 21, 150, 3, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Structures_Platforms()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(75, "Structures Platforms", "", 101, 51, 2, 18, 50, 50)
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
        oProcessStep = AddProcessStep(82, "Air Piping", "", 101, 51, 1, 19, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App.AirPiping/CAE_Air_Piping")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 391, "1", "0", "RsSubForm", 0, "", 431, 691, 376, 557, 0, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,281,Control_Panel_Air_Piping_Delta")
        oProcessStep.AddCustomLayout(1, 391, "2", "1", "RsGroupBox", 0, "", 16, 17, 316, 518, 1, "Delta", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 391, "3", "2", "RsLabel", 0, "", 131, 186, 36, 177, 2, "Air Piping delta selected from combobox", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 391, "4", "0", "RsGrid", 0, "", 28, 50, 319, 497, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,280,Control_Panel_Air_Piping;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 391, "5", "4", "RsGridColumn", 0, "CP_Name", 0, 0, 0, 100, 0, "CP Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 391, "6", "0", "RsSubForm", 0, "", 12, 691, 376, 557, 4, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,280,Control_Panel_Air_Piping")
        oProcessStep.AddCustomLayout(1, 391, "7", "6", "RsGroupBox", 0, "", 16, 17, 316, 518, 5, "Original", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 391, "8", "7", "RsLabel", 0, "", 131, 213, 21, 150, 6, "Air Piping selected from grid", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 391, "9", "0", "RsComboBox", 0, "Delta_Selection", 447, 487, 22, 164, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 391, "10", "0", "RsLabel", 0, "", 447, 367, 22, 114, 8, "Delta Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Shuttle_Mech()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(91, "Shuttle Mech", "", 101, 51, 1, 20, 50, 50)
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
        oProcessStep = AddProcessStep(92, "TTCB Costing Mech", "", 101, 51, 1, 21, 50, 50)
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
        oProcessStep = AddProcessStep(83, "Base_Options_Alternates Mech Delta", "", 101, 51, 1, 22, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsSubForm", 0, "", 38, 12, 291, 385, 0, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,119,My_Base_Options_Alternates")
        oProcessStep.AddCustomLayout(1, 360, "2", "1", "RsGroupBox", 0, "", 4, 3, 281, 376, 1, "System 1", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
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
        oProcessStep.AddCustomLayout(1, 360, "13", "12", "RsGroupBox", 0, "", 4, 3, 281, 376, 12, "System 2", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "14", "13", "RsLabel", 0, "", 177, 147, 21, 150, 13, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "15", "13", "RsTextbox", 0, "DisplayName", 95, 196, 22, 125, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "16", "13", "RsTextbox", 0, "HCAD_VBelt_Total_Units", 123, 196, 22, 125, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "17", "0", "RsLabel", 0, "", 15, 490, 21, 124, 16, "System 2 Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "18", "0", "RsComboBox", 0, "Selection_System_Delta", 14, 620, 22, 125, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "19", "0", "RsLabel", 0, "", 15, 83, 21, 122, 18, "System 1 Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
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
        oProcessStep = AddProcessStep(84, "Output Mech", "", 101, 51, 1, 23, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsLabel", 0, "", 9, 12, 21, 57, 0, "System", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "2", "0", "RsActionButton", 0, "", 9, 1211, 82, 155, 1, "Sourcing Inputs", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 360, "3", "0", "RsComboBox", 0, "Selection_System", 8, 75, 22, 125, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "4", "0", "RsSubForm", 0, "", 36, 12, 479, 1099, 3, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,119,My_Base_Options_Alternates")
        oProcessStep.AddCustomLayout(1, 360, "5", "4", "RsGroupBox", 0, "", 3, 550, 466, 541, 4, "PRD", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "6", "5", "RsLabel", 0, "", 177, 147, 21, 150, 5, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "7", "4", "RsGroupBox", 0, "", 3, 3, 466, 541, 6, "Total Mechanical Installation Sub Estimate", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "8", "7", "RsLabel", 0, "", 177, 147, 21, 150, 7, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
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
      Public Function Process_DefaultProcess_App_Calc_STATUS() as Integer 'Long
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
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_App_Calc_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_App_Calc_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:79; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:79; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_App_Calc_COMMENT", ex.Message)
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
      Public Function Process_DefaultProcess_Conveyor_Subcontractor_Mechanical_Installation_STATUS() as Integer 'Long
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
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Conveyor_Subcontractor_Mechanical_Installation_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Conveyor_Subcontractor_Mechanical_Installation_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:80; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:80; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Conveyor_Subcontractor_Mechanical_Installation_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Conveyor_Intelligrated_Support_Mechanical_Installa_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:81; TYPE:ST
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
      '   END FORMULA; PROC ID:81; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Conveyor_Intelligrated_Support_Mechanical_Installa_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Conveyor_Intelligrated_Support_Mechanical_Installa_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:81; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:81; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Conveyor_Intelligrated_Support_Mechanical_Installa_COMMENT", ex.Message)
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

  