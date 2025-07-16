Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: APC_Setup
'$ GenerateDate: 07/16/2025 19:18:25

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

    Public Class [APC_Setup]
    
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

    Private this as APC_Setup = me

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
    
          Public Property [Belt_InclineDecline_Max_Deg]() As Double
      Get
      Return Properties("Belt_InclineDecline_Max_Deg").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Belt_InclineDecline_Max_Deg").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Height_Avg_IN]() As Double
      Get
      Return Properties("BoxSize_Height_Avg_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Height_Avg_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Height_Avg_User]() As Double
      Get
      Return Properties("BoxSize_Height_Avg_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Height_Avg_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Height_Avg_User_UOM]() As String
      Get
      Return Properties("BoxSize_Height_Avg_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("BoxSize_Height_Avg_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Height_GRTR_Len_Possible]() As Boolean
      Get
      Return Properties("BoxSize_Height_GRTR_Len_Possible").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("BoxSize_Height_GRTR_Len_Possible").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Height_Max_IN]() As Double
      Get
      Return Properties("BoxSize_Height_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Height_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Height_Max_User]() As Double
      Get
      Return Properties("BoxSize_Height_Max_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Height_Max_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Height_Max_User_UOM]() As String
      Get
      Return Properties("BoxSize_Height_Max_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("BoxSize_Height_Max_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Height_Min_IN]() As Double
      Get
      Return Properties("BoxSize_Height_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Height_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Height_Min_User]() As Double
      Get
      Return Properties("BoxSize_Height_Min_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Height_Min_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Height_Min_User_UOM]() As String
      Get
      Return Properties("BoxSize_Height_Min_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("BoxSize_Height_Min_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Length_Avg_IN]() As Double
      Get
      Return Properties("BoxSize_Length_Avg_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Length_Avg_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Length_Avg_User]() As Double
      Get
      Return Properties("BoxSize_Length_Avg_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Length_Avg_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Length_Avg_User_UOM]() As String
      Get
      Return Properties("BoxSize_Length_Avg_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("BoxSize_Length_Avg_User_UOM").CalculatedValue = Value
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
    
          Public Property [BoxSize_Other_Known_Issues]() As Boolean
      Get
      Return Properties("BoxSize_Other_Known_Issues").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("BoxSize_Other_Known_Issues").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_User_UOM]() As String
      Get
      Return Properties("BoxSize_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("BoxSize_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Weight_Avg_LBS]() As Double
      Get
      Return Properties("BoxSize_Weight_Avg_LBS").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Weight_Avg_LBS").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Weight_Avg_User]() As Double
      Get
      Return Properties("BoxSize_Weight_Avg_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Weight_Avg_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Weight_Avg_User_UOM]() As String
      Get
      Return Properties("BoxSize_Weight_Avg_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("BoxSize_Weight_Avg_User_UOM").CalculatedValue = Value
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
    
          Public Property [BoxSize_Width_Avg_IN]() As Double
      Get
      Return Properties("BoxSize_Width_Avg_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Width_Avg_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Width_Avg_User]() As Double
      Get
      Return Properties("BoxSize_Width_Avg_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Width_Avg_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Width_Avg_User_UOM]() As String
      Get
      Return Properties("BoxSize_Width_Avg_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("BoxSize_Width_Avg_User_UOM").CalculatedValue = Value
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
    
          Public Property [BoxSize_Worst_Case_Height_IN]() As Double
      Get
      Return Properties("BoxSize_Worst_Case_Height_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Worst_Case_Height_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Worst_Case_HL_Ratio]() As String
      Get
      Return Properties("BoxSize_Worst_Case_HL_Ratio").Value
      End Get
      Set(ByVal Value As String)
      Properties("BoxSize_Worst_Case_HL_Ratio").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxSize_Worst_Case_Length_IN]() As Double
      Get
      Return Properties("BoxSize_Worst_Case_Length_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("BoxSize_Worst_Case_Length_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Case_Length_Per_Minute_Target_FT]() As Double
      Get
      Return Properties("Case_Length_Per_Minute_Target_FT").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Case_Length_Per_Minute_Target_FT").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Case_Length_Per_Minute_Target_M]() As Double
      Get
      Return Properties("Case_Length_Per_Minute_Target_M").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Case_Length_Per_Minute_Target_M").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_BF_Selected_Min_IN]() As Double
      Get
      Return Properties("Conveyor_BF_Selected_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conveyor_BF_Selected_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_BF_Selected_Min_User]() As Double
      Get
      Return Properties("Conveyor_BF_Selected_Min_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conveyor_BF_Selected_Min_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_BF_Selected_Min_User_UOM]() As String
      Get
      Return Properties("Conveyor_BF_Selected_Min_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Conveyor_BF_Selected_Min_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_Curve_BF_Calc_Min_In]() As Double
      Get
      Return Properties("Conveyor_Curve_BF_Calc_Min_In").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conveyor_Curve_BF_Calc_Min_In").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_Curve_BF_Calc_Rcmd_In]() As Double
      Get
      Return Properties("Conveyor_Curve_BF_Calc_Rcmd_In").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conveyor_Curve_BF_Calc_Rcmd_In").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_Curve_OffSet_Guide_Viable]() As Boolean
      Get
      Return Properties("Conveyor_Curve_OffSet_Guide_Viable").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Conveyor_Curve_OffSet_Guide_Viable").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_Inside_Radius_Min_IN]() As Double
      Get
      Return Properties("Conveyor_Inside_Radius_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conveyor_Inside_Radius_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_Product_Line_Used]() As String
      Get
      Return Properties("Conveyor_Product_Line_Used").Value
      End Get
      Set(ByVal Value As String)
      Properties("Conveyor_Product_Line_Used").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_Skew_Bed_Length_Min_Reqd_IN]() As Double
      Get
      Return Properties("Conveyor_Skew_Bed_Length_Min_Reqd_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conveyor_Skew_Bed_Length_Min_Reqd_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_Skew_Bed_Length_MTBH_Width_IN]() As Double
      Get
      Return Properties("Conveyor_Skew_Bed_Length_MTBH_Width_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conveyor_Skew_Bed_Length_MTBH_Width_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_Skew_Total_Length_MTBH_Width_IN]() As Double
      Get
      Return Properties("Conveyor_Skew_Total_Length_MTBH_Width_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conveyor_Skew_Total_Length_MTBH_Width_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conveyor_Width_Min_IN]() As Double
      Get
      Return Properties("Conveyor_Width_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conveyor_Width_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Customer_Location_CityState]() As String
      Get
      Return Properties("Customer_Location_CityState").Value
      End Get
      Set(ByVal Value As String)
      Properties("Customer_Location_CityState").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Customer_Name]() As String
      Get
      Return Properties("Customer_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Customer_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Live_Load_Avg_KGM]() As Double
      Get
      Return Properties("Live_Load_Avg_KGM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Live_Load_Avg_KGM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Live_Load_Avg_LBSFT]() As Double
      Get
      Return Properties("Live_Load_Avg_LBSFT").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Live_Load_Avg_LBSFT").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Live_Load_Avg_User]() As Double
      Get
      Return Properties("Live_Load_Avg_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Live_Load_Avg_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Live_Load_Avg_User_UOM]() As String
      Get
      Return Properties("Live_Load_Avg_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Live_Load_Avg_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Material_Gap_Override_IN]() As Double
      Get
      Return Properties("Material_Gap_Override_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Material_Gap_Override_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Material_Gap_Override_MM]() As Double
      Get
      Return Properties("Material_Gap_Override_MM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Material_Gap_Override_MM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Material_Gap_Override_User]() As Double
      Get
      Return Properties("Material_Gap_Override_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Material_Gap_Override_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Material_Gap_Override_User_UOM]() As String
      Get
      Return Properties("Material_Gap_Override_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Material_Gap_Override_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_Date]() As Date
      Get
      Return Properties("Proposal_Date").Value
      End Get
      Set(ByVal Value As Date)
      Properties("Proposal_Date").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_No]() As String
      Get
      Return Properties("Proposal_No").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_No").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Selected_Sortation_Controls]() As String
      Get
      Return Properties("Selected_Sortation_Controls").Value
      End Get
      Set(ByVal Value As String)
      Properties("Selected_Sortation_Controls").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Dual_Sided]() As Boolean
      Get
      Return Properties("Sort_Dual_Sided").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Sort_Dual_Sided").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sort_Rate_Required_CPM]() As Double
      Get
      Return Properties("Sort_Rate_Required_CPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Sort_Rate_Required_CPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Temp_Sort_Operating_Min_F]() As Double
      Get
      Return Properties("Temp_Sort_Operating_Min_F").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Temp_Sort_Operating_Min_F").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Temp_Sort_Operating_Min_User]() As Double
      Get
      Return Properties("Temp_Sort_Operating_Min_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Temp_Sort_Operating_Min_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Temp_Sort_Operating_Min_User_UOM]() As String
      Get
      Return Properties("Temp_Sort_Operating_Min_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Temp_Sort_Operating_Min_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Temp_System_Operating_Min_F]() As Double
      Get
      Return Properties("Temp_System_Operating_Min_F").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Temp_System_Operating_Min_F").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Temp_System_Operating_Min_UOM]() As String
      Get
      Return Properties("Temp_System_Operating_Min_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Temp_System_Operating_Min_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Temp_System_Operating_Min_User]() As Double
      Get
      Return Properties("Temp_System_Operating_Min_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Temp_System_Operating_Min_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Totes_Plastic]() As Boolean
      Get
      Return Properties("Totes_Plastic").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Totes_Plastic").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Totes_Plastic_Type]() As String
      Get
      Return Properties("Totes_Plastic_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Totes_Plastic_Type").CalculatedValue = Value
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
    
          Public Property [Valid]() As Boolean
      Get
      Return Properties("Valid").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Valid").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Valid_Message]() As String
      Get
      Return Properties("Valid_Message").Value
      End Get
      Set(ByVal Value As String)
      Properties("Valid_Message").CalculatedValue = Value
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
    InitPart("APC_Setup", <a><![CDATA[APC_Setup]]></a>.Value, 119, "APCTMP01",  "N", "N", True, False, "In Development", "", "Initially Application Setup Object", "", "", "",  "GLOBAL\H601424", "07/16/2025 19:17:39")
    AddProperty("3778", "Belt_InclineDecline_Max_Deg", <a><![CDATA[Belt InclineDecline Max Deg (Degrees)]]></a>.Value, "Max. Belt Incline/Decline Angle for Stable Product (in Degrees)", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/18/2025 6:37:40 PM")
    AddProperty("3170", "BoxSize_Height_Avg_IN", <a><![CDATA[BoxSize Height Avg IN]]></a>.Value, "BoxSize Height Avg IN", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:37:24 PM")
    AddProperty("3158", "BoxSize_Height_Avg_User", <a><![CDATA[BoxSize Height Avg User]]></a>.Value, "Todo: Enter Description from Spreadsheet", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:21:15 PM")
    AddProperty("3171", "BoxSize_Height_Avg_User_UOM", <a><![CDATA[BoxSize Height Avg User UOM]]></a>.Value, "BoxSize Height Avg User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:11:09 PM")
    AddProperty("3776", "BoxSize_Height_GRTR_Len_Possible", <a><![CDATA[BoxSize Height GRTR Len Possible]]></a>.Value, "Within MTBH Range, Can Product Heights be > Length?", "Boolean","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 12:33:45 PM")
    AddProperty("3296", "BoxSize_Height_Max_IN", <a><![CDATA[BoxSize Height Max IN]]></a>.Value, "BoxSize Height Max IN", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:37:44 PM")
    AddProperty("3160", "BoxSize_Height_Max_User", <a><![CDATA[BoxSize Height Max User]]></a>.Value, "Todo: Enter Description from Spreadsheet", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:21:57 PM")
    AddProperty("3247", "BoxSize_Height_Max_User_UOM", <a><![CDATA[BoxSize Height Max User UOM]]></a>.Value, "BoxSize Height Max User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:12:05 PM")
    AddProperty("3297", "BoxSize_Height_Min_IN", <a><![CDATA[BoxSize Height Min IN]]></a>.Value, "BoxSize Height Min IN", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:38:00 PM")
    AddProperty("3159", "BoxSize_Height_Min_User", <a><![CDATA[BoxSize Height Min User]]></a>.Value, "The allowable input range is 0.75 inch (19.05 mm) to the defined ""Average Height"". Conveying product heights below 0.75 inch (19.05 mm) is possible, but requires special design considerations system wide and needs PAE/engineering approval.", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:21:33 PM")
    AddProperty("3246", "BoxSize_Height_Min_User_UOM", <a><![CDATA[BoxSize Height Min User UOM]]></a>.Value, "BoxSize Height Min User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:11:33 PM")
    AddProperty("3298", "BoxSize_Length_Avg_IN", <a><![CDATA[BoxSize Length Avg IN]]></a>.Value, "BoxSize Length Avg IN", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:38:18 PM")
    AddProperty("3161", "BoxSize_Length_Avg_User", <a><![CDATA[BoxSize Length Avg User]]></a>.Value, "Todo: Enter Description from Spreadsheet", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:22:21 PM")
    AddProperty("3248", "BoxSize_Length_Avg_User_UOM", <a><![CDATA[BoxSize Length Avg User UOM]]></a>.Value, "BoxSize Length Avg User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:12:26 PM")
    AddProperty("3299", "BoxSize_Length_Max_IN", <a><![CDATA[BoxSize Length Max IN]]></a>.Value, "BoxSize Length Max IN", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:38:43 PM")
    AddProperty("3300", "BoxSize_Length_Max_MM", <a><![CDATA[BoxSize Length Max MM]]></a>.Value, "BoxSize Length Max MM", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:39:04 PM")
    AddProperty("3163", "BoxSize_Length_Max_User", <a><![CDATA[BoxSize Length Max User]]></a>.Value, "Todo: Enter Description from Spreadsheet", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:23:07 PM")
    AddProperty("3250", "BoxSize_Length_Max_User_UOM", <a><![CDATA[BoxSize Length Max User UOM]]></a>.Value, "BoxSize Length Max User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:18:23 PM")
    AddProperty("3301", "BoxSize_Length_Min_IN", <a><![CDATA[BoxSize Length Min IN]]></a>.Value, "BoxSize Length Min IN", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:39:30 PM")
    AddProperty("3302", "BoxSize_Length_Min_MM", <a><![CDATA[BoxSize Length Min MM]]></a>.Value, "BoxSize Length Min MM", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 12:27:12 PM")
    AddProperty("3162", "BoxSize_Length_Min_User", <a><![CDATA[BoxSize Length Min User]]></a>.Value, "Allowable input range is 4 inches (101.6 mm) to defined ""Average Length"" in inches. Minimum lengths less than 6 inches (152.4 mm) must be conveyed on belt or suitable sorters only. Minimum lengths less than 9 inch (228.6 mm) require roller conveyors with 2 inch (50.8 mm) roller centers.", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:22:36 PM")
    AddProperty("3249", "BoxSize_Length_Min_User_UOM", <a><![CDATA[BoxSize Length Min User UOM]]></a>.Value, "BoxSize Length Min User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:12:49 PM")
    AddProperty("3777", "BoxSize_Other_Known_Issues", <a><![CDATA[BoxSize Other Known Issues]]></a>.Value, "Other Known or Potential Product Stability Issues Exist?", "Boolean","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 12:36:38 PM")
    AddProperty("3157", "BoxSize_User_UOM", <a><![CDATA[BoxSize User UOM]]></a>.Value, "Default UOM For Box Size", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/12/2025 10:13:18 PM")
    AddProperty("3303", "BoxSize_Weight_Avg_LBS", <a><![CDATA[BoxSize Weight Avg LBS]]></a>.Value, "BoxSize Weight Avg LBS", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 2:11:55 PM")
    AddProperty("3167", "BoxSize_Weight_Avg_User", <a><![CDATA[BoxSize Weight Avg User]]></a>.Value, "Todo: Enter Description from Spreadsheet", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:24:27 PM")
    AddProperty("3254", "BoxSize_Weight_Avg_User_UOM", <a><![CDATA[BoxSize Weight Avg User UOM]]></a>.Value, "BoxSize Weight Avg User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/19/2025 12:11:07 PM")
    AddProperty("3760", "BoxSize_Weight_Max_LBS", <a><![CDATA[BoxSize Weight Max LBS]]></a>.Value, "BoxSize Weight Max LBS", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 2:06:40 PM")
    AddProperty("3169", "BoxSize_Weight_Max_User", <a><![CDATA[BoxSize Weight Max User]]></a>.Value, "Todo: Enter Description from Spreadsheet", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:25:17 PM")
    AddProperty("3295", "BoxSize_Weight_Max_User_UOM", <a><![CDATA[BoxSize Weight Max User UOM]]></a>.Value, "BoxSize Weight Max User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/19/2025 12:11:44 PM")
    AddProperty("3761", "BoxSize_Weight_Min_LBS", <a><![CDATA[BoxSize Weight Min LBS]]></a>.Value, "BoxSize Weight Min LBS", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/19/2025 12:12:16 PM")
    AddProperty("3168", "BoxSize_Weight_Min_User", <a><![CDATA[BoxSize Weight Min User]]></a>.Value, "The allowable input range is 0.5 LBS (0.23 Kg) to the defined Maximum Weight.", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:24:45 PM")
    AddProperty("3255", "BoxSize_Weight_Min_User_UOM", <a><![CDATA[BoxSize Weight Min User UOM]]></a>.Value, "BoxSize Weight Min User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/19/2025 12:13:21 PM")
    AddProperty("3763", "BoxSize_Width_Avg_IN", <a><![CDATA[BoxSize Width Avg IN]]></a>.Value, "BoxSize Width Avg IN", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 12:29:02 PM")
    AddProperty("3164", "BoxSize_Width_Avg_User", <a><![CDATA[BoxSize Width Avg User]]></a>.Value, "Todo: Enter Description from Spreadsheet", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:23:30 PM")
    AddProperty("3251", "BoxSize_Width_Avg_User_UOM", <a><![CDATA[BoxSize Width Avg User UOM]]></a>.Value, "BoxSize Width Avg User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:18:41 PM")
    AddProperty("3765", "BoxSize_Width_Max_IN", <a><![CDATA[BoxSize Width Max IN]]></a>.Value, "BoxSize Width Max IN", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 12:29:42 PM")
    AddProperty("3767", "BoxSize_Width_Max_MM", <a><![CDATA[BoxSize Width Max MM]]></a>.Value, "BoxSize Width Max MM", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 12:30:11 PM")
    AddProperty("3166", "BoxSize_Width_Max_User", <a><![CDATA[BoxSize Width Max User]]></a>.Value, "Todo: Enter Description from Spreadsheet", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:24:13 PM")
    AddProperty("3253", "BoxSize_Width_Max_User_UOM", <a><![CDATA[BoxSize Width Max User UOM]]></a>.Value, "BoxSize Width Max User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:19:33 PM")
    AddProperty("3768", "BoxSize_Width_Min_IN", <a><![CDATA[BoxSize Width Min IN]]></a>.Value, "BoxSize Width Min IN", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 12:30:33 PM")
    AddProperty("3769", "BoxSize_Width_Min_MM", <a><![CDATA[BoxSize Width Min MM]]></a>.Value, "BoxSize Width Min MM", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 12:30:54 PM")
    AddProperty("3165", "BoxSize_Width_Min_User", <a><![CDATA[BoxSize Width Min User]]></a>.Value, "The allowable input range is from 4 inches (101.6 mm) to the defined ""Average Width"".", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:23:56 PM")
    AddProperty("3252", "BoxSize_Width_Min_User_UOM", <a><![CDATA[BoxSize Width Min User UOM]]></a>.Value, "BoxSize Width Min User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:19:06 PM")
    AddProperty("4533", "BoxSize_Worst_Case_Height_IN", <a><![CDATA[BoxSize_Worst_Case_Height IN]]></a>.Value, "Allowable input range is between the defined MTBH Minimum Product Length and Maximum Product Length.", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/18/2025 6:07:28 PM")
    AddProperty("3306", "BoxSize_Worst_Case_HL_Ratio", <a><![CDATA[BoxSize Worst Case HL Ratio]]></a>.Value, "Is this a Worst Case Scenario Box Size Arrangent", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/18/2025 6:24:07 PM")
    AddProperty("4534", "BoxSize_Worst_Case_Length_IN", <a><![CDATA[BoxSize_Worst_Case_Length IN]]></a>.Value, "Allowable input range is between the defined MTBH Minimum Product Length and Maximum Product Length.", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/18/2025 6:08:06 PM")
    AddProperty("4892", "Case_Length_Per_Minute_Target_FT", <a><![CDATA[Case_Length_Per_Minute_Target_FT]]></a>.Value, "Target Case Length per Minute (in Feet)", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/24/2025 3:22:03 PM")
    AddProperty("4891", "Case_Length_Per_Minute_Target_M", <a><![CDATA[Case_Length_Per_Minute_Target_M]]></a>.Value, "Target Case Length per Minute (in Meters)", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/24/2025 2:24:13 PM")
    AddProperty("4521", "Conveyor_BF_Selected_Min_IN", <a><![CDATA[Conveyor_BF_Selected_Min_IN]]></a>.Value, "Selected Minimum System Conveyor Width (B/F - Inches)", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/23/2025 4:55:28 PM")
    AddProperty("4522", "Conveyor_BF_Selected_Min_User", <a><![CDATA[Conveyor_BF_Selected_Min_User]]></a>.Value, "Selected Minimum System Conveyor Width (B/F - Inches)", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/23/2025 4:59:25 PM")
    AddProperty("4523", "Conveyor_BF_Selected_Min_User_UOM", <a><![CDATA[Conveyor_BF_Selected_Min_User_UOM]]></a>.Value, "Selected Minimum System Conveyor Width (UOM)", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/23/2025 4:55:37 PM")
    AddProperty("4519", "Conveyor_Curve_BF_Calc_Min_In", <a><![CDATA[Conveyor Curve BF Calc Min In]]></a>.Value, "Calculated Min Curve B/F (Min. Calculated Curve Conveyor Width)", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/19/2025 12:06:03 PM")
    AddProperty("4520", "Conveyor_Curve_BF_Calc_Rcmd_In", <a><![CDATA[Conveyor Curve BF Calc Rcmd In]]></a>.Value, "Recommended B/F for App (Minimum Recommended Conveyor Width)  Minimum Calculated Conveyor Width:
This is the recommended minimum conveyor width (B/F dimension) based on the Material-to-be-Handled max. dimensions defined in the section above. This minimum width is determined using Intelligrated's standard published product/curve dimension formula.", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/23/2025 4:30:48 PM")
    AddProperty("4827", "Conveyor_Curve_OffSet_Guide_Viable", <a><![CDATA[Conveyor_Curve_OffSet_Guide_Viable]]></a>.Value, "Offset Guide Option for Curves Viable for This App?  (2""- 50mm Max)", "Boolean","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/23/2025 4:40:58 PM")
    AddProperty("4518", "Conveyor_Inside_Radius_Min_IN", <a><![CDATA[Conveyor Inside Radius Min IN]]></a>.Value, "Inside Radius of Curve", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/19/2025 12:03:35 PM")
    AddProperty("3785", "Conveyor_Product_Line_Used", <a><![CDATA[Conveyor Product Line Used]]></a>.Value, "Control system used for Primary Merge/Sortation?", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 12:40:12 PM")
    AddProperty("4524", "Conveyor_Skew_Bed_Length_Min_Reqd_IN", <a><![CDATA[Conveyor Skew Bed Length Min Reqd IN]]></a>.Value, "Minimum Required Skew Bed Length for Selected MTBH Width and BF", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/24/2025 12:31:10 PM")
    AddProperty("4526", "Conveyor_Skew_Bed_Length_MTBH_Width_IN", <a><![CDATA[Conveyor Skew Bed Length MTBH Width IN]]></a>.Value, "Minimum Required Skew Bed Length for Selected MTBH Width and BF", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/24/2025 11:59:57 AM")
    AddProperty("4525", "Conveyor_Skew_Total_Length_MTBH_Width_IN", <a><![CDATA[Conveyor Skew Total Length MTBH Width IN]]></a>.Value, "Total Skew Length Required for Selected MTBH Width and BF", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/24/2025 11:53:07 AM")
    AddProperty("4517", "Conveyor_Width_Min_IN", <a><![CDATA[Conveyor Width Min IN]]></a>.Value, "Min. Allowable Straight Conveyor Width  ' =VLOOKUP(BoxSize_Width_Max_IN+1.99,$S$55:$U$60,2,TRUE)  'B/F (Imperial)  IR '0 16 30 '16 22 40 '22 28 50 '28 34 60 '34 40 60 '40 40 60", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/23/2025 4:26:26 PM")
    AddProperty("3154", "Customer_Location_CityState", <a><![CDATA[Customer Location CityState]]></a>.Value, "Customer's Site Location (City, St)", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/16/2025 7:17:39 PM")
    AddProperty("3153", "Customer_Name", <a><![CDATA[Customer Name]]></a>.Value, "Customer Name (From Salesforce ePRD If Available)", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/16/2025 7:16:14 PM")
    AddProperty("3774", "Live_Load_Avg_KGM", <a><![CDATA[Live Load Avg KGM]]></a>.Value, "Live Load", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/19/2025 12:16:35 PM")
    AddProperty("3773", "Live_Load_Avg_LBSFT", <a><![CDATA[Live Load Avg LBSFT]]></a>.Value, "Live Load", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 2:14:19 PM")
    AddProperty("3308", "Live_Load_Avg_User", <a><![CDATA[Live Load Avg User]]></a>.Value, "Live Load (Average)", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 2:11:18 PM")
    AddProperty("3856", "Live_Load_Avg_User_UOM", <a><![CDATA[Live_Load_Avg_User_UOM]]></a>.Value, "Live Load (UOM)", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/19/2025 12:16:28 PM")
    AddProperty("4529", "Material_Gap_Override_IN", <a><![CDATA[Material Gap Override IN]]></a>.Value, "Global Design Gap Override", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/18/2025 5:28:45 PM")
    AddProperty("4530", "Material_Gap_Override_MM", <a><![CDATA[Material Gap Override MM]]></a>.Value, "Global Design Gap Override", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/18/2025 5:29:13 PM")
    AddProperty("4528", "Material_Gap_Override_User", <a><![CDATA[Material Gap Override User]]></a>.Value, "Global Design Gap Override", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/18/2025 5:38:22 PM")
    AddProperty("4531", "Material_Gap_Override_User_UOM", <a><![CDATA[Material Gap Override User UOM]]></a>.Value, "Global Design Gap Override  (UOM)", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/18/2025 5:38:36 PM")
    AddProperty("3156", "Proposal_Date", <a><![CDATA[Proposal_Date]]></a>.Value, "Salesface Proposal Date", "Date","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/16/2025 7:16:31 PM")
    AddProperty("3155", "Proposal_No", <a><![CDATA[Proposal_No]]></a>.Value, "IGS Proposal Number", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/16/2025 7:16:42 PM")
    AddProperty("3307", "Selected_Sortation_Controls", <a><![CDATA[Selected Sortation Controls]]></a>.Value, "Control system used for Primary Merge/Sortation? ICW & Boss Control platforms are now in ""sunset"" status and should not used for new projects moving forward.", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 12:36:08 PM")
    AddProperty("3770", "Sort_Dual_Sided", <a><![CDATA[Sort Dual Sided]]></a>.Value, "Dual Sided Sort Application?", "Boolean","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 12:31:09 PM")
    AddProperty("3771", "Sort_Rate_Required_CPM", <a><![CDATA[Sort_Rate_Required_CPM]]></a>.Value, "Target Sortation Rate (CPM)  This is the maximum expected throughput the sortation system is to be designed to convey with the carton parameters input above. Allowable input range for this parameter is 5 to 400 CPM.", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/24/2025 2:19:48 PM")
    AddProperty("3781", "Temp_Sort_Operating_Min_F", <a><![CDATA[Temp Sort Operating Min F]]></a>.Value, "Min. Operating Temp. for Sorter Environment", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/18/2025 7:02:27 PM")
    AddProperty("3779", "Temp_Sort_Operating_Min_User", <a><![CDATA[Temp Sort Operating Min User]]></a>.Value, "Min. Operating Temp. for Sorter Environment", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 12:37:15 PM")
    AddProperty("3780", "Temp_Sort_Operating_Min_User_UOM", <a><![CDATA[Temp Sort Operating Min User UOM]]></a>.Value, "Temp Sort Operating Min User UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/18/2025 7:04:54 PM")
    AddProperty("3784", "Temp_System_Operating_Min_F", <a><![CDATA[Temp System Operating Min F]]></a>.Value, "Min. Operating Temp. for System Environment", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/18/2025 7:01:46 PM")
    AddProperty("3783", "Temp_System_Operating_Min_UOM", <a><![CDATA[Temp System Operating Min UOM]]></a>.Value, "Temp System Operating Min UOM", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/18/2025 6:53:19 PM")
    AddProperty("3782", "Temp_System_Operating_Min_User", <a><![CDATA[Temp System Operating Min User]]></a>.Value, "Min. Operating Temp. for System Environment", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 12:38:49 PM")
    AddProperty("3775", "Totes_Plastic", <a><![CDATA[Totes Plastic]]></a>.Value, "Are Plastic Totes Used?", "Boolean","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/16/2025 12:33:23 PM")
    AddProperty("4532", "Totes_Plastic_Type", <a><![CDATA[Totes Plastic Type]]></a>.Value, "Type of Plastic Tote Used", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/18/2025 5:38:54 PM")
    AddProperty("3172", "User_UOM_System", <a><![CDATA[User UOM System]]></a>.Value, "Default UOM System", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "6/13/2025 6:10:22 PM")
    AddProperty("9795", "Valid", <a><![CDATA[Valid]]></a>.Value, "Are Plastic Totes Used?", "Boolean","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/10/2025 2:33:56 PM")
    AddProperty("9794", "Valid_Message", <a><![CDATA[Valid_Message]]></a>.Value, "Customer Name (From Salesforce ePRD If Available)", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H621516", "7/16/2025 2:03:18 PM")
    AddProperty("715", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/24/2025 5:32:55 PM")
    
      AddValidValue("BoxSize_Height_Avg_User_UOM")
    
      AddValidValue("BoxSize_Height_Max_User_UOM")
    
      AddValidValue("BoxSize_Height_Min_User_UOM")
    
      AddValidValue("BoxSize_Length_Avg_User_UOM")
    
      AddValidValue("BoxSize_Length_Max_User_UOM")
    
      AddValidValue("BoxSize_Length_Min_User_UOM")
    
      AddValidValue("BoxSize_Weight_Avg_User_UOM")
    
      AddValidValue("BoxSize_Weight_Max_User_UOM")
    
      AddValidValue("BoxSize_Weight_Min_User_UOM")
    
      AddValidValue("BoxSize_Width_Avg_User_UOM")
    
      AddValidValue("BoxSize_Width_Max_User_UOM")
    
      AddValidValue("BoxSize_Width_Min_User_UOM")
    
      AddValidValue("Conveyor_BF_Selected_Min_User")
    
      AddValidValue("Conveyor_BF_Selected_Min_User_UOM")
    
      AddValidValue("Conveyor_Product_Line_Used")
    
      AddValidValue("Live_Load_Avg_User_UOM")
    
      AddValidValue("Material_Gap_Override_User_UOM")
    
      AddValidValue("Selected_Sortation_Controls")
    
      AddValidValue("Temp_Sort_Operating_Min_User_UOM")
    
      AddValidValue("Temp_System_Operating_Min_UOM")
    
      AddValidValue("Totes_Plastic_Type")
    
      AddValidValue("User_UOM_System")
    
      oConnection = AddConnection("My_PRD", <a><![CDATA[My PRD]]></a>.Value, "", "115", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "6/18/2025 9:30:13 PM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      
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
          InitProperty("Belt_InclineDecline_Max_Deg", "3408", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 6:37:40 PM", "Max. Belt Incline/Decline Angle for Stable Product (in Degrees)", "In Development",  0,5690)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Height_Avg_IN", "2804", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:37:24 PM", "BoxSize Height Avg IN", "In Development",  0,4307)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Height_Avg_User", "2792", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:21:15 PM", "Todo: Enter Description from Spreadsheet", "In Development",  0,4139)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Height_Avg_User_UOM", "2805", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:11:09 PM", "BoxSize Height Avg User UOM", "In Development",  0,4137)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Height_GRTR_Len_Possible", "3406", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 12:33:45 PM", "Within MTBH Range, Can Product Heights be > Length?", "In Development",  0,4785)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Height_Max_IN", "2926", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:37:44 PM", "BoxSize Height Max IN", "In Development",  0,4308)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Height_Max_User", "2794", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:21:57 PM", "Todo: Enter Description from Spreadsheet", "In Development",  0,4240)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Height_Max_User_UOM", "2878", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:12:05 PM", "BoxSize Height Max User UOM", "In Development",  0,4219)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Height_Min_IN", "2927", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:38:00 PM", "BoxSize Height Min IN", "In Development",  0,4309)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Height_Min_User", "2793", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:21:33 PM", "The allowable input range is 0.75 inch (19.05 mm) to the defined ""Average Height"". Conveying product heights below 0.75 inch (19.05 mm) is possible, but requires special design considerations system wide and needs PAE/engineering approval.", "In Development",  0,4239)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Height_Min_User_UOM", "2877", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:11:33 PM", "BoxSize Height Min User UOM", "In Development",  0,4217)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Avg_IN", "2928", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:38:18 PM", "BoxSize Length Avg IN", "In Development",  0,4310)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Avg_User", "2795", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:22:21 PM", "Todo: Enter Description from Spreadsheet", "In Development",  0,4241)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Avg_User_UOM", "2879", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:12:26 PM", "BoxSize Length Avg User UOM", "In Development",  0,4221)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Max_IN", "2929", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:38:43 PM", "BoxSize Length Max IN", "In Development",  0,4311)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Max_MM", "2930", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:39:04 PM", "BoxSize Length Max MM", "In Development",  0,4312)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Max_User", "2797", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:23:07 PM", "Todo: Enter Description from Spreadsheet", "In Development",  0,4244)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Max_User_UOM", "2881", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:18:23 PM", "BoxSize Length Max User UOM", "In Development",  0,4225)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Min_IN", "2931", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:39:30 PM", "BoxSize Length Min IN", "In Development",  0,4313)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Min_MM", "2932", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 12:27:12 PM", "BoxSize Length Min MM", "In Development",  0,4765)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Min_User", "2796", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:22:36 PM", "Allowable input range is 4 inches (101.6 mm) to defined ""Average Length"" in inches. Minimum lengths less than 6 inches (152.4 mm) must be conveyed on belt or suitable sorters only. Minimum lengths less than 9 inch (228.6 mm) require roller conveyors with 2 inch (50.8 mm) roller centers.", "In Development",  0,4243)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Length_Min_User_UOM", "2880", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:12:49 PM", "BoxSize Length Min User UOM", "In Development",  0,4223)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Other_Known_Issues", "3407", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 12:36:38 PM", "Other Known or Potential Product Stability Issues Exist?", "In Development",  0,4786)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_User_UOM", "2791", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/12/2025 10:13:18 PM", "Default UOM For Box Size", "In Development",  0,4123)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Avg_LBS", "2933", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 2:11:55 PM", "BoxSize Weight Avg LBS", "In Development",  0,4876)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Avg_User", "2801", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:24:27 PM", "Todo: Enter Description from Spreadsheet", "In Development",  0,4248)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Avg_User_UOM", "2885", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/19/2025 12:11:07 PM", "BoxSize Weight Avg User UOM", "In Development",  0,5783)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Max_LBS", "3390", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 2:06:40 PM", "BoxSize Weight Max LBS", "In Development",  0,4868)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Max_User", "2803", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:25:17 PM", "Todo: Enter Description from Spreadsheet", "In Development",  0,4251)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Max_User_UOM", "2925", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/19/2025 12:11:44 PM", "BoxSize Weight Max User UOM", "In Development",  0,5785)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Min_LBS", "3391", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/19/2025 12:12:16 PM", "BoxSize Weight Min LBS", "In Development",  0,5788)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Min_User", "2802", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:24:45 PM", "The allowable input range is 0.5 LBS (0.23 Kg) to the defined Maximum Weight.", "In Development",  0,4249)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Weight_Min_User_UOM", "2886", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/19/2025 12:13:21 PM", "BoxSize Weight Min User UOM", "In Development",  0,5789)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Avg_IN", "3393", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 12:29:02 PM", "BoxSize Width Avg IN", "In Development",  0,4772)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Avg_User", "2798", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:23:30 PM", "Todo: Enter Description from Spreadsheet", "In Development",  0,4245)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Avg_User_UOM", "2882", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:18:41 PM", "BoxSize Width Avg User UOM", "In Development",  0,4227)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Max_IN", "3395", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 12:29:42 PM", "BoxSize Width Max IN", "In Development",  0,4774)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Max_MM", "3397", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 12:30:11 PM", "BoxSize Width Max MM", "In Development",  0,4776)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Max_User", "2800", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:24:13 PM", "Todo: Enter Description from Spreadsheet", "In Development",  0,4247)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Max_User_UOM", "2884", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:19:33 PM", "BoxSize Width Max User UOM", "In Development",  0,4231)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Min_IN", "3398", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 12:30:33 PM", "BoxSize Width Min IN", "In Development",  0,4777)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Min_MM", "3399", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 12:30:54 PM", "BoxSize Width Min MM", "In Development",  0,4778)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Min_User", "2799", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:23:56 PM", "The allowable input range is from 4 inches (101.6 mm) to the defined ""Average Width"".", "In Development",  0,4246)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Width_Min_User_UOM", "2883", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:19:06 PM", "BoxSize Width Min User UOM", "In Development",  0,4229)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Worst_Case_Height_IN", "4161", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 6:07:28 PM", "Allowable input range is between the defined MTBH Minimum Product Length and Maximum Product Length.", "In Development",  0,5685)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Worst_Case_HL_Ratio", "2936", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 6:24:07 PM", "Is this a Worst Case Scenario Box Size Arrangent", "In Development",  0,5689)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxSize_Worst_Case_Length_IN", "4162", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 6:08:06 PM", "Allowable input range is between the defined MTBH Minimum Product Length and Maximum Product Length.", "In Development",  0,5686)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Case_Length_Per_Minute_Target_FT", "4513", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/24/2025 2:52:38 PM", "", "In Development",  0,6536)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Case_Length_Per_Minute_Target_M", "4512", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/24/2025 2:24:13 PM", "", "In Development",  0,6537)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_BF_Selected_Min_IN", "4149", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/23/2025 4:55:28 PM", "Selected Minimum System Conveyor Width (B/F - Inches)", "In Development",  0,6389)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_BF_Selected_Min_User", "4150", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "6/23/2025 4:59:25 PM", "Selected Minimum System Conveyor Width (B/F - Inches)", "In Development",  0,6391)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_BF_Selected_Min_User_UOM", "4151", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/23/2025 4:55:37 PM", "Selected Minimum System Conveyor Width (UOM)", "In Development",  0,5665)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_Curve_BF_Calc_Min_In", "4147", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/19/2025 12:06:03 PM", "Calculated Min Curve B/F (Min. Calculated Curve Conveyor Width)", "In Development",  0,5781)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_Curve_BF_Calc_Rcmd_In", "4148", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/23/2025 4:30:48 PM", "Recommended B/F for App (Minimum Recommended Conveyor Width) Minimum Calculated Conveyor Width:
This is the recommended minimum conveyor width (B/F dimension) based on the Material-to-be-Handled max. dimensions defined in the section above. This minimum width is determined using Intelligrated's standard published product/curve dimension formula.", "In Development",  0,6386)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_Curve_OffSet_Guide_Viable", "4450", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/23/2025 4:40:58 PM", "Dual Sided Sort Application?", "In Development",  0,6388)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_Inside_Radius_Min_IN", "4146", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/19/2025 12:03:12 PM", "Inside Radius of Curve", "In Development",  0,5775)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_Product_Line_Used", "3415", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 12:40:12 PM", "Control system used for Primary Merge/Sortation?", "In Development",  0,4794)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_Skew_Bed_Length_Min_Reqd_IN", "4152", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/24/2025 12:31:10 PM", "Minimum Required Skew Bed Length for Selected MTBH Width and BF", "In Development",  0,6519)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_Skew_Bed_Length_MTBH_Width_IN", "4154", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/24/2025 11:59:57 AM", "Minimum Required Skew Bed Length for Selected MTBH Width and BF", "In Development",  0,6509)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_Skew_Total_Length_MTBH_Width_IN", "4153", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/24/2025 11:53:07 AM", "Total Skew Length Required for Selected MTBH Width and BF", "In Development",  0,6502)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conveyor_Width_Min_IN", "4145", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/23/2025 4:26:26 PM", "Min. Allowable Straight Conveyor Width", "In Development",  0,6385)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_Location_CityState", "2788", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 7:17:39 PM", "Customer's Site Location (City, St)", "In Development",  0,5730)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_Name", "2787", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 7:16:14 PM", "Customer Name (From Salesforce ePRD If Available)", "In Development",  0,5732)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Live_Load_Avg_KGM", "3404", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 2:14:32 PM", "Live Load", "In Development",  0,4823)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Live_Load_Avg_LBSFT", "3403", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 2:14:19 PM", "Live Load", "In Development",  0,4882)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Live_Load_Avg_User", "2938", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 2:11:18 PM", "Live Load (Average)", "In Development",  0,4306)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Live_Load_Avg_User_UOM", "3486", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/19/2025 12:16:28 PM", "Live Load (UOM)", "In Development",  0,5790)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Material_Gap_Override_IN", "4157", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 5:28:45 PM", "Global Design Gap Override", "In Development",  0,5676)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Material_Gap_Override_MM", "4158", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 5:29:13 PM", "Global Design Gap Override", "In Development",  0,5677)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Material_Gap_Override_User", "4156", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 5:38:22 PM", "Global Design Gap Override", "In Development",  0,5675)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Material_Gap_Override_User_UOM", "4159", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 5:38:36 PM", "Global Design Gap Override  (UOM)", "In Development",  0,5678)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_Date", "2790", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 7:16:31 PM", "Salesface Proposal Date", "In Development",  0,4291)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_No", "2789", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 7:16:42 PM", "IGS Proposal Number", "In Development",  0,5733)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Selected_Sortation_Controls", "2937", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 12:36:08 PM", "Control system used for Primary Merge/Sortation? ICW & Boss Control platforms are now in ""sunset"" status and should not used for new projects moving forward.", "In Development",  0,4304)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Dual_Sided", "3400", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 12:31:09 PM", "Dual Sided Sort Application?", "In Development",  0,4779)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sort_Rate_Required_CPM", "3401", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 5:22:47 PM", "Target Sortation Rate (CPM)  This is the maximum expected throughput the sortation system is to be designed to convey with the carton parameters input above. Allowable input range for this parameter is 5 to 400 CPM.", "In Development",  0,4780)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Temp_Sort_Operating_Min_F", "3411", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 7:02:27 PM", "Min. Operating Temp. for Sorter Environment", "In Development",  0,5697)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Temp_Sort_Operating_Min_User", "3409", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 12:37:15 PM", "Min. Operating Temp. for Sorter Environment", "In Development",  0,4788)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Temp_Sort_Operating_Min_User_UOM", "3410", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 7:04:49 PM", "Temp Sort Operating Min User UOM", "In Development",  0,5699)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Temp_System_Operating_Min_F", "3414", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 7:01:46 PM", "Min. Operating Temp. for System Environment", "In Development",  0,5696)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Temp_System_Operating_Min_UOM", "3413", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 6:53:19 PM", "Temp System Operating Min UOM", "In Development",  0,5693)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Temp_System_Operating_Min_User", "3412", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 12:38:49 PM", "Min. Operating Temp. for System Environment", "In Development",  0,4791)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Totes_Plastic", "3405", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/16/2025 12:33:23 PM", "Are Plastic Totes Used?", "In Development",  0,4784)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Totes_Plastic_Type", "4160", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 5:38:54 PM", "Type of Plastic Tote Used", "In Development",  0,5680)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("User_UOM_System", "2806", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/13/2025 6:10:22 PM", "Default UOM System", "In Development",  0,4145)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Valid", "9381", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/10/2025 2:33:56 PM", "Are Plastic Totes Used?", "In Development",  0,16048)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Valid_Message", "9380", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H621516", "7/16/2025 2:03:18 PM", "Customer Name (From Salesforce ePRD If Available)", "In Development",  0,17492)
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
          
        InitValidValue("BoxSize_Height_Avg_User_UOM_ValidValues", "2805", "-1", 4138)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Height_Max_User_UOM_ValidValues", "2878", "-1", 4220)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Height_Min_User_UOM_ValidValues", "2877", "-1", 4218)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Length_Avg_User_UOM_ValidValues", "2879", "-1", 4222)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Length_Max_User_UOM_ValidValues", "2881", "-1", 4226)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Length_Min_User_UOM_ValidValues", "2880", "-1", 4224)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Weight_Avg_User_UOM_ValidValues", "2885", "-1", 5784)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Weight_Max_User_UOM_ValidValues", "2925", "-1", 5786)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Weight_Min_User_UOM_ValidValues", "2886", "-1", 5787)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Width_Avg_User_UOM_ValidValues", "2882", "-1", 4228)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Width_Max_User_UOM_ValidValues", "2884", "-1", 4232)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("BoxSize_Width_Min_User_UOM_ValidValues", "2883", "-1", 4230)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Conveyor_BF_Selected_Min_User_ValidValues", "4150", "-1", 5669)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Conveyor_BF_Selected_Min_User_UOM_ValidValues", "4151", "-1", 5666)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Conveyor_Product_Line_Used_ValidValues", "3415", "-1", 4795)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Live_Load_Avg_User_UOM_ValidValues", "3486", "-1", 5791)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Material_Gap_Override_User_UOM_ValidValues", "4159", "-1", 5679)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Selected_Sortation_Controls_ValidValues", "2937", "-1", 4305)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Temp_Sort_Operating_Min_User_UOM_ValidValues", "3410", "-1", 5698)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Temp_System_Operating_Min_UOM_ValidValues", "3413", "-1", 5694)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Totes_Plastic_Type_ValidValues", "4160", "-1", 5681)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("User_UOM_System_ValidValues", "2806", "-1", 4146)
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
          
        InitConnection("My_PRD", "95", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "6/18/2025 9:30:13 PM", "", "In Development", "N",166)
        
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
        '   BEGIN FORMULA; CON ID:95; TYPE:PF
        Result = Me.Parent.My_Prd(1)
        '   END FORMULA; CON ID:95; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_My_PRD_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Belt_InclineDecline_Max_Deg() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Belt_InclineDecline_Max_Deg").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3408; TYPE:PF
      Result = 0 ' TODO: Fix
'S33 = IF(AND(BoxSize_Worst_Case_Length_IN>0,BoxSize_Worst_Case_Height_IN>0),DEGREES(ATAN((BoxSize_Worst_Case_Length_IN/6)/(BoxSize_Worst_Case_Height_IN/2))),0)
If BoxSize_Worst_Case_Length_IN >0 And BoxSize_Worst_Case_Height_IN >0 Then
	Result  = Math.Atan((BoxSize_Worst_Case_Length_IN / 6) / (BoxSize_Worst_Case_Height_IN / 2)) * (180 / Math.PI)
Else
	Result = 0
End If

' =IF(AND(Totes_Plastic="No",S33<=18,Box_Height_GRTR_Len_Possible="Yes"),S33,IF(Totes_Plastic="Yes",15,18))

If Totes_Plastic = False And BoxSize_Height_GRTR_Len_Possible = True Then
	'Use Current Result
Else
	If Totes_Plastic Then 
		Result = 15
	Else
		Result = 18
	End If
End If
      '   END FORMULA; PROP ID:3408; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Belt_InclineDecline_Max_Deg", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Height_Avg_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Height_Avg_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2804; TYPE:PF
      result = Units.Convert(Me.BoxSize_Height_Avg_User,"IN", Me.BoxSize_Height_Avg_User_UOM)
      '   END FORMULA; PROP ID:2804; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Height_Avg_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Height_Avg_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Height_Avg_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2792; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2792; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Height_Avg_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Height_Avg_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Height_Avg_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2805; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:2805; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Height_Avg_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Height_GRTR_Len_Possible() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Height_GRTR_Len_Possible").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3406; TYPE:PF
      result = False
      '   END FORMULA; PROP ID:3406; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Height_GRTR_Len_Possible", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Height_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Height_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2926; TYPE:PF
      result = Units.Convert(Me.BoxSize_Height_Max_User,"IN", Me.BoxSize_Height_Max_User_UOM)
      '   END FORMULA; PROP ID:2926; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Height_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Height_Max_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Height_Max_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2794; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2794; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Height_Max_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Height_Max_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Height_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2878; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:2878; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Height_Max_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Height_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Height_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2927; TYPE:PF
      result = Units.Convert(Me.BoxSize_Height_Min_User,"IN", Me.BoxSize_Height_Min_User_UOM)
      '   END FORMULA; PROP ID:2927; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Height_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Height_Min_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Height_Min_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2793; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2793; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Height_Min_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Height_Min_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Height_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2877; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:2877; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Height_Min_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Length_Avg_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Length_Avg_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2928; TYPE:PF
      result = Units.Convert(Me.BoxSize_Length_Avg_User,"IN", Me.BoxSize_Length_Avg_User_UOM)
      '   END FORMULA; PROP ID:2928; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Length_Avg_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Length_Avg_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Length_Avg_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2795; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2795; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Length_Avg_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Length_Avg_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Length_Avg_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2879; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:2879; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Length_Avg_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2929; TYPE:PF
      result = Units.Convert(Me.BoxSize_Length_Max_User,"IN", Me.BoxSize_Length_Max_User_UOM)
      '   END FORMULA; PROP ID:2929; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Length_Max_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2930; TYPE:PF
      result = Units.Convert(Me.BoxSize_Length_Max_User,"MM", Me.BoxSize_Length_Max_User_UOM)
      '   END FORMULA; PROP ID:2930; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Length_Max_MM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2797; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2797; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Length_Max_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2881; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:2881; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Length_Max_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2931; TYPE:PF
      result = Units.Convert(Me.BoxSize_Length_Min_User,"IN", Me.BoxSize_Length_Min_User_UOM)
      '   END FORMULA; PROP ID:2931; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Length_Min_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2932; TYPE:PF
      result = Units.Convert(Me.BoxSize_Length_Min_User,"MM", Me.BoxSize_Length_Min_User_UOM)
      '   END FORMULA; PROP ID:2932; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Length_Min_MM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2796; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2796; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Length_Min_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2880; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:2880; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Length_Min_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Other_Known_Issues() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Other_Known_Issues").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3407; TYPE:PF
      result = false
      '   END FORMULA; PROP ID:3407; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Other_Known_Issues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2791; TYPE:PF
      result = "IN"
      '   END FORMULA; PROP ID:2791; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Weight_Avg_LBS() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Weight_Avg_LBS").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2933; TYPE:PF
      result = Units.Convert(Me.BoxSize_Weight_Avg_User,"LBS", BoxSize_Weight_Avg_User_UOM)
      '   END FORMULA; PROP ID:2933; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Weight_Avg_LBS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Weight_Avg_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Weight_Avg_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2801; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2801; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Weight_Avg_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Weight_Avg_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Weight_Avg_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2885; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "LBS" Else Result = "KG"
      '   END FORMULA; PROP ID:2885; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Weight_Avg_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:3390; TYPE:PF
      result = Units.Convert(Me.BoxSize_Weight_Max_User,"LBS", Me.BoxSize_Weight_Max_User_UOM)
      '   END FORMULA; PROP ID:3390; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Weight_Max_LBS", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2803; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2803; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Weight_Max_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2925; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "lbs" Else Result = "kg"
      '   END FORMULA; PROP ID:2925; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Weight_Max_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:3391; TYPE:PF
      Result = Units.Convert(Me.BoxSize_Weight_Min_User,"LBS", Me.BoxSize_Weight_Min_User_UOM)
      '   END FORMULA; PROP ID:3391; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Weight_Min_LBS", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2802; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2802; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Weight_Min_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2886; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "LBS" Else Result = "KG"
      '   END FORMULA; PROP ID:2886; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Weight_Min_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Width_Avg_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Width_Avg_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3393; TYPE:PF
      result = Units.Convert(Me.BoxSize_Width_Avg_User,"IN", Me.BoxSize_Width_Avg_User_UOM)
      '   END FORMULA; PROP ID:3393; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Width_Avg_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Width_Avg_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Width_Avg_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2798; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2798; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Width_Avg_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Width_Avg_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Width_Avg_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2882; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:2882; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Width_Avg_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:3395; TYPE:PF
      result = Units.Convert(Me.BoxSize_Width_Max_User,"IN", Me.BoxSize_Width_Max_User_UOM)
      '   END FORMULA; PROP ID:3395; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Width_Max_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:3397; TYPE:PF
      result = Units.Convert(Me.BoxSize_Width_Max_User,"MM", Me.BoxSize_Width_Max_User_UOM)
      '   END FORMULA; PROP ID:3397; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Width_Max_MM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2800; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2800; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Width_Max_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2884; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:2884; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Width_Max_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:3398; TYPE:PF
      result = Units.Convert(Me.BoxSize_Width_Min_User,"IN", Me.BoxSize_Width_Min_User_UOM)
      '   END FORMULA; PROP ID:3398; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Width_Min_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:3399; TYPE:PF
      result = Units.Convert(Me.BoxSize_Width_Min_User,"MM", Me.BoxSize_Width_Min_User_UOM)
      '   END FORMULA; PROP ID:3399; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Width_Min_MM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2799; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2799; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Width_Min_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2883; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:2883; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Width_Min_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Worst_Case_Height_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Worst_Case_Height_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4161; TYPE:PF
      result = 32
      '   END FORMULA; PROP ID:4161; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Worst_Case_Height_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Worst_Case_HL_Ratio() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Worst_Case_HL_Ratio").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2936; TYPE:PF
      Result = ""
    '=IF(AND(Box_Height_GRTR_Len_Possible="Yes",BoxSize_Worst_Case_Length_IN>0,BoxSize_Worst_Case_Height_IN>0),BoxSize_Worst_Case_Length_IN/BoxSize_Worst_Case_Height_IN,IF(Box_Height_GRTR_Len_Possible="No","","Invalid Input"))
    'TODO: Fix
If BoxSize_Height_GRTR_Len_Possible And BoxSize_Worst_Case_Length_IN>0 And BoxSize_Worst_Case_Height_IN>0 Then
	Result = BoxSize_Worst_Case_Length_IN/BoxSize_Worst_Case_Height_IN
Else
	If Not BoxSize_Height_GRTR_Len_Possible Then 
		Result = "" 
	Else 
		Result = "Invalid Input"	
	End If 
End If
      '   END FORMULA; PROP ID:2936; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Worst_Case_HL_Ratio", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxSize_Worst_Case_Length_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Worst_Case_Length_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4162; TYPE:PF
      result = 60
      '   END FORMULA; PROP ID:4162; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Worst_Case_Length_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Case_Length_Per_Minute_Target_FT() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Case_Length_Per_Minute_Target_FT").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4513; TYPE:PF
      Result = BoxSize_Length_Avg_IN *Sort_Rate_Required_CPM / 12
      '   END FORMULA; PROP ID:4513; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Case_Length_Per_Minute_Target_FT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Case_Length_Per_Minute_Target_M() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Case_Length_Per_Minute_Target_M").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4512; TYPE:PF
      Result = Units.Convert(Me.Case_Length_Per_Minute_Target_FT,"FT", "M")
      '   END FORMULA; PROP ID:4512; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Case_Length_Per_Minute_Target_M", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_BF_Selected_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_BF_Selected_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4149; TYPE:PF
      Result = Units.Convert(Me.Conveyor_BF_Selected_Min_User,"IN", Me.Conveyor_BF_Selected_Min_User_UOM)
      '   END FORMULA; PROP ID:4149; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_BF_Selected_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_BF_Selected_Min_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_BF_Selected_Min_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4150; TYPE:PF
      Result = Conveyor_Curve_BF_Calc_Min_In

If Me.Conveyor_BF_Selected_Min_User_UOM = "MM" Then
	Result = Conveyor_Curve_BF_Calc_Min_IN 'TODO: FIX to MM
End If
      '   END FORMULA; PROP ID:4150; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_BF_Selected_Min_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_BF_Selected_Min_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_BF_Selected_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4151; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:4151; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_BF_Selected_Min_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_Curve_BF_Calc_Min_In() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Curve_BF_Calc_Min_In").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4147; TYPE:PF
      result = 0
'=SQRT((POWER(Conveyor_Inside_Radius_Min_IN+BoxSize_Width_Max_IN,2)+POWER(BoxSize_Length_Max_IN/2,2)))+(2-Conveyor_Inside_Radius_Min_IN)

Dim X As Double = Conveyor_Inside_Radius_Min_IN + BoxSize_Width_Max_IN
Dim Y As Double = BoxSize_Length_Max_IN / 2
Dim Z As Double = Conveyor_Inside_Radius_Min_IN  ' For clarity, though not strictly necessary

' Compute the sum inside the square root
Dim sumInsideSqrt As Double = Math.Pow(X, 2) + Math.Pow(Y, 2)

' Compute the square root
Dim sqrtResult As Double = Math.Sqrt(sumInsideSqrt)

' Add the final adjustment
Result =  sqrtResult + (2 - Z)
      '   END FORMULA; PROP ID:4147; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_Curve_BF_Calc_Min_In", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_Curve_BF_Calc_Rcmd_In() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Curve_BF_Calc_Rcmd_In").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4148; TYPE:PF
      result = 0


'S64 = =SQRT((POWER(Conveyor_Inside_Radius_Min_IN+BoxSize_Width_Max_IN,2)+POWER(BoxSize_Length_Max_IN/2,2)))+(2-Conveyor_Inside_Radius_Min_IN)
Dim SearchWidth As Double = Me.Conveyor_Curve_BF_Calc_Min_In
'=IF(S64<=42,VLOOKUP(S64,$S$55:$U$60,2,TRUE), "N/A")


'B/F (Imperial)		IR
If SearchWidth > 0 And SearchWidth <=	16 Then Result = 16
If SearchWidth >=  16  And SearchWidth < 22 Then Result = 22
If SearchWidth >= 22  And SearchWidth < 28 Then Result = 28
If SearchWidth >= 28  And SearchWidth < 34 Then Result = 34
If SearchWidth >= 34  And SearchWidth < 40 Then Result = 40
If SearchWidth >= 40  And SearchWidth <= 40 Then Result = 40
      '   END FORMULA; PROP ID:4148; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_Curve_BF_Calc_Rcmd_In", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_Curve_OffSet_Guide_Viable() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Curve_OffSet_Guide_Viable").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4450; TYPE:PF
      result = false
      '   END FORMULA; PROP ID:4450; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_Curve_OffSet_Guide_Viable", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_Inside_Radius_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Inside_Radius_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4146; TYPE:PF
      result = 0
'=VLOOKUP(BoxSize_Width_Max_IN+2,$S$55:$U$60,3,TRUE)
Dim SearchWidth = Me.BoxSize_Width_Max_IN + 2

'B/F (Imperial)		IR
If SearchWidth > 0 And SearchWidth <=	16 Then Result = 30
If SearchWidth >=  16  And SearchWidth < 22 Then Result = 40
If SearchWidth >= 22  And SearchWidth < 28 Then Result = 50
If SearchWidth >= 28  And SearchWidth < 34 Then Result = 60
If SearchWidth >= 34  And SearchWidth < 40 Then Result = 60
If SearchWidth >= 40  And SearchWidth <= 40 Then Result = 60
      '   END FORMULA; PROP ID:4146; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_Inside_Radius_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_Product_Line_Used() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Product_Line_Used").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3415; TYPE:PF
      result = "Imperial"
      '   END FORMULA; PROP ID:3415; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_Product_Line_Used", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_Skew_Bed_Length_Min_Reqd_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Skew_Bed_Length_Min_Reqd_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4152; TYPE:PF
      result = 0

If Conveyor_BF_Selected_Min_IN <= 40 Then Result = 6
If Conveyor_BF_Selected_Min_IN <= 34 Then Result = 5
If Conveyor_BF_Selected_Min_IN <= 28 Then Result = 4
If Conveyor_BF_Selected_Min_IN <= 22 Then Result = 3
If Conveyor_BF_Selected_Min_IN <= 16 Then Result = 2
If Conveyor_BF_Selected_Min_IN > 40 Then Result = 6
      '   END FORMULA; PROP ID:4152; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_Skew_Bed_Length_Min_Reqd_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_Skew_Bed_Length_MTBH_Width_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Skew_Bed_Length_MTBH_Width_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4154; TYPE:PF
      Result = (Math.Ceiling(((( (Conveyor_BF_Selected_Min_IN - BoxSize_Width_Min_IN) / (Conveyor_Skew_Bed_Length_Min_Reqd_IN / Conveyor_BF_Selected_Min_IN) ) / 12 + 3) / 3 ) ) * 3)

'Old Excel Formula
'=ROUNDUP((((Conveyor_BF_Selected_Min_IN-BoxSize_Width_Min_IN)/(Conveyor_Skew_Bed_Length_Min_Reqd_IN/Conveyor_BF_Selected_Min_IN))/12+3)/3,0)*3
      '   END FORMULA; PROP ID:4154; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_Skew_Bed_Length_MTBH_Width_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_Skew_Total_Length_MTBH_Width_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Skew_Total_Length_MTBH_Width_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4153; TYPE:PF
      Result = Math.Floor( ((Conveyor_BF_Selected_Min_IN - BoxSize_Width_Min_IN) / (Conveyor_Skew_Bed_Length_Min_Reqd_IN / Conveyor_BF_Selected_Min_IN)))
      '   END FORMULA; PROP ID:4153; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_Skew_Total_Length_MTBH_Width_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conveyor_Width_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Width_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4145; TYPE:PF
      result = 0

' =VLOOKUP(BoxSize_Width_Max_IN+1.99,$S$55:$U$60,2,TRUE)
Dim Eval_Width = BoxSize_Width_Max_IN + 1.99
'B/F (Imperial)		IR
'0	16	30
'16	22	40
'22	28	50
'28	34	60
'34	40	60
'40	40	60

If Eval_Width > 0 And Eval_Width < 16 Then Result = 16
If Eval_Width >= 16	 And Eval_Width < 22 Then Result = 22
If Eval_Width >= 22	 And Eval_Width < 28	Then Result = 28
If Eval_Width >= 28	 And Eval_Width < 34	Then Result = 34
If Eval_Width >= 34	 And Eval_Width < 40	Then Result = 40
If Eval_Width >= 40	Then Result = 60
      '   END FORMULA; PROP ID:4145; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_Width_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Customer_Location_CityState() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Customer_Location_CityState").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2788; TYPE:PF
      Result = ""
If Not Me.My_PRD(1) Is Nothing
	Result = Me.My_PRD(1).Proposal_City_State
End If
      '   END FORMULA; PROP ID:2788; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Customer_Location_CityState", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Customer_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Customer_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2787; TYPE:PF
      Result = ""
If Not Me.My_PRD(1) Is Nothing
	Result = Me.My_PRD(1).Proposal_Customer_Name
End If
      '   END FORMULA; PROP ID:2787; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Customer_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Live_Load_Avg_KGM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Live_Load_Avg_KGM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3404; TYPE:PF
      result = Units.Convert(Me.Live_Load_Avg_User,"KGM", Me.Live_Load_Avg_User_UOM)
      '   END FORMULA; PROP ID:3404; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Live_Load_Avg_KGM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Live_Load_Avg_LBSFT() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Live_Load_Avg_LBSFT").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3403; TYPE:PF
      result = Units.Convert(Me.Live_Load_Avg_User,"LBSFT", Me.Live_Load_Avg_User_UOM)
      '   END FORMULA; PROP ID:3403; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Live_Load_Avg_LBSFT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Live_Load_Avg_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Live_Load_Avg_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2938; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:2938; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Live_Load_Avg_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Live_Load_Avg_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Live_Load_Avg_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3486; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "LBSFT" Else Result = "KGM"
      '   END FORMULA; PROP ID:3486; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Live_Load_Avg_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Material_Gap_Override_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Material_Gap_Override_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4157; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:4157; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Material_Gap_Override_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Material_Gap_Override_MM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Material_Gap_Override_MM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4158; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:4158; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Material_Gap_Override_MM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Material_Gap_Override_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Material_Gap_Override_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4156; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:4156; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Material_Gap_Override_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Material_Gap_Override_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Material_Gap_Override_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4159; TYPE:PF
      if Me.User_UOM_System = "Imperial" then result = "IN" else result = "MM"
      '   END FORMULA; PROP ID:4159; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Material_Gap_Override_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_Date() As Date
          Dim Result as Date
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_Date").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2790; TYPE:PF
      Result = Nothing
      '   END FORMULA; PROP ID:2790; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Proposal_Date", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_No() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_No").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2789; TYPE:PF
      Result = ""
If Not Me.My_PRD(1) Is Nothing
	Result = Me.My_PRD(1).Proposal_ID
End If
      '   END FORMULA; PROP ID:2789; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Proposal_No", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Selected_Sortation_Controls() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Selected_Sortation_Controls").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2937; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:2937; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Selected_Sortation_Controls", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Dual_Sided() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Dual_Sided").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3400; TYPE:PF
      result = false
      '   END FORMULA; PROP ID:3400; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Sort_Dual_Sided", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sort_Rate_Required_CPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sort_Rate_Required_CPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3401; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:3401; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Sort_Rate_Required_CPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Temp_Sort_Operating_Min_F() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Temp_Sort_Operating_Min_F").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3411; TYPE:PF
      Result = 0 'Fix
Result = Units.Convert(Me.Temp_Sort_operating_Min_User, Me.Temp_Sort_operating_Min_User_UOM, "F")
      '   END FORMULA; PROP ID:3411; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Temp_Sort_Operating_Min_F", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Temp_Sort_Operating_Min_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Temp_Sort_Operating_Min_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3409; TYPE:PF
      result = 0 'Fix
      '   END FORMULA; PROP ID:3409; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Temp_Sort_Operating_Min_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Temp_Sort_Operating_Min_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Temp_Sort_Operating_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3410; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "F" Else Result = "C"
      '   END FORMULA; PROP ID:3410; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Temp_Sort_Operating_Min_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Temp_System_Operating_Min_F() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Temp_System_Operating_Min_F").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3414; TYPE:PF
      result = 0 'Fix
Result = Units.Convert(Me.Temp_System_operating_Min_User, Me.Temp_System_operating_Min_UOM, "F")
      '   END FORMULA; PROP ID:3414; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Temp_System_Operating_Min_F", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Temp_System_Operating_Min_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Temp_System_Operating_Min_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3413; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "F" Else Result = "C"
      '   END FORMULA; PROP ID:3413; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Temp_System_Operating_Min_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Temp_System_Operating_Min_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Temp_System_Operating_Min_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3412; TYPE:PF
      result = 0 'Fix
      '   END FORMULA; PROP ID:3412; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Temp_System_Operating_Min_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Totes_Plastic() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Totes_Plastic").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3405; TYPE:PF
      result = False
      '   END FORMULA; PROP ID:3405; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Totes_Plastic", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Totes_Plastic_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Totes_Plastic_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4160; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:4160; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Totes_Plastic_Type", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2806; TYPE:PF
      result = "Imperial"
      '   END FORMULA; PROP ID:2806; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_User_UOM_System", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Valid() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Valid").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9381; TYPE:PF
      Result = True


' This Section should be a duplicate of Valid Message
Dim EList As New Custom.HWErrorList
EList.Add(0, "Warning Message", "ERR000", Me.Name)
EList.Add(1, "Warning Message", "ERR001", Me.Name)
EList.Add(2, "Errror Message", "ERR002", Me.Name)
EList.Add(3, "Critcal Message", "ERR003", Me.Name)
' End Duplicate Section


Result = EList.IsValid(2)
      '   END FORMULA; PROP ID:9381; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Valid", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Valid_Message() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Valid_Message").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9380; TYPE:PF
      Result = ""

'Sampl Errors
'	EList.Add(0, "Info Message", "ERR000",Source)
'	EList.Add(1, "Warning Message", "ERR001", Source)
'	EList.Add(2, "Errror Message", "ERR002",Source)
'	EList.Add(3, "Critcal Message", "ERR003",Source)

Dim Source As String = "APC_SETUP"
Dim EList As New Custom.HWErrorList

' =IF(BoxSize_Length_Max_IN>48,"WARNING: LENGTHS IN EXCESS OF 48 INCH MAXIMUM MAY RESTRICT MAXIMUM WIDTHS POSSIBLE FOR A GIVEN B/F DIMENSION!","") 
If BoxSize_Length_Max_IN > 48 Then
	EList.Add(1, "WARNING: LENGTHS IN EXCESS OF 48 INCH MAXIMUM MAY RESTRICT MAXIMUM WIDTHS POSSIBLE FOR A GIVEN B/F DIMENSION!", "APC001", Source)
End If

' TODO: VV  7/15/2025  Complete this error , ref Setup Cell L20 - SorterWidthMetric
'=IF(Conveyor_Product_Line_Used="Metric",IF(BoxSize_Width_Max_MM>(SorterWidthMetric-50),"ERROR: MAX WIDTH CARTON EXCEEDS LIMIT FOR SELECTED SORTER/CONVEYOR B/F!",""),IF(BoxSize_Width_Max_IN>(SorterWidth-2),"ERROR: MAX WIDTH CARTON EXCEEDS LIMIT FOR SELECTED SORTER/CONVEYOR B/F!",""))
'If Conveyor_Product_Line_Used = "Metric" Then
    'If BoxSize_Width_Max_MM > (SorterWidthMetric - 50) Then
        'EList.Add(2, "ERROR: MAX WIDTH CARTON EXCEEDS LIMIT FOR SELECTED SORTER/CONVEYOR B/F!", "APC002", Source)
    'End If
'Else
 '   If BoxSize_Width_Max_IN > (SorterWidth - 2) Then
  '      EList.Add(2, "ERROR: MAX WIDTH CARTON EXCEEDS LIMIT FOR SELECTED SORTER/CONVEYOR B/F!", "APC003", Source)
   ' End If
'End If

'=IF(BoxSize_Height_Min_IN<1,"WARNING: SUB 1 INCH MIN. PRODUCT HEIGHT REQUIRES SPECIAL PHOTOCELL CONDSIDERATIONS TO CONVEY AND DETECT PRODUCT PROPERLY","")
If BoxSize_Height_Min_IN < 1 Then
	EList.Add(1,"WARNING: SUB 1 INCH MIN. PRODUCT HEIGHT REQUIRES SPECIAL PHOTOCELL CONDSIDERATIONS TO CONVEY AND DETECT PRODUCT PROPERLY!", "APC004", Source)
End If 

'IF(BoxSize_Length_Min_IN<9,IF(BoxSize_Length_Min_IN<6,"WARNING: SUB 6 INCH MINIMUM PRODUCT LENGTHS REQUIRE SPECIAL DESIGN CONSIDERATIONS SYSTEM WIDE!","WARNING: SUB 9 INCH MINIMUM PRODUCT LENGTHS WILL REQUIRE 2 INCH ROLLER CENTER SPACING TO CONVEY PROPERLY!"),"")
If BoxSize_Length_Min_IN < 9 Then
   If BoxSize_Length_Min_IN < 6 Then
        EList.Add(1, "WARNING: SUB 6 INCH MINIMUM PRODUCT LENGTHS REQUIRE SPECIAL DESIGN CONSIDERATIONS SYSTEM WIDE!", "APC005", Source)
    Else
        EList.Add(1, "WARNING: SUB 9 INCH MINIMUM PRODUCT LENGTHS WILL REQUIRE 2 INCH ROLLER CENTER SPACING TO CONVEY PROPERLY!", "APC006", Source)
    End If
End If

'=IF(OR(BoxSize_Length_Min_IN<9,BoxSize_Length_Max_IN>48,BoxSize_Height_Min_IN<1,BoxSize_Weight_Max_LBS>70),"**REFER TO THE LINK AT THE BOTTOM OF SHEET FOR MASTER OUT-OF-SPEC PRODUCT GUIDELINES**","")
'Check information or refer message 
If BoxSize_Length_Min_IN < 9 OrElse BoxSize_Length_Max_IN > 48 OrElse BoxSize_Height_Min_IN < 1 OrElse BoxSize_Weight_Max_LBS > 70 Then
     EList.Add(0, "**REFER TO THE LINK AT THE BOTTOM OF SHEET FOR MASTER OUT-OF-SPEC PRODUCT GUIDELINES**", "APC007", Source)
End If

'IF(OR(BoxSize_Width_Min_IN>BoxSize_Length_Min_IN,BoxSize_Width_Max_IN>BoxSize_Length_Max_IN,BoxSize_Width_Avg_IN>BoxSize_Length_Avg),"ERROR - WIDTH CANNOT EXCEED LENGTH","")
If BoxSize_Width_Min_IN > BoxSize_Length_Min_IN OrElse BoxSize_Width_Max_IN > BoxSize_Length_Max_IN OrElse BoxSize_Width_Avg_IN > BoxSize_Length_Avg_IN Then
    EList.Add(2, "ERROR - WIDTH CANNOT EXCEED LENGTH", "APC008", Source)
End If

'=IF(;BoxSize_Weight_Max_LBS>70,"WARNING: CONVEYED PRODUCT WEIGHTS IN EXCESS OF 70 LBS MAY REQUIRE SPECIAL CONSIDERATION FOR SOME EQUIPMENT!","")
If BoxSize_Weight_Max_LBS > 70 Then
   EList.Add(1, "WARNING: CONVEYED PRODUCT WEIGHTS IN EXCESS OF 70 LBS MAY REQUIRE SPECIAL CONSIDERATION FOR SOME EQUIPMENT!", "APC009", Source)
End If

'=IF(AND(Live_Load_Avg_LBS>50,Live_Load_Avg_LBS<100),"WARNING: LIVE LOAD IS ABOVE THE TYPICAL RANGE FOR MOST EQUIPMENT TYPES","")
If Live_Load_Avg_LBSFT > 50 And Live_Load_Avg_LBSFT < 100 Then
      EList.Add(1,"WARNING: LIVE LOAD IS ABOVE THE TYPICAL RANGE FOR MOST EQUIPMENT TYPES", "APC010", Source)
End If
'Below both warnings are similar
' TODO: VV  7/15/2025  Complete this error , ref Setup Cell M33 Check property BoxSize_Worst_Case_HL_Ratio
'=IF(OR($I$33="Yes",AND($I$30="Yes",$I$32<0.75)),"WARNING: PRODUCT STABILITY TESTING/PROTOTYPING IS STRONGLY RECOMMENDED!","")
'If BoxSize_Other_Known_Issues = True Or (BoxSize_Height_GRTR_Len_Possible = True And BoxSize_Worst_Case_HL_Ratio < 0.75) Then
    'EList.Add(1, "WARNING: PRODUCT STABILITY TESTING/PROTOTYPING IS STRONGLY RECOMMENDED!", "APC011", Source)
'End If

' TODO: VV  7/15/2025  Complete this error , ref Setup Cell N34 Check property BoxSize_Worst_Case_HL_Ratio
'=IF(OR($I$33="Yes",AND($I$30="Yes",$I$32<0.75)),"REDUCED INCLINE/DECLINE BELT ANGLES AND/OR VFD's MAY BE REQUIRED!'","")
'If BoxSize_Other_Known_Issues = True Or (BoxSize_Height_GRTR_Len_Possible = True And BoxSize_Worst_Case_HL_Ratio < 0.75) Then
    'EList.Add(1, "WARNING: REDUCED INCLINE/DECLINE BELT ANGLES AND/OR VFD's MAY BE REQUIRED!'", "APC012", Source)
'End If

'=IF(OR(Selected_Sortation_Controls="BOSS",Selected_Sortation_Controls="ICW"),"WARNING: THE BOSS AND ICW CONTROLS PLATFORMS ARE IN SUNSET STATUS AND SHOULD ONLY BE USED FOR RETROFITS OF EXISTING SYSTEMS!","")
If Selected_Sortation_Controls = "BOSS" Or Selected_Sortation_Controls = "ICW" Then
    EList.Add(1, "WARNING: THE BOSS AND ICW CONTROLS PLATFORMS ARE IN SUNSET STATUS AND SHOULD ONLY BE USED FOR RETROFITS OF EXISTING SYSTEMS!", "APC013", Source)
End If

'=IF($I$40="Metric","WARNING: METRIC PERFORMANCE VALUES ARE ESTIMATES UNTIL TESTING CAN BE DONE BY PRODUCT ENGINEERING","")
If Conveyor_Product_Line_Used = "Metric" Then
    EList.Add(1, "WARNING: METRIC PERFORMANCE VALUES ARE ESTIMATES UNTIL TESTING CAN BE DONE BY PRODUCT ENGINEERING", "APC014", Source)
End If

'MPC - 20250712 - Did a different check for BoxSize_Worst_Case_HL_Ratio to capture a string "Error" Error. 
					' The Original Spreadsheet had BoxSize_Worst_Case_HL_Ratio evaluating to a string
'If Not isnumeric( BoxSize_Worst_Case_HL_Ratio) Then
'	EList.Add(2, "ERROR: PRODUCT STABILITY TESTING/PROTOTYPING IS STRONGLY RECOMMENDED!", "APC0027", Source)


'TODO: VV  7/15/2025  Verify this error , ref Setup Cell L43
'=If(Or(And($I$43="N/A",Conveyor_Product_Line_Used="Imperial"),And($J$43="N/A",Conveyor_Product_Line_Used="Metric")),"ERROR: PRODUCT DIMENSIONS EXCEEDS KNOW CONVEYABLE LIMITS FOR STANDARD CASE CONVEYOR! CONSIDER PALLET EQUIPMENT","")
	
''TODO: VV  7/15/2025  Verify this error , ref Setup Cell L44
'=If(Or(And(Or(Conveyor_BF_Selected_Min_IN<I41,(Conveyor_BF_Selected_Min_IN+2)<I42),Conveyor_Product_Line_Used="Imperial"),And(Or(SelectedMinConvBFMetric<J41,(SelectedMinConvBFMetric+50)<J42),Conveyor_Product_Line_Used="Metric")),"ERROR: SELECTED MINIMUM B/F IS TOO NARROW FOR DEFINED MTBH","")
	
'TODO: VV  7/15/2025  Verify this error , ref Setup Cell M45
'=IF(OR(AND($I$44="Yes",Conveyor_BF_Selected_Min_IN<=I43,Conveyor_BF_Selected_Min_IN=I41,Conveyor_Product_Line_Used="Imperial"),AND($I$44="Yes",SelectedMinConvBFMetric<=J43,SelectedMinConvBFMetric=J41,Conveyor_Product_Line_Used="Metric")),"WARNING: APPLICATION WILL REQUIRE THE USE OF OFFSET GUIDES ON ALL CURVE CONVEYORS AT SELECTED B/F","")

'TODO: VV  7/15/2025  Verify this error , ref Setup Cell L50
'=IFERROR(If(And(Sort_Dual_Sided="Yes",VLOOKUP(SorterType,'Lists-1'!D4:N15,11,FALSE)="SS"),"ERROR: A 2-SIDED SORTER IS NOT SELECTED ON THE SORTATION WORKSHEET!",IF(AND(Sort_Dual_Sided="No",VLOOKUP(SorterType,'Lists-1'!D4:N15,11,FALSE)="DS"),"CHOOSE A 1-SIDED SORTER!","")),"")

'TODO: VV  7/15/2025  Verify this error , ref Setup Cell N51
'Case_Length_Per_Ft_Minute_Target - Variable remains constantin engineer
'=IF(Case_Length_Per_Ft_Minute_Target>216,IF(Case_Length_Per_Ft_Minute_Target>400,"SEEK PAE/ENGINEERING ASSISTANCE ON ANY APPLICATION EXCEEDING 400 CFPM","APPLICATIONS EXCEEDING 216 CFPM WILL LIKELY REQUIRE SOME FORM OF ACTIVE GAPPING INDUCTION TECHOLOGY"),"")
If Case_Length_Per_Minute_Target_FT > 216 Then
    If Case_Length_Per_Minute_Target_FT > 400 Then
      EList.Add(1, "Warning - SEEK PAE/ENGINEERING ASSISTANCE ON ANY APPLICATION EXCEEDING 400 CFPM", "APC006", Source)
    Else
      EList.Add(1, "Warning - APPLICATIONS EXCEEDING 216 CFPM WILL LIKELY REQUIRE SOME FORM OF ACTIVE GAPPING INDUCTION TECHOLOGY", "APC007", Source)
    End If
End If

'TODO: VV  7/15/2025  Verify this error , ref Setup Cell M53 - finish code
'=IF(OverrideGap<>"","WARNING: GAP OVERRIDE IS ENABLED!","")
'If OverrideGap <> "" Then
 '   EList.Add(1, "WARNING: GAP OVERRIDE IS ENABLED!", "APC003", Source)
'End If

Result = EList.ErrorSummary(1)
      '   END FORMULA; PROP ID:9380; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Valid_Message", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_InclineDecline_Max_Deg_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Avg_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Avg_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Avg_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_GRTR_Len_Possible_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Max_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Max_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Min_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Min_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Avg_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Avg_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Avg_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_BoxSize_Other_Known_Issues_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Avg_LBS_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Avg_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Avg_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_BoxSize_Width_Avg_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Avg_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Avg_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_BoxSize_Worst_Case_Height_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Worst_Case_HL_Ratio_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Worst_Case_Length_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Case_Length_Per_Minute_Target_FT_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Case_Length_Per_Minute_Target_M_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_BF_Selected_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_BF_Selected_Min_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_BF_Selected_Min_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Curve_BF_Calc_Min_In_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Curve_BF_Calc_Rcmd_In_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Curve_OffSet_Guide_Viable_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Inside_Radius_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Product_Line_Used_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Skew_Bed_Length_Min_Reqd_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Skew_Bed_Length_MTBH_Width_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Skew_Total_Length_MTBH_Width_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Width_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Location_CityState_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Live_Load_Avg_KGM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Live_Load_Avg_LBSFT_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Live_Load_Avg_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Live_Load_Avg_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Material_Gap_Override_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Material_Gap_Override_MM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Material_Gap_Override_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Material_Gap_Override_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Date_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_No_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selected_Sortation_Controls_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Dual_Sided_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Rate_Required_CPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_Sort_Operating_Min_F_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_Sort_Operating_Min_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_Sort_Operating_Min_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_System_Operating_Min_F_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_System_Operating_Min_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_System_Operating_Min_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Totes_Plastic_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Totes_Plastic_Type_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Valid_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Valid_Message_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_InclineDecline_Max_Deg_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Avg_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Avg_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Avg_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_GRTR_Len_Possible_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Max_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Max_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Max_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Min_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Min_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Min_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Avg_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Avg_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Avg_User_UOM_USERCHANGE() as Boolean
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
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Max_User_USERCHANGE() as Boolean
      Return True
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
      Return True
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
      Public Function Formula_BoxSize_Other_Known_Issues_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Avg_LBS_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Avg_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Avg_User_UOM_USERCHANGE() as Boolean
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
      Return True
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
      Public Function Formula_BoxSize_Width_Avg_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Avg_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Avg_User_UOM_USERCHANGE() as Boolean
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
      Return True
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
      Return True
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
      Public Function Formula_BoxSize_Worst_Case_Height_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Worst_Case_HL_Ratio_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Worst_Case_Length_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Case_Length_Per_Minute_Target_FT_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Case_Length_Per_Minute_Target_M_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_BF_Selected_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_BF_Selected_Min_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_BF_Selected_Min_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Curve_BF_Calc_Min_In_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Curve_BF_Calc_Rcmd_In_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Curve_OffSet_Guide_Viable_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Inside_Radius_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Product_Line_Used_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Skew_Bed_Length_Min_Reqd_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Skew_Bed_Length_MTBH_Width_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Skew_Total_Length_MTBH_Width_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Width_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Location_CityState_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Name_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Live_Load_Avg_KGM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Live_Load_Avg_LBSFT_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Live_Load_Avg_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Live_Load_Avg_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Material_Gap_Override_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Material_Gap_Override_MM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Material_Gap_Override_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Material_Gap_Override_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_Date_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_No_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selected_Sortation_Controls_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Dual_Sided_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sort_Rate_Required_CPM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_Sort_Operating_Min_F_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_Sort_Operating_Min_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_Sort_Operating_Min_User_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_System_Operating_Min_F_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_System_Operating_Min_UOM_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_System_Operating_Min_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Totes_Plastic_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Totes_Plastic_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_User_UOM_System_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Valid_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Valid_Message_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Avg_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Height_Avg_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2805; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:2805; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Height_Avg_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Max_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Height_Max_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2878; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:2878; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Height_Max_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Height_Min_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Height_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2877; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:2877; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Height_Min_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Length_Avg_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Length_Avg_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2879; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:2879; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Length_Avg_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      '   BEGIN FORMULA; PROP ID:2881; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:2881; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Length_Max_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2880; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:2880; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Length_Min_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Weight_Avg_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Weight_Avg_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2885; TYPE:VV
      Result = MakeValidValues(Array( "LBS", "KG"))
      '   END FORMULA; PROP ID:2885; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Weight_Avg_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2925; TYPE:VV
      Result = MakeValidValues(Array( "LBS", "KG"))
      '   END FORMULA; PROP ID:2925; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Weight_Max_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2886; TYPE:VV
      Result = MakeValidValues(Array( "LBS", "KG"))
      '   END FORMULA; PROP ID:2886; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Weight_Min_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxSize_Width_Avg_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxSize_Width_Avg_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2882; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:2882; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Width_Avg_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2884; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:2884; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Width_Max_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2883; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:2883; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_BoxSize_Width_Min_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_BF_Selected_Min_User_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_BF_Selected_Min_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4150; TYPE:VV
      If Me.User_UOM_System = "Imperial" Then 
	Result = MakeValidKeyValues(Array(16, 22, 28, 34, 40), Array("16 in.", "22 in.", "28 in.", "34 in.", "40 in."))
Else
	Result = MakeValidKeyValues(Array(440, 540, 690, 840, 990), Array("440 mm", "540 mm", "690 mm", "840 mm", "990 mm"))
End If
      '   END FORMULA; PROP ID:4150; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_BF_Selected_Min_User_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_BF_Selected_Min_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_BF_Selected_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4151; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:4151; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_BF_Selected_Min_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Product_Line_Used_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conveyor_Product_Line_Used").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3415; TYPE:VV
      Result = MakeValidValues(Array( "Imperial", "Metric"))
      '   END FORMULA; PROP ID:3415; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Conveyor_Product_Line_Used_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Live_Load_Avg_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Live_Load_Avg_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3486; TYPE:VV
      Result = MakeValidValues(Array( "LBSFT", "KGM"))
      '   END FORMULA; PROP ID:3486; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Live_Load_Avg_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Material_Gap_Override_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Material_Gap_Override_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4159; TYPE:VV
      Result = MakeValidValues(Array( "IN", "MM"))
      '   END FORMULA; PROP ID:4159; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Material_Gap_Override_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selected_Sortation_Controls_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Selected_Sortation_Controls").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2937; TYPE:VV
      Result = MakeValidValues(Array( "PLC", "MC4","BOSS","ICW"))
      '   END FORMULA; PROP ID:2937; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Selected_Sortation_Controls_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_Sort_Operating_Min_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Temp_Sort_Operating_Min_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3410; TYPE:VV
      Result = MakeValidValues(Array( "F", "C"))
      '   END FORMULA; PROP ID:3410; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Temp_Sort_Operating_Min_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_System_Operating_Min_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Temp_System_Operating_Min_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:3413; TYPE:VV
      Result = MakeValidValues(Array( "F", "C"))
      '   END FORMULA; PROP ID:3413; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Temp_System_Operating_Min_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Totes_Plastic_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Totes_Plastic_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4160; TYPE:VV
      Result = MakeValidValues(Array( "Tapered", "Square_Sided"))
      '   END FORMULA; PROP ID:4160; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_Totes_Plastic_Type_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:2806; TYPE:VV
      Result = MakeValidValues(Array( "Imperial", "Metric"))
      '   END FORMULA; PROP ID:2806; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Setup.Formula_User_UOM_System_ValidValues", ex.Message)
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

  