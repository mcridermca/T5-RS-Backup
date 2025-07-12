Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS_Demo
'$ PartFamily: Controller
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

    Public Class [Controller]
    
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

    Private this as Controller = me

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
    
          Public Property [IsStandardPart]() As Boolean
      Get
      Return Properties("IsStandardPart").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("IsStandardPart").CalculatedValue = Value
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
    
      Public ReadOnly Property [Controller_DBDetails]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Controller_DBDetails")
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
    InitPart("Controller", <a><![CDATA[Controller]]></a>.Value, 6, "HBS_Demo",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\SVRSDevAdmin", "02/28/2025 12:04:59")
    AddProperty("56", "ConfigurablePortQuantity", <a><![CDATA[Configurable Port Quantity]]></a>.Value, "The number of configurable ports on this controller.", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:10:00 AM")
    AddProperty("59", "ConfigurablePortsOptions", <a><![CDATA[Configurable Ports Options]]></a>.Value, "The options for the configurable port(s) on this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:10:26 AM")
    AddProperty("55", "ConfigurablePortType", <a><![CDATA[Configurable Port Type]]></a>.Value, "The type of configurable port(s) on this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:10:32 AM")
    AddProperty("158", "ConfigurablePortTypeLimits", <a><![CDATA[Configurable Port Type Limits]]></a>.Value, "The type names of the configurable port(s) on this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:12:13 AM")
    AddProperty("57", "ConfigurablePortTypeNames", <a><![CDATA[Configurable Port Type Names]]></a>.Value, "The type names of the configurable port(s) on this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:11:24 AM")
    AddProperty("43", "ControllerPartNumber", <a><![CDATA[Controller Part Number]]></a>.Value, "The part number or code for this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:31:27 AM")
    AddProperty("49", "CPU_IOType", <a><![CDATA[CPU IO Type]]></a>.Value, "The IO type for the controller's CPU.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:12:42 AM")
    AddProperty("46", "DefaultQuantity", <a><![CDATA[Default Quantity]]></a>.Value, "The default quantity for this controller.", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:12:58 AM")
    AddProperty("42", "Family", <a><![CDATA[Family]]></a>.Value, "The family this controller belongs to.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:13:04 AM")
    AddProperty("157", "IsStandardPart", <a><![CDATA[IsStandardPart]]></a>.Value, "Determines if the part number is a standard part number, or an ad-hoc part number", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:04:58 AM")
    AddProperty("47", "Mnemonic", <a><![CDATA[Mnemonic]]></a>.Value, "The mnemonic for this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:13:11 AM")
    AddProperty("48", "Mount", <a><![CDATA[Mount]]></a>.Value, "Where this controller is mounted.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:56:57 AM")
    AddProperty("45", "PartDescription", <a><![CDATA[Part Description]]></a>.Value, "Description of the part for this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:13:22 AM")
    AddProperty("44", "Pole", <a><![CDATA[Pole]]></a>.Value, "The super-region or collection of regions this controller belongs to.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:57:57 AM")
    AddProperty("51", "UplinkPortQuantity", <a><![CDATA[Uplink Port Quantity]]></a>.Value, "The quantity of uplink ports for this controller.", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:13:45 AM")
    AddProperty("50", "UplinkPortType", <a><![CDATA[Uplink Port Type]]></a>.Value, "The type of uplink port for this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:13:50 AM")
    AddProperty("160", "UplinkPortTypeLimits", <a><![CDATA[Uplink Port Type Limits]]></a>.Value, "The names of the uplink ports of this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:28:25 AM")
    AddProperty("52", "UplinkPortTypeNames", <a><![CDATA[Uplink Port Type Names]]></a>.Value, "The names of the uplink ports of this controller.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:14:14 AM")
    AddProperty("6", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/21/2025 7:02:11 PM")
    
      AddPropertyExtended(59,"ConfigurablePortsOptions", "52", "EXTLABEL", "Label", "Options for Configurable Ports", "GLOBAL\SVRSDevAdmin", "2/28/2025 1:10:26 AM")
    
      AddValidValue("ControllerPartNumber")
    
      AddValidValue("Mount")
    
      AddValidValue("Pole")
    
      AddValidValue("UplinkPortQuantity")
    
      oSubpart = AddSubpart(9,"Controller_DBDetails", <a><![CDATA[Controller_DBDetails]]></a>.Value, "FD", "", "Subparts and Connections", 9999, "", "GLOBAL\SVRSDevAdmin", "2/28/2025 12:04:59 PM")
      
        oSubpart.AddVPF (11, "Controller_DBDetail", "Controller_DBDetail")
      
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
          InitProperty("ConfigurablePortQuantity", "49", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:10:00 AM", "", "In Development",  0,351)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ConfigurablePortsOptions", "52", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:10:26 AM", "", "In Development",  0,352)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ConfigurablePortType", "48", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:10:32 AM", "", "In Development",  0,353)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ConfigurablePortTypeLimits", "132", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:12:09 AM", "", "In Development",  0,355)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ConfigurablePortTypeNames", "50", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:11:24 AM", "", "In Development",  0,354)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerPartNumber", "36", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:31:27 AM", "", "In Development",  0,382)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CPU_IOType", "42", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:12:42 AM", "", "In Development",  0,356)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DefaultQuantity", "39", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:12:58 AM", "", "In Development",  0,357)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Family", "35", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:13:04 AM", "", "In Development",  0,358)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("IsStandardPart", "131", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:04:16 AM", "", "In Development",  0,349)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Mnemonic", "40", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:13:11 AM", "", "In Development",  0,359)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Mount", "41", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:56:57 AM", "", "In Development",  0,116)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartDescription", "38", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:13:22 AM", "", "In Development",  0,360)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Pole", "37", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:57:57 AM", "", "In Development",  0,119)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UplinkPortQuantity", "44", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:13:45 AM", "", "In Development",  0,361)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UplinkPortType", "43", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:13:50 AM", "", "In Development",  0,362)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UplinkPortTypeLimits", "149", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:28:22 AM", "", "In Development",  0,381)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UplinkPortTypeNames", "45", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 1:14:08 AM", "", "In Development",  0,364)
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
            If Incontext("-1", ctx) Then
          
        InitValidValue("ControllerPartNumber_ValidValues", "36", "-1", 286)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Mount_ValidValues", "41", "-1", 117)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Pole_ValidValues", "37", "-1", 115)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("UplinkPortQuantity_ValidValues", "44", "-1", 83)
        End If
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
          
        InitSubpart("Controller_DBDetails", 9, "", "", "Y", 0, "-1", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 12:49:39 AM", "", "In Development", "N",0,20,19)
        
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
          Public Function Formula_ConfigurablePortQuantity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ConfigurablePortQuantity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:49; TYPE:PF
      Result = 0

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Controller_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Controller_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Controller_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Controller_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Controller_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Controller_DBDetails.Quantity >= 1 Then
		Result = Me.Controller_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:49; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ConfigurablePortQuantity", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:52; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Controller_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Controller_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Controller_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Controller_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Controller_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Controller_DBDetails.Quantity >= 1 Then
		Result = Me.Controller_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:52; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ConfigurablePortsOptions", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:48; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Controller_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Controller_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Controller_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Controller_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Controller_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Controller_DBDetails.Quantity >= 1 Then
		Result = Me.Controller_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:48; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ConfigurablePortType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:132; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Controller_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Controller_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Controller_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Controller_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Controller_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Controller_DBDetails.Quantity >= 1 Then
		Result = Me.Controller_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:132; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ConfigurablePortTypeLimits", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:50; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Controller_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Controller_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Controller_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Controller_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Controller_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Controller_DBDetails.Quantity >= 1 Then
		Result = Me.Controller_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:50; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ConfigurablePortTypeNames", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:36; TYPE:PF
      Result = Me.Parent.ControllerDefaultPartNumber
      '   END FORMULA; PROP ID:36; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ControllerPartNumber", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:42; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Controller_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Controller_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Controller_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Controller_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Controller_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Controller_DBDetails.Quantity >= 1 Then
		Result = Me.Controller_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:42; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_CPU_IOType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:39; TYPE:PF
      Result = 1

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Controller_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Controller_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Controller_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Controller_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Controller_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Controller_DBDetails.Quantity >= 1 Then
		Result = Me.Controller_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:39; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_DefaultQuantity", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:35; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Controller_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Controller_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Controller_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Controller_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Controller_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Controller_DBDetails.Quantity >= 1 Then
		Result = Me.Controller_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:35; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Family", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_IsStandardPart() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("IsStandardPart").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:131; TYPE:PF
      Result = False

If Me.Controller_DBDetails.Quantity > 0 Then
	'If The Part number exists in a database spec / lookup, then it is a standard part for this demo
	If Me.Controller_DBDetails(1).ControllerPartNumber.Trim().ToLower() = Me.ControllerPartNumber.Trim().ToLower()
		Result = True
	End If
End If
      '   END FORMULA; PROP ID:131; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_IsStandardPart", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:40; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Controller_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Controller_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Controller_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Controller_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Controller_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Controller_DBDetails.Quantity >= 1 Then
		Result = Me.Controller_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:40; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Mnemonic", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:41; TYPE:PF
      Result = Me.ValidValues("Mount").FirstValue
'Default to first ValidValue.
      '   END FORMULA; PROP ID:41; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Mount", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:38; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Controller_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Controller_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Controller_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Controller_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Controller_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Controller_DBDetails.Quantity >= 1 Then
		Result = Me.Controller_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:38; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_PartDescription", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:37; TYPE:PF
      Result = Me.ValidValues("Pole").FirstValue
'Default of to first ValidValue.
      '   END FORMULA; PROP ID:37; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Pole", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:44; TYPE:PF
      Result = 1
'Always 1


'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Controller_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Controller_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Controller_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Controller_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Controller_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Controller_DBDetails.Quantity >= 1 Then
		Result = Me.Controller_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:44; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_UplinkPortQuantity", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:43; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Controller_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Controller_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Controller_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Controller_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Controller_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Controller_DBDetails.Quantity >= 1 Then
		Result = Me.Controller_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:43; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_UplinkPortType", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:149; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Controller_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Controller_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Controller_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Controller_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Controller_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Controller_DBDetails.Quantity >= 1 Then
		Result = Me.Controller_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:149; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_UplinkPortTypeLimits", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:45; TYPE:PF
      Result = ""

'Pattern: Me.PropertyX =  OtherPartFamily.PropertyX.Value Pattern
' Mirrors properties values from another property without requiring hard coded property names
' Allows for fast copy paste implementation

Dim Debug As Boolean = False
Dim MyPropertyName As String = CurrentProperty.Name.Trim()

If Me.IsStandardPart AndAlso Me.Controller_DBDetails.Quantity >= 1 Then
	If Debug Then
		MessageBox.Show("DB #: " & Me.Controller_DBDetails.Quantity)
		MessageBox.Show("DB # Name: " & Me.Controller_DBDetails(1).Name)
		MessageBox.Show("Property Name: " & MyPropertyName)
		
		If Me.Controller_DBDetails(1).Properties.ContainsKey(MyPropertyName) Then
			MessageBox.Show("Found Property: " &  MyPropertyName)
		Else
			MessageBox.Show("Property Missing: " &  MyPropertyName)
	    End If
		MessageBox.Show("Value: " & Me.Controller_DBDetails(1).Properties(MyPropertyName).Value)
	End If
	
	'Production Code
	If Me.Controller_DBDetails.Quantity >= 1 Then
		Result = Me.Controller_DBDetails(1).Properties(MyPropertyName).Value
	End If
End If
      '   END FORMULA; PROP ID:45; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_UplinkPortTypeNames", ex.Message)
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
      Public Function Formula_IsStandardPart_HIDE_CALCULATED_VALUE() as Boolean
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
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortsOptions_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortTypeLimits_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ConfigurablePortTypeNames_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerPartNumber_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CPU_IOType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DefaultQuantity_USERCHANGE() as Boolean
      Return True
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
      Public Function Formula_IsStandardPart_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mnemonic_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mount_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartDescription_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pole_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortQuantity_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortTypeLimits_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortTypeNames_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerPartNumber_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerPartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:36; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_ControllersTable_Demo]", "[Part Number]", "[Display_1]", " ORDER BY [Display_1]")
      '   END FORMULA; PROP ID:36; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_ControllerPartNumber_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mount_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Mount").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:41; TYPE:VV
      Result = MakeValidValues(Array("Panel"))
'Options can exist, currently only "Panel"
      '   END FORMULA; PROP ID:41; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Mount_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pole_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Pole").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:37; TYPE:VV
      Result = Rootpart.HBS_Projects(1).ValidValues("Pole")
'Pulls ValidValues from the highest-level Part (HBS_Projects) that has the property.
      '   END FORMULA; PROP ID:37; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Pole_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UplinkPortQuantity_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("UplinkPortQuantity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:44; TYPE:VV
      Result = MakeValidValues(Array(1))
      '   END FORMULA; PROP ID:44; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_UplinkPortQuantity_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_DBDetails_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:9; TYPE:PN
      
      '   END FORMULA; SUB ID:9; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Controller_DBDetails_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_DBDetails_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Controller_DBDetails").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:9; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:9; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Controller_DBDetails_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_DBDetails_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Controller_DBDetails").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:9; TYPE:OP
      result = "Controller_DBDetail"
      '   END FORMULA; SUB ID:9; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Controller.Formula_Controller_DBDetails_OPTIMALPARTFAMILY", ex.Message)
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

  