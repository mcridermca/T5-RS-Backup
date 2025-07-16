Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_Chutes
'$ GenerateDate: 07/16/2025 13:16:42

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

    Public Class [CAE_Chutes]
    
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

    Private this as CAE_Chutes = me

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
    
          Public Shadows Property [DisplayName]() As String
      Get
      Return Properties("DisplayName").Value
      End Get
      Set(ByVal Value As String)
      Properties("DisplayName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_1_Angle_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_1_Angle_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_1_Angle_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_1_Angle_of_Curve]() As Double
      Get
      Return Properties("MEI_Chutes_Style_1_Angle_of_Curve").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_1_Angle_of_Curve").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_1_Infeed_Conveyor_Type]() As String
      Get
      Return Properties("MEI_Chutes_Style_1_Infeed_Conveyor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_1_Infeed_Conveyor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_1_Infeed_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_1_Infeed_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_1_Infeed_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_1_Length_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_1_Length_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_1_Length_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_1_Length_in_Feet]() As String
      Get
      Return Properties("MEI_Chutes_Style_1_Length_in_Feet").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_1_Length_in_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_1_Material_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_1_Material_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_1_Material_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_1_Merge_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_1_Merge_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_1_Merge_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_1_Number_of_Merging_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_1_Number_of_Merging_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_1_Number_of_Merging_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_1_Number_of_Sorting_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_1_Number_of_Sorting_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_1_Number_of_Sorting_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_1_Sort_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_1_Sort_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_1_Sort_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_1_Total_Hours_per_Chute]() As Double
      Get
      Return Properties("MEI_Chutes_Style_1_Total_Hours_per_Chute").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_1_Total_Hours_per_Chute").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_1_Type_of_Material]() As String
      Get
      Return Properties("MEI_Chutes_Style_1_Type_of_Material").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_1_Type_of_Material").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_10_Angle_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_10_Angle_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_10_Angle_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_10_Angle_of_Curve]() As Double
      Get
      Return Properties("MEI_Chutes_Style_10_Angle_of_Curve").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_10_Angle_of_Curve").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_10_Infeed_Conveyor_Type]() As String
      Get
      Return Properties("MEI_Chutes_Style_10_Infeed_Conveyor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_10_Infeed_Conveyor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_10_Infeed_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_10_Infeed_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_10_Infeed_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_10_Length_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_10_Length_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_10_Length_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_10_Length_in_Feet]() As String
      Get
      Return Properties("MEI_Chutes_Style_10_Length_in_Feet").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_10_Length_in_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_10_Material_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_10_Material_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_10_Material_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_10_Merge_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_10_Merge_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_10_Merge_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_10_Number_of_Merging_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_10_Number_of_Merging_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_10_Number_of_Merging_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_10_Number_of_Sorting_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_10_Number_of_Sorting_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_10_Number_of_Sorting_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_10_Sort_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_10_Sort_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_10_Sort_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_10_Total_Hours_per_Chute]() As Double
      Get
      Return Properties("MEI_Chutes_Style_10_Total_Hours_per_Chute").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_10_Total_Hours_per_Chute").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_10_Type_of_Material]() As String
      Get
      Return Properties("MEI_Chutes_Style_10_Type_of_Material").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_10_Type_of_Material").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_2_Angle_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_2_Angle_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_2_Angle_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_2_Angle_of_Curve]() As Double
      Get
      Return Properties("MEI_Chutes_Style_2_Angle_of_Curve").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_2_Angle_of_Curve").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_2_Infeed_Conveyor_Type]() As String
      Get
      Return Properties("MEI_Chutes_Style_2_Infeed_Conveyor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_2_Infeed_Conveyor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_2_Infeed_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_2_Infeed_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_2_Infeed_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_2_Length_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_2_Length_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_2_Length_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_2_Length_in_Feet]() As String
      Get
      Return Properties("MEI_Chutes_Style_2_Length_in_Feet").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_2_Length_in_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_2_Material_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_2_Material_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_2_Material_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_2_Merge_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_2_Merge_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_2_Merge_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_2_Number_of_Merging_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_2_Number_of_Merging_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_2_Number_of_Merging_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_2_Number_of_Sorting_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_2_Number_of_Sorting_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_2_Number_of_Sorting_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_2_Sort_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_2_Sort_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_2_Sort_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_2_Total_Hours_per_Chute]() As Double
      Get
      Return Properties("MEI_Chutes_Style_2_Total_Hours_per_Chute").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_2_Total_Hours_per_Chute").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_2_Type_of_Material]() As String
      Get
      Return Properties("MEI_Chutes_Style_2_Type_of_Material").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_2_Type_of_Material").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_3_Angle_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_3_Angle_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_3_Angle_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_3_Angle_of_Curve]() As Double
      Get
      Return Properties("MEI_Chutes_Style_3_Angle_of_Curve").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_3_Angle_of_Curve").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_3_Infeed_Conveyor_Type]() As String
      Get
      Return Properties("MEI_Chutes_Style_3_Infeed_Conveyor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_3_Infeed_Conveyor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_3_Infeed_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_3_Infeed_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_3_Infeed_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_3_Length_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_3_Length_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_3_Length_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_3_Length_in_Feet]() As String
      Get
      Return Properties("MEI_Chutes_Style_3_Length_in_Feet").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_3_Length_in_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_3_Material_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_3_Material_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_3_Material_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_3_Merge_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_3_Merge_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_3_Merge_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_3_Number_of_Merging_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_3_Number_of_Merging_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_3_Number_of_Merging_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_3_Number_of_Sorting_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_3_Number_of_Sorting_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_3_Number_of_Sorting_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_3_Sort_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_3_Sort_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_3_Sort_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_3_Total_Hours_per_Chute]() As Double
      Get
      Return Properties("MEI_Chutes_Style_3_Total_Hours_per_Chute").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_3_Total_Hours_per_Chute").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_3_Type_of_Material]() As String
      Get
      Return Properties("MEI_Chutes_Style_3_Type_of_Material").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_3_Type_of_Material").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_4_Angle_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_4_Angle_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_4_Angle_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_4_Angle_of_Curve]() As Double
      Get
      Return Properties("MEI_Chutes_Style_4_Angle_of_Curve").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_4_Angle_of_Curve").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_4_Infeed_Conveyor_Type]() As String
      Get
      Return Properties("MEI_Chutes_Style_4_Infeed_Conveyor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_4_Infeed_Conveyor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_4_Infeed_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_4_Infeed_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_4_Infeed_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_4_Length_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_4_Length_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_4_Length_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_4_Length_in_Feet]() As String
      Get
      Return Properties("MEI_Chutes_Style_4_Length_in_Feet").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_4_Length_in_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_4_Material_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_4_Material_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_4_Material_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_4_Merge_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_4_Merge_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_4_Merge_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_4_Number_of_Merging_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_4_Number_of_Merging_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_4_Number_of_Merging_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_4_Number_of_Sorting_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_4_Number_of_Sorting_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_4_Number_of_Sorting_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_4_Sort_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_4_Sort_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_4_Sort_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_4_Total_Hours_per_Chute]() As Double
      Get
      Return Properties("MEI_Chutes_Style_4_Total_Hours_per_Chute").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_4_Total_Hours_per_Chute").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_4_Type_of_Material]() As String
      Get
      Return Properties("MEI_Chutes_Style_4_Type_of_Material").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_4_Type_of_Material").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_5_Angle_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_5_Angle_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_5_Angle_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_5_Angle_of_Curve]() As Double
      Get
      Return Properties("MEI_Chutes_Style_5_Angle_of_Curve").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_5_Angle_of_Curve").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_5_Infeed_Conveyor_Type]() As String
      Get
      Return Properties("MEI_Chutes_Style_5_Infeed_Conveyor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_5_Infeed_Conveyor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_5_Infeed_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_5_Infeed_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_5_Infeed_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_5_Length_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_5_Length_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_5_Length_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_5_Length_in_Feet]() As String
      Get
      Return Properties("MEI_Chutes_Style_5_Length_in_Feet").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_5_Length_in_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_5_Material_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_5_Material_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_5_Material_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_5_Merge_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_5_Merge_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_5_Merge_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_5_Number_of_Merging_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_5_Number_of_Merging_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_5_Number_of_Merging_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_5_Number_of_Sorting_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_5_Number_of_Sorting_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_5_Number_of_Sorting_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_5_Sort_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_5_Sort_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_5_Sort_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_5_Total_Hours_per_Chute]() As Double
      Get
      Return Properties("MEI_Chutes_Style_5_Total_Hours_per_Chute").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_5_Total_Hours_per_Chute").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_5_Type_of_Material]() As String
      Get
      Return Properties("MEI_Chutes_Style_5_Type_of_Material").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_5_Type_of_Material").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_6_Angle_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_6_Angle_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_6_Angle_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_6_Angle_of_Curve]() As Double
      Get
      Return Properties("MEI_Chutes_Style_6_Angle_of_Curve").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_6_Angle_of_Curve").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_6_Infeed_Conveyor_Type]() As String
      Get
      Return Properties("MEI_Chutes_Style_6_Infeed_Conveyor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_6_Infeed_Conveyor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_6_Infeed_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_6_Infeed_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_6_Infeed_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_6_Length_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_6_Length_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_6_Length_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_6_Length_in_Feet]() As String
      Get
      Return Properties("MEI_Chutes_Style_6_Length_in_Feet").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_6_Length_in_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_6_Material_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_6_Material_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_6_Material_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_6_Merge_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_6_Merge_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_6_Merge_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_6_Number_of_Merging_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_6_Number_of_Merging_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_6_Number_of_Merging_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_6_Number_of_Sorting_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_6_Number_of_Sorting_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_6_Number_of_Sorting_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_6_Sort_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_6_Sort_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_6_Sort_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_6_Total_Hours_per_Chute]() As Double
      Get
      Return Properties("MEI_Chutes_Style_6_Total_Hours_per_Chute").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_6_Total_Hours_per_Chute").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_6_Type_of_Material]() As String
      Get
      Return Properties("MEI_Chutes_Style_6_Type_of_Material").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_6_Type_of_Material").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_7_Angle_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_7_Angle_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_7_Angle_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_7_Angle_of_Curve]() As Double
      Get
      Return Properties("MEI_Chutes_Style_7_Angle_of_Curve").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_7_Angle_of_Curve").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_7_Infeed_Conveyor_Type]() As String
      Get
      Return Properties("MEI_Chutes_Style_7_Infeed_Conveyor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_7_Infeed_Conveyor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_7_Infeed_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_7_Infeed_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_7_Infeed_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_7_Length_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_7_Length_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_7_Length_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_7_Length_in_Feet]() As String
      Get
      Return Properties("MEI_Chutes_Style_7_Length_in_Feet").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_7_Length_in_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_7_Material_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_7_Material_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_7_Material_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_7_Merge_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_7_Merge_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_7_Merge_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_7_Number_of_Merging_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_7_Number_of_Merging_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_7_Number_of_Merging_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_7_Number_of_Sorting_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_7_Number_of_Sorting_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_7_Number_of_Sorting_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_7_Sort_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_7_Sort_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_7_Sort_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_7_Total_Hours_per_Chute]() As Double
      Get
      Return Properties("MEI_Chutes_Style_7_Total_Hours_per_Chute").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_7_Total_Hours_per_Chute").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_7_Type_of_Material]() As String
      Get
      Return Properties("MEI_Chutes_Style_7_Type_of_Material").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_7_Type_of_Material").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_8_Angle_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_8_Angle_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_8_Angle_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_8_Angle_of_Curve]() As Double
      Get
      Return Properties("MEI_Chutes_Style_8_Angle_of_Curve").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_8_Angle_of_Curve").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_8_Infeed_Conveyor_Type]() As String
      Get
      Return Properties("MEI_Chutes_Style_8_Infeed_Conveyor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_8_Infeed_Conveyor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_8_Infeed_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_8_Infeed_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_8_Infeed_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_8_Length_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_8_Length_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_8_Length_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_8_Length_in_Feet]() As String
      Get
      Return Properties("MEI_Chutes_Style_8_Length_in_Feet").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_8_Length_in_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_8_Material_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_8_Material_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_8_Material_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_8_Merge_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_8_Merge_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_8_Merge_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_8_Number_of_Merging_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_8_Number_of_Merging_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_8_Number_of_Merging_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_8_Number_of_Sorting_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_8_Number_of_Sorting_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_8_Number_of_Sorting_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_8_Sort_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_8_Sort_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_8_Sort_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_8_Total_Hours_per_Chute]() As Double
      Get
      Return Properties("MEI_Chutes_Style_8_Total_Hours_per_Chute").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_8_Total_Hours_per_Chute").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_8_Type_of_Material]() As String
      Get
      Return Properties("MEI_Chutes_Style_8_Type_of_Material").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_8_Type_of_Material").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_9_Angle_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_9_Angle_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_9_Angle_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_9_Angle_of_Curve]() As Double
      Get
      Return Properties("MEI_Chutes_Style_9_Angle_of_Curve").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_9_Angle_of_Curve").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_9_Infeed_Conveyor_Type]() As String
      Get
      Return Properties("MEI_Chutes_Style_9_Infeed_Conveyor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_9_Infeed_Conveyor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_9_Infeed_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_9_Infeed_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_9_Infeed_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_9_Length_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_9_Length_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_9_Length_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_9_Length_in_Feet]() As String
      Get
      Return Properties("MEI_Chutes_Style_9_Length_in_Feet").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_9_Length_in_Feet").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_9_Material_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_9_Material_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_9_Material_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_9_Merge_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_9_Merge_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_9_Merge_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_9_Number_of_Merging_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_9_Number_of_Merging_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_9_Number_of_Merging_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_9_Number_of_Sorting_Lanes]() As Double
      Get
      Return Properties("MEI_Chutes_Style_9_Number_of_Sorting_Lanes").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_9_Number_of_Sorting_Lanes").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_9_Sort_hrs]() As Double
      Get
      Return Properties("MEI_Chutes_Style_9_Sort_hrs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_9_Sort_hrs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_9_Total_Hours_per_Chute]() As Double
      Get
      Return Properties("MEI_Chutes_Style_9_Total_Hours_per_Chute").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MEI_Chutes_Style_9_Total_Hours_per_Chute").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MEI_Chutes_Style_9_Type_of_Material]() As String
      Get
      Return Properties("MEI_Chutes_Style_9_Type_of_Material").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Style_9_Type_of_Material").CalculatedValue = Value
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
    
      Public ReadOnly Property [My_Subsystem]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Subsystem")
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
    InitPart("CAE_Chutes", <a><![CDATA[CAE_Chutes]]></a>.Value, 409, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H582667", "07/16/2025 10:07:19")
    AddProperty("9512", "DisplayName", <a><![CDATA[Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/8/2025 6:31:23 PM")
    AddProperty("9580", "MEI_Chutes_Style_1_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_1_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:45:56 AM")
    AddProperty("9649", "MEI_Chutes_Style_1_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_1_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 8:54:20 AM")
    AddProperty("9679", "MEI_Chutes_Style_1_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_1_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E7", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 8:59:26 AM")
    AddProperty("9583", "MEI_Chutes_Style_1_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_1_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:11:35 AM")
    AddProperty("9581", "MEI_Chutes_Style_1_Length_hrs", <a><![CDATA[MEI_Chutes_Style_1_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:20:32 AM")
    AddProperty("9659", "MEI_Chutes_Style_1_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_1_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C7", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:14:24 AM")
    AddProperty("9582", "MEI_Chutes_Style_1_Material_hrs", <a><![CDATA[MEI_Chutes_Style_1_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:02:23 AM")
    AddProperty("9584", "MEI_Chutes_Style_1_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_1_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:56:39 AM")
    AddProperty("9689", "MEI_Chutes_Style_1_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_1_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:15 AM")
    AddProperty("9699", "MEI_Chutes_Style_1_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_1_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:48 AM")
    AddProperty("9585", "MEI_Chutes_Style_1_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_1_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:56:41 AM")
    AddProperty("9579", "MEI_Chutes_Style_1_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_1_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:56:28 AM")
    AddProperty("9669", "MEI_Chutes_Style_1_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_1_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D7", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:07:19 AM")
    AddProperty("9643", "MEI_Chutes_Style_10_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_10_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:51:38 AM")
    AddProperty("9658", "MEI_Chutes_Style_10_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_10_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 8:55:53 AM")
    AddProperty("9688", "MEI_Chutes_Style_10_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_10_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E16", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:00:05 AM")
    AddProperty("9646", "MEI_Chutes_Style_10_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_10_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:05:23 AM")
    AddProperty("9644", "MEI_Chutes_Style_10_Length_hrs", <a><![CDATA[MEI_Chutes_Style_10_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:21:10 AM")
    AddProperty("9668", "MEI_Chutes_Style_10_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_10_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C16", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:18:45 AM")
    AddProperty("9645", "MEI_Chutes_Style_10_Material_hrs", <a><![CDATA[MEI_Chutes_Style_10_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:03:02 AM")
    AddProperty("9647", "MEI_Chutes_Style_10_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_10_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:58:47 AM")
    AddProperty("9698", "MEI_Chutes_Style_10_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_10_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:46 AM")
    AddProperty("9708", "MEI_Chutes_Style_10_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_10_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:01:07 AM")
    AddProperty("9648", "MEI_Chutes_Style_10_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_10_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:58:49 AM")
    AddProperty("9642", "MEI_Chutes_Style_10_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_10_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:58:36 AM")
    AddProperty("9678", "MEI_Chutes_Style_10_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_10_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D16", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:07:13 AM")
    AddProperty("9587", "MEI_Chutes_Style_2_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_2_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:47:10 AM")
    AddProperty("9650", "MEI_Chutes_Style_2_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_2_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 8:56:07 AM")
    AddProperty("9680", "MEI_Chutes_Style_2_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_2_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E8", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:00:29 AM")
    AddProperty("9590", "MEI_Chutes_Style_2_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_2_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:05:38 AM")
    AddProperty("9588", "MEI_Chutes_Style_2_Length_hrs", <a><![CDATA[MEI_Chutes_Style_2_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:21:25 AM")
    AddProperty("9660", "MEI_Chutes_Style_2_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_2_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C8", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:18:35 AM")
    AddProperty("9589", "MEI_Chutes_Style_2_Material_hrs", <a><![CDATA[MEI_Chutes_Style_2_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:03:16 AM")
    AddProperty("9591", "MEI_Chutes_Style_2_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_2_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:56:53 AM")
    AddProperty("9690", "MEI_Chutes_Style_2_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_2_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:29 AM")
    AddProperty("9700", "MEI_Chutes_Style_2_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_2_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:50 AM")
    AddProperty("9592", "MEI_Chutes_Style_2_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_2_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:56:55 AM")
    AddProperty("9586", "MEI_Chutes_Style_2_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_2_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:56:43 AM")
    AddProperty("9670", "MEI_Chutes_Style_2_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_2_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D8", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:07:06 AM")
    AddProperty("9594", "MEI_Chutes_Style_3_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_3_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:51:29 AM")
    AddProperty("9651", "MEI_Chutes_Style_3_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_3_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 8:56:17 AM")
    AddProperty("9681", "MEI_Chutes_Style_3_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_3_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E9", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:00:50 AM")
    AddProperty("9597", "MEI_Chutes_Style_3_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_3_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:05:51 AM")
    AddProperty("9595", "MEI_Chutes_Style_3_Length_hrs", <a><![CDATA[MEI_Chutes_Style_3_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:21:39 AM")
    AddProperty("9661", "MEI_Chutes_Style_3_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_3_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C9", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:17:26 AM")
    AddProperty("9596", "MEI_Chutes_Style_3_Material_hrs", <a><![CDATA[MEI_Chutes_Style_3_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:03:34 AM")
    AddProperty("9598", "MEI_Chutes_Style_3_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_3_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:57:06 AM")
    AddProperty("9691", "MEI_Chutes_Style_3_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_3_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:31 AM")
    AddProperty("9701", "MEI_Chutes_Style_3_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_3_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:52 AM")
    AddProperty("9599", "MEI_Chutes_Style_3_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_3_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:57:08 AM")
    AddProperty("9593", "MEI_Chutes_Style_3_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_3_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:56:56 AM")
    AddProperty("9671", "MEI_Chutes_Style_3_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_3_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D9", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:06:57 AM")
    AddProperty("9601", "MEI_Chutes_Style_4_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_4_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:48:16 AM")
    AddProperty("9652", "MEI_Chutes_Style_4_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_4_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 8:56:36 AM")
    AddProperty("9682", "MEI_Chutes_Style_4_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_4_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E10", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:01:11 AM")
    AddProperty("9604", "MEI_Chutes_Style_4_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_4_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:06:09 AM")
    AddProperty("9602", "MEI_Chutes_Style_4_Length_hrs", <a><![CDATA[MEI_Chutes_Style_4_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:21:51 AM")
    AddProperty("9662", "MEI_Chutes_Style_4_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_4_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C10", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:17:36 AM")
    AddProperty("9603", "MEI_Chutes_Style_4_Material_hrs", <a><![CDATA[MEI_Chutes_Style_4_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:03:47 AM")
    AddProperty("9605", "MEI_Chutes_Style_4_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_4_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:57:20 AM")
    AddProperty("9692", "MEI_Chutes_Style_4_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_4_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:33 AM")
    AddProperty("9702", "MEI_Chutes_Style_4_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_4_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:54 AM")
    AddProperty("9606", "MEI_Chutes_Style_4_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_4_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:57:22 AM")
    AddProperty("9600", "MEI_Chutes_Style_4_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_4_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:57:10 AM")
    AddProperty("9672", "MEI_Chutes_Style_4_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_4_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D10", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:06:48 AM")
    AddProperty("9608", "MEI_Chutes_Style_5_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_5_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:48:59 AM")
    AddProperty("9653", "MEI_Chutes_Style_5_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_5_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 8:56:52 AM")
    AddProperty("9683", "MEI_Chutes_Style_5_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_5_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E11", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:01:29 AM")
    AddProperty("9611", "MEI_Chutes_Style_5_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_5_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:06:23 AM")
    AddProperty("9609", "MEI_Chutes_Style_5_Length_hrs", <a><![CDATA[MEI_Chutes_Style_5_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:22:03 AM")
    AddProperty("9663", "MEI_Chutes_Style_5_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_5_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C11", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:17:44 AM")
    AddProperty("9610", "MEI_Chutes_Style_5_Material_hrs", <a><![CDATA[MEI_Chutes_Style_5_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:05:32 AM")
    AddProperty("9612", "MEI_Chutes_Style_5_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_5_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:57:34 AM")
    AddProperty("9693", "MEI_Chutes_Style_5_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_5_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:35 AM")
    AddProperty("9703", "MEI_Chutes_Style_5_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_5_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:57 AM")
    AddProperty("9613", "MEI_Chutes_Style_5_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_5_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:57:36 AM")
    AddProperty("9607", "MEI_Chutes_Style_5_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_5_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:57:24 AM")
    AddProperty("9673", "MEI_Chutes_Style_5_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_5_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D11", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:06:41 AM")
    AddProperty("9615", "MEI_Chutes_Style_6_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_6_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:50:54 AM")
    AddProperty("9654", "MEI_Chutes_Style_6_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_6_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 8:57:06 AM")
    AddProperty("9684", "MEI_Chutes_Style_6_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_6_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E12", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:02:00 AM")
    AddProperty("9618", "MEI_Chutes_Style_6_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_6_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:06:37 AM")
    AddProperty("9616", "MEI_Chutes_Style_6_Length_hrs", <a><![CDATA[MEI_Chutes_Style_6_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:22:17 AM")
    AddProperty("9664", "MEI_Chutes_Style_6_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_6_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C12", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:17:52 AM")
    AddProperty("9617", "MEI_Chutes_Style_6_Material_hrs", <a><![CDATA[MEI_Chutes_Style_6_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:05:25 AM")
    AddProperty("9619", "MEI_Chutes_Style_6_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_6_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:57:48 AM")
    AddProperty("9694", "MEI_Chutes_Style_6_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_6_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:37 AM")
    AddProperty("9704", "MEI_Chutes_Style_6_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_6_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:59 AM")
    AddProperty("9620", "MEI_Chutes_Style_6_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_6_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:57:50 AM")
    AddProperty("9614", "MEI_Chutes_Style_6_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_6_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:57:38 AM")
    AddProperty("9674", "MEI_Chutes_Style_6_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_6_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D12", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:06:34 AM")
    AddProperty("9622", "MEI_Chutes_Style_7_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_7_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:50:50 AM")
    AddProperty("9655", "MEI_Chutes_Style_7_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_7_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 8:57:23 AM")
    AddProperty("9685", "MEI_Chutes_Style_7_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_7_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E13", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:02:18 AM")
    AddProperty("9625", "MEI_Chutes_Style_7_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_7_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:06:49 AM")
    AddProperty("9623", "MEI_Chutes_Style_7_Length_hrs", <a><![CDATA[MEI_Chutes_Style_7_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:22:33 AM")
    AddProperty("9665", "MEI_Chutes_Style_7_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_7_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C13", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:18:00 AM")
    AddProperty("9624", "MEI_Chutes_Style_7_Material_hrs", <a><![CDATA[MEI_Chutes_Style_7_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:05:21 AM")
    AddProperty("9626", "MEI_Chutes_Style_7_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_7_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:58:02 AM")
    AddProperty("9695", "MEI_Chutes_Style_7_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_7_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:39 AM")
    AddProperty("9705", "MEI_Chutes_Style_7_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_7_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:01:01 AM")
    AddProperty("9627", "MEI_Chutes_Style_7_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_7_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:58:04 AM")
    AddProperty("9621", "MEI_Chutes_Style_7_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_7_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:57:52 AM")
    AddProperty("9675", "MEI_Chutes_Style_7_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_7_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D13", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:06:26 AM")
    AddProperty("9629", "MEI_Chutes_Style_8_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_8_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:50:46 AM")
    AddProperty("9656", "MEI_Chutes_Style_8_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_8_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 8:57:38 AM")
    AddProperty("9686", "MEI_Chutes_Style_8_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_8_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E14", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:02:58 AM")
    AddProperty("9632", "MEI_Chutes_Style_8_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_8_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:07:01 AM")
    AddProperty("9630", "MEI_Chutes_Style_8_Length_hrs", <a><![CDATA[MEI_Chutes_Style_8_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:22:49 AM")
    AddProperty("9666", "MEI_Chutes_Style_8_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_8_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C14", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:18:08 AM")
    AddProperty("9631", "MEI_Chutes_Style_8_Material_hrs", <a><![CDATA[MEI_Chutes_Style_8_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:04:45 AM")
    AddProperty("9633", "MEI_Chutes_Style_8_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_8_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:58:17 AM")
    AddProperty("9696", "MEI_Chutes_Style_8_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_8_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:42 AM")
    AddProperty("9706", "MEI_Chutes_Style_8_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_8_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:01:03 AM")
    AddProperty("9634", "MEI_Chutes_Style_8_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_8_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:58:19 AM")
    AddProperty("9628", "MEI_Chutes_Style_8_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_8_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:58:06 AM")
    AddProperty("9676", "MEI_Chutes_Style_8_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_8_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D14", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:06:19 AM")
    AddProperty("9636", "MEI_Chutes_Style_9_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_9_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:50:42 AM")
    AddProperty("9657", "MEI_Chutes_Style_9_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_9_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 8:57:54 AM")
    AddProperty("9687", "MEI_Chutes_Style_9_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_9_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E15", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:02:52 AM")
    AddProperty("9639", "MEI_Chutes_Style_9_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_9_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:07:12 AM")
    AddProperty("9637", "MEI_Chutes_Style_9_Length_hrs", <a><![CDATA[MEI_Chutes_Style_9_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:23:17 AM")
    AddProperty("9667", "MEI_Chutes_Style_9_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_9_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C15", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 9:18:16 AM")
    AddProperty("9638", "MEI_Chutes_Style_9_Material_hrs", <a><![CDATA[MEI_Chutes_Style_9_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:05:07 AM")
    AddProperty("9640", "MEI_Chutes_Style_9_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_9_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:58:32 AM")
    AddProperty("9697", "MEI_Chutes_Style_9_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_9_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:00:44 AM")
    AddProperty("9707", "MEI_Chutes_Style_9_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_9_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 6:01:05 AM")
    AddProperty("9641", "MEI_Chutes_Style_9_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_9_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:58:34 AM")
    AddProperty("9635", "MEI_Chutes_Style_9_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_9_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H581955", "7/9/2025 5:58:21 AM")
    AddProperty("9677", "MEI_Chutes_Style_9_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_9_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D15", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H582667", "7/16/2025 10:06:09 AM")
    AddProperty("9491", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/8/2025 3:52:07 PM")
    
      AddValidValue("MEI_Chutes_Style_1_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_1_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_1_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_1_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_10_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_10_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_10_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_10_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_2_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_2_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_2_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_2_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_3_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_3_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_3_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_3_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_4_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_4_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_4_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_4_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_5_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_5_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_5_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_5_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_6_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_6_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_6_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_6_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_7_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_7_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_7_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_7_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_8_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_8_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_8_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_8_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_9_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_9_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_9_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_9_Type_of_Material")
    
      oConnection = AddConnection("My_Subsystem", <a><![CDATA[My_Subsystem]]></a>.Value, "", "126", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/8/2025 6:31:23 PM")
      
        oConnection.AddVPF(399, "CAE_Mech_Install_CP_Comp")
      
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
          InitProperty("DisplayName", "9092", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/8/2025 6:31:23 PM", "", "In Development",  0,15187)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Angle_hrs", "9160", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:45:56 AM", "", "In Development",  0,17936)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Angle_of_Curve", "9229", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 8:54:20 AM", "", "In Development",  0,17811)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Infeed_Conveyor_Type", "9259", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 8:59:26 AM", "", "In Development",  0,17825)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Infeed_hrs", "9163", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:11:35 AM", "", "In Development",  0,17874)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Length_hrs", "9161", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:20:32 AM", "", "In Development",  0,17905)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Length_in_Feet", "9239", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:14:24 AM", "", "In Development",  0,17877)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Material_hrs", "9162", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:02:23 AM", "", "In Development",  0,17959)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Merge_hrs", "9164", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:56:39 AM", "", "In Development",  0,15331)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Number_of_Merging_Lanes", "9269", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:15 AM", "", "In Development",  0,15542)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Number_of_Sorting_Lanes", "9279", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:48 AM", "", "In Development",  0,15562)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Sort_hrs", "9165", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:56:41 AM", "", "In Development",  0,15333)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Total_Hours_per_Chute", "9159", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:56:28 AM", "", "In Development",  0,15321)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Type_of_Material", "9249", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:58:56 AM", "", "In Development",  0,17947)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Angle_hrs", "9223", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:46:40 AM", "", "In Development",  0,17937)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Angle_of_Curve", "9238", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 8:55:53 AM", "", "In Development",  0,17812)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Infeed_Conveyor_Type", "9268", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:00:05 AM", "", "In Development",  0,17828)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Infeed_hrs", "9226", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:05:23 AM", "", "In Development",  0,17856)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Length_hrs", "9224", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:21:10 AM", "", "In Development",  0,17908)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Length_in_Feet", "9248", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:17:09 AM", "", "In Development",  0,17893)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Material_hrs", "9225", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:03:02 AM", "", "In Development",  0,17960)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Merge_hrs", "9227", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:58:47 AM", "", "In Development",  0,15457)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Number_of_Merging_Lanes", "9278", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:46 AM", "", "In Development",  0,15560)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Number_of_Sorting_Lanes", "9288", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:01:07 AM", "", "In Development",  0,15580)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Sort_hrs", "9228", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:58:49 AM", "", "In Development",  0,15459)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Total_Hours_per_Chute", "9222", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:58:36 AM", "", "In Development",  0,15447)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Type_of_Material", "9258", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:07:13 AM", "", "In Development",  0,17978)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Angle_hrs", "9167", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:47:10 AM", "", "In Development",  0,17938)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Angle_of_Curve", "9230", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 8:56:07 AM", "", "In Development",  0,17810)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Infeed_Conveyor_Type", "9260", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:00:29 AM", "", "In Development",  0,17830)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Infeed_hrs", "9170", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:05:38 AM", "", "In Development",  0,17857)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Length_hrs", "9168", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:21:25 AM", "", "In Development",  0,17909)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Length_in_Feet", "9240", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:18:35 AM", "", "In Development",  0,17895)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Material_hrs", "9169", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:03:16 AM", "", "In Development",  0,17961)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Merge_hrs", "9171", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:56:53 AM", "", "In Development",  0,15345)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Number_of_Merging_Lanes", "9270", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:29 AM", "", "In Development",  0,15544)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Number_of_Sorting_Lanes", "9280", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:50 AM", "", "In Development",  0,15564)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Sort_hrs", "9172", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:56:55 AM", "", "In Development",  0,15347)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Total_Hours_per_Chute", "9166", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:56:43 AM", "", "In Development",  0,15335)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Type_of_Material", "9250", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:07:06 AM", "", "In Development",  0,17977)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Angle_hrs", "9174", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:51:29 AM", "", "In Development",  0,17939)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Angle_of_Curve", "9231", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 8:56:17 AM", "", "In Development",  0,17808)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Infeed_Conveyor_Type", "9261", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:00:50 AM", "", "In Development",  0,17832)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Infeed_hrs", "9177", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:05:51 AM", "", "In Development",  0,17858)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Length_hrs", "9175", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:21:39 AM", "", "In Development",  0,17911)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Length_in_Feet", "9241", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:17:26 AM", "", "In Development",  0,17896)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Material_hrs", "9176", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:03:34 AM", "", "In Development",  0,17962)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Merge_hrs", "9178", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:57:06 AM", "", "In Development",  0,15359)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Number_of_Merging_Lanes", "9271", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:31 AM", "", "In Development",  0,15546)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Number_of_Sorting_Lanes", "9281", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:52 AM", "", "In Development",  0,15566)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Sort_hrs", "9179", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:57:08 AM", "", "In Development",  0,15361)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Total_Hours_per_Chute", "9173", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:56:56 AM", "", "In Development",  0,15349)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Type_of_Material", "9251", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:06:57 AM", "", "In Development",  0,17976)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Angle_hrs", "9181", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:48:16 AM", "", "In Development",  0,17940)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Angle_of_Curve", "9232", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 8:56:36 AM", "", "In Development",  0,17813)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Infeed_Conveyor_Type", "9262", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:01:11 AM", "", "In Development",  0,17835)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Infeed_hrs", "9184", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:06:09 AM", "", "In Development",  0,17859)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Length_hrs", "9182", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:21:51 AM", "", "In Development",  0,17912)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Length_in_Feet", "9242", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:17:36 AM", "", "In Development",  0,17897)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Material_hrs", "9183", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:03:47 AM", "", "In Development",  0,17963)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Merge_hrs", "9185", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:57:20 AM", "", "In Development",  0,15373)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Number_of_Merging_Lanes", "9272", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:33 AM", "", "In Development",  0,15548)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Number_of_Sorting_Lanes", "9282", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:54 AM", "", "In Development",  0,15568)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Sort_hrs", "9186", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:57:22 AM", "", "In Development",  0,15375)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Total_Hours_per_Chute", "9180", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:57:10 AM", "", "In Development",  0,15363)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Type_of_Material", "9252", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:06:48 AM", "", "In Development",  0,17975)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Angle_hrs", "9188", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:48:59 AM", "", "In Development",  0,17941)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Angle_of_Curve", "9233", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 8:56:52 AM", "", "In Development",  0,17815)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Infeed_Conveyor_Type", "9263", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:01:29 AM", "", "In Development",  0,17837)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Infeed_hrs", "9191", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:06:23 AM", "", "In Development",  0,17860)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Length_hrs", "9189", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:22:03 AM", "", "In Development",  0,17913)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Length_in_Feet", "9243", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:17:44 AM", "", "In Development",  0,17898)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Material_hrs", "9190", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:05:32 AM", "", "In Development",  0,17965)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Merge_hrs", "9192", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:57:34 AM", "", "In Development",  0,15387)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Number_of_Merging_Lanes", "9273", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:35 AM", "", "In Development",  0,15550)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Number_of_Sorting_Lanes", "9283", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:57 AM", "", "In Development",  0,15570)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Sort_hrs", "9193", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:57:36 AM", "", "In Development",  0,15389)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Total_Hours_per_Chute", "9187", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:57:24 AM", "", "In Development",  0,15377)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Type_of_Material", "9253", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:06:41 AM", "", "In Development",  0,17974)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Angle_hrs", "9195", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:50:54 AM", "", "In Development",  0,17942)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Angle_of_Curve", "9234", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 8:57:06 AM", "", "In Development",  0,17817)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Infeed_Conveyor_Type", "9264", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:02:00 AM", "", "In Development",  0,17840)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Infeed_hrs", "9198", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:06:37 AM", "", "In Development",  0,17861)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Length_hrs", "9196", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:22:17 AM", "", "In Development",  0,17915)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Length_in_Feet", "9244", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:17:52 AM", "", "In Development",  0,17899)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Material_hrs", "9197", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:05:25 AM", "", "In Development",  0,17966)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Merge_hrs", "9199", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:57:48 AM", "", "In Development",  0,15401)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Number_of_Merging_Lanes", "9274", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:37 AM", "", "In Development",  0,15552)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Number_of_Sorting_Lanes", "9284", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:59 AM", "", "In Development",  0,15572)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Sort_hrs", "9200", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:57:50 AM", "", "In Development",  0,15403)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Total_Hours_per_Chute", "9194", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:57:38 AM", "", "In Development",  0,15391)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Type_of_Material", "9254", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:06:34 AM", "", "In Development",  0,17973)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Angle_hrs", "9202", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:50:50 AM", "", "In Development",  0,17943)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Angle_of_Curve", "9235", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 8:57:23 AM", "", "In Development",  0,17819)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Infeed_Conveyor_Type", "9265", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:02:18 AM", "", "In Development",  0,17842)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Infeed_hrs", "9205", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:06:49 AM", "", "In Development",  0,17862)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Length_hrs", "9203", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:22:33 AM", "", "In Development",  0,17916)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Length_in_Feet", "9245", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:18:00 AM", "", "In Development",  0,17900)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Material_hrs", "9204", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:05:21 AM", "", "In Development",  0,17967)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Merge_hrs", "9206", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:58:02 AM", "", "In Development",  0,15415)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Number_of_Merging_Lanes", "9275", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:39 AM", "", "In Development",  0,15554)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Number_of_Sorting_Lanes", "9285", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:01:01 AM", "", "In Development",  0,15574)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Sort_hrs", "9207", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:58:04 AM", "", "In Development",  0,15417)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Total_Hours_per_Chute", "9201", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:57:52 AM", "", "In Development",  0,15405)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Type_of_Material", "9255", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:06:26 AM", "", "In Development",  0,17972)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Angle_hrs", "9209", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:50:46 AM", "", "In Development",  0,17944)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Angle_of_Curve", "9236", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 8:57:38 AM", "", "In Development",  0,17821)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Infeed_Conveyor_Type", "9266", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:02:58 AM", "", "In Development",  0,17844)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Infeed_hrs", "9212", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:07:01 AM", "", "In Development",  0,17863)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Length_hrs", "9210", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:22:49 AM", "", "In Development",  0,17919)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Length_in_Feet", "9246", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:18:08 AM", "", "In Development",  0,17901)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Material_hrs", "9211", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:04:45 AM", "", "In Development",  0,17968)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Merge_hrs", "9213", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:58:17 AM", "", "In Development",  0,15429)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Number_of_Merging_Lanes", "9276", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:42 AM", "", "In Development",  0,15556)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Number_of_Sorting_Lanes", "9286", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:01:03 AM", "", "In Development",  0,15576)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Sort_hrs", "9214", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:58:19 AM", "", "In Development",  0,15431)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Total_Hours_per_Chute", "9208", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:58:06 AM", "", "In Development",  0,15419)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Type_of_Material", "9256", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:06:19 AM", "", "In Development",  0,17971)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Angle_hrs", "9216", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:50:42 AM", "", "In Development",  0,17945)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Angle_of_Curve", "9237", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 8:57:54 AM", "", "In Development",  0,17823)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Infeed_Conveyor_Type", "9267", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:02:52 AM", "", "In Development",  0,17846)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Infeed_hrs", "9219", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:07:12 AM", "", "In Development",  0,17864)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Length_hrs", "9217", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:23:01 AM", "", "In Development",  0,17920)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Length_in_Feet", "9247", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 9:18:16 AM", "", "In Development",  0,17902)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Material_hrs", "9218", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:05:07 AM", "", "In Development",  0,17969)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Merge_hrs", "9220", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:58:32 AM", "", "In Development",  0,15443)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Number_of_Merging_Lanes", "9277", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:00:44 AM", "", "In Development",  0,15558)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Number_of_Sorting_Lanes", "9287", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 6:01:05 AM", "", "In Development",  0,15578)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Sort_hrs", "9221", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:58:34 AM", "", "In Development",  0,15445)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Total_Hours_per_Chute", "9215", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H581955", "7/9/2025 5:58:21 AM", "", "In Development",  0,15433)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Type_of_Material", "9257", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H582667", "7/16/2025 10:06:09 AM", "", "In Development",  0,17970)
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
          
        InitValidValue("MEI_Chutes_Style_1_Angle_of_Curve_ValidValues", "9229", "-1", 17342)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_1_Infeed_Conveyor_Type_ValidValues", "9259", "-1", 17826)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_1_Length_in_Feet_ValidValues", "9239", "-1", 17879)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_1_Type_of_Material_ValidValues", "9249", "-1", 17948)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_10_Angle_of_Curve_ValidValues", "9238", "-1", 17348)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_10_Infeed_Conveyor_Type_ValidValues", "9268", "-1", 17829)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_10_Length_in_Feet_ValidValues", "9248", "-1", 17880)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_10_Type_of_Material_ValidValues", "9258", "-1", 17949)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_2_Angle_of_Curve_ValidValues", "9230", "-1", 17806)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_2_Infeed_Conveyor_Type_ValidValues", "9260", "-1", 17831)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_2_Length_in_Feet_ValidValues", "9240", "-1", 17881)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_2_Type_of_Material_ValidValues", "9250", "-1", 17950)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_3_Angle_of_Curve_ValidValues", "9231", "-1", 17807)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_3_Infeed_Conveyor_Type_ValidValues", "9261", "-1", 17833)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_3_Length_in_Feet_ValidValues", "9241", "-1", 17883)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_3_Type_of_Material_ValidValues", "9251", "-1", 17951)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_4_Angle_of_Curve_ValidValues", "9232", "-1", 17814)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_4_Infeed_Conveyor_Type_ValidValues", "9262", "-1", 17836)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_4_Length_in_Feet_ValidValues", "9242", "-1", 17884)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_4_Type_of_Material_ValidValues", "9252", "-1", 17952)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_5_Angle_of_Curve_ValidValues", "9233", "-1", 17816)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_5_Infeed_Conveyor_Type_ValidValues", "9263", "-1", 17838)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_5_Length_in_Feet_ValidValues", "9243", "-1", 17886)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_5_Type_of_Material_ValidValues", "9253", "-1", 17953)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_6_Angle_of_Curve_ValidValues", "9234", "-1", 17818)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_6_Infeed_Conveyor_Type_ValidValues", "9264", "-1", 17841)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_6_Length_in_Feet_ValidValues", "9244", "-1", 17887)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_6_Type_of_Material_ValidValues", "9254", "-1", 17954)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_7_Angle_of_Curve_ValidValues", "9235", "-1", 17820)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_7_Infeed_Conveyor_Type_ValidValues", "9265", "-1", 17843)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_7_Length_in_Feet_ValidValues", "9245", "-1", 17889)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_7_Type_of_Material_ValidValues", "9255", "-1", 17955)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_8_Angle_of_Curve_ValidValues", "9236", "-1", 17822)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_8_Infeed_Conveyor_Type_ValidValues", "9266", "-1", 17845)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_8_Length_in_Feet_ValidValues", "9246", "-1", 17890)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_8_Type_of_Material_ValidValues", "9256", "-1", 17956)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_9_Angle_of_Curve_ValidValues", "9237", "-1", 17824)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_9_Infeed_Conveyor_Type_ValidValues", "9267", "-1", 17847)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_9_Length_in_Feet_ValidValues", "9247", "-1", 17892)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_9_Type_of_Material_ValidValues", "9257", "-1", 17957)
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
          
        InitConnection("My_Subsystem", "106", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/8/2025 6:31:23 PM", "", "In Development", "N",200)
        
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
      Public Function Formula_My_Subsystem_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:106; TYPE:PF
        Result = Me.Parent.Base_Options_Alternates(Me.SubpartID)
        '   END FORMULA; CON ID:106; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_My_Subsystem_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
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
      '   BEGIN FORMULA; PROP ID:9092; TYPE:PF
      Result = me.My_Subsystem(1).DisplayName
      '   END FORMULA; PROP ID:9092; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_DisplayName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Angle_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Angle_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9160; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_1_Angle_of_Curve
Case 30
	Result = 5
Case 45
	Result = 10
Case 90
	Result = 15
Case 180
	Result = 20
Case 360
	Result = 25
Case 540
	Result = 30
Case 720
	Result = 35
Case 900
	Result = 40
End Select
      '   END FORMULA; PROP ID:9160; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Angle_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Angle_of_Curve() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9229; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:9229; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Angle_of_Curve", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9259; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:9259; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Infeed_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Infeed_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9163; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_1_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:9163; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Infeed_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Length_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Length_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9161; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_1_Length_in_Feet
 Case "0 to 2 Ft 11 Inch"
Result = 5
 Case "10 Ft to Max"
Result = 30
 Case "3 Ft To 5 Ft 11 Inch"
Result = 10
Case "6 Ft to 9 Ft 11 Inche"
Result = 20
End Select
      '   END FORMULA; PROP ID:9161; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Length_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Length_in_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9239; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:9239; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Length_in_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Material_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Material_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9162; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_1_Type_of_Material
 Case "Other(Ask)"
Result = 0
 Case "Painted Steel"
Result = 20
 Case "Stainless Steel"
Result = 15
Case "UHMW"
Result = 0
End Select
      '   END FORMULA; PROP ID:9162; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Material_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Merge_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Merge_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9164; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9164; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Merge_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Number_of_Merging_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9269; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9269; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Number_of_Merging_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Number_of_Sorting_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9279; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9279; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Number_of_Sorting_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Sort_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Sort_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9165; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9165; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Sort_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Total_Hours_per_Chute() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Total_Hours_per_Chute").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9159; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9159; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Total_Hours_per_Chute", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Type_of_Material() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9249; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:9249; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Type_of_Material", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Angle_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Angle_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9223; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_10_Angle_of_Curve
Case 30
	Result = 5
Case 45
	Result = 10
Case 90
	Result = 15
Case 180
	Result = 20
Case 360
	Result = 25
Case 540
	Result = 30
Case 720
	Result = 35
Case 900
	Result = 40
End Select
      '   END FORMULA; PROP ID:9223; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Angle_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Angle_of_Curve() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9238; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:9238; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Angle_of_Curve", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9268; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:9268; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Infeed_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Infeed_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9226; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_10_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:9226; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Infeed_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Length_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Length_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9224; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_10_Length_in_Feet
 Case "0 to 2 Ft 11 Inch"
Result = 5
 Case "10 Ft to Max"
Result = 30
 Case "3 Ft To 5 Ft 11 Inch"
Result = 10
Case "6 Ft to 9 Ft 11 Inche"
Result = 20
End Select
      '   END FORMULA; PROP ID:9224; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Length_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Length_in_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9248; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:9248; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Length_in_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Material_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Material_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9225; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_10_Type_of_Material
 Case "Other(Ask)"
Result = 0
 Case "Painted Steel"
Result = 20
 Case "Stainless Steel"
Result = 15
Case "UHMW"
Result = 0
End Select
      '   END FORMULA; PROP ID:9225; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Material_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Merge_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Merge_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9227; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9227; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Merge_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Number_of_Merging_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9278; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9278; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Number_of_Merging_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Number_of_Sorting_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9288; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9288; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Number_of_Sorting_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Sort_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Sort_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9228; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9228; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Sort_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Total_Hours_per_Chute() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Total_Hours_per_Chute").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9222; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9222; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Total_Hours_per_Chute", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Type_of_Material() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9258; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:9258; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Type_of_Material", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Angle_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Angle_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9167; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_2_Angle_of_Curve
Case 30
	Result = 5
Case 45
	Result = 10
Case 90
	Result = 15
Case 180
	Result = 20
Case 360
	Result = 25
Case 540
	Result = 30
Case 720
	Result = 35
Case 900
	Result = 40
End Select
      '   END FORMULA; PROP ID:9167; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Angle_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Angle_of_Curve() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9230; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:9230; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Angle_of_Curve", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9260; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:9260; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Infeed_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Infeed_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9170; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_2_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:9170; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Infeed_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Length_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Length_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9168; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_2_Length_in_Feet
 Case "0 to 2 Ft 11 Inch"
Result = 5
 Case "10 Ft to Max"
Result = 30
 Case "3 Ft To 5 Ft 11 Inch"
Result = 10
Case "6 Ft to 9 Ft 11 Inche"
Result = 20
End Select
      '   END FORMULA; PROP ID:9168; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Length_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Length_in_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9240; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:9240; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Length_in_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Material_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Material_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9169; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_2_Type_of_Material
 Case "Other(Ask)"
Result = 0
 Case "Painted Steel"
Result = 20
 Case "Stainless Steel"
Result = 15
Case "UHMW"
Result = 0
End Select
      '   END FORMULA; PROP ID:9169; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Material_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Merge_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Merge_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9171; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9171; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Merge_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Number_of_Merging_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9270; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9270; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Number_of_Merging_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Number_of_Sorting_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9280; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9280; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Number_of_Sorting_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Sort_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Sort_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9172; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9172; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Sort_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Total_Hours_per_Chute() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Total_Hours_per_Chute").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9166; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9166; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Total_Hours_per_Chute", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Type_of_Material() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9250; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:9250; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Type_of_Material", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Angle_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Angle_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9174; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_3_Angle_of_Curve
Case 30
	Result = 5
Case 45
	Result = 10
Case 90
	Result = 15
Case 180
	Result = 20
Case 360
	Result = 25
Case 540
	Result = 30
Case 720
	Result = 35
Case 900
	Result = 40
End Select
      '   END FORMULA; PROP ID:9174; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Angle_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Angle_of_Curve() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9231; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:9231; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Angle_of_Curve", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9261; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:9261; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Infeed_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Infeed_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9177; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_3_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:9177; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Infeed_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Length_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Length_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9175; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_3_Length_in_Feet
 Case "0 to 2 Ft 11 Inch"
Result = 5
 Case "10 Ft to Max"
Result = 30
 Case "3 Ft To 5 Ft 11 Inch"
Result = 10
Case "6 Ft to 9 Ft 11 Inche"
Result = 20
End Select
      '   END FORMULA; PROP ID:9175; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Length_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Length_in_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9241; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:9241; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Length_in_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Material_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Material_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9176; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_3_Type_of_Material
 Case "Other(Ask)"
Result = 0
 Case "Painted Steel"
Result = 20
 Case "Stainless Steel"
Result = 15
Case "UHMW"
Result = 0
End Select
      '   END FORMULA; PROP ID:9176; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Material_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Merge_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Merge_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9178; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9178; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Merge_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Number_of_Merging_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9271; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9271; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Number_of_Merging_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Number_of_Sorting_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9281; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9281; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Number_of_Sorting_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Sort_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Sort_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9179; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9179; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Sort_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Total_Hours_per_Chute() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Total_Hours_per_Chute").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9173; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9173; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Total_Hours_per_Chute", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Type_of_Material() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9251; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:9251; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Type_of_Material", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Angle_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Angle_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9181; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_4_Angle_of_Curve
Case 30
	Result = 5
Case 45
	Result = 10
Case 90
	Result = 15
Case 180
	Result = 20
Case 360
	Result = 25
Case 540
	Result = 30
Case 720
	Result = 35
Case 900
	Result = 40
End Select
      '   END FORMULA; PROP ID:9181; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Angle_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Angle_of_Curve() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9232; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:9232; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Angle_of_Curve", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9262; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:9262; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Infeed_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Infeed_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9184; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_4_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:9184; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Infeed_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Length_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Length_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9182; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_4_Length_in_Feet
 Case "0 to 2 Ft 11 Inch"
Result = 5
 Case "10 Ft to Max"
Result = 30
 Case "3 Ft To 5 Ft 11 Inch"
Result = 10
Case "6 Ft to 9 Ft 11 Inche"
Result = 20
End Select
      '   END FORMULA; PROP ID:9182; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Length_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Length_in_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9242; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:9242; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Length_in_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Material_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Material_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9183; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_4_Type_of_Material
 Case "Other(Ask)"
Result = 0
 Case "Painted Steel"
Result = 20
 Case "Stainless Steel"
Result = 15
Case "UHMW"
Result = 0
End Select
      '   END FORMULA; PROP ID:9183; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Material_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Merge_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Merge_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9185; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9185; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Merge_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Number_of_Merging_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9272; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9272; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Number_of_Merging_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Number_of_Sorting_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9282; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9282; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Number_of_Sorting_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Sort_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Sort_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9186; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9186; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Sort_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Total_Hours_per_Chute() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Total_Hours_per_Chute").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9180; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9180; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Total_Hours_per_Chute", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Type_of_Material() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9252; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:9252; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Type_of_Material", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Angle_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Angle_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9188; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_5_Angle_of_Curve
Case 30
	Result = 5
Case 45
	Result = 10
Case 90
	Result = 15
Case 180
	Result = 20
Case 360
	Result = 25
Case 540
	Result = 30
Case 720
	Result = 35
Case 900
	Result = 40
End Select
      '   END FORMULA; PROP ID:9188; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Angle_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Angle_of_Curve() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9233; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:9233; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Angle_of_Curve", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9263; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:9263; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Infeed_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Infeed_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9191; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_5_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:9191; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Infeed_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Length_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Length_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9189; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_5_Length_in_Feet
 Case "0 to 2 Ft 11 Inch"
Result = 5
 Case "10 Ft to Max"
Result = 30
 Case "3 Ft To 5 Ft 11 Inch"
Result = 10
Case "6 Ft to 9 Ft 11 Inche"
Result = 20
End Select
      '   END FORMULA; PROP ID:9189; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Length_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Length_in_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9243; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:9243; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Length_in_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Material_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Material_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9190; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_5_Type_of_Material
 Case "Other(Ask)"
Result = 0
 Case "Painted Steel"
Result = 20
 Case "Stainless Steel"
Result = 15
Case "UHMW"
Result = 0
End Select
      '   END FORMULA; PROP ID:9190; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Material_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Merge_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Merge_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9192; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9192; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Merge_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Number_of_Merging_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9273; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9273; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Number_of_Merging_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Number_of_Sorting_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9283; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9283; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Number_of_Sorting_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Sort_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Sort_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9193; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9193; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Sort_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Total_Hours_per_Chute() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Total_Hours_per_Chute").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9187; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9187; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Total_Hours_per_Chute", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Type_of_Material() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9253; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:9253; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Type_of_Material", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Angle_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Angle_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9195; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_6_Angle_of_Curve
Case 30
	Result = 5
Case 45
	Result = 10
Case 90
	Result = 15
Case 180
	Result = 20
Case 360
	Result = 25
Case 540
	Result = 30
Case 720
	Result = 35
Case 900
	Result = 40
End Select
      '   END FORMULA; PROP ID:9195; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Angle_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Angle_of_Curve() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9234; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:9234; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Angle_of_Curve", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9264; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:9264; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Infeed_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Infeed_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9198; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_6_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:9198; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Infeed_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Length_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Length_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9196; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_6_Length_in_Feet
 Case "0 to 2 Ft 11 Inch"
Result = 5
 Case "10 Ft to Max"
Result = 30
 Case "3 Ft To 5 Ft 11 Inch"
Result = 10
Case "6 Ft to 9 Ft 11 Inche"
Result = 20
End Select
      '   END FORMULA; PROP ID:9196; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Length_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Length_in_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9244; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:9244; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Length_in_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Material_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Material_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9197; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_6_Type_of_Material
 Case "Other(Ask)"
Result = 0
 Case "Painted Steel"
Result = 20
 Case "Stainless Steel"
Result = 15
Case "UHMW"
Result = 0
End Select
      '   END FORMULA; PROP ID:9197; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Material_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Merge_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Merge_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9199; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9199; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Merge_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Number_of_Merging_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9274; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9274; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Number_of_Merging_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Number_of_Sorting_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9284; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9284; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Number_of_Sorting_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Sort_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Sort_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9200; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9200; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Sort_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Total_Hours_per_Chute() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Total_Hours_per_Chute").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9194; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9194; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Total_Hours_per_Chute", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Type_of_Material() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9254; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:9254; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Type_of_Material", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Angle_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Angle_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9202; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_7_Angle_of_Curve
Case 30
	Result = 5
Case 45
	Result = 10
Case 90
	Result = 15
Case 180
	Result = 20
Case 360
	Result = 25
Case 540
	Result = 30
Case 720
	Result = 35
Case 900
	Result = 40
End Select
      '   END FORMULA; PROP ID:9202; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Angle_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Angle_of_Curve() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9235; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:9235; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Angle_of_Curve", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9265; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:9265; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Infeed_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Infeed_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9205; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_7_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:9205; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Infeed_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Length_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Length_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9203; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_7_Length_in_Feet
 Case "0 to 2 Ft 11 Inch"
Result = 5
 Case "10 Ft to Max"
Result = 30
 Case "3 Ft To 5 Ft 11 Inch"
Result = 10
Case "6 Ft to 9 Ft 11 Inche"
Result = 20
End Select
      '   END FORMULA; PROP ID:9203; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Length_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Length_in_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9245; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:9245; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Length_in_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Material_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Material_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9204; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_7_Type_of_Material
 Case "Other(Ask)"
Result = 0
 Case "Painted Steel"
Result = 20
 Case "Stainless Steel"
Result = 15
Case "UHMW"
Result = 0
End Select
      '   END FORMULA; PROP ID:9204; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Material_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Merge_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Merge_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9206; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9206; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Merge_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Number_of_Merging_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9275; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9275; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Number_of_Merging_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Number_of_Sorting_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9285; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9285; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Number_of_Sorting_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Sort_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Sort_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9207; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9207; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Sort_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Total_Hours_per_Chute() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Total_Hours_per_Chute").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9201; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9201; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Total_Hours_per_Chute", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Type_of_Material() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9255; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:9255; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Type_of_Material", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Angle_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Angle_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9209; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_8_Angle_of_Curve
Case 30
	Result = 5
Case 45
	Result = 10
Case 90
	Result = 15
Case 180
	Result = 20
Case 360
	Result = 25
Case 540
	Result = 30
Case 720
	Result = 35
Case 900
	Result = 40
End Select
      '   END FORMULA; PROP ID:9209; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Angle_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Angle_of_Curve() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9236; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:9236; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Angle_of_Curve", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9266; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:9266; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Infeed_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Infeed_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9212; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_8_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:9212; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Infeed_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Length_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Length_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9210; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_8_Length_in_Feet
 Case "0 to 2 Ft 11 Inch"
Result = 5
 Case "10 Ft to Max"
Result = 30
 Case "3 Ft To 5 Ft 11 Inch"
Result = 10
Case "6 Ft to 9 Ft 11 Inche"
Result = 20
End Select
      '   END FORMULA; PROP ID:9210; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Length_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Length_in_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9246; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:9246; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Length_in_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Material_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Material_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9211; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_8_Type_of_Material
 Case "Other(Ask)"
Result = 0
 Case "Painted Steel"
Result = 20
 Case "Stainless Steel"
Result = 15
Case "UHMW"
Result = 0
End Select
      '   END FORMULA; PROP ID:9211; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Material_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Merge_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Merge_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9213; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9213; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Merge_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Number_of_Merging_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9276; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9276; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Number_of_Merging_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Number_of_Sorting_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9286; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9286; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Number_of_Sorting_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Sort_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Sort_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9214; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9214; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Sort_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Total_Hours_per_Chute() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Total_Hours_per_Chute").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9208; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9208; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Total_Hours_per_Chute", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Type_of_Material() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9256; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:9256; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Type_of_Material", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Angle_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Angle_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9216; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_9_Angle_of_Curve
Case 30
	Result = 5
Case 45
	Result = 10
Case 90
	Result = 15
Case 180
	Result = 20
Case 360
	Result = 25
Case 540
	Result = 30
Case 720
	Result = 35
Case 900
	Result = 40
End Select
      '   END FORMULA; PROP ID:9216; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Angle_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Angle_of_Curve() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9237; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:9237; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Angle_of_Curve", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9267; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:9267; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Infeed_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Infeed_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9219; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_9_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:9219; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Infeed_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Length_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Length_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9217; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_9_Length_in_Feet
 Case "0 to 2 Ft 11 Inch"
Result = 5
 Case "10 Ft to Max"
Result = 30
 Case "3 Ft To 5 Ft 11 Inch"
Result = 10
Case "6 Ft to 9 Ft 11 Inche"
Result = 20
End Select
      '   END FORMULA; PROP ID:9217; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Length_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Length_in_Feet() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9247; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:9247; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Length_in_Feet", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Material_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Material_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9218; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_9_Type_of_Material
 Case "Other(Ask)"
Result = 0
 Case "Painted Steel"
Result = 20
 Case "Stainless Steel"
Result = 15
Case "UHMW"
Result = 0
End Select
      '   END FORMULA; PROP ID:9218; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Material_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Merge_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Merge_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9220; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9220; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Merge_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Number_of_Merging_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9277; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9277; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Number_of_Merging_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Number_of_Sorting_Lanes() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9287; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9287; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Number_of_Sorting_Lanes", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Sort_hrs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Sort_hrs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9221; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9221; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Sort_hrs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Total_Hours_per_Chute() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Total_Hours_per_Chute").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9215; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9215; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Total_Hours_per_Chute", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Type_of_Material() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9257; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:9257; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Type_of_Material", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Angle_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_1_Angle_hrs"
          Me.Properties("MEI_Chutes_Style_1_Angle_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9160; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9160; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Angle_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_1_Angle_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Angle_of_Curve_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_1_Angle_of_Curve"
          Me.Properties("MEI_Chutes_Style_1_Angle_of_Curve").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9229; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9229; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Angle_of_Curve_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_1_Angle_of_Curve").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_1_Infeed_Conveyor_Type"
          Me.Properties("MEI_Chutes_Style_1_Infeed_Conveyor_Type").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9259; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9259; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_1_Infeed_Conveyor_Type").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Infeed_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_1_Infeed_hrs"
          Me.Properties("MEI_Chutes_Style_1_Infeed_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9163; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9163; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Infeed_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_1_Infeed_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Length_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_1_Length_hrs"
          Me.Properties("MEI_Chutes_Style_1_Length_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9161; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9161; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Length_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_1_Length_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Length_in_Feet_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_1_Length_in_Feet"
          Me.Properties("MEI_Chutes_Style_1_Length_in_Feet").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9239; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9239; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Length_in_Feet_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_1_Length_in_Feet").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Material_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_1_Material_hrs"
          Me.Properties("MEI_Chutes_Style_1_Material_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9162; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9162; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Material_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_1_Material_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Merge_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_1_Merge_hrs"
          Me.Properties("MEI_Chutes_Style_1_Merge_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9164; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9164; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Merge_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_1_Merge_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Number_of_Merging_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_1_Number_of_Merging_Lanes"
          Me.Properties("MEI_Chutes_Style_1_Number_of_Merging_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9269; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9269; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Number_of_Merging_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_1_Number_of_Merging_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Number_of_Sorting_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_1_Number_of_Sorting_Lanes"
          Me.Properties("MEI_Chutes_Style_1_Number_of_Sorting_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9279; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9279; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_1_Number_of_Sorting_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Sort_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_1_Sort_hrs"
          Me.Properties("MEI_Chutes_Style_1_Sort_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9165; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9165; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Sort_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_1_Sort_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Total_Hours_per_Chute_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_1_Total_Hours_per_Chute"
          Me.Properties("MEI_Chutes_Style_1_Total_Hours_per_Chute").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9159; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9159; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Total_Hours_per_Chute_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_1_Total_Hours_per_Chute").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_1_Type_of_Material_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_1_Type_of_Material"
          Me.Properties("MEI_Chutes_Style_1_Type_of_Material").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9249; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9249; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Type_of_Material_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_1_Type_of_Material").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Angle_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_10_Angle_hrs"
          Me.Properties("MEI_Chutes_Style_10_Angle_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9223; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9223; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Angle_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_10_Angle_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Angle_of_Curve_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_10_Angle_of_Curve"
          Me.Properties("MEI_Chutes_Style_10_Angle_of_Curve").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9238; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9238; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Angle_of_Curve_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_10_Angle_of_Curve").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_10_Infeed_Conveyor_Type"
          Me.Properties("MEI_Chutes_Style_10_Infeed_Conveyor_Type").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9268; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9268; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_10_Infeed_Conveyor_Type").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Infeed_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_10_Infeed_hrs"
          Me.Properties("MEI_Chutes_Style_10_Infeed_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9226; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9226; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Infeed_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_10_Infeed_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Length_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_10_Length_hrs"
          Me.Properties("MEI_Chutes_Style_10_Length_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9224; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9224; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Length_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_10_Length_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Length_in_Feet_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_10_Length_in_Feet"
          Me.Properties("MEI_Chutes_Style_10_Length_in_Feet").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9248; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9248; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Length_in_Feet_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_10_Length_in_Feet").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Material_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_10_Material_hrs"
          Me.Properties("MEI_Chutes_Style_10_Material_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9225; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9225; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Material_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_10_Material_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Merge_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_10_Merge_hrs"
          Me.Properties("MEI_Chutes_Style_10_Merge_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9227; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9227; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Merge_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_10_Merge_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Number_of_Merging_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_10_Number_of_Merging_Lanes"
          Me.Properties("MEI_Chutes_Style_10_Number_of_Merging_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9278; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9278; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Number_of_Merging_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_10_Number_of_Merging_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Number_of_Sorting_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_10_Number_of_Sorting_Lanes"
          Me.Properties("MEI_Chutes_Style_10_Number_of_Sorting_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9288; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9288; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_10_Number_of_Sorting_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Sort_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_10_Sort_hrs"
          Me.Properties("MEI_Chutes_Style_10_Sort_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9228; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9228; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Sort_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_10_Sort_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Total_Hours_per_Chute_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_10_Total_Hours_per_Chute"
          Me.Properties("MEI_Chutes_Style_10_Total_Hours_per_Chute").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9222; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9222; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Total_Hours_per_Chute_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_10_Total_Hours_per_Chute").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_10_Type_of_Material_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_10_Type_of_Material"
          Me.Properties("MEI_Chutes_Style_10_Type_of_Material").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9258; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9258; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Type_of_Material_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_10_Type_of_Material").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Angle_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_2_Angle_hrs"
          Me.Properties("MEI_Chutes_Style_2_Angle_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9167; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9167; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Angle_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_2_Angle_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Angle_of_Curve_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_2_Angle_of_Curve"
          Me.Properties("MEI_Chutes_Style_2_Angle_of_Curve").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9230; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9230; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Angle_of_Curve_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_2_Angle_of_Curve").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_2_Infeed_Conveyor_Type"
          Me.Properties("MEI_Chutes_Style_2_Infeed_Conveyor_Type").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9260; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9260; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_2_Infeed_Conveyor_Type").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Infeed_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_2_Infeed_hrs"
          Me.Properties("MEI_Chutes_Style_2_Infeed_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9170; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9170; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Infeed_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_2_Infeed_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Length_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_2_Length_hrs"
          Me.Properties("MEI_Chutes_Style_2_Length_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9168; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9168; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Length_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_2_Length_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Length_in_Feet_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_2_Length_in_Feet"
          Me.Properties("MEI_Chutes_Style_2_Length_in_Feet").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9240; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9240; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Length_in_Feet_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_2_Length_in_Feet").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Material_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_2_Material_hrs"
          Me.Properties("MEI_Chutes_Style_2_Material_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9169; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9169; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Material_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_2_Material_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Merge_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_2_Merge_hrs"
          Me.Properties("MEI_Chutes_Style_2_Merge_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9171; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9171; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Merge_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_2_Merge_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Number_of_Merging_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_2_Number_of_Merging_Lanes"
          Me.Properties("MEI_Chutes_Style_2_Number_of_Merging_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9270; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9270; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Number_of_Merging_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_2_Number_of_Merging_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Number_of_Sorting_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_2_Number_of_Sorting_Lanes"
          Me.Properties("MEI_Chutes_Style_2_Number_of_Sorting_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9280; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9280; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_2_Number_of_Sorting_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Sort_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_2_Sort_hrs"
          Me.Properties("MEI_Chutes_Style_2_Sort_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9172; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9172; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Sort_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_2_Sort_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Total_Hours_per_Chute_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_2_Total_Hours_per_Chute"
          Me.Properties("MEI_Chutes_Style_2_Total_Hours_per_Chute").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9166; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9166; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Total_Hours_per_Chute_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_2_Total_Hours_per_Chute").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_2_Type_of_Material_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_2_Type_of_Material"
          Me.Properties("MEI_Chutes_Style_2_Type_of_Material").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9250; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9250; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Type_of_Material_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_2_Type_of_Material").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Angle_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_3_Angle_hrs"
          Me.Properties("MEI_Chutes_Style_3_Angle_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9174; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9174; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Angle_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_3_Angle_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Angle_of_Curve_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_3_Angle_of_Curve"
          Me.Properties("MEI_Chutes_Style_3_Angle_of_Curve").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9231; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9231; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Angle_of_Curve_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_3_Angle_of_Curve").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_3_Infeed_Conveyor_Type"
          Me.Properties("MEI_Chutes_Style_3_Infeed_Conveyor_Type").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9261; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9261; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_3_Infeed_Conveyor_Type").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Infeed_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_3_Infeed_hrs"
          Me.Properties("MEI_Chutes_Style_3_Infeed_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9177; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9177; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Infeed_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_3_Infeed_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Length_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_3_Length_hrs"
          Me.Properties("MEI_Chutes_Style_3_Length_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9175; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9175; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Length_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_3_Length_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Length_in_Feet_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_3_Length_in_Feet"
          Me.Properties("MEI_Chutes_Style_3_Length_in_Feet").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9241; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9241; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Length_in_Feet_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_3_Length_in_Feet").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Material_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_3_Material_hrs"
          Me.Properties("MEI_Chutes_Style_3_Material_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9176; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9176; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Material_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_3_Material_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Merge_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_3_Merge_hrs"
          Me.Properties("MEI_Chutes_Style_3_Merge_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9178; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9178; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Merge_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_3_Merge_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Number_of_Merging_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_3_Number_of_Merging_Lanes"
          Me.Properties("MEI_Chutes_Style_3_Number_of_Merging_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9271; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9271; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Number_of_Merging_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_3_Number_of_Merging_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Number_of_Sorting_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_3_Number_of_Sorting_Lanes"
          Me.Properties("MEI_Chutes_Style_3_Number_of_Sorting_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9281; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9281; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_3_Number_of_Sorting_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Sort_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_3_Sort_hrs"
          Me.Properties("MEI_Chutes_Style_3_Sort_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9179; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9179; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Sort_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_3_Sort_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Total_Hours_per_Chute_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_3_Total_Hours_per_Chute"
          Me.Properties("MEI_Chutes_Style_3_Total_Hours_per_Chute").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9173; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9173; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Total_Hours_per_Chute_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_3_Total_Hours_per_Chute").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_3_Type_of_Material_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_3_Type_of_Material"
          Me.Properties("MEI_Chutes_Style_3_Type_of_Material").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9251; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9251; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Type_of_Material_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_3_Type_of_Material").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Angle_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_4_Angle_hrs"
          Me.Properties("MEI_Chutes_Style_4_Angle_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9181; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9181; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Angle_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_4_Angle_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Angle_of_Curve_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_4_Angle_of_Curve"
          Me.Properties("MEI_Chutes_Style_4_Angle_of_Curve").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9232; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9232; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Angle_of_Curve_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_4_Angle_of_Curve").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_4_Infeed_Conveyor_Type"
          Me.Properties("MEI_Chutes_Style_4_Infeed_Conveyor_Type").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9262; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9262; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_4_Infeed_Conveyor_Type").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Infeed_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_4_Infeed_hrs"
          Me.Properties("MEI_Chutes_Style_4_Infeed_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9184; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9184; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Infeed_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_4_Infeed_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Length_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_4_Length_hrs"
          Me.Properties("MEI_Chutes_Style_4_Length_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9182; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9182; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Length_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_4_Length_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Length_in_Feet_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_4_Length_in_Feet"
          Me.Properties("MEI_Chutes_Style_4_Length_in_Feet").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9242; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9242; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Length_in_Feet_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_4_Length_in_Feet").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Material_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_4_Material_hrs"
          Me.Properties("MEI_Chutes_Style_4_Material_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9183; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9183; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Material_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_4_Material_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Merge_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_4_Merge_hrs"
          Me.Properties("MEI_Chutes_Style_4_Merge_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9185; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9185; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Merge_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_4_Merge_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Number_of_Merging_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_4_Number_of_Merging_Lanes"
          Me.Properties("MEI_Chutes_Style_4_Number_of_Merging_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9272; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9272; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Number_of_Merging_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_4_Number_of_Merging_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Number_of_Sorting_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_4_Number_of_Sorting_Lanes"
          Me.Properties("MEI_Chutes_Style_4_Number_of_Sorting_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9282; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9282; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_4_Number_of_Sorting_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Sort_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_4_Sort_hrs"
          Me.Properties("MEI_Chutes_Style_4_Sort_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9186; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9186; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Sort_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_4_Sort_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Total_Hours_per_Chute_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_4_Total_Hours_per_Chute"
          Me.Properties("MEI_Chutes_Style_4_Total_Hours_per_Chute").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9180; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9180; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Total_Hours_per_Chute_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_4_Total_Hours_per_Chute").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_4_Type_of_Material_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_4_Type_of_Material"
          Me.Properties("MEI_Chutes_Style_4_Type_of_Material").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9252; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9252; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Type_of_Material_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_4_Type_of_Material").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Angle_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_5_Angle_hrs"
          Me.Properties("MEI_Chutes_Style_5_Angle_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9188; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9188; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Angle_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_5_Angle_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Angle_of_Curve_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_5_Angle_of_Curve"
          Me.Properties("MEI_Chutes_Style_5_Angle_of_Curve").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9233; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9233; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Angle_of_Curve_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_5_Angle_of_Curve").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_5_Infeed_Conveyor_Type"
          Me.Properties("MEI_Chutes_Style_5_Infeed_Conveyor_Type").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9263; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9263; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_5_Infeed_Conveyor_Type").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Infeed_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_5_Infeed_hrs"
          Me.Properties("MEI_Chutes_Style_5_Infeed_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9191; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9191; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Infeed_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_5_Infeed_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Length_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_5_Length_hrs"
          Me.Properties("MEI_Chutes_Style_5_Length_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9189; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9189; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Length_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_5_Length_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Length_in_Feet_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_5_Length_in_Feet"
          Me.Properties("MEI_Chutes_Style_5_Length_in_Feet").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9243; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9243; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Length_in_Feet_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_5_Length_in_Feet").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Material_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_5_Material_hrs"
          Me.Properties("MEI_Chutes_Style_5_Material_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9190; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9190; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Material_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_5_Material_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Merge_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_5_Merge_hrs"
          Me.Properties("MEI_Chutes_Style_5_Merge_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9192; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9192; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Merge_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_5_Merge_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Number_of_Merging_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_5_Number_of_Merging_Lanes"
          Me.Properties("MEI_Chutes_Style_5_Number_of_Merging_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9273; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9273; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Number_of_Merging_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_5_Number_of_Merging_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Number_of_Sorting_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_5_Number_of_Sorting_Lanes"
          Me.Properties("MEI_Chutes_Style_5_Number_of_Sorting_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9283; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9283; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_5_Number_of_Sorting_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Sort_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_5_Sort_hrs"
          Me.Properties("MEI_Chutes_Style_5_Sort_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9193; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9193; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Sort_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_5_Sort_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Total_Hours_per_Chute_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_5_Total_Hours_per_Chute"
          Me.Properties("MEI_Chutes_Style_5_Total_Hours_per_Chute").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9187; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9187; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Total_Hours_per_Chute_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_5_Total_Hours_per_Chute").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_5_Type_of_Material_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_5_Type_of_Material"
          Me.Properties("MEI_Chutes_Style_5_Type_of_Material").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9253; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9253; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Type_of_Material_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_5_Type_of_Material").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Angle_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_6_Angle_hrs"
          Me.Properties("MEI_Chutes_Style_6_Angle_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9195; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9195; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Angle_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_6_Angle_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Angle_of_Curve_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_6_Angle_of_Curve"
          Me.Properties("MEI_Chutes_Style_6_Angle_of_Curve").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9234; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9234; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Angle_of_Curve_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_6_Angle_of_Curve").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_6_Infeed_Conveyor_Type"
          Me.Properties("MEI_Chutes_Style_6_Infeed_Conveyor_Type").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9264; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9264; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_6_Infeed_Conveyor_Type").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Infeed_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_6_Infeed_hrs"
          Me.Properties("MEI_Chutes_Style_6_Infeed_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9198; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9198; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Infeed_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_6_Infeed_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Length_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_6_Length_hrs"
          Me.Properties("MEI_Chutes_Style_6_Length_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9196; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9196; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Length_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_6_Length_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Length_in_Feet_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_6_Length_in_Feet"
          Me.Properties("MEI_Chutes_Style_6_Length_in_Feet").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9244; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9244; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Length_in_Feet_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_6_Length_in_Feet").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Material_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_6_Material_hrs"
          Me.Properties("MEI_Chutes_Style_6_Material_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9197; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9197; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Material_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_6_Material_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Merge_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_6_Merge_hrs"
          Me.Properties("MEI_Chutes_Style_6_Merge_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9199; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9199; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Merge_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_6_Merge_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Number_of_Merging_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_6_Number_of_Merging_Lanes"
          Me.Properties("MEI_Chutes_Style_6_Number_of_Merging_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9274; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9274; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Number_of_Merging_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_6_Number_of_Merging_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Number_of_Sorting_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_6_Number_of_Sorting_Lanes"
          Me.Properties("MEI_Chutes_Style_6_Number_of_Sorting_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9284; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9284; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_6_Number_of_Sorting_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Sort_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_6_Sort_hrs"
          Me.Properties("MEI_Chutes_Style_6_Sort_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9200; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9200; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Sort_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_6_Sort_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Total_Hours_per_Chute_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_6_Total_Hours_per_Chute"
          Me.Properties("MEI_Chutes_Style_6_Total_Hours_per_Chute").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9194; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9194; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Total_Hours_per_Chute_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_6_Total_Hours_per_Chute").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_6_Type_of_Material_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_6_Type_of_Material"
          Me.Properties("MEI_Chutes_Style_6_Type_of_Material").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9254; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9254; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Type_of_Material_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_6_Type_of_Material").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Angle_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_7_Angle_hrs"
          Me.Properties("MEI_Chutes_Style_7_Angle_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9202; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9202; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Angle_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_7_Angle_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Angle_of_Curve_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_7_Angle_of_Curve"
          Me.Properties("MEI_Chutes_Style_7_Angle_of_Curve").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9235; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9235; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Angle_of_Curve_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_7_Angle_of_Curve").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_7_Infeed_Conveyor_Type"
          Me.Properties("MEI_Chutes_Style_7_Infeed_Conveyor_Type").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9265; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9265; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_7_Infeed_Conveyor_Type").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Infeed_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_7_Infeed_hrs"
          Me.Properties("MEI_Chutes_Style_7_Infeed_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9205; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9205; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Infeed_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_7_Infeed_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Length_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_7_Length_hrs"
          Me.Properties("MEI_Chutes_Style_7_Length_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9203; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9203; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Length_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_7_Length_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Length_in_Feet_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_7_Length_in_Feet"
          Me.Properties("MEI_Chutes_Style_7_Length_in_Feet").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9245; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9245; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Length_in_Feet_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_7_Length_in_Feet").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Material_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_7_Material_hrs"
          Me.Properties("MEI_Chutes_Style_7_Material_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9204; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9204; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Material_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_7_Material_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Merge_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_7_Merge_hrs"
          Me.Properties("MEI_Chutes_Style_7_Merge_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9206; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9206; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Merge_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_7_Merge_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Number_of_Merging_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_7_Number_of_Merging_Lanes"
          Me.Properties("MEI_Chutes_Style_7_Number_of_Merging_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9275; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9275; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Number_of_Merging_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_7_Number_of_Merging_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Number_of_Sorting_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_7_Number_of_Sorting_Lanes"
          Me.Properties("MEI_Chutes_Style_7_Number_of_Sorting_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9285; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9285; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_7_Number_of_Sorting_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Sort_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_7_Sort_hrs"
          Me.Properties("MEI_Chutes_Style_7_Sort_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9207; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9207; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Sort_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_7_Sort_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Total_Hours_per_Chute_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_7_Total_Hours_per_Chute"
          Me.Properties("MEI_Chutes_Style_7_Total_Hours_per_Chute").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9201; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9201; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Total_Hours_per_Chute_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_7_Total_Hours_per_Chute").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_7_Type_of_Material_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_7_Type_of_Material"
          Me.Properties("MEI_Chutes_Style_7_Type_of_Material").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9255; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9255; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Type_of_Material_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_7_Type_of_Material").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Angle_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_8_Angle_hrs"
          Me.Properties("MEI_Chutes_Style_8_Angle_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9209; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9209; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Angle_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_8_Angle_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Angle_of_Curve_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_8_Angle_of_Curve"
          Me.Properties("MEI_Chutes_Style_8_Angle_of_Curve").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9236; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9236; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Angle_of_Curve_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_8_Angle_of_Curve").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_8_Infeed_Conveyor_Type"
          Me.Properties("MEI_Chutes_Style_8_Infeed_Conveyor_Type").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9266; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9266; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_8_Infeed_Conveyor_Type").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Infeed_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_8_Infeed_hrs"
          Me.Properties("MEI_Chutes_Style_8_Infeed_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9212; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9212; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Infeed_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_8_Infeed_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Length_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_8_Length_hrs"
          Me.Properties("MEI_Chutes_Style_8_Length_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9210; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9210; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Length_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_8_Length_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Length_in_Feet_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_8_Length_in_Feet"
          Me.Properties("MEI_Chutes_Style_8_Length_in_Feet").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9246; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9246; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Length_in_Feet_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_8_Length_in_Feet").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Material_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_8_Material_hrs"
          Me.Properties("MEI_Chutes_Style_8_Material_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9211; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9211; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Material_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_8_Material_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Merge_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_8_Merge_hrs"
          Me.Properties("MEI_Chutes_Style_8_Merge_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9213; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9213; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Merge_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_8_Merge_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Number_of_Merging_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_8_Number_of_Merging_Lanes"
          Me.Properties("MEI_Chutes_Style_8_Number_of_Merging_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9276; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9276; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Number_of_Merging_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_8_Number_of_Merging_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Number_of_Sorting_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_8_Number_of_Sorting_Lanes"
          Me.Properties("MEI_Chutes_Style_8_Number_of_Sorting_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9286; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9286; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_8_Number_of_Sorting_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Sort_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_8_Sort_hrs"
          Me.Properties("MEI_Chutes_Style_8_Sort_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9214; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9214; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Sort_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_8_Sort_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Total_Hours_per_Chute_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_8_Total_Hours_per_Chute"
          Me.Properties("MEI_Chutes_Style_8_Total_Hours_per_Chute").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9208; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9208; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Total_Hours_per_Chute_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_8_Total_Hours_per_Chute").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_8_Type_of_Material_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_8_Type_of_Material"
          Me.Properties("MEI_Chutes_Style_8_Type_of_Material").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9256; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9256; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Type_of_Material_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_8_Type_of_Material").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Angle_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_9_Angle_hrs"
          Me.Properties("MEI_Chutes_Style_9_Angle_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9216; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9216; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Angle_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_9_Angle_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Angle_of_Curve_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_9_Angle_of_Curve"
          Me.Properties("MEI_Chutes_Style_9_Angle_of_Curve").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9237; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9237; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Angle_of_Curve_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_9_Angle_of_Curve").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_9_Infeed_Conveyor_Type"
          Me.Properties("MEI_Chutes_Style_9_Infeed_Conveyor_Type").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9267; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9267; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_9_Infeed_Conveyor_Type").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Infeed_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_9_Infeed_hrs"
          Me.Properties("MEI_Chutes_Style_9_Infeed_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9219; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9219; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Infeed_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_9_Infeed_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Length_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_9_Length_hrs"
          Me.Properties("MEI_Chutes_Style_9_Length_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9217; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9217; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Length_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_9_Length_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Length_in_Feet_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_9_Length_in_Feet"
          Me.Properties("MEI_Chutes_Style_9_Length_in_Feet").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9247; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9247; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Length_in_Feet_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_9_Length_in_Feet").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Material_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_9_Material_hrs"
          Me.Properties("MEI_Chutes_Style_9_Material_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9218; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9218; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Material_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_9_Material_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Merge_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_9_Merge_hrs"
          Me.Properties("MEI_Chutes_Style_9_Merge_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9220; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9220; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Merge_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_9_Merge_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Number_of_Merging_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_9_Number_of_Merging_Lanes"
          Me.Properties("MEI_Chutes_Style_9_Number_of_Merging_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9277; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9277; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Number_of_Merging_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_9_Number_of_Merging_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Number_of_Sorting_Lanes_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_9_Number_of_Sorting_Lanes"
          Me.Properties("MEI_Chutes_Style_9_Number_of_Sorting_Lanes").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9287; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9287; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_9_Number_of_Sorting_Lanes").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Sort_hrs_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_9_Sort_hrs"
          Me.Properties("MEI_Chutes_Style_9_Sort_hrs").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9221; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9221; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Sort_hrs_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_9_Sort_hrs").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Total_Hours_per_Chute_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_9_Total_Hours_per_Chute"
          Me.Properties("MEI_Chutes_Style_9_Total_Hours_per_Chute").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9215; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9215; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Total_Hours_per_Chute_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_9_Total_Hours_per_Chute").ErrorReporting
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Style_9_Type_of_Material_CustomCheck() as Object
          
          Dim Result as Object
          Dim ctx as Object
          Dim PropertyName As String
          PropertyName = "MEI_Chutes_Style_9_Type_of_Material"
          Me.Properties("MEI_Chutes_Style_9_Type_of_Material").ClearCustomErrors()
          Try
          ctx = this
              '   BEGIN FORMULA; PROP ID:9257; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:9257; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Type_of_Material_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_9_Type_of_Material").ErrorReporting
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
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
      Public Function Formula_MEI_Chutes_Style_1_Angle_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Angle_of_Curve_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Infeed_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Length_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Length_in_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Material_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Merge_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Number_of_Merging_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Number_of_Sorting_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Sort_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Total_Hours_per_Chute_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Type_of_Material_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Angle_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Angle_of_Curve_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Infeed_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Length_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Length_in_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Material_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Merge_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Number_of_Merging_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Number_of_Sorting_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Sort_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Total_Hours_per_Chute_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Type_of_Material_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Angle_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Angle_of_Curve_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Infeed_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Length_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Length_in_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Material_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Merge_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Number_of_Merging_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Number_of_Sorting_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Sort_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Total_Hours_per_Chute_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Type_of_Material_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Angle_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Angle_of_Curve_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Infeed_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Length_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Length_in_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Material_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Merge_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Number_of_Merging_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Number_of_Sorting_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Sort_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Total_Hours_per_Chute_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Type_of_Material_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Angle_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Angle_of_Curve_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Infeed_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Length_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Length_in_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Material_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Merge_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Number_of_Merging_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Number_of_Sorting_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Sort_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Total_Hours_per_Chute_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Type_of_Material_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Angle_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Angle_of_Curve_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Infeed_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Length_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Length_in_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Material_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Merge_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Number_of_Merging_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Number_of_Sorting_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Sort_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Total_Hours_per_Chute_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Type_of_Material_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Angle_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Angle_of_Curve_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Infeed_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Length_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Length_in_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Material_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Merge_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Number_of_Merging_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Number_of_Sorting_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Sort_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Total_Hours_per_Chute_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Type_of_Material_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Angle_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Angle_of_Curve_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Infeed_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Length_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Length_in_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Material_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Merge_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Number_of_Merging_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Number_of_Sorting_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Sort_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Total_Hours_per_Chute_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Type_of_Material_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Angle_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Angle_of_Curve_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Infeed_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Length_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Length_in_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Material_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Merge_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Number_of_Merging_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Number_of_Sorting_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Sort_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Total_Hours_per_Chute_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Type_of_Material_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Angle_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Angle_of_Curve_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Infeed_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Length_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Length_in_Feet_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Material_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Merge_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Number_of_Merging_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Number_of_Sorting_Lanes_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Sort_hrs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Total_Hours_per_Chute_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Type_of_Material_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_MEI_Chutes_Style_1_Angle_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Angle_of_Curve_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Infeed_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Length_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Length_in_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Material_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Merge_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Number_of_Merging_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Number_of_Sorting_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Sort_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Total_Hours_per_Chute_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Type_of_Material_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Angle_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Angle_of_Curve_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Infeed_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Length_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Length_in_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Material_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Merge_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Number_of_Merging_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Number_of_Sorting_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Sort_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Total_Hours_per_Chute_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Type_of_Material_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Angle_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Angle_of_Curve_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Infeed_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Length_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Length_in_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Material_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Merge_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Number_of_Merging_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Number_of_Sorting_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Sort_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Total_Hours_per_Chute_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Type_of_Material_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Angle_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Angle_of_Curve_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Infeed_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Length_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Length_in_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Material_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Merge_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Number_of_Merging_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Number_of_Sorting_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Sort_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Total_Hours_per_Chute_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Type_of_Material_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Angle_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Angle_of_Curve_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Infeed_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Length_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Length_in_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Material_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Merge_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Number_of_Merging_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Number_of_Sorting_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Sort_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Total_Hours_per_Chute_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Type_of_Material_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Angle_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Angle_of_Curve_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Infeed_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Length_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Length_in_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Material_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Merge_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Number_of_Merging_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Number_of_Sorting_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Sort_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Total_Hours_per_Chute_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Type_of_Material_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Angle_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Angle_of_Curve_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Infeed_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Length_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Length_in_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Material_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Merge_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Number_of_Merging_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Number_of_Sorting_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Sort_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Total_Hours_per_Chute_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Type_of_Material_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Angle_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Angle_of_Curve_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Infeed_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Length_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Length_in_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Material_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Merge_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Number_of_Merging_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Number_of_Sorting_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Sort_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Total_Hours_per_Chute_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Type_of_Material_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Angle_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Angle_of_Curve_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Infeed_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Length_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Length_in_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Material_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Merge_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Number_of_Merging_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Number_of_Sorting_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Sort_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Total_Hours_per_Chute_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Type_of_Material_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Angle_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Angle_of_Curve_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Infeed_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Length_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Length_in_Feet_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Material_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Merge_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Number_of_Merging_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Number_of_Sorting_Lanes_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Sort_hrs_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Total_Hours_per_Chute_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Type_of_Material_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Angle_of_Curve_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9229; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:9229; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Angle_of_Curve_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9259; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:9259; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Length_in_Feet_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9239; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:9239; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Type_of_Material_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9249; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:9249; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_1_Type_of_Material_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Angle_of_Curve_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9238; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:9238; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Angle_of_Curve_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9268; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:9268; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Length_in_Feet_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9248; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:9248; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Type_of_Material_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9258; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:9258; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_10_Type_of_Material_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Angle_of_Curve_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9230; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:9230; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Angle_of_Curve_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9260; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:9260; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Length_in_Feet_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9240; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:9240; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Type_of_Material_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9250; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:9250; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_2_Type_of_Material_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Angle_of_Curve_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9231; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:9231; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Angle_of_Curve_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9261; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:9261; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Length_in_Feet_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9241; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:9241; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Type_of_Material_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9251; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:9251; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_3_Type_of_Material_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Angle_of_Curve_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9232; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:9232; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Angle_of_Curve_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9262; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:9262; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Length_in_Feet_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9242; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:9242; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Type_of_Material_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9252; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:9252; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_4_Type_of_Material_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Angle_of_Curve_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9233; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:9233; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Angle_of_Curve_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9263; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:9263; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Length_in_Feet_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9243; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:9243; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Type_of_Material_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9253; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:9253; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_5_Type_of_Material_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Angle_of_Curve_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9234; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:9234; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Angle_of_Curve_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9264; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:9264; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Length_in_Feet_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9244; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:9244; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Type_of_Material_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9254; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:9254; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_6_Type_of_Material_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Angle_of_Curve_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9235; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:9235; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Angle_of_Curve_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9265; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:9265; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Length_in_Feet_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9245; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:9245; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Type_of_Material_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9255; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:9255; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_7_Type_of_Material_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Angle_of_Curve_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9236; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:9236; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Angle_of_Curve_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9266; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:9266; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Length_in_Feet_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9246; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:9246; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Type_of_Material_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9256; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:9256; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_8_Type_of_Material_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Angle_of_Curve_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Angle_of_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9237; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:9237; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Angle_of_Curve_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Infeed_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9267; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:9267; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Length_in_Feet_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Length_in_Feet").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9247; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:9247; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Type_of_Material_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Type_of_Material").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9257; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:9257; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chutes.Formula_MEI_Chutes_Style_9_Type_of_Material_ValidValues", ex.Message)
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

  