Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_APC_Belt_Turn
'$ GenerateDate: 07/24/2025 13:40:56

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

    Public Class [CAE_APC_Belt_Turn]
    
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

    Private this as CAE_APC_Belt_Turn = me

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
    
          Public Property [Adjustment_Factor]() As Double
      Get
      Return Properties("Adjustment_Factor").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Adjustment_Factor").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Belt_Curve_Centerline_Radius_IN]() As Double
      Get
      Return Properties("Belt_Curve_Centerline_Radius_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Belt_Curve_Centerline_Radius_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Belt_Curve_Inside_Radius_IN]() As Double
      Get
      Return Properties("Belt_Curve_Inside_Radius_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Belt_Curve_Inside_Radius_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Belt_Curve_Width_IN]() As Double
      Get
      Return Properties("Belt_Curve_Width_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Belt_Curve_Width_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Belt_Turn_Data_Row_DBKeys]() As Long
      Get
      Return Properties("Belt_Turn_Data_Row_DBKeys").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Belt_Turn_Data_Row_DBKeys").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_Alignment]() As String
      Get
      Return Properties("Carton_Alignment").Value
      End Get
      Set(ByVal Value As String)
      Properties("Carton_Alignment").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_Length_Allowable_Max_IN]() As Double
      Get
      Return Properties("Carton_Length_Allowable_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Carton_Length_Allowable_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_Length_Max_IN]() As Double
      Get
      Return Properties("Carton_Length_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Carton_Length_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_Width_Allowable_Max_In]() As Double
      Get
      Return Properties("Carton_Width_Allowable_Max_In").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Carton_Width_Allowable_Max_In").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_Width_Avg_IN]() As Double
      Get
      Return Properties("Carton_Width_Avg_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Carton_Width_Avg_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_Width_Max_IN]() As Double
      Get
      Return Properties("Carton_Width_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Carton_Width_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Matched_Input_Speed_FPM]() As Double
      Get
      Return Properties("Matched_Input_Speed_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Matched_Input_Speed_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Radius_Outside_Edge_IN]() As Double
      Get
      Return Properties("Radius_Outside_Edge_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Radius_Outside_Edge_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_Belt_Curve_at_Centerline_FPM]() As Double
      Get
      Return Properties("Speed_Belt_Curve_at_Centerline_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Speed_Belt_Curve_at_Centerline_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_Conveyor_Infeed_FPM]() As Double
      Get
      Return Properties("Speed_Conveyor_Infeed_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Speed_Conveyor_Infeed_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_Match_Radius_Value_IN]() As Double
      Get
      Return Properties("Speed_Match_Radius_Value_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Speed_Match_Radius_Value_IN").CalculatedValue = Value
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
    
      Public ReadOnly Property [Belt_Turn_Data_Rows]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Belt_Turn_Data_Rows")
      End Get
      End Property
    
      Public ReadOnly Property [My_Belt_Turn_Data_Row]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Belt_Turn_Data_Row")
      End Get
      End Property
    
      Public ReadOnly Property [My_Induction]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Induction")
      End Get
      End Property
    
      Public ReadOnly Property [My_PRD]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_PRD")
      End Get
      End Property
    
      Public ReadOnly Property [My_Setup]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Setup")
      End Get
      End Property
    
      Public ReadOnly Property [My_Sortation]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Sortation")
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
    InitPart("CAE_APC_Belt_Turn", <a><![CDATA[CAE_APC_Belt_Turn]]></a>.Value, 452, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/24/2025 13:34:47")
    AddProperty("11338", "Adjustment_Factor", <a><![CDATA[Adjustment_Factor]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 12:21:29 AM")
    AddProperty("11347", "Belt_Curve_Centerline_Radius_IN", <a><![CDATA[Belt_Curve_Centerline_Radius_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 2:20:58 AM")
    AddProperty("11346", "Belt_Curve_Inside_Radius_IN", <a><![CDATA[Belt_Curve_Inside_Radius_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 1:35:51 AM")
    AddProperty("11345", "Belt_Curve_Width_IN", <a><![CDATA[Belt_Curve_Width_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 12:37:10 AM")
    AddProperty("11327", "Belt_Turn_Data_Row_DBKeys", <a><![CDATA[Belt_Turn_Data_Row_DBKeys]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/23/2025 11:32:18 PM")
    AddProperty("11341", "Carton_Alignment", <a><![CDATA[Carton_Alignment]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 12:20:42 AM")
    AddProperty("11350", "Carton_Length_Allowable_Max_IN", <a><![CDATA[Carton_Length_Allowable_Max_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 1:34:47 PM")
    AddProperty("11339", "Carton_Length_Max_IN", <a><![CDATA[Carton_Length_Max_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/23/2025 11:59:49 PM")
    AddProperty("11357", "Carton_Width_Allowable_Max_In", <a><![CDATA[Carton_Width_Allowable_Max_In]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 11:59:18 AM")
    AddProperty("11343", "Carton_Width_Avg_IN", <a><![CDATA[Carton_Width_Avg_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 12:26:55 AM")
    AddProperty("11344", "Carton_Width_Max_IN", <a><![CDATA[Carton_Width_Max_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 12:27:18 AM")
    AddProperty("11351", "Matched_Input_Speed_FPM", <a><![CDATA[Matched_Input_Speed_FPM]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 1:03:26 AM")
    AddProperty("11358", "Radius_Outside_Edge_IN", <a><![CDATA[Radius_Outside_Edge_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 12:00:36 PM")
    AddProperty("11349", "Speed_Belt_Curve_at_Centerline_FPM", <a><![CDATA[Speed_Belt_Curve_at_Centerline_FPM]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 2:24:06 AM")
    AddProperty("11342", "Speed_Conveyor_Infeed_FPM", <a><![CDATA[Speed_Conveyor_Infeed_FPM]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 12:26:14 AM")
    AddProperty("11348", "Speed_Match_Radius_Value_IN", <a><![CDATA[Speed_Match_Radius_Value_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 2:14:56 AM")
    AddProperty("11325", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/23/2025 11:19:55 PM")
    
      AddValidValue("Belt_Turn_Data_Row_DBKeys")
    
      AddValidValue("Carton_Alignment")
    
      oSubpart = AddSubpart(364,"Belt_Turn_Data_Rows", <a><![CDATA[Belt_Turn_Data_Rows]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "7/23/2025 11:39:32 PM")
      
        oSubpart.AddVPF (453, "CAE_APC_Belt_Turn_Data_Row", "CAE_APC_Belt_Turn_Data_Row")
      
      oConnection = AddConnection("My_Belt_Turn_Data_Row", <a><![CDATA[My_Belt_Turn_Data_Row]]></a>.Value, "", "240", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/24/2025 1:08:32 AM")
      
        oConnection.AddVPF(453, "CAE_APC_Belt_Turn_Data_Row")
      
      oConnection = AddConnection("My_Induction", <a><![CDATA[My_Induction]]></a>.Value, "Connection to My Induction Object", "236", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/23/2025 11:58:15 PM")
      
        oConnection.AddVPF(448, "CAE_APC_Induction")
      
      oConnection = AddConnection("My_PRD", <a><![CDATA[My PRD]]></a>.Value, "", "237", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/23/2025 11:57:54 PM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      
      oConnection = AddConnection("My_Setup", <a><![CDATA[My_Setup]]></a>.Value, "My App Calc Setup Object", "238", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/23/2025 11:57:54 PM")
      
        oConnection.AddVPF(119, "APC_Setup")
      
      oConnection = AddConnection("My_Sortation", <a><![CDATA[My_Sortation]]></a>.Value, "", "239", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/24/2025 12:32:53 AM")
      
        oConnection.AddVPF(436, "APC_Setup_Sort_Equip_Option")
      
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
          InitProperty("Adjustment_Factor", "10885", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 12:21:29 AM", "", "In Development",  0,21447)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Belt_Curve_Centerline_Radius_IN", "10894", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 2:20:58 AM", "", "In Development",  0,21502)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Belt_Curve_Inside_Radius_IN", "10893", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 1:35:51 AM", "", "In Development",  0,21488)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Belt_Curve_Width_IN", "10892", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 12:36:58 AM", "", "In Development",  0,21476)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Belt_Turn_Data_Row_DBKeys", "10874", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/23/2025 11:32:18 PM", "", "In Development",  0,21432)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_Alignment", "10888", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 12:20:42 AM", "", "In Development",  0,21461)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_Length_Allowable_Max_IN", "10897", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 1:34:47 PM", "", "In Development",  0,21613)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_Length_Max_IN", "10886", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/23/2025 11:59:49 PM", "", "In Development",  0,21453)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_Width_Allowable_Max_In", "10904", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 11:59:18 AM", "", "In Development",  0,21594)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_Width_Avg_IN", "10890", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 12:26:55 AM", "", "In Development",  0,21473)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_Width_Max_IN", "10891", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 12:27:18 AM", "", "In Development",  0,21474)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Matched_Input_Speed_FPM", "10898", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 1:03:26 AM", "", "In Development",  0,21483)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Radius_Outside_Edge_IN", "10905", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 12:00:36 PM", "", "In Development",  0,21597)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_Belt_Curve_at_Centerline_FPM", "10896", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 2:24:06 AM", "", "In Development",  0,21507)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_Conveyor_Infeed_FPM", "10889", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 12:26:14 AM", "", "In Development",  0,21472)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_Match_Radius_Value_IN", "10895", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 2:14:51 AM", "", "In Development",  0,21501)
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
          
        InitValidValue("Belt_Turn_Data_Row_DBKeys_ValidValues", "10874", "-1", 21433)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Carton_Alignment_ValidValues", "10888", "-1", 21462)
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
          
        InitSubpart("Belt_Turn_Data_Rows", 291, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "7/23/2025 11:39:32 PM", "", "In Development", "N",0,816,818)
        
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
          
        InitConnection("My_Belt_Turn_Data_Row", "219", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/24/2025 1:08:26 AM", "", "In Development", "N",387)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Induction", "215", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/23/2025 11:57:54 PM", "", "In Development", "N",383)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_PRD", "216", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/23/2025 11:57:54 PM", "", "In Development", "N",384)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Setup", "217", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/23/2025 11:57:54 PM", "", "In Development", "N",385)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Sortation", "218", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/24/2025 12:32:53 AM", "", "In Development", "N",386)
        
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
      Public Function Formula_My_Belt_Turn_Data_Row_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:219; TYPE:PF
        Result = Nothing

For Each p As part In Me.Belt_Turn_Data_Rows
	If p.properties("Speed_conveyor_Infeed_FPM").Value = Me.Matched_Input_Speed_FPM  Then
		Result = p
	End If
Next p
        '   END FORMULA; CON ID:219; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_My_Belt_Turn_Data_Row_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Induction_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:215; TYPE:PF
        Result = Nothing
If Me.Parent.Induction.Quantity > 0 Then
	Result = Me.Parent.Induction(1)
End If
        '   END FORMULA; CON ID:215; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_My_Induction_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_PRD_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:216; TYPE:PF
        Result = Me.Parent.My_Prd(1)
        '   END FORMULA; CON ID:216; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_My_PRD_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Setup_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:217; TYPE:PF
        Result = Me.Parent.My_Setup(1)
        '   END FORMULA; CON ID:217; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_My_Setup_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Sortation_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:218; TYPE:PF
        Result = Me.Parent.Sortation(1)
        '   END FORMULA; CON ID:218; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_My_Sortation_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Adjustment_Factor() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Adjustment_Factor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10885; TYPE:PF
      Result = 2.22
      '   END FORMULA; PROP ID:10885; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Adjustment_Factor", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Belt_Curve_Centerline_Radius_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Belt_Curve_Centerline_Radius_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10894; TYPE:PF
      '=IF(BTInfeedSpeed>0,IF(BTWidth>0,BTInsideRadius+(BTWidth/2),"Enter Belt Width"),"Enter Infeed Speed")
'=IF(BTInfeedSpeed>0,IF(BTWidth>0,BTInsideRadius+(BTWidth/2),"Enter Belt Width"),"Enter Infeed Speed")
'
Dim BTInfeedSpeed = Me.Speed_Conveyor_Infeed_FPM
Dim BTWidth = Me.My_Induction(1).Sorter_Selected_Width_IN
Dim BTInsideRadius = Me.My_Belt_Turn_Data_Row(1).Radius_Inside_Recommended

Result = If(BTInfeedSpeed>0,If(BTWidth>0,BTInsideRadius+(BTWidth/2),0),0)
      '   END FORMULA; PROP ID:10894; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Belt_Curve_Centerline_Radius_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Belt_Curve_Inside_Radius_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Belt_Curve_Inside_Radius_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10893; TYPE:PF
      ' = IF(BTInfeedSpeed>0,HLOOKUP(BTInfeedSpeed,'Belt Turn Data'!$G$3:$T$8,6),"Enter Infeed Speed")
Result = Me.My_Belt_Turn_Data_Row(1).Radius_Inside_Recommended
      '   END FORMULA; PROP ID:10893; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Belt_Curve_Inside_Radius_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Belt_Curve_Width_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Belt_Curve_Width_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10892; TYPE:PF
      Result = me.My_Induction(1).Sorter_Selected_Width_IN
      '   END FORMULA; PROP ID:10892; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Belt_Curve_Width_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Belt_Turn_Data_Row_DBKeys() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Belt_Turn_Data_Row_DBKeys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10874; TYPE:PF
      Result = Me.ValidValues("Belt_Turn_Data_Row_DBKeys").Count
      '   END FORMULA; PROP ID:10874; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Belt_Turn_Data_Row_DBKeys", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_Alignment() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Alignment").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10888; TYPE:PF
      Result = Me.My_Induction(1).Carton_Alignment_on_Belt_Curve
      '   END FORMULA; PROP ID:10888; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Carton_Alignment", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_Length_Allowable_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Length_Allowable_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10897; TYPE:PF
      '=IF(BTInfeedSpeed>0,IF(BTWidth>0,IF(BTMaxBoxWidth>0,2*SQRT(((BTOutsideEdgeRadius)*(BTOutsideEdgeRadius))-((BTInsideRadius+BTMaxBoxWidth+2)*(BTInsideRadius+BTMaxBoxWidth+2))),"Enter Maximum Carton Width"),"Enter Belt Width"),"Enter Infeed Speed")
'Stop
Dim BTInfeedSpeed = Me.Speed_Conveyor_Infeed_FPM
Dim BTWidth = Me.My_Induction(1).Sorter_Selected_Width_IN
Dim BTInsideRadius = Me.My_Belt_Turn_Data_Row(1).Radius_Inside_Recommended
Dim BTCartonAlignment = Me.Carton_Alignment
Dim BTAvgBoxWidth = Me.Carton_Width_Avg_IN
Dim BTMaxBoxWidth = Me.Carton_Width_Max_IN
Dim BTMatchRadius = Me.Speed_Match_Radius_Value_In
Dim BTOutsideEdgeRadius As Double = Me.Radius_Outside_Edge_IN

'=If(BTInfeedSpeed>0,If(BTWidth>0,If(BTMaxBoxWidth>0,2*SQRT(((BTOutsideEdgeRadius)*(BTOutsideEdgeRadius))-((BTInsideRadius+BTMaxBoxWidth+2)*(BTInsideRadius+BTMaxBoxWidth+2))),"Enter Maximum Carton Width"),"Enter Belt Width"),"Enter Infeed Speed")
Result = If(BTInfeedSpeed>0,If(BTWidth>0,If(BTMaxBoxWidth>0,2*SQRT(((BTOutsideEdgeRadius)*(BTOutsideEdgeRadius))-((BTInsideRadius+BTMaxBoxWidth+2)*(BTInsideRadius+BTMaxBoxWidth+2))),"Enter Maximum Carton Width"),"Enter Belt Width"),"Enter Infeed Speed")
      '   END FORMULA; PROP ID:10897; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Carton_Length_Allowable_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_Length_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Length_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10886; TYPE:PF
      Result = Me.My_Setup(1).BoxSize_Length_Max_IN
      '   END FORMULA; PROP ID:10886; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Carton_Length_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_Width_Allowable_Max_In() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Width_Allowable_Max_In").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10904; TYPE:PF
      '=IF($A$5>0,IF($E$5>0,IF($D$15>0,SQRT((BTOutsideEdgeRadius*BTOutsideEdgeRadius)-(($D$15/2)*($D$15/2)))-$F$5-2,"Enter Maximum Carton Length"),"Enter Belt Width"),"Enter Infeed Speed")

Dim BTInfeedSpeed = Me.Speed_Conveyor_Infeed_FPM 'A5
Dim BTWidth = Me.My_Induction(1).Sorter_Selected_Width_IN 'E5
Dim BTInsideRadius = Me.My_Belt_Turn_Data_Row(1).Radius_Inside_Recommended
Dim BTCartonAlignment = Me.Carton_Alignment
Dim BTAvgBoxWidth = Me.Carton_Width_Avg_IN
Dim BTMaxBoxWidth = Me.Carton_Width_Max_IN
Dim BTMatchRadius = Me.Speed_Match_Radius_Value_In
Dim BTCartonLengthMax = Me.Carton_Length_Max_IN 'D15
Dim BTOutsideEdgeRadius As Double = Me.Radius_Outside_Edge_IN

'=IF($A$5>0,IF($E$5>0,IF($D$15>0,SQRT((BTOutsideEdgeRadius*BTOutsideEdgeRadius)-(($D$15/2)*($D$15/2)))-$F$5-2,"Enter Maximum Carton Length"),"Enter Belt Width"),"Enter Infeed Speed")
Result = If(BTInfeedSpeed>0,If(BTWidth>0,If(BTCartonLengthMax>0,SQRT((BTOutsideEdgeRadius*BTOutsideEdgeRadius)-((BTCartonLengthMax/2)*(BTCartonLengthMax/2)))-BTInsideRadius-2,0),0),0)
      '   END FORMULA; PROP ID:10904; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Carton_Width_Allowable_Max_In", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_Width_Avg_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Width_Avg_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10890; TYPE:PF
      Result = Me.My_Setup(1).BoxSize_Width_Avg_IN
      '   END FORMULA; PROP ID:10890; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Carton_Width_Avg_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_Width_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Width_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10891; TYPE:PF
      Result = Me.My_Setup(1).BoxSize_Width_Max_IN
      '   END FORMULA; PROP ID:10891; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Carton_Width_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Matched_Input_Speed_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Matched_Input_Speed_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10898; TYPE:PF
      ' = IF(BTInfeedSpeed>0,HLOOKUP(BTInfeedSpeed,'Belt Turn Data'!$G$3:$T$8,6),"Enter Infeed Speed")
Result = 0

Dim BTInfeedSpeed As Double = Me.Speed_Conveyor_Infeed_FPM  

Dim ThisLookup As Double = 0
Dim LastLookup As Double = 0 
 
For Each p As part In Me.Belt_Turn_Data_Rows
	ThisLookup = p.Properties("Speed_Conveyor_Infeed_FPM").Value
	If LastLookup <= BTInfeedSpeed And BTInfeedSpeed < ThisLookup Then
		 Result = ThisLookup
	 End If
	 LastLookup = ThisLookup
Next p
      '   END FORMULA; PROP ID:10898; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Matched_Input_Speed_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Radius_Outside_Edge_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Radius_Outside_Edge_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10905; TYPE:PF
      '=BTWidth+BTInsideRadius


Dim BTWidth = Me.My_Induction(1).Sorter_Selected_Width_IN 'E5
Dim BTInsideRadius = Me.My_Belt_Turn_Data_Row(1).Radius_Inside_Recommended



Result = BTWidth + BTInsideRadius
      '   END FORMULA; PROP ID:10905; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Radius_Outside_Edge_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_Belt_Curve_at_Centerline_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_Belt_Curve_at_Centerline_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10896; TYPE:PF
      '=IF(BTWidth>0,IF(OR(BTCartonAlignment="Random",BTCartonAlignment="Centered",BTCartonAlignment="Inside",BTCartonAlignment="Outside"),BTInfeedSpeed*(BTInsideRadius+(BTWidth/2))/BTMatchRadius,"Enter Alignment"),"Enter Belt Width")
Dim BTInfeedSpeed = Me.Speed_Conveyor_Infeed_FPM
Dim BTWidth = Me.My_Induction(1).Sorter_Selected_Width_IN
Dim BTInsideRadius = Me.My_Belt_Turn_Data_Row(1).Radius_Inside_Recommended
Dim BTCartonAlignment = Me.Carton_Alignment
Dim BTAvgBoxWidth = Me.Carton_Width_Avg_IN
Dim BTMaxBoxWidth = Me.Carton_Width_Max_IN
Dim BTMatchRadius = Me.Speed_Match_Radius_Value_In

Result = If(BTWidth>0,If(XlsOr(BTCartonAlignment="Random",BTCartonAlignment="Centered",BTCartonAlignment="Inside",BTCartonAlignment="Outside"),BTInfeedSpeed*(BTInsideRadius+(BTWidth/2))/BTMatchRadius,0),0)
      '   END FORMULA; PROP ID:10896; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Speed_Belt_Curve_at_Centerline_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_Conveyor_Infeed_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_Conveyor_Infeed_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10889; TYPE:PF
      Result = me.My_Induction(1).Chosen_Sort_Speed_FPM
      '   END FORMULA; PROP ID:10889; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Speed_Conveyor_Infeed_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_Match_Radius_Value_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_Match_Radius_Value_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10895; TYPE:PF
      Dim BTInfeedSpeed = Me.Speed_Conveyor_Infeed_FPM
Dim BTWidth = Me.My_Induction(1).Sorter_Selected_Width_IN
Dim BTInsideRadius = Me.My_Belt_Turn_Data_Row(1).Radius_Inside_Recommended
Dim BTCartonAlignment = Me.Carton_Alignment
Dim BTAvgBoxWidth = Me.Carton_Width_Avg_IN
Dim BTMaxBoxWidth = Me.Carton_Width_Max_IN

Result = If(BTWidth>0,If(BTCartonAlignment="Inside",If(BTAvgBoxWidth>0,BTInsideRadius+(BTAvgBoxWidth/2),"Enter Average Carton Width"),If(BTCartonAlignment="Outside",BTInsideRadius+BTWidth-(BTMaxBoxWidth/2),If(XlsOR(BTCartonAlignment="Random",BTCartonAlignment="Centered"),BTInsideRadius+(BTWidth/2),0))),0)
      '   END FORMULA; PROP ID:10895; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Speed_Match_Radius_Value_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Adjustment_Factor_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Curve_Centerline_Radius_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Curve_Inside_Radius_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Curve_Width_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Turn_Data_Row_DBKeys_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Alignment_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Length_Allowable_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Length_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Width_Allowable_Max_In_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Width_Avg_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Width_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Matched_Input_Speed_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Radius_Outside_Edge_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Belt_Curve_at_Centerline_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Conveyor_Infeed_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Match_Radius_Value_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Adjustment_Factor_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Curve_Centerline_Radius_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Curve_Inside_Radius_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Curve_Width_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Turn_Data_Row_DBKeys_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Alignment_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Length_Allowable_Max_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Length_Max_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Width_Allowable_Max_In_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Width_Avg_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Width_Max_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Matched_Input_Speed_FPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Radius_Outside_Edge_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Belt_Curve_at_Centerline_FPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Conveyor_Infeed_FPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Match_Radius_Value_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Turn_Data_Row_DBKeys_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Belt_Turn_Data_Row_DBKeys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10874; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_APC_Belt_Turn_Turn_Data]", "[PK_ID]", "[PK_ID]", " ORDER BY [Speed_Conveyor_Infeed_FPM]")
      '   END FORMULA; PROP ID:10874; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Belt_Turn_Data_Row_DBKeys_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Alignment_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Alignment").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10888; TYPE:VV
      Result = MakeValidValues(Array("Centered", "Inside","Outside","Random"))
      '   END FORMULA; PROP ID:10888; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Carton_Alignment_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Turn_Data_Rows_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:291; TYPE:PN
      
      '   END FORMULA; SUB ID:291; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Belt_Turn_Data_Rows_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Turn_Data_Rows_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Belt_Turn_Data_Rows").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:291; TYPE:QF
      Result = Me.Belt_Turn_Data_Row_DBKeys
      '   END FORMULA; SUB ID:291; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Belt_Turn_Data_Rows_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Turn_Data_Rows_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Belt_Turn_Data_Rows").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:291; TYPE:OP
      result = "CAE_APC_Belt_Turn_Data_Row"
      '   END FORMULA; SUB ID:291; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Belt_Turn.Formula_Belt_Turn_Data_Rows_OPTIMALPARTFAMILY", ex.Message)
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

  