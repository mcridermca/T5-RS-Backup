Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBSADMIN
'$ PartFamily: ADM_Parameter_Name_Master_Row_dbInfo
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

    Public Class [ADM_Parameter_Name_Master_Row_dbInfo]
    
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

    Private this as ADM_Parameter_Name_Master_Row_dbInfo = me

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
    
          Public Property [Parameter_Name_Master]() As String
      Get
      Return Properties("Parameter_Name_Master").Value
      End Get
      Set(ByVal Value As String)
      Properties("Parameter_Name_Master").CalculatedValue = Value
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
    
          Public Property [Parameter_Name_Master_Id]() As Long
      Get
      Return Properties("Parameter_Name_Master_Id").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Parameter_Name_Master_Id").CalculatedValue = Value
      End Set
      End Property
    
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
    
          Public Property [Data_Hash]() As String
      Get
      Return Properties("Data_Hash").Value
      End Get
      Set(ByVal Value As String)
      Properties("Data_Hash").CalculatedValue = Value
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
    InitPart("ADM_Parameter_Name_Master_Row_dbInfo", <a><![CDATA[ADM_Parameter_Name_Master_Row_dbInfo]]></a>.Value, 104, "HBSADMIN",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601423", "07/09/2025 10:46:44")
    AddProperty("1309", "Deleted", <a><![CDATA[Deleted]]></a>.Value, "Deleted Flag", "Boolean","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:00:33 PM")
    AddProperty("1310", "Is_Active", <a><![CDATA[Is_Active]]></a>.Value, "Is Record Active (Not Obsolete)", "Boolean","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:01:10 PM")
    AddProperty("1314", "Parameter_Name_Master", <a><![CDATA[Parameter_Name_Master]]></a>.Value, "Parameter Name", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:03:06 PM")
    AddProperty("1315", "Sort_Order", <a><![CDATA[Sort_Order]]></a>.Value, "First Sort Order 0 = Default = 100 , Adjust Accordingly", "Long","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:03:25 PM")
    AddProperty("1313", "Parameter_Name_Master_Id", <a><![CDATA[Parameter_Name_Master_Id]]></a>.Value, "Primary Key", "Long","","Master Data PK","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:02:35 PM")
    AddProperty("1306", "Created_By", <a><![CDATA[Created_By]]></a>.Value, "User that created the record", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 7:59:28 PM")
    AddProperty("1307", "Created_On", <a><![CDATA[Created_On]]></a>.Value, "Date User Created record", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 7:59:41 PM")
    AddProperty("1308", "Data_Hash", <a><![CDATA[Data_Hash]]></a>.Value, "Hash of Master Data Fields", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:00:12 PM")
    AddProperty("1311", "Modified_By", <a><![CDATA[Modified_By]]></a>.Value, "User that modified the record", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:01:27 PM")
    AddProperty("1312", "Modified_On", <a><![CDATA[Modified_On]]></a>.Value, "Date modified", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 8:02:05 PM")
    AddProperty("1290", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/8/2025 7:52:55 PM")
    
      AddDBConstraint(38, "dbInfo", <a><![CDATA[dbInfo]]></a>.Value,"Master DBInfo", 9999)
    
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
          InitProperty("Deleted", "1207", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:00:33 PM", "Deleted Flag", "In Development",  0,2279)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Is_Active", "1208", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:01:10 PM", "Is Record Active (Not Obsolete)", "In Development",  0,2280)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Parameter_Name_Master", "1212", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:03:06 PM", "Parameter Name", "In Development",  0,2284)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Order", "1213", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:03:25 PM", "First Sort Order 0 = Default = 100 , Adjust Accordingly", "In Development",  0,2285)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Parameter_Name_Master_Id", "1211", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:02:35 PM", "Primary Key", "In Development",  0,2283)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Created_By", "1204", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 7:59:28 PM", "User that created the record", "In Development",  0,2276)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Created_On", "1205", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 7:59:41 PM", "Date User Created record", "In Development",  0,2277)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Data_Hash", "1206", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:00:12 PM", "Hash of Master Data Fields", "In Development",  0,2278)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Modified_By", "1209", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:01:27 PM", "User that modified the record", "In Development",  0,2281)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Modified_On", "1210", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/8/2025 8:02:05 PM", "Date modified", "In Development",  0,2282)
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
          
        InitDBConstraint("dbInfo", 38,"", "Y","", "", "Parameter_Name_Master")
        
          InitDBproperty("dbInfo", "Created_By",38, "Created_By", "Parameter_Name_Master")
        
          InitDBproperty("dbInfo", "Created_On",38, "Created_On", "Parameter_Name_Master")
        
          InitDBproperty("dbInfo", "Deleted",38, "Deleted", "Parameter_Name_Master")
        
          InitDBproperty("dbInfo", "Is_Active",38, "Is_Active", "Parameter_Name_Master")
        
          InitDBproperty("dbInfo", "Modified_By",38, "Modified_By", "Parameter_Name_Master")
        
          InitDBproperty("dbInfo", "Modified_On",38, "Modified_On", "Parameter_Name_Master")
        
          InitDBproperty("dbInfo", "Parameter_Name_Master",38, "Parameter_Name_Master", "Parameter_Name_Master")
        
          InitDBproperty("dbInfo", "Sort_Order",38, "Sort_Order", "Parameter_Name_Master")
        
          End If
        
    End Sub

    #End Region

    #Region " Formulas "

    
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
      '   BEGIN FORMULA; PROP ID:1207; TYPE:PF
      result = False
      '   END FORMULA; PROP ID:1207; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Parameter_Name_Master_Row_dbInfo.Formula_Deleted", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1208; TYPE:PF
      result = True
      '   END FORMULA; PROP ID:1208; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Parameter_Name_Master_Row_dbInfo.Formula_Is_Active", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Parameter_Name_Master() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Parameter_Name_Master").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1212; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1212; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Parameter_Name_Master_Row_dbInfo.Formula_Parameter_Name_Master", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1213; TYPE:PF
      result = 100
      '   END FORMULA; PROP ID:1213; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Parameter_Name_Master_Row_dbInfo.Formula_Sort_Order", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Parameter_Name_Master_Id() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Parameter_Name_Master_Id").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1211; TYPE:PF
      result = Me.Parent.Properties("Parameter_Name_Master_ID").Value
      '   END FORMULA; PROP ID:1211; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Parameter_Name_Master_Row_dbInfo.Formula_Parameter_Name_Master_Id", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
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
      '   BEGIN FORMULA; PROP ID:1204; TYPE:PF
      result = "ERROR"
      '   END FORMULA; PROP ID:1204; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Parameter_Name_Master_Row_dbInfo.Formula_Created_By", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1205; TYPE:PF
      result = nothing
      '   END FORMULA; PROP ID:1205; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Parameter_Name_Master_Row_dbInfo.Formula_Created_On", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1206; TYPE:PF
      Result = ""

For Each p As PropertySF In Me.properties
	If P.CategoryName.Trim().ToLower() = "master data" Or P.CategoryName.Trim().ToLower() = "master data pk"Then
		Result = Result & $"{P.Value}".Tolower() & ";"
	End If
Next P
      '   END FORMULA; PROP ID:1206; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Parameter_Name_Master_Row_dbInfo.Formula_Data_Hash", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1209; TYPE:PF
      result = "ERROR"
      '   END FORMULA; PROP ID:1209; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Parameter_Name_Master_Row_dbInfo.Formula_Modified_By", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1210; TYPE:PF
      result = nothing
      '   END FORMULA; PROP ID:1210; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Parameter_Name_Master_Row_dbInfo.Formula_Modified_On", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      Public Function Formula_Parameter_Name_Master_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Parameter_Name_Master_Id_HIDE_CALCULATED_VALUE() as Boolean
      Return False
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
      Public Function Formula_Data_Hash_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Deleted_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Is_Active_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Parameter_Name_Master_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_Parameter_Name_Master_Id_USERCHANGE() as Boolean
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
      Public Function Formula_Data_Hash_USERCHANGE() as Boolean
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
      
        Case 38
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "Created_By" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Created_On" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Deleted" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Is_Active" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Modified_By" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Modified_On" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Parameter_Name_Master" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Sort_Order" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
                  varPropSpecVal = me.Parameter_Name_Master_Id
              BuildWhereClause(strWhereClause, "0", "0", "  ", "[Parameter_Name_Master_ID]", "=", varPropSpecVal, "")
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("Parameter_Name_Master"), strWhereClause, leftDelimiter & "Parameter_Name_Master_ID" & rightDelimiter, "ASC")
          
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Parameter_Name_Master_Row_dbInfo.GetRecordset", strError)
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

  