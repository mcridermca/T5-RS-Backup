Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBSADMIN
'$ PartFamily: ADM_Engg_Units_Master_Row_dbInfo
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

    Public Class [ADM_Engg_Units_Master_Row_dbInfo]
    
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

    Private this as ADM_Engg_Units_Master_Row_dbInfo = me

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
    
          Public Property [Base_Unit_Name]() As String
      Get
      Return Properties("Base_Unit_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Base_Unit_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Base_Unit_Symbol]() As String
      Get
      Return Properties("Base_Unit_Symbol").Value
      End Get
      Set(ByVal Value As String)
      Properties("Base_Unit_Symbol").CalculatedValue = Value
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
    
          Public Property [Engg_Units_Standard_Ref]() As String
      Get
      Return Properties("Engg_Units_Standard_Ref").Value
      End Get
      Set(ByVal Value As String)
      Properties("Engg_Units_Standard_Ref").CalculatedValue = Value
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
    
          Public Property [Unit_Of_Measure]() As String
      Get
      Return Properties("Unit_Of_Measure").Value
      End Get
      Set(ByVal Value As String)
      Properties("Unit_Of_Measure").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Engg_Units_Master_ID]() As Long
      Get
      Return Properties("Engg_Units_Master_ID").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Engg_Units_Master_ID").CalculatedValue = Value
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
    InitPart("ADM_Engg_Units_Master_Row_dbInfo", <a><![CDATA[ADM_Engg_Units_Master_Row_dbInfo]]></a>.Value, 95, "HBSADMIN",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601422", "07/07/2025 15:39:56")
    AddProperty("1216", "Base_Unit_Name", <a><![CDATA[Base_Unit_Name]]></a>.Value, "Name for the Base Unit", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/30/2025 12:13:06 PM")
    AddProperty("1217", "Base_Unit_Symbol", <a><![CDATA[Base_Unit_Symbol]]></a>.Value, "Symbol of the Base Unit", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/30/2025 12:13:44 PM")
    AddProperty("1210", "Deleted", <a><![CDATA[Deleted]]></a>.Value, "Deleted Flag", "Boolean","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/30/2025 12:10:56 PM")
    AddProperty("1286", "Engg_Units_Standard_Ref", <a><![CDATA[Engg_Units_Standard_Ref]]></a>.Value, "Which Units Standard Ref is this row for?", "String","","Master Data","FD", 9999, "", 0,0, "HBS", "", "GLOBAL\H601422", "7/7/2025 3:39:26 PM")
    AddProperty("1211", "Is_Active", <a><![CDATA[Is_Active]]></a>.Value, "Is Record Active (Not Obsolute)", "Boolean","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/30/2025 12:11:14 PM")
    AddProperty("1218", "Sort_Order", <a><![CDATA[Sort_Order]]></a>.Value, "First Sort Order 0 = Default = 100 , Adjust Accordingly", "Long","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/30/2025 12:14:17 PM")
    AddProperty("1215", "Unit_Of_Measure", <a><![CDATA[Unit_Of_Measure]]></a>.Value, "What the Unit Measures", "String","","Master Data","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/30/2025 12:12:42 PM")
    AddProperty("1214", "Engg_Units_Master_ID", <a><![CDATA[Engg_Units_Master_ID]]></a>.Value, "Primary Key", "Long","","Master Data PK","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/30/2025 12:12:30 PM")
    AddProperty("1207", "Created_By", <a><![CDATA[Created_By]]></a>.Value, "User that created the record", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/30/2025 12:09:07 PM")
    AddProperty("1208", "Created_On", <a><![CDATA[Created_On]]></a>.Value, "Date User Created record", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/30/2025 12:09:40 PM")
    AddProperty("1209", "Data_Hash", <a><![CDATA[Data_Hash]]></a>.Value, "Hash of Master Data Fields", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/30/2025 12:10:16 PM")
    AddProperty("1212", "Modified_By", <a><![CDATA[Modified_By]]></a>.Value, "User that modified the record", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/30/2025 12:11:51 PM")
    AddProperty("1213", "Modified_On", <a><![CDATA[Modified_On]]></a>.Value, "Date modified", "String","","Master DBInfo","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/30/2025 12:12:14 PM")
    AddProperty("1189", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/30/2025 12:00:31 PM")
    
      AddDBConstraint(33, "dbInfo", <a><![CDATA[dbInfo]]></a>.Value,"Master DBInfo", 9999)
    
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
          InitProperty("Base_Unit_Name", "1123", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/30/2025 12:13:06 PM", "Name for the Base Unit", "In Development",  0,2146)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Base_Unit_Symbol", "1124", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/30/2025 12:13:44 PM", "Symbol of the Base Unit", "In Development",  0,2147)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Deleted", "1117", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/30/2025 12:10:56 PM", "Deleted Flag", "In Development",  0,2140)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Engg_Units_Standard_Ref", "1187", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601422", "7/7/2025 3:39:26 PM", "Symbol of the Base Unit", "In Development",  0,2250)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Is_Active", "1118", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/30/2025 12:11:14 PM", "Is Record Active (Not Obsolute)", "In Development",  0,2141)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Order", "1125", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/30/2025 12:14:17 PM", "First Sort Order 0 = Default = 100 , Adjust Accordingly", "In Development",  0,2148)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Unit_Of_Measure", "1122", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/30/2025 12:12:42 PM", "What the Unit Measures", "In Development",  0,2145)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Engg_Units_Master_ID", "1121", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/30/2025 12:12:30 PM", "Primary Key", "In Development",  0,2144)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Created_By", "1114", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/30/2025 12:09:07 PM", "User that created the record", "In Development",  0,2137)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Created_On", "1115", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/30/2025 12:09:40 PM", "Date User Created record", "In Development",  0,2138)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Data_Hash", "1116", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/30/2025 12:10:16 PM", "Hash of Master Data Fields", "In Development",  0,2139)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Modified_By", "1119", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/30/2025 12:11:51 PM", "User that modified the record", "In Development",  0,2142)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Modified_On", "1120", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/30/2025 12:12:14 PM", "Date modified", "In Development",  0,2143)
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
          
        InitDBConstraint("dbInfo", 33,"", "Y","", "", "Engg_Units_Master")
        
          InitDBproperty("dbInfo", "Base_Unit_Name",33, "Base_Unit_Name", "Engg_Units_Master")
        
          InitDBproperty("dbInfo", "Base_Unit_Symbol",33, "Base_Unit_Symbol", "Engg_Units_Master")
        
          InitDBproperty("dbInfo", "Created_By",33, "Created_By", "Engg_Units_Master")
        
          InitDBproperty("dbInfo", "Created_On",33, "Created_On", "Engg_Units_Master")
        
          InitDBproperty("dbInfo", "Deleted",33, "Deleted", "Engg_Units_Master")
        
          InitDBproperty("dbInfo", "Engg_Units_Standard_Ref",33, "Engg_Units_Standard_Ref", "Engg_Units_Master")
        
          InitDBproperty("dbInfo", "Is_Active",33, "Is_Active", "Engg_Units_Master")
        
          InitDBproperty("dbInfo", "Modified_By",33, "Modified_By", "Engg_Units_Master")
        
          InitDBproperty("dbInfo", "Modified_On",33, "Modified_On", "Engg_Units_Master")
        
          InitDBproperty("dbInfo", "Sort_Order",33, "Sort_Order", "Engg_Units_Master")
        
          InitDBproperty("dbInfo", "Unit_Of_Measure",33, "Unit_Of_Measure", "Engg_Units_Master")
        
          End If
        
    End Sub

    #End Region

    #Region " Formulas "

    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Base_Unit_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Base_Unit_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1123; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1123; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Engg_Units_Master_Row_dbInfo.Formula_Base_Unit_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Base_Unit_Symbol() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Base_Unit_Symbol").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1124; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1124; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Engg_Units_Master_Row_dbInfo.Formula_Base_Unit_Symbol", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1117; TYPE:PF
      result = False
      '   END FORMULA; PROP ID:1117; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Engg_Units_Master_Row_dbInfo.Formula_Deleted", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Engg_Units_Standard_Ref() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Engg_Units_Standard_Ref").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1187; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:1187; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Engg_Units_Master_Row_dbInfo.Formula_Engg_Units_Standard_Ref", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1118; TYPE:PF
      result = True
      '   END FORMULA; PROP ID:1118; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Engg_Units_Master_Row_dbInfo.Formula_Is_Active", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1125; TYPE:PF
      result = 100
      '   END FORMULA; PROP ID:1125; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Engg_Units_Master_Row_dbInfo.Formula_Sort_Order", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Unit_Of_Measure() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Unit_Of_Measure").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1122; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1122; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Engg_Units_Master_Row_dbInfo.Formula_Unit_Of_Measure", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Engg_Units_Master_ID() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Engg_Units_Master_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1121; TYPE:PF
      result = Me.Parent.Properties("Engg_Units_Master_ID").Value
      '   END FORMULA; PROP ID:1121; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Engg_Units_Master_Row_dbInfo.Formula_Engg_Units_Master_ID", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1114; TYPE:PF
      result = "ERROR"
      '   END FORMULA; PROP ID:1114; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Engg_Units_Master_Row_dbInfo.Formula_Created_By", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1115; TYPE:PF
      result = nothing
      '   END FORMULA; PROP ID:1115; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Engg_Units_Master_Row_dbInfo.Formula_Created_On", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1116; TYPE:PF
      Result = ""

For Each p As PropertySF In Me.properties
	If P.CategoryName.Trim().ToLower() = "master data" Or P.CategoryName.Trim().ToLower() = "master data pk"Then
		Result = Result & $"{P.Value}".Tolower() & ";"
	End If
Next P
      '   END FORMULA; PROP ID:1116; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Engg_Units_Master_Row_dbInfo.Formula_Data_Hash", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1119; TYPE:PF
      result = "ERROR"
      '   END FORMULA; PROP ID:1119; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Engg_Units_Master_Row_dbInfo.Formula_Modified_By", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1120; TYPE:PF
      result = nothing
      '   END FORMULA; PROP ID:1120; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Engg_Units_Master_Row_dbInfo.Formula_Modified_On", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Base_Unit_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Base_Unit_Symbol_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Engg_Units_Standard_Ref_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Unit_Of_Measure_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Engg_Units_Master_ID_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Base_Unit_Name_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Base_Unit_Symbol_USERCHANGE() as Boolean
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
      Public Function Formula_Engg_Units_Standard_Ref_USERCHANGE() as Boolean
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
      Public Function Formula_Sort_Order_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unit_Of_Measure_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Engg_Units_Master_ID_USERCHANGE() as Boolean
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
      
        Case 33
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "Base_Unit_Name" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Base_Unit_Symbol" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Created_By" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Created_On" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Deleted" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Engg_Units_Standard_Ref" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Is_Active" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Modified_By" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Modified_On" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Sort_Order" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Unit_Of_Measure" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
                  varPropSpecVal = me.Engg_Units_Master_ID
              BuildWhereClause(strWhereClause, "0", "0", "  ", "[Engg_Units_Master_ID]", "=", varPropSpecVal, "")
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("Engg_Units_Master"), strWhereClause, leftDelimiter & "Engg_Units_Master_ID" & rightDelimiter, "ASC")
          
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Engg_Units_Master_Row_dbInfo.GetRecordset", strError)
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

  