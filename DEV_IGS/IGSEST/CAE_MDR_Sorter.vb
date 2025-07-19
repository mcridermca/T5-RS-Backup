Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_MDR_Sorter
'$ GenerateDate: 07/18/2025 17:35:28

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
    Imports IGSEST.swMateType_e
    Imports IGSEST.swMateAlign_e
    Imports IGSEST.severity

    Public Class [CAE_MDR_Sorter]
    
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

    Private this as CAE_MDR_Sorter = me

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
    
          Public Property [CAE_MDR_SORTER_MASTER_ID]() As String
      Get
      Return Properties("CAE_MDR_SORTER_MASTER_ID").Value
      End Get
      Set(ByVal Value As String)
      Properties("CAE_MDR_SORTER_MASTER_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Divert_Angle]() As Double
      Get
      Return Properties("Divert_Angle").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Divert_Angle").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Max_Length]() As Double
      Get
      Return Properties("Max_Length").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Max_Length").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Max_Speed]() As Double
      Get
      Return Properties("Max_Speed").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Max_Speed").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Max_Weight]() As Double
      Get
      Return Properties("Max_Weight").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Max_Weight").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Max_Width]() As Double
      Get
      Return Properties("Max_Width").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Max_Width").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MDR_Type]() As String
      Get
      Return Properties("MDR_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("MDR_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Min_Gap]() As Double
      Get
      Return Properties("Min_Gap").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Min_Gap").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Min_Length]() As Double
      Get
      Return Properties("Min_Length").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Min_Length").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Min_Op_Temp]() As Double
      Get
      Return Properties("Min_Op_Temp").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Min_Op_Temp").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Min_Weight]() As Double
      Get
      Return Properties("Min_Weight").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Min_Weight").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Min_Width]() As Double
      Get
      Return Properties("Min_Width").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Min_Width").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sides]() As Double
      Get
      Return Properties("Sides").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sides").CalculatedValue = Value
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
    InitPart("CAE_MDR_Sorter", <a><![CDATA[CAE_MDR_Sorter]]></a>.Value, 438, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H602502", "07/18/2025 16:37:54")
    AddProperty("10699", "CAE_MDR_SORTER_MASTER_ID", <a><![CDATA[CAE_MDR_SORTER_MASTER_ID]]></a>.Value, "Primary Key (System Use Only)", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 4:37:40 PM")
    AddProperty("10693", "Divert_Angle", <a><![CDATA[Divert_Angle]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 3:18:24 PM")
    AddProperty("10690", "Max_Length", <a><![CDATA[Max_Length]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 3:17:57 PM")
    AddProperty("10685", "Max_Speed", <a><![CDATA[Max_Speed]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 3:17:07 PM")
    AddProperty("10692", "Max_Weight", <a><![CDATA[Max_Weight]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 3:18:16 PM")
    AddProperty("10691", "Max_Width", <a><![CDATA[Max_Width]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 3:18:05 PM")
    AddProperty("10684", "MDR_Type", <a><![CDATA[MDR_Type]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 3:16:28 PM")
    AddProperty("10686", "Min_Gap", <a><![CDATA[Min_Gap]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 3:17:19 PM")
    AddProperty("10687", "Min_Length", <a><![CDATA[Min_Length]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 3:17:27 PM")
    AddProperty("10695", "Min_Op_Temp", <a><![CDATA[Min_Op_Temp]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 3:18:42 PM")
    AddProperty("10689", "Min_Weight", <a><![CDATA[Min_Weight]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 3:17:45 PM")
    AddProperty("10688", "Min_Width", <a><![CDATA[Min_Width]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 3:17:35 PM")
    AddProperty("10694", "Sides", <a><![CDATA[Sides]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 3:18:33 PM")
    AddProperty("10679", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 3:11:41 PM")
    
      AddDBConstraint(15, "dbInfo", <a><![CDATA[db Info]]></a>.Value,"General", 9999)
    
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
          InitProperty("CAE_MDR_SORTER_MASTER_ID", "10260", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 4:37:40 PM", "", "In Development",  0,19135)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Divert_Angle", "10255", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 3:18:24 PM", "", "In Development",  0,19117)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Max_Length", "10252", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 3:17:57 PM", "", "In Development",  0,19114)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Max_Speed", "10247", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 3:17:07 PM", "", "In Development",  0,19109)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Max_Weight", "10254", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 3:18:16 PM", "", "In Development",  0,19116)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Max_Width", "10253", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 3:18:05 PM", "", "In Development",  0,19115)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MDR_Type", "10246", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 3:16:28 PM", "", "In Development",  0,19108)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Min_Gap", "10248", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 3:17:19 PM", "", "In Development",  0,19110)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Min_Length", "10249", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 3:17:27 PM", "", "In Development",  0,19111)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Min_Op_Temp", "10257", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 3:18:42 PM", "", "In Development",  0,19119)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Min_Weight", "10251", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 3:17:45 PM", "", "In Development",  0,19113)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Min_Width", "10250", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 3:17:35 PM", "", "In Development",  0,19112)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sides", "10256", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 3:18:33 PM", "", "In Development",  0,19118)
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
          
        InitDBConstraint("dbInfo", 15,"", "Y","", "", "CAE_APC_MDR_Sorters")
        
          InitDBproperty("dbInfo", "Divert_Angle",15, "Divert_Angle", "CAE_APC_MDR_Sorters")
        
          InitDBproperty("dbInfo", "Max_Length",15, "Max_Length", "CAE_APC_MDR_Sorters")
        
          InitDBproperty("dbInfo", "Max_Speed",15, "Max_Speed_", "CAE_APC_MDR_Sorters")
        
          InitDBproperty("dbInfo", "Max_Weight",15, "Max_Weight", "CAE_APC_MDR_Sorters")
        
          InitDBproperty("dbInfo", "Max_Width",15, "Max_Width", "CAE_APC_MDR_Sorters")
        
          InitDBproperty("dbInfo", "Min_Length",15, "Min_Length", "CAE_APC_MDR_Sorters")
        
          InitDBproperty("dbInfo", "Min_Op_Temp",15, "Min_Op_Temp_°F", "CAE_APC_MDR_Sorters")
        
          InitDBproperty("dbInfo", "Min_Weight",15, "Min_Weight", "CAE_APC_MDR_Sorters")
        
          InitDBproperty("dbInfo", "Min_Width",15, "Min_Width", "CAE_APC_MDR_Sorters")
        
          End If
        
    End Sub

    #End Region

    #Region " Formulas "

    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CAE_MDR_SORTER_MASTER_ID() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CAE_MDR_SORTER_MASTER_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10260; TYPE:PF
      Result = Me.Parent.ValidValues("Qty_MDR_Sorter_Row_DBKeys")(Me.SubpartID-1)
      '   END FORMULA; PROP ID:10260; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_MDR_Sorter.Formula_CAE_MDR_SORTER_MASTER_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Divert_Angle() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Divert_Angle").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10255; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10255; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_MDR_Sorter.Formula_Divert_Angle", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Max_Length() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Max_Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10252; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10252; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_MDR_Sorter.Formula_Max_Length", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Max_Speed() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Max_Speed").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10247; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10247; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_MDR_Sorter.Formula_Max_Speed", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Max_Weight() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Max_Weight").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10254; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10254; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_MDR_Sorter.Formula_Max_Weight", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Max_Width() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Max_Width").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10253; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10253; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_MDR_Sorter.Formula_Max_Width", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MDR_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MDR_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10246; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:10246; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_MDR_Sorter.Formula_MDR_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Min_Gap() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Min_Gap").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10248; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10248; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_MDR_Sorter.Formula_Min_Gap", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Min_Length() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Min_Length").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10249; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10249; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_MDR_Sorter.Formula_Min_Length", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Min_Op_Temp() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Min_Op_Temp").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10257; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10257; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_MDR_Sorter.Formula_Min_Op_Temp", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Min_Weight() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Min_Weight").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10251; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10251; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_MDR_Sorter.Formula_Min_Weight", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Min_Width() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Min_Width").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10250; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10250; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_MDR_Sorter.Formula_Min_Width", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sides() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sides").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10256; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10256; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_MDR_Sorter.Formula_Sides", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CAE_MDR_SORTER_MASTER_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Divert_Angle_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Max_Length_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Max_Speed_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Max_Weight_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Max_Width_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Min_Gap_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Min_Length_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Min_Op_Temp_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Min_Weight_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Min_Width_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sides_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CAE_MDR_SORTER_MASTER_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Divert_Angle_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Max_Length_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Max_Speed_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Max_Weight_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Max_Width_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Min_Gap_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Min_Length_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Min_Op_Temp_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Min_Weight_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Min_Width_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sides_USERCHANGE() as Boolean
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
      
        Case 15
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "Divert_Angle" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Max_Length" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Max_Speed_" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Max_Weight" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Max_Width" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Min_Length" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Min_Op_Temp_°F" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Min_Weight" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Min_Width" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
                  varPropSpecVal = me.CAE_MDR_SORTER_MASTER_ID
              BuildWhereClause(strWhereClause, "0", "0", "  ", "[Types]", "=", varPropSpecVal, "")
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("CAE_APC_MDR_Sorters"), strWhereClause, leftDelimiter & "" & rightDelimiter, "")
          
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " CAE_MDR_Sorter.GetRecordset", strError)
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

  