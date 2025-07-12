Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_App_Calc_Print_And_Apply
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

    Public Class [CAE_App_Calc_Print_And_Apply]
    
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

    Private this as CAE_App_Calc_Print_And_Apply = me

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
    
          Public Property [User_UOM_System]() As String
      Get
      Return Properties("User_UOM_System").Value
      End Get
      Set(ByVal Value As String)
      Properties("User_UOM_System").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Acq_Label_Data_Acquisition_Method]() As String
      Get
      Return Properties("Acq_Label_Data_Acquisition_Method").Value
      End Get
      Set(ByVal Value As String)
      Properties("Acq_Label_Data_Acquisition_Method").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Acq_Label_Data_Acquisition_Travel_IN]() As Double
      Get
      Return Properties("Acq_Label_Data_Acquisition_Travel_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Acq_Label_Data_Acquisition_Travel_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Acq_Label_Data_Acquisition_Travel_User]() As Double
      Get
      Return Properties("Acq_Label_Data_Acquisition_Travel_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Acq_Label_Data_Acquisition_Travel_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Acq_Label_Data_Acquisition_Travel_User_UOM]() As String
      Get
      Return Properties("Acq_Label_Data_Acquisition_Travel_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Acq_Label_Data_Acquisition_Travel_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Acq_Max_Host_Resp_Time_Secs]() As Double
      Get
      Return Properties("Acq_Max_Host_Resp_Time_Secs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Acq_Max_Host_Resp_Time_Secs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Acq_Max_Local_Lookup_Time_Secs]() As Double
      Get
      Return Properties("Acq_Max_Local_Lookup_Time_Secs").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Acq_Max_Local_Lookup_Time_Secs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conv_Total_App_Belt_Length_Req_FT]() As Double
      Get
      Return Properties("Conv_Total_App_Belt_Length_Req_FT").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conv_Total_App_Belt_Length_Req_FT").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conv_Total_App_Belt_Length_Req_FT_User]() As Double
      Get
      Return Properties("Conv_Total_App_Belt_Length_Req_FT_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conv_Total_App_Belt_Length_Req_FT_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conv_Total_App_Belt_Length_Req_FT_User_UOM]() As String
      Get
      Return Properties("Conv_Total_App_Belt_Length_Req_FT_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Conv_Total_App_Belt_Length_Req_FT_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conv_Total_App_Belt_Length_Req_IN]() As Double
      Get
      Return Properties("Conv_Total_App_Belt_Length_Req_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conv_Total_App_Belt_Length_Req_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conv_Total_App_Belt_Length_Req_IN_User]() As Double
      Get
      Return Properties("Conv_Total_App_Belt_Length_Req_IN_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conv_Total_App_Belt_Length_Req_IN_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conv_Total_App_Belt_Length_Req_IN_User_UOM]() As String
      Get
      Return Properties("Conv_Total_App_Belt_Length_Req_IN_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Conv_Total_App_Belt_Length_Req_IN_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conv_Total_Solution_Length_FT]() As Double
      Get
      Return Properties("Conv_Total_Solution_Length_FT").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conv_Total_Solution_Length_FT").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conv_Total_Solution_Length_FT_User]() As Double
      Get
      Return Properties("Conv_Total_Solution_Length_FT_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Conv_Total_Solution_Length_FT_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Conv_Total_Solution_Length_FT_User_UOM]() As String
      Get
      Return Properties("Conv_Total_Solution_Length_FT_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Conv_Total_Solution_Length_FT_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Accumulation_Convey_Type_Pre_Panda]() As String
      Get
      Return Properties("Gen_Accumulation_Convey_Type_Pre_Panda").Value
      End Get
      Set(ByVal Value As String)
      Properties("Gen_Accumulation_Convey_Type_Pre_Panda").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Accumulation_Zone_Length_IN]() As Double
      Get
      Return Properties("Gen_Accumulation_Zone_Length_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_Accumulation_Zone_Length_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Accumulation_Zone_Length_User]() As Double
      Get
      Return Properties("Gen_Accumulation_Zone_Length_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_Accumulation_Zone_Length_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Accumulation_Zone_Length_User_UOM]() As String
      Get
      Return Properties("Gen_Accumulation_Zone_Length_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Gen_Accumulation_Zone_Length_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Accumulation_Zone_Quantity]() As Long
      Get
      Return Properties("Gen_Accumulation_Zone_Quantity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Gen_Accumulation_Zone_Quantity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Belt_Speed_IN]() As Double
      Get
      Return Properties("Gen_Belt_Speed_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_Belt_Speed_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Belt_Speed_User]() As Double
      Get
      Return Properties("Gen_Belt_Speed_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_Belt_Speed_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Belt_Speed_User_Max_Value]() As Double
      Get
      Return Properties("Gen_Belt_Speed_User_Max_Value").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_Belt_Speed_User_Max_Value").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Belt_Speed_User_Min_Value]() As Double
      Get
      Return Properties("Gen_Belt_Speed_User_Min_Value").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_Belt_Speed_User_Min_Value").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Belt_Speed_User_UOM]() As String
      Get
      Return Properties("Gen_Belt_Speed_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Gen_Belt_Speed_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_BM_Belt_Acc_Dec_Rate_IN]() As Double
      Get
      Return Properties("Gen_BM_Belt_Acc_Dec_Rate_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_BM_Belt_Acc_Dec_Rate_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_BM_Belt_Acc_Dec_Rate_User]() As Double
      Get
      Return Properties("Gen_BM_Belt_Acc_Dec_Rate_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_BM_Belt_Acc_Dec_Rate_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_BM_Belt_Acc_Dec_Rate_User_Max_Value]() As Double
      Get
      Return Properties("Gen_BM_Belt_Acc_Dec_Rate_User_Max_Value").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_BM_Belt_Acc_Dec_Rate_User_Max_Value").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_BM_Belt_Acc_Dec_Rate_User_Min_Value]() As Double
      Get
      Return Properties("Gen_BM_Belt_Acc_Dec_Rate_User_Min_Value").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_BM_Belt_Acc_Dec_Rate_User_Min_Value").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_BM_Belt_Acc_Dec_Rate_User_UOM]() As String
      Get
      Return Properties("Gen_BM_Belt_Acc_Dec_Rate_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Gen_BM_Belt_Acc_Dec_Rate_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_BM_Belt_Gap_Stop_Min_Carton_IN]() As Double
      Get
      Return Properties("Gen_BM_Belt_Gap_Stop_Min_Carton_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_BM_Belt_Gap_Stop_Min_Carton_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_BM_Belt_Gap_Stop_Min_Carton_User]() As Double
      Get
      Return Properties("Gen_BM_Belt_Gap_Stop_Min_Carton_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_BM_Belt_Gap_Stop_Min_Carton_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM]() As String
      Get
      Return Properties("Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_BM_Belt_Input_Speed_IN]() As Double
      Get
      Return Properties("Gen_BM_Belt_Input_Speed_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_BM_Belt_Input_Speed_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_BM_Belt_Input_Speed_User]() As Double
      Get
      Return Properties("Gen_BM_Belt_Input_Speed_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_BM_Belt_Input_Speed_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_BM_Belt_Input_Speed_User_UOM]() As String
      Get
      Return Properties("Gen_BM_Belt_Input_Speed_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Gen_BM_Belt_Input_Speed_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_BM_Belt_PTO_Ratio]() As Double
      Get
      Return Properties("Gen_BM_Belt_PTO_Ratio").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_BM_Belt_PTO_Ratio").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_BM_Belt_PTO_Target_Ratio]() As Double
      Get
      Return Properties("Gen_BM_Belt_PTO_Target_Ratio").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_BM_Belt_PTO_Target_Ratio").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Conveyor_Type]() As String
      Get
      Return Properties("Gen_Conveyor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Gen_Conveyor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Conveyor_Width_IN]() As Double
      Get
      Return Properties("Gen_Conveyor_Width_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_Conveyor_Width_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Conveyor_Width_User]() As Double
      Get
      Return Properties("Gen_Conveyor_Width_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_Conveyor_Width_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Conveyor_Width_User_UOM]() As String
      Get
      Return Properties("Gen_Conveyor_Width_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Gen_Conveyor_Width_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_MDR_Min_Gap_Throughput_Limit_IN]() As Double
      Get
      Return Properties("Gen_MDR_Min_Gap_Throughput_Limit_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_MDR_Min_Gap_Throughput_Limit_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_MDR_Min_Gap_Throughput_Limit_User]() As Double
      Get
      Return Properties("Gen_MDR_Min_Gap_Throughput_Limit_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_MDR_Min_Gap_Throughput_Limit_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_MDR_Min_Gap_Throughput_Limit_User_UOM]() As String
      Get
      Return Properties("Gen_MDR_Min_Gap_Throughput_Limit_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Gen_MDR_Min_Gap_Throughput_Limit_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gen_Throughput_Rate]() As Double
      Get
      Return Properties("Gen_Throughput_Rate").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gen_Throughput_Rate").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Carton_Panels_Scanned_Quantity]() As Long
      Get
      Return Properties("Ind_Scan_Carton_Panels_Scanned_Quantity").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Ind_Scan_Carton_Panels_Scanned_Quantity").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Carton_Percent_Max_Length_Scanned]() As Double
      Get
      Return Properties("Ind_Scan_Carton_Percent_Max_Length_Scanned").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ind_Scan_Carton_Percent_Max_Length_Scanned").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Carton_Percent_Max_Length_Scanned_User]() As Double
      Get
      Return Properties("Ind_Scan_Carton_Percent_Max_Length_Scanned_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ind_Scan_Carton_Percent_Max_Length_Scanned_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Carton_Presentation]() As String
      Get
      Return Properties("Ind_Scan_Carton_Presentation").Value
      End Get
      Set(ByVal Value As String)
      Properties("Ind_Scan_Carton_Presentation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Carton_Scanned_Max_Lin_Length_IN]() As Double
      Get
      Return Properties("Ind_Scan_Carton_Scanned_Max_Lin_Length_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ind_Scan_Carton_Scanned_Max_Lin_Length_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Carton_Scanned_Max_Lin_Length_User]() As Double
      Get
      Return Properties("Ind_Scan_Carton_Scanned_Max_Lin_Length_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ind_Scan_Carton_Scanned_Max_Lin_Length_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM]() As String
      Get
      Return Properties("Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Label_Orientation]() As String
      Get
      Return Properties("Ind_Scan_Label_Orientation").Value
      End Get
      Set(ByVal Value As String)
      Properties("Ind_Scan_Label_Orientation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Scan_App_Min_Gap_IN]() As Double
      Get
      Return Properties("Ind_Scan_Scan_App_Min_Gap_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ind_Scan_Scan_App_Min_Gap_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Scan_App_Min_Gap_User]() As Double
      Get
      Return Properties("Ind_Scan_Scan_App_Min_Gap_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ind_Scan_Scan_App_Min_Gap_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Scan_App_Min_Gap_User_UOM]() As String
      Get
      Return Properties("Ind_Scan_Scan_App_Min_Gap_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Ind_Scan_Scan_App_Min_Gap_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Scan_Window_Length_Req_IN]() As Double
      Get
      Return Properties("Ind_Scan_Scan_Window_Length_Req_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ind_Scan_Scan_Window_Length_Req_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Scan_Window_Length_Req_User]() As Double
      Get
      Return Properties("Ind_Scan_Scan_Window_Length_Req_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ind_Scan_Scan_Window_Length_Req_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Scan_Window_Length_Req_User_UOM]() As String
      Get
      Return Properties("Ind_Scan_Scan_Window_Length_Req_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Ind_Scan_Scan_Window_Length_Req_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Scanner_Config]() As String
      Get
      Return Properties("Ind_Scan_Scanner_Config").Value
      End Get
      Set(ByVal Value As String)
      Properties("Ind_Scan_Scanner_Config").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Scanner_Data_Transmit_Mode]() As String
      Get
      Return Properties("Ind_Scan_Scanner_Data_Transmit_Mode").Value
      End Get
      Set(ByVal Value As String)
      Properties("Ind_Scan_Scanner_Data_Transmit_Mode").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Scanner_Min_Xmit_Point_IN]() As Double
      Get
      Return Properties("Ind_Scan_Scanner_Min_Xmit_Point_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ind_Scan_Scanner_Min_Xmit_Point_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Scanner_Min_Xmit_Point_User]() As Double
      Get
      Return Properties("Ind_Scan_Scanner_Min_Xmit_Point_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ind_Scan_Scanner_Min_Xmit_Point_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Scanner_Min_Xmit_Point_User_UOM]() As String
      Get
      Return Properties("Ind_Scan_Scanner_Min_Xmit_Point_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Ind_Scan_Scanner_Min_Xmit_Point_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Shadowing_Allowed]() As String
      Get
      Return Properties("Ind_Scan_Shadowing_Allowed").Value
      End Get
      Set(ByVal Value As String)
      Properties("Ind_Scan_Shadowing_Allowed").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Shadowing_Potential]() As String
      Get
      Return Properties("Ind_Scan_Shadowing_Potential").Value
      End Get
      Set(ByVal Value As String)
      Properties("Ind_Scan_Shadowing_Potential").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Tracking_Photocell_Distance_IN]() As Double
      Get
      Return Properties("Ind_Scan_Tracking_Photocell_Distance_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ind_Scan_Tracking_Photocell_Distance_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Tracking_Photocell_Distance_User]() As Double
      Get
      Return Properties("Ind_Scan_Tracking_Photocell_Distance_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ind_Scan_Tracking_Photocell_Distance_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Tracking_Photocell_Distance_User_Max_Val]() As Double
      Get
      Return Properties("Ind_Scan_Tracking_Photocell_Distance_User_Max_Val").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ind_Scan_Tracking_Photocell_Distance_User_Max_Val").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Tracking_Photocell_Distance_User_Min_Val]() As Double
      Get
      Return Properties("Ind_Scan_Tracking_Photocell_Distance_User_Min_Val").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Ind_Scan_Tracking_Photocell_Distance_User_Min_Val").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Ind_Scan_Tracking_Photocell_Distance_User_UOM]() As String
      Get
      Return Properties("Ind_Scan_Tracking_Photocell_Distance_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Ind_Scan_Tracking_Photocell_Distance_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MDR_RAT_Swivel_Rate]() As Double
      Get
      Return Properties("MDR_RAT_Swivel_Rate").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MDR_RAT_Swivel_Rate").CalculatedValue = Value
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
    
          Public Property [Reject_Diverter_Min_Gap_Required_IN]() As Double
      Get
      Return Properties("Reject_Diverter_Min_Gap_Required_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Reject_Diverter_Min_Gap_Required_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Reject_Diverter_Min_Gap_Required_User]() As Double
      Get
      Return Properties("Reject_Diverter_Min_Gap_Required_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Reject_Diverter_Min_Gap_Required_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Reject_Diverter_Min_Gap_Required_User_UOM]() As String
      Get
      Return Properties("Reject_Diverter_Min_Gap_Required_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Reject_Diverter_Min_Gap_Required_User_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Reject_Diverter_Required]() As String
      Get
      Return Properties("Reject_Diverter_Required").Value
      End Get
      Set(ByVal Value As String)
      Properties("Reject_Diverter_Required").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_IN]() As Double
      Get
      Return Properties("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM]() As String
      Get
      Return Properties("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User]() As Double
      Get
      Return Properties("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Reject_Diverter_Spacing_Cont_Flow_Max_Carton_IN]() As Double
      Get
      Return Properties("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM]() As String
      Get
      Return Properties("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User]() As Double
      Get
      Return Properties("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Reject_Diverter_Type]() As String
      Get
      Return Properties("Reject_Diverter_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Reject_Diverter_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Transnorm_TS4800_Control_Reaction_Time_Distance_IN]() As Double
      Get
      Return Properties("Transnorm_TS4800_Control_Reaction_Time_Distance_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Transnorm_TS4800_Control_Reaction_Time_Distance_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Transnorm_TS4800_Divert_Angle]() As Double
      Get
      Return Properties("Transnorm_TS4800_Divert_Angle").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Transnorm_TS4800_Divert_Angle").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Transnorm_TS4800_Divert_Shifting_Distance_IN]() As Double
      Get
      Return Properties("Transnorm_TS4800_Divert_Shifting_Distance_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Transnorm_TS4800_Divert_Shifting_Distance_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Transnorm_TS4800_Encoder_Resolution_IN]() As Double
      Get
      Return Properties("Transnorm_TS4800_Encoder_Resolution_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Transnorm_TS4800_Encoder_Resolution_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Transnorm_TS4800_Required_Gap_Max_Box]() As Double
      Get
      Return Properties("Transnorm_TS4800_Required_Gap_Max_Box").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Transnorm_TS4800_Required_Gap_Max_Box").CalculatedValue = Value
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
    InitPart("CAE_App_Calc_Print_And_Apply", <a><![CDATA[CAE_App_Calc_Print_And_Apply]]></a>.Value, 416, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H602502", "07/12/2025 15:06:37")
    AddProperty("9808", "User_UOM_System", <a><![CDATA[User_UOM_System]]></a>.Value, "", "String","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/10/2025 6:08:33 PM")
    AddProperty("9951", "Acq_Label_Data_Acquisition_Method", <a><![CDATA[Acq_Label_Data_Acquisition_Method]]></a>.Value, "AppCalc^'Belted PandA'!74", "String","","AppCalc_PandA_Acquisition","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 7:15:41 PM")
    AddProperty("9956", "Acq_Label_Data_Acquisition_Travel_IN", <a><![CDATA[Acq_Label_Data_Acquisition_Travel_IN]]></a>.Value, "Conversion to IN", "Double","","AppCalc_PandA_Acquisition","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 7:47:28 PM")
    AddProperty("9954", "Acq_Label_Data_Acquisition_Travel_User", <a><![CDATA[Acq_Label_Data_Acquisition_Travel_User]]></a>.Value, "AppCalc^'Belted PandA'!77", "Double","","AppCalc_PandA_Acquisition","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 7:58:41 PM")
    AddProperty("9955", "Acq_Label_Data_Acquisition_Travel_User_UOM", <a><![CDATA[Acq_Label_Data_Acquisition_Travel_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Acquisition","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 7:20:53 PM")
    AddProperty("9952", "Acq_Max_Host_Resp_Time_Secs", <a><![CDATA[Acq_Max_Host_Resp_Time_Secs]]></a>.Value, "AppCalc^'Belted PandA'!75", "Double","","AppCalc_PandA_Acquisition","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 7:30:55 PM")
    AddProperty("9953", "Acq_Max_Local_Lookup_Time_Secs", <a><![CDATA[Acq_Max_Local_Lookup_Time_Secs]]></a>.Value, "AppCalc^'Belted PandA'!76", "Double","","AppCalc_PandA_Acquisition","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 7:30:43 PM")
    AddProperty("10006", "Conv_Total_App_Belt_Length_Req_FT", <a><![CDATA[Conv_Total_App_Belt_Length_Req_FT]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_Conveyor","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 3:06:14 PM")
    AddProperty("10003", "Conv_Total_App_Belt_Length_Req_FT_User", <a><![CDATA[Conv_Total_App_Belt_Length_Req_FT_User]]></a>.Value, "AppCalc^'Belted PandA'!J131", "Double","","AppCalc_PandA_Conveyor","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 3:04:47 PM")
    AddProperty("10000", "Conv_Total_App_Belt_Length_Req_FT_User_UOM", <a><![CDATA[Conv_Total_App_Belt_Length_Req_FT_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Conveyor","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 3:03:33 PM")
    AddProperty("10005", "Conv_Total_App_Belt_Length_Req_IN", <a><![CDATA[Conv_Total_App_Belt_Length_Req_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_Conveyor","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 3:05:42 PM")
    AddProperty("10002", "Conv_Total_App_Belt_Length_Req_IN_User", <a><![CDATA[Conv_Total_App_Belt_Length_Req_IN_User]]></a>.Value, "AppCalc^'Belted PandA'!J130", "Double","","AppCalc_PandA_Conveyor","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 3:04:33 PM")
    AddProperty("9999", "Conv_Total_App_Belt_Length_Req_IN_User_UOM", <a><![CDATA[Conv_Total_App_Belt_Length_Req_IN_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Conveyor","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 3:02:54 PM")
    AddProperty("10007", "Conv_Total_Solution_Length_FT", <a><![CDATA[Conv_Total_Solution_Length_FT]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_Conveyor","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 3:06:37 PM")
    AddProperty("10004", "Conv_Total_Solution_Length_FT_User", <a><![CDATA[Conv_Total_Solution_Length_FT_User]]></a>.Value, "AppCalc^'Belted PandA'!J131", "Double","","AppCalc_PandA_Conveyor","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 3:04:56 PM")
    AddProperty("10001", "Conv_Total_Solution_Length_FT_User_UOM", <a><![CDATA[Conv_Total_Solution_Length_FT_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Conveyor","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 3:04:03 PM")
    AddProperty("9832", "Gen_Accumulation_Convey_Type_Pre_Panda", <a><![CDATA[Gen_Accumulation_Convey_Type_Pre_Panda]]></a>.Value, "AppCalc^'Belted PandA'!J38", "String","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:37:20 PM")
    AddProperty("9825", "Gen_Accumulation_Zone_Length_IN", <a><![CDATA[Gen_Accumulation_Zone_Length_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:47:42 PM")
    AddProperty("9818", "Gen_Accumulation_Zone_Length_User", <a><![CDATA[Gen_Accumulation_Zone_Length_User]]></a>.Value, "AppCalc^'Belted PandA'!J35", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:37:28 PM")
    AddProperty("9811", "Gen_Accumulation_Zone_Length_User_UOM", <a><![CDATA[Gen_Accumulation_Zone_Length_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:37:33 PM")
    AddProperty("9830", "Gen_Accumulation_Zone_Quantity", <a><![CDATA[Gen_Accumulation_Zone_Quantity]]></a>.Value, "AppCalc^'Belted PandA'!J34", "Long","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:37:39 PM")
    AddProperty("9823", "Gen_Belt_Speed_IN", <a><![CDATA[Gen_Belt_Speed_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 7:50:50 PM")
    AddProperty("9816", "Gen_Belt_Speed_User", <a><![CDATA[Gen_Belt_Speed_User]]></a>.Value, "AppCalc^'Belted PandA'!J32", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:37:47 PM")
    AddProperty("9903", "Gen_Belt_Speed_User_Max_Value", <a><![CDATA[Gen_Belt_Speed_User_Max_Value]]></a>.Value, "", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:37:51 PM")
    AddProperty("9904", "Gen_Belt_Speed_User_Min_Value", <a><![CDATA[Gen_Belt_Speed_User_Min_Value]]></a>.Value, "", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:38:03 PM")
    AddProperty("9809", "Gen_Belt_Speed_User_UOM", <a><![CDATA[Gen_Belt_Speed_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:38:09 PM")
    AddProperty("9826", "Gen_BM_Belt_Acc_Dec_Rate_IN", <a><![CDATA[Gen_BM_Belt_Acc_Dec_Rate_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:47:57 PM")
    AddProperty("9819", "Gen_BM_Belt_Acc_Dec_Rate_User", <a><![CDATA[Gen_BM_Belt_Acc_Dec_Rate_User]]></a>.Value, "AppCalc^'Belted PandA'!J37", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:40:52 PM")
    AddProperty("9905", "Gen_BM_Belt_Acc_Dec_Rate_User_Max_Value", <a><![CDATA[Gen_BM_Belt_Acc_Dec_Rate_User_Max_Value]]></a>.Value, "", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:38:23 PM")
    AddProperty("9906", "Gen_BM_Belt_Acc_Dec_Rate_User_Min_Value", <a><![CDATA[Gen_BM_Belt_Acc_Dec_Rate_User_Min_Value]]></a>.Value, "", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:38:27 PM")
    AddProperty("9812", "Gen_BM_Belt_Acc_Dec_Rate_User_UOM", <a><![CDATA[Gen_BM_Belt_Acc_Dec_Rate_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:38:32 PM")
    AddProperty("9827", "Gen_BM_Belt_Gap_Stop_Min_Carton_IN", <a><![CDATA[Gen_BM_Belt_Gap_Stop_Min_Carton_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:48:12 PM")
    AddProperty("9820", "Gen_BM_Belt_Gap_Stop_Min_Carton_User", <a><![CDATA[Gen_BM_Belt_Gap_Stop_Min_Carton_User]]></a>.Value, "AppCalc^'Belted PandA'!J39", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:44:12 PM")
    AddProperty("9813", "Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM", <a><![CDATA[Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:38:43 PM")
    AddProperty("9828", "Gen_BM_Belt_Input_Speed_IN", <a><![CDATA[Gen_BM_Belt_Input_Speed_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:48:26 PM")
    AddProperty("9821", "Gen_BM_Belt_Input_Speed_User", <a><![CDATA[Gen_BM_Belt_Input_Speed_User]]></a>.Value, "AppCalc^'Belted PandA'!J41", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:38:50 PM")
    AddProperty("9814", "Gen_BM_Belt_Input_Speed_User_UOM", <a><![CDATA[Gen_BM_Belt_Input_Speed_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:38:55 PM")
    AddProperty("9833", "Gen_BM_Belt_PTO_Ratio", <a><![CDATA[Gen_BM_Belt_PTO_Ratio]]></a>.Value, "AppCalc^'Belted PandA'!J40", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:38:59 PM")
    AddProperty("9893", "Gen_BM_Belt_PTO_Target_Ratio", <a><![CDATA[Gen_BM_Belt_PTO_Target_Ratio]]></a>.Value, "AppCalc^'Belted PandA'!S47", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:39:02 PM")
    AddProperty("9831", "Gen_Conveyor_Type", <a><![CDATA[Gen_Conveyor_Type]]></a>.Value, "AppCalc^'Belted PandA'!J36", "String","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:39:07 PM")
    AddProperty("9824", "Gen_Conveyor_Width_IN", <a><![CDATA[Gen_Conveyor_Width_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:48:41 PM")
    AddProperty("9817", "Gen_Conveyor_Width_User", <a><![CDATA[Gen_Conveyor_Width_User]]></a>.Value, "AppCalc^'Belted PandA'!J33", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:39:15 PM")
    AddProperty("9810", "Gen_Conveyor_Width_User_UOM", <a><![CDATA[Gen_Conveyor_Width_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:39:20 PM")
    AddProperty("9829", "Gen_MDR_Min_Gap_Throughput_Limit_IN", <a><![CDATA[Gen_MDR_Min_Gap_Throughput_Limit_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:48:55 PM")
    AddProperty("9822", "Gen_MDR_Min_Gap_Throughput_Limit_User", <a><![CDATA[Gen_MDR_Min_Gap_Throughput_Limit_User]]></a>.Value, "AppCalc^'Belted PandA'!J42", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:39:28 PM")
    AddProperty("9815", "Gen_MDR_Min_Gap_Throughput_Limit_User_UOM", <a><![CDATA[Gen_MDR_Min_Gap_Throughput_Limit_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:39:33 PM")
    AddProperty("9806", "Gen_Throughput_Rate", <a><![CDATA[Gen_Throughput_Rate]]></a>.Value, "AppCalc^'BeltedPandA'!J31", "Double","","AppCalc_PandA_General_Input","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:39:37 PM")
    AddProperty("9917", "Ind_Scan_Carton_Panels_Scanned_Quantity", <a><![CDATA[Ind_Scan_Carton_Panels_Scanned_Quantity]]></a>.Value, "AppCalc^'Belted PandA'!J52", "Long","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:09:02 PM")
    AddProperty("9923", "Ind_Scan_Carton_Percent_Max_Length_Scanned", <a><![CDATA[Ind_Scan_Carton_Percent_Max_Length_Scanned]]></a>.Value, "AppCalc^'Belted PandA'!60", "Double","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:09:32 PM")
    AddProperty("9924", "Ind_Scan_Carton_Percent_Max_Length_Scanned_User", <a><![CDATA[Ind_Scan_Carton_Percent_Max_Length_Scanned_User]]></a>.Value, "AppCalc^'Belted PandA'!60", "Double","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:38:17 PM")
    AddProperty("9919", "Ind_Scan_Carton_Presentation", <a><![CDATA[Ind_Scan_Carton_Presentation]]></a>.Value, "AppCalc^'Belted PandA'!54", "String","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:28:38 PM")
    AddProperty("9929", "Ind_Scan_Carton_Scanned_Max_Lin_Length_IN", <a><![CDATA[Ind_Scan_Carton_Scanned_Max_Lin_Length_IN]]></a>.Value, "Conversion to IN", "Double","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:49:32 PM")
    AddProperty("9933", "Ind_Scan_Carton_Scanned_Max_Lin_Length_User", <a><![CDATA[Ind_Scan_Carton_Scanned_Max_Lin_Length_User]]></a>.Value, "AppCalc^'Belted PandA'!J62", "Double","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 7:04:22 PM")
    AddProperty("9938", "Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM", <a><![CDATA[Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:39:11 PM")
    AddProperty("9918", "Ind_Scan_Label_Orientation", <a><![CDATA[Ind_Scan_Label_Orientation]]></a>.Value, "AppCalc^'Belted PandA'!53", "String","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 7:01:49 PM")
    AddProperty("9925", "Ind_Scan_Scan_App_Min_Gap_IN", <a><![CDATA[Ind_Scan_Scan_App_Min_Gap_IN]]></a>.Value, "Conversion to IN", "Double","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:49:45 PM")
    AddProperty("9926", "Ind_Scan_Scan_App_Min_Gap_User", <a><![CDATA[Ind_Scan_Scan_App_Min_Gap_User]]></a>.Value, "AppCalc^'Belted PandA'!J57", "Double","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:10:46 PM")
    AddProperty("9935", "Ind_Scan_Scan_App_Min_Gap_User_UOM", <a><![CDATA[Ind_Scan_Scan_App_Min_Gap_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:39:18 PM")
    AddProperty("9927", "Ind_Scan_Scan_Window_Length_Req_IN", <a><![CDATA[Ind_Scan_Scan_Window_Length_Req_IN]]></a>.Value, "Conversion to IN", "Double","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:49:56 PM")
    AddProperty("9931", "Ind_Scan_Scan_Window_Length_Req_User", <a><![CDATA[Ind_Scan_Scan_Window_Length_Req_User]]></a>.Value, "AppCalc^'Belted PandA'!J58", "Double","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:13:48 PM")
    AddProperty("9936", "Ind_Scan_Scan_Window_Length_Req_User_UOM", <a><![CDATA[Ind_Scan_Scan_Window_Length_Req_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:39:34 PM")
    AddProperty("9916", "Ind_Scan_Scanner_Config", <a><![CDATA[Ind_Scan_Scanner_Config]]></a>.Value, "AppCalc^'Belted PandA'!51", "String","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:18:06 PM")
    AddProperty("9922", "Ind_Scan_Scanner_Data_Transmit_Mode", <a><![CDATA[Ind_Scan_Scanner_Data_Transmit_Mode]]></a>.Value, "AppCalc^'Belted PandA'!59", "String","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:35:10 PM")
    AddProperty("9930", "Ind_Scan_Scanner_Min_Xmit_Point_IN", <a><![CDATA[Ind_Scan_Scanner_Min_Xmit_Point_IN]]></a>.Value, "Conversion to IN", "Double","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:50:14 PM")
    AddProperty("9934", "Ind_Scan_Scanner_Min_Xmit_Point_User", <a><![CDATA[Ind_Scan_Scanner_Min_Xmit_Point_User]]></a>.Value, "AppCalc^'Belted PandA'!J63", "Double","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 6:47:26 PM")
    AddProperty("9939", "Ind_Scan_Scanner_Min_Xmit_Point_User_UOM", <a><![CDATA[Ind_Scan_Scanner_Min_Xmit_Point_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:39:26 PM")
    AddProperty("9921", "Ind_Scan_Shadowing_Allowed", <a><![CDATA[Ind_Scan_Shadowing_Allowed]]></a>.Value, "AppCalc^'Belted PandA'!56", "String","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:31:50 PM")
    AddProperty("9920", "Ind_Scan_Shadowing_Potential", <a><![CDATA[Ind_Scan_Shadowing_Potential]]></a>.Value, "AppCalc^'Belted PandA'!55", "String","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:28:58 PM")
    AddProperty("9928", "Ind_Scan_Tracking_Photocell_Distance_IN", <a><![CDATA[Ind_Scan_Tracking_Photocell_Distance_IN]]></a>.Value, "Conversion to IN", "Double","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:50:24 PM")
    AddProperty("9932", "Ind_Scan_Tracking_Photocell_Distance_User", <a><![CDATA[Ind_Scan_Tracking_Photocell_Distance_User]]></a>.Value, "AppCalc^'Belted PandA'!J61", "Double","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 7:33:53 PM")
    AddProperty("9948", "Ind_Scan_Tracking_Photocell_Distance_User_Max_Val", <a><![CDATA[Ind_Scan_Tracking_Photocell_Distance_User_Max_Val]]></a>.Value, "", "Double","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 7:00:57 PM")
    AddProperty("9949", "Ind_Scan_Tracking_Photocell_Distance_User_Min_Val", <a><![CDATA[Ind_Scan_Tracking_Photocell_Distance_User_Min_Val]]></a>.Value, "", "Double","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 7:01:03 PM")
    AddProperty("9937", "Ind_Scan_Tracking_Photocell_Distance_User_UOM", <a><![CDATA[Ind_Scan_Tracking_Photocell_Distance_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Induction_Scanning","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 4:39:42 PM")
    AddProperty("9998", "MDR_RAT_Swivel_Rate", <a><![CDATA[MDR_RAT_Swivel_Rate]]></a>.Value, "AppCalc^'MDR Sort'!S39", "Double","","AppCalc_PandA_MDR","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:46:12 PM")
    AddProperty("9875", "MTBH_Height_Average_IN", <a><![CDATA[MTBH_Height_Average_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:50:50 PM")
    AddProperty("9858", "MTBH_Height_Average_User", <a><![CDATA[MTBH_Height_Average_User]]></a>.Value, "AppCalc^'Belted PandA'!H49", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:29:39 PM")
    AddProperty("9852", "MTBH_Height_Average_User_UOM", <a><![CDATA[MTBH_Height_Average_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:28:36 PM")
    AddProperty("9874", "MTBH_Height_Maximum_IN", <a><![CDATA[MTBH_Height_Maximum_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:50:58 PM")
    AddProperty("9857", "MTBH_Height_Maximum_User", <a><![CDATA[MTBH_Height_Maximum_User]]></a>.Value, "AppCalc^'Belted PandA'!H48", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:28:27 PM")
    AddProperty("9913", "MTBH_Height_Maximum_User_Max_Value", <a><![CDATA[MTBH_Height_Maximum_User_Max_Value]]></a>.Value, "", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:28:10 PM")
    AddProperty("9851", "MTBH_Height_Maximum_User_UOM", <a><![CDATA[MTBH_Height_Maximum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:26:42 PM")
    AddProperty("9873", "MTBH_Height_Minimum_IN", <a><![CDATA[MTBH_Height_Minimum_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:51:08 PM")
    AddProperty("9856", "MTBH_Height_Minimum_User", <a><![CDATA[MTBH_Height_Minimum_User]]></a>.Value, "AppCalc^'Belted PandA'!H47", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:26:32 PM")
    AddProperty("9912", "MTBH_Height_Minimum_User_Min_Value", <a><![CDATA[MTBH_Height_Minimum_User_Min_Value]]></a>.Value, "", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:26:16 PM")
    AddProperty("9850", "MTBH_Height_Minimum_User_UOM", <a><![CDATA[MTBH_Height_Minimum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:25:02 PM")
    AddProperty("9868", "MTBH_Length_Average_IN", <a><![CDATA[MTBH_Length_Average_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:51:20 PM")
    AddProperty("9846", "MTBH_Length_Average_User", <a><![CDATA[MTBH_Length_Average_User]]></a>.Value, "AppCalc^'Belted PandA'!D49", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 2:54:33 PM")
    AddProperty("9837", "MTBH_Length_Average_User_UOM", <a><![CDATA[MTBH_Length_Average_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 2:48:29 PM")
    AddProperty("9867", "MTBH_Length_Maximum_IN", <a><![CDATA[MTBH_Length_Maximum_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:51:31 PM")
    AddProperty("9845", "MTBH_Length_Maximum_User", <a><![CDATA[MTBH_Length_Maximum_User]]></a>.Value, "AppCalc^'Belted PandA'!D48", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 2:56:59 PM")
    AddProperty("9909", "MTBH_Length_Maximum_User_Max_Value", <a><![CDATA[MTBH_Length_Maximum_User_Max_Value]]></a>.Value, "", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:10:28 PM")
    AddProperty("9836", "MTBH_Length_Maximum_User_UOM", <a><![CDATA[MTBH_Length_Maximum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 2:44:22 PM")
    AddProperty("9866", "MTBH_Length_Minimum_IN", <a><![CDATA[MTBH_Length_Minimum_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:51:42 PM")
    AddProperty("9844", "MTBH_Length_Minimum_User", <a><![CDATA[MTBH_Length_Minimum_User]]></a>.Value, "AppCalc^'Belted PandA'!D47", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 2:56:22 PM")
    AddProperty("9908", "MTBH_Length_Minimum_User_Min_Value", <a><![CDATA[MTBH_Length_Minimum_User_Min_Value]]></a>.Value, "", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 2:42:41 PM")
    AddProperty("9835", "MTBH_Length_Minimum_User_UOM", <a><![CDATA[MTBH_Length_Minimum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 2:44:13 PM")
    AddProperty("9834", "MTBH_Use_Local", <a><![CDATA[MTBH_Use_Local]]></a>.Value, "AppCalc^'Belted PandA'!J40", "String","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 2:48:55 PM")
    AddProperty("9880", "MTBH_Weight_Average_LBS", <a><![CDATA[MTBH_Weight_Average_LBS]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:51:57 PM")
    AddProperty("9861", "MTBH_Weight_Average_User", <a><![CDATA[MTBH_Weight_Average_User]]></a>.Value, "AppCalc^'Belted PandA'!J49", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:37:08 PM")
    AddProperty("9864", "MTBH_Weight_Average_User_UOM", <a><![CDATA[MTBH_Weight_Average_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:36:06 PM")
    AddProperty("9878", "MTBH_Weight_Maximum_LBS", <a><![CDATA[MTBH_Weight_Maximum_LBS]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:52:09 PM")
    AddProperty("9860", "MTBH_Weight_Maximum_User", <a><![CDATA[MTBH_Weight_Maximum_User]]></a>.Value, "AppCalc^'Belted PandA'!J48", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:35:50 PM")
    AddProperty("9915", "MTBH_Weight_Maximum_User_Max_Value", <a><![CDATA[MTBH_Weight_Maximum_User_Max_Value]]></a>.Value, "", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:35:27 PM")
    AddProperty("9863", "MTBH_Weight_Maximum_User_UOM", <a><![CDATA[MTBH_Weight_Maximum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:33:51 PM")
    AddProperty("9877", "MTBH_Weight_Minimum_LBS", <a><![CDATA[MTBH_Weight_Minimum_LBS]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:52:21 PM")
    AddProperty("9859", "MTBH_Weight_Minimum_User", <a><![CDATA[MTBH_Weight_Minimum_User]]></a>.Value, "AppCalc^'Belted PandA'!J47", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:33:27 PM")
    AddProperty("9914", "MTBH_Weight_Minimum_User_Min_Value", <a><![CDATA[MTBH_Weight_Minimum_User_Min_Value]]></a>.Value, "", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:32:45 PM")
    AddProperty("9862", "MTBH_Weight_Minimum_User_UOM", <a><![CDATA[MTBH_Weight_Minimum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:30:28 PM")
    AddProperty("9872", "MTBH_Width_Average_IN", <a><![CDATA[MTBH_Width_Average_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:52:31 PM")
    AddProperty("9855", "MTBH_Width_Average_User", <a><![CDATA[MTBH_Width_Average_User]]></a>.Value, "AppCalc^'Belted PandA'!F49", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:15:47 PM")
    AddProperty("9843", "MTBH_Width_Average_User_UOM", <a><![CDATA[MTBH_Width_Average_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:14:54 PM")
    AddProperty("9871", "MTBH_Width_Maximum_IN", <a><![CDATA[MTBH_Width_Maximum_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:52:42 PM")
    AddProperty("9854", "MTBH_Width_Maximum_User", <a><![CDATA[MTBH_Width_Maximum_User]]></a>.Value, "AppCalc^'Belted PandA'!F48", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:22:03 PM")
    AddProperty("9911", "MTBH_Width_Maximum_User_Max_Value", <a><![CDATA[MTBH_Width_Maximum_User_Max_Value]]></a>.Value, "", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:19:26 PM")
    AddProperty("9842", "MTBH_Width_Maximum_User_UOM", <a><![CDATA[MTBH_Width_Maximum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:12:33 PM")
    AddProperty("9870", "MTBH_Width_Minimum_IN", <a><![CDATA[MTBH_Width_Minimum_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:52:54 PM")
    AddProperty("9853", "MTBH_Width_Minimum_User", <a><![CDATA[MTBH_Width_Minimum_User]]></a>.Value, "AppCalc^'Belted PandA'!F47", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:23:42 PM")
    AddProperty("9910", "MTBH_Width_Minimum_User_Min_Value", <a><![CDATA[MTBH_Width_Minimum_User_Min_Value]]></a>.Value, "", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 3:19:35 PM")
    AddProperty("9841", "MTBH_Width_Minimum_User_UOM", <a><![CDATA[MTBH_Width_Minimum_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/11/2025 2:54:47 PM")
    AddProperty("9985", "Reject_Diverter_Min_Gap_Required_IN", <a><![CDATA[Reject_Diverter_Min_Gap_Required_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_Reject_Diverter","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:16:25 PM")
    AddProperty("9973", "Reject_Diverter_Min_Gap_Required_User", <a><![CDATA[Reject_Diverter_Min_Gap_Required_User]]></a>.Value, "AppCalc^'Belted PandA'!J125", "Double","","AppCalc_PandA_Reject_Diverter","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 2:32:46 PM")
    AddProperty("9970", "Reject_Diverter_Min_Gap_Required_User_UOM", <a><![CDATA[Reject_Diverter_Min_Gap_Required_User_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Reject_Diverter","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:06:31 PM")
    AddProperty("9968", "Reject_Diverter_Required", <a><![CDATA[Reject_Diverter_Required]]></a>.Value, "AppCalc^'Belted PandA'!J123", "String","","AppCalc_PandA_Reject_Diverter","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 12:58:01 PM")
    AddProperty("9990", "Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_IN", <a><![CDATA[Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_Reject_Diverter","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:20:46 PM")
    AddProperty("9972", "Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM", <a><![CDATA[Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Reject_Diverter","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:06:53 PM")
    AddProperty("9989", "Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User", <a><![CDATA[Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User]]></a>.Value, "AppCalc^'Belted PandA'!J127", "Double","","AppCalc_PandA_Reject_Diverter","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:57:30 PM")
    AddProperty("9987", "Reject_Diverter_Spacing_Cont_Flow_Max_Carton_IN", <a><![CDATA[Reject_Diverter_Spacing_Cont_Flow_Max_Carton_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_Reject_Diverter","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:20:15 PM")
    AddProperty("9971", "Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM", <a><![CDATA[Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM]]></a>.Value, "Property User UOM", "String","","AppCalc_PandA_Reject_Diverter","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:06:40 PM")
    AddProperty("9988", "Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User", <a><![CDATA[Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User]]></a>.Value, "AppCalc^'Belted PandA'!J126", "Double","","AppCalc_PandA_Reject_Diverter","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:57:39 PM")
    AddProperty("9969", "Reject_Diverter_Type", <a><![CDATA[Reject_Diverter_Type]]></a>.Value, "AppCalc^'Belted PandA'!J124", "String","","AppCalc_PandA_Reject_Diverter","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:01:04 PM")
    AddProperty("9994", "Transnorm_TS4800_Control_Reaction_Time_Distance_IN", <a><![CDATA[Transnorm_TS4800_Control_Reaction_Time_Distance_IN]]></a>.Value, "AppCalc^'Belted PandA'!T127", "Double","","AppCalc_PandA_Transnorm_TS4800","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:36:54 PM")
    AddProperty("9992", "Transnorm_TS4800_Divert_Angle", <a><![CDATA[Transnorm_TS4800_Divert_Angle]]></a>.Value, "AppCalc^'Belted PandA'!T124", "Double","","AppCalc_PandA_Transnorm_TS4800","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:36:58 PM")
    AddProperty("9993", "Transnorm_TS4800_Divert_Shifting_Distance_IN", <a><![CDATA[Transnorm_TS4800_Divert_Shifting_Distance_IN]]></a>.Value, "AppCalc^'Belted PandA'!T125", "Double","","AppCalc_PandA_Transnorm_TS4800","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:37:03 PM")
    AddProperty("9995", "Transnorm_TS4800_Encoder_Resolution_IN", <a><![CDATA[Transnorm_TS4800_Encoder_Resolution_IN]]></a>.Value, "AppCalc^'Belted PandA'!T128", "Double","","AppCalc_PandA_Transnorm_TS4800","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:37:32 PM")
    AddProperty("9996", "Transnorm_TS4800_Required_Gap_Max_Box", <a><![CDATA[Transnorm_TS4800_Required_Gap_Max_Box]]></a>.Value, "AppCalc^'Belted PandA'!T128", "Double","","AppCalc_PandA_Transnorm_TS4800","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/12/2025 1:38:48 PM")
    AddProperty("9805", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/10/2025 4:45:56 PM")
    
      AddPropertyExtended(9830,"Gen_Accumulation_Zone_Quantity", "9414", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/11/2025 3:37:39 PM")
    
      AddPropertyExtended(9816,"Gen_Belt_Speed_User", "9400", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/11/2025 3:37:47 PM")
    
      AddPropertyExtended(9819,"Gen_BM_Belt_Acc_Dec_Rate_User", "9403", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/11/2025 3:40:52 PM")
    
      AddPropertyExtended(9806,"Gen_Throughput_Rate", "9390", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/11/2025 3:39:37 PM")
    
      AddPropertyExtended(9844,"MTBH_Length_Minimum_User", "9428", "EXTTOOLT", "Tooltip", "FORMULA", "GLOBAL\H602502", "7/11/2025 2:56:22 PM")
    
      AddValidValue("User_UOM_System")
    
      AddValidValue("Acq_Label_Data_Acquisition_Method")
    
      AddValidValue("Acq_Label_Data_Acquisition_Travel_User_UOM")
    
      AddValidValue("Conv_Total_App_Belt_Length_Req_FT_User_UOM")
    
      AddValidValue("Conv_Total_App_Belt_Length_Req_IN_User_UOM")
    
      AddValidValue("Conv_Total_Solution_Length_FT_User_UOM")
    
      AddValidValue("Gen_Accumulation_Zone_Length_User")
    
      AddValidValue("Gen_Accumulation_Zone_Length_User_UOM")
    
      AddValidValue("Gen_Belt_Speed_User_UOM")
    
      AddValidValue("Gen_BM_Belt_Acc_Dec_Rate_User_UOM")
    
      AddValidValue("Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM")
    
      AddValidValue("Gen_BM_Belt_Input_Speed_User_UOM")
    
      AddValidValue("Gen_Conveyor_Type")
    
      AddValidValue("Gen_Conveyor_Width_User")
    
      AddValidValue("Gen_Conveyor_Width_User_UOM")
    
      AddValidValue("Gen_MDR_Min_Gap_Throughput_Limit_User_UOM")
    
      AddValidValue("Ind_Scan_Carton_Presentation")
    
      AddValidValue("Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM")
    
      AddValidValue("Ind_Scan_Label_Orientation")
    
      AddValidValue("Ind_Scan_Scan_App_Min_Gap_User_UOM")
    
      AddValidValue("Ind_Scan_Scan_Window_Length_Req_User_UOM")
    
      AddValidValue("Ind_Scan_Scanner_Config")
    
      AddValidValue("Ind_Scan_Scanner_Data_Transmit_Mode")
    
      AddValidValue("Ind_Scan_Scanner_Min_Xmit_Point_User_UOM")
    
      AddValidValue("Ind_Scan_Shadowing_Allowed")
    
      AddValidValue("Ind_Scan_Shadowing_Potential")
    
      AddValidValue("Ind_Scan_Tracking_Photocell_Distance_User_UOM")
    
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
    
      AddValidValue("Reject_Diverter_Min_Gap_Required_User_UOM")
    
      AddValidValue("Reject_Diverter_Required")
    
      AddValidValue("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM")
    
      AddValidValue("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM")
    
      AddValidValue("Reject_Diverter_Type")
    
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
          InitProperty("User_UOM_System", "9392", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/10/2025 6:08:33 PM", "", "In Development",  0,16115)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Acq_Label_Data_Acquisition_Method", "9533", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 7:15:41 PM", "", "In Development",  0,16575)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Acq_Label_Data_Acquisition_Travel_IN", "9538", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 7:47:28 PM", "", "In Development",  0,16605)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Acq_Label_Data_Acquisition_Travel_User", "9536", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 7:58:41 PM", "", "In Development",  0,16610)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Acq_Label_Data_Acquisition_Travel_User_UOM", "9537", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 7:20:45 PM", "", "In Development",  0,16587)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Acq_Max_Host_Resp_Time_Secs", "9534", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 7:30:55 PM", "", "In Development",  0,16595)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Acq_Max_Local_Lookup_Time_Secs", "9535", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 7:30:43 PM", "", "In Development",  0,16594)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conv_Total_App_Belt_Length_Req_FT", "9588", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 3:06:14 PM", "", "In Development",  0,16732)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conv_Total_App_Belt_Length_Req_FT_User", "9585", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 3:04:43 PM", "", "In Development",  0,16727)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conv_Total_App_Belt_Length_Req_FT_User_UOM", "9582", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/12/2025 3:03:33 PM", "", "In Development",  0,16723)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conv_Total_App_Belt_Length_Req_IN", "9587", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 3:05:42 PM", "", "In Development",  0,16730)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conv_Total_App_Belt_Length_Req_IN_User", "9584", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 3:04:33 PM", "", "In Development",  0,16726)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conv_Total_App_Belt_Length_Req_IN_User_UOM", "9581", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/12/2025 3:02:43 PM", "", "In Development",  0,16719)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conv_Total_Solution_Length_FT", "9589", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 3:06:37 PM", "", "In Development",  0,16734)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conv_Total_Solution_Length_FT_User", "9586", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 3:04:56 PM", "", "In Development",  0,16728)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Conv_Total_Solution_Length_FT_User_UOM", "9583", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/12/2025 3:04:03 PM", "", "In Development",  0,16724)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Accumulation_Convey_Type_Pre_Panda", "9416", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/10/2025 6:26:59 PM", "", "In Development",  0,16160)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Accumulation_Zone_Length_IN", "9409", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:47:42 PM", "", "In Development",  0,16624)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Accumulation_Zone_Length_User", "9402", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/10/2025 9:01:56 PM", "", "In Development",  0,16282)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Accumulation_Zone_Length_User_UOM", "9395", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:47:44 PM", "", "In Development",  0,16123)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Accumulation_Zone_Quantity", "9414", "8", "20", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 2:31:13 PM", "", "In Development",  0,16281)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Belt_Speed_IN", "9407", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 7:50:50 PM", "", "In Development",  0,16606)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Belt_Speed_User", "9400", "Gen_Belt_Speed_User_Min_Value", "Gen_Belt_Speed_User_Max_Value", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 2:28:16 PM", "", "In Development",  0,16414)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Belt_Speed_User_Max_Value", "9487", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 2:26:46 PM", "", "In Development",  0,16433)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Belt_Speed_User_Min_Value", "9488", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 2:27:54 PM", "", "In Development",  0,16435)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Belt_Speed_User_UOM", "9393", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:48:08 PM", "", "In Development",  0,16287)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_BM_Belt_Acc_Dec_Rate_IN", "9410", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:47:57 PM", "", "In Development",  0,16625)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_BM_Belt_Acc_Dec_Rate_User", "9403", "Gen_BM_Belt_Acc_Dec_Rate_User_Min_Value", "Gen_BM_Belt_Acc_Dec_Rate_User_Max_Value", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:40:52 PM", "", "In Development",  0,16487)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_BM_Belt_Acc_Dec_Rate_User_Max_Value", "9489", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 2:35:15 PM", "", "In Development",  0,16439)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_BM_Belt_Acc_Dec_Rate_User_Min_Value", "9490", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 2:35:40 PM", "", "In Development",  0,16441)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_BM_Belt_Acc_Dec_Rate_User_UOM", "9396", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:47:51 PM", "", "In Development",  0,16291)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_BM_Belt_Gap_Stop_Min_Carton_IN", "9411", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:48:12 PM", "", "In Development",  0,16626)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_BM_Belt_Gap_Stop_Min_Carton_User", "9404", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:44:12 PM", "", "In Development",  0,16418)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM", "9397", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:47:59 PM", "", "In Development",  0,16127)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_BM_Belt_Input_Speed_IN", "9412", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:48:26 PM", "", "In Development",  0,16627)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_BM_Belt_Input_Speed_User", "9405", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:47:24 PM", "", "In Development",  0,16416)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_BM_Belt_Input_Speed_User_UOM", "9398", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:48:18 PM", "", "In Development",  0,16294)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_BM_Belt_PTO_Ratio", "9417", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:37:38 PM", "", "In Development",  0,16413)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_BM_Belt_PTO_Target_Ratio", "9477", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:12:32 PM", "", "In Development",  0,16397)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Conveyor_Type", "9415", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/10/2025 6:24:36 PM", "", "In Development",  0,16156)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Conveyor_Width_IN", "9408", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:48:41 PM", "", "In Development",  0,16628)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Conveyor_Width_User", "9401", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/10/2025 8:40:02 PM", "", "In Development",  0,16263)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Conveyor_Width_User_UOM", "9394", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:48:30 PM", "", "In Development",  0,16121)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_MDR_Min_Gap_Throughput_Limit_IN", "9413", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:48:55 PM", "", "In Development",  0,16629)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_MDR_Min_Gap_Throughput_Limit_User", "9406", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/10/2025 9:06:58 PM", "", "In Development",  0,16284)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_MDR_Min_Gap_Throughput_Limit_User_UOM", "9399", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:48:38 PM", "", "In Development",  0,16131)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gen_Throughput_Rate", "9390", "0", "60", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 1:27:15 PM", "", "In Development",  0,16109)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Carton_Panels_Scanned_Quantity", "9501", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:09:02 PM", "", "In Development",  0,16490)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Carton_Percent_Max_Length_Scanned", "9507", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:09:32 PM", "", "In Development",  0,16498)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Carton_Percent_Max_Length_Scanned_User", "9508", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:38:17 PM", "", "In Development",  0,16533)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Carton_Presentation", "9503", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:28:38 PM", "", "In Development",  0,16524)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Carton_Scanned_Max_Lin_Length_IN", "9513", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:49:32 PM", "", "In Development",  0,16630)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Carton_Scanned_Max_Lin_Length_User", "9517", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 7:04:22 PM", "", "In Development",  0,16572)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM", "9522", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:16:16 PM", "", "In Development",  0,16516)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Label_Orientation", "9502", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 7:01:49 PM", "", "In Development",  0,16522)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Scan_App_Min_Gap_IN", "9509", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:49:45 PM", "", "In Development",  0,16631)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Scan_App_Min_Gap_User", "9510", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:10:27 PM", "", "In Development",  0,16501)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Scan_App_Min_Gap_User_UOM", "9519", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:15:51 PM", "", "In Development",  0,16510)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Scan_Window_Length_Req_IN", "9511", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:49:56 PM", "", "In Development",  0,16632)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Scan_Window_Length_Req_User", "9515", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:13:43 PM", "", "In Development",  0,16506)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Scan_Window_Length_Req_User_UOM", "9520", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:16:00 PM", "", "In Development",  0,16512)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Scanner_Config", "9500", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:18:06 PM", "", "In Development",  0,16520)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Scanner_Data_Transmit_Mode", "9506", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:35:10 PM", "", "In Development",  0,16531)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Scanner_Min_Xmit_Point_IN", "9514", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:50:14 PM", "", "In Development",  0,16633)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Scanner_Min_Xmit_Point_User", "9518", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 6:47:26 PM", "", "In Development",  0,16561)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Scanner_Min_Xmit_Point_User_UOM", "9523", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:16:29 PM", "", "In Development",  0,16518)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Shadowing_Allowed", "9505", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:31:50 PM", "", "In Development",  0,16528)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Shadowing_Potential", "9504", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:28:58 PM", "", "In Development",  0,16526)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Tracking_Photocell_Distance_IN", "9512", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:50:24 PM", "", "In Development",  0,16634)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Tracking_Photocell_Distance_User", "9516", "Ind_Scan_Tracking_Photocell_Distance_User_Min_Val", "Ind_Scan_Tracking_Photocell_Distance_User_Max_Val", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 7:33:53 PM", "", "In Development",  0,16596)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Tracking_Photocell_Distance_User_Max_Val", "9530", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 7:00:57 PM", "", "In Development",  0,16568)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Tracking_Photocell_Distance_User_Min_Val", "9531", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 7:01:03 PM", "", "In Development",  0,16569)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Ind_Scan_Tracking_Photocell_Distance_User_UOM", "9521", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 4:16:09 PM", "", "In Development",  0,16514)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MDR_RAT_Swivel_Rate", "9580", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:46:12 PM", "", "In Development",  0,16713)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Average_IN", "9459", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:50:50 PM", "", "In Development",  0,16635)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Average_User", "9442", "MTBH_Height_Minimum_User", "MTBH_Height_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:29:39 PM", "", "In Development",  0,16477)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Average_User_UOM", "9436", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:48:55 PM", "", "In Development",  0,16195)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Maximum_IN", "9458", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:50:58 PM", "", "In Development",  0,16636)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Maximum_User", "9441", "MTBH_Height_Minimum_User", "MTBH_Height_Maximum_User_Max_Value", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:28:27 PM", "", "In Development",  0,16473)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Maximum_User_Max_Value", "9497", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:28:10 PM", "", "In Development",  0,16476)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Maximum_User_UOM", "9435", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:49:01 PM", "", "In Development",  0,16193)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Minimum_IN", "9457", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:51:08 PM", "", "In Development",  0,16637)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Minimum_User", "9440", "MTBH_Height_Minimum_User_Min_Value", "MTBH_Height_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:26:32 PM", "", "In Development",  0,16470)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Minimum_User_Min_Value", "9496", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:26:16 PM", "", "In Development",  0,16472)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Minimum_User_UOM", "9434", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:49:07 PM", "", "In Development",  0,16191)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Average_IN", "9452", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:51:20 PM", "", "In Development",  0,16638)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Average_User", "9430", "MTBH_Length_Minimum_User", "MTBH_Length_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 2:53:53 PM", "", "In Development",  0,16452)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Average_User_UOM", "9421", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:49:13 PM", "", "In Development",  0,16171)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Maximum_IN", "9451", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:51:31 PM", "", "In Development",  0,16639)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Maximum_User", "9429", "MTBH_Length_Minimum_User", "MTBH_Length_Maximum_User_Max_Value", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 2:56:59 PM", "", "In Development",  0,16453)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Maximum_User_Max_Value", "9493", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:10:28 PM", "", "In Development",  0,16456)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Maximum_User_UOM", "9420", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:49:18 PM", "", "In Development",  0,16169)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Minimum_IN", "9450", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:51:42 PM", "", "In Development",  0,16640)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Minimum_User", "9428", "MTBH_Length_Minimum_User_Min_Value", "MTBH_Length_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 2:56:22 PM", "", "In Development",  0,16444)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Minimum_User_Min_Value", "9492", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 2:42:41 PM", "", "In Development",  0,16448)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Length_Minimum_User_UOM", "9419", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:49:24 PM", "", "In Development",  0,16167)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Use_Local", "9418", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 1:24:34 PM", "", "In Development",  0,16430)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Average_LBS", "9464", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:51:57 PM", "", "In Development",  0,16641)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Average_User", "9445", "MTBH_Weight_Minimum_User", "MTBH_Weight_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:37:08 PM", "", "In Development",  0,16486)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Average_User_UOM", "9448", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:49:32 PM", "", "In Development",  0,16212)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Maximum_LBS", "9462", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:52:09 PM", "", "In Development",  0,16642)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Maximum_User", "9444", "MTBH_Weight_Minimum_User", "MTBH_Weight_Maximum_User_Max_Value", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:35:50 PM", "", "In Development",  0,16483)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Maximum_User_Max_Value", "9499", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:35:27 PM", "", "In Development",  0,16485)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Maximum_User_UOM", "9447", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:49:40 PM", "", "In Development",  0,16210)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Minimum_LBS", "9461", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:52:21 PM", "", "In Development",  0,16644)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Minimum_User", "9443", "MTBH_Weight_Minimum_User_Min_Value", "MTBH_Weight_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:33:12 PM", "", "In Development",  0,16481)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Minimum_User_Min_Value", "9498", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:32:45 PM", "", "In Development",  0,16480)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Weight_Minimum_User_UOM", "9446", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:49:46 PM", "", "In Development",  0,16208)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Average_IN", "9456", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:52:31 PM", "", "In Development",  0,16645)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Average_User", "9439", "MTBH_Width_Minimum_User", "MTBH_Width_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:15:47 PM", "", "In Development",  0,16461)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Average_User_UOM", "9427", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:49:55 PM", "", "In Development",  0,16183)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Maximum_IN", "9455", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:52:42 PM", "", "In Development",  0,16646)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Maximum_User", "9438", "MTBH_Width_Minimum_User", "MTBH_Width_Maximum_User_Max_Value", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:22:03 PM", "", "In Development",  0,16468)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Maximum_User_Max_Value", "9495", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:19:26 PM", "", "In Development",  0,16464)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Maximum_User_UOM", "9426", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:50:00 PM", "", "In Development",  0,16181)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Minimum_IN", "9454", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:52:54 PM", "", "In Development",  0,16648)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Minimum_User", "9437", "MTBH_Width_Minimum_User_Min_Value", "MTBH_Width_Maximum_User", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:23:42 PM", "", "In Development",  0,16469)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Minimum_User_Min_Value", "9494", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/11/2025 3:19:35 PM", "", "In Development",  0,16465)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Width_Minimum_User_UOM", "9425", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/11/2025 12:50:05 PM", "", "In Development",  0,16179)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reject_Diverter_Min_Gap_Required_IN", "9567", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:16:25 PM", "", "In Development",  0,16677)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reject_Diverter_Min_Gap_Required_User", "9555", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 2:32:46 PM", "", "In Development",  0,16718)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reject_Diverter_Min_Gap_Required_User_UOM", "9552", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:06:24 PM", "", "In Development",  0,16658)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reject_Diverter_Required", "9550", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/12/2025 12:58:01 PM", "", "In Development",  0,16651)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_IN", "9572", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:20:46 PM", "", "In Development",  0,16686)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM", "9554", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:06:53 PM", "", "In Development",  0,16662)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User", "9571", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:57:30 PM", "", "In Development",  0,16715)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_IN", "9569", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:20:15 PM", "", "In Development",  0,16684)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM", "9553", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:06:40 PM", "", "In Development",  0,16660)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User", "9570", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:57:39 PM", "", "In Development",  0,16717)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Reject_Diverter_Type", "9551", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:01:04 PM", "", "In Development",  0,16655)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Transnorm_TS4800_Control_Reaction_Time_Distance_IN", "9576", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:36:05 PM", "", "In Development",  0,16701)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Transnorm_TS4800_Divert_Angle", "9574", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:32:51 PM", "", "In Development",  0,16694)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Transnorm_TS4800_Divert_Shifting_Distance_IN", "9575", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:35:21 PM", "", "In Development",  0,16699)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Transnorm_TS4800_Encoder_Resolution_IN", "9577", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:37:32 PM", "", "In Development",  0,16704)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Transnorm_TS4800_Required_Gap_Max_Box", "9578", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/12/2025 1:38:48 PM", "", "In Development",  0,16707)
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
          
        InitValidValue("User_UOM_System_ValidValues", "9392", "-1", 16116)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Acq_Label_Data_Acquisition_Method_ValidValues", "9533", "-1", 16576)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Acq_Label_Data_Acquisition_Travel_User_UOM_ValidValues", "9537", "-1", 16588)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Conv_Total_App_Belt_Length_Req_FT_User_UOM_ValidValues", "9582", "-1", 16722)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Conv_Total_App_Belt_Length_Req_IN_User_UOM_ValidValues", "9581", "-1", 16720)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Conv_Total_Solution_Length_FT_User_UOM_ValidValues", "9583", "-1", 16725)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Gen_Accumulation_Zone_Length_User_ValidValues", "9402", "-1", 16283)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Gen_Accumulation_Zone_Length_User_UOM_ValidValues", "9395", "-1", 16124)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Gen_Belt_Speed_User_UOM_ValidValues", "9393", "-1", 16288)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Gen_BM_Belt_Acc_Dec_Rate_User_UOM_ValidValues", "9396", "-1", 16292)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM_ValidValues", "9397", "-1", 16128)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Gen_BM_Belt_Input_Speed_User_UOM_ValidValues", "9398", "-1", 16295)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Gen_Conveyor_Type_ValidValues", "9415", "-1", 16157)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Gen_Conveyor_Width_User_ValidValues", "9401", "-1", 16279)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Gen_Conveyor_Width_User_UOM_ValidValues", "9394", "-1", 16122)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Gen_MDR_Min_Gap_Throughput_Limit_User_UOM_ValidValues", "9399", "-1", 16132)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Ind_Scan_Carton_Presentation_ValidValues", "9503", "-1", 16525)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM_ValidValues", "9522", "-1", 16517)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Ind_Scan_Label_Orientation_ValidValues", "9502", "-1", 16539)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Ind_Scan_Scan_App_Min_Gap_User_UOM_ValidValues", "9519", "-1", 16511)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Ind_Scan_Scan_Window_Length_Req_User_UOM_ValidValues", "9520", "-1", 16513)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Ind_Scan_Scanner_Config_ValidValues", "9500", "-1", 16521)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Ind_Scan_Scanner_Data_Transmit_Mode_ValidValues", "9506", "-1", 16532)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Ind_Scan_Scanner_Min_Xmit_Point_User_UOM_ValidValues", "9523", "-1", 16519)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Ind_Scan_Shadowing_Allowed_ValidValues", "9505", "-1", 16530)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Ind_Scan_Shadowing_Potential_ValidValues", "9504", "-1", 16527)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Ind_Scan_Tracking_Photocell_Distance_User_UOM_ValidValues", "9521", "-1", 16515)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Height_Average_User_UOM_ValidValues", "9436", "-1", 16196)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Height_Maximum_User_UOM_ValidValues", "9435", "-1", 16194)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Height_Minimum_User_UOM_ValidValues", "9434", "-1", 16192)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Length_Average_User_UOM_ValidValues", "9421", "-1", 16172)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Length_Maximum_User_UOM_ValidValues", "9420", "-1", 16170)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Length_Minimum_User_UOM_ValidValues", "9419", "-1", 16168)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Use_Local_ValidValues", "9418", "-1", 16166)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Weight_Average_User_UOM_ValidValues", "9448", "-1", 16213)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Weight_Maximum_User_UOM_ValidValues", "9447", "-1", 16211)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Weight_Minimum_User_UOM_ValidValues", "9446", "-1", 16209)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Width_Average_User_UOM_ValidValues", "9427", "-1", 16184)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Width_Maximum_User_UOM_ValidValues", "9426", "-1", 16182)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("MTBH_Width_Minimum_User_UOM_ValidValues", "9425", "-1", 16180)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Reject_Diverter_Min_Gap_Required_User_UOM_ValidValues", "9552", "-1", 16659)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Reject_Diverter_Required_ValidValues", "9550", "-1", 16652)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM_ValidValues", "9554", "-1", 16663)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM_ValidValues", "9553", "-1", 16661)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Reject_Diverter_Type_ValidValues", "9551", "-1", 16656)
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
          Public Function Formula_User_UOM_System() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("User_UOM_System").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9392; TYPE:PF
      Result = "Imperial"
      '   END FORMULA; PROP ID:9392; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_User_UOM_System", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Acq_Label_Data_Acquisition_Method() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Acq_Label_Data_Acquisition_Method").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9533; TYPE:PF
      Result = "Real-Time Host Query"
      '   END FORMULA; PROP ID:9533; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Acq_Label_Data_Acquisition_Method", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Acq_Label_Data_Acquisition_Travel_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Acq_Label_Data_Acquisition_Travel_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9538; TYPE:PF
      Result = Units.Convert(Me.Acq_Label_Data_Acquisition_Travel_User, Me.Acq_Label_Data_Acquisition_Travel_User_UOM, "IN")
      '   END FORMULA; PROP ID:9538; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Acq_Label_Data_Acquisition_Travel_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Acq_Label_Data_Acquisition_Travel_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Acq_Label_Data_Acquisition_Travel_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9536; TYPE:PF
      Select Case Me.Acq_Label_Data_Acquisition_Method
	Case "Real-Time Host Query"
		Result = (Me.Gen_Belt_Speed_IN / 5) * Me.Acq_Max_Host_Resp_Time_Secs
	Case Else
		Result = (Me.Gen_Belt_Speed_IN / 5) * Me.Acq_Max_Local_Lookup_Time_Secs
End Select

If Me.Acq_Label_Data_Acquisition_Travel_User_UOM = "MM" Then
	Result = Units.Convert(Result, "IN", "MM")
End If
      '   END FORMULA; PROP ID:9536; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Acq_Label_Data_Acquisition_Travel_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Acq_Label_Data_Acquisition_Travel_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Acq_Label_Data_Acquisition_Travel_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9537; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9537; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Acq_Label_Data_Acquisition_Travel_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Acq_Max_Host_Resp_Time_Secs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Acq_Max_Host_Resp_Time_Secs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9534; TYPE:PF
      Select Case Me.Acq_Label_Data_Acquisition_Method
	Case "Real-Time Host Query"
		Result = 2
	Case Else
		Result = 0
End Select
      '   END FORMULA; PROP ID:9534; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Acq_Max_Host_Resp_Time_Secs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Acq_Max_Local_Lookup_Time_Secs() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Acq_Max_Local_Lookup_Time_Secs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9535; TYPE:PF
      Select Case Me.Acq_Label_Data_Acquisition_Method
	Case "Real-Time Host Query"
		Result = 0
	Case Else
		Result = 0.25
End Select
      '   END FORMULA; PROP ID:9535; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Acq_Max_Local_Lookup_Time_Secs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conv_Total_App_Belt_Length_Req_FT() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conv_Total_App_Belt_Length_Req_FT").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9588; TYPE:PF
      Result = Units.Convert(Me.Conv_Total_App_Belt_Length_Req_FT_User, Me.Conv_Total_App_Belt_Length_Req_FT_User_UOM,"FT")
      '   END FORMULA; PROP ID:9588; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Conv_Total_App_Belt_Length_Req_FT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conv_Total_App_Belt_Length_Req_FT_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conv_Total_App_Belt_Length_Req_FT_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9585; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9585; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Conv_Total_App_Belt_Length_Req_FT_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conv_Total_App_Belt_Length_Req_FT_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conv_Total_App_Belt_Length_Req_FT_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9582; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "FT" Else Result = "M"
      '   END FORMULA; PROP ID:9582; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Conv_Total_App_Belt_Length_Req_FT_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conv_Total_App_Belt_Length_Req_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conv_Total_App_Belt_Length_Req_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9587; TYPE:PF
      Result = Units.Convert(Me.Conv_Total_App_Belt_Length_Req_IN_User, Me.Conv_Total_App_Belt_Length_Req_IN_User_UOM,"IN")
      '   END FORMULA; PROP ID:9587; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Conv_Total_App_Belt_Length_Req_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conv_Total_App_Belt_Length_Req_IN_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conv_Total_App_Belt_Length_Req_IN_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9584; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9584; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Conv_Total_App_Belt_Length_Req_IN_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conv_Total_App_Belt_Length_Req_IN_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conv_Total_App_Belt_Length_Req_IN_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9581; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9581; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Conv_Total_App_Belt_Length_Req_IN_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conv_Total_Solution_Length_FT() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conv_Total_Solution_Length_FT").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9589; TYPE:PF
      Result = Units.Convert(Me.Conv_Total_Solution_Length_FT_User, Me.Conv_Total_Solution_Length_FT_User_UOM,"FT")
      '   END FORMULA; PROP ID:9589; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Conv_Total_Solution_Length_FT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conv_Total_Solution_Length_FT_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conv_Total_Solution_Length_FT_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9586; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9586; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Conv_Total_Solution_Length_FT_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Conv_Total_Solution_Length_FT_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conv_Total_Solution_Length_FT_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9583; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "FT" Else Result = "M"
      '   END FORMULA; PROP ID:9583; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Conv_Total_Solution_Length_FT_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Accumulation_Convey_Type_Pre_Panda() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Accumulation_Convey_Type_Pre_Panda").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9416; TYPE:PF
      Select Case Me.Gen_Conveyor_Type
	Case "Standard B/M Belt"
		Result = "I/Q or A/G"
	Case Else
		Result = "MDR"	
End Select
      '   END FORMULA; PROP ID:9416; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Accumulation_Convey_Type_Pre_Panda", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Accumulation_Zone_Length_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Accumulation_Zone_Length_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9409; TYPE:PF
      Result = Units.Convert(Me.Gen_Accumulation_Zone_Length_User, Me.Gen_Accumulation_Zone_Length_User_UOM,"IN")
      '   END FORMULA; PROP ID:9409; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Accumulation_Zone_Length_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Accumulation_Zone_Length_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Accumulation_Zone_Length_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9402; TYPE:PF
      Select Case Me.Gen_Accumulation_Zone_Length_User_UOM
	Case "IN"
		Result = 24
	Case Else
		Result = 624	
End Select
      '   END FORMULA; PROP ID:9402; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Accumulation_Zone_Length_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Accumulation_Zone_Length_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Accumulation_Zone_Length_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9395; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9395; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Accumulation_Zone_Length_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Accumulation_Zone_Quantity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Accumulation_Zone_Quantity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9414; TYPE:PF
      Result = 8
      '   END FORMULA; PROP ID:9414; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Accumulation_Zone_Quantity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Belt_Speed_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Belt_Speed_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9407; TYPE:PF
      Result = Units.Convert(Me.Gen_Belt_Speed_User, Me.Gen_Belt_Speed_User_UOM,"FT/MIN")
      '   END FORMULA; PROP ID:9407; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Belt_Speed_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Belt_Speed_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Belt_Speed_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9400; TYPE:PF
      Select Case Me.Gen_Belt_Speed_User_UOM
	Case "FT/MIN"
		Result = 120
	Case Else
		Result = 0.61
End Select
      '   END FORMULA; PROP ID:9400; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Belt_Speed_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Belt_Speed_User_Max_Value() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Belt_Speed_User_Max_Value").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9487; TYPE:PF
      Select Case Me.Gen_Belt_Speed_User_UOM
	Case "FT/MIN"
		Result = 180
	Case Else
		Result = 0.92
End Select
      '   END FORMULA; PROP ID:9487; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Belt_Speed_User_Max_Value", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Belt_Speed_User_Min_Value() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Belt_Speed_User_Min_Value").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9488; TYPE:PF
      Select Case Me.Gen_Belt_Speed_User_UOM
	Case "FT/MIN"
		Result = 75
	Case Else
		Result = 0.38
End Select
      '   END FORMULA; PROP ID:9488; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Belt_Speed_User_Min_Value", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Belt_Speed_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Belt_Speed_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9393; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "FT/MIN" Else Result = "M/SEC"
      '   END FORMULA; PROP ID:9393; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Belt_Speed_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_Acc_Dec_Rate_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9410; TYPE:PF
      Result = Units.Convert(Me.Gen_BM_Belt_Acc_Dec_Rate_User, Me.Gen_BM_Belt_Acc_Dec_Rate_User_UOM,"IN/SEC/SEC")
      '   END FORMULA; PROP ID:9410; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Acc_Dec_Rate_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_Acc_Dec_Rate_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9403; TYPE:PF
      Select Case Me.Gen_BM_Belt_Acc_Dec_Rate_User_UOM
	Case "IN/SEC/SEC"
		Result = 115
	Case Else
		Result = 2.92
End Select
      '   END FORMULA; PROP ID:9403; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Acc_Dec_Rate_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_User_Max_Value() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_Acc_Dec_Rate_User_Max_Value").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9489; TYPE:PF
      Select Case Me.Gen_BM_Belt_Acc_Dec_Rate_User_UOM
	Case "IN/SEC/SEC"
		Result = 115
	Case Else
		Result = 2.92
End Select
      '   END FORMULA; PROP ID:9489; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Acc_Dec_Rate_User_Max_Value", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_User_Min_Value() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_Acc_Dec_Rate_User_Min_Value").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9490; TYPE:PF
      Select Case Me.Gen_BM_Belt_Acc_Dec_Rate_User_UOM
	Case "IN/SEC/SEC"
		Result = 84
	Case Else
		Result = 2.13
End Select
      '   END FORMULA; PROP ID:9490; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Acc_Dec_Rate_User_Min_Value", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_Acc_Dec_Rate_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9396; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN/SEC/SEC" Else Result = "M/SEC/SEC"
      '   END FORMULA; PROP ID:9396; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Acc_Dec_Rate_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_Gap_Stop_Min_Carton_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9411; TYPE:PF
      Result = Units.Convert(Me.Gen_BM_Belt_Gap_Stop_Min_Carton_User, Me.Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM,"IN")
      '   END FORMULA; PROP ID:9411; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_Gap_Stop_Min_Carton_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9404; TYPE:PF
      Select Case Me.Gen_Conveyor_Type
	Case "Standard B/M Belt"
		Result = ((((Me.Gen_Belt_Speed_User / 5) / Me.Gen_BM_Belt_Acc_Dec_Rate_User) / 2) * Me.Gen_Belt_Speed_User / 5)
	Case Else
		Result = 0
End Select
      '   END FORMULA; PROP ID:9404; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9397; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9397; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_BM_Belt_Input_Speed_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_Input_Speed_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9412; TYPE:PF
      Result = Units.Convert(Me.Gen_BM_Belt_Input_Speed_User, Me.Gen_BM_Belt_Input_Speed_User_UOM,"FT/MIN")
      '   END FORMULA; PROP ID:9412; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Input_Speed_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_BM_Belt_Input_Speed_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_Input_Speed_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9405; TYPE:PF
      Select Case Me.Gen_Conveyor_Type
	Case "Standard B/M Belt"
		Result = Me.Gen_Belt_Speed_User / Me.Gen_BM_Belt_PTO_Ratio
	Case Else
		Result = 0
End Select
      '   END FORMULA; PROP ID:9405; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Input_Speed_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_BM_Belt_Input_Speed_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_Input_Speed_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9398; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "FT/MIN" Else Result = "M/SEC"
      '   END FORMULA; PROP ID:9398; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Input_Speed_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_BM_Belt_PTO_Ratio() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_PTO_Ratio").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9417; TYPE:PF
      Select Case Me.Gen_Conveyor_Type
	Case "Standard B/M Belt"
Dim BMRatio As Double = 0
Dim TargetBMRatio As Double = Me.Gen_BM_Belt_PTO_Target_Ratio

If TargetBMRatio < 1.11 Then
	BMRatio = 1.10
ElseIf TargetBMRatio < 1.16 Then
	BMRatio = 1.15
ElseIf TargetBMRatio < 1.21 Then
	BMRatio = 1.20
ElseIf TargetBMRatio < 1.26 Then
	BMRatio = 1.25
ElseIf TargetBMRatio < 1.34 Then
	BMRatio = 1.33
ElseIf TargetBMRatio < 1.41 Then
	BMRatio = 1.40
ElseIf TargetBMRatio < 1.51 Then
	BMRatio = 1.50
ElseIf TargetBMRatio < 1.61 Then
	BMRatio = 1.60
ElseIf TargetBMRatio < 1.68 Then
	BMRatio = 1.67
ElseIf TargetBMRatio < 1.76 Then
	BMRatio = 1.75
ElseIf TargetBMRatio < 1.86 Then
	BMRatio = 1.85
ElseIf TargetBMRatio < 2.01 Then
	BMRatio = 2.00
ElseIf TargetBMRatio < 2.26 Then
	BMRatio = 2.25
ElseIf TargetBMRatio < 2.51 Then
	BMRatio = 2.50
Else
	BMRatio = 3.00	
End If

Result = BMRatio

Case Else
	Result = 1
End Select
      '   END FORMULA; PROP ID:9417; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_PTO_Ratio", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_BM_Belt_PTO_Target_Ratio() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_PTO_Target_Ratio").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9477; TYPE:PF
      Select Case Me.Gen_Conveyor_Type
	Case "Standard B/M Belt"
		Result = Math.Max(((Me.MTBH_Length_Minimum_IN + Me.Gen_BM_Belt_Gap_Stop_Min_Carton_IN) / Me.MTBH_Length_Minimum_IN), 1.4)
	Case Else
		Result = 0
End Select
      '   END FORMULA; PROP ID:9477; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_PTO_Target_Ratio", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Conveyor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9415; TYPE:PF
      Result = "Standard B/M Belt"
      '   END FORMULA; PROP ID:9415; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Conveyor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Conveyor_Width_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Conveyor_Width_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9408; TYPE:PF
      Result = Units.Convert(Me.Gen_Conveyor_Width_User, Me.Gen_Conveyor_Width_User_UOM,"IN")
      '   END FORMULA; PROP ID:9408; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Conveyor_Width_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Conveyor_Width_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Conveyor_Width_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9401; TYPE:PF
      Select Case Me.Gen_Conveyor_Width_User_UOM
	Case "IN"
		Result = 28
	Case Else
		Result = 690
End Select
      '   END FORMULA; PROP ID:9401; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Conveyor_Width_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Conveyor_Width_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Conveyor_Width_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9394; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9394; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Conveyor_Width_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_MDR_Min_Gap_Throughput_Limit_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_MDR_Min_Gap_Throughput_Limit_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9413; TYPE:PF
      Result = Units.Convert(Me.Gen_MDR_Min_Gap_Throughput_Limit_User, Me.Gen_MDR_Min_Gap_Throughput_Limit_User_UOM,"IN")
      '   END FORMULA; PROP ID:9413; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_MDR_Min_Gap_Throughput_Limit_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_MDR_Min_Gap_Throughput_Limit_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_MDR_Min_Gap_Throughput_Limit_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9406; TYPE:PF
      Select Case Me.Gen_Conveyor_Type
	Case "2 - Belted MDR Zones"
		Result = Me.Gen_Accumulation_Zone_Length_User
	Case Else
		Result = 0	
End Select
      '   END FORMULA; PROP ID:9406; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_MDR_Min_Gap_Throughput_Limit_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_MDR_Min_Gap_Throughput_Limit_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_MDR_Min_Gap_Throughput_Limit_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9399; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9399; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_MDR_Min_Gap_Throughput_Limit_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Throughput_Rate() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Throughput_Rate").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9390; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9390; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Throughput_Rate", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Carton_Panels_Scanned_Quantity() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Carton_Panels_Scanned_Quantity").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9501; TYPE:PF
      result = 0
      '   END FORMULA; PROP ID:9501; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Carton_Panels_Scanned_Quantity", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Carton_Percent_Max_Length_Scanned() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Carton_Percent_Max_Length_Scanned").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9507; TYPE:PF
      Result = Ind_Scan_Carton_Percent_Max_Length_Scanned_User / 100
      '   END FORMULA; PROP ID:9507; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Carton_Percent_Max_Length_Scanned", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Carton_Percent_Max_Length_Scanned_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Carton_Percent_Max_Length_Scanned_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9508; TYPE:PF
      Result = 100
      '   END FORMULA; PROP ID:9508; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Carton_Percent_Max_Length_Scanned_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Carton_Presentation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Carton_Presentation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9503; TYPE:PF
      Result = "Edge Aligned"
      '   END FORMULA; PROP ID:9503; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Carton_Presentation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Carton_Scanned_Max_Lin_Length_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Carton_Scanned_Max_Lin_Length_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9513; TYPE:PF
      Result = Units.Convert(Me.Ind_Scan_Carton_Scanned_Max_Lin_Length_User, Me.Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM,"IN")
      '   END FORMULA; PROP ID:9513; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Carton_Scanned_Max_Lin_Length_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Carton_Scanned_Max_Lin_Length_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Carton_Scanned_Max_Lin_Length_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9517; TYPE:PF
      Select Case Me.Ind_Scan_Scanner_Data_Transmit_Mode
	Case "Trail Edge"
		Result = me.Ind_Scan_Carton_Percent_Max_Length_Scanned * Me.MTBH_Length_Maximum_User
	Case Else
		Result = Me.MTBH_Length_Maximum_User	
End Select
      '   END FORMULA; PROP ID:9517; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Carton_Scanned_Max_Lin_Length_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9522; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9522; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Label_Orientation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Label_Orientation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9502; TYPE:PF
      Select Case Me.Ind_Scan_Carton_Panels_Scanned_Quantity
	Case 0
		Result = ""
	Case Else
		Result = "Uni-Directional"
End Select
      '   END FORMULA; PROP ID:9502; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Label_Orientation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Scan_App_Min_Gap_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scan_App_Min_Gap_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9509; TYPE:PF
      Result = Units.Convert(Me.Ind_Scan_Scan_App_Min_Gap_User, Me.Ind_Scan_Scan_App_Min_Gap_User_UOM,"IN")
      '   END FORMULA; PROP ID:9509; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scan_App_Min_Gap_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Scan_App_Min_Gap_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scan_App_Min_Gap_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9510; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9510; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scan_App_Min_Gap_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Scan_App_Min_Gap_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scan_App_Min_Gap_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9519; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9519; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scan_App_Min_Gap_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Scan_Window_Length_Req_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scan_Window_Length_Req_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9511; TYPE:PF
      Result = Units.Convert(Me.Ind_Scan_Scan_Window_Length_Req_User, Me.Ind_Scan_Scan_Window_Length_Req_User_UOM,"IN")
      '   END FORMULA; PROP ID:9511; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scan_Window_Length_Req_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Scan_Window_Length_Req_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scan_Window_Length_Req_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9515; TYPE:PF
      Result = 0.0
      '   END FORMULA; PROP ID:9515; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scan_Window_Length_Req_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Scan_Window_Length_Req_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scan_Window_Length_Req_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9520; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9520; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scan_Window_Length_Req_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Scanner_Config() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scanner_Config").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9500; TYPE:PF
      Result = "Scan Config A"
      '   END FORMULA; PROP ID:9500; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scanner_Config", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Scanner_Data_Transmit_Mode() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scanner_Data_Transmit_Mode").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9506; TYPE:PF
      Result = "Lead Edge"
      '   END FORMULA; PROP ID:9506; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scanner_Data_Transmit_Mode", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Scanner_Min_Xmit_Point_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scanner_Min_Xmit_Point_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9514; TYPE:PF
      Result = Units.Convert(Me.Ind_Scan_Scanner_Min_Xmit_Point_User, Me.Ind_Scan_Scanner_Min_Xmit_Point_User_UOM,"IN")
      '   END FORMULA; PROP ID:9514; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scanner_Min_Xmit_Point_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Scanner_Min_Xmit_Point_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scanner_Min_Xmit_Point_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9518; TYPE:PF
      Select Case Me.Ind_Scan_Scanner_Data_Transmit_Mode
	Case "Trail Edge"
		Result = 4
	Case Else
		Result = Me.Ind_Scan_Carton_Scanned_Max_Lin_Length_User	
End Select
      '   END FORMULA; PROP ID:9518; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scanner_Min_Xmit_Point_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Scanner_Min_Xmit_Point_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scanner_Min_Xmit_Point_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9523; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9523; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scanner_Min_Xmit_Point_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Shadowing_Allowed() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Shadowing_Allowed").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9505; TYPE:PF
      Select Case Me.Ind_Scan_Shadowing_Potential
	Case "No"
		Result = "N/A"
	Case Else
		Result = "No"
End Select
      '   END FORMULA; PROP ID:9505; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Shadowing_Allowed", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Shadowing_Potential() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Shadowing_Potential").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9504; TYPE:PF
      Result = "No"
      '   END FORMULA; PROP ID:9504; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Shadowing_Potential", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Tracking_Photocell_Distance_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9512; TYPE:PF
      Result = Units.Convert(Me.Ind_Scan_Tracking_Photocell_Distance_User, Me.Ind_Scan_Tracking_Photocell_Distance_User_UOM,"IN")
      '   END FORMULA; PROP ID:9512; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Tracking_Photocell_Distance_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Tracking_Photocell_Distance_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9516; TYPE:PF
      Select Case Me.Ind_Scan_Tracking_Photocell_Distance_User_UOM
	Case "IN"
		Result = 2
	Case Else
		Result = 100
End Select
      '   END FORMULA; PROP ID:9516; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Tracking_Photocell_Distance_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_User_Max_Val() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Tracking_Photocell_Distance_User_Max_Val").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9530; TYPE:PF
      Result = Me.MTBH_Length_Minimum_User * (2/3)
      '   END FORMULA; PROP ID:9530; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Tracking_Photocell_Distance_User_Max_Val", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_User_Min_Val() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Tracking_Photocell_Distance_User_Min_Val").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9531; TYPE:PF
      Select Case Me.Ind_Scan_Tracking_Photocell_Distance_User_UOM
	Case "IN"
		Result = 2
	Case Else
		Result = 50.8
End Select
      '   END FORMULA; PROP ID:9531; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Tracking_Photocell_Distance_User_Min_Val", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Tracking_Photocell_Distance_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9521; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9521; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Tracking_Photocell_Distance_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MDR_RAT_Swivel_Rate() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MDR_RAT_Swivel_Rate").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9580; TYPE:PF
      Result = 35.69
      '   END FORMULA; PROP ID:9580; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MDR_RAT_Swivel_Rate", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9459; TYPE:PF
      Result = Units.Convert(Me.MTBH_Height_Average_User, Me.MTBH_Height_Average_User_UOM,"IN")
      '   END FORMULA; PROP ID:9459; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Height_Average_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9442; TYPE:PF
      Result = (Me.MTBH_Height_Minimum_User + me.MTBH_Height_Maximum_User) / 2
      '   END FORMULA; PROP ID:9442; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Height_Average_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9436; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9436; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Height_Average_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9458; TYPE:PF
      Result = Units.Convert(Me.MTBH_Height_Maximum_User, Me.MTBH_Height_Maximum_User_UOM,"IN")
      '   END FORMULA; PROP ID:9458; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Height_Maximum_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9441; TYPE:PF
      Select Case Me.MTBH_Height_Maximum_User_UOM
	Case "IN"
		Result = 10
	Case Else
		Result = 200
End Select
      '   END FORMULA; PROP ID:9441; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Height_Maximum_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9497; TYPE:PF
      Select Case Me.MTBH_Height_Maximum_User_UOM
	Case "IN"
		Result = 30
	Case Else
		Result = 762
End Select
      '   END FORMULA; PROP ID:9497; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Height_Maximum_User_Max_Value", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9435; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9435; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Height_Maximum_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9457; TYPE:PF
      Result = Units.Convert(Me.MTBH_Height_Minimum_User, Me.MTBH_Height_Minimum_User_UOM,"IN")
      '   END FORMULA; PROP ID:9457; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Height_Minimum_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9440; TYPE:PF
      Select Case Me.MTBH_Height_Minimum_User_UOM
	Case "IN"
		Result = 10
	Case Else
		Result = 200
End Select
      '   END FORMULA; PROP ID:9440; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Height_Minimum_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9496; TYPE:PF
      Select Case Me.MTBH_Length_Minimum_User_UOM
	Case "IN"
		Result = 1
	Case Else
		Result = 25.4
End Select
      '   END FORMULA; PROP ID:9496; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Height_Minimum_User_Min_Value", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9434; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9434; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Height_Minimum_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9452; TYPE:PF
      Result = Units.Convert(Me.MTBH_Length_Average_User, Me.MTBH_Length_Average_User_UOM,"IN")
      '   END FORMULA; PROP ID:9452; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Average_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9430; TYPE:PF
      Result = (Me.MTBH_Length_Maximum_User + Me.MTBH_Length_Minimum_User) / 2
      '   END FORMULA; PROP ID:9430; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Average_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9421; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9421; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Average_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9451; TYPE:PF
      Result = Units.Convert(Me.MTBH_Length_Maximum_User, Me.MTBH_Length_Maximum_User_UOM,"IN")
      '   END FORMULA; PROP ID:9451; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Maximum_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9429; TYPE:PF
      Select Case Me.MTBH_Length_Maximum_User_UOM
	Case "IN"
		Result = 10
	Case Else
		Result = 200
End Select
      '   END FORMULA; PROP ID:9429; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Maximum_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9493; TYPE:PF
      Select Case Me.MTBH_Length_Maximum_User_UOM
	Case "IN"
		Result = 60
	Case Else
		Result = 1524
End Select
      '   END FORMULA; PROP ID:9493; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Maximum_User_Max_Value", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9420; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9420; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Maximum_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9450; TYPE:PF
      Result = Units.Convert(Me.MTBH_Length_Minimum_User, Me.MTBH_Length_Minimum_User_UOM,"IN")
      '   END FORMULA; PROP ID:9450; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Minimum_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9428; TYPE:PF
      Select Case Me.MTBH_Length_Minimum_User_UOM
	Case "IN"
		Result = 10
	Case Else
		Result = 200
End Select
      '   END FORMULA; PROP ID:9428; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Minimum_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9492; TYPE:PF
      Select Case Me.MTBH_Length_Minimum_User_UOM
	Case "IN"
		Result = 4
	Case Else
		Result = 101.6
End Select
      '   END FORMULA; PROP ID:9492; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Minimum_User_Min_Value", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9419; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9419; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Minimum_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9418; TYPE:PF
      Result = "Yes"
      '   END FORMULA; PROP ID:9418; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Use_Local", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9464; TYPE:PF
      Result = Units.Convert(Me.MTBH_Weight_Average_User, Me.MTBH_Weight_Average_User_UOM,"LB")
      '   END FORMULA; PROP ID:9464; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Weight_Average_LBS", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9445; TYPE:PF
      Result = (Me.MTBH_Weight_Maximum_User + me.MTBH_Weight_Minimum_User) / 2
      '   END FORMULA; PROP ID:9445; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Weight_Average_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9448; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "LB" Else Result = "KG"
      '   END FORMULA; PROP ID:9448; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Weight_Average_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9462; TYPE:PF
      Result = Units.Convert(Me.MTBH_Weight_Maximum_User, Me.MTBH_Weight_Maximum_User_UOM,"LB")
      '   END FORMULA; PROP ID:9462; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Weight_Maximum_LBS", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9444; TYPE:PF
      Select Case Me.MTBH_Weight_Maximum_User_UOM
	Case "LB"
		Result = 10
	Case Else
		Result = 30
End Select
      '   END FORMULA; PROP ID:9444; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Weight_Maximum_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9499; TYPE:PF
      Select Case Me.MTBH_Length_Maximum_User_UOM
	Case "LB"
		Result = 120
	Case Else
		Result = 54.43
End Select
      '   END FORMULA; PROP ID:9499; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Weight_Maximum_User_Max_Value", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9447; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "LB" Else Result = "KG"
      '   END FORMULA; PROP ID:9447; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Weight_Maximum_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9461; TYPE:PF
      Result = Units.Convert(Me.MTBH_Weight_Minimum_User, Me.MTBH_Weight_Minimum_User_UOM,"LB")
      '   END FORMULA; PROP ID:9461; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Weight_Minimum_LBS", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9443; TYPE:PF
      Select Case Me.MTBH_Weight_Minimum_User_UOM
	Case "LB"
		Result = 10
	Case Else
		Result = 30
End Select
      '   END FORMULA; PROP ID:9443; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Weight_Minimum_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9498; TYPE:PF
      Select Case Me.MTBH_Weight_Minimum_User_UOM
	Case "LB"
		Result = 0.5
	Case Else
		Result = 0.23
End Select
      '   END FORMULA; PROP ID:9498; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Weight_Minimum_User_Min_Value", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9446; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "LB" Else Result = "KG"
      '   END FORMULA; PROP ID:9446; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Weight_Minimum_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9456; TYPE:PF
      Result = Units.Convert(Me.MTBH_Width_Average_User, Me.MTBH_Width_Average_User_UOM,"IN")
      '   END FORMULA; PROP ID:9456; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Width_Average_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9439; TYPE:PF
      Result = (Me.MTBH_Width_Maximum_User + Me.MTBH_Width_Minimum_User) / 2
      '   END FORMULA; PROP ID:9439; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Width_Average_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9427; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9427; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Width_Average_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9455; TYPE:PF
      Result = Units.Convert(Me.MTBH_Width_Maximum_User, Me.MTBH_Width_Maximum_User_UOM,"IN")
      '   END FORMULA; PROP ID:9455; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Width_Maximum_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9438; TYPE:PF
      Select Case Me.MTBH_Width_Maximum_User_UOM
	Case "IN"
		Result = 10
	Case Else
		Result = 200
End Select
      '   END FORMULA; PROP ID:9438; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Width_Maximum_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9495; TYPE:PF
      Select Case Me.MTBH_Width_Maximum_User_UOM
	Case "IN"
		Result = 38
	Case Else
		Result = 965.2
End Select
      '   END FORMULA; PROP ID:9495; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Width_Maximum_User_Max_Value", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9426; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9426; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Width_Maximum_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9454; TYPE:PF
      Result = Units.Convert(Me.MTBH_Width_Minimum_User, Me.MTBH_Width_Minimum_User_UOM,"IN")
      '   END FORMULA; PROP ID:9454; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Width_Minimum_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9437; TYPE:PF
      Select Case Me.MTBH_Width_Minimum_User_UOM
	Case "IN"
		Result = 10
	Case Else
		Result = 200
End Select
      '   END FORMULA; PROP ID:9437; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Width_Minimum_User", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9494; TYPE:PF
      Select Case Me.MTBH_Width_Minimum_User_UOM
	Case "IN"
		Result = 4
	Case Else
		Result = 101.6
End Select
      '   END FORMULA; PROP ID:9494; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Width_Minimum_User_Min_Value", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9425; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9425; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Width_Minimum_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Reject_Diverter_Min_Gap_Required_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Min_Gap_Required_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9567; TYPE:PF
      Result = Units.Convert(Me.Reject_Diverter_Min_Gap_Required_User, Me.Reject_Diverter_Min_Gap_Required_User_UOM,"IN")
      '   END FORMULA; PROP ID:9567; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Min_Gap_Required_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Reject_Diverter_Min_Gap_Required_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Min_Gap_Required_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9555; TYPE:PF
      Select Case Me.Reject_Diverter_Required
	Case "Yes"
		Select Case Me.Reject_Diverter_Type
			Case "WD Pop-Up Wheel"
				Result = 18
			Case "Transnorm TS4800 30deg"
				Result = Me.Transnorm_TS4800_Required_Gap_Max_Box
			Case Else
				Result = Me.Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_IN - Me.MTBH_Length_Average_IN
		End Select
	Case Else
		Result = 0
End Select

If Me.Reject_Diverter_Min_Gap_Required_User_UOM = "MM" Then
	Result = Units.Convert(Result, "IN", Me.Reject_Diverter_Min_Gap_Required_User_UOM)
End If
      '   END FORMULA; PROP ID:9555; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Min_Gap_Required_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Reject_Diverter_Min_Gap_Required_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Min_Gap_Required_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9552; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9552; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Min_Gap_Required_User_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Reject_Diverter_Required() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Required").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9550; TYPE:PF
      Result = "Yes"
      '   END FORMULA; PROP ID:9550; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Required", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9572; TYPE:PF
      Result = Units.Convert(Me.Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User, Me.Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM,"IN")
      '   END FORMULA; PROP ID:9572; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9554; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9554; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9571; TYPE:PF
      Select Case Me.Reject_Diverter_Required
	Case "Yes"
		Select Case Me.Reject_Diverter_Type
			Case "WD Pop-Up Wheel", "Transnorm TS4800 30deg"
				Result = Me.Reject_Diverter_Min_Gap_Required_IN + Me.MTBH_Length_Average_IN
			Case "MDR RAT"
				Result = 0 '''Needs MDR info
			Case Else
				Result = 0 '''Needs MDR info
		End Select
	Case Else
		Result = 0
End Select

If Me.Reject_Diverter_Min_Gap_Required_User_UOM = "MM" Then
	Result = Units.Convert(Result, "IN", "MM")
End If
      '   END FORMULA; PROP ID:9571; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9569; TYPE:PF
      Result = Units.Convert(Me.Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User, Me.Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM,"IN")
      '   END FORMULA; PROP ID:9569; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9553; TYPE:PF
      If Me.User_UOM_System = "Imperial" Then Result = "IN" Else Result = "MM"
      '   END FORMULA; PROP ID:9553; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9570; TYPE:PF
      Select Case Me.Reject_Diverter_Required
	Case "Yes"
		Select Case Me.Reject_Diverter_Type
			Case "WD Pop-Up Wheel", "Transnorm TS4800 30deg"
				Result = Me.Reject_Diverter_Min_Gap_Required_IN + Me.MTBH_Length_Maximum_IN
			Case "MDR RAT"
				Result = 0 '''Needs MDR info
			Case Else
				Result = 0 '''Needs MDR info
		End Select
	Case Else
		Result = 0
End Select

If Me.Reject_Diverter_Min_Gap_Required_User_UOM = "MM" Then
	Result = Units.Convert(Result, "IN", "MM")
End If
      '   END FORMULA; PROP ID:9570; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Reject_Diverter_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9551; TYPE:PF
      Select Case Me.Reject_Diverter_Required
	Case "Yes"
		Result = "WD Pop-Up Wheel"
	Case Else
		Result = ""
End Select
      '   END FORMULA; PROP ID:9551; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Transnorm_TS4800_Control_Reaction_Time_Distance_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Transnorm_TS4800_Control_Reaction_Time_Distance_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9576; TYPE:PF
      Result = ((Me.Gen_Belt_Speed_IN * 12) / 60) * (0.025 * 2)
      '   END FORMULA; PROP ID:9576; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Transnorm_TS4800_Control_Reaction_Time_Distance_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Transnorm_TS4800_Divert_Angle() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Transnorm_TS4800_Divert_Angle").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9574; TYPE:PF
      Result = 30
      '   END FORMULA; PROP ID:9574; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Transnorm_TS4800_Divert_Angle", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Transnorm_TS4800_Divert_Shifting_Distance_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Transnorm_TS4800_Divert_Shifting_Distance_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9575; TYPE:PF
      Result = ((Me.Gen_Belt_Speed_IN * 12) / 60) * 0.15
      '   END FORMULA; PROP ID:9575; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Transnorm_TS4800_Divert_Shifting_Distance_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Transnorm_TS4800_Encoder_Resolution_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Transnorm_TS4800_Encoder_Resolution_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9577; TYPE:PF
      Result = 1.5
      '   END FORMULA; PROP ID:9577; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Transnorm_TS4800_Encoder_Resolution_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Transnorm_TS4800_Required_Gap_Max_Box() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Transnorm_TS4800_Required_Gap_Max_Box").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9578; TYPE:PF
      Result = Me.Transnorm_TS4800_Divert_Shifting_Distance_IN _
	+ Me.Transnorm_TS4800_Control_Reaction_Time_Distance_IN _
	+ me.Transnorm_TS4800_Encoder_Resolution_IN
      '   END FORMULA; PROP ID:9578; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Transnorm_TS4800_Required_Gap_Max_Box", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Accumulation_Zone_Quantity_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:9414; TYPE:TT
              Result = "The minimun allowable number of pre-PandA accumulation zones is 8.  Maximum number of zones for this calculation is 20 as there is no additional benefit from a PandA perspective for more than this."
              '   END FORMULA; PROP ID:9414; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Accumulation_Zone_Quantity_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Belt_Speed_User_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:9400; TYPE:TT
              Select Case Me.Gen_Belt_Speed_User_UOM
	Case "FT/MIN"
		Result = "Allowable speed range is 75 to 180 FPM"
	Case Else
		Result = "Allowable speed range is 0.38 to 0.92 MPS"
End Select
              '   END FORMULA; PROP ID:9400; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Belt_Speed_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_User_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:9403; TYPE:TT
              Select Case Me.Gen_BM_Belt_Acc_Dec_Rate_User_UOM
	Case "IN/SEC/SEC"
		Result = "This is the Accel/Decel rate of the PandA Brake/Meter belt using for spacing cartons.  The value is in 'Inches per second per second'.  The allowable range is currently restricted to 84 to 115 inches/sec/sec. (0.21g to 0.3g)"
	Case Else
		Result = "This is the Accel/Decel rate of the PandA Brake/Meter belt using for spacing cartons.  The value is in 'Inches per second per second'.  The allowable range is currently restricted to 2.13 to 2.92 meters/sec/sec. (0.21g to 0.3g)"
End Select
              '   END FORMULA; PROP ID:9403; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Acc_Dec_Rate_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
          End Function
        
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gen_Throughput_Rate_TOOLTIP() as String
          
          Dim Result as String = String.Empty
          Dim ctx as Object
          Try
          ctx = this
          'formula
          
              '   BEGIN FORMULA; PROP ID:9390; TYPE:TT
              Result = "This selection is optional.  Allowable input is 0 to 60 CPM."
              '   END FORMULA; PROP ID:9390; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Throughput_Rate_TOOLTIP", ex.Message)
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
          
              '   BEGIN FORMULA; PROP ID:9428; TYPE:TT
              Select Case Me.MTBH_Length_Minimum_User_UOM
	Case "IN"
		Result = "Allowable input range is 4 to 48 inches.  Minimum lengths less than 6 inches must be conveyed on belt or suitable sorters only.  Minimum lengths less than 9 inches require roller conveyors with 2 inch roller centers."
	Case Else
		Result = "Allowable input range is 101.6 to 1219.2 mm.  Minimum lengths less than 152.4 mm must be conveyed on belt or suitable sorters only.  Minimum lengths less than 228.6 mm require roller conveyors with 50.8 mm roller centers."
End Select
              '   END FORMULA; PROP ID:9428; TYPE:TT
            
          Catch ex As Exception
          ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Minimum_User_TOOLTIP", ex.Message)
          If ObjectManager.StopOnErrors Then Stop
          End Try
          Return Result
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
      Public Function Formula_Acq_Label_Data_Acquisition_Method_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Label_Data_Acquisition_Travel_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Label_Data_Acquisition_Travel_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Label_Data_Acquisition_Travel_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Max_Host_Resp_Time_Secs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Max_Local_Lookup_Time_Secs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_App_Belt_Length_Req_FT_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_App_Belt_Length_Req_FT_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_App_Belt_Length_Req_FT_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_App_Belt_Length_Req_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_App_Belt_Length_Req_IN_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_App_Belt_Length_Req_IN_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_Solution_Length_FT_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_Solution_Length_FT_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_Solution_Length_FT_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Accumulation_Convey_Type_Pre_Panda_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Accumulation_Zone_Length_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Accumulation_Zone_Length_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Accumulation_Zone_Length_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Accumulation_Zone_Quantity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Belt_Speed_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Belt_Speed_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Belt_Speed_User_Max_Value_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Belt_Speed_User_Min_Value_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Belt_Speed_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_User_Max_Value_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_User_Min_Value_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Input_Speed_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Input_Speed_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Input_Speed_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_PTO_Ratio_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_PTO_Target_Ratio_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Conveyor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Conveyor_Width_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Conveyor_Width_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Conveyor_Width_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_MDR_Min_Gap_Throughput_Limit_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_MDR_Min_Gap_Throughput_Limit_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_MDR_Min_Gap_Throughput_Limit_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Throughput_Rate_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Panels_Scanned_Quantity_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Percent_Max_Length_Scanned_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Percent_Max_Length_Scanned_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Presentation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Scanned_Max_Lin_Length_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Scanned_Max_Lin_Length_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Label_Orientation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scan_App_Min_Gap_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scan_App_Min_Gap_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scan_App_Min_Gap_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scan_Window_Length_Req_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scan_Window_Length_Req_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scan_Window_Length_Req_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scanner_Config_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scanner_Data_Transmit_Mode_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scanner_Min_Xmit_Point_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scanner_Min_Xmit_Point_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scanner_Min_Xmit_Point_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Shadowing_Allowed_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Shadowing_Potential_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_User_Max_Val_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_User_Min_Val_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_RAT_Swivel_Rate_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Reject_Diverter_Min_Gap_Required_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Min_Gap_Required_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Min_Gap_Required_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Required_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Transnorm_TS4800_Control_Reaction_Time_Distance_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Transnorm_TS4800_Divert_Angle_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Transnorm_TS4800_Divert_Shifting_Distance_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Transnorm_TS4800_Encoder_Resolution_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Transnorm_TS4800_Required_Gap_Max_Box_HIDE_CALCULATED_VALUE() as Boolean
      Return False
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
      Public Function Formula_Acq_Label_Data_Acquisition_Method_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Label_Data_Acquisition_Travel_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Label_Data_Acquisition_Travel_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Label_Data_Acquisition_Travel_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Max_Host_Resp_Time_Secs_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Acq_Max_Host_Resp_Time_Secs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9534; TYPE:UC
              Select Case Me.Acq_Label_Data_Acquisition_Method
	Case "Real-Time Host Query"
		Result = True
	Case Else
		Result = False
End Select
              '   END FORMULA; PROP ID:9534; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Acq_Max_Host_Resp_Time_Secs_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Max_Local_Lookup_Time_Secs_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Acq_Max_Local_Lookup_Time_Secs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9535; TYPE:UC
              Select Case Me.Acq_Label_Data_Acquisition_Method
	Case "Real-Time Host Query"
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:9535; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Acq_Max_Local_Lookup_Time_Secs_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_App_Belt_Length_Req_FT_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_App_Belt_Length_Req_FT_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_App_Belt_Length_Req_FT_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_App_Belt_Length_Req_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_App_Belt_Length_Req_IN_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_App_Belt_Length_Req_IN_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_Solution_Length_FT_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_Solution_Length_FT_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_Solution_Length_FT_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Accumulation_Convey_Type_Pre_Panda_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Accumulation_Zone_Length_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Accumulation_Zone_Length_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Accumulation_Zone_Length_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Accumulation_Zone_Quantity_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Belt_Speed_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Belt_Speed_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Belt_Speed_User_Max_Value_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Belt_Speed_User_Min_Value_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Belt_Speed_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_User_Max_Value_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_User_Min_Value_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Gen_BM_Belt_Gap_Stop_Min_Carton_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9404; TYPE:UC
              Select Case Me.Gen_Conveyor_Type
	Case "Standard B/M Belt"
		Result = True
	Case Else
		Result = False
End Select
              '   END FORMULA; PROP ID:9404; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Input_Speed_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Input_Speed_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Gen_BM_Belt_Input_Speed_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9405; TYPE:UC
              Select Case Me.Gen_Conveyor_Type
	Case "Standard B/M Belt"
		Result = True
	Case Else
		Result = False
End Select
              '   END FORMULA; PROP ID:9405; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Input_Speed_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Input_Speed_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_PTO_Ratio_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_PTO_Target_Ratio_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Conveyor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Conveyor_Width_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Conveyor_Width_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Conveyor_Width_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_MDR_Min_Gap_Throughput_Limit_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_MDR_Min_Gap_Throughput_Limit_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Gen_MDR_Min_Gap_Throughput_Limit_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9406; TYPE:UC
              Select Case Me.Gen_Conveyor_Type
	Case "2 - Belted MDR Zones"
		Result = True
	Case Else
		Result = False
End Select
              '   END FORMULA; PROP ID:9406; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_MDR_Min_Gap_Throughput_Limit_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_MDR_Min_Gap_Throughput_Limit_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Throughput_Rate_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Panels_Scanned_Quantity_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Percent_Max_Length_Scanned_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Percent_Max_Length_Scanned_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Presentation_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Scanned_Max_Lin_Length_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Scanned_Max_Lin_Length_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Label_Orientation_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Ind_Scan_Label_Orientation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9502; TYPE:UC
              Select Case Me.Ind_Scan_Carton_Panels_Scanned_Quantity
	Case 0
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:9502; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Label_Orientation_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scan_App_Min_Gap_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scan_App_Min_Gap_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scan_App_Min_Gap_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scan_Window_Length_Req_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scan_Window_Length_Req_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scan_Window_Length_Req_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scanner_Config_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scanner_Data_Transmit_Mode_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scanner_Min_Xmit_Point_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scanner_Min_Xmit_Point_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scanner_Min_Xmit_Point_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Shadowing_Allowed_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Ind_Scan_Shadowing_Allowed").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9505; TYPE:UC
              Select Case Me.Ind_Scan_Shadowing_Potential
	Case "No"
		Result = False
	Case Else
		Result = True
End Select
              '   END FORMULA; PROP ID:9505; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Shadowing_Allowed_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Shadowing_Potential_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_User_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_User_Max_Val_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_User_Min_Val_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_RAT_Swivel_Rate_USERCHANGE() as Boolean
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
      Return True
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
      Return True
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
      Return True
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
      Return True
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
      Return True
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
      Return True
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
      Return False
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
      Return True
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
      Return True
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
      Return True
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
      Return True
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
      Return True
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
      Return True
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
      Public Function Formula_Reject_Diverter_Min_Gap_Required_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Min_Gap_Required_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Reject_Diverter_Min_Gap_Required_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9555; TYPE:UC
              Select Case Me.Reject_Diverter_Required
	Case "Yes"
		Result = True
	Case Else
		Result = False
End Select
              '   END FORMULA; PROP ID:9555; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Min_Gap_Required_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Min_Gap_Required_User_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Required_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9571; TYPE:UC
              Select Case Me.Reject_Diverter_Required
	Case "Yes"
		Result = True
	Case Else
		Result = False
End Select
              '   END FORMULA; PROP ID:9571; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9570; TYPE:UC
              Select Case Me.Reject_Diverter_Required
	Case "Yes"
		Result = True
	Case Else
		Result = False
End Select
              '   END FORMULA; PROP ID:9570; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_User_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Type_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Reject_Diverter_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:9551; TYPE:UC
              Select Case Me.Reject_Diverter_Required
	Case "Yes"
		Result = True
	Case Else
		Result = False
End Select
              '   END FORMULA; PROP ID:9551; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Type_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Transnorm_TS4800_Control_Reaction_Time_Distance_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Transnorm_TS4800_Divert_Angle_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Transnorm_TS4800_Divert_Shifting_Distance_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Transnorm_TS4800_Encoder_Resolution_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Transnorm_TS4800_Required_Gap_Max_Box_USERCHANGE() as Boolean
      Return False
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
      '   BEGIN FORMULA; PROP ID:9392; TYPE:VV
      Result = MakeValidValues(Array("Imperial", "Metric"))
      '   END FORMULA; PROP ID:9392; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_User_UOM_System_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Label_Data_Acquisition_Method_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Acq_Label_Data_Acquisition_Method").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9533; TYPE:VV
      Result = MakeValidValues(Array("Real-Time Host Query", "Local Lookup"))
      '   END FORMULA; PROP ID:9533; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Acq_Label_Data_Acquisition_Method_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Acq_Label_Data_Acquisition_Travel_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Acq_Label_Data_Acquisition_Travel_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9537; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9537; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Acq_Label_Data_Acquisition_Travel_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_App_Belt_Length_Req_FT_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conv_Total_App_Belt_Length_Req_FT_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9582; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9582; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Conv_Total_App_Belt_Length_Req_FT_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_App_Belt_Length_Req_IN_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conv_Total_App_Belt_Length_Req_IN_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9581; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9581; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Conv_Total_App_Belt_Length_Req_IN_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conv_Total_Solution_Length_FT_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Conv_Total_Solution_Length_FT_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9583; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9583; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Conv_Total_Solution_Length_FT_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Accumulation_Zone_Length_User_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Accumulation_Zone_Length_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9402; TYPE:VV
      Select Case Me.Gen_Accumulation_Zone_Length_User_UOM
	Case "IN"
		Result = MakeValidValues(Array(24, 30, 36, 48))
	Case Else
		Result = MakeValidValues(Array(624, 780, 936))
End Select
      '   END FORMULA; PROP ID:9402; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Accumulation_Zone_Length_User_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Accumulation_Zone_Length_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Accumulation_Zone_Length_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9395; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9395; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Accumulation_Zone_Length_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Belt_Speed_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Belt_Speed_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9393; TYPE:VV
      Result = MakeValidValues(Array("FT/MIN", "M/SEC"))
      '   END FORMULA; PROP ID:9393; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Belt_Speed_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Acc_Dec_Rate_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_Acc_Dec_Rate_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9396; TYPE:VV
      Result = MakeValidValues(Array("IN/SEC/SEC", "M/SEC/SEC"))
      '   END FORMULA; PROP ID:9396; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Acc_Dec_Rate_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9397; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9397; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Gap_Stop_Min_Carton_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_BM_Belt_Input_Speed_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_BM_Belt_Input_Speed_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9398; TYPE:VV
      Result = MakeValidValues(Array("FT/MIN", "M/SEC"))
      '   END FORMULA; PROP ID:9398; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_BM_Belt_Input_Speed_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Conveyor_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Conveyor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9415; TYPE:VV
      Result = MakeValidValues(Array("Standard B/M Belt", "2 - Belted MDR Zones"))
      '   END FORMULA; PROP ID:9415; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Conveyor_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Conveyor_Width_User_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Conveyor_Width_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9401; TYPE:VV
      Select Case Me.Gen_Conveyor_Width_User_UOM
	Case "IN"
		Result = MakeValidValues(Array(16, 22, 28, 34))
	Case Else
		Result = MakeValidValues(Array(440, 540, 690, 840, 990))
End Select
      '   END FORMULA; PROP ID:9401; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Conveyor_Width_User_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_Conveyor_Width_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_Conveyor_Width_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9394; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9394; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_Conveyor_Width_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gen_MDR_Min_Gap_Throughput_Limit_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gen_MDR_Min_Gap_Throughput_Limit_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9399; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9399; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Gen_MDR_Min_Gap_Throughput_Limit_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Presentation_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Carton_Presentation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9503; TYPE:VV
      Result = MakeValidValues(Array("Edge Aligned", "Random"))
      '   END FORMULA; PROP ID:9503; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Carton_Presentation_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9522; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9522; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Carton_Scanned_Max_Lin_Length_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Label_Orientation_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Label_Orientation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9502; TYPE:VV
      Select Case Me.Ind_Scan_Carton_Panels_Scanned_Quantity
	Case 0
		Result = MakeValidValues(Array(""))
	Case Else
		Result = MakeValidValues(Array("Uni-Directional", "Omni-Directional"))
End Select
      '   END FORMULA; PROP ID:9502; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Label_Orientation_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scan_App_Min_Gap_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scan_App_Min_Gap_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9519; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9519; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scan_App_Min_Gap_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scan_Window_Length_Req_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scan_Window_Length_Req_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9520; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9520; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scan_Window_Length_Req_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scanner_Config_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scanner_Config").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9500; TYPE:VV
      Result = MakeValidValues(Array("Scan Config A", "Scan Config B", "Scan Config C", "Scan Config D"))
      '   END FORMULA; PROP ID:9500; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scanner_Config_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scanner_Data_Transmit_Mode_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scanner_Data_Transmit_Mode").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9506; TYPE:VV
      Result = MakeValidValues(Array("Lead Edge", "Trail Edge"))
      '   END FORMULA; PROP ID:9506; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scanner_Data_Transmit_Mode_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Scanner_Min_Xmit_Point_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Scanner_Min_Xmit_Point_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9523; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9523; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Scanner_Min_Xmit_Point_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Shadowing_Allowed_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Shadowing_Allowed").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9505; TYPE:VV
      Select Case Me.Ind_Scan_Shadowing_Potential
	Case "No"
		Result = MakeValidValues(Array("N/A"))
	Case Else
		Result = MakeValidValues(Array("No", "Partial", "Full"))
End Select
      '   END FORMULA; PROP ID:9505; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Shadowing_Allowed_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Shadowing_Potential_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Shadowing_Potential").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9504; TYPE:VV
      Result = MakeValidValues(Array("Yes", "No"))
      '   END FORMULA; PROP ID:9504; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Shadowing_Potential_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Ind_Scan_Tracking_Photocell_Distance_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Ind_Scan_Tracking_Photocell_Distance_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9521; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9521; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Ind_Scan_Tracking_Photocell_Distance_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9436; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9436; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Height_Average_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9435; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9435; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Height_Maximum_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9434; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9434; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Height_Minimum_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9421; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9421; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Average_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9420; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9420; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Maximum_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9419; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9419; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Length_Minimum_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9418; TYPE:VV
      Result = MakeValidValues(Array("Yes", "No"))
      '   END FORMULA; PROP ID:9418; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Use_Local_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9448; TYPE:VV
      Result = MakeValidValues(Array("LB", "KG"))
      '   END FORMULA; PROP ID:9448; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Weight_Average_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9447; TYPE:VV
      Result = MakeValidValues(Array("LB", "KG"))
      '   END FORMULA; PROP ID:9447; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Weight_Maximum_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9446; TYPE:VV
      Result = MakeValidValues(Array("LB", "KG"))
      '   END FORMULA; PROP ID:9446; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Weight_Minimum_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9427; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9427; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Width_Average_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9426; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9426; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Width_Maximum_User_UOM_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9425; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9425; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_MTBH_Width_Minimum_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Min_Gap_Required_User_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Min_Gap_Required_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9552; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9552; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Min_Gap_Required_User_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Required_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Required").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9550; TYPE:VV
      Result = MakeValidValues(Array("Yes", "No"))
      '   END FORMULA; PROP ID:9550; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Required_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9554; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9554; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Spacing_Cont_Flow_Avg_Carton_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9553; TYPE:VV
      Result = MakeValidValues(Array("IN", "MM"))
      '   END FORMULA; PROP ID:9553; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Spacing_Cont_Flow_Max_Carton_UOM_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Reject_Diverter_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Reject_Diverter_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9551; TYPE:VV
      Select Case Me.Reject_Diverter_Required
	Case "Yes"
		Result = MakeValidValues(Array("MDR RAT", "MDR Swivel", "WD Pop-Up Wheel", "Transnorm TS4800 30deg"))
	Case Else
		Result = MakeValidValues(Array(""))
End Select
      '   END FORMULA; PROP ID:9551; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_App_Calc_Print_And_Apply.Formula_Reject_Diverter_Type_ValidValues", ex.Message)
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

  