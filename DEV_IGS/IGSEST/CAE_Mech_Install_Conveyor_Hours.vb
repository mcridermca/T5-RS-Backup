Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_Mech_Install_Conveyor_Hours
'$ GenerateDate: 07/12/2025 19:19:17

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

    Public Class [CAE_Mech_Install_Conveyor_Hours]
    
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

    Private this as CAE_Mech_Install_Conveyor_Hours = me

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
    
          Public Property [Bed_Lgth_Avg]() As Double
      Get
      Return Properties("Bed_Lgth_Avg").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Bed_Lgth_Avg").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Beds_Misc]() As Double
      Get
      Return Properties("Beds_Misc").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Beds_Misc").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Belting_Chain_per_100_ft]() As Double
      Get
      Return Properties("Belting_Chain_per_100_ft").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Belting_Chain_per_100_ft").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CAE_MCHINST_CONVEYOR_HRS_MASTER_ID]() As Long
      Get
      Return Properties("CAE_MCHINST_CONVEYOR_HRS_MASTER_ID").Value
      End Get
      Set(ByVal Value As Long)
      Properties("CAE_MCHINST_CONVEYOR_HRS_MASTER_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_Type]() As String
      Get
      Return Properties("Conveyor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Conveyor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Diverts]() As Long
      Get
      Return Properties("Diverts").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Diverts").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Drives]() As Double
      Get
      Return Properties("Drives").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Drives").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Large]() As Double
      Get
      Return Properties("Large").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Large").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Layout_Per_100_ft]() As Double
      Get
      Return Properties("Layout_Per_100_ft").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Layout_Per_100_ft").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Medium]() As Double
      Get
      Return Properties("Medium").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Medium").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Run_In_Per_100_ft]() As Double
      Get
      Return Properties("Run_In_Per_100_ft").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Run_In_Per_100_ft").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Side_Guide_per_bed_per_side]() As Double
      Get
      Return Properties("Side_Guide_per_bed_per_side").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Side_Guide_per_bed_per_side").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Small]() As Double
      Get
      Return Properties("Small").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Small").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Supports_Each]() As Double
      Get
      Return Properties("Supports_Each").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Supports_Each").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Transfers]() As Long
      Get
      Return Properties("Transfers").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Transfers").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Unloading_per_bed]() As Double
      Get
      Return Properties("Unloading_per_bed").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Unloading_per_bed").CalculatedValue = Value
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
    InitPart("CAE_Mech_Install_Conveyor_Hours", <a><![CDATA[CAE Mech Install Conveyor Hours]]></a>.Value, 384, "IGSEST",  "N", "N", False, False, "In Development", "", "Data Cache for Converyor Data that was in the Original Data's Metric Spreadsheet", "", "", "",  "GLOBAL\H617242", "07/10/2025 07:00:12")
    AddProperty("5312", "Bed_Lgth_Avg", <a><![CDATA[Bed Lgth Avg]]></a>.Value, "Bed Lgth Avg", "Double","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 12:31:28 PM")
    AddProperty("5302", "Beds_Misc", <a><![CDATA[Beds Misc]]></a>.Value, "Beds Misc", "Double","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 12:26:20 PM")
    AddProperty("5308", "Belting_Chain_per_100_ft", <a><![CDATA[Belting Chain per 100 ft]]></a>.Value, "Belting Chain per 100 ft", "Double","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 12:29:49 PM")
    AddProperty("5300", "CAE_MCHINST_CONVEYOR_HRS_MASTER_ID", <a><![CDATA[CAE MCHINST CONVEYOR HRS MASTER ID]]></a>.Value, "Primary Key (System Use Only)", "Long","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H617242", "7/10/2025 7:00:12 AM")
    AddProperty("5301", "Conveyor_Type", <a><![CDATA[Conveyor Type]]></a>.Value, "Conveyor Type", "String","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/30/2025 12:39:45 PM")
    AddProperty("5305", "Diverts", <a><![CDATA[Diverts]]></a>.Value, "Diverts", "Long","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 12:28:09 PM")
    AddProperty("5303", "Drives", <a><![CDATA[Drives]]></a>.Value, "Drives", "Double","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 12:26:55 PM")
    AddProperty("5313", "Large", <a><![CDATA[Large]]></a>.Value, "Large", "Double","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 12:32:03 PM")
    AddProperty("5310", "Layout_Per_100_ft", <a><![CDATA[Layout Per 100 ft]]></a>.Value, "Layout Per 100 ft", "Double","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 12:30:58 PM")
    AddProperty("5314", "Medium", <a><![CDATA[Medium]]></a>.Value, "Medium", "Double","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 12:32:41 PM")
    AddProperty("5311", "Run_In_Per_100_ft", <a><![CDATA[Run In Per 100 ft]]></a>.Value, "Run In Per 100 ft", "Double","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 12:31:11 PM")
    AddProperty("5306", "Side_Guide_per_bed_per_side", <a><![CDATA[Side Guide per bed per side]]></a>.Value, "Side Guide per bed per side", "Double","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 12:28:36 PM")
    AddProperty("5315", "Small", <a><![CDATA[Small]]></a>.Value, "Small", "Double","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 12:33:20 PM")
    AddProperty("5307", "Supports_Each", <a><![CDATA[Supports Each]]></a>.Value, "Supports Each", "Double","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 12:29:13 PM")
    AddProperty("5304", "Transfers", <a><![CDATA[Transfers]]></a>.Value, "Transfers", "Long","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 12:27:29 PM")
    AddProperty("5309", "Unloading_per_bed", <a><![CDATA[Unloading per bed]]></a>.Value, "Unloading per bed", "Double","","Database Lookup","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/27/2025 12:30:17 PM")
    AddProperty("5036", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/26/2025 12:24:22 PM")
    
      AddDBConstraint(7, "dbInfo", <a><![CDATA[dbInfo]]></a>.Value,"Database Lookup", 9999)
    
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
          InitProperty("Bed_Lgth_Avg", "4925", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 12:31:28 PM", "Bed Lgth Avg", "In Development",  0,7546)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Beds_Misc", "4915", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 12:26:20 PM", "Beds Misc", "In Development",  0,7536)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Belting_Chain_per_100_ft", "4921", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 12:29:49 PM", "Belting Chain per 100 ft", "In Development",  0,7542)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CAE_MCHINST_CONVEYOR_HRS_MASTER_ID", "4913", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H617242", "7/10/2025 7:00:12 AM", "Primary Key (System Use Only)", "In Development",  0,15917)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_Type", "4914", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/30/2025 12:39:45 PM", "Conveyor Type", "In Development",  0,8836)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Diverts", "4918", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 12:28:09 PM", "Diverts", "In Development",  0,7539)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Drives", "4916", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 12:26:55 PM", "Drives", "In Development",  0,7537)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Large", "4926", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 12:32:03 PM", "Large", "In Development",  0,7547)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Layout_Per_100_ft", "4923", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 12:30:58 PM", "Layout Per 100 ft", "In Development",  0,7544)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Medium", "4927", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 12:32:41 PM", "Medium", "In Development",  0,7548)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Run_In_Per_100_ft", "4924", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 12:31:11 PM", "Run In Per 100 ft", "In Development",  0,7545)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Side_Guide_per_bed_per_side", "4919", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 12:28:36 PM", "Side Guide per bed per side", "In Development",  0,7540)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Small", "4928", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 12:33:20 PM", "Small", "In Development",  0,7549)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Supports_Each", "4920", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 12:29:13 PM", "Supports Each", "In Development",  0,7541)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Transfers", "4917", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 12:27:29 PM", "Transfers", "In Development",  0,7538)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Unloading_per_bed", "4922", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/27/2025 12:30:17 PM", "Unloading per bed", "In Development",  0,7543)
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
          
        InitDBConstraint("dbInfo", 7,"", "Y","", "", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Bed_Lgth_Avg",7, "Bed_Lgth_Avg", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Beds_Misc",7, "Beds_Misc", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Belting_Chain_per_100_ft",7, "Belting_Chain_per_100_ft", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Conveyor_Type",7, "Conveyor_Type", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Diverts",7, "Diverts", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Drives",7, "Drives", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Large",7, "Large", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Layout_Per_100_ft",7, "Layout_Per_100_ft", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Medium",7, "Medium", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Run_In_Per_100_ft",7, "Run_In_Per_100_ft", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Side_Guide_per_bed_per_side",7, "Side_Guide_per_bed_per_side", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Small",7, "Small", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Supports_Each",7, "Supports_Each", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Transfers",7, "Transfers", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          InitDBproperty("dbInfo", "Unloading_per_bed",7, "Unloading_per_bed", "CAE_MEI_CONVEYOR_HRS_MASTER")
        
          End If
        
    End Sub

    #End Region

    #Region " Formulas "

    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Bed_Lgth_Avg() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Bed_Lgth_Avg").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4925; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:4925; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Bed_Lgth_Avg", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Beds_Misc() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Beds_Misc").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4915; TYPE:PF
      result = 3.6412
      '   END FORMULA; PROP ID:4915; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Beds_Misc", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Belting_Chain_per_100_ft() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Belting_Chain_per_100_ft").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4921; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:4921; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Belting_Chain_per_100_ft", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CAE_MCHINST_CONVEYOR_HRS_MASTER_ID() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CAE_MCHINST_CONVEYOR_HRS_MASTER_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4913; TYPE:PF
      Result = Me.Parent.ValidValues("Conveyor_Hours_Row_DBKeys")(Me.SubpartID-1)
      '   END FORMULA; PROP ID:4913; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_CAE_MCHINST_CONVEYOR_HRS_MASTER_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4914; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:4914; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Conveyor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Diverts() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Diverts").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4918; TYPE:PF
      result =  2
      '   END FORMULA; PROP ID:4918; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Diverts", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Drives() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Drives").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4916; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:4916; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Drives", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Large() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Large").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4926; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:4926; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Large", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Layout_Per_100_ft() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Layout_Per_100_ft").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4923; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:4923; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Layout_Per_100_ft", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Medium() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Medium").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4927; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:4927; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Medium", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Run_In_Per_100_ft() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Run_In_Per_100_ft").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4924; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:4924; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Run_In_Per_100_ft", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Side_Guide_per_bed_per_side() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Side_Guide_per_bed_per_side").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4919; TYPE:PF
      result = 1.02
      '   END FORMULA; PROP ID:4919; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Side_Guide_per_bed_per_side", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Small() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Small").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4928; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:4928; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Small", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Supports_Each() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Supports_Each").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4920; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:4920; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Supports_Each", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Transfers() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Transfers").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4917; TYPE:PF
      result = 4
      '   END FORMULA; PROP ID:4917; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Transfers", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Unloading_per_bed() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Unloading_per_bed").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4922; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:4922; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.Formula_Unloading_per_bed", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Bed_Lgth_Avg_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Beds_Misc_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belting_Chain_per_100_ft_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CAE_MCHINST_CONVEYOR_HRS_MASTER_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Diverts_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drives_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Large_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Layout_Per_100_ft_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Medium_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Run_In_Per_100_ft_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Side_Guide_per_bed_per_side_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Small_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Supports_Each_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Transfers_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unloading_per_bed_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Bed_Lgth_Avg_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Beds_Misc_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belting_Chain_per_100_ft_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CAE_MCHINST_CONVEYOR_HRS_MASTER_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Diverts_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Drives_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Large_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Layout_Per_100_ft_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Medium_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Run_In_Per_100_ft_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Side_Guide_per_bed_per_side_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Small_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Supports_Each_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Transfers_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Unloading_per_bed_USERCHANGE() as Boolean
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
      
        Case 7
        ctx = this
            strWhereClause = ""
            strSelectList = ""
            
              strSelectList = strSelectList & leftDelimiter & "Bed_Lgth_Avg" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Beds_Misc" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Belting_Chain_per_100_ft" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Conveyor_Type" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Diverts" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Drives" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Large" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Layout_Per_100_ft" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Medium" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Run_In_Per_100_ft" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Side_Guide_per_bed_per_side" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Small" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Supports_Each" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Transfers" & rightDelimiter & ", "
            
              strSelectList = strSelectList & leftDelimiter & "Unloading_per_bed" & rightDelimiter & ", "
            
            'Build the WHERE clause
            
                  varPropSpecVal = me.CAE_MCHINST_CONVEYOR_HRS_MASTER_ID
              BuildWhereClause(strWhereClause, "0", "0", "  ", "[CAE_MCHINST_CONVEYOR_HRS_MASTER_ID]", "=", varPropSpecVal, "")
            
            strSelectStmt = BuildSQLStatement(strSelectList, DelimitTableName("CAE_MEI_CONVEYOR_HRS_MASTER"), strWhereClause, leftDelimiter & "Conveyor_Type" & rightDelimiter, "ASC")
          
      End Select
      Catch ex as Exception
      Dim strError As String = ex.Message
      If strSelectStmt <> "" Then
      strError = strError & vbCrLf & vbCrLf & strSelectStmt
      strSelectStmt = ""
      End If
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_Conveyor_Hours.GetRecordset", strError)
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

  