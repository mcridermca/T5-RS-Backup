Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBS_Demo
'$ PartFamily: Plant
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

    Public Class [Plant]
    
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

    Private this as Plant = me

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
    
      Case "button_AddDevice_"
      Formula_button_AddDevice_WHENCHANGED(Value, OldValue)
    
    End Select
    End Sub

    Public Function OnChangedStatus(ByRef Value as Object, ByVal OldValue as Object, ByVal specName As String, ByVal context As String)As Boolean Implements RuleStream.IRsPartFormulas.OnChangedStatus
    'Dim MethodName as String = string.format("Formula_{0}_WHENCHANGED{1}", specName, context)
    'CallByName(Me, MethodName, CallType.Method, Value)
    Dim Status as Boolean = False
    Select Case specName & "_" & context
    
      Case "button_AddDevice_"
      'Formula_button_AddDevice_WHENCHANGED(Value, OldValue)
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
    
          Public Property [ControllerDefaultPartNumber]() As String
      Get
      Return Properties("ControllerDefaultPartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("ControllerDefaultPartNumber").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerFamily]() As String
      Get
      Return Properties("ControllerFamily").Value
      End Get
      Set(ByVal Value As String)
      Properties("ControllerFamily").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ControllerQuantity]() As Long
      Get
      Return Properties("ControllerQuantity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("ControllerQuantity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [DevicePartNumber]() As String
      Get
      Return Properties("DevicePartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("DevicePartNumber").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PartType]() As String
      Get
      Return Properties("PartType").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PlantName]() As String
      Get
      Return Properties("PlantName").Value
      End Get
      Set(ByVal Value As String)
      Properties("PlantName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PlantType]() As String
      Get
      Return Properties("PlantType").Value
      End Get
      Set(ByVal Value As String)
      Properties("PlantType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ProcessVariable]() As String
      Get
      Return Properties("ProcessVariable").Value
      End Get
      Set(ByVal Value As String)
      Properties("ProcessVariable").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Search_Default_Library]() As String
      Get
      Return Properties("Search_Default_Library").Value
      End Get
      Set(ByVal Value As String)
      Properties("Search_Default_Library").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Search_Part_Description]() As String
      Get
      Return Properties("Search_Part_Description").Value
      End Get
      Set(ByVal Value As String)
      Properties("Search_Part_Description").CalculatedValue = Value
      End Set
      End Property
    
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
    
          Public Property [SystemName]() As String
      Get
      Return Properties("SystemName").Value
      End Get
      Set(ByVal Value As String)
      Properties("SystemName").CalculatedValue = Value
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
    
          Public Property [button_AddDevice]() As String
      Get
      Return Properties("button_AddDevice").Value
      End Get
      Set(ByVal Value As String)
      Properties("button_AddDevice").CalculatedValue = Value
      End Set
      End Property
    
      Public ReadOnly Property [Controllers]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Controllers")
      End Get
      End Property
    
      Public ReadOnly Property [Devices]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Devices")
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
    InitPart("Plant", <a><![CDATA[Plant]]></a>.Value, 4, "HBS_Demo",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\SVRSDevAdmin", "03/03/2025 11:59:25")
    AddProperty("60", "ApplicationUse", <a><![CDATA[Application Use]]></a>.Value, "The application use for the device. Used to filter Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 9:18:00 PM")
    AddProperty("124", "ControllerDefaultPartNumber", <a><![CDATA[Controlle PN (Default)]]></a>.Value, "The family for the controller of this Plant.", "String","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 8:30:30 PM")
    AddProperty("80", "ControllerFamily", <a><![CDATA[Controller Family]]></a>.Value, "The family for the controller of this Plant.", "String","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 6:27:45 PM")
    AddProperty("81", "ControllerQuantity", <a><![CDATA[Controller Quantity]]></a>.Value, "The number of controllers for this Plant.", "Long","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 6:31:42 PM")
    AddProperty("61", "DevicePartNumber", <a><![CDATA[Device Part Number]]></a>.Value, "The identifying number or code for the device part.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/28/2025 12:52:39 PM")
    AddProperty("62", "PartType", <a><![CDATA[Part Type]]></a>.Value, "The type of device part. Used to filter the Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 5:52:37 PM")
    AddProperty("18", "PlantName", <a><![CDATA[Plant Name]]></a>.Value, "The name of the plant.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/21/2025 8:30:37 PM")
    AddProperty("19", "PlantType", <a><![CDATA[Plant Type]]></a>.Value, "The type of plant.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/21/2025 8:31:55 PM")
    AddProperty("63", "ProcessVariable", <a><![CDATA[Process Variable]]></a>.Value, "A process variable used to filter the Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 5:51:48 PM")
    AddProperty("122", "Search_Default_Library", <a><![CDATA[Search_Default_Library]]></a>.Value, "The Master Device Library to Pull  Data From  !!! No Data In System to Demo !!!", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "3/3/2025 11:59:25 AM")
    AddProperty("121", "Search_Part_Description", <a><![CDATA[Search_Part_Description]]></a>.Value, "The application use for the device. Used to filter Device Part Numbers.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/27/2025 6:18:58 PM")
    AddProperty("73", "SpareCapacityForControllers", <a><![CDATA[Spare Capacity for Controllers]]></a>.Value, "The spare capacity of this plant for controllers.", "String","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:38:59 AM")
    AddProperty("71", "SpareCapacityForPSSizing", <a><![CDATA[Spare Capacity for PS Sizing]]></a>.Value, "The spare capacity of this plant for PS sizing.", "String","","General","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:39:04 AM")
    AddProperty("65", "SystemName", <a><![CDATA[System Name]]></a>.Value, "The name of the system.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:51:37 AM")
    AddProperty("4", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\SVRSDevAdmin", "2/21/2025 6:59:34 PM")
    AddProperty("64", "button_AddDevice", <a><![CDATA[Button - Add Device]]></a>.Value, "Add a Device to the Plant.", "String","","UI Control","FD", 9999, "", 0,0, "RuleStream", "", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:54:54 AM")
    
      AddPropertyExtended(61,"DevicePartNumber", "54", "EXTLABEL", "Label", "Part Number", "GLOBAL\SVRSDevAdmin", "2/28/2025 12:52:39 PM")
    
      AddPropertyExtended(64,"button_AddDevice", "57", "EXTWC   ", "WhenChanged", "BUTTONCLICK", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:54:54 AM")
    
      AddValidValue("ApplicationUse")
    
      AddValidValue("ControllerDefaultPartNumber")
    
      AddValidValue("DevicePartNumber")
    
      AddValidValue("PartType")
    
      AddValidValue("ProcessVariable")
    
      AddValidValue("Search_Default_Library")
    
      oSubpart = AddSubpart(5,"Controllers", <a><![CDATA[Controllers]]></a>.Value, "FD", "The controllers involved.", "Subparts and Connections", 9999, "RuleStream", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:49:35 AM")
      
        oSubpart.AddVPF (6, "Controller", "Controller")
      
      oSubpart = AddSubpart(4,"Devices", <a><![CDATA[Devices]]></a>.Value, "FD", "The devices involved.", "Subparts and Connections", 9999, "RuleStream", "GLOBAL\SVRSDevAdmin", "2/26/2025 11:49:40 AM")
      
        oSubpart.AddVPF (5, "Device", "Device")
      
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
          InitProperty("ApplicationUse", "53", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 9:15:58 PM", "", "In Development",  0,76)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerDefaultPartNumber", "114", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 8:30:18 PM", "", "In Development",  0,288)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerFamily", "72", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 6:27:45 PM", "", "In Development",  0,129)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ControllerQuantity", "73", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 6:31:42 PM", "", "In Development",  0,131)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DevicePartNumber", "54", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/28/2025 12:52:39 PM", "", "In Development",  0,77)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PartType", "55", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 5:52:37 PM", "", "In Development",  0,78)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantName", "11", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/21/2025 8:30:37 PM", "", "In Development",  0,15)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PlantType", "12", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/21/2025 8:31:55 PM", "", "In Development",  0,16)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ProcessVariable", "56", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 5:51:48 PM", "", "In Development",  0,79)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Search_Default_Library", "112", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\SVRSDevAdmin", "3/3/2025 11:59:10 AM", "", "In Development",  0,271)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Search_Part_Description", "111", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/27/2025 6:18:58 PM", "", "In Development",  0,266)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SpareCapacityForControllers", "66", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:38:52 AM", "", "In Development",  0,99)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SpareCapacityForPSSizing", "64", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:38:13 AM", "", "In Development",  0,97)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("SystemName", "58", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:51:37 AM", "", "In Development",  0,106)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("button_AddDevice", "57", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\SVRSDevAdmin", "2/26/2025 11:54:54 AM", "", "In Development",  0,80)
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
          
        InitValidValue("ApplicationUse_ValidValues", "53", "-1", 189)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ControllerDefaultPartNumber_ValidValues", "114", "-1", 289)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("DevicePartNumber_ValidValues", "54", "-1", 389)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PartType_ValidValues", "55", "-1", 276)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ProcessVariable_ValidValues", "56", "-1", 275)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Search_Default_Library_ValidValues", "112", "-1", 392)
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
          
        InitSubpart("Controllers", 5, "", "", "Y", 0, "-1", "", "GLOBAL\SVRSDevAdmin", "2/21/2025 7:02:46 PM", "", "In Development", "N",0,10,9)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Devices", 4, "", "", "Y", 0, "-1", "", "GLOBAL\SVRSDevAdmin", "2/21/2025 7:00:47 PM", "", "In Development", "Y",0,8,7)
        
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
          Public Function Formula_ApplicationUse() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ApplicationUse").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:53; TYPE:PF
      result = ""
'Filter 0
      '   END FORMULA; PROP ID:53; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ApplicationUse", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerDefaultPartNumber() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerDefaultPartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:114; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:114; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerDefaultPartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerFamily() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerFamily").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:72; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:72; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerFamily", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ControllerQuantity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerQuantity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:73; TYPE:PF
      If (Devices.Quantity > 4) Then
	Result = 2
Else
	Result = 1
End If
      '   END FORMULA; PROP ID:73; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerQuantity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_DevicePartNumber() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DevicePartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:54; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:54; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_DevicePartNumber", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PartType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PartType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:55; TYPE:PF
      result = ""
'Filter 2
      '   END FORMULA; PROP ID:55; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PartType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PlantName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PlantName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:11; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:11; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PlantName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PlantType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PlantType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:12; TYPE:PF
      Result = ""
'TODO: Get VV list from DB
      '   END FORMULA; PROP ID:12; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PlantType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ProcessVariable() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ProcessVariable").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:56; TYPE:PF
      result = ""
'Filter 1
      '   END FORMULA; PROP ID:56; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ProcessVariable", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Search_Default_Library() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Search_Default_Library").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:112; TYPE:PF
      result = ""
'Filter 0
      '   END FORMULA; PROP ID:112; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Search_Default_Library", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Search_Part_Description() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Search_Part_Description").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:111; TYPE:PF
      result = ""
'Filter 0
      '   END FORMULA; PROP ID:111; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Search_Part_Description", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      '   BEGIN FORMULA; PROP ID:66; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:66; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_SpareCapacityForControllers", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:64; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:64; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_SpareCapacityForPSSizing", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:58; TYPE:PF
      Result = me.Parent.SystemName
'Pull the name from the parent System.
      '   END FORMULA; PROP ID:58; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_SystemName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_button_AddDevice() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_AddDevice").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:57; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:57; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_button_AddDevice", ex.Message)
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
      Public Function Formula_ControllerDefaultPartNumber_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerFamily_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerQuantity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DevicePartNumber_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ProcessVariable_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Search_Default_Library_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Search_Part_Description_HIDE_CALCULATED_VALUE() as Boolean
      Return False
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
      Public Function Formula_SystemName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_AddDevice_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_ControllerDefaultPartNumber_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerFamily_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerQuantity_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DevicePartNumber_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantName_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PlantType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ProcessVariable_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Search_Default_Library_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Search_Part_Description_USERCHANGE() as Boolean
      Return True
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
      Public Function Formula_SystemName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_button_AddDevice_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ApplicationUse_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ApplicationUse").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:53; TYPE:VV
      Result = MakeValidValues(Array("Actuator", "Current", "Current","Field", "OSA", "Pressure", "Room"))
      '   END FORMULA; PROP ID:53; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ApplicationUse_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ControllerDefaultPartNumber_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ControllerDefaultPartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:114; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_ControllersTable_Demo]", "[Part Number]", "[Display_1]", " ORDER BY [Display_1]")
      '   END FORMULA; PROP ID:114; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ControllerDefaultPartNumber_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_DevicePartNumber_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DevicePartNumber").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:54; TYPE:VV
      Result = Nothing

If Me.Search_Default_Library.Length > 0
   Result = MakeValidValueKeyFromDatabase("[vw_PartsTable_Demo]", "[Part Number]", "[Display_1]", _
					 	"WHERE [application] like " & FormatCriteria("%" & Me.ApplicationUse & "%") & _
							" AND [Process  Variable] like " & FormatCriteria("%" & Me.ProcessVariable & "%") & _ 
							" AND [Type] like " & FormatCriteria("%" & Me.PartType & "%") & _
							" AND [Display_1] like " & FormatCriteria("%" & Me.Search_Part_Description & "%") & _
					 	" ORDER BY [Part Number]")

End If
      '   END FORMULA; PROP ID:54; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_DevicePartNumber_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PartType_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PartType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:55; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_PartTypes]", "[Type]", "[Type]", "WHERE 1 = 1 ORDER BY [Type]")
      '   END FORMULA; PROP ID:55; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_PartType_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ProcessVariable_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ProcessVariable").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:56; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_ProcessVariables]", "[Process  Variable]", "[Process  Variable]", "WHERE 1 = 1 ORDER BY [Process  Variable]")
      '   END FORMULA; PROP ID:56; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_ProcessVariable_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Search_Default_Library_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Search_Default_Library").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:112; TYPE:VV
      Result = MakeValidValues(Array("Library 1", "Library 2", "Library 3","Microsoft-Like Library"))
      '   END FORMULA; PROP ID:112; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Search_Default_Library_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controllers_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:5; TYPE:PN
      
      '   END FORMULA; SUB ID:5; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Controllers_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controllers_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Controllers").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:5; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:5; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Controllers_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controllers_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Controllers").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:5; TYPE:OP
      result = "Controller"
      '   END FORMULA; SUB ID:5; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Controllers_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Devices_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:4; TYPE:PN
      
      '   END FORMULA; SUB ID:4; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Devices_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Devices_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Devices").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:4; TYPE:QF
      Result = 0
      '   END FORMULA; SUB ID:4; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Devices_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Devices_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Devices").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:4; TYPE:OP
      result = "Device"
      '   END FORMULA; SUB ID:4; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_Devices_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Sub Formula_button_AddDevice_WHENCHANGED(ByRef Value as Object, ByVal OldValue as Object)
      
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("button_AddDevice").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.WHENCHANGED_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:57; TYPE:WC
      Dim _devicePartNumber As String = DevicePartNumber
'Used multiple times: set as local variable.

Dim _device As Object = Subparts("Devices").AddPart("Device")
'Add a new Part and set a local variable to point to it.

_device.Properties("PartNumber").InputValue = _devicePartNumber
'Set the Part Number
      '   END FORMULA; PROP ID:57; TYPE:WC
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " Plant.Formula_button_AddDevice_WHENCHANGED", ex.Message)
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

  