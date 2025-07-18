Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_Chute
'$ GenerateDate: 07/18/2025 11:37:15

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

    Public Class [CAE_Chute]
    
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

    Private this as CAE_Chute = me

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
    
          Public Property [MEI_Chutes_Styles]() As String
      Get
      Return Properties("MEI_Chutes_Styles").Value
      End Get
      Set(ByVal Value As String)
      Properties("MEI_Chutes_Styles").CalculatedValue = Value
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
    InitPart("CAE_Chute", <a><![CDATA[CAE_Chute]]></a>.Value, 430, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H602502", "07/17/2025 14:20:08")
    AddProperty("10450", "DisplayName", <a><![CDATA[Display Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:20:08 PM")
    AddProperty("10451", "MEI_Chutes_Style_1_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_1_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10452", "MEI_Chutes_Style_1_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_1_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10453", "MEI_Chutes_Style_1_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_1_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E7", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10454", "MEI_Chutes_Style_1_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_1_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10455", "MEI_Chutes_Style_1_Length_hrs", <a><![CDATA[MEI_Chutes_Style_1_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10456", "MEI_Chutes_Style_1_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_1_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C7", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10457", "MEI_Chutes_Style_1_Material_hrs", <a><![CDATA[MEI_Chutes_Style_1_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10458", "MEI_Chutes_Style_1_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_1_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10459", "MEI_Chutes_Style_1_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_1_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10460", "MEI_Chutes_Style_1_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_1_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10461", "MEI_Chutes_Style_1_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_1_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10462", "MEI_Chutes_Style_1_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_1_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H7", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10463", "MEI_Chutes_Style_1_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_1_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D7", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10464", "MEI_Chutes_Style_10_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_10_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10465", "MEI_Chutes_Style_10_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_10_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10466", "MEI_Chutes_Style_10_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_10_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E16", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10467", "MEI_Chutes_Style_10_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_10_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10468", "MEI_Chutes_Style_10_Length_hrs", <a><![CDATA[MEI_Chutes_Style_10_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10469", "MEI_Chutes_Style_10_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_10_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C16", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10470", "MEI_Chutes_Style_10_Material_hrs", <a><![CDATA[MEI_Chutes_Style_10_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10471", "MEI_Chutes_Style_10_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_10_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10472", "MEI_Chutes_Style_10_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_10_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10473", "MEI_Chutes_Style_10_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_10_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10474", "MEI_Chutes_Style_10_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_10_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10475", "MEI_Chutes_Style_10_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_10_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H16", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10476", "MEI_Chutes_Style_10_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_10_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D16", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10477", "MEI_Chutes_Style_2_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_2_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10478", "MEI_Chutes_Style_2_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_2_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10479", "MEI_Chutes_Style_2_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_2_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E8", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10480", "MEI_Chutes_Style_2_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_2_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10481", "MEI_Chutes_Style_2_Length_hrs", <a><![CDATA[MEI_Chutes_Style_2_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10482", "MEI_Chutes_Style_2_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_2_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C8", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10483", "MEI_Chutes_Style_2_Material_hrs", <a><![CDATA[MEI_Chutes_Style_2_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10484", "MEI_Chutes_Style_2_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_2_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10485", "MEI_Chutes_Style_2_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_2_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10486", "MEI_Chutes_Style_2_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_2_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10487", "MEI_Chutes_Style_2_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_2_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10488", "MEI_Chutes_Style_2_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_2_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H8", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10489", "MEI_Chutes_Style_2_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_2_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D8", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10490", "MEI_Chutes_Style_3_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_3_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10491", "MEI_Chutes_Style_3_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_3_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10492", "MEI_Chutes_Style_3_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_3_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E9", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10493", "MEI_Chutes_Style_3_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_3_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10494", "MEI_Chutes_Style_3_Length_hrs", <a><![CDATA[MEI_Chutes_Style_3_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10495", "MEI_Chutes_Style_3_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_3_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C9", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10496", "MEI_Chutes_Style_3_Material_hrs", <a><![CDATA[MEI_Chutes_Style_3_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10497", "MEI_Chutes_Style_3_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_3_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10498", "MEI_Chutes_Style_3_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_3_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10499", "MEI_Chutes_Style_3_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_3_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10500", "MEI_Chutes_Style_3_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_3_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10501", "MEI_Chutes_Style_3_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_3_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H9", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10502", "MEI_Chutes_Style_3_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_3_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D9", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10503", "MEI_Chutes_Style_4_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_4_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10504", "MEI_Chutes_Style_4_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_4_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10505", "MEI_Chutes_Style_4_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_4_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E10", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:12 PM")
    AddProperty("10506", "MEI_Chutes_Style_4_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_4_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10507", "MEI_Chutes_Style_4_Length_hrs", <a><![CDATA[MEI_Chutes_Style_4_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10508", "MEI_Chutes_Style_4_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_4_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C10", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10509", "MEI_Chutes_Style_4_Material_hrs", <a><![CDATA[MEI_Chutes_Style_4_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10510", "MEI_Chutes_Style_4_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_4_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10511", "MEI_Chutes_Style_4_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_4_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10512", "MEI_Chutes_Style_4_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_4_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10513", "MEI_Chutes_Style_4_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_4_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10514", "MEI_Chutes_Style_4_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_4_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H10", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10515", "MEI_Chutes_Style_4_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_4_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D10", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10516", "MEI_Chutes_Style_5_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_5_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10517", "MEI_Chutes_Style_5_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_5_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10518", "MEI_Chutes_Style_5_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_5_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E11", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10519", "MEI_Chutes_Style_5_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_5_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10520", "MEI_Chutes_Style_5_Length_hrs", <a><![CDATA[MEI_Chutes_Style_5_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10521", "MEI_Chutes_Style_5_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_5_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C11", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10522", "MEI_Chutes_Style_5_Material_hrs", <a><![CDATA[MEI_Chutes_Style_5_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10523", "MEI_Chutes_Style_5_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_5_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10524", "MEI_Chutes_Style_5_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_5_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10525", "MEI_Chutes_Style_5_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_5_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10526", "MEI_Chutes_Style_5_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_5_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10527", "MEI_Chutes_Style_5_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_5_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H11", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10528", "MEI_Chutes_Style_5_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_5_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D11", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10529", "MEI_Chutes_Style_6_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_6_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10530", "MEI_Chutes_Style_6_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_6_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10531", "MEI_Chutes_Style_6_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_6_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E12", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10532", "MEI_Chutes_Style_6_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_6_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10533", "MEI_Chutes_Style_6_Length_hrs", <a><![CDATA[MEI_Chutes_Style_6_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10534", "MEI_Chutes_Style_6_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_6_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C12", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10535", "MEI_Chutes_Style_6_Material_hrs", <a><![CDATA[MEI_Chutes_Style_6_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10536", "MEI_Chutes_Style_6_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_6_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10537", "MEI_Chutes_Style_6_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_6_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10538", "MEI_Chutes_Style_6_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_6_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10539", "MEI_Chutes_Style_6_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_6_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10540", "MEI_Chutes_Style_6_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_6_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H12", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10541", "MEI_Chutes_Style_6_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_6_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D12", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10542", "MEI_Chutes_Style_7_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_7_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10543", "MEI_Chutes_Style_7_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_7_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10544", "MEI_Chutes_Style_7_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_7_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E13", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10545", "MEI_Chutes_Style_7_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_7_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10546", "MEI_Chutes_Style_7_Length_hrs", <a><![CDATA[MEI_Chutes_Style_7_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10547", "MEI_Chutes_Style_7_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_7_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C13", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10548", "MEI_Chutes_Style_7_Material_hrs", <a><![CDATA[MEI_Chutes_Style_7_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10549", "MEI_Chutes_Style_7_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_7_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10550", "MEI_Chutes_Style_7_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_7_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10551", "MEI_Chutes_Style_7_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_7_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10552", "MEI_Chutes_Style_7_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_7_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10553", "MEI_Chutes_Style_7_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_7_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H13", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10554", "MEI_Chutes_Style_7_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_7_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D13", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10555", "MEI_Chutes_Style_8_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_8_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10556", "MEI_Chutes_Style_8_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_8_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10557", "MEI_Chutes_Style_8_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_8_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E14", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10558", "MEI_Chutes_Style_8_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_8_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10559", "MEI_Chutes_Style_8_Length_hrs", <a><![CDATA[MEI_Chutes_Style_8_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10560", "MEI_Chutes_Style_8_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_8_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C14", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10561", "MEI_Chutes_Style_8_Material_hrs", <a><![CDATA[MEI_Chutes_Style_8_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10562", "MEI_Chutes_Style_8_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_8_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10563", "MEI_Chutes_Style_8_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_8_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10564", "MEI_Chutes_Style_8_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_8_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10565", "MEI_Chutes_Style_8_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_8_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10566", "MEI_Chutes_Style_8_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_8_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H14", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10567", "MEI_Chutes_Style_8_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_8_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D14", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10568", "MEI_Chutes_Style_9_Angle_hrs", <a><![CDATA[MEI_Chutes_Style_9_Angle_hrs]]></a>.Value, "Mech Install^'Chutes'!J15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10569", "MEI_Chutes_Style_9_Angle_of_Curve", <a><![CDATA[MEI_Chutes_Style_9_Angle_of_Curve]]></a>.Value, "Mech Install^'Chutes'!B15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10570", "MEI_Chutes_Style_9_Infeed_Conveyor_Type", <a><![CDATA[MEI_Chutes_Style_9_Infeed_Conveyor_Type]]></a>.Value, "Mech Install^'Chutes'!E15", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10571", "MEI_Chutes_Style_9_Infeed_hrs", <a><![CDATA[MEI_Chutes_Style_9_Infeed_hrs]]></a>.Value, "Mech Install^'Chutes'!M15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10572", "MEI_Chutes_Style_9_Length_hrs", <a><![CDATA[MEI_Chutes_Style_9_Length_hrs]]></a>.Value, "Mech Install^'Chutes'!K15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10573", "MEI_Chutes_Style_9_Length_in_Feet", <a><![CDATA[MEI_Chutes_Style_9_Length_in_Feet]]></a>.Value, "Mech Install^'Chutes'!C15", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10574", "MEI_Chutes_Style_9_Material_hrs", <a><![CDATA[MEI_Chutes_Style_9_Material_hrs]]></a>.Value, "Mech Install^'Chutes'!L15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10575", "MEI_Chutes_Style_9_Merge_hrs", <a><![CDATA[MEI_Chutes_Style_9_Merge_hrs]]></a>.Value, "Mech Install^'Chutes'!N15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10576", "MEI_Chutes_Style_9_Number_of_Merging_Lanes", <a><![CDATA[MEI_Chutes_Style_9_Number_of_Merging_Lanes]]></a>.Value, "Mech Install^'Chutes'!F15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10577", "MEI_Chutes_Style_9_Number_of_Sorting_Lanes", <a><![CDATA[MEI_Chutes_Style_9_Number_of_Sorting_Lanes]]></a>.Value, "Mech Install^'Chutes'!G15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10578", "MEI_Chutes_Style_9_Sort_hrs", <a><![CDATA[MEI_Chutes_Style_9_Sort_hrs]]></a>.Value, "Mech Install^'Chutes'!O15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10579", "MEI_Chutes_Style_9_Total_Hours_per_Chute", <a><![CDATA[MEI_Chutes_Style_9_Total_Hours_per_Chute]]></a>.Value, "Mech Install^'Chutes'!H15", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10580", "MEI_Chutes_Style_9_Type_of_Material", <a><![CDATA[MEI_Chutes_Style_9_Type_of_Material]]></a>.Value, "Mech Install^'Chutes'!D15", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10581", "MEI_Chutes_Styles", <a><![CDATA[MEI_Chutes_Styles]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    AddProperty("10449", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 2:18:13 PM")
    
      AddValidValue("MEI_Chutes_Style_1_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_1_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_1_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_1_Number_of_Merging_Lanes")
    
      AddValidValue("MEI_Chutes_Style_1_Number_of_Sorting_Lanes")
    
      AddValidValue("MEI_Chutes_Style_1_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_10_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_10_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_10_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_10_Number_of_Merging_Lanes")
    
      AddValidValue("MEI_Chutes_Style_10_Number_of_Sorting_Lanes")
    
      AddValidValue("MEI_Chutes_Style_10_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_2_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_2_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_2_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_2_Number_of_Merging_Lanes")
    
      AddValidValue("MEI_Chutes_Style_2_Number_of_Sorting_Lanes")
    
      AddValidValue("MEI_Chutes_Style_2_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_3_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_3_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_3_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_3_Number_of_Merging_Lanes")
    
      AddValidValue("MEI_Chutes_Style_3_Number_of_Sorting_Lanes")
    
      AddValidValue("MEI_Chutes_Style_3_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_4_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_4_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_4_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_4_Number_of_Merging_Lanes")
    
      AddValidValue("MEI_Chutes_Style_4_Number_of_Sorting_Lanes")
    
      AddValidValue("MEI_Chutes_Style_4_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_5_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_5_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_5_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_5_Number_of_Merging_Lanes")
    
      AddValidValue("MEI_Chutes_Style_5_Number_of_Sorting_Lanes")
    
      AddValidValue("MEI_Chutes_Style_5_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_6_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_6_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_6_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_6_Number_of_Merging_Lanes")
    
      AddValidValue("MEI_Chutes_Style_6_Number_of_Sorting_Lanes")
    
      AddValidValue("MEI_Chutes_Style_6_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_7_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_7_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_7_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_7_Number_of_Merging_Lanes")
    
      AddValidValue("MEI_Chutes_Style_7_Number_of_Sorting_Lanes")
    
      AddValidValue("MEI_Chutes_Style_7_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_8_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_8_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_8_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_8_Number_of_Merging_Lanes")
    
      AddValidValue("MEI_Chutes_Style_8_Number_of_Sorting_Lanes")
    
      AddValidValue("MEI_Chutes_Style_8_Type_of_Material")
    
      AddValidValue("MEI_Chutes_Style_9_Angle_of_Curve")
    
      AddValidValue("MEI_Chutes_Style_9_Infeed_Conveyor_Type")
    
      AddValidValue("MEI_Chutes_Style_9_Length_in_Feet")
    
      AddValidValue("MEI_Chutes_Style_9_Number_of_Merging_Lanes")
    
      AddValidValue("MEI_Chutes_Style_9_Number_of_Sorting_Lanes")
    
      AddValidValue("MEI_Chutes_Style_9_Type_of_Material")
    
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
          InitProperty("DisplayName", "10020", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:20:08 PM", "", "In Development",  0,18852)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Angle_hrs", "10021", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18531)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Angle_of_Curve", "10022", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18533)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Infeed_Conveyor_Type", "10023", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18536)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Infeed_hrs", "10024", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18539)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Length_hrs", "10025", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18541)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Length_in_Feet", "10026", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18543)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Material_hrs", "10027", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18546)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Merge_hrs", "10028", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18548)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Number_of_Merging_Lanes", "10029", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18550)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Number_of_Sorting_Lanes", "10030", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18553)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Sort_hrs", "10031", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18556)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Total_Hours_per_Chute", "10032", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18558)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_1_Type_of_Material", "10033", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18560)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Angle_hrs", "10034", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18563)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Angle_of_Curve", "10035", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18565)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Infeed_Conveyor_Type", "10036", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18568)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Infeed_hrs", "10037", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18571)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Length_hrs", "10038", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18573)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Length_in_Feet", "10039", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18575)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Material_hrs", "10040", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18578)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Merge_hrs", "10041", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18580)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Number_of_Merging_Lanes", "10042", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18582)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Number_of_Sorting_Lanes", "10043", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18585)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Sort_hrs", "10044", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18588)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Total_Hours_per_Chute", "10045", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18590)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_10_Type_of_Material", "10046", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18592)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Angle_hrs", "10047", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18595)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Angle_of_Curve", "10048", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18597)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Infeed_Conveyor_Type", "10049", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18600)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Infeed_hrs", "10050", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:13 PM", "", "In Development",  0,18603)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Length_hrs", "10051", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18605)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Length_in_Feet", "10052", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18607)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Material_hrs", "10053", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18610)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Merge_hrs", "10054", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18612)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Number_of_Merging_Lanes", "10055", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18614)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Number_of_Sorting_Lanes", "10056", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18617)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Sort_hrs", "10057", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18620)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Total_Hours_per_Chute", "10058", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18622)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_2_Type_of_Material", "10059", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18624)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Angle_hrs", "10060", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18627)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Angle_of_Curve", "10061", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18629)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Infeed_Conveyor_Type", "10062", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18632)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Infeed_hrs", "10063", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18635)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Length_hrs", "10064", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18637)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Length_in_Feet", "10065", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18639)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Material_hrs", "10066", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18642)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Merge_hrs", "10067", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18644)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Number_of_Merging_Lanes", "10068", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18646)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Number_of_Sorting_Lanes", "10069", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18649)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Sort_hrs", "10070", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18652)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Total_Hours_per_Chute", "10071", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18654)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_3_Type_of_Material", "10072", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18656)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Angle_hrs", "10073", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18659)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Angle_of_Curve", "10074", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18661)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Infeed_Conveyor_Type", "10075", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18664)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Infeed_hrs", "10076", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18667)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Length_hrs", "10077", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18669)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Length_in_Feet", "10078", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18671)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Material_hrs", "10079", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18674)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Merge_hrs", "10080", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18676)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Number_of_Merging_Lanes", "10081", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18678)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Number_of_Sorting_Lanes", "10082", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18681)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Sort_hrs", "10083", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18684)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Total_Hours_per_Chute", "10084", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:14 PM", "", "In Development",  0,18686)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_4_Type_of_Material", "10085", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18688)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Angle_hrs", "10086", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18691)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Angle_of_Curve", "10087", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18693)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Infeed_Conveyor_Type", "10088", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18696)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Infeed_hrs", "10089", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18699)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Length_hrs", "10090", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18701)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Length_in_Feet", "10091", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18703)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Material_hrs", "10092", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18706)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Merge_hrs", "10093", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18708)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Number_of_Merging_Lanes", "10094", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18710)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Number_of_Sorting_Lanes", "10095", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18713)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Sort_hrs", "10096", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18716)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Total_Hours_per_Chute", "10097", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18718)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_5_Type_of_Material", "10098", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18720)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Angle_hrs", "10099", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18723)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Angle_of_Curve", "10100", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18725)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Infeed_Conveyor_Type", "10101", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18728)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Infeed_hrs", "10102", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18731)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Length_hrs", "10103", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18733)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Length_in_Feet", "10104", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18735)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Material_hrs", "10105", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18738)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Merge_hrs", "10106", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18740)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Number_of_Merging_Lanes", "10107", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18742)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Number_of_Sorting_Lanes", "10108", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18745)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Sort_hrs", "10109", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18748)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Total_Hours_per_Chute", "10110", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18750)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_6_Type_of_Material", "10111", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18752)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Angle_hrs", "10112", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18755)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Angle_of_Curve", "10113", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18757)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Infeed_Conveyor_Type", "10114", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18760)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Infeed_hrs", "10115", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18763)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Length_hrs", "10116", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:15 PM", "", "In Development",  0,18765)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Length_in_Feet", "10117", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18767)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Material_hrs", "10118", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18770)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Merge_hrs", "10119", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18772)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Number_of_Merging_Lanes", "10120", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18774)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Number_of_Sorting_Lanes", "10121", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18777)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Sort_hrs", "10122", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18780)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Total_Hours_per_Chute", "10123", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18782)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_7_Type_of_Material", "10124", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18784)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Angle_hrs", "10125", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18787)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Angle_of_Curve", "10126", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18789)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Infeed_Conveyor_Type", "10127", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18792)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Infeed_hrs", "10128", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18795)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Length_hrs", "10129", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18797)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Length_in_Feet", "10130", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18799)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Material_hrs", "10131", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18802)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Merge_hrs", "10132", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18804)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Number_of_Merging_Lanes", "10133", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18806)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Number_of_Sorting_Lanes", "10134", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18809)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Sort_hrs", "10135", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18812)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Total_Hours_per_Chute", "10136", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18814)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_8_Type_of_Material", "10137", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18816)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Angle_hrs", "10138", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18819)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Angle_of_Curve", "10139", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18821)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Infeed_Conveyor_Type", "10140", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18824)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Infeed_hrs", "10141", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18827)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Length_hrs", "10142", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18829)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Length_in_Feet", "10143", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18831)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Material_hrs", "10144", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18834)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Merge_hrs", "10145", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:16 PM", "", "In Development",  0,18836)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Number_of_Merging_Lanes", "10146", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:17 PM", "", "In Development",  0,18838)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Number_of_Sorting_Lanes", "10147", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:17 PM", "", "In Development",  0,18841)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Sort_hrs", "10148", "", "", "Y", "","", 1, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:17 PM", "", "In Development",  0,18844)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Total_Hours_per_Chute", "10149", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:17 PM", "", "In Development",  0,18846)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Style_9_Type_of_Material", "10150", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:17 PM", "", "In Development",  0,18848)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MEI_Chutes_Styles", "10151", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 2:18:17 PM", "", "In Development",  0,18851)
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
          
        InitValidValue("MEI_Chutes_Style_1_Angle_of_Curve_ValidValues", "10022", "-1", 18534)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_1_Infeed_Conveyor_Type_ValidValues", "10023", "-1", 18537)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_1_Length_in_Feet_ValidValues", "10026", "-1", 18544)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_1_Number_of_Merging_Lanes_ValidValues", "10029", "-1", 18551)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_1_Number_of_Sorting_Lanes_ValidValues", "10030", "-1", 18554)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_1_Type_of_Material_ValidValues", "10033", "-1", 18561)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_10_Angle_of_Curve_ValidValues", "10035", "-1", 18566)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_10_Infeed_Conveyor_Type_ValidValues", "10036", "-1", 18569)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_10_Length_in_Feet_ValidValues", "10039", "-1", 18576)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_10_Number_of_Merging_Lanes_ValidValues", "10042", "-1", 18583)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_10_Number_of_Sorting_Lanes_ValidValues", "10043", "-1", 18586)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_10_Type_of_Material_ValidValues", "10046", "-1", 18593)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_2_Angle_of_Curve_ValidValues", "10048", "-1", 18598)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_2_Infeed_Conveyor_Type_ValidValues", "10049", "-1", 18601)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_2_Length_in_Feet_ValidValues", "10052", "-1", 18608)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_2_Number_of_Merging_Lanes_ValidValues", "10055", "-1", 18615)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_2_Number_of_Sorting_Lanes_ValidValues", "10056", "-1", 18618)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_2_Type_of_Material_ValidValues", "10059", "-1", 18625)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_3_Angle_of_Curve_ValidValues", "10061", "-1", 18630)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_3_Infeed_Conveyor_Type_ValidValues", "10062", "-1", 18633)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_3_Length_in_Feet_ValidValues", "10065", "-1", 18640)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_3_Number_of_Merging_Lanes_ValidValues", "10068", "-1", 18647)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_3_Number_of_Sorting_Lanes_ValidValues", "10069", "-1", 18650)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_3_Type_of_Material_ValidValues", "10072", "-1", 18657)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_4_Angle_of_Curve_ValidValues", "10074", "-1", 18662)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_4_Infeed_Conveyor_Type_ValidValues", "10075", "-1", 18665)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_4_Length_in_Feet_ValidValues", "10078", "-1", 18672)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_4_Number_of_Merging_Lanes_ValidValues", "10081", "-1", 18679)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_4_Number_of_Sorting_Lanes_ValidValues", "10082", "-1", 18682)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_4_Type_of_Material_ValidValues", "10085", "-1", 18689)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_5_Angle_of_Curve_ValidValues", "10087", "-1", 18694)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_5_Infeed_Conveyor_Type_ValidValues", "10088", "-1", 18697)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_5_Length_in_Feet_ValidValues", "10091", "-1", 18704)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_5_Number_of_Merging_Lanes_ValidValues", "10094", "-1", 18711)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_5_Number_of_Sorting_Lanes_ValidValues", "10095", "-1", 18714)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_5_Type_of_Material_ValidValues", "10098", "-1", 18721)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_6_Angle_of_Curve_ValidValues", "10100", "-1", 18726)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_6_Infeed_Conveyor_Type_ValidValues", "10101", "-1", 18729)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_6_Length_in_Feet_ValidValues", "10104", "-1", 18736)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_6_Number_of_Merging_Lanes_ValidValues", "10107", "-1", 18743)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_6_Number_of_Sorting_Lanes_ValidValues", "10108", "-1", 18746)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_6_Type_of_Material_ValidValues", "10111", "-1", 18753)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_7_Angle_of_Curve_ValidValues", "10113", "-1", 18758)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_7_Infeed_Conveyor_Type_ValidValues", "10114", "-1", 18761)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_7_Length_in_Feet_ValidValues", "10117", "-1", 18768)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_7_Number_of_Merging_Lanes_ValidValues", "10120", "-1", 18775)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_7_Number_of_Sorting_Lanes_ValidValues", "10121", "-1", 18778)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_7_Type_of_Material_ValidValues", "10124", "-1", 18785)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_8_Angle_of_Curve_ValidValues", "10126", "-1", 18790)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_8_Infeed_Conveyor_Type_ValidValues", "10127", "-1", 18793)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_8_Length_in_Feet_ValidValues", "10130", "-1", 18800)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_8_Number_of_Merging_Lanes_ValidValues", "10133", "-1", 18807)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_8_Number_of_Sorting_Lanes_ValidValues", "10134", "-1", 18810)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_8_Type_of_Material_ValidValues", "10137", "-1", 18817)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_9_Angle_of_Curve_ValidValues", "10139", "-1", 18822)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_9_Infeed_Conveyor_Type_ValidValues", "10140", "-1", 18825)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_9_Length_in_Feet_ValidValues", "10143", "-1", 18832)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_9_Number_of_Merging_Lanes_ValidValues", "10146", "-1", 18839)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_9_Number_of_Sorting_Lanes_ValidValues", "10147", "-1", 18842)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MEI_Chutes_Style_9_Type_of_Material_ValidValues", "10150", "-1", 18849)
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
          Public Function Formula_DisplayName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("DisplayName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10020; TYPE:PF
      Result = "Chute Sytle " & Me.SubpartID
      '   END FORMULA; PROP ID:10020; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_DisplayName", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10021; TYPE:PF
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
      '   END FORMULA; PROP ID:10021; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Angle_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10022; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:10022; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Angle_of_Curve", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10023; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:10023; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10024; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_1_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:10024; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Infeed_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10025; TYPE:PF
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
      '   END FORMULA; PROP ID:10025; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Length_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10026; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:10026; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Length_in_Feet", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10027; TYPE:PF
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
      '   END FORMULA; PROP ID:10027; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Material_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10028; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_1_Number_of_Merging_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10028; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Merge_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10029; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10029; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Number_of_Merging_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10030; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10030; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Number_of_Sorting_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10031; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_1_Number_of_Sorting_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10031; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Sort_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10032; TYPE:PF
      Result = (Me.MEI_Chutes_Style_1_Angle_hrs +
Me.MEI_Chutes_Style_1_Length_hrs +
Me.MEI_Chutes_Style_1_Material_hrs +
Me.MEI_Chutes_Style_1_Infeed_hrs +
Me.MEI_Chutes_Style_1_Merge_hrs +
Me.MEI_Chutes_Style_1_Sort_hrs)
      '   END FORMULA; PROP ID:10032; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Total_Hours_per_Chute", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10033; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:10033; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Type_of_Material", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10034; TYPE:PF
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
      '   END FORMULA; PROP ID:10034; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Angle_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10035; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:10035; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Angle_of_Curve", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10036; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:10036; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10037; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_10_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:10037; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Infeed_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10038; TYPE:PF
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
      '   END FORMULA; PROP ID:10038; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Length_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10039; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:10039; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Length_in_Feet", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10040; TYPE:PF
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
      '   END FORMULA; PROP ID:10040; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Material_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10041; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_10_Number_of_Merging_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10041; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Merge_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10042; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10042; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Number_of_Merging_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10043; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10043; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Number_of_Sorting_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10044; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_10_Number_of_Sorting_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10044; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Sort_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10045; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10045; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Total_Hours_per_Chute", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10046; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:10046; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Type_of_Material", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10047; TYPE:PF
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
      '   END FORMULA; PROP ID:10047; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Angle_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10048; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:10048; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Angle_of_Curve", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10049; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:10049; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10050; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_2_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:10050; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Infeed_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10051; TYPE:PF
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
      '   END FORMULA; PROP ID:10051; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Length_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10052; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:10052; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Length_in_Feet", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10053; TYPE:PF
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
      '   END FORMULA; PROP ID:10053; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Material_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10054; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_2_Number_of_Merging_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10054; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Merge_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10055; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10055; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Number_of_Merging_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10056; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10056; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Number_of_Sorting_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10057; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_2_Number_of_Sorting_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10057; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Sort_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10058; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10058; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Total_Hours_per_Chute", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10059; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:10059; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Type_of_Material", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10060; TYPE:PF
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
      '   END FORMULA; PROP ID:10060; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Angle_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10061; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:10061; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Angle_of_Curve", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10062; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:10062; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10063; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_3_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:10063; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Infeed_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10064; TYPE:PF
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
      '   END FORMULA; PROP ID:10064; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Length_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10065; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:10065; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Length_in_Feet", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10066; TYPE:PF
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
      '   END FORMULA; PROP ID:10066; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Material_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10067; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_3_Number_of_Merging_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10067; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Merge_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10068; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10068; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Number_of_Merging_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10069; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10069; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Number_of_Sorting_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10070; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_3_Number_of_Sorting_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10070; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Sort_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10071; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10071; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Total_Hours_per_Chute", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10072; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:10072; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Type_of_Material", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10073; TYPE:PF
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
      '   END FORMULA; PROP ID:10073; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Angle_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10074; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:10074; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Angle_of_Curve", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10075; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:10075; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10076; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_4_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:10076; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Infeed_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10077; TYPE:PF
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
      '   END FORMULA; PROP ID:10077; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Length_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10078; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:10078; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Length_in_Feet", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10079; TYPE:PF
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
      '   END FORMULA; PROP ID:10079; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Material_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10080; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_4_Number_of_Merging_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10080; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Merge_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10081; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10081; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Number_of_Merging_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10082; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10082; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Number_of_Sorting_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10083; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_4_Number_of_Sorting_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10083; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Sort_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10084; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10084; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Total_Hours_per_Chute", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10085; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:10085; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Type_of_Material", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10086; TYPE:PF
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
      '   END FORMULA; PROP ID:10086; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Angle_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10087; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:10087; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Angle_of_Curve", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10088; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:10088; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10089; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_5_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:10089; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Infeed_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10090; TYPE:PF
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
      '   END FORMULA; PROP ID:10090; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Length_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10091; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:10091; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Length_in_Feet", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10092; TYPE:PF
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
      '   END FORMULA; PROP ID:10092; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Material_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10093; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_5_Number_of_Merging_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10093; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Merge_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10094; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10094; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Number_of_Merging_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10095; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10095; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Number_of_Sorting_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10096; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_5_Number_of_Sorting_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10096; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Sort_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10097; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10097; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Total_Hours_per_Chute", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10098; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:10098; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Type_of_Material", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10099; TYPE:PF
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
      '   END FORMULA; PROP ID:10099; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Angle_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10100; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:10100; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Angle_of_Curve", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10101; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:10101; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10102; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_6_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:10102; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Infeed_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10103; TYPE:PF
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
      '   END FORMULA; PROP ID:10103; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Length_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10104; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:10104; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Length_in_Feet", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10105; TYPE:PF
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
      '   END FORMULA; PROP ID:10105; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Material_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10106; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_6_Number_of_Merging_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10106; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Merge_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10107; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10107; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Number_of_Merging_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10108; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10108; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Number_of_Sorting_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10109; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_6_Number_of_Sorting_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10109; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Sort_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10110; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10110; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Total_Hours_per_Chute", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10111; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:10111; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Type_of_Material", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10112; TYPE:PF
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
      '   END FORMULA; PROP ID:10112; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Angle_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10113; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:10113; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Angle_of_Curve", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10114; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:10114; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10115; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_7_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:10115; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Infeed_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10116; TYPE:PF
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
      '   END FORMULA; PROP ID:10116; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Length_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10117; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:10117; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Length_in_Feet", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10118; TYPE:PF
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
      '   END FORMULA; PROP ID:10118; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Material_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10119; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_7_Number_of_Merging_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10119; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Merge_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10120; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10120; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Number_of_Merging_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10121; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10121; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Number_of_Sorting_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10122; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_7_Number_of_Sorting_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10122; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Sort_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10123; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10123; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Total_Hours_per_Chute", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10124; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:10124; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Type_of_Material", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10125; TYPE:PF
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
      '   END FORMULA; PROP ID:10125; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Angle_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10126; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:10126; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Angle_of_Curve", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10127; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:10127; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10128; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_8_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:10128; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Infeed_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10129; TYPE:PF
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
      '   END FORMULA; PROP ID:10129; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Length_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10130; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:10130; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Length_in_Feet", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10131; TYPE:PF
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
      '   END FORMULA; PROP ID:10131; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Material_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10132; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_8_Number_of_Merging_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10132; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Merge_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10133; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10133; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Number_of_Merging_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10134; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10134; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Number_of_Sorting_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10135; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_8_Number_of_Sorting_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10135; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Sort_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10136; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10136; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Total_Hours_per_Chute", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10137; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:10137; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Type_of_Material", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10138; TYPE:PF
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
      '   END FORMULA; PROP ID:10138; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Angle_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10139; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:10139; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Angle_of_Curve", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10140; TYPE:PF
      Result = "Conveyor"
      '   END FORMULA; PROP ID:10140; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10141; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_9_Infeed_Conveyor_Type
 Case "Conveyor"
Result = 0
 Case "Other(Ask)"
Result = 0
 Case "TTCB"
Result = 0
End Select
      '   END FORMULA; PROP ID:10141; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Infeed_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10142; TYPE:PF
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
      '   END FORMULA; PROP ID:10142; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Length_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10143; TYPE:PF
      Result = "0 to 2 Ft 11 Inch"
      '   END FORMULA; PROP ID:10143; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Length_in_Feet", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10144; TYPE:PF
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
      '   END FORMULA; PROP ID:10144; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Material_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10145; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_9_Number_of_Merging_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10145; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Merge_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10146; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10146; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Number_of_Merging_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10147; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10147; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Number_of_Sorting_Lanes", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10148; TYPE:PF
      'If in future, Hours Values will get changed then result needs to updates as per leatest hours values below.

Select Case Me.MEI_Chutes_Style_9_Number_of_Sorting_Lanes
Case 0
	Result = 0
Case 1
	Result = 0
Case 2
	Result = 10
Case 3
	Result = 20
Case 4
	Result = 30
End Select
      '   END FORMULA; PROP ID:10148; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Sort_hrs", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10149; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:10149; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Total_Hours_per_Chute", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10150; TYPE:PF
      Result = "UHMW"
      '   END FORMULA; PROP ID:10150; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Type_of_Material", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MEI_Chutes_Styles() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Styles").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10151; TYPE:PF
      Result = "Chutes Style - " & Me.SubpartID
      '   END FORMULA; PROP ID:10151; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Styles", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10021; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10021; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Angle_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10022; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10022; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Angle_of_Curve_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10023; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10023; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10024; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10024; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Infeed_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10025; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10025; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Length_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10026; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10026; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Length_in_Feet_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10027; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10027; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Material_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10028; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10028; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Merge_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10029; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10029; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Number_of_Merging_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10030; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10030; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10031; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10031; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Sort_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10032; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10032; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Total_Hours_per_Chute_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10033; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10033; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Type_of_Material_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10034; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10034; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Angle_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10035; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10035; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Angle_of_Curve_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10036; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10036; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10037; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10037; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Infeed_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10038; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10038; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Length_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10039; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10039; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Length_in_Feet_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10040; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10040; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Material_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10041; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10041; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Merge_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10042; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10042; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Number_of_Merging_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10043; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10043; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10044; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10044; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Sort_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10045; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10045; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Total_Hours_per_Chute_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10046; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10046; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Type_of_Material_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10047; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10047; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Angle_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10048; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10048; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Angle_of_Curve_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10049; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10049; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10050; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10050; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Infeed_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10051; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10051; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Length_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10052; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10052; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Length_in_Feet_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10053; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10053; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Material_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10054; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10054; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Merge_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10055; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10055; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Number_of_Merging_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10056; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10056; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10057; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10057; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Sort_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10058; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10058; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Total_Hours_per_Chute_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10059; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10059; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Type_of_Material_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10060; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10060; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Angle_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10061; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10061; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Angle_of_Curve_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10062; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10062; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10063; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10063; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Infeed_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10064; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10064; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Length_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10065; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10065; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Length_in_Feet_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10066; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10066; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Material_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10067; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10067; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Merge_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10068; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10068; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Number_of_Merging_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10069; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10069; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10070; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10070; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Sort_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10071; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10071; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Total_Hours_per_Chute_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10072; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10072; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Type_of_Material_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10073; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10073; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Angle_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10074; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10074; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Angle_of_Curve_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10075; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10075; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10076; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10076; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Infeed_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10077; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10077; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Length_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10078; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10078; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Length_in_Feet_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10079; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10079; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Material_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10080; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10080; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Merge_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10081; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10081; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Number_of_Merging_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10082; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10082; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10083; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10083; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Sort_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10084; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10084; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Total_Hours_per_Chute_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10085; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10085; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Type_of_Material_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10086; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10086; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Angle_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10087; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10087; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Angle_of_Curve_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10088; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10088; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10089; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10089; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Infeed_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10090; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10090; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Length_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10091; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10091; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Length_in_Feet_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10092; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10092; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Material_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10093; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10093; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Merge_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10094; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10094; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Number_of_Merging_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10095; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10095; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10096; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10096; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Sort_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10097; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10097; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Total_Hours_per_Chute_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10098; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10098; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Type_of_Material_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10099; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10099; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Angle_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10100; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10100; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Angle_of_Curve_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10101; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10101; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10102; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10102; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Infeed_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10103; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10103; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Length_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10104; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10104; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Length_in_Feet_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10105; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10105; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Material_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10106; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10106; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Merge_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10107; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10107; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Number_of_Merging_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10108; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10108; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10109; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10109; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Sort_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10110; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10110; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Total_Hours_per_Chute_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10111; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10111; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Type_of_Material_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10112; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10112; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Angle_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10113; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10113; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Angle_of_Curve_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10114; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10114; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10115; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10115; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Infeed_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10116; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10116; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Length_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10117; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10117; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Length_in_Feet_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10118; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10118; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Material_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10119; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10119; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Merge_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10120; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10120; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Number_of_Merging_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10121; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10121; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10122; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10122; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Sort_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10123; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10123; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Total_Hours_per_Chute_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10124; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10124; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Type_of_Material_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10125; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10125; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Angle_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10126; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10126; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Angle_of_Curve_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10127; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10127; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10128; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10128; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Infeed_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10129; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10129; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Length_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10130; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10130; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Length_in_Feet_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10131; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10131; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Material_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10132; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10132; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Merge_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10133; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10133; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Number_of_Merging_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10134; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10134; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10135; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10135; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Sort_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10136; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10136; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Total_Hours_per_Chute_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10137; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10137; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Type_of_Material_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10138; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10138; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Angle_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10139; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10139; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Angle_of_Curve_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10140; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10140; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10141; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10141; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Infeed_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10142; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10142; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Length_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10143; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10143; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Length_in_Feet_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10144; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10144; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Material_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10145; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10145; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Merge_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10146; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10146; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Number_of_Merging_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10147; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10147; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Number_of_Sorting_Lanes_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10148; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10148; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Sort_hrs_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10149; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10149; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Total_Hours_per_Chute_CustomCheck", ex.Message)
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
              '   BEGIN FORMULA; PROP ID:10150; TYPE:CC
              'Dim MyProp As PropertySF = Me.Properties("Replace Your Property Name")
'Choices For Severity ARE: VIA_ERROR, VIA_WARNING
'If MyProp.IsInvalid() Then 
' RS_CustomReportError(Me, PropertyName, VIA_ERROR/VIA_WARNING, "Replace Your Error Message")
'End If
              '   END FORMULA; PROP ID:10150; TYPE:CC
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Type_of_Material_CustomCheck", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Me.Properties("MEI_Chutes_Style_9_Type_of_Material").ErrorReporting
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_1_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_10_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_2_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_3_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_4_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_5_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_6_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_7_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_8_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Type_of_Material_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Angle_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Angle_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Angle_of_Curve_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Angle_of_Curve_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Infeed_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Infeed_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Length_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Length_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Length_in_Feet_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Length_in_Feet_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Material_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Material_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Merge_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Merge_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Number_of_Merging_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Number_of_Merging_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Number_of_Sorting_Lanes_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Number_of_Sorting_Lanes_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Sort_hrs_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Sort_hrs_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Total_Hours_per_Chute_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Total_Hours_per_Chute_CustomCheckDependnacy", ex.Message)
          End Try
          End Function
        
          Public Function Formula_MEI_Chutes_Style_9_Type_of_Material_CustomCheckDependnacy() as Boolean
          Try
          Return True
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Type_of_Material_CustomCheckDependnacy", ex.Message)
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
      Public Function Formula_MEI_Chutes_Styles_HIDE_CALCULATED_VALUE() as Boolean
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
      Return False
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
      Public Function Formula_MEI_Chutes_Styles_USERCHANGE() as Boolean
      Return False
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
      '   BEGIN FORMULA; PROP ID:10022; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:10022; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Angle_of_Curve_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10023; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:10023; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Infeed_Conveyor_Type_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10026; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:10026; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Number_of_Merging_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10029; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Merging_lanes]", "[CAE_MEI_Merging_lanes]", "[CAE_MEI_Merging_lanes]", " ORDER BY [CAE_MEI_Merging_lanes_ID]")
      '   END FORMULA; PROP ID:10029; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Number_of_Merging_Lanes_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_1_Number_of_Sorting_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_1_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10030; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", " ORDER BY [CAE_MEI_Sorting_Lanes_ID]")
      '   END FORMULA; PROP ID:10030; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Number_of_Sorting_Lanes_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10033; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:10033; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_1_Type_of_Material_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10035; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:10035; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Angle_of_Curve_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10036; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:10036; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Infeed_Conveyor_Type_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10039; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:10039; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Number_of_Merging_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10042; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Merging_lanes]", "[CAE_MEI_Merging_lanes]", "[CAE_MEI_Merging_lanes]", " ORDER BY [CAE_MEI_Merging_lanes_ID]")
      '   END FORMULA; PROP ID:10042; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Number_of_Merging_Lanes_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_10_Number_of_Sorting_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_10_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10043; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", " ORDER BY [CAE_MEI_Sorting_Lanes_ID]")
      '   END FORMULA; PROP ID:10043; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Number_of_Sorting_Lanes_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10046; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:10046; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_10_Type_of_Material_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10048; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:10048; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Angle_of_Curve_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10049; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:10049; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Infeed_Conveyor_Type_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10052; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:10052; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Number_of_Merging_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10055; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Merging_lanes]", "[CAE_MEI_Merging_lanes]", "[CAE_MEI_Merging_lanes]", " ORDER BY [CAE_MEI_Merging_lanes_ID]")
      '   END FORMULA; PROP ID:10055; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Number_of_Merging_Lanes_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_2_Number_of_Sorting_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_2_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10056; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", " ORDER BY [CAE_MEI_Sorting_Lanes_ID]")
      '   END FORMULA; PROP ID:10056; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Number_of_Sorting_Lanes_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10059; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:10059; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_2_Type_of_Material_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10061; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:10061; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Angle_of_Curve_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10062; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:10062; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Infeed_Conveyor_Type_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10065; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:10065; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Number_of_Merging_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10068; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Merging_lanes]", "[CAE_MEI_Merging_lanes]", "[CAE_MEI_Merging_lanes]", " ORDER BY [CAE_MEI_Merging_lanes_ID]")
      '   END FORMULA; PROP ID:10068; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Number_of_Merging_Lanes_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_3_Number_of_Sorting_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_3_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10069; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", " ORDER BY [CAE_MEI_Sorting_Lanes_ID]")
      '   END FORMULA; PROP ID:10069; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Number_of_Sorting_Lanes_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10072; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:10072; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_3_Type_of_Material_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10074; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:10074; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Angle_of_Curve_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10075; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:10075; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Infeed_Conveyor_Type_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10078; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:10078; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Number_of_Merging_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10081; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Merging_lanes]", "[CAE_MEI_Merging_lanes]", "[CAE_MEI_Merging_lanes]", " ORDER BY [CAE_MEI_Merging_lanes_ID]")
      '   END FORMULA; PROP ID:10081; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Number_of_Merging_Lanes_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_4_Number_of_Sorting_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_4_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10082; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", " ORDER BY [CAE_MEI_Sorting_Lanes_ID]")
      '   END FORMULA; PROP ID:10082; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Number_of_Sorting_Lanes_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10085; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:10085; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_4_Type_of_Material_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10087; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:10087; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Angle_of_Curve_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10088; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:10088; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Infeed_Conveyor_Type_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10091; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:10091; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Number_of_Merging_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10094; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Merging_lanes]", "[CAE_MEI_Merging_lanes]", "[CAE_MEI_Merging_lanes]", " ORDER BY [CAE_MEI_Merging_lanes_ID]")
      '   END FORMULA; PROP ID:10094; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Number_of_Merging_Lanes_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_5_Number_of_Sorting_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_5_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10095; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", " ORDER BY [CAE_MEI_Sorting_Lanes_ID]")
      '   END FORMULA; PROP ID:10095; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Number_of_Sorting_Lanes_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10098; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:10098; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_5_Type_of_Material_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10100; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:10100; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Angle_of_Curve_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10101; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:10101; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Infeed_Conveyor_Type_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10104; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:10104; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Number_of_Merging_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10107; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Merging_lanes]", "[CAE_MEI_Merging_lanes]", "[CAE_MEI_Merging_lanes]", " ORDER BY [CAE_MEI_Merging_lanes_ID]")
      '   END FORMULA; PROP ID:10107; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Number_of_Merging_Lanes_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_6_Number_of_Sorting_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_6_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10108; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", " ORDER BY [CAE_MEI_Sorting_Lanes_ID]")
      '   END FORMULA; PROP ID:10108; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Number_of_Sorting_Lanes_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10111; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:10111; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_6_Type_of_Material_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10113; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:10113; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Angle_of_Curve_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10114; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:10114; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Infeed_Conveyor_Type_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10117; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:10117; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Number_of_Merging_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10120; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Merging_lanes]", "[CAE_MEI_Merging_lanes]", "[CAE_MEI_Merging_lanes]", " ORDER BY [CAE_MEI_Merging_lanes_ID]")
      '   END FORMULA; PROP ID:10120; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Number_of_Merging_Lanes_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_7_Number_of_Sorting_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_7_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10121; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", " ORDER BY [CAE_MEI_Sorting_Lanes_ID]")
      '   END FORMULA; PROP ID:10121; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Number_of_Sorting_Lanes_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10124; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:10124; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_7_Type_of_Material_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10126; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:10126; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Angle_of_Curve_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10127; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:10127; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Infeed_Conveyor_Type_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10130; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:10130; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Number_of_Merging_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10133; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Merging_lanes]", "[CAE_MEI_Merging_lanes]", "[CAE_MEI_Merging_lanes]", " ORDER BY [CAE_MEI_Merging_lanes_ID]")
      '   END FORMULA; PROP ID:10133; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Number_of_Merging_Lanes_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_8_Number_of_Sorting_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_8_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10134; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", " ORDER BY [CAE_MEI_Sorting_Lanes_ID]")
      '   END FORMULA; PROP ID:10134; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Number_of_Sorting_Lanes_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10137; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:10137; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_8_Type_of_Material_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10139; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", "[Chutes_Curve_Angles]", " ORDER BY [CAE_MEI_Chutes_Curve_Angles_ID]")
      '   END FORMULA; PROP ID:10139; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Angle_of_Curve_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10140; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Infeed_Type]", "[CAE_MEI_Infeed_Type_Available]", "[CAE_MEI_Infeed_Type_Available]", " ORDER BY [CAE_MEI_Infeed_Type_ID]")
      '   END FORMULA; PROP ID:10140; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Infeed_Conveyor_Type_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10143; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Length]", "[Length]", "[Length]", " ORDER BY [CAE_MEI_Chutes_Length_ID]")
      '   END FORMULA; PROP ID:10143; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Length_in_Feet_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Number_of_Merging_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Number_of_Merging_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10146; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Merging_lanes]", "[CAE_MEI_Merging_lanes]", "[CAE_MEI_Merging_lanes]", " ORDER BY [CAE_MEI_Merging_lanes_ID]")
      '   END FORMULA; PROP ID:10146; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Number_of_Merging_Lanes_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MEI_Chutes_Style_9_Number_of_Sorting_Lanes_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MEI_Chutes_Style_9_Number_of_Sorting_Lanes").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10147; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", "[CAE_MEI_Sorting_Lanes]", " ORDER BY [CAE_MEI_Sorting_Lanes_ID]")
      '   END FORMULA; PROP ID:10147; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Number_of_Sorting_Lanes_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10150; TYPE:VV
      Result = MakeValidValueKeyFromDatabase("[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", "[CAE_MEI_Chutes_Materials]", " ORDER BY [CAE_MEI_Chutes_Materials_ID]")
      '   END FORMULA; PROP ID:10150; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Chute.Formula_MEI_Chutes_Style_9_Type_of_Material_ValidValues", ex.Message)
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

  