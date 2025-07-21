Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: PLI_Information
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

    Public Class [PLI_Information]
    
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

    Private this as PLI_Information = me

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
    
          Public Property [Honeywell_Designer]() As String
      Get
      Return Properties("Honeywell_Designer").Value
      End Get
      Set(ByVal Value As String)
      Properties("Honeywell_Designer").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Project_Site_Plant]() As String
      Get
      Return Properties("Project_Site_Plant").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Site_Plant").CalculatedValue = Value
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
    InitPart("PLI_Information", <a><![CDATA[PLI Information]]></a>.Value, 101, "HBS",  "N", "N", True, False, "In Development", "", "This is a roll-up PF to hold all fields that need to be written out to the RSXLI_PLI_Search_Data Table.  It currently spans CORA_Info and Project_Info", "", "", "RSXLI_PLI_Search_Data",  "GLOBAL\H601423", "07/17/2025 11:22:43")
    AddProperty("1756", "Account_Name", <a><![CDATA[Account Name]]></a>.Value, "The name of the account associated with this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:11:18 AM")
    AddProperty("1761", "Actual_Schedule_End_Date", <a><![CDATA[Actual Schedule End Date]]></a>.Value, "The actual end date of the schedule.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:14:58 AM")
    AddProperty("1762", "Actual_Schedule_Start_Date", <a><![CDATA[Actual Schedule Start Date]]></a>.Value, "The actual start date of the schedule.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:15:10 AM")
    AddProperty("1272", "Country", <a><![CDATA[Country]]></a>.Value, "The country for the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Country", "GLOBAL\H601423", "7/17/2025 11:15:16 AM")
    AddProperty("1763", "Currency_Local", <a><![CDATA[Currency - Local]]></a>.Value, "The local currency for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:15:24 AM")
    AddProperty("1759", "Customer_Contact_Email", <a><![CDATA[Customer Contact Email]]></a>.Value, "The contact email for the customer for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:15:32 AM")
    AddProperty("1758", "Customer_Name", <a><![CDATA[Customer Name]]></a>.Value, "The name of the customer for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:15:38 AM")
    AddProperty("1757", "Customer_PO_Number", <a><![CDATA[Customer PO Number]]></a>.Value, "The PO number of the customer for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:15:47 AM")
    AddProperty("1770", "ERP_Finish_Date", <a><![CDATA[ERP Finish Date]]></a>.Value, "The finish date of the ERP project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:15:55 AM")
    AddProperty("1273", "ERP_Project_Description", <a><![CDATA[ERP Project Description]]></a>.Value, "The description of the ERP project - mappped to the Project_Name in HBS.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Project_Name", "GLOBAL\H601423", "7/17/2025 11:16:05 AM")
    AddProperty("1769", "ERP_Project_Start_Date", <a><![CDATA[ERP Project Start Date]]></a>.Value, "The start date of the ERP project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:16:33 AM")
    AddProperty("1768", "ERP_Project_Status", <a><![CDATA[ERP Project Status]]></a>.Value, "The status of the ERP project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:16:44 AM")
    AddProperty("1767", "GBE", <a><![CDATA[GBE]]></a>.Value, "The GBE.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:16:48 AM")
    AddProperty("1766", "Lead_Engineer", <a><![CDATA[Lead Engineer]]></a>.Value, "The lead engineer of this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:16:58 AM")
    AddProperty("1765", "LEAP_ID", <a><![CDATA[LEAP ID]]></a>.Value, "The LEAP ID for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:17:03 AM")
    AddProperty("1764", "LOB", <a><![CDATA[LOB]]></a>.Value, "The LOB.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:14:45 AM")
    AddProperty("1274", "Pole", <a><![CDATA[Pole]]></a>.Value, "A super-region of sorts.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Pole", "GLOBAL\H601423", "7/17/2025 11:14:39 AM")
    AddProperty("1790", "Profit_Center", <a><![CDATA[Profit Center]]></a>.Value, "The profit center for the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:14:29 AM")
    AddProperty("1275", "Project_Code", <a><![CDATA[Project Code]]></a>.Value, "The identifying code of the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Project_Number", "GLOBAL\H601423", "7/17/2025 11:14:03 AM")
    AddProperty("1794", "Project_ID", <a><![CDATA[Project ID]]></a>.Value, "The ID of the project. It is not editable once it has been selected and the model saved.", "Long","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:14:18 AM")
    AddProperty("1276", "Project_Manager", <a><![CDATA[Project Manager]]></a>.Value, "The project manager for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Honeywell_PM", "GLOBAL\H601423", "7/17/2025 11:17:33 AM")
    AddProperty("1277", "Project_Manager_EID", <a><![CDATA[Project Manager EID]]></a>.Value, "The EID of the project manager.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Honeywell_PM_EID", "GLOBAL\H601423", "7/17/2025 11:17:41 AM")
    AddProperty("1793", "Project_Name", <a><![CDATA[Project Name]]></a>.Value, "The name of the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 5:47:11 AM")
    AddProperty("1792", "Project_Percentage_Complete", <a><![CDATA[Project Percentage Complete]]></a>.Value, "The percentage completion of the project.", "Double","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:17:52 AM")
    AddProperty("1791", "Project_Site_Address", <a><![CDATA[Project Site Address]]></a>.Value, "The address, city/state, and PIN of the site of the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:18:02 AM")
    AddProperty("1789", "Project_Site_Name", <a><![CDATA[Project Site Name]]></a>.Value, "The name of the site of the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:18:12 AM")
    AddProperty("1788", "Project_Status", <a><![CDATA[Project Status]]></a>.Value, "The current status of the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:18:21 AM")
    AddProperty("1787", "Project_Tier", <a><![CDATA[Project Tier]]></a>.Value, "The tier of this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:18:27 AM")
    AddProperty("1278", "Project_Type", <a><![CDATA[Project Type]]></a>.Value, "The type of project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Project_Type", "GLOBAL\H601423", "7/17/2025 11:13:56 AM")
    AddProperty("1786", "Project_Type_Others", <a><![CDATA[Project Type Others]]></a>.Value, "If Others is selected as the Project Type, then this field will contain the details.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:18:37 AM")
    AddProperty("1279", "Region", <a><![CDATA[Region]]></a>.Value, "The local region.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Region", "GLOBAL\H601423", "7/17/2025 11:18:42 AM")
    AddProperty("1785", "Revenue_Type_Description_1", <a><![CDATA[Revenue Type Description 1]]></a>.Value, "The first description of the revenue type.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:22:43 AM")
    AddProperty("1784", "Revenue_Type_Description_2", <a><![CDATA[Revenue Type Description 2]]></a>.Value, "The second description of the revenue type.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:22:32 AM")
    AddProperty("1783", "Revenue_Type_Description_3", <a><![CDATA[Revenue Type Description 3]]></a>.Value, "The third description of the revenue type.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:22:23 AM")
    AddProperty("1782", "Sales_Order_Sold_To_City", <a><![CDATA[Sales Order Sold to City]]></a>.Value, "The sold-to city of the sales order for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:21:28 AM")
    AddProperty("1781", "Sales_Order_Sold_To_Country", <a><![CDATA[Sales Order Sold to Country]]></a>.Value, "The sold-to country of the sales order for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:22:12 AM")
    AddProperty("1780", "Sales_Order_Sold_To_Postal_Code", <a><![CDATA[Sales Order Sold to Postal Code]]></a>.Value, "The sold-to postal code of the sales order for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:21:15 AM")
    AddProperty("1779", "Sales_Order_Sold_To_Street_Address", <a><![CDATA[Sales Order Sold to Street Address]]></a>.Value, "The sold-to street address of the sales order for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:20:58 AM")
    AddProperty("1778", "Sales_Rep", <a><![CDATA[Sales Rep]]></a>.Value, "The sales rep for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:20:38 AM")
    AddProperty("1777", "Sales_Rep_EID", <a><![CDATA[Sales Rep EID]]></a>.Value, "The EID of the sales rep.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:20:46 AM")
    AddProperty("1776", "SBG", <a><![CDATA[SBG]]></a>.Value, "The SBG.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:20:30 AM")
    AddProperty("1775", "SBU", <a><![CDATA[SBU]]></a>.Value, "The SBU.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:20:25 AM")
    AddProperty("1280", "SFDC_Opportunity_ID", <a><![CDATA[SFDC Opportunity ID]]></a>.Value, "The ID of the SFDC opportunity.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "SFDC_Opportunity_ID", "GLOBAL\H601423", "7/17/2025 11:19:52 AM")
    AddProperty("1774", "Ship_To_Customer_Name", <a><![CDATA[Ship to Customer Name]]></a>.Value, "The ship-to name of the customer for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:19:43 AM")
    AddProperty("1773", "Ship_To_Customer_Number", <a><![CDATA[Ship to Customer Number]]></a>.Value, "The ship-to number of the customer for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:19:34 AM")
    AddProperty("1772", "Solution", <a><![CDATA[Solution]]></a>.Value, "The solution associated with this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:19:20 AM")
    AddProperty("1771", "Stage", <a><![CDATA[Stage]]></a>.Value, "The current stage of the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/17/2025 11:19:14 AM")
    AddProperty("1281", "SubLOB", <a><![CDATA[Sub-LOB]]></a>.Value, "The Sub-LOB.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "Vertical", "GLOBAL\H601423", "7/17/2025 11:19:09 AM")
    AddProperty("1283", "Honeywell_Designer", <a><![CDATA[Honeywell Designer]]></a>.Value, "The name of the Honeywell designer for this project.", "String","","General","FD", 9999, "", 0,0, "HBS", "Honeywell_Designer", "GLOBAL\H601422", "7/16/2025 8:15:04 PM")
    AddProperty("1282", "Project_Site_Plant", <a><![CDATA[Project Site Plant]]></a>.Value, "The site plant of the project.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601423", "7/2/2025 2:48:58 PM")
    AddProperty("1284", "RSXLI_PLI_Search_Data_ID", <a><![CDATA[RSXLI_PLI_Search_Data_ID]]></a>.Value, "Concatenation of the Project_ID & ""_"" & LineItemID", "String","","RSXLI_Control","FD", 9999, "", 0,0, "HBS", "RSXLI_PLI_Search_Data_ID", "GLOBAL\H601422", "7/16/2025 8:11:14 PM")
    AddProperty("1755", "_DataSharingMode", <a><![CDATA[_DataSharingMode]]></a>.Value, "Denote that any existing row for the given Project_ID and LineItem_ID would be deleted before new values are written to the OutputTable entry for this PartFamily.", "String","","SolidWorks","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\H601422", "7/16/2025 7:51:26 PM")
    AddProperty("1271", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601423", "7/2/2025 1:56:30 PM")
    
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
          InitProperty("Account_Name", "1622", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:11:18 AM", "", "In Development",  0,3224)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Actual_Schedule_End_Date", "1626", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:14:58 AM", "", "In Development",  0,3238)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Actual_Schedule_Start_Date", "1627", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:15:10 AM", "", "In Development",  0,3239)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Country", "1173", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:15:16 AM", "", "In Development",  0,3240)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Currency_Local", "1628", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:15:24 AM", "", "In Development",  0,3241)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_Contact_Email", "1625", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:15:32 AM", "", "In Development",  0,3242)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_Name", "1624", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:15:38 AM", "", "In Development",  0,3243)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_PO_Number", "1623", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:15:47 AM", "", "In Development",  0,3244)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ERP_Finish_Date", "1635", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:15:55 AM", "", "In Development",  0,3245)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ERP_Project_Description", "1174", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:16:05 AM", "", "In Development",  0,3246)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ERP_Project_Start_Date", "1634", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:16:33 AM", "", "In Development",  0,3247)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ERP_Project_Status", "1633", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:16:44 AM", "", "In Development",  0,3248)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("GBE", "1632", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:16:48 AM", "", "In Development",  0,3249)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Lead_Engineer", "1631", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:16:58 AM", "", "In Development",  0,3250)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LEAP_ID", "1630", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:17:03 AM", "", "In Development",  0,3251)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LOB", "1629", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:14:45 AM", "", "In Development",  0,3237)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pole", "1175", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:14:39 AM", "", "In Development",  0,3236)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Profit_Center", "1655", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:14:29 AM", "", "In Development",  0,3235)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Code", "1176", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:14:03 AM", "", "In Development",  0,3233)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_ID", "1659", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:14:18 AM", "", "In Development",  0,3234)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Manager", "1177", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:17:33 AM", "", "In Development",  0,3253)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Manager_EID", "1178", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:17:41 AM", "", "In Development",  0,3254)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Name", "1658", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 5:47:11 AM", "", "In Development",  0,3216)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Percentage_Complete", "1657", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:17:52 AM", "", "In Development",  0,3255)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Site_Address", "1656", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:18:02 AM", "", "In Development",  0,3256)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Site_Name", "1654", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:18:12 AM", "", "In Development",  0,3258)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Status", "1653", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:18:21 AM", "", "In Development",  0,3259)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Tier", "1652", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:18:27 AM", "", "In Development",  0,3260)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Type", "1179", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:13:56 AM", "", "In Development",  0,3232)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Type_Others", "1651", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:18:37 AM", "", "In Development",  0,3261)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Region", "1180", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:18:42 AM", "", "In Development",  0,3263)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Revenue_Type_Description_1", "1650", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:22:43 AM", "", "In Development",  0,3288)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Revenue_Type_Description_2", "1649", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:22:32 AM", "", "In Development",  0,3286)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Revenue_Type_Description_3", "1648", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:22:23 AM", "", "In Development",  0,3285)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_City", "1647", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:21:28 AM", "", "In Development",  0,3280)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_Country", "1646", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:22:12 AM", "", "In Development",  0,3283)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_Postal_Code", "1645", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:21:15 AM", "", "In Development",  0,3279)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_Street_Address", "1644", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:20:58 AM", "", "In Development",  0,3278)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Rep", "1643", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:20:38 AM", "", "In Development",  0,3276)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Rep_EID", "1642", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:20:46 AM", "", "In Development",  0,3277)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SBG", "1641", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:20:30 AM", "", "In Development",  0,3274)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SBU", "1640", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:20:25 AM", "", "In Development",  0,3273)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SFDC_Opportunity_ID", "1181", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:19:52 AM", "", "In Development",  0,3271)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ship_To_Customer_Name", "1639", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:19:43 AM", "", "In Development",  0,3270)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ship_To_Customer_Number", "1638", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:19:34 AM", "", "In Development",  0,3269)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Solution", "1637", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:19:20 AM", "", "In Development",  0,3266)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Stage", "1636", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:19:14 AM", "", "In Development",  0,3265)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SubLOB", "1182", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/17/2025 11:19:09 AM", "", "In Development",  0,3264)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_Designer", "1184", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/2/2025 2:48:37 PM", "", "In Development",  0,2243)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Site_Plant", "1183", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/2/2025 2:48:58 PM", "", "In Development",  0,2244)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("RSXLI_PLI_Search_Data_ID", "1185", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/2/2025 2:41:48 PM", "", "In Development",  0,2228)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("_DataSharingMode", "1621", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601422", "7/16/2025 7:51:26 PM", "", "In Development",  0,3120)
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
          Public Function Formula_Account_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Account_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1622; TYPE:PF
      Result = Rootpart.CORA_Info(1).Account_Name
      '   END FORMULA; PROP ID:1622; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Account_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1626; TYPE:PF
      Result = Rootpart.CORA_Info(1).Actual_Schedule_End_Date
      '   END FORMULA; PROP ID:1626; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Actual_Schedule_End_Date", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1627; TYPE:PF
      Result = Rootpart.CORA_Info(1).Actual_Schedule_Start_Date
      '   END FORMULA; PROP ID:1627; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Actual_Schedule_Start_Date", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1173; TYPE:PF
      Result = Rootpart.CORA_Info(1).Country
      '   END FORMULA; PROP ID:1173; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Country", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1628; TYPE:PF
      Result = Rootpart.CORA_Info(1).Currency_Local
      '   END FORMULA; PROP ID:1628; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Currency_Local", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1625; TYPE:PF
      Result = Rootpart.CORA_Info(1).Customer_Contact_Email
      '   END FORMULA; PROP ID:1625; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Customer_Contact_Email", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1624; TYPE:PF
      Result = Rootpart.CORA_Info(1).Customer_Name
      '   END FORMULA; PROP ID:1624; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Customer_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1623; TYPE:PF
      Result = Rootpart.CORA_Info(1).Customer_PO_Number
      '   END FORMULA; PROP ID:1623; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Customer_PO_Number", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1635; TYPE:PF
      Result = Rootpart.CORA_Info(1).ERP_Finish_Date
      '   END FORMULA; PROP ID:1635; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_ERP_Finish_Date", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1174; TYPE:PF
      Result = Rootpart.CORA_Info(1).ERP_Project_Description
      '   END FORMULA; PROP ID:1174; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_ERP_Project_Description", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1634; TYPE:PF
      Result = Rootpart.CORA_Info(1).ERP_Project_Start_Date
      '   END FORMULA; PROP ID:1634; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_ERP_Project_Start_Date", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1633; TYPE:PF
      Result = Rootpart.CORA_Info(1).ERP_Project_Status
      '   END FORMULA; PROP ID:1633; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_ERP_Project_Status", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1632; TYPE:PF
      Result = Rootpart.CORA_Info(1).GBE
      '   END FORMULA; PROP ID:1632; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_GBE", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1631; TYPE:PF
      Result = Rootpart.CORA_Info(1).Lead_Engineer
      '   END FORMULA; PROP ID:1631; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Lead_Engineer", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1630; TYPE:PF
      Result = Rootpart.CORA_Info(1).LEAP_ID
      '   END FORMULA; PROP ID:1630; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_LEAP_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1629; TYPE:PF
      Result = Rootpart.CORA_Info(1).LOB
      '   END FORMULA; PROP ID:1629; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_LOB", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1175; TYPE:PF
      Result = Rootpart.CORA_Info(1).Pole
      '   END FORMULA; PROP ID:1175; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Pole", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1655; TYPE:PF
      Result = Rootpart.CORA_Info(1).Profit_Center
      '   END FORMULA; PROP ID:1655; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Profit_Center", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1176; TYPE:PF
      Result = Rootpart.CORA_Info(1).Project_Code
      '   END FORMULA; PROP ID:1176; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Project_Code", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1659; TYPE:PF
      Result = Rootpart.CORA_Info(1).Project_ID
      '   END FORMULA; PROP ID:1659; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Project_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1177; TYPE:PF
      Result = Rootpart.CORA_Info(1).Project_Manager
      '   END FORMULA; PROP ID:1177; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Project_Manager", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1178; TYPE:PF
      Result = Rootpart.CORA_Info(1).Project_Manager_EID
      '   END FORMULA; PROP ID:1178; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Project_Manager_EID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1658; TYPE:PF
      Result = String.Format($"{me.Project_Code} {me.ERP_Project_Description}")
      '   END FORMULA; PROP ID:1658; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Project_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1657; TYPE:PF
      Result = Rootpart.CORA_Info(1).Project_Percentage_Complete
      '   END FORMULA; PROP ID:1657; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Project_Percentage_Complete", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1656; TYPE:PF
      Result = Rootpart.CORA_Info(1).Project_Site_Address
      '   END FORMULA; PROP ID:1656; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Project_Site_Address", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1654; TYPE:PF
      Result = Rootpart.CORA_Info(1).Project_Site_Name
      '   END FORMULA; PROP ID:1654; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Project_Site_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1653; TYPE:PF
      Result = Rootpart.CORA_Info(1).Project_Status
      '   END FORMULA; PROP ID:1653; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Project_Status", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1652; TYPE:PF
      Result = Rootpart.CORA_Info(1).Project_Tier
      '   END FORMULA; PROP ID:1652; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Project_Tier", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1179; TYPE:PF
      Result = Rootpart.CORA_Info(1).Project_Type
      '   END FORMULA; PROP ID:1179; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Project_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1651; TYPE:PF
      Result = Rootpart.CORA_Info(1).Project_Type_Others
      '   END FORMULA; PROP ID:1651; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Project_Type_Others", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1180; TYPE:PF
      Result = Rootpart.CORA_Info(1).Region
      '   END FORMULA; PROP ID:1180; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Region", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1650; TYPE:PF
      Result = Rootpart.CORA_Info(1).Revenue_Type_Description_1
      '   END FORMULA; PROP ID:1650; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Revenue_Type_Description_1", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1649; TYPE:PF
      Result = Rootpart.CORA_Info(1).Revenue_Type_Description_2
      '   END FORMULA; PROP ID:1649; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Revenue_Type_Description_2", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1648; TYPE:PF
      Result = Rootpart.CORA_Info(1).Revenue_Type_Description_3
      '   END FORMULA; PROP ID:1648; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Revenue_Type_Description_3", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1647; TYPE:PF
      Result = Rootpart.CORA_Info(1).Sales_Order_Sold_To_City
      '   END FORMULA; PROP ID:1647; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Sales_Order_Sold_To_City", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1646; TYPE:PF
      Result = Rootpart.CORA_Info(1).Sales_Order_Sold_To_Country
      '   END FORMULA; PROP ID:1646; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Sales_Order_Sold_To_Country", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1645; TYPE:PF
      Result = Rootpart.CORA_Info(1).Sales_Order_Sold_To_Postal_Code
      '   END FORMULA; PROP ID:1645; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Sales_Order_Sold_To_Postal_Code", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1644; TYPE:PF
      Result = Rootpart.CORA_Info(1).Sales_Order_Sold_To_Street_Address
      '   END FORMULA; PROP ID:1644; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Sales_Order_Sold_To_Street_Address", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1643; TYPE:PF
      Result = Rootpart.CORA_Info(1).Sales_Rep
      '   END FORMULA; PROP ID:1643; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Sales_Rep", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1642; TYPE:PF
      Result = Rootpart.CORA_Info(1).Sales_Rep_EID
      '   END FORMULA; PROP ID:1642; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Sales_Rep_EID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1641; TYPE:PF
      Result = Rootpart.CORA_Info(1).SBG
      '   END FORMULA; PROP ID:1641; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_SBG", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1640; TYPE:PF
      Result = Rootpart.CORA_Info(1).SBU
      '   END FORMULA; PROP ID:1640; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_SBU", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1181; TYPE:PF
      Result = Rootpart.CORA_Info(1).SFDC_Opportunity_ID
      '   END FORMULA; PROP ID:1181; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_SFDC_Opportunity_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1639; TYPE:PF
      Result = Rootpart.CORA_Info(1).Ship_To_Customer_Name
      '   END FORMULA; PROP ID:1639; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Ship_To_Customer_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1638; TYPE:PF
      Result = Rootpart.CORA_Info(1).Ship_To_Customer_Number
      '   END FORMULA; PROP ID:1638; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Ship_To_Customer_Number", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1637; TYPE:PF
      Result = Rootpart.CORA_Info(1).Solution
      '   END FORMULA; PROP ID:1637; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Solution", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1636; TYPE:PF
      Result = Rootpart.CORA_Info(1).Stage
      '   END FORMULA; PROP ID:1636; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Stage", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1182; TYPE:PF
      Result = Rootpart.CORA_Info(1).SubLOB
      '   END FORMULA; PROP ID:1182; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_SubLOB", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Honeywell_Designer() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Honeywell_Designer").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1184; TYPE:PF
      Result = Rootpart.Project_Info(1).Honeywell_Designer
      '   END FORMULA; PROP ID:1184; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Honeywell_Designer", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Site_Plant() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Site_Plant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1183; TYPE:PF
      Result = Rootpart.Project_Info(1).Project_Site_Plant
      '   END FORMULA; PROP ID:1183; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_Project_Site_Plant", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1185; TYPE:PF
      Result = Rootpart.CORA_Info(1).RSXLI_PLI_Search_Data_ID
      '   END FORMULA; PROP ID:1185; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula_RSXLI_PLI_Search_Data_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1621; TYPE:PF
      Result = "DELETE"
      '   END FORMULA; PROP ID:1621; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PLI_Information.Formula__DataSharingMode", ex.Message)
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
      Public Function Formula_Honeywell_Designer_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Site_Plant_HIDE_CALCULATED_VALUE() as Boolean
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
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Actual_Schedule_End_Date_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Actual_Schedule_Start_Date_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Country_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Currency_Local_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Contact_Email_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Name_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_PO_Number_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ERP_Finish_Date_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ERP_Project_Description_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ERP_Project_Start_Date_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ERP_Project_Status_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_GBE_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Lead_Engineer_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LEAP_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LOB_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pole_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Profit_Center_USERCHANGE() as Boolean
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
      Public Function Formula_Project_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Manager_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Manager_EID_USERCHANGE() as Boolean
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
      Public Function Formula_Project_Percentage_Complete_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Site_Address_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Site_Name_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Status_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Tier_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Type_Others_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Region_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Revenue_Type_Description_1_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Revenue_Type_Description_2_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Revenue_Type_Description_3_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Sold_To_City_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Sold_To_Country_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Sold_To_Postal_Code_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Sold_To_Street_Address_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Rep_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Rep_EID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SBG_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SBU_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SFDC_Opportunity_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ship_To_Customer_Name_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ship_To_Customer_Number_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Solution_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Stage_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SubLOB_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Designer_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Site_Plant_USERCHANGE() as Boolean
      Return False
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

  