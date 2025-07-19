Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_APC_MDR
'$ GenerateDate: 07/19/2025 12:56:59

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

    Public Class [CAE_APC_MDR]
    
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

    Private this as CAE_APC_MDR = me

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
    
          Public Property [Gen_Sorter_Type]() As String
      Get
      Return Properties("Gen_Sorter_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Gen_Sorter_Type").CalculatedValue = Value
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
    
          Public Property [MTBH_Height_Average_IN]() As Double
      Get
      Return Properties("MTBH_Height_Average_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Height_Average_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Height_Average_User]() As Double
      Get
      Return Properties("MTBH_Height_Average_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Height_Average_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Height_Average_User_UOM]() As String
      Get
      Return Properties("MTBH_Height_Average_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("MTBH_Height_Average_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Height_Maximum_IN]() As Double
      Get
      Return Properties("MTBH_Height_Maximum_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Height_Maximum_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Height_Maximum_User]() As Double
      Get
      Return Properties("MTBH_Height_Maximum_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Height_Maximum_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Height_Maximum_User_Max_Value]() As Double
      Get
      Return Properties("MTBH_Height_Maximum_User_Max_Value").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Height_Maximum_User_Max_Value").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Height_Maximum_User_UOM]() As String
      Get
      Return Properties("MTBH_Height_Maximum_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("MTBH_Height_Maximum_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Height_Minimum_IN]() As Double
      Get
      Return Properties("MTBH_Height_Minimum_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Height_Minimum_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Height_Minimum_User]() As Double
      Get
      Return Properties("MTBH_Height_Minimum_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Height_Minimum_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Height_Minimum_User_Min_Value]() As Double
      Get
      Return Properties("MTBH_Height_Minimum_User_Min_Value").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Height_Minimum_User_Min_Value").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Height_Minimum_User_UOM]() As String
      Get
      Return Properties("MTBH_Height_Minimum_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("MTBH_Height_Minimum_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Length_Average_IN]() As Double
      Get
      Return Properties("MTBH_Length_Average_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Length_Average_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Length_Average_User]() As Double
      Get
      Return Properties("MTBH_Length_Average_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Length_Average_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Length_Average_User_UOM]() As String
      Get
      Return Properties("MTBH_Length_Average_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("MTBH_Length_Average_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Length_Maximum_IN]() As Double
      Get
      Return Properties("MTBH_Length_Maximum_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Length_Maximum_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Length_Maximum_User]() As Double
      Get
      Return Properties("MTBH_Length_Maximum_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Length_Maximum_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Length_Maximum_User_Max_Value]() As Double
      Get
      Return Properties("MTBH_Length_Maximum_User_Max_Value").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Length_Maximum_User_Max_Value").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Length_Maximum_User_UOM]() As String
      Get
      Return Properties("MTBH_Length_Maximum_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("MTBH_Length_Maximum_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Length_Minimum_IN]() As Double
      Get
      Return Properties("MTBH_Length_Minimum_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Length_Minimum_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Length_Minimum_User]() As Double
      Get
      Return Properties("MTBH_Length_Minimum_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Length_Minimum_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Length_Minimum_User_Min_Value]() As Double
      Get
      Return Properties("MTBH_Length_Minimum_User_Min_Value").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Length_Minimum_User_Min_Value").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Length_Minimum_User_UOM]() As String
      Get
      Return Properties("MTBH_Length_Minimum_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("MTBH_Length_Minimum_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Use_Local]() As String
      Get
      Return Properties("MTBH_Use_Local").Value
      End Get
      Set(ByVal Value As String)
      Properties("MTBH_Use_Local").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Weight_Average_LBS]() As Double
      Get
      Return Properties("MTBH_Weight_Average_LBS").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Weight_Average_LBS").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Weight_Average_User]() As Double
      Get
      Return Properties("MTBH_Weight_Average_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Weight_Average_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Weight_Average_User_UOM]() As String
      Get
      Return Properties("MTBH_Weight_Average_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("MTBH_Weight_Average_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Weight_Maximum_LBS]() As Double
      Get
      Return Properties("MTBH_Weight_Maximum_LBS").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Weight_Maximum_LBS").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Weight_Maximum_User]() As Double
      Get
      Return Properties("MTBH_Weight_Maximum_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Weight_Maximum_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Weight_Maximum_User_Max_Value]() As Double
      Get
      Return Properties("MTBH_Weight_Maximum_User_Max_Value").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Weight_Maximum_User_Max_Value").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Weight_Maximum_User_UOM]() As String
      Get
      Return Properties("MTBH_Weight_Maximum_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("MTBH_Weight_Maximum_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Weight_Minimum_LBS]() As Double
      Get
      Return Properties("MTBH_Weight_Minimum_LBS").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Weight_Minimum_LBS").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Weight_Minimum_User]() As Double
      Get
      Return Properties("MTBH_Weight_Minimum_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Weight_Minimum_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Weight_Minimum_User_Min_Value]() As Double
      Get
      Return Properties("MTBH_Weight_Minimum_User_Min_Value").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Weight_Minimum_User_Min_Value").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Weight_Minimum_User_UOM]() As String
      Get
      Return Properties("MTBH_Weight_Minimum_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("MTBH_Weight_Minimum_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Width_Average_IN]() As Double
      Get
      Return Properties("MTBH_Width_Average_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Width_Average_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Width_Average_User]() As Double
      Get
      Return Properties("MTBH_Width_Average_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Width_Average_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Width_Average_User_UOM]() As String
      Get
      Return Properties("MTBH_Width_Average_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("MTBH_Width_Average_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Width_Maximum_IN]() As Double
      Get
      Return Properties("MTBH_Width_Maximum_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Width_Maximum_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Width_Maximum_User]() As Double
      Get
      Return Properties("MTBH_Width_Maximum_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Width_Maximum_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Width_Maximum_User_Max_Value]() As Double
      Get
      Return Properties("MTBH_Width_Maximum_User_Max_Value").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Width_Maximum_User_Max_Value").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Width_Maximum_User_UOM]() As String
      Get
      Return Properties("MTBH_Width_Maximum_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("MTBH_Width_Maximum_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Width_Minimum_IN]() As Double
      Get
      Return Properties("MTBH_Width_Minimum_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Width_Minimum_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Width_Minimum_User]() As Double
      Get
      Return Properties("MTBH_Width_Minimum_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Width_Minimum_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Width_Minimum_User_Min_Value]() As Double
      Get
      Return Properties("MTBH_Width_Minimum_User_Min_Value").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Width_Minimum_User_Min_Value").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MTBH_Width_Minimum_User_UOM]() As String
      Get
      Return Properties("MTBH_Width_Minimum_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("MTBH_Width_Minimum_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Height_Max_User_UOM]() As String
      Get
      Return Properties("Size_Limits_Height_Max_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Size_Limits_Height_Max_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Height_Min_User_UOM]() As String
      Get
      Return Properties("Size_Limits_Height_Min_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Size_Limits_Height_Min_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Length_Max_User]() As Double
      Get
      Return Properties("Size_Limits_Length_Max_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Size_Limits_Length_Max_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Length_Max_User_UOM]() As String
      Get
      Return Properties("Size_Limits_Length_Max_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Size_Limits_Length_Max_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Length_Min_User]() As Double
      Get
      Return Properties("Size_Limits_Length_Min_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Size_Limits_Length_Min_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Length_Min_User_UOM]() As String
      Get
      Return Properties("Size_Limits_Length_Min_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Size_Limits_Length_Min_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Weight_Max_User]() As Double
      Get
      Return Properties("Size_Limits_Weight_Max_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Size_Limits_Weight_Max_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Weight_Max_User_UOM]() As String
      Get
      Return Properties("Size_Limits_Weight_Max_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Size_Limits_Weight_Max_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Weight_Min_User]() As Double
      Get
      Return Properties("Size_Limits_Weight_Min_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Size_Limits_Weight_Min_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Weight_Min_User_UOM]() As String
      Get
      Return Properties("Size_Limits_Weight_Min_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Size_Limits_Weight_Min_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Width_Max_User]() As Double
      Get
      Return Properties("Size_Limits_Width_Max_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Size_Limits_Width_Max_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Width_Max_User_UOM]() As String
      Get
      Return Properties("Size_Limits_Width_Max_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Size_Limits_Width_Max_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Width_Min_User]() As Double
      Get
      Return Properties("Size_Limits_Width_Min_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Size_Limits_Width_Min_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Width_Min_User_UOM]() As String
      Get
      Return Properties("Size_Limits_Width_Min_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Size_Limits_Width_Min_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Length_Max_IN]() As Double
      Get
      Return Properties("Size_Limits_Length_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Size_Limits_Length_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Length_Min_IN]() As Double
      Get
      Return Properties("Size_Limits_Length_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Size_Limits_Length_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Weight_Max_LB]() As Double
      Get
      Return Properties("Size_Limits_Weight_Max_LB").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Size_Limits_Weight_Max_LB").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Weight_Min_LB]() As Double
      Get
      Return Properties("Size_Limits_Weight_Min_LB").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Size_Limits_Weight_Min_LB").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Width_Max_IN]() As Double
      Get
      Return Properties("Size_Limits_Width_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Size_Limits_Width_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Size_Limits_Width_Min_IN]() As Double
      Get
      Return Properties("Size_Limits_Width_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Size_Limits_Width_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Char_Divert_Angle]() As Double
      Get
      Return Properties("Sort_Char_Divert_Angle").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sort_Char_Divert_Angle").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Char_Max_Speed_FPM]() As Double
      Get
      Return Properties("Sort_Char_Max_Speed_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sort_Char_Max_Speed_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Char_Max_Speed_User]() As Double
      Get
      Return Properties("Sort_Char_Max_Speed_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sort_Char_Max_Speed_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Char_Max_Speed_User_UOM]() As String
      Get
      Return Properties("Sort_Char_Max_Speed_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sort_Char_Max_Speed_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Char_Min_Operating_Temp_F]() As Double
      Get
      Return Properties("Sort_Char_Min_Operating_Temp_F").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sort_Char_Min_Operating_Temp_F").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Char_Min_Operating_Temp_User]() As Double
      Get
      Return Properties("Sort_Char_Min_Operating_Temp_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sort_Char_Min_Operating_Temp_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Char_Min_Operating_Temp_User_UOM]() As String
      Get
      Return Properties("Sort_Char_Min_Operating_Temp_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sort_Char_Min_Operating_Temp_User_UOM").CalculatedValue = Value
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
    InitPart("CAE_APC_MDR", <a><![CDATA[CAE_APC_MDR]]></a>.Value, 439, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H602502", "07/18/2025 20:56:10")
    AddProperty("10697", "Gen_Sorter_Type", <a><![CDATA[Gen_Sorter_Type]]></a>.Value, "AppCalc^'MDR Sort'!C17", "String","","AppCalc_MDR","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 4:23:00 PM")
    AddProperty("10703", "User_UOM_System", <a><![CDATA[User_UOM_System]]></a>.Value, "", "String","","AppCalc_MDR","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 6:20:27 PM")
    AddProperty("10729", "MTBH_Height_Average_IN", <a><![CDATA[MTBH_Height_Average_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:42:16 PM")
    AddProperty("10730", "MTBH_Height_Average_User", <a><![CDATA[MTBH_Height_Average_User]]></a>.Value, "AppCalc^'Belted PandA'!H33", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:50:17 PM")
    AddProperty("10731", "MTBH_Height_Average_User_UOM", <a><![CDATA[MTBH_Height_Average_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:42:33 PM")
    AddProperty("10732", "MTBH_Height_Maximum_IN", <a><![CDATA[MTBH_Height_Maximum_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:42:25 PM")
    AddProperty("10733", "MTBH_Height_Maximum_User", <a><![CDATA[MTBH_Height_Maximum_User]]></a>.Value, "AppCalc^'Belted PandA'!H48", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:50:58 PM")
    AddProperty("10734", "MTBH_Height_Maximum_User_Max_Value", <a><![CDATA[MTBH_Height_Maximum_User_Max_Value]]></a>.Value, "", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:43:09 PM")
    AddProperty("10735", "MTBH_Height_Maximum_User_UOM", <a><![CDATA[MTBH_Height_Maximum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:43:17 PM")
    AddProperty("10736", "MTBH_Height_Minimum_IN", <a><![CDATA[MTBH_Height_Minimum_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:43:28 PM")
    AddProperty("10737", "MTBH_Height_Minimum_User", <a><![CDATA[MTBH_Height_Minimum_User]]></a>.Value, "AppCalc^'Belted PandA'!H31", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:51:53 PM")
    AddProperty("10738", "MTBH_Height_Minimum_User_Min_Value", <a><![CDATA[MTBH_Height_Minimum_User_Min_Value]]></a>.Value, "", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:44:02 PM")
    AddProperty("10739", "MTBH_Height_Minimum_User_UOM", <a><![CDATA[MTBH_Height_Minimum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:44:10 PM")
    AddProperty("10740", "MTBH_Length_Average_IN", <a><![CDATA[MTBH_Length_Average_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:44:18 PM")
    AddProperty("10741", "MTBH_Length_Average_User", <a><![CDATA[MTBH_Length_Average_User]]></a>.Value, "AppCalc^'Belted PandA'!D33", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:52:14 PM")
    AddProperty("10742", "MTBH_Length_Average_User_UOM", <a><![CDATA[MTBH_Length_Average_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:44:33 PM")
    AddProperty("10743", "MTBH_Length_Maximum_IN", <a><![CDATA[MTBH_Length_Maximum_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:44:51 PM")
    AddProperty("10744", "MTBH_Length_Maximum_User", <a><![CDATA[MTBH_Length_Maximum_User]]></a>.Value, "AppCalc^'Belted PandA'!D32", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:53:01 PM")
    AddProperty("10745", "MTBH_Length_Maximum_User_Max_Value", <a><![CDATA[MTBH_Length_Maximum_User_Max_Value]]></a>.Value, "", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:45:13 PM")
    AddProperty("10746", "MTBH_Length_Maximum_User_UOM", <a><![CDATA[MTBH_Length_Maximum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:45:21 PM")
    AddProperty("10747", "MTBH_Length_Minimum_IN", <a><![CDATA[MTBH_Length_Minimum_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:46:05 PM")
    AddProperty("10748", "MTBH_Length_Minimum_User", <a><![CDATA[MTBH_Length_Minimum_User]]></a>.Value, "AppCalc^'Belted PandA'!D31", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:53:39 PM")
    AddProperty("10749", "MTBH_Length_Minimum_User_Min_Value", <a><![CDATA[MTBH_Length_Minimum_User_Min_Value]]></a>.Value, "", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:45:57 PM")
    AddProperty("10750", "MTBH_Length_Minimum_User_UOM", <a><![CDATA[MTBH_Length_Minimum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:46:13 PM")
    AddProperty("10751", "MTBH_Use_Local", <a><![CDATA[MTBH_Use_Local]]></a>.Value, "AppCalc^'MDR Sort'!I31", "String","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:46:47 PM")
    AddProperty("10752", "MTBH_Weight_Average_LBS", <a><![CDATA[MTBH_Weight_Average_LBS]]></a>.Value, "Property unit conversion", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:46:54 PM")
    AddProperty("10753", "MTBH_Weight_Average_User", <a><![CDATA[MTBH_Weight_Average_User]]></a>.Value, "AppCalc^'Belted PandA'!J33", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:53:53 PM")
    AddProperty("10754", "MTBH_Weight_Average_User_UOM", <a><![CDATA[MTBH_Weight_Average_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:47:01 PM")
    AddProperty("10755", "MTBH_Weight_Maximum_LBS", <a><![CDATA[MTBH_Weight_Maximum_LBS]]></a>.Value, "Property unit conversion", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:47:13 PM")
    AddProperty("10756", "MTBH_Weight_Maximum_User", <a><![CDATA[MTBH_Weight_Maximum_User]]></a>.Value, "AppCalc^'Belted PandA'!J32", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:54:04 PM")
    AddProperty("10757", "MTBH_Weight_Maximum_User_Max_Value", <a><![CDATA[MTBH_Weight_Maximum_User_Max_Value]]></a>.Value, "", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:47:41 PM")
    AddProperty("10758", "MTBH_Weight_Maximum_User_UOM", <a><![CDATA[MTBH_Weight_Maximum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:47:48 PM")
    AddProperty("10759", "MTBH_Weight_Minimum_LBS", <a><![CDATA[MTBH_Weight_Minimum_LBS]]></a>.Value, "Property unit conversion", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:47:54 PM")
    AddProperty("10760", "MTBH_Weight_Minimum_User", <a><![CDATA[MTBH_Weight_Minimum_User]]></a>.Value, "AppCalc^'Belted PandA'!J31", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:54:14 PM")
    AddProperty("10761", "MTBH_Weight_Minimum_User_Min_Value", <a><![CDATA[MTBH_Weight_Minimum_User_Min_Value]]></a>.Value, "", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:48:06 PM")
    AddProperty("10762", "MTBH_Weight_Minimum_User_UOM", <a><![CDATA[MTBH_Weight_Minimum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:48:14 PM")
    AddProperty("10763", "MTBH_Width_Average_IN", <a><![CDATA[MTBH_Width_Average_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:48:21 PM")
    AddProperty("10764", "MTBH_Width_Average_User", <a><![CDATA[MTBH_Width_Average_User]]></a>.Value, "AppCalc^'Belted PandA'!F33", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:55:34 PM")
    AddProperty("10765", "MTBH_Width_Average_User_UOM", <a><![CDATA[MTBH_Width_Average_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:48:28 PM")
    AddProperty("10766", "MTBH_Width_Maximum_IN", <a><![CDATA[MTBH_Width_Maximum_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:49:18 PM")
    AddProperty("10767", "MTBH_Width_Maximum_User", <a><![CDATA[MTBH_Width_Maximum_User]]></a>.Value, "AppCalc^'Belted PandA'!F32", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:55:59 PM")
    AddProperty("10768", "MTBH_Width_Maximum_User_Max_Value", <a><![CDATA[MTBH_Width_Maximum_User_Max_Value]]></a>.Value, "", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:48:44 PM")
    AddProperty("10769", "MTBH_Width_Maximum_User_UOM", <a><![CDATA[MTBH_Width_Maximum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:49:25 PM")
    AddProperty("10770", "MTBH_Width_Minimum_IN", <a><![CDATA[MTBH_Width_Minimum_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:49:31 PM")
    AddProperty("10771", "MTBH_Width_Minimum_User", <a><![CDATA[MTBH_Width_Minimum_User]]></a>.Value, "AppCalc^'Belted PandA'!F31", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:56:10 PM")
    AddProperty("10772", "MTBH_Width_Minimum_User_Min_Value", <a><![CDATA[MTBH_Width_Minimum_User_Min_Value]]></a>.Value, "", "Double","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:49:12 PM")
    AddProperty("10773", "MTBH_Width_Minimum_User_UOM", <a><![CDATA[MTBH_Width_Minimum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:49:37 PM")
    AddProperty("10713", "Size_Limits_Height_Max_User_UOM", <a><![CDATA[Size_Limits_Height_Max_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_Size_Limits","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 7:33:29 PM")
    AddProperty("10714", "Size_Limits_Height_Min_User_UOM", <a><![CDATA[Size_Limits_Height_Min_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_Size_Limits","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 7:20:00 PM")
    AddProperty("10717", "Size_Limits_Length_Max_User", <a><![CDATA[Size_Limits_Length_Max_User]]></a>.Value, "AppCalc^'MDR Sort'!D26", "Double","","AppCalc_MDR_Size_Limits","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:28:11 PM")
    AddProperty("10709", "Size_Limits_Length_Max_User_UOM", <a><![CDATA[Size_Limits_Length_Max_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_Size_Limits","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 7:20:08 PM")
    AddProperty("10718", "Size_Limits_Length_Min_User", <a><![CDATA[Size_Limits_Length_Min_User]]></a>.Value, "AppCalc^'MDR Sort'!D25", "Double","","AppCalc_MDR_Size_Limits","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:28:23 PM")
    AddProperty("10710", "Size_Limits_Length_Min_User_UOM", <a><![CDATA[Size_Limits_Length_Min_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_Size_Limits","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 7:19:40 PM")
    AddProperty("10721", "Size_Limits_Weight_Max_User", <a><![CDATA[Size_Limits_Weight_Max_User]]></a>.Value, "AppCalc^'MDR Sort'!J26", "Double","","AppCalc_MDR_Size_Limits","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:28:28 PM")
    AddProperty("10715", "Size_Limits_Weight_Max_User_UOM", <a><![CDATA[Size_Limits_Weight_Max_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_Size_Limits","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 7:20:45 PM")
    AddProperty("10722", "Size_Limits_Weight_Min_User", <a><![CDATA[Size_Limits_Weight_Min_User]]></a>.Value, "AppCalc^'MDR Sort'!J25", "Double","","AppCalc_MDR_Size_Limits","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:28:47 PM")
    AddProperty("10716", "Size_Limits_Weight_Min_User_UOM", <a><![CDATA[Size_Limits_Weight_Min_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_Size_Limits","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 7:20:54 PM")
    AddProperty("10720", "Size_Limits_Width_Max_User", <a><![CDATA[Size_Limits_Width_Max_User]]></a>.Value, "AppCalc^'MDR Sort'!F26", "Double","","AppCalc_MDR_Size_Limits","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:28:33 PM")
    AddProperty("10711", "Size_Limits_Width_Max_User_UOM", <a><![CDATA[Size_Limits_Width_Max_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_Size_Limits","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 7:19:46 PM")
    AddProperty("10719", "Size_Limits_Width_Min_User", <a><![CDATA[Size_Limits_Width_Min_User]]></a>.Value, "AppCalc^'MDR Sort'!F25", "Double","","AppCalc_MDR_Size_Limits","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:28:38 PM")
    AddProperty("10712", "Size_Limits_Width_Min_User_UOM", <a><![CDATA[Size_Limits_Width_Min_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_Size_Limits","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 7:33:38 PM")
    AddProperty("10723", "Size_Limits_Length_Max_IN", <a><![CDATA[Size_Limits_Length_Max_IN]]></a>.Value, "Unit conversion to IN", "Double","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:34:07 PM")
    AddProperty("10724", "Size_Limits_Length_Min_IN", <a><![CDATA[Size_Limits_Length_Min_IN]]></a>.Value, "Unit conversion to IN", "Double","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:34:28 PM")
    AddProperty("10727", "Size_Limits_Weight_Max_LB", <a><![CDATA[Size_Limits_Weight_Max_LB]]></a>.Value, "Unit conversion to LB", "Double","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:35:39 PM")
    AddProperty("10728", "Size_Limits_Weight_Min_LB", <a><![CDATA[Size_Limits_Weight_Min_LB]]></a>.Value, "Unit conversion to LB", "Double","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:35:59 PM")
    AddProperty("10725", "Size_Limits_Width_Max_IN", <a><![CDATA[Size_Limits_Width_Max_IN]]></a>.Value, "Unit conversion to IN", "Double","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:34:50 PM")
    AddProperty("10726", "Size_Limits_Width_Min_IN", <a><![CDATA[Size_Limits_Width_Min_IN]]></a>.Value, "Unit conversion to IN", "Double","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:35:09 PM")
    AddProperty("10700", "Sort_Char_Divert_Angle", <a><![CDATA[Sort_Char_Divert_Angle]]></a>.Value, "AppCalc^'MDR Sort'!J19", "Double","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 6:16:50 PM")
    AddProperty("10706", "Sort_Char_Max_Speed_FPM", <a><![CDATA[Sort_Char_Max_Speed_FPM]]></a>.Value, "Unit conversion to FT/MIN", "Double","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:30:39 PM")
    AddProperty("10705", "Sort_Char_Max_Speed_User", <a><![CDATA[Sort_Char_Max_Speed_User]]></a>.Value, "AppCalc^'MDR Sort'!J20", "Double","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 7:01:23 PM")
    AddProperty("10702", "Sort_Char_Max_Speed_User_UOM", <a><![CDATA[Sort_Char_Max_Speed_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 7:14:18 PM")
    AddProperty("10708", "Sort_Char_Min_Operating_Temp_F", <a><![CDATA[Sort_Char_Min_Operating_Temp_F]]></a>.Value, "Unit conversion to F", "Double","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 8:33:32 PM")
    AddProperty("10707", "Sort_Char_Min_Operating_Temp_User", <a><![CDATA[Sort_Char_Min_Operating_Temp_User]]></a>.Value, "AppCalc^'MDR Sort'!J21", "Double","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 7:02:17 PM")
    AddProperty("10704", "Sort_Char_Min_Operating_Temp_User_UOM", <a><![CDATA[Sort_Char_Min_Operating_Temp_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_MDR_Sort_Characteristics","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 7:14:07 PM")
    AddProperty("10696", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 4:20:38 PM")
    
      AddPropertyExtended(10730,"MTBH_Height_Average_User", "10291", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/18/2025 8:50:17 PM")
    
      AddPropertyExtended(10733,"MTBH_Height_Maximum_User", "10294", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/18/2025 8:50:58 PM")
    
      AddPropertyExtended(10737,"MTBH_Height_Minimum_User", "10298", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/18/2025 8:51:53 PM")
    
      AddPropertyExtended(10741,"MTBH_Length_Average_User", "10302", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/18/2025 8:52:14 PM")
    
      AddPropertyExtended(10744,"MTBH_Length_Maximum_User", "10305", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/18/2025 8:53:01 PM")
    
      AddPropertyExtended(10748,"MTBH_Length_Minimum_User", "10309", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/18/2025 8:53:39 PM")
    
      AddPropertyExtended(10753,"MTBH_Weight_Average_User", "10314", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/18/2025 8:53:53 PM")
    
      AddPropertyExtended(10756,"MTBH_Weight_Maximum_User", "10317", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/18/2025 8:54:04 PM")
    
      AddPropertyExtended(10760,"MTBH_Weight_Minimum_User", "10321", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/18/2025 8:54:14 PM")
    
      AddPropertyExtended(10764,"MTBH_Width_Average_User", "10325", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/18/2025 8:55:34 PM")
    
      AddPropertyExtended(10767,"MTBH_Width_Maximum_User", "10328", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/18/2025 8:55:59 PM")
    
      AddPropertyExtended(10771,"MTBH_Width_Minimum_User", "10332", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/18/2025 8:56:10 PM")
    
      AddValidValue("Gen_Sorter_Type")
    
      AddValidValue("User_UOM_System")
    
      AddValidValue("MTBH_Height_Average_User_UOM")
    
      AddValidValue("MTBH_Height_Maximum_User_UOM")
    
      AddValidValue("MTBH_Height_Minimum_User_UOM")
    
      AddValidValue("MTBH_Length_Average_User_UOM")
    
      AddValidValue("MTBH_Length_Maximum_User_UOM")
    
      AddValidValue("MTBH_Length_Minimum_User_UOM")
    
      AddValidValue("MTBH_Use_Local")
    
      AddValidValue("MTBH_Weight_Average_User_UOM")
    
      AddValidValue("MTBH_Weight_Maximum_User_UOM")
    
      AddValidValue("MTBH_Weight_Minimum_User_UOM")
    
      AddValidValue("MTBH_Width_Average_User_UOM")
    
      AddValidValue("MTBH_Width_Maximum_User_UOM")
    
      AddValidValue("MTBH_Width_Minimum_User_UOM")
    
      AddValidValue("Size_Limits_Height_Max_User_UOM")
    
      AddValidValue("Size_Limits_Height_Min_User_UOM")
    
      AddValidValue("Size_Limits_Length_Max_User_UOM")
    
      AddValidValue("Size_Limits_Length_Min_User_UOM")
    
      AddValidValue("Size_Limits_Weight_Max_User_UOM")
    
      AddValidValue("Size_Limits_Weight_Min_User_UOM")
    
      AddValidValue("Size_Limits_Width_Max_User_UOM")
    
      AddValidValue("Size_Limits_Width_Min_User_UOM")
    
      AddValidValue("Sort_Char_Max_Speed_User_UOM")
    
      AddValidValue("Sort_Char_Min_Operating_Temp_User_UOM")
    
      oConnection = AddConnection("My_PRD", <a><![CDATA[My_PRD]]></a>.Value, "", "207", "OO", 0, "","AppCalc_MDR", 9999, "", "GLOBAL\H602502", "7/18/2025 6:34:08 PM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      
      oConnection = AddConnection("My_Setup", <a><![CDATA[My_Setup]]></a>.Value, "", "208", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/18/2025 6:34:08 PM")
      
        oConnection.AddVPF(119, "APC_Setup")
      
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
          InitProperty("Gen_Sorter_Type", "10258", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 4:23:00 PM", "", "In Development",  0,19129)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("User_UOM_System", "10264", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 6:20:27 PM", "", "In Development",  0,19147)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Average_IN", "10290", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:16 PM", "", "In Development",  0,19221)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Average_User", "10291", "MTBH_Height_Minimum_User", "MTBH_Height_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:16 PM", "", "In Development",  0,19222)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Average_User_UOM", "10292", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:16 PM", "", "In Development",  0,19225)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Maximum_IN", "10293", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:16 PM", "", "In Development",  0,19227)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Maximum_User", "10294", "MTBH_Height_Minimum_User", "MTBH_Height_Maximum_User_Max_Value", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:50:53 PM", "", "In Development",  0,19228)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Maximum_User_Max_Value", "10295", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:43:03 PM", "", "In Development",  0,19303)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Maximum_User_UOM", "10296", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:16 PM", "", "In Development",  0,19232)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Minimum_IN", "10297", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:16 PM", "", "In Development",  0,19234)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Minimum_User", "10298", "MTBH_Height_Minimum_User_Min_Value", "MTBH_Height_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:51:38 PM", "", "In Development",  0,19235)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Minimum_User_Min_Value", "10299", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:43:53 PM", "", "In Development",  0,19304)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Minimum_User_UOM", "10300", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:16 PM", "", "In Development",  0,19239)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Average_IN", "10301", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:16 PM", "", "In Development",  0,19241)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Average_User", "10302", "MTBH_Length_Minimum_User", "MTBH_Length_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:16 PM", "", "In Development",  0,19242)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Average_User_UOM", "10303", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:16 PM", "", "In Development",  0,19245)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Maximum_IN", "10304", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:16 PM", "", "In Development",  0,19247)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Maximum_User", "10305", "MTBH_Length_Minimum_User", "MTBH_Length_Maximum_User_Max_Value", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:16 PM", "", "In Development",  0,19248)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Maximum_User_Max_Value", "10306", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19251)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Maximum_User_UOM", "10307", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19252)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Minimum_IN", "10308", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19254)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Minimum_User", "10309", "MTBH_Length_Minimum_User_Min_Value", "MTBH_Length_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:53:39 PM", "", "In Development",  0,19255)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Minimum_User_Min_Value", "10310", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:45:52 PM", "", "In Development",  0,19305)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Minimum_User_UOM", "10311", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19259)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Use_Local", "10312", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19261)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Average_LBS", "10313", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19263)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Average_User", "10314", "MTBH_Weight_Minimum_User", "MTBH_Weight_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19264)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Average_User_UOM", "10315", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19267)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Maximum_LBS", "10316", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19269)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Maximum_User", "10317", "MTBH_Weight_Minimum_User", "MTBH_Weight_Maximum_User_Max_Value", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19270)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Maximum_User_Max_Value", "10318", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:47:36 PM", "", "In Development",  0,19306)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Maximum_User_UOM", "10319", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19274)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Minimum_LBS", "10320", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19276)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Minimum_User", "10321", "MTBH_Weight_Minimum_User_Min_Value", "MTBH_Weight_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19277)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Minimum_User_Min_Value", "10322", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19280)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Minimum_User_UOM", "10323", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19281)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Average_IN", "10324", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19283)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Average_User", "10325", "MTBH_Width_Minimum_User", "MTBH_Width_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19284)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Average_User_UOM", "10326", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19287)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Maximum_IN", "10327", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19289)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Maximum_User", "10328", "MTBH_Width_Minimum_User", "MTBH_Width_Maximum_User_Max_Value", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19290)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Maximum_User_Max_Value", "10329", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19293)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Maximum_User_UOM", "10330", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19294)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Minimum_IN", "10331", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19296)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Minimum_User", "10332", "MTBH_Width_Minimum_User_Min_Value", "MTBH_Width_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19297)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Minimum_User_Min_Value", "10333", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:49:12 PM", "", "In Development",  0,19307)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Minimum_User_UOM", "10334", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:38:17 PM", "", "In Development",  0,19301)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Height_Max_User_UOM", "10274", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 7:33:29 PM", "", "In Development",  0,19201)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Height_Min_User_UOM", "10275", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 7:20:00 PM", "", "In Development",  0,19176)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Length_Max_User", "10278", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 7:25:56 PM", "", "In Development",  0,19193)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Length_Max_User_UOM", "10270", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 7:20:08 PM", "", "In Development",  0,19167)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Length_Min_User", "10279", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 7:26:13 PM", "", "In Development",  0,19194)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Length_Min_User_UOM", "10271", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 7:19:40 PM", "", "In Development",  0,19168)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Weight_Max_User", "10282", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:26:50 PM", "", "In Development",  0,19204)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Weight_Max_User_UOM", "10276", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 7:20:45 PM", "", "In Development",  0,19186)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Weight_Min_User", "10283", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:27:13 PM", "", "In Development",  0,19206)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Weight_Min_User_UOM", "10277", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 7:20:54 PM", "", "In Development",  0,19188)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Width_Max_User", "10281", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 7:27:33 PM", "", "In Development",  0,19198)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Width_Max_User_UOM", "10272", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 7:19:46 PM", "", "In Development",  0,19170)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Width_Min_User", "10280", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 7:26:49 PM", "", "In Development",  0,19196)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Width_Min_User_UOM", "10273", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 7:33:38 PM", "", "In Development",  0,19202)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Length_Max_IN", "10284", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:34:07 PM", "", "In Development",  0,19210)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Length_Min_IN", "10285", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:34:28 PM", "", "In Development",  0,19212)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Weight_Max_LB", "10288", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:35:39 PM", "", "In Development",  0,19218)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Weight_Min_LB", "10289", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:35:59 PM", "", "In Development",  0,19220)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Width_Max_IN", "10286", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:34:50 PM", "", "In Development",  0,19214)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Size_Limits_Width_Min_IN", "10287", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:35:09 PM", "", "In Development",  0,19216)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Char_Divert_Angle", "10261", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 6:16:50 PM", "", "In Development",  0,19141)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Char_Max_Speed_FPM", "10267", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:30:39 PM", "", "In Development",  0,19207)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Char_Max_Speed_User", "10266", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 6:29:10 PM", "", "In Development",  0,19157)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Char_Max_Speed_User_UOM", "10263", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 6:25:36 PM", "", "In Development",  0,19149)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Char_Min_Operating_Temp_F", "10269", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 8:31:31 PM", "", "In Development",  0,19208)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Char_Min_Operating_Temp_User", "10268", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 7:02:17 PM", "", "In Development",  0,19162)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Char_Min_Operating_Temp_User_UOM", "10265", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 6:25:19 PM", "", "In Development",  0,19152)
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
          
        InitValidValue("Gen_Sorter_Type_ValidValues", "10258", "-1", 19130)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("User_UOM_System_ValidValues", "10264", "-1", 19148)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Height_Average_User_UOM_ValidValues", "10292", "-1", 19226)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Height_Maximum_User_UOM_ValidValues", "10296", "-1", 19233)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Height_Minimum_User_UOM_ValidValues", "10300", "-1", 19240)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Length_Average_User_UOM_ValidValues", "10303", "-1", 19246)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Length_Maximum_User_UOM_ValidValues", "10307", "-1", 19253)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Length_Minimum_User_UOM_ValidValues", "10311", "-1", 19260)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Use_Local_ValidValues", "10312", "-1", 19262)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Weight_Average_User_UOM_ValidValues", "10315", "-1", 19268)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Weight_Maximum_User_UOM_ValidValues", "10319", "-1", 19275)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Weight_Minimum_User_UOM_ValidValues", "10323", "-1", 19282)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Width_Average_User_UOM_ValidValues", "10326", "-1", 19288)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Width_Maximum_User_UOM_ValidValues", "10330", "-1", 19295)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Width_Minimum_User_UOM_ValidValues", "10334", "-1", 19302)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Size_Limits_Height_Max_User_UOM_ValidValues", "10274", "-1", 19199)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Size_Limits_Height_Min_User_UOM_ValidValues", "10275", "-1", 19182)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Size_Limits_Length_Max_User_UOM_ValidValues", "10270", "-1", 19183)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Size_Limits_Length_Min_User_UOM_ValidValues", "10271", "-1", 19178)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Size_Limits_Weight_Max_User_UOM_ValidValues", "10276", "-1", 19187)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Size_Limits_Weight_Min_User_UOM_ValidValues", "10277", "-1", 19189)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Size_Limits_Width_Max_User_UOM_ValidValues", "10272", "-1", 19179)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Size_Limits_Width_Min_User_UOM_ValidValues", "10273", "-1", 19200)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Sort_Char_Max_Speed_User_UOM_ValidValues", "10263", "-1", 19154)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Sort_Char_Min_Operating_Temp_User_UOM_ValidValues", "10265", "-1", 19153)
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
          
        InitConnection("My_PRD", "186", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/18/2025 6:34:08 PM", "", "In Development", "N",334)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Setup", "187", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/18/2025 6:34:08 PM", "", "In Development", "N",335)
        
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
        '   BEGIN FORMULA; CON ID:186; TYPE:PF
        Result = me.Parent.Parent.Parent
        '   END FORMULA; CON ID:186; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_My_PRD_PARTS", ex.Message)
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
        '   BEGIN FORMULA; CON ID:187; TYPE:PF
        Result = me.Parent.Setup(1)
        '   END FORMULA; CON ID:187; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_My_Setup_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Sorter_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Sorter_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10258; TYPE:PF
      Result = "MDR - RT3 RAT"
      '   END FORMULA; PROP ID:10258; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Gen_Sorter_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10264; TYPE:PF
      Result = me.My_Setup(1).User_UOM_System
      '   END FORMULA; PROP ID:10264; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_User_UOM_System", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Height_Average_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Height_Average_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10290; TYPE:PF
      Result = Units.Convert(Me.MTBH_Height_Average_User, Me.MTBH_Height_Average_User_UOM,"IN")
      '   END FORMULA; PROP ID:10290; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Average_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Height_Average_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Height_Average_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10291; TYPE:PF
      Select Case Me.MTBH_Use_Local
	Case "No"
		Select Case Me.MTBH_Height_Average_User_UOM
			Case "IN"
				Result = Me.My_Setup(1).BoxSize_Height_Avg_IN
			Case Else
				Result = Me.My_Setup(1).BoxSize_Height_Avg_MM
		End Select
	Case Else
		Result = (Me.MTBH_Height_Minimum_User + Me.MTBH_Height_Maximum_User) / 2
End Select
      '   END FORMULA; PROP ID:10291; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Average_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Height_Average_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Height_Average_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10292; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10292; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Average_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Height_Maximum_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Height_Maximum_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10293; TYPE:PF
      Result = Units.Convert(Me.MTBH_Height_Maximum_User, Me.MTBH_Height_Maximum_User_UOM,"IN")
      '   END FORMULA; PROP ID:10293; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Maximum_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Height_Maximum_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Height_Maximum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10294; TYPE:PF
      Select Case Me.MTBH_Use_Local
	Case "No"
		Select Case Me.MTBH_Height_Maximum_User_UOM
			Case "IN"
				Result = Me.My_Setup(1).BoxSize_Height_Max_IN
			Case Else
				Result = Me.My_Setup(1).BoxSize_Height_Max_MM
		End Select
	Case Else
		Select Case Me.MTBH_Height_Maximum_User_UOM
			Case "IN"
				Result = 10
			Case Else
				Result = 200
		End Select
End Select
      '   END FORMULA; PROP ID:10294; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Maximum_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Height_Maximum_User_Max_Value() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Height_Maximum_User_Max_Value").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10295; TYPE:PF
      Select Case Me.MTBH_Height_Maximum_User_UOM
	Case "IN"
		Result = 32
	Case Else
		Result = 812.8
End Select
      '   END FORMULA; PROP ID:10295; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Maximum_User_Max_Value", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Height_Maximum_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Height_Maximum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10296; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10296; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Maximum_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Height_Minimum_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Height_Minimum_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10297; TYPE:PF
      Result = Units.Convert(Me.MTBH_Height_Minimum_User, Me.MTBH_Height_Minimum_User_UOM,"IN")
      '   END FORMULA; PROP ID:10297; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Minimum_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Height_Minimum_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Height_Minimum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10298; TYPE:PF
      Select Case Me.MTBH_Use_Local
	Case "No"
		Select Case Me.MTBH_Height_Minimum_User_UOM
			Case "IN"
				Result = Me.My_Setup(1).BoxSize_Height_Min_IN
			Case Else
				Result = Me.My_Setup(1).BoxSize_Height_Min_MM
		End Select
	Case Else
		Select Case Me.MTBH_Height_Minimum_User_UOM
			Case "IN"
				Result = 10
			Case Else
				Result = 200
		End Select
End Select
      '   END FORMULA; PROP ID:10298; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Minimum_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Height_Minimum_User_Min_Value() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Height_Minimum_User_Min_Value").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10299; TYPE:PF
      Select Case Me.MTBH_Length_Minimum_User_UOM
	Case "IN"
		Result = 0.75
	Case Else
		Result = 19.05
End Select
      '   END FORMULA; PROP ID:10299; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Minimum_User_Min_Value", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Height_Minimum_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Height_Minimum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10300; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10300; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Minimum_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Length_Average_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Length_Average_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10301; TYPE:PF
      Result = Units.Convert(Me.MTBH_Length_Average_User, Me.MTBH_Length_Average_User_UOM,"IN")
      '   END FORMULA; PROP ID:10301; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Average_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Length_Average_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Length_Average_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10302; TYPE:PF
      Select Case Me.MTBH_Use_Local
	Case "No"
		Select Case MTBH_Length_Average_User_UOM
			Case "IN"
				Result = Me.My_Setup(1).BoxSize_Length_Avg_IN
			Case Else
				Result = Me.My_Setup(1).BoxSize_Length_Avg_MM
		End Select
	Case Else
		Result = (Me.MTBH_Length_Maximum_User + Me.MTBH_Length_Minimum_User) / 2
End Select
      '   END FORMULA; PROP ID:10302; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Average_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Length_Average_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Length_Average_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10303; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10303; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Average_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Length_Maximum_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Length_Maximum_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10304; TYPE:PF
      Result = Units.Convert(Me.MTBH_Length_Maximum_User, Me.MTBH_Length_Maximum_User_UOM,"IN")
      '   END FORMULA; PROP ID:10304; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Maximum_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Length_Maximum_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Length_Maximum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10305; TYPE:PF
      Select Case Me.MTBH_Use_Local
	Case "No"
		Select Case MTBH_Length_Maximum_User_UOM
			Case "IN"
				Result = Me.My_Setup(1).BoxSize_Length_Max_IN
			Case Else
				Result = Me.My_Setup(1).BoxSize_Length_Max_MM
		End Select
	Case Else
		Select Case Me.MTBH_Length_Maximum_User_UOM
			Case "IN"
				Result = 10
			Case Else
				Result = 200
		End Select
End Select
      '   END FORMULA; PROP ID:10305; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Maximum_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Length_Maximum_User_Max_Value() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Length_Maximum_User_Max_Value").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10306; TYPE:PF
      Select Case Me.MTBH_Length_Maximum_User_UOM
	Case "IN"
		Result = 60
	Case Else
		Result = 1524
End Select
      '   END FORMULA; PROP ID:10306; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Maximum_User_Max_Value", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Length_Maximum_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Length_Maximum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10307; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10307; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Maximum_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Length_Minimum_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Length_Minimum_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10308; TYPE:PF
      Result = Units.Convert(Me.MTBH_Length_Minimum_User, Me.MTBH_Length_Minimum_User_UOM,"IN")
      '   END FORMULA; PROP ID:10308; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Minimum_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Length_Minimum_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Length_Minimum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10309; TYPE:PF
      Select Case Me.MTBH_Use_Local
	Case "No"
		Select Case MTBH_Length_Minimum_User_UOM
			Case "IN"
				Result = Me.My_Setup(1).BoxSize_Length_Min_IN
			Case Else
				Result = Me.My_Setup(1).BoxSize_Length_Min_MM
		End Select
	Case Else
		Select Case Me.MTBH_Length_Minimum_User_UOM
			Case "IN"
				Result = 10
			Case Else
				Result = 200
		End Select
End Select
      '   END FORMULA; PROP ID:10309; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Minimum_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Length_Minimum_User_Min_Value() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Length_Minimum_User_Min_Value").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10310; TYPE:PF
      Select Case Me.MTBH_Length_Minimum_User_UOM
	Case "IN"
		Result = 9
	Case Else
		Result = 228.6
End Select
      '   END FORMULA; PROP ID:10310; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Minimum_User_Min_Value", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Length_Minimum_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Length_Minimum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10311; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10311; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Minimum_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Use_Local() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Use_Local").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10312; TYPE:PF
      Result = "Yes"
      '   END FORMULA; PROP ID:10312; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Use_Local", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Weight_Average_LBS() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Weight_Average_LBS").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10313; TYPE:PF
      Result = Units.Convert(Me.MTBH_Weight_Average_User, Me.MTBH_Weight_Average_User_UOM,"LB")
      '   END FORMULA; PROP ID:10313; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Average_LBS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Weight_Average_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Weight_Average_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10314; TYPE:PF
      Select Case Me.MTBH_Use_Local
	Case "No"
		Select Case  Me.MTBH_Weight_Average_User_UOM
			Case "LB"
				Result = Me.My_Setup(1).BoxSize_Weight_Avg_LBS
			Case Else
				Result = Units.Convert(Me.My_Setup(1).BoxSize_Weight_Avg_LBS, "LB", "KG")
		End Select
	Case Else
		Result = (Me.MTBH_Weight_Maximum_User + Me.MTBH_Weight_Minimum_User) / 2
End Select
      '   END FORMULA; PROP ID:10314; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Average_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Weight_Average_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Weight_Average_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10315; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "LB" Else Result = "KG"
      '   END FORMULA; PROP ID:10315; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Average_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Weight_Maximum_LBS() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Weight_Maximum_LBS").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10316; TYPE:PF
      Result = Units.Convert(Me.MTBH_Weight_Maximum_User, Me.MTBH_Weight_Maximum_User_UOM,"LB")
      '   END FORMULA; PROP ID:10316; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Maximum_LBS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Weight_Maximum_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Weight_Maximum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10317; TYPE:PF
      Select Case Me.MTBH_Use_Local
	Case "No"
		Select Case  Me.MTBH_Weight_Maximum_User_UOM
			Case "LB"
				Result = Me.My_Setup(1).BoxSize_Weight_Max_LBS
			Case Else
				Result = Units.Convert(Me.My_Setup(1).BoxSize_Weight_Max_LBS, "LB", "KG")
		End Select
	Case Else
		Select Case Me.MTBH_Weight_Maximum_User_UOM
			Case "LB"
				Result = 10
			Case Else
				Result = 30
		End Select
End Select
      '   END FORMULA; PROP ID:10317; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Maximum_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Weight_Maximum_User_Max_Value() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Weight_Maximum_User_Max_Value").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10318; TYPE:PF
      Select Case Me.MTBH_Length_Maximum_User_UOM
	Case "LB"
		Result = 70
	Case Else
		Result = 31.75
End Select
      '   END FORMULA; PROP ID:10318; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Maximum_User_Max_Value", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Weight_Maximum_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Weight_Maximum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10319; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "LB" Else Result = "KG"
      '   END FORMULA; PROP ID:10319; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Maximum_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Weight_Minimum_LBS() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Weight_Minimum_LBS").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10320; TYPE:PF
      Result = Units.Convert(Me.MTBH_Weight_Minimum_User, Me.MTBH_Weight_Minimum_User_UOM,"LB")
      '   END FORMULA; PROP ID:10320; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Minimum_LBS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Weight_Minimum_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Weight_Minimum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10321; TYPE:PF
      Select Case Me.MTBH_Use_Local
	Case "No"
		Select Case  Me.MTBH_Weight_Minimum_User_UOM
			Case "LB"
				Result = Me.My_Setup(1).BoxSize_Weight_Min_LBS
			Case Else
				Result = Units.Convert(Me.My_Setup(1).BoxSize_Weight_Min_LBS, "LB", "KG")
		End Select
	Case Else
		Select Case Me.MTBH_Weight_Minimum_User_UOM
			Case "LB"
				Result = 10
			Case Else
				Result = 30
		End Select
End Select
      '   END FORMULA; PROP ID:10321; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Minimum_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Weight_Minimum_User_Min_Value() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Weight_Minimum_User_Min_Value").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10322; TYPE:PF
      Select Case Me.MTBH_Weight_Minimum_User_UOM
	Case "LB"
		Result = 0.5
	Case Else
		Result = 0.23
End Select
      '   END FORMULA; PROP ID:10322; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Minimum_User_Min_Value", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Weight_Minimum_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Weight_Minimum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10323; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "LB" Else Result = "KG"
      '   END FORMULA; PROP ID:10323; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Minimum_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Width_Average_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Width_Average_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10324; TYPE:PF
      Result = Units.Convert(Me.MTBH_Width_Average_User, Me.MTBH_Width_Average_User_UOM,"IN")
      '   END FORMULA; PROP ID:10324; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Average_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Width_Average_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Width_Average_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10325; TYPE:PF
      Select Case Me.MTBH_Use_Local
	Case "No"
		Select Case Me.MTBH_Width_Average_User_UOM
			Case "IN"
				Result = Me.My_Setup(1).BoxSize_Width_Avg_IN
			Case Else
				Result = Me.My_Setup(1).BoxSize_Width_Avg_MM
		End Select
	Case Else
		Result = (Me.MTBH_Width_Maximum_User + Me.MTBH_Width_Minimum_User) / 2
End Select
      '   END FORMULA; PROP ID:10325; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Average_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Width_Average_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Width_Average_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10326; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10326; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Average_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Width_Maximum_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Width_Maximum_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10327; TYPE:PF
      Result = Units.Convert(Me.MTBH_Width_Maximum_User, Me.MTBH_Width_Maximum_User_UOM,"IN")
      '   END FORMULA; PROP ID:10327; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Maximum_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Width_Maximum_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Width_Maximum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10328; TYPE:PF
      Select Case Me.MTBH_Use_Local
	Case "No"
		Select Case Me.MTBH_Width_Maximum_User_UOM
			Case "IN"
				Result = Me.My_Setup(1).BoxSize_Width_Max_IN
			Case Else
				Result = Me.My_Setup(1).BoxSize_Width_Max_MM
		End Select
	Case Else
		Select Case Me.MTBH_Width_Maximum_User_UOM
			Case "IN"
				Result = 10
			Case Else
				Result = 200
		End Select
End Select
      '   END FORMULA; PROP ID:10328; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Maximum_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Width_Maximum_User_Max_Value() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Width_Maximum_User_Max_Value").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10329; TYPE:PF
      Select Case Me.MTBH_Width_Maximum_User_UOM
	Case "IN"
		Result = 38
	Case Else
		Result = 965.2
End Select
      '   END FORMULA; PROP ID:10329; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Maximum_User_Max_Value", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Width_Maximum_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Width_Maximum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10330; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10330; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Maximum_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Width_Minimum_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Width_Minimum_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10331; TYPE:PF
      Result = Units.Convert(Me.MTBH_Width_Minimum_User, Me.MTBH_Width_Minimum_User_UOM,"IN")
      '   END FORMULA; PROP ID:10331; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Minimum_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Width_Minimum_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Width_Minimum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10332; TYPE:PF
      Select Case Me.MTBH_Use_Local
	Case "No"
		Select Case MTBH_Width_Minimum_User_UOM
			Case "IN"
				Result = Me.My_Setup(1).BoxSize_Width_Min_IN
			Case Else
				Result = Me.My_Setup(1).BoxSize_Width_Min_MM
		End Select
	Case Else
		Select Case Me.MTBH_Width_Minimum_User_UOM
			Case "IN"
				Result = 10
			Case Else
				Result = 200
		End Select
End Select
      '   END FORMULA; PROP ID:10332; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Minimum_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Width_Minimum_User_Min_Value() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Width_Minimum_User_Min_Value").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10333; TYPE:PF
      Select Case Me.MTBH_Width_Minimum_User_UOM
	Case "IN"
		Result = 6
	Case Else
		Result = 152.4
End Select
      '   END FORMULA; PROP ID:10333; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Minimum_User_Min_Value", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Width_Minimum_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Width_Minimum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10334; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10334; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Minimum_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Height_Max_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Height_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10274; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10274; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Height_Max_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Height_Min_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Height_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10275; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10275; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Height_Min_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Length_Max_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Length_Max_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10278; TYPE:PF
      Result = 90

For Each pf As Rulestream.Kernel.Part In Me.Parent.App_Calc_Metrics(1).MDR_Sorters
	If pf.Properties("CAE_MDR_SORTER_MASTER_ID").Value.ToUpper() = Me.Gen_Sorter_Type.ToUpper()
		Result = pf.Properties("Max_Length").Value	
		Exit For
	End If
Next

If Me.Size_Limits_Length_Max_User_UOM = "MM" Then
	Result = Units.Convert(Result, "IN", "MM")
End If
      '   END FORMULA; PROP ID:10278; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Length_Max_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Length_Max_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Length_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10270; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10270; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Length_Max_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Length_Min_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Length_Min_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10279; TYPE:PF
      Result = 90

For Each pf As Rulestream.Kernel.Part In Me.Parent.App_Calc_Metrics(1).MDR_Sorters
	If pf.Properties("CAE_MDR_SORTER_MASTER_ID").Value.ToUpper() = Me.Gen_Sorter_Type.ToUpper()
		Result = pf.Properties("Min_Length").Value	
		Exit For
	End If
Next

If Me.Size_Limits_Length_Min_User_UOM = "MM" Then
	Result = Units.Convert(Result, "IN", "MM")
End If
      '   END FORMULA; PROP ID:10279; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Length_Min_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Length_Min_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Length_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10271; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10271; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Length_Min_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Weight_Max_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Weight_Max_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10282; TYPE:PF
      Result = 90

For Each pf As Rulestream.Kernel.Part In Me.Parent.App_Calc_Metrics(1).MDR_Sorters
	If pf.Properties("CAE_MDR_SORTER_MASTER_ID").Value.ToUpper() = Me.Gen_Sorter_Type.ToUpper()
		Result = pf.Properties("Max_Weight").Value	
		Exit For
	End If
Next

If Me.Size_Limits_Width_Max_User_UOM = "KG" Then
	Result = Units.Convert(Result, "LB", "KG")
End If
      '   END FORMULA; PROP ID:10282; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Weight_Max_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Weight_Max_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Weight_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10276; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "LB" Else Result = "KG"
      '   END FORMULA; PROP ID:10276; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Weight_Max_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Weight_Min_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Weight_Min_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10283; TYPE:PF
      Result = 90

For Each pf As Rulestream.Kernel.Part In Me.Parent.App_Calc_Metrics(1).MDR_Sorters
	If pf.Properties("CAE_MDR_SORTER_MASTER_ID").Value.ToUpper() = Me.Gen_Sorter_Type.ToUpper()
		Result = pf.Properties("Min_Weight").Value	
		Exit For
	End If
Next

If Me.Size_Limits_Width_Max_User_UOM = "KG" Then
	Result = Units.Convert(Result, "LB", "KG")
End If
      '   END FORMULA; PROP ID:10283; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Weight_Min_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Weight_Min_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Weight_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10277; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "LB" Else Result = "KG"
      '   END FORMULA; PROP ID:10277; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Weight_Min_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Width_Max_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Width_Max_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10281; TYPE:PF
      Result = 90

For Each pf As Rulestream.Kernel.Part In Me.Parent.App_Calc_Metrics(1).MDR_Sorters
	If pf.Properties("CAE_MDR_SORTER_MASTER_ID").Value.ToUpper() = Me.Gen_Sorter_Type.ToUpper()
		Result = pf.Properties("Max_Width").Value	
		Exit For
	End If
Next

If Me.Size_Limits_Width_Max_User_UOM = "MM" Then
	Result = Units.Convert(Result, "IN", "MM")
End If
      '   END FORMULA; PROP ID:10281; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Width_Max_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Width_Max_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Width_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10272; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10272; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Width_Max_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Width_Min_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Width_Min_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10280; TYPE:PF
      Result = 90

For Each pf As Rulestream.Kernel.Part In Me.Parent.App_Calc_Metrics(1).MDR_Sorters
	If pf.Properties("CAE_MDR_SORTER_MASTER_ID").Value.ToUpper() = Me.Gen_Sorter_Type.ToUpper()
		Result = pf.Properties("Min_Width").Value	
		Exit For
	End If
Next

If Me.Size_Limits_Width_Min_User_UOM = "MM" Then
	Result = Units.Convert(Result, "IN", "MM")
End If
      '   END FORMULA; PROP ID:10280; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Width_Min_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Width_Min_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Width_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10273; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:10273; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Width_Min_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Length_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Length_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10284; TYPE:PF
      Result = Units.Convert(Me.Size_Limits_Length_Max_User, Me.Size_Limits_Length_Max_User_UOM, "IN")
      '   END FORMULA; PROP ID:10284; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Length_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Length_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Length_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10285; TYPE:PF
      Result = Units.Convert(Me.Size_Limits_Length_Min_User, Me.Size_Limits_Length_Min_User_UOM, "IN")
      '   END FORMULA; PROP ID:10285; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Length_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Weight_Max_LB() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Weight_Max_LB").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10288; TYPE:PF
      Result = Units.Convert(Me.Size_Limits_Weight_Max_User, Me.Size_Limits_Weight_Max_User_UOM, "LB")
      '   END FORMULA; PROP ID:10288; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Weight_Max_LB", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Weight_Min_LB() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Weight_Min_LB").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10289; TYPE:PF
      Result = Units.Convert(Me.Size_Limits_Weight_Min_User, Me.Size_Limits_Weight_Min_User_UOM, "LB")
      '   END FORMULA; PROP ID:10289; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Weight_Min_LB", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Width_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Width_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10286; TYPE:PF
      Result = Units.Convert(Me.Size_Limits_Width_Max_User, Me.Size_Limits_Width_Max_User_UOM, "IN")
      '   END FORMULA; PROP ID:10286; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Width_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Size_Limits_Width_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Width_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10287; TYPE:PF
      Result = Units.Convert(Me.Size_Limits_Width_Min_User, Me.Size_Limits_Width_Min_User_UOM, "IN")
      '   END FORMULA; PROP ID:10287; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Width_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Char_Divert_Angle() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Divert_Angle").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10261; TYPE:PF
      Result = 90

For Each pf As Rulestream.Kernel.Part In Me.Parent.App_Calc_Metrics(1).MDR_Sorters
	If pf.Properties("CAE_MDR_SORTER_MASTER_ID").Value.ToUpper() = Me.Gen_Sorter_Type.ToUpper()
		Result = pf.Properties("Divert_Angle").Value	
		Exit For
	End If
Next
      '   END FORMULA; PROP ID:10261; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Divert_Angle", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Char_Max_Speed_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Max_Speed_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10267; TYPE:PF
      Result = Units.Convert(Me.Sort_Char_Max_Speed_User, Me.Sort_Char_Max_Speed_User_UOM, "FT/MIN")
      '   END FORMULA; PROP ID:10267; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Max_Speed_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Char_Max_Speed_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Max_Speed_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10266; TYPE:PF
      Result = 90

For Each pf As Rulestream.Kernel.Part In Me.Parent.App_Calc_Metrics(1).MDR_Sorters
	If pf.Properties("CAE_MDR_SORTER_MASTER_ID").Value.ToUpper() = Me.Gen_Sorter_Type.ToUpper()
		Result = pf.Properties("Max_Speed").Value	
		Exit For
	End If
Next

If Me.Sort_Char_Max_Speed_User_UOM = "M/SEC" Then
	Result = Units.Convert(Result, "FT/MIN", "M/SEC")
End If
      '   END FORMULA; PROP ID:10266; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Max_Speed_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Char_Max_Speed_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Max_Speed_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10263; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "FT/MIN" Else Result = "M/SEC"
      '   END FORMULA; PROP ID:10263; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Max_Speed_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Char_Min_Operating_Temp_F() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Min_Operating_Temp_F").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10269; TYPE:PF
      Result = Units.Convert(Me.Sort_Char_Min_Operating_Temp_User, Me.Sort_Char_Min_Operating_Temp_User_UOM, "F")
      '   END FORMULA; PROP ID:10269; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Min_Operating_Temp_F", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Char_Min_Operating_Temp_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Min_Operating_Temp_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10268; TYPE:PF
      Result = 90

For Each pf As Rulestream.Kernel.Part In Me.Parent.App_Calc_Metrics(1).MDR_Sorters
	If pf.Properties("CAE_MDR_SORTER_MASTER_ID").Value.ToUpper() = Me.Gen_Sorter_Type.ToUpper()
		Result = pf.Properties("Min_Op_Temp").Value	
		Exit For
	End If
Next

If Me.Sort_Char_Max_Speed_User_UOM = "C" Then
	Result = Units.Convert(Result, "F", "C")
End If
      '   END FORMULA; PROP ID:10268; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Min_Operating_Temp_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Char_Min_Operating_Temp_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Min_Operating_Temp_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10265; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "F" Else Result = "C"
      '   END FORMULA; PROP ID:10265; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Min_Operating_Temp_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Height_Average_User_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:10291; TYPE:TT
              Result = "Average Product Height" & vbcrlf & "The allowable range must fall between the defined Minimum and Maximum height values."
              '   END FORMULA; PROP ID:10291; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Average_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Height_Maximum_User_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:10294; TYPE:TT
              Select Case Me.MTBH_Height_Minimum_User_UOM
	Case "IN"
		Result = "Maximum Product Height" & vbcrlf & "The allowable input range is the defined Minimum Height to 32 inches on PandA applications.  Conveying product heights above 32 inches may be possible but require special design considerations and needs PAE/Engineering approval."
	Case Else
		Result = "Maximum Product Height" & vbcrlf & "The allowable input range is the defined Minimum Height to 812.8 mm on PandA applications.  Conveying product heights above 812.8 mm may be possible but require special design considerations and needs PAE/Engineering approval."
End Select
              '   END FORMULA; PROP ID:10294; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Maximum_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Height_Minimum_User_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:10298; TYPE:TT
              Select Case Me.MTBH_Height_Minimum_User_UOM
	Case "IN"
		Result = "Minimum Product Height" & vbcrlf & "The allowable input range is 0.75 inch to the defined Maximum Height."
	Case Else
		Result = "Minimum Product Height" & vbcrlf & "The allowable input range is 19.05 mm to the defined Maximum Height."
End Select
              '   END FORMULA; PROP ID:10298; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Minimum_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Length_Average_User_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:10302; TYPE:TT
              Result = "Average Product Length" & vbcrlf & "Allowable input range must be between the defined Minimum and Maximum product lengths."
              '   END FORMULA; PROP ID:10302; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Average_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Length_Maximum_User_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:10305; TYPE:TT
              Select Case Me.MTBH_Length_Maximum_User_UOM
	Case "IN"
		Result = "Maximum Product Length" & vbcrlf & "Allow input range is the defined minimum length to 60 inches.  Please understand any length grater than 48 inches requires special design considerations for the PandA Reject Divert and should be reviewed by PAE/Engineering."
	Case Else
		Result = "Maximum Product Length" & vbcrlf & "Allow input range is the defined minimum length to 1524 mm.  Please understand any length grater than 1219.2 mm requires special design considerations for the PandA Reject Divert and should be reviewed by PAE/Engineering."
End Select
              '   END FORMULA; PROP ID:10305; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Maximum_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Length_Minimum_User_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:10309; TYPE:TT
              Select Case Me.MTBH_Length_Minimum_User_UOM
	Case "IN"
		Result = "Allowable input range is 4 to 48 inches.  Minimum lengths less than 9 inches must be conveyed on belt or suitable sorters only.  Minimum lengths less than 9 inches require roller conveyors with 2 inch roller centers."
	Case Else
		Result = "Allowable input range is 101.6 to 1219.2 mm.  Minimum lengths less than 152.4 mm must be conveyed on belt or suitable sorters only.  Minimum lengths less than 228.6 mm require roller conveyors with 50.8 mm roller centers."
End Select
              '   END FORMULA; PROP ID:10309; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Minimum_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Weight_Average_User_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:10314; TYPE:TT
              Result = "Average Carton Weight" & vbcrlf & "The allowable input range is the defined Minimum weight up to the defined Maximum weight."
              '   END FORMULA; PROP ID:10314; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Average_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Weight_Maximum_User_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:10317; TYPE:TT
              Select Case Me.MTBH_Weight_Maximum_User_UOM
	Case "IN"
		Result = "Maximum Product Weight" & vbcrlf & "The allowable input range is the defined Minimum weight to 120 LBS.  Please Note!  The Maximum weight for MDR is 70 LBS."
	Case Else
		Result = "Maximum Product Weight" & vbcrlf & "The allowable input range is the defined Minimum weight to 54.43 Kg.  Please Note!  The Maximum weight for MDR is 31.75 Kg."
End Select
              '   END FORMULA; PROP ID:10317; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Maximum_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Weight_Minimum_User_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:10321; TYPE:TT
              Select Case  Me.MTBH_Weight_Minimum_User_UOM
	Case "IN"
		Result = "Minimum Product Weight" & vbcrlf & "The allowable input range is 0.5 LBS to the defined Maximum Weight."
	Case Else
		Result = "Minimum Product Weight" & vbcrlf & "The allowable input range is 0.23 Kg to the defined Maximum Weight."
End Select
              '   END FORMULA; PROP ID:10321; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Minimum_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Width_Average_User_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:10325; TYPE:TT
              Result = "Average Product Width" & vbcrlf & "The allowable input range must fall between the defined Minimum and Maximum widths."
              '   END FORMULA; PROP ID:10325; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Average_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Width_Maximum_User_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:10328; TYPE:TT
              Select Case Me.MTBH_Width_Maximum_User_UOM
	Case "IN"
		Result = "Maximum Product Width" & vbcrlf & "The allowable input range is the defined 'Average Width' to 38 inches."
	Case Else
		Result = "Maximum Product Width" & vbcrlf & "The allowable input range is the defined 'Average Width' to 965.2 mm."
End Select
              '   END FORMULA; PROP ID:10328; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Maximum_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MTBH_Width_Minimum_User_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:10332; TYPE:TT
              Select Case MTBH_Width_Minimum_User_UOM
	Case "IN"
		Result = "Minimum Product Width" & vbcrlf & "Allowable rand is 4 inches to the defined Maximum Width.  Please Note!  MADR Reject Diverts require a minimum of 6 inches for a BW Diverter & 9 inches for an MDR RAT."
	Case "IN"
		Result = "Minimum Product Width" & vbcrlf & "Allowable rand is 101.6 mm to the defined Maximum Width.  Please Note!  MADR Reject Diverts require a minimum of 152.4 mm for a BW Diverter & 228.6 mm for an MDR RAT."
End Select
              '   END FORMULA; PROP ID:10332; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Minimum_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Sorter_Type_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_MTBH_Height_Average_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Average_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Average_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Maximum_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Maximum_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Maximum_User_Max_Value_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Maximum_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Minimum_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Minimum_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Minimum_User_Min_Value_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Minimum_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Average_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Average_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Average_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Maximum_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Maximum_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Maximum_User_Max_Value_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Maximum_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Minimum_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Minimum_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Minimum_User_Min_Value_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Minimum_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Use_Local_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Average_LBS_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Average_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Average_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Maximum_LBS_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Maximum_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Maximum_User_Max_Value_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Maximum_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Minimum_LBS_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Minimum_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Minimum_User_Min_Value_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Minimum_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Average_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Average_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Average_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Maximum_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Maximum_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Maximum_User_Max_Value_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Maximum_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Minimum_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Minimum_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Minimum_User_Min_Value_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Minimum_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Height_Max_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Height_Min_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Length_Max_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Length_Max_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Length_Min_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Length_Min_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Weight_Max_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Weight_Max_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Weight_Min_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Weight_Min_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Width_Max_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Width_Max_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Width_Min_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Width_Min_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Length_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Length_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Weight_Max_LB_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Weight_Min_LB_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Width_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Width_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Divert_Angle_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Max_Speed_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Max_Speed_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Max_Speed_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Min_Operating_Temp_F_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Min_Operating_Temp_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Min_Operating_Temp_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Sorter_Type_USERCHANGE() as Boolean
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
      Public Function Formula_MTBH_Height_Average_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Average_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("MTBH_Height_Average_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10291; TYPE:UC
              Select Case Me.MTBH_Use_Local
	Case "No"
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:10291; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Average_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Average_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Maximum_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Maximum_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("MTBH_Height_Maximum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10294; TYPE:UC
              Select Case Me.MTBH_Use_Local
	Case "No"
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:10294; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Maximum_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Maximum_User_Max_Value_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Maximum_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Minimum_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Minimum_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("MTBH_Height_Minimum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10298; TYPE:UC
              Select Case Me.MTBH_Use_Local
	Case "No"
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:10298; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Minimum_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Minimum_User_Min_Value_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Minimum_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Average_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Average_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("MTBH_Length_Average_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10302; TYPE:UC
              Select Case Me.MTBH_Use_Local
	Case "No"
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:10302; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Average_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Average_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Maximum_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Maximum_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("MTBH_Length_Maximum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10305; TYPE:UC
              Select Case Me.MTBH_Use_Local
	Case "No"
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:10305; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Maximum_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Maximum_User_Max_Value_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Maximum_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Minimum_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Minimum_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("MTBH_Length_Minimum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10309; TYPE:UC
              Select Case Me.MTBH_Use_Local
	Case "No"
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:10309; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Minimum_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Minimum_User_Min_Value_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Minimum_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Use_Local_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Average_LBS_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Average_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("MTBH_Weight_Average_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10314; TYPE:UC
              Select Case Me.MTBH_Use_Local
	Case "No"
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:10314; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Average_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Average_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Maximum_LBS_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Maximum_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("MTBH_Weight_Maximum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10317; TYPE:UC
              Select Case Me.MTBH_Use_Local
	Case "No"
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:10317; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Maximum_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Maximum_User_Max_Value_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Maximum_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Minimum_LBS_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Minimum_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("MTBH_Weight_Minimum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10321; TYPE:UC
              Select Case Me.MTBH_Use_Local
	Case "No"
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:10321; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Minimum_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Minimum_User_Min_Value_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Minimum_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Average_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Average_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("MTBH_Width_Average_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10325; TYPE:UC
              Select Case Me.MTBH_Use_Local
	Case "No"
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:10325; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Average_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Average_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Maximum_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Maximum_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("MTBH_Width_Maximum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10328; TYPE:UC
              Select Case Me.MTBH_Use_Local
	Case "No"
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:10328; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Maximum_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Maximum_User_Max_Value_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Maximum_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Minimum_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Minimum_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("MTBH_Width_Minimum_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10332; TYPE:UC
              Select Case Me.MTBH_Use_Local
	Case "No"
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:10332; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Minimum_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Minimum_User_Min_Value_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Minimum_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Height_Max_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Height_Min_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Length_Max_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Length_Max_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Length_Min_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Length_Min_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Weight_Max_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Weight_Max_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Weight_Min_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Weight_Min_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Width_Max_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Width_Max_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Width_Min_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Width_Min_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Length_Max_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Length_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Weight_Max_LB_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Weight_Min_LB_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Width_Max_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Width_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Divert_Angle_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Max_Speed_FPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Max_Speed_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Max_Speed_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Min_Operating_Temp_F_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Min_Operating_Temp_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Min_Operating_Temp_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Sorter_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Sorter_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10258; TYPE:VV
      Result = MakeValidValues(Array("MDR - Blue Wheel Diverter", "MDR - RT3 RAT", "MDR - 710 RAT Pneumatic"))
      '   END FORMULA; PROP ID:10258; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Gen_Sorter_Type_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10264; TYPE:VV
      Result = MakeValidValues(Array("Imperial", "Metric"))
      '   END FORMULA; PROP ID:10264; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_User_UOM_System_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Average_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Height_Average_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10292; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10292; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Average_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Maximum_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Height_Maximum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10296; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10296; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Maximum_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Height_Minimum_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Height_Minimum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10300; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10300; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Height_Minimum_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Average_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Length_Average_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10303; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10303; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Average_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Maximum_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Length_Maximum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10307; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10307; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Maximum_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Length_Minimum_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Length_Minimum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10311; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10311; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Length_Minimum_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Use_Local_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Use_Local").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10312; TYPE:VV
      Result = MakeValidValues(Array("Yes", "No"))
      '   END FORMULA; PROP ID:10312; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Use_Local_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Average_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Weight_Average_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10315; TYPE:VV
      Result = MakeValidValues(Array("LB", "KG"))
      '   END FORMULA; PROP ID:10315; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Average_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Maximum_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Weight_Maximum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10319; TYPE:VV
      Result = MakeValidValues(Array("LB", "KG"))
      '   END FORMULA; PROP ID:10319; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Maximum_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Weight_Minimum_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Weight_Minimum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10323; TYPE:VV
      Result = MakeValidValues(Array("LB", "KG"))
      '   END FORMULA; PROP ID:10323; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Weight_Minimum_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Average_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Width_Average_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10326; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10326; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Average_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Maximum_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Width_Maximum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10330; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10330; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Maximum_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MTBH_Width_Minimum_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MTBH_Width_Minimum_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10334; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10334; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_MTBH_Width_Minimum_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Height_Max_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Height_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10274; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10274; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Height_Max_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Height_Min_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Height_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10275; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10275; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Height_Min_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Length_Max_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Length_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10270; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10270; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Length_Max_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Length_Min_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Length_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10271; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10271; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Length_Min_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Weight_Max_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Weight_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10276; TYPE:VV
      Result = MakeValidValues(Array("LB", "KG"))
      '   END FORMULA; PROP ID:10276; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Weight_Max_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Weight_Min_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Weight_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10277; TYPE:VV
      Result = MakeValidValues(Array("LB", "KG"))
      '   END FORMULA; PROP ID:10277; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Weight_Min_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Width_Max_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Width_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10272; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10272; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Width_Max_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Size_Limits_Width_Min_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Size_Limits_Width_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10273; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:10273; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Size_Limits_Width_Min_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Max_Speed_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Max_Speed_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10263; TYPE:VV
      Result = MakeValidValues(Array("FT/MIN", "M/SEC"))
      '   END FORMULA; PROP ID:10263; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Max_Speed_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Char_Min_Operating_Temp_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Char_Min_Operating_Temp_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10265; TYPE:VV
      Result = MakeValidValues(Array("F", "C"))
      '   END FORMULA; PROP ID:10265; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_MDR.Formula_Sort_Char_Min_Operating_Temp_User_UOM_ValidValues", ex.Message)
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

  