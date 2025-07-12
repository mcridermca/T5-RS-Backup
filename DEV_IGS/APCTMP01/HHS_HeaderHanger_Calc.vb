Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: HHS_HeaderHanger_Calc
'$ GenerateDate: 07/12/2025 13:20:28

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

    Public Class [HHS_HeaderHanger_Calc]
    
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

    Private this as HHS_HeaderHanger_Calc = me

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
      Case "39"
      Select Case processStep
        Case "97"
        Result = Process_DefaultProcess_Intro_COMMENT()
        
        Case "48"
        Result = Process_DefaultProcess_ACAD_Block_Input_COMMENT()
        
        Case "50"
        Result = Process_DefaultProcess_Detailed_View_COMMENT()
        
        Case "51"
        Result = Process_DefaultProcess_Bill_Of_Material_COMMENT()
        End Select
        End Select
      
    Return Result
    End Function

    Public Function GetProcessStepStatus(ByVal processId As String, ByVal processStep As String) As Integer Implements RuleStream.IRsPartFormulas.GetProcessStepStatus
    Dim Result as Integer 'Long
    Select Case processId
      Case "39"
      Select Case processStep
        Case "97"
        Result = Process_DefaultProcess_Intro_STATUS()
        
        Case "48"
        Result = Process_DefaultProcess_ACAD_Block_Input_STATUS()
        
        Case "50"
        Result = Process_DefaultProcess_Detailed_View_STATUS()
        
        Case "51"
        Result = Process_DefaultProcess_Bill_Of_Material_STATUS()
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
    
          Public Property [Valid]() As Boolean
      Get
      Return Properties("Valid").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Valid").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Valid_Message]() As String
      Get
      Return Properties("Valid_Message").Value
      End Get
      Set(ByVal Value As String)
      Properties("Valid_Message").CalculatedValue = Value
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
    
      Public ReadOnly Property [BOM_Report_01]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("BOM_Report_01")
      End Get
      End Property
    
      Public ReadOnly Property [HHS_Importer]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("HHS_Importer")
      End Get
      End Property
    
      Public ReadOnly Property [HHS_Output]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("HHS_Output")
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
    InitPart("HHS_HeaderHanger_Calc", <a><![CDATA[Header Hanger Calculator]]></a>.Value, 333, "APCTMP01",  "", "", True, True, "In Development", "", "Header Hanger Calculator", "", "", "",  "GLOBAL\H621516", "07/11/2025 16:49:12")
    AddProperty("9797", "Valid", <a><![CDATA[Valid]]></a>.Value, "Are Plastic Totes Used?", "Boolean","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/10/2025 2:34:37 PM")
    AddProperty("9796", "Valid_Message", <a><![CDATA[Valid_Message]]></a>.Value, "Customer Name (From Salesforce ePRD If Available)", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/10/2025 2:26:45 PM")
    AddProperty("2199", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "4/21/2025 3:45:13 PM")
    
      oSubpart = AddSubpart(302,"BOM_Report_01", <a><![CDATA[BOM_Report_01]]></a>.Value, "FD", "", "BOM Item", 9999, "", "GLOBAL\H601424", "7/7/2025 6:32:30 PM")
      
        oSubpart.AddVPF (407, "HHS_BOM_Report_Header", "HHS_BOM_Report_Header")
      
      oSubpart = AddSubpart(201,"HHS_Importer", <a><![CDATA[Import Application]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "4/22/2025 12:19:45 AM")
      
        oSubpart.AddVPF (334, "HHS_DWGXLSX_Importer", "Header Hanger DWG Excel Importer")
      
      oSubpart = AddSubpart(200,"HHS_Output", <a><![CDATA[Output Application]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "4/22/2025 12:19:45 AM")
      
        oSubpart.AddVPF (336, "HHS_Output_Header", "HHS Output Header")
      
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Sub Initialize_Process(ByVal lngProcessID as Integer) Implements RuleStream.IRsPartFormulas.InitializeProcess
    Select Case lngProcessID
    
      Case 39
      Process = "DefaultProcess"	
        Initialize_Process_DefaultProcess_Intro()
        Initialize_Process_DefaultProcess_ACAD_Block_Input()
        Initialize_Process_DefaultProcess_Detailed_View()
        Initialize_Process_DefaultProcess_Bill_Of_Material()
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
        Private Sub Initialize_Process_DefaultProcess_Intro()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(97, "Intro", "Intro", 1, 39, 1, 1, 50, 50)
        oProcessStep.AddPath("HHS_HeaderHanger_Calc.HHS_Output/HHS_Output_Header")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 336, "1", "0", "RsLabel", 0, "", 0, 14, 36, 384, 0, "Customer / Project Information", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "2", "0", "RsGroupBox", 0, "", 138, 12, 181, 744, 1, "Site / Customer Information", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 336, "3", "2", "RsTextbox", 0, "Proposal_Customer_Name", 34, 127, 32, 528, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 336, "4", "2", "RsTextbox", 0, "Proposal_City_State", 72, 127, 32, 528, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 336, "5", "2", "RsTextbox", 0, "Proposal_ID", 110, 127, 32, 528, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 336, "6", "2", "RsTextbox", 0, "Proposal_Description", 145, 127, 32, 528, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 336, "7", "2", "RsLabel", 0, "", 106, 35, 32, 86, 6, "Proposal #:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "8", "2", "RsLabel", 0, "", 141, 22, 32, 99, 7, "Application:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "9", "2", "RsLabel", 0, "", 68, 6, 32, 115, 8, "Location (City, St):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "10", "2", "RsLabel", 0, "", 35, 35, 16, 86, 9, "Customer Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "11", "0", "RsGroupBox", 0, "", 39, 12, 93, 744, 10, "Instructions / Notes", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 336, "12", "11", "RsLabel", 0, "", 28, 22, 49, 706, 11, "Complete the information below from the ePRD.  Then move on to the HCAD Step to import  the Block Data From AutoCAD", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_ACAD_Block_Input()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(48, "ACAD Block Input", "This process step was created automatically by RuleStream.", 1, 39, 1, 2, 50, 50)
        oProcessStep.AddPath("HHS_HeaderHanger_Calc.HHS_Importer/HHS_DWGXLSX_Importer")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 334, "1", "0", "RsLabel", 0, "", 0, 20, 36, 384, 0, "AutoCAD Block Input", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 334, "2", "0", "RsGroupBox", 0, "", 39, 20, 106, 758, 1, "Instructions / Notes", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 334, "3", "2", "RsLabel", 0, "", 26, 6, 68, 734, 2, "Following the instructions on Header Hanger Spreadsheet, extract the blocks pertaining to header hanger components. Copy and Paste the extracted output into the box below. Select the appropriate Siesmic rate based on the site lcoation, and adjust the Hanger  spacing accordingly.", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 334, "4", "0", "RsGroupBox", 0, "", 151, 446, 106, 332, 3, "Additional Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 334, "5", "4", "RsLabel", 0, "", 33, 6, 20, 106, 4, "Seismi Requirement", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 334, "6", "4", "RsComboBox", 0, "Seismic_Requirement", 27, 118, 26, 208, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 334, "7", "4", "RsLabel", 0, "", 53, 260, 28, 66, 6, "(feet)", 0, 0, 0, 4, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 334, "8", "4", "RsLabel", 0, "", 53, 18, 28, 94, 7, "Hanger Spacing", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 334, "9", "4", "RsComboBox", 0, "Hanger_Spacing", 54, 118, 28, 136, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 334, "10", "0", "RsGroupBox", 0, "", 151, 20, 538, 420, 9, "Block Data From Excel", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 334, "11", "10", "RsTextbox", 0, "HHS_Input_Text_Tab_Formatted", 27, 6, 499, 408, 10, "", -1, 0, 0, 4, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 334, "12", "10", "RsGrid", 0, "", 53, 17, 273, 322, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:,0,;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 334, "13", "0", "RsGroupBox", 0, "", 263, 446, 426, 332, 12, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Detailed_View()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(50, "Detailed View", "Detail", 1, 39, 1, 3, 50, 50)
        oProcessStep.AddPath("HHS_HeaderHanger_Calc.HHS_Output/HHS_Output_Header")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 336, "1", "0", "RsGroupBox", 0, "", 758, 39, 65, 1045, 0, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 336, "2", "1", "RsTextbox", 0, "Total_Cost", 12, 935, 19, 104, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 336, "3", "1", "RsLabel", 0, "", 12, 851, 22, 78, 2, "Total Cost:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "4", "1", "RsLabel", 0, "", 40, 823, 22, 106, 3, "Cost Per Hanger:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "5", "1", "RsTextbox", 0, "Cost_Per_Hanger", 37, 935, 19, 104, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 336, "6", "0", "RsLabel", 0, "", 13, 33, 33, 479, 5, "Detailed Component View", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "7", "0", "RsGroupBox", 0, "", 42, 33, 789, 1057, 6, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 336, "8", "7", "RsGrid", 0, "", 20, 5, 688, 1045, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,102,Calculated_Items;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:False;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 336, "9", "8", "RsGridColumn", 0, "Qty_Total_Per_Hanger_Formatted", 0, 0, 0, 50, 0, "QTY", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 336, "10", "8", "RsGridColumn", 0, "Part_Number_ERP", 0, 0, 0, 125, 0, "Part Number ERP", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 336, "11", "8", "RsGridColumn", 0, "Component_Type", 0, 0, 0, 100, 0, "Component Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 336, "12", "8", "RsGridColumn", 0, "Item_Description", 0, 0, 0, 300, 0, "Item Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 336, "13", "8", "RsGridColumn", 0, "UnitCost", 0, 0, 0, 100, 0, "Unit Cost", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 336, "14", "8", "RsGridColumn", 0, "ExtCost_Formatted", 0, 0, 0, 100, 0, "Ext Cost", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 336, "15", "8", "RsGridColumn", 0, "Hanger_Type", 0, 0, 0, 60, 0, "Hanger", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 336, "16", "8", "RsGridColumn", 0, "Drop_Length", 0, 0, 0, 50, 0, "Drop", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 336, "17", "8", "RsGridColumn", 0, "Section", 0, 0, 0, 60, 0, "Section", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 336, "18", "8", "RsGridColumn", 0, "Sort_Order_1_Dbg_Grouping", 0, 0, 0, 50, 0, "Sort", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Bill_Of_Material()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(51, "Bill Of Material", "Bill Of Material", 1, 39, 1, 4, 50, 50)
        oProcessStep.AddPath("HHS_HeaderHanger_Calc.HHS_Output/HHS_Output_Header")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 336, "1", "0", "RsLabel", 0, "", 9, 28, 31, 505, 0, "Bill Of Material", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "2", "0", "RsGroupBox", 0, "", 35, 28, 638, 1008, 1, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 336, "3", "2", "RsGrid", 0, "", 15, 6, 537, 995, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,106,Bom_Items_Flat_Sorted;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:False;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 336, "4", "3", "RsGridColumn", 0, "Qty", 0, 0, 0, 75, 0, "Qty", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 336, "5", "3", "RsGridColumn", 0, "Part_Number_ERP", 0, 0, 0, 175, 0, "Part Number ERP", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 336, "6", "3", "RsGridColumn", 0, "Item_Description", 0, 0, 0, 400, 0, "Item Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 336, "7", "3", "RsGridColumn", 0, "UnitCost", 0, 0, 0, 100, 0, "UnitCost", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 336, "8", "3", "RsGridColumn", 0, "ExtdCost", 0, 0, 0, 100, 0, "Extended Cost", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 336, "9", "3", "RsGridColumn", 0, "Sort_Order_1", 0, 0, 0, 100, 0, "Sort", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 336, "10", "2", "RsGroupBox", 0, "", 556, 7, 76, 996, 3, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 336, "11", "10", "RsActionButton", 0, "", 22, 27, 40, 173, 4, "Open / Generate Excel", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:HHS_Save_BOM_Report_01;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 336, "12", "10", "RsTextbox", 0, "Total_Cost", 15, 886, 19, 98, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 336, "13", "10", "RsTextbox", 0, "Cost_Per_Hanger", 40, 886, 19, 98, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 336, "14", "10", "RsLabel", 0, "", 15, 802, 22, 78, 7, "Total Cost:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "15", "10", "RsLabel", 0, "", 40, 774, 22, 106, 8, "Cost Per Hanger:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
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
          InitProperty("Valid", "9383", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:34:37 PM", "Are Plastic Totes Used?", "In Development",  0,16049)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Valid_Message", "9382", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:21:44 PM", "Customer Name (From Salesforce ePRD If Available)", "In Development",  0,16043)
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
          
        InitSubpart("BOM_Report_01", 229, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "7/7/2025 6:32:16 PM", "", "In Development", "N",0,621,620)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("HHS_Importer", 139, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "4/22/2025 12:19:45 AM", "", "In Development", "Y",0,321,322)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("HHS_Output", 138, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "4/22/2025 12:19:45 AM", "", "In Development", "Y",0,319,320)
        
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
      Public Function Process_DefaultProcess_Intro_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:97; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:97; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Process_DefaultProcess_Intro_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Intro_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:97; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:97; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Process_DefaultProcess_Intro_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_ACAD_Block_Input_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:48; TYPE:ST
      result = STATUS_ENABLED
      '   END FORMULA; PROC ID:48; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Process_DefaultProcess_ACAD_Block_Input_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_ACAD_Block_Input_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:48; TYPE:CO
      result = ""
      '   END FORMULA; PROC ID:48; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Process_DefaultProcess_ACAD_Block_Input_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Detailed_View_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:50; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_DISABLED

If Me.HHS_Importer(1).Product_Lines.Count > 0 Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:50; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Process_DefaultProcess_Detailed_View_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Detailed_View_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:50; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:50; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Process_DefaultProcess_Detailed_View_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Bill_Of_Material_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:51; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_DISABLED

If Me.HHS_Importer(1).Product_Lines.Count > 0 Then
	Result = STATUS_ENABLED
End If
      '   END FORMULA; PROC ID:51; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Process_DefaultProcess_Bill_Of_Material_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Bill_Of_Material_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:51; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:51; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Process_DefaultProcess_Bill_Of_Material_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Valid() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Valid").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9383; TYPE:PF
      Result = True


' This Section should be a duplicate of Valid Message
Dim EList As New Custom.HWErrorList
EList.Add(0, "Warning Message", "ERR000", Me.Name)
EList.Add(1, "Warning Message", "ERR001", Me.Name)
EList.Add(2, "Errror Message", "ERR002", Me.Name)
EList.Add(3, "Critcal Message", "ERR003", Me.Name)
' End Duplicate Section


Result = EList.IsValid(2)
      '   END FORMULA; PROP ID:9383; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Formula_Valid", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Valid_Message() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Valid_Message").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9382; TYPE:PF
      Result = ""

'Dim Source As String = Me.Name
Dim EList As New Custom.HWErrorList

EList.Add(0, "Warning Message", "ERR000", Me.Name)
EList.Add(1, "Warning Message", "ERR001", Me.Name)
EList.Add(2, "Errror Message", "ERR002", Me.Name)
EList.Add(3, "Critcal Message", "ERR003", Me.Name)

Result = EList.ErrorSummary(1)
      '   END FORMULA; PROP ID:9382; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Formula_Valid_Message", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Valid_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Valid_Message_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Valid_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Valid_Message_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BOM_Report_01_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:229; TYPE:PN
      
      '   END FORMULA; SUB ID:229; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Formula_BOM_Report_01_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BOM_Report_01_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("BOM_Report_01").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:229; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:229; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Formula_BOM_Report_01_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BOM_Report_01_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("BOM_Report_01").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:229; TYPE:OP
      result = "HHS_BOM_Report_Header"
      '   END FORMULA; SUB ID:229; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Formula_BOM_Report_01_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Importer_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:139; TYPE:PN
      
      '   END FORMULA; SUB ID:139; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Formula_HHS_Importer_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Importer_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("HHS_Importer").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:139; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:139; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Formula_HHS_Importer_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Importer_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("HHS_Importer").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:139; TYPE:OP
      Result = "HHS_DWGXLSX_Importer"
      '   END FORMULA; SUB ID:139; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Formula_HHS_Importer_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Output_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:138; TYPE:PN
      
      '   END FORMULA; SUB ID:138; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Formula_HHS_Output_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Output_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("HHS_Output").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:138; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:138; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Formula_HHS_Output_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HHS_Output_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("HHS_Output").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:138; TYPE:OP
      Result = "HHS_Output_Header"
      '   END FORMULA; SUB ID:138; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HHS_HeaderHanger_Calc.Formula_HHS_Output_OPTIMALPARTFAMILY", ex.Message)
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

  