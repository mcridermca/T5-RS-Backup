Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: APC_Opportunity_Data
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

    Public Class [APC_Opportunity_Data]
    
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

    Private this as APC_Opportunity_Data = me

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
    
          Public Property [End_User_Customer_ID]() As String
      Get
      Return Properties("End_User_Customer_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("End_User_Customer_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [End_User_Customer_Name]() As String
      Get
      Return Properties("End_User_Customer_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("End_User_Customer_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Pole]() As Long
      Get
      Return Properties("Pole").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Pole").CalculatedValue = Value
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
    
          Public Property [Project_Manager]() As String
      Get
      Return Properties("Project_Manager").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Manager").CalculatedValue = Value
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
    
          Public Property [Project_Source_System]() As String
      Get
      Return Properties("Project_Source_System").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Source_System").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sales_Order_Ship_To_City]() As String
      Get
      Return Properties("Sales_Order_Ship_To_City").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sales_Order_Ship_To_City").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sales_Order_Ship_To_Country]() As String
      Get
      Return Properties("Sales_Order_Ship_To_Country").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sales_Order_Ship_To_Country").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sales_Order_Ship_To_Email]() As String
      Get
      Return Properties("Sales_Order_Ship_To_Email").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sales_Order_Ship_To_Email").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sales_Order_Ship_To_Postal_Code]() As String
      Get
      Return Properties("Sales_Order_Ship_To_Postal_Code").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sales_Order_Ship_To_Postal_Code").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sales_Order_Ship_To_Street_Address]() As String
      Get
      Return Properties("Sales_Order_Ship_To_Street_Address").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sales_Order_Ship_To_Street_Address").CalculatedValue = Value
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
    
          Public Property [SBG]() As String
      Get
      Return Properties("SBG").Value
      End Get
      Set(ByVal Value As String)
      Properties("SBG").CalculatedValue = Value
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
    
          Public Property [Sold_To_Customer_Name]() As String
      Get
      Return Properties("Sold_To_Customer_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sold_To_Customer_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sold_To_Customer_Number]() As String
      Get
      Return Properties("Sold_To_Customer_Number").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sold_To_Customer_Number").CalculatedValue = Value
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
    
      Public ReadOnly Property [Cora_Opportunity]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Cora_Opportunity")
      End Get
      End Property
    
      Public ReadOnly Property [Salesforce_Opportunity]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Salesforce_Opportunity")
      End Get
      End Property
    
      Public ReadOnly Property [My_Opportunity_Source]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Opportunity_Source")
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
    InitPart("APC_Opportunity_Data", <a><![CDATA[APC_Opportunity_Data]]></a>.Value, 141, "APCTMP01",  "N", "N", False, False, "In Development", "", "Opportunity Data - Mapping Layer, since we don't know the source of this data. Either CORA, Salesforce, Or Both.", "", "", "",  "GLOBAL\H601424", "03/26/2025 01:58:23")
    AddProperty("1302", "Customer_Contact_Email", <a><![CDATA[Customer_Contact_Email]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1301", "Customer_Name", <a><![CDATA[Customer_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1303", "Customer_PO_Number", <a><![CDATA[Customer_PO_Number]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1317", "End_User_Customer_ID", <a><![CDATA[End_User_Customer_ID]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
    AddProperty("1318", "End_User_Customer_Name", <a><![CDATA[End_User_Customer_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
    AddProperty("1300", "Pole", <a><![CDATA[Pole]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1297", "Project_Code", <a><![CDATA[Project_Code]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1296", "Project_Identifier", <a><![CDATA[Project_Identifier]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1319", "Project_Manager", <a><![CDATA[Project_Manager]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
    AddProperty("1298", "Project_Name", <a><![CDATA[Project_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1295", "Project_Source_System", <a><![CDATA[Project_Source_System]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1307", "Sales_Order_Ship_To_City", <a><![CDATA[Sales_Order_Ship_To_City]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1308", "Sales_Order_Ship_To_Country", <a><![CDATA[Sales_Order_Ship_To_Country]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1310", "Sales_Order_Ship_To_Email", <a><![CDATA[Sales_Order_Ship_To_Email]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1309", "Sales_Order_Ship_To_Postal_Code", <a><![CDATA[Sales_Order_Ship_To_Postal_Code]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1306", "Sales_Order_Ship_To_Street_Address", <a><![CDATA[Sales_Order_Ship_To_Street_Address]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1314", "Sales_Order_Sold_To_City", <a><![CDATA[Sales_Order_Sold_To_City]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
    AddProperty("1315", "Sales_Order_Sold_To_Country", <a><![CDATA[Sales_Order_Sold_To_Country]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
    AddProperty("1316", "Sales_Order_Sold_To_Postal_Code", <a><![CDATA[Sales_Order_Sold_To_Postal_Code]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
    AddProperty("1313", "Sales_Order_Sold_To_Street_Address", <a><![CDATA[Sales_Order_Sold_To_Street_Address]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
    AddProperty("1299", "SBG", <a><![CDATA[SBG]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1304", "Ship_To_Customer_Name", <a><![CDATA[Ship_To_Customer_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1305", "Ship_To_Customer_Number", <a><![CDATA[Ship_To_Customer_Number]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1311", "Sold_To_Customer_Name", <a><![CDATA[Sold_To_Customer_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
    AddProperty("1312", "Sold_To_Customer_Number", <a><![CDATA[Sold_To_Customer_Number]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
    AddProperty("737", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/24/2025 5:32:56 PM")
    
      oSubpart = AddSubpart(15,"Cora_Opportunity", <a><![CDATA[Cora_Opportunity]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
      
        oSubpart.AddVPF (142, "CPM_CORA_Data_Mock", "CPM_CORA_Data_Mock")
      
      oSubpart = AddSubpart(16,"Salesforce_Opportunity", <a><![CDATA[Salesforce_Opportunity]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
      
        oSubpart.AddVPF (143, "SFD_Salesforce_Data_Mock", "SFD_Salesforce_Data_Mock")
      
      oConnection = AddConnection("My_Opportunity_Source", <a><![CDATA[My_Opportunity_Source]]></a>.Value, "", "13", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
      
        oConnection.AddVPF(142, "CPM_CORA_Data_Mock")
      
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
          InitProperty("Customer_Contact_Email", "1001", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1005)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_Name", "1000", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1004)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_PO_Number", "1002", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1006)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("End_User_Customer_ID", "1016", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development",  0,1020)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("End_User_Customer_Name", "1017", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development",  0,1021)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pole", "999", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1003)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Code", "996", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1000)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Identifier", "995", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,999)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Manager", "1018", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development",  0,1022)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Name", "997", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1001)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Source_System", "994", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,998)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Ship_To_City", "1006", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1010)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Ship_To_Country", "1007", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1011)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Ship_To_Email", "1009", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1013)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Ship_To_Postal_Code", "1008", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1012)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Ship_To_Street_Address", "1005", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1009)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_City", "1013", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development",  0,1017)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_Country", "1014", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development",  0,1018)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_Postal_Code", "1015", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development",  0,1019)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_Street_Address", "1012", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development",  0,1016)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SBG", "998", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1002)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ship_To_Customer_Name", "1003", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1007)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ship_To_Customer_Number", "1004", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1008)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sold_To_Customer_Name", "1010", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development",  0,1014)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sold_To_Customer_Number", "1011", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development",  0,1015)
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
          
        InitSubpart("Cora_Opportunity", 11, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development", "N",0,134,37)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Salesforce_Opportunity", 12, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development", "N",0,135,39)
        
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
          
        InitConnection("My_Opportunity_Source", "9", "N","N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development", "N",15)
        
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
      Public Function Formula_My_Opportunity_Source_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:9; TYPE:PF
        Result = Nothing
        '   END FORMULA; CON ID:9; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_My_Opportunity_Source_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
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
      '   BEGIN FORMULA; PROP ID:1001; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1001; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Customer_Contact_Email", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1000; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1000; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Customer_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1002; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1002; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Customer_PO_Number", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_End_User_Customer_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("End_User_Customer_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1016; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1016; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_End_User_Customer_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_End_User_Customer_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("End_User_Customer_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1017; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1017; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_End_User_Customer_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Pole() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Pole").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:999; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:999; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Pole", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:996; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:996; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Project_Code", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:995; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:995; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Project_Identifier", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1018; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1018; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Project_Manager", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:997; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:997; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Project_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Source_System() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Source_System").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:994; TYPE:PF
      result = "Salesforce"
      '   END FORMULA; PROP ID:994; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Project_Source_System", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sales_Order_Ship_To_City() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sales_Order_Ship_To_City").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1006; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1006; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Sales_Order_Ship_To_City", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sales_Order_Ship_To_Country() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sales_Order_Ship_To_Country").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1007; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1007; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Sales_Order_Ship_To_Country", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sales_Order_Ship_To_Email() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sales_Order_Ship_To_Email").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1009; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1009; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Sales_Order_Ship_To_Email", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sales_Order_Ship_To_Postal_Code() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sales_Order_Ship_To_Postal_Code").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1008; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1008; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Sales_Order_Ship_To_Postal_Code", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sales_Order_Ship_To_Street_Address() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sales_Order_Ship_To_Street_Address").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1005; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1005; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Sales_Order_Ship_To_Street_Address", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1013; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1013; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Sales_Order_Sold_To_City", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1014; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1014; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Sales_Order_Sold_To_Country", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1015; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1015; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Sales_Order_Sold_To_Postal_Code", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1012; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1012; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Sales_Order_Sold_To_Street_Address", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:998; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:998; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_SBG", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1003; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1003; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Ship_To_Customer_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1004; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1004; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Ship_To_Customer_Number", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sold_To_Customer_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sold_To_Customer_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1010; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1010; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Sold_To_Customer_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sold_To_Customer_Number() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sold_To_Customer_Number").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1011; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1011; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Sold_To_Customer_Number", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      Public Function Formula_End_User_Customer_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_End_User_Customer_Name_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Project_Manager_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Project_Source_System_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_City_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_Country_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_Email_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_Postal_Code_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_Street_Address_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_SBG_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Sold_To_Customer_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sold_To_Customer_Number_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_End_User_Customer_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_End_User_Customer_Name_USERCHANGE() as Boolean
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
      Public Function Formula_Project_Code_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Identifier_USERCHANGE() as Boolean
      Return True
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
      Public Function Formula_Project_Name_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Source_System_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_City_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_Country_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_Email_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_Postal_Code_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_Street_Address_USERCHANGE() as Boolean
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
      Public Function Formula_SBG_USERCHANGE() as Boolean
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
      Public Function Formula_Sold_To_Customer_Name_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sold_To_Customer_Number_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cora_Opportunity_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:11; TYPE:PN
      
      '   END FORMULA; SUB ID:11; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Cora_Opportunity_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cora_Opportunity_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Cora_Opportunity").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:11; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:11; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Cora_Opportunity_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Cora_Opportunity_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Cora_Opportunity").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:11; TYPE:OP
      result = "CPM_CORA_Data_Mock"
      '   END FORMULA; SUB ID:11; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Cora_Opportunity_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Salesforce_Opportunity_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:12; TYPE:PN
      
      '   END FORMULA; SUB ID:12; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Salesforce_Opportunity_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Salesforce_Opportunity_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Salesforce_Opportunity").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:12; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:12; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Salesforce_Opportunity_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Salesforce_Opportunity_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Salesforce_Opportunity").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:12; TYPE:OP
      result = "SFD_Salesforce_Data_Mock"
      '   END FORMULA; SUB ID:12; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Opportunity_Data.Formula_Salesforce_Opportunity_OPTIMALPARTFAMILY", ex.Message)
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

  