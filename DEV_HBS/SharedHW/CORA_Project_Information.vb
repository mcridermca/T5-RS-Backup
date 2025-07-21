Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: SharedHW
'$ PartFamily: CORA_Project_Information
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
    Imports SharedHW.swMateType_e
    Imports SharedHW.swMateAlign_e
    Imports SharedHW.severity

    Public Class [CORA_Project_Information]
    
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

    Private this as CORA_Project_Information = me

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
    
          Public Property [Account_Name]() As String
      Get
      Return Properties("Account_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Account_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Actual_Schedule_End_Date]() As String
      Get
      Return Properties("Actual_Schedule_End_Date").Value
      End Get
      Set(ByVal Value As String)
      Properties("Actual_Schedule_End_Date").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Actual_Schedule_Start_Date]() As String
      Get
      Return Properties("Actual_Schedule_Start_Date").Value
      End Get
      Set(ByVal Value As String)
      Properties("Actual_Schedule_Start_Date").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Country]() As String
      Get
      Return Properties("Country").Value
      End Get
      Set(ByVal Value As String)
      Properties("Country").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Currency_Local]() As String
      Get
      Return Properties("Currency_Local").Value
      End Get
      Set(ByVal Value As String)
      Properties("Currency_Local").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Customer_Contact_Email]() As String
      Get
      Return Properties("Customer_Contact_Email").Value
      End Get
      Set(ByVal Value As String)
      Properties("Customer_Contact_Email").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Customer_Name]() As String
      Get
      Return Properties("Customer_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Customer_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Customer_PO_Number]() As String
      Get
      Return Properties("Customer_PO_Number").Value
      End Get
      Set(ByVal Value As String)
      Properties("Customer_PO_Number").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ERP_Finish_Date]() As String
      Get
      Return Properties("ERP_Finish_Date").Value
      End Get
      Set(ByVal Value As String)
      Properties("ERP_Finish_Date").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ERP_Project_Description]() As String
      Get
      Return Properties("ERP_Project_Description").Value
      End Get
      Set(ByVal Value As String)
      Properties("ERP_Project_Description").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ERP_Project_Start_Date]() As String
      Get
      Return Properties("ERP_Project_Start_Date").Value
      End Get
      Set(ByVal Value As String)
      Properties("ERP_Project_Start_Date").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ERP_Project_Status]() As String
      Get
      Return Properties("ERP_Project_Status").Value
      End Get
      Set(ByVal Value As String)
      Properties("ERP_Project_Status").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [GBE]() As String
      Get
      Return Properties("GBE").Value
      End Get
      Set(ByVal Value As String)
      Properties("GBE").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Lead_Engineer]() As String
      Get
      Return Properties("Lead_Engineer").Value
      End Get
      Set(ByVal Value As String)
      Properties("Lead_Engineer").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LEAP_ID]() As String
      Get
      Return Properties("LEAP_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("LEAP_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LOB]() As String
      Get
      Return Properties("LOB").Value
      End Get
      Set(ByVal Value As String)
      Properties("LOB").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Pole]() As String
      Get
      Return Properties("Pole").Value
      End Get
      Set(ByVal Value As String)
      Properties("Pole").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Profit_Center]() As String
      Get
      Return Properties("Profit_Center").Value
      End Get
      Set(ByVal Value As String)
      Properties("Profit_Center").CalculatedValue = Value
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
    
          Public Property [Project_ID]() As Long
      Get
      Return Properties("Project_ID").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Project_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Manager]() As String
      Get
      Return Properties("Project_Manager").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Manager").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Manager_EID]() As String
      Get
      Return Properties("Project_Manager_EID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Manager_EID").CalculatedValue = Value
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
    
          Public Property [Project_Percentage_Complete]() As Double
      Get
      Return Properties("Project_Percentage_Complete").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Project_Percentage_Complete").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Site_Address]() As String
      Get
      Return Properties("Project_Site_Address").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Site_Address").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Site_Name]() As String
      Get
      Return Properties("Project_Site_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Site_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Status]() As String
      Get
      Return Properties("Project_Status").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Status").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Tier]() As String
      Get
      Return Properties("Project_Tier").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Tier").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Type]() As String
      Get
      Return Properties("Project_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Type_Others]() As String
      Get
      Return Properties("Project_Type_Others").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Type_Others").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Region]() As String
      Get
      Return Properties("Region").Value
      End Get
      Set(ByVal Value As String)
      Properties("Region").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Revenue_Type_Description_1]() As String
      Get
      Return Properties("Revenue_Type_Description_1").Value
      End Get
      Set(ByVal Value As String)
      Properties("Revenue_Type_Description_1").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Revenue_Type_Description_2]() As String
      Get
      Return Properties("Revenue_Type_Description_2").Value
      End Get
      Set(ByVal Value As String)
      Properties("Revenue_Type_Description_2").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Revenue_Type_Description_3]() As String
      Get
      Return Properties("Revenue_Type_Description_3").Value
      End Get
      Set(ByVal Value As String)
      Properties("Revenue_Type_Description_3").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sales_Order_Sold_To_City]() As String
      Get
      Return Properties("Sales_Order_Sold_To_City").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sales_Order_Sold_To_City").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sales_Order_Sold_To_Country]() As String
      Get
      Return Properties("Sales_Order_Sold_To_Country").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sales_Order_Sold_To_Country").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sales_Order_Sold_To_Postal_Code]() As String
      Get
      Return Properties("Sales_Order_Sold_To_Postal_Code").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sales_Order_Sold_To_Postal_Code").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sales_Order_Sold_To_Street_Address]() As String
      Get
      Return Properties("Sales_Order_Sold_To_Street_Address").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sales_Order_Sold_To_Street_Address").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sales_Rep]() As String
      Get
      Return Properties("Sales_Rep").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sales_Rep").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sales_Rep_EID]() As String
      Get
      Return Properties("Sales_Rep_EID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sales_Rep_EID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SBG]() As String
      Get
      Return Properties("SBG").Value
      End Get
      Set(ByVal Value As String)
      Properties("SBG").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SBU]() As String
      Get
      Return Properties("SBU").Value
      End Get
      Set(ByVal Value As String)
      Properties("SBU").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SFDC_Opportunity_ID]() As String
      Get
      Return Properties("SFDC_Opportunity_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("SFDC_Opportunity_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ship_To_Customer_Name]() As String
      Get
      Return Properties("Ship_To_Customer_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Ship_To_Customer_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ship_To_Customer_Number]() As String
      Get
      Return Properties("Ship_To_Customer_Number").Value
      End Get
      Set(ByVal Value As String)
      Properties("Ship_To_Customer_Number").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Solution]() As String
      Get
      Return Properties("Solution").Value
      End Get
      Set(ByVal Value As String)
      Properties("Solution").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Stage]() As String
      Get
      Return Properties("Stage").Value
      End Get
      Set(ByVal Value As String)
      Properties("Stage").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SubLOB]() As String
      Get
      Return Properties("SubLOB").Value
      End Get
      Set(ByVal Value As String)
      Properties("SubLOB").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Info_From_CORA]() As String
      Get
      Return Properties("Info_From_CORA").Value
      End Get
      Set(ByVal Value As String)
      Properties("Info_From_CORA").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [RSXLI_PLI_Search_Data_ID]() As String
      Get
      Return Properties("RSXLI_PLI_Search_Data_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("RSXLI_PLI_Search_Data_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [_DataSharingMode]() As String
      Get
      Return Properties("_DataSharingMode").Value
      End Get
      Set(ByVal Value As String)
      Properties("_DataSharingMode").CalculatedValue = Value
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
    InitPart("CORA_Project_Information", <a><![CDATA[CORA Project Information]]></a>.Value, 19, "SharedHW",  "N", "N", True, False, "In Development", "", "A shared location for information imported from CORA.", "", "", "",  "GLOBAL\H601422", "07/16/2025 19:49:53")
    AddProperty("670", "Account_Name", <a><![CDATA[Account Name]]></a>.Value, "The name of the account associated with this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "5/6/2025 10:17:10 PM")
    AddProperty("227", "Actual_Schedule_End_Date", <a><![CDATA[Actual Schedule End Date]]></a>.Value, "The actual end date of the schedule.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:44:25 PM")
    AddProperty("226", "Actual_Schedule_Start_Date", <a><![CDATA[Actual Schedule Start Date]]></a>.Value, "The actual start date of the schedule.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:38:57 PM")
    AddProperty("218", "Country", <a><![CDATA[Country]]></a>.Value, "The country for the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Country", "GLOBAL\H601422", "6/30/2025 9:03:01 AM")
    AddProperty("672", "Currency_Local", <a><![CDATA[Currency - Local]]></a>.Value, "The local currency for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "5/6/2025 10:18:17 PM")
    AddProperty("232", "Customer_Contact_Email", <a><![CDATA[Customer Contact Email]]></a>.Value, "The contact email for the customer for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:50:58 PM")
    AddProperty("231", "Customer_Name", <a><![CDATA[Customer Name]]></a>.Value, "The name of the customer for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:50:15 PM")
    AddProperty("233", "Customer_PO_Number", <a><![CDATA[Customer PO Number]]></a>.Value, "The PO number of the customer for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:51:40 PM")
    AddProperty("225", "ERP_Finish_Date", <a><![CDATA[ERP Finish Date]]></a>.Value, "The finish date of the ERP project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:37:35 PM")
    AddProperty("230", "ERP_Project_Description", <a><![CDATA[ERP Project Description]]></a>.Value, "The description of the ERP project - mappped to the Project_Name in HBS.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Project_Name", "GLOBAL\H601422", "6/30/2025 8:46:48 AM")
    AddProperty("224", "ERP_Project_Start_Date", <a><![CDATA[ERP Project Start Date]]></a>.Value, "The start date of the ERP project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:37:01 PM")
    AddProperty("221", "ERP_Project_Status", <a><![CDATA[ERP Project Status]]></a>.Value, "The status of the ERP project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:35:08 PM")
    AddProperty("213", "GBE", <a><![CDATA[GBE]]></a>.Value, "The GBE.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:25:35 PM")
    AddProperty("242", "Lead_Engineer", <a><![CDATA[Lead Engineer]]></a>.Value, "The lead engineer of this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 1:01:48 PM")
    AddProperty("240", "LEAP_ID", <a><![CDATA[LEAP ID]]></a>.Value, "The LEAP ID for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 1:00:45 PM")
    AddProperty("214", "LOB", <a><![CDATA[LOB]]></a>.Value, "The LOB.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "5/6/2025 10:13:15 PM")
    AddProperty("216", "Pole", <a><![CDATA[Pole]]></a>.Value, "A super-region of sorts.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Pole", "GLOBAL\H601422", "6/30/2025 8:56:35 AM")
    AddProperty("219", "Profit_Center", <a><![CDATA[Profit Center]]></a>.Value, "The profit center for the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:33:00 PM")
    AddProperty("208", "Project_Code", <a><![CDATA[Project Code]]></a>.Value, "The identifying code of the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Project_Number", "GLOBAL\H601422", "6/30/2025 8:45:12 AM")
    AddProperty("210", "Project_ID", <a><![CDATA[Project ID]]></a>.Value, "The ID of the project. It is not editable once it has been selected and the model saved.", "Long","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "5/6/2025 10:15:45 PM")
    AddProperty("243", "Project_Manager", <a><![CDATA[Project Manager]]></a>.Value, "The project manager for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Honeywell_PM", "GLOBAL\H601422", "6/30/2025 8:58:40 AM")
    AddProperty("675", "Project_Manager_EID", <a><![CDATA[Project Manager EID]]></a>.Value, "The EID of the project manager.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Honeywell_PM_EID", "GLOBAL\H601422", "6/30/2025 8:58:55 AM")
    AddProperty("209", "Project_Name", <a><![CDATA[Project Name]]></a>.Value, "The name of the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "5/6/2025 10:12:12 PM")
    AddProperty("228", "Project_Percentage_Complete", <a><![CDATA[Project Percentage Complete]]></a>.Value, "The percentage completion of the project.", "Double","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:46:19 PM")
    AddProperty("674", "Project_Site_Address", <a><![CDATA[Project Site Address]]></a>.Value, "The address, city/state, and PIN of the site of the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "5/6/2025 10:21:08 PM")
    AddProperty("673", "Project_Site_Name", <a><![CDATA[Project Site Name]]></a>.Value, "The name of the site of the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "5/6/2025 10:20:41 PM")
    AddProperty("220", "Project_Status", <a><![CDATA[Project Status]]></a>.Value, "The current status of the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "5/6/2025 10:16:27 PM")
    AddProperty("241", "Project_Tier", <a><![CDATA[Project Tier]]></a>.Value, "The tier of this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 1:01:20 PM")
    AddProperty("222", "Project_Type", <a><![CDATA[Project Type]]></a>.Value, "The type of project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Project_Type", "GLOBAL\H601422", "6/30/2025 9:02:30 AM")
    AddProperty("678", "Project_Type_Others", <a><![CDATA[Project Type Others]]></a>.Value, "If Others is selected as the Project Type, then this field will contain the details.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "5/6/2025 10:24:33 PM")
    AddProperty("217", "Region", <a><![CDATA[Region]]></a>.Value, "The local region.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Region", "GLOBAL\H601422", "6/30/2025 9:02:43 AM")
    AddProperty("244", "Revenue_Type_Description_1", <a><![CDATA[Revenue Type Description 1]]></a>.Value, "The first description of the revenue type.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 1:03:02 PM")
    AddProperty("245", "Revenue_Type_Description_2", <a><![CDATA[Revenue Type Description 2]]></a>.Value, "The second description of the revenue type.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 1:03:34 PM")
    AddProperty("246", "Revenue_Type_Description_3", <a><![CDATA[Revenue Type Description 3]]></a>.Value, "The third description of the revenue type.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 1:04:00 PM")
    AddProperty("237", "Sales_Order_Sold_To_City", <a><![CDATA[Sales Order Sold to City]]></a>.Value, "The sold-to city of the sales order for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:58:31 PM")
    AddProperty("238", "Sales_Order_Sold_To_Country", <a><![CDATA[Sales Order Sold to Country]]></a>.Value, "The sold-to country of the sales order for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:59:23 PM")
    AddProperty("239", "Sales_Order_Sold_To_Postal_Code", <a><![CDATA[Sales Order Sold to Postal Code]]></a>.Value, "The sold-to postal code of the sales order for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 1:00:03 PM")
    AddProperty("236", "Sales_Order_Sold_To_Street_Address", <a><![CDATA[Sales Order Sold to Street Address]]></a>.Value, "The sold-to street address of the sales order for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:58:23 PM")
    AddProperty("677", "Sales_Rep", <a><![CDATA[Sales Rep]]></a>.Value, "The sales rep for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "5/6/2025 10:22:39 PM")
    AddProperty("676", "Sales_Rep_EID", <a><![CDATA[Sales Rep EID]]></a>.Value, "The EID of the sales rep.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "5/6/2025 10:22:14 PM")
    AddProperty("212", "SBG", <a><![CDATA[SBG]]></a>.Value, "The SBG.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:24:59 PM")
    AddProperty("211", "SBU", <a><![CDATA[SBU]]></a>.Value, "The SBU.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:24:26 PM")
    AddProperty("229", "SFDC_Opportunity_ID", <a><![CDATA[SFDC Opportunity ID]]></a>.Value, "The ID of the SFDC opportunity.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "SFDC_Opportunity_ID", "GLOBAL\H601422", "6/30/2025 8:52:58 AM")
    AddProperty("234", "Ship_To_Customer_Name", <a><![CDATA[Ship to Customer Name]]></a>.Value, "The ship-to name of the customer for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:52:30 PM")
    AddProperty("235", "Ship_To_Customer_Number", <a><![CDATA[Ship to Customer Number]]></a>.Value, "The ship-to number of the customer for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:53:12 PM")
    AddProperty("671", "Solution", <a><![CDATA[Solution]]></a>.Value, "The solution associated with this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "5/6/2025 10:17:40 PM")
    AddProperty("223", "Stage", <a><![CDATA[Stage]]></a>.Value, "The current stage of the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "3/17/2025 12:36:14 PM")
    AddProperty("215", "SubLOB", <a><![CDATA[Sub-LOB]]></a>.Value, "The Sub-LOB.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Vertical", "GLOBAL\H601422", "6/30/2025 9:04:14 AM")
    AddProperty("667", "Info_From_CORA", <a><![CDATA[Info From CORA?]]></a>.Value, "Should the information be from CORA or manual entry?", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("1248", "RSXLI_PLI_Search_Data_ID", <a><![CDATA[RSXLI_PLI_Search_Data_ID]]></a>.Value, "Concatenation of the Project_ID & ""_"" & LineItemID", "String","","RSXLI_Control","FD", 9999, "", 0,0, "HBS", "RSXLI_PLI_Search_Data_ID", "GLOBAL\H601422", "7/1/2025 1:53:12 AM")
    AddProperty("1221", "_DataSharingMode", <a><![CDATA[_DataSharingMode]]></a>.Value, "Denote that any existing row for the given Project_ID and LineItem_ID would be deleted before new values are written to the OutputTable entry for this PartFamily.", "String","","SolidWorks","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\H601422", "6/30/2025 6:42:10 PM")
    AddProperty("207", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601423", "3/17/2025 11:44:55 AM")
    
      AddValidValue("ERP_Project_Description")
    
      AddValidValue("Pole")
    
      AddValidValue("Project_Code")
    
      AddValidValue("Info_From_CORA")
    
      AddDBConstraint(3, "db_vw_CORA_Project_Info", <a><![CDATA[DB: vw_CORA_Project_Info]]></a>.Value,"Database Lookup", 9999)
    
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
          InitProperty("Account_Name", "625", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:17:10 PM", "", "In Development",  0,1475)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Actual_Schedule_End_Date", "208", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:44:25 PM", "", "In Development",  0,472)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Actual_Schedule_Start_Date", "207", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:38:57 PM", "", "In Development",  0,471)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Country", "199", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:31:02 PM", "", "In Development",  0,461)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Currency_Local", "627", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:18:17 PM", "", "In Development",  0,1479)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_Contact_Email", "213", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:50:58 PM", "", "In Development",  0,477)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_Name", "212", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:49:04 PM", "", "In Development",  0,476)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_PO_Number", "214", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:51:40 PM", "", "In Development",  0,478)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ERP_Finish_Date", "206", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:37:35 PM", "", "In Development",  0,470)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ERP_Project_Description", "211", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601422", "4/24/2025 5:52:08 PM", "", "In Development",  0,475)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ERP_Project_Start_Date", "205", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:37:01 PM", "", "In Development",  0,469)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ERP_Project_Status", "202", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:35:08 PM", "", "In Development",  0,466)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("GBE", "194", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:25:35 PM", "", "In Development",  0,456)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lead_Engineer", "223", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 1:01:48 PM", "", "In Development",  0,487)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LEAP_ID", "221", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 1:00:45 PM", "", "In Development",  0,485)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LOB", "195", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:13:15 PM", "", "In Development",  0,457)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pole", "197", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:16:03 PM", "", "In Development",  0,462)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Profit_Center", "200", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:33:00 PM", "", "In Development",  0,464)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Code", "189", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "4/23/2025 9:00:17 PM", "", "In Development",  0,451)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_ID", "191", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:15:45 PM", "", "In Development",  0,1031)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Manager", "224", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 1:02:21 PM", "", "In Development",  0,488)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Manager_EID", "630", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:21:48 PM", "", "In Development",  0,1483)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Name", "190", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:12:12 PM", "", "In Development",  0,1249)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Percentage_Complete", "209", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:46:19 PM", "", "In Development",  0,473)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Site_Address", "629", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:20:56 PM", "", "In Development",  0,1482)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Site_Name", "628", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:20:41 PM", "", "In Development",  0,1481)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Status", "201", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:16:27 PM", "", "In Development",  0,465)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Tier", "222", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 1:01:20 PM", "", "In Development",  0,486)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Type", "203", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:35:50 PM", "", "In Development",  0,467)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Type_Others", "633", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:24:33 PM", "", "In Development",  1,1486)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Region", "198", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:16:20 PM", "", "In Development",  0,460)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Revenue_Type_Description_1", "225", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 1:03:02 PM", "", "In Development",  0,489)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Revenue_Type_Description_2", "226", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 1:03:26 PM", "", "In Development",  0,490)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Revenue_Type_Description_3", "227", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 1:03:56 PM", "", "In Development",  0,491)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_City", "218", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:58:31 PM", "", "In Development",  0,482)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_Country", "219", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:59:23 PM", "", "In Development",  0,483)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_Postal_Code", "220", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 1:00:03 PM", "", "In Development",  0,484)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_Street_Address", "217", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:56:22 PM", "", "In Development",  0,481)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Rep", "632", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:22:39 PM", "", "In Development",  0,1485)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Rep_EID", "631", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:22:04 PM", "", "In Development",  0,1484)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SBG", "193", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:24:59 PM", "", "In Development",  0,455)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SBU", "192", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:24:26 PM", "", "In Development",  0,454)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SFDC_Opportunity_ID", "210", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:48:09 PM", "", "In Development",  0,474)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ship_To_Customer_Name", "215", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:52:30 PM", "", "In Development",  0,479)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ship_To_Customer_Number", "216", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:53:12 PM", "", "In Development",  0,480)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Solution", "626", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "5/6/2025 10:17:40 PM", "", "In Development",  0,1477)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Stage", "204", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:36:14 PM", "", "In Development",  0,468)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SubLOB", "196", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "3/17/2025 12:26:31 PM", "", "In Development",  0,458)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Info_From_CORA", "622", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601423", "5/6/2025 9:31:41 PM", "", "In Development",  0,1463)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("RSXLI_PLI_Search_Data_ID", "1151", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601422", "7/1/2025 1:53:12 AM", "", "In Development",  0,2199)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("_DataSharingMode", "1128", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601422", "6/30/2025 6:42:10 PM", "", "In Development",  0,2151)
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
          
        InitValidValue("ERP_Project_Description_ValidValues", "211", "-1", 1057)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Pole_ValidValues", "197", "-1", 463)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Project_Code_ValidValues", "189", "-1", 1233)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Info_From_CORA_ValidValues", "622", "-1", 1464)
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
            If Incontext("-1", ctx) Then
          
        InitDBConstraint("db_vw_CORA_Project_Info", 3,"", "Y","", "", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Actual_Schedule_End_Date",3, "Actual_Schedule_Start_Date", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Actual_Schedule_Start_Date",3, "Actual_Schedule_End_Date", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Country",3, "Country", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Customer_Contact_Email",3, "Customer_Contact_Email", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Customer_Name",3, "Customer_Name", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Customer_PO_Number",3, "Customer_PO_Number", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "ERP_Project_Description",3, "ERP_Project_Description", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "ERP_Project_Start_Date",3, "ERP_Project_Start_Date", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "ERP_Project_Status",3, "ERP_Project_Status", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "GBE",3, "GBE", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Lead_Engineer",3, "Lead_Engineer", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "LEAP_ID",3, "LEAP_ID", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "LOB",3, "LOB", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Pole",3, "Pole", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Project_Code",3, "project_no", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Project_ID",3, "Project_Id", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Project_Manager",3, "Project_Manager", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Project_Tier",3, "Project_Tier", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Region",3, "Region", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Revenue_Type_Description_1",3, "Revenue_Type_Description_1", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Revenue_Type_Description_2",3, "Revenue_Type_Description_2", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Revenue_Type_Description_3",3, "Revenue_Type_Description_3", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Sales_Order_Sold_To_City",3, "Sales_Order_Sold_To_City", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Sales_Order_Sold_To_Country",3, "Sales_Order_Ship_To_Country", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Sales_Order_Sold_To_Postal_Code",3, "Sales_Order_Ship_To_Postal_Code", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Sales_Order_Sold_To_Street_Address",3, "Sales_Order_Ship_To_Street_Address", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "SBG",3, "SBG", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "SBU",3, "SBU", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "SFDC_Opportunity_ID",3, "SFDC_Opportunity_ID", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "Stage",3, "Stage", "vw_CORA_Project_Data")
        
          InitDBproperty("db_vw_CORA_Project_Info", "SubLOB",3, "Sub-LOB", "vw_CORA_Project_Data")
        
          End If
        
    End Sub

    #End Region

    #Region " Formulas "

    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Account_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Account_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:625; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:625; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Account_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Actual_Schedule_End_Date() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Actual_Schedule_End_Date").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:208; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:208; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Actual_Schedule_End_Date", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Actual_Schedule_Start_Date() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Actual_Schedule_Start_Date").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:207; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:207; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Actual_Schedule_Start_Date", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Country() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Country").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:199; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:199; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Country", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Currency_Local() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Currency_Local").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:627; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:627; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Currency_Local", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Customer_Contact_Email() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Customer_Contact_Email").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:213; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:213; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Customer_Contact_Email", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Customer_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Customer_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:212; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:212; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Customer_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Customer_PO_Number() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Customer_PO_Number").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:214; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:214; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Customer_PO_Number", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ERP_Finish_Date() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ERP_Finish_Date").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:206; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:206; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_ERP_Finish_Date", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ERP_Project_Description() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ERP_Project_Description").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:211; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:211; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_ERP_Project_Description", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ERP_Project_Start_Date() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ERP_Project_Start_Date").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:205; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:205; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_ERP_Project_Start_Date", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ERP_Project_Status() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ERP_Project_Status").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:202; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:202; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_ERP_Project_Status", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_GBE() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("GBE").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:194; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:194; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_GBE", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Lead_Engineer() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Lead_Engineer").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:223; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:223; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Lead_Engineer", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LEAP_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LEAP_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:221; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:221; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_LEAP_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LOB() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LOB").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:195; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:195; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_LOB", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Pole() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Pole").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:197; TYPE:PF
      Result = Me.ValidValues("Pole").FirstValue
'Default to first of the ValidValues.
      '   END FORMULA; PROP ID:197; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Pole", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Profit_Center() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Profit_Center").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:200; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:200; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Profit_Center", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:189; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:189; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Code", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_ID() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:191; TYPE:PF
      Result = 0
'Me.ValidValues("Project_ID").FirstValue
      '   END FORMULA; PROP ID:191; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Manager() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Manager").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:224; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:224; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Manager", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Manager_EID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Manager_EID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:630; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:630; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Manager_EID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:190; TYPE:PF
      Result = String.Format($"{me.Project_Code} {me.ERP_Project_Description}")
      '   END FORMULA; PROP ID:190; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Percentage_Complete() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Percentage_Complete").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:209; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:209; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Percentage_Complete", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Site_Address() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Site_Address").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:629; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:629; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Site_Address", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Site_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Site_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:628; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:628; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Site_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Status() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Status").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:201; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:201; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Status", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Tier() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Tier").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:222; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:222; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Tier", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:203; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:203; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Type_Others() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Type_Others").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:633; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:633; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Type_Others", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Region() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Region").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:198; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:198; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Region", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Revenue_Type_Description_1() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Revenue_Type_Description_1").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:225; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:225; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Revenue_Type_Description_1", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Revenue_Type_Description_2() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Revenue_Type_Description_2").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:226; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:226; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Revenue_Type_Description_2", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Revenue_Type_Description_3() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Revenue_Type_Description_3").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:227; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:227; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Revenue_Type_Description_3", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sales_Order_Sold_To_City() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sales_Order_Sold_To_City").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:218; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:218; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Sales_Order_Sold_To_City", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sales_Order_Sold_To_Country() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sales_Order_Sold_To_Country").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:219; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:219; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Sales_Order_Sold_To_Country", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sales_Order_Sold_To_Postal_Code() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sales_Order_Sold_To_Postal_Code").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:220; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:220; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Sales_Order_Sold_To_Postal_Code", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sales_Order_Sold_To_Street_Address() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sales_Order_Sold_To_Street_Address").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:217; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:217; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Sales_Order_Sold_To_Street_Address", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sales_Rep() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sales_Rep").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:632; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:632; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Sales_Rep", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sales_Rep_EID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sales_Rep_EID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:631; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:631; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Sales_Rep_EID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SBG() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SBG").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:193; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:193; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_SBG", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SBU() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SBU").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:192; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:192; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_SBU", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SFDC_Opportunity_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SFDC_Opportunity_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:210; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:210; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_SFDC_Opportunity_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ship_To_Customer_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ship_To_Customer_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:215; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:215; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Ship_To_Customer_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ship_To_Customer_Number() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ship_To_Customer_Number").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:216; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:216; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Ship_To_Customer_Number", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Solution() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Solution").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:626; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:626; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Solution", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Stage() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Stage").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:204; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:204; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Stage", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SubLOB() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SubLOB").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:196; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:196; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_SubLOB", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Info_From_CORA() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Info_From_CORA").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:622; TYPE:PF
      Result = "Select from CORA"
      '   END FORMULA; PROP ID:622; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Info_From_CORA", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_RSXLI_PLI_Search_Data_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("RSXLI_PLI_Search_Data_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1151; TYPE:PF
      Result = Rootpart.ProjectID & "_" & Rootpart.LineItem.ToString
      '   END FORMULA; PROP ID:1151; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_RSXLI_PLI_Search_Data_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula__DataSharingMode() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("_DataSharingMode").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1128; TYPE:PF
      Result = "DELETE"
      '   END FORMULA; PROP ID:1128; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula__DataSharingMode", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Account_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Actual_Schedule_End_Date_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Actual_Schedule_Start_Date_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Country_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Currency_Local_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Contact_Email_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_PO_Number_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ERP_Finish_Date_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ERP_Project_Description_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ERP_Project_Start_Date_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ERP_Project_Status_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_GBE_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lead_Engineer_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LEAP_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LOB_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pole_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Profit_Center_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Project_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Manager_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Manager_EID_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Project_Percentage_Complete_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Site_Address_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Site_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Status_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Tier_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Type_Others_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Region_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Revenue_Type_Description_1_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Revenue_Type_Description_2_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Revenue_Type_Description_3_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Sold_To_City_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Sold_To_Country_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Sold_To_Postal_Code_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Sold_To_Street_Address_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Rep_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Rep_EID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SBG_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SBU_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SFDC_Opportunity_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ship_To_Customer_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ship_To_Customer_Number_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Solution_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Stage_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SubLOB_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Info_From_CORA_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RSXLI_PLI_Search_Data_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula__DataSharingMode_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Account_Name_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Account_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:625; TYPE:UC
              Result = False

If (Me.Info_From_CORA = "Manual Entry") Then
	Result = True
End If
              '   END FORMULA; PROP ID:625; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Account_Name_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Actual_Schedule_End_Date_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Actual_Schedule_Start_Date_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Country_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Currency_Local_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Currency_Local").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:627; TYPE:UC
              Result = False

If (Me.Info_From_CORA = "Manual Entry") Then
	Result = True
End If
              '   END FORMULA; PROP ID:627; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Currency_Local_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Contact_Email_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_PO_Number_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ERP_Finish_Date_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ERP_Project_Description_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("ERP_Project_Description").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:211; TYPE:UC
              Result = False
              '   END FORMULA; PROP ID:211; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_ERP_Project_Description_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ERP_Project_Start_Date_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ERP_Project_Status_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_GBE_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lead_Engineer_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LEAP_ID_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LOB_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("LOB").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:195; TYPE:UC
              Result = False

If (Me.Info_From_CORA = "Manual Entry") Then
	Result = True
End If
              '   END FORMULA; PROP ID:195; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_LOB_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pole_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Pole").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:197; TYPE:UC
              Result = False

If (Me.Info_From_CORA = "Manual Entry") Then
	Result = True
End If
              '   END FORMULA; PROP ID:197; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Pole_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Profit_Center_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Code_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Project_Code").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:189; TYPE:UC
              Result = Not(RootPart.CORAInfoSaved)
              '   END FORMULA; PROP ID:189; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Code_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Manager_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Manager_EID_USERCHANGE() as Boolean
      Return True
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
      Public Function Formula_Project_Percentage_Complete_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Site_Address_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Site_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Status_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Project_Status").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:201; TYPE:UC
              Result = False

If (Me.Info_From_CORA = "Manual Entry") Then
	Result = True
End If
              '   END FORMULA; PROP ID:201; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Status_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Tier_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Type_Others_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Project_Type_Others").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:633; TYPE:UC
              Result = False

If (Me.Project_Type = "Others") Then
	Result = True
End If
              '   END FORMULA; PROP ID:633; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Type_Others_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Region_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Region").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:198; TYPE:UC
              Result = False

If (Me.Info_From_CORA = "Manual Entry") Then
	Result = True
End If
              '   END FORMULA; PROP ID:198; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Region_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Revenue_Type_Description_1_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Revenue_Type_Description_2_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Revenue_Type_Description_3_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Sold_To_City_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Sold_To_Country_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Sold_To_Postal_Code_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Sold_To_Street_Address_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Rep_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Rep_EID_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SBG_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SBU_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SFDC_Opportunity_ID_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ship_To_Customer_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ship_To_Customer_Number_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Solution_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Solution").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:626; TYPE:UC
              Result = False

If (Me.Info_From_CORA = "Manual Entry") Then
	Result = True
End If
              '   END FORMULA; PROP ID:626; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Solution_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Stage_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SubLOB_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Info_From_CORA_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RSXLI_PLI_Search_Data_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula__DataSharingMode_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ERP_Project_Description_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ERP_Project_Description").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:211; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_CORA_Project_Data]", "[ERP_Project_Description]", "[ERP_Project_Description]", " ORDER BY [ERP_Project_Description]")
'Used for DB spec WHERE statement.
      '   END FORMULA; PROP ID:211; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_ERP_Project_Description_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pole_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Pole").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:197; TYPE:VV
      Result = MakeValidValues(Array("Americas"))
      '   END FORMULA; PROP ID:197; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Pole_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Code_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Code").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:189; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_CORA_Project_Data]", "[Project_No]", "[Project_No]", " ORDER BY [Project_No]")
'Used for DB spec WHERE statement.
      '   END FORMULA; PROP ID:189; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Project_Code_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Info_From_CORA_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Info_From_CORA").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:622; TYPE:VV
      Result = MakeValidValues(Array("Select from CORA", "Manual Entry"))
      '   END FORMULA; PROP ID:622; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.Formula_Info_From_CORA_ValidValues", ex.Message)
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
    
      Dim strWhereClause as String = ""
      Dim strSelectList as String = ""
      Dim varPropSpecVal As Object
      Dim ctx As Object
      Dim leftDelimiter As String = String.Empty
      Dim rightDelimiter As String = String.Empty
      Try
      Select Case g_rsUser.UserSettings.ActiveProfile.ComponentsDatabaseType
      Case RuleStream.DataService.PublicEnumerations.DatabaseTypes.MSAccess, RuleStream.DataService.PublicEnumerations.DatabaseTypes.SQLServer
      leftDelimiter = "["
      rightDelimiter = "]"
      Case RuleStream.DataService.PublicEnumerations.DatabaseTypes.Oracle
      leftDelimiter = """"
      rightDelimiter = """"
      End Select
      ObjectManager.UnitConversion = False
      'Used to set the parameters results
      Select Case lngDBConID
      
        Case 3
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "Actual_Schedule_Start_Date" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Actual_Schedule_End_Date" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Country" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Customer_Contact_Email" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Customer_Name" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Customer_PO_Number" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "ERP_Project_Description" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "ERP_Project_Start_Date" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "ERP_Project_Status" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "GBE" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Lead_Engineer" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "LEAP_ID" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "LOB" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Pole" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "project_no" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Project_Id" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Project_Manager" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Project_Tier" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Region" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Revenue_Type_Description_1" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Revenue_Type_Description_2" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Revenue_Type_Description_3" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Sales_Order_Sold_To_City" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Sales_Order_Ship_To_Country" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Sales_Order_Ship_To_Postal_Code" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Sales_Order_Ship_To_Street_Address" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "SBG" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "SBU" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "SFDC_Opportunity_ID" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Stage" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Sub-LOB" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
                  varPropSpecVal = me.Project_Code
              BuildWhereClause(strWhereClause, "0", "0", "  ", "[project_no]", "=", varPropSpecVal, "")
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("vw_CORA_Project_Data"), strWhereClause, leftDelimiter & "" & rightDelimiter, "ASC")
          
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " CORA_Project_Information.GetRecordset", strError)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      ObjectManager.UnitConversion = True
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

  