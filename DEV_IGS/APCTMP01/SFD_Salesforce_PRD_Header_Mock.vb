Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: SFD_Salesforce_PRD_Header_Mock
'$ GenerateDate: 07/12/2025 19:19:17

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

    Public Class [SFD_Salesforce_PRD_Header_Mock]
    
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

    Private this as SFD_Salesforce_PRD_Header_Mock = me

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
    
          Public Property [Debug_1]() As String
      Get
      Return Properties("Debug_1").Value
      End Get
      Set(ByVal Value As String)
      Properties("Debug_1").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Opportunity_Data_Source_Type]() As String
      Get
      Return Properties("Opportunity_Data_Source_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Opportunity_Data_Source_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Conveyor_ASRS_VV]() As Long
      Get
      Return Properties("PRD_Conveyor_ASRS_VV").Value
      End Get
      Set(ByVal Value As Long)
      Properties("PRD_Conveyor_ASRS_VV").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Conveyor_Electrical_VV]() As Long
      Get
      Return Properties("PRD_Conveyor_Electrical_VV").Value
      End Get
      Set(ByVal Value As Long)
      Properties("PRD_Conveyor_Electrical_VV").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Conveyor_HCAD_Metric_VV]() As Long
      Get
      Return Properties("PRD_Conveyor_HCAD_Metric_VV").Value
      End Get
      Set(ByVal Value As Long)
      Properties("PRD_Conveyor_HCAD_Metric_VV").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Conveyor_HCAD_VV]() As Long
      Get
      Return Properties("PRD_Conveyor_HCAD_VV").Value
      End Get
      Set(ByVal Value As Long)
      Properties("PRD_Conveyor_HCAD_VV").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Conveyor_NON_STD_VV]() As Long
      Get
      Return Properties("PRD_Conveyor_NON_STD_VV").Value
      End Get
      Set(ByVal Value As Long)
      Properties("PRD_Conveyor_NON_STD_VV").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Data_Entered]() As Boolean
      Get
      Return Properties("PRD_Data_Entered").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("PRD_Data_Entered").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Date_Contract_Award]() As String
      Get
      Return Properties("PRD_Date_Contract_Award").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_Date_Contract_Award").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Date_Eng_InHouse_Start]() As String
      Get
      Return Properties("PRD_Date_Eng_InHouse_Start").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_Date_Eng_InHouse_Start").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Generic_KeyValue_List_Distinct_VV]() As Long
      Get
      Return Properties("PRD_Generic_KeyValue_List_Distinct_VV").Value
      End Get
      Set(ByVal Value As Long)
      Properties("PRD_Generic_KeyValue_List_Distinct_VV").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Generic_Product_List_Distinct_VV]() As Long
      Get
      Return Properties("PRD_Generic_Product_List_Distinct_VV").Value
      End Get
      Set(ByVal Value As Long)
      Properties("PRD_Generic_Product_List_Distinct_VV").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Input_Text_Tab_Formatted]() As String
      Get
      Return Properties("PRD_Input_Text_Tab_Formatted").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_Input_Text_Tab_Formatted").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Lines_Distinct_VV]() As Long
      Get
      Return Properties("PRD_Lines_Distinct_VV").Value
      End Get
      Set(ByVal Value As Long)
      Properties("PRD_Lines_Distinct_VV").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Name]() As String
      Get
      Return Properties("PRD_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_TOTAL_DEBUG]() As String
      Get
      Return Properties("PRD_TOTAL_DEBUG").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_TOTAL_DEBUG").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Code]() As String
      Get
      Return Properties("Project_Code").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Code").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Identifier]() As Long
      Get
      Return Properties("Project_Identifier").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Project_Identifier").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Name]() As String
      Get
      Return Properties("Project_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_City_State]() As String
      Get
      Return Properties("Proposal_City_State").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_City_State").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_Customer_Name]() As String
      Get
      Return Properties("Proposal_Customer_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_Customer_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_Customer_Number]() As String
      Get
      Return Properties("Proposal_Customer_Number").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_Customer_Number").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_Description]() As String
      Get
      Return Properties("Proposal_Description").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_Description").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_ID]() As String
      Get
      Return Properties("Proposal_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_Name]() As String
      Get
      Return Properties("Proposal_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Use_PRD_Total_Text]() As Boolean
      Get
      Return Properties("Use_PRD_Total_Text").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Use_PRD_Total_Text").CalculatedValue = Value
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
    
      Public ReadOnly Property [PRD_Conveyor_ASRS]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("PRD_Conveyor_ASRS")
      End Get
      End Property
    
      Public ReadOnly Property [PRD_Conveyor_Electrical]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("PRD_Conveyor_Electrical")
      End Get
      End Property
    
      Public ReadOnly Property [PRD_Conveyor_HCAD]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("PRD_Conveyor_HCAD")
      End Get
      End Property
    
      Public ReadOnly Property [PRD_Conveyor_HCAD_Metric]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("PRD_Conveyor_HCAD_Metric")
      End Get
      End Property
    
      Public ReadOnly Property [PRD_Conveyor_NON_STD]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("PRD_Conveyor_NON_STD")
      End Get
      End Property
    
      Public ReadOnly Property [PRD_Product_Lines]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("PRD_Product_Lines")
      End Get
      End Property
    
      Public ReadOnly Property [Project_Tool_Manager]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Project_Tool_Manager")
      End Get
      End Property
    
      Public ReadOnly Property [tmp_PRD_Base_Items]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("tmp_PRD_Base_Items")
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
    InitPart("SFD_Salesforce_PRD_Header_Mock", <a><![CDATA[SFD_Salesforce_PRD_Header_Mock]]></a>.Value, 163, "APCTMP01",  "N", "N", False, False, "In Development", "", "Salesforce PRD Document Mockup", "", "", "",  "GLOBAL\H601424", "06/27/2025 18:02:23")
    AddProperty("1442", "Debug_1", <a><![CDATA[Debug_1]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/27/2025 12:04:45 AM")
    AddProperty("1529", "Opportunity_Data_Source_Type", <a><![CDATA[Opportunity_Data_Source_Type]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "CORA Data", "", "GLOBAL\H601424", "3/28/2025 11:26:09 AM")
    AddProperty("4493", "PRD_Conveyor_ASRS_VV", <a><![CDATA[PRD Conveyor ASRS VV]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/18/2025 3:15:21 PM")
    AddProperty("4483", "PRD_Conveyor_Electrical_VV", <a><![CDATA[PRD Conveyor Electrical VV]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/17/2025 7:46:42 PM")
    AddProperty("4492", "PRD_Conveyor_HCAD_Metric_VV", <a><![CDATA[PRD Conveyor HCAD Metric VV]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/18/2025 2:58:11 PM")
    AddProperty("4388", "PRD_Conveyor_HCAD_VV", <a><![CDATA[PRD Conveyor HCAD VV]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/17/2025 5:17:27 PM")
    AddProperty("4387", "PRD_Conveyor_NON_STD_VV", <a><![CDATA[PRD Conveyor NON STD VV]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/17/2025 5:17:12 PM")
    AddProperty("1447", "PRD_Data_Entered", <a><![CDATA[PRD_Data_Entered]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/27/2025 9:56:29 PM")
    AddProperty("5590", "PRD_Date_Contract_Award", <a><![CDATA[PRD Date Contract Award]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 6:02:23 PM")
    AddProperty("5589", "PRD_Date_Eng_InHouse_Start", <a><![CDATA[PRD Date Eng InHouse Start]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 5:59:00 PM")
    AddProperty("3934", "PRD_Generic_KeyValue_List_Distinct_VV", <a><![CDATA[PRD Generic KeyValue List Distinct VV]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/17/2025 1:34:00 PM")
    AddProperty("1440", "PRD_Generic_Product_List_Distinct_VV", <a><![CDATA[PRD_Generic_Product_List_Distinct_VV]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 11:33:32 AM")
    AddProperty("1368", "PRD_Input_Text_Tab_Formatted", <a><![CDATA[PRD_Input_Text_Tab_Formatted]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/27/2025 2:55:41 PM")
    AddProperty("1439", "PRD_Lines_Distinct_VV", <a><![CDATA[PRD_Lines_Distinct_VV]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/16/2025 5:05:29 PM")
    AddProperty("4825", "PRD_Name", <a><![CDATA[PRD_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/24/2025 5:47:10 PM")
    AddProperty("1435", "PRD_TOTAL_DEBUG", <a><![CDATA[PRD_TOTAL_DEBUG]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 11:26:09 AM")
    AddProperty("1369", "Project_Code", <a><![CDATA[Project_Code]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 11:25:30 AM")
    AddProperty("1371", "Project_Identifier", <a><![CDATA[Project_Identifier]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 11:25:30 AM")
    AddProperty("1370", "Project_Name", <a><![CDATA[Project_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 11:25:30 AM")
    AddProperty("3937", "Proposal_City_State", <a><![CDATA[Proposal City State]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/18/2025 9:45:21 PM")
    AddProperty("3939", "Proposal_Customer_Name", <a><![CDATA[Proposal Customer Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/18/2025 9:43:48 PM")
    AddProperty("3940", "Proposal_Customer_Number", <a><![CDATA[Proposal Customer Number]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/16/2025 7:59:09 PM")
    AddProperty("3938", "Proposal_Description", <a><![CDATA[Proposal Description]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/18/2025 9:44:34 PM")
    AddProperty("3935", "Proposal_ID", <a><![CDATA[Proposal ID]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/18/2025 9:44:25 PM")
    AddProperty("3936", "Proposal_Name", <a><![CDATA[Proposal Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/18/2025 9:44:42 PM")
    AddProperty("1436", "Use_PRD_Total_Text", <a><![CDATA[Use_PRD_Total_Text]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 11:25:31 AM")
    AddProperty("927", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/25/2025 9:02:46 PM")
    
      AddValidValue("Debug_1")
    
      AddValidValue("Opportunity_Data_Source_Type")
    
      AddValidValue("PRD_Conveyor_ASRS_VV")
    
      AddValidValue("PRD_Conveyor_Electrical_VV")
    
      AddValidValue("PRD_Conveyor_HCAD_Metric_VV")
    
      AddValidValue("PRD_Conveyor_HCAD_VV")
    
      AddValidValue("PRD_Conveyor_NON_STD_VV")
    
      AddValidValue("PRD_Generic_KeyValue_List_Distinct_VV")
    
      AddValidValue("PRD_Generic_Product_List_Distinct_VV")
    
      AddValidValue("PRD_Lines_Distinct_VV")
    
      AddValidValue("PRD_TOTAL_DEBUG")
    
      oSubpart = AddSubpart(251,"PRD_Conveyor_ASRS", <a><![CDATA[PRD Conveyor ASRS]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/18/2025 3:17:59 PM")
      
        oSubpart.AddVPF (371, "SFD_sm_PRD_Base_Item", "SubMst PRD Base Item")
      
      oSubpart = AddSubpart(249,"PRD_Conveyor_Electrical", <a><![CDATA[PRD Conveyor Electrical]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/17/2025 8:34:44 PM")
      
        oSubpart.AddVPF (371, "SFD_sm_PRD_Base_Item", "SubMst PRD Base Item")
      
      oSubpart = AddSubpart(248,"PRD_Conveyor_HCAD", <a><![CDATA[PRD Conveyor HCAD]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/17/2025 5:17:27 PM")
      
        oSubpart.AddVPF (371, "SFD_sm_PRD_Base_Item", "SubMst PRD Base Item")
      
      oSubpart = AddSubpart(250,"PRD_Conveyor_HCAD_Metric", <a><![CDATA[PRD Conveyor HCAD Metric]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/18/2025 2:58:26 PM")
      
        oSubpart.AddVPF (371, "SFD_sm_PRD_Base_Item", "SubMst PRD Base Item")
      
      oSubpart = AddSubpart(247,"PRD_Conveyor_NON_STD", <a><![CDATA[PRD Conveyor NON STD]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/17/2025 5:17:27 PM")
      
        oSubpart.AddVPF (371, "SFD_sm_PRD_Base_Item", "SubMst PRD Base Item")
      
      oSubpart = AddSubpart(58,"PRD_Product_Lines", <a><![CDATA[PRD_Product_Lines]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 12:03:12 PM")
      
        oSubpart.AddVPF (164, "SFD_Salesforce_PRD_Product_Item", "SFD_Salesforce_PRD_Product_Item")
      
      oSubpart = AddSubpart(258,"Project_Tool_Manager", <a><![CDATA[Project_Tool_Manager]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "6/23/2025 3:05:58 PM")
      
        oSubpart.AddVPF (377, "IGS_Tool_Instance_Mgr", "IGS_Tool_Instance_Mgr")
      
      oSubpart = AddSubpart(245,"tmp_PRD_Base_Items", <a><![CDATA[tmp_PRD_Base_Items]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/16/2025 4:55:03 PM")
      
        oSubpart.AddVPF (371, "SFD_sm_PRD_Base_Item", "SubMst PRD Base Item")
      
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
          InitProperty("Debug_1", "1141", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/27/2025 12:04:45 AM", "", "In Development",  0,1214)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Opportunity_Data_Source_Type", "1223", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 11:26:09 AM", "", "In Development",  0,1315)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Conveyor_ASRS_VV", "4121", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 3:15:21 PM", "", "In Development",  0,5630)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Conveyor_Electrical_VV", "4111", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/17/2025 7:45:59 PM", "", "In Development",  0,5574)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Conveyor_HCAD_Metric_VV", "4120", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 2:58:11 PM", "", "In Development",  0,5626)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Conveyor_HCAD_VV", "4016", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/17/2025 5:17:27 PM", "", "In Development",  0,5450)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Conveyor_NON_STD_VV", "4015", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/17/2025 5:17:12 PM", "", "In Development",  0,5448)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Data_Entered", "1146", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/27/2025 9:56:25 PM", "", "In Development",  0,1231)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Date_Contract_Award", "5202", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 6:02:20 PM", "", "In Development",  0,8183)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Date_Eng_InHouse_Start", "5201", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 5:59:00 PM", "", "In Development",  0,8179)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Generic_KeyValue_List_Distinct_VV", "3563", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/17/2025 1:34:00 PM", "", "In Development",  0,4974)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Generic_Product_List_Distinct_VV", "1139", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 11:33:32 AM", "", "In Development",  0,1161)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Input_Text_Tab_Formatted", "1067", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/27/2025 2:55:15 PM", "", "In Development",  0,1071)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Lines_Distinct_VV", "1138", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 5:03:53 PM", "", "In Development",  0,1164)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Name", "4448", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/24/2025 5:47:10 PM", "", "In Development",  0,6539)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_TOTAL_DEBUG", "1134", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 11:26:09 AM", "", "In Development",  0,1156)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Code", "1068", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 11:25:30 AM", "", "In Development",  0,1072)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Identifier", "1070", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 11:25:30 AM", "", "In Development",  0,1074)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Name", "1069", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 11:25:30 AM", "", "In Development",  0,1073)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_City_State", "3566", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 9:45:21 PM", "", "In Development",  0,4997)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_Customer_Name", "3568", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 9:43:48 PM", "", "In Development",  0,4999)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_Customer_Number", "3569", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 7:59:09 PM", "", "In Development",  0,4988)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_Description", "3567", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 9:44:34 PM", "", "In Development",  0,4998)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_ID", "3564", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 9:44:25 PM", "", "In Development",  0,4995)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_Name", "3565", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 9:44:42 PM", "", "In Development",  0,4996)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Use_PRD_Total_Text", "1135", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 11:25:31 AM", "", "In Development",  0,1151)
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
          
        InitValidValue("Debug_1_ValidValues", "1141", "-1", 1212)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Opportunity_Data_Source_Type_ValidValues", "1223", "-1", 1316)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PRD_Conveyor_ASRS_VV_ValidValues", "4121", "-1", 5648)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PRD_Conveyor_Electrical_VV_ValidValues", "4111", "-1", 5577)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PRD_Conveyor_HCAD_Metric_VV_ValidValues", "4120", "-1", 5627)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PRD_Conveyor_HCAD_VV_ValidValues", "4016", "-1", 5566)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PRD_Conveyor_NON_STD_VV_ValidValues", "4015", "-1", 5565)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PRD_Generic_KeyValue_List_Distinct_VV_ValidValues", "3563", "-1", 5337)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PRD_Generic_Product_List_Distinct_VV_ValidValues", "1139", "-1", 1160)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PRD_Lines_Distinct_VV_ValidValues", "1138", "-1", 4921)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PRD_TOTAL_DEBUG_ValidValues", "1134", "-1", 1157)
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
          
        InitSubpart("PRD_Conveyor_ASRS", 187, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "6/18/2025 3:17:59 PM", "", "In Development", "N",0,518,520)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("PRD_Conveyor_Electrical", 185, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "6/17/2025 8:34:44 PM", "", "In Development", "N",0,513,515)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("PRD_Conveyor_HCAD", 184, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "6/17/2025 5:17:27 PM", "", "In Development", "N",0,512,510)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("PRD_Conveyor_HCAD_Metric", 186, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "6/18/2025 2:58:26 PM", "", "In Development", "N",0,516,517)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("PRD_Conveyor_NON_STD", 183, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "6/17/2025 5:17:27 PM", "", "In Development", "N",0,511,508)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("PRD_Product_Lines", 53, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 12:02:44 PM", "", "In Development", "N",0,231,232)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Project_Tool_Manager", 193, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "6/23/2025 3:05:58 PM", "", "In Development", "N",0,532,531)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("tmp_PRD_Base_Items", 181, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "6/16/2025 4:55:03 PM", "", "In Development", "N",0,503,504)
        
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
          Public Function Formula_Debug_1() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Debug_1").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1141; TYPE:PF
      Result = "1"
      '   END FORMULA; PROP ID:1141; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Debug_1", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Opportunity_Data_Source_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Opportunity_Data_Source_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1223; TYPE:PF
      Result = "Please Select"
      '   END FORMULA; PROP ID:1223; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Opportunity_Data_Source_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Conveyor_ASRS_VV() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Conveyor_ASRS_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4121; TYPE:PF
      Dim MyPropertyName = Me.CurrentProperty.Name
Result = Me.ValidValues(MyPropertyName).Count
      '   END FORMULA; PROP ID:4121; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_ASRS_VV", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Conveyor_Electrical_VV() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Conveyor_Electrical_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4111; TYPE:PF
      Dim MyPropertyName = Me.CurrentProperty.Name
Result = Me.ValidValues(MyPropertyName).Count
      '   END FORMULA; PROP ID:4111; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_Electrical_VV", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Conveyor_HCAD_Metric_VV() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Conveyor_HCAD_Metric_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4120; TYPE:PF
      Dim MyPropertyName = Me.CurrentProperty.Name
Result = Me.ValidValues(MyPropertyName).Count
      '   END FORMULA; PROP ID:4120; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_HCAD_Metric_VV", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Conveyor_HCAD_VV() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Conveyor_HCAD_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4016; TYPE:PF
      Dim MyPropertyName = Me.CurrentProperty.Name
Result = Me.ValidValues(MyPropertyName).Count
      '   END FORMULA; PROP ID:4016; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_HCAD_VV", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Conveyor_NON_STD_VV() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Conveyor_NON_STD_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4015; TYPE:PF
      Dim MyPropertyName = Me.CurrentProperty.Name
Result = Me.ValidValues(MyPropertyName).Count
      '   END FORMULA; PROP ID:4015; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_NON_STD_VV", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Data_Entered() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Data_Entered").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1146; TYPE:PF
      Result = (Me.PRD_Input_Text_Tab_Formatted.Trim().Length > 100)
      '   END FORMULA; PROP ID:1146; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Data_Entered", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Date_Contract_Award() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Date_Contract_Award").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:5202; TYPE:PF
      result = nothing
Dim SearchElement As String = "Contract Award".ToLower()
Const SearchVVList As String = "PRD_Generic_KeyValue_List_Distinct_VV"

For Each s As String In Me.ValidValues(SearchVVList).Keys
	'Dim s As String = vv.Value
	If s.ToLower().Trim().split("|")(0) = SearchElement Then
		Result = s.split("|")(1)
	End If
Next
      '   END FORMULA; PROP ID:5202; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Date_Contract_Award", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Date_Eng_InHouse_Start() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Date_Eng_InHouse_Start").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:5201; TYPE:PF
      result = nothing
Dim SearchElement As String = "In-House Engineering Start Date".toLower()
Const SearchVVList As String = "PRD_Generic_KeyValue_List_Distinct_VV"

For Each s As String In Me.ValidValues(SearchVVList).Keys
	'Dim s As String = vv.Value
	If s.ToLower().Trim().split("|")(0) = SearchElement Then
		Result = s.split("|")(1)
	End If
Next
      '   END FORMULA; PROP ID:5201; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Date_Eng_InHouse_Start", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Generic_KeyValue_List_Distinct_VV() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Generic_KeyValue_List_Distinct_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3563; TYPE:PF
      Dim MyPropertyName = Me.CurrentProperty.Name
Result = Me.ValidValues(MyPropertyName).Count
      '   END FORMULA; PROP ID:3563; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Generic_KeyValue_List_Distinct_VV", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Generic_Product_List_Distinct_VV() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Generic_Product_List_Distinct_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1139; TYPE:PF
      Dim MyPropertyName = Me.CurrentProperty.Name
Result = Me.ValidValues(MyPropertyName).Count
      '   END FORMULA; PROP ID:1139; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Generic_Product_List_Distinct_VV", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Input_Text_Tab_Formatted() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Input_Text_Tab_Formatted").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1067; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1067; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Input_Text_Tab_Formatted", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Lines_Distinct_VV() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Lines_Distinct_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1138; TYPE:PF
      Dim MyPropertyName = Me.CurrentProperty.Name
Result = Me.ValidValues(MyPropertyName).Count
      '   END FORMULA; PROP ID:1138; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Lines_Distinct_VV", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4448; TYPE:PF
      Result = "PRD: " & Me.SubpartID
      '   END FORMULA; PROP ID:4448; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_TOTAL_DEBUG() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_TOTAL_DEBUG").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1134; TYPE:PF
      Result = ""

If True And Me.Use_PRD_Total_Text Then
	Dim lines() As String = Me.PRD_Input_Text_Tab_Formatted.Split(New String() {vbCrLf}, StringSplitOptions.None)
	Dim StartProd As Boolean = False
	Dim linecount As Integer = 0
	For Each line As String In lines
		linecount += 1
		Dim linemarker As String = right($"0000{linecount}",4)
		Dim elements() As String = line.Split(New String() {vbTab}, StringSplitOptions.None)
		If elements.length > 1 Then
			If elements(0).trim().ToLower() = "metrics" Then
				StartProd = True
			End If
			
			If StartProd Then
				If Me.validvalues("PRD_TOTAL_DEBUG").contains(elements(0).Trim()) Then
				Result = Result & $"Line: {linemarker} | Item: {elements(0)} | QTY: {elements(2)} | $/UOM: {elements(3)} | FT: {left(elements(4),4).TRim()} | CstSTD: {elements(5)} | CstESC: {elements(6)}{vbcrlf}"
			End If
			End If
	End If
	Next line
End If

Dim productlines() As String = Result.Split(New String() {vbCrLf}, StringSplitOptions.None)
Dim NewResult As String = $"{productlines.length -1} Products Found"  &  vbcrlf &  "--------------------------------------" &  vbcrlf
Result = NewResult & Result
      '   END FORMULA; PROP ID:1134; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_TOTAL_DEBUG", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Code() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Code").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1068; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1068; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Project_Code", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Identifier() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Identifier").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1070; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:1070; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Project_Identifier", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1069; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1069; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Project_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_City_State() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_City_State").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3566; TYPE:PF
      result = ""
Const SearchElement As String = "city, state"
Const SearchVVList As String = "PRD_Generic_KeyValue_List_Distinct_VV"

'If Element = "customer/prd information" Or Element = "prd name" Or Element = "customer/prd information" Or Element = "prd name" _
'Or Element = "proposal" Or Element = "city, state" Or Element = "description" Then

For Each s As String In Me.ValidValues(SearchVVList).Keys
	'Dim s As String = vv.Value
	If s.ToLower().Trim().split("|")(0) = SearchElement Then
		Result = s.split("|")(1)
	End If
Next
      '   END FORMULA; PROP ID:3566; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Proposal_City_State", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_Customer_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_Customer_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3568; TYPE:PF
      result = ""
Const SearchElement As String = "customer/prd information"
Const SearchVVList As String = "PRD_Generic_KeyValue_List_Distinct_VV"

'If Element = "customer/prd information" Or Element = "prd name" Or Element = "customer/prd information" Or Element = "prd name" _
'Or Element = "proposal" Or Element = "city, state" Or Element = "description" Then

For Each s As String In Me.ValidValues(SearchVVList).Keys
	'Dim s As String = vv.Value
	If s.ToLower().Trim().split("|")(0) = SearchElement Then
		Result = s.split("|")(1)
	End If
Next
      '   END FORMULA; PROP ID:3568; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Proposal_Customer_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_Customer_Number() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_Customer_Number").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3569; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:3569; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Proposal_Customer_Number", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_Description() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_Description").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3567; TYPE:PF
      result = ""
Const SearchElement As String = "description"
Const SearchVVList As String = "PRD_Generic_KeyValue_List_Distinct_VV"

'If Element = "customer/prd information" Or Element = "prd name" Or Element = "customer/prd information" Or Element = "prd name" _
'Or Element = "proposal" Or Element = "city, state" Or Element = "description" Then

For Each s As String In Me.ValidValues(SearchVVList).Keys
	'Dim s As String = vv.Value
	If s.ToLower().Trim().split("|")(0) = SearchElement Then
		Result = s.split("|")(1)
	End If
Next
      '   END FORMULA; PROP ID:3567; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Proposal_Description", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3564; TYPE:PF
      result = ""
Const SearchElement As String = "prd name"
Const SearchVVList As String = "PRD_Generic_KeyValue_List_Distinct_VV"

'If Element = "customer/prd information" Or Element = "prd name" Or Element = "customer/prd information" Or Element = "prd name" _
'Or Element = "proposal" Or Element = "city, state" Or Element = "description" Then

For Each s As String In Me.ValidValues(SearchVVList).Keys
	'Dim s As String = vv.Value
	If s.ToLower().Trim().split("|")(0) = SearchElement Then
		Result = s.split("|")(1)
	End If
Next
      '   END FORMULA; PROP ID:3564; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Proposal_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3565; TYPE:PF
      result = ""
Const SearchElement As String = "proposal"
Const SearchVVList As String = "PRD_Generic_KeyValue_List_Distinct_VV"

'If Element = "customer/prd information" Or Element = "prd name" Or Element = "customer/prd information" Or Element = "prd name" _
'Or Element = "proposal" Or Element = "city, state" Or Element = "description" Then

For Each s As String In Me.ValidValues(SearchVVList).Keys
	'Dim s As String = vv.Value
	If s.ToLower().Trim().split("|")(0) = SearchElement Then
		Result = s.split("|")(1)
	End If
Next
      '   END FORMULA; PROP ID:3565; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Proposal_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Use_PRD_Total_Text() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Use_PRD_Total_Text").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1135; TYPE:PF
      result = true
      '   END FORMULA; PROP ID:1135; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Use_PRD_Total_Text", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Debug_1_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Opportunity_Data_Source_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_ASRS_VV_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_Electrical_VV_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_HCAD_Metric_VV_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_HCAD_VV_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_NON_STD_VV_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Data_Entered_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Date_Contract_Award_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Date_Eng_InHouse_Start_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Generic_KeyValue_List_Distinct_VV_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Generic_Product_List_Distinct_VV_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Input_Text_Tab_Formatted_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Lines_Distinct_VV_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_TOTAL_DEBUG_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Code_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Identifier_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_City_State_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Customer_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Customer_Number_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Description_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Use_PRD_Total_Text_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Debug_1_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Opportunity_Data_Source_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_ASRS_VV_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_Electrical_VV_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_HCAD_Metric_VV_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_HCAD_VV_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_NON_STD_VV_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Data_Entered_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Date_Contract_Award_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Date_Eng_InHouse_Start_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Generic_KeyValue_List_Distinct_VV_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Generic_Product_List_Distinct_VV_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Input_Text_Tab_Formatted_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("PRD_Input_Text_Tab_Formatted").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:1067; TYPE:UC
              Result = Me.Use_PRD_Total_Text
              '   END FORMULA; PROP ID:1067; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Input_Text_Tab_Formatted_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Lines_Distinct_VV_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_TOTAL_DEBUG_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Code_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Identifier_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Name_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_City_State_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Customer_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Customer_Number_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Description_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_ID_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Use_PRD_Total_Text_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Debug_1_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Debug_1").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1141; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_Freight_Product_Generic_List]", "[Product_Name]", "[Product_Name]", " ORDER BY [Product_Name]")
      '   END FORMULA; PROP ID:1141; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Debug_1_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Opportunity_Data_Source_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Opportunity_Data_Source_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1223; TYPE:VV
      Result = MakeValidValues(Array("Please Select", "Manual", "Salesforce PRD"))
      '   END FORMULA; PROP ID:1223; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Opportunity_Data_Source_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_ASRS_VV_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Conveyor_ASRS_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4121; TYPE:VV
      Result = New ValidValues()

If True And Me.Use_PRD_Total_Text Then
	Result = New ValidValues()
	Dim lines() As String = Me.PRD_Input_Text_Tab_Formatted.Split(New String() {vbCrLf}, StringSplitOptions.None)
	Dim StartProd As Boolean = False
	Dim EndProd As Boolean = False
	
	Dim linecount As Integer = 0
	For Each line As String In lines
		linecount += 1
		Dim linemarker As String = right($"0000{linecount}",4)
		Dim elements() As String = line.Split(New String() {vbTab}, StringSplitOptions.None)
		If elements.length >= 1 Then
			If elements(0).trim().ToUpper().Contains("AS/RS HARDWARE") And linecount > 94 Then
				StartProd = True
			End If
			If StartProd AndAlso elements(0).trim().ToUpper().Contains("TOTAL") Then
				EndProd = True
			End If
			
			If StartProd And Not EndProd Then
				If elements(0).trim().length > 1 And elements(1).trim().length > 1 Then
    				If elements(0).trim().tolower() <> "name" And elements(1).trim().tolower() <> "task code" Then
        				Dim VVText As String = $"{linemarker}|{elements(0)}|{elements(1)}|{elements(2)}|{elements(3)}|{elements(4)}|{elements(5)}|{elements(6)}"
        				Result.Add(VVText)
    				End If
				End If
			End If
		End If
	Next line
End If
      '   END FORMULA; PROP ID:4121; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_ASRS_VV_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_Electrical_VV_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Conveyor_Electrical_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4111; TYPE:VV
      Result = New ValidValues()

If True And Me.Use_PRD_Total_Text Then
	Result = New ValidValues()
	Dim lines() As String = Me.PRD_Input_Text_Tab_Formatted.Split(New String() {vbCrLf}, StringSplitOptions.None)
	Dim StartProd As Boolean = False
	Dim EndProd As Boolean = False
	
	Dim linecount As Integer = 0
	For Each line As String In lines
		linecount += 1
		Dim linemarker As String = right($"0000{linecount}",4)
		Dim elements() As String = line.Split(New String() {vbTab}, StringSplitOptions.None)
		If elements.length >= 1 Then
			If elements(0).trim().ToUpper().Contains("CONVEYOR ELECTRICAL BUYOUTS") Then
				StartProd = True
			End If
			If StartProd AndAlso elements(0).trim().ToUpper().Contains("TOTAL") Then
				EndProd = True
			End If
			
			If StartProd And Not EndProd Then
				If elements(0).trim().length > 1 And elements(1).trim().length > 1 Then
    				If elements(0).trim().tolower() <> "name" And elements(1).trim().tolower() <> "task code" Then
        				Dim VVText As String = $"{linemarker}|{elements(0)}|{elements(1)}|{elements(2)}|{elements(3)}|{elements(4)}|{elements(5)}|{elements(6)}"
        				Result.Add(VVText)
    				End If
				End If
			End If
		End If
	Next line
End If
      '   END FORMULA; PROP ID:4111; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_Electrical_VV_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_HCAD_Metric_VV_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Conveyor_HCAD_Metric_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4120; TYPE:VV
      Result = New ValidValues()

If True And Me.Use_PRD_Total_Text Then
	Result = New ValidValues()
	Dim lines() As String = Me.PRD_Input_Text_Tab_Formatted.Split(New String() {vbCrLf}, StringSplitOptions.None)
	Dim StartProd As Boolean = False
	Dim EndProd As Boolean = False
	
	Dim linecount As Integer = 0
	For Each line As String In lines
		linecount += 1
		Dim linemarker As String = right($"0000{linecount}",4)
		Dim elements() As String = line.Split(New String() {vbTab}, StringSplitOptions.None)
		If elements.length >= 1 Then
			If elements(0).trim().ToUpper().Contains("CASE CONVEYOR - METRIC HCAD") Then
				StartProd = True
			End If
			If StartProd AndAlso elements(0).trim().ToUpper().Contains("TOTAL") Then
				EndProd = True
			End If
			
			If StartProd And Not EndProd Then
				If elements(0).trim().length > 1 And elements(1).trim().length > 1 Then
    				If elements(0).trim().tolower() <> "name" And elements(1).trim().tolower() <> "task code" Then
        				Dim VVText As String = $"{linemarker}|{elements(0)}|{elements(1)}|{elements(2)}|{elements(3)}|{elements(4)}|{elements(5)}|{elements(6)}"
        				Result.Add(VVText)
    				End If
				End If
			End If
		End If
	Next line
End If
      '   END FORMULA; PROP ID:4120; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_HCAD_Metric_VV_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_HCAD_VV_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Conveyor_HCAD_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4016; TYPE:VV
      Result = New ValidValues()

If True And Me.Use_PRD_Total_Text Then
	Result = New ValidValues()
	Dim lines() As String = Me.PRD_Input_Text_Tab_Formatted.Split(New String() {vbCrLf}, StringSplitOptions.None)
	Dim StartProd As Boolean = False
	Dim EndProd As Boolean = False
	
	Dim linecount As Integer = 0
	For Each line As String In lines
		linecount += 1
		Dim linemarker As String = right($"0000{linecount}",4)
		Dim elements() As String = line.Split(New String() {vbTab}, StringSplitOptions.None)
		If elements.length >= 1 Then
			If elements(0).trim().ToUpper().Contains("CASE CONVEYOR - HCAD") Then
				StartProd = True
			End If
			If StartProd AndAlso elements(0).trim().ToUpper().Contains("TOTAL") Then
				EndProd = True
			End If
			
			If StartProd And Not EndProd Then
				If elements(0).trim().length > 1 And elements(1).trim().length > 1 Then
    				If elements(0).trim().tolower() <> "name" And elements(1).trim().tolower() <> "task code" Then
        				Dim VVText As String = $"{linemarker}|{elements(0)}|{elements(1)}|{elements(2)}|{elements(3)}|{elements(4)}|{elements(5)}|{elements(6)}"
        				Result.Add(VVText)
    				End If
				End If
			End If
		End If
	Next line
End If
      '   END FORMULA; PROP ID:4016; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_HCAD_VV_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_NON_STD_VV_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Conveyor_NON_STD_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4015; TYPE:VV
      Result = New ValidValues()

If True And Me.Use_PRD_Total_Text Then
	Result = New ValidValues()
	Dim lines() As String = Me.PRD_Input_Text_Tab_Formatted.Split(New String() {vbCrLf}, StringSplitOptions.None)
	Dim StartProd As Boolean = False
	Dim EndProd As Boolean = False
	
	Dim linecount As Integer = 0
	For Each line As String In lines
		linecount += 1
		Dim linemarker As String = right($"0000{linecount}",4)
		Dim elements() As String = line.Split(New String() {vbTab}, StringSplitOptions.None)
		If elements.length >= 1 Then
			If elements(0).trim().ToUpper().Contains("CASE CONVEYOR - NON STRD") Then
				StartProd = True
			End If
			If StartProd AndAlso elements(0).trim().ToUpper().Contains("TOTAL") Then
				EndProd = True
			End If
			
			If StartProd And Not EndProd Then
				If elements(0).trim().length > 1 And elements(1).trim().length > 1 Then
    				If elements(0).trim().tolower() <> "name" And elements(1).trim().tolower() <> "task code" Then
        				Dim VVText As String = $"{linemarker}|{elements(0)}|{elements(1)}|{elements(2)}|{elements(3)}|{elements(4)}|{elements(5)}|{elements(6)}"
        				Result.Add(VVText)
    				End If
				End If
			End If
		End If
	Next line
End If
      '   END FORMULA; PROP ID:4015; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_NON_STD_VV_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Generic_KeyValue_List_Distinct_VV_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Generic_KeyValue_List_Distinct_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3563; TYPE:VV
      Result = Nothing
'Valid Values to Parse Generic Key Values from PRD
Result = New ValidValues()
Dim lines() As String = Me.PRD_Input_Text_Tab_Formatted.Split(New String() {vbCrLf}, StringSplitOptions.None)
Dim StartProd As Boolean = False
Dim linecount As Integer = 0
For Each line As String In lines
	linecount += 1
	Dim linemarker As String = right($"0000{linecount}",4)
	Dim elements() As String = line.Split(New String() {vbTab}, StringSplitOptions.None)
	If elements.length > 1 Then
		Dim Element As String = elements(0).toLower().Trim()
		
		Dim ElementList As List(Of String) = New List(Of String)( {"customer/prd information","prd name","proposal","city, state","description","subsystems included","contract award","proposal due date","turnover to customer", _
				"project complete to lss", "in-house engineering start date", "manufacturing start date", "installation start date", "on-site engineering start date","in-house engineering end date", _
				"manufacturing end date", "installation end date", "on-site engineering end date", "currency"})
		
        If ElementList.Contains(Element) Then
			Dim GenValue As String = lines(linecount).trim()
			Result.Add(elements(0)& "|" & GenValue)
			
		End If
		If elements(0).trim().ToLower() = "metrics" Or elements(0).trim().ToLower() = "submit" Then
			'Done Collecting Key Values (At the Momemt)
			Exit For
	
		End If
	End If
Next line
      '   END FORMULA; PROP ID:3563; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Generic_KeyValue_List_Distinct_VV_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Generic_Product_List_Distinct_VV_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Generic_Product_List_Distinct_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1139; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_Freight_Product_Generic_List]", "[Product_Name]", "[Product_Name]", " ORDER BY [Product_Name]")
      '   END FORMULA; PROP ID:1139; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Generic_Product_List_Distinct_VV_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Lines_Distinct_VV_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Lines_Distinct_VV").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1138; TYPE:VV
      Result = New ValidValues()

If True And Me.Use_PRD_Total_Text Then
	Result = New ValidValues()
	Dim lines() As String = Me.PRD_Input_Text_Tab_Formatted.Split(New String() {vbCrLf}, StringSplitOptions.None)
	Dim StartProd As Boolean = False
	Dim linecount As Integer = 0
	For Each line As String In lines
		linecount += 1
		Dim linemarker As String = right($"0000{linecount}",4)
		Dim elements() As String = line.Split(New String() {vbTab}, StringSplitOptions.None)
		If elements.length > 1 Then
			If elements(0).trim().ToLower() = "metrics" Then
				StartProd = True
			End If
			
			If StartProd Then
				If Me.validvalues("PRD_Generic_Product_List_Distinct_VV").contains(elements(0).Trim()) Then
					Dim VVText As String = $"{linemarker}|{elements(0)}|{elements(2)}|{elements(3)}|{elements(4)}|{elements(5)}|{elements(6)}|{elements(1)}"
					Result.Add(VVText)
				End If
			End If
	End If
	Next line
End If
      '   END FORMULA; PROP ID:1138; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Lines_Distinct_VV_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_TOTAL_DEBUG_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_TOTAL_DEBUG").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1134; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_Freight_Product_Generic_List]", "[Product_Name]", "[Product_Name]", " ORDER BY [Product_Name]")
      '   END FORMULA; PROP ID:1134; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_TOTAL_DEBUG_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_ASRS_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:187; TYPE:PN
      
      '   END FORMULA; SUB ID:187; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_ASRS_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_ASRS_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PRD_Conveyor_ASRS").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:187; TYPE:QF
      Result = Me.PRD_Conveyor_ASRS_VV
      '   END FORMULA; SUB ID:187; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_ASRS_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_ASRS_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PRD_Conveyor_ASRS").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:187; TYPE:OP
      Result = "SFD_sm_PRD_Base_Item"
      '   END FORMULA; SUB ID:187; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_ASRS_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_Electrical_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:185; TYPE:PN
      
      '   END FORMULA; SUB ID:185; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_Electrical_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_Electrical_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PRD_Conveyor_Electrical").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:185; TYPE:QF
      Result = Me.PRD_Conveyor_Electrical_VV
      '   END FORMULA; SUB ID:185; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_Electrical_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_Electrical_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PRD_Conveyor_Electrical").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:185; TYPE:OP
      Result = "SFD_sm_PRD_Base_Item"
      '   END FORMULA; SUB ID:185; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_Electrical_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_HCAD_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:184; TYPE:PN
      
      '   END FORMULA; SUB ID:184; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_HCAD_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_HCAD_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PRD_Conveyor_HCAD").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:184; TYPE:QF
      Result = Me.PRD_Conveyor_HCAD_VV
      '   END FORMULA; SUB ID:184; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_HCAD_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_HCAD_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PRD_Conveyor_HCAD").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:184; TYPE:OP
      Result = "SFD_sm_PRD_Base_Item"
      '   END FORMULA; SUB ID:184; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_HCAD_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_HCAD_Metric_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:186; TYPE:PN
      
      '   END FORMULA; SUB ID:186; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_HCAD_Metric_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_HCAD_Metric_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PRD_Conveyor_HCAD_Metric").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:186; TYPE:QF
      Result = Me.PRD_Conveyor_HCAD_Metric_VV
      '   END FORMULA; SUB ID:186; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_HCAD_Metric_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_HCAD_Metric_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PRD_Conveyor_HCAD_Metric").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:186; TYPE:OP
      Result = "SFD_sm_PRD_Base_Item"
      '   END FORMULA; SUB ID:186; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_HCAD_Metric_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_NON_STD_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:183; TYPE:PN
      
      '   END FORMULA; SUB ID:183; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_NON_STD_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_NON_STD_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PRD_Conveyor_NON_STD").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:183; TYPE:QF
      Result = Me.PRD_Conveyor_NON_STD_VV
      '   END FORMULA; SUB ID:183; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_NON_STD_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Conveyor_NON_STD_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PRD_Conveyor_NON_STD").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:183; TYPE:OP
      Result = "SFD_sm_PRD_Base_Item"
      '   END FORMULA; SUB ID:183; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Conveyor_NON_STD_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Product_Lines_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:53; TYPE:PN
      
      '   END FORMULA; SUB ID:53; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Product_Lines_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Product_Lines_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PRD_Product_Lines").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:53; TYPE:QF
      Result = Me.PRD_Lines_Distinct_VV
      '   END FORMULA; SUB ID:53; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Product_Lines_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Product_Lines_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PRD_Product_Lines").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:53; TYPE:OP
      Result = "SFD_Salesforce_PRD_Product_Item"
      '   END FORMULA; SUB ID:53; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_PRD_Product_Lines_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Tool_Manager_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:193; TYPE:PN
      
      '   END FORMULA; SUB ID:193; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Project_Tool_Manager_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Tool_Manager_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Project_Tool_Manager").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:193; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:193; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Project_Tool_Manager_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Tool_Manager_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Project_Tool_Manager").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:193; TYPE:OP
      result = "IGS_Tool_Instance_Mgr"
      '   END FORMULA; SUB ID:193; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_Project_Tool_Manager_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_tmp_PRD_Base_Items_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:181; TYPE:PN
      
      '   END FORMULA; SUB ID:181; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_tmp_PRD_Base_Items_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_tmp_PRD_Base_Items_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("tmp_PRD_Base_Items").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:181; TYPE:QF
      Result = Me.PRD_Lines_Distinct_VV
      '   END FORMULA; SUB ID:181; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_tmp_PRD_Base_Items_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_tmp_PRD_Base_Items_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("tmp_PRD_Base_Items").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:181; TYPE:OP
      result = "SFD_sm_PRD_Base_Item"
      '   END FORMULA; SUB ID:181; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_PRD_Header_Mock.Formula_tmp_PRD_Base_Items_OPTIMALPARTFAMILY", ex.Message)
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

  