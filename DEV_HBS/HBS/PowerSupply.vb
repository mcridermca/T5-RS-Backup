Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS
'$ PartFamily: PowerSupply
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

    Public Class [PowerSupply]
    
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

    Private this as PowerSupply = me

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
    
      Case "button_RemovePowerSupply_"
      Formula_button_RemovePowerSupply_WHENCHANGED(Value, OldValue)
    
    End Select
    End Sub

    Public Function OnChangedStatus(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String)As Boolean Implements RuleStream.IRsPartFormulas.OnChangedStatus
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Dim Status as Boolean = False
    Select Case specName & "_" & context
    
      Case "button_RemovePowerSupply_"
      'Formula_button_RemovePowerSupply_WHENCHANGED(Value, OldValue)
      Status = True
    Case Else
    Status = False
    End Select
    Return Status
    End Function

    #End Region

    #Region " Properties, Subparts, Connections "
    
          Public Property [ApplicationUse]() As String
      Get
      Return Properties("ApplicationUse").Value
      End Get
      Set(ByVal Value As String)
      Properties("ApplicationUse").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [button_RemovePowerSupply]() As String
      Get
      Return Properties("button_RemovePowerSupply").Value
      End Get
      Set(ByVal Value As String)
      Properties("button_RemovePowerSupply").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CircuitCount]() As Long
      Get
      Return Properties("CircuitCount").Value
      End Get
      Set(ByVal Value As Long)
      Properties("CircuitCount").CalculatedValue = Value
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
    
          Public Shadows Property [DisplayName]() As String
      Get
      Return Properties("DisplayName").Value
      End Get
      Set(ByVal Value As String)
      Properties("DisplayName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [InputVoltage]() As String
      Get
      Return Properties("InputVoltage").Value
      End Get
      Set(ByVal Value As String)
      Properties("InputVoltage").CalculatedValue = Value
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
    
          Public Property [OutputVoltage]() As String
      Get
      Return Properties("OutputVoltage").Value
      End Get
      Set(ByVal Value As String)
      Properties("OutputVoltage").CalculatedValue = Value
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
    
          Public Property [PowerConsumption]() As Double
      Get
      Return Properties("PowerConsumption").Value
      End Get
      Set(ByVal Value As Double)
      Properties("PowerConsumption").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerRating]() As String
      Get
      Return Properties("PowerRating").Value
      End Get
      Set(ByVal Value As String)
      Properties("PowerRating").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerRatingsByCircuit]() As String
      Get
      Return Properties("PowerRatingsByCircuit").Value
      End Get
      Set(ByVal Value As String)
      Properties("PowerRatingsByCircuit").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PowerSupplyIndex]() As Long
      Get
      Return Properties("PowerSupplyIndex").Value
      End Get
      Set(ByVal Value As Long)
      Properties("PowerSupplyIndex").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Qty]() As Long
      Get
      Return Properties("Qty").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Qty").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SafetyMargin]() As Double
      Get
      Return Properties("SafetyMargin").Value
      End Get
      Set(ByVal Value As Double)
      Properties("SafetyMargin").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scope]() As String
      Get
      Return Properties("Scope").Value
      End Get
      Set(ByVal Value As String)
      Properties("Scope").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [SelectedCircuitIndex]() As Long
      Get
      Return Properties("SelectedCircuitIndex").Value
      End Get
      Set(ByVal Value As Long)
      Properties("SelectedCircuitIndex").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Tag]() As String
      Get
      Return Properties("Tag").Value
      End Get
      Set(ByVal Value As String)
      Properties("Tag").CalculatedValue = Value
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
    
      Public ReadOnly Property [Circuits]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Circuits")
      End Get
      End Property
    
      Public ReadOnly Property [Devices]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Devices")
      End Get
      End Property
    
      Public ReadOnly Property [HBSSystem]() As Rulestream.Kernel.Connection
      Get
      Return Connections("HBSSystem")
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
    InitPart("PowerSupply", <a><![CDATA[Power Supply]]></a>.Value, 22, "HBS",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601421", "07/09/2025 04:16:37")
    AddProperty("349", "ApplicationUse", <a><![CDATA[Application Use]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("1183", "button_RemovePowerSupply", <a><![CDATA[button_Remove Power Supply]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/9/2025 3:18:35 AM")
    AddProperty("419", "CircuitCount", <a><![CDATA[Circuit Count]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("1484", "DefaultQuantity", <a><![CDATA[Default Quantity]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/9/2025 4:16:13 AM")
    AddProperty("426", "DisplayName", <a><![CDATA[Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("350", "InputVoltage", <a><![CDATA[Input Voltage]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("680", "Mnemonic", <a><![CDATA[Mnemonic]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/26/2025 4:11:21 AM")
    AddProperty("351", "OutputVoltage", <a><![CDATA[Output Voltage]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("348", "PartDescription", <a><![CDATA[Part Description]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/30/2025 4:01:03 AM")
    AddProperty("855", "PowerConsumption", <a><![CDATA[Power Consumption]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/27/2025 4:39:22 AM")
    AddProperty("364", "PowerRating", <a><![CDATA[Power Rating]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("422", "PowerRatingsByCircuit", <a><![CDATA[Power Ratings By Circuit]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("355", "PowerSupplyIndex", <a><![CDATA[Power Supply Index]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
    AddProperty("809", "Qty", <a><![CDATA[Qty]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/26/2025 4:11:06 AM")
    AddProperty("853", "SafetyMargin", <a><![CDATA[Safety Margin]]></a>.Value, "%", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "7/1/2025 3:20:09 AM")
    AddProperty("810", "Scope", <a><![CDATA[Scope]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/26/2025 2:51:57 AM")
    AddProperty("770", "SelectedCircuitIndex", <a><![CDATA[Selected Circuit Index]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/30/2025 5:31:05 AM")
    AddProperty("681", "Tag", <a><![CDATA[Tag]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601421", "6/30/2025 12:24:23 AM")
    AddProperty("347", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601421", "4/2/2025 8:44:26 PM")
    
      AddPropertyExtended(1183,"button_RemovePowerSupply", "1093", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\H601421", "7/9/2025 3:18:35 AM")
    
      AddValidValue("Scope")
    
      oSubpart = AddSubpart(24,"Circuits", <a><![CDATA[Circuits]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oSubpart.AddVPF (23, "Circuit", "Circuit")
      
      oConnection = AddConnection("Devices", <a><![CDATA[Devices]]></a>.Value, "", "19", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "6/19/2025 7:41:00 PM")
      
        oConnection.AddVPF(5, "Device")
      
      oConnection = AddConnection("HBSSystem", <a><![CDATA[HBS System]]></a>.Value, "", "65", "OO", 0, "","General", 9999, "", "GLOBAL\H601421", "7/9/2025 3:14:48 AM")
      
        oConnection.AddVPF(17, "HBSSystem")
      
      AddDBConstraint(11, "PowerSupplyData", <a><![CDATA[Power Supply Data]]></a>.Value,"General", 9999)
    
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
          InitProperty("ApplicationUse", "327", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/2/2025 10:31:13 PM", "", "In Development",  0,823)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("button_RemovePowerSupply", "1093", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/9/2025 3:18:35 AM", "", "In Development",  0,2097)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CircuitCount", "397", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/8/2025 5:42:41 PM", "", "In Development",  0,966)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DefaultQuantity", "1369", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/9/2025 4:16:13 AM", "", "In Development",  0,2470)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DisplayName", "405", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/8/2025 8:01:37 PM", "", "In Development",  0,976)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("InputVoltage", "328", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/2/2025 10:31:47 PM", "", "In Development",  0,824)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Mnemonic", "635", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/26/2025 4:11:21 AM", "", "In Development",  0,1515)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("OutputVoltage", "329", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/2/2025 10:35:35 PM", "", "In Development",  0,825)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartDescription", "326", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/30/2025 4:01:03 AM", "", "In Development",  0,822)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerConsumption", "792", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/27/2025 4:39:22 AM", "", "In Development",  0,1770)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerRating", "342", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/3/2025 9:09:11 PM", "", "In Development",  0,867)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerRatingsByCircuit", "400", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/9/2025 12:59:55 AM", "", "In Development",  0,989)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PowerSupplyIndex", "333", "", "", "Y", "","", 3, "-1", 0, "", "N","0",  "GLOBAL\H601421", "4/6/2025 4:05:26 AM", "", "In Development",  0,895)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Qty", "749", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/26/2025 4:11:06 AM", "", "In Development",  0,1715)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SafetyMargin", "790", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "7/1/2025 3:20:09 AM", "", "In Development",  0,2202)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scope", "750", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601421", "6/26/2025 2:51:57 AM", "", "In Development",  0,1716)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SelectedCircuitIndex", "714", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/30/2025 5:31:05 AM", "", "In Development",  0,1657)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Tag", "636", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601421", "6/30/2025 12:24:23 AM", "", "In Development",  0,2087)
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
          
        InitValidValue("Scope_ValidValues", "750", "-1", 1717)
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
          
        InitSubpart("Circuits", 24, "", "", "Y", 0, "-1", "", "GLOBAL\H601421", "4/8/2025 5:43:36 PM", "", "In Development", "N",0,56,55)
        
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
          
        InitConnection("Devices", "19", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "4/8/2025 6:25:19 PM", "", "In Development", "N",39)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("HBSSystem", "69", "","", "Y", 0, "-1", "", "GLOBAL\H601421", "7/9/2025 3:14:48 AM", "", "In Development", "Y",138)
        
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
            If Incontext("-1", ctx) Then
          
        InitDBConstraint("PowerSupplyData", 11,"", "Y","", "", "Power_Supply_Vest")
        
          InitDBproperty("PowerSupplyData", "ApplicationUse",11, "Default_Application", "Power_Supply_Vest")
        
          InitDBproperty("PowerSupplyData", "CircuitCount",11, "Number_Of_Power_Circuits", "Power_Supply_Vest")
        
          InitDBproperty("PowerSupplyData", "DefaultQuantity",11, "Default_Part_Qty", "Power_Supply_Vest")
        
          InitDBproperty("PowerSupplyData", "InputVoltage",11, "Input_Voltage", "Power_Supply_Vest")
        
          InitDBproperty("PowerSupplyData", "Mnemonic",11, "Power_Supply_Mnemonic", "Power_Supply_Vest")
        
          InitDBproperty("PowerSupplyData", "OutputVoltage",11, "Output_Voltage", "Power_Supply_Vest")
        
          InitDBproperty("PowerSupplyData", "PartDescription",11, "Part_Description", "Power_Supply_Vest")
        
          InitDBproperty("PowerSupplyData", "PartNumber",11, "Part_Number", "Power_Supply_Vest")
        
          InitDBproperty("PowerSupplyData", "PowerRating",11, "Total_Power_Rating", "Power_Supply_Vest")
        
          InitDBproperty("PowerSupplyData", "PowerRatingsByCircuit",11, "Power_Rating_Per_Circuit", "Power_Supply_Vest")
        
          End If
        
    End Sub

    #End Region

    #Region " Formulas "

    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Devices_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:19; TYPE:PF
        Dim _myPartNumber As String = PartNumber

Result = New rsCollection

For Each _obj In Parent.Devices
	If _obj.AssignedPowerSupply.StartsWith(_myPartNumber) Then Result.Add(_obj)
Next

For Each _obj In Parent.Controllers
	If _obj.AssignedPowerSupply.StartsWith(_myPartNumber) Then Result.Add(_obj)
Next
        '   END FORMULA; CON ID:19; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_Devices_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HBSSystem_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:69; TYPE:PF
        Result = Nothing
        '   END FORMULA; CON ID:69; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_HBSSystem_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ApplicationUse() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ApplicationUse").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:327; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:327; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_ApplicationUse", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_button_RemovePowerSupply() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_RemovePowerSupply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1093; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:1093; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_button_RemovePowerSupply", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CircuitCount() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CircuitCount").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:397; TYPE:PF
      Result = 1
      '   END FORMULA; PROP ID:397; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_CircuitCount", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:1369; TYPE:PF
      Result = 1
      '   END FORMULA; PROP ID:1369; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_DefaultQuantity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DisplayName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DisplayName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:405; TYPE:PF
      Result = PartNumber
      '   END FORMULA; PROP ID:405; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_DisplayName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_InputVoltage() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("InputVoltage").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:328; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:328; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_InputVoltage", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:635; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:635; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_Mnemonic", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_OutputVoltage() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("OutputVoltage").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:329; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:329; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_OutputVoltage", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:326; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:326; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_PartDescription", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerConsumption() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerConsumption").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:792; TYPE:PF
      For Each _ckt As Object In Circuits
	Result += _ckt.PowerConsumption
Next
      '   END FORMULA; PROP ID:792; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_PowerConsumption", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerRating() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerRating").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:342; TYPE:PF
      Result = String.Empty
      '   END FORMULA; PROP ID:342; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_PowerRating", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerRatingsByCircuit() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerRatingsByCircuit").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:400; TYPE:PF
      Result = PowerRating
      '   END FORMULA; PROP ID:400; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_PowerRatingsByCircuit", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PowerSupplyIndex() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PowerSupplyIndex").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:333; TYPE:PF
      Result = If(SubpartId = 1, 1, Owner(SubpartId - 1).PowerSupplyIndex + 1)
      '   END FORMULA; PROP ID:333; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_PowerSupplyIndex", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Qty() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:749; TYPE:PF
      Result = 1
      '   END FORMULA; PROP ID:749; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SafetyMargin() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SafetyMargin").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:790; TYPE:PF
      Result = If(IsConnected(HBSSystem), HBSSystem(1).SafetyMargin, Parent.SafetyMargin)
      '   END FORMULA; PROP ID:790; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_SafetyMargin", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scope() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scope").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:750; TYPE:PF
      Result = "Supplied By Honeywell"
      '   END FORMULA; PROP ID:750; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_Scope", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_SelectedCircuitIndex() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("SelectedCircuitIndex").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:714; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:714; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_SelectedCircuitIndex", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Tag() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Tag").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:636; TYPE:PF
      Result = PartNumber & "-" & PowerSupplyIndex
      '   END FORMULA; PROP ID:636; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_Tag", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ApplicationUse_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_RemovePowerSupply_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CircuitCount_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_DisplayName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_InputVoltage_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_OutputVoltage_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_PowerConsumption_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerRating_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerRatingsByCircuit_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplyIndex_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SafetyMargin_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scope_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedCircuitIndex_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Tag_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ApplicationUse_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_RemovePowerSupply_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CircuitCount_USERCHANGE() as Boolean
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
      Public Function Formula_DisplayName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_InputVoltage_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_OutputVoltage_USERCHANGE() as Boolean
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
      Public Function Formula_PowerConsumption_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerRating_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerRatingsByCircuit_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerSupplyIndex_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Qty_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SafetyMargin_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scope_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_SelectedCircuitIndex_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Tag_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scope_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scope").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:750; TYPE:VV
      Result = MakeValidValues(Array("Supplied By Honeywell", "Supplied By Others", "Existing"))
      '   END FORMULA; PROP ID:750; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_Scope_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Circuits_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:24; TYPE:PN
      
      '   END FORMULA; SUB ID:24; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_Circuits_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Circuits_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Circuits").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:24; TYPE:QF
      Result = CircuitCount
      '   END FORMULA; SUB ID:24; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_Circuits_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Circuits_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Circuits").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:24; TYPE:OP
      Result = "Circuit"
      '   END FORMULA; SUB ID:24; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_Circuits_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_button_RemovePowerSupply_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_RemovePowerSupply").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1093; TYPE:WC
      Dim _poweredParts As New List(Of Object)

'capture all parts powered by all circuits of this power supply
For Each _ckt As Object In Circuits
	For Each _part As Object In _ckt.PoweredParts
		_poweredParts.Add(_part)
	Next
Next

'unassign all powered parts from this power supply's cicuits
For Each _part As Object In _poweredParts
	_part.Circuit.RevertToCalc()
Next

'finally remove myself
Owner.Remove(Name)
      '   END FORMULA; PROP ID:1093; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.Formula_button_RemovePowerSupply_WHENCHANGED", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      End Sub
    

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
      
        Case 11
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "Default_Application" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Number_Of_Power_Circuits" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Default_Part_Qty" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Input_Voltage" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Power_Supply_Mnemonic" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Output_Voltage" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Part_Description" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Part_Number" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Total_Power_Rating" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Power_Rating_Per_Circuit" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
                  varPropSpecVal = PartNumber
              BuildWhereClause(strWhereClause, "0", "0", "  ", "[Part_Number]", "=", varPropSpecVal, "")
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("Power_Supply_Vest"), strWhereClause, leftDelimiter & "" & rightDelimiter, "")
          
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " PowerSupply.GetRecordset", strError)
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

  