Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: APC_Advanced_Calcs
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

    Public Class [APC_Advanced_Calcs]
    
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

    Private this as APC_Advanced_Calcs = me

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
    
          Public Property [PartNumber]() As String
      Get
      Return Properties("PartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartNumber").CalculatedValue = Value
      End Set
      End Property
    
      Public ReadOnly Property [MDR_Belt_Turn]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("MDR_Belt_Turn")
      End Get
      End Property
    
      Public ReadOnly Property [MDR_BW_Divert]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("MDR_BW_Divert")
      End Get
      End Property
    
      Public ReadOnly Property [MDR_RAT]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("MDR_RAT")
      End Get
      End Property
    
      Public ReadOnly Property [Sort_Choices]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Sort_Choices")
      End Get
      End Property
    
      Public ReadOnly Property [Std_Merge_Sim]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Std_Merge_Sim")
      End Get
      End Property
    
      Public ReadOnly Property [Zip_Test]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Zip_Test")
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
    InitPart("APC_Advanced_Calcs", <a><![CDATA[APC_Advanced_Calcs]]></a>.Value, 162, "APCTMP01",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "06/13/2025 12:27:37")
    AddProperty("925", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/25/2025 1:44:45 AM")
    
      oSubpart = AddSubpart(54,"MDR_Belt_Turn", <a><![CDATA[MDR_Belt_Turn]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (155, "APC_MDR_RAT_Data", "APC_MDR_RAT_Data")
      
      oSubpart = AddSubpart(53,"MDR_BW_Divert", <a><![CDATA[MDR_BW_Divert]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (138, "APC_MDR_RAT", "APC_MDR_RAT")
      
      oSubpart = AddSubpart(52,"MDR_RAT", <a><![CDATA[MDR_RAT]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (138, "APC_MDR_RAT", "APC_MDR_RAT")
      
      oSubpart = AddSubpart(55,"Sort_Choices", <a><![CDATA[Sort_Choices]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (139, "APC_MDR_BW_Divert", "APC_MDR_BW_Divert")
      
      oSubpart = AddSubpart(50,"Std_Merge_Sim", <a><![CDATA[Std_Merge_Sim]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (136, "APC_STD_MergeSim", "APC_STD_MergeSim")
      
      oSubpart = AddSubpart(51,"Zip_Test", <a><![CDATA[Zip_Test]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (137, "APC_ZipTest", "APC_ZipTest")
      
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
          
        InitSubpart("MDR_Belt_Turn", 49, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,116,117)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("MDR_BW_Divert", 48, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,114,115)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("MDR_RAT", 47, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,112,113)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Sort_Choices", 50, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,118,119)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Std_Merge_Sim", 45, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,108,109)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Zip_Test", 46, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,110,111)
        
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
      Public Function Formula_MDR_Belt_Turn_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:49; TYPE:PN
      
      '   END FORMULA; SUB ID:49; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_MDR_Belt_Turn_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_Belt_Turn_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("MDR_Belt_Turn").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:49; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:49; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_MDR_Belt_Turn_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_Belt_Turn_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("MDR_Belt_Turn").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:49; TYPE:OP
      result = "APC_MDR_RAT_Data"
      '   END FORMULA; SUB ID:49; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_MDR_Belt_Turn_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_BW_Divert_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:48; TYPE:PN
      
      '   END FORMULA; SUB ID:48; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_MDR_BW_Divert_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_BW_Divert_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("MDR_BW_Divert").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:48; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:48; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_MDR_BW_Divert_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_BW_Divert_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("MDR_BW_Divert").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:48; TYPE:OP
      result = "APC_MDR_RAT"
      '   END FORMULA; SUB ID:48; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_MDR_BW_Divert_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_RAT_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:47; TYPE:PN
      
      '   END FORMULA; SUB ID:47; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_MDR_RAT_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_RAT_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("MDR_RAT").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:47; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:47; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_MDR_RAT_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_RAT_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("MDR_RAT").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:47; TYPE:OP
      result = "APC_MDR_RAT"
      '   END FORMULA; SUB ID:47; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_MDR_RAT_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Choices_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:50; TYPE:PN
      
      '   END FORMULA; SUB ID:50; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_Sort_Choices_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Choices_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Sort_Choices").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:50; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:50; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_Sort_Choices_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Choices_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Sort_Choices").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:50; TYPE:OP
      result = "APC_MDR_BW_Divert"
      '   END FORMULA; SUB ID:50; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_Sort_Choices_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Std_Merge_Sim_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:45; TYPE:PN
      
      '   END FORMULA; SUB ID:45; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_Std_Merge_Sim_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Std_Merge_Sim_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Std_Merge_Sim").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:45; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:45; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_Std_Merge_Sim_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Std_Merge_Sim_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Std_Merge_Sim").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:45; TYPE:OP
      result = "APC_STD_MergeSim"
      '   END FORMULA; SUB ID:45; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_Std_Merge_Sim_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zip_Test_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:46; TYPE:PN
      
      '   END FORMULA; SUB ID:46; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_Zip_Test_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zip_Test_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Zip_Test").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:46; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:46; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_Zip_Test_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zip_Test_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Zip_Test").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:46; TYPE:OP
      result = "APC_ZipTest"
      '   END FORMULA; SUB ID:46; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Advanced_Calcs.Formula_Zip_Test_OPTIMALPARTFAMILY", ex.Message)
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

  