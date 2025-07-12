Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBSADMIN
'$ PartFamily: ADM_Standards_Master_Row
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

    Public Class [ADM_Standards_Master_Row]
    
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

    Private this as ADM_Standards_Master_Row = me

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
    
          Public Property [Created_By]() As String
      Get
      Return Properties("Created_By").Value
      End Get
      Set(ByVal Value As String)
      Properties("Created_By").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Created_On]() As String
      Get
      Return Properties("Created_On").Value
      End Get
      Set(ByVal Value As String)
      Properties("Created_On").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Is_Dirty]() As Boolean
      Get
      Return Properties("Is_Dirty").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Is_Dirty").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Is_New]() As Boolean
      Get
      Return Properties("Is_New").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Is_New").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Modified_By]() As String
      Get
      Return Properties("Modified_By").Value
      End Get
      Set(ByVal Value As String)
      Properties("Modified_By").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Modified_On]() As String
      Get
      Return Properties("Modified_On").Value
      End Get
      Set(ByVal Value As String)
      Properties("Modified_On").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Deleted]() As Boolean
      Get
      Return Properties("Deleted").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Deleted").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Is_Active]() As Boolean
      Get
      Return Properties("Is_Active").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Is_Active").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Order]() As Long
      Get
      Return Properties("Sort_Order").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Sort_Order").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Standards]() As String
      Get
      Return Properties("Standards").Value
      End Get
      Set(ByVal Value As String)
      Properties("Standards").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Standards_Master_Id]() As Long
      Get
      Return Properties("Standards_Master_Id").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Standards_Master_Id").CalculatedValue = Value
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
    InitPart("ADM_Standards_Master_Row", <a><![CDATA[ADM_Standards_Master_Row]]></a>.Value, 109, "HBSADMIN",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/08/2025 21:00:20")
    AddProperty("1350", "Created_By", <a><![CDATA[Created_By]]></a>.Value, "User that created the record", "String","","Master Audit","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:28:01 PM")
    AddProperty("1351", "Created_On", <a><![CDATA[Created_On]]></a>.Value, "Date User Created record", "String","","Master Audit","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:28:28 PM")
    AddProperty("1355", "Is_Dirty", <a><![CDATA[Is_Dirty]]></a>.Value, "Is this a new Record", "Boolean","","Master Audit","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:57:18 PM")
    AddProperty("1356", "Is_New", <a><![CDATA[Is_New]]></a>.Value, "Is this a Dirty / Changed Record", "Boolean","","Master Audit","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:57:58 PM")
    AddProperty("1357", "Modified_By", <a><![CDATA[Modified_By]]></a>.Value, "User that modified the record", "String","","Master Audit","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:58:38 PM")
    AddProperty("1358", "Modified_On", <a><![CDATA[Modified_On]]></a>.Value, "Date modified", "String","","Master Audit","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:58:55 PM")
    AddProperty("1353", "Deleted", <a><![CDATA[Deleted]]></a>.Value, "Deleted Flag", "Boolean","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:29:05 PM")
    AddProperty("1354", "Is_Active", <a><![CDATA[Is_Active]]></a>.Value, "Is Record Active (Not Obsolete)", "Boolean","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:29:25 PM")
    AddProperty("1361", "Sort_Order", <a><![CDATA[Sort_Order]]></a>.Value, "First Sort Order 0 = Default = 100 , Adjust Accordingly", "Long","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 9:00:20 PM")
    AddProperty("1360", "Standards", <a><![CDATA[Standards]]></a>.Value, "Standards Name", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:59:55 PM")
    AddProperty("1359", "Standards_Master_Id", <a><![CDATA[Standards_Master_Id]]></a>.Value, "Primary Key", "Long","","Master Data PK","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:59:33 PM")
    AddProperty("1352", "Data_Hash", <a><![CDATA[Data_Hash]]></a>.Value, "Hash of Master Data Fields", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:28:44 PM")
    AddProperty("1345", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:26:26 PM")
    
      oSubpart = AddSubpart(122,"DbInfo", <a><![CDATA[DB Info Part Family]]></a>.Value, "FD", "Subpart for Database Information for this Part", "Master Audit", 9999, "", "GLOBAL\H601424", "7/8/2025 9:00:20 PM")
      
        oSubpart.AddVPF (110, "ADM_Standards_Master_Row_dbInfo", "ADM_Standards_Master_Row_dbInfo")
      
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
          InitProperty("Created_By", "1242", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:28:01 PM", "User that created the record", "In Development",  0,2316)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Created_On", "1243", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:28:28 PM", "Date User Created record", "In Development",  0,2317)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Is_Dirty", "1247", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:57:18 PM", "Is this a new Record", "In Development",  0,2321)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Is_New", "1248", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:57:58 PM", "Is this a Dirty / Changed Record", "In Development",  0,2322)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Modified_By", "1249", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:58:38 PM", "User that modified the record", "In Development",  0,2323)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Modified_On", "1250", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:58:55 PM", "Date modified", "In Development",  0,2324)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Deleted", "1245", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:29:05 PM", "Deleted Flag", "In Development",  0,2319)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Is_Active", "1246", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:29:25 PM", "Is Record Active (Not Obsolete)", "In Development",  0,2320)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Order", "1253", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 9:00:20 PM", "First Sort Order 0 = Default = 100 , Adjust Accordingly", "In Development",  0,2327)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Standards", "1252", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:59:55 PM", "Standards Name", "In Development",  0,2326)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Standards_Master_Id", "1251", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:59:33 PM", "Primary Key", "In Development",  0,2325)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Data_Hash", "1244", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:28:44 PM", "Hash of Master Data Fields", "In Development",  0,2318)
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
          
        InitSubpart("DbInfo", 104, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "7/8/2025 9:00:20 PM", "Subpart for Database Information for this Part", "In Development", "N",0,238,239)
        
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
          Public Function Formula_Created_By() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Created_By").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1242; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1242; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_Created_By", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Created_On() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Created_On").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1243; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1243; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_Created_On", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Is_Dirty() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Is_Dirty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1247; TYPE:PF
      Result = True
If Me.dbinfo.Count = 1 Then
	Result = (Me.Data_Hash <> Me.dbinfo(1).Data_Hash)
End If
If Me.Is_New Then Result = True
      '   END FORMULA; PROP ID:1247; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_Is_Dirty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Is_New() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Is_New").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1248; TYPE:PF
      Result = Me.DBInfo.Count = 0
      '   END FORMULA; PROP ID:1248; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_Is_New", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Modified_By() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Modified_By").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1249; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1249; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_Modified_By", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Modified_On() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Modified_On").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1250; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1250; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_Modified_On", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Deleted() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Deleted").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1245; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1245; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_Deleted", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Is_Active() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Is_Active").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1246; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1246; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_Is_Active", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Order() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Order").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1253; TYPE:PF
      Result = 100
If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1253; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_Sort_Order", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Standards() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Standards").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1252; TYPE:PF
      If Me.DBInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.DBInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:1252; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_Standards", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Standards_Master_Id() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Standards_Master_Id").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1251; TYPE:PF
      Result = -1 ' Flag as New Record
If  Me.Parent.ValidValues("Row_DBKeys").Count > Me.Subpartid
	Result = Me.Parent.ValidValues("Row_DBKeys")(Me.SubpartID-1)
End If
      '   END FORMULA; PROP ID:1251; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_Standards_Master_Id", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1244; TYPE:PF
      Result = ""

For Each p As PropertySF In Me.properties
	If P.CategoryName.Trim().ToLower() = "master data" Or P.CategoryName.Trim().ToLower() = "master data pk"Then
		Result = Result & $"{P.Value}".Tolower() & ";"
	End If
Next P
      '   END FORMULA; PROP ID:1244; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_Data_Hash", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Created_By_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Created_On_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Dirty_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_New_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Modified_By_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Modified_On_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Deleted_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Active_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Order_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Standards_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Standards_Master_Id_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Created_By_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Created_On_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Dirty_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_New_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Modified_By_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Modified_On_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Deleted_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Active_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Order_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Standards_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Standards_Master_Id_USERCHANGE() as Boolean
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
      Public Function Formula_DbInfo_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:104; TYPE:PN
      
      '   END FORMULA; SUB ID:104; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_DbInfo_PARTNAMES", ex.Message)
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
      '   BEGIN FORMULA; SUB ID:104; TYPE:QF
      Result = 0

Dim TableName As String = Me.Parent.Name.Split(":")(0).Trim()
Dim SubpartName As String = "Adm_" & TableName & "_Row"

Dim PKField As String = TableName & "_ID" 
If Me.Properties(PKField).Value > 0 Then
	Result = 1
End If
      '   END FORMULA; SUB ID:104; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_DbInfo_QUANTITY", ex.Message)
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
      '   BEGIN FORMULA; SUB ID:104; TYPE:OP
      result = "ADM_Standards_Master_Row_dbInfo"
      '   END FORMULA; SUB ID:104; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Standards_Master_Row.Formula_DbInfo_OPTIMALPARTFAMILY", ex.Message)
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

  