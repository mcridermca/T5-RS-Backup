Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS_Demo
'$ PartFamily: HBS_System
'$ GenerateDate: 07/21/2025 12:28:57

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
    Imports HBS_Demo.swMateType_e
    Imports HBS_Demo.swMateAlign_e
    Imports HBS_Demo.severity

    Public Class [HBS_System]
    
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

    Private this as HBS_System = me

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
    
          Public Property [SpareCapacityForControllers]() As String
      Get
      Return Properties("SpareCapacityForControllers").Value
      End Get
      Set(ByVal Value As String)
      Properties("SpareCapacityForControllers").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SpareCapacityForPSSizing]() As String
      Get
      Return Properties("SpareCapacityForPSSizing").Value
      End Get
      Set(ByVal Value As String)
      Properties("SpareCapacityForPSSizing").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SystemDescription]() As String
      Get
      Return Properties("SystemDescription").Value
      End Get
      Set(ByVal Value As String)
      Properties("SystemDescription").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SystemName]() As String
      Get
      Return Properties("SystemName").Value
      End Get
      Set(ByVal Value As String)
      Properties("SystemName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [TargetHardware]() As String
      Get
      Return Properties("TargetHardware").Value
      End Get
      Set(ByVal Value As String)
      Properties("TargetHardware").CalculatedValue = Value
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
    
      Public ReadOnly Property [Plants]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Plants")
      End Get
      End Property
    
      Public ReadOnly Property [AllDevices]() As Rulestream.Kernel.Connection
      Get
      Return Connections("AllDevices")
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
    InitPart("HBS_System", <a><![CDATA[HBS System]]></a>.Value, 3, "HBS_Demo",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "06/19/2025 19:41:00")
    AddProperty("72", "SpareCapacityForControllers", <a><![CDATA[Spare Capacity for Controllers]]></a>.Value, "The spare capacity of this system for controllers.", "String","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("70", "SpareCapacityForPSSizing", <a><![CDATA[Spare Capacity for PS Sizing]]></a>.Value, "The spare capacity of this system for PS sizing.", "String","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("16", "SystemDescription", <a><![CDATA[System Description]]></a>.Value, "A description of the system.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("15", "SystemName", <a><![CDATA[System Name]]></a>.Value, "The name of the system.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("17", "TargetHardware", <a><![CDATA[Target Hardware]]></a>.Value, "The target hardware for the system.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("3", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/21/2025 6:56:48 PM")
    
      oSubpart = AddSubpart(3,"Plants", <a><![CDATA[Plants]]></a>.Value, "FD", "The plants (locations) involved.", "Subparts and Connections", 9999, "RuleStream", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:49:29 AM")
      
        oSubpart.AddVPF (4, "Plant", "Plant")
      
      oConnection = AddConnection("AllDevices", <a><![CDATA[All Devices]]></a>.Value, "Every Device in this System.", "2", "OM", 0, "","Subparts and Connections", 9999, "RuleStream", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:48:32 AM")
      
        oConnection.AddVPF(5, "Device")
      
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
          InitProperty("SpareCapacityForControllers", "65", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:38:47 AM", "", "In Development",  0,98)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SpareCapacityForPSSizing", "63", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:38:06 AM", "", "In Development",  0,96)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SystemDescription", "9", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/21/2025 8:28:14 PM", "", "In Development",  0,12)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SystemName", "8", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/21/2025 8:27:49 PM", "", "In Development",  0,11)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("TargetHardware", "10", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/21/2025 8:28:33 PM", "", "In Development",  0,13)
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
          
        InitSubpart("Plants", 3, "", "", "Y", 0, "-1", "", "GLOBAL\SVRSDevAdmin", "2/21/2025 6:59:50 PM", "", "In Development", "Y",0,6,5)
        
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
          
        InitConnection("AllDevices", "2", "","", "Y", 0, "-1", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:48:32 AM", "", "In Development", "Y",6)
        
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
      Public Function Formula_AllDevices_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:2; TYPE:PF
        Result = Nothing

Result = TraverseCollection(Me, "Device", True)
'Traverse the tree
'	Starting from Me (HBS_System)
'	Searching for "Device"
'	Look through Subparts
        '   END FORMULA; CON ID:2; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_System.Formula_AllDevices_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SpareCapacityForControllers() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SpareCapacityForControllers").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:65; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:65; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_System.Formula_SpareCapacityForControllers", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SpareCapacityForPSSizing() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SpareCapacityForPSSizing").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:63; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:63; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_System.Formula_SpareCapacityForPSSizing", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SystemDescription() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SystemDescription").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:9; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_System.Formula_SystemDescription", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SystemName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SystemName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:8; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:8; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_System.Formula_SystemName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_TargetHardware() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("TargetHardware").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:10; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_System.Formula_TargetHardware", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SpareCapacityForControllers_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SpareCapacityForPSSizing_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SystemDescription_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SystemName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TargetHardware_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SpareCapacityForControllers_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SpareCapacityForPSSizing_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SystemDescription_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SystemName_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TargetHardware_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Plants_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:3; TYPE:PN
      
      '   END FORMULA; SUB ID:3; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_System.Formula_Plants_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Plants_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Plants").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:3; TYPE:QF
      Result = 0
      '   END FORMULA; SUB ID:3; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_System.Formula_Plants_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Plants_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Plants").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:3; TYPE:OP
      result = "Plant"
      '   END FORMULA; SUB ID:3; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " HBS_System.Formula_Plants_OPTIMALPARTFAMILY", ex.Message)
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

  