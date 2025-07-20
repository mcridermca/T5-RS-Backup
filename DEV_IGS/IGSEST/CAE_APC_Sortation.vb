Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_APC_Sortation
'$ GenerateDate: 07/20/2025 22:09:35

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

    Public Class [CAE_APC_Sortation]
    
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

    Private this as CAE_APC_Sortation = me

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
    
          Public Property [Decouple_Merge_From_Sorter]() As Boolean
      Get
      Return Properties("Decouple_Merge_From_Sorter").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Decouple_Merge_From_Sorter").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Length_Max_IN]() As Double
      Get
      Return Properties("BoxSize_Length_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Length_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Length_Max_MM]() As Double
      Get
      Return Properties("BoxSize_Length_Max_MM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Length_Max_MM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Length_Max_User]() As Double
      Get
      Return Properties("BoxSize_Length_Max_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Length_Max_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Length_Max_User_UOM]() As String
      Get
      Return Properties("BoxSize_Length_Max_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("BoxSize_Length_Max_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Length_Min_IN]() As Double
      Get
      Return Properties("BoxSize_Length_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Length_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Length_Min_MM]() As Double
      Get
      Return Properties("BoxSize_Length_Min_MM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Length_Min_MM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Length_Min_User]() As Double
      Get
      Return Properties("BoxSize_Length_Min_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Length_Min_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Length_Min_User_UOM]() As String
      Get
      Return Properties("BoxSize_Length_Min_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("BoxSize_Length_Min_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Weight_Max_LBS]() As Double
      Get
      Return Properties("BoxSize_Weight_Max_LBS").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Weight_Max_LBS").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Weight_Max_User]() As Double
      Get
      Return Properties("BoxSize_Weight_Max_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Weight_Max_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Weight_Max_User_UOM]() As String
      Get
      Return Properties("BoxSize_Weight_Max_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("BoxSize_Weight_Max_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Weight_Min_LBS]() As Double
      Get
      Return Properties("BoxSize_Weight_Min_LBS").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Weight_Min_LBS").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Weight_Min_User]() As Double
      Get
      Return Properties("BoxSize_Weight_Min_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Weight_Min_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Weight_Min_User_UOM]() As String
      Get
      Return Properties("BoxSize_Weight_Min_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("BoxSize_Weight_Min_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Width_Max_IN]() As Double
      Get
      Return Properties("BoxSize_Width_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Width_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Width_Max_MM]() As Double
      Get
      Return Properties("BoxSize_Width_Max_MM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Width_Max_MM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Width_Max_User]() As Double
      Get
      Return Properties("BoxSize_Width_Max_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Width_Max_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Width_Max_User_UOM]() As String
      Get
      Return Properties("BoxSize_Width_Max_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("BoxSize_Width_Max_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Width_Min_IN]() As Double
      Get
      Return Properties("BoxSize_Width_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Width_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Width_Min_MM]() As Double
      Get
      Return Properties("BoxSize_Width_Min_MM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Width_Min_MM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Width_Min_User]() As Double
      Get
      Return Properties("BoxSize_Width_Min_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Width_Min_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Width_Min_User_UOM]() As String
      Get
      Return Properties("BoxSize_Width_Min_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("BoxSize_Width_Min_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Check_Width]() As Boolean
      Get
      Return Properties("Check_Width").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Check_Width").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Chosen_Sort_Speed_FPM]() As Double
      Get
      Return Properties("Chosen_Sort_Speed_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Chosen_Sort_Speed_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Chosen_Sort_Speed_User]() As Double
      Get
      Return Properties("Chosen_Sort_Speed_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Chosen_Sort_Speed_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Chosen_Sort_Speed_User_UOM]() As String
      Get
      Return Properties("Chosen_Sort_Speed_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Chosen_Sort_Speed_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Chosen_Sorter_Divert_Angle]() As Double
      Get
      Return Properties("Chosen_Sorter_Divert_Angle").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Chosen_Sorter_Divert_Angle").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Chosen_Sorter_Divert_Angle_Radians]() As Double
      Get
      Return Properties("Chosen_Sorter_Divert_Angle_Radians").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Chosen_Sorter_Divert_Angle_Radians").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Chosen_Sorter_ID]() As Long
      Get
      Return Properties("Chosen_Sorter_ID").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Chosen_Sorter_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gap_Control_Method]() As String
      Get
      Return Properties("Gap_Control_Method").Value
      End Get
      Set(ByVal Value As String)
      Properties("Gap_Control_Method").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gap_Design]() As Double
      Get
      Return Properties("Gap_Design").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_Design").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gap_Reqd_Box_Width_Min_IN]() As Double
      Get
      Return Properties("Gap_Reqd_Box_Width_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_Reqd_Box_Width_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gap_Tolerance]() As String
      Get
      Return Properties("Gap_Tolerance").Value
      End Get
      Set(ByVal Value As String)
      Properties("Gap_Tolerance").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sorter_Candidates_dbKeys]() As Long
      Get
      Return Properties("Sorter_Candidates_dbKeys").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Sorter_Candidates_dbKeys").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sorter_Selected_Width_IN]() As Double
      Get
      Return Properties("Sorter_Selected_Width_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sorter_Selected_Width_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_After_Sort_Recd_Calc1]() As Double
      Get
      Return Properties("Speed_After_Sort_Recd_Calc1").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Speed_After_Sort_Recd_Calc1").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_After_Sort_Recd_FPM]() As Double
      Get
      Return Properties("Speed_After_Sort_Recd_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Speed_After_Sort_Recd_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_Induct_Theoretic_Ratio_Min]() As Double
      Get
      Return Properties("Speed_Induct_Theoretic_Ratio_Min").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Speed_Induct_Theoretic_Ratio_Min").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_Intellisort_Closest_Std_FPM]() As Double
      Get
      Return Properties("Speed_Intellisort_Closest_Std_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Speed_Intellisort_Closest_Std_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_Sorter_Reccomended_Min_FPM]() As Double
      Get
      Return Properties("Speed_Sorter_Reccomended_Min_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Speed_Sorter_Reccomended_Min_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_Sorter_Theoretic_Min_FPM]() As Double
      Get
      Return Properties("Speed_Sorter_Theoretic_Min_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Speed_Sorter_Theoretic_Min_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Spur_After_Sort_Drop_Reqd_Min_IN]() As Double
      Get
      Return Properties("Spur_After_Sort_Drop_Reqd_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Spur_After_Sort_Drop_Reqd_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Spur_After_Sort_Exit_Dist_IN]() As Double
      Get
      Return Properties("Spur_After_Sort_Exit_Dist_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Spur_After_Sort_Exit_Dist_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Spur_After_Sort_Exit_Dist_User]() As Double
      Get
      Return Properties("Spur_After_Sort_Exit_Dist_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Spur_After_Sort_Exit_Dist_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Spur_After_Sort_Exit_Dist_User_UOM]() As String
      Get
      Return Properties("Spur_After_Sort_Exit_Dist_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Spur_After_Sort_Exit_Dist_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Spur_After_Sort_Orientation]() As String
      Get
      Return Properties("Spur_After_Sort_Orientation").Value
      End Get
      Set(ByVal Value As String)
      Properties("Spur_After_Sort_Orientation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Spur_After_Sort_Reqd_Slope_Min]() As String
      Get
      Return Properties("Spur_After_Sort_Reqd_Slope_Min").Value
      End Get
      Set(ByVal Value As String)
      Properties("Spur_After_Sort_Reqd_Slope_Min").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Spur_After_Sort_Type]() As String
      Get
      Return Properties("Spur_After_Sort_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Spur_After_Sort_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [User_UOM_System]() As String
      Get
      Return Properties("User_UOM_System").Value
      End Get
      Set(ByVal Value As String)
      Properties("User_UOM_System").CalculatedValue = Value
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
    
      Public ReadOnly Property [Selected_Sorter]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Selected_Sorter")
      End Get
      End Property
    
      Public ReadOnly Property [Sorter_Candidates]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Sorter_Candidates")
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
    
      Public ReadOnly Property [Valid_Sorter_Candidates]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Valid_Sorter_Candidates")
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
    InitPart("CAE_APC_Sortation", <a><![CDATA[CAE_APC_Sortation]]></a>.Value, 442, "IGSEST",  "N", "N", True, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/20/2025 22:09:26")
    AddProperty("10889", "Decouple_Merge_From_Sorter", <a><![CDATA[Decouple_Merge_From_Sorter]]></a>.Value, "", "Boolean","","File","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 8:33:12 PM")
    AddProperty("10890", "BoxSize_Length_Max_IN", <a><![CDATA[BoxSize Length Max IN]]></a>.Value, "BoxSize Length Max IN", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:41:22 PM")
    AddProperty("10891", "BoxSize_Length_Max_MM", <a><![CDATA[BoxSize Length Max MM]]></a>.Value, "BoxSize Length Max MM", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:56:09 PM")
    AddProperty("10892", "BoxSize_Length_Max_User", <a><![CDATA[BoxSize Length Max User]]></a>.Value, "Todo: Enter Description from Spreadsheet", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:45:33 PM")
    AddProperty("10893", "BoxSize_Length_Max_User_UOM", <a><![CDATA[BoxSize Length Max User UOM]]></a>.Value, "BoxSize Length Max User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:38:04 PM")
    AddProperty("10894", "BoxSize_Length_Min_IN", <a><![CDATA[BoxSize Length Min IN]]></a>.Value, "BoxSize Length Min IN", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:48:28 PM")
    AddProperty("10895", "BoxSize_Length_Min_MM", <a><![CDATA[BoxSize Length Min MM]]></a>.Value, "BoxSize Length Min MM", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:56:32 PM")
    AddProperty("10896", "BoxSize_Length_Min_User", <a><![CDATA[BoxSize Length Min User]]></a>.Value, "Allowable input range is 4 inches (101.6 mm) to defined ""Average Length"" in inches. Minimum lengths less than 6 inches (152.4 mm) must be conveyed on belt or suitable sorters only. Minimum lengths less than 9 inch (228.6 mm) require roller conveyors with 2 inch (50.8 mm) roller centers.", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:58:43 PM")
    AddProperty("10897", "BoxSize_Length_Min_User_UOM", <a><![CDATA[BoxSize Length Min User UOM]]></a>.Value, "BoxSize Length Min User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:38:04 PM")
    AddProperty("10898", "BoxSize_Weight_Max_LBS", <a><![CDATA[BoxSize Weight Max LBS]]></a>.Value, "BoxSize Weight Max LBS", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:42:11 PM")
    AddProperty("10899", "BoxSize_Weight_Max_User", <a><![CDATA[BoxSize Weight Max User]]></a>.Value, "Todo: Enter Description from Spreadsheet", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 9:01:45 PM")
    AddProperty("10900", "BoxSize_Weight_Max_User_UOM", <a><![CDATA[BoxSize Weight Max User UOM]]></a>.Value, "BoxSize Weight Max User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:38:04 PM")
    AddProperty("10901", "BoxSize_Weight_Min_LBS", <a><![CDATA[BoxSize Weight Min LBS]]></a>.Value, "BoxSize Weight Min LBS", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:52:11 PM")
    AddProperty("10902", "BoxSize_Weight_Min_User", <a><![CDATA[BoxSize Weight Min User]]></a>.Value, "The allowable input range is 0.5 LBS (0.23 Kg) to the defined Maximum Weight.", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 9:03:01 PM")
    AddProperty("10903", "BoxSize_Weight_Min_User_UOM", <a><![CDATA[BoxSize Weight Min User UOM]]></a>.Value, "BoxSize Weight Min User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:38:04 PM")
    AddProperty("10905", "BoxSize_Width_Max_IN", <a><![CDATA[BoxSize Width Max IN]]></a>.Value, "BoxSize Width Max IN", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:55:25 PM")
    AddProperty("10906", "BoxSize_Width_Max_MM", <a><![CDATA[BoxSize Width Max MM]]></a>.Value, "BoxSize Width Max MM", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:57:54 PM")
    AddProperty("10907", "BoxSize_Width_Max_User", <a><![CDATA[BoxSize Width Max User]]></a>.Value, "Todo: Enter Description from Spreadsheet", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 9:02:55 PM")
    AddProperty("10908", "BoxSize_Width_Max_User_UOM", <a><![CDATA[BoxSize Width Max User UOM]]></a>.Value, "BoxSize Width Max User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:50:10 PM")
    AddProperty("10909", "BoxSize_Width_Min_IN", <a><![CDATA[BoxSize Width Min IN]]></a>.Value, "BoxSize Width Min IN", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/20/2025 9:46:41 PM")
    AddProperty("10910", "BoxSize_Width_Min_MM", <a><![CDATA[BoxSize Width Min MM]]></a>.Value, "BoxSize Width Min MM", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:58:08 PM")
    AddProperty("10911", "BoxSize_Width_Min_User", <a><![CDATA[BoxSize Width Min User]]></a>.Value, "The allowable input range is from 4 inches (101.6 mm) to the defined ""Average Width"".", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 9:02:43 PM")
    AddProperty("10912", "BoxSize_Width_Min_User_UOM", <a><![CDATA[BoxSize Width Min User UOM]]></a>.Value, "BoxSize Width Min User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:50:10 PM")
    AddProperty("10946", "Check_Width", <a><![CDATA[Check_Width]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 9:30:15 PM")
    AddProperty("10879", "Chosen_Sort_Speed_FPM", <a><![CDATA[Chosen_Sort_Speed_FPM]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 8:05:29 PM")
    AddProperty("10880", "Chosen_Sort_Speed_User", <a><![CDATA[Chosen_Sort_Speed_User]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 3:53:41 PM")
    AddProperty("10881", "Chosen_Sort_Speed_User_UOM", <a><![CDATA[Chosen_Sort_Speed_User_UOM]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 4:26:22 PM")
    AddProperty("10936", "Chosen_Sorter_Divert_Angle", <a><![CDATA[Chosen_Sorter_Divert_Angle]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 9:59:32 PM")
    AddProperty("10950", "Chosen_Sorter_Divert_Angle_Radians", <a><![CDATA[Chosen_Sorter_Divert_Angle_Radians]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 9:59:13 PM")
    AddProperty("10884", "Chosen_Sorter_ID", <a><![CDATA[Chosen_Sorter_ID]]></a>.Value, "USer Selected Sorter Model", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 6:42:06 PM")
    AddProperty("10886", "Gap_Control_Method", <a><![CDATA[Gap_Control_Method]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 8:30:00 PM")
    AddProperty("10860", "Gap_Design", <a><![CDATA[Gap_Design]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 1:43:12 PM")
    AddProperty("10947", "Gap_Reqd_Box_Width_Min_IN", <a><![CDATA[Gap_Reqd_Box_Width_Min_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/20/2025 10:09:26 PM")
    AddProperty("10887", "Gap_Tolerance", <a><![CDATA[Gap_Tolerance]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 8:30:48 PM")
    AddProperty("10859", "Sorter_Candidates_dbKeys", <a><![CDATA[Sorter_Candidates_dbKeys]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 3:02:16 PM")
    AddProperty("10821", "Sorter_Selected_Width_IN", <a><![CDATA[Sorter_Selected_Width_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:40:59 PM")
    AddProperty("10934", "Speed_After_Sort_Recd_Calc1", <a><![CDATA[Speed_After_Sort_Recd_Calc1]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 8:26:54 PM")
    AddProperty("10935", "Speed_After_Sort_Recd_FPM", <a><![CDATA[Speed_After_Sort_Recd_FPM]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 7:35:01 PM")
    AddProperty("10941", "Speed_Induct_Theoretic_Ratio_Min", <a><![CDATA[Speed_Induct_Theoretic_Ratio_ Min]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 7:58:17 PM")
    AddProperty("10945", "Speed_Intellisort_Closest_Std_FPM", <a><![CDATA[Speed_Intellisort_Closest_Std_FPM]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 9:34:32 PM")
    AddProperty("10944", "Speed_Sorter_Reccomended_Min_FPM", <a><![CDATA[Speed_Sorter_Reccomended_Min_FPM]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 8:41:31 PM")
    AddProperty("10943", "Speed_Sorter_Theoretic_Min_FPM", <a><![CDATA[Speed_Sorter_Theoretic_Min_FPM]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 8:43:50 PM")
    AddProperty("10932", "Spur_After_Sort_Drop_Reqd_Min_IN", <a><![CDATA[Spur_After_Sort_Drop_Reqd_Min_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 6:01:40 PM")
    AddProperty("10928", "Spur_After_Sort_Exit_Dist_IN", <a><![CDATA[Spur_After_Sort_Exit_Dist_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 5:39:27 PM")
    AddProperty("10929", "Spur_After_Sort_Exit_Dist_User", <a><![CDATA[Spur_After_Sort_Exit_Dist_User]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 5:35:46 PM")
    AddProperty("10930", "Spur_After_Sort_Exit_Dist_User_UOM", <a><![CDATA[Spur_After_Sort_Exit_Dist_User_UOM]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 5:36:55 PM")
    AddProperty("10927", "Spur_After_Sort_Orientation", <a><![CDATA[Spur_After_Sort_Orientation]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 4:00:37 PM")
    AddProperty("10931", "Spur_After_Sort_Reqd_Slope_Min", <a><![CDATA[Spur_After_Sort_Reqd_Slope_Min]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 5:56:17 PM")
    AddProperty("10926", "Spur_After_Sort_Type", <a><![CDATA[Spur_After_Sort_Type]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 3:59:21 PM")
    AddProperty("10904", "User_UOM_System", <a><![CDATA[User UOM System]]></a>.Value, "App Calc Default UOM System", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/19/2025 8:39:53 PM")
    AddProperty("10820", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 12:39:50 PM")
    
      AddValidValue("BoxSize_Length_Max_User_UOM")
    
      AddValidValue("BoxSize_Length_Min_User_UOM")
    
      AddValidValue("BoxSize_Weight_Max_User_UOM")
    
      AddValidValue("BoxSize_Weight_Min_User_UOM")
    
      AddValidValue("BoxSize_Width_Max_User_UOM")
    
      AddValidValue("BoxSize_Width_Min_User_UOM")
    
      AddValidValue("Chosen_Sort_Speed_User_UOM")
    
      AddValidValue("Chosen_Sorter_ID")
    
      AddValidValue("Gap_Control_Method")
    
      AddValidValue("Gap_Tolerance")
    
      AddValidValue("Sorter_Candidates_dbKeys")
    
      AddValidValue("Sorter_Selected_Width_IN")
    
      AddValidValue("Spur_After_Sort_Exit_Dist_User_UOM")
    
      AddValidValue("Spur_After_Sort_Orientation")
    
      AddValidValue("Spur_After_Sort_Type")
    
      AddValidValue("User_UOM_System")
    
      oSubpart = AddSubpart(356,"Selected_Sorter", <a><![CDATA[Selected_Sorter]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "7/19/2025 8:13:19 PM")
      
        oSubpart.AddVPF (443, "CAE_APC_Sorter_App_Details", "CAE_APC_Sorter_App_Details")
      
      oSubpart = AddSubpart(355,"Sorter_Candidates", <a><![CDATA[Sorter_Candidates]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "7/19/2025 1:16:44 PM")
      
        oSubpart.AddVPF (443, "CAE_APC_Sorter_App_Details", "CAE_APC_Sorter_App_Details")
      
      oConnection = AddConnection("My_PRD", <a><![CDATA[My PRD]]></a>.Value, "", "216", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/19/2025 2:42:40 PM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      
      oConnection = AddConnection("My_Setup", <a><![CDATA[My_Setup]]></a>.Value, "My App Calc Setup Object", "217", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/19/2025 2:43:14 PM")
      
        oConnection.AddVPF(119, "APC_Setup")
      
      oConnection = AddConnection("Valid_Sorter_Candidates", <a><![CDATA[Valid_Sorter_Candidates]]></a>.Value, "A Collection of Sorters that are valid for the given application setup / MTBH", "220", "OM", 0, "","General", 9999, "AppCalc Spreadsheet", "GLOBAL\H601424", "7/19/2025 7:57:55 PM")
      
        oConnection.AddVPF(443, "CAE_APC_Sorter_App_Details")
      
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
          InitProperty("Decouple_Merge_From_Sorter", "10443", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:33:12 PM", "", "In Development",  0,19682)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Max_IN", "10444", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:41:22 PM", "BoxSize Length Max IN", "In Development",  0,19704)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Max_MM", "10445", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:56:09 PM", "BoxSize Length Max MM", "In Development",  0,19726)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Max_User", "10446", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:45:33 PM", "Todo: Enter Description from Spreadsheet", "In Development",  0,19707)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Max_User_UOM", "10447", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:38:04 PM", "BoxSize Length Max User UOM", "In Development",  0,19686)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Min_IN", "10448", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:48:28 PM", "BoxSize Length Min IN", "In Development",  0,19710)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Min_MM", "10449", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:56:32 PM", "BoxSize Length Min MM", "In Development",  0,19727)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Min_User", "10450", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:58:43 PM", "Allowable input range is 4 inches (101.6 mm) to defined ""Average Length"" in inches. Minimum lengths less than 6 inches (152.4 mm) must be conveyed on belt or suitable sorters only. Minimum lengths less than 9 inch (228.6 mm) require roller conveyors with 2 inch (50.8 mm) roller centers.", "In Development",  0,19730)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Min_User_UOM", "10451", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:38:04 PM", "BoxSize Length Min User UOM", "In Development",  0,19691)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Max_LBS", "10452", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:42:11 PM", "BoxSize Weight Max LBS", "In Development",  0,19705)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Max_User", "10453", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 9:01:45 PM", "Todo: Enter Description from Spreadsheet", "In Development",  0,19735)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Max_User_UOM", "10454", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:38:04 PM", "BoxSize Weight Max User UOM", "In Development",  0,19695)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Min_LBS", "10455", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:52:11 PM", "BoxSize Weight Min LBS", "In Development",  0,19724)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Min_User", "10456", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 9:03:01 PM", "The allowable input range is 0.5 LBS (0.23 Kg) to the defined Maximum Weight.", "In Development",  0,19734)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Min_User_UOM", "10457", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:38:04 PM", "BoxSize Weight Min User UOM", "In Development",  0,19699)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Max_IN", "10459", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:55:25 PM", "BoxSize Width Max IN", "In Development",  0,19725)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Max_MM", "10460", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:57:54 PM", "BoxSize Width Max MM", "In Development",  0,19728)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Max_User", "10461", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 9:02:55 PM", "Todo: Enter Description from Spreadsheet", "In Development",  0,19733)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Max_User_UOM", "10462", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:50:10 PM", "BoxSize Width Max User UOM", "In Development",  0,19714)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Min_IN", "10463", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 9:46:41 PM", "BoxSize Width Min IN", "In Development",  0,20122)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Min_MM", "10464", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:58:08 PM", "BoxSize Width Min MM", "In Development",  0,19729)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Min_User", "10465", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 9:02:43 PM", "The allowable input range is from 4 inches (101.6 mm) to the defined ""Average Width"".", "In Development",  0,19736)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Min_User_UOM", "10466", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:50:10 PM", "BoxSize Width Min User UOM", "In Development",  0,19719)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Check_Width", "10499", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 9:30:15 PM", "", "In Development",  0,20120)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Chosen_Sort_Speed_FPM", "10433", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 4:33:15 PM", "", "In Development",  0,19552)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Chosen_Sort_Speed_User", "10434", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 3:53:41 PM", "", "In Development",  0,19539)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Chosen_Sort_Speed_User_UOM", "10435", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/19/2025 4:02:50 PM", "", "In Development",  0,19544)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Chosen_Sorter_Divert_Angle", "10489", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 9:59:32 PM", "", "In Development",  0,20132)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Chosen_Sorter_Divert_Angle_Radians", "10503", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 9:59:13 PM", "", "In Development",  0,20131)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Chosen_Sorter_ID", "10438", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/20/2025 6:42:06 PM", "", "In Development",  0,19667)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Control_Method", "10440", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:29:52 PM", "", "In Development",  0,19674)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Design", "10416", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 1:43:02 PM", "", "In Development",  0,19486)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Reqd_Box_Width_Min_IN", "10500", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 10:09:26 PM", "BoxSize Width Max IN", "In Development",  0,20139)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Tolerance", "10441", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:30:48 PM", "", "In Development",  0,19677)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sorter_Candidates_dbKeys", "10415", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/19/2025 3:02:16 PM", "", "In Development",  0,19465)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sorter_Selected_Width_IN", "10379", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/19/2025 12:40:59 PM", "", "In Development",  0,19417)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_After_Sort_Recd_Calc1", "10487", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 8:26:54 PM", "", "In Development",  0,20105)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_After_Sort_Recd_FPM", "10488", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 7:35:01 PM", "", "In Development",  0,20087)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_Induct_Theoretic_Ratio_Min", "10494", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 7:58:17 PM", "", "In Development",  0,20102)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_Intellisort_Closest_Std_FPM", "10498", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 9:34:32 PM", "", "In Development",  0,20121)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_Sorter_Reccomended_Min_FPM", "10497", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 8:41:28 PM", "", "In Development",  0,20111)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_Sorter_Theoretic_Min_FPM", "10496", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 8:43:50 PM", "", "In Development",  0,20112)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Spur_After_Sort_Drop_Reqd_Min_IN", "10485", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 6:01:36 PM", "", "In Development",  0,20069)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Spur_After_Sort_Exit_Dist_IN", "10481", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 5:38:39 PM", "", "In Development",  0,20062)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Spur_After_Sort_Exit_Dist_User", "10482", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 5:35:46 PM", "", "In Development",  0,20056)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Spur_After_Sort_Exit_Dist_User_UOM", "10483", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/20/2025 5:36:55 PM", "", "In Development",  0,20059)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Spur_After_Sort_Orientation", "10480", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/20/2025 4:00:28 PM", "", "In Development",  0,20050)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Spur_After_Sort_Reqd_Slope_Min", "10484", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 5:56:17 PM", "", "In Development",  0,20067)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Spur_After_Sort_Type", "10479", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/20/2025 3:59:21 PM", "", "In Development",  0,20048)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("User_UOM_System", "10458", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:39:53 PM", "Default UOM System", "In Development",  0,19703)
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
          
        InitValidValue("BoxSize_Length_Max_User_UOM_ValidValues", "10447", "-1", 19687)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Length_Min_User_UOM_ValidValues", "10451", "-1", 19692)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Weight_Max_User_UOM_ValidValues", "10454", "-1", 19696)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Weight_Min_User_UOM_ValidValues", "10457", "-1", 19700)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Width_Max_User_UOM_ValidValues", "10462", "-1", 19715)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Width_Min_User_UOM_ValidValues", "10466", "-1", 19720)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Chosen_Sort_Speed_User_UOM_ValidValues", "10435", "-1", 19542)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Chosen_Sorter_ID_ValidValues", "10438", "-1", 20081)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Gap_Control_Method_ValidValues", "10440", "-1", 19676)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Gap_Tolerance_ValidValues", "10441", "-1", 19679)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Sorter_Candidates_dbKeys_ValidValues", "10415", "-1", 19520)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Sorter_Selected_Width_IN_ValidValues", "10379", "-1", 19418)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Spur_After_Sort_Exit_Dist_User_UOM_ValidValues", "10483", "-1", 20060)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Spur_After_Sort_Orientation_ValidValues", "10480", "-1", 20052)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Spur_After_Sort_Type_ValidValues", "10479", "-1", 20049)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("User_UOM_System_ValidValues", "10458", "-1", 19702)
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
          
        InitSubpart("Selected_Sorter", 283, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "7/19/2025 8:13:19 PM", "", "In Development", "N",0,786,785)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Sorter_Candidates", 282, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "7/19/2025 1:16:44 PM", "", "In Development", "N",0,782,783)
        
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
          
        InitConnection("My_PRD", "195", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/19/2025 2:42:40 PM", "", "In Development", "N",349)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Setup", "196", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/19/2025 2:43:14 PM", "", "In Development", "N",350)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Valid_Sorter_Candidates", "199", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/19/2025 7:57:55 PM", "", "In Development", "N",355)
        
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
      Public Function Formula_My_PRD_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:195; TYPE:PF
        Result = Me.Parent.My_Prd(1)
        '   END FORMULA; CON ID:195; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_My_PRD_PARTS", ex.Message)
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
        '   BEGIN FORMULA; CON ID:196; TYPE:PF
        Result = Me.Parent.My_Setup(1)
        '   END FORMULA; CON ID:196; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_My_Setup_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Valid_Sorter_Candidates_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:199; TYPE:PF
        Result = New rscollection()
For Each p As part In Me.Sorter_Candidates
	If p.properties("Faults_Total").value = 0 Then
		Result.add(p)
	End If
Next p
        '   END FORMULA; CON ID:199; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Valid_Sorter_Candidates_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Decouple_Merge_From_Sorter() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Decouple_Merge_From_Sorter").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10443; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:10443; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Decouple_Merge_From_Sorter", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Length_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Length_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10444; TYPE:PF
      Result = Me.Selected_Sorter(1).Length_Max_IN
      '   END FORMULA; PROP ID:10444; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Length_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Length_Max_MM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Length_Max_MM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10445; TYPE:PF
      Result = Units.Convert(Me.BoxSize_Length_Max_IN, "IN","MM")
      '   END FORMULA; PROP ID:10445; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Length_Max_MM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Length_Max_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Length_Max_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10446; TYPE:PF
      Result = Custom.Units.Convert(Me.BoxSize_Length_Max_IN, "IN", Me.BoxSize_Length_Max_User_UOM)
      '   END FORMULA; PROP ID:10446; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Length_Max_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Length_Max_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Length_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10447; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:10447; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Length_Max_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Length_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Length_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10448; TYPE:PF
      Result = Me.Selected_Sorter(1).Length_Min_IN
      '   END FORMULA; PROP ID:10448; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Length_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Length_Min_MM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Length_Min_MM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10449; TYPE:PF
      Result = Units.Convert(Me.BoxSize_Length_Min_IN, "IN","MM")
      '   END FORMULA; PROP ID:10449; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Length_Min_MM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Length_Min_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Length_Min_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10450; TYPE:PF
      Result = Custom.Units.Convert(Me.BoxSize_Length_Min_IN, "IN", Me.BoxSize_Length_Min_User_UOM)
      '   END FORMULA; PROP ID:10450; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Length_Min_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Length_Min_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Length_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10451; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:10451; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Length_Min_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Weight_Max_LBS() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Weight_Max_LBS").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10452; TYPE:PF
      Result = Me.Selected_Sorter(1).Weight_Max_LBS
      '   END FORMULA; PROP ID:10452; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Weight_Max_LBS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Weight_Max_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Weight_Max_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10453; TYPE:PF
      Result = Custom.Units.Convert(Me.BoxSize_Weight_Max_LBS, "LBS", Me.BoxSize_Weight_Max_User_UOM)
      '   END FORMULA; PROP ID:10453; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Weight_Max_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Weight_Max_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Weight_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10454; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "lbs" Else Result = "kg"
      '   END FORMULA; PROP ID:10454; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Weight_Max_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Weight_Min_LBS() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Weight_Min_LBS").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10455; TYPE:PF
      Result = Me.Selected_Sorter(1).Weight_Min_LBS
      '   END FORMULA; PROP ID:10455; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Weight_Min_LBS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Weight_Min_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Weight_Min_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10456; TYPE:PF
      Result = Custom.Units.Convert(Me.BoxSize_Weight_Min_LBS, "LBS", Me.BoxSize_Weight_Min_User_UOM)
      '   END FORMULA; PROP ID:10456; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Weight_Min_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Weight_Min_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Weight_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10457; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "LBS" Else Result = "KG"
      '   END FORMULA; PROP ID:10457; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Weight_Min_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Width_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Width_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10459; TYPE:PF
      Result = Me.Selected_Sorter(1).Width_Max_IN
      '   END FORMULA; PROP ID:10459; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Width_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Width_Max_MM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Width_Max_MM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10460; TYPE:PF
      Result = Units.Convert(Me.BoxSize_Width_Max_IN, "IN","MM")
      '   END FORMULA; PROP ID:10460; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Width_Max_MM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Width_Max_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Width_Max_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10461; TYPE:PF
      Result = Custom.Units.Convert(Me.BoxSize_Width_Max_IN, "IN", Me.BoxSize_Width_Max_User_UOM)
      '   END FORMULA; PROP ID:10461; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Width_Max_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Width_Max_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Width_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10462; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:10462; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Width_Max_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Width_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Width_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10463; TYPE:PF
      Result = Me.Selected_Sorter(1).Width_Min_IN
      '   END FORMULA; PROP ID:10463; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Width_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Width_Min_MM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Width_Min_MM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10464; TYPE:PF
      Result = Units.Convert(Me.BoxSize_Width_Min_IN, "IN","MM")
      '   END FORMULA; PROP ID:10464; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Width_Min_MM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Width_Min_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Width_Min_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10465; TYPE:PF
      Result = Custom.Units.Convert(Me.BoxSize_Width_Min_IN, "IN", Me.BoxSize_Width_Min_User_UOM)
      '   END FORMULA; PROP ID:10465; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Width_Min_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Width_Min_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Width_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10466; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:10466; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Width_Min_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Check_Width() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Check_Width").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10499; TYPE:PF
      Result = False
If Me.Selected_Sorter.Quantity > 0 Then
		Result  = Me.Selected_Sorter(1).Check_Width 
End If
      '   END FORMULA; PROP ID:10499; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Check_Width", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Chosen_Sort_Speed_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Chosen_Sort_Speed_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10433; TYPE:PF
      Result = Units.Convert(Me.Chosen_Sort_Speed_User, Me.Chosen_Sort_Speed_User_UOM, "ft/min")
      '   END FORMULA; PROP ID:10433; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Chosen_Sort_Speed_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Chosen_Sort_Speed_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Chosen_Sort_Speed_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10434; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10434; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Chosen_Sort_Speed_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Chosen_Sort_Speed_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Chosen_Sort_Speed_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10435; TYPE:PF
      Result = "ft/min"
If Me.My_Setup(1).User_UOM_System = "Metric" Then
	Result = "m/sec"
End If
      '   END FORMULA; PROP ID:10435; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Chosen_Sort_Speed_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Chosen_Sorter_Divert_Angle() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Chosen_Sorter_Divert_Angle").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10489; TYPE:PF
      Result =  Me.Selected_Sorter(1).Divert_Angle
      '   END FORMULA; PROP ID:10489; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Chosen_Sorter_Divert_Angle", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Chosen_Sorter_Divert_Angle_Radians() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Chosen_Sorter_Divert_Angle_Radians").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10503; TYPE:PF
      Result =  Me.Chosen_Sorter_Divert_Angle  * (PI / 180)
      '   END FORMULA; PROP ID:10503; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Chosen_Sorter_Divert_Angle_Radians", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Chosen_Sorter_ID() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Chosen_Sorter_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10438; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:10438; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Chosen_Sorter_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gap_Control_Method() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Control_Method").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10440; TYPE:PF
      Result = "Please Select"
      '   END FORMULA; PROP ID:10440; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gap_Control_Method", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gap_Design() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Design").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10416; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10416; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gap_Design", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gap_Reqd_Box_Width_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Reqd_Box_Width_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10500; TYPE:PF
      'R66 :ogic  =IF(SorterType<>"",IF((VLOOKUP(SorterType,'Lists-1'!$D$4:$P$20,13,FALSE)="Y"),"Yes","No"),"No")
'IE Me. Check_Width

'R67 = =IF(R66="Yes",BoxSize_Width_Max_IN*SIN(RADIANS($H$36)),"")
'R68 = =IF(R66="Yes",BoxSize_Width_Avg_IN*SIN(RADIANS($H$36)),"")
Dim R67 = If(Me.Check_Width,Me.My_Setup(1).BoxSize_Width_Max_IN * SIN(Me.Chosen_Sorter_Divert_Angle_Radians),0)
Dim R68 = If(Me.Check_Width,Me.My_Setup(1).BoxSize_Width_Avg_IN * SIN(Me.Chosen_Sorter_Divert_Angle_Radians),0)
'Stop

'=If(R66="Yes",If(BoxSize_Width_Avg_IN>20,R67,R68),"")
Result = If(Me.Check_Width,If(Me.My_Setup(1).BoxSize_Width_Avg_IN>20,R67,R68),0)
      '   END FORMULA; PROP ID:10500; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gap_Reqd_Box_Width_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gap_Tolerance() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Tolerance").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10441; TYPE:PF
      Result = "Please Select"
      '   END FORMULA; PROP ID:10441; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gap_Tolerance", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sorter_Candidates_dbKeys() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sorter_Candidates_dbKeys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10415; TYPE:PF
      Result = Me.ValidValues("Sorter_Candidates_dbKeys").Count
      '   END FORMULA; PROP ID:10415; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Sorter_Candidates_dbKeys", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sorter_Selected_Width_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sorter_Selected_Width_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10379; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10379; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Sorter_Selected_Width_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_After_Sort_Recd_Calc1() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_After_Sort_Recd_Calc1").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10487; TYPE:PF
      '=IF(AND(H53="Powered",ChosenDivertAngle<>90),IF(H54="Horizontal",ROUND(ChosenSortSpeed/COS(RADIANS(ChosenDivertAngle)),0),ROUND(ChosenSortSpeed/COS(RADIANS(ChosenDivertAngle)),0)*0.8),"") 

Dim DivertAngleAsRadians As Double  = Me.Chosen_Sorter_Divert_Angle * (PI / 180)

'=       IF(   AND(H53=                           "Powered",                 ChosenDivertAngle<>90),IF(                           H54="Horizontal",ROUND(         ChosenSortSpeed/COS(RADIANS(ChosenDivertAngle)),0),ROUND(ChosenSortSpeed/         COS(RADIANS(ChosenDivertAngle)),0)*0.8),"") 
Result = If(XlsAnd(Me.Spur_After_Sort_Type="Powered",Me.Selected_Sorter(1).Divert_Angle<>90),If(Me.Spur_After_Sort_Orientation="Horizontal",ROUND(Me.Chosen_Sort_Speed_FPM/COS(DivertAngleAsRadians      ),0),ROUND(Me.Chosen_Sort_Speed_FPM/COS(DivertAngleAsRadians)      ,0)*0.8),0)
      '   END FORMULA; PROP ID:10487; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Speed_After_Sort_Recd_Calc1", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_After_Sort_Recd_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_After_Sort_Recd_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10488; TYPE:PF
      '=IF(AND(H53="Powered",ChosenDivertAngle<>90),VLOOKUP(R58,R131:S145,2,TRUE),"")

'From Sortation Table R131:S145

Dim VBSpeed As Double = 0
If Me.Speed_After_Sort_Recd_Calc1 <= 650 Then VBSpeed = 650
If Me.Speed_After_Sort_Recd_Calc1 <= 600 Then VBSpeed = 600
If Me.Speed_After_Sort_Recd_Calc1 <= 550 Then VBSpeed = 550
If Me.Speed_After_Sort_Recd_Calc1 <= 500 Then VBSpeed = 500
If Me.Speed_After_Sort_Recd_Calc1 <= 450 Then VBSpeed = 450
If Me.Speed_After_Sort_Recd_Calc1 <= 400 Then VBSpeed = 400
If Me.Speed_After_Sort_Recd_Calc1 <= 350 Then VBSpeed = 350
If Me.Speed_After_Sort_Recd_Calc1 <= 300 Then VBSpeed = 300
If Me.Speed_After_Sort_Recd_Calc1 <= 270 Then VBSpeed = 270
If Me.Speed_After_Sort_Recd_Calc1 <= 240 Then VBSpeed = 240
If Me.Speed_After_Sort_Recd_Calc1 <= 210 Then VBSpeed = 210
If Me.Speed_After_Sort_Recd_Calc1 <= 180 Then VBSpeed = 180
If Me.Speed_After_Sort_Recd_Calc1 <= 150 Then VBSpeed = 150
If Me.Speed_After_Sort_Recd_Calc1 <= 120 Then VBSpeed = 120
If Me.Speed_After_Sort_Recd_Calc1 <= 090 Then VBSpeed = 90


Result = If(XlsAnd(Me.Spur_After_Sort_Type="Powered",Me.Selected_Sorter(1).Divert_Angle<>90),VBSpeed,0)
      '   END FORMULA; PROP ID:10488; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Speed_After_Sort_Recd_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_Induct_Theoretic_Ratio_Min() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_Induct_Theoretic_Ratio_Min").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10494; TYPE:PF
      '=IF(GapControlMethod="Passive",(BoxSize_Length_Min_IN+DesignGap)/BoxSize_Length_Min_IN,(BoxSize_Length_Max_IN+DesignGap)/BoxSize_Length_Max_IN)

Result = If(Me.Gap_Control_Method="Passive",(Me.My_Setup(1).BoxSize_Length_Min_IN+Me.Gap_Design) / Me.My_Setup(1).BoxSize_Length_Min_IN,(Me.My_Setup(1).BoxSize_Length_Max_IN + Me.Gap_Design)/Me.My_Setup(1).BoxSize_Length_Max_IN)
      '   END FORMULA; PROP ID:10494; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Speed_Induct_Theoretic_Ratio_Min", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_Intellisort_Closest_Std_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_Intellisort_Closest_Std_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10498; TYPE:PF
      ' =If(Or(R66="Yes",SorterType="HDS, Dual Sided, 20°"),If(H63>650,"*",HLOOKUP(H63,R108:Z109,2)),"**")

'=If(SorterType<>"",If((VLOOKUP(SorterType,'Lists-1'!$D$4:$P$20,13,FALSE)="Y"),"Yes","No"),"No")

If Me.Selected_Sorter.Quantity > 0 Then

		'=If(XlsOR(Check_Width", Me.Selected_Sorter(1)="HDS, Dual Sided, 20°"),If(me.Speed_Sorter_Theoretic_Min_FPM > 650,"-1",HLOOKUP(H63,R108:Z109,2)),"**")
		'0.00	250.00	300.00	350.00	400.00	450.00	500.00	550.00	600.00
		'250.00	300.00	350.00	400.00	450.00	500.00	550.00	600.00	650.00

	If Me.Check_Width = True  Or Me.Selected_Sorter(1).Model="HDS, Dual Sided, 20°" Then
		If Me.Speed_Sorter_Theoretic_Min_FPM > 650 Then
			Result = 0
		Else
			'Use the Table above
			If Me.Speed_Sorter_Theoretic_Min_FPM > 0 And Me.Speed_Sorter_Theoretic_Min_FPM <=650 Then Result = 650
			If Me.Speed_Sorter_Theoretic_Min_FPM > 0 And Me.Speed_Sorter_Theoretic_Min_FPM < 600 Then Result = 600
			If Me.Speed_Sorter_Theoretic_Min_FPM > 0 And Me.Speed_Sorter_Theoretic_Min_FPM < 550 Then Result = 550
			If Me.Speed_Sorter_Theoretic_Min_FPM > 0 And Me.Speed_Sorter_Theoretic_Min_FPM < 500 Then Result = 500
			If Me.Speed_Sorter_Theoretic_Min_FPM > 0 And Me.Speed_Sorter_Theoretic_Min_FPM < 450 Then Result = 450
			If Me.Speed_Sorter_Theoretic_Min_FPM > 0 And Me.Speed_Sorter_Theoretic_Min_FPM < 400 Then Result = 400
			If Me.Speed_Sorter_Theoretic_Min_FPM > 0 And Me.Speed_Sorter_Theoretic_Min_FPM < 350 Then Result = 350
			If Me.Speed_Sorter_Theoretic_Min_FPM > 0 And Me.Speed_Sorter_Theoretic_Min_FPM < 300 Then Result = 300
			If Me.Speed_Sorter_Theoretic_Min_FPM > 0 And Me.Speed_Sorter_Theoretic_Min_FPM <=250 Then Result = 250
			
		End If
	Else
		Result = 0
	End If
		
End If
      '   END FORMULA; PROP ID:10498; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Speed_Intellisort_Closest_Std_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_Sorter_Reccomended_Min_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_Sorter_Reccomended_Min_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10497; TYPE:PF
      '=IF(H50="Passive",MIN(H62*1.1,MaxSortSpeed),MIN(H62*1.07,MaxSortSpeed))

Result = If(Me.Gap_Control_Method="Passive",MIN(Me.Speed_Sorter_Theoretic_Min_FPM*1.1,Me.Selected_Sorter(1).Speed_Max_RPM),MIN(Me.Speed_Sorter_Theoretic_Min_FPM*1.07,Me.Selected_Sorter(1).Speed_Max_RPM))
      '   END FORMULA; PROP ID:10497; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Speed_Sorter_Reccomended_Min_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_Sorter_Theoretic_Min_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_Sorter_Theoretic_Min_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10496; TYPE:PF
      '=IF(H50="Active",((BoxSize_Length_Avg+DesignGap)/12)*Sort_Rate_Required_CPM,((BoxSize_Length_Min_IN+DesignGap)/BoxSize_Length_Min_IN)*Case_Length_Per_Ft_Minute_Target)

'=IF(                         H50="Active",((              BoxSize_Length_Avg  +     DesignGap)/12)*                 Sort_Rate_Required_CPM, ((               BoxSize_Length_Min_IN +     DesignGap) /                BoxSize_Length_Min_IN) *                Case_Length_Per_Ft_Minute_Target)
Result = If(Me.Gap_Control_Method="Active",((Me.My_Setup(1).BoxSize_Length_Avg + Me.Gap_Design)/12) * Me.My_Setup(1).Sort_Rate_Required_CPM, ((Me.My_Setup(1).BoxSize_Length_Min_IN + Me.Gap_Design) / Me.My_Setup(1).BoxSize_Length_Min_IN) * Me.My_Setup(1).Case_Length_Per_Minute_Target_FT)
      '   END FORMULA; PROP ID:10496; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Speed_Sorter_Theoretic_Min_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Spur_After_Sort_Drop_Reqd_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Spur_After_Sort_Drop_Reqd_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10485; TYPE:PF
      '=IF(H54="Sloped",IF(H53="Gravity",(H55/12)*1.26,(H55/12)*0.75),"")
Result = If(Me.Spur_After_Sort_Orientation="Sloped",If(Me.Spur_After_Sort_Type="Gravity",(Me.Spur_After_Sort_Exit_Dist_IN/12)*1.26,(Me.Spur_After_Sort_Exit_Dist_IN/12)*0.75),"")
      '   END FORMULA; PROP ID:10485; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Spur_After_Sort_Drop_Reqd_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Spur_After_Sort_Exit_Dist_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Spur_After_Sort_Exit_Dist_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10481; TYPE:PF
      Result =  Units.Convert(Me.Spur_After_Sort_Exit_Dist_User, Me.Spur_After_Sort_Exit_Dist_User_UOM, "IN")
      '   END FORMULA; PROP ID:10481; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Spur_After_Sort_Exit_Dist_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Spur_After_Sort_Exit_Dist_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Spur_After_Sort_Exit_Dist_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10482; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10482; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Spur_After_Sort_Exit_Dist_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Spur_After_Sort_Exit_Dist_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Spur_After_Sort_Exit_Dist_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10483; TYPE:PF
      Result = "IN"
If Me.My_Setup(1).User_UOM_System = "Metric" Then
	Result = "MM"
End If
      '   END FORMULA; PROP ID:10483; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Spur_After_Sort_Exit_Dist_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Spur_After_Sort_Orientation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Spur_After_Sort_Orientation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10480; TYPE:PF
      Result = "Please Select"
      '   END FORMULA; PROP ID:10480; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Spur_After_Sort_Orientation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Spur_After_Sort_Reqd_Slope_Min() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Spur_After_Sort_Reqd_Slope_Min").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10484; TYPE:PF
      '=IF(H54="Sloped",IF(H53="Gravity","1.26 In/FT (6.00 Degrees)","0.75 In/FT (3.58 Degrees)"),"0 In/FT (0 Degrees)")

Result = If(Me.Spur_After_Sort_Orientation="Sloped",If(Me.Spur_After_Sort_Type="Gravity","1.26 In/FT (6.00 Degrees)","0.75 In/FT (3.58 Degrees)"),"0 In/FT (0 Degrees)")
      '   END FORMULA; PROP ID:10484; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Spur_After_Sort_Reqd_Slope_Min", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Spur_After_Sort_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Spur_After_Sort_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10479; TYPE:PF
      Result = "Please Select"
      '   END FORMULA; PROP ID:10479; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Spur_After_Sort_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_User_UOM_System() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("User_UOM_System").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10458; TYPE:PF
      Result = Me.My_Setup(1).User_UOM_System
      '   END FORMULA; PROP ID:10458; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_User_UOM_System", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Decouple_Merge_From_Sorter_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Max_MM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Max_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Max_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Min_MM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Min_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Min_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Max_LBS_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Max_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Max_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Min_LBS_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Min_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Min_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Max_MM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Max_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Max_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Min_MM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Min_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Min_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Check_Width_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sort_Speed_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sort_Speed_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sort_Speed_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sorter_Divert_Angle_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sorter_Divert_Angle_Radians_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sorter_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Control_Method_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Design_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Reqd_Box_Width_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Tolerance_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Candidates_dbKeys_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Selected_Width_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_After_Sort_Recd_Calc1_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_After_Sort_Recd_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Induct_Theoretic_Ratio_Min_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Intellisort_Closest_Std_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Sorter_Reccomended_Min_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Sorter_Theoretic_Min_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Drop_Reqd_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Exit_Dist_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Exit_Dist_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Exit_Dist_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Orientation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Reqd_Slope_Min_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_User_UOM_System_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Decouple_Merge_From_Sorter_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Max_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Max_MM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Max_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Max_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Min_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Min_MM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Min_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Min_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Max_LBS_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Max_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Max_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Min_LBS_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Min_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Min_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Max_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Max_MM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Max_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Max_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Min_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Min_MM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Min_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Min_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Check_Width_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sort_Speed_FPM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sort_Speed_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sort_Speed_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sorter_Divert_Angle_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sorter_Divert_Angle_Radians_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sorter_ID_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Control_Method_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Design_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Reqd_Box_Width_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Tolerance_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Candidates_dbKeys_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Selected_Width_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_After_Sort_Recd_Calc1_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_After_Sort_Recd_FPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Induct_Theoretic_Ratio_Min_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Intellisort_Closest_Std_FPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Sorter_Reccomended_Min_FPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Sorter_Theoretic_Min_FPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Drop_Reqd_Min_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Exit_Dist_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Exit_Dist_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Exit_Dist_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Orientation_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Reqd_Slope_Min_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_User_UOM_System_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Max_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Length_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10447; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:10447; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Length_Max_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Min_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Length_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10451; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:10451; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Length_Min_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Max_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Weight_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10454; TYPE:VV
      Result = MakeValidValues(Array( "LBS", "KG"))
      '   END FORMULA; PROP ID:10454; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Weight_Max_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Min_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Weight_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10457; TYPE:VV
      Result = MakeValidValues(Array( "LBS", "KG"))
      '   END FORMULA; PROP ID:10457; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Weight_Min_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Max_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Width_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10462; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:10462; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Width_Max_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Min_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Width_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10466; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:10466; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_BoxSize_Width_Min_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sort_Speed_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Chosen_Sort_Speed_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10435; TYPE:VV
      Result = MakeValidValues(Array("ft/min", "m/sec"))
      '   END FORMULA; PROP ID:10435; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Chosen_Sort_Speed_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sorter_ID_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Chosen_Sorter_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10438; TYPE:VV
      'Result = MakeValidKeyValues(Array(1, 2), Array("AAA", "BBB"))
'Result.Clear()
Dim inString As String = ""
Dim First As Boolean = True
For Each p As part In Valid_Sorter_Candidates
	If First Then
		 inString = p.properties("pk_id").value
		
	 Else
		 inString = inString + $",{p.properties("pk_id").value}"
	 End If
	  First = False
Next p

Result = MakeValidValueKeyFromDatabase("[vw_CAE_APC_Sorter_Types]", "[PK_ID]", "[Model]", "WHERE [PK_ID] IN (" & instring & ") ORDER BY [Model]")
      '   END FORMULA; PROP ID:10438; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Chosen_Sorter_ID_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Control_Method_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Control_Method").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10440; TYPE:VV
      Result = MakeValidValues(Array("Active", "Passive"))
      '   END FORMULA; PROP ID:10440; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gap_Control_Method_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Tolerance_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Tolerance").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10441; TYPE:VV
      Result = MakeValidValues(Array("Standard", "Small"))
      '   END FORMULA; PROP ID:10441; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gap_Tolerance_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Candidates_dbKeys_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sorter_Candidates_dbKeys").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10415; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[vw_CAE_APC_Sorter_Types]", "[PK_ID]", "[PK_ID]", " ORDER BY [PK_ID]")
      '   END FORMULA; PROP ID:10415; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Sorter_Candidates_dbKeys_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Selected_Width_IN_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sorter_Selected_Width_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10379; TYPE:VV
      Result = MakeValidValues(Array(22, 28, 34, 38))
      '   END FORMULA; PROP ID:10379; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Sorter_Selected_Width_IN_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Exit_Dist_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Spur_After_Sort_Exit_Dist_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10483; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10483; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Spur_After_Sort_Exit_Dist_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Orientation_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Spur_After_Sort_Orientation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10480; TYPE:VV
      Result = MakeValidValues(Array("Horizontal", "Sloped"))
      '   END FORMULA; PROP ID:10480; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Spur_After_Sort_Orientation_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spur_After_Sort_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Spur_After_Sort_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10479; TYPE:VV
      Result = MakeValidValues(Array("Powered", "Gravity"))
      '   END FORMULA; PROP ID:10479; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Spur_After_Sort_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_User_UOM_System_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("User_UOM_System").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10458; TYPE:VV
      Result = MakeValidValues(Array( "Imperial", "Metric"))
      '   END FORMULA; PROP ID:10458; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_User_UOM_System_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selected_Sorter_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:283; TYPE:PN
      
      '   END FORMULA; SUB ID:283; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Selected_Sorter_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selected_Sorter_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Selected_Sorter").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:283; TYPE:QF
      Result = 0
If Chosen_Sorter_ID > 0 Then 
	Result = 1	
End If
      '   END FORMULA; SUB ID:283; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Selected_Sorter_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selected_Sorter_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Selected_Sorter").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:283; TYPE:OP
      result = "CAE_APC_Sorter_App_Details"
      '   END FORMULA; SUB ID:283; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Selected_Sorter_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Candidates_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:282; TYPE:PN
      
      '   END FORMULA; SUB ID:282; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Sorter_Candidates_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Candidates_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Sorter_Candidates").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:282; TYPE:QF
      Result = Me.Sorter_Candidates_dbKeys
      '   END FORMULA; SUB ID:282; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Sorter_Candidates_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Candidates_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Sorter_Candidates").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:282; TYPE:OP
      result = "CAE_APC_Sorter_App_Details"
      '   END FORMULA; SUB ID:282; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Sorter_Candidates_OPTIMALPARTFAMILY", ex.Message)
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

  