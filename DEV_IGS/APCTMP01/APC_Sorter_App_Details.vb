Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: APC_Sorter_App_Details
'$ GenerateDate: 07/19/2025 12:53:26

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

    Public Class [APC_Sorter_App_Details]
    
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

    Private this as APC_Sorter_App_Details = me

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
    
          Public Property [Faults_Avail]() As Long
      Get
      Return Properties("Faults_Avail").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Avail").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Length_Max]() As Long
      Get
      Return Properties("Faults_Length_Max").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Length_Max").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Length_Min]() As Long
      Get
      Return Properties("Faults_Length_Min").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Length_Min").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Rate]() As Long
      Get
      Return Properties("Faults_Rate").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Rate").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Sides]() As Long
      Get
      Return Properties("Faults_Sides").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Sides").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Temp_Min_Operating_Min]() As Long
      Get
      Return Properties("Faults_Temp_Min_Operating_Min").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Temp_Min_Operating_Min").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Total]() As Long
      Get
      Return Properties("Faults_Total").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Total").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Wdiths_Max]() As Long
      Get
      Return Properties("Faults_Wdiths_Max").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Wdiths_Max").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Weight_Max]() As Long
      Get
      Return Properties("Faults_Weight_Max").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Weight_Max").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Weight_Min]() As Long
      Get
      Return Properties("Faults_Weight_Min").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Weight_Min").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Width_Min]() As Long
      Get
      Return Properties("Faults_Width_Min").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Width_Min").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gap_Min_IN]() As Double
      Get
      Return Properties("Gap_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Length_Max_IN]() As Double
      Get
      Return Properties("Length_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Length_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Length_Min_IN]() As Double
      Get
      Return Properties("Length_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Length_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PK_ID]() As Long
      Get
      Return Properties("PK_ID").Value
      End Get
      Set(ByVal Value As Long)
      Properties("PK_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Rate_Max_IN]() As Double
      Get
      Return Properties("Rate_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Rate_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sorter_Type]() As String
      Get
      Return Properties("Sorter_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sorter_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_Max_RPM]() As Long
      Get
      Return Properties("Speed_Max_RPM").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Speed_Max_RPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Temp_Min_Operating_F]() As Double
      Get
      Return Properties("Temp_Min_Operating_F").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Temp_Min_Operating_F").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Weight_Max_IN]() As Double
      Get
      Return Properties("Weight_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Weight_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Weight_Min_IN]() As Double
      Get
      Return Properties("Weight_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Weight_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Width_Max_IN]() As Double
      Get
      Return Properties("Width_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Width_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Width_Min_IN]() As Double
      Get
      Return Properties("Width_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Width_Min_IN").CalculatedValue = Value
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
    
      Public ReadOnly Property [dbInfo]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("dbInfo")
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
    InitPart("APC_Sorter_App_Details", <a><![CDATA[APC Sorter App Details]]></a>.Value, 440, "APCTMP01",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/19/2025 12:30:21")
    AddProperty("10809", "Faults_Avail", <a><![CDATA[Faults Avail]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:30:21 PM")
    AddProperty("10803", "Faults_Length_Max", <a><![CDATA[Faults Length Max]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:27:52 PM")
    AddProperty("10800", "Faults_Length_Min", <a><![CDATA[Faults Length Min]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:26:49 PM")
    AddProperty("10806", "Faults_Rate", <a><![CDATA[Faults Rate]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:29:19 PM")
    AddProperty("10807", "Faults_Sides", <a><![CDATA[Faults Sides]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:29:49 PM")
    AddProperty("10808", "Faults_Temp_Min_Operating_Min", <a><![CDATA[Faults Temp Min Operating Min]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:30:02 PM")
    AddProperty("10799", "Faults_Total", <a><![CDATA[Faults Total]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:26:34 PM")
    AddProperty("10804", "Faults_Wdiths_Max", <a><![CDATA[Faults Wdiths Max]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:28:21 PM")
    AddProperty("10805", "Faults_Weight_Max", <a><![CDATA[Faults Weight Max]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:28:49 PM")
    AddProperty("10802", "Faults_Weight_Min", <a><![CDATA[Faults Weight Min]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:27:16 PM")
    AddProperty("10801", "Faults_Width_Min", <a><![CDATA[Faults Width Min]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:27:03 PM")
    AddProperty("10790", "Gap_Min_IN", <a><![CDATA[Gap Min IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:22:20 PM")
    AddProperty("10794", "Length_Max_IN", <a><![CDATA[Length Max  IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:24:26 PM")
    AddProperty("10791", "Length_Min_IN", <a><![CDATA[Length Min IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:22:48 PM")
    AddProperty("10787", "PK_ID", <a><![CDATA[PK_ID]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:20:52 PM")
    AddProperty("10797", "Rate_Max_IN", <a><![CDATA[Rate Max IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:25:26 PM")
    AddProperty("10788", "Sorter_Type", <a><![CDATA[Sorter Type]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:21:18 PM")
    AddProperty("10789", "Speed_Max_RPM", <a><![CDATA[Speed Max RPM]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:21:47 PM")
    AddProperty("10798", "Temp_Min_Operating_F", <a><![CDATA[Temp Min Operating F]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:25:57 PM")
    AddProperty("10796", "Weight_Max_IN", <a><![CDATA[Weight Max  IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:25:02 PM")
    AddProperty("10793", "Weight_Min_IN", <a><![CDATA[Weight Min IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:23:50 PM")
    AddProperty("10795", "Width_Max_IN", <a><![CDATA[Width Max  IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:24:49 PM")
    AddProperty("10792", "Width_Min_IN", <a><![CDATA[Width Min IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:23:30 PM")
    AddProperty("10785", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:10:27 PM")
    
      oSubpart = AddSubpart(353,"dbInfo", <a><![CDATA[dbInfo]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "7/19/2025 12:16:03 PM")
      
        oSubpart.AddVPF (441, "APC_Sorter_App_Details_dbInfo", "APC Sorter App Details dbInfo")
      
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
          InitProperty("Faults_Avail", "10368", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:30:21 PM", "", "In Development",  0,19416)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Length_Max", "10362", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:27:52 PM", "", "In Development",  0,19410)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Length_Min", "10359", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:26:49 PM", "", "In Development",  0,19406)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Rate", "10365", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:29:19 PM", "", "In Development",  0,19413)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Sides", "10366", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:29:49 PM", "", "In Development",  0,19414)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Temp_Min_Operating_Min", "10367", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:30:02 PM", "", "In Development",  0,19415)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Total", "10358", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:26:34 PM", "", "In Development",  0,19405)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Wdiths_Max", "10363", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:28:21 PM", "", "In Development",  0,19411)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Weight_Max", "10364", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:28:49 PM", "", "In Development",  0,19412)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Weight_Min", "10361", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:27:16 PM", "", "In Development",  0,19408)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Width_Min", "10360", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:27:03 PM", "", "In Development",  0,19407)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Min_IN", "10349", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:22:20 PM", "", "In Development",  0,19395)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Length_Max_IN", "10353", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:24:26 PM", "", "In Development",  0,19399)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Length_Min_IN", "10350", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:22:48 PM", "", "In Development",  0,19396)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PK_ID", "10346", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:20:52 PM", "", "In Development",  0,19357)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Rate_Max_IN", "10356", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:25:26 PM", "", "In Development",  0,19402)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sorter_Type", "10347", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:21:18 PM", "", "In Development",  0,19393)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_Max_RPM", "10348", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:21:47 PM", "", "In Development",  0,19394)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Temp_Min_Operating_F", "10357", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:25:57 PM", "", "In Development",  0,19404)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Weight_Max_IN", "10355", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:25:02 PM", "", "In Development",  0,19401)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Weight_Min_IN", "10352", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:23:50 PM", "", "In Development",  0,19398)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Width_Max_IN", "10354", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:24:49 PM", "", "In Development",  0,19400)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Width_Min_IN", "10351", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:23:30 PM", "", "In Development",  0,19397)
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
          
        InitSubpart("dbInfo", 280, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "7/19/2025 12:16:03 PM", "", "In Development", "N",0,775,774)
        
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
          Public Function Formula_Faults_Avail() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Avail").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10368; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10368; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Faults_Avail", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Length_Max() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Length_Max").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10362; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10362; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Faults_Length_Max", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Length_Min() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Length_Min").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10359; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10359; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Faults_Length_Min", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Rate() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Rate").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10365; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10365; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Faults_Rate", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Sides() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Sides").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10366; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10366; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Faults_Sides", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Temp_Min_Operating_Min() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Temp_Min_Operating_Min").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10367; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10367; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Faults_Temp_Min_Operating_Min", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Total() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Total").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10358; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10358; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Faults_Total", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Wdiths_Max() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Wdiths_Max").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10363; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10363; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Faults_Wdiths_Max", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Weight_Max() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Weight_Max").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10364; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10364; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Faults_Weight_Max", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Weight_Min() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Weight_Min").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10361; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10361; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Faults_Weight_Min", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Width_Min() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Width_Min").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10360; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10360; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Faults_Width_Min", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gap_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10349; TYPE:PF
      result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10349; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Gap_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Length_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Length_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10353; TYPE:PF
      result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10353; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Length_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Length_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Length_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10350; TYPE:PF
      result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10350; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Length_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PK_ID() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PK_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10346; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:10346; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_PK_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Rate_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Rate_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10356; TYPE:PF
      result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10356; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Rate_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sorter_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sorter_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10347; TYPE:PF
      result = ""
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10347; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Sorter_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_Max_RPM() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_Max_RPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10348; TYPE:PF
      result = 0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10348; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Speed_Max_RPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Temp_Min_Operating_F() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Temp_Min_Operating_F").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10357; TYPE:PF
      result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10357; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Temp_Min_Operating_F", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Weight_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Weight_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10355; TYPE:PF
      result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10355; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Weight_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Weight_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Weight_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10352; TYPE:PF
      result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10352; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Weight_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Width_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Width_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10354; TYPE:PF
      result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10354; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Width_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Width_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Width_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10351; TYPE:PF
      result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10351; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_Width_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Avail_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Length_Max_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Length_Min_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Rate_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Sides_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Temp_Min_Operating_Min_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Total_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Wdiths_Max_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Weight_Max_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Weight_Min_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Width_Min_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PK_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Rate_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Max_RPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_Min_Operating_F_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Width_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Width_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Avail_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Length_Max_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Length_Min_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Rate_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Sides_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Temp_Min_Operating_Min_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Total_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Wdiths_Max_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Weight_Max_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Weight_Min_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Width_Min_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_Max_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PK_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Rate_Max_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Max_RPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_Min_Operating_F_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_Max_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Width_Max_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Width_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_dbInfo_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:280; TYPE:PN
      
      '   END FORMULA; SUB ID:280; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_dbInfo_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_dbInfo_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("dbInfo").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:280; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:280; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_dbInfo_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_dbInfo_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("dbInfo").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:280; TYPE:OP
      result = "APC_Sorter_App_Details_dbInfo"
      '   END FORMULA; SUB ID:280; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Sorter_App_Details.Formula_dbInfo_OPTIMALPARTFAMILY", ex.Message)
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

  