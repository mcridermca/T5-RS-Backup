Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: PLI_Information
'$ GenerateDate: 07/12/2025 14:09:33

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
    
          Public Property [Country]() As String
      Get
      Return Properties("Country").Value
      End Get
      Set(ByVal Value As String)
      Properties("Country").CalculatedValue = Value
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
    
          Public Property [Pole]() As String
      Get
      Return Properties("Pole").Value
      End Get
      Set(ByVal Value As String)
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
    
          Public Property [SFDC_Opportunity_ID]() As String
      Get
      Return Properties("SFDC_Opportunity_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("SFDC_Opportunity_ID").CalculatedValue = Value
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
    InitPart("PLI_Information", <a><![CDATA[PLI Information]]></a>.Value, 101, "HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601423", "07/02/2025 14:48:58")
    AddProperty("1272", "Country", <a><![CDATA[Country]]></a>.Value, "The country for the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/2/2025 2:47:36 PM")
    AddProperty("1273", "ERP_Project_Description", <a><![CDATA[ERP Project Description]]></a>.Value, "The description of the ERP project - mappped to the Project_Name in HBS.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/2/2025 2:46:57 PM")
    AddProperty("1274", "Pole", <a><![CDATA[Pole]]></a>.Value, "A super-region of sorts.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/2/2025 2:46:31 PM")
    AddProperty("1275", "Project_Code", <a><![CDATA[Project Code]]></a>.Value, "The identifying code of the project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/2/2025 2:45:59 PM")
    AddProperty("1276", "Project_Manager", <a><![CDATA[Project Manager]]></a>.Value, "The project manager for this project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/2/2025 2:45:19 PM")
    AddProperty("1277", "Project_Manager_EID", <a><![CDATA[Project Manager EID]]></a>.Value, "The EID of the project manager.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/2/2025 2:44:28 PM")
    AddProperty("1278", "Project_Type", <a><![CDATA[Project Type]]></a>.Value, "The type of project.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/2/2025 2:44:03 PM")
    AddProperty("1279", "Region", <a><![CDATA[Region]]></a>.Value, "The local region.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/2/2025 2:40:20 PM")
    AddProperty("1280", "SFDC_Opportunity_ID", <a><![CDATA[SFDC Opportunity ID]]></a>.Value, "The ID of the SFDC opportunity.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/2/2025 2:42:16 PM")
    AddProperty("1281", "SubLOB", <a><![CDATA[Sub-LOB]]></a>.Value, "The Sub-LOB.", "String","","CORA Data","FD", 9999, "", 0,0, "CORA", "", "GLOBAL\H601423", "7/2/2025 2:43:51 PM")
    AddProperty("1283", "Honeywell_Designer", <a><![CDATA[Honeywell Designer]]></a>.Value, "The name of the Honeywell designer for this project.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601423", "7/2/2025 2:48:37 PM")
    AddProperty("1282", "Project_Site_Plant", <a><![CDATA[Project Site Plant]]></a>.Value, "The site plant of the project.", "String","","General","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601423", "7/2/2025 2:48:58 PM")
    AddProperty("1284", "RSXLI_PLI_Search_Data_ID", <a><![CDATA[RSXLI_PLI_Search_Data_ID]]></a>.Value, "Concatenation of the Project_ID & ""_"" & LineItemID", "String","","RSXLI_Control","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601423", "7/2/2025 2:41:48 PM")
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
          InitProperty("Country", "1173", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/2/2025 2:47:36 PM", "", "In Development",  0,2242)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ERP_Project_Description", "1174", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/2/2025 2:46:57 PM", "", "In Development",  0,2239)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pole", "1175", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/2/2025 2:46:31 PM", "", "In Development",  0,2238)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Code", "1176", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/2/2025 2:45:59 PM", "", "In Development",  0,2236)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Manager", "1177", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/2/2025 2:45:19 PM", "", "In Development",  0,2233)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Manager_EID", "1178", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/2/2025 2:44:28 PM", "", "In Development",  0,2232)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Project_Type", "1179", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/2/2025 2:44:03 PM", "", "In Development",  0,2231)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Region", "1180", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/2/2025 2:40:20 PM", "", "In Development",  0,2226)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SFDC_Opportunity_ID", "1181", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/2/2025 2:42:16 PM", "", "In Development",  0,2229)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SubLOB", "1182", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601423", "7/2/2025 2:43:51 PM", "", "In Development",  0,2230)
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
          Public Function Formula_ERP_Project_Description() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ERP_Project_Description").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1174; TYPE:PF
      Result = Rootpart.CORA_Info(1).ERP_Project_Information
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
      Public Function Formula_Country_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_SFDC_Opportunity_ID_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Country_USERCHANGE() as Boolean
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
      Public Function Formula_SFDC_Opportunity_ID_USERCHANGE() as Boolean
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

  