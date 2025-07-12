Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS_Demo
'$ PartFamily: Controller_DBDetail
'$ GenerateDate: 03/03/2025 14:37:41

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

    Public Class [Controller_DBDetail]
    
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

    Private this as Controller_DBDetail = me

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
    
          Public Property [ConfigurablePortQuantity]() As Long
      Get
      Return Properties("ConfigurablePortQuantity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("ConfigurablePortQuantity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ConfigurablePortsOptions]() As String
      Get
      Return Properties("ConfigurablePortsOptions").Value
      End Get
      Set(ByVal Value As String)
      Properties("ConfigurablePortsOptions").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ConfigurablePortType]() As String
      Get
      Return Properties("ConfigurablePortType").Value
      End Get
      Set(ByVal Value As String)
      Properties("ConfigurablePortType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ConfigurablePortTypeLimits]() As String
      Get
      Return Properties("ConfigurablePortTypeLimits").Value
      End Get
      Set(ByVal Value As String)
      Properties("ConfigurablePortTypeLimits").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ConfigurablePortTypeNames]() As String
      Get
      Return Properties("ConfigurablePortTypeNames").Value
      End Get
      Set(ByVal Value As String)
      Properties("ConfigurablePortTypeNames").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerPartNumber]() As String
      Get
      Return Properties("ControllerPartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("ControllerPartNumber").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CPU_IOType]() As String
      Get
      Return Properties("CPU_IOType").Value
      End Get
      Set(ByVal Value As String)
      Properties("CPU_IOType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DefaultQuantity]() As Long
      Get
      Return Properties("DefaultQuantity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("DefaultQuantity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Family]() As String
      Get
      Return Properties("Family").Value
      End Get
      Set(ByVal Value As String)
      Properties("Family").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Mnemonic]() As String
      Get
      Return Properties("Mnemonic").Value
      End Get
      Set(ByVal Value As String)
      Properties("Mnemonic").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Mount]() As String
      Get
      Return Properties("Mount").Value
      End Get
      Set(ByVal Value As String)
      Properties("Mount").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PartDescription]() As String
      Get
      Return Properties("PartDescription").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartDescription").CalculatedValue = Value
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
    
          Public Property [UplinkPortQuantity]() As Long
      Get
      Return Properties("UplinkPortQuantity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("UplinkPortQuantity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [UplinkPortType]() As String
      Get
      Return Properties("UplinkPortType").Value
      End Get
      Set(ByVal Value As String)
      Properties("UplinkPortType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [UplinkPortTypeLimits]() As String
      Get
      Return Properties("UplinkPortTypeLimits").Value
      End Get
      Set(ByVal Value As String)
      Properties("UplinkPortTypeLimits").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [UplinkPortTypeNames]() As String
      Get
      Return Properties("UplinkPortTypeNames").Value
      End Get
      Set(ByVal Value As String)
      Properties("UplinkPortTypeNames").CalculatedValue = Value
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
    InitPart("Controller_DBDetail", <a><![CDATA[Controller_DBDetail]]></a>.Value, 11, "HBS_Demo",  "N", "N", True, False, "In Development", "", "", "", "", "",  "GLOBAL\SVRSDevAdmin", "02/28/2025 12:05:32")
    AddProperty("138", "ConfigurablePortQuantity", <a><![CDATA[Configurable Port Quantity]]></a>.Value, "The number of configurable ports on this controller.", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:18:49 AM")
    AddProperty("139", "ConfigurablePortsOptions", <a><![CDATA[Configurable Ports Options]]></a>.Value, "The options for the configurable port(s) on this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:19:02 AM")
    AddProperty("140", "ConfigurablePortType", <a><![CDATA[Configurable Port Type]]></a>.Value, "The type of configurable port(s) on this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:19:06 AM")
    AddProperty("141", "ConfigurablePortTypeLimits", <a><![CDATA[Configurable Port Type Limits]]></a>.Value, "The type limits of the configurable port(s) on this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:19:21 AM")
    AddProperty("142", "ConfigurablePortTypeNames", <a><![CDATA[Configurable Port Type Names]]></a>.Value, "The type names of the configurable port(s) on this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:19:42 AM")
    AddProperty("143", "ControllerPartNumber", <a><![CDATA[Controller Part Number]]></a>.Value, "The part number or code for this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 12:55:50 AM")
    AddProperty("144", "CPU_IOType", <a><![CDATA[CPU IO Type]]></a>.Value, "The IO type for the controller's CPU.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:19:50 AM")
    AddProperty("145", "DefaultQuantity", <a><![CDATA[Default Quantity]]></a>.Value, "The default quantity for this controller.", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:19:57 AM")
    AddProperty("146", "Family", <a><![CDATA[Family]]></a>.Value, "The family this controller belongs to.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 12:51:12 AM")
    AddProperty("147", "Mnemonic", <a><![CDATA[Mnemonic]]></a>.Value, "The mnemonic for this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:20:08 AM")
    AddProperty("148", "Mount", <a><![CDATA[Mount]]></a>.Value, "Where this controller is mounted.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:20:12 AM")
    AddProperty("149", "PartDescription", <a><![CDATA[Part Description]]></a>.Value, "Description of the part for this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:20:17 AM")
    AddProperty("150", "Pole", <a><![CDATA[Pole]]></a>.Value, "The super-region or collection of regions this controller belongs to.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:20:23 AM")
    AddProperty("151", "UplinkPortQuantity", <a><![CDATA[Uplink Port Quantity]]></a>.Value, "The quantity of uplink ports for this controller.", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:20:29 AM")
    AddProperty("152", "UplinkPortType", <a><![CDATA[Uplink Port Type]]></a>.Value, "The type of uplink port for this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:20:34 AM")
    AddProperty("159", "UplinkPortTypeLimits", <a><![CDATA[Uplink Port Type Limits]]></a>.Value, "The names of the uplink ports of this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:21:41 AM")
    AddProperty("154", "UplinkPortTypeNames", <a><![CDATA[Uplink Port Type Names]]></a>.Value, "The names of the uplink ports of this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:20:42 AM")
    AddProperty("137", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 12:51:12 AM")
    
      AddDBConstraint(2, "dbControllersTable", <a><![CDATA[dbControllersTable]]></a>.Value,"Database Lookup", 9999)
    
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
          InitProperty("ConfigurablePortQuantity", "133", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:18:49 AM", "", "In Development",  0,365)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ConfigurablePortsOptions", "134", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:19:02 AM", "", "In Development",  0,366)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ConfigurablePortType", "135", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:19:06 AM", "", "In Development",  0,367)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ConfigurablePortTypeLimits", "136", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:19:21 AM", "", "In Development",  0,368)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ConfigurablePortTypeNames", "137", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:19:42 AM", "", "In Development",  0,369)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerPartNumber", "128", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 12:55:40 AM", "", "In Development",  0,344)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CPU_IOType", "138", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:19:50 AM", "", "In Development",  0,370)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DefaultQuantity", "139", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:19:57 AM", "", "In Development",  0,371)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Family", "127", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 12:51:12 AM", "", "In Development",  0,343)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Mnemonic", "140", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:20:08 AM", "", "In Development",  0,372)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Mount", "141", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:20:12 AM", "", "In Development",  0,373)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartDescription", "142", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:20:17 AM", "", "In Development",  0,374)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pole", "143", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:20:23 AM", "", "In Development",  0,375)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UplinkPortQuantity", "144", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:20:29 AM", "", "In Development",  0,376)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UplinkPortType", "145", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:20:34 AM", "", "In Development",  0,377)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UplinkPortTypeLimits", "148", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:21:29 AM", "", "In Development",  0,380)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UplinkPortTypeNames", "147", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:20:42 AM", "", "In Development",  0,379)
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
          
        InitDBConstraint("dbControllersTable", 2,"", "Y","", "", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "ConfigurablePortQuantity",2, "CONFIGURABLE PORT QTY", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "ConfigurablePortsOptions",2, "OPTIONS FOR CONFIGURABLE PORTS", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "ConfigurablePortType",2, "CONFIGURABLE PORT TYPE", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "ConfigurablePortTypeLimits",2, "CONFIGURABLE PORT TYPE LIMITS", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "ConfigurablePortTypeNames",2, "DOWNLINK PORT TYPE NAMES", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "CPU_IOType",2, "cpu  Io type", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "DefaultQuantity",2, "Default Part Qty", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "Family",2, "Controller Family", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "Mnemonic",2, "Controller Mnemonic", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "Mount",2, "Mount", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "PartDescription",2, "Part Description", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "Pole",2, "Pole", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "UplinkPortQuantity",2, "UPLINK PORT QTY", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "UplinkPortType",2, "UPLINK PORT TYPE", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "UplinkPortTypeLimits",2, "UPLINK PORT TYPE LIMITS", "vw_ControllersTable_Demo")
        
          InitDBproperty("dbControllersTable", "UplinkPortTypeNames",2, "UPLINK PORT TYPE NAMES", "vw_ControllersTable_Demo")
        
          End If
        
    End Sub

    #End Region

    #Region " Formulas "

    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ConfigurablePortQuantity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ConfigurablePortQuantity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:133; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:133; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_ConfigurablePortQuantity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ConfigurablePortsOptions() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ConfigurablePortsOptions").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:134; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:134; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_ConfigurablePortsOptions", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ConfigurablePortType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ConfigurablePortType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:135; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:135; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_ConfigurablePortType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ConfigurablePortTypeLimits() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ConfigurablePortTypeLimits").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:136; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:136; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_ConfigurablePortTypeLimits", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ConfigurablePortTypeNames() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ConfigurablePortTypeNames").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:137; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:137; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_ConfigurablePortTypeNames", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerPartNumber() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerPartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:128; TYPE:PF
      Result = Me.Parent.ControllerPartNumber
      '   END FORMULA; PROP ID:128; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_ControllerPartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CPU_IOType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CPU_IOType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:138; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:138; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_CPU_IOType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DefaultQuantity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DefaultQuantity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:139; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:139; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_DefaultQuantity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Family() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Family").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:127; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:127; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_Family", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Mnemonic() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Mnemonic").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:140; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:140; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_Mnemonic", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Mount() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Mount").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:141; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:141; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_Mount", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PartDescription() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PartDescription").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:142; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:142; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_PartDescription", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:143; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:143; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_Pole", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_UplinkPortQuantity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("UplinkPortQuantity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:144; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:144; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_UplinkPortQuantity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_UplinkPortType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("UplinkPortType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:145; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:145; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_UplinkPortType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_UplinkPortTypeLimits() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("UplinkPortTypeLimits").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:148; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:148; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_UplinkPortTypeLimits", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_UplinkPortTypeNames() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("UplinkPortTypeNames").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:147; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:147; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.Formula_UplinkPortTypeNames", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortQuantity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortsOptions_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortTypeLimits_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortTypeNames_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerPartNumber_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CPU_IOType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DefaultQuantity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Family_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mnemonic_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mount_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartDescription_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_UplinkPortQuantity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortTypeLimits_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortTypeNames_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortQuantity_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortsOptions_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortType_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortTypeLimits_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortTypeNames_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerPartNumber_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CPU_IOType_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DefaultQuantity_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Family_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mnemonic_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mount_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartDescription_USERCHANGE() as Boolean
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
      Public Function Formula_UplinkPortQuantity_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortType_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortTypeLimits_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortTypeNames_USERCHANGE() as Boolean
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
      
        Case 2
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "CONFIGURABLE PORT QTY" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "OPTIONS FOR CONFIGURABLE PORTS" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "CONFIGURABLE PORT TYPE" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "CONFIGURABLE PORT TYPE LIMITS" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "DOWNLINK PORT TYPE NAMES" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "cpu  Io type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Default Part Qty" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Controller Family" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Controller Mnemonic" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Mount" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Part Description" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Pole" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "UPLINK PORT QTY" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "UPLINK PORT TYPE" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "UPLINK PORT TYPE LIMITS" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "UPLINK PORT TYPE NAMES" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
                  varPropSpecVal = me.ControllerPartNumber
              BuildWhereClause(strWhereClause, "0", "0", "  ", "[Part Number]", "=", varPropSpecVal, "")
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("vw_ControllersTable_Demo"), strWhereClause, leftDelimiter & "Display_1" & rightDelimiter, "ASC")
          
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " Controller_DBDetail.GetRecordset", strError)
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

  