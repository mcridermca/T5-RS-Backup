Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: SFD_Salesforce_Data_Mock
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

    Public Class [SFD_Salesforce_Data_Mock]
    
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

    Private this as SFD_Salesforce_Data_Mock = me

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
    
      Public ReadOnly Property [DB_Details]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("DB_Details")
      End Get
      End Property
    
      Public ReadOnly Property [PRD_Document]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("PRD_Document")
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
    InitPart("SFD_Salesforce_Data_Mock", <a><![CDATA[SFD_Salesforce_Data_Mock]]></a>.Value, 143, "APCTMP01",  "N", "N", False, False, "In Development", "", "Salesforce Data Mockup", "", "", "",  "GLOBAL\H601424", "06/17/2025 19:36:15")
    AddProperty("1350", "Customer_Contact_Email", <a><![CDATA[Customer_Contact_Email]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1349", "Customer_Name", <a><![CDATA[Customer_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1351", "Customer_PO_Number", <a><![CDATA[Customer_PO_Number]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1365", "End_User_Customer_ID", <a><![CDATA[End_User_Customer_ID]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1366", "End_User_Customer_Name", <a><![CDATA[End_User_Customer_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1348", "Pole", <a><![CDATA[Pole]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1345", "Project_Code", <a><![CDATA[Project_Code]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
    AddProperty("1344", "Project_Identifier", <a><![CDATA[Project_Identifier]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
    AddProperty("1367", "Project_Manager", <a><![CDATA[Project_Manager]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1346", "Project_Name", <a><![CDATA[Project_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
    AddProperty("1355", "Sales_Order_Ship_To_City", <a><![CDATA[Sales_Order_Ship_To_City]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1356", "Sales_Order_Ship_To_Country", <a><![CDATA[Sales_Order_Ship_To_Country]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1358", "Sales_Order_Ship_To_Email", <a><![CDATA[Sales_Order_Ship_To_Email]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1357", "Sales_Order_Ship_To_Postal_Code", <a><![CDATA[Sales_Order_Ship_To_Postal_Code]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1354", "Sales_Order_Ship_To_Street_Address", <a><![CDATA[Sales_Order_Ship_To_Street_Address]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1362", "Sales_Order_Sold_To_City", <a><![CDATA[Sales_Order_Sold_To_City]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1363", "Sales_Order_Sold_To_Country", <a><![CDATA[Sales_Order_Sold_To_Country]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1364", "Sales_Order_Sold_To_Postal_Code", <a><![CDATA[Sales_Order_Sold_To_Postal_Code]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1361", "Sales_Order_Sold_To_Street_Address", <a><![CDATA[Sales_Order_Sold_To_Street_Address]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1347", "SBG", <a><![CDATA[SBG]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:23 AM")
    AddProperty("1352", "Ship_To_Customer_Name", <a><![CDATA[Ship_To_Customer_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1353", "Ship_To_Customer_Number", <a><![CDATA[Ship_To_Customer_Number]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1359", "Sold_To_Customer_Name", <a><![CDATA[Sold_To_Customer_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("1360", "Sold_To_Customer_Number", <a><![CDATA[Sold_To_Customer_Number]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
    AddProperty("739", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/24/2025 5:32:56 PM")
    
      oSubpart = AddSubpart(18,"DB_Details", <a><![CDATA[DB_Details]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
      
        oSubpart.AddVPF (144, "CPM_DBDetails_CORA", "CPM_DBDetails_CORA")
      
      oSubpart = AddSubpart(57,"PRD_Document", <a><![CDATA[PRD_Document]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM")
      
        oSubpart.AddVPF (163, "SFD_Salesforce_PRD_Header_Mock", "SFD_Salesforce_PRD_Header_Mock")
      
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
          InitProperty("Customer_Contact_Email", "1049", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1053)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_Name", "1048", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1052)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_PO_Number", "1050", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1054)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("End_User_Customer_ID", "1064", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1068)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("End_User_Customer_Name", "1065", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1069)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pole", "1047", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1051)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Code", "1044", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development",  0,1048)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Identifier", "1043", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development",  0,1047)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Manager", "1066", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1070)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Name", "1045", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development",  0,1049)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Ship_To_City", "1054", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1058)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Ship_To_Country", "1055", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1059)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Ship_To_Email", "1057", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1061)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Ship_To_Postal_Code", "1056", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1060)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Ship_To_Street_Address", "1053", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1057)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_City", "1061", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1065)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_Country", "1062", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1066)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_Postal_Code", "1063", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1067)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sales_Order_Sold_To_Street_Address", "1060", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1064)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SBG", "1046", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:23 AM", "", "In Development",  0,1050)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ship_To_Customer_Name", "1051", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1055)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ship_To_Customer_Number", "1052", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1056)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sold_To_Customer_Name", "1058", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1062)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sold_To_Customer_Number", "1059", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development",  0,1063)
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
          
        InitSubpart("DB_Details", 14, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development", "N",0,42,43)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("PRD_Document", 52, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:24 AM", "", "In Development", "N",0,122,123)
        
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
          Public Function Formula_Customer_Contact_Email() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Customer_Contact_Email").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1049; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1049; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Customer_Contact_Email", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1048; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1048; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Customer_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1050; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1050; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Customer_PO_Number", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1064; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1064; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_End_User_Customer_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1065; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1065; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_End_User_Customer_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1047; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:1047; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Pole", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1044; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1044; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Project_Code", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1043; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:1043; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Project_Identifier", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1066; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1066; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Project_Manager", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1045; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1045; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Project_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1054; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1054; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Sales_Order_Ship_To_City", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1055; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1055; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Sales_Order_Ship_To_Country", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1057; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1057; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Sales_Order_Ship_To_Email", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1056; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1056; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Sales_Order_Ship_To_Postal_Code", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1053; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1053; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Sales_Order_Ship_To_Street_Address", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1061; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1061; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Sales_Order_Sold_To_City", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1062; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1062; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Sales_Order_Sold_To_Country", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1063; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1063; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Sales_Order_Sold_To_Postal_Code", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1060; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1060; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Sales_Order_Sold_To_Street_Address", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1046; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1046; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_SBG", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1051; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1051; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Ship_To_Customer_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1052; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1052; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Ship_To_Customer_Number", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1058; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1058; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Sold_To_Customer_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1059; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1059; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_Sold_To_Customer_Number", ex.Message)
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
      Public Function Formula_End_User_Customer_ID_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_End_User_Customer_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pole_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Code_USERCHANGE() as Boolean
      Return True
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
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_City_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_Country_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_Email_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_Postal_Code_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sales_Order_Ship_To_Street_Address_USERCHANGE() as Boolean
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
      Public Function Formula_SBG_USERCHANGE() as Boolean
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
      Public Function Formula_Sold_To_Customer_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sold_To_Customer_Number_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DB_Details_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:14; TYPE:PN
      
      '   END FORMULA; SUB ID:14; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_DB_Details_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DB_Details_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("DB_Details").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:14; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:14; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_DB_Details_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DB_Details_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("DB_Details").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:14; TYPE:OP
      result = "CPM_DBDetails_CORA"
      '   END FORMULA; SUB ID:14; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_DB_Details_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Document_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:52; TYPE:PN
      
      '   END FORMULA; SUB ID:52; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_PRD_Document_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Document_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PRD_Document").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:52; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:52; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_PRD_Document_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Document_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PRD_Document").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:52; TYPE:OP
      result = "SFD_Salesforce_PRD_Header_Mock"
      '   END FORMULA; SUB ID:52; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " SFD_Salesforce_Data_Mock.Formula_PRD_Document_OPTIMALPARTFAMILY", ex.Message)
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

  