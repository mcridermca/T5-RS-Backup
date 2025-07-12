Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBSADMIN
'$ PartFamily: RSXLI_PLI_Search_Data_Row
'$ GenerateDate: 07/12/2025 14:08:17

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
    Imports HBSADMIN.swMateType_e
    Imports HBSADMIN.swMateAlign_e
    Imports HBSADMIN.severity

    Public Class [RSXLI_PLI_Search_Data_Row]
    
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

    Private this as RSXLI_PLI_Search_Data_Row = me

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
    
          Public Property [Country]() As String
      Get
      Return Properties("Country").Value
      End Get
      Set(ByVal Value As String)
      Properties("Country").CalculatedValue = Value
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
    
          Public Property [Honeywell_Designer_EID]() As String
      Get
      Return Properties("Honeywell_Designer_EID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Honeywell_Designer_EID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Honeywell_PM]() As String
      Get
      Return Properties("Honeywell_PM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Honeywell_PM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Honeywell_PM_EID]() As String
      Get
      Return Properties("Honeywell_PM_EID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Honeywell_PM_EID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LineItem_ID]() As Long
      Get
      Return Properties("LineItem_ID").Value
      End Get
      Set(ByVal Value As Long)
      Properties("LineItem_ID").CalculatedValue = Value
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
    
          Public Property [Project_ID]() As String
      Get
      Return Properties("Project_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_ID").CalculatedValue = Value
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
    
          Public Property [Project_Number]() As String
      Get
      Return Properties("Project_Number").Value
      End Get
      Set(ByVal Value As String)
      Properties("Project_Number").CalculatedValue = Value
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
    
          Public Property [Region]() As String
      Get
      Return Properties("Region").Value
      End Get
      Set(ByVal Value As String)
      Properties("Region").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SAP_Plant]() As String
      Get
      Return Properties("SAP_Plant").Value
      End Get
      Set(ByVal Value As String)
      Properties("SAP_Plant").CalculatedValue = Value
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
    
          Public Property [Vertical]() As String
      Get
      Return Properties("Vertical").Value
      End Get
      Set(ByVal Value As String)
      Properties("Vertical").CalculatedValue = Value
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
    
          Public Property [Data_Hash]() As String
      Get
      Return Properties("Data_Hash").Value
      End Get
      Set(ByVal Value As String)
      Properties("Data_Hash").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LastUpdateDate_1]() As String
      Get
      Return Properties("LastUpdateDate_1").Value
      End Get
      Set(ByVal Value As String)
      Properties("LastUpdateDate_1").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LastUpdateUser]() As String
      Get
      Return Properties("LastUpdateUser").Value
      End Get
      Set(ByVal Value As String)
      Properties("LastUpdateUser").CalculatedValue = Value
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
    
      Public ReadOnly Property [DbInfo]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("DbInfo")
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
    InitPart("RSXLI_PLI_Search_Data_Row", <a><![CDATA[RSXLI_PLI_Search_Data_Row]]></a>.Value, 99, "HBSADMIN",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601422", "07/01/2025 03:55:49")
    AddProperty("1244", "Country", <a><![CDATA[Country]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:52 AM")
    AddProperty("1236", "Honeywell_Designer", <a><![CDATA[Honeywell_Designer]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:52 AM")
    AddProperty("1237", "Honeywell_Designer_EID", <a><![CDATA[Honeywell_Designer_EID]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:52 AM")
    AddProperty("1238", "Honeywell_PM", <a><![CDATA[Honeywell_PM]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:52 AM")
    AddProperty("1239", "Honeywell_PM_EID", <a><![CDATA[Honeywell_PM_EID]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:52 AM")
    AddProperty("1231", "LineItem_ID", <a><![CDATA[LineItem_ID]]></a>.Value, "", "Long","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:51 AM")
    AddProperty("1235", "Pole", <a><![CDATA[Pole]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:51 AM")
    AddProperty("1230", "Project_ID", <a><![CDATA[Project_ID]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:51 AM")
    AddProperty("1233", "Project_Name", <a><![CDATA[Project_Name]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:51 AM")
    AddProperty("1232", "Project_Number", <a><![CDATA[Project_Number]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:51 AM")
    AddProperty("1241", "Project_Type", <a><![CDATA[Project_Type]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:52 AM")
    AddProperty("1242", "Region", <a><![CDATA[Region]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:52 AM")
    AddProperty("1240", "SAP_Plant", <a><![CDATA[SAP_Plant]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:52 AM")
    AddProperty("1234", "SFDC_Opportunity_ID", <a><![CDATA[SFDC_Opportunity_ID]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:51 AM")
    AddProperty("1243", "Vertical", <a><![CDATA[Vertical]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:52 AM")
    AddProperty("1269", "RSXLI_PLI_Search_Data_ID", <a><![CDATA[RSXLI_PLI_Search_Data_ID]]></a>.Value, "The Primary Key for the Row", "String","","Master Data PK","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\H601422", "7/1/2025 3:41:13 AM")
    AddProperty("1247", "Data_Hash", <a><![CDATA[Data_Hash]]></a>.Value, "Hash of Master Data Fields", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:52 AM")
    AddProperty("1245", "LastUpdateDate_1", <a><![CDATA[LastUpdateDate]]></a>.Value, "User that modified the record", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:52 AM")
    AddProperty("1246", "LastUpdateUser", <a><![CDATA[LastUpdateUser]]></a>.Value, "Date modified", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:33:52 AM")
    AddProperty("1227", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:28:42 AM")
    
      oSubpart = AddSubpart(114,"DbInfo", <a><![CDATA[DB Info Part Family]]></a>.Value, "FD", "Subpart for Database Information for this Part", "Master Audit", 9999, "", "GLOBAL\H601422", "7/1/2025 3:55:49 AM")
      
        oSubpart.AddVPF (100, "RSXLI_PLI_Search_Data_Row_dbInfo", "RSXLI_PLI_Search_Data_Row_dbInfo")
      
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
          InitProperty("Country", "1147", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:52 AM", "", "In Development",  0,2171)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_Designer", "1139", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:52 AM", "", "In Development",  0,2163)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_Designer_EID", "1140", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:52 AM", "", "In Development",  0,2164)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_PM", "1141", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:52 AM", "", "In Development",  0,2165)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_PM_EID", "1142", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:52 AM", "", "In Development",  0,2166)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LineItem_ID", "1134", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:51 AM", "", "In Development",  0,2158)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pole", "1138", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:51 AM", "", "In Development",  0,2162)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_ID", "1133", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:51 AM", "", "In Development",  0,2157)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Name", "1136", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:51 AM", "", "In Development",  0,2160)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Number", "1135", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:51 AM", "", "In Development",  0,2159)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Type", "1144", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:52 AM", "", "In Development",  0,2168)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Region", "1145", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:52 AM", "", "In Development",  0,2169)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SAP_Plant", "1143", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:52 AM", "", "In Development",  0,2167)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SFDC_Opportunity_ID", "1137", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:51 AM", "", "In Development",  0,2161)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Vertical", "1146", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:52 AM", "", "In Development",  0,2170)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("RSXLI_PLI_Search_Data_ID", "1171", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601422", "7/1/2025 3:41:13 AM", "", "In Development",  0,2203)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Data_Hash", "1150", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:52 AM", "Hash of Master Data Fields", "In Development",  0,2174)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LastUpdateDate_1", "1148", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:52 AM", "User that modified the record", "In Development",  0,2172)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LastUpdateUser", "1149", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:33:52 AM", "Date modified", "In Development",  0,2173)
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
          
        InitSubpart("DbInfo", 99, "", "", "Y", 0, "-1", "", "GLOBAL\H601422", "7/1/2025 3:55:49 AM", "Subpart for Database Information for this Part", "In Development", "N",0,227,231)
        
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
          Public Function Formula_Country() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Country").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1147; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1147; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_Country", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1139; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1139; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_Honeywell_Designer", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Honeywell_Designer_EID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Honeywell_Designer_EID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1140; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1140; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_Honeywell_Designer_EID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Honeywell_PM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Honeywell_PM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1141; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1141; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_Honeywell_PM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Honeywell_PM_EID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Honeywell_PM_EID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1142; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1142; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_Honeywell_PM_EID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LineItem_ID() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LineItem_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1134; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1134; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_LineItem_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1138; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1138; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_Pole", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1133; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1133; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_Project_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1136; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1136; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_Project_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Project_Number() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Project_Number").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1135; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1135; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_Project_Number", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1144; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1144; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_Project_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1145; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1145; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_Region", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SAP_Plant() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SAP_Plant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1143; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1143; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_SAP_Plant", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1137; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1137; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_SFDC_Opportunity_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Vertical() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Vertical").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1146; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1146; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_Vertical", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1171; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1171; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_RSXLI_PLI_Search_Data_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Data_Hash() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Data_Hash").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1150; TYPE:PF
      Result = ""

For Each p As PropertySF In Me.properties
	If P.CategoryName.Trim().ToLower() = "master data" Or P.CategoryName.Trim().ToLower() = "master data pk"Then
		Result = Result & $"{P.Value}".Tolower() & ";"
	End If
Next P
      '   END FORMULA; PROP ID:1150; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_Data_Hash", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LastUpdateDate_1() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LastUpdateDate_1").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1148; TYPE:PF
      result = "ERROR"
      '   END FORMULA; PROP ID:1148; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_LastUpdateDate_1", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LastUpdateUser() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LastUpdateUser").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1149; TYPE:PF
      result = nothing
      '   END FORMULA; PROP ID:1149; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_LastUpdateUser", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      Public Function Formula_Honeywell_Designer_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Designer_EID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_PM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_PM_EID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LineItem_ID_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Project_ID_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Project_Number_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Region_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SAP_Plant_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Vertical_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Data_Hash_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LastUpdateDate_1_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LastUpdateUser_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Honeywell_Designer_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_Designer_EID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_PM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Honeywell_PM_EID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LineItem_ID_USERCHANGE() as Boolean
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
      Public Function Formula_Project_ID_USERCHANGE() as Boolean
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
      Public Function Formula_Project_Number_USERCHANGE() as Boolean
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
      Public Function Formula_Region_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SAP_Plant_USERCHANGE() as Boolean
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
      Public Function Formula_Vertical_USERCHANGE() as Boolean
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
      Public Function Formula_Data_Hash_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LastUpdateDate_1_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LastUpdateUser_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DbInfo_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:99; TYPE:PN
      
      '   END FORMULA; SUB ID:99; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_DbInfo_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DbInfo_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("DbInfo").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:99; TYPE:QF
      Result = 0

Dim TableName As String = "RSXLI_PLI_Search_Data"
Dim SubpartName As String = TableName & "_Row"

Dim PKField As String = TableName & "_ID" 
If Not (String.IsNullOrEmpty(Me.Properties(PKField).Value)) Then
	Result = 1
End If
      '   END FORMULA; SUB ID:99; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_DbInfo_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DbInfo_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("DbInfo").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:99; TYPE:OP
      result = "RSXLI_PLI_Search_Data_Row_dbInfo"
      '   END FORMULA; SUB ID:99; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row.Formula_DbInfo_OPTIMALPARTFAMILY", ex.Message)
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

  