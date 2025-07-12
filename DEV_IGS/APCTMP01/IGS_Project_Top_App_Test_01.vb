Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: IGS_Project_Top_App_Test_01
'$ GenerateDate: 07/12/2025 14:40:53

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
    Imports APCTMP01.swMateType_e
    Imports APCTMP01.swMateAlign_e
    Imports APCTMP01.severity

    Public Class [IGS_Project_Top_App_Test_01]
    
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

    Private this as IGS_Project_Top_App_Test_01 = me

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
      Case "33"
      Select Case processStep
        Case "38"
        Result = Process_DefaultProcess_Instructions_COMMENT()
        
        Case "41"
        Result = Process_DefaultProcess_Salesforce_PRD_Import_COMMENT()
        
        Case "63"
        Result = Process_DefaultProcess_Salesforce_Proprosal__PRD__Information_COMMENT()
        
        Case "64"
        Result = Process_DefaultProcess_App_Calculations_COMMENT()
        
        Case "43"
        Result = Process_DefaultProcess_Freight_Estimation_Products_and_Weights_COMMENT()
        End Select
        End Select
      
    Return Result
    End Function

    Public Function GetProcessStepStatus(ByVal processId As String, ByVal processStep As String) As Integer Implements RuleStream.IRsPartFormulas.GetProcessStepStatus
    Dim Result as Integer 'Long
    Select Case processId
      Case "33"
      Select Case processStep
        Case "38"
        Result = Process_DefaultProcess_Instructions_STATUS()
        
        Case "41"
        Result = Process_DefaultProcess_Salesforce_PRD_Import_STATUS()
        
        Case "63"
        Result = Process_DefaultProcess_Salesforce_Proprosal__PRD__Information_STATUS()
        
        Case "64"
        Result = Process_DefaultProcess_App_Calculations_STATUS()
        
        Case "43"
        Result = Process_DefaultProcess_Freight_Estimation_Products_and_Weights_STATUS()
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
    
      Public ReadOnly Property [GEN_Connection_Paths]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("GEN_Connection_Paths")
      End Get
      End Property
    
      Public ReadOnly Property [Project]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Project")
      End Get
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
    InitPart("IGS_Project_Top_App_Test_01", <a><![CDATA[IGS_Project_Top_App_Test_01]]></a>.Value, 285, "APCTMP01",  "", "", True, True, "In Development", "", "App Calc Top Part", "", "", "",  "GLOBAL\H602502", "06/23/2025 19:09:06")
    AddProperty("1275", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:17 AM")
    
      oSubpart = AddSubpart(174,"GEN_Connection_Paths", <a><![CDATA[GEN_Connection_Paths]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/28/2025 11:59:54 AM")
      
        oSubpart.AddVPF (308, "GEN_Connection_Path_List", "GEN_Connection_Path_List")
      
      oSubpart = AddSubpart(152,"Project", <a><![CDATA[Project]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:21 AM")
      
        oSubpart.AddVPF (286, "IGS_Project_Header", "IGS_Project_Header")
      
      oSubpart = AddSubpart(151,"Project_Information", <a><![CDATA[Project_Information]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/28/2025 4:16:22 AM")
      
        oSubpart.AddVPF (302, "IGS_Opportunity_Data", "IGS_Opportunity_Data")
      
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Sub Initialize_Process(ByVal lngProcessID as Integer) Implements RuleStream.IRsPartFormulas.InitializeProcess
    Select Case lngProcessID
    
      Case 33
      Process = "DefaultProcess"	
        Initialize_Process_DefaultProcess_Instructions()
        Initialize_Process_DefaultProcess_Salesforce_PRD_Import()
        Initialize_Process_DefaultProcess_Salesforce_Proprosal__PRD__Information()
        Initialize_Process_DefaultProcess_App_Calculations()
        Initialize_Process_DefaultProcess_Freight_Estimation_Products_and_Weights()
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
        Private Sub Initialize_Process_DefaultProcess_Instructions()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(38, "Instructions", "This process step was created automatically by RuleStream.", 1, 33, 1, 1, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App_Test_01.Project_Information/IGS_Opportunity_Data")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 302, "1", "0", "RsLabel", 0, "", 9, 12, 34, 354, 0, "IGS Integrated Applications Example", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 302, "2", "0", "RsLabel", 0, "", 101, 34, 73, 354, 1, "TBA ..... Instructions to be updated to reflect business process and data sources", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.11;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 302, "3", "0", "RsLabel", 0, "", 184, 34, 27, 408, 2, "Select Opportunity Data Source To Continue", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 302, "4", "0", "RsLabel", 0, "", 59, 34, 27, 354, 3, "Instructions", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.14;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 302, "5", "0", "RsGroupBox", 0, "", 214, 34, 212, 436, 4, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 302, "6", "5", "RsRadioButton", 0, "Opportunity_Data_Source_Type", 23, 20, 18, 72, 5, "Manual", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 302, "7", "5", "RsLabel", 0, "", 86, 38, 21, 370, 6, "- Copy and Paste Products &amp;amp; Weights from Salesforce PRD Document", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 302, "8", "5", "RsRadioButton", 0, "Opportunity_Data_Source_Type", 65, 20, 18, 116, 7, "Salesforce PRD", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 302, "9", "5", "RsLabel", 0, "", 41, 38, 21, 230, 8, "- Manually Enter Product Details and Weights", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 302, "10", "5", "RsLabel", 0, "", 131, 38, 21, 370, 9, "- TBA (Not Available / Coming Soon)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 302, "11", "5", "RsLabel", 0, "", 176, 38, 21, 370, 10, "- TBA (Not Available / Coming Soon)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 302, "12", "5", "RsLabel", 0, "", 65, 138, 21, 130, 11, "(Copy/Paste Method)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 302, "13", "5", "RsRadioButton", 0, "Opportunity_Data_Source_Type", 155, 20, 18, 293, 12, "CORA Project        (Direct Import  By Project #)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 302, "14", "5", "RsRadioButton", 0, "Opportunity_Data_Source_Type", 110, 20, 18, 294, 13, "Salesforce PRD     (Direct Import  By Project #)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Salesforce_PRD_Import()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(41, "Salesforce PRD Import", "Import PRD Document from Salesforce", 1, 33, 1, 2, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App_Test_01.Project_Information/IGS_Opportunity_Data.Salesforce_Opportunity/SFD_Salesforce_Data_Mock.PRD_Document/SFD_Salesforce_PRD_Header_Mock")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 163, "1", "0", "RsTextbox", 0, "PRD_Input_Text_Tab_Formatted", 140, 12, 630, 577, 0, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "2", "0", "RsTextbox", 0, "PRD_TOTAL_DEBUG", 140, 595, 304, 677, 1, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "3", "0", "RsLabel", 0, "", 9, 595, 35, 342, 2, "PRD Item Import", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.20;Font_Style:1.;ForeColor:ActiveCaption;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "4", "0", "RsLabel", 0, "", 9, 12, 35, 520, 3, "Salesforce PRD Product Import", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.20;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "5", "0", "RsLabel", 0, "", 44, 595, 29, 520, 4, "Step 2: Review &amp;amp; Import PRD Products Into Freight Calc", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.14;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "6", "0", "RsLabel", 0, "", 73, 34, 40, 520, 5, "(Please Note, you may have to paste and copy from MS Excel to capture HTML Formatting Properly)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "7", "0", "RsLabel", 0, "", 44, 12, 29, 520, 6, "Step 1: Copy &amp;amp; Paste PRD Information Below", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.14;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "8", "0", "RsActionButton", 0, "", 450, 1102, 50, 170, 7, "Import Items", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:FRT_Import_Items;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Salesforce_Proprosal__PRD__Information()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(63, "Salesforce Proprosal  PRD  Information", "PRD Information", 1, 33, 1, 3, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App_Test_01.Project_Information/IGS_Opportunity_Data.Salesforce_Opportunity/SFD_Salesforce_Data_Mock.PRD_Document/SFD_Salesforce_PRD_Header_Mock")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 163, "1", "0", "RsLabel", 0, "", 23, 29, 30, 184, 0, "Salesforce PRD", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "2", "0", "RsGroupBox", 0, "", 99, 33, 96, 646, 1, "Proposal Header Information", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 163, "3", "2", "RsTextbox", 0, "Proposal_Name", 49, 274, 20, 354, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "4", "2", "RsTextbox", 0, "Proposal_ID", 49, 78, 20, 138, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "5", "2", "RsTextbox", 0, "Proposal_City_State", 26, 400, 20, 228, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "6", "2", "RsLabel", 0, "", 26, 338, 20, 56, 5, "City State:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "7", "2", "RsLabel", 0, "", 49, 2, 20, 70, 6, "Proposal #:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "8", "2", "RsLabel", 0, "", 49, 210, 20, 58, 7, "Summary:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "9", "2", "RsLabel", 0, "", 26, 10, 20, 62, 8, "Customer:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "10", "2", "RsTextbox", 0, "Proposal_Customer_Name", 26, 78, 20, 254, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_App_Calculations()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(64, "App Calculations", "App Calcs", 1, 33, 1, 4, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App_Test_01.Project/IGS_Project_Header.Project_Tool_Manager/IGS_Tool_Instance_Mgr")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 288, "1", "0", "RsLabel", 0, "", 9, 12, 31, 280, 0, "Proposal Tools - App Calc", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "2", "0", "RsGrid", 0, "", 43, 29, 140, 809, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,156,AppCalc_Instances;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 288, "3", "2", "RsGridColumn", 0, "App_Calc_Name", 0, 0, 0, 500, 0, "App_Calc_Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 288, "4", "0", "RsAddDeleteCopy", 0, "", 189, 584, 32, 224, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,156,AppCalc_Instances;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 288, "5", "0", "RsSubForm", 0, "", 227, 12, 1200, 826, 3, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,156,AppCalc_Instances")
        oProcessStep.AddCustomLayout(1, 288, "6", "5", "RsTabControl", 0, "", 3, 17, 1118, 783, 4, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 288, "7", "6", "RsTabPage", 0, "", 0, 0, 1092, 775, 0, "Setup", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 288, "8", "7", "RsSubForm", 0, "", 43, 8, 1028, 758, 5, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,33,Setup")
        oProcessStep.AddCustomLayout(1, 288, "9", "8", "RsGroupBox", 0, "", 12, 3, 130, 744, 6, "Site / Customer Information", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 288, "10", "9", "RsTextbox", 0, "Customer_Name", 32, 127, 26, 528, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 288, "11", "9", "RsTextbox", 0, "Customer_Location_CityState", 64, 127, 26, 528, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 288, "12", "9", "RsTextbox", 0, "Proposal_No", 92, 127, 26, 264, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 288, "13", "9", "RsLabel", 0, "", 92, 393, 30, 58, 10, "Date:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "14", "9", "RsSingleDatePicker", 0, "Proposal_Date", 92, 457, 20, 198, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 288, "15", "9", "RsLabel", 0, "", 92, 35, 30, 86, 12, "Proposal #:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "16", "9", "RsLabel", 0, "", 64, 6, 30, 115, 13, "Location (City, St):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "17", "9", "RsLabel", 0, "", 34, 35, 30, 86, 14, "Customer Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "18", "8", "RsGroupBox", 0, "", 148, 3, 106, 744, 15, "Instructions / Notes", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "19", "18", "RsLabel", 0, "", 28, 22, 68, 706, 16, "Use this sheet to setup the General &amp;quot;Material to be Handled&amp;quot; parameters to be used globally throughout the remaining worksheets. Some of the worksheets have the option to use locally defined &amp;quot;Material to be Handled&amp;quot; parameters instead of these &amp;quot;Global&amp;quot; parameters defined on this sheet.  This feature is provided where there is a possibility that these material parameters could be more restrictive than the system as a whole.", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "20", "8", "RsGroupBox", 0, "", 260, 3, 192, 744, 17, "Material Size", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "21", "20", "RsComboBox", 0, "User_UOM_System", 28, 109, 22, 172, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "22", "20", "RsTextbox", 0, "BoxSize_Length_Min_User", 95, 109, 21, 60, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "23", "20", "RsComboBox", 0, "BoxSize_Length_Min_User_UOM", 94, 169, 22, 60, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "24", "20", "RsLabel", 0, "", 127, 22, 16, 78, 21, "Maximum", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "25", "20", "RsTextbox", 0, "BoxSize_Width_Min_User", 95, 235, 21, 60, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "26", "20", "RsComboBox", 0, "BoxSize_Length_Min_User_UOM", 94, 300, 22, 60, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "27", "20", "RsTextbox", 0, "BoxSize_Height_Min_User", 95, 366, 21, 60, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "28", "20", "RsComboBox", 0, "BoxSize_Height_Min_User_UOM", 94, 426, 22, 60, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "29", "20", "RsTextbox", 0, "BoxSize_Weight_Min_User", 95, 492, 21, 60, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "30", "20", "RsComboBox", 0, "BoxSize_Weight_Min_User_UOM", 94, 552, 22, 60, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "31", "20", "RsLabel", 0, "", 28, 16, 16, 78, 28, "Default UOM", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "32", "20", "RsTextbox", 0, "BoxSize_Length_Max_User", 122, 109, 21, 60, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "33", "20", "RsComboBox", 0, "BoxSize_Length_Max_User_UOM", 121, 169, 22, 60, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "34", "20", "RsTextbox", 0, "BoxSize_Width_Max_User", 122, 235, 21, 60, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "35", "20", "RsComboBox", 0, "BoxSize_Length_Max_User_UOM", 121, 300, 22, 60, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "36", "20", "RsTextbox", 0, "BoxSize_Height_Max_User", 122, 366, 21, 60, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "37", "20", "RsComboBox", 0, "BoxSize_Height_Max_User_UOM", 121, 426, 22, 60, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "38", "20", "RsTextbox", 0, "BoxSize_Weight_Max_User", 122, 492, 21, 60, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "39", "20", "RsComboBox", 0, "BoxSize_Weight_Max_User_UOM", 121, 552, 22, 60, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "40", "20", "RsTextbox", 0, "BoxSize_Length_Avg_User", 149, 109, 21, 60, 37, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "41", "20", "RsComboBox", 0, "BoxSize_Length_Avg_User_UOM", 148, 169, 22, 60, 38, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "42", "20", "RsTextbox", 0, "BoxSize_Width_Avg_User", 149, 235, 21, 60, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "43", "20", "RsComboBox", 0, "BoxSize_Length_Avg_User_UOM", 148, 300, 22, 60, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "44", "20", "RsTextbox", 0, "BoxSize_Height_Avg_User", 149, 366, 21, 60, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "45", "20", "RsLabel", 0, "", 66, 366, 16, 134, 42, "Height", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "46", "20", "RsComboBox", 0, "BoxSize_Height_Avg_User_UOM", 148, 426, 22, 60, 43, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "47", "20", "RsTextbox", 0, "BoxSize_Weight_Avg_User", 149, 492, 21, 60, 44, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "48", "20", "RsComboBox", 0, "BoxSize_Weight_Max_User_UOM", 148, 552, 22, 60, 45, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "49", "20", "RsLabel", 0, "", 154, 22, 16, 78, 46, "Average", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "50", "20", "RsLabel", 0, "", 100, 22, 16, 78, 47, "Minimum", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "51", "20", "RsLabel", 0, "", 66, 492, 16, 106, 48, "Weight", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "52", "20", "RsLabel", 0, "", 66, 227, 16, 100, 49, "Width", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "53", "20", "RsLabel", 0, "", 66, 109, 16, 78, 50, "Length", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "54", "8", "RsGroupBox", 0, "", 458, 3, 155, 744, 51, "MTBH Factors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "55", "54", "RsTextbox", 0, "Live_Load_Avg_User", 21, 128, 21, 60, 52, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "56", "54", "RsLabel", 0, "", 20, 44, 16, 78, 53, "Live Load:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "57", "54", "RsComboBox", 0, "Live_Load_Avg_User_UOM", 20, 197, 22, 60, 54, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "58", "54", "RsCheckbox", 0, "Totes_Plastic", 48, 128, 18, 129, 55, "Plastic Totes in Use?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "59", "54", "RsCheckbox", 0, "BoxSize_Height_GRTR_Len_Possible", 72, 128, 18, 298, 56, "Within MTBH Range, Can Product Heights be &amp;gt; Length?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "60", "54", "RsCheckbox", 0, "BoxSize_Other_Known_Issues", 96, 128, 18, 175, 57, "Other Known Stability Issues?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "61", "54", "RsComboBox", 0, "Selected_Sortation_Controls", 120, 128, 22, 140, 58, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "62", "54", "RsLabel", 0, "", 95, 398, 22, 114, 59, "Worst Case H/L Ratio:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "63", "54", "RsTextbox", 0, "Temp_Sort_Operating_Min_User", 18, 518, 21, 74, 60, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "64", "54", "RsComboBox", 0, "Temp_Sort_Operating_Min_User_UOM", 17, 598, 22, 60, 61, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "65", "54", "RsLabel", 0, "", 122, 398, 16, 114, 62, "Max Incline / Decline:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "66", "54", "RsTextbox", 0, "Temp_System_Operating_Min_User", 45, 518, 21, 74, 63, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "67", "54", "RsLabel", 0, "", 122, 584, 22, 60, 64, "Degrees", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "68", "54", "RsComboBox", 0, "Temp_System_Operating_Min_UOM", 44, 598, 22, 60, 65, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "69", "54", "RsTextbox", 0, "BoxSize_Worst_Case_HL_Ratio", 96, 518, 21, 60, 66, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "70", "54", "RsTextbox", 0, "Belt_InclineDecline_Max_Deg", 123, 518, 21, 60, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "71", "54", "RsLabel", 0, "", 120, 44, 16, 78, 68, "Control System:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "72", "54", "RsLabel", 0, "", 17, 346, 18, 166, 69, "Operating Temp Min ( Sorter ):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "73", "54", "RsLabel", 0, "", 48, 346, 18, 166, 70, "Operating Temp Min ( System ):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "74", "54", "RsTextbox", 0, "Temp_Sort_Operating_Min_F", 14, 664, 25, 74, 71, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "75", "54", "RsTextbox", 0, "Temp_System_Operating_Min_F", 41, 664, 25, 74, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "76", "8", "RsGroupBox", 0, "", 619, 3, 176, 744, 73, "General Application Factors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "77", "76", "RsLabel", 0, "", 29, 43, 16, 78, 74, "Product Line:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "78", "76", "RsComboBox", 0, "Conveyor_Product_Line_Used", 29, 127, 22, 140, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 288, "79", "76", "RsTextbox", 0, "Conveyor_Width_Min_IN", 61, 127, 21, 74, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "80", "76", "RsLabel", 0, "", 64, 6, 18, 115, 77, "Min Converyor Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "81", "76", "RsTextbox", 0, "Conveyor_Curve_BF_Calc_Min_In", 88, 128, 21, 74, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "82", "76", "RsLabel", 0, "", 91, 7, 18, 115, 79, "Min Calc Curve Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "83", "76", "RsTextbox", 0, "Conveyor_Curve_BF_Calc_Rcmd_In", 115, 127, 21, 74, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 288, "84", "76", "RsLabel", 0, "", 118, 6, 18, 115, 81, "Min Rcmd Curve Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "85", "76", "RsLabel", 0, "", 91, 207, 18, 22, 82, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "86", "76", "RsLabel", 0, "", 64, 207, 18, 22, 83, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "87", "76", "RsLabel", 0, "", 118, 207, 18, 22, 84, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "88", "7", "RsTextbox", 0, "App_Calc_Name", 15, 108, 22, 647, 85, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 288, "89", "7", "RsLabel", 0, "", 18, 8, 19, 94, 86, "App Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 288, "90", "5", "RsGrid", 0, "", 79, 114, 91, 146, 87, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,33,Setup;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 288, "91", "90", "RsGridColumn", 0, "Customer_Location_CityState", 0, 0, 0, 100, 0, "Customer Location CityState", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Freight_Estimation_Products_and_Weights()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(43, "Freight Estimation Products and Weights", "Freight Estimation - Products & Weights", 1, 33, 1, 5, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App_Test_01.Project/IGS_Project_Header.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Freight_Estimator/IGS_Freight_App.Freight_Calculator/Freight_Estimate_Head")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 22, "1", "0", "RsGroupBox", 0, "", 502, 12, 180, 906, 0, "AR/RS Products", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 22, "2", "1", "RsGrid", 0, "", 19, 6, 111, 892, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,7,Product_Details_ASRS;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 22, "3", "2", "RsGridColumn", 0, "Product_Name", 0, 0, 0, 350, 0, "Product_Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "4", "2", "RsGridColumn", 0, "Cost_Per_UOM", 0, 0, 0, 75, 0, "$/UOM", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "5", "2", "RsGridColumn", 0, "Ft_Per_Qty", 0, 0, 0, 75, 0, "Ft/Qty", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "6", "2", "RsGridColumn", 0, "Cost_Per_UOM", 0, 0, 0, 50, 0, "$/ft", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "7", "2", "RsGridColumn", 0, "Cost_Standard", 0, 0, 0, 60, 0, "Cost Std", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "8", "2", "RsGridColumn", 0, "Cost_Escalated", 0, 0, 0, 60, 0, "Cost Esc", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "9", "2", "RsGridColumn", 0, "Ship_From", 0, 0, 0, 120, 0, "Ship_From", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "10", "2", "RsGridColumn", 0, "Weight_In_Lbs", 0, 0, 0, 50, 0, "Lbs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "11", "2", "RsGridColumn", 0, "Percent_of_Total_Display", 0, 0, 0, 40, 0, "% Ttl", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "12", "1", "RsAddDeleteCopy", 0, "", 136, 712, 38, 188, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,7,Product_Details_ASRS;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 22, "13", "0", "RsGroupBox", 0, "", 682, 12, 164, 906, 3, "Electrical", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 22, "14", "13", "RsGrid", 0, "", 19, 6, 98, 892, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,8,Product_Details_Electrical;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 22, "15", "14", "RsGridColumn", 0, "Product_Name", 0, 0, 0, 350, 0, "Product_Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "16", "14", "RsGridColumn", 0, "Cost_Per_UOM", 0, 0, 0, 75, 0, "$/UOM", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "17", "14", "RsGridColumn", 0, "Ft_Per_Qty", 0, 0, 0, 75, 0, "Ft/Qty", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "18", "14", "RsGridColumn", 0, "Cost_Per_UOM", 0, 0, 0, 50, 0, "$/ft", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "19", "14", "RsGridColumn", 0, "Cost_Standard", 0, 0, 0, 60, 0, "Cost Std", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "20", "14", "RsGridColumn", 0, "Cost_Escalated", 0, 0, 0, 60, 0, "Cost Esc", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "21", "14", "RsGridColumn", 0, "Ship_From", 0, 0, 0, 120, 0, "Ship_From", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "22", "14", "RsGridColumn", 0, "Weight_In_Lbs", 0, 0, 0, 50, 0, "Lbs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "23", "14", "RsGridColumn", 0, "Percent_of_Total_Display", 0, 0, 0, 40, 0, "% Ttl", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "24", "13", "RsAddDeleteCopy", 0, "", 123, 710, 38, 188, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,8,Product_Details_Electrical;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 22, "25", "0", "RsGroupBox", 0, "", 311, 12, 188, 906, 6, "Non-Standard Products", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 22, "26", "25", "RsGrid", 0, "", 19, 6, 122, 892, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,6,Product_Details_NonStd;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 22, "27", "26", "RsGridColumn", 0, "Product_Name", 0, 0, 0, 350, 0, "Product_Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "28", "26", "RsGridColumn", 0, "Cost_Per_UOM", 0, 0, 0, 75, 0, "$/UOM", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "29", "26", "RsGridColumn", 0, "Ft_Per_Qty", 0, 0, 0, 75, 0, "Ft/Qty", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "30", "26", "RsGridColumn", 0, "Cost_Per_UOM", 0, 0, 0, 50, 0, "$/ft", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "31", "26", "RsGridColumn", 0, "Cost_Standard", 0, 0, 0, 60, 0, "Cost Std", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "32", "26", "RsGridColumn", 0, "Cost_Escalated", 0, 0, 0, 60, 0, "Cost Esc", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "33", "26", "RsGridColumn", 0, "Ship_From", 0, 0, 0, 120, 0, "Ship_From", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "34", "26", "RsGridColumn", 0, "Weight_In_Lbs", 0, 0, 0, 50, 0, "Lbs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "35", "26", "RsGridColumn", 0, "Percent_of_Total_Display", 0, 0, 0, 40, 0, "% Ttl", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "36", "25", "RsAddDeleteCopy", 0, "", 147, 712, 38, 188, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,6,Product_Details_NonStd;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 22, "37", "0", "RsLabel", 0, "", 9, 12, 35, 176, 9, "Products", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.20;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "38", "0", "RsGroupBox", 0, "", 387, 924, 196, 468, 10, "Trailer Quantities", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 22, "39", "38", "RsTextbox", 0, "Trailer_Max_Load_Lbs", 13, 326, 24, 65, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "40", "38", "RsTextbox", 0, "Trailer_Qty_No_Misc", 43, 326, 24, 65, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "41", "38", "RsLabel", 0, "", 43, 198, 18, 122, 13, "Trailer Qty - Misc Prods", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "42", "38", "RsLabel", 0, "", 73, 198, 18, 122, 14, "Misc Prod Trailers", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "43", "38", "RsTextbox", 0, "Trailer_Qty_Misc_Equip_Pcnt", 73, 397, 24, 34, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "44", "38", "RsLabel", 0, "", 165, 198, 18, 122, 16, "Total Trailers", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "45", "38", "RsTextbox", 0, "Trailer_Qty_from_TTCB_Est", 94, 326, 24, 65, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "46", "38", "RsTextbox", 0, "Trailer_Qty_Misc_Equip", 73, 326, 24, 65, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "47", "38", "RsTextbox", 0, "Trailer_Qty_from_USS_Est", 115, 326, 24, 65, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "48", "38", "RsTextbox", 0, "Trailer_Qty_from_STL_Est", 135, 326, 24, 65, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "49", "38", "RsLabel", 0, "", 165, 397, 18, 59, 21, "(Est)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "50", "38", "RsTextbox", 0, "Trailer_Qty_Total_Est", 165, 326, 24, 65, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "51", "38", "RsLabel", 0, "", 73, 430, 18, 13, 23, "%", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "52", "38", "RsLabel", 0, "", 94, 198, 18, 122, 24, "TTCB Trailers", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "53", "38", "RsLabel", 0, "", 115, 198, 18, 122, 25, "USS Trailers", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "54", "38", "RsLabel", 0, "", 135, 198, 18, 122, 26, "STL Trailers", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "55", "38", "RsLabel", 0, "", 13, 198, 18, 122, 27, "Max Loader Per Trailers", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "56", "38", "RsLabel", 0, "", 13, 397, 18, 59, 28, "Lbs (Each)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "57", "0", "RsGroupBox", 0, "", 589, 924, 100, 468, 29, "Cost Adders", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 22, "58", "57", "RsLabel", 0, "", 42, 266, 18, 13, 30, "%", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "59", "57", "RsTextbox", 0, "Cost_Fuel_Adder_Pcnt", 62, 233, 24, 34, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "60", "57", "RsTextbox", 0, "Cost_Fuel_Adder", 62, 285, 24, 106, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "61", "57", "RsTextbox", 0, "Cost_Adder_Wood_Product_Pcnt", 42, 233, 24, 34, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "62", "57", "RsLabel", 0, "", 62, 135, 18, 92, 34, "Fuel", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "63", "57", "RsTextbox", 0, "Cost_Adder_Wood_Product", 42, 285, 24, 106, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "64", "57", "RsLabel", 0, "", 42, 135, 18, 92, 36, "Wood", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "65", "57", "RsLabel", 0, "", 12, 135, 18, 92, 37, "Trailer (Each)", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "66", "57", "RsTextbox", 0, "Cost_Adder_Trailer_Each", 12, 233, 24, 158, 38, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "67", "57", "RsLabel", 0, "", 62, 266, 18, 13, 39, "%", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "68", "0", "RsGroupBox", 0, "", 47, 12, 253, 906, 40, "HCAD Products", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 22, "69", "68", "RsGrid", 0, "", 19, 6, 179, 892, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,5,Product_Details_HCAD;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 22, "70", "69", "RsGridColumn", 0, "Product_Name", 0, 0, 0, 350, 0, "Product_Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "71", "69", "RsGridColumn", 0, "Cost_Per_UOM", 0, 0, 0, 75, 0, "$/UOM", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "72", "69", "RsGridColumn", 0, "Ft_Per_Qty", 0, 0, 0, 75, 0, "Ft/Qty", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "73", "69", "RsGridColumn", 0, "Cost_Per_UOM", 0, 0, 0, 50, 0, "$/ft", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "74", "69", "RsGridColumn", 0, "Cost_Standard", 0, 0, 0, 60, 0, "Cost Std", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "75", "69", "RsGridColumn", 0, "Cost_Escalated", 0, 0, 0, 60, 0, "Cost Esc", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "76", "69", "RsGridColumn", 0, "Ship_From", 0, 0, 0, 120, 0, "Ship_From", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "77", "69", "RsGridColumn", 0, "Weight_In_Lbs", 0, 0, 0, 50, 0, "Lbs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "78", "69", "RsGridColumn", 0, "Percent_of_Total_Display", 0, 0, 0, 40, 0, "% Ttl", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "79", "68", "RsAddDeleteCopy", 0, "", 204, 712, 38, 188, 42, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,5,Product_Details_HCAD;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 22, "80", "0", "RsGroupBox", 0, "", 139, 924, 161, 468, 43, "Trailer / Ship From Summary", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 22, "81", "80", "RsGrid", 0, "", 19, 15, 131, 442, 44, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,4,ShipFrom_Summaries;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 22, "82", "81", "RsGridColumn", 0, "Ship_From", 0, 0, 0, 80, 0, "Ship From", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "83", "81", "RsGridColumn", 0, "Cost_Freight", 0, 0, 0, 120, 0, "Freight Per Truck $ (USD)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "84", "81", "RsGridColumn", 0, "Weight", 0, 0, 0, 120, 0, "Total Weight (Lbs)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "85", "81", "RsGridColumn", 0, "Trailer_Qty", 0, 0, 0, 75, 0, "Trailer Qty", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 22, "86", "0", "RsGroupBox", 0, "", 47, 924, 86, 468, 45, "Totals", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 22, "87", "86", "RsTextbox", 0, "Sum_Products_Weight_Total", 49, 255, 24, 62, 46, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "88", "86", "RsTextbox", 0, "Sum_Products_Ft_Total", 49, 13, 24, 82, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "89", "86", "RsTextbox", 0, "Sum_Products_Cost_Standard", 49, 101, 24, 72, 48, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "90", "86", "RsLabel", 0, "", 28, 175, 18, 74, 49, "Cost Escalated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "91", "86", "RsLabel", 0, "", 28, 255, 18, 50, 50, "Weight", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "92", "86", "RsLabel", 0, "", 28, 13, 18, 82, 51, "Feet Of Product", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "93", "86", "RsLabel", 0, "", 28, 101, 18, 72, 52, "Cost Standard", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "94", "86", "RsTextbox", 0, "Sum_Products_Cost_Escalated", 49, 175, 24, 74, 53, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "95", "0", "RsGroupBox", 0, "", 695, 924, 148, 468, 54, "$ Totals", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 22, "96", "95", "RsTextbox", 0, "Cost_Subtotal_Mfg_Product", 16, 317, 24, 69, 55, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "97", "95", "RsLabel", 0, "", 40, 160, 18, 147, 56, "Total All Products", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "98", "95", "RsTextbox", 0, "Cost_Total_All_Products", 40, 317, 24, 69, 57, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "99", "95", "RsLabel", 0, "", 40, 392, 18, 59, 58, "(USD)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "100", "95", "RsLabel", 0, "", 16, 158, 18, 147, 59, "Sub Total Mfg Products", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "101", "0", "RsLabel", 0, "", 9, 924, 35, 176, 60, "Summary", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.20;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "102", "0", "RsGroupBox", 0, "", 311, 924, 70, 468, 61, "Total Weights", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 22, "103", "102", "RsTextbox", 0, "Weight_Total_Conveyors_Only", 8, 326, 24, 69, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "104", "102", "RsLabel", 0, "", 32, 169, 18, 147, 63, "Total All Products", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 22, "105", "102", "RsTextbox", 0, "Sum_Products_Weight_Total", 32, 326, 24, 69, 64, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 22, "106", "102", "RsLabel", 0, "", 8, 169, 18, 147, 65, "Conveyors Only", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        
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
          
        InitSubpart("GEN_Connection_Paths", 114, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "3/28/2025 11:59:54 AM", "", "In Development", "N",0,256,255)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Project", 99, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:21 AM", "", "In Development", "Y",0,220,221)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Project_Information", 98, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "3/28/2025 4:15:56 AM", "", "In Development", "Y",0,238,219)
        
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
      Public Function Process_DefaultProcess_Instructions_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:38; TYPE:ST
      result = STATUS_ENABLED
      '   END FORMULA; PROC ID:38; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Process_DefaultProcess_Instructions_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Instructions_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:38; TYPE:CO
      result = ""
      '   END FORMULA; PROC ID:38; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Process_DefaultProcess_Instructions_COMMENT", ex.Message)
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
      '   BEGIN FORMULA; PROC ID:41; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:41; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Process_DefaultProcess_Salesforce_PRD_Import_STATUS", ex.Message)
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
      '   BEGIN FORMULA; PROC ID:41; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:41; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Process_DefaultProcess_Salesforce_PRD_Import_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Salesforce_Proprosal__PRD__Information_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:63; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:63; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Process_DefaultProcess_Salesforce_Proprosal__PRD__Information_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Salesforce_Proprosal__PRD__Information_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:63; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:63; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Process_DefaultProcess_Salesforce_Proprosal__PRD__Information_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_App_Calculations_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:64; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:64; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Process_DefaultProcess_App_Calculations_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_App_Calculations_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:64; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:64; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Process_DefaultProcess_App_Calculations_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Freight_Estimation_Products_and_Weights_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:43; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:43; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Process_DefaultProcess_Freight_Estimation_Products_and_Weights_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Freight_Estimation_Products_and_Weights_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:43; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:43; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Process_DefaultProcess_Freight_Estimation_Products_and_Weights_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_GEN_Connection_Paths_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:114; TYPE:PN
      
      '   END FORMULA; SUB ID:114; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Formula_GEN_Connection_Paths_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_GEN_Connection_Paths_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("GEN_Connection_Paths").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:114; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:114; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Formula_GEN_Connection_Paths_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_GEN_Connection_Paths_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("GEN_Connection_Paths").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:114; TYPE:OP
      Result = "GEN_Connection_Path_List"
      '   END FORMULA; SUB ID:114; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Formula_GEN_Connection_Paths_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:99; TYPE:PN
      
      '   END FORMULA; SUB ID:99; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Formula_Project_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Project").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:99; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:99; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Formula_Project_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Project").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:99; TYPE:OP
      result = "IGS_Project_Header"
      '   END FORMULA; SUB ID:99; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Formula_Project_OPTIMALPARTFAMILY", ex.Message)
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
      '   BEGIN FORMULA; SUB ID:98; TYPE:PN
      
      '   END FORMULA; SUB ID:98; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Formula_Project_Information_PARTNAMES", ex.Message)
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
      '   BEGIN FORMULA; SUB ID:98; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:98; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Formula_Project_Information_QUANTITY", ex.Message)
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
      '   BEGIN FORMULA; SUB ID:98; TYPE:OP
      Result = "IGS_Opportunity_Data"
      '   END FORMULA; SUB ID:98; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App_Test_01.Formula_Project_Information_OPTIMALPARTFAMILY", ex.Message)
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
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Overrides Sub RemoveRsEventHandlerMappings()
    
      RemoveHandler ObjectManager.RsEngineer.RsActionButtonClick, AddressOf g_rsEngineer_RsActionButtonClick
    End Sub
    #End Region

    End Class

  