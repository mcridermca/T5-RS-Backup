Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_Sourcing_Input
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

    Public Class [CAE_Sourcing_Input]
    
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

    Private this as CAE_Sourcing_Input = me

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
    
          Public Property [Debug_Mode]() As Boolean
      Get
      Return Properties("Debug_Mode").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Debug_Mode").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Air_Piping_1_1_5_in_Pipe]() As Long
      Get
      Return Properties("Air_Piping_1_1_5_in_Pipe").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Air_Piping_1_1_5_in_Pipe").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Air_Piping_1_2_in_Pipe]() As Long
      Get
      Return Properties("Air_Piping_1_2_in_Pipe").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Air_Piping_1_2_in_Pipe").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Air_Piping_2_1_5_in_Pipe]() As Long
      Get
      Return Properties("Air_Piping_2_1_5_in_Pipe").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Air_Piping_2_1_5_in_Pipe").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Air_Piping_3_in_Pipe]() As Long
      Get
      Return Properties("Air_Piping_3_in_Pipe").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Air_Piping_3_in_Pipe").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Air_Piping_7_8_in_Pipe]() As Long
      Get
      Return Properties("Air_Piping_7_8_in_Pipe").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Air_Piping_7_8_in_Pipe").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Air_Piping_AC]() As Long
      Get
      Return Properties("Air_Piping_AC").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Air_Piping_AC").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Air_Piping_AC_Redundant]() As Long
      Get
      Return Properties("Air_Piping_AC_Redundant").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Air_Piping_AC_Redundant").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Air_Piping_Anchors]() As Long
      Get
      Return Properties("Air_Piping_Anchors").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Air_Piping_Anchors").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Air_Piping_Bottom_Pans]() As Long
      Get
      Return Properties("Air_Piping_Bottom_Pans").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Air_Piping_Bottom_Pans").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Air_Piping_Dryer]() As Long
      Get
      Return Properties("Air_Piping_Dryer").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Air_Piping_Dryer").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Air_Piping_Filter_Reg]() As Long
      Get
      Return Properties("Air_Piping_Filter_Reg").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Air_Piping_Filter_Reg").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Air_Piping_Tubing]() As Long
      Get
      Return Properties("Air_Piping_Tubing").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Air_Piping_Tubing").CalculatedValue = Value
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
    
          Public Property [Sourcing_Commisioning_Crew_Size]() As Long
      Get
      Return Properties("Sourcing_Commisioning_Crew_Size").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Sourcing_Commisioning_Crew_Size").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sourcing_Equipment]() As Double
      Get
      Return Properties("Sourcing_Equipment").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sourcing_Equipment").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sourcing_Installation_Crew_Size]() As Long
      Get
      Return Properties("Sourcing_Installation_Crew_Size").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Sourcing_Installation_Crew_Size").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sourcing_Installer_Hours]() As Double
      Get
      Return Properties("Sourcing_Installer_Hours").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sourcing_Installer_Hours").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sourcing_Lead_Hours]() As Double
      Get
      Return Properties("Sourcing_Lead_Hours").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sourcing_Lead_Hours").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sourcing_Materials]() As Double
      Get
      Return Properties("Sourcing_Materials").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sourcing_Materials").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sourcing_Misc]() As Double
      Get
      Return Properties("Sourcing_Misc").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sourcing_Misc").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sourcing_Super_Hours]() As Double
      Get
      Return Properties("Sourcing_Super_Hours").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sourcing_Super_Hours").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [XMLObjectName]() As String
      Get
      Return Properties("XMLObjectName").Value
      End Get
      Set(ByVal Value As String)
      Properties("XMLObjectName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [XMLObjectType]() As String
      Get
      Return Properties("XMLObjectType").Value
      End Get
      Set(ByVal Value As String)
      Properties("XMLObjectType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [XMLObjectValue]() As String
      Get
      Return Properties("XMLObjectValue").Value
      End Get
      Set(ByVal Value As String)
      Properties("XMLObjectValue").CalculatedValue = Value
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
    
      Public ReadOnly Property [My_Air_Piping]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Air_Piping")
      End Get
      End Property
    
      Public ReadOnly Property [My_Conveyor_Costing]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Conveyor_Costing")
      End Get
      End Property
    
      Public ReadOnly Property [My_System]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_System")
      End Get
      End Property
    
      Public ReadOnly Property [My_TTCB_Costing]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_TTCB_Costing")
      End Get
      End Property
    
      Public ReadOnly Property [MySource]() As Rulestream.Kernel.Connection
      Get
      Return Connections("MySource")
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
    InitPart("CAE_Sourcing_Input", <a><![CDATA[CAE_Sourcing_Input]]></a>.Value, 431, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H602502", "07/18/2025 14:16:23")
    AddProperty("10632", "Debug_Mode", <a><![CDATA[Debug_Mode]]></a>.Value, "True = Debug On / False = Debug Off", "Boolean","","Debugging","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 8:00:47 PM")
    AddProperty("10658", "Air_Piping_1_1_5_in_Pipe", <a><![CDATA[Air_Piping_1_1_5_in_Pipe]]></a>.Value, "Mech Install^'Sourcing Inputs'!C8", "Long","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:06:04 PM")
    AddProperty("10660", "Air_Piping_1_2_in_Pipe", <a><![CDATA[Air_Piping_1_2_in_Pipe]]></a>.Value, "Mech Install^'Sourcing Inputs'!C10", "Long","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:08:22 PM")
    AddProperty("10657", "Air_Piping_2_1_5_in_Pipe", <a><![CDATA[Air_Piping_2_1_5_in_Pipe]]></a>.Value, "Mech Install^'Sourcing Inputs'!C7", "Long","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:05:52 PM")
    AddProperty("10656", "Air_Piping_3_in_Pipe", <a><![CDATA[Air_Piping_3_in_Pipe]]></a>.Value, "Mech Install^'Sourcing Inputs'!C6", "Long","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:05:40 PM")
    AddProperty("10659", "Air_Piping_7_8_in_Pipe", <a><![CDATA[Air_Piping_7_8_in_Pipe]]></a>.Value, "Mech Install^'Sourcing Inputs'!C9", "Long","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:07:42 PM")
    AddProperty("10663", "Air_Piping_AC", <a><![CDATA[Air_Piping_AC]]></a>.Value, "Mech Install^'Sourcing Inputs'!C13", "Long","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:11:24 PM")
    AddProperty("10664", "Air_Piping_AC_Redundant", <a><![CDATA[Air_Piping_AC_Redundant]]></a>.Value, "Mech Install^'Sourcing Inputs'!C14", "Long","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:12:28 PM")
    AddProperty("10666", "Air_Piping_Anchors", <a><![CDATA[Air_Piping_Anchors]]></a>.Value, "Mech Install^'Sourcing Inputs'!H3", "Long","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:15:12 PM")
    AddProperty("10667", "Air_Piping_Bottom_Pans", <a><![CDATA[Air_Piping_Bottom_Pans]]></a>.Value, "Mech Install^'Sourcing Inputs'!H6", "Long","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:16:23 PM")
    AddProperty("10665", "Air_Piping_Dryer", <a><![CDATA[Air_Piping_Dryer]]></a>.Value, "Mech Install^'Sourcing Inputs'!C15", "Long","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:12:57 PM")
    AddProperty("10662", "Air_Piping_Filter_Reg", <a><![CDATA[Air_Piping_Filter_Reg]]></a>.Value, "Mech Install^'Sourcing Inputs'!C12", "Long","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:10:24 PM")
    AddProperty("10661", "Air_Piping_Tubing", <a><![CDATA[Air_Piping_Tubing]]></a>.Value, "Mech Install^'Sourcing Inputs'!C11", "Long","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:09:33 PM")
    AddProperty("10610", "DisplayName", <a><![CDATA[Display Name]]></a>.Value, "Mech Install^'Sourcing Input'!J3", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 7:25:50 PM")
    AddProperty("10619", "Sourcing_Commisioning_Crew_Size", <a><![CDATA[Sourcing_Commisioning_Crew_Size]]></a>.Value, "Mech Install^'Sourcing Input'!L3", "Long","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 7:45:58 PM")
    AddProperty("10616", "Sourcing_Equipment", <a><![CDATA[Sourcing_Equipment]]></a>.Value, "Mech Install^'Sourcing Input'!P3", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 7:37:42 PM")
    AddProperty("10621", "Sourcing_Installation_Crew_Size", <a><![CDATA[Sourcing_Installation_Crew_Size]]></a>.Value, "Mech Install^'Sourcing Input'!K3", "Long","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 7:46:32 PM")
    AddProperty("10615", "Sourcing_Installer_Hours", <a><![CDATA[Sourcing_Installer_Hours]]></a>.Value, "Mech Install^'Sourcing Input'!O3", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 7:36:25 PM")
    AddProperty("10622", "Sourcing_Lead_Hours", <a><![CDATA[Sourcing_Lead_Hours]]></a>.Value, "Mech Install^'Sourcing Input'!N3", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 7:46:54 PM")
    AddProperty("10617", "Sourcing_Materials", <a><![CDATA[Sourcing_Materials]]></a>.Value, "Mech Install^'Sourcing Input'!Q3", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 7:38:31 PM")
    AddProperty("10618", "Sourcing_Misc", <a><![CDATA[Sourcing_Misc]]></a>.Value, "Mech Install^'Sourcing Input'!R3", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 7:39:51 PM")
    AddProperty("10620", "Sourcing_Super_Hours", <a><![CDATA[Sourcing_Super_Hours]]></a>.Value, "Mech Install^'Sourcing Input'!M3", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 7:46:14 PM")
    AddProperty("10633", "XMLObjectName", <a><![CDATA[XMLObjectName]]></a>.Value, "XML Export Object Name", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H602502", "7/17/2025 8:01:06 PM")
    AddProperty("10634", "XMLObjectType", <a><![CDATA[XMLObjectType]]></a>.Value, "XML Export Object Type", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H602502", "7/17/2025 8:00:47 PM")
    AddProperty("10635", "XMLObjectValue", <a><![CDATA[XMLObjectValue]]></a>.Value, "XML Export Object Value", "String","","Oracle Config XML","FD", 9999, "", 0,0, "Oracle Configurator Transfer", "", "GLOBAL\H602502", "7/17/2025 8:00:47 PM")
    AddProperty("10608", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 7:19:10 PM")
    
      oConnection = AddConnection("My_Air_Piping", <a><![CDATA[My_Air_Piping]]></a>.Value, "", "206", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/18/2025 1:56:21 PM")
      
        oConnection.AddVPF(392, "CAE_Air_Piping_Control_Panel")
      
      oConnection = AddConnection("My_Conveyor_Costing", <a><![CDATA[My_Conveyor_Costing]]></a>.Value, "", "200", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/17/2025 7:23:17 PM")
      
        oConnection.AddVPF(389, "CAE_Conveyor_Costing")
      
      oConnection = AddConnection("My_System", <a><![CDATA[My_System]]></a>.Value, "", "199", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/17/2025 7:22:19 PM")
      
        oConnection.AddVPF(399, "CAE_Mech_Install_CP_Comp")
      
      oConnection = AddConnection("My_TTCB_Costing", <a><![CDATA[My_TTCB_Costing]]></a>.Value, "", "201", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/17/2025 7:23:56 PM")
      
        oConnection.AddVPF(401, "CAE_TTCB_Costing_Mech")
      
      oConnection = AddConnection("MySource", <a><![CDATA[My Source Part Family]]></a>.Value, "Connection to the Value Provider Part Family Instance", "203", "OO", 0, "","Oracle Config XML", 9999, "Oracle Configurator Transfer", "GLOBAL\H602502", "7/17/2025 8:00:47 PM")
      
        oConnection.AddVPF(33, "OCT_Accessory")
      
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
          InitProperty("Debug_Mode", "10200", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 8:00:47 PM", "True = Debug On / False = Debug Off", "In Development",  0,18943)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Air_Piping_1_1_5_in_Pipe", "10222", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:06:04 PM", "", "In Development",  0,19061)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Air_Piping_1_2_in_Pipe", "10224", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:08:22 PM", "", "In Development",  0,19065)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Air_Piping_2_1_5_in_Pipe", "10221", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:05:52 PM", "", "In Development",  0,19060)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Air_Piping_3_in_Pipe", "10220", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:05:40 PM", "", "In Development",  0,19059)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Air_Piping_7_8_in_Pipe", "10223", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:07:11 PM", "", "In Development",  0,19063)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Air_Piping_AC", "10227", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:11:24 PM", "", "In Development",  0,19071)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Air_Piping_AC_Redundant", "10228", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:12:28 PM", "", "In Development",  0,19073)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Air_Piping_Anchors", "10230", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:15:12 PM", "", "In Development",  0,19077)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Air_Piping_Bottom_Pans", "10231", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:16:23 PM", "", "In Development",  0,19079)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Air_Piping_Dryer", "10229", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:12:57 PM", "", "In Development",  0,19075)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Air_Piping_Filter_Reg", "10226", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:10:24 PM", "", "In Development",  0,19069)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Air_Piping_Tubing", "10225", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:09:33 PM", "", "In Development",  0,19067)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DisplayName", "10178", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 7:24:43 PM", "", "In Development",  0,18905)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sourcing_Commisioning_Crew_Size", "10187", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 7:45:58 PM", "", "In Development",  0,18921)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sourcing_Equipment", "10184", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 7:37:42 PM", "", "In Development",  0,18916)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sourcing_Installation_Crew_Size", "10189", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 7:46:32 PM", "", "In Development",  0,18923)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sourcing_Installer_Hours", "10183", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 7:36:25 PM", "", "In Development",  0,18914)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sourcing_Lead_Hours", "10190", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 7:46:54 PM", "", "In Development",  0,18924)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sourcing_Materials", "10185", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 7:38:31 PM", "", "In Development",  0,18918)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sourcing_Misc", "10186", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 7:39:51 PM", "", "In Development",  0,18920)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sourcing_Super_Hours", "10188", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 7:46:14 PM", "", "In Development",  0,18922)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectName", "10201", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 8:01:06 PM", "XML Export Object Name", "In Development",  0,18947)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectType", "10202", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 8:00:47 PM", "XML Export Object Type", "In Development",  0,18945)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("XMLObjectValue", "10203", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 8:00:47 PM", "XML Export Object Value", "In Development",  0,18946)
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
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Air_Piping", "185", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/18/2025 1:56:21 PM", "", "In Development", "N",333)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Conveyor_Costing", "180", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/17/2025 7:23:17 PM", "", "In Development", "N",328)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_System", "179", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/17/2025 7:22:19 PM", "", "In Development", "N",327)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_TTCB_Costing", "181", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/17/2025 7:23:56 PM", "", "In Development", "N",329)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("MySource", "183", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/17/2025 8:00:47 PM", "Connection to the Value Provider Part Family Instance", "In Development", "Y",331)
        
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
      Public Function Formula_My_Air_Piping_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:185; TYPE:PF
        Result = Me.Parent.Parent.Air_Piping(Me.SubpartID)
        '   END FORMULA; CON ID:185; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_My_Air_Piping_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Conveyor_Costing_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:180; TYPE:PF
        Result = Me.Parent.Parent.Conveyor_Costing_SC_Mech_Install(Me.SubpartID)
        '   END FORMULA; CON ID:180; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_My_Conveyor_Costing_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_System_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:179; TYPE:PF
        Result = Me.Parent.Parent.Base_Options_Alternates(Me.SubpartID)
        '   END FORMULA; CON ID:179; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_My_System_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_TTCB_Costing_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:181; TYPE:PF
        Result = me.Parent.Parent.TTCB_Costing_Mech(1)
        '   END FORMULA; CON ID:181; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_My_TTCB_Costing_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MySource_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
          '   THIS FORMULA IS INHERITED. CHANGES TO THIS FORMULA WILL BREAK INHERITANCE.
        
        '   BEGIN FORMULA; CON ID:183; TYPE:PF
        Result = Nothing ' Set to Object that has the data you need to report on ' Me.Parent.HHS_Output(1)
        '   END FORMULA; CON ID:183; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_MySource_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Debug_Mode() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
        '   THIS FORMULA IS INHERITED. CHANGES TO THIS FORMULA WILL BREAK INHERITANCE.
      
      If Me.Properties("Debug_Mode").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10200; TYPE:PF
      Result = False
If Not Me.Parent Is Nothing AndAlso Me.Parent.Properties.ContainsKey("Debug_Mode") Then
		Result = Me.Parent.Debug_Mode
End If
      '   END FORMULA; PROP ID:10200; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Debug_Mode", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Air_Piping_1_1_5_in_Pipe() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Air_Piping_1_1_5_in_Pipe").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10222; TYPE:PF
      Result = Me.My_Air_Piping(1).MEI_AP_SS1_Pipe_Type_Total_Order_1Half_In_Pipe + Me.My_Air_Piping(1).MEI_AP_TTCB_Total_Order_1_and_1_2_Inch_63mm_pipe
      '   END FORMULA; PROP ID:10222; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Air_Piping_1_1_5_in_Pipe", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Air_Piping_1_2_in_Pipe() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Air_Piping_1_2_in_Pipe").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10224; TYPE:PF
      Result = Me.My_Air_Piping(1).MEI_AP_SS1_Pipe_Type_Total_Order_1Half_In_Pipe + Me.My_Air_Piping(1).MEI_AP_TTCB_Total_Order_1_2_inch_16_5mm_pipe
      '   END FORMULA; PROP ID:10224; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Air_Piping_1_2_in_Pipe", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Air_Piping_2_1_5_in_Pipe() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Air_Piping_2_1_5_in_Pipe").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10221; TYPE:PF
      Result = Me.My_Air_Piping(1).MEI_AP_SS1_Pipe_Type_Total_Order_2Half_In_Pipe + Me.My_Air_Piping(1).MEI_AP_TTCB_Total_Order_2_and_1_2_Inch_63mm_pipe
      '   END FORMULA; PROP ID:10221; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Air_Piping_2_1_5_in_Pipe", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Air_Piping_3_in_Pipe() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Air_Piping_3_in_Pipe").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10220; TYPE:PF
      Result = Me.My_Air_Piping(1).MEI_AP_SS1_Pipe_Type_Total_Order_3Inch_Pipe + Me.My_Air_Piping(1).MEI_AP_TTCB_Total_Order_3_Inch_76mm_pipe
      '   END FORMULA; PROP ID:10220; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Air_Piping_3_in_Pipe", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Air_Piping_7_8_in_Pipe() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Air_Piping_7_8_in_Pipe").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10223; TYPE:PF
      Result = Me.My_Air_Piping(1).MEI_AP_SS1_Pipe_Type_Total_Order_7_8Inch_Pipe + Me.My_Air_Piping(1).MEI_AP_TTCB_Total_Order_7_8_Inch_25mm_pipe
      '   END FORMULA; PROP ID:10223; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Air_Piping_7_8_in_Pipe", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Air_Piping_AC() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Air_Piping_AC").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10227; TYPE:PF
      Result = Me.My_Air_Piping(1).MEI_AP_SS1_Total_Order_AC + Me.My_Air_Piping(1).MEI_AP_TTCB_Total_Order_A_C
      '   END FORMULA; PROP ID:10227; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Air_Piping_AC", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Air_Piping_AC_Redundant() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Air_Piping_AC_Redundant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10228; TYPE:PF
      Result = Me.My_Air_Piping(1).MEI_AP_SS1_Total_Order_Red_AC + Me.My_Air_Piping(1).MEI_AP_TTCB_Total_Order_Red_A_C
      '   END FORMULA; PROP ID:10228; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Air_Piping_AC_Redundant", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Air_Piping_Anchors() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Air_Piping_Anchors").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10230; TYPE:PF
      Result = me.My_System(1).Add_Hours_Dollars_Anchors_Qty
      '   END FORMULA; PROP ID:10230; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Air_Piping_Anchors", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Air_Piping_Bottom_Pans() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Air_Piping_Bottom_Pans").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10231; TYPE:PF
      Result = me.My_System(1).Hrs_Misc_Bottom_Pans_Qty
      '   END FORMULA; PROP ID:10231; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Air_Piping_Bottom_Pans", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Air_Piping_Dryer() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Air_Piping_Dryer").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10229; TYPE:PF
      Result = Me.My_Air_Piping(1).MEI_AP_SS1_Total_Order_Dryer + Me.My_Air_Piping(1).MEI_AP_TTCB_Total_Order_Dryer
      '   END FORMULA; PROP ID:10229; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Air_Piping_Dryer", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Air_Piping_Filter_Reg() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Air_Piping_Filter_Reg").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10226; TYPE:PF
      Result = Me.My_Air_Piping(1).MEI_AP_SS1_Total_Order_Filter_Reg + Me.My_Air_Piping(1).MEI_AP_TTCB_Total_Order_FILTER_REG
      '   END FORMULA; PROP ID:10226; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Air_Piping_Filter_Reg", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Air_Piping_Tubing() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Air_Piping_Tubing").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10225; TYPE:PF
      Result = Me.My_Air_Piping(1).MEI_AP_SS1_Total_Order_Tubing + Me.My_Air_Piping(1).MEI_AP_TTCB_Total_Order_Tubing
      '   END FORMULA; PROP ID:10225; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Air_Piping_Tubing", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10178; TYPE:PF
      Result = me.My_System(1).DisplayName
      '   END FORMULA; PROP ID:10178; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_DisplayName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sourcing_Commisioning_Crew_Size() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sourcing_Commisioning_Crew_Size").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10187; TYPE:PF
      Result = Me.My_Conveyor_Costing(1).People_Needs_Num_of_Installers_Comm _
		+ Me.My_Conveyor_Costing(1).People_Needs_Num_of_Lead_Men_Comm _
		+ Me.My_Conveyor_Costing(1).People_Needs_Num_of_Superintendents_Comm _
		+ Me.My_TTCB_Costing(1).MEI_People_Needs_Comm_No_of_Installers _
		+ Me.My_TTCB_Costing(1).MEI_People_Needs_Comm_No_of_Lead_Men _
		+ Me.My_TTCB_Costing(1).MEI_People_Needs_Comm_No_of_Superintendents
      '   END FORMULA; PROP ID:10187; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Sourcing_Commisioning_Crew_Size", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sourcing_Equipment() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sourcing_Equipment").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10184; TYPE:PF
      Result = me.My_System(1).Rollup_Equipment_Rental_COST
      '   END FORMULA; PROP ID:10184; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Sourcing_Equipment", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sourcing_Installation_Crew_Size() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sourcing_Installation_Crew_Size").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10189; TYPE:PF
      Result = Me.My_Conveyor_Costing(1).People_Needs_Num_of_Installers_Install _
		+ Me.My_Conveyor_Costing(1).People_Needs_Num_of_Lead_Men_Install _
		+ Me.My_Conveyor_Costing(1).People_Needs_Num_of_Superintendents_Install _
		+ Me.My_TTCB_Costing(1).MEI_People_Needs_Install_No_of_Installers _
		+ Me.My_TTCB_Costing(1).MEI_People_Needs_Install_No_of_Lead_Men _
		+ Me.My_TTCB_Costing(1).MEI_People_Needs_Install_No_of_Superintendents
      '   END FORMULA; PROP ID:10189; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Sourcing_Installation_Crew_Size", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sourcing_Installer_Hours() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sourcing_Installer_Hours").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10183; TYPE:PF
      Result = Me.My_System(1).Rollup_Conv_Intelligrated_Installers_HRS + me.My_System(1).Rollup_TTCB_Intelligrated_Installers_HRS
      '   END FORMULA; PROP ID:10183; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Sourcing_Installer_Hours", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sourcing_Lead_Hours() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sourcing_Lead_Hours").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10190; TYPE:PF
      Result = Me.My_System(1).Rollup_Conv_Lead_Men_HRS + me.My_System(1).Rollup_TTCB_Lead_Men_HRS
      '   END FORMULA; PROP ID:10190; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Sourcing_Lead_Hours", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sourcing_Materials() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sourcing_Materials").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10185; TYPE:PF
      Result = me.My_System(1).Rollup_SuppliesConsumables_COST
      '   END FORMULA; PROP ID:10185; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Sourcing_Materials", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sourcing_Misc() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sourcing_Misc").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10186; TYPE:PF
      Result = Me.My_System(1).Rollup_Permits_COST + me.My_System(1).Rollup_Miscellanious_COST
      '   END FORMULA; PROP ID:10186; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Sourcing_Misc", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sourcing_Super_Hours() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sourcing_Super_Hours").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10188; TYPE:PF
      Result = me.My_System(1).Rollup_Superintendent_HRS
      '   END FORMULA; PROP ID:10188; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_Sourcing_Super_Hours", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_XMLObjectName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("XMLObjectName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10201; TYPE:PF
      Result = "Sourcing_Input"
      '   END FORMULA; PROP ID:10201; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_XMLObjectName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_XMLObjectType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
        '   THIS FORMULA IS INHERITED. CHANGES TO THIS FORMULA WILL BREAK INHERITANCE.
      
      If Me.Properties("XMLObjectType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10202; TYPE:PF
      result = "Element"
      '   END FORMULA; PROP ID:10202; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_XMLObjectType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_XMLObjectValue() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
        '   THIS FORMULA IS INHERITED. CHANGES TO THIS FORMULA WILL BREAK INHERITANCE.
      
      If Me.Properties("XMLObjectValue").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10203; TYPE:PF
      Dim Prop As PropertySF = Me.CurrentProperty
Result = Custom.GetPFXMLRepresentation(Prop) 'Generate XML For this and Children Classes
      '   END FORMULA; PROP ID:10203; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Sourcing_Input.Formula_XMLObjectValue", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Debug_Mode_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_1_1_5_in_Pipe_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_1_2_in_Pipe_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_2_1_5_in_Pipe_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_3_in_Pipe_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_7_8_in_Pipe_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_AC_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_AC_Redundant_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_Anchors_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_Bottom_Pans_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_Dryer_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_Filter_Reg_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_Tubing_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Sourcing_Commisioning_Crew_Size_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Equipment_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Installation_Crew_Size_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Installer_Hours_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Lead_Hours_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Materials_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Misc_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Super_Hours_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectValue_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Debug_Mode_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_1_1_5_in_Pipe_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_1_2_in_Pipe_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_2_1_5_in_Pipe_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_3_in_Pipe_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_7_8_in_Pipe_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_AC_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_AC_Redundant_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_Anchors_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_Bottom_Pans_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_Dryer_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_Filter_Reg_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_Tubing_USERCHANGE() as Boolean
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
      Public Function Formula_Sourcing_Commisioning_Crew_Size_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Equipment_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Installation_Crew_Size_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Installer_Hours_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Lead_Hours_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Materials_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Misc_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Super_Hours_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectName_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectType_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_XMLObjectValue_USERCHANGE() as Boolean
      Return True
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

  