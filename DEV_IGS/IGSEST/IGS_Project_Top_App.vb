Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: IGS_Project_Top_App
'$ GenerateDate: 07/24/2025 22:14:38

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
        Result = Process_DefaultProcess_Instructions_COMMENT()
        
        Case "70"
        Result = Process_DefaultProcess_PRD_Import_COMMENT()
        
        Case "109"
        Result = Process_DefaultProcess_PRD_Summary_COMMENT()
        
        Case "71"
        Result = Process_DefaultProcess_Tools_COMMENT()
        
        Case "103"
        Result = Process_DefaultProcess_Setup_And_Global_MTBF_COMMENT()
        
        Case "105"
        Result = Process_DefaultProcess_Sortation_COMMENT()
        
        Case "118"
        Result = Process_DefaultProcess_Induction_COMMENT()
        
        Case "104"
        Result = Process_DefaultProcess_Scanner_Configurations_COMMENT()
        
        Case "79"
        Result = Process_DefaultProcess_Print_And_Apply_COMMENT()
        
        Case "113"
        Result = Process_DefaultProcess_Setup_And_Global_MTBF___DEBUG_COMMENT()
        
        Case "115"
        Result = Process_DefaultProcess_MDR_Sort_COMMENT()
        
        Case "119"
        Result = Process_DefaultProcess_Scan_Belt_COMMENT()
        
        Case "106"
        Result = Process_DefaultProcess_Intro_COMMENT()
        
        Case "78"
        Result = Process_DefaultProcess_Header_Hanger_Import_COMMENT()
        
        Case "107"
        Result = Process_DefaultProcess_Detailed_Comp_View_COMMENT()
        
        Case "108"
        Result = Process_DefaultProcess_BOM_View_COMMENT()
        
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
        Result = Process_DefaultProcess_System_Mech_Delta_COMMENT()
        
        Case "84"
        Result = Process_DefaultProcess_Output_Mech_COMMENT()
        
        Case "101"
        Result = Process_DefaultProcess_Chutes_test_COMMENT()
        
        Case "112"
        Result = Process_DefaultProcess_TTCB_Test_COMMENT()
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
        Result = Process_DefaultProcess_Instructions_STATUS()
        
        Case "70"
        Result = Process_DefaultProcess_PRD_Import_STATUS()
        
        Case "109"
        Result = Process_DefaultProcess_PRD_Summary_STATUS()
        
        Case "71"
        Result = Process_DefaultProcess_Tools_STATUS()
        
        Case "103"
        Result = Process_DefaultProcess_Setup_And_Global_MTBF_STATUS()
        
        Case "105"
        Result = Process_DefaultProcess_Sortation_STATUS()
        
        Case "118"
        Result = Process_DefaultProcess_Induction_STATUS()
        
        Case "104"
        Result = Process_DefaultProcess_Scanner_Configurations_STATUS()
        
        Case "79"
        Result = Process_DefaultProcess_Print_And_Apply_STATUS()
        
        Case "113"
        Result = Process_DefaultProcess_Setup_And_Global_MTBF___DEBUG_STATUS()
        
        Case "115"
        Result = Process_DefaultProcess_MDR_Sort_STATUS()
        
        Case "119"
        Result = Process_DefaultProcess_Scan_Belt_STATUS()
        
        Case "106"
        Result = Process_DefaultProcess_Intro_STATUS()
        
        Case "78"
        Result = Process_DefaultProcess_Header_Hanger_Import_STATUS()
        
        Case "107"
        Result = Process_DefaultProcess_Detailed_Comp_View_STATUS()
        
        Case "108"
        Result = Process_DefaultProcess_BOM_View_STATUS()
        
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
        Result = Process_DefaultProcess_System_Mech_Delta_STATUS()
        
        Case "84"
        Result = Process_DefaultProcess_Output_Mech_STATUS()
        
        Case "101"
        Result = Process_DefaultProcess_Chutes_test_STATUS()
        
        Case "112"
        Result = Process_DefaultProcess_TTCB_Test_STATUS()
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
    
          Public Property [Data_Capture_Creation_Date]() As String
      Get
      Return Properties("Data_Capture_Creation_Date").Value
      End Get
      Set(ByVal Value As String)
      Properties("Data_Capture_Creation_Date").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Data_Capture_Creation_User_ID]() As String
      Get
      Return Properties("Data_Capture_Creation_User_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Data_Capture_Creation_User_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Data_Capture_Customer_Name]() As String
      Get
      Return Properties("Data_Capture_Customer_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Data_Capture_Customer_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Data_Capture_Last_Update_Date]() As String
      Get
      Return Properties("Data_Capture_Last_Update_Date").Value
      End Get
      Set(ByVal Value As String)
      Properties("Data_Capture_Last_Update_Date").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Data_Capture_Last_Update_User_ID]() As String
      Get
      Return Properties("Data_Capture_Last_Update_User_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Data_Capture_Last_Update_User_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Data_Capture_Line_Item]() As String
      Get
      Return Properties("Data_Capture_Line_Item").Value
      End Get
      Set(ByVal Value As String)
      Properties("Data_Capture_Line_Item").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Data_Capture_Project_ID]() As String
      Get
      Return Properties("Data_Capture_Project_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Data_Capture_Project_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Data_Capture_TeamCenter_ID]() As String
      Get
      Return Properties("Data_Capture_TeamCenter_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Data_Capture_TeamCenter_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TeamCenter_ID]() As String
      Get
      Return Properties("TeamCenter_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("TeamCenter_ID").CalculatedValue = Value
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
    
      Public ReadOnly Property [Project_Information]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Project_Information")
      End Get
      End Property
    
      Public ReadOnly Property [Delete_ME_MPC_Testing]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Delete_ME_MPC_Testing")
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
    InitPart("IGS_Project_Top_App", <a><![CDATA[IGS_Project_Top_App]]></a>.Value, 376, "IGSEST",  "", "", True, True, "In Development", "", "", "", "", "Rulestream_Reporting_Data",  "GLOBAL\H601424", "07/24/2025 21:57:31")
    AddProperty("11315", "Data_Capture_Creation_Date", <a><![CDATA[Data_Capture_Creation_Date]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "Project_Creation_Date", "GLOBAL\H602502", "7/23/2025 7:51:01 PM")
    AddProperty("11316", "Data_Capture_Creation_User_ID", <a><![CDATA[Data_Capture_Creation_User_ID]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "Project_Creation_User_ID", "GLOBAL\H602502", "7/23/2025 7:51:05 PM")
    AddProperty("11314", "Data_Capture_Customer_Name", <a><![CDATA[Data_Capture_Customer_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "Customer_Name", "GLOBAL\H602502", "7/23/2025 7:51:11 PM")
    AddProperty("11317", "Data_Capture_Last_Update_Date", <a><![CDATA[Data_Capture_Last_Update_Date]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "Last_Update_Date", "GLOBAL\H602502", "7/23/2025 7:58:59 PM")
    AddProperty("11318", "Data_Capture_Last_Update_User_ID", <a><![CDATA[Data_Capture_Last_Update_User_ID]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "Last_Update_User_ID", "GLOBAL\H602502", "7/23/2025 7:51:40 PM")
    AddProperty("11311", "Data_Capture_Line_Item", <a><![CDATA[Data_Capture_Line_Item]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "Rulestream_Line_Item_ID", "GLOBAL\H602502", "7/23/2025 7:51:46 PM")
    AddProperty("11310", "Data_Capture_Project_ID", <a><![CDATA[Data_Capture_Project_ID]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "Rulestream_Project_ID", "GLOBAL\H602502", "7/23/2025 7:51:52 PM")
    AddProperty("11313", "Data_Capture_TeamCenter_ID", <a><![CDATA[Data_Capture_TeamCenter_ID]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "TeamCenter_ID", "GLOBAL\H602502", "7/23/2025 7:51:57 PM")
    AddProperty("11312", "TeamCenter_ID", <a><![CDATA[TeamCenter_ID]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/23/2025 7:39:21 PM")
    AddProperty("4821", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/23/2025 1:10:55 PM")
    
      oSubpart = AddSubpart(255,"Project_Information", <a><![CDATA[Project_Information]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "6/23/2025 1:12:18 PM")
      
        oSubpart.AddVPF (374, "IGS_Opportunity", "IGS_Opportunity")
      
      oConnection = AddConnection("Delete_ME_MPC_Testing", <a><![CDATA[Debug_MPC_Testing_Object]]></a>.Value, "Debug Connection for Quick Access to Debug Items . Delete before Moving to Prod", "181", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/15/2025 5:15:02 PM")
      
        oConnection.AddVPF(377, "IGS_Tool_Instance_Mgr")
      
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
        Initialize_Process_DefaultProcess_Instructions()
        Initialize_Process_DefaultProcess_PRD_Import()
        Initialize_Process_DefaultProcess_PRD_Summary()
        Initialize_Process_DefaultProcess_Tools()
        Initialize_Process_DefaultProcess_Setup_And_Global_MTBF()
        Initialize_Process_DefaultProcess_Sortation()
        Initialize_Process_DefaultProcess_Induction()
        Initialize_Process_DefaultProcess_Scanner_Configurations()
        Initialize_Process_DefaultProcess_Print_And_Apply()
        Initialize_Process_DefaultProcess_Setup_And_Global_MTBF___DEBUG()
        Initialize_Process_DefaultProcess_MDR_Sort()
        Initialize_Process_DefaultProcess_Scan_Belt()
        Initialize_Process_DefaultProcess_Intro()
        Initialize_Process_DefaultProcess_Header_Hanger_Import()
        Initialize_Process_DefaultProcess_Detailed_Comp_View()
        Initialize_Process_DefaultProcess_BOM_View()
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
        Initialize_Process_DefaultProcess_System_Mech_Delta()
        Initialize_Process_DefaultProcess_Output_Mech()
        Initialize_Process_DefaultProcess_Chutes_test()
        Initialize_Process_DefaultProcess_TTCB_Test()
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
        oProcessStep.AddCustomLayout(1, 374, "1", "0", "RsLabel", 0, "", 16, 6, 34, 458, 0, "IGS Integrated Applications Example", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 374, "2", "0", "RsLabel", 0, "", 77, 6, 27, 579, 1, "TBA ..... Instructions to be updated to reflect business process and data sources", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 374, "3", "0", "RsLabel", 0, "", 50, 6, 27, 354, 2, "Instructions", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 374, "4", "0", "RsGroupBox", 0, "", 107, 6, 633, 1065, 3, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 374, "5", "4", "RsGrid", 0, "", 9, 4, 350, 400, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,253,Proposal_Information;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 374, "6", "5", "RsGridColumn", 0, "DisplayName", 0, 0, 0, 150, 0, "Proposal", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 374, "7", "4", "RsAddDeleteCopy", 0, "", 365, 246, 22, 158, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,253,Proposal_Information;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 374, "8", "4", "RsSubForm", 0, "", 9, 410, 396, 418, 6, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,253,Proposal_Information")
        oProcessStep.AddCustomLayout(1, 374, "9", "8", "RsGrid", 0, "", 0, 0, 350, 400, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,256,PRD_Document;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 374, "10", "9", "RsGridColumn", 0, "DisplayName", 0, 0, 0, 150, 0, "PRD", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 374, "11", "8", "RsAddDeleteCopy", 0, "", 356, 242, 22, 158, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,256,PRD_Document;CanDelete:;AddPrompt:False;ShowCopy:True")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Instructions()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(69, "Instructions", "Instructions", 103, 51, 1, 2, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 163, "1", "0", "RsLabel", 0, "", 9, 22, 34, 458, 0, "IGS Integrated Applications Example", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "2", "0", "RsLabel", 0, "", 92, 22, 30, 654, 1, "TBA ..... Instructions to be updated to reflect business process and data sources", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "3", "0", "RsLabel", 0, "", 131, 22, 27, 408, 2, "Select Opportunity Data Source To Continue", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.9;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "4", "0", "RsLabel", 0, "", 50, 22, 27, 354, 3, "Instructions", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "5", "0", "RsGroupBox", 0, "", 161, 22, 236, 436, 4, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 163, "6", "5", "RsRadioButton", 0, "Opportunity_Data_Source_Type", 23, 20, 22, 81, 5, "Manual", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.10;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 163, "7", "5", "RsLabel", 0, "", 86, 38, 21, 370, 6, "- Copy and Paste Products &amp;amp; Weights from Salesforce PRD Document", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "8", "5", "RsLabel", 0, "", 41, 38, 21, 230, 7, "- Manually Enter Product Details and Weights", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "9", "5", "RsLabel", 0, "", 131, 38, 21, 370, 8, "- TBA (Not Available / Coming Soon)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "10", "5", "RsLabel", 0, "", 176, 38, 21, 370, 9, "- TBA (Not Available / Coming Soon)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "11", "5", "RsRadioButton", 0, "Opportunity_Data_Source_Type", 155, 20, 18, 293, 10, "CORA Project        (Direct Import  By Project #)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 163, "12", "5", "RsRadioButton", 0, "Opportunity_Data_Source_Type", 65, 20, 18, 116, 11, "Salesforce PRD", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 163, "13", "5", "RsRadioButton", 0, "Opportunity_Data_Source_Type", 110, 20, 18, 294, 12, "Salesforce PRD     (Direct Import  By Project #)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 163, "14", "5", "RsLabel", 0, "", 65, 138, 21, 130, 13, "(Copy/Paste Method)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_PRD_Import()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(70, "PRD Import", "", 103, 51, 1, 3, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 163, "1", "0", "RsTextbox", 0, "PRD_Input_Text_Tab_Formatted", 113, 0, 648, 560, 0, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "2", "0", "RsTextbox", 0, "PRD_TOTAL_DEBUG", 113, 558, 648, 641, 1, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "3", "0", "RsLabel", 0, "", 9, 0, 35, 429, 2, "Salesforce PRD Product Import", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "4", "0", "RsLabel", 0, "", 50, 558, 29, 520, 3, "Step 2: Review Items", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.14;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "5", "0", "RsLabel", 0, "", 79, 0, 20, 533, 4, "(Please Note, you may have to paste and copy from MS Excel to capture HTML Formatting Properly)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "6", "0", "RsLabel", 0, "", 50, 0, 29, 406, 5, "Step 1: Copy &amp;amp; Paste PRD Information Below", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_PRD_Summary()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(109, "PRD Summary", "", 103, 51, 1, 4, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 163, "1", "0", "RsLabel", 0, "", 18, 12, 36, 674, 0, "Salesforce ePRD", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "2", "0", "RsGroupBox", 0, "", 57, 12, 551, 703, 1, "Site / Customer Information", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 163, "3", "2", "RsTextbox", 0, "Date_Install_Duration", 335, 459, 32, 113, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "4", "2", "RsLabel", 0, "", 335, 333, 32, 120, 3, "Install Duration:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "5", "2", "RsLabel", 0, "", 373, 578, 32, 104, 4, "Weeks", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "6", "2", "RsLabel", 0, "", 335, 578, 32, 104, 5, "Weeks", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "7", "2", "RsLabel", 0, "", 297, 578, 32, 104, 6, "Weeks", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "8", "2", "RsSingleDatePicker", 0, "Proposal_Date_Contract_Award", 221, 127, 20, 200, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 163, "9", "2", "RsSingleDatePicker", 0, "Proposal_Date_Quote", 220, 459, 20, 200, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 163, "10", "2", "RsLabel", 0, "", 220, 354, 32, 99, 9, "Quote Date:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "11", "2", "RsTextbox", 0, "Date_Pre_Install_Duration", 297, 459, 32, 113, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "12", "2", "RsTextbox", 0, "Date_Comm_Duration", 373, 459, 32, 113, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "13", "2", "RsLabel", 0, "", 297, 333, 32, 120, 12, "Pre Install Duration:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "14", "2", "RsLabel", 0, "", 373, 333, 32, 120, 13, "Comm Duration:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "15", "2", "RsSingleDatePicker", 0, "Proposal_Date_Eng_InHouse_Start", 259, 127, 20, 200, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 163, "16", "2", "RsLabel", 0, "", 405, 22, 32, 99, 15, "Go Live Date:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "17", "2", "RsLabel", 0, "", 297, 22, 32, 99, 16, "Install Start Date:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "18", "2", "RsSingleDatePicker", 0, "Proposal_Date_Turn_Over_To_Customer_Go_Live", 405, 127, 20, 200, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 163, "19", "2", "RsTextbox", 0, "Proposal_City_State", 72, 127, 32, 528, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "20", "2", "RsSingleDatePicker", 0, "Proposal_Date_Installation_End", 335, 127, 20, 200, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 163, "21", "2", "RsSingleDatePicker", 0, "Proposal_Date_Installation_Start", 297, 127, 20, 200, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 163, "22", "2", "RsLabel", 0, "", 183, 22, 32, 99, 21, "Proposal Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "23", "2", "RsLabel", 0, "", 373, 22, 32, 99, 22, "End Run-In Date:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "24", "2", "RsLabel", 0, "", 335, 22, 32, 99, 23, "Install End Date:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "25", "2", "RsTextbox", 0, "Proposal_Customer_Name", 35, 127, 32, 528, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "26", "2", "RsLabel", 0, "", 259, 22, 28, 99, 25, "Eng Start Date:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "27", "2", "RsLabel", 0, "", 221, 22, 32, 99, 26, "Contract Award:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "28", "2", "RsTextbox", 0, "Proposal_Name", 183, 127, 32, 528, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "29", "2", "RsTextbox", 0, "Proposal_ID", 110, 127, 29, 528, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "30", "2", "RsTextbox", 0, "Proposal_Description", 145, 127, 32, 528, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 163, "31", "2", "RsLabel", 0, "", 110, 35, 22, 86, 30, "Proposal #:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "32", "2", "RsLabel", 0, "", 145, 22, 24, 99, 31, "Application:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "33", "2", "RsLabel", 0, "", 72, 6, 32, 115, 32, "Location (City, St):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "34", "2", "RsLabel", 0, "", 35, 35, 16, 86, 33, "Customer Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 163, "35", "2", "RsSingleDatePicker", 0, "Proposal_Date_Run_In_End", 373, 127, 20, 200, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Tools()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(71, "Tools", "", 104, 51, 1, 5, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 377, "1", "0", "RsLabel", 0, "", 9, 12, 34, 494, 0, "IGS Integrated Applications Example", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 377, "2", "0", "RsLabel", 0, "", 83, 12, 23, 354, 1, "Select the tool(s) to be included in this PRD", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.9;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 377, "3", "0", "RsLabel", 0, "", 445, 144, 23, 303, 2, "Select the AppCalc tool(s) to be included in this PRD", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.9;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 377, "4", "0", "RsLabel", 0, "", 43, 12, 27, 354, 3, "Instructions", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 377, "5", "0", "RsGrid", 0, "", 119, 238, 319, 373, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,116,ToolRollup;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 377, "6", "5", "RsGridColumn", 0, "Tool_Name", 0, 0, 0, 200, 0, "Tool", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 377, "7", "5", "RsGridColumn", 0, "Tool_Status", 0, 0, 0, 150, 0, "Status", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 377, "8", "0", "RsAddDeleteCopy", 0, "", 445, 453, 22, 158, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,314,App_Calc;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 377, "9", "0", "RsGroupBox", 0, "", 113, 12, 325, 220, 6, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 377, "10", "9", "RsCheckbox", 0, "HasHeaderHanger", 19, 6, 18, 105, 7, "Header Hanger", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 377, "11", "9", "RsCheckbox", 0, "HasMechInstall", 57, 6, 18, 89, 8, "Mech Install", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Setup_And_Global_MTBF()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(103, "Setup And Global MTBF", "Setup And Global MTBF", 106, 51, 1, 6, 50, 50)
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
        oProcessStep.AddCustomLayout(1, 119, "12", "11", "RsLabel", 0, "", 25, 7, 57, 706, 11, "Use this sheet to setup the General &amp;quot;Material to be Handled&amp;quot; parameters to be used globally throughout the remaining worksheets. Some of the worksheets have the option to use locally defined &amp;quot;Material to be Handled&amp;quot; parameters instead of these &amp;quot;Global&amp;quot; parameters defined on this sheet.  This feature is provided where there is a possibility that these material parameters could be more restrictive than the system as a whole.", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "13", "0", "RsGroupBox", 0, "", 296, 12, 192, 744, 12, "Material Size", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "14", "13", "RsComboBox", 0, "User_UOM_System", 28, 127, 22, 172, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "15", "13", "RsTextbox", 0, "BoxSize_Length_Min_User", 95, 127, 21, 60, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "16", "13", "RsComboBox", 0, "BoxSize_Length_Min_User_UOM", 95, 187, 22, 60, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "17", "13", "RsLabel", 0, "", 121, 40, 16, 78, 16, "Maximum", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "18", "13", "RsTextbox", 0, "BoxSize_Width_Min_User", 95, 253, 21, 60, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "19", "13", "RsComboBox", 0, "BoxSize_Length_Min_User_UOM", 95, 318, 22, 60, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "20", "13", "RsTextbox", 0, "BoxSize_Height_Min_User", 95, 384, 21, 60, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "21", "13", "RsComboBox", 0, "BoxSize_Height_Min_User_UOM", 95, 444, 22, 60, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "22", "13", "RsTextbox", 0, "BoxSize_Weight_Min_User", 95, 510, 21, 60, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "23", "13", "RsComboBox", 0, "BoxSize_Weight_Min_User_UOM", 95, 570, 22, 60, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "24", "13", "RsLabel", 0, "", 28, 34, 16, 78, 23, "Default UOM", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "25", "13", "RsTextbox", 0, "BoxSize_Length_Max_User", 121, 127, 21, 60, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "26", "13", "RsComboBox", 0, "BoxSize_Length_Max_User_UOM", 121, 187, 22, 60, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "27", "13", "RsTextbox", 0, "BoxSize_Width_Max_User", 121, 253, 21, 60, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "28", "13", "RsComboBox", 0, "BoxSize_Length_Max_User_UOM", 121, 318, 22, 60, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "29", "13", "RsTextbox", 0, "BoxSize_Height_Max_User", 121, 384, 21, 60, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "30", "13", "RsComboBox", 0, "BoxSize_Height_Max_User_UOM", 121, 444, 22, 60, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "31", "13", "RsTextbox", 0, "BoxSize_Weight_Max_User", 121, 510, 21, 60, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "32", "13", "RsComboBox", 0, "BoxSize_Weight_Max_User_UOM", 121, 570, 22, 60, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "33", "13", "RsTextbox", 0, "BoxSize_Length_Avg_User", 149, 127, 21, 60, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "34", "13", "RsComboBox", 0, "BoxSize_Length_Avg_User_UOM", 149, 187, 22, 60, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "35", "13", "RsTextbox", 0, "BoxSize_Width_Avg_User", 149, 253, 21, 60, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "36", "13", "RsComboBox", 0, "BoxSize_Length_Avg_User_UOM", 149, 318, 22, 60, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "37", "13", "RsTextbox", 0, "BoxSize_Height_Avg_User", 149, 384, 21, 60, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "38", "13", "RsLabel", 0, "", 75, 384, 16, 120, 37, "Height", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "39", "13", "RsComboBox", 0, "BoxSize_Height_Avg_User_UOM", 149, 444, 22, 60, 38, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "40", "13", "RsTextbox", 0, "BoxSize_Weight_Avg_User", 149, 510, 21, 60, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "41", "13", "RsComboBox", 0, "BoxSize_Weight_Max_User_UOM", 149, 570, 22, 60, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "42", "13", "RsLabel", 0, "", 149, 40, 16, 78, 41, "Average", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "43", "13", "RsLabel", 0, "", 95, 40, 16, 78, 42, "Minimum", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "44", "13", "RsLabel", 0, "", 75, 510, 16, 106, 43, "Weight", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "45", "13", "RsLabel", 0, "", 75, 253, 16, 100, 44, "Width", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "46", "13", "RsLabel", 0, "", 75, 149, 16, 78, 45, "Length", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
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
        oProcessStep.AddCustomLayout(1, 119, "63", "47", "RsTextbox", 0, "Belt_InclineDecline_Max_Deg", 122, 518, 21, 60, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "64", "47", "RsLabel", 0, "", 120, 44, 16, 78, 63, "Control System:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "65", "47", "RsLabel", 0, "", 17, 346, 18, 166, 64, "Operating Temp Min ( Sorter ):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "66", "47", "RsLabel", 0, "", 48, 346, 18, 166, 65, "Operating Temp Min ( System ):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "67", "47", "RsTextbox", 0, "Temp_Sort_Operating_Min_F", 18, 664, 25, 64, 66, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "68", "47", "RsTextbox", 0, "Temp_System_Operating_Min_F", 44, 664, 25, 64, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "69", "0", "RsGroupBox", 0, "", 655, 12, 200, 744, 68, "General Application Factors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "70", "69", "RsLabel", 0, "", 37, 44, 16, 78, 69, "Product Line:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "71", "69", "RsComboBox", 0, "Conveyor_Product_Line_Used", 31, 137, 22, 140, 70, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "72", "69", "RsLabel", 0, "", 143, 369, 22, 177, 71, "Target Case Length per Minute:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "73", "69", "RsTextbox", 0, "Conveyor_Width_Min_IN", 61, 137, 21, 74, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "74", "69", "RsLabel", 0, "", 29, 293, 18, 316, 73, "Total Skew Length Required for Selected MTBH Width and BF:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "75", "69", "RsTextbox", 0, "Conveyor_Curve_BF_Calc_Min_In", 88, 137, 21, 74, 74, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "76", "69", "RsTextbox", 0, "Conveyor_Curve_BF_Calc_Rcmd_In", 115, 137, 21, 74, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "77", "69", "RsComboBox", 0, "Conveyor_BF_Selected_Min_User", 142, 137, 22, 140, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "78", "69", "RsTextbox", 0, "Material_Gap_Override_User", 170, 552, 21, 60, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "79", "69", "RsComboBox", 0, "Conveyor_BF_Selected_Min_User_UOM", 141, 280, 22, 60, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "80", "69", "RsLabel", 0, "", 64, 6, 18, 115, 79, "Min Converyor Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "81", "69", "RsTextbox", 0, "Conveyor_Skew_Total_Length_MTBH_Width_IN", 26, 615, 21, 74, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "82", "69", "RsTextbox", 0, "Conveyor_Skew_Bed_Length_Min_Reqd_IN", 53, 615, 21, 74, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "83", "69", "RsLabel", 0, "", 112, 439, 19, 107, 82, "Target Sort Rate:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "84", "69", "RsCheckbox", 0, "Sort_Dual_Sided", 80, 599, 18, 129, 83, "Dual Sided Sortation", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "85", "69", "RsLabel", 0, "", 144, 706, 18, 22, 84, "M", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "86", "69", "RsTextbox", 0, "Sort_Rate_Required_CPM", 112, 552, 21, 60, 85, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "87", "69", "RsLabel", 0, "", 170, 441, 22, 105, 86, "Design Gap Override:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "88", "69", "RsLabel", 0, "", 114, 618, 18, 105, 87, "CPM (Cases Per Min)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "89", "69", "RsTextbox", 0, "Case_Length_Per_Minute_Target_FT", 144, 552, 21, 60, 88, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "90", "69", "RsLabel", 0, "", 147, 618, 18, 14, 89, "Ft.", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "91", "69", "RsTextbox", 0, "Case_Length_Per_Minute_Target_M", 143, 640, 21, 60, 90, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "92", "69", "RsLabel", 0, "", 91, 7, 18, 115, 91, "Min Calc Curve Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "93", "69", "RsComboBox", 0, "Material_Gap_Override_User_UOM", 170, 640, 22, 60, 92, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "94", "69", "RsLabel", 0, "", 56, 264, 18, 345, 93, "Minimum Required Skew Bed Length for Selected MTBH Width and BF:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "95", "69", "RsLabel", 0, "", 118, 6, 18, 115, 94, "Min Rcmd Curve Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "96", "69", "RsLabel", 0, "", 29, 695, 18, 22, 95, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "97", "69", "RsLabel", 0, "", 53, 695, 18, 22, 96, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "98", "69", "RsLabel", 0, "", 142, 16, 22, 105, 97, "Selected Min Wdith:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "99", "69", "RsLabel", 0, "", 88, 217, 18, 22, 98, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "100", "69", "RsLabel", 0, "", 64, 217, 18, 22, 99, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "101", "69", "RsLabel", 0, "", 118, 217, 18, 22, 100, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "102", "0", "RsPrevActionButton", 0, "", 1246, 12, 38, 94, 101, "Previous", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 119, "103", "0", "RsNextActionButton", 0, "", 1246, 640, 38, 116, 102, "Next", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 119, "104", "0", "RsGroupBox", 0, "", 876, 12, 364, 744, 103, "Sortation Equipment Options", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "105", "104", "RsGrid", 0, "", 69, 16, 278, 707, 104, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,222,Sort_Equipment_Options;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:False;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:False")
        oProcessStep.AddCustomLayout(1, 119, "106", "105", "RsGridColumn", 0, "Model", 0, 0, 0, 200, 0, "List of Suitable Models:", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 119, "107", "105", "RsGridColumn", 0, "Speed_Max_RPM", 0, 0, 0, 160, 0, "Max Speed", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 119, "108", "105", "RsGridColumn", 0, "Gap_Min_IN_Formatted", 0, 0, 0, 160, 0, "Min Gap Required", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 119, "109", "105", "RsGridColumn", 0, "Rate_Max_CPM_Formatted", 0, 0, 0, 160, 0, "Max Capacity (CPM)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 119, "110", "104", "RsTextbox", 0, "Material_Gap_Design_Sorter_IN", 27, 592, 22, 125, 105, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "111", "104", "RsLabel", 0, "", 28, 428, 21, 150, 106, "Defined Min Design Gap:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "112", "104", "RsLabel", 0, "", 29, 16, 21, 127, 107, "Total Sorters Found:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "113", "104", "RsTextbox", 0, "Sorter_Options_Found_Qty", 27, 149, 22, 125, 108, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Sortation()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(105, "Sortation", "Sortation", 106, 51, 1, 7, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.App_Calc/CAE_App_Calc.Sortation/CAE_APC_Sortation")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 442, "1", "0", "RsTabControl", 0, "", 76, 10, 704, 831, 0, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 442, "2", "1", "RsTabPage", 0, "", 0, 0, 678, 823, 0, "Selected", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 442, "3", "2", "RsGroupBox", 0, "", 17, 16, 288, 803, 1, "Sorter Model Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "4", "3", "RsSubForm", 0, "", 19, 6, 261, 780, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,356,Selected_Sorter")
        oProcessStep.AddCustomLayout(1, 442, "5", "4", "RsCheckbox", 0, "Check_Width", 70, 360, 18, 92, 3, "Check Width", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "6", "4", "RsLabel", 0, "", 121, 37, 20, 76, 4, "Type:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "7", "4", "RsLabel", 0, "", 188, 37, 20, 76, 5, "Design Gap", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "8", "4", "RsTextbox", 0, "PK_ID", 14, 605, 26, 160, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "9", "4", "RsLabel", 0, "", 14, 499, 20, 100, 7, "Database ID:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "10", "4", "RsTextbox", 0, "Sorter_Type", 121, 119, 26, 160, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "11", "4", "RsTextbox", 0, "Faults_Total", 46, 605, 26, 160, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "12", "4", "RsLabel", 0, "", 156, 37, 20, 76, 10, "Max Speed", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "13", "4", "RsLabel", 0, "", 97, 293, 20, 61, 11, "Max Rate:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "14", "4", "RsLabel", 0, "", 46, 499, 20, 100, 12, "Total Faults:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "15", "4", "RsLabel", 0, "", 214, 37, 20, 76, 13, "Sides:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "16", "4", "RsLabel", 0, "", 14, 37, 20, 76, 14, "Model:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "17", "4", "RsTextbox", 0, "Model", 14, 119, 20, 238, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "18", "4", "RsTextbox", 0, "Sides", 214, 119, 26, 160, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "19", "4", "RsTextbox", 0, "Gap_Design", 188, 119, 26, 160, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "20", "4", "RsTextbox", 0, "Speed_Max_RPM", 156, 119, 26, 160, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "21", "4", "RsLabel", 0, "", 38, 37, 20, 76, 19, "Divert Angle:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "22", "4", "RsTextbox", 0, "Divert_Angle", 38, 119, 20, 160, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "23", "4", "RsTextbox", 0, "Rate_Max_Formatted", 97, 360, 26, 160, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "24", "4", "RsLabel", 0, "", 89, 37, 20, 76, 22, "Required Gap:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "25", "4", "RsTextbox", 0, "Gap_Min_IN", 89, 119, 26, 160, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "26", "4", "RsCheckbox", 0, "Shoe_Set", 46, 360, 18, 75, 24, "Shoe Set", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "27", "4", "RsLabel", 0, "", 62, 6, 20, 107, 25, "Sorter Configuration:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "28", "4", "RsTextbox", 0, "Sides", 62, 119, 26, 160, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "29", "2", "RsGroupBox", 0, "", 533, 16, 101, 445, 27, "Carton Size Limits", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "30", "29", "RsComboBox", 0, "BoxSize_Weight_Max_User_UOM", 71, 359, 24, 52, 28, "", 4, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "31", "29", "RsComboBox", 0, "BoxSize_Weight_Min_User_UOM", 41, 359, 24, 52, 29, "", 4, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "32", "29", "RsComboBox", 0, "BoxSize_Width_Max_User_UOM", 42, 243, 24, 52, 30, "", 4, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "33", "29", "RsComboBox", 0, "BoxSize_Length_Min_User_UOM", 42, 121, 24, 52, 31, "", 4, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "34", "29", "RsComboBox", 0, "BoxSize_Width_Min_User_UOM", 72, 243, 24, 52, 32, "", 4, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "35", "29", "RsComboBox", 0, "BoxSize_Length_Max_User_UOM", 72, 121, 24, 52, 33, "", 4, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "36", "29", "RsLabel", 0, "", 71, 11, 20, 50, 34, "Max", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "37", "29", "RsTextbox", 0, "BoxSize_Length_Max_User", 71, 67, 26, 52, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "38", "29", "RsTextbox", 0, "BoxSize_Width_Max_User", 71, 185, 26, 52, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "39", "29", "RsTextbox", 0, "BoxSize_Weight_Max_User", 71, 301, 26, 52, 37, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "40", "29", "RsLabel", 0, "", 18, 317, 20, 80, 38, "Weight", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "41", "29", "RsLabel", 0, "", 18, 185, 20, 80, 39, "Width", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "42", "29", "RsLabel", 0, "", 42, 11, 20, 50, 40, "Min", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "43", "29", "RsLabel", 0, "", 18, 71, 20, 80, 41, "Length", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "44", "29", "RsTextbox", 0, "BoxSize_Length_Min_User", 42, 67, 26, 52, 42, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "45", "29", "RsTextbox", 0, "BoxSize_Weight_Min_User", 42, 185, 26, 52, 43, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "46", "29", "RsTextbox", 0, "BoxSize_Weight_Min_User", 42, 301, 26, 52, 44, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 442, "47", "2", "RsGroupBox", 0, "", 327, 16, 268, 673, 45, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "48", "47", "RsComboBox", 0, "Sorter_Selected_Width_IN", 19, 99, 24, 154, 46, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "49", "47", "RsLabel", 0, "", 19, 39, 20, 54, 47, "Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "50", "47", "RsLabel", 0, "", 85, 13, 20, 80, 48, "Gap Tolerance:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "51", "47", "RsLabel", 0, "", 49, 305, 20, 185, 49, "After Sort Spur Orientation:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "52", "47", "RsLabel", 0, "", 81, 305, 20, 185, 50, "After Sort Spur Orientation:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "53", "47", "RsLabel", 0, "", 111, 319, 20, 171, 51, "Reccomended After Sort Speed:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "54", "47", "RsLabel", 0, "", 196, 288, 20, 199, 52, "Theoretical Minimum Sorter Speed:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "55", "47", "RsLabel", 0, "", 236, 288, 20, 199, 53, "Closest Standard IntelliSort Speed:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "56", "47", "RsLabel", 0, "", 216, 288, 20, 199, 54, "Recommended Min Speed", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "57", "47", "RsLabel", 0, "", 164, 291, 20, 199, 55, "Theoretical Minimum Induct Speed Ratio:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "58", "47", "RsLabel", 0, "", 19, 343, 20, 147, 56, "After Sort Spur Type:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "59", "47", "RsLabel", 0, "", 117, 13, 20, 80, 57, "Gap Control:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "60", "47", "RsLabel", 0, "", 49, 13, 20, 80, 58, "Sorter Speed:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "61", "47", "RsLabel", 0, "", 111, 554, 20, 53, 59, "ft/min", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "62", "47", "RsLabel", 0, "", 196, 551, 20, 53, 60, "ft/min", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "63", "47", "RsLabel", 0, "", 236, 551, 20, 53, 61, "ft/min", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "64", "47", "RsLabel", 0, "", 216, 551, 20, 53, 62, "ft/min", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "65", "47", "RsLabel", 0, "", 164, 554, 20, 53, 63, "ft/min", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "66", "47", "RsTextbox", 0, "Chosen_Sort_Speed_User", 49, 99, 26, 52, 64, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "67", "47", "RsComboBox", 0, "Chosen_Sort_Speed_User_UOM", 49, 157, 24, 52, 65, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "68", "47", "RsComboBox", 0, "Gap_Tolerance", 81, 99, 24, 144, 66, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "69", "47", "RsComboBox", 0, "Spur_After_Sort_Orientation", 45, 496, 24, 144, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "70", "47", "RsComboBox", 0, "Gap_Control_Method", 113, 99, 24, 144, 68, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "71", "47", "RsComboBox", 0, "Spur_After_Sort_Type", 15, 496, 24, 144, 69, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "72", "47", "RsCheckbox", 0, "Decouple_Merge_From_Sorter", 143, 99, 18, 178, 70, "Decouple_Merge_From_Sorter", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "73", "47", "RsComboBox", 0, "Spur_After_Sort_Exit_Dist_User_UOM", 77, 554, 24, 52, 71, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "74", "47", "RsTextbox", 0, "Speed_After_Sort_Recd_FPM", 107, 496, 26, 52, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "75", "47", "RsTextbox", 0, "Spur_After_Sort_Exit_Dist_User", 78, 496, 26, 52, 73, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "76", "47", "RsTextbox", 0, "Speed_Induct_Theoretic_Ratio_Min", 160, 496, 24, 52, 74, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "77", "47", "RsTextbox", 0, "Speed_Sorter_Theoretic_Min_FPM", 190, 496, 26, 52, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "78", "47", "RsTextbox", 0, "Speed_Sorter_Reccomended_Min_FPM", 210, 496, 26, 52, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "79", "47", "RsTextbox", 0, "Speed_Intellisort_Closest_Std_FPM", 230, 496, 26, 52, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "80", "1", "RsTabPage", 0, "", 0, 0, 550, 823, 0, "Valid Candidates", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 442, "81", "80", "RsSubForm", 0, "", 375, 19, 138, 816, 78, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,356,Selected_Sorter")
        oProcessStep.AddCustomLayout(1, 442, "82", "80", "RsGrid", 0, "", 25, 19, 308, 822, 79, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,220,Valid_Sorter_Candidates;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 442, "83", "82", "RsGridColumn", 0, "Sorter_Type", 0, 0, 0, 100, 0, "Sorter Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "84", "82", "RsGridColumn", 0, "Model", 0, 0, 0, 225, 0, "Model", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "85", "82", "RsGridColumn", 0, "Speed_Max_RPM", 0, 0, 0, 100, 0, "Max Speed", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "86", "82", "RsGridColumn", 0, "Gap_Min_IN", 0, 0, 0, 100, 0, "Gap Min IN", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "87", "82", "RsGridColumn", 0, "Rate_Max_Formatted", 0, 0, 0, 75, 0, "Max Rate", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "88", "82", "RsGridColumn", 0, "Sides", 0, 0, 0, 50, 0, "Sides", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "89", "82", "RsGridColumn", 0, "Shoe_Set", 0, 0, 0, 50, 0, "Shoe Set", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "90", "82", "RsGridColumn", 0, "Faults_Total", 0, 0, 0, 85, 0, "Faults", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "91", "1", "RsTabPage", 0, "", 0, 0, 550, 823, 0, "All Candidates", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 442, "92", "91", "RsGrid", 0, "", 25, 3, 352, 838, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,355,Sorter_Candidates;ShowFilter:False;ShowGroups:False;RowIcon:Grid_Icon;RowIconSize:20,20;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 442, "93", "92", "RsGridColumn", 0, "Sorter_Type", 0, 0, 0, 100, 0, "Sorter Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "94", "92", "RsGridColumn", 0, "Model", 0, 0, 0, 225, 0, "Model", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "95", "92", "RsGridColumn", 0, "Speed_Max_RPM", 0, 0, 0, 75, 0, "Max Speed", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "96", "92", "RsGridColumn", 0, "Gap_Min_IN", 0, 0, 0, 100, 0, "Gap Min IN", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "97", "92", "RsGridColumn", 0, "Rate_Max_Formatted", 0, 0, 0, 75, 0, "Max Rate", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "98", "92", "RsGridColumn", 0, "Sides", 0, 0, 0, 50, 0, "Sides", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "99", "92", "RsGridColumn", 0, "Shoe_Set", 0, 0, 0, 50, 0, "Shoe Set", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "100", "92", "RsGridColumn", 0, "Faults_Total", 0, 0, 0, 60, 0, "Faults", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 442, "101", "91", "RsSubForm", 0, "", 407, 25, 154, 816, 81, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,355,Sorter_Candidates")
        oProcessStep.AddCustomLayout(1, 442, "102", "101", "RsLabel", 0, "", 78, 34, 20, 80, 82, "Weight", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "103", "101", "RsLabel", 0, "", 7, 178, 20, 52, 83, "Max", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "104", "101", "RsLabel", 0, "", 7, 120, 20, 52, 84, "Min", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "105", "101", "RsLabel", 0, "", 72, 262, 20, 80, 85, "Temp", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "106", "101", "RsLabel", 0, "", 50, 262, 20, 80, 86, "Sides", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "107", "101", "RsLabel", 0, "", 56, 34, 20, 80, 87, "Width", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "108", "101", "RsTextbox", 0, "Faults_Width_Max", 56, 178, 26, 52, 88, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "109", "101", "RsTextbox", 0, "Faults_Sides", 50, 348, 26, 52, 89, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "110", "101", "RsTextbox", 0, "Faults_Weight_Min", 56, 120, 26, 52, 90, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "111", "101", "RsLabel", 0, "", 21, 262, 20, 80, 91, "Rate", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "112", "101", "RsLabel", 0, "", 27, 34, 20, 80, 92, "Length", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "113", "101", "RsTextbox", 0, "Faults_Rate", 21, 348, 26, 52, 93, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "114", "101", "RsTextbox", 0, "Faults_Length_Max", 27, 178, 26, 52, 94, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "115", "101", "RsTextbox", 0, "Faults_Length_Min", 27, 120, 26, 52, 95, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "116", "101", "RsTextbox", 0, "Faults_Temp_Min_Operating_Min", 72, 348, 26, 52, 96, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "117", "101", "RsTextbox", 0, "Faults_Weight_Max", 78, 178, 26, 52, 97, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "118", "101", "RsTextbox", 0, "Faults_Weight_Min", 78, 120, 26, 52, 98, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "119", "91", "RsLabel", 0, "", 390, 28, 24, 120, 99, "Faults / Disqualifications", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "120", "0", "RsLabel", 0, "", -1, 6, 30, 298, 100, "Sortation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 442, "121", "0", "RsGroupBox", 0, "", 356, 863, 322, 656, 101, "Errors &amp;amp; Warnings", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "122", "121", "RsTextbox", 0, "Valid_Message", 19, 16, 283, 626, 102, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.12;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 442, "123", "0", "RsGroupBox", 0, "", 32, 10, 38, 834, 103, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "124", "123", "RsComboBox", 0, "Chosen_Sorter_ID", 8, 79, 24, 391, 104, "", 4, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 442, "125", "123", "RsLabel", 0, "", 8, 8, 20, 65, 105, "Sorter Type:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Induction()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(118, "Induction", "Induction", 106, 51, 1, 8, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.App_Calc/CAE_App_Calc.Induction/CAE_APC_Induction")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 448, "1", "0", "RsGroupBox", 0, "", 40, 504, 440, 510, 0, "Scale Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "2", "1", "RsTextbox", 0, "Rate_Theoretic_Max_w_Active_Gapping_Avg_Len_CPM", 414, 338, 22, 156, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "3", "1", "RsTextbox", 0, "Scale_Speed_Final_FPM", 131, 338, 22, 156, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "4", "1", "RsTextbox", 0, "Rate_Theoretic_Max_BlowThru_at_Avg_Length_CPM", 388, 338, 22, 156, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "5", "1", "RsLabel", 0, "", 77, 32, 22, 300, 4, "Scale Bed Length:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "6", "1", "RsTextbox", 0, "Scale_Speed_Override_FPM", 103, 338, 22, 156, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "7", "1", "RsTextbox", 0, "Spacing_Type_Required", 159, 338, 22, 156, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "8", "1", "RsCheckbox", 0, "Induction_Scale_Exists", 19, 338, 14, 25, 7, "", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "9", "1", "RsLabel", 0, "", 390, 32, 22, 300, 8, "Max Theoretical Blow-Thru Rate @ Avg Length (CPM):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "10", "1", "RsTextbox", 0, "Scale_Gap_Multi_Stage_Override_IN", 187, 338, 22, 156, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "11", "1", "RsLabel", 0, "", 105, 32, 22, 300, 10, "Scale Speed Override (FPM):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "12", "1", "RsComboBox", 0, "Induction_Scale_Type", 47, 338, 22, 156, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "13", "1", "RsTextbox", 0, "Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN", 323, 338, 22, 156, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "14", "1", "RsLabel", 0, "", 299, 32, 22, 300, 13, "Min. Gap on Avg. Box (Inches - for Active Gapping Only):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "15", "1", "RsLabel", 0, "", 325, 32, 22, 300, 14, "Scanner Min. Xmit Point Downstream of Scan Window :", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "16", "1", "RsTextbox", 0, "Head_to_Head_Min_IN", 213, 338, 22, 156, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "17", "1", "RsTextbox", 0, "Gap_Min_on_Box_Size_IN", 269, 338, 22, 156, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "18", "1", "RsTextbox", 0, "Gap_Min_on_Avg_Box_Size_IN", 297, 338, 22, 156, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "19", "1", "RsLabel", 0, "", 49, 32, 22, 300, 18, "Scale Type:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "20", "1", "RsTextbox", 0, "Speed_Ratio_Theoretic_Reqd_for_BlowThru", 360, 338, 22, 156, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "21", "1", "RsLabel", 0, "", 362, 32, 22, 300, 20, "Theoretical Speed Ratio Req. for Blow-Thru:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "22", "1", "RsLabel", 0, "", 21, 32, 22, 300, 21, "Induction Scaled Present:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "23", "1", "RsLabel", 0, "", 271, 32, 22, 300, 22, "Min. Gap on Min. Box (Inches - for Passive Gapping Only):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "24", "1", "RsLabel", 0, "", 416, 6, 22, 326, 23, "Max Theoretical Rate With Active Gapping @ Avg Length (CPM):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "25", "1", "RsTextbox", 0, "Carton_Length_Scanned_Max_Pcnt", 241, 338, 22, 156, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "26", "1", "RsLabel", 0, "", 189, 32, 22, 300, 25, "Scale Gap Override (Multi-Stage Scales Only):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "27", "1", "RsLabel", 0, "", 215, 32, 22, 300, 26, "Min. Head-to-Head (Inches):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "28", "1", "RsTextbox", 0, "Scale_Bed_Length_IN", 75, 338, 22, 156, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "29", "1", "RsLabel", 0, "", 133, 32, 22, 300, 28, "Scale Speed :", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "30", "1", "RsLabel", 0, "", 161, 32, 22, 300, 29, "Type of Spacing Required:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "31", "1", "RsLabel", 0, "", 243, 32, 22, 300, 30, "% of Maximum Carton Length Scanned (L.E. Xmit Mode Only):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "32", "0", "RsGroupBox", 0, "", 40, 6, 390, 492, 31, "Carton Scanning Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "33", "32", "RsTextbox", 0, "Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN", 351, 312, 22, 156, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "34", "32", "RsComboBox", 0, "Scanner_Configuration_Name", 19, 312, 22, 156, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "35", "32", "RsTextbox", 0, "Carton_Panels_Scanned_Qty", 47, 312, 22, 156, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "36", "32", "RsComboBox", 0, "Scanner_Data_Transmit_Mode", 241, 312, 22, 156, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "37", "32", "RsLabel", 0, "", 213, 74, 22, 232, 36, "Scan Window Length Required (Linear Inches):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "38", "32", "RsLabel", 0, "", 325, 24, 22, 282, 37, "Maximum Linear Length of Carton Scanned:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "39", "32", "RsLabel", 0, "", 351, 24, 22, 282, 38, "Scanner Min. Xmit Point Downstream of Scan Window :", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "40", "32", "RsTextbox", 0, "Carton_Maximum_Linear_Length_Scanned_In", 325, 312, 22, 156, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "41", "32", "RsLabel", 0, "", 131, 190, 22, 116, 40, "Shadowing Potential :", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "42", "32", "RsLabel", 0, "", 19, 92, 22, 214, 41, "Select Pre-defined Scanner Configuration :", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "43", "32", "RsLabel", 0, "", 47, 112, 22, 194, 42, "Number of Carton Panels Scanned:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "44", "32", "RsCheckbox", 0, "ShadowingPotential", 131, 312, 14, 25, 43, "", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "45", "32", "RsTextbox", 0, "ReadWindowSize_IN", 213, 312, 22, 156, 44, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "46", "32", "RsLabel", 0, "", 241, 112, 22, 194, 45, "Scanner Data Transmit Mode:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "47", "32", "RsTextbox", 0, "Label_Orientation", 75, 312, 22, 156, 46, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "48", "32", "RsTextbox", 0, "Gap_Min_on_Avg_Box_Size_IN", 187, 312, 22, 156, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "49", "32", "RsLabel", 0, "", 75, 190, 22, 116, 48, "Label Orientation :", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "50", "32", "RsTextbox", 0, "Tracking_Photocell_Dist_From_Scanner_Xmit_Pnt_IN", 297, 312, 22, 156, 49, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "51", "32", "RsLabel", 0, "", 103, 190, 22, 116, 50, "Carton Presentation:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "52", "32", "RsTextbox", 0, "Carton_Presentation", 103, 312, 22, 156, 51, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "53", "32", "RsLabel", 0, "", 297, 24, 22, 282, 52, "Tracking Photocell Distance From Scanner Xmit Point:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "54", "32", "RsLabel", 0, "", 269, 6, 21, 300, 53, "% of Maximum Carton Length Scanned (L.E. Xmit Mode Only):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "55", "32", "RsTextbox", 0, "ShadowingStatus", 159, 312, 22, 156, 54, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "56", "32", "RsTextbox", 0, "Carton_Length_Scanned_Max_Pcnt", 269, 312, 22, 156, 55, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "57", "32", "RsLabel", 0, "", 159, 190, 22, 116, 56, "Shadowing Allowed:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "58", "32", "RsLabel", 0, "", 187, 112, 22, 194, 57, "Minimum Gap for this Scan Application:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "59", "0", "RsGroupBox", 0, "", 439, 6, 104, 492, 58, "Carton Routing Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "60", "59", "RsLabel", 0, "", 19, 92, 22, 214, 59, "Induction Routing Method?", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "61", "59", "RsComboBox", 0, "Induction_Routing_Method", 19, 312, 22, 156, 60, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "62", "59", "RsLabel", 0, "", 47, 112, 22, 194, 61, "Max Host Resp.Time (Secs):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "63", "59", "RsTextbox", 0, "Host_Response_Max_Time_Sec", 47, 312, 22, 156, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "64", "59", "RsTextbox", 0, "Local_LookupTime_Max_Sec", 75, 312, 22, 156, 63, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "65", "59", "RsLabel", 0, "", 75, 148, 22, 158, 64, "Max. Local LookupTime (Secs):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "66", "0", "RsGroupBox", 0, "", 549, 6, 268, 492, 65, "Conveyor Requirements", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "67", "66", "RsLabel", 0, "", 234, 24, 22, 282, 66, "Max. Allowable Carton Length:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "68", "66", "RsComboBox", 0, "Carton_Alignment_on_Belt_Curve", 68, 312, 22, 156, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "69", "66", "RsTextbox", 0, "Belt_Curve_Centerline_Radius_IN", 150, 312, 22, 156, 68, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "70", "66", "RsLabel", 0, "", 150, 74, 22, 232, 69, "Centerline Radius of Belt Curve:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "71", "66", "RsLabel", 0, "", 68, 112, 22, 194, 70, "Carton Alignment on Belt Curve?", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "72", "66", "RsLabel", 0, "", 46, 92, 22, 214, 71, "Induction Belt Curve Exist?:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "73", "66", "RsCheckbox", 0, "Induction_Belt_Curve_Exists", 46, 312, 14, 25, 72, "", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "74", "66", "RsTextbox", 0, "Gap_Scan_Application_Min_IN", 124, 312, 22, 156, 73, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "75", "66", "RsTextbox", 0, "Carton_Length_Max_Allowable_IN", 234, 312, 22, 156, 74, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "76", "66", "RsTextbox", 0, "Resulting_Centerline_Speed_of_Curve_FPM", 206, 312, 22, 156, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "77", "66", "RsLabel", 0, "", 19, 112, 22, 194, 76, "Estimated Induct Belt Length Required:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "78", "66", "RsLabel", 0, "", 206, 24, 22, 282, 77, "Resulting Centerline Speed of Curve:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "79", "66", "RsTextbox", 0, "Radius_Value_Used_for_Speed_Match_IN", 178, 312, 22, 156, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "80", "66", "RsTextbox", 0, "Induct_Belt_Length_Reqd_Estimated_IN", 19, 312, 22, 156, 79, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "81", "66", "RsLabel", 0, "", 96, 112, 22, 194, 80, "Min. Inside Radius for Belt Curve:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "82", "66", "RsLabel", 0, "", 178, 6, 21, 300, 81, "Radius Value Used for Speed Match:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "83", "66", "RsTextbox", 0, "Belt_Curve_Inside_Radius_Min_IN", 96, 312, 22, 156, 82, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "84", "66", "RsLabel", 0, "", 124, 112, 22, 194, 83, "Minimum Gap for this Scan Application:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "85", "0", "RsLabel", 0, "", 9, 12, 22, 524, 84, "Induction", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "86", "0", "RsGroupBox", 0, "", 486, 502, 331, 512, 85, "Errors and Warnings", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "87", "86", "RsTextbox", 0, "Valid_Message", 36, 13, 283, 481, 86, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "88", "86", "RsCheckbox", 0, "Valid", 12, 415, 18, 54, 87, "Valid", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Scanner_Configurations()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(104, "Scanner Configurations", "", 106, 51, 1, 9, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.App_Calc/CAE_App_Calc")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 411, "1", "0", "RsLabel", 0, "", 9, 28, 33, 294, 0, "Scanner Configuration", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "2", "0", "RsGrid", 0, "", 45, 28, 120, 900, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,335,Scan_Configurations;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 411, "3", "2", "RsGridColumn", 0, "Configuration_Name", 0, 0, 0, 120, 0, "Configuration_Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "4", "2", "RsGridColumn", 0, "AppType", 0, 0, 0, 100, 0, "AppType", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "5", "0", "RsSubForm", 0, "", 226, 12, 661, 1376, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,335,Scan_Configurations")
        oProcessStep.AddCustomLayout(1, 411, "6", "5", "RsGroupBox", 0, "", 12, 16, 427, 385, 3, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "7", "6", "RsTextbox", 0, "MinGapForScan_IN", 66, 202, 20, 78, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 411, "8", "6", "RsLabel", 0, "", 265, 60, 18, 136, 5, "Minimum Gap Required:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "9", "6", "RsComboBox", 0, "GapControlMethod", 36, 202, 24, 153, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "10", "6", "RsLabel", 0, "", 212, 60, 18, 136, 7, "Primary Application Type:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "11", "6", "RsLabel", 0, "", 322, 297, 18, 31, 8, "In", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "12", "6", "RsComboBox", 0, "Tool_Status", 10, 202, 24, 153, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "13", "6", "RsLabel", 0, "", 36, 6, 22, 190, 10, "Gap Control (From Soratation):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "14", "6", "RsLabel", 0, "", 12, 6, 22, 190, 11, "Status:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "15", "6", "RsTextbox", 0, "BoxPanelsScanned", 186, 202, 20, 148, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 411, "16", "6", "RsCheckbox", 0, "ShadowingPotential", 108, 202, 18, 125, 13, "Shadowing Possible", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "17", "6", "RsLabel", 0, "", 186, 88, 18, 108, 14, "Qty Panels Scanned:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "18", "6", "RsCheckbox", 0, "UsePandAMTBH", 88, 202, 18, 114, 15, "Use PandA MTBH", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "19", "6", "RsLabel", 0, "", 347, 60, 18, 136, 16, "Vendor Read Window Size", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "20", "6", "RsComboBox", 0, "CartonPresentation", 162, 202, 24, 153, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "21", "6", "RsComboBox", 0, "ShadowingStatus", 136, 202, 24, 153, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "22", "6", "RsComboBox", 0, "User_UOM_System", 238, 202, 24, 153, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "23", "6", "RsLabel", 0, "", 66, 296, 18, 30, 20, "IN", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "24", "6", "RsTextbox", 0, "AppType", 212, 202, 20, 148, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 411, "25", "6", "RsLabel", 0, "", 162, 82, 18, 114, 22, "Carton Presentation:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "26", "6", "RsTextbox", 0, "MinGapRequired_IN", 265, 202, 20, 88, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 411, "27", "6", "RsLabel", 0, "", 136, 82, 18, 114, 24, "Shadowing Allowed?", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "28", "6", "RsTextbox", 0, "MinGapOverride_Vendor_Provider_IN", 293, 202, 20, 88, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 411, "29", "6", "RsLabel", 0, "", 66, 40, 18, 156, 26, "Min Gap Allowed:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "30", "6", "RsLabel", 0, "", 293, 6, 18, 190, 27, "Min Gap Required (Vendor) Overide:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "31", "6", "RsTextbox", 0, "ReadWindowSize_Vendor_Supplied_IN", 347, 202, 20, 88, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 411, "32", "6", "RsTextbox", 0, "ReadWindowSize_IN", 320, 202, 20, 88, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 411, "33", "6", "RsLabel", 0, "", 320, 20, 18, 176, 30, "Read Window Size (Estimated):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "34", "6", "RsLabel", 0, "", 238, 54, 18, 142, 31, "System (Global Setup):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "35", "6", "RsLabel", 0, "", 293, 296, 18, 31, 32, "In", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "36", "6", "RsLabel", 0, "", 347, 297, 18, 31, 33, "In", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "37", "6", "RsLabel", 0, "", 265, 296, 18, 31, 34, "In", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 411, "38", "5", "RsGroupBox", 0, "", 445, 16, 205, 920, 35, "Panel Configuration", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 411, "39", "38", "RsGrid", 0, "", 19, 6, 181, 910, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,333,Panel_Configs;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 411, "40", "39", "RsGridColumn", 0, "Panel_ID", 0, 0, 0, 65, 0, "Panel_ID", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "41", "39", "RsGridColumn", 0, "Is_Scanned", 0, 0, 0, 75, 0, "Is_Scanned", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "42", "39", "RsGridColumn", 0, "Scanner_Selected", 0, 0, 0, 125, 0, "Scanner_Selected", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "43", "39", "RsGridColumn", 0, "Scan_Type", 0, 0, 0, 75, 0, "Scan_Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "44", "39", "RsGridColumn", 0, "Scanner_CCD_Position", 0, 0, 0, 130, 0, "Scanner_CCD_Position", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "45", "39", "RsGridColumn", 0, "Scan_Angle_Degrees", 0, 0, 0, 110, 0, "Scan Angle Degrees", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "46", "39", "RsGridColumn", 0, "Scan_Head_Location", 0, 0, 0, 120, 0, "Scan Head Location", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "47", "39", "RsGridColumn", 0, "Product_Spacing_Category", 0, 0, 0, 100, 0, "Spacing Category", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "48", "39", "RsGridColumn", 0, "Min_Gap_Required", 0, 0, 0, 85, 0, "Min_Gap_Reqd", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 411, "49", "5", "RsPictureBox", 0, "ScannerConfig_Image", 19, 422, 420, 595, 37, "", 0, 0, 0, 5, 0, "", "", "Filename:;IsGeneratedImg:False;RsTooltip:;")
        oProcessStep.AddCustomLayout(1, 411, "50", "0", "RsAddDeleteCopy", 0, "", 182, 704, 38, 224, 38, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,335,Scan_Configurations;CanDelete:;AddPrompt:False;ShowCopy:True")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Print_And_Apply()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(79, "Print And Apply", "", 106, 51, 1, 10, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.App_Calc/CAE_App_Calc.Print_And_Apply/CAE_App_Calc_Print_And_Apply")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 416, "1", "0", "RsGroupBox", 0, "", 96, 12, 49, 182, 0, "Global Units", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "2", "1", "RsLabel", 0, "", 16, 12, 21, 39, 1, "Units:", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "3", "1", "RsComboBox", 0, "User_UOM_System", 16, 68, 22, 108, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "4", "0", "RsLabel", 0, "", 12, 12, 46, 448, 3, "Belted PandA Application Calculator", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "5", "0", "RsTabControl", 0, "", 164, 12, 708, 1394, 4, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 416, "6", "5", "RsTabPage", 0, "", 0, 0, 678, 1386, 0, "Intro", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 416, "7", "6", "RsLabel", 0, "UI_Summary", 11, 3, 419, 1052, 5, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "8", "5", "RsTabPage", 0, "", 0, 0, 678, 1386, 0, "Belted PandA", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 416, "9", "8", "RsTabControl", 0, "", 3, 3, 674, 817, 6, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 416, "10", "9", "RsTabPage", 0, "", 0, 0, 644, 809, 0, "General", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 416, "11", "10", "RsGroupBox", 0, "", 3, 3, 357, 437, 7, "General Application Specific Selections", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "12", "11", "RsLabel", 0, "", 299, 6, 21, 219, 8, "B/M Belt Input Speed", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "13", "11", "RsComboBox", 0, "Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM", 242, 285, 22, 76, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "14", "11", "RsLabel", 0, "", 243, 6, 21, 219, 10, "B/M Belt Gap Required to Stop (Min. Carton)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "15", "11", "RsTextbox", 0, "Gen_BM_Belt_Acc_Dec_Rate_User", 186, 231, 22, 48, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "16", "11", "RsLabel", 0, "", 215, 6, 21, 219, 12, "Pre-PandA Accumulation Conveyor Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "17", "11", "RsComboBox", 0, "Gen_MDR_Min_Gap_Throughput_Limit_User_UOM", 326, 285, 22, 76, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "18", "11", "RsTextbox", 0, "Gen_BM_Belt_PTO_Ratio", 270, 231, 22, 48, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "19", "11", "RsLabel", 0, "", 187, 6, 21, 219, 15, "B/M Belt Acc/Dec Rate", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "20", "11", "RsTextbox", 0, "Gen_MDR_Min_Gap_Throughput_Limit_User", 326, 231, 22, 48, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "21", "11", "RsTextbox", 0, "Gen_BM_Belt_Input_Speed_User", 298, 231, 22, 48, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "22", "11", "RsLabel", 0, "", 327, 6, 21, 219, 18, "Min Gap Throughout Limit (MDR Spacing)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "23", "11", "RsComboBox", 0, "Gen_BM_Belt_Input_Speed_User_UOM", 298, 285, 22, 76, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "24", "11", "RsLabel", 0, "", 159, 6, 21, 219, 20, "Carton Spacing Conveyor Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "25", "11", "RsLabel", 0, "", 271, 6, 21, 219, 21, "Spacing B/M Belt PTO Ratio", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "26", "11", "RsLabel", 0, "", 131, 6, 21, 219, 22, "Pre-PandA Accumulation Zone Length", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "27", "11", "RsTextbox", 0, "Gen_BM_Belt_Gap_Stop_Min_Carton_User", 242, 231, 22, 48, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "28", "11", "RsComboBox", 0, "Gen_Accumulation_Convey_Type_Pre_Panda", 214, 231, 22, 130, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "29", "11", "RsLabel", 0, "", 47, 6, 21, 219, 25, "Choose Applicator Belt Speed", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "30", "11", "RsComboBox", 0, "Gen_BM_Belt_Acc_Dec_Rate_User_UOM", 186, 285, 22, 76, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "31", "11", "RsComboBox", 0, "Gen_Conveyor_Type", 158, 231, 22, 130, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "32", "11", "RsComboBox", 0, "Gen_Conveyor_Width_User_UOM", 74, 285, 22, 76, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "33", "11", "RsLabel", 0, "", 103, 6, 21, 219, 29, "Pre-PandA Accumulation Zones", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "34", "11", "RsLabel", 0, "", 19, 6, 21, 219, 30, "Throughput Rate in CPM (Optional)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "35", "11", "RsTextbox", 0, "Gen_Accumulation_Zone_Length_User", 130, 231, 22, 48, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "36", "11", "RsComboBox", 0, "Gen_Accumulation_Zone_Length_User_UOM", 130, 285, 22, 76, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "37", "11", "RsComboBox", 0, "Gen_Belt_Speed_User_UOM", 47, 285, 22, 76, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "38", "11", "RsLabel", 0, "", 75, 6, 21, 219, 34, "Define Conveyor Width (B/F)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "39", "11", "RsTextbox", 0, "Gen_Accumulation_Zone_Quantity", 102, 231, 22, 48, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "40", "11", "RsTextbox", 0, "Gen_Conveyor_Width_User", 74, 231, 22, 48, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "41", "11", "RsTextbox", 0, "Gen_Belt_Speed_User", 46, 231, 22, 48, 37, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "42", "11", "RsTextbox", 0, "Gen_Throughput_Rate", 19, 231, 21, 48, 38, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "43", "9", "RsTabPage", 0, "", 0, 0, 644, 809, 0, "Local MTBH", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 416, "44", "43", "RsGroupBox", 0, "", 3, 3, 162, 584, 39, "Material To Be Handled", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "45", "44", "RsTextbox", 0, "MTBH_Width_Average_User", 131, 207, 22, 48, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "46", "44", "RsTextbox", 0, "MTBH_Length_Average_User", 131, 81, 22, 48, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "47", "44", "RsComboBox", 0, "MTBH_Height_Minimum_User_UOM", 75, 384, 22, 52, 42, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "48", "44", "RsTextbox", 0, "MTBH_Length_Maximum_User", 103, 81, 22, 48, 43, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "49", "44", "RsComboBox", 0, "MTBH_Width_Average_User_UOM", 131, 261, 22, 52, 44, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "50", "44", "RsComboBox", 0, "MTBH_Weight_Maximum_User_UOM", 103, 509, 22, 52, 45, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "51", "44", "RsComboBox", 0, "MTBH_Weight_Minimum_User_UOM", 75, 509, 22, 52, 46, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "52", "44", "RsComboBox", 0, "MTBH_Height_Maximum_User_UOM", 103, 384, 22, 52, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "53", "44", "RsTextbox", 0, "MTBH_Weight_Average_User", 131, 455, 22, 48, 48, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "54", "44", "RsTextbox", 0, "MTBH_Height_Average_User", 131, 330, 22, 48, 49, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "55", "44", "RsComboBox", 0, "MTBH_Weight_Average_User_UOM", 131, 509, 22, 52, 50, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "56", "44", "RsTextbox", 0, "MTBH_Weight_Minimum_User", 75, 455, 22, 48, 51, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "57", "44", "RsComboBox", 0, "MTBH_Width_Maximum_User_UOM", 103, 261, 22, 52, 52, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "58", "44", "RsComboBox", 0, "MTBH_Height_Average_User_UOM", 131, 384, 22, 52, 53, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "59", "44", "RsTextbox", 0, "MTBH_Weight_Maximum_User", 103, 455, 22, 48, 54, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "60", "44", "RsComboBox", 0, "MTBH_Length_Average_User_UOM", 131, 135, 22, 52, 55, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "61", "44", "RsComboBox", 0, "MTBH_Length_Maximum_User_UOM", 103, 135, 22, 52, 56, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "62", "44", "RsTextbox", 0, "MTBH_Height_Maximum_User", 103, 330, 22, 48, 57, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "63", "44", "RsTextbox", 0, "MTBH_Height_Minimum_User", 75, 330, 22, 48, 58, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "64", "44", "RsLabel", 0, "", 131, 6, 21, 69, 59, "Average", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "65", "44", "RsTextbox", 0, "MTBH_Width_Maximum_User", 103, 207, 22, 48, 60, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "66", "44", "RsComboBox", 0, "MTBH_Width_Minimum_User_UOM", 75, 261, 22, 52, 61, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "67", "44", "RsTextbox", 0, "MTBH_Width_Minimum_User", 75, 207, 22, 48, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "68", "44", "RsComboBox", 0, "MTBH_Length_Minimum_User_UOM", 75, 135, 22, 52, 63, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "69", "44", "RsTextbox", 0, "MTBH_Length_Minimum_User", 75, 81, 22, 48, 64, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "70", "44", "RsLabel", 0, "", 51, 455, 21, 69, 65, "Weight", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "71", "44", "RsLabel", 0, "", 51, 330, 21, 69, 66, "Height", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "72", "44", "RsLabel", 0, "", 75, 6, 21, 69, 67, "Minimum", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "73", "44", "RsLabel", 0, "", 51, 207, 21, 69, 68, "Width", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "74", "44", "RsLabel", 0, "", 51, 81, 21, 69, 69, "Length", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "75", "44", "RsComboBox", 0, "MTBH_Use_Local", 22, 81, 22, 73, 70, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "76", "44", "RsLabel", 0, "", 22, 6, 21, 69, 71, "Use Local?", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "77", "44", "RsLabel", 0, "", 103, 6, 21, 69, 72, "Maximum", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "78", "9", "RsTabPage", 0, "", 0, 0, 644, 809, 0, "Induction Scanning", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 416, "79", "78", "RsGroupBox", 0, "", 3, 3, 412, 375, 73, "Induction Scanning Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "80", "79", "RsLabel", 0, "", 271, 6, 21, 219, 74, "% of Max Carton Length Scanned (Xmit)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "81", "79", "RsComboBox", 0, "Ind_Scan_Label_Orientation", 74, 231, 22, 130, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "82", "79", "RsTextbox", 0, "Ind_Scan_Scan_Window_Length_Req_User", 214, 231, 22, 48, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "83", "79", "RsLabel", 0, "", 19, 6, 21, 219, 77, "Pre-defined Scanner Configuration", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "84", "79", "RsTextbox", 0, "Ind_Scan_Scan_App_Min_Gap_User", 186, 231, 22, 48, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "85", "79", "RsLabel", 0, "", 159, 6, 21, 219, 79, "Shadowing Allowed", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "86", "79", "RsTextbox", 0, "Ind_Scan_Carton_Panels_Scanned_Quantity", 46, 231, 22, 48, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "87", "79", "RsComboBox", 0, "Ind_Scan_Scanner_Min_Xmit_Point_User_UOM", 354, 285, 22, 76, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "88", "79", "RsComboBox", 0, "Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM", 326, 285, 22, 76, 82, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "89", "79", "RsLabel", 0, "", 103, 6, 21, 219, 83, "Carton Presentation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "90", "79", "RsTextbox", 0, "Ind_Scan_Scanner_Min_Xmit_Point_User", 354, 231, 22, 48, 84, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "91", "79", "RsComboBox", 0, "Ind_Scan_Tracking_Photocell_Distance_User_UOM", 298, 285, 22, 76, 85, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "92", "79", "RsLabel", 0, "", 355, 6, 29, 219, 86, "Scanner Min Xmit Point Downstream of Scan Window", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "93", "79", "RsTextbox", 0, "Ind_Scan_Carton_Scanned_Max_Lin_Length_User", 326, 231, 22, 48, 87, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "94", "79", "RsLabel", 0, "", 47, 6, 21, 219, 88, "Number of Carton Panels Scanned", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "95", "79", "RsLabel", 0, "", 327, 6, 21, 219, 89, "Max Linear Length of Carton Scanned", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "96", "79", "RsTextbox", 0, "Ind_Scan_Carton_Percent_Max_Length_Scanned_User", 270, 231, 22, 48, 90, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "97", "79", "RsTextbox", 0, "Ind_Scan_Tracking_Photocell_Distance_User", 298, 231, 22, 48, 91, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "98", "79", "RsLabel", 0, "", 299, 6, 21, 219, 92, "Tracking Photocell Distance From Scanner Xmit Point", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "99", "79", "RsComboBox", 0, "Ind_Scan_Scanner_Data_Transmit_Mode", 242, 231, 22, 130, 93, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "100", "79", "RsLabel", 0, "", 243, 6, 21, 219, 94, "Scanner Data Transmit Mode", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "101", "79", "RsComboBox", 0, "Ind_Scan_Scanner_Config", 18, 231, 22, 130, 95, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "102", "79", "RsComboBox", 0, "Ind_Scan_Scan_Window_Length_Req_User_UOM", 214, 285, 22, 76, 96, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "103", "79", "RsComboBox", 0, "Ind_Scan_Scan_App_Min_Gap_User_UOM", 186, 285, 22, 76, 97, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "104", "79", "RsLabel", 0, "", 215, 6, 21, 219, 98, "Scan Window Length Required (Linear)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "105", "79", "RsComboBox", 0, "Ind_Scan_Shadowing_Allowed", 158, 231, 22, 130, 99, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "106", "79", "RsLabel", 0, "", 187, 6, 21, 219, 100, "Min Gap for this Scanning Application", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "107", "79", "RsComboBox", 0, "Ind_Scan_Carton_Presentation", 102, 231, 22, 130, 101, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "108", "79", "RsComboBox", 0, "Ind_Scan_Shadowing_Potential", 130, 231, 22, 130, 102, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "109", "79", "RsLabel", 0, "", 131, 6, 21, 219, 103, "Shadowing Potential", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "110", "79", "RsLabel", 0, "", 75, 6, 21, 219, 104, "Label Orientation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "111", "9", "RsTabPage", 0, "", 0, 0, 644, 809, 0, "Scale Details (Optional)", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 416, "112", "111", "RsGroupBox", 0, "", 3, 3, 248, 264, 105, "Scale Details (Optional)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "113", "112", "RsTextbox", 0, "Scale_Min_Gap_on_Max_Box_User", 215, 129, 22, 48, 106, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "114", "112", "RsTextbox", 0, "Scale_Min_Head_to_Head_User", 159, 129, 22, 48, 107, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "115", "112", "RsLabel", 0, "", 215, 6, 21, 117, 108, "Min Gap on Max Box", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "116", "112", "RsComboBox", 0, "Scale_Min_Gap_on_Max_Box_User_UOM", 215, 183, 22, 76, 109, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "117", "112", "RsComboBox", 0, "Scale_Scale_Bed_Length_User_UOM", 75, 183, 22, 76, 110, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "118", "112", "RsTextbox", 0, "Scale_Scale_Gap_Override_User", 131, 129, 22, 48, 111, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "119", "112", "RsComboBox", 0, "Scale_Min_Gap_on_Min_Box_User_UOM", 187, 183, 22, 76, 112, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "120", "112", "RsComboBox", 0, "Scale_Min_Head_to_Head_User_UOM", 159, 183, 22, 76, 113, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "121", "112", "RsTextbox", 0, "Scale_Min_Gap_on_Min_Box_User", 187, 129, 22, 48, 114, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "122", "112", "RsLabel", 0, "", 159, 6, 21, 117, 115, "Min Head-to-Head", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "123", "112", "RsLabel", 0, "", 187, 6, 21, 117, 116, "Min Gap on Min Box", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "124", "112", "RsComboBox", 0, "Scale_Scale_Gap_Override_User_UOM", 131, 183, 22, 76, 117, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "125", "112", "RsLabel", 0, "", 131, 6, 21, 117, 118, "Scale Gap Override", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "126", "112", "RsComboBox", 0, "Scale_Spacing_Type", 103, 129, 22, 130, 119, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "127", "112", "RsLabel", 0, "", 103, 6, 21, 117, 120, "Spacing Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "128", "112", "RsTextbox", 0, "Scale_Scale_Bed_Length_User", 75, 129, 22, 48, 121, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "129", "112", "RsLabel", 0, "", 75, 6, 21, 117, 122, "Scale Bed Length", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "130", "112", "RsLabel", 0, "", 47, 6, 21, 117, 123, "Scale Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "131", "112", "RsComboBox", 0, "Scale_Scale_Type", 47, 129, 22, 130, 124, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "132", "112", "RsLabel", 0, "", 19, 6, 21, 117, 125, "Scale Exists", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "133", "112", "RsComboBox", 0, "Scale_PandA_Scale_Required", 19, 129, 22, 130, 126, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "134", "9", "RsTabPage", 0, "", 0, 0, 644, 809, 0, "Printed Label Data Acq", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 416, "135", "134", "RsGroupBox", 0, "", 3, 3, 133, 375, 127, "Printed Label Data Acquisition Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "136", "135", "RsLabel", 0, "", 19, 6, 21, 219, 128, "Label Data Acquisition Method", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "137", "135", "RsTextbox", 0, "Acq_Label_Data_Acquisition_Travel_User", 102, 231, 22, 48, 129, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "138", "135", "RsTextbox", 0, "Acq_Max_Local_Lookup_Time_Secs", 74, 231, 22, 48, 130, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "139", "135", "RsLabel", 0, "", 75, 6, 21, 219, 131, "Max Local Lookup Time (secs)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "140", "135", "RsTextbox", 0, "Acq_Max_Host_Resp_Time_Secs", 46, 231, 22, 48, 132, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "141", "135", "RsLabel", 0, "", 47, 6, 21, 219, 133, "Max Host Response Time (secs)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "142", "135", "RsComboBox", 0, "Acq_Label_Data_Acquisition_Method", 18, 231, 22, 130, 134, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "143", "135", "RsComboBox", 0, "Acq_Label_Data_Acquisition_Travel_User_UOM", 102, 285, 22, 76, 135, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "144", "135", "RsLabel", 0, "", 103, 6, 21, 219, 136, "Label Data Acquisition Travel (in)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "145", "9", "RsTabPage", 0, "", 0, 0, 644, 809, 0, "Applicator", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 416, "146", "145", "RsGroupBox", 0, "", 10, 3, 638, 375, 137, "Pinter Applicator Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "147", "146", "RsComboBox", 0, "App_Min_H_to_H_Spacing_Avg_Carton_User_UOM", 606, 285, 22, 76, 138, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "148", "146", "RsComboBox", 0, "App_Min_Dist_Req_Data_Xmit_to_Tamp_Prepos_User_UOM", 522, 285, 22, 76, 139, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "149", "146", "RsComboBox", 0, "App_Min_H_to_H_Req_Compl_PandA_Cycle_User_UOM", 550, 285, 22, 76, 140, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "150", "146", "RsComboBox", 0, "App_Min_Gap_Req_Avg_to_Min_Box_Tamp_Clr_User_UOM", 578, 285, 22, 76, 141, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "151", "146", "RsLabel", 0, "", 439, 6, 21, 219, 142, "Max Tamp Stroke Req", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "152", "146", "RsTextbox", 0, "App_Min_H_to_H_Spacing_Avg_Carton_User", 606, 231, 22, 48, 143, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "153", "146", "RsLabel", 0, "", 551, 6, 21, 219, 144, "Min H-to-H Spacing Req for Complete Raw PandA Cycle", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "154", "146", "RsComboBox", 0, "App_Min_Gap_Req_Max_Min_Box_Tamp_Clr_User_UOM", 466, 285, 22, 76, 145, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "155", "146", "RsComboBox", 0, "App_Max_Tamp_Stroke_Req_User_UOM", 438, 285, 22, 76, 146, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "156", "146", "RsLabel", 0, "", 467, 6, 21, 219, 147, "Min Gap Req for Max to Min Box Tamp Clearance", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "157", "146", "RsTextbox", 0, "App_Min_H_to_H_Req_Compl_PandA_Cycle_User", 550, 231, 22, 48, 148, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "158", "146", "RsLabel", 0, "", 607, 6, 21, 219, 149, "Min H-to-H Spacing for Avg Carton", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "159", "146", "RsTextbox", 0, "App_Min_Gap_Req_Avg_to_Min_Box_Tamp_Clr_User", 578, 231, 22, 48, 150, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "160", "146", "RsLabel", 0, "", 579, 6, 21, 219, 151, "Min Gap Req for Avg to Min Box Tamp Clearance", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "161", "146", "RsComboBox", 0, "App_Tamp_Home_Height_Above_Conveyor_User_UOM", 410, 285, 22, 76, 152, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "162", "146", "RsComboBox", 0, "App_Min_H_to_H_Spacing_Largest_Carton_User_UOM", 494, 285, 22, 76, 153, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "163", "146", "RsTextbox", 0, "App_Min_Dist_Req_Data_Xmit_to_Tamp_Prepos_User", 522, 231, 22, 48, 154, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "164", "146", "RsLabel", 0, "", 523, 6, 21, 219, 155, "Min Distance Req from Data Xmit to Tamp Prepos", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "165", "146", "RsTextbox", 0, "App_Min_H_to_H_Spacing_Largest_Carton_User", 494, 231, 22, 48, 156, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "166", "146", "RsLabel", 0, "", 495, 6, 21, 219, 157, "Min H-to-H Spacing for Largest Carton", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "167", "146", "RsTextbox", 0, "App_Min_Gap_Req_Max_Min_Box_Tamp_Clr_User", 466, 231, 22, 48, 158, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "168", "146", "RsLabel", 0, "", 383, 6, 21, 219, 159, "Label Print Time (secs)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "169", "146", "RsTextbox", 0, "App_Max_Tamp_Stroke_Req_User", 438, 231, 22, 48, 160, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "170", "146", "RsTextbox", 0, "App_Return_Stroke_Tamp_Clearance_User", 298, 231, 22, 48, 161, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "171", "146", "RsTextbox", 0, "App_Tamp_Cycle_Time_Pneumatic_Side_Apply", 354, 231, 22, 48, 162, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "172", "146", "RsTextbox", 0, "App_Label_Print_Time", 382, 231, 22, 48, 163, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "173", "146", "RsTextbox", 0, "App_Tamp_Home_Height_Above_Conveyor_User", 410, 231, 22, 48, 164, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "174", "146", "RsLabel", 0, "", 411, 6, 21, 219, 165, "Tamp Home Height Above Conveyor (Top Apply Only)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "175", "146", "RsLabel", 0, "", 355, 6, 21, 219, 166, "Tamp Cycle Time for Pneumatic Side Apply (secs)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "176", "146", "RsComboBox", 0, "App_Min_Pitch_Btw_App_User_UOM", 326, 285, 22, 76, 167, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "177", "146", "RsComboBox", 0, "App_Return_Stroke_Tamp_Clearance_User_UOM", 298, 285, 22, 76, 168, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "178", "146", "RsTextbox", 0, "App_Min_Pitch_Btw_App_User", 326, 231, 22, 48, 169, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "179", "146", "RsLabel", 0, "", 327, 6, 21, 219, 170, "Min Pitch Between Applicators", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "180", "146", "RsComboBox", 0, "App_Down_Stroke_Tamp_Clearance_User_UOM", 270, 285, 22, 76, 171, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "181", "146", "RsLabel", 0, "", 299, 6, 21, 219, 172, "Return Stroke Tamp Clearance Margin", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "182", "146", "RsTextbox", 0, "App_Label_Applicator_Fixed_Printer_Overhead", 242, 231, 22, 48, 173, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "183", "146", "RsLabel", 0, "", 159, 6, 21, 219, 174, "Label Print Speed", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "184", "146", "RsTextbox", 0, "App_Down_Stroke_Tamp_Clearance_User", 270, 231, 22, 48, 175, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "185", "146", "RsLabel", 0, "", 271, 6, 21, 219, 176, "Down Stroke Tamp Clearance Margin + Preposition Dwell", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "186", "146", "RsLabel", 0, "", 243, 6, 21, 219, 177, "Fixed Printer Overhead (secs)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "187", "146", "RsComboBox", 0, "App_Label_Applicator_Tamp_Pad_Length_User_UOM", 186, 285, 22, 76, 178, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "188", "146", "RsComboBox", 0, "App_Label_Printed_Length_User_UOM", 130, 285, 22, 76, 179, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "189", "146", "RsTextbox", 0, "App_Label_Print_Speed_User", 158, 231, 22, 48, 180, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "190", "146", "RsLabel", 0, "", 215, 6, 21, 219, 181, "Applicator Tamp Brush Req", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "191", "146", "RsLabel", 0, "", 103, 6, 21, 219, 182, "Applicator Tamp Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "192", "146", "RsComboBox", 0, "App_Label_Applicator_Tamp_Brush_Required", 214, 231, 22, 130, 183, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "193", "146", "RsComboBox", 0, "App_Label_Print_Speed_User_UOM", 158, 285, 22, 76, 184, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "194", "146", "RsLabel", 0, "", 47, 6, 21, 219, 185, "Number of Applicators Req", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "195", "146", "RsTextbox", 0, "App_Label_Applicator_Tamp_Pad_Length_User", 186, 231, 22, 48, 186, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "196", "146", "RsLabel", 0, "", 19, 6, 21, 219, 187, "Label Applicator Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "197", "146", "RsLabel", 0, "", 187, 6, 21, 219, 188, "Applicator Tamp Pad Length", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "198", "146", "RsComboBox", 0, "App_Label_Applicator_Type_Tamp", 102, 231, 22, 130, 189, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "199", "146", "RsTextbox", 0, "App_Label_Printed_Length_User", 130, 231, 22, 48, 190, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "200", "146", "RsLabel", 0, "", 131, 6, 21, 219, 191, "Printed Label Length", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "201", "146", "RsLabel", 0, "", 75, 6, 21, 219, 192, "Reason for Multiple Applicators", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "202", "146", "RsTextbox", 0, "App_Label_Applicator_Quantity", 46, 231, 22, 48, 193, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "203", "146", "RsComboBox", 0, "App_Label_Applicator_Reason_For_Multiple", 74, 231, 22, 130, 194, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "204", "146", "RsComboBox", 0, "App_Label_Applicator_Type", 18, 231, 22, 130, 195, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "205", "9", "RsTabPage", 0, "", 0, 0, 644, 809, 0, "Verify Scanning", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 416, "206", "205", "RsGroupBox", 0, "", 3, 3, 446, 375, 196, "Pinter Applicator Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "207", "206", "RsLabel", 0, "", 299, 6, 21, 219, 197, "Scanner Data Transmit Mode", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "208", "206", "RsComboBox", 0, "Ver_Scan_Scanner_Data_Transmit_Mode", 298, 231, 22, 130, 198, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "209", "206", "RsComboBox", 0, "Ver_Scan_Max_Linear_Length_Carton_Scanned_User_UOM", 382, 285, 22, 76, 199, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "210", "206", "RsComboBox", 0, "Ver_Scan_Distance_Last_Tamp__Scan_Window_User_UOM", 270, 285, 22, 76, 200, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "211", "206", "RsTextbox", 0, "Ver_Scan_Max_Linear_Length_Carton_Scanned_User", 382, 231, 22, 48, 201, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "212", "206", "RsComboBox", 0, "Ver_Scan_Min_Xmit_Point_FromScan_Window_User_UOM", 410, 285, 22, 76, 202, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "213", "206", "RsTextbox", 0, "Ver_Scan_Min_Xmit_Point_FromScan_Window_User", 410, 231, 22, 48, 203, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "214", "206", "RsLabel", 0, "", 411, 6, 21, 219, 204, "Scanner Min Xmit Point Downstream of Scan Window", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "215", "206", "RsComboBox", 0, "Ver_Scan_Tracking_Photocell_Distance_User_UOM", 354, 285, 22, 76, 205, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "216", "206", "RsComboBox", 0, "Ver_Scan_Shadowing_Allowed", 186, 231, 22, 130, 206, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "217", "206", "RsTextbox", 0, "Ver_Scan_Scan_Window_Length_Req_User", 242, 231, 22, 48, 207, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "218", "206", "RsTextbox", 0, "Ver_Scan_Tracking_Photocell_Distance_User", 354, 231, 22, 48, 208, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "219", "206", "RsComboBox", 0, "Ver_Scan_Label_Orientation", 102, 231, 22, 130, 209, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "220", "206", "RsLabel", 0, "", 187, 6, 21, 219, 210, "Shadowing Allowed", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "221", "206", "RsLabel", 0, "", 327, 6, 21, 219, 211, "% of Max Carton Length Scanned (L.E. Xmit Mode Only)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "222", "206", "RsComboBox", 0, "Ver_Scan_Scan_Window_Length_Req_User_UOM", 242, 285, 22, 76, 212, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "223", "206", "RsTextbox", 0, "Ver_Scan_Percent_Max_Carton_Length_Scanned_User", 326, 231, 22, 48, 213, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "224", "206", "RsLabel", 0, "", 47, 6, 21, 219, 214, "Select Pre-defined Scanner Configuration", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "225", "206", "RsLabel", 0, "", 383, 6, 21, 219, 215, "Max Linear Length of Carton Scanned", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "226", "206", "RsTextbox", 0, "Ver_Scan_Distance_Last_Tamp__Scan_Window_User", 270, 231, 22, 48, 216, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "227", "206", "RsLabel", 0, "", 131, 6, 21, 219, 217, "Carton Presentation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "228", "206", "RsLabel", 0, "", 355, 6, 21, 219, 218, "Tracking Photocall Distance from Scanner Xmit Point", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "229", "206", "RsLabel", 0, "", 159, 6, 21, 219, 219, "Shadowing Potentail", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "230", "206", "RsLabel", 0, "", 271, 6, 21, 219, 220, "Distance from Last Tamp to Start of Verify Scan Window", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "231", "206", "RsLabel", 0, "", 243, 6, 21, 219, 221, "Scan Window Length Req", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "232", "206", "RsComboBox", 0, "Ver_Scan_Carton_Presentation", 130, 231, 22, 130, 222, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "233", "206", "RsComboBox", 0, "Ver_Scan_Shadowing_Potential", 158, 231, 22, 130, 223, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "234", "206", "RsComboBox", 0, "Ver_Scan_Min_Gap_Scan_Application_User_UOM", 214, 285, 22, 76, 224, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "235", "206", "RsComboBox", 0, "Ver_Scan_Scanner_Configuration", 46, 231, 22, 130, 225, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "236", "206", "RsLabel", 0, "", 103, 6, 21, 219, 226, "Label Orientation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "237", "206", "RsTextbox", 0, "Ver_Scan_Min_Gap_Scan_Application_User", 214, 231, 22, 48, 227, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "238", "206", "RsLabel", 0, "", 215, 6, 21, 219, 228, "Min Gap for this Scan Application", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "239", "206", "RsLabel", 0, "", 75, 6, 21, 219, 229, "Number of Carton Panels Scanned", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "240", "206", "RsLabel", 0, "", 19, 6, 21, 219, 230, "Must Re-scan Induction Barcode for Verification", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "241", "206", "RsTextbox", 0, "Ver_Scan_Carton_Panels_Scanned_Quantity", 74, 231, 22, 48, 231, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "242", "206", "RsComboBox", 0, "Ver_Scan_Rescan_Barcode_For_Verification", 18, 231, 22, 130, 232, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "243", "9", "RsTabPage", 0, "", 0, 0, 644, 809, 0, "Reject Diverter", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 416, "244", "243", "RsGroupBox", 0, "", 13, 3, 178, 424, 233, "Reject Diverter Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "245", "244", "RsComboBox", 0, "Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM", 311, 285, 22, 76, 234, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "246", "244", "RsLabel", 0, "", 131, 6, 21, 276, 235, "Min H-to-H Spacing for Continuous Flow / Avg Carton", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "247", "244", "RsTextbox", 0, "Reject_Diverter_Min_Gap_Required_User", 74, 288, 22, 48, 236, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "248", "244", "RsComboBox", 0, "Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM", 73, 342, 22, 76, 237, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "249", "244", "RsComboBox", 0, "Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM", 102, 342, 22, 76, 238, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "250", "244", "RsComboBox", 0, "Reject_Diverter_Type", 46, 288, 22, 130, 239, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "251", "244", "RsLabel", 0, "", 47, 6, 21, 219, 240, "Reject Diverter Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "252", "244", "RsComboBox", 0, "Reject_Diverter_Min_Gap_Required_User_UOM", 311, 285, 22, 76, 241, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "253", "244", "RsLabel", 0, "", 74, 6, 21, 219, 242, "Minimum Diverter Gap Requirement", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "254", "244", "RsTextbox", 0, "Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User", 130, 288, 22, 48, 243, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "255", "244", "RsComboBox", 0, "Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM", 130, 342, 22, 76, 244, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "256", "244", "RsTextbox", 0, "Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User", 102, 288, 22, 48, 245, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "257", "244", "RsLabel", 0, "", 103, 6, 21, 276, 246, "Min H-to-H Spacing for Continuous Flow / Max Carton", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "258", "244", "RsLabel", 0, "", 19, 6, 21, 219, 247, "Reject Diverter Required", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "259", "244", "RsComboBox", 0, "Reject_Diverter_Required", 18, 288, 22, 130, 248, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "260", "243", "RsGroupBox", 0, "", 13, 427, 178, 250, 249, "Transnorm TS4800", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "261", "260", "RsTextbox", 0, "Transnorm_TS4800_Divert_Angle", 18, 195, 22, 48, 250, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "262", "260", "RsLabel", 0, "", 20, 6, 21, 183, 251, "Divert Angle (deg)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "263", "260", "RsTextbox", 0, "Transnorm_TS4800_Divert_Shifting_Distance_IN", 47, 195, 22, 48, 252, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "264", "260", "RsLabel", 0, "", 48, 6, 21, 183, 253, "Divert Shifting Distance (in)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "265", "260", "RsTextbox", 0, "Transnorm_TS4800_Control_Reaction_Time_Distance_IN", 75, 195, 22, 48, 254, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "266", "260", "RsLabel", 0, "", 76, 6, 20, 183, 255, "Control Reaction Time Distance (in)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "267", "260", "RsTextbox", 0, "Transnorm_TS4800_Encoder_Resolution_IN", 103, 195, 22, 48, 256, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "268", "260", "RsTextbox", 0, "Transnorm_TS4800_Required_Gap_Max_Box", 131, 195, 22, 48, 257, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "269", "260", "RsLabel", 0, "", 104, 6, 21, 183, 258, "Encoder Resolution (in)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "270", "260", "RsLabel", 0, "", 132, 6, 21, 183, 259, "Required Gap (Max Box) (in)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "271", "9", "RsTabPage", 0, "", 0, 0, 644, 809, 0, "Conveyor Req Output", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 416, "272", "271", "RsGroupBox", 0, "", 8, 3, 115, 386, 260, "Conveyor Requirements Output", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "273", "272", "RsTextbox", 0, "Conv_Total_App_Belt_Length_Req_IN_User", 19, 219, 22, 48, 261, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "274", "272", "RsLabel", 0, "", 20, 6, 21, 207, 262, "Total Applicator Belt Length Required (in)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "275", "272", "RsTextbox", 0, "Conv_Total_App_Belt_Length_Req_FT_User", 47, 219, 22, 48, 263, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "276", "272", "RsLabel", 0, "", 48, 6, 21, 207, 264, "Total Applicator Belt Length Required (ft)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "277", "272", "RsTextbox", 0, "Conv_Total_Solution_Length_FT_User", 75, 219, 22, 48, 265, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "278", "272", "RsLabel", 0, "", 76, 6, 21, 207, 266, "Total Solution Length (ft)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "279", "272", "RsComboBox", 0, "Conv_Total_Solution_Length_FT_User_UOM", 75, 273, 22, 76, 267, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "280", "272", "RsComboBox", 0, "Conv_Total_App_Belt_Length_Req_FT_User_UOM", 47, 273, 22, 76, 268, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "281", "272", "RsComboBox", 0, "Conv_Total_App_Belt_Length_Req_IN_User_UOM", 19, 273, 22, 76, 269, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "282", "8", "RsGroupBox", 0, "", 19, 820, 658, 561, 270, "Estimated Throughput Results", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "283", "282", "RsLabel", 0, "", 145, 6, 21, 159, 271, "Calculation Warnings Present", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "284", "282", "RsTextbox", 0, "Summary_Min_H_to_H_Spacing_Limit_Set_By", 44, 171, 22, 130, 272, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "285", "282", "RsTextbox", 0, "Summary_Min_H_to_H_Spacing_Req_User", 19, 171, 22, 48, 273, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "286", "282", "RsActionButton", 0, "", 67, 400, 54, 128, 274, "Graph Output", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:PandA_Save_Theoretical_Max_Report;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 416, "287", "282", "RsComboBox", 0, "Summary_Min_T_to_H_Gap_Req_User_UOM", 72, 225, 22, 76, 275, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "288", "282", "RsTextbox", 0, "Summary_Min_T_to_H_Gap_Limit_Set_By", 101, 171, 22, 130, 276, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "289", "282", "RsTextbox", 0, "Summary_Caclucation_Errors_Present", 173, 171, 22, 62, 277, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "290", "282", "RsTextbox", 0, "Summary_Caclucation_Warnings_Present", 145, 171, 22, 62, 278, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "291", "282", "RsLabel", 0, "", 173, 6, 21, 159, 279, "Calculation Errors Present", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "292", "282", "RsLabel", 0, "", 47, 6, 21, 159, 280, "Min H-to-H Spacing Limit Set By", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "293", "282", "RsComboBox", 0, "Summary_Min_H_to_H_Spacing_Req_User_UOM", 19, 225, 22, 76, 281, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "294", "282", "RsLabel", 0, "", 100, 6, 21, 159, 282, "Min T-to-H Gap Limit Set By", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "295", "282", "RsTextbox", 0, "Summary_Min_T_to_H_Gap_Req_User", 72, 171, 22, 48, 283, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "296", "282", "RsLabel", 0, "", 72, 6, 21, 159, 284, "Min T-to-H Gap Req", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "297", "282", "RsLabel", 0, "", 19, 6, 21, 159, 285, "Min H-to-H Spacing Req", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "298", "282", "RsGrid", 0, "", 201, 6, 451, 559, 286, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,340,PandA_Theoretical_Max_Throughput_Rate;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 416, "299", "298", "RsGridColumn", 0, "Summary_Carton_Length_User", 0, 0, 0, 85, 0, "Carton Length", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 416, "300", "298", "RsGridColumn", 0, "Summary_Carton_Length_User_UOM", 0, 0, 0, 50, 0, "UOM", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 416, "301", "298", "RsGridColumn", 0, "Summary_H_H_Spacing_User", 0, 0, 0, 75, 0, "H-H Spacing", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 416, "302", "298", "RsGridColumn", 0, "Summary_H_H_Spacing_User_UOM", 0, 0, 0, 50, 0, "UOM", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 416, "303", "298", "RsGridColumn", 0, "Summary_Carton_Rate_Display", 0, 0, 0, 75, 0, "Rate (CPM)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 416, "304", "298", "RsGridColumn", 0, "Summary_Volume_Flow_Rate_User", 0, 0, 0, 75, 0, "Flow Rate", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 416, "305", "298", "RsGridColumn", 0, "Summary_Volume_Flow_Rate_User_UOM", 0, 0, 0, 50, 0, "UOM", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 416, "306", "298", "RsGridColumn", 0, "Summary_Limited_By", 0, 0, 0, 75, 0, "Limited By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 416, "307", "5", "RsTabPage", 0, "", 0, 0, 678, 1386, 0, "Layout", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 416, "308", "307", "RsGroupBox", 0, "", 504, 3, 51, 459, 287, "Total Calculated Belt Length (Two Belt Design)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "309", "308", "RsComboBox", 0, "Output_Total_Calc_Belt_Length_Double_FT_User_UOM", 19, 229, 22, 76, 288, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "310", "308", "RsComboBox", 0, "Output_Total_Calc_Belt_Length_Double_IN_User_UOM", 19, 60, 22, 76, 289, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "311", "308", "RsTextbox", 0, "Output_Total_Calc_Belt_Length_Double_IN_User", 19, 6, 22, 48, 290, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "312", "308", "RsTextbox", 0, "Output_Total_Calc_Belt_Length_Double_FT_User", 19, 175, 22, 48, 291, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "313", "307", "RsGroupBox", 0, "", 447, 3, 51, 459, 292, "Total Calculated Belt Length (Single Belt Design)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "314", "313", "RsComboBox", 0, "Output_Total_Calc_Belt_Length_Single_FT_User_UOM", 19, 229, 22, 76, 293, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "315", "313", "RsComboBox", 0, "Output_Total_Calc_Belt_Length_Single_IN_User_UOM", 19, 60, 22, 76, 294, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "316", "313", "RsTextbox", 0, "Output_Total_Calc_Belt_Length_Single_IN_User", 19, 6, 22, 48, 295, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "317", "313", "RsTextbox", 0, "Output_Total_Calc_Belt_Length_Single_FT_User", 19, 175, 22, 48, 296, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "318", "307", "RsGroupBox", 0, "", 3, 3, 438, 459, 297, "Layout Parameters", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "319", "318", "RsLabel", 0, "", 320, 40, 21, 271, 298, "Verify Max Linear Length of Carton Scanned", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "320", "318", "RsLabel", 0, "", 15, 317, 21, 130, 299, "Value", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "321", "318", "RsLabel", 0, "", 348, 40, 21, 271, 300, "Verify Scanner Distance to Xmit", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "322", "318", "RsLabel", 0, "", 237, 6, 21, 28, 301, "H", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "323", "318", "RsLabel", 0, "", 152, 40, 21, 271, 302, "Label Data Acquisition Distance Applicator 1", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "324", "318", "RsLabel", 0, "", 264, 40, 21, 271, 303, "Min Dist Last Applicator Tamp-&amp;gt;Verify Scan PE", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "325", "318", "RsLabel", 0, "", 97, 6, 21, 28, 304, "C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "326", "318", "RsLabel", 0, "", 293, 6, 21, 28, 305, "J", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "327", "318", "RsLabel", 0, "", 69, 6, 21, 28, 306, "B", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "328", "318", "RsLabel", 0, "", 265, 6, 21, 28, 307, "I", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "329", "318", "RsLabel", 0, "", 125, 6, 21, 28, 308, "D", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "330", "318", "RsLabel", 0, "", 321, 6, 21, 28, 309, "~", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "331", "318", "RsLabel", 0, "", 181, 6, 21, 28, 310, "F", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "332", "318", "RsLabel", 0, "", 377, 6, 21, 28, 311, "L", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "333", "318", "RsLabel", 0, "", 376, 40, 21, 271, 312, "Verify Scanner Data Capture Window Length", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "334", "318", "RsLabel", 0, "", 179, 40, 21, 271, 313, "Label Data Acquisition Distance Applicator 2", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "335", "318", "RsLabel", 0, "", 292, 40, 21, 271, 314, "Verify Scanner Window Length", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "336", "318", "RsLabel", 0, "", 96, 40, 21, 271, 315, "Induction Scan Window Length", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "337", "318", "RsLabel", 0, "", 236, 40, 21, 271, 316, "Minimum Distance Between Applicator 1 &amp;amp; 2", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "338", "318", "RsLabel", 0, "", 153, 6, 21, 28, 317, "E", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "339", "318", "RsLabel", 0, "", 349, 6, 21, 28, 318, "K", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "340", "318", "RsLabel", 0, "", 209, 6, 21, 28, 319, "G", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "341", "318", "RsLabel", 0, "", 405, 6, 21, 28, 320, "M", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "342", "318", "RsLabel", 0, "", 404, 40, 21, 271, 321, "PandA Belt Exit PE Distance", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "343", "318", "RsLabel", 0, "", 208, 40, 21, 271, 322, "Minimum Distance for Printer Setup", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "344", "318", "RsLabel", 0, "", 16, 40, 21, 271, 323, "Description", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "345", "318", "RsLabel", 0, "", 124, 40, 21, 271, 324, "Induct Scanner Data Capture Window Length", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "346", "318", "RsLabel", 0, "", 68, 40, 21, 271, 325, "Carton Stability Length", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "347", "318", "RsLabel", 0, "", 40, 40, 21, 271, 326, "Induct Max Linear Length of Carton Scanned", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "348", "318", "RsLabel", 0, "", 41, 6, 21, 28, 327, "A", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "349", "318", "RsLabel", 0, "", 16, 6, 21, 28, 328, "ID", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "350", "318", "RsComboBox", 0, "Output_PandA_Belt_Exit_PE_Distance_User_UOM", 403, 371, 22, 76, 329, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "351", "318", "RsComboBox", 0, "Output_Min_Distance_for_Printer_Setup_User_UOM", 207, 371, 22, 76, 330, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "352", "318", "RsComboBox", 0, "Output_Induct_Scan_Data_Cap_Window_Lgth_User_UOM", 123, 371, 22, 76, 331, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "353", "318", "RsComboBox", 0, "Output_Carton_Stability_Length_User_UOM", 67, 371, 22, 76, 332, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "354", "318", "RsComboBox", 0, "Output_Induct_Max_Lgth_of_Carton_Scanned_User_UOM", 39, 371, 22, 76, 333, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "355", "318", "RsTextbox", 0, "Output_Induct_Max_Lgth_of_Carton_Scanned_User", 39, 317, 22, 48, 334, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "356", "318", "RsComboBox", 0, "Output_Ver_Max_Length_of_Carton_Scanned_User_UOM", 319, 371, 22, 76, 335, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "357", "318", "RsComboBox", 0, "Output_Label_Data_Acq_Distance_App_1_User_UOM", 151, 371, 22, 76, 336, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "358", "318", "RsComboBox", 0, "Output_Induction_Scan_Window_Length_User_UOM", 95, 371, 22, 76, 337, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "359", "318", "RsTextbox", 0, "Output_Carton_Stability_Length_User", 67, 317, 22, 48, 338, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "360", "318", "RsComboBox", 0, "Output_Verify_Scanner_Distance_to_Xmit_User_UOM", 347, 371, 22, 76, 339, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "361", "318", "RsComboBox", 0, "Output_Label_Data_Acq_Distance_App_2_User_UOM", 179, 371, 22, 76, 340, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "362", "318", "RsTextbox", 0, "Output_Induct_Scan_Data_Cap_Window_Lgth_User", 123, 317, 22, 48, 341, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "363", "318", "RsTextbox", 0, "Output_Induction_Scan_Window_Length_User", 95, 317, 22, 48, 342, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "364", "318", "RsComboBox", 0, "Output_Min_Dist_Last_App_Tamp_Ver_Scan_PE_User_UOM", 263, 371, 22, 76, 343, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "365", "318", "RsTextbox", 0, "Output_Min_Distance_for_Printer_Setup_User", 207, 317, 22, 48, 344, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "366", "318", "RsTextbox", 0, "Output_Label_Data_Acq_Distance_App_1_User", 151, 317, 22, 48, 345, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "367", "318", "RsComboBox", 0, "Output_Ver_Scan_Data_Capture_Window_Length_User_UO", 375, 371, 22, 76, 346, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "368", "318", "RsTextbox", 0, "Output_Label_Data_Acq_Distance_App_2_User", 179, 317, 22, 48, 347, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "369", "318", "RsComboBox", 0, "Output_Verify_Scanner_Window_Length_User_UOM", 291, 371, 22, 76, 348, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "370", "318", "RsComboBox", 0, "Output_Min_Distance_Between_Applicator_1_2_User_UO", 235, 371, 22, 76, 349, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "371", "318", "RsTextbox", 0, "Output_PandA_Belt_Exit_PE_Distance_User", 403, 317, 22, 48, 350, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "372", "318", "RsTextbox", 0, "Output_Verify_Scanner_Distance_to_Xmit_User", 347, 317, 22, 48, 351, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "373", "318", "RsTextbox", 0, "Output_Ver_Max_Length_of_Carton_Scanned_User", 319, 317, 22, 48, 352, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "374", "318", "RsTextbox", 0, "Output_Min_Dist_Last_App_Tamp_Ver_Scan_PE_User", 263, 317, 22, 48, 353, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "375", "318", "RsTextbox", 0, "Output_Ver_Scan_Data_Capture_Window_Length_User", 375, 317, 22, 48, 354, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "376", "318", "RsTextbox", 0, "Output_Verify_Scanner_Window_Length_User", 291, 317, 22, 48, 355, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "377", "318", "RsTextbox", 0, "Output_Min_Distance_Between_Applicator_1_2_User", 235, 317, 22, 48, 356, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "378", "307", "RsPictureBox", 0, "", 15, 477, 344, 780, 357, "", 0, 0, 1, 5, 0, "", "", "Filename:Belted_PandA_Layout_Example.png;IsGeneratedImg:False;RsTooltip:;")
        oProcessStep.AddCustomLayout(1, 416, "379", "307", "RsPictureBox", 0, "", 438, 477, 236, 806, 358, "", 0, 0, 1, 5, 0, "", "", "Filename:Belted_PandA_Layout_Example_2.png;IsGeneratedImg:False;RsTooltip:;")
        oProcessStep.AddCustomLayout(1, 416, "380", "0", "RsLabel", 0, "", 58, 12, 29, 399, 359, "*** Note:  Global Units should ONLY be changed before inputting other values", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "381", "0", "RsGroupBox", 0, "", 12, 1059, 131, 347, 360, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 416, "382", "381", "RsLabel", 0, "", 19, 6, 21, 112, 361, "Customer Name", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "383", "381", "RsTextbox", 0, "Customer_Name", 19, 125, 21, 214, 362, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "384", "381", "RsLabel", 0, "", 46, 6, 21, 112, 363, "Location", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "385", "381", "RsTextbox", 0, "Customer_Location", 46, 125, 21, 214, 364, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "386", "381", "RsLabel", 0, "", 100, 6, 21, 112, 365, "Date", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "387", "381", "RsLabel", 0, "", 73, 6, 21, 112, 366, "Proposal Number", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 416, "388", "381", "RsTextbox", 0, "Customer_Date", 100, 125, 21, 214, 367, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 416, "389", "381", "RsTextbox", 0, "Customer_Proposal_Number", 73, 125, 21, 214, 368, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Setup_And_Global_MTBF___DEBUG()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(113, "Setup And Global MTBF _ DEBUG", "Setup And Global MTBF  DEBUG", 106, 51, 1, 11, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.App_Calc/CAE_App_Calc.Setup/APC_Setup")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 119, "1", "0", "RsLabel", 0, "", 0, 0, 36, 384, 0, "Setup", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "2", "0", "RsGroupBox", 0, "", 39, 0, 130, 744, 1, "Site / Customer Information", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 119, "3", "2", "RsTextbox", 0, "Customer_Name", 32, 127, 26, 528, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "4", "2", "RsTextbox", 0, "Customer_Location_CityState", 64, 127, 26, 528, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "5", "2", "RsTextbox", 0, "Proposal_No", 92, 127, 26, 264, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "6", "2", "RsLabel", 0, "", 92, 393, 30, 58, 5, "Date:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "7", "2", "RsSingleDatePicker", 0, "Proposal_Date", 92, 457, 20, 198, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 119, "8", "2", "RsLabel", 0, "", 92, 35, 30, 86, 7, "Proposal #:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "9", "2", "RsLabel", 0, "", 64, 6, 30, 115, 8, "Location (City, St):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "10", "2", "RsLabel", 0, "", 34, 35, 30, 86, 9, "Customer Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "11", "0", "RsLabel", 0, "", 39, 750, 36, 384, 10, "Warnings And Errors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:Firebrick;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "12", "0", "RsTextbox", 0, "Valid_Message", 78, 750, 562, 508, 11, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "13", "0", "RsGroupBox", 0, "", 175, 0, 106, 744, 12, "Instructions / Notes", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "14", "13", "RsLabel", 0, "", 25, 7, 57, 706, 13, "Use this sheet to setup the General &amp;quot;Material to be Handled&amp;quot; parameters to be used globally throughout the remaining worksheets. Some of the worksheets have the option to use locally defined &amp;quot;Material to be Handled&amp;quot; parameters instead of these &amp;quot;Global&amp;quot; parameters defined on this sheet.  This feature is provided where there is a possibility that these material parameters could be more restrictive than the system as a whole.", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "15", "0", "RsGroupBox", 0, "", 287, 0, 192, 744, 14, "Material Size", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "16", "15", "RsComboBox", 0, "User_UOM_System", 28, 127, 22, 172, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "17", "15", "RsTextbox", 0, "BoxSize_Length_Min_User", 95, 127, 21, 60, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "18", "15", "RsComboBox", 0, "BoxSize_Length_Min_User_UOM", 95, 187, 22, 60, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "19", "15", "RsLabel", 0, "", 121, 40, 16, 78, 18, "Maximum", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "20", "15", "RsTextbox", 0, "BoxSize_Width_Min_User", 95, 253, 21, 60, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "21", "15", "RsComboBox", 0, "BoxSize_Length_Min_User_UOM", 95, 318, 22, 60, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "22", "15", "RsTextbox", 0, "BoxSize_Height_Min_User", 95, 384, 21, 60, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "23", "15", "RsComboBox", 0, "BoxSize_Height_Min_User_UOM", 95, 444, 22, 60, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "24", "15", "RsTextbox", 0, "BoxSize_Weight_Min_User", 95, 510, 21, 60, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "25", "15", "RsComboBox", 0, "BoxSize_Weight_Min_User_UOM", 95, 570, 22, 60, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "26", "15", "RsLabel", 0, "", 28, 34, 16, 78, 25, "Default UOM", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "27", "15", "RsTextbox", 0, "BoxSize_Length_Max_User", 121, 127, 21, 60, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "28", "15", "RsComboBox", 0, "BoxSize_Length_Max_User_UOM", 121, 187, 22, 60, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "29", "15", "RsTextbox", 0, "BoxSize_Width_Max_User", 121, 253, 21, 60, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "30", "15", "RsComboBox", 0, "BoxSize_Length_Max_User_UOM", 121, 318, 22, 60, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "31", "15", "RsTextbox", 0, "BoxSize_Height_Max_User", 121, 384, 21, 60, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "32", "15", "RsComboBox", 0, "BoxSize_Height_Max_User_UOM", 121, 444, 22, 60, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "33", "15", "RsTextbox", 0, "BoxSize_Weight_Max_User", 121, 510, 21, 60, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "34", "15", "RsComboBox", 0, "BoxSize_Weight_Max_User_UOM", 121, 570, 22, 60, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "35", "15", "RsTextbox", 0, "BoxSize_Length_Avg_User", 149, 127, 21, 60, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "36", "15", "RsComboBox", 0, "BoxSize_Length_Avg_User_UOM", 149, 187, 22, 60, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "37", "15", "RsTextbox", 0, "BoxSize_Width_Avg_User", 149, 253, 21, 60, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "38", "15", "RsComboBox", 0, "BoxSize_Length_Avg_User_UOM", 149, 318, 22, 60, 37, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "39", "15", "RsTextbox", 0, "BoxSize_Height_Avg_User", 149, 384, 21, 60, 38, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "40", "15", "RsLabel", 0, "", 75, 384, 16, 120, 39, "Height", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "41", "15", "RsComboBox", 0, "BoxSize_Height_Avg_User_UOM", 149, 444, 22, 60, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "42", "15", "RsTextbox", 0, "BoxSize_Weight_Avg_User", 149, 510, 21, 60, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "43", "15", "RsComboBox", 0, "BoxSize_Weight_Max_User_UOM", 149, 570, 22, 60, 42, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "44", "15", "RsLabel", 0, "", 149, 40, 16, 78, 43, "Average", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "45", "15", "RsLabel", 0, "", 95, 40, 16, 78, 44, "Minimum", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "46", "15", "RsLabel", 0, "", 75, 510, 16, 106, 45, "Weight", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "47", "15", "RsLabel", 0, "", 75, 253, 16, 100, 46, "Width", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "48", "15", "RsLabel", 0, "", 75, 149, 16, 78, 47, "Length", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "49", "0", "RsGroupBox", 0, "", 485, 0, 155, 744, 48, "MTBH Factors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "50", "49", "RsTextbox", 0, "Live_Load_Avg_User", 21, 128, 21, 60, 49, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "51", "49", "RsLabel", 0, "", 20, 44, 16, 78, 50, "Live Load:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "52", "49", "RsComboBox", 0, "Live_Load_Avg_User_UOM", 20, 197, 22, 60, 51, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "53", "49", "RsCheckbox", 0, "Totes_Plastic", 48, 128, 18, 129, 52, "Plastic Totes in Use?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "54", "49", "RsCheckbox", 0, "BoxSize_Height_GRTR_Len_Possible", 72, 128, 18, 298, 53, "Within MTBH Range, Can Product Heights be &amp;gt; Length?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "55", "49", "RsCheckbox", 0, "BoxSize_Other_Known_Issues", 96, 128, 18, 175, 54, "Other Known Stability Issues?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "56", "49", "RsComboBox", 0, "Selected_Sortation_Controls", 120, 128, 22, 140, 55, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "57", "49", "RsLabel", 0, "", 95, 398, 22, 114, 56, "Worst Case H/L Ratio:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "58", "49", "RsTextbox", 0, "Temp_Sort_Operating_Min_User", 18, 518, 21, 74, 57, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "59", "49", "RsComboBox", 0, "Temp_Sort_Operating_Min_User_UOM", 17, 598, 22, 60, 58, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "60", "49", "RsLabel", 0, "", 122, 398, 16, 114, 59, "Max Incline / Decline:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "61", "49", "RsTextbox", 0, "Temp_System_Operating_Min_User", 45, 518, 21, 74, 60, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "62", "49", "RsLabel", 0, "", 122, 584, 22, 60, 61, "Degrees", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "63", "49", "RsComboBox", 0, "Temp_System_Operating_Min_UOM", 44, 598, 22, 60, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "64", "49", "RsTextbox", 0, "BoxSize_Worst_Case_HL_Ratio", 96, 518, 21, 60, 63, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "65", "49", "RsTextbox", 0, "Belt_InclineDecline_Max_Deg", 122, 518, 21, 60, 64, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "66", "49", "RsLabel", 0, "", 120, 44, 16, 78, 65, "Control System:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "67", "49", "RsLabel", 0, "", 17, 346, 18, 166, 66, "Operating Temp Min ( Sorter ):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "68", "49", "RsLabel", 0, "", 48, 346, 18, 166, 67, "Operating Temp Min ( System ):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "69", "49", "RsTextbox", 0, "Temp_Sort_Operating_Min_F", 18, 664, 25, 64, 68, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "70", "49", "RsTextbox", 0, "Temp_System_Operating_Min_F", 44, 664, 25, 64, 69, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "71", "0", "RsGroupBox", 0, "", 646, 0, 200, 744, 70, "General Application Factors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "72", "71", "RsLabel", 0, "", 37, 44, 16, 78, 71, "Product Line:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "73", "71", "RsComboBox", 0, "Conveyor_Product_Line_Used", 31, 137, 22, 140, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "74", "71", "RsLabel", 0, "", 143, 369, 22, 177, 73, "Target Case Length per Minute:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "75", "71", "RsTextbox", 0, "Conveyor_Width_Min_IN", 61, 137, 21, 74, 74, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "76", "71", "RsLabel", 0, "", 29, 293, 18, 316, 75, "Total Skew Length Required for Selected MTBH Width and BF:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "77", "71", "RsTextbox", 0, "Conveyor_Curve_BF_Calc_Min_In", 88, 137, 21, 74, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "78", "71", "RsTextbox", 0, "Conveyor_Curve_BF_Calc_Rcmd_In", 115, 137, 21, 74, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "79", "71", "RsComboBox", 0, "Conveyor_BF_Selected_Min_User", 142, 137, 22, 140, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "80", "71", "RsTextbox", 0, "Material_Gap_Override_User", 170, 552, 21, 60, 79, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "81", "71", "RsComboBox", 0, "Conveyor_BF_Selected_Min_User_UOM", 141, 280, 22, 60, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "82", "71", "RsLabel", 0, "", 64, 6, 18, 115, 81, "Min Converyor Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "83", "71", "RsTextbox", 0, "Conveyor_Skew_Total_Length_MTBH_Width_IN", 26, 615, 21, 74, 82, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "84", "71", "RsTextbox", 0, "Conveyor_Skew_Bed_Length_Min_Reqd_IN", 53, 615, 21, 74, 83, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "85", "71", "RsLabel", 0, "", 112, 439, 19, 107, 84, "Target Sort Rate:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "86", "71", "RsCheckbox", 0, "Sort_Dual_Sided", 80, 599, 18, 129, 85, "Dual Sided Sortation", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "87", "71", "RsLabel", 0, "", 144, 706, 18, 22, 86, "M", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "88", "71", "RsTextbox", 0, "Sort_Rate_Required_CPM", 112, 552, 21, 60, 87, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "89", "71", "RsLabel", 0, "", 170, 441, 22, 105, 88, "Design Gap Override:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "90", "71", "RsLabel", 0, "", 114, 618, 18, 105, 89, "CPM (Cases Per Min)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "91", "71", "RsTextbox", 0, "Case_Length_Per_Minute_Target_FT", 144, 552, 21, 60, 90, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "92", "71", "RsLabel", 0, "", 147, 618, 18, 14, 91, "Ft.", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "93", "71", "RsTextbox", 0, "Case_Length_Per_Minute_Target_M", 143, 640, 21, 60, 92, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "94", "71", "RsLabel", 0, "", 91, 7, 18, 115, 93, "Min Calc Curve Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "95", "71", "RsComboBox", 0, "Material_Gap_Override_User_UOM", 170, 640, 22, 60, 94, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "96", "71", "RsLabel", 0, "", 56, 264, 18, 345, 95, "Minimum Required Skew Bed Length for Selected MTBH Width and BF:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "97", "71", "RsLabel", 0, "", 118, 6, 18, 115, 96, "Min Rcmd Curve Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "98", "71", "RsLabel", 0, "", 29, 695, 18, 22, 97, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "99", "71", "RsLabel", 0, "", 53, 695, 18, 22, 98, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "100", "71", "RsLabel", 0, "", 142, 16, 22, 105, 99, "Selected Min Wdith:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "101", "71", "RsLabel", 0, "", 88, 217, 18, 22, 100, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "102", "71", "RsLabel", 0, "", 64, 217, 18, 22, 101, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "103", "71", "RsLabel", 0, "", 118, 217, 18, 22, 102, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "104", "0", "RsPrevActionButton", 0, "", 852, 0, 38, 94, 103, "Previous", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 119, "105", "0", "RsNextActionButton", 0, "", 852, 628, 38, 116, 104, "Next", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_MDR_Sort()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(115, "MDR Sort", "", 106, 51, 1, 12, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.App_Calc/CAE_App_Calc.MDR/CAE_APC_MDR")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 439, "1", "0", "RsGroupBox", 0, "", 102, 12, 49, 182, 0, "Global Units", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "2", "1", "RsLabel", 0, "", 16, 12, 21, 39, 1, "Units:", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "3", "1", "RsComboBox", 0, "User_UOM_System", 16, 68, 22, 108, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "4", "0", "RsLabel", 0, "", 12, 12, 36, 384, 3, "MDR Sortation Calculator", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "5", "0", "RsLabel", 0, "", 70, 12, 29, 399, 4, "*** Note:  Global Units should ONLY be changed before inputting other values", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "6", "0", "RsGroupBox", 0, "", 12, 1124, 131, 399, 5, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "7", "6", "RsLabel", 0, "", 19, 6, 21, 97, 6, "Customer Name", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "8", "6", "RsTextbox", 0, "Customer_Name", 19, 109, 21, 278, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "9", "6", "RsLabel", 0, "", 46, 6, 21, 97, 8, "Location", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "10", "6", "RsTextbox", 0, "Customer_Location", 46, 109, 21, 278, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "11", "6", "RsLabel", 0, "", 100, 6, 21, 97, 10, "Date", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "12", "6", "RsLabel", 0, "", 73, 6, 21, 97, 11, "Proposal Number", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "13", "6", "RsTextbox", 0, "Customer_Date", 100, 109, 21, 278, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "14", "6", "RsTextbox", 0, "Customer_Proposal_Number", 73, 109, 21, 278, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "15", "0", "RsTabControl", 0, "", 224, 8, 638, 1515, 14, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 439, "16", "15", "RsTabPage", 0, "", 0, 0, 608, 1507, 0, "Intro", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 439, "17", "16", "RsLabel", 0, "UI_Summary", 13, 3, 320, 763, 15, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "18", "15", "RsTabPage", 0, "", 0, 0, 608, 1507, 0, "Input", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 439, "19", "18", "RsGroupBox", 0, "", 8, 3, 55, 313, 16, "Sorter Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "20", "19", "RsLabel", 0, "", 16, 6, 21, 147, 17, "Choose Sorter Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "21", "19", "RsComboBox", 0, "Gen_Sorter_Type", 15, 159, 22, 125, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "22", "18", "RsGroupBox", 0, "", 69, 3, 105, 313, 19, "Sorter Characteristics", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "23", "22", "RsLabel", 0, "", 44, 6, 21, 147, 20, "Maximum Speed", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "24", "22", "RsTextbox", 0, "Sort_Char_Min_Operating_Temp_User", 71, 159, 22, 43, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "25", "22", "RsGroupBox", 0, "", 66, 319, 162, 584, 22, "Material To Be Handled", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "26", "25", "RsTextbox", 0, "MTBH_Width_Average_User", 131, 207, 22, 48, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "27", "25", "RsTextbox", 0, "MTBH_Length_Average_User", 131, 81, 22, 48, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "28", "25", "RsComboBox", 0, "MTBH_Height_Minimum_User_UOM", 75, 384, 22, 52, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "29", "25", "RsTextbox", 0, "MTBH_Length_Maximum_User", 103, 81, 22, 48, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "30", "25", "RsComboBox", 0, "MTBH_Width_Average_User_UOM", 131, 261, 22, 52, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "31", "25", "RsComboBox", 0, "MTBH_Weight_Maximum_User_UOM", 103, 509, 22, 52, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "32", "25", "RsComboBox", 0, "MTBH_Weight_Minimum_User_UOM", 75, 509, 22, 52, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "33", "25", "RsComboBox", 0, "MTBH_Height_Maximum_User_UOM", 103, 384, 22, 52, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "34", "25", "RsTextbox", 0, "MTBH_Weight_Average_User", 131, 455, 22, 48, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "35", "25", "RsTextbox", 0, "MTBH_Height_Average_User", 131, 330, 22, 48, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "36", "25", "RsComboBox", 0, "MTBH_Weight_Average_User_UOM", 131, 509, 22, 52, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "37", "25", "RsTextbox", 0, "MTBH_Weight_Minimum_User", 75, 455, 22, 48, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "38", "25", "RsComboBox", 0, "MTBH_Width_Maximum_User_UOM", 103, 261, 22, 52, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "39", "25", "RsComboBox", 0, "MTBH_Height_Average_User_UOM", 131, 384, 22, 52, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "40", "25", "RsTextbox", 0, "MTBH_Weight_Maximum_User", 103, 455, 22, 48, 37, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "41", "25", "RsComboBox", 0, "MTBH_Length_Average_User_UOM", 131, 135, 22, 52, 38, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "42", "25", "RsComboBox", 0, "MTBH_Length_Maximum_User_UOM", 103, 135, 22, 52, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "43", "25", "RsTextbox", 0, "MTBH_Height_Maximum_User", 103, 330, 22, 48, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "44", "25", "RsTextbox", 0, "MTBH_Height_Minimum_User", 75, 330, 22, 48, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "45", "25", "RsLabel", 0, "", 131, 6, 21, 69, 42, "Average", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "46", "25", "RsTextbox", 0, "MTBH_Width_Maximum_User", 103, 207, 22, 48, 43, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "47", "25", "RsComboBox", 0, "MTBH_Width_Minimum_User_UOM", 75, 261, 22, 52, 44, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "48", "25", "RsTextbox", 0, "MTBH_Width_Minimum_User", 75, 207, 22, 48, 45, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "49", "25", "RsComboBox", 0, "MTBH_Length_Minimum_User_UOM", 75, 135, 22, 52, 46, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "50", "25", "RsTextbox", 0, "MTBH_Length_Minimum_User", 75, 81, 22, 48, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "51", "25", "RsLabel", 0, "", 51, 455, 21, 69, 48, "Weight", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "52", "25", "RsLabel", 0, "", 51, 330, 21, 69, 49, "Height", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "53", "25", "RsLabel", 0, "", 75, 6, 21, 69, 50, "Minimum", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "54", "25", "RsLabel", 0, "", 51, 207, 21, 69, 51, "Width", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "55", "25", "RsLabel", 0, "", 51, 81, 21, 69, 52, "Length", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "56", "25", "RsComboBox", 0, "MTBH_Use_Local", 22, 81, 22, 73, 53, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "57", "25", "RsLabel", 0, "", 22, 6, 21, 69, 54, "Use Local?", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "58", "25", "RsLabel", 0, "", 103, 6, 21, 69, 55, "Maximum", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "59", "22", "RsLabel", 0, "", 16, 6, 21, 147, 56, "Divert Angle (deg)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "60", "22", "RsTextbox", 0, "Sort_Char_Max_Speed_User", 43, 159, 22, 43, 57, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "61", "22", "RsTextbox", 0, "Sort_Char_Divert_Angle", 15, 159, 22, 125, 58, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "62", "22", "RsComboBox", 0, "Sort_Char_Max_Speed_User_UOM", 43, 208, 22, 76, 59, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "63", "22", "RsLabel", 0, "", 72, 6, 21, 147, 60, "Min Operating Temp", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "64", "22", "RsComboBox", 0, "Sort_Char_Min_Operating_Temp_User_UOM", 71, 208, 22, 76, 61, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "65", "18", "RsGroupBox", 0, "", 8, 322, 121, 472, 62, "Size Limites for Chosen Sorter", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "66", "65", "RsTextbox", 0, "Size_Limits_Length_Max_User", 77, 81, 22, 48, 63, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "67", "65", "RsComboBox", 0, "Size_Limits_Weight_Max_User_UOM", 76, 384, 22, 52, 64, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "68", "65", "RsComboBox", 0, "Size_Limits_Weight_Min_User_UOM", 48, 384, 22, 52, 65, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "69", "65", "RsTextbox", 0, "Size_Limits_Weight_Min_User", 48, 330, 22, 48, 66, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "70", "65", "RsComboBox", 0, "Size_Limits_Width_Max_User_UOM", 77, 261, 22, 52, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "71", "65", "RsTextbox", 0, "Size_Limits_Weight_Max_User", 76, 330, 22, 48, 68, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "72", "65", "RsComboBox", 0, "Size_Limits_Length_Max_User_UOM", 77, 135, 22, 52, 69, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "73", "65", "RsTextbox", 0, "Size_Limits_Width_Max_User", 77, 207, 22, 48, 70, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "74", "65", "RsComboBox", 0, "Size_Limits_Width_Min_User_UOM", 49, 261, 22, 52, 71, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "75", "65", "RsTextbox", 0, "Size_Limits_Width_Min_User", 49, 207, 22, 48, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "76", "65", "RsComboBox", 0, "Size_Limits_Length_Min_User_UOM", 49, 135, 22, 52, 73, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "77", "65", "RsTextbox", 0, "Size_Limits_Length_Min_User", 49, 81, 22, 48, 74, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "78", "65", "RsLabel", 0, "", 24, 330, 21, 69, 75, "Weight", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "79", "65", "RsLabel", 0, "", 49, 6, 21, 69, 76, "Minimum", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "80", "65", "RsLabel", 0, "", 25, 207, 21, 69, 77, "Width", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "81", "65", "RsLabel", 0, "", 25, 81, 21, 69, 78, "Length", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "82", "65", "RsLabel", 0, "", 77, 6, 21, 69, 79, "Maximum", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "83", "18", "RsGroupBox", 0, "", 180, 3, 415, 313, 80, "Physical MDR Diverter Configuration", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "84", "83", "RsComboBox", 0, "MDR_Diverter_RAT_Decision_Point", 320, 159, 22, 125, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "85", "83", "RsComboBox", 0, "MDR_Diverter_Transfer_Band_Speed_User", 293, 159, 22, 55, 82, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "86", "83", "RsComboBox", 0, "MDR_Diverter_MDR_Speed_User", 264, 159, 22, 55, 83, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "87", "83", "RsComboBox", 0, "MDR_Diverter_Transfer_Wdth_pl_Frame_Width_User", 153, 159, 22, 55, 84, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "88", "83", "RsComboBox", 0, "MDR_Diverter_MDR_Transfer_Length_User", 69, 159, 22, 55, 85, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "89", "83", "RsComboBox", 0, "MDR_Diverter_MDR_Zone_Length_User", 41, 159, 22, 55, 86, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "90", "83", "RsComboBox", 0, "MDR_Diverter_Dist_Stop_Upstrm_Trans_Zone_User_UOM", 376, 208, 22, 76, 87, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "91", "83", "RsComboBox", 0, "MDR_Diverter_Dist_Infeed_to_Trail_Edge_User_UOM", 348, 208, 22, 76, 88, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "92", "83", "RsLabel", 0, "", 293, 6, 21, 147, 89, "Transfer Band Speed (if applicable)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "93", "83", "RsLabel", 0, "", 321, 6, 21, 147, 90, "RAT Decision Point", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "94", "83", "RsComboBox", 0, "MDR_Diverter_Side_Exit_Eye_Dist_User_UOM", 236, 208, 22, 76, 91, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "95", "83", "RsLabel", 0, "", 265, 6, 21, 147, 92, "MDR Speed", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "96", "83", "RsComboBox", 0, "MDR_Diverter_MDR_Speed_User_UOM", 264, 220, 22, 64, 93, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "97", "83", "RsTextbox", 0, "MDR_Diverter_Side_Exit_Eye_Dist_User", 236, 159, 22, 43, 94, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "98", "83", "RsComboBox", 0, "MDR_Diverter_Transfer_Belt_Ext_Req", 180, 159, 22, 125, 95, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "99", "83", "RsLabel", 0, "", 377, 6, 21, 147, 96, "Dist of Stop Upstream from Transfer Zone Discharge", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "100", "83", "RsLabel", 0, "", 349, 6, 21, 147, 97, "Distance from Infeed to Trail Edge of Box in Xfer Pos", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "101", "83", "RsTextbox", 0, "MDR_Diverter_Dist_Stop_Upstrm_Trans_Zone_User", 376, 159, 22, 43, 98, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "102", "83", "RsTextbox", 0, "MDR_Diverter_Dist_Infeed_to_Trail_Edge_User", 348, 159, 22, 43, 99, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "103", "83", "RsComboBox", 0, "MDR_Diverter_Transfer_Band_Speed_User_UOM", 292, 220, 22, 64, 100, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "104", "83", "RsLabel", 0, "", 237, 6, 21, 147, 101, "Side Exit Eye Distance", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "105", "83", "RsLabel", 0, "", 209, 6, 21, 147, 102, "Net Transfer Width for Calc", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "106", "83", "RsTextbox", 0, "MDR_Diverter_Net_Transfer_Width_User", 208, 159, 22, 43, 103, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "107", "83", "RsComboBox", 0, "MDR_Diverter_Net_Transfer_Width_User_UOM", 208, 208, 22, 76, 104, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "108", "83", "RsLabel", 0, "", 181, 6, 21, 147, 105, "Transfer Belt Ext Used?", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "109", "83", "RsLabel", 0, "", 154, 6, 21, 147, 106, "Transfer Width B/F + Frame Width (2.5 Inches)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "110", "83", "RsLabel", 0, "", 126, 6, 21, 147, 107, "Exit Eye Distance", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "111", "83", "RsTextbox", 0, "MDR_Diverter_Exit_Eye_User", 125, 159, 22, 43, 108, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "112", "83", "RsComboBox", 0, "MDR_Diverter_Transfer_Wdth_pl_Frame_Width_User_UOM", 153, 220, 22, 64, 109, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "113", "83", "RsLabel", 0, "", 98, 6, 21, 147, 110, "Entry Eye Distance", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "114", "83", "RsComboBox", 0, "MDR_Diverter_Exit_Eye_User_UOM", 125, 208, 22, 76, 111, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "115", "83", "RsLabel", 0, "", 70, 6, 21, 147, 112, "MDR Transfer Length", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "116", "83", "RsTextbox", 0, "MDR_Diverter_Entry_Eye_Dist_User", 97, 159, 22, 43, 113, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "117", "83", "RsComboBox", 0, "MDR_Diverter_Entry_Eye_Dist_User_UOM", 97, 208, 22, 76, 114, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "118", "83", "RsLabel", 0, "", 44, 6, 21, 147, 115, "MDR Zone Length", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "119", "83", "RsComboBox", 0, "MDR_Diverter_MDR_Transfer_Length_User_UOM", 69, 220, 22, 64, 116, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "120", "83", "RsComboBox", 0, "MDR_Diverter_MDR_Zone_Length_User_UOM", 43, 220, 22, 64, 117, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "121", "83", "RsLabel", 0, "", 16, 6, 21, 147, 118, "MDR Width", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "122", "83", "RsComboBox", 0, "MDR_Diverter_MDR_Width_User_UOM", 15, 220, 22, 64, 119, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "123", "83", "RsComboBox", 0, "MDR_Diverter_MDR_Width_User", 15, 159, 22, 55, 120, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "124", "18", "RsGroupBox", 0, "", 303, 322, 159, 313, 121, "Operational Parameters", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "125", "124", "RsLabel", 0, "", 44, 6, 21, 147, 122, "Carton Justification", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "126", "124", "RsComboBox", 0, "Operation_Params_Carton_Justification", 43, 159, 22, 125, 123, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "127", "124", "RsLabel", 0, "", 16, 6, 21, 147, 124, "Desired Local Throughput Rate (CPM)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "128", "124", "RsTextbox", 0, "Operation_Params_Desired_Local_Throughput_Rate", 15, 159, 22, 125, 125, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "129", "124", "RsLabel", 0, "", 72, 6, 21, 147, 126, "Left Divert %", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "130", "124", "RsTextbox", 0, "Operation_Params_Percent_Left_Divert_User", 71, 159, 22, 125, 127, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "131", "124", "RsLabel", 0, "", 100, 6, 21, 147, 128, "Right Divert %", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "132", "124", "RsTextbox", 0, "Operation_Params_Percent_Right_Divert_User", 99, 159, 22, 125, 129, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "133", "124", "RsLabel", 0, "", 128, 6, 21, 147, 130, "Go Straight %", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "134", "124", "RsTextbox", 0, "Operation_Params_Percent_Straight_User", 127, 159, 22, 125, 131, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "135", "18", "RsGroupBox", 0, "", 135, 322, 162, 584, 132, "Material To Be Handled", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "136", "135", "RsTextbox", 0, "MTBH_Width_Average_User", 131, 207, 22, 48, 133, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "137", "135", "RsTextbox", 0, "MTBH_Length_Average_User", 131, 81, 22, 48, 134, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "138", "135", "RsComboBox", 0, "MTBH_Height_Minimum_User_UOM", 75, 384, 22, 52, 135, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "139", "135", "RsTextbox", 0, "MTBH_Length_Maximum_User", 103, 81, 22, 48, 136, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "140", "135", "RsComboBox", 0, "MTBH_Width_Average_User_UOM", 131, 261, 22, 52, 137, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "141", "135", "RsComboBox", 0, "MTBH_Weight_Maximum_User_UOM", 103, 509, 22, 52, 138, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "142", "135", "RsComboBox", 0, "MTBH_Weight_Minimum_User_UOM", 75, 509, 22, 52, 139, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "143", "135", "RsComboBox", 0, "MTBH_Height_Maximum_User_UOM", 103, 384, 22, 52, 140, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "144", "135", "RsTextbox", 0, "MTBH_Weight_Average_User", 131, 455, 22, 48, 141, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "145", "135", "RsTextbox", 0, "MTBH_Height_Average_User", 131, 330, 22, 48, 142, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "146", "135", "RsComboBox", 0, "MTBH_Weight_Average_User_UOM", 131, 509, 22, 52, 143, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "147", "135", "RsTextbox", 0, "MTBH_Weight_Minimum_User", 75, 455, 22, 48, 144, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "148", "135", "RsComboBox", 0, "MTBH_Width_Maximum_User_UOM", 103, 261, 22, 52, 145, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "149", "135", "RsComboBox", 0, "MTBH_Height_Average_User_UOM", 131, 384, 22, 52, 146, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "150", "135", "RsTextbox", 0, "MTBH_Weight_Maximum_User", 103, 455, 22, 48, 147, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "151", "135", "RsComboBox", 0, "MTBH_Length_Average_User_UOM", 131, 135, 22, 52, 148, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "152", "135", "RsComboBox", 0, "MTBH_Length_Maximum_User_UOM", 103, 135, 22, 52, 149, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "153", "135", "RsTextbox", 0, "MTBH_Height_Maximum_User", 103, 330, 22, 48, 150, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "154", "135", "RsTextbox", 0, "MTBH_Height_Minimum_User", 75, 330, 22, 48, 151, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "155", "135", "RsLabel", 0, "", 131, 6, 21, 69, 152, "Average", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "156", "135", "RsTextbox", 0, "MTBH_Width_Maximum_User", 103, 207, 22, 48, 153, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "157", "135", "RsComboBox", 0, "MTBH_Width_Minimum_User_UOM", 75, 261, 22, 52, 154, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "158", "135", "RsTextbox", 0, "MTBH_Width_Minimum_User", 75, 207, 22, 48, 155, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "159", "135", "RsComboBox", 0, "MTBH_Length_Minimum_User_UOM", 75, 135, 22, 52, 156, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "160", "135", "RsTextbox", 0, "MTBH_Length_Minimum_User", 75, 81, 22, 48, 157, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "161", "135", "RsLabel", 0, "", 51, 455, 21, 69, 158, "Weight", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "162", "135", "RsLabel", 0, "", 51, 330, 21, 69, 159, "Height", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "163", "135", "RsLabel", 0, "", 75, 6, 21, 69, 160, "Minimum", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "164", "135", "RsLabel", 0, "", 51, 207, 21, 69, 161, "Width", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "165", "135", "RsLabel", 0, "", 51, 81, 21, 69, 162, "Length", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "166", "135", "RsComboBox", 0, "MTBH_Use_Local", 22, 81, 22, 73, 163, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "167", "135", "RsLabel", 0, "", 22, 6, 21, 69, 164, "Use Local?", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "168", "135", "RsLabel", 0, "", 103, 6, 21, 69, 165, "Maximum", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "169", "15", "RsTabPage", 0, "", 0, 0, 608, 1507, 0, "Output", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 439, "170", "169", "RsGrid", 0, "", 40, 319, 569, 355, 166, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,360,MDR_Transportation_And_Merge_Rates;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 439, "171", "170", "RsGridColumn", 0, "Summary_Carton_Length_User", 0, 0, 0, 90, 0, "Carton Length", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 439, "172", "170", "RsGridColumn", 0, "Summary_Carton_Length_User_UOM", 0, 0, 0, 40, 0, "UOM", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 439, "173", "170", "RsGridColumn", 0, "Summary_Estimated_MDR_Transport_Rates_CPM", 0, 0, 0, 200, 0, "Estimated MDR Transport Rates (CPM)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 439, "174", "169", "RsGrid", 0, "", 40, 680, 569, 827, 167, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,360,MDR_Transportation_And_Merge_Rates;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 439, "175", "174", "RsGridColumn", 0, "Summary_Carton_Length_User", 0, 0, 0, 90, 0, "Carton Length", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 439, "176", "174", "RsGridColumn", 0, "Summary_Carton_Length_User_UOM", 0, 0, 0, 40, 0, "UOM", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 439, "177", "174", "RsGridColumn", 0, "Summary_Estimated_MDR_2_1_Merge_Rates_Main_CPM", 0, 0, 0, 225, 0, "Est MDR 2:1 Merge Rates - Main Line (CPM)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 439, "178", "174", "RsGridColumn", 0, "Summary_Estimated_MDR_2_1_Merge_Rates_Input_CPM", 0, 0, 0, 225, 0, "Est MDR 2:1 Merge Rates - Input Line (CPM)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 439, "179", "174", "RsGridColumn", 0, "Summary_Estimated_MDR_2_1_Merge_Rate_Combined", 0, 0, 0, 225, 0, "Est MDR 2:1 Merge Rate Combine 50-50", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 439, "180", "169", "RsGroupBox", 0, "", 13, 3, 189, 299, 168, "Calculated Rate Results", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "181", "180", "RsLabel", 0, "", 16, 6, 21, 147, 169, "Rate Going Left (CPM)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "182", "180", "RsLabel", 0, "", 44, 6, 21, 147, 170, "Rate Going Right (CPM)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "183", "180", "RsLabel", 0, "", 72, 6, 21, 147, 171, "Rate Going Straight (CPM)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "184", "180", "RsLabel", 0, "", 100, 6, 21, 147, 172, "Calculation Warnings Present", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "185", "180", "RsTextbox", 0, "Results_Rate_Going_Left_CPM", 15, 159, 22, 125, 173, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "186", "180", "RsTextbox", 0, "Results_Rate_Going_Right_CPM", 43, 159, 22, 125, 174, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "187", "180", "RsTextbox", 0, "Results_Rate_Going_Straight_Thru_CPM", 71, 159, 22, 125, 175, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "188", "180", "RsTextbox", 0, "Results_Calculation_Warnings_Present_Qty", 99, 159, 22, 125, 176, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "189", "180", "RsLabel", 0, "", 128, 6, 21, 147, 177, "Calculation Errors Present", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "190", "180", "RsLabel", 0, "", 156, 6, 21, 147, 178, "Total Throughput Rate Possible (CPM)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "191", "180", "RsTextbox", 0, "Results_Calculation_Errors_Present_Qty", 127, 159, 22, 125, 179, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "192", "180", "RsTextbox", 0, "Results_Total_Throughput_Rate_Possible_Display", 155, 159, 22, 125, 180, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "193", "169", "RsGroupBox", 0, "", 208, 3, 386, 299, 181, "Common MDR Parameters &amp;amp; Constants", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "194", "193", "RsTextbox", 0, "MDR_Param_Roller_Dec_Distance_User", 352, 159, 22, 43, 182, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "195", "193", "RsComboBox", 0, "MDR_Param_Speed_FPM_User_UOM", 44, 208, 22, 76, 183, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "196", "193", "RsLabel", 0, "", 325, 6, 21, 147, 184, "Deceleration Time", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "197", "193", "RsTextbox", 0, "MDR_Param_Roller_Dec_Rate_User", 295, 159, 22, 43, 185, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "198", "193", "RsLabel", 0, "", 241, 6, 21, 147, 186, "Acceleration Time", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "199", "193", "RsLabel", 0, "", 297, 6, 21, 147, 187, "Deceleration Rate Rollers", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "200", "193", "RsLabel", 0, "", 16, 6, 21, 147, 188, "Avg Carton Length", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "201", "193", "RsLabel", 0, "", 44, 6, 21, 147, 189, "Speed", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "202", "193", "RsLabel", 0, "", 72, 6, 21, 147, 190, "Speed (ips)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "203", "193", "RsComboBox", 0, "MDR_Param_Roller_Acc_Distance_User_UOM", 268, 208, 22, 76, 191, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "204", "193", "RsTextbox", 0, "MDR_Param_Avg_Carton_Length_User", 16, 159, 22, 43, 192, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "205", "193", "RsLabel", 0, "", 268, 6, 21, 147, 193, "Acceleration Distance", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "206", "193", "RsLabel", 0, "", 100, 6, 21, 147, 194, "Zone Length", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "207", "193", "RsTextbox", 0, "MDR_Param_Roller_Acc_Distance_User", 268, 159, 22, 43, 195, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "208", "193", "RsTextbox", 0, "MDR_Param_Roller_Acc_Rate_User", 211, 159, 22, 43, 196, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "209", "193", "RsComboBox", 0, "MDR_Param_Roller_Dec_Distance_User_UOM", 352, 208, 22, 76, 197, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "210", "193", "RsLabel", 0, "", 184, 6, 21, 147, 198, "Configured Zone Clear Distance (in)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "211", "193", "RsTextbox", 0, "MDR_Param_Conveyor_Width_User", 126, 159, 22, 43, 199, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "212", "193", "RsTextbox", 0, "MDR_Param_Net_Distance_Delta_User", 154, 159, 22, 43, 200, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "213", "193", "RsComboBox", 0, "MDR_Param_Roller_Acc_Rate_User_UOM", 211, 208, 22, 76, 201, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "214", "193", "RsTextbox", 0, "MDR_Param_Configured_Zone_Clear_Distance_IN", 183, 159, 22, 125, 202, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "215", "193", "RsLabel", 0, "", 352, 6, 21, 147, 203, "Deceleration Distance", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "216", "193", "RsLabel", 0, "", 156, 6, 21, 147, 204, "Net Distance Delta", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "217", "193", "RsTextbox", 0, "MDR_Param_Zone_Length_User", 98, 159, 22, 43, 205, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "218", "193", "RsComboBox", 0, "MDR_Param_Net_Distance_Delta_User_UOM", 154, 208, 22, 76, 206, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "219", "193", "RsComboBox", 0, "MDR_Param_Roller_Dec_Rate_User_UOM", 295, 208, 22, 76, 207, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "220", "193", "RsComboBox", 0, "MDR_Param_Conveyor_Width_User_UOM", 126, 208, 22, 76, 208, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "221", "193", "RsTextbox", 0, "MDR_Param_Roller_Dec_Time", 324, 159, 22, 125, 209, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "222", "193", "RsTextbox", 0, "MDR_Param_Speed_IPS_User", 70, 159, 22, 43, 210, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "223", "193", "RsComboBox", 0, "MDR_Param_Zone_Length_User_UOM", 98, 208, 22, 76, 211, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "224", "193", "RsComboBox", 0, "MDR_Param_Speed_IPS_User_UOM", 70, 208, 22, 76, 212, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "225", "193", "RsTextbox", 0, "MDR_Param_Speed_FPM_User", 44, 159, 22, 43, 213, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "226", "193", "RsComboBox", 0, "MDR_Param_Avg_Carton_Length_User_UOM", 16, 208, 22, 76, 214, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 439, "227", "193", "RsTextbox", 0, "MDR_Param_Roller_Acc_Time", 240, 159, 22, 125, 215, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 439, "228", "193", "RsLabel", 0, "", 128, 6, 21, 147, 216, "Conveyor Width (B/F)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "229", "193", "RsLabel", 0, "", 213, 6, 21, 147, 217, "Acceleration Rate Rollers", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "230", "169", "RsLabel", 0, "", 13, 319, 21, 365, 218, "MDR Transportation Rates", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 439, "231", "169", "RsLabel", 0, "", 13, 680, 21, 827, 219, "MDR 2:1 Merge Rates", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Scan_Belt()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(119, "Scan Belt", "Scan Belt", 106, 51, 1, 13, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.App_Calc/CAE_App_Calc.Scan_Belt/CAE_APC_Scan_Belt")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 451, "1", "0", "RsLabel", 0, "", 39, 34, 36, 186, 0, "Scan Belt", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Intro()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(106, "Intro", "", 105, 51, 1, 14, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Header_Hanger/HHS_HeaderHanger_Calc.HHS_Output/HHS_Output_Header")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 336, "1", "0", "RsLabel", 0, "", 10, 14, 36, 384, 0, "Customer / Project Information", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "2", "0", "RsGroupBox", 0, "", 148, 12, 181, 744, 1, "Site / Customer Information", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 336, "3", "2", "RsTextbox", 0, "Proposal_Customer_Name", 34, 127, 32, 528, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 336, "4", "2", "RsTextbox", 0, "Proposal_City_State", 72, 127, 32, 528, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 336, "5", "2", "RsTextbox", 0, "Proposal_ID", 110, 127, 32, 528, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 336, "6", "2", "RsTextbox", 0, "Proposal_Description", 145, 127, 32, 528, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 336, "7", "2", "RsLabel", 0, "", 106, 35, 32, 86, 6, "Proposal #:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "8", "2", "RsLabel", 0, "", 141, 22, 32, 99, 7, "Application:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "9", "2", "RsLabel", 0, "", 68, 6, 32, 115, 8, "Location (City, St):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "10", "2", "RsLabel", 0, "", 35, 35, 16, 86, 9, "Customer Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "11", "0", "RsGroupBox", 0, "", 49, 12, 93, 744, 10, "Instructions / Notes", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 336, "12", "11", "RsLabel", 0, "", 28, 22, 49, 706, 11, "Complete the information below from the ePRD.  Then move on to the HCAD Step to import  the Block Data From AutoCAD", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Header_Hanger_Import()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(78, "Header Hanger Import", "", 105, 51, 1, 15, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Header_Hanger/HHS_HeaderHanger_Calc.HHS_Importer/HHS_DWGXLSX_Importer")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 334, "1", "0", "RsLabel", 0, "", 9, 12, 36, 384, 0, "AutoCAD Block Input", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 334, "2", "0", "RsGroupBox", 0, "", 48, 12, 106, 758, 1, "Instructions / Notes", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 334, "3", "2", "RsLabel", 0, "", 26, 6, 68, 734, 2, "Following the instructions on Header Hanger Spreadsheet, extract the blocks pertaining to header hanger components. Copy and Paste the extracted output into the box below. Select the appropriate Siesmic rate based on the site lcoation, and adjust the Hanger  spacing accordingly.", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 334, "4", "0", "RsGroupBox", 0, "", 160, 438, 106, 332, 3, "Additional Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 334, "5", "4", "RsLabel", 0, "", 33, 6, 20, 106, 4, "Seismi Requirement", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 334, "6", "4", "RsComboBox", 0, "Seismic_Requirement", 27, 118, 26, 208, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 334, "7", "4", "RsLabel", 0, "", 53, 260, 28, 66, 6, "(feet)", 0, 0, 0, 4, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 334, "8", "4", "RsLabel", 0, "", 53, 18, 28, 94, 7, "Hanger Spacing", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 334, "9", "4", "RsComboBox", 0, "Hanger_Spacing", 54, 118, 28, 136, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 334, "10", "0", "RsGroupBox", 0, "", 160, 12, 538, 420, 9, "Block Data From Excel", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 334, "11", "10", "RsTextbox", 0, "HHS_Input_Text_Tab_Formatted", 27, 6, 499, 408, 10, "", -1, 0, 0, 4, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 334, "12", "10", "RsGrid", 0, "", 53, 17, 273, 322, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:,0,;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 334, "13", "0", "RsGroupBox", 0, "", 272, 438, 426, 332, 12, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Detailed_Comp_View()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(107, "Detailed Comp View", "", 105, 51, 1, 16, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Header_Hanger/HHS_HeaderHanger_Calc.HHS_Output/HHS_Output_Header")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 336, "1", "0", "RsGroupBox", 0, "", 754, 18, 65, 1045, 0, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 336, "2", "1", "RsTextbox", 0, "Total_Cost", 12, 935, 19, 104, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 336, "3", "1", "RsLabel", 0, "", 12, 851, 22, 78, 2, "Total Cost:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "4", "1", "RsLabel", 0, "", 40, 823, 22, 106, 3, "Cost Per Hanger:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "5", "1", "RsTextbox", 0, "Cost_Per_Hanger", 37, 935, 19, 104, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 336, "6", "0", "RsLabel", 0, "", 9, 12, 33, 479, 5, "Detailed Component View", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "7", "0", "RsGroupBox", 0, "", 38, 12, 789, 1057, 6, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
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
        Private Sub Initialize_Process_DefaultProcess_BOM_View()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(108, "BOM View", "", 105, 51, 1, 17, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Header_Hanger/HHS_HeaderHanger_Calc.HHS_Output/HHS_Output_Header")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 336, "1", "0", "RsLabel", 0, "", 18, 12, 31, 505, 0, "Bill Of Material", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 336, "2", "0", "RsGroupBox", 0, "", 44, 12, 638, 1008, 1, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
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
        Private Sub Initialize_Process_DefaultProcess_EQS_Import()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(76, "EQS Import", "", 102, 51, 1, 18, 50, 50)
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
        oProcessStep = AddProcessStep(85, "Conveyer Electrical Installation", "", 102, 51, 1, 19, 50, 50)
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
        oProcessStep = AddProcessStep(86, "Conveyor Electrical Installation IGS Personnel", "", 102, 51, 1, 20, 50, 50)
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
        oProcessStep = AddProcessStep(87, "Base_Options_Alternates Elec Delta", "", 102, 51, 1, 21, 50, 50)
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
        oProcessStep = AddProcessStep(89, "Power Feeds", "", 102, 51, 1, 22, 50, 50)
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
        oProcessStep = AddProcessStep(90, "Shuttle Elec", "", 102, 51, 1, 23, 50, 50)
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
        oProcessStep = AddProcessStep(93, "TTCB Costing Elec", "", 102, 51, 1, 24, 50, 50)
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
        oProcessStep = AddProcessStep(88, "Output Elec", "", 102, 51, 1, 25, 50, 50)
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
        oProcessStep = AddProcessStep(72, "HCAD Import", "", 101, 51, 1, 26, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsGrid", 0, "", 12, 12, 393, 364, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,252,Control_Panels;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 360, "2", "1", "RsGridColumn", 0, "DATA_CPNumber", 0, 0, 0, 150, 0, "CP Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "3", "1", "RsGridColumn", 0, "bool_Include_In_Subsystem", 0, 0, 0, 150, 0, "Include In System", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "4", "0", "RsGrid", 0, "", 12, 411, 393, 236, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,285,Base_Options_Alternates;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 360, "5", "4", "RsGridColumn", 0, "DisplayName", 0, 0, 0, 100, 0, "System Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "6", "0", "RsAddDeleteCopy", 0, "", 411, 218, 22, 158, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,252,Control_Panels;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 360, "7", "0", "RsSubForm", 0, "", 439, 12, 484, 1192, 3, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,252,Control_Panels")
        oProcessStep.AddCustomLayout(1, 360, "8", "7", "RsTabControl", 0, "", 3, 3, 469, 1189, 4, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "9", "8", "RsTabPage", 0, "", 0, 0, 0, 0, 0, "Models", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "10", "9", "RsLabel", 0, "", 319, 3, 21, 131, 5, "Spiral Curve Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "11", "9", "RsGroupBox", 0, "", 3, 539, 49, 219, 6, "Misc", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "12", "11", "RsTextbox", 0, "HCAD_Misc_Hours", 15, 95, 22, 109, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "13", "11", "RsLabel", 0, "", 16, 6, 21, 83, 8, "Misc Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "14", "9", "RsTextbox", 0, "HCAD_ECCTrashBelt_Total_Units", 151, 392, 22, 109, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "15", "9", "RsTextbox", 0, "HCAD_IntelliFlow_Total_Footage", 234, 140, 22, 109, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "16", "9", "RsTextbox", 0, "HCAD_IntelliQAccuglide_Total_Footage", 10, 140, 22, 109, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "17", "9", "RsTextbox", 0, "HCAD_FlatBeltCurves_Total_Footage", 178, 140, 22, 109, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "18", "9", "RsTextbox", 0, "HCAD_IntelliFlow_Total_Units", 235, 392, 22, 109, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "19", "9", "RsLabel", 0, "", 151, 269, 21, 117, 14, "ECC Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "20", "9", "RsLabel", 0, "", 235, 269, 21, 117, 15, "Intelliflow Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "21", "9", "RsTextbox", 0, "HCAD_WheelDivert_Total_Footage", 374, 140, 22, 109, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "22", "9", "RsTextbox", 0, "HCAD_SpiralCurvessets_Total_Footage", 318, 140, 22, 109, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "23", "9", "RsTextbox", 0, "HCAD_Chutes_Total_Footage", 122, 140, 22, 109, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "24", "9", "RsLabel", 0, "", 375, 3, 21, 131, 19, "Wheel Sorter Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "25", "9", "RsTextbox", 0, "HCAD_ShoeSorter_Total_Footage", 290, 140, 22, 109, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "26", "9", "RsLabel", 0, "", 95, 3, 21, 131, 21, "Belt Staging Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "27", "9", "RsTextbox", 0, "HCAD_WheelDivert_Total_Units", 375, 392, 22, 109, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "28", "9", "RsTextbox", 0, "HCAD_SpiralCurvessets_Total_Units", 319, 392, 22, 109, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "29", "9", "RsLabel", 0, "", 291, 3, 21, 131, 24, "Shoe Sorter Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "30", "9", "RsLabel", 0, "", 123, 3, 21, 131, 25, "Chutes Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "31", "9", "RsLabel", 0, "", 375, 269, 21, 117, 26, "Wheel Sorter Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "32", "9", "RsLabel", 0, "", 319, 269, 21, 117, 27, "Spiral Curve Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "33", "9", "RsLabel", 0, "", 11, 269, 21, 117, 28, "Accuglide/IQZF Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "34", "9", "RsTextbox", 0, "HCAD_ShoeSorter_Total_Units", 291, 392, 22, 109, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "35", "9", "RsTextbox", 0, "HCAD_IntelliMerge_Total_Footage", 262, 140, 22, 109, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "36", "9", "RsLabel", 0, "", 291, 269, 21, 117, 31, "Shoe Sorter Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "37", "9", "RsLabel", 0, "", 179, 3, 21, 131, 32, "Flat Belt Curve Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "38", "9", "RsLabel", 0, "", 263, 3, 21, 131, 33, "Intellimerge Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "39", "9", "RsLabel", 0, "", 67, 3, 21, 131, 34, "Brake Belt/Meter Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "40", "9", "RsLabel", 0, "", 95, 269, 21, 117, 35, "Belt Staging Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "41", "9", "RsTextbox", 0, "HCAD_IntelliMerge_Total_Units", 263, 392, 22, 109, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "42", "9", "RsLabel", 0, "", 235, 3, 21, 131, 37, "Intelliflow Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "43", "9", "RsTextbox", 0, "HCAD_BeltonRoller_Total_Units", 39, 392, 22, 109, 38, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "44", "9", "RsLabel", 0, "", 263, 269, 21, 117, 39, "Intellimerge Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "45", "9", "RsTextbox", 0, "HCAD_IntelliQAccuglide_Total_Units", 11, 392, 22, 109, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "46", "9", "RsTextbox", 0, "HCAD_ECCTrashBelt_Total_Footage", 150, 140, 22, 109, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "47", "9", "RsTextbox", 0, "HCAD_FlatBeltCurves_Total_Units", 179, 392, 22, 109, 42, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "48", "9", "RsTextbox", 0, "HCAD_VBelt_Total_Footage", 346, 140, 22, 109, 43, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "49", "9", "RsLabel", 0, "", 151, 3, 21, 131, 44, "ECC Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "50", "9", "RsLabel", 0, "", 11, 3, 21, 131, 45, "Accuglide/IQZF Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "51", "9", "RsLabel", 0, "", 179, 269, 21, 117, 46, "Flat Belt Curve Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "52", "9", "RsTextbox", 0, "HCAD_BeltStaging_Total_Footage", 94, 140, 22, 109, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "53", "9", "RsTextbox", 0, "HCAD_Chutes_Total_Units", 123, 392, 22, 109, 48, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "54", "9", "RsLabel", 0, "", 346, 36, 21, 97, 49, "V Belt Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "55", "9", "RsLabel", 0, "", 123, 269, 21, 117, 50, "Chutes Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "56", "9", "RsTextbox", 0, "HCAD_VBelt_Total_Units", 346, 392, 22, 109, 51, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "57", "9", "RsTextbox", 0, "HCAD_BeltBrakeMeter_Total_Footage", 66, 140, 22, 109, 52, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "58", "9", "RsLabel", 0, "", 346, 297, 21, 88, 53, "V Belt Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "59", "9", "RsTextbox", 0, "HCAD_BeltStaging_Total_Units", 95, 392, 22, 109, 54, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "60", "9", "RsTextbox", 0, "HCAD_BeltonRoller_Total_Footage", 38, 140, 22, 109, 55, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "61", "9", "RsTextbox", 0, "HCAD_BeltBrakeMeter_Total_Units", 67, 392, 22, 109, 56, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "62", "9", "RsLabel", 0, "", 39, 3, 21, 131, 57, "Belt Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "63", "9", "RsLabel", 0, "", 67, 269, 21, 117, 58, "Brake Belt/Meter Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "64", "9", "RsLabel", 0, "", 39, 269, 21, 117, 59, "Belt Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "65", "9", "RsTextbox", 0, "HCAD_Gravity_Total_Footage", 206, 140, 22, 109, 60, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "66", "9", "RsLabel", 0, "", 206, 36, 21, 97, 61, "Gravity Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "67", "9", "RsTextbox", 0, "HCAD_Gravity_Total_Units", 205, 392, 22, 109, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "68", "9", "RsLabel", 0, "", 205, 297, 21, 88, 63, "Gravity Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "69", "9", "RsGroupBox", 0, "", 3, 764, 105, 414, 64, "MDR", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "70", "69", "RsTextbox", 0, "HCAD_MDR_Gates", 70, 291, 22, 109, 65, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "71", "69", "RsTextbox", 0, "HCAD_MDR_Total_Footage", 15, 95, 22, 109, 66, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "72", "69", "RsLabel", 0, "", 16, 6, 21, 83, 67, "MDR Footage", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "73", "69", "RsTextbox", 0, "HCAD_MDR_Total_Units", 43, 95, 22, 109, 68, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "74", "69", "RsTextbox", 0, "HCAD_MDR_Total_Hours", 71, 95, 22, 109, 69, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "75", "69", "RsLabel", 0, "", 43, 25, 21, 64, 70, "MDR Units", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "76", "69", "RsLabel", 0, "", 71, 25, 21, 64, 71, "MDR Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "77", "69", "RsTextbox", 0, "HCAD_MDR_Pneumatic_Transfers", 14, 291, 22, 109, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "78", "69", "RsLabel", 0, "", 15, 220, 21, 65, 73, "Transfers", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "79", "69", "RsTextbox", 0, "HCAD_MDR_Pneumatic_Diverts", 42, 291, 22, 109, 74, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "80", "69", "RsLabel", 0, "", 70, 220, 21, 65, 75, "Gates", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "81", "69", "RsLabel", 0, "", 42, 220, 21, 65, 76, "Diverts", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "82", "8", "RsTabPage", 0, "", 0, 0, 0, 0, 0, "Hours", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "83", "82", "RsLabel", 0, "", 320, 3, 21, 131, 77, "Spiral Curve Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "84", "82", "RsLabel", 0, "", 376, 3, 21, 131, 78, "Wheel Sorter Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "85", "82", "RsLabel", 0, "", 96, 3, 21, 131, 79, "Belt Staging Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "86", "82", "RsLabel", 0, "", 292, 3, 21, 131, 80, "Shoe Sorter Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "87", "82", "RsLabel", 0, "", 124, 3, 21, 131, 81, "Chutes Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "88", "82", "RsLabel", 0, "", 180, 3, 21, 131, 82, "Flat Belt Curve Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "89", "82", "RsLabel", 0, "", 264, 3, 21, 131, 83, "Intellimerge Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "90", "82", "RsTextbox", 0, "HCAD_IntelliFlow_Total_Hours", 235, 152, 22, 109, 84, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "91", "82", "RsLabel", 0, "", 68, 3, 21, 131, 85, "Brake Belt/Meter Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "92", "82", "RsTextbox", 0, "HCAD_IntelliQAccuglide_Total_Hours", 11, 152, 22, 109, 86, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "93", "82", "RsLabel", 0, "", 236, 3, 21, 131, 87, "Intelliflow Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "94", "82", "RsTextbox", 0, "HCAD_FlatBeltCurves_Total_Hours", 179, 152, 22, 109, 88, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "95", "82", "RsLabel", 0, "", 152, 3, 21, 131, 89, "ECC Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "96", "82", "RsTextbox", 0, "HCAD_WheelDivert_Total_Hours", 375, 152, 22, 109, 90, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "97", "82", "RsLabel", 0, "", 11, 3, 21, 131, 91, "Accuglide/IQZF Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "98", "82", "RsTextbox", 0, "HCAD_SpiralCurvessets_Total_Hours", 319, 152, 22, 109, 92, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "99", "82", "RsLabel", 0, "", 347, 36, 21, 97, 93, "V Belt Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "100", "82", "RsTextbox", 0, "HCAD_Chutes_Total_Hours", 123, 152, 22, 109, 94, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "101", "82", "RsLabel", 0, "", 40, 3, 21, 131, 95, "Belt Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "102", "82", "RsLabel", 0, "", 207, 36, 21, 97, 96, "Gravity Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "103", "82", "RsTextbox", 0, "HCAD_ShoeSorter_Total_Hours", 291, 152, 22, 109, 97, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "104", "82", "RsTextbox", 0, "HCAD_IntelliMerge_Total_Hours", 263, 152, 22, 109, 98, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "105", "82", "RsTextbox", 0, "HCAD_ECCTrashBelt_Total_Hours", 151, 152, 22, 109, 99, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "106", "82", "RsTextbox", 0, "HCAD_VBelt_Total_PHours", 347, 152, 22, 109, 100, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "107", "82", "RsTextbox", 0, "HCAD_BeltStaging_Total_Hours", 95, 152, 22, 109, 101, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "108", "82", "RsTextbox", 0, "HCAD_BeltBrakeMeter_Total_Hours", 67, 152, 22, 109, 102, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "109", "82", "RsTextbox", 0, "HCAD_BeltonRoller_Total_Hours", 39, 152, 22, 109, 103, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "110", "82", "RsTextbox", 0, "HCAD_Gravity_Total_Hours", 207, 152, 22, 109, 104, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "111", "8", "RsTabPage", 0, "", 0, 0, 0, 0, 0, "Air Piping Hours", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "112", "111", "RsTextbox", 0, "Air_Piping_AC", 207, 107, 22, 125, 105, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "113", "111", "RsTextbox", 0, "Air_Piping_212_inches_pipe", 39, 107, 22, 125, 106, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "114", "111", "RsTextbox", 0, "Air_Piping_Dryer", 264, 107, 22, 125, 107, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "115", "111", "RsTextbox", 0, "Air_Piping_RedAC", 236, 107, 22, 125, 108, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "116", "111", "RsLabel", 0, "", 95, 14, 21, 78, 109, "7/8&amp;quot; pipe", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "117", "111", "RsTextbox", 0, "Air_Piping_FILTERREG", 179, 107, 22, 125, 110, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "118", "111", "RsTextbox", 0, "Air_Piping_12_inches_pipe", 123, 107, 22, 125, 111, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "119", "111", "RsTextbox", 0, "Air_Piping_Tubing", 151, 107, 22, 125, 112, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "120", "111", "RsTextbox", 0, "Air_Piping_78_inches_pipe", 95, 107, 22, 125, 113, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "121", "111", "RsTextbox", 0, "Air_Piping_112_inches_pipe", 67, 107, 22, 125, 114, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "122", "111", "RsLabel", 0, "", 264, 14, 19, 78, 115, "Dryer", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "123", "111", "RsLabel", 0, "", 123, 14, 21, 78, 116, "1/2&amp;quot; pipe", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "124", "111", "RsTextbox", 0, "Air_Piping_3pipe", 11, 107, 22, 125, 117, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "125", "111", "RsLabel", 0, "", 236, 14, 21, 78, 118, "Red A/C", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "126", "111", "RsLabel", 0, "", 207, 14, 21, 78, 119, "A/C", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "127", "111", "RsLabel", 0, "", 151, 14, 21, 78, 120, "Tubing", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "128", "111", "RsLabel", 0, "", 179, 14, 21, 78, 121, "FILTER/REG", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "129", "111", "RsLabel", 0, "", 39, 14, 21, 78, 122, "2 1/2&amp;quot; pipe", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "130", "111", "RsLabel", 0, "", 67, 14, 21, 78, 123, "1 1/2&amp;quot; pipe", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "131", "111", "RsLabel", 0, "", 11, 14, 21, 78, 124, "3&amp;quot; pipe", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "132", "8", "RsTabPage", 0, "", 0, 0, 0, 0, 0, "Miscellaneous Hours", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "133", "132", "RsGrid", 0, "", 23, 20, 408, 624, 125, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,210,My_Misc_Hours;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 360, "134", "133", "RsGridColumn", 0, "Misc_Description", 0, 0, 0, 100, 0, "Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "135", "133", "RsGridColumn", 0, "Misc_Dollars", 0, 0, 0, 100, 0, "Dollars", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "136", "133", "RsGridColumn", 0, "Misc_Quantity", 0, 0, 0, 100, 0, "Quantity", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "137", "133", "RsGridColumn", 0, "Misc_Hours", 0, 0, 0, 100, 0, "Hours", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "138", "133", "RsGridColumn", 0, "Misc_Air", 0, 0, 0, 100, 0, "Air", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "139", "133", "RsGridColumn", 0, "Misc_Factor", 0, 0, 0, 100, 0, "Metric", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "140", "8", "RsTabPage", 0, "", 0, 0, 0, 0, 0, "Flow Package Hours", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "141", "140", "RsGrid", 0, "", 23, 20, 408, 424, 126, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,211,My_Package_Flow_Hours;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 360, "142", "141", "RsGridColumn", 0, "Package_Description", 0, 0, 0, 100, 0, "Package_Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "143", "141", "RsGridColumn", 0, "Quantity_per_Feet", 0, 0, 0, 100, 0, "Quantity per Feet", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "144", "141", "RsGridColumn", 0, "Flow_Rate", 0, 0, 0, 100, 0, "Metrics", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "145", "141", "RsGridColumn", 0, "Hours", 0, 0, 0, 100, 0, "Hours", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "146", "8", "RsTabPage", 0, "", 0, 0, 0, 0, 0, "Pallet Conveyor Hours", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "147", "146", "RsGrid", 0, "", 23, 20, 408, 626, 127, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:C,212,My_Pallet_Conveyor_Hours;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 360, "148", "147", "RsGridColumn", 0, "Pallet_Conveyor_Range", 0, 0, 0, 100, 0, "Pallet Conveyor Range", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "149", "147", "RsGridColumn", 0, "Pallet_Conveyor_Quantity", 0, 0, 0, 100, 0, "Quantity", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "150", "147", "RsGridColumn", 0, "Pallet_Conveyor_Factor", 0, 0, 0, 100, 0, "Metrics", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "151", "147", "RsGridColumn", 0, "Pallet_Conveyor_Hours", 0, 0, 0, 100, 0, "Hours", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "152", "147", "RsGridColumn", 0, "Pallet_Conveyor_Air", 0, 0, 0, 100, 0, "Air", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "153", "147", "RsGridColumn", 0, "Pallet_Conveyor_Footage", 0, 0, 0, 100, 0, "Footage", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "154", "0", "RsGroupBox", 0, "", 127, 727, 95, 477, 128, "HCAD Import", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "155", "154", "RsActionButton", 0, "", 43, 367, 27, 83, 129, "Import", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ImportHCADPricingSheetData;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 360, "156", "154", "RsFileImporter", 0, "", 19, 6, 51, 355, 130, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;SpecName:HCAD_Import_File_Import")
        oProcessStep.AddCustomLayout(1, 360, "157", "0", "RsGroupBox", 0, "", 228, 727, 77, 477, 131, "Base/Option/Alternate Construction", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "158", "157", "RsLabel", 0, "", 31, 6, 21, 55, 132, "Name", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "159", "157", "RsTextbox", 0, "Base_Option_Alternate_Name", 30, 67, 22, 194, 133, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "160", "157", "RsActionButton", 0, "", 25, 367, 27, 83, 134, "Build", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:bool_Unique_System_Name;FunctionToCall:MechBuildOption;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 360, "161", "0", "RsGroupBox", 0, "", 311, 963, 47, 241, 135, "Mech Install Properties", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "162", "161", "RsLabel", 0, "", 16, 6, 21, 101, 136, "Air Piping Factor", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "163", "161", "RsComboBox", 0, "AirPipingFactor", 15, 113, 22, 125, 137, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "164", "0", "RsGroupBox", 0, "", 12, 939, 109, 265, 138, "Customer Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "165", "164", "RsLabel", 0, "", 58, 6, 21, 107, 139, "Location", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "166", "164", "RsLabel", 0, "", 16, 6, 21, 107, 140, "Project Number", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "167", "164", "RsTextbox", 0, "CAE_Quote_Date", 78, 119, 22, 125, 141, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "168", "164", "RsTextbox", 0, "CAE_Customer_Location", 58, 119, 22, 125, 142, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "169", "164", "RsTextbox", 0, "CAE_Customer", 36, 119, 22, 125, 143, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "170", "164", "RsTextbox", 0, "CAE_Customer_Project_Number", 15, 119, 22, 125, 144, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "171", "164", "RsLabel", 0, "", 79, 6, 21, 107, 145, "Quote Date", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "172", "164", "RsLabel", 0, "", 37, 6, 21, 107, 146, "Customer", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Conveyor_Mechanical_Installation()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(80, "Conveyor Mechanical Installation", "", 101, 51, 1, 27, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsLabel", 0, "", 9, 12, 21, 67, 0, "Subsystem", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "2", "0", "RsSubForm", 0, "", 36, 807, 808, 789, 1, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,130,My_Conveyor_Intelligrated")
        oProcessStep.AddCustomLayout(1, 360, "3", "2", "RsGroupBox", 0, "", 3, 6, 805, 783, 2, "Intelligrated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "4", "3", "RsTabControl", 0, "", 35, 22, 659, 708, 3, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "5", "4", "RsTabPage", 0, "", 0, 0, 633, 700, 0, "Inputs", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "6", "5", "RsGroupBox", 0, "", 514, 22, 109, 393, 4, "HSE Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "7", "6", "RsLabel", 0, "", 19, 13, 22, 94, 5, "HSE Wages", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "8", "6", "RsTextbox", 0, "HSE_Wages_Headcount", 19, 113, 22, 80, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "9", "6", "RsTextbox", 0, "HSE_Per_Diem_Rate_Cost", 47, 285, 22, 80, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "10", "6", "RsTextbox", 0, "HSE_Per_Diem_Rate_Headcount", 47, 113, 22, 80, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "11", "6", "RsTextbox", 0, "HSE_Wages_Total_Cost", 75, 285, 22, 80, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "12", "6", "RsTextbox", 0, "HSE_Wages_Cost", 19, 285, 22, 80, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "13", "6", "RsTextbox", 0, "HSE_Per_Diem_Rate", 47, 199, 22, 80, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "14", "6", "RsTextbox", 0, "HSE_Wages_Rate", 19, 199, 22, 80, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "15", "6", "RsLabel", 0, "", 47, 13, 22, 94, 13, "HSE Per Diem Rate", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "16", "6", "RsLabel", 0, "", 75, 13, 22, 94, 14, "Total", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "17", "5", "RsGroupBox", 0, "", 6, 21, 179, 394, 15, "Schedule", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "18", "17", "RsTextbox", 0, "Schedule_Total_Project_Duration_Weeks", 137, 294, 22, 80, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "19", "17", "RsLabel", 0, "", 109, 215, 22, 73, 17, "Commissioning", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "20", "17", "RsLabel", 0, "", 17, 294, 19, 80, 18, "Weeks", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "21", "17", "RsLabel", 0, "", 75, 220, 22, 68, 19, "Install", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "22", "17", "RsLabel", 0, "", 39, 215, 22, 73, 20, "Pre-Install", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "23", "17", "RsLabel", 0, "", 140, 13, 29, 110, 21, "Turnover to Customer (Go-Live)", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "24", "17", "RsSingleDatePicker", 0, "Schedule_Start_Mechanical_Install", 41, 129, 20, 80, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 360, "25", "17", "RsSingleDatePicker", 0, "Schedule_Turnover_to_Customer_Go_Live", 143, 129, 20, 80, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 360, "26", "17", "RsTextbox", 0, "Schedule_Commissioning_Duration_Weeks", 109, 294, 22, 80, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "27", "17", "RsSingleDatePicker", 0, "Schedule_End_Run_to_In_Level_5", 109, 129, 20, 80, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 360, "28", "17", "RsSingleDatePicker", 0, "Schedule_End_Mechanical_Install", 75, 129, 20, 80, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 360, "29", "17", "RsTextbox", 0, "Schedule_Install_Duration_Weeks", 75, 294, 22, 80, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "30", "17", "RsTextbox", 0, "Schedule_Pre_Install_Duration_Weeks", 39, 294, 22, 80, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "31", "17", "RsLabel", 0, "", 131, 215, 32, 73, 29, "Total Project Duration", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "32", "17", "RsLabel", 0, "", 41, 13, 28, 110, 30, "Start In-house Engineering", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "33", "17", "RsLabel", 0, "", 77, 13, 22, 110, 31, "Start Mechanical Install", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "34", "17", "RsLabel", 0, "", 113, 13, 22, 110, 32, "End Mechanical Install", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "35", "5", "RsGroupBox", 0, "", 194, 21, 111, 394, 33, "Support", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "36", "35", "RsLabel", 0, "", 52, 251, 19, 80, 34, "Hrs/Wk", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "37", "35", "RsTextbox", 0, "Support_Superintendent_Hrs_per_Wk", 24, 151, 19, 80, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "38", "35", "RsTextbox", 0, "Support_Lead_Men_Hrs_per_Wk", 52, 151, 19, 80, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "39", "35", "RsLabel", 0, "", 24, 46, 19, 89, 37, "Superintendent", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "40", "35", "RsLabel", 0, "", 24, 251, 19, 80, 38, "Hrs/Wk", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "41", "35", "RsLabel", 0, "", 80, 251, 19, 80, 39, "Hrs/Wk", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "42", "35", "RsTextbox", 0, "Support_Project_Administrative_Hrs_per_Wk", 80, 151, 19, 80, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "43", "35", "RsLabel", 0, "", 52, 46, 19, 89, 41, "Lead Men", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "44", "35", "RsLabel", 0, "", 80, 20, 19, 115, 42, "Project (Administrative)", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "45", "5", "RsGroupBox", 0, "", 393, 21, 115, 393, 43, "Crew Mobilization Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "46", "45", "RsLabel", 0, "", 10, 122, 22, 126, 44, "Crew Mobilization Cost", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "47", "45", "RsTextbox", 0, "Crew_Mobilization_Cost_per_person", 10, 266, 22, 80, 45, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "48", "45", "RsLabel", 0, "", 40, 5, 28, 80, 46, "Crew", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "49", "45", "RsLabel", 0, "", 40, 91, 28, 80, 47, "Mobilization Count", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "50", "45", "RsTextbox", 0, "Crew_Lead_Man_Mobilization_Count", 75, 91, 22, 80, 48, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "51", "45", "RsLabel", 0, "", 40, 177, 28, 80, 49, "Headcount", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "52", "45", "RsTextbox", 0, "Crew_Lead_Man_Total_Mobilization_Cost", 75, 266, 22, 80, 50, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "53", "45", "RsTextbox", 0, "Crew_Lead_Man_Headcount", 75, 177, 22, 80, 51, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "54", "45", "RsLabel", 0, "", 40, 266, 28, 80, 52, "Total Mobilization Cost", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "55", "45", "RsLabel", 0, "", 75, 5, 22, 80, 53, "Lead Man", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "56", "5", "RsGroupBox", 0, "", 315, 20, 71, 394, 54, "Site Needs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "57", "56", "RsLabel", 0, "", 16, 151, 19, 80, 55, "Install", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "58", "56", "RsTextbox", 0, "Site_Needs_Lead_Men_Install", 44, 151, 19, 80, 56, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "59", "56", "RsTextbox", 0, "Site_Needs_Lead_Men_Commissioning", 44, 251, 19, 80, 57, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "60", "56", "RsLabel", 0, "", 16, 251, 19, 80, 58, "Comm", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "61", "56", "RsLabel", 0, "", 44, 46, 19, 89, 59, "# Lead Men", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "62", "4", "RsTabPage", 0, "", 0, 0, 633, 700, 0, "Equipment Rentals", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "63", "62", "RsGroupBox", 0, "", 24, 24, 404, 484, 103, "Equipment Rentals", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "64", "63", "RsLabel", 0, "", 7, 391, 35, 80, 104, "Total Cost", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "65", "63", "RsTextbox", 0, "EQ_Rental_Small_Scissors_Lift_Quantity", 50, 133, 22, 80, 105, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "66", "63", "RsTextbox", 0, "EQ_Rental_Small_Scissors_Lift_Duration", 50, 219, 22, 80, 106, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "67", "63", "RsLabel", 0, "", 104, 6, 21, 111, 107, "Small Boom Lift", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "68", "63", "RsTextbox", 0, "EQ_Rental_Small_Scissors_Lift_Wkly_Rate", 50, 305, 22, 80, 108, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "69", "63", "RsTextbox", 0, "EQ_Rental_Small_Scissors_Lift_Total_Cost", 50, 391, 22, 80, 109, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "70", "63", "RsTextbox", 0, "EQ_Rental_Large_Scissor_Lift_Quantity", 77, 133, 22, 80, 110, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "71", "63", "RsTextbox", 0, "EQ_Rental_Large_Scissor_Lift_Duration", 77, 219, 22, 80, 111, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "72", "63", "RsTextbox", 0, "EQ_Rental_Large_Scissor_Lift_Wkly_Rate", 77, 305, 22, 80, 112, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "73", "63", "RsTextbox", 0, "EQ_Rental_Large_Scissor_Lift_Total_Cost", 77, 391, 22, 80, 113, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "74", "63", "RsTextbox", 0, "EQ_Rental_Small_Boom_Lift_Quantity", 104, 133, 22, 80, 114, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "75", "63", "RsTextbox", 0, "EQ_Rental_Small_Boom_Lift_Duration", 104, 219, 22, 80, 115, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "76", "63", "RsTextbox", 0, "EQ_Rental_Small_Boom_Lift_Wkly_Rate", 104, 305, 22, 80, 116, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "77", "63", "RsLabel", 0, "", 7, 305, 35, 80, 117, "Weekly Rate", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "78", "63", "RsTextbox", 0, "EQ_Rental_Small_Boom_Lift_Total_Cost", 104, 391, 22, 80, 118, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "79", "63", "RsTextbox", 0, "EQ_Rental_Large_Boom_Lift_Quantity", 131, 133, 22, 80, 119, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "80", "63", "RsTextbox", 0, "EQ_Rental_Large_Boom_Lift_Duration", 131, 219, 22, 80, 120, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "81", "63", "RsLabel", 0, "", 293, 6, 21, 111, 121, "Welders", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "82", "63", "RsTextbox", 0, "EQ_Rental_Large_Boom_Lift_Wkly_Rate", 131, 305, 22, 80, 122, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "83", "63", "RsTextbox", 0, "EQ_Rental_Large_Boom_Lift_Total_Cost", 131, 391, 22, 80, 123, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "84", "63", "RsTextbox", 0, "EQ_Rental_Small_TelehandlerQuantity", 158, 133, 22, 80, 124, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "85", "63", "RsTextbox", 0, "EQ_Rental_Small_Telehandler_Duration", 158, 219, 22, 80, 125, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "86", "63", "RsTextbox", 0, "EQ_Rental_Small_Telehandler_Wkly_Rate", 158, 305, 22, 80, 126, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "87", "63", "RsTextbox", 0, "EQ_Rental_Small_Telehandler_Total_Cost", 158, 391, 22, 80, 127, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "88", "63", "RsTextbox", 0, "EQ_Rental_Large_Telehandler_Quantity", 185, 133, 22, 80, 128, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "89", "63", "RsTextbox", 0, "EQ_Rental_Large_Telehandler_Duration", 185, 219, 22, 80, 129, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "90", "63", "RsTextbox", 0, "EQ_Rental_Large_Telehandler_Wkly_Rate", 185, 305, 22, 80, 130, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "91", "63", "RsTextbox", 0, "EQ_Rental_Large_Telehandler_Total_Cost", 185, 391, 22, 80, 131, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "92", "63", "RsTextbox", 0, "EQ_Rental_Fork_Truck_Quantity", 212, 133, 22, 80, 132, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "93", "63", "RsTextbox", 0, "EQ_Rental_Fork_Truck_Duration", 212, 219, 22, 80, 133, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "94", "63", "RsTextbox", 0, "EQ_Rental_Fork_Truck_Wkly_Rate", 212, 305, 22, 80, 134, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "95", "63", "RsTextbox", 0, "EQ_Rental_Fork_Truck_Total_Cost", 212, 391, 22, 80, 135, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "96", "63", "RsTextbox", 0, "EQ_Rental_Cranes_Small_indoors_Quantity", 239, 133, 22, 80, 136, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "97", "63", "RsTextbox", 0, "EQ_Rental_Cranes_Small_indoors_Duration", 239, 219, 22, 80, 137, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "98", "63", "RsLabel", 0, "", 158, 5, 21, 111, 138, "Small Telehandler", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "99", "63", "RsTextbox", 0, "EQ_Rental_Cranes_Small_indoors_Wkly_Rate", 239, 305, 22, 80, 139, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "100", "63", "RsTextbox", 0, "EQ_Rental_Crane_Large_Outdoor_Total_Cost", 239, 391, 22, 80, 140, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "101", "63", "RsTextbox", 0, "EQ_Rental_Crane_Large_Outdoor_Quantity", 266, 133, 22, 80, 141, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "102", "63", "RsTextbox", 0, "EQ_Rental_Crane_Large_Outdoor_Duration", 266, 219, 22, 80, 142, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "103", "63", "RsTextbox", 0, "EQ_Rental_Crane_Large_Outdoor_Wkly_Rate", 266, 305, 22, 80, 143, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "104", "63", "RsLabel", 0, "", 376, 6, 21, 111, 144, "Porta Johns", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "105", "63", "RsTextbox", 0, "EQ_Rental_Crane_Large_Outdoor_Total_Cost", 266, 391, 22, 80, 145, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "106", "63", "RsTextbox", 0, "EQ_Rental_Welders_Quantity", 293, 133, 22, 80, 146, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "107", "63", "RsLabel", 0, "", 348, 6, 21, 111, 147, "Dumpsters", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "108", "63", "RsTextbox", 0, "EQ_Rental_Welders_Duration", 293, 219, 22, 80, 148, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "109", "63", "RsTextbox", 0, "EQ_Rental_Welders_Wkly_Rate", 293, 305, 22, 80, 149, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "110", "63", "RsTextbox", 0, "EQ_Rental_Welders_Total_Cost", 293, 391, 22, 80, 150, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "111", "63", "RsTextbox", 0, "EQ_Rental_Site_Trailer_Quantity", 320, 133, 22, 80, 151, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "112", "63", "RsTextbox", 0, "EQ_Rental_Site_Trailer_Duration", 320, 219, 22, 80, 152, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "113", "63", "RsTextbox", 0, "EQ_Rental_Site_Trailer_Wkly_Rate", 320, 305, 22, 80, 153, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "114", "63", "RsLabel", 0, "", 320, 6, 21, 111, 154, "Site Trailer", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "115", "63", "RsTextbox", 0, "EQ_Rental_Site_Trailer_Total_Cost", 320, 391, 22, 80, 155, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "116", "63", "RsTextbox", 0, "EQ_Rental_Dumpsters_Quantity", 348, 133, 22, 80, 156, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "117", "63", "RsLabel", 0, "", 7, 219, 35, 80, 157, "Install Duration (Weeks)", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "118", "63", "RsTextbox", 0, "EQ_Rental_Dumpsters_Duration", 348, 219, 22, 80, 158, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "119", "63", "RsTextbox", 0, "EQ_Rental_Dumpsters_Wkly_Rate", 348, 305, 22, 80, 159, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "120", "63", "RsLabel", 0, "", 131, 6, 21, 111, 160, "Large Boom Lift", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "121", "63", "RsTextbox", 0, "EQ_Rental_Dumpsters_Total_Cost", 348, 391, 22, 80, 161, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "122", "63", "RsTextbox", 0, "EQ_Rental_Porta_Johns_Quantity", 376, 133, 22, 80, 162, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "123", "63", "RsTextbox", 0, "EQ_Rental_Porta_Johns_Duration", 376, 219, 22, 80, 163, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "124", "63", "RsTextbox", 0, "EQ_Rental_Porta_Johns_Wkly_Rate", 376, 305, 22, 80, 164, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "125", "63", "RsTextbox", 0, "EQ_Rental_Porta_Johns_Total_Cost", 376, 391, 22, 80, 165, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "126", "63", "RsLabel", 0, "", 73, 6, 21, 111, 166, "Large Scissor Lift", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "127", "63", "RsLabel", 0, "", 266, 6, 21, 111, 167, "Crane (Large Outdoor)", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "128", "63", "RsLabel", 0, "", 50, 6, 21, 111, 168, "Small Scissors Lift", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "129", "63", "RsLabel", 0, "", 7, 133, 35, 80, 169, "Quantity", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "130", "63", "RsLabel", 0, "", 185, 5, 21, 111, 170, "Large Telehandler", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "131", "63", "RsLabel", 0, "", 239, 6, 21, 111, 171, "Cranes (Small indoors)", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "132", "63", "RsLabel", 0, "", 212, 6, 21, 111, 172, "Fork Truck", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "133", "62", "RsGroupBox", 0, "", 447, 24, 115, 484, 173, "Travel Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "134", "133", "RsLabel", 0, "", 8, 122, 22, 126, 174, "Per Diem Range:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "135", "133", "RsLabel", 0, "", 40, 37, 28, 80, 175, "Crew", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "136", "133", "RsComboBox", 0, "Travel_Cost_Per_Diem_Range_Intelligrated", 8, 266, 22, 125, 176, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "137", "133", "RsLabel", 0, "", 40, 391, 28, 80, 177, "Total Travel Cost", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "138", "133", "RsTextbox", 0, "Travel_Cost_Lead_Men_Total_Travel_Cost", 79, 391, 22, 80, 178, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "139", "133", "RsLabel", 0, "", 40, 133, 28, 80, 179, "Per Diem Rates (Weekly)", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "140", "133", "RsTextbox", 0, "Travel_Cost_Lead_Men_Per_Diem_Rates_Wkly", 79, 133, 22, 80, 180, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "141", "133", "RsLabel", 0, "", 40, 219, 28, 80, 181, "Total Project Per Diem", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "142", "133", "RsTextbox", 0, "Travel_Cost_Lead_Men_Total_Mobilization", 79, 305, 22, 80, 182, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "143", "133", "RsTextbox", 0, "Travel_Cost_Lead_Men_Total_Project_Per_Diem", 79, 219, 22, 80, 183, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "144", "133", "RsLabel", 0, "", 40, 305, 28, 80, 184, "Total Mobilization Cost", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "145", "133", "RsLabel", 0, "", 79, 37, 22, 80, 185, "Lead Man", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "146", "4", "RsTabPage", 0, "", 0, 0, 633, 700, 0, "Total Costs", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "147", "146", "RsGroupBox", 0, "", 19, 14, 360, 668, 60, "Mechanical Install", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "148", "147", "RsLabel", 0, "", 126, 148, 21, 99, 61, "Install", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "149", "147", "RsLabel", 0, "", 147, 148, 21, 99, 62, "Commissioning", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "150", "147", "RsTextbox", 0, "Superintendent_Total_Hours", 43, 384, 22, 125, 63, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "151", "147", "RsTextbox", 0, "Superintendent_Total_Hours", 70, 384, 22, 125, 64, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "152", "147", "RsLabel", 0, "", 44, 76, 21, 171, 65, "Mechanical Conveyor Installation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "153", "147", "RsTextbox", 0, "Project_Support_Total_Hours", 183, 384, 22, 125, 66, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "154", "147", "RsTextbox", 0, "Equipment_Rental_Porta_Johns_Cost", 258, 515, 22, 125, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "155", "147", "RsTextbox", 0, "Project_Support_Rate", 183, 253, 22, 125, 68, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "156", "147", "RsLabel", 0, "", 183, 9, 21, 61, 69, "16.01.03.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "157", "147", "RsLabel", 0, "", 258, 148, 21, 99, 70, "Porta Johns", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "158", "147", "RsTextbox", 0, "Superintendent_Total_Cost", 43, 515, 22, 125, 71, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "159", "147", "RsTextbox", 0, "Equipment_Rental_Dumpsters_Cost", 237, 515, 22, 125, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "160", "147", "RsTextbox", 0, "Lead_Men_Install_Hours", 126, 384, 22, 125, 73, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "161", "147", "RsLabel", 0, "", 237, 148, 21, 99, 74, "Dumpsters", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "162", "147", "RsTextbox", 0, "Lead_Men_Install_Cost", 125, 515, 22, 125, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "163", "147", "RsLabel", 0, "", 16, 512, 21, 125, 76, "Cost", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "164", "147", "RsTextbox", 0, "Lead_Men_Commissioning_Hours", 147, 384, 22, 125, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "165", "147", "RsTextbox", 0, "Lead_Men_Commissioning_Cost", 147, 515, 22, 125, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "166", "147", "RsLabel", 0, "", 44, 9, 21, 72, 79, "16.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "167", "147", "RsTextbox", 0, "Superintendent_Install_Support_Cost", 70, 756, 22, 125, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "168", "147", "RsTextbox", 0, "Superintendent_Total_Cost", 70, 515, 22, 125, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "169", "147", "RsTextbox", 0, "Superintendent_Rate", 70, 253, 22, 125, 82, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "170", "147", "RsTextbox", 0, "Additional_Subcontractor_Services_Total_Cost", 324, 515, 22, 125, 83, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "171", "147", "RsTextbox", 0, "Travel_Expense_Total_Cost", 291, 515, 22, 125, 84, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "172", "147", "RsLabel", 0, "", 16, 381, 21, 125, 85, "Hours", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "173", "147", "RsTextbox", 0, "Project_Support_Total_Cost", 182, 515, 22, 125, 86, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "174", "147", "RsLabel", 0, "", 16, 250, 21, 125, 87, "Rate", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "175", "147", "RsTextbox", 0, "Equipment_Rental_Total_Cost", 214, 515, 22, 125, 88, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "176", "147", "RsTextbox", 0, "Lead_Men_Total_Cost", 99, 515, 22, 125, 89, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "177", "147", "RsTextbox", 0, "Lead_Men_Rate", 99, 253, 22, 125, 90, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "178", "147", "RsTextbox", 0, "Lead_Men_Total_Hours", 99, 384, 22, 125, 91, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "179", "147", "RsLabel", 0, "", 71, 76, 21, 171, 92, "Superintendent", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "180", "147", "RsLabel", 0, "", 99, 76, 21, 171, 93, "Lead Men", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "181", "147", "RsLabel", 0, "", 71, 9, 21, 72, 94, "16.01.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "182", "147", "RsLabel", 0, "", 324, 76, 21, 171, 95, "Additional Subcontractor Services", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "183", "147", "RsLabel", 0, "", 291, 76, 21, 171, 96, "Travel Expenses", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "184", "147", "RsLabel", 0, "", 183, 76, 21, 171, 97, "Project Support", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "185", "147", "RsLabel", 0, "", 221, 76, 21, 171, 98, "Equipment Rental", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "186", "147", "RsLabel", 0, "", 99, 9, 21, 72, 99, "16.01.02.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "187", "147", "RsLabel", 0, "", 324, 9, 21, 72, 100, "16.01.98", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "188", "147", "RsLabel", 0, "", 291, 9, 21, 72, 101, "16.01.07", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "189", "147", "RsLabel", 0, "", 221, 9, 21, 72, 102, "16.01.04", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "190", "3", "RsLabel", 0, "Project_Tier_Value", 15, 663, 21, 67, 186, "", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "191", "3", "RsLabel", 0, "", 16, 580, 21, 67, 187, "Project Tier", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "192", "0", "RsComboBox", 0, "Selection_System", 8, 85, 22, 125, 188, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "193", "0", "RsSubForm", 0, "", 36, 12, 808, 789, 189, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,129,My_Conveyor_Sub_Contractor")
        oProcessStep.AddCustomLayout(1, 360, "194", "193", "RsGroupBox", 0, "", 3, 3, 805, 783, 190, "Sub Contractor", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "195", "194", "RsTabControl", 0, "", 35, 26, 764, 751, 191, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "196", "195", "RsTabPage", 0, "", 0, 0, 738, 743, 0, "Inputs", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "197", "196", "RsGroupBox", 0, "", 6, 14, 137, 316, 192, "Factors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "198", "197", "RsComboBox", 0, "Factors_Risk_Rating", 19, 131, 22, 125, 193, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "199", "197", "RsComboBox", 0, "Factors_Air_Piping", 47, 131, 22, 125, 194, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "200", "197", "RsTextbox", 0, "Factors_Seismic", 75, 131, 22, 125, 195, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "201", "197", "RsTextbox", 0, "Factors_Customer_Spec_Difficulty", 103, 131, 22, 125, 196, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "202", "197", "RsLabel", 0, "", 19, 15, 22, 110, 197, "Risk Rating", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "203", "197", "RsLabel", 0, "", 47, 15, 22, 110, 198, "Air Piping", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "204", "197", "RsLabel", 0, "", 75, 15, 22, 110, 199, "Seismic", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "205", "197", "RsLabel", 0, "", 103, 6, 22, 119, 200, "Customer Spec Difficulty", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "206", "196", "RsGroupBox", 0, "", 480, 7, 109, 375, 201, "HSE Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "207", "206", "RsLabel", 0, "", 19, 13, 22, 94, 202, "HSE Wages", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "208", "206", "RsTextbox", 0, "HSE_Wages_Headcount", 19, 113, 22, 80, 203, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "209", "206", "RsTextbox", 0, "HSE_Per_Diem_Rate_Cost", 47, 285, 22, 80, 204, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "210", "206", "RsTextbox", 0, "HSE_Per_Diem_Rate_Headcount", 47, 113, 22, 80, 205, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "211", "206", "RsTextbox", 0, "HSE_Wages_Total_Cost", 75, 285, 22, 80, 206, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "212", "206", "RsTextbox", 0, "HSE_Wages_Cost", 19, 285, 22, 80, 207, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "213", "206", "RsTextbox", 0, "HSE_Per_Diem_Rate", 47, 199, 22, 80, 208, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "214", "206", "RsTextbox", 0, "HSE_Wages_Rate", 19, 199, 22, 80, 209, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "215", "206", "RsLabel", 0, "", 47, 13, 22, 94, 210, "HSE Per Diem Rate", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "216", "206", "RsLabel", 0, "", 75, 13, 22, 94, 211, "Total", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "217", "196", "RsGroupBox", 0, "", 149, 7, 109, 375, 212, "Schedule", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "218", "217", "RsSingleDatePicker", 0, "Schedule_Start_Mechanical_Install", 19, 122, 20, 80, 213, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 360, "219", "217", "RsSingleDatePicker", 0, "Schedule_End_Run_to_In_Level_5", 71, 122, 20, 80, 214, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 360, "220", "217", "RsSingleDatePicker", 0, "Schedule_End_Mechanical_Install", 45, 122, 20, 80, 215, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 360, "221", "217", "RsLabel", 0, "", 47, 208, 22, 73, 216, "Commissioning", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "222", "217", "RsTextbox", 0, "Schedule_Total_Project_Duration_Weeks", 75, 287, 22, 80, 217, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "223", "217", "RsTextbox", 0, "Schedule_Commissioning_Duration_Weeks", 47, 287, 22, 80, 218, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "224", "217", "RsLabel", 0, "", 19, 213, 22, 68, 219, "Install", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "225", "217", "RsLabel", 0, "", 75, 213, 22, 68, 220, "Total Weeks", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "226", "217", "RsLabel", 0, "", 19, 6, 22, 110, 221, "Start Mechanical Install", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "227", "217", "RsTextbox", 0, "Schedule_Install_Duration_Weeks", 19, 287, 22, 80, 222, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "228", "217", "RsLabel", 0, "", 47, 6, 22, 110, 223, "End Mechanical Install", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "229", "217", "RsLabel", 0, "", 75, 6, 22, 110, 224, "End Run-In (Level 5)", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "230", "196", "RsGroupBox", 0, "", 149, 384, 109, 356, 225, "Crew", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "231", "230", "RsLabel", 0, "", 19, 194, 22, 68, 226, "Peak Crew", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "232", "230", "RsLabel", 0, "", 19, 6, 22, 96, 227, "Average", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "233", "230", "RsTextbox", 0, "Crew_Average_Hours_per_wk", 19, 108, 22, 80, 228, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "234", "230", "RsTextbox", 0, "Crew_Peak_Crew_Multiplier", 75, 108, 22, 80, 229, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "235", "230", "RsTextbox", 0, "Crew_Comm_Sppt_Hours_per_wk", 47, 108, 22, 80, 230, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "236", "230", "RsTextbox", 0, "Avg_Crew_Size", 47, 268, 22, 80, 231, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "237", "230", "RsLabel", 0, "", 47, 194, 22, 68, 232, "Avg Crew Size", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "238", "230", "RsTextbox", 0, "Peak_Crew", 19, 268, 22, 80, 233, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "239", "230", "RsLabel", 0, "", 47, 6, 22, 96, 234, "Comm Sppt", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "240", "230", "RsLabel", 0, "", 75, 6, 22, 96, 235, "Peak Crew Multiplier", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "241", "196", "RsGroupBox", 0, "", 6, 346, 137, 394, 236, "People Needs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "242", "241", "RsLabel", 0, "", 16, 102, 19, 80, 237, "Install", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "243", "241", "RsTextbox", 0, "People_Needs_Num_of_Superintendents_Install", 38, 102, 19, 80, 238, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "244", "241", "RsTextbox", 0, "People_Needs_Num_of_Lead_Men_Install", 66, 102, 19, 80, 239, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "245", "241", "RsLabel", 0, "", 38, 7, 19, 89, 240, "# Superintendents", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "246", "241", "RsTextbox", 0, "People_Needs_Num_of_Installers_Install", 94, 102, 19, 80, 241, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "247", "241", "RsLabel", 0, "", 16, 310, 19, 80, 242, "Working %", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "248", "241", "RsTextbox", 0, "People_Needs_Num_of_Superintendents_Comm", 38, 207, 19, 80, 243, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "249", "241", "RsTextbox", 0, "People_Needs_Lead_Men_Working_Percent", 66, 310, 19, 80, 244, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "250", "241", "RsTextbox", 0, "People_Needs_Num_of_Lead_Men_Comm", 66, 207, 19, 80, 245, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "251", "241", "RsTextbox", 0, "People_Needs_Num_of_Installers_Comm", 94, 207, 19, 80, 246, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "252", "241", "RsLabel", 0, "", 16, 207, 19, 80, 247, "Comm", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "253", "241", "RsTextbox", 0, "People_Needs_Superintendents_Working_Percent", 38, 310, 19, 80, 248, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "254", "241", "RsLabel", 0, "", 66, 7, 19, 89, 249, "# Lead Men", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "255", "241", "RsLabel", 0, "", 94, 7, 19, 89, 250, "# Installers", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "256", "196", "RsGroupBox", 0, "", 273, 385, 268, 358, 251, "Miscellaneous Hours &amp;amp; Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "257", "256", "RsLabel", 0, "", 204, 7, 22, 80, 252, "Misc Item 2", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "258", "256", "RsTextbox", 0, "Miscellaneous_Misc_Item_2_Cost", 201, 94, 22, 80, 253, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "259", "256", "RsLabel", 0, "", 176, 7, 22, 80, 254, "Misc Item 1", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "260", "256", "RsTextbox", 0, "Miscellaneous_System_Efficiency", 51, 271, 22, 80, 255, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "261", "256", "RsLabel", 0, "", 125, 7, 28, 80, 256, "Customer Spec Adder", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "262", "256", "RsLabel", 0, "", 153, 7, 22, 80, 257, "Elevation Adder", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "263", "256", "RsTextbox", 0, "Miscellaneous_Customer_Spec_Adder_Cost", 126, 180, 22, 80, 258, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "264", "256", "RsTextbox", 0, "Total_Miscellaneous_Hours", 226, 180, 22, 80, 259, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "265", "256", "RsTextbox", 0, "Miscellaneous_Elevation_Adder", 151, 94, 22, 80, 260, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "266", "256", "RsTextbox", 0, "Miscellaneous_Misc_Item_1_Cost", 176, 94, 22, 80, 261, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "267", "256", "RsLabel", 0, "", 28, 94, 20, 80, 262, "Cost", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "268", "256", "RsTextbox", 0, "Miscellaneous_Customer_Spec_Adder", 126, 94, 22, 80, 263, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "269", "256", "RsTextbox", 0, "Miscellaneous_Elevation_Adder_Cost", 151, 180, 22, 80, 264, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "270", "256", "RsTextbox", 0, "Miscellaneous_System_Efficiency_Cost", 51, 94, 22, 80, 265, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "271", "256", "RsLabel", 0, "", 229, 7, 22, 80, 266, "Total", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "272", "256", "RsLabel", 0, "", 51, 7, 22, 80, 267, "System Efficiency", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "273", "256", "RsTextbox", 0, "Miscellaneous_Miscellaneous_Cost", 101, 94, 22, 80, 268, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "274", "256", "RsTextbox", 0, "Miscellaneous_Shuttle_Cost", 76, 94, 22, 80, 269, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "275", "256", "RsTextbox", 0, "Miscellaneous_Miscellaneous_Hours", 101, 180, 22, 80, 270, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "276", "256", "RsLabel", 0, "", 28, 180, 20, 80, 271, "Hours", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "277", "256", "RsTextbox", 0, "Miscellaneous_Shuttle_Hours", 76, 180, 22, 80, 272, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "278", "256", "RsLabel", 0, "", 28, 269, 20, 80, 273, "%", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "279", "256", "RsTextbox", 0, "Total_Miscellaneous_Cost", 226, 94, 22, 80, 274, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "280", "256", "RsTextbox", 0, "Miscellaneous_System_Efficiency_Hours", 51, 180, 22, 80, 275, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "281", "256", "RsLabel", 0, "", 75, 7, 22, 80, 276, "Shuttle", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "282", "256", "RsLabel", 0, "", 97, 7, 22, 80, 277, "Miscellaneous", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "283", "196", "RsGroupBox", 0, "", 273, 7, 189, 375, 278, "Crew Mobilization Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "284", "283", "RsLabel", 0, "", 8, 122, 22, 126, 279, "Mobilzation Cost/Person:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "285", "283", "RsTextbox", 0, "Crew_Mobilization_Cost_per_person", 8, 266, 22, 80, 280, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "286", "283", "RsLabel", 0, "", 40, 5, 28, 80, 281, "Crew", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "287", "283", "RsLabel", 0, "", 155, 5, 22, 80, 282, "Total", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "288", "283", "RsTextbox", 0, "Crew_Total_Mobilization_Cost", 155, 266, 22, 80, 283, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "289", "283", "RsLabel", 0, "", 40, 91, 28, 80, 284, "Mobilization Count", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "290", "283", "RsTextbox", 0, "Crew_Total_Headcount", 155, 177, 22, 80, 285, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "291", "283", "RsTextbox", 0, "Crew_Superintendent_Mobilization_Count", 71, 91, 22, 80, 286, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "292", "283", "RsLabel", 0, "", 71, 5, 22, 80, 287, "Superintendent", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "293", "283", "RsTextbox", 0, "Crew_Installer_Mobilization_Count", 127, 91, 22, 80, 288, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "294", "283", "RsTextbox", 0, "Crew_Lead_Man_Mobilization_Count", 99, 91, 22, 80, 289, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "295", "283", "RsTextbox", 0, "Crew_Lead_Man_Headcount", 127, 177, 22, 80, 290, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "296", "283", "RsLabel", 0, "", 40, 177, 28, 80, 291, "Headcount", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "297", "283", "RsTextbox", 0, "Crew_Lead_Man_Total_Mobilization_Cost", 99, 266, 22, 80, 292, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "298", "283", "RsTextbox", 0, "Crew_Lead_Man_Headcount", 99, 177, 22, 80, 293, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "299", "283", "RsLabel", 0, "", 40, 266, 28, 80, 294, "Total Mobilization Cost", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "300", "283", "RsTextbox", 0, "Crew_Installer_Total_Mobilization_Cost", 71, 266, 22, 80, 295, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "301", "283", "RsTextbox", 0, "Crew_Superintendent_Headcount", 71, 177, 22, 80, 296, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "302", "283", "RsLabel", 0, "", 99, 5, 22, 80, 297, "Lead Man", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "303", "283", "RsLabel", 0, "", 127, 5, 22, 80, 298, "Installer", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "304", "195", "RsTabPage", 0, "", 0, 0, 738, 743, 0, "Equipment Rentals Input", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "305", "304", "RsGroupBox", 0, "", 17, 18, 404, 484, 299, "Equipment Rentals", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "306", "305", "RsLabel", 0, "", 7, 391, 35, 80, 300, "Total Cost", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "307", "305", "RsTextbox", 0, "EQ_Rental_Small_Scissors_Lift_Quantity", 50, 133, 22, 80, 301, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "308", "305", "RsTextbox", 0, "EQ_Rental_Small_Scissors_Lift_Duration", 50, 219, 22, 80, 302, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "309", "305", "RsLabel", 0, "", 104, 6, 21, 111, 303, "Small Boom Lift", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "310", "305", "RsTextbox", 0, "EQ_Rental_Small_Scissors_Lift_Wkly_Rate", 50, 305, 22, 80, 304, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "311", "305", "RsTextbox", 0, "EQ_Rental_Small_Scissors_Lift_Total_Cost", 50, 391, 22, 80, 305, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "312", "305", "RsTextbox", 0, "EQ_Rental_Large_Scissor_Lift_Quantity", 77, 133, 22, 80, 306, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "313", "305", "RsTextbox", 0, "EQ_Rental_Large_Scissor_Lift_Duration", 77, 219, 22, 80, 307, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "314", "305", "RsTextbox", 0, "EQ_Rental_Large_Scissor_Lift_Wkly_Rate", 77, 305, 22, 80, 308, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "315", "305", "RsTextbox", 0, "EQ_Rental_Large_Scissor_Lift_Total_Cost", 77, 391, 22, 80, 309, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "316", "305", "RsTextbox", 0, "EQ_Rental_Small_Boom_Lift_Quantity", 104, 133, 22, 80, 310, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "317", "305", "RsTextbox", 0, "EQ_Rental_Small_Boom_Lift_Duration", 104, 219, 22, 80, 311, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "318", "305", "RsTextbox", 0, "EQ_Rental_Small_Boom_Lift_Wkly_Rate", 104, 305, 22, 80, 312, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "319", "305", "RsLabel", 0, "", 7, 305, 35, 80, 313, "Weekly Rate", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "320", "305", "RsTextbox", 0, "EQ_Rental_Small_Boom_Lift_Total_Cost", 104, 391, 22, 80, 314, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "321", "305", "RsTextbox", 0, "EQ_Rental_Large_Boom_Lift_Quantity", 131, 133, 22, 80, 315, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "322", "305", "RsTextbox", 0, "EQ_Rental_Large_Boom_Lift_Duration", 131, 219, 22, 80, 316, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "323", "305", "RsLabel", 0, "", 293, 6, 21, 111, 317, "Welders", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "324", "305", "RsTextbox", 0, "EQ_Rental_Large_Boom_Lift_Wkly_Rate", 131, 305, 22, 80, 318, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "325", "305", "RsTextbox", 0, "EQ_Rental_Large_Boom_Lift_Total_Cost", 131, 391, 22, 80, 319, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "326", "305", "RsTextbox", 0, "EQ_Rental_Small_TelehandlerQuantity", 158, 133, 22, 80, 320, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "327", "305", "RsTextbox", 0, "EQ_Rental_Small_Telehandler_Duration", 158, 219, 22, 80, 321, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "328", "305", "RsTextbox", 0, "EQ_Rental_Small_Telehandler_Wkly_Rate", 158, 305, 22, 80, 322, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "329", "305", "RsTextbox", 0, "EQ_Rental_Small_Telehandler_Total_Cost", 158, 391, 22, 80, 323, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "330", "305", "RsTextbox", 0, "EQ_Rental_Large_Telehandler_Quantity", 185, 133, 22, 80, 324, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "331", "305", "RsTextbox", 0, "EQ_Rental_Large_Telehandler_Duration", 185, 219, 22, 80, 325, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "332", "305", "RsTextbox", 0, "EQ_Rental_Large_Telehandler_Wkly_Rate", 185, 305, 22, 80, 326, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "333", "305", "RsTextbox", 0, "EQ_Rental_Large_Telehandler_Total_Cost", 185, 391, 22, 80, 327, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "334", "305", "RsTextbox", 0, "EQ_Rental_Fork_Truck_Quantity", 212, 133, 22, 80, 328, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "335", "305", "RsTextbox", 0, "EQ_Rental_Fork_Truck_Duration", 212, 219, 22, 80, 329, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "336", "305", "RsTextbox", 0, "EQ_Rental_Fork_Truck_Wkly_Rate", 212, 305, 22, 80, 330, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "337", "305", "RsTextbox", 0, "EQ_Rental_Fork_Truck_Total_Cost", 212, 391, 22, 80, 331, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "338", "305", "RsTextbox", 0, "EQ_Rental_Cranes_Small_indoors_Quantity", 239, 133, 22, 80, 332, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "339", "305", "RsTextbox", 0, "EQ_Rental_Cranes_Small_indoors_Duration", 239, 219, 22, 80, 333, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "340", "305", "RsLabel", 0, "", 158, 5, 21, 111, 334, "Small Telehandler", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "341", "305", "RsTextbox", 0, "EQ_Rental_Cranes_Small_indoors_Wkly_Rate", 239, 305, 22, 80, 335, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "342", "305", "RsTextbox", 0, "EQ_Rental_Crane_Large_Outdoor_Total_Cost", 239, 391, 22, 80, 336, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "343", "305", "RsTextbox", 0, "EQ_Rental_Crane_Large_Outdoor_Quantity", 266, 133, 22, 80, 337, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "344", "305", "RsTextbox", 0, "EQ_Rental_Crane_Large_Outdoor_Duration", 266, 219, 22, 80, 338, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "345", "305", "RsTextbox", 0, "EQ_Rental_Crane_Large_Outdoor_Wkly_Rate", 266, 305, 22, 80, 339, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "346", "305", "RsLabel", 0, "", 376, 6, 21, 111, 340, "Porta Johns", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "347", "305", "RsTextbox", 0, "EQ_Rental_Crane_Large_Outdoor_Total_Cost", 266, 391, 22, 80, 341, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "348", "305", "RsTextbox", 0, "EQ_Rental_Welders_Quantity", 293, 133, 22, 80, 342, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "349", "305", "RsLabel", 0, "", 348, 6, 21, 111, 343, "Dumpsters", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "350", "305", "RsTextbox", 0, "EQ_Rental_Welders_Duration", 293, 219, 22, 80, 344, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "351", "305", "RsTextbox", 0, "EQ_Rental_Welders_Wkly_Rate", 293, 305, 22, 80, 345, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "352", "305", "RsTextbox", 0, "EQ_Rental_Welders_Total_Cost", 293, 391, 22, 80, 346, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "353", "305", "RsTextbox", 0, "EQ_Rental_Site_Trailer_Quantity", 320, 133, 22, 80, 347, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "354", "305", "RsTextbox", 0, "EQ_Rental_Site_Trailer_Duration", 320, 219, 22, 80, 348, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "355", "305", "RsTextbox", 0, "EQ_Rental_Site_Trailer_Wkly_Rate", 320, 305, 22, 80, 349, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "356", "305", "RsLabel", 0, "", 320, 6, 21, 111, 350, "Site Trailer", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "357", "305", "RsTextbox", 0, "EQ_Rental_Site_Trailer_Total_Cost", 320, 391, 22, 80, 351, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "358", "305", "RsTextbox", 0, "EQ_Rental_Dumpsters_Quantity", 348, 133, 22, 80, 352, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "359", "305", "RsLabel", 0, "", 7, 219, 35, 80, 353, "Install Duration (Weeks)", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "360", "305", "RsTextbox", 0, "EQ_Rental_Dumpsters_Duration", 348, 219, 22, 80, 354, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "361", "305", "RsTextbox", 0, "EQ_Rental_Dumpsters_Wkly_Rate", 348, 305, 22, 80, 355, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "362", "305", "RsLabel", 0, "", 131, 6, 21, 111, 356, "Large Boom Lift", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "363", "305", "RsTextbox", 0, "EQ_Rental_Dumpsters_Total_Cost", 348, 391, 22, 80, 357, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "364", "305", "RsTextbox", 0, "EQ_Rental_Porta_Johns_Quantity", 376, 133, 22, 80, 358, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "365", "305", "RsTextbox", 0, "EQ_Rental_Porta_Johns_Duration", 376, 219, 22, 80, 359, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "366", "305", "RsTextbox", 0, "EQ_Rental_Porta_Johns_Wkly_Rate", 376, 305, 22, 80, 360, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "367", "305", "RsTextbox", 0, "EQ_Rental_Porta_Johns_Total_Cost", 376, 391, 22, 80, 361, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "368", "305", "RsLabel", 0, "", 73, 6, 21, 111, 362, "Large Scissor Lift", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "369", "305", "RsLabel", 0, "", 266, 6, 21, 111, 363, "Crane (Large Outdoor)", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "370", "305", "RsLabel", 0, "", 50, 6, 21, 111, 364, "Small Scissors Lift", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "371", "305", "RsLabel", 0, "", 7, 133, 35, 80, 365, "Quantity", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "372", "305", "RsLabel", 0, "", 185, 5, 21, 111, 366, "Large Telehandler", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "373", "305", "RsLabel", 0, "", 239, 6, 21, 111, 367, "Cranes (Small indoors)", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "374", "305", "RsLabel", 0, "", 212, 6, 21, 111, 368, "Fork Truck", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "375", "304", "RsGroupBox", 0, "", 23, 519, 247, 207, 369, "Other Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "376", "375", "RsLabel", 0, "", 191, 13, 22, 80, 370, "Hrs Per Week", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "377", "375", "RsTextbox", 0, "Other_Cost_Qty_Trucks", 26, 100, 22, 80, 371, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "378", "375", "RsLabel", 0, "", 124, 13, 28, 80, 372, "Onsite Admin", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "379", "375", "RsTextbox", 0, "Other_Cost_Qty_Gang_Boxes", 59, 100, 22, 80, 373, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "380", "375", "RsLabel", 0, "", 160, 13, 22, 80, 374, "Duration (Wks)", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "381", "375", "RsTextbox", 0, "Other_Cost_Permit_Hours", 92, 100, 22, 80, 375, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "382", "375", "RsTextbox", 0, "Other_Cost_Onsite_Admin", 125, 100, 22, 80, 376, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "383", "375", "RsTextbox", 0, "Other_Cost_Duration_Wks", 158, 100, 22, 80, 377, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "384", "375", "RsTextbox", 0, "Other_Cost_Hrs_Per_Week", 191, 100, 22, 80, 378, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "385", "375", "RsLabel", 0, "", 26, 13, 22, 80, 379, "Qty Trucks", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "386", "375", "RsLabel", 0, "", 58, 13, 22, 80, 380, "Qty Gang Boxes", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "387", "375", "RsLabel", 0, "", 88, 13, 22, 80, 381, "Permit Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "388", "304", "RsGroupBox", 0, "", 440, 470, 122, 271, 382, "Structures", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "389", "388", "RsLabel", 0, "", 11, 76, 19, 80, 383, "Feet", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "390", "388", "RsTextbox", 0, "People_Needs_Num_of_Superintendents_Install", 33, 76, 19, 80, 384, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "391", "388", "RsTextbox", 0, "People_Needs_Num_of_Lead_Men_Install", 61, 76, 19, 80, 385, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "392", "388", "RsLabel", 0, "", 33, 3, 19, 67, 386, "DEMO", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "393", "388", "RsTextbox", 0, "People_Needs_Num_of_Installers_Install", 89, 76, 19, 80, 387, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "394", "388", "RsTextbox", 0, "People_Needs_Num_of_Superintendents_Comm", 33, 181, 19, 80, 388, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "395", "388", "RsTextbox", 0, "People_Needs_Num_of_Lead_Men_Comm", 61, 181, 19, 80, 389, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "396", "388", "RsTextbox", 0, "People_Needs_Num_of_Installers_Comm", 89, 181, 19, 80, 390, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "397", "388", "RsLabel", 0, "", 11, 181, 19, 80, 391, "Hours", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "398", "388", "RsLabel", 0, "", 61, 3, 19, 67, 392, "PLATFORM", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "399", "388", "RsLabel", 0, "", 89, 3, 19, 67, 393, "CATWALK", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "400", "304", "RsGroupBox", 0, "", 440, 18, 189, 446, 394, "Travel Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "401", "400", "RsLabel", 0, "", 8, 122, 22, 126, 395, "Per Diem Range:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "402", "400", "RsLabel", 0, "", 40, 5, 28, 80, 396, "Crew", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "403", "400", "RsTextbox", 0, "Travel_Cost_Total_Travel_Cost", 155, 351, 22, 80, 397, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "404", "400", "RsComboBox", 0, "Travel_Cost_Per_Diem_Range", 8, 266, 22, 125, 398, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "405", "400", "RsLabel", 0, "", 40, 351, 28, 80, 399, "Total Travel Cost", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "406", "400", "RsTextbox", 0, "Travel_Cost_Installer_Total_Travel_Cost", 127, 351, 22, 80, 400, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "407", "400", "RsLabel", 0, "", 155, 5, 22, 80, 401, "Total", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "408", "400", "RsTextbox", 0, "Travel_Cost_Lead_Men_Total_Travel_Cost", 99, 351, 22, 80, 402, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "409", "400", "RsTextbox", 0, "Travel_Cost_Installer_Total_Mobilization", 127, 266, 22, 80, 403, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "410", "400", "RsTextbox", 0, "Travel_Cost_Superintendent_Total_Travel_Cost", 71, 351, 22, 80, 404, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "411", "400", "RsTextbox", 0, "Travel_Cost_Total_Mobilization_Cost", 155, 266, 22, 80, 405, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "412", "400", "RsLabel", 0, "", 40, 91, 28, 80, 406, "Per Diem Rates (Weekly)", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "413", "400", "RsTextbox", 0, "Travel_Cost_Total_Project_Per_Diem", 155, 177, 22, 80, 407, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "414", "400", "RsTextbox", 0, "Travel_Cost_Superintendent_Per_Diem_Rates_Wkly", 71, 91, 22, 80, 408, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "415", "400", "RsLabel", 0, "", 71, 5, 22, 80, 409, "Superintendent", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "416", "400", "RsTextbox", 0, "Travel_Cost_Installer_Per_Diem_Rates_Wkly", 127, 91, 22, 80, 410, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "417", "400", "RsTextbox", 0, "Travel_Cost_Lead_Men_Per_Diem_Rates_Wkly", 99, 91, 22, 80, 411, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "418", "400", "RsTextbox", 0, "Travel_Cost_Installer_Total_Project_Per_Diem", 127, 177, 22, 80, 412, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "419", "400", "RsLabel", 0, "", 40, 177, 28, 80, 413, "Total Project Per Diem", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "420", "400", "RsTextbox", 0, "Travel_Cost_Lead_Men_Total_Mobilization", 99, 266, 22, 80, 414, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "421", "400", "RsTextbox", 0, "Travel_Cost_Lead_Men_Total_Project_Per_Diem", 99, 177, 22, 80, 415, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "422", "400", "RsLabel", 0, "", 40, 266, 28, 80, 416, "Total Mobilization Cost", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "423", "400", "RsTextbox", 0, "Travel_Cost_Superintendent_Total_Mobilization", 71, 266, 22, 80, 417, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "424", "400", "RsTextbox", 0, "Travel_Cost_Superintendent_Total_Prj_Per_Diem", 71, 177, 22, 80, 418, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "425", "400", "RsLabel", 0, "", 99, 5, 22, 80, 419, "Lead Man", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "426", "400", "RsLabel", 0, "", 127, 5, 22, 80, 420, "Installer", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "427", "304", "RsGroupBox", 0, "", 276, 519, 145, 207, 421, "Conveyor at Elevation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "428", "427", "RsTextbox", 0, "Conveyor_between_5_ft_to_8_ft_Footage", 41, 99, 22, 80, 422, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "429", "427", "RsTextbox", 0, "Conveyor_above_8_ft", 74, 99, 22, 80, 423, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "430", "427", "RsTextbox", 0, "Conveyor_Hours_Added", 107, 99, 22, 80, 424, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "431", "427", "RsLabel", 0, "", 37, 12, 31, 80, 425, "Conveyor between 5&amp;apos;-8&amp;apos;", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "432", "427", "RsLabel", 0, "", 17, 99, 19, 80, 426, "Footage", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "433", "427", "RsLabel", 0, "", 70, 13, 31, 80, 427, "Conveyor above 8&amp;apos;", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "434", "427", "RsLabel", 0, "", 107, 12, 22, 80, 428, "Hours Added:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "435", "195", "RsTabPage", 0, "", 0, 0, 738, 743, 0, "Rate adjustments", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "436", "435", "RsGroupBox", 0, "", 28, 26, 183, 406, 429, "Labor Rate Adjustments", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "437", "436", "RsLabel", 0, "", 66, 6, 22, 104, 430, "Superintendent", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "438", "436", "RsLabel", 0, "", 16, 185, 22, 104, 431, "Percent Adjustment", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "439", "436", "RsTextbox", 0, "Labor_Rate_Intelligrated_Installer_Tot_Cost_Adj", 125, 298, 22, 80, 432, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "440", "436", "RsLabel", 0, "", 147, 6, 28, 104, 433, "Total", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "441", "436", "RsTextbox", 0, "Labor_Rate_Percent_Adjustment", 16, 298, 22, 80, 434, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "442", "436", "RsLabel", 0, "", 44, 123, 22, 80, 435, "Current Rate", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "443", "436", "RsTextbox", 0, "Labor_Rate_Tot_Cost_Adjustment", 153, 298, 22, 80, 436, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "444", "436", "RsTextbox", 0, "Labor_Rate_Superintendent_Current_Rate", 69, 123, 22, 80, 437, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "445", "436", "RsTextbox", 0, "Labor_Rate_Intelligrated_Installer_Current_Rate", 125, 123, 22, 80, 438, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "446", "436", "RsTextbox", 0, "Labor_Rate_Lead_Person_Current_Rate", 97, 123, 22, 80, 439, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "447", "436", "RsTextbox", 0, "Labor_Rate_Intelligrated_Installer_New_Rate", 125, 209, 22, 80, 440, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "448", "436", "RsLabel", 0, "", 44, 209, 22, 80, 441, "New Rate", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "449", "436", "RsTextbox", 0, "Labor_Rate_Lead_Person_Tot_Cost_Adj", 97, 298, 22, 80, 442, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "450", "436", "RsTextbox", 0, "Labor_Rate_Lead_Person_New_Rate", 97, 209, 22, 80, 443, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "451", "436", "RsLabel", 0, "", 44, 298, 22, 80, 444, "Tot Cost Adj", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "452", "436", "RsTextbox", 0, "Labor_Rate_Superintendent_Tot_Cost_Adj", 69, 298, 22, 80, 445, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "453", "436", "RsTextbox", 0, "Labor_Rate_Superintendent_New_Rate", 69, 209, 22, 80, 446, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "454", "436", "RsLabel", 0, "", 94, 6, 22, 104, 447, "Lead Person", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "455", "436", "RsLabel", 0, "", 122, 6, 22, 104, 448, "Intelligrated Installer", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "456", "435", "RsGroupBox", 0, "", 230, 26, 183, 406, 449, "Union Rate Adjustments", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "457", "456", "RsLabel", 0, "", 16, 185, 22, 104, 450, "Percent Adjustment", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "458", "456", "RsTextbox", 0, "Union_Rate_Intelligrated_Installer_Tot_Cost_Adj", 125, 298, 22, 80, 451, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "459", "456", "RsTextbox", 0, "Union_Rate_Percent_Adjustment", 16, 298, 22, 80, 452, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "460", "456", "RsLabel", 0, "", 147, 6, 28, 104, 453, "Total", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "461", "456", "RsLabel", 0, "", 44, 123, 22, 80, 454, "Current Rate", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "462", "456", "RsTextbox", 0, "Union_Rate_Tot_Cost_Adjustment", 153, 298, 22, 80, 455, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "463", "456", "RsTextbox", 0, "Union_Rate_Superintendent_Current_Rate", 69, 123, 22, 80, 456, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "464", "456", "RsLabel", 0, "", 66, 6, 22, 104, 457, "Superintendent", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "465", "456", "RsTextbox", 0, "Union_Rate_Intelligrated_Installer_Current_Rate", 125, 123, 22, 80, 458, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "466", "456", "RsTextbox", 0, "Union_Rate_Lead_Person_Current_Rate", 97, 123, 22, 80, 459, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "467", "456", "RsTextbox", 0, "Union_Rate_Intelligrated_Installer_New_Rate", 125, 209, 22, 80, 460, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "468", "456", "RsLabel", 0, "", 44, 209, 22, 80, 461, "New Rate", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "469", "456", "RsTextbox", 0, "Union_Rate_Lead_Person_Tot_Cost_Adj", 97, 298, 22, 80, 462, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "470", "456", "RsTextbox", 0, "Union_Rate_Lead_Person_New_Rate", 97, 209, 22, 80, 463, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "471", "456", "RsLabel", 0, "", 44, 298, 22, 80, 464, "Tot Cost Adj", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "472", "456", "RsTextbox", 0, "Union_Rate_Intelligrated_Installer_Tot_Cost_Adj", 69, 298, 22, 80, 465, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "473", "456", "RsTextbox", 0, "Union_Rate_Superintendent_New_Rate", 69, 209, 22, 80, 466, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "474", "456", "RsLabel", 0, "", 94, 6, 22, 104, 467, "Lead Person", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "475", "456", "RsLabel", 0, "", 122, 6, 22, 104, 468, "Intelligrated Installer", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "476", "195", "RsTabPage", 0, "", 0, 0, 738, 743, 0, "Total Costs", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 360, "477", "476", "RsGroupBox", 0, "", 16, 12, 720, 668, 469, "Mechanical Install", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "478", "477", "RsTextbox", 0, "Lead_Person_Commissioning_Hours", 238, 381, 22, 125, 470, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "479", "477", "RsLabel", 0, "", 238, 145, 21, 99, 471, "Commissioning", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "480", "477", "RsTextbox", 0, "Superintendent_Total_Hours", 42, 381, 22, 125, 472, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "481", "477", "RsTextbox", 0, "Installer_Stagnant_Hours_Hours", 419, 381, 22, 125, 473, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "482", "477", "RsTextbox", 0, "Lead_Person_Install_Support_Cost", 182, 512, 22, 125, 474, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "483", "477", "RsTextbox", 0, "Installer_Demo_Cost", 367, 512, 22, 125, 475, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "484", "477", "RsLabel", 0, "", 284, 73, 21, 171, 476, "Installer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "485", "477", "RsTextbox", 0, "Installer_Demo_Hours", 367, 381, 22, 125, 477, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "486", "477", "RsTextbox", 0, "Superintendent_Install_Support_Cost", 69, 512, 22, 125, 478, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "487", "477", "RsLabel", 0, "", 475, 145, 21, 135, 479, "Working Super/Lead Deduct", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "488", "477", "RsLabel", 0, "", 395, 145, 21, 99, 480, "Misc Install", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "489", "477", "RsTextbox", 0, "Lead_Person_Commissioning_Cost", 238, 512, 22, 125, 481, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "490", "477", "RsLabel", 0, "", 311, 145, 21, 99, 482, "Install", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "491", "477", "RsLabel", 0, "", 419, 145, 21, 99, 483, "Stagnant Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "492", "477", "RsTextbox", 0, "Lead_Person_Stagnant_Hours_Hours", 210, 381, 22, 125, 484, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "493", "477", "RsLabel", 0, "", 447, 145, 21, 135, 485, "Commissioning Support", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "494", "477", "RsLabel", 0, "", 678, 73, 21, 171, 486, "Administrative", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "495", "477", "RsLabel", 0, "", 339, 145, 21, 135, 487, "Platforms, Grid, &amp;amp; Catwalk", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "496", "477", "RsLabel", 0, "", 16, 512, 21, 125, 488, "Cost", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "497", "477", "RsTextbox", 0, "Installer_Working_Super_or_Lead_Deduct_Hours", 475, 381, 22, 125, 489, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "498", "477", "RsTextbox", 0, "Installer_Total_Hours", 283, 381, 22, 125, 490, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "499", "477", "RsLabel", 0, "", 367, 145, 21, 99, 491, "Demo", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "500", "477", "RsTextbox", 0, "Installer_Misc_Install_Hours", 395, 381, 22, 125, 492, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "501", "477", "RsTextbox", 0, "Installer_Working_Super_or_Lead_Deduct_Cost", 475, 512, 22, 125, 493, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "502", "477", "RsTextbox", 0, "Installer_Commissioning_Support_Cost", 447, 512, 22, 125, 494, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "503", "477", "RsTextbox", 0, "Installer_Commissioning_Support_Hours", 447, 381, 22, 125, 495, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "504", "477", "RsTextbox", 0, "Superintendent_Commissioning_Hours", 126, 381, 22, 125, 496, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "505", "477", "RsTextbox", 0, "Lead_Person_Install_Support_Hours", 182, 381, 22, 125, 497, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "506", "477", "RsTextbox", 0, "Installer_Misc_Install_Cost", 395, 512, 22, 125, 498, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "507", "477", "RsTextbox", 0, "Installer_Platforms_Grid_Catwalk_Hours", 339, 381, 22, 125, 499, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "508", "477", "RsTextbox", 0, "Installer_Stagnant_Hours_Cost", 419, 512, 22, 125, 500, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "509", "477", "RsTextbox", 0, "Superintendent_Commissioning_Cost", 126, 512, 22, 125, 501, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "510", "477", "RsLabel", 0, "", 98, 145, 21, 99, 502, "Stagnant Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "511", "477", "RsTextbox", 0, "Installer_Platforms_Grid_Catwalk_Cost", 339, 512, 22, 125, 503, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "512", "477", "RsTextbox", 0, "Installer_Install_Cost", 311, 512, 22, 125, 504, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "513", "477", "RsLabel", 0, "", 126, 145, 21, 99, 505, "Commissioning", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "514", "477", "RsTextbox", 0, "Installer_Install_Hours", 311, 381, 22, 125, 506, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "515", "477", "RsLabel", 0, "", 210, 145, 21, 99, 507, "Stagnant Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "516", "477", "RsTextbox", 0, "Lead_Person_Stagnant_Hours_Cost", 210, 512, 22, 125, 508, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "517", "477", "RsTextbox", 0, "Superintendent_Stagnant_Hours_Cost", 98, 512, 22, 125, 509, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "518", "477", "RsTextbox", 0, "Superintendent_Stagnant_Hours_Hours", 98, 381, 22, 125, 510, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "519", "477", "RsTextbox", 0, "Superintendent_Install_Support_Hours", 70, 381, 22, 125, 511, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "520", "477", "RsLabel", 0, "", 182, 145, 21, 99, 512, "Install Support", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "521", "477", "RsLabel", 0, "", 70, 145, 21, 99, 513, "Install Support", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "522", "477", "RsTextbox", 0, "Superintendent_Install_Support_Cost", 70, 756, 22, 125, 514, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "523", "477", "RsTextbox", 0, "Administrative_Cost", 677, 512, 22, 125, 515, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "524", "477", "RsTextbox", 0, "Miscellaneous_Total_Cost", 649, 512, 22, 125, 516, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "525", "477", "RsTextbox", 0, "Superintendent_Total_Cost", 42, 512, 22, 125, 517, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "526", "477", "RsLabel", 0, "", 650, 73, 21, 171, 518, "Miscellanious", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "527", "477", "RsTextbox", 0, "Installer_Rate", 283, 250, 22, 125, 519, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "528", "477", "RsLabel", 0, "", 650, 6, 21, 72, 520, "16.01.99", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "529", "477", "RsTextbox", 0, "Superintendent_Rate", 42, 250, 22, 125, 521, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "530", "477", "RsTextbox", 0, "Additional_Subcontractor_Services_Total_Cost", 621, 512, 22, 125, 522, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "531", "477", "RsTextbox", 0, "Supplies_Consumables_Total_Cost", 537, 512, 22, 125, 523, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "532", "477", "RsTextbox", 0, "Travel_Expense_Total_Cost", 565, 512, 22, 125, 524, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "533", "477", "RsTextbox", 0, "Installer_Total_Cost", 283, 512, 22, 125, 525, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "534", "477", "RsLabel", 0, "", 16, 381, 21, 125, 526, "Hours", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "535", "477", "RsTextbox", 0, "Permits_Total_Cost", 593, 512, 22, 125, 527, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "536", "477", "RsLabel", 0, "", 16, 250, 21, 125, 528, "Rate", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "537", "477", "RsTextbox", 0, "Equipment_Rental_Total_Cost", 510, 512, 22, 125, 529, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "538", "477", "RsTextbox", 0, "Lead_Person_Total_Cost", 161, 512, 22, 125, 530, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "539", "477", "RsTextbox", 0, "Lead_Men_Rate", 161, 250, 22, 125, 531, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "540", "477", "RsTextbox", 0, "Lead_Person_Total_Hours", 161, 381, 22, 125, 532, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "541", "477", "RsLabel", 0, "", 43, 73, 21, 171, 533, "Superintendent", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "542", "477", "RsLabel", 0, "", 284, 6, 21, 72, 534, "16.01.02.02", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "543", "477", "RsLabel", 0, "", 161, 73, 21, 171, 535, "Lead Person", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "544", "477", "RsLabel", 0, "", 43, 6, 21, 72, 536, "16.01.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "545", "477", "RsLabel", 0, "", 622, 73, 21, 171, 537, "Additional Subcontractor Services", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "546", "477", "RsLabel", 0, "", 538, 73, 21, 171, 538, "Supplies/Consumables", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "547", "477", "RsLabel", 0, "", 566, 73, 21, 171, 539, "Travel Expenses", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "548", "477", "RsLabel", 0, "", 594, 73, 21, 171, 540, "Permits", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "549", "477", "RsLabel", 0, "", 517, 73, 21, 171, 541, "Equipment Rental", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "550", "477", "RsLabel", 0, "", 161, 6, 21, 72, 542, "16.01.02.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "551", "477", "RsLabel", 0, "", 622, 6, 21, 72, 543, "16.01.98", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "552", "477", "RsLabel", 0, "", 538, 6, 21, 72, 544, "16.01.05", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "553", "477", "RsLabel", 0, "", 566, 6, 21, 72, 545, "16.01.07", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "554", "477", "RsLabel", 0, "", 594, 6, 21, 72, 546, "16.01.08", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "555", "477", "RsLabel", 0, "", 517, 6, 21, 72, 547, "16.01.04", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "556", "194", "RsLabel", 0, "", 16, 522, 21, 67, 548, "Project Tier", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "557", "194", "RsComboBox", 0, "Project_Tier", 15, 595, 22, 125, 549, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Structures_Platforms()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(75, "Structures Platforms", "", 101, 51, 2, 28, 50, 50)
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
        oProcessStep = AddProcessStep(82, "Air Piping", "", 101, 51, 1, 29, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsSubForm", 0, "", 31, 12, 442, 1508, 0, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,132,My_Air_Piping")
        oProcessStep.AddCustomLayout(1, 360, "2", "1", "RsGroupBox", 0, "", 16, 3, 423, 1400, 1, "System 1", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "3", "2", "RsLabel", 0, "", 340, 6, 21, 111, 2, "Total Costs", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "4", "2", "RsLabel", 0, "", 375, 6, 21, 111, 3, "Total Hours", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "5", "2", "RsLabel", 0, "", 142, 949, 21, 111, 4, "@.150 HR/FT =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "6", "2", "RsLabel", 0, "", 120, 949, 21, 111, 5, "@.200 HR/FT =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "7", "2", "RsLabel", 0, "", 296, 949, 21, 111, 6, "@ 4 HRS EA =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "8", "2", "RsLabel", 0, "", 98, 949, 21, 111, 7, "@.350 HR/FT =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "9", "2", "RsLabel", 0, "", 274, 949, 21, 111, 8, "@ 2 HRS EA =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "10", "2", "RsLabel", 0, "", 208, 949, 21, 111, 9, "1 HR/100&amp;apos;  =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "11", "2", "RsTextbox", 0, "MEI_AP_SS1_IR_2HRS_EA_Red_AC", 273, 1059, 22, 86, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "12", "2", "RsLabel", 0, "", 252, 949, 21, 111, 11, "@ 8 HRS EA =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "13", "2", "RsLabel", 0, "", 164, 949, 21, 111, 12, "@.125 HR/FT =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "14", "2", "RsLabel", 0, "", 76, 949, 21, 111, 13, "@.450 HR/FT =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "15", "2", "RsLabel", 0, "", 341, 310, 20, 102, 14, "Air Piping Factor", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "16", "2", "RsTextbox", 0, "MEI_AP_SS1_Total_Hours", 374, 139, 22, 86, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "17", "2", "RsTextbox", 0, "MEI_AP_SS1_Air_Piping_Factor", 364, 310, 22, 102, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "18", "2", "RsTextbox", 0, "MEI_AP_SS1_Total_Costs", 339, 139, 22, 86, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "19", "2", "RsLabel", 0, "", 230, 949, 21, 111, 18, "@ 3 HRS EA =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "20", "2", "RsTextbox", 0, "MEI_AP_SS1_IR_4HRS_EA_Dryer", 295, 1059, 22, 86, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "21", "2", "RsLabel", 0, "", 46, 949, 20, 196, 20, "Installation Rate", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "22", "2", "RsTextbox", 0, "MEI_AP_SS1_IR_8HRS_EA_AC", 251, 1059, 22, 86, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "23", "2", "RsLabel", 0, "", 46, 858, 20, 85, 22, "Cost of Valves", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "24", "2", "RsTextbox", 0, "MEI_AP_SS1_IR_0_450_HR_FT_3Inch_Pipe", 75, 1060, 22, 85, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "25", "2", "RsTextbox", 0, "MEI_AP_SS1_IR_3HRS_EA_Filter_Reg", 229, 1059, 22, 86, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "26", "2", "RsTextbox", 0, "MEI_AP_SS1_IR_0_350_HR_FT_2Half_In_Pipe", 97, 1060, 22, 85, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "27", "2", "RsTextbox", 0, "MEI_AP_SS1_IR_1_HR_100FT_Tubing", 207, 1059, 22, 86, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "28", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Valves_3Inch_Pipe", 75, 858, 22, 85, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "29", "2", "RsTextbox", 0, "MEI_AP_SS1_IR_0_200_HR_FT_1Half_In_Pipe", 119, 1060, 22, 85, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "30", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Tees_7_8Inch_Pipe", 141, 767, 22, 85, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "31", "2", "RsLabel", 0, "", 46, 767, 20, 85, 30, "Cost of Tee&amp;apos;s", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "32", "2", "RsTextbox", 0, "MEI_AP_SS1_IR_0_150_HR_FT_7_8Inch_Pipe", 141, 1060, 22, 85, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "33", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Valves_2Half_In_Pipe", 97, 858, 22, 85, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "34", "2", "RsTextbox", 0, "MEI_AP_SS1_IR_0_125_HR_FT_Half_In_Pipe", 163, 1060, 22, 85, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "35", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Tees_3Inch_Pipe", 75, 767, 22, 85, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "36", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Valves_7_8Inch_Pipe", 141, 858, 22, 85, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "37", "2", "RsTextbox", 0, "", 185, 1060, 22, 85, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 360, "38", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Valves_1Half_In_Pipe", 119, 858, 22, 85, 37, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "39", "2", "RsLabel", 0, "", 46, 676, 20, 85, 38, "Cost of Elbows", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "40", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Tees_2Half_In_Pipe", 97, 767, 22, 85, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "41", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Valves_Half_In_Pipe", 163, 858, 22, 85, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "42", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_Pipe_n_Coupling_Sub_Totals", 185, 339, 22, 135, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 360, "43", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Elbows_2Half_In_Pipe", 97, 676, 22, 85, 42, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "44", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Valves_Sub_Totals", 185, 858, 22, 85, 43, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 360, "45", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Tees_1Half_In_Pipe", 119, 767, 22, 85, 44, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "46", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Elbows_3Inch_Pipe", 75, 676, 22, 85, 45, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "47", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_Pipe_n_Coupling_3Inch_Pipe", 75, 339, 22, 135, 46, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "48", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Elbows_1Half_In_Pipe", 119, 676, 22, 85, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "49", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Tees_Half_In_Pipe", 163, 767, 22, 85, 48, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "50", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Tees_Sub_Totals", 185, 767, 22, 85, 49, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 360, "51", "2", "RsLabel", 0, "", 46, 231, 20, 102, 50, "HookUp Cost", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "52", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Elbows_7_8Inch_Pipe", 141, 676, 22, 85, 51, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "53", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Elbows_Sub_Totals", 185, 676, 22, 85, 52, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 360, "54", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_Pipe_n_Coupling_7_8Inch_Pipe", 141, 339, 22, 135, 53, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "55", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Elbows_Half_In_Pipe", 163, 676, 22, 85, 54, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "56", "2", "RsLabel", 0, "", 46, 585, 20, 85, 55, "Cost of Hangers", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "57", "2", "RsLabel", 0, "", 46, 339, 20, 135, 56, "Cost of Pipe and Couplings", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "58", "2", "RsTextbox", 0, "MEI_AP_SS1_Hookup_Costs_Filter_Reg", 229, 231, 22, 102, 57, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "59", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_Half_In_Pipe", 163, 585, 22, 85, 58, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "60", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_Pipe_n_Coupling_Half_In_Pipe", 163, 339, 22, 135, 59, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "61", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_Sub_Totals", 185, 585, 22, 85, 60, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 360, "62", "2", "RsTextbox", 0, "MEI_AP_SS1_Hookup_Costs_AC", 251, 231, 22, 102, 61, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "63", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_2Half_In_Pipe", 97, 585, 22, 85, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "64", "2", "RsLabel", 0, "", 46, 480, 20, 99, 63, "Hangers Total Units", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "65", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_Pipe_n_Coupling_2Half_In_Pipe", 97, 339, 22, 135, 64, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "66", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Elbows_7_8Inch_Pipe", 141, 585, 22, 85, 65, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "67", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_TU_Half_In_Pipe", 163, 480, 22, 99, 66, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "68", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_Pipe_n_Coupling_1Half_In_Pipe", 119, 339, 22, 135, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "69", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_1Half_In_Pipe", 119, 585, 22, 85, 68, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "70", "2", "RsTextbox", 0, "", 185, 480, 22, 99, 69, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 360, "71", "2", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Dryer", 295, 123, 22, 102, 70, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "72", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_3Inch_Pipe", 75, 585, 22, 85, 71, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "73", "2", "RsTextbox", 0, "MEI_AP_SS1_Hookup_Costs_Red_AC", 273, 231, 22, 102, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "74", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_TU_2Half_In_Pipe", 97, 480, 22, 99, 73, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "75", "2", "RsTextbox", 0, "MEI_AP_SS1_Hookup_Costs_Dryer", 295, 231, 22, 102, 74, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "76", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_TU_7_8Inch_Pipe", 141, 480, 22, 99, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "77", "2", "RsTextbox", 0, "MEI_AP_SS1_Hookup_Costs_Tubing", 207, 231, 22, 102, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "78", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_TU_1Half_In_Pipe", 119, 480, 22, 99, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "79", "2", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Red_AC", 273, 123, 22, 102, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "80", "2", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_TU_3Inch_Pipe", 75, 480, 22, 99, 79, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "81", "2", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_Half_In_Pipe", 163, 123, 22, 102, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "82", "2", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_AC", 251, 123, 22, 102, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "83", "2", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_Sub_Totals", 185, 123, 22, 102, 82, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 360, "84", "2", "RsLabel", 0, "", 46, 123, 20, 102, 83, "Total Order", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "85", "2", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Filter_Reg", 229, 123, 22, 102, 84, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "86", "2", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_2Half_In_Pipe", 97, 123, 22, 102, 85, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "87", "2", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Tubing", 207, 123, 22, 102, 86, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "88", "2", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_7_8Inch_Pipe", 141, 123, 22, 102, 87, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "89", "2", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_1Half_In_Pipe", 119, 123, 22, 102, 88, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "90", "2", "RsLabel", 0, "", 274, 15, 20, 102, 89, "Red A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "91", "2", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_3Inch_Pipe", 75, 123, 22, 102, 90, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "92", "2", "RsLabel", 0, "", 296, 15, 20, 102, 91, "Dryer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "93", "2", "RsLabel", 0, "", 252, 15, 20, 102, 92, "A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "94", "2", "RsLabel", 0, "", 230, 15, 20, 102, 93, "FILTER/REG", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "95", "2", "RsLabel", 0, "", 208, 15, 20, 102, 94, "Tubing", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "96", "2", "RsLabel", 0, "", 186, 15, 20, 102, 95, "SUBTOTALS", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ActiveCaption;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "97", "2", "RsLabel", 0, "", 164, 15, 20, 102, 96, "1/2&amp;quot; (16.5mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "98", "2", "RsLabel", 0, "", 142, 15, 20, 102, 97, "7/8&amp;quot; (25mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "99", "2", "RsLabel", 0, "", 120, 15, 20, 102, 98, "1 1/2&amp;quot; (40mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "100", "2", "RsLabel", 0, "", 98, 15, 20, 102, 99, "2 1/2&amp;quot; (63mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "101", "2", "RsLabel", 0, "", 76, 15, 20, 102, 100, "3&amp;quot; (76mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "102", "2", "RsLabel", 0, "", 46, 15, 20, 102, 101, "Pipe Type", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "103", "2", "RsTextbox", 0, "DisplayName", 8, 196, 22, 125, 102, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "104", "2", "RsLabel", 0, "", 8, 112, 21, 78, 103, "System 1 Name", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "105", "0", "RsActionButton", 0, "", 581, 1289, 60, 114, 104, "Reset Delta", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:mechResetAirPipingDelta;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 360, "106", "0", "RsActionButton", 0, "", 499, 1289, 60, 114, 105, "Compare Delta", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:MechCompareAirPipingDelta;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 360, "107", "0", "RsSubForm", 0, "", 512, 40, 455, 385, 106, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,132,My_Air_Piping")
        oProcessStep.AddCustomLayout(1, 360, "108", "107", "RsGroupBox", 0, "", 6, 22, 438, 347, 107, "System 1", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "109", "108", "RsLabel", 0, "", 20, 12, 21, 94, 108, "System 1 Name", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "110", "108", "RsTextbox", 0, "DisplayName", 19, 112, 22, 125, 109, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "111", "108", "RsLabel", 0, "", 368, 57, 21, 111, 110, "Total Costs", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "112", "108", "RsLabel", 0, "", 403, 57, 21, 111, 111, "Total Hours", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "113", "108", "RsTextbox", 0, "MEI_AP_SS1_Total_Hours", 402, 190, 22, 86, 112, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "114", "108", "RsTextbox", 0, "MEI_AP_SS1_Total_Costs", 367, 190, 22, 86, 113, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "115", "108", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Dryer", 323, 174, 22, 102, 114, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "116", "108", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Red_AC", 301, 174, 22, 102, 115, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "117", "108", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_Half_In_Pipe", 191, 174, 22, 102, 116, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "118", "108", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_AC", 279, 174, 22, 102, 117, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "119", "108", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_Sub_Totals", 213, 174, 22, 102, 118, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 360, "120", "108", "RsLabel", 0, "", 74, 174, 20, 102, 119, "Total Order", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "121", "108", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Filter_Reg", 257, 174, 22, 102, 120, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "122", "108", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_2Half_In_Pipe", 125, 174, 22, 102, 121, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "123", "108", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Tubing", 235, 174, 22, 102, 122, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "124", "108", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_7_8Inch_Pipe", 169, 174, 22, 102, 123, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "125", "108", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_1Half_In_Pipe", 147, 174, 22, 102, 124, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "126", "108", "RsLabel", 0, "", 302, 66, 20, 102, 125, "Red A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "127", "108", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_3Inch_Pipe", 103, 174, 22, 102, 126, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "128", "108", "RsLabel", 0, "", 324, 66, 20, 102, 127, "Dryer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "129", "108", "RsLabel", 0, "", 280, 66, 20, 102, 128, "A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "130", "108", "RsLabel", 0, "", 258, 66, 20, 102, 129, "FILTER/REG", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "131", "108", "RsLabel", 0, "", 236, 66, 20, 102, 130, "Tubing", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "132", "108", "RsLabel", 0, "", 214, 66, 20, 102, 131, "SUBTOTALS", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ActiveCaption;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "133", "108", "RsLabel", 0, "", 192, 66, 20, 102, 132, "1/2&amp;quot; (16.5mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "134", "108", "RsLabel", 0, "", 170, 66, 20, 102, 133, "7/8&amp;quot; (25mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "135", "108", "RsLabel", 0, "", 148, 66, 20, 102, 134, "1 1/2&amp;quot; (40mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "136", "108", "RsLabel", 0, "", 126, 66, 20, 102, 135, "2 1/2&amp;quot; (63mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "137", "108", "RsLabel", 0, "", 104, 66, 20, 102, 136, "3&amp;quot; (76mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "138", "108", "RsLabel", 0, "", 74, 66, 20, 102, 137, "Pipe Type", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "139", "0", "RsLabel", 0, "", 8, 83, 21, 122, 138, "System 1 Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "140", "0", "RsSubForm", 0, "", 512, 850, 455, 385, 139, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,133,My_Air_Piping_Delta")
        oProcessStep.AddCustomLayout(1, 360, "141", "140", "RsGroupBox", 0, "", 5, 6, 438, 376, 140, "Delta", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "142", "141", "RsLabel", 0, "", 20, 40, 21, 94, 141, "Delta Name", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "143", "141", "RsTextbox", 0, "DisplayName", 20, 160, 22, 125, 142, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "144", "141", "RsLabel", 0, "", 367, 61, 21, 111, 143, "Total Costs", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "145", "141", "RsLabel", 0, "", 402, 61, 21, 111, 144, "Total Hours", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "146", "141", "RsTextbox", 0, "MEI_AP_SS1_Total_Hours", 401, 221, 22, 86, 145, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "147", "141", "RsTextbox", 0, "MEI_AP_SS1_Total_Costs", 366, 221, 22, 86, 146, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "148", "141", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Dryer", 323, 221, 22, 102, 147, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "149", "141", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Red_AC", 301, 221, 22, 102, 148, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "150", "141", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_Half_In_Pipe", 191, 221, 22, 102, 149, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "151", "141", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_AC", 279, 221, 22, 102, 150, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "152", "141", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_Sub_Totals", 213, 221, 22, 102, 151, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 360, "153", "141", "RsLabel", 0, "", 74, 221, 20, 102, 152, "Total Order", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "154", "141", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Filter_Reg", 257, 221, 22, 102, 153, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "155", "141", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_2Half_In_Pipe", 125, 221, 22, 102, 154, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "156", "141", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Tubing", 235, 221, 22, 102, 155, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "157", "141", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_7_8Inch_Pipe", 169, 221, 22, 102, 156, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "158", "141", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_1Half_In_Pipe", 147, 221, 22, 102, 157, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "159", "141", "RsLabel", 0, "", 302, 64, 20, 102, 158, "Red A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "160", "141", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_3Inch_Pipe", 103, 221, 22, 102, 159, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "161", "141", "RsLabel", 0, "", 324, 64, 20, 102, 160, "Dryer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "162", "141", "RsLabel", 0, "", 280, 64, 20, 102, 161, "A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "163", "141", "RsLabel", 0, "", 258, 64, 20, 102, 162, "FILTER/REG", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "164", "141", "RsLabel", 0, "", 236, 64, 20, 102, 163, "Tubing", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "165", "141", "RsLabel", 0, "", 214, 64, 20, 102, 164, "SUBTOTALS", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ActiveCaption;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "166", "141", "RsLabel", 0, "", 192, 64, 20, 102, 165, "1/2&amp;quot; (16.5mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "167", "141", "RsLabel", 0, "", 170, 64, 20, 102, 166, "7/8&amp;quot; (25mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "168", "141", "RsLabel", 0, "", 148, 64, 20, 102, 167, "1 1/2&amp;quot; (40mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "169", "141", "RsLabel", 0, "", 126, 64, 20, 102, 168, "2 1/2&amp;quot; (63mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "170", "141", "RsLabel", 0, "", 104, 64, 20, 102, 169, "3&amp;quot; (76mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "171", "141", "RsLabel", 0, "", 74, 64, 20, 102, 170, "Pipe Type", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "172", "0", "RsSubForm", 0, "", 513, 447, 455, 385, 171, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,134,My_Air_Piping_2")
        oProcessStep.AddCustomLayout(1, 360, "173", "172", "RsGroupBox", 0, "", 4, 3, 439, 376, 172, "System 2", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "174", "173", "RsLabel", 0, "", 20, 16, 21, 94, 173, "System 2 Name", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "175", "173", "RsTextbox", 0, "DisplayName", 20, 116, 22, 125, 174, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "176", "173", "RsLabel", 0, "", 369, 88, 21, 111, 175, "Total Costs", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "177", "173", "RsLabel", 0, "", 404, 88, 21, 111, 176, "Total Hours", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "178", "173", "RsTextbox", 0, "MEI_AP_SS1_Total_Hours", 403, 221, 22, 86, 177, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "179", "173", "RsTextbox", 0, "MEI_AP_SS1_Total_Costs", 368, 221, 22, 86, 178, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "180", "173", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Dryer", 324, 205, 22, 102, 179, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "181", "173", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Red_AC", 302, 205, 22, 102, 180, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "182", "173", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_Half_In_Pipe", 192, 205, 22, 102, 181, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "183", "173", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_AC", 280, 205, 22, 102, 182, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "184", "173", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_Sub_Totals", 214, 205, 22, 102, 183, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 360, "185", "173", "RsLabel", 0, "", 75, 205, 20, 102, 184, "Total Order", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "186", "173", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Filter_Reg", 258, 205, 22, 102, 185, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "187", "173", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_2Half_In_Pipe", 126, 205, 22, 102, 186, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "188", "173", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Tubing", 236, 205, 22, 102, 187, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "189", "173", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_7_8Inch_Pipe", 170, 205, 22, 102, 188, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "190", "173", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_1Half_In_Pipe", 148, 205, 22, 102, 189, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "191", "173", "RsLabel", 0, "", 303, 97, 20, 102, 190, "Red A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "192", "173", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_3Inch_Pipe", 104, 205, 22, 102, 191, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "193", "173", "RsLabel", 0, "", 325, 97, 20, 102, 192, "Dryer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "194", "173", "RsLabel", 0, "", 281, 97, 20, 102, 193, "A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "195", "173", "RsLabel", 0, "", 259, 97, 20, 102, 194, "FILTER/REG", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "196", "173", "RsLabel", 0, "", 237, 97, 20, 102, 195, "Tubing", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "197", "173", "RsLabel", 0, "", 215, 97, 20, 102, 196, "SUBTOTALS", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ActiveCaption;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "198", "173", "RsLabel", 0, "", 193, 97, 20, 102, 197, "1/2&amp;quot; (16.5mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "199", "173", "RsLabel", 0, "", 171, 97, 20, 102, 198, "7/8&amp;quot; (25mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "200", "173", "RsLabel", 0, "", 149, 97, 20, 102, 199, "1 1/2&amp;quot; (40mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "201", "173", "RsLabel", 0, "", 127, 97, 20, 102, 200, "2 1/2&amp;quot; (63mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "202", "173", "RsLabel", 0, "", 105, 97, 20, 102, 201, "3&amp;quot; (76mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "203", "173", "RsLabel", 0, "", 75, 97, 20, 102, 202, "Pipe Type", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "204", "0", "RsLabel", 0, "", 489, 490, 21, 124, 203, "System 2 Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "205", "0", "RsComboBox", 0, "Selection_System_Delta", 488, 620, 22, 125, 204, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "206", "0", "RsLabel", 0, "", 488, 83, 21, 122, 205, "System 1 Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "207", "0", "RsComboBox", 0, "Selection_System", 488, 211, 22, 125, 206, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "208", "0", "RsComboBox", 0, "Selection_System", 7, 211, 22, 125, 207, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Chutes()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(94, "Chutes", "", 101, 51, 1, 30, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsLabel", 0, "", 9, 12, 21, 47, 0, "System", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "2", "0", "RsComboBox", 0, "Selection_System", 8, 65, 22, 125, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "3", "0", "RsSubForm", 0, "", 36, 12, 772, 1513, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,135,My_Chute")
        oProcessStep.AddCustomLayout(1, 360, "4", "3", "RsGrid", 0, "", 3, 0, 319, 723, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,345,Chute;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 360, "5", "4", "RsGridColumn", 0, "MEI_Chutes_Styles", 0, 0, 0, 100, 0, "Chute Style", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "6", "4", "RsGridColumn", 0, "MEI_Chutes_Style_1_Angle_of_Curve", 0, 0, 0, 100, 0, "Angle of Curve", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "7", "4", "RsGridColumn", 0, "MEI_Chutes_Style_1_Length_in_Feet", 0, 0, 0, 100, 0, "Length in Feet", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "8", "4", "RsGridColumn", 0, "MEI_Chutes_Style_1_Type_of_Material", 0, 0, 0, 100, 0, "Type of Material", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "9", "4", "RsGridColumn", 0, "MEI_Chutes_Style_1_Infeed_Conveyor_Type", 0, 0, 0, 100, 0, "Infeed Conveyor Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "10", "4", "RsGridColumn", 0, "MEI_Chutes_Style_1_Number_of_Merging_Lanes", 0, 0, 0, 100, 0, "Number of Merging Lanes", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "11", "4", "RsGridColumn", 0, "MEI_Chutes_Style_1_Number_of_Sorting_Lanes", 0, 0, 0, 100, 0, "Number of Sorting Lanes", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "12", "3", "RsAddDeleteCopy", 0, "", 328, 565, 22, 158, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,345,Chute;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 360, "13", "3", "RsGrid", 0, "", 369, 0, 319, 822, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,345,Chute;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 360, "14", "13", "RsGridColumn", 0, "MEI_Chutes_Styles", 0, 0, 0, 100, 0, "Chute Style", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "15", "13", "RsGridColumn", 0, "MEI_Chutes_Style_1_Angle_hrs", 0, 0, 0, 100, 0, "Angle hrs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "16", "13", "RsGridColumn", 0, "MEI_Chutes_Style_1_Length_hrs", 0, 0, 0, 100, 0, "Length hrs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "17", "13", "RsGridColumn", 0, "MEI_Chutes_Style_1_Material_hrs", 0, 0, 0, 100, 0, "Material hrs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "18", "13", "RsGridColumn", 0, "MEI_Chutes_Style_1_Infeed_hrs", 0, 0, 0, 100, 0, "Infeed hrs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "19", "13", "RsGridColumn", 0, "MEI_Chutes_Style_1_Merge_hrs", 0, 0, 0, 100, 0, "Merge hrs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "20", "13", "RsGridColumn", 0, "MEI_Chutes_Style_1_Sort_hrs", 0, 0, 0, 100, 0, "Sort hrs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "21", "13", "RsGridColumn", 0, "MEI_Chutes_Style_1_Total_Hours_per_Chute", 0, 0, 0, 100, 0, "Total Hours per Chute", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Shuttle_Mech()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(91, "Shuttle Mech", "", 101, 51, 1, 31, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App.Shuttle_Mech/CAE_Shuttle_Mech")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 398, "1", "0", "RsGroupBox", 0, "", 12, 1, 1400, 1800, 0, "Shuttle", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 398, "2", "1", "RsGroupBox", 0, "", 46, 12, 609, 735, 1, "Racking Installation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 398, "3", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Layout_System_Qty", 504, 389, 22, 102, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "4", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Netting_System_Qty", 410, 389, 22, 102, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "5", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_Ladders_Rate", 432, 497, 22, 102, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "6", "2", "RsLabel", 0, "", 433, 277, 21, 111, 5, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "7", "2", "RsLabel", 0, "", 455, 277, 21, 111, 6, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "8", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Layout_Hours", 504, 605, 22, 102, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "9", "2", "RsLabel", 0, "", 289, 277, 21, 111, 8, "Feet", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "10", "2", "RsLabel", 0, "", 245, 277, 21, 111, 9, "Feet", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "11", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Total_Rack_Hours", 566, 605, 22, 102, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "12", "2", "RsLabel", 0, "", 567, 488, 21, 111, 11, "Total Rack Hours:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "13", "2", "RsLabel", 0, "", 147, 277, 21, 111, 12, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "14", "2", "RsLabel", 0, "", 526, 277, 21, 111, 13, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "15", "2", "RsLabel", 0, "", 21, 339, 20, 152, 14, "Racking Installation", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "16", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Entry_Gates_Rate", 475, 497, 22, 102, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "17", "2", "RsLabel", 0, "", 505, 277, 21, 111, 16, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "18", "2", "RsLabel", 0, "", 476, 31, 20, 132, 17, "Entry Gates", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "19", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Material_Movement_Hours", 525, 605, 22, 102, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "20", "2", "RsLabel", 0, "", 191, 277, 21, 111, 19, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "21", "2", "RsLabel", 0, "", 267, 277, 21, 111, 20, "Feet", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "22", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Layout_Rate", 504, 497, 22, 102, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "23", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Stairs_Rate", 454, 497, 22, 102, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "24", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Entry_Gates_Hours", 475, 605, 22, 102, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "25", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Stairs_System_Qty", 454, 389, 22, 102, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "26", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Material_Movement_Input", 525, 169, 22, 102, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "27", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Material_Movement_System_Qty", 525, 389, 22, 102, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "28", "2", "RsLabel", 0, "", 213, 277, 21, 111, 27, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "29", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Stairs_Hours", 454, 605, 22, 102, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "30", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Layout_Input", 504, 169, 22, 102, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "31", "2", "RsLabel", 0, "", 367, 277, 21, 111, 30, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "32", "2", "RsLabel", 0, "", 57, 389, 20, 102, 31, "System Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "33", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_Ladders_Hours", 432, 605, 22, 102, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "34", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Entry_Gates_System_Qty", 475, 389, 22, 102, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "35", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Sides_of_Netting_Hours", 388, 605, 22, 102, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "36", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Material_Movement_Rate", 525, 497, 22, 102, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "37", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Netting_Hours", 410, 605, 22, 102, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "38", "2", "RsLabel", 0, "", 344, 277, 21, 111, 37, "Sq.Ft.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "39", "2", "RsLabel", 0, "", 476, 277, 21, 111, 38, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "40", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_Platform_Hours", 366, 605, 22, 102, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "41", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Sides_of_Netting_Rate", 388, 497, 22, 102, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "42", "2", "RsLabel", 0, "", 57, 281, 20, 102, 41, "UoM", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "43", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Netting_Rate", 410, 497, 22, 102, 42, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "44", "2", "RsLabel", 0, "", 389, 277, 21, 111, 43, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "45", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_SQ_Ft_Platform_Hours", 343, 605, 22, 102, 44, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "46", "2", "RsLabel", 0, "", 103, 277, 21, 111, 45, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "47", "2", "RsLabel", 0, "", 125, 277, 21, 111, 46, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "48", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_Ladders_System_Qty", 432, 389, 22, 102, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "49", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Fencing_Hours", 323, 605, 22, 102, 48, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "50", "2", "RsLabel", 0, "", 411, 277, 21, 111, 49, "Linear Ft per Side", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "51", "2", "RsLabel", 0, "", 169, 277, 21, 111, 50, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "52", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Width_Hours", 288, 605, 22, 102, 51, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "53", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Entry_Gates_Input", 475, 169, 22, 102, 52, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "54", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Sides_of_Netting_System_Qty", 388, 389, 22, 102, 53, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "55", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_Platform_Rate", 366, 497, 22, 102, 54, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "56", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Levels_Aisle_Hours", 168, 605, 22, 102, 55, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "57", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_Platform_System_Qty", 366, 389, 22, 102, 56, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "58", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_SQ_Ft_Platform_Rate", 343, 497, 22, 102, 57, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "59", "2", "RsLabel", 0, "", 324, 277, 21, 111, 58, "Ft", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "60", "2", "RsLabel", 0, "", 81, 277, 21, 111, 59, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "61", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Fencing_Rate", 323, 497, 22, 102, 60, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "62", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Length_Hours", 266, 605, 22, 102, 61, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "63", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_SQ_Ft_Platform_Sys_Qty", 343, 389, 22, 102, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "64", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Width_Rate", 288, 497, 22, 102, 63, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "65", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Totes_per_Bay_Hours", 190, 605, 22, 102, 64, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.0;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "66", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Fencing_System_Qty", 323, 389, 22, 102, 65, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "67", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Levels_Aisle_Rate", 168, 497, 22, 102, 66, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "68", "2", "RsLabel", 0, "", 57, 605, 20, 102, 67, "Hours", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "69", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Width_System_Qty", 288, 389, 22, 102, 68, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "70", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Length_Rate", 266, 497, 22, 102, 69, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "71", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Height_Hours", 244, 605, 22, 102, 70, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "72", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Levels_Aisle_System_Qty", 168, 389, 22, 102, 71, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "73", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Totes_per_Bay_Rate", 190, 497, 22, 102, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.0;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "74", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Std_Rack_Bays_Aisle_Hours", 102, 605, 22, 102, 73, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "75", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Front_Zone_Hours", 212, 605, 22, 102, 74, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "76", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_Levels_Aisle_Hours", 146, 605, 22, 102, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "77", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Bracing_Rack_Bays_Aisle_Hours", 124, 605, 22, 102, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "78", "2", "RsLabel", 0, "", 57, 497, 20, 102, 77, "Rate", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "79", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Aisles_Hours", 80, 605, 22, 102, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "80", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Length_System_Qty", 266, 389, 22, 102, 79, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "81", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Height_Rate", 244, 497, 22, 102, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "82", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Totes_per_Bay_System_Qty", 190, 389, 22, 102, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.0;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "83", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Height_System_Qty", 244, 389, 22, 102, 82, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "84", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Stairs_Input", 454, 169, 22, 102, 83, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "85", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Std_Rack_Bays_Aisle_System_Qty", 102, 389, 22, 102, 84, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "86", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Front_Zone_System_Qty", 212, 389, 22, 102, 85, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "87", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_Levels_Aisle_System_Qty", 146, 389, 22, 102, 86, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "88", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_Ladders_Input", 432, 169, 22, 102, 87, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "89", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Bracing_Rack_Bays_Aisle_System_Qty", 124, 389, 22, 102, 88, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "90", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Sides_of_Netting_Input", 388, 169, 22, 102, 89, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "91", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Aisles_System_Qty", 80, 389, 22, 102, 90, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "92", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Std_Rack_Bays_Aisle_Rate", 102, 497, 22, 102, 91, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "93", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Front_Zone_Rate", 212, 497, 22, 102, 92, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "94", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_Levels_Aisle_Rate", 146, 497, 22, 102, 93, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "95", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Bracing_Rack_Bays_Aisle_Rate", 124, 497, 22, 102, 94, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "96", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Aisles_Rate", 80, 497, 22, 102, 95, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "97", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Netting_Input", 410, 169, 22, 102, 96, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "98", "2", "RsLabel", 0, "", 526, 31, 20, 132, 97, "Material Movement", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "99", "2", "RsLabel", 0, "", 505, 31, 20, 132, 98, "Layout", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "100", "2", "RsLabel", 0, "", 455, 31, 20, 132, 99, "Stairs", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "101", "2", "RsLabel", 0, "", 433, 31, 20, 132, 100, "Service Ladders", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "102", "2", "RsLabel", 0, "", 411, 31, 20, 132, 101, "Netting", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "103", "2", "RsLabel", 0, "", 389, 31, 20, 132, 102, "Sides of Netting", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "104", "2", "RsLabel", 0, "", 367, 31, 20, 132, 103, "Service Platform", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "105", "2", "RsLabel", 0, "", 344, 31, 20, 132, 104, "Service Platform", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "106", "2", "RsLabel", 0, "", 324, 31, 20, 132, 105, "Fencing", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "107", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_Platform_Input", 366, 169, 22, 102, 106, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "108", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_SQ_Ft_Platform_Input", 343, 169, 22, 102, 107, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "109", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Fencing_Input", 323, 169, 22, 102, 108, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "110", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Width_Input", 288, 169, 22, 102, 109, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "111", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Levels_Aisle_Input", 168, 169, 22, 102, 110, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "112", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Length_Input", 266, 169, 22, 102, 111, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "113", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Totes_per_Bay_Input", 190, 169, 22, 102, 112, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.0;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "114", "2", "RsLabel", 0, "", 57, 169, 20, 102, 113, "Input", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "115", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Height_Input", 244, 169, 22, 102, 114, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "116", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Std_Rack_Bays_Aisle_Input", 102, 169, 22, 102, 115, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "117", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Front_Zone_Input", 212, 169, 22, 102, 116, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "118", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Service_Levels_Aisle_Input", 146, 169, 22, 102, 117, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "119", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Bracing_Rack_Bays_Aisle_Input", 124, 169, 22, 102, 118, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "120", "2", "RsLabel", 0, "", 289, 31, 20, 132, 119, "Width", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "121", "2", "RsTextbox", 0, "MEI_Shuttle_RI_Aisles_Input", 80, 169, 22, 102, 120, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "122", "2", "RsLabel", 0, "", 267, 31, 20, 132, 121, "Length", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "123", "2", "RsLabel", 0, "", 245, 31, 20, 132, 122, "Height", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "124", "2", "RsLabel", 0, "", 213, 31, 20, 132, 123, "Front Zone", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "125", "2", "RsLabel", 0, "", 191, 31, 20, 132, 124, "Totes per Bay", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "126", "2", "RsLabel", 0, "", 169, 31, 20, 132, 125, "Levels/Aisle", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "127", "2", "RsLabel", 0, "", 147, 31, 20, 132, 126, "Service Levels/Aisle", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "128", "2", "RsLabel", 0, "", 125, 31, 20, 132, 127, "Bracing Rack Bays/Aisle", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "129", "2", "RsLabel", 0, "", 103, 31, 20, 132, 128, "Standard Rack Bays/Aisle", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "130", "2", "RsLabel", 0, "", 81, 31, 20, 132, 129, "Aisles", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "131", "1", "RsGroupBox", 0, "", 47, 753, 309, 735, 130, "Mechanical Installation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 398, "132", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Total_Hours", 266, 169, 22, 102, 131, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "133", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Total_Shuttle_Hours", 233, 169, 22, 102, 132, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "134", "131", "RsLabel", 0, "", 267, 57, 21, 111, 133, "TOTAL HOURS", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "135", "131", "RsLabel", 0, "", 234, 57, 21, 111, 134, "Total Shuttle Hours:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "136", "131", "RsLabel", 0, "", 147, 277, 21, 111, 135, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "137", "131", "RsLabel", 0, "", 20, 287, 20, 204, 136, "Mechanical Installation", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "138", "131", "RsLabel", 0, "", 191, 277, 21, 111, 137, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "139", "131", "RsLabel", 0, "", 57, 389, 20, 102, 138, "System Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "140", "131", "RsLabel", 0, "", 57, 281, 20, 102, 139, "UoM", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "141", "131", "RsLabel", 0, "", 103, 277, 21, 111, 140, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "142", "131", "RsLabel", 0, "", 125, 277, 21, 111, 141, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "143", "131", "RsLabel", 0, "", 169, 277, 21, 111, 142, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "144", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Other_Lifts_Aisle_Hours", 168, 605, 22, 102, 143, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "145", "131", "RsLabel", 0, "", 81, 277, 21, 111, 144, "Qty", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "146", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Hoist_Hours", 190, 605, 22, 102, 145, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.0;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "147", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Other_Lifts_Aisle_Rate", 168, 497, 22, 102, 146, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "148", "131", "RsLabel", 0, "", 57, 605, 20, 102, 147, "Hours", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "149", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Other_Lifts_Aisle_System_Qty", 168, 389, 22, 102, 148, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "150", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Hoist_Rate", 190, 497, 22, 102, 149, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.0;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "151", "131", "RsTextbox", 0, "MEI_Shuttle_MI_MDR_Installation_Aisle_Hours", 102, 605, 22, 102, 150, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "152", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Double_MDR_Lifts_Aisle_Hours", 146, 605, 22, 102, 151, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "153", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Vertical_Lifts_Aisle_Hours", 124, 605, 22, 102, 152, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "154", "131", "RsLabel", 0, "", 57, 497, 20, 102, 153, "Rate", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "155", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Shuttles_Aisle_Hours", 80, 605, 22, 102, 154, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "156", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Hoist_System_Qty", 190, 389, 22, 102, 155, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.0;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "157", "131", "RsTextbox", 0, "MEI_Shuttle_MI_MDR_Installation_Aisle_System_Qty", 102, 389, 22, 102, 156, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "158", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Double_MDR_Lifts_Aisle_System_Qty", 146, 389, 22, 102, 157, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "159", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Vertical_Lifts_Aisle_System_Qty", 124, 389, 22, 102, 158, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "160", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Shuttles_Aisle_System_Qty", 80, 389, 22, 102, 159, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "161", "131", "RsTextbox", 0, "MEI_Shuttle_MI_MDR_Installation_Aisle_Rate", 102, 497, 22, 102, 160, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "162", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Double_MDR_Lifts_Aisle_Rate", 146, 497, 22, 102, 161, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "163", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Vertical_Lifts_Aisle_Rate", 124, 497, 22, 102, 162, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "164", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Shuttles_Aisle_Rate", 80, 497, 22, 102, 163, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "165", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Other_Lifts_Aisle_Input", 168, 169, 22, 102, 164, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "166", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Hoist_Input", 190, 169, 22, 102, 165, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.0;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "167", "131", "RsLabel", 0, "", 57, 169, 20, 102, 166, "Input", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.12;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "168", "131", "RsTextbox", 0, "MEI_Shuttle_MI_MDR_Installation_Aisle_Input", 102, 169, 22, 102, 167, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "169", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Double_MDR_Lifts_Aisle_Input", 146, 169, 22, 102, 168, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "170", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Vertical_Lifts_Aisle_Input", 124, 169, 22, 102, 169, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "171", "131", "RsTextbox", 0, "MEI_Shuttle_MI_Shuttles_Aisle_Input", 80, 169, 22, 102, 170, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 398, "172", "131", "RsLabel", 0, "", 191, 31, 20, 132, 171, "Hoist", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "173", "131", "RsLabel", 0, "", 169, 31, 20, 132, 172, "Other Lifts/Aisle", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "174", "131", "RsLabel", 0, "", 147, 31, 20, 132, 173, "Double MDR Lifts/Aisle", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "175", "131", "RsLabel", 0, "", 125, 31, 20, 132, 174, "Vertical Lifts/Aisle", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "176", "131", "RsLabel", 0, "", 103, 31, 20, 132, 175, "MDR Installation/Aisle", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "177", "131", "RsLabel", 0, "", 81, 31, 20, 132, 176, "Shuttles/Aisle", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 398, "178", "1", "RsLabel", 0, "", 16, 713, 27, 73, 177, "Shuttle", 0, 2, 1, 5, 0, "", "", "Font:1.;Font_Size:1.15;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_TTCB_Costing_Mech()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(92, "TTCB Costing Mech", "", 101, 51, 1, 32, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App.TTCB_Costing_Mech/CAE_TTCB_Costing_Mech")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 401, "1", "0", "RsTabControl", 0, "", 0, 0, 658, 1020, 0, "", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 401, "2", "1", "RsTabPage", 0, "", 0, 0, 0, 0, 0, "Inputs", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 401, "3", "2", "RsGroupBox", 0, "", 12, 18, 166, 364, 1, "Project Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "4", "3", "RsTextbox", 0, "MEI_Project_Info_Number", 74, 87, 22, 125, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "5", "3", "RsTextbox", 0, "MEI_Project_Info_Location", 45, 87, 22, 125, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "6", "3", "RsComboBox", 0, "MEI_Project_Info_Project_Tier", 37, 235, 22, 125, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "7", "3", "RsLabel", 0, "", 16, 235, 21, 75, 5, "Project Tier", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "8", "3", "RsTextbox", 0, "MEI_Project_Info_Description", 102, 87, 22, 125, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "9", "3", "RsTextbox", 0, "MEI_Project_Info_Customer", 16, 87, 22, 125, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "10", "3", "RsLabel", 0, "", 132, 6, 21, 75, 8, "Quote Date", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "11", "3", "RsLabel", 0, "", 103, 6, 21, 75, 9, "Description", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "12", "3", "RsLabel", 0, "", 74, 6, 21, 75, 10, "Number", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "13", "3", "RsLabel", 0, "", 45, 6, 21, 75, 11, "Location", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "14", "3", "RsLabel", 0, "", 16, 6, 21, 75, 12, "Customer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "15", "3", "RsSingleDatePicker", 0, "MEI_Project_Info_Quote_Date", 132, 87, 20, 125, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 401, "16", "2", "RsGroupBox", 0, "", 190, 606, 111, 331, 14, "Fencing and Gates", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "17", "16", "RsTextbox", 0, "MEI_Fencing_Footage_Cost_per_Hours", 45, 187, 22, 62, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "18", "16", "RsTextbox", 0, "MEI_Gates_QTY_Cost_per_Hours", 66, 187, 22, 62, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "19", "16", "RsTextbox", 0, "MEI_Gates_QTY_Total", 66, 255, 22, 62, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "20", "16", "RsTextbox", 0, "MEI_Fencing_Footage_Total", 45, 255, 22, 62, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "21", "16", "RsLabel", 0, "", 16, 255, 21, 62, 19, "Total", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "22", "16", "RsTextbox", 0, "MEI_Gates_QTY", 66, 119, 22, 62, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "23", "16", "RsLabel", 0, "", 16, 187, 21, 62, 21, "Cost/HRS", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "24", "16", "RsTextbox", 0, "MEI_Fencing_Footage", 45, 119, 22, 62, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "25", "16", "RsLabel", 0, "", 16, 119, 21, 62, 23, "Quantity", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "26", "16", "RsLabel", 0, "", 66, 6, 21, 105, 24, "Gates QTY", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "27", "16", "RsLabel", 0, "", 45, 6, 21, 105, 25, "Fencing footage", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "28", "2", "RsGroupBox", 0, "", 313, 478, 243, 538, 26, "Adjust $ and Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "29", "28", "RsTextbox", 0, "MEI_Adjust_Hours_TTCB_Sorter", 41, 234, 22, 62, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "30", "28", "RsTextbox", 0, "MEI_Adjust_Hours_Total", 211, 234, 22, 62, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "31", "28", "RsLabel", 0, "", 212, 24, 21, 105, 29, "Total", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "32", "28", "RsLabel", 0, "", 170, 24, 21, 105, 30, "Miscellaneous 2", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "33", "28", "RsTextbox", 0, "MEI_Adjust_Hours_Miscellaneous_2", 169, 234, 22, 62, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "34", "28", "RsTextbox", 0, "MEI_Adjust_Dollar_Miscellaneous_2", 169, 137, 22, 91, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "35", "28", "RsLabel", 0, "", 191, 24, 21, 105, 33, "Miscellaneous 3", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "36", "28", "RsTextbox", 0, "MEI_Adjust_Hours_Fencing", 106, 234, 22, 62, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "37", "28", "RsTextbox", 0, "MEI_Adjust_Hours_Miscellaneous_3", 190, 234, 22, 62, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "38", "28", "RsLabel", 0, "", 18, 24, 21, 105, 36, "Items", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "39", "28", "RsTextbox", 0, "MEI_Adjust_Hours_Gates", 127, 234, 22, 62, 37, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "40", "28", "RsTextbox", 0, "MEI_Adjust_Dollar_Total", 211, 137, 22, 91, 38, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "41", "28", "RsTextbox", 0, "MEI_Adjust_Hours_System_Efficiency", 62, 234, 22, 62, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "42", "28", "RsTextbox", 0, "MEI_Adjust_Dollar_Miscellaneous_1", 148, 137, 22, 91, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "43", "28", "RsTextbox", 0, "MEI_Adjust_Dollar_Miscellaneous_3", 190, 137, 22, 91, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "44", "28", "RsTextbox", 0, "MEI_Ajust_Total_Percentage", 62, 302, 22, 66, 42, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "45", "28", "RsTextbox", 0, "MEI_Adjust_Dollar_Clean_Up", 85, 137, 22, 91, 43, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "46", "28", "RsTextbox", 0, "MEI_Adjust_Hours_Miscellaneous_1", 148, 234, 22, 62, 44, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "47", "28", "RsTextbox", 0, "MEI_Adjust_TTCB_Sorter_Length_in_Meters", 41, 302, 22, 66, 45, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "48", "28", "RsTextbox", 0, "MEI_Adjust_Dollar_Gates", 127, 137, 22, 91, 46, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "49", "28", "RsTextbox", 0, "MEI_Adjust_Hours_Clean_Up", 85, 234, 22, 62, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "50", "28", "RsTextbox", 0, "MEI_Adjust_Dollar_Fencing", 106, 137, 22, 91, 48, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "51", "28", "RsLabel", 0, "", 18, 302, 21, 66, 49, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "52", "28", "RsLabel", 0, "", 149, 24, 21, 105, 50, "Miscellaneous 1", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "53", "28", "RsTextbox", 0, "MEI_Adjust_Dollar_System_Efficiency", 62, 137, 22, 91, 51, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "54", "28", "RsLabel", 0, "", 128, 24, 21, 105, 52, "Gates", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "55", "28", "RsLabel", 0, "", 18, 234, 21, 62, 53, "Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "56", "28", "RsLabel", 0, "", 107, 24, 21, 105, 54, "Fencing", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "57", "28", "RsTextbox", 0, "MEI_Adjust_Dollar_TTCB_Sorter", 41, 137, 22, 91, 55, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "58", "28", "RsLabel", 0, "", 18, 137, 21, 91, 56, "USD($)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "59", "28", "RsLabel", 0, "", 86, 24, 21, 105, 57, "Clean Up", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "60", "28", "RsLabel", 0, "", 63, 24, 21, 105, 58, "System Efficiency", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "61", "28", "RsLabel", 0, "", 42, 24, 21, 105, 59, "TT/CB Sorter", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "62", "28", "RsLabel", 0, "", 41, 374, 21, 158, 60, "&amp;lt;-- Enter TTCB length in Meter", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "63", "2", "RsGroupBox", 0, "", 12, 394, 168, 425, 61, "Crew Mobilization Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "64", "63", "RsLabel", 0, "", 10, 245, 21, 174, 62, "NOTE: Mobilization = 1 Roundtrip", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:Red;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "65", "63", "RsLabel", 0, "", 19, 24, 21, 127, 63, "Mobilzation Cost/Person:", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "66", "63", "RsLabel", 0, "", 132, 137, 21, 91, 64, "Total", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "67", "63", "RsTextbox", 0, "MEI_Crew_Mobilization_Cost_Per_Person", 19, 157, 22, 71, 65, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "68", "63", "RsTextbox", 0, "MEI_Crew_Head_Count_Total", 132, 234, 22, 62, 66, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "69", "63", "RsTextbox", 0, "MEI_Crew_Total_Mobilization_Cost_Total", 132, 302, 22, 117, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "70", "63", "RsLabel", 0, "", 45, 24, 21, 105, 68, "Crew", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "71", "63", "RsTextbox", 0, "MEI_Crew_Head_Count_Superintendent", 66, 234, 22, 62, 69, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "72", "63", "RsTextbox", 0, "MEI_Crew_Total_Mobilization_Cost_Installer", 110, 302, 22, 117, 70, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "73", "63", "RsTextbox", 0, "MEI_Crew_Head_Count_Lead_Men", 88, 234, 22, 62, 71, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "74", "63", "RsTextbox", 0, "MEI_Crew_Total_Mobilization_Cost_Lead_Men", 88, 302, 22, 117, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "75", "63", "RsTextbox", 0, "MEI_Crew_Mobilization_Count_Installer", 110, 137, 22, 91, 73, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "76", "63", "RsTextbox", 0, "MEI_Crew_Total_Mobilization_Cost_Superintendent", 66, 302, 22, 117, 74, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "77", "63", "RsTextbox", 0, "MEI_Crew_Head_Count_Installer", 110, 234, 22, 62, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "78", "63", "RsLabel", 0, "", 45, 302, 21, 117, 76, "Total Mobilization Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "79", "63", "RsTextbox", 0, "MEI_Crew_Mobilization_Count_Lead_Men", 88, 137, 22, 91, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "80", "63", "RsLabel", 0, "", 45, 234, 21, 62, 78, "Headcount", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "81", "63", "RsTextbox", 0, "MEI_Crew_Mobilization_Count_Superintendent", 66, 137, 22, 91, 79, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "82", "63", "RsLabel", 0, "", 45, 137, 21, 91, 80, "Mobilization Count", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "83", "63", "RsLabel", 0, "", 108, 24, 21, 105, 81, "Installers", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "84", "63", "RsLabel", 0, "", 87, 24, 21, 105, 82, "Lead Men", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "85", "63", "RsLabel", 0, "", 66, 24, 21, 105, 83, "Superintendents", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "86", "2", "RsGroupBox", 0, "", 186, 269, 115, 331, 84, "People Needs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "87", "86", "RsTextbox", 0, "MEI_People_Needs_Comm_No_of_Superintendents", 45, 187, 22, 62, 85, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "88", "86", "RsTextbox", 0, "MEI_People_Needs_Comm_No_of_Lead_Men", 66, 187, 22, 62, 86, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "89", "86", "RsTextbox", 0, "MEI_People_Needs_Work_Percent_No_of_Lead_Men", 66, 255, 22, 62, 87, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "90", "86", "RsTextbox", 0, "MEI_People_Needs_Install_No_of_Installers", 87, 119, 22, 62, 88, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "91", "86", "RsTextbox", 0, "MEI_People_Needs_Work_Percent_No_of_Superintendent", 45, 255, 22, 62, 89, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "92", "86", "RsTextbox", 0, "MEI_People_Needs_Comm_No_of_Installers", 87, 187, 22, 62, 90, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "93", "86", "RsLabel", 0, "", 21, 255, 21, 62, 91, "Working %", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "94", "86", "RsTextbox", 0, "MEI_People_Needs_Install_No_of_Lead_Men", 66, 119, 22, 62, 92, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "95", "86", "RsLabel", 0, "", 21, 187, 21, 62, 93, "Comm", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "96", "86", "RsTextbox", 0, "MEI_People_Needs_Install_No_of_Superintendents", 45, 119, 22, 62, 94, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "97", "86", "RsLabel", 0, "", 21, 119, 21, 62, 95, "Install", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "98", "86", "RsLabel", 0, "", 87, 6, 21, 105, 96, "# Installers", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "99", "86", "RsLabel", 0, "", 66, 6, 21, 105, 97, "# Lead Men", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "100", "86", "RsLabel", 0, "", 45, 6, 21, 105, 98, "# Superintendents", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "101", "2", "RsGroupBox", 0, "", 434, 18, 122, 447, 99, "Crew", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "102", "101", "RsTextbox", 0, "MEI_Crew_Avg_Crew_Size_Installers", 90, 352, 22, 62, 100, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "103", "101", "RsLabel", 0, "", 90, 282, 21, 62, 101, "Installers", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "104", "101", "RsTextbox", 0, "MEI_Crew_Peak_Crew_Hrs_per_Wk", 67, 157, 22, 125, 102, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "105", "101", "RsLabel", 0, "", 66, 282, 21, 62, 103, "Hrs/Wk", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "106", "101", "RsTextbox", 0, "MEI_Crew_Comm_Sppt_Hrs_per_Wk", 45, 157, 22, 125, 104, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "107", "101", "RsLabel", 0, "", 46, 282, 21, 62, 105, "Hrs/Wk", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "108", "101", "RsTextbox", 0, "MEI_Crew_Average_Hrs_per_Wk", 25, 157, 22, 125, 106, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "109", "101", "RsLabel", 0, "", 69, 352, 21, 88, 107, "Avg Crew Size", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "110", "101", "RsTextbox", 0, "MEI_Crew_Peak_Crew_Installers", 47, 352, 22, 62, 108, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "111", "101", "RsLabel", 0, "", 26, 352, 21, 88, 109, "Peak Crew", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "112", "101", "RsLabel", 0, "", 26, 282, 21, 62, 110, "Hrs/Wk", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "113", "101", "RsLabel", 0, "", 67, 6, 21, 143, 111, "Peak Crew", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "114", "101", "RsLabel", 0, "", 46, 6, 21, 143, 112, "Comm Sppt", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "115", "101", "RsLabel", 0, "", 25, 6, 21, 143, 113, "Average", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "116", "2", "RsGroupBox", 0, "", 186, 18, 119, 241, 114, "Factors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "117", "116", "RsComboBox", 0, "MEI_Factors_Air_Piping", 54, 87, 22, 125, 115, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "118", "116", "RsComboBox", 0, "MEI_Factors_Risk_Rating", 25, 87, 22, 125, 116, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "119", "116", "RsLabel", 0, "", 25, 6, 21, 75, 117, "Risk Rating", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "120", "116", "RsTextbox", 0, "MEI_Factors_Seismic", 83, 87, 22, 125, 118, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "121", "116", "RsLabel", 0, "", 54, 6, 21, 75, 119, "Air Piping", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "122", "116", "RsLabel", 0, "", 83, 6, 21, 75, 120, "Seismic", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "123", "2", "RsGroupBox", 0, "", 313, 18, 115, 447, 121, "Schedule", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "124", "123", "RsTextbox", 0, "MEI_Schedule_Weeks_Comm", 85, 298, 22, 62, 122, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "125", "123", "RsLabel", 0, "", 86, 376, 21, 39, 123, "Comm", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "126", "123", "RsTextbox", 0, "MEI_Schedule_Weeks_Install", 55, 298, 22, 62, 124, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "127", "123", "RsLabel", 0, "", 56, 376, 21, 39, 125, "Install", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "128", "123", "RsLabel", 0, "", 26, 298, 21, 62, 126, "Weeks", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "129", "123", "RsLabel", 0, "", 84, 6, 21, 143, 127, "End Run-In (Level 5)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "130", "123", "RsLabel", 0, "", 55, 6, 21, 143, 128, "End Mechanical Installation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "131", "123", "RsSingleDatePicker", 0, "MEI_Schedule_End_Run_In_Level_5", 85, 157, 20, 125, 129, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 401, "132", "123", "RsSingleDatePicker", 0, "MEI_Schedule_End_Mechanical_Installation", 55, 157, 20, 125, 130, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 401, "133", "123", "RsLabel", 0, "", 26, 6, 21, 143, 131, "Start Mechanical Installation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "134", "123", "RsSingleDatePicker", 0, "MEI_Schedule_Start_Mechanical_Installation", 26, 157, 20, 125, 132, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 401, "135", "1", "RsTabPage", 0, "", 0, 0, 0, 0, 0, "Inputs2", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 401, "136", "135", "RsGroupBox", 0, "", 14, 12, 349, 663, 133, "Equipment Rentals", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "137", "136", "RsTextbox", 0, "MEI_EquipRent_Quantity_Dumpsters", 300, 130, 22, 116, 134, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "138", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Porta_Johns", 321, 254, 22, 150, 135, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "139", "136", "RsTextbox", 0, "MEI_EquipRent_Quantity_Welders", 258, 130, 22, 116, 136, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "140", "136", "RsTextbox", 0, "MEI_EquipRent_Quantity_Cranes_Large_Outdoors", 237, 130, 22, 116, 137, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "141", "136", "RsTextbox", 0, "MEI_EquipRent_Quantity_Cranes_Small_Indoors", 216, 130, 22, 116, 138, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "142", "136", "RsTextbox", 0, "MEI_EquipRent_Quantity_Fork_Truck", 195, 130, 22, 116, 139, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "143", "136", "RsTextbox", 0, "MEI_EquipRent_Quantity_Large_Telehandler", 174, 130, 22, 116, 140, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "144", "136", "RsTextbox", 0, "MEI_EquipRent_Quantity_Small_Telehandler", 153, 130, 22, 116, 141, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "145", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Large_Boom_Lift", 132, 130, 22, 116, 142, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "146", "136", "RsLabel", 0, "", 69, 6, 21, 116, 143, "Small Scissors Lift:", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "147", "136", "RsTextbox", 0, "MEI_EquipRent_Quantity_Small_Boom_Lift", 111, 130, 22, 116, 144, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "148", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Dumpsters", 300, 532, 22, 116, 145, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "149", "136", "RsTextbox", 0, "MEI_EquipRent_Weekly_Rate_Dumpsters", 300, 410, 22, 116, 146, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "150", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Single_Person_Lift", 48, 532, 22, 116, 147, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "151", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Dumpsters", 300, 254, 22, 150, 148, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "152", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Porta_Johns", 321, 532, 22, 116, 149, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "153", "136", "RsTextbox", 0, "MEI_EquipRent_Weekly_Rate_Single_Person_Lift", 48, 410, 22, 116, 150, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "154", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Site_Trailer", 279, 532, 22, 116, 151, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "155", "136", "RsTextbox", 0, "MEI_EquipRent_Weekly_Rate_Porta_Johns", 321, 410, 22, 116, 152, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "156", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Welders", 258, 532, 22, 116, 153, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "157", "136", "RsTextbox", 0, "MEI_EquipRent_Weekly_Rate_Site_Trailer", 279, 410, 22, 116, 154, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "158", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Site_Trailer", 279, 254, 22, 150, 155, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "159", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Cranes_Large_Outdoors", 237, 532, 22, 116, 156, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "160", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Single_Person_Lift", 48, 254, 22, 150, 157, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "161", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Cranes_Small_Indoors", 216, 532, 22, 116, 158, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "162", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Welders", 258, 410, 22, 116, 159, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "163", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Fork_Truck", 195, 532, 22, 116, 160, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "164", "136", "RsTextbox", 0, "MEI_EquipRent_Weekly_Rate_Cranes_Large_Outdoors", 237, 410, 22, 116, 161, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "165", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Large_Telehandler", 174, 532, 22, 116, 162, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "166", "136", "RsTextbox", 0, "MEI_EquipRent_Quantity_Single_Person_Lift", 48, 130, 22, 116, 163, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "167", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Small_Telehandler", 153, 532, 22, 116, 164, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "168", "136", "RsTextbox", 0, "MEI_EquipRent_Weekly_Rate_Cranes_Small_Indoors", 216, 410, 22, 116, 165, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "169", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Large_Boom_Lift", 132, 532, 22, 116, 166, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "170", "136", "RsTextbox", 0, "MEI_EquipRent_Weekly_Rate_Fork_Truck", 195, 410, 22, 116, 167, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "171", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Small_Boom_Lift", 111, 532, 22, 116, 168, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "172", "136", "RsTextbox", 0, "MEI_EquipRent_Quantity_Porta_Johns", 321, 130, 22, 116, 169, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "173", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Large_Scissors_Lift", 90, 532, 22, 116, 170, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "174", "136", "RsTextbox", 0, "MEI_EquipRent_Weekly_Rate_Large_Telehandler", 174, 410, 22, 116, 171, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "175", "136", "RsTextbox", 0, "MEI_EquipRent_Quantity_Site_Trailer", 279, 130, 22, 116, 172, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "176", "136", "RsTextbox", 0, "MEI_EquipRent_Total_Cost_Small_Scissors_Lift", 69, 532, 22, 116, 173, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "177", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Welders", 258, 254, 22, 150, 174, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "178", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Cranes_LargeOutdoor", 237, 254, 22, 150, 175, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "179", "136", "RsTextbox", 0, "MEI_EquipRent_Weekly_Rate_Small_Telehandler", 153, 410, 22, 116, 176, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "180", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Cranes_SmallIndoor", 216, 254, 22, 150, 177, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "181", "136", "RsTextbox", 0, "MEI_EquipRent_Weekly_Rate_Large_Boom_Lift", 132, 410, 22, 116, 178, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "182", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Fork_Truck", 195, 254, 22, 150, 179, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "183", "136", "RsTextbox", 0, "MEI_EquipRent_Weekly_Rate_Small_Boom_Lift", 111, 410, 22, 116, 180, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "184", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Large_Telehandler", 174, 254, 22, 150, 181, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "185", "136", "RsTextbox", 0, "MEI_EquipRent_Weekly_Rate_Large_Scissors_Lift", 90, 410, 22, 116, 182, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "186", "136", "RsTextbox", 0, "MEI_EquipRent_Weekly_Rate_Small_Scissors_Lift", 69, 410, 22, 116, 183, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "187", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Small_Telehandler", 153, 254, 22, 150, 184, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "188", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Large_Boom_Lift", 132, 254, 22, 150, 185, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "189", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Small_Boom_Lift", 111, 254, 22, 150, 186, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "190", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Large_Scissors_Lift", 90, 254, 22, 150, 187, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "191", "136", "RsTextbox", 0, "MEI_EquipRent_Install_Duration_Small_Scissors_Lift", 69, 254, 22, 150, 188, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "192", "136", "RsTextbox", 0, "MEI_EquipRent_Quantity_Large_Scissors_Lift", 90, 130, 22, 116, 189, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "193", "136", "RsTextbox", 0, "MEI_EquipRent_Quantity_Small_Scissors_Lift", 69, 130, 22, 116, 190, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "194", "136", "RsLabel", 0, "", 321, 6, 21, 116, 191, "Porta Johns:", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "195", "136", "RsLabel", 0, "", 300, 6, 21, 116, 192, "Dumpsters:", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "196", "136", "RsLabel", 0, "", 279, 6, 21, 116, 193, "Site Trailer:", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "197", "136", "RsLabel", 0, "", 111, 6, 21, 116, 194, "Small Boom Lift:", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "198", "136", "RsLabel", 0, "", 258, 6, 21, 116, 195, "Welders:", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "199", "136", "RsLabel", 0, "", 237, 6, 21, 116, 196, "Crane (Large Outdoor)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "200", "136", "RsLabel", 0, "", 216, 6, 21, 116, 197, "Cranes (Small indoors)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "201", "136", "RsLabel", 0, "", 195, 6, 21, 116, 198, "Fork Truck", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "202", "136", "RsLabel", 0, "", 174, 6, 21, 116, 199, "Large Telehandler", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "203", "136", "RsLabel", 0, "", 153, 6, 21, 116, 200, "Small Telehandler", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "204", "136", "RsLabel", 0, "", 132, 6, 21, 116, 201, "Large Boom Lift:", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "205", "136", "RsLabel", 0, "", 90, 6, 21, 116, 202, "Large Scissor Lift", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "206", "136", "RsLabel", 0, "", 48, 6, 21, 116, 203, "Single Person Lift:", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "207", "136", "RsLabel", 0, "", 27, 532, 21, 116, 204, "Total Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "208", "136", "RsLabel", 0, "", 27, 410, 21, 116, 205, "Weekly Rate", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "209", "136", "RsLabel", 0, "", 27, 254, 21, 150, 206, "Install Duration (Weeks)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "210", "136", "RsLabel", 0, "", 27, 130, 21, 116, 207, "Quantity", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "211", "136", "RsLabel", 0, "", 27, 6, 21, 116, 208, "Items", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "212", "135", "RsGroupBox", 0, "", 395, 12, 175, 298, 209, "Other Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "213", "212", "RsTextbox", 0, "MEI_Other_Cost_Qty_Gang_Boxes", 48, 150, 22, 125, 210, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "214", "212", "RsLabel", 0, "", 27, 15, 21, 116, 211, "Qty Trucks", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "215", "212", "RsTextbox", 0, "MEI_Other_Cost_Permit_Hours", 70, 150, 22, 125, 212, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "216", "212", "RsTextbox", 0, "MEI_Other_Cost_Qty_Trucks", 27, 150, 22, 125, 213, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "217", "212", "RsTextbox", 0, "MEI_Other_Cost_Onsite_Admin_Duration_Wks", 111, 150, 22, 125, 214, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "218", "212", "RsTextbox", 0, "MEI_Other_Cost_Onsite_Admin_Hrs_Per_Week", 132, 150, 22, 125, 215, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "219", "212", "RsLabel", 0, "", 132, 49, 21, 95, 216, "Hrs Per Week", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "220", "212", "RsLabel", 0, "", 111, 49, 21, 95, 217, "Duration (Wks)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "221", "212", "RsLabel", 0, "", 91, 15, 21, 116, 218, "Onsite Admin", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "222", "212", "RsLabel", 0, "", 70, 15, 21, 116, 219, "Permit Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "223", "212", "RsLabel", 0, "", 48, 15, 21, 116, 220, "Qty Gang Boxes", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "224", "135", "RsGroupBox", 0, "", 14, 696, 349, 287, 221, "Air Piping", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "225", "224", "RsTextbox", 0, "MEI_Air_Pipe_Mat_Cost_Cost", 280, 146, 22, 116, 222, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "226", "224", "RsTextbox", 0, "MEI_Air_Pipe_Dryer_Cost", 237, 146, 22, 116, 223, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "227", "224", "RsTextbox", 0, "MEI_Air_Pipe_Red_A_C_Cost", 216, 146, 22, 116, 224, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "228", "224", "RsTextbox", 0, "MEI_Air_Pipe_A_C_Cost", 195, 146, 22, 116, 225, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "229", "224", "RsTextbox", 0, "MEI_Air_Pipe_FILTER_REG_Cost", 174, 146, 22, 116, 226, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "230", "224", "RsTextbox", 0, "MEI_Air_Pipe_Tubing_Cost", 153, 146, 22, 116, 227, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "231", "224", "RsTextbox", 0, "MEI_Air_Pipe_1_2_Inch_pipeCost", 132, 146, 22, 116, 228, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "232", "224", "RsLabel", 0, "", 69, 22, 21, 116, 229, "2 1/2&amp;quot; pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "233", "224", "RsTextbox", 0, "MEI_Air_Pipe_7_8_Inch_pipe_Cost", 111, 146, 22, 116, 230, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "234", "224", "RsTextbox", 0, "MEI_Air_Pipe_3_Inch_pipe_Cost", 48, 146, 22, 116, 231, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "235", "224", "RsTextbox", 0, "MEI_Air_Pipe_Hours_Cost", 301, 146, 22, 116, 232, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "236", "224", "RsTextbox", 0, "MEI_Air_Pipe_1_And_1_2_Inch_pipe_Cost", 90, 146, 22, 116, 233, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "237", "224", "RsTextbox", 0, "MEI_Air_Pipe_2_and_1_2_Inch_pipe_Cost", 69, 146, 22, 116, 234, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "238", "224", "RsLabel", 0, "", 301, 22, 21, 116, 235, "Air Pipe Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "239", "224", "RsLabel", 0, "", 111, 22, 21, 116, 236, "7/8&amp;quot; pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "240", "224", "RsLabel", 0, "", 280, 22, 21, 116, 237, "Air Pipe Mat Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "241", "224", "RsLabel", 0, "", 237, 22, 21, 116, 238, "Dryer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "242", "224", "RsLabel", 0, "", 216, 22, 21, 116, 239, "Red A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "243", "224", "RsLabel", 0, "", 195, 22, 21, 116, 240, "A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "244", "224", "RsLabel", 0, "", 174, 22, 21, 116, 241, "FILTER/REG", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "245", "224", "RsLabel", 0, "", 153, 22, 21, 116, 242, "Tubing", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "246", "224", "RsLabel", 0, "", 132, 22, 21, 116, 243, "1/2&amp;quot; pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "247", "224", "RsLabel", 0, "", 90, 22, 21, 116, 244, "1 1/2&amp;quot; pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "248", "224", "RsLabel", 0, "", 48, 22, 21, 116, 245, "3&amp;quot; pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "249", "224", "RsLabel", 0, "", 27, 146, 21, 116, 246, "Total Order", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "250", "224", "RsLabel", 0, "", 27, 22, 21, 116, 247, "Items", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "251", "1", "RsTabPage", 0, "", 0, 0, 0, 0, 0, "Inputs3", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 401, "252", "251", "RsGroupBox", 0, "", 17, 19, 204, 955, 248, "Travel Costs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "253", "252", "RsTextbox", 0, "MEI_Travel_Cost_Crew_Total_Mobilization_Cost", 164, 482, 22, 139, 249, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "254", "252", "RsLabel", 0, "", 165, 380, 21, 96, 250, "Total :", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ButtonShadow;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "255", "252", "RsLabel", 0, "", 117, 6, 21, 116, 251, "Lead Men", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "256", "252", "RsTextbox", 0, "MEI_Travel_Cost_Crew_Total_Travel_Cost", 164, 637, 22, 116, 252, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "257", "252", "RsLabel", 0, "", 27, 6, 21, 96, 253, "Per Diem Range:", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "258", "252", "RsTextbox", 0, "MEI_Travel_Cost_Crew_Tot_Travel_Cost_SI", 95, 637, 22, 116, 254, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "259", "252", "RsTextbox", 0, "MEI_Travel_Cost_Crew_Tot_Mobile_Cost_SI", 95, 482, 22, 139, 255, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "260", "252", "RsTextbox", 0, "MEI_Travel_Cost_Crew_Tot_Proj_Diem_Superintendent", 95, 316, 22, 150, 256, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "261", "252", "RsTextbox", 0, "MEI_Travel_Cost_Crew_Per_Diem_Rates_Superintendent", 95, 138, 22, 162, 257, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "262", "252", "RsTextbox", 0, "MEI_Travel_Cost_Crew_Tot_Travel_Cost_Installer", 137, 637, 22, 116, 258, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "263", "252", "RsTextbox", 0, "MEI_Travel_Cost_Crew_Tot_Travel_Cost_Lead_Men", 116, 637, 22, 116, 259, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "264", "252", "RsTextbox", 0, "MEI_Travel_Cost_Crew_Tot_Mobile_Cost_Installer", 137, 482, 22, 139, 260, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "265", "252", "RsTextbox", 0, "MEI_Travel_Cost_Crew_Tot_Mobile_Cost_Lead_Men", 116, 482, 22, 139, 261, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "266", "252", "RsTextbox", 0, "MEI_Travel_Cost_Crew_Tot_Proj_Diem_Installer", 137, 316, 22, 150, 262, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "267", "252", "RsTextbox", 0, "MEI_Travel_Cost_Crew_Tot_Proj_Diem_Lead_Men", 116, 316, 22, 150, 263, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "268", "252", "RsTextbox", 0, "MEI_Travel_Cost_Crew_Per_Diem_Rates_Installer", 137, 138, 22, 162, 264, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "269", "252", "RsTextbox", 0, "MEI_Travel_Cost_Crew_Per_Diem_Rates_Lead_Men", 116, 138, 22, 162, 265, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "270", "252", "RsLabel", 0, "", 138, 6, 21, 116, 266, "Installer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "271", "252", "RsLabel", 0, "", 96, 6, 21, 116, 267, "Superintendent", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "272", "252", "RsLabel", 0, "", 67, 637, 21, 116, 268, "Total Travel Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "273", "252", "RsLabel", 0, "", 67, 482, 21, 139, 269, "Total Mobilization Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "274", "252", "RsLabel", 0, "", 67, 316, 21, 150, 270, "Total Project Per Diem", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "275", "252", "RsLabel", 0, "", 67, 138, 21, 162, 271, "Per Diem Rates (Weekly)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "276", "252", "RsLabel", 0, "", 67, 6, 21, 116, 272, "Crew", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "277", "252", "RsComboBox", 0, "MEI_Travel_Cost_Per_Diem_Range", 27, 110, 22, 125, 273, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "278", "252", "RsLabel", 0, "", 27, 254, 21, 150, 274, "Per Diem Rates Look-Up", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:https%3a%2f%2fwww.gsa.gov%2ftravel%2fplan-book%2fper-diem-rates;")
        oProcessStep.AddCustomLayout(1, 401, "279", "251", "RsGroupBox", 0, "", 394, 19, 230, 955, 275, "Structures Platforms", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "280", "279", "RsLabel", 0, "", 78, 18, 21, 116, 276, "GRID - Structure", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "281", "279", "RsLabel", 0, "", 141, 18, 21, 116, 277, "CATWALK", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "282", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Per_Ft_Demo", 56, 504, 22, 139, 278, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "283", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Hour_Demo", 56, 338, 22, 150, 279, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "284", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Hour_Platform_Resin_Deck", 119, 338, 22, 150, 280, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "285", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Feet_Demo", 56, 160, 22, 162, 281, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "286", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Feet_Platform_Resin_Deck", 119, 160, 22, 162, 282, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "287", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Per_Ft_Total", 161, 504, 22, 139, 283, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "288", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Per_Ft_Catwalk", 140, 504, 22, 139, 284, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "289", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Hour_Platform_Bar_Grating", 98, 338, 22, 150, 285, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "290", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Hour_Total", 161, 338, 22, 150, 286, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "291", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Hour_GRID_Structure", 77, 338, 22, 150, 287, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "292", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Hour_Catwalk", 140, 338, 22, 150, 288, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "293", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Feet_Platform_Bar_Grating", 98, 160, 22, 162, 289, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "294", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Feet_Total", 161, 160, 22, 162, 290, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "295", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Feet_GRID_Structure", 77, 160, 22, 162, 291, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "296", "279", "RsTextbox", 0, "MEI_Structures_Platforms_Feet_Catwalk", 140, 160, 22, 162, 292, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "297", "279", "RsLabel", 0, "", 99, 18, 21, 137, 293, "PLATFORM - Bar Grating", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "298", "279", "RsLabel", 0, "", 162, 18, 21, 116, 294, "Total", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ButtonShadow;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "299", "279", "RsLabel", 0, "", 57, 18, 21, 116, 295, "DEMO", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "300", "279", "RsLabel", 0, "", 120, 18, 21, 116, 296, "PLATFORM - Resin Deck", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "301", "279", "RsLabel", 0, "", 28, 504, 21, 139, 297, "Per/Ft", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "302", "279", "RsLabel", 0, "", 28, 338, 21, 150, 298, "Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "303", "279", "RsLabel", 0, "", 28, 160, 21, 162, 299, "Feet", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "304", "279", "RsLabel", 0, "", 28, 18, 21, 116, 300, "Platforms", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "305", "251", "RsGroupBox", 0, "", 229, 19, 157, 955, 301, "Labor Rate Adjustments", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "306", "305", "RsTextbox", 0, "MEI_Labor_Rate_Percent_Adjustment", 40, 38, 22, 96, 302, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "307", "305", "RsLabel", 0, "", 113, 713, 21, 96, 303, "Total :", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ButtonShadow;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "308", "305", "RsLabel", 0, "", 66, 184, 21, 116, 304, "Lead Men", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "309", "305", "RsTextbox", 0, "MEI_Labor_Rate_Total_Cost_Adjustment", 113, 815, 22, 116, 305, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "310", "305", "RsLabel", 0, "", 16, 38, 21, 96, 306, "Percent Adjustment", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "311", "305", "RsTextbox", 0, "MEI_Labor_Rate_Tot_Cost_Adj_Superintendent", 44, 815, 22, 116, 307, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "312", "305", "RsTextbox", 0, "MEI_Labor_Rate_New_Rate_Superintendent", 44, 660, 22, 139, 308, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "313", "305", "RsTextbox", 0, "MEI_Labor_Rate_Current_Rate_Superintendent", 44, 494, 22, 150, 309, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "314", "305", "RsTextbox", 0, "MEI_Labor_Rate_Percent_Adjustment_Superintendent", 44, 316, 22, 162, 310, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "315", "305", "RsTextbox", 0, "MEI_Labor_Rate_Tot_Cost_Adj_Installer", 86, 815, 22, 116, 311, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "316", "305", "RsTextbox", 0, "MEI_Labor_Rate_Tot_Cost_Adj_Lead_Person", 65, 815, 22, 116, 312, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "317", "305", "RsTextbox", 0, "MEI_Labor_Rate_New_Rate_IG_Installer", 86, 660, 22, 139, 313, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "318", "305", "RsTextbox", 0, "MEI_Labor_Rate_New_Rate_Lead_Person", 65, 660, 22, 139, 314, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "319", "305", "RsTextbox", 0, "MEI_Labor_Rate_Current_Rate_IG_Installer", 86, 494, 22, 150, 315, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "320", "305", "RsTextbox", 0, "MEI_Labor_Rate_Current_Rate_Lead_Person", 65, 494, 22, 150, 316, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "321", "305", "RsTextbox", 0, "MEI_Labor_Rate_Percent_Adjustment_IG_Installer", 86, 316, 22, 162, 317, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "322", "305", "RsTextbox", 0, "MEI_Labor_Rate_Percent_Adjustment_Lead_Person", 65, 316, 22, 162, 318, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "323", "305", "RsLabel", 0, "", 87, 184, 21, 116, 319, "Intelligrated Installer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "324", "305", "RsLabel", 0, "", 45, 184, 21, 116, 320, "Superintendent", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "325", "305", "RsLabel", 0, "", 16, 815, 21, 116, 321, "Tot Cost Adj", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "326", "305", "RsLabel", 0, "", 16, 660, 21, 139, 322, "New Rate", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "327", "305", "RsLabel", 0, "", 16, 494, 21, 150, 323, "Current Rate", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "328", "305", "RsLabel", 0, "", 16, 316, 21, 162, 324, "Percentage Adjusted", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "329", "305", "RsLabel", 0, "", 16, 184, 21, 116, 325, "Crew", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "330", "1", "RsTabPage", 0, "", 0, 0, 0, 0, 0, "Total Cost", 0, 0, 0, 5, 0, "", "", "")
        oProcessStep.AddCustomLayout(1, 401, "331", "330", "RsGroupBox", 0, "", 13, 513, 480, 466, 326, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "332", "331", "RsLabel", 0, "", 365, 16, 19, 69, 327, "16.01.99", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "333", "331", "RsLabel", 0, "", 393, 91, 21, 158, 328, "Administrative", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "334", "331", "RsLabel", 0, "", 365, 91, 19, 158, 329, "Miscellaneous", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "335", "331", "RsTextbox", 0, "MEI_Miscellaneous_Administrative_Cost", 392, 333, 22, 53, 330, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "336", "331", "RsLabel", 0, "", 337, 16, 19, 69, 331, "16.01.08", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "337", "331", "RsTextbox", 0, "MEI_Miscellaneous_Cost", 362, 333, 22, 53, 332, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "338", "331", "RsLabel", 0, "", 337, 91, 19, 158, 333, "Permits", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "339", "331", "RsLabel", 0, "", 309, 16, 19, 69, 334, "16.01.07", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "340", "331", "RsTextbox", 0, "MEI_Permits_Cost", 334, 333, 22, 53, 335, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "341", "331", "RsLabel", 0, "", 309, 91, 19, 158, 336, "Travel Expense", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "342", "331", "RsLabel", 0, "", 110, 91, 21, 158, 337, "Dumpsters", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "343", "331", "RsTextbox", 0, "MEI_Travel_Expense_Cost", 306, 333, 22, 53, 338, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "344", "331", "RsLabel", 0, "", 131, 91, 21, 158, 339, "Porta Johns", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "345", "331", "RsLabel", 0, "", 250, 91, 21, 158, 340, "All Other", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "346", "331", "RsTextbox", 0, "MEI_Equipment_Rental_Porta_Johns_Cost", 130, 333, 22, 53, 341, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "347", "331", "RsTextbox", 0, "MEI_Equipment_Rental_Dumpsters_Cost", 109, 333, 22, 53, 342, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "348", "331", "RsLabel", 0, "", 229, 91, 21, 158, 343, "Hardware/Air Piping", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "349", "331", "RsLabel", 0, "", 15, 266, 19, 39, 344, "Rate", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "350", "331", "RsLabel", 0, "", 15, 400, 19, 39, 345, "Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "351", "331", "RsTextbox", 0, "MEI_Supplies_Consumables_All_Other_Cost", 249, 333, 22, 53, 346, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "352", "331", "RsTextbox", 0, "MEI_Supplies_Consumables_HW_Air_Piping_Cost", 228, 333, 22, 53, 347, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "353", "331", "RsLabel", 0, "", 15, 333, 19, 37, 348, "Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "354", "331", "RsTextbox", 0, "MEI_Supplies_Consumables_Cost", 191, 333, 22, 53, 349, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "355", "331", "RsLabel", 0, "", 194, 91, 19, 158, 350, "Supplies/Consumables", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "356", "331", "RsTextbox", 0, "MEI_Equipment_Rental_Cost", 72, 333, 22, 53, 351, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "357", "331", "RsLabel", 0, "", 194, 16, 19, 69, 352, "16.01.05", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "358", "331", "RsLabel", 0, "", 75, 91, 19, 158, 353, "Equipment Rental", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "359", "331", "RsLabel", 0, "", 75, 16, 19, 69, 354, "16.01.04", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "360", "330", "RsGroupBox", 0, "", 13, 13, 500, 466, 355, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "361", "360", "RsLabel", 0, "", 406, 91, 21, 158, 356, "Miscellaneous", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "362", "360", "RsLabel", 0, "", 427, 91, 21, 158, 357, "Stagnant Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "363", "360", "RsTextbox", 0, "MEI_Supplies_Consumables_Cost", -181, 22, 22, 53, 358, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "364", "360", "RsLabel", 0, "", -178, -220, 19, 158, 359, "Supplies/Consumables", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "365", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Stagnant_Hours_Hours", 426, 400, 22, 53, 360, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "366", "360", "RsLabel", 0, "", -178, -295, 19, 69, 361, "16.01.05", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "367", "360", "RsLabel", 0, "", 47, 91, 19, 169, 362, "Mechanical Conveyor Installation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.6.5;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "368", "360", "RsLabel", 0, "", 469, 91, 21, 158, 363, "Working Super/Lead Deduct", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "369", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Demo_Cost", 384, 333, 22, 53, 364, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "370", "360", "RsLabel", 0, "", 448, 91, 21, 158, 365, "Commissioning", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "371", "360", "RsTextbox", 0, "MEI_Superintendent_Commissioning_Cost", 151, 333, 22, 53, 366, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "372", "360", "RsTextbox", 0, "MEI_TTCB_Installer_WorkingSuper_LeadDeduct_Hours", 468, 400, 22, 53, 367, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "373", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Install_Cost", 342, 333, 22, 53, 368, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "374", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Commissioning_Hours", 447, 400, 22, 53, 369, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "375", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Miscellaneous_Hours", 405, 400, 22, 53, 370, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "376", "360", "RsLabel", 0, "", 110, 91, 21, 158, 371, "Install", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "377", "360", "RsLabel", 0, "", 343, 91, 21, 158, 372, "Install", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "378", "360", "RsTextbox", 0, "MEI_TTCB_Installer_WorkingSuper_LeadDeduct_Cost", 468, 333, 22, 53, 373, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "379", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Stagnant_Hours_Cost", 426, 333, 22, 53, 374, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "380", "360", "RsLabel", 0, "", 152, 91, 21, 158, 375, "Commissioning", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "381", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Commissioning_Cost", 447, 333, 22, 53, 376, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "382", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Miscellaneous_Cost", 405, 333, 22, 53, 377, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "383", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Install_Hours", 342, 400, 22, 53, 378, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "384", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Platforms_Grid_Catwalk_Hours", 363, 400, 22, 53, 379, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "385", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Demo_Hours", 384, 400, 22, 53, 380, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "386", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Platforms_Grid_Catwalk_Cost", 363, 333, 22, 53, 381, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "387", "360", "RsLabel", 0, "", 385, 91, 21, 158, 382, "Demo", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "388", "360", "RsLabel", 0, "", 364, 91, 21, 158, 383, "Platforms, Grid, &amp;amp; Catwalk", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "389", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Hours", 309, 400, 22, 53, 384, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "390", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Cost", 309, 333, 22, 53, 385, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "391", "360", "RsTextbox", 0, "MEI_Superintendent_Install_Hours", 109, 400, 22, 53, 386, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "392", "360", "RsLabel", 0, "", 309, 91, 19, 158, 387, "TTCB Installer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "393", "360", "RsLabel", 0, "", 131, 91, 21, 158, 388, "Stagnant Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "394", "360", "RsTextbox", 0, "MEI_Superintendent_Stagnant_Hours_Hours", 130, 400, 22, 53, 389, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "395", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Install_Hours", 228, 400, 22, 53, 390, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "396", "360", "RsTextbox", 0, "MEI_TTCB_Installer_Rate", 309, 266, 22, 53, 391, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "397", "360", "RsLabel", 0, "", 271, 91, 21, 158, 392, "Commissioning", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "398", "360", "RsTextbox", 0, "MEI_Superintendent_Commissioning_Hours", 151, 400, 22, 53, 393, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "399", "360", "RsLabel", 0, "", 309, 16, 19, 69, 394, "16.01.02.04", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "400", "360", "RsTextbox", 0, "MEI_TTCB_Lead_Person_Stagnant_Hours_Hours", 249, 400, 22, 53, 395, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "401", "360", "RsTextbox", 0, "MEI_Superintendent_Install_Cost", 109, 333, 22, 53, 396, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "402", "360", "RsLabel", 0, "", 15, 400, 19, 39, 397, "Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "403", "360", "RsLabel", 0, "", 229, 91, 21, 158, 398, "Install", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "404", "360", "RsTextbox", 0, "MEI_Superintendent_Stagnant_Hours_Cost", 130, 333, 22, 53, 399, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "405", "360", "RsTextbox", 0, "MEI_TTCB_Lead_Person_Commissioning_Cost", 270, 333, 22, 53, 400, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "406", "360", "RsTextbox", 0, "MEI_Mech_Conveyor_Installation_Hours", 47, 400, 22, 53, 401, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "407", "360", "RsLabel", 0, "", 250, 91, 21, 158, 402, "Stagnant Hours", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "408", "360", "RsTextbox", 0, "MEI_TTCB_Lead_Person_Stagnant_Hours_Cost", 249, 333, 22, 53, 403, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "409", "360", "RsLabel", 0, "", 15, 266, 19, 39, 404, "Rate", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "410", "360", "RsTextbox", 0, "MEI_TTCB_Lead_Person_Commissioning_Hours", 270, 400, 22, 53, 405, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "411", "360", "RsTextbox", 0, "MEI_Mech_Conveyor_Installation_Cost", 47, 333, 22, 53, 406, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "412", "360", "RsTextbox", 0, "MEI_TTCB_Lead_Person_Install_Cost", 228, 333, 22, 53, 407, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "413", "360", "RsTextbox", 0, "MEI_Superintendent__Hours", 75, 400, 22, 53, 408, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "414", "360", "RsTextbox", 0, "MEI_TTCB_Lead_Person_Hours", 194, 400, 22, 53, 409, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "415", "360", "RsLabel", 0, "", 15, 333, 19, 37, 410, "Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "416", "360", "RsLabel", 0, "", 47, 16, 19, 69, 411, "16.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "417", "360", "RsLabel", 0, "", 194, 91, 19, 158, 412, "TTCB Lead Person", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "418", "360", "RsTextbox", 0, "MEI_Superintendent_Cost", 75, 333, 22, 53, 413, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "419", "360", "RsTextbox", 0, "MEI_TTCB_Lead_Person_Cost", 194, 333, 22, 53, 414, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "420", "360", "RsLabel", 0, "", 194, 16, 19, 69, 415, "16.01.02.03", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "421", "360", "RsLabel", 0, "", 75, 91, 19, 158, 416, "Superintendent", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "422", "360", "RsTextbox", 0, "MEI_TTCB_Lead_Person_Rate", 194, 266, 22, 53, 417, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "423", "360", "RsLabel", 0, "", 75, 16, 19, 69, 418, "16.01.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:ActiveBorder;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "424", "360", "RsTextbox", 0, "MEI_Superintendent_Rate", 75, 266, 22, 53, 419, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_System_Mech_Delta()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(83, "System Mech Delta", "", 101, 51, 1, 33, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsSubForm", 0, "", 38, 12, 291, 385, 0, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,119,My_Base_Options_Alternates")
        oProcessStep.AddCustomLayout(1, 360, "2", "1", "RsGroupBox", 0, "", 4, 3, 281, 376, 1, "System 1", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "3", "2", "RsLabel", 0, "", 123, 96, 21, 94, 2, "Total VBelt Units", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "4", "2", "RsLabel", 0, "", 96, 96, 21, 94, 3, "System 1 Name", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "5", "2", "RsLabel", 0, "", 177, 147, 21, 150, 4, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "6", "2", "RsTextbox", 0, "DisplayName", 95, 196, 22, 125, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "7", "2", "RsTextbox", 0, "HCAD_VBelt_Total_Units", 123, 196, 22, 125, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "8", "0", "RsActionButton", 0, "", 104, 1287, 60, 114, 7, "Reset Delta", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:MechResetDelta;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 360, "9", "0", "RsSubForm", 0, "", 38, 849, 291, 385, 8, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,120,My_Base_Options_Alternates_Delta")
        oProcessStep.AddCustomLayout(1, 360, "10", "9", "RsGroupBox", 0, "", 4, 3, 281, 376, 9, "Delta", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "11", "10", "RsLabel", 0, "", 177, 147, 21, 150, 10, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "12", "10", "RsLabel", 0, "", 95, 96, 21, 94, 11, "Delta Name", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "13", "10", "RsLabel", 0, "", 123, 96, 21, 94, 12, "Total VBelt Units", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "14", "10", "RsTextbox", 0, "DisplayName", 95, 196, 22, 125, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "15", "10", "RsTextbox", 0, "HCAD_VBelt_Total_Units", 123, 196, 22, 125, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "16", "0", "RsSubForm", 0, "", 38, 431, 291, 385, 15, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,121,My_Base_Options_Alternates_2")
        oProcessStep.AddCustomLayout(1, 360, "17", "16", "RsGroupBox", 0, "", 4, 3, 281, 376, 16, "System 2", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "18", "17", "RsLabel", 0, "", 177, 147, 21, 150, 17, "To be populated", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "19", "17", "RsLabel", 0, "", 95, 96, 21, 94, 18, "System 2 Name", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "20", "17", "RsLabel", 0, "", 123, 96, 21, 94, 19, "Total VBelt Units", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "21", "17", "RsTextbox", 0, "DisplayName", 95, 196, 22, 125, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "22", "17", "RsTextbox", 0, "HCAD_VBelt_Total_Units", 123, 196, 22, 125, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "23", "0", "RsLabel", 0, "", 15, 490, 21, 124, 22, "System 2 Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "24", "0", "RsComboBox", 0, "Selection_System_Delta", 14, 620, 22, 125, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "25", "0", "RsLabel", 0, "", 14, 83, 21, 122, 24, "System 1 Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "26", "0", "RsComboBox", 0, "Selection_System", 14, 211, 22, 125, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "27", "0", "RsActionButton", 0, "", 38, 1287, 60, 114, 26, "Compare Delta", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:MechCompareDelta;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Output_Mech()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(84, "Output Mech", "", 101, 51, 1, 34, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsGroupBox", 0, "", 12, 12, 109, 265, 0, "Customer Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "2", "1", "RsTextbox", 0, "CAE_Quote_Date", 78, 119, 22, 125, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "3", "1", "RsTextbox", 0, "CAE_Customer", 36, 119, 22, 125, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "4", "1", "RsTextbox", 0, "CAE_Customer_Location", 58, 119, 22, 125, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "5", "1", "RsTextbox", 0, "CAE_Customer_Project_Number", 15, 119, 22, 125, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "6", "1", "RsLabel", 0, "", 58, 6, 21, 107, 5, "Location", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "7", "1", "RsLabel", 0, "", 16, 6, 21, 107, 6, "Project Number", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "8", "1", "RsLabel", 0, "", 79, 6, 21, 107, 7, "Quote Date", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "9", "1", "RsLabel", 0, "", 37, 6, 21, 107, 8, "Customer", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "10", "0", "RsLabel", 0, "", 100, 339, 21, 57, 9, "System", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "11", "0", "RsComboBox", 0, "Selection_System", 99, 402, 22, 125, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "12", "0", "RsSubForm", 0, "", 127, 12, 732, 1395, 11, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,119,My_Base_Options_Alternates")
        oProcessStep.AddCustomLayout(1, 360, "13", "12", "RsGroupBox", 0, "", 3, 704, 515, 684, 12, "PRD", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "14", "13", "RsGroupBox", 0, "", 19, 6, 236, 668, 13, "Base", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "15", "14", "RsLabel", 0, "", 154, 6, 21, 72, 14, "16.01.07", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "16", "14", "RsLabel", 0, "", 15, 547, 21, 72, 15, "Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "17", "14", "RsLabel", 0, "", 70, 84, 21, 160, 16, "Conv - Lead Men", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "18", "14", "RsTextbox", 0, "PRD_Base_Sbcntrct_Svcs_HRS", 181, 250, 22, 125, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "19", "14", "RsTextbox", 0, "PRD_Base_Travel_Expenses_HRS", 153, 250, 22, 125, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "20", "14", "RsTextbox", 0, "PRD_Base_Project_Support_RATE", 97, 381, 22, 125, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "21", "14", "RsTextbox", 0, "PRD_Base_Sbcntrct_Svcs_HSE_COST", 209, 512, 22, 125, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "22", "14", "RsTextbox", 0, "PRD_Base_Sbcntrct_Svcs_COST", 181, 512, 22, 125, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "23", "14", "RsTextbox", 0, "PRD_Base_Sbcntrct_Svcs_HSE_HRS", 209, 250, 22, 125, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "24", "14", "RsTextbox", 0, "PRD_Base_Travel_Expenses_COST", 153, 512, 22, 125, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "25", "14", "RsLabel", 0, "", 210, 84, 21, 160, 24, "Sbcntrct Svcs - HSE", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "26", "14", "RsLabel", 0, "", 182, 84, 21, 160, 25, "Sbcntrct Svcs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "27", "14", "RsLabel", 0, "", 210, 6, 21, 72, 26, "16.01.98.02", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "28", "14", "RsLabel", 0, "", 182, 6, 21, 72, 27, "16.01.98.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "29", "14", "RsLabel", 0, "", 154, 84, 21, 160, 28, "Travel Expenses", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "30", "14", "RsLabel", 0, "", 98, 84, 21, 160, 29, "Project Support", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "31", "14", "RsTextbox", 0, "PRD_Base_Superintendent_RATE", 41, 381, 22, 125, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "32", "14", "RsTextbox", 0, "PRD_Base_Superintendent_COST", 41, 512, 22, 125, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "33", "14", "RsTextbox", 0, "PRD_Base_Project_Support_HRS", 97, 250, 22, 125, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "34", "14", "RsTextbox", 0, "PRD_Base_Superintendent_HRS", 41, 250, 22, 125, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "35", "14", "RsTextbox", 0, "PRD_Base_Project_Support_COST", 97, 512, 22, 125, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "36", "14", "RsLabel", 0, "", 15, 423, 21, 72, 35, "$/UOM", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "37", "14", "RsLabel", 0, "", 15, 292, 21, 72, 36, "Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "38", "14", "RsTextbox", 0, "PRD_Base_Equipment_Rental_COST", 125, 512, 22, 125, 37, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "39", "14", "RsLabel", 0, "", 42, 84, 21, 160, 38, "Superintendent", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "40", "14", "RsLabel", 0, "", 98, 6, 21, 72, 39, "16.01.03.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "41", "14", "RsTextbox", 0, "PRD_Base_Conv_Lead_Men_RATE", 69, 381, 22, 125, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "42", "14", "RsLabel", 0, "", 42, 6, 21, 72, 41, "16.01.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "43", "14", "RsTextbox", 0, "PRD_Base_Conv_Lead_Men_COST", 69, 512, 22, 125, 42, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "44", "14", "RsLabel", 0, "", 126, 84, 21, 160, 43, "Equipment Rental", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "45", "14", "RsTextbox", 0, "PRD_Base_Conv_Lead_Men_HRS", 69, 250, 22, 125, 44, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "46", "14", "RsLabel", 0, "", 70, 6, 21, 72, 45, "16.01.02.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "47", "14", "RsLabel", 0, "", 126, 6, 21, 72, 46, "16.01.04", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "48", "13", "RsGroupBox", 0, "", 261, 6, 77, 668, 47, "Base Internal Install", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "49", "48", "RsLabel", 0, "", 15, 547, 21, 72, 48, "Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "50", "48", "RsTextbox", 0, "PRD_Base__Internal_Install_Sbcntrct_Svcs_COST", 41, 512, 22, 125, 49, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "51", "48", "RsTextbox", 0, "PRD_Base__Internal_Install_Sbcntrct_Svcs_HRS", 41, 250, 22, 125, 50, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "52", "48", "RsLabel", 0, "", 15, 292, 21, 72, 51, "Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "53", "48", "RsLabel", 0, "", 42, 84, 21, 160, 52, "Sbcntrct Svcs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "54", "48", "RsLabel", 0, "", 42, 6, 21, 72, 53, "16.01.98.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "55", "13", "RsGroupBox", 0, "", 344, 6, 77, 668, 54, "Option", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "56", "55", "RsLabel", 0, "", 15, 547, 21, 72, 55, "Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "57", "55", "RsTextbox", 0, "PRD_Option_Sbcntrct_Svcs_COST", 41, 512, 22, 125, 56, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "58", "55", "RsTextbox", 0, "PRD_Option_Sbcntrct_Svcs_HRS", 41, 250, 22, 125, 57, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "59", "55", "RsLabel", 0, "", 15, 292, 21, 72, 58, "Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "60", "55", "RsLabel", 0, "", 42, 84, 21, 160, 59, "Sbcntrct Svcs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "61", "55", "RsLabel", 0, "", 42, 6, 21, 72, 60, "16.01.98.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "62", "13", "RsGroupBox", 0, "", 427, 6, 77, 668, 61, "Option Internal Install", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "63", "62", "RsLabel", 0, "", 15, 547, 21, 72, 62, "Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "64", "62", "RsTextbox", 0, "PRD_Option_Internal_Install_Sbcntrct_Svcs_COST", 41, 512, 22, 125, 63, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "65", "62", "RsTextbox", 0, "PRD_Option_Internal_Install_Sbcntrct_Svcs_HRS", 41, 250, 22, 125, 64, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "66", "62", "RsLabel", 0, "", 15, 292, 21, 72, 65, "Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "67", "62", "RsLabel", 0, "", 42, 84, 21, 160, 66, "Sbcntrct Svcs", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "68", "62", "RsLabel", 0, "", 42, 6, 21, 72, 67, "16.01.98.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "69", "12", "RsActionButton", 0, "", 524, 704, 82, 684, 68, "Sourcing Inputs", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Mech_Install_Sourcing_Inputs_Report;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 360, "70", "12", "RsGroupBox", 0, "", 3, 3, 691, 680, 69, "Total Mechanical Installation Sub Estimate", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "71", "70", "RsGroupBox", 0, "", 15, 6, 437, 668, 70, "Mechanical Install", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "72", "71", "RsLabel", 0, "", 407, 73, 21, 171, 71, "Mechanical Install Total", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "73", "71", "RsLabel", 0, "", 16, 547, 21, 72, 72, "Std. Cost", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "74", "71", "RsTextbox", 0, "Rollup_Conv_Intelligrated_Installers_HRS", 126, 381, 22, 125, 73, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "75", "71", "RsLabel", 0, "", 127, 73, 21, 171, 74, "Conv - Intelligrated Installers", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "76", "71", "RsTextbox", 0, "Rollup_Superintendent_HRS", 42, 381, 22, 125, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "77", "71", "RsTextbox", 0, "Rollup__Mech_Install_Total_HRS", 406, 381, 22, 125, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "78", "71", "RsTextbox", 0, "Rollup__Mech_Install_Total_COST", 406, 512, 22, 125, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "79", "71", "RsLabel", 0, "", 407, 6, 21, 72, 78, "16.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "80", "71", "RsTextbox", 0, "Rollup_Miscellanious_COST", 378, 512, 22, 125, 79, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "81", "71", "RsTextbox", 0, "Rollup_Superintendent_COST", 42, 512, 22, 125, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "82", "71", "RsLabel", 0, "", 379, 73, 21, 171, 81, "Miscellanious", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "83", "71", "RsTextbox", 0, "Rollup_Conv_Intelligrated_Installers_UOM", 126, 250, 22, 125, 82, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "84", "71", "RsLabel", 0, "", 379, 6, 21, 72, 83, "16.01.99", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "85", "71", "RsTextbox", 0, "Rollup_Intelligrated_Installer_HRS", 70, 381, 22, 125, 84, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "86", "71", "RsTextbox", 0, "Rollup_Superintendent_UOM", 42, 250, 22, 125, 85, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "87", "71", "RsTextbox", 0, "Rollup_Additional_Subcontractor_Services_COST", 350, 512, 22, 125, 86, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "88", "71", "RsTextbox", 0, "Rollup_SuppliesConsumables_COST", 238, 512, 22, 125, 87, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "89", "71", "RsTextbox", 0, "Rollup_Travel_Expenses_COST", 294, 512, 22, 125, 88, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "90", "71", "RsTextbox", 0, "Rollup_Conv_Intelligrated_Installers_COST", 126, 512, 22, 125, 89, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "91", "71", "RsLabel", 0, "", 16, 423, 21, 72, 90, "Hours", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "92", "71", "RsTextbox", 0, "Rollup_TTCB_Intelligrated_Installers_COST", 182, 512, 22, 125, 91, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "93", "71", "RsTextbox", 0, "Rollup_Permits_COST", 322, 512, 22, 125, 92, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "94", "71", "RsTextbox", 0, "Rollup_Intelligrated_Installer_COST", 70, 512, 22, 125, 93, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "95", "71", "RsTextbox", 0, "Rollup_Prototype_COST", 266, 512, 22, 125, 94, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "96", "71", "RsTextbox", 0, "Rollup_Intelligrated_Installer_UOM", 70, 250, 22, 125, 95, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "97", "71", "RsLabel", 0, "", 16, 292, 21, 72, 96, "$/UOM", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "98", "71", "RsTextbox", 0, "Rollup_TTCB_Intelligrated_Installers_UOM", 182, 250, 22, 125, 97, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "99", "71", "RsTextbox", 0, "Rollup_Equipment_Rental_COST", 210, 512, 22, 125, 98, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "100", "71", "RsTextbox", 0, "Rollup_TTCB_Lead_Men_COST", 154, 512, 22, 125, 99, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "101", "71", "RsTextbox", 0, "Rollup_Conv_Lead_Men_COST", 98, 512, 22, 125, 100, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "102", "71", "RsTextbox", 0, "Rollup_Conv_Lead_Men_UOM", 98, 250, 22, 125, 101, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "103", "71", "RsLabel", 0, "", 71, 73, 21, 171, 102, "Intelligrated Installer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "104", "71", "RsTextbox", 0, "Rollup_Conv_Lead_Men_HRS", 98, 381, 22, 125, 103, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "105", "71", "RsLabel", 0, "", 71, 6, 21, 72, 104, "16.01.02", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "106", "71", "RsLabel", 0, "", 43, 73, 21, 171, 105, "Superintendent", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "107", "71", "RsTextbox", 0, "Rollup_TTCB_Intelligrated_Installers_HRS", 182, 381, 22, 125, 106, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "108", "71", "RsLabel", 0, "", 127, 6, 21, 72, 107, "16.01.02.02", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "109", "71", "RsLabel", 0, "", 99, 73, 21, 171, 108, "Conv - Lead Men", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "110", "71", "RsLabel", 0, "", 43, 6, 21, 72, 109, "16.01.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "111", "71", "RsLabel", 0, "", 351, 73, 21, 171, 110, "Additional Subcontractor Services", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "112", "71", "RsLabel", 0, "", 239, 73, 21, 171, 111, "Supplies/Consumables", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "113", "71", "RsTextbox", 0, "Rollup_TTCB_Lead_Men_HRS", 154, 381, 22, 125, 112, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "114", "71", "RsLabel", 0, "", 295, 73, 21, 171, 113, "Travel Expenses", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "115", "71", "RsLabel", 0, "", 183, 73, 21, 171, 114, "TT/CB - Intelligrated Installers", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "116", "71", "RsTextbox", 0, "Rollup_TTCB_Lead_Men_UOM", 154, 250, 22, 125, 115, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "117", "71", "RsLabel", 0, "", 323, 73, 21, 171, 116, "Permits", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "118", "71", "RsLabel", 0, "", 211, 73, 21, 171, 117, "Equipment Rental", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "119", "71", "RsLabel", 0, "", 99, 6, 21, 72, 118, "16.01.02.01", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "120", "71", "RsLabel", 0, "", 267, 73, 21, 171, 119, "Prototype", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "121", "71", "RsLabel", 0, "", 155, 73, 21, 171, 120, "TT/CB - Lead Men", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "122", "71", "RsLabel", 0, "", 351, 6, 21, 72, 121, "16.01.98", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "123", "71", "RsLabel", 0, "", 239, 6, 21, 72, 122, "16.01.05", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "124", "71", "RsLabel", 0, "", 295, 6, 21, 72, 123, "16.01.07", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "125", "71", "RsLabel", 0, "", 183, 6, 21, 72, 124, "16.01.02.04", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "126", "71", "RsLabel", 0, "", 323, 6, 21, 72, 125, "16.01.08", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "127", "71", "RsLabel", 0, "", 211, 6, 21, 72, 126, "16.01.04", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "128", "71", "RsLabel", 0, "", 267, 6, 21, 72, 127, "16.01.06", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "129", "71", "RsLabel", 0, "", 155, 6, 21, 72, 128, "16.01.02.03", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "130", "70", "RsGroupBox", 0, "", 458, 6, 224, 668, 129, "Additional Metrics", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "131", "130", "RsComboBox", 0, "Rollup__Work_Week_Type", 160, 427, 22, 125, 130, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "132", "130", "RsTextbox", 0, "Rollup_Tariff_Adder_COST", 133, 166, 22, 125, 131, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "133", "130", "RsLabel", 0, "", 106, 71, 21, 89, 132, "Tariff Adder (%)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "134", "130", "RsLabel", 0, "", 21, 463, 21, 72, 133, "Cost / Feet", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "135", "130", "RsLabel", 0, "", 132, 6, 21, 59, 134, "4.91.05", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "136", "130", "RsTextbox", 0, "Rollup__Total_Conveyor_COST_per_Footage", 47, 428, 22, 125, 135, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "137", "130", "RsTextbox", 0, "Rollup__Total_Conveyor_HRS_per_Footage", 47, 297, 22, 125, 136, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "138", "130", "RsLabel", 0, "", 188, 71, 21, 89, 137, "Comm Weeks", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "139", "130", "RsLabel", 0, "", 133, 71, 21, 89, 138, "Tariff Cost ($)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "140", "130", "RsTextbox", 0, "Rollup__Weeks_Comm", 188, 166, 22, 125, 139, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "141", "130", "RsTextbox", 0, "Rollup__Work_Week_HRS_per_Week", 189, 427, 22, 125, 140, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "142", "130", "RsTextbox", 0, "Rollup__Weeks_Install", 160, 166, 22, 125, 141, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "143", "130", "RsTextbox", 0, "Rollup_Tariff_Adder_Pecentage_UI", 105, 166, 22, 125, 142, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "144", "130", "RsLabel", 0, "", 161, 71, 21, 89, 143, "Install Weeks", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "145", "130", "RsLabel", 0, "", 21, 208, 21, 72, 144, "Feet", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "146", "130", "RsLabel", 0, "", 189, 332, 21, 89, 145, "Hours / Week", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "147", "130", "RsLabel", 0, "", 133, 332, 21, 89, 146, "Labor Type", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "148", "130", "RsTextbox", 0, "Rollup__Total_Conveyor_Footage", 47, 166, 22, 125, 147, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 360, "149", "130", "RsLabel", 0, "", 162, 332, 21, 89, 148, "Work Week", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "150", "130", "RsCheckbox", 0, "Rollup__Include_Stagnant_HRS", 105, 427, 18, 137, 149, "Include Stagnant HRS", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "151", "130", "RsComboBox", 0, "Rollup__Labor_Type", 132, 427, 22, 125, 150, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 360, "152", "130", "RsLabel", 0, "", 21, 323, 21, 72, 151, "Hours / Feet", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 360, "153", "130", "RsLabel", 0, "", 48, 71, 21, 89, 152, "Metrics", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Chutes_test()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(101, "Chutes_test", "", 101, 51, 1, 35, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App")
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
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsGrid", 0, "", 12, 12, 401, 761, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,307,Chutes;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:100,100;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 360, "2", "1", "RsGridColumn", 0, "MEI_Chutes_Styles", 0, 0, 0, 100, 0, "Chutes Style", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "3", "1", "RsGridColumn", 0, "MEI_Chutes_Style_1_Angle_of_Curve", 0, 0, 0, 100, 0, "Angle of Curve", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 360, "4", "1", "RsGridColumn", 0, "MEI_Chutes_Style_1_Length_in_Feet", 0, 0, 0, 100, 0, "Length in Feet", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 360, "5", "1", "RsGridColumn", 0, "MEI_Chutes_Style_1_Type_of_Material", 0, 0, 0, 100, 0, "Type of Material", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 360, "6", "1", "RsGridColumn", 0, "MEI_Chutes_Style_1_Infeed_Conveyor_Type", 0, 0, 0, 100, 0, "Infeed Conveyor Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 360, "7", "1", "RsGridColumn", 0, "MEI_Chutes_Style_1_Number_of_Merging_Lanes", 0, 0, 0, 100, 0, "Number of Merging Lanes", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 360, "8", "1", "RsGridColumn", 0, "MEI_Chutes_Style_1_Number_of_Sorting_Lanes", 0, 0, 0, 100, 0, "Number of Sorting Lanes", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 360, "9", "0", "RsAddDeleteCopy", 0, "", 419, 12, 22, 158, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,307,Chutes;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 360, "10", "0", "RsGrid", 0, "", 476, 12, 401, 928, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,307,Chutes;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 360, "11", "10", "RsGridColumn", 0, "MEI_Chutes_Styles", 0, 0, 0, 100, 0, "Chutes Styles", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "12", "10", "RsGridColumn", 0, "MEI_Chutes_Style_1_Angle_hrs", 0, 0, 0, 100, 0, "Angle hrs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "13", "10", "RsGridColumn", 0, "MEI_Chutes_Style_1_Length_hrs", 0, 0, 0, 100, 0, "Length hrs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "14", "10", "RsGridColumn", 0, "MEI_Chutes_Style_1_Material_hrs", 0, 0, 0, 100, 0, "Material hrs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "15", "10", "RsGridColumn", 0, "MEI_Chutes_Style_1_Infeed_hrs", 0, 0, 0, 100, 0, "Infeed hrs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "16", "10", "RsGridColumn", 0, "MEI_Chutes_Style_1_Merge_hrs", 0, 0, 0, 100, 0, "Merge hrs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "17", "10", "RsGridColumn", 0, "MEI_Chutes_Style_1_Sort_hrs", 0, 0, 0, 100, 0, "Sort hrs", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "18", "10", "RsGridColumn", 0, "MEI_Chutes_Style_1_Total_Hours_per_Chute", 0, 0, 0, 100, 0, "Total Hours Per Chute", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_TTCB_Test()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(112, "TTCB_Test", "", 101, 51, 1, 36, 50, 50)
        oProcessStep.AddPath("IGS_Project_Top_App.Project_Information/IGS_Opportunity.Proposal_Information/IGS_Proposal_Data.PRD_Document/SFD_Salesforce_PRD_Header_Mock.Project_Tool_Manager/IGS_Tool_Instance_Mgr.Mech_Install_Estimator/CAE_Mech_Install_App.TTCB_Costing_Mech/CAE_TTCB_Costing_Mech")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 401, "1", "0", "RsGroupBox", 0, "", 510, 24, 455, 392, 0, "System 1", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "2", "1", "RsLabel", 0, "", 350, 36, 21, 111, 1, "Total Costs", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "3", "1", "RsTextbox", 0, "Air_Piping_FILTERREG", 240, 196, 22, 102, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "4", "1", "RsLabel", 0, "", 153, 39, 20, 102, 3, "7/8&amp;quot; (25mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "5", "1", "RsLabel", 0, "", 385, 36, 21, 111, 4, "Total Hours", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "6", "1", "RsLabel", 0, "", 57, 39, 20, 102, 5, "Pipe Type", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "7", "1", "RsLabel", 0, "", 87, 39, 20, 102, 6, "3&amp;quot; (76mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "8", "1", "RsLabel", 0, "", 20, 12, 21, 94, 7, "System 1 Name", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "9", "1", "RsTextbox", 0, "DisplayName", 19, 112, 22, 125, 8, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "10", "1", "RsLabel", 0, "", 307, 39, 20, 102, 9, "Dryer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "11", "1", "RsLabel", 0, "", 285, 39, 20, 102, 10, "Red A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "12", "1", "RsLabel", 0, "", 175, 39, 20, 102, 11, "1/2&amp;quot; (16.5mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "13", "1", "RsLabel", 0, "", 263, 39, 20, 102, 12, "A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "14", "1", "RsLabel", 0, "", 131, 39, 20, 102, 13, "1 1/2&amp;quot; (40mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "15", "1", "RsTextbox", 0, "Air_Piping_SUBTOTAL_Hours", 384, 196, 22, 86, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "16", "1", "RsLabel", 0, "", 197, 39, 20, 102, 15, "SUBTOTALS", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ActiveCaption;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "17", "1", "RsTextbox", 0, "Air_Piping_SUBTOTAL_Units", 349, 196, 22, 86, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "18", "1", "RsLabel", 0, "", 241, 39, 20, 102, 17, "FILTER/REG", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "19", "1", "RsLabel", 0, "", 109, 39, 20, 102, 18, "2 1/2&amp;quot; (63mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "20", "1", "RsTextbox", 0, "Air_Piping_12_inches_pipe", 174, 196, 22, 102, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "21", "1", "RsTextbox", 0, "Air_Piping_SUBTOTAL", 196, 196, 22, 102, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 401, "22", "1", "RsLabel", 0, "", 219, 39, 20, 102, 21, "Tubing", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "23", "1", "RsLabel", 0, "", 57, 196, 20, 102, 22, "Total Order", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "24", "1", "RsTextbox", 0, "Air_Piping_RedAC", 284, 196, 22, 102, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "25", "1", "RsTextbox", 0, "Air_Piping_212_inches_pipe", 108, 196, 22, 102, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "26", "1", "RsTextbox", 0, "Air_Piping_Tubing", 218, 196, 22, 102, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "27", "1", "RsTextbox", 0, "Air_Piping_78_inches_pipe", 152, 196, 22, 102, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "28", "1", "RsTextbox", 0, "Air_Piping_112_inches_pipe", 130, 196, 22, 102, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "29", "1", "RsTextbox", 0, "Base_Option_Alternate_Name", 86, 196, 22, 102, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "30", "1", "RsTextbox", 0, "Air_Piping_Dryer", 306, 196, 22, 102, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "31", "1", "RsTextbox", 0, "Air_Piping_AC", 262, 196, 22, 102, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "32", "0", "RsSubForm", 0, "", 24, 0, 442, 1508, 31, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,132,My_Air_Piping")
        oProcessStep.AddCustomLayout(1, 401, "33", "32", "RsGroupBox", 0, "", 16, 3, 423, 1400, 32, "System 1", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "34", "33", "RsLabel", 0, "", 340, 6, 21, 111, 33, "Total Costs", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "35", "33", "RsLabel", 0, "", 375, 6, 21, 111, 34, "Total Hours", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "36", "33", "RsLabel", 0, "", 142, 949, 21, 111, 35, "@.150 HR/FT =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "37", "33", "RsLabel", 0, "", 120, 949, 21, 111, 36, "@.200 HR/FT =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "38", "33", "RsLabel", 0, "", 296, 949, 21, 111, 37, "@ 4 HRS EA =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "39", "33", "RsLabel", 0, "", 98, 949, 21, 111, 38, "@.350 HR/FT =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "40", "33", "RsLabel", 0, "", 274, 949, 21, 111, 39, "@ 2 HRS EA =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "41", "33", "RsLabel", 0, "", 208, 949, 21, 111, 40, "1 HR/100&amp;apos;  =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "42", "33", "RsTextbox", 0, "MEI_AP_SS1_IR_2HRS_EA_Red_AC", 273, 1059, 22, 86, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "43", "33", "RsLabel", 0, "", 252, 949, 21, 111, 42, "@ 8 HRS EA =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "44", "33", "RsLabel", 0, "", 164, 949, 21, 111, 43, "@.125 HR/FT =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "45", "33", "RsLabel", 0, "", 76, 949, 21, 111, 44, "@.450 HR/FT =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "46", "33", "RsLabel", 0, "", 341, 310, 20, 102, 45, "Air Piping Factor", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "47", "33", "RsTextbox", 0, "MEI_AP_SS1_Total_Hours", 374, 139, 22, 86, 46, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "48", "33", "RsTextbox", 0, "MEI_AP_SS1_Air_Piping_Factor", 364, 310, 22, 102, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "49", "33", "RsTextbox", 0, "MEI_AP_SS1_Total_Costs", 339, 139, 22, 86, 48, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "50", "33", "RsLabel", 0, "", 230, 949, 21, 111, 49, "@ 3 HRS EA =", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:RosyBrown;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "51", "33", "RsTextbox", 0, "MEI_AP_SS1_IR_4HRS_EA_Dryer", 295, 1059, 22, 86, 50, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "52", "33", "RsLabel", 0, "", 46, 949, 20, 196, 51, "Installation Rate", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "53", "33", "RsTextbox", 0, "MEI_AP_SS1_IR_8HRS_EA_AC", 251, 1059, 22, 86, 52, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "54", "33", "RsLabel", 0, "", 46, 858, 20, 85, 53, "Cost of Valves", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "55", "33", "RsTextbox", 0, "MEI_AP_SS1_IR_0_450_HR_FT_3Inch_Pipe", 75, 1060, 22, 85, 54, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "56", "33", "RsTextbox", 0, "MEI_AP_SS1_IR_3HRS_EA_Filter_Reg", 229, 1059, 22, 86, 55, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "57", "33", "RsTextbox", 0, "MEI_AP_SS1_IR_0_350_HR_FT_2Half_In_Pipe", 97, 1060, 22, 85, 56, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "58", "33", "RsTextbox", 0, "MEI_AP_SS1_IR_1_HR_100FT_Tubing", 207, 1059, 22, 86, 57, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "59", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Valves_3Inch_Pipe", 75, 858, 22, 85, 58, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "60", "33", "RsTextbox", 0, "MEI_AP_SS1_IR_0_200_HR_FT_1Half_In_Pipe", 119, 1060, 22, 85, 59, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "61", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Tees_7_8Inch_Pipe", 141, 767, 22, 85, 60, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "62", "33", "RsLabel", 0, "", 46, 767, 20, 85, 61, "Cost of Tee&amp;apos;s", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "63", "33", "RsTextbox", 0, "MEI_AP_SS1_IR_0_150_HR_FT_7_8Inch_Pipe", 141, 1060, 22, 85, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "64", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Valves_2Half_In_Pipe", 97, 858, 22, 85, 63, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "65", "33", "RsTextbox", 0, "MEI_AP_SS1_IR_0_125_HR_FT_Half_In_Pipe", 163, 1060, 22, 85, 64, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "66", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Tees_3Inch_Pipe", 75, 767, 22, 85, 65, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "67", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Valves_7_8Inch_Pipe", 141, 858, 22, 85, 66, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "68", "33", "RsTextbox", 0, "", 185, 1060, 22, 85, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 401, "69", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Valves_1Half_In_Pipe", 119, 858, 22, 85, 68, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "70", "33", "RsLabel", 0, "", 46, 676, 20, 85, 69, "Cost of Elbows", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "71", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Tees_2Half_In_Pipe", 97, 767, 22, 85, 70, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "72", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Valves_Half_In_Pipe", 163, 858, 22, 85, 71, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "73", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_Pipe_n_Coupling_Sub_Totals", 185, 339, 22, 135, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 401, "74", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Elbows_2Half_In_Pipe", 97, 676, 22, 85, 73, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "75", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Valves_Sub_Totals", 185, 858, 22, 85, 74, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 401, "76", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Tees_1Half_In_Pipe", 119, 767, 22, 85, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "77", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Elbows_3Inch_Pipe", 75, 676, 22, 85, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "78", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_Pipe_n_Coupling_3Inch_Pipe", 75, 339, 22, 135, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "79", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Elbows_1Half_In_Pipe", 119, 676, 22, 85, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "80", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Tees_Half_In_Pipe", 163, 767, 22, 85, 79, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "81", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Tees_Sub_Totals", 185, 767, 22, 85, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 401, "82", "33", "RsLabel", 0, "", 46, 231, 20, 102, 81, "HookUp Cost", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "83", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Elbows_7_8Inch_Pipe", 141, 676, 22, 85, 82, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "84", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Elbows_Sub_Totals", 185, 676, 22, 85, 83, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 401, "85", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_Pipe_n_Coupling_7_8Inch_Pipe", 141, 339, 22, 135, 84, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "86", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Elbows_Half_In_Pipe", 163, 676, 22, 85, 85, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "87", "33", "RsLabel", 0, "", 46, 585, 20, 85, 86, "Cost of Hangers", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "88", "33", "RsLabel", 0, "", 46, 339, 20, 135, 87, "Cost of Pipe and Couplings", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "89", "33", "RsTextbox", 0, "MEI_AP_SS1_Hookup_Costs_Filter_Reg", 229, 231, 22, 102, 88, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "90", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_Half_In_Pipe", 163, 585, 22, 85, 89, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "91", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_Pipe_n_Coupling_Half_In_Pipe", 163, 339, 22, 135, 90, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "92", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_Sub_Totals", 185, 585, 22, 85, 91, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 401, "93", "33", "RsTextbox", 0, "MEI_AP_SS1_Hookup_Costs_AC", 251, 231, 22, 102, 92, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "94", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_2Half_In_Pipe", 97, 585, 22, 85, 93, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "95", "33", "RsLabel", 0, "", 46, 480, 20, 99, 94, "Hangers Total Units", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "96", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_Pipe_n_Coupling_2Half_In_Pipe", 97, 339, 22, 135, 95, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "97", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Elbows_7_8Inch_Pipe", 141, 585, 22, 85, 96, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "98", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_TU_Half_In_Pipe", 163, 480, 22, 99, 97, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "99", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_Pipe_n_Coupling_1Half_In_Pipe", 119, 339, 22, 135, 98, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "100", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_1Half_In_Pipe", 119, 585, 22, 85, 99, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "101", "33", "RsTextbox", 0, "", 185, 480, 22, 99, 100, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 401, "102", "33", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Dryer", 295, 123, 22, 102, 101, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "103", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_3Inch_Pipe", 75, 585, 22, 85, 102, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "104", "33", "RsTextbox", 0, "MEI_AP_SS1_Hookup_Costs_Red_AC", 273, 231, 22, 102, 103, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "105", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_TU_2Half_In_Pipe", 97, 480, 22, 99, 104, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "106", "33", "RsTextbox", 0, "MEI_AP_SS1_Hookup_Costs_Dryer", 295, 231, 22, 102, 105, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "107", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_TU_7_8Inch_Pipe", 141, 480, 22, 99, 106, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "108", "33", "RsTextbox", 0, "MEI_AP_SS1_Hookup_Costs_Tubing", 207, 231, 22, 102, 107, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "109", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_TU_1Half_In_Pipe", 119, 480, 22, 99, 108, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "110", "33", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Red_AC", 273, 123, 22, 102, 109, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "111", "33", "RsTextbox", 0, "MEI_AP_SS1_Cost_of_Hanger_TU_3Inch_Pipe", 75, 480, 22, 99, 110, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "112", "33", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_Half_In_Pipe", 163, 123, 22, 102, 111, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "113", "33", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_AC", 251, 123, 22, 102, 112, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "114", "33", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_Sub_Totals", 185, 123, 22, 102, 113, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 401, "115", "33", "RsLabel", 0, "", 46, 123, 20, 102, 114, "Total Order", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "116", "33", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Filter_Reg", 229, 123, 22, 102, 115, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "117", "33", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_2Half_In_Pipe", 97, 123, 22, 102, 116, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "118", "33", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Tubing", 207, 123, 22, 102, 117, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "119", "33", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_7_8Inch_Pipe", 141, 123, 22, 102, 118, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "120", "33", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_1Half_In_Pipe", 119, 123, 22, 102, 119, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "121", "33", "RsLabel", 0, "", 274, 15, 20, 102, 120, "Red A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "122", "33", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_3Inch_Pipe", 75, 123, 22, 102, 121, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "123", "33", "RsLabel", 0, "", 296, 15, 20, 102, 122, "Dryer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "124", "33", "RsLabel", 0, "", 252, 15, 20, 102, 123, "A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "125", "33", "RsLabel", 0, "", 230, 15, 20, 102, 124, "FILTER/REG", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "126", "33", "RsLabel", 0, "", 208, 15, 20, 102, 125, "Tubing", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "127", "33", "RsLabel", 0, "", 186, 15, 20, 102, 126, "SUBTOTALS", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ActiveCaption;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "128", "33", "RsLabel", 0, "", 164, 15, 20, 102, 127, "1/2&amp;quot; (16.5mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "129", "33", "RsLabel", 0, "", 142, 15, 20, 102, 128, "7/8&amp;quot; (25mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "130", "33", "RsLabel", 0, "", 120, 15, 20, 102, 129, "1 1/2&amp;quot; (40mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "131", "33", "RsLabel", 0, "", 98, 15, 20, 102, 130, "2 1/2&amp;quot; (63mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "132", "33", "RsLabel", 0, "", 76, 15, 20, 102, 131, "3&amp;quot; (76mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "133", "33", "RsLabel", 0, "", 46, 15, 20, 102, 132, "Pipe Type", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "134", "33", "RsTextbox", 0, "DisplayName", 8, 196, 22, 125, 133, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "135", "33", "RsLabel", 0, "", 8, 112, 21, 78, 134, "System 1 Name", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "136", "0", "RsSubForm", 0, "", 505, 28, 455, 385, 135, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,119,My_Base_Options_Alternates")
        oProcessStep.AddCustomLayout(1, 401, "137", "0", "RsLabel", 0, "", 1, 71, 21, 122, 136, "System 1 Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "138", "0", "RsActionButton", 0, "", 571, 1275, 60, 114, 137, "Reset Delta", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:MechResetDelta;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 401, "139", "0", "RsSubForm", 0, "", 505, 826, 455, 385, 138, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,120,My_Base_Options_Alternates_Delta")
        oProcessStep.AddCustomLayout(1, 401, "140", "139", "RsGroupBox", 0, "", 5, 6, 438, 376, 139, "Delta", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "141", "140", "RsLabel", 0, "", 20, 40, 21, 94, 140, "Delta Name", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "142", "140", "RsTextbox", 0, "DisplayName", 20, 160, 22, 125, 141, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "143", "140", "RsLabel", 0, "", 349, 61, 21, 111, 142, "Total Costs", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "144", "140", "RsLabel", 0, "", 384, 61, 21, 111, 143, "Total Hours", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "145", "140", "RsTextbox", 0, "MEI_AP_SS1_Total_Hours", 383, 221, 22, 86, 144, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "146", "140", "RsTextbox", 0, "MEI_AP_SS1_Total_Costs", 348, 221, 22, 86, 145, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "147", "140", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Dryer", 305, 221, 22, 102, 146, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "148", "140", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Red_AC", 283, 221, 22, 102, 147, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "149", "140", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_Half_In_Pipe", 173, 221, 22, 102, 148, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "150", "140", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_AC", 261, 221, 22, 102, 149, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "151", "140", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_Sub_Totals", 195, 221, 22, 102, 150, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 401, "152", "140", "RsLabel", 0, "", 56, 221, 20, 102, 151, "Total Order", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "153", "140", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Filter_Reg", 239, 221, 22, 102, 152, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "154", "140", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_2Half_In_Pipe", 107, 221, 22, 102, 153, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "155", "140", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Tubing", 217, 221, 22, 102, 154, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "156", "140", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_7_8Inch_Pipe", 151, 221, 22, 102, 155, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "157", "140", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_1Half_In_Pipe", 129, 221, 22, 102, 156, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "158", "140", "RsLabel", 0, "", 284, 64, 20, 102, 157, "Red A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "159", "140", "RsTextbox", 0, "Air_Piping_3pipe", 85, 221, 22, 102, 158, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "160", "140", "RsLabel", 0, "", 306, 64, 20, 102, 159, "Dryer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "161", "140", "RsLabel", 0, "", 262, 64, 20, 102, 160, "A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "162", "140", "RsLabel", 0, "", 240, 64, 20, 102, 161, "FILTER/REG", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "163", "140", "RsLabel", 0, "", 218, 64, 20, 102, 162, "Tubing", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "164", "140", "RsLabel", 0, "", 196, 64, 20, 102, 163, "SUBTOTALS", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ActiveCaption;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "165", "140", "RsLabel", 0, "", 174, 64, 20, 102, 164, "1/2&amp;quot; (16.5mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "166", "140", "RsLabel", 0, "", 152, 64, 20, 102, 165, "7/8&amp;quot; (25mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "167", "140", "RsLabel", 0, "", 130, 64, 20, 102, 166, "1 1/2&amp;quot; (40mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "168", "140", "RsLabel", 0, "", 108, 64, 20, 102, 167, "2 1/2&amp;quot; (63mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "169", "140", "RsLabel", 0, "", 86, 64, 20, 102, 168, "3&amp;quot; (76mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "170", "140", "RsLabel", 0, "", 56, 64, 20, 102, 169, "Pipe Type", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "171", "0", "RsSubForm", 0, "", 505, 419, 455, 385, 170, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:C,121,My_Base_Options_Alternates_2")
        oProcessStep.AddCustomLayout(1, 401, "172", "171", "RsGroupBox", 0, "", 4, 3, 439, 376, 171, "System 2", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "173", "172", "RsLabel", 0, "", 20, 16, 21, 94, 172, "System 2 Name", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "174", "172", "RsTextbox", 0, "DisplayName", 20, 116, 22, 125, 173, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "175", "172", "RsLabel", 0, "", 350, 58, 21, 111, 174, "Total Costs", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "176", "172", "RsLabel", 0, "", 385, 58, 21, 111, 175, "Total Hours", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ffffff80;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "177", "172", "RsTextbox", 0, "MEI_AP_SS1_Total_Hours", 384, 218, 22, 86, 176, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "178", "172", "RsTextbox", 0, "MEI_AP_SS1_Total_Costs", 349, 218, 22, 86, 177, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "179", "172", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Dryer", 306, 218, 22, 102, 178, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "180", "172", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Red_AC", 284, 218, 22, 102, 179, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "181", "172", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_Half_In_Pipe", 174, 218, 22, 102, 180, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "182", "172", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_AC", 262, 218, 22, 102, 181, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "183", "172", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_Sub_Totals", 196, 218, 22, 102, 182, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.1;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 401, "184", "172", "RsLabel", 0, "", 57, 218, 20, 102, 183, "Total Order", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "185", "172", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Filter_Reg", 240, 218, 22, 102, 184, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "186", "172", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_2Half_In_Pipe", 108, 218, 22, 102, 185, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "187", "172", "RsTextbox", 0, "MEI_AP_SS1_Total_Order_Tubing", 218, 218, 22, 102, 186, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "188", "172", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_7_8Inch_Pipe", 152, 218, 22, 102, 187, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "189", "172", "RsTextbox", 0, "MEI_AP_SS1_Pipe_Type_Total_Order_1Half_In_Pipe", 130, 218, 22, 102, 188, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "190", "172", "RsLabel", 0, "", 285, 61, 20, 102, 189, "Red A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "191", "172", "RsTextbox", 0, "Air_Piping_3pipe", 86, 218, 22, 102, 190, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 401, "192", "172", "RsLabel", 0, "", 307, 61, 20, 102, 191, "Dryer", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "193", "172", "RsLabel", 0, "", 263, 61, 20, 102, 192, "A/C", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "194", "172", "RsLabel", 0, "", 241, 61, 20, 102, 193, "FILTER/REG", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "195", "172", "RsLabel", 0, "", 219, 61, 20, 102, 194, "Tubing", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "196", "172", "RsLabel", 0, "", 197, 61, 20, 102, 195, "SUBTOTALS", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:ActiveCaption;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "197", "172", "RsLabel", 0, "", 175, 61, 20, 102, 196, "1/2&amp;quot; (16.5mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "198", "172", "RsLabel", 0, "", 153, 61, 20, 102, 197, "7/8&amp;quot; (25mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "199", "172", "RsLabel", 0, "", 131, 61, 20, 102, 198, "1 1/2&amp;quot; (40mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "200", "172", "RsLabel", 0, "", 109, 61, 20, 102, 199, "2 1/2&amp;quot; (63mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "201", "172", "RsLabel", 0, "", 87, 61, 20, 102, 200, "3&amp;quot; (76mm) pipe", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "202", "172", "RsLabel", 0, "", 57, 61, 20, 102, 201, "Pipe Type", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.8;Font_Style:1.;ForeColor:ControlText;BackColor:Info;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "203", "0", "RsLabel", 0, "", 482, 478, 21, 124, 202, "System 2 Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "204", "0", "RsComboBox", 0, "Selection_System_Delta", 481, 608, 22, 125, 203, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "205", "0", "RsLabel", 0, "", 481, 71, 21, 122, 204, "System 1 Selection", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 401, "206", "0", "RsComboBox", 0, "Selection_System", 481, 199, 22, 125, 205, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 401, "207", "0", "RsActionButton", 0, "", 505, 1275, 60, 114, 206, "Compare Delta", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:MechCompareDelta;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 401, "208", "0", "RsComboBox", 0, "Selection_System", 0, 199, 22, 125, 207, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        
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
          InitProperty("Data_Capture_Creation_Date", "10865", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/23/2025 7:40:59 PM", "", "In Development",  0,21391)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Data_Capture_Creation_User_ID", "10866", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/23/2025 7:41:35 PM", "", "In Development",  0,21393)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Data_Capture_Customer_Name", "10864", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/23/2025 7:41:53 PM", "", "In Development",  0,21394)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Data_Capture_Last_Update_Date", "10867", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/23/2025 7:58:59 PM", "", "In Development",  0,21396)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Data_Capture_Last_Update_User_ID", "10868", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/23/2025 7:50:37 PM", "", "In Development",  0,21397)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Data_Capture_Line_Item", "10861", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/23/2025 7:38:49 PM", "", "In Development",  0,21384)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Data_Capture_Project_ID", "10860", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/23/2025 7:38:03 PM", "", "In Development",  0,21382)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Data_Capture_TeamCenter_ID", "10863", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/23/2025 7:39:42 PM", "", "In Development",  0,21387)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TeamCenter_ID", "10862", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/23/2025 7:39:21 PM", "", "In Development",  0,21385)
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
            If Incontext("-1", ctx) Then
          
        InitConnection("Delete_ME_MPC_Testing", "161", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/15/2025 5:15:02 PM", "", "In Development", "N",294)
        
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
      Public Function Formula_Delete_ME_MPC_Testing_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:161; TYPE:PF
        Result = Nothing

Result = Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1)
        '   END FORMULA; CON ID:161; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Formula_Delete_ME_MPC_Testing_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
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
      Public Function Process_DefaultProcess_Instructions_STATUS() as Integer 'Long
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
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Instructions_STATUS", ex.Message)
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
      '   BEGIN FORMULA; PROC ID:69; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:69; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Instructions_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_PRD_Import_STATUS() as Integer 'Long
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
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_PRD_Import_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_PRD_Import_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:70; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:70; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_PRD_Import_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_PRD_Summary_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:109; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:109; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_PRD_Summary_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_PRD_Summary_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:109; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:109; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_PRD_Summary_COMMENT", ex.Message)
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

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasAppCalc Then
	Result = STATUS_ENABLED
End If
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

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasAppCalc Then
	Result = STATUS_ENABLED
End If
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
      Public Function Process_DefaultProcess_Induction_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:118; TYPE:ST
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
      '   END FORMULA; PROC ID:118; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Induction_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Induction_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:118; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:118; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Induction_COMMENT", ex.Message)
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

Result = STATUS_HIDDEN

If Me.Project_Information(1).Proposal_Information(1).PRD_Document(1).Project_Tool_Manager(1).HasAppCalc Then
	Result = STATUS_ENABLED
End If
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
      Public Function Process_DefaultProcess_Setup_And_Global_MTBF___DEBUG_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:113; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN
      '   END FORMULA; PROC ID:113; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Setup_And_Global_MTBF___DEBUG_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Setup_And_Global_MTBF___DEBUG_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:113; TYPE:CO
      Result = String.Empty
      '   END FORMULA; PROC ID:113; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Setup_And_Global_MTBF___DEBUG_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_MDR_Sort_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:115; TYPE:ST
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
      '   END FORMULA; PROC ID:115; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_MDR_Sort_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_MDR_Sort_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:115; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:115; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_MDR_Sort_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Scan_Belt_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:119; TYPE:ST
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
      '   END FORMULA; PROC ID:119; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Scan_Belt_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Scan_Belt_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:119; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:119; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Scan_Belt_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Intro_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:106; TYPE:ST
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
      '   END FORMULA; PROC ID:106; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Intro_STATUS", ex.Message)
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
      '   BEGIN FORMULA; PROC ID:106; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:106; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Intro_COMMENT", ex.Message)
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
      Public Function Process_DefaultProcess_Detailed_Comp_View_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:107; TYPE:ST
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
      '   END FORMULA; PROC ID:107; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Detailed_Comp_View_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Detailed_Comp_View_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:107; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:107; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_Detailed_Comp_View_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_BOM_View_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:108; TYPE:ST
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
      '   END FORMULA; PROC ID:108; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_BOM_View_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_BOM_View_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:108; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:108; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_BOM_View_COMMENT", ex.Message)
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
      Public Function Process_DefaultProcess_System_Mech_Delta_STATUS() as Integer 'Long
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
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_System_Mech_Delta_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_System_Mech_Delta_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:83; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:83; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_System_Mech_Delta_COMMENT", ex.Message)
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

Result = STATUS_HIDDEN
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
      Public Function Process_DefaultProcess_TTCB_Test_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:112; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

'Result = STATUS_ENABLED
Result = STATUS_HIDDEN
      '   END FORMULA; PROC ID:112; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_TTCB_Test_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_TTCB_Test_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:112; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:112; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Process_DefaultProcess_TTCB_Test_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Data_Capture_Creation_Date() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Data_Capture_Creation_Date").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10865; TYPE:PF
      Result = Me.CreationDate
      '   END FORMULA; PROP ID:10865; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Formula_Data_Capture_Creation_Date", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Data_Capture_Creation_User_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Data_Capture_Creation_User_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10866; TYPE:PF
      Result = Me.UserID
      '   END FORMULA; PROP ID:10866; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Formula_Data_Capture_Creation_User_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Data_Capture_Customer_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Data_Capture_Customer_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10864; TYPE:PF
      Result = Me.CustomerName
      '   END FORMULA; PROP ID:10864; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Formula_Data_Capture_Customer_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Data_Capture_Last_Update_Date() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Data_Capture_Last_Update_Date").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10867; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:10867; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Formula_Data_Capture_Last_Update_Date", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Data_Capture_Last_Update_User_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Data_Capture_Last_Update_User_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10868; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:10868; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Formula_Data_Capture_Last_Update_User_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Data_Capture_Line_Item() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Data_Capture_Line_Item").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10861; TYPE:PF
      Result = Me.LineItem
      '   END FORMULA; PROP ID:10861; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Formula_Data_Capture_Line_Item", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Data_Capture_Project_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Data_Capture_Project_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10860; TYPE:PF
      Result = Me.ProjectID
      '   END FORMULA; PROP ID:10860; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Formula_Data_Capture_Project_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Data_Capture_TeamCenter_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Data_Capture_TeamCenter_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10863; TYPE:PF
      Result = Me.TeamCenter_ID
      '   END FORMULA; PROP ID:10863; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Formula_Data_Capture_TeamCenter_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TeamCenter_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TeamCenter_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10862; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:10862; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_Project_Top_App.Formula_TeamCenter_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_Creation_Date_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_Creation_User_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_Customer_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_Last_Update_Date_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_Last_Update_User_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_Line_Item_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_Project_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_TeamCenter_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TeamCenter_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_Creation_Date_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_Creation_User_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_Customer_Name_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_Last_Update_Date_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_Last_Update_User_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_Line_Item_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_Project_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Data_Capture_TeamCenter_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TeamCenter_ID_USERCHANGE() as Boolean
      Return False
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

  