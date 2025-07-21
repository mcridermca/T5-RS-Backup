Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBSADMIN
'$ PartFamily: RSXLI_PLI_Search_Data_Row_dbInfo
'$ GenerateDate: 07/21/2025 12:33:29

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

    Public Class [RSXLI_PLI_Search_Data_Row_dbInfo]
    
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

    Private this as RSXLI_PLI_Search_Data_Row_dbInfo = me

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
    
          Public Property [RSXLI_PLI_Search_Data_ID]() As String
      Get
      Return Properties("RSXLI_PLI_Search_Data_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("RSXLI_PLI_Search_Data_ID").CalculatedValue = Value
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
    InitPart("RSXLI_PLI_Search_Data_Row_dbInfo", <a><![CDATA[RSXLI_PLI_Search_Data_Row_dbInfo]]></a>.Value, 100, "HBSADMIN",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601422", "07/01/2025 04:08:13")
    AddProperty("1264", "Country", <a><![CDATA[Country]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1256", "Honeywell_Designer", <a><![CDATA[Honeywell_Designer]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1257", "Honeywell_Designer_EID", <a><![CDATA[Honeywell_Designer_EID]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1258", "Honeywell_PM", <a><![CDATA[Honeywell_PM]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1259", "Honeywell_PM_EID", <a><![CDATA[Honeywell_PM_EID]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1251", "LineItem_ID", <a><![CDATA[LineItem_ID]]></a>.Value, "", "Long","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:56 AM")
    AddProperty("1255", "Pole", <a><![CDATA[Pole]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1250", "Project_ID", <a><![CDATA[Project_ID]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:56 AM")
    AddProperty("1253", "Project_Name", <a><![CDATA[Project_Name]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1252", "Project_Number", <a><![CDATA[Project_Number]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1261", "Project_Type", <a><![CDATA[Project_Type]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1262", "Region", <a><![CDATA[Region]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1260", "SAP_Plant", <a><![CDATA[SAP_Plant]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1254", "SFDC_Opportunity_ID", <a><![CDATA[SFDC_Opportunity_ID]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1263", "Vertical", <a><![CDATA[Vertical]]></a>.Value, "", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1267", "Data_Hash", <a><![CDATA[Data_Hash]]></a>.Value, "Hash of Master Data Fields", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1265", "LastUpdateDate_1", <a><![CDATA[LastUpdateDate]]></a>.Value, "", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1266", "LastUpdateUser", <a><![CDATA[LastUpdateUser]]></a>.Value, "", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:57 AM")
    AddProperty("1270", "RSXLI_PLI_Search_Data_ID", <a><![CDATA[RSXLI_PLI_Search_Data_ID]]></a>.Value, "Primary Key for the Row", "String","","Master DBInfo","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\H601422", "7/1/2025 3:45:43 AM")
    AddProperty("1249", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/1/2025 1:41:56 AM")
    
      AddDBConstraint(34, "DbInfo", <a><![CDATA[DbInfo]]></a>.Value,"Master DBInfo", 9999)
    
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
          InitProperty("Country", "1166", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2191)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_Designer", "1158", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2183)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_Designer_EID", "1159", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2184)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_PM", "1160", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2185)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Honeywell_PM_EID", "1161", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2186)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LineItem_ID", "1153", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:56 AM", "", "In Development",  0,2178)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pole", "1157", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2182)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_ID", "1152", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:56 AM", "", "In Development",  0,2177)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Name", "1155", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2180)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Number", "1154", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2179)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Type", "1163", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2188)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Region", "1164", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2189)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SAP_Plant", "1162", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2187)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SFDC_Opportunity_ID", "1156", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2181)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Vertical", "1165", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2190)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Data_Hash", "1169", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "Hash of Master Data Fields", "In Development",  0,2194)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LastUpdateDate_1", "1167", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2192)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LastUpdateUser", "1168", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/1/2025 1:41:57 AM", "", "In Development",  0,2193)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("RSXLI_PLI_Search_Data_ID", "1172", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601422", "7/1/2025 3:45:43 AM", "", "In Development",  0,2204)
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
            If Incontext("-1", ctx) Then
          
        InitDBConstraint("DbInfo", 34,"", "Y","", "", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "Country",34, "Country", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "Honeywell_Designer",34, "Honeywell_Designer", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "Honeywell_Designer_EID",34, "Honeywell_Designer_EID", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "Honeywell_PM",34, "Honeywell_PM", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "Honeywell_PM_EID",34, "Honeywell_PM_EID", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "LineItem_ID",34, "LineItem_ID", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "Pole",34, "Pole", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "Project_ID",34, "Project_ID", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "Project_Name",34, "Project_Name", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "Project_Number",34, "Project_Number", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "Project_Type",34, "Project_Type", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "Region",34, "Region", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "SAP_Plant",34, "SAP_Plant", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "SFDC_Opportunity_ID",34, "SFDC_Opportunity_ID", "RSXLI_PLI_Search_Data")
        
          InitDBproperty("DbInfo", "Vertical",34, "Vertical", "RSXLI_PLI_Search_Data")
        
          End If
        
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
      '   BEGIN FORMULA; PROP ID:1166; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1166; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_Country", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1158; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1158; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_Honeywell_Designer", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1159; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1159; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_Honeywell_Designer_EID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1160; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1160; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_Honeywell_PM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1161; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1161; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_Honeywell_PM_EID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1153; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:1153; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_LineItem_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1157; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1157; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_Pole", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1152; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1152; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_Project_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1155; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1155; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_Project_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1154; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1154; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_Project_Number", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1163; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1163; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_Project_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1164; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1164; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_Region", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1162; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1162; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_SAP_Plant", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1156; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1156; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_SFDC_Opportunity_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1165; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1165; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_Vertical", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1169; TYPE:PF
      Result = ""

For Each p As PropertySF In Me.properties
	If P.CategoryName.Trim().ToLower() = "master data" Or P.CategoryName.Trim().ToLower() = "master data pk"Then
		Result = Result & $"{P.Value}".Tolower() & ";"
	End If
Next P
      '   END FORMULA; PROP ID:1169; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_Data_Hash", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1167; TYPE:PF
      result = nothing
      '   END FORMULA; PROP ID:1167; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_LastUpdateDate_1", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1168; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1168; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_LastUpdateUser", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1172; TYPE:PF
      Result = Me.Parent.Properties("RSXLI_PLI_Search_Data_ID").Value
      '   END FORMULA; PROP ID:1172; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.Formula_RSXLI_PLI_Search_Data_ID", ex.Message)
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
      Public Function Formula_RSXLI_PLI_Search_Data_ID_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_RSXLI_PLI_Search_Data_ID_USERCHANGE() as Boolean
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
      
        Case 34
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "Country" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Honeywell_Designer" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Honeywell_Designer_EID" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Honeywell_PM" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Honeywell_PM_EID" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "LineItem_ID" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Pole" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Project_ID" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Project_Name" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Project_Number" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Project_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Region" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "SAP_Plant" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "SFDC_Opportunity_ID" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Vertical" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
                  varPropSpecVal = me.RSXLI_PLI_Search_Data_ID
              BuildWhereClause(strWhereClause, "0", "0", "  ", "[RSXLI_PLI_Search_Data_ID]", "=", varPropSpecVal, "")
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("RSXLI_PLI_Search_Data"), strWhereClause, leftDelimiter & "RSXLI_PLI_Search_Data_ID" & rightDelimiter, "")
          
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " RSXLI_PLI_Search_Data_Row_dbInfo.GetRecordset", strError)
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

  