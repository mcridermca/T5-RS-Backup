Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_EHS350_Data
'$ GenerateDate: 07/15/2025 13:30:18

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

    Public Class [CAE_EHS350_Data]
    
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

    Private this as CAE_EHS350_Data = me

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
    
          Public Property [EHS350_Tamp_Data_Ad]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Ad").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Ad").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Ar]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Ar").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Ar").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Au]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Au").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Au").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Avg_Height_Stroke_Prepos_Mv_Time]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Avg_Height_Stroke_Prepos_Mv_Time").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Avg_Height_Stroke_Prepos_Mv_Time").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Dd]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Dd").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Dd").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Dr]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Dr").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Dr").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Du]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Du").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Du").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Full_Stroke_Preposition_Move_Time]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Full_Stroke_Preposition_Move_Time").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Full_Stroke_Preposition_Move_Time").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Full_Stroke_Run_Home_Time]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Full_Stroke_Run_Home_Time").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Full_Stroke_Run_Home_Time").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Home_variable]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Home_variable").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Home_variable").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Prepos_variable]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Prepos_variable").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Prepos_variable").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Preposition_A_D_Time_Constant]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Preposition_A_D_Time_Constant").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Preposition_A_D_Time_Constant").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Print_Time]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Print_Time").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Print_Time").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Reg_Move_Time]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Reg_Move_Time").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Reg_Move_Time").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Run_Home_A_D_Time_Constant]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Run_Home_A_D_Time_Constant").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Run_Home_A_D_Time_Constant").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Static_Blast_Wait_Time]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Static_Blast_Wait_Time").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Static_Blast_Wait_Time").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Vf]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Vf").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Vf").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Vr]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Vr").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Vr").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Xpp]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Xpp").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Xpp").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EHS350_Tamp_Data_Xreg]() As Double
      Get
      Return Properties("EHS350_Tamp_Data_Xreg").Value
      End Get
      Set(ByVal Value As Double)
      Properties("EHS350_Tamp_Data_Xreg").CalculatedValue = Value
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
    
          Public Property [MTBH_Height_Minimum_IN]() As Double
      Get
      Return Properties("MTBH_Height_Minimum_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MTBH_Height_Minimum_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [App_Label_Print_Speed_IN]() As Double
      Get
      Return Properties("App_Label_Print_Speed_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("App_Label_Print_Speed_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [App_Label_Printed_Length_IN]() As Double
      Get
      Return Properties("App_Label_Printed_Length_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("App_Label_Printed_Length_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [App_Tamp_Home_Height_Above_Conveyor_IN]() As Double
      Get
      Return Properties("App_Tamp_Home_Height_Above_Conveyor_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("App_Tamp_Home_Height_Above_Conveyor_IN").CalculatedValue = Value
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
    
      Public ReadOnly Property [My_Print_And_Apply]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Print_And_Apply")
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
    InitPart("CAE_EHS350_Data", <a><![CDATA[CAE_EHS350_Data]]></a>.Value, 419, "IGSEST",  "N", "N", False, False, "In Development", "", "", "", "", "",  "GLOBAL\H602502", "07/15/2025 12:03:03")
    AddProperty("10099", "EHS350_Tamp_Data_Ad", <a><![CDATA[EHS350_Tamp_Data_Ad]]></a>.Value, "AppCalc^'EHS350 Data'!M9", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:47 PM")
    AddProperty("10100", "EHS350_Tamp_Data_Ar", <a><![CDATA[EHS350_Tamp_Data_Ar]]></a>.Value, "AppCalc^'EHS350 Data'!M11", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:47 PM")
    AddProperty("10101", "EHS350_Tamp_Data_Au", <a><![CDATA[EHS350_Tamp_Data_Au]]></a>.Value, "AppCalc^'EHS350 Data'!M10", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:47 PM")
    AddProperty("10102", "EHS350_Tamp_Data_Avg_Height_Stroke_Prepos_Mv_Time", <a><![CDATA[EHS350_Tamp_Data_Avg_Height_Stroke_Prepos_Mv_Time]]></a>.Value, "AppCalc^'EHS350 Data'!M32", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 5:21:45 PM")
    AddProperty("10103", "EHS350_Tamp_Data_Dd", <a><![CDATA[EHS350_Tamp_Data_Dd]]></a>.Value, "AppCalc^'EHS350 Data'!M12", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:47 PM")
    AddProperty("10104", "EHS350_Tamp_Data_Dr", <a><![CDATA[EHS350_Tamp_Data_Dr]]></a>.Value, "AppCalc^'EHS350 Data'!M14", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:47 PM")
    AddProperty("10105", "EHS350_Tamp_Data_Du", <a><![CDATA[EHS350_Tamp_Data_Du]]></a>.Value, "AppCalc^'EHS350 Data'!M13", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:47 PM")
    AddProperty("10106", "EHS350_Tamp_Data_Full_Stroke_Preposition_Move_Time", <a><![CDATA[EHS350_Tamp_Data_Full_Stroke_Preposition_Move_Time]]></a>.Value, "AppCalc^'EHS350 Data'!M22", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:47 PM")
    AddProperty("10107", "EHS350_Tamp_Data_Full_Stroke_Run_Home_Time", <a><![CDATA[EHS350_Tamp_Data_Full_Stroke_Run_Home_Time]]></a>.Value, "AppCalc^'EHS350 Data'!M24", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 5:23:24 PM")
    AddProperty("10108", "EHS350_Tamp_Data_Home_variable", <a><![CDATA[EHS350_Tamp_Data_Home_variable]]></a>.Value, "AppCalc^'EHS350 Data'!M29", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:47 PM")
    AddProperty("10109", "EHS350_Tamp_Data_Prepos_variable", <a><![CDATA[EHS350_Tamp_Data_Prepos_variable]]></a>.Value, "AppCalc^'EHS350 Data'!M28", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 5:02:16 PM")
    AddProperty("10110", "EHS350_Tamp_Data_Preposition_A_D_Time_Constant", <a><![CDATA[EHS350_Tamp_Data_Preposition_A_D_Time_Constant]]></a>.Value, "AppCalc^'EHS350 Data'!M25", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:47 PM")
    AddProperty("10111", "EHS350_Tamp_Data_Print_Time", <a><![CDATA[EHS350_Tamp_Data_Print_Time]]></a>.Value, "AppCalc^'EHS350 Data'!M21", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:47 PM")
    AddProperty("10112", "EHS350_Tamp_Data_Reg_Move_Time", <a><![CDATA[EHS350_Tamp_Data_Reg_Move_Time]]></a>.Value, "AppCalc^'EHS350 Data'!M23", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 5:13:59 PM")
    AddProperty("10113", "EHS350_Tamp_Data_Run_Home_A_D_Time_Constant", <a><![CDATA[EHS350_Tamp_Data_Run_Home_A_D_Time_Constant]]></a>.Value, "AppCalc^'EHS350 Data'!M26", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:47 PM")
    AddProperty("10114", "EHS350_Tamp_Data_Static_Blast_Wait_Time", <a><![CDATA[EHS350_Tamp_Data_Static_Blast_Wait_Time]]></a>.Value, "AppCalc^'EHS350 Data'!M17", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:47 PM")
    AddProperty("10115", "EHS350_Tamp_Data_Vf", <a><![CDATA[EHS350_Tamp_Data_Vf]]></a>.Value, "AppCalc^'EHS350 Data'!M7", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:47 PM")
    AddProperty("10116", "EHS350_Tamp_Data_Vr", <a><![CDATA[EHS350_Tamp_Data_Vr]]></a>.Value, "AppCalc^'EHS350 Data'!M8", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:47 PM")
    AddProperty("10117", "EHS350_Tamp_Data_Xpp", <a><![CDATA[EHS350_Tamp_Data_Xpp]]></a>.Value, "AppCalc^'EHS350 Data'!M15", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:48 PM")
    AddProperty("10118", "EHS350_Tamp_Data_Xreg", <a><![CDATA[EHS350_Tamp_Data_Xreg]]></a>.Value, "AppCalc^'EHS350 Data'!M16", "Double","","AppCalc_PandA","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:20:48 PM")
    AddProperty("10119", "MTBH_Height_Average_IN", <a><![CDATA[MTBH_Height_Average_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:22:01 PM")
    AddProperty("10120", "MTBH_Height_Minimum_IN", <a><![CDATA[MTBH_Height_Minimum_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_MTBH","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:22:19 PM")
    AddProperty("10121", "App_Label_Print_Speed_IN", <a><![CDATA[App_Label_Print_Speed_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_Printer_Applicator","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:26:24 PM")
    AddProperty("10122", "App_Label_Printed_Length_IN", <a><![CDATA[App_Label_Printed_Length_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_Printer_Applicator","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:26:36 PM")
    AddProperty("10098", "App_Tamp_Home_Height_Above_Conveyor_IN", <a><![CDATA[App_Tamp_Home_Height_Above_Conveyor_IN]]></a>.Value, "Property unit conversion", "Double","","AppCalc_PandA_Printer_Applicator","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:22:33 PM")
    AddProperty("10097", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/14/2025 4:18:56 PM")
    
      oConnection = AddConnection("My_Print_And_Apply", <a><![CDATA[My_Print_And_Apply]]></a>.Value, "", "166", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/15/2025 12:03:03 PM")
      
        oConnection.AddVPF(416, "CAE_App_Calc_Print_And_Apply")
      
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
          InitProperty("EHS350_Tamp_Data_Ad", "9680", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17067)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Ar", "9681", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17068)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Au", "9682", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17069)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Avg_Height_Stroke_Prepos_Mv_Time", "9683", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 5:21:45 PM", "", "In Development",  0,17109)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Dd", "9684", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17071)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Dr", "9685", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17072)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Du", "9686", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17073)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Full_Stroke_Preposition_Move_Time", "9687", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17074)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Full_Stroke_Run_Home_Time", "9688", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 5:23:24 PM", "", "In Development",  0,17110)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Home_variable", "9689", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17076)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Prepos_variable", "9690", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 5:02:16 PM", "", "In Development",  0,17104)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Preposition_A_D_Time_Constant", "9691", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17078)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Print_Time", "9692", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17079)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Reg_Move_Time", "9693", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 5:13:59 PM", "", "In Development",  0,17107)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Run_Home_A_D_Time_Constant", "9694", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17081)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Static_Blast_Wait_Time", "9695", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17082)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Vf", "9696", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17083)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Vr", "9697", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17084)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Xpp", "9698", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17085)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EHS350_Tamp_Data_Xreg", "9699", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:20:48 PM", "", "In Development",  0,17086)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Average_IN", "9700", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:22:01 PM", "", "In Development",  0,17089)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MTBH_Height_Minimum_IN", "9701", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:22:19 PM", "", "In Development",  0,17090)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("App_Label_Print_Speed_IN", "9702", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:26:24 PM", "", "In Development",  0,17094)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("App_Label_Printed_Length_IN", "9703", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:26:36 PM", "", "In Development",  0,17095)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("App_Tamp_Home_Height_Above_Conveyor_IN", "9679", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/14/2025 4:22:33 PM", "", "In Development",  0,17091)
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
          
        InitConnection("My_Print_And_Apply", "146", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/15/2025 12:03:03 PM", "", "In Development", "N",292)
        
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
      Public Function Formula_My_Print_And_Apply_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:146; TYPE:PF
        Result = Me.Parent.Print_And_Apply(Me.subpartid)
        '   END FORMULA; CON ID:146; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_My_Print_And_Apply_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Ad() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Ad").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9680; TYPE:PF
      Result = 1500
      '   END FORMULA; PROP ID:9680; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Ad", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Ar() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Ar").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9681; TYPE:PF
      Result = 100
      '   END FORMULA; PROP ID:9681; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Ar", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Au() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Au").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9682; TYPE:PF
      Result = 1250
      '   END FORMULA; PROP ID:9682; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Au", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Avg_Height_Stroke_Prepos_Mv_Time() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Avg_Height_Stroke_Prepos_Mv_Time").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9683; TYPE:PF
      Dim Vf = Me.EHS350_Tamp_Data_Vf
Dim Ad = Me.EHS350_Tamp_Data_Ad
Dim Dd = Me.EHS350_Tamp_Data_Dd
Dim Home_Height_in = Me.App_Tamp_Home_Height_Above_Conveyor_IN
Dim Xpp = Me.EHS350_Tamp_Data_Xpp
Dim PandAAvgBoxHeight = me.MTBH_Height_Average_IN

Result = Vf/Ad+Vf/Dd+(((Home_Height_in-(Xpp+PandAAvgBoxHeight))-(Vf^2/(2*Ad)+Vf^2/(2*Dd)))/Vf)
      '   END FORMULA; PROP ID:9683; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Avg_Height_Stroke_Prepos_Mv_Time", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Dd() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Dd").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9684; TYPE:PF
      Result = 1500
      '   END FORMULA; PROP ID:9684; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Dd", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Dr() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Dr").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9685; TYPE:PF
      Result = 3000
      '   END FORMULA; PROP ID:9685; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Dr", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Du() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Du").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9686; TYPE:PF
      Result = 1000
      '   END FORMULA; PROP ID:9686; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Du", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Full_Stroke_Preposition_Move_Time() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Full_Stroke_Preposition_Move_Time").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9687; TYPE:PF
      Result = (Me.EHS350_Tamp_Data_Vf / Me.EHS350_Tamp_Data_Ad) + (Me.EHS350_Tamp_Data_Vf / Me.EHS350_Tamp_Data_Dd) + (((Me.App_Tamp_Home_Height_Above_Conveyor_IN - Me.EHS350_Tamp_Data_Xpp) - ((Me.EHS350_Tamp_Data_Vf * Me.EHS350_Tamp_Data_Vf) / ( 2 * Me.EHS350_Tamp_Data_Ad) + ((Me.EHS350_Tamp_Data_Vf * Me.EHS350_Tamp_Data_Vf) / (2 * Me.EHS350_Tamp_Data_Dd))))) / Me.EHS350_Tamp_Data_Vf
      '   END FORMULA; PROP ID:9687; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Full_Stroke_Preposition_Move_Time", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Full_Stroke_Run_Home_Time() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Full_Stroke_Run_Home_Time").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9688; TYPE:PF
      Dim Vf = Me.EHS350_Tamp_Data_Vf
Dim Au = Me.EHS350_Tamp_Data_Au
Dim Du = Me.EHS350_Tamp_Data_Du
Dim Home_Height_in = Me.App_Tamp_Home_Height_Above_Conveyor_IN
Dim Xpp = Me.EHS350_Tamp_Data_Xpp
Dim Xreg = Me.EHS350_Tamp_Data_Xreg

Result = Vf/Au+Vf/Du+(((Home_Height_in-Xpp+Xreg)-(Vf^2/(2*Au)+Vf^2/(2*Du)))/Vf)
      '   END FORMULA; PROP ID:9688; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Full_Stroke_Run_Home_Time", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Home_variable() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Home_variable").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9689; TYPE:PF
      Result = (Me.App_Tamp_Home_Height_Above_Conveyor_IN - Me.EHS350_Tamp_Data_Xpp + Me.EHS350_Tamp_Data_Xreg - Me.MTBH_Height_Minimum_IN) / Me.EHS350_Tamp_Data_Vf
      '   END FORMULA; PROP ID:9689; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Home_variable", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Prepos_variable() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Prepos_variable").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9690; TYPE:PF
      Result = (Me.App_Tamp_Home_Height_Above_Conveyor_IN - Me.EHS350_Tamp_Data_Xpp - Me.MTBH_Height_Minimum_IN) / Me.EHS350_Tamp_Data_Vf
      '   END FORMULA; PROP ID:9690; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Prepos_variable", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Preposition_A_D_Time_Constant() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Preposition_A_D_Time_Constant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9691; TYPE:PF
      Result = (Me.EHS350_Tamp_Data_Vf / Me.EHS350_Tamp_Data_Ad) + (Me.EHS350_Tamp_Data_Vf / Me.EHS350_Tamp_Data_Dd) - ((((Me.EHS350_Tamp_Data_Vf * Me.EHS350_Tamp_Data_Vf) / (2 * Me.EHS350_Tamp_Data_Ad)) + ((Me.EHS350_Tamp_Data_Vf * Me.EHS350_Tamp_Data_Vf) / (2 * Me.EHS350_Tamp_Data_Dd))) / Me.EHS350_Tamp_Data_Vf)
      '   END FORMULA; PROP ID:9691; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Preposition_A_D_Time_Constant", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Print_Time() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Print_Time").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9692; TYPE:PF
      Result = Me.App_Label_Printed_Length_IN / me.App_Label_Print_Speed_IN
      '   END FORMULA; PROP ID:9692; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Print_Time", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Reg_Move_Time() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Reg_Move_Time").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9693; TYPE:PF
      Dim Vr = Me.EHS350_Tamp_Data_Vr
Dim Ar = Me.EHS350_Tamp_Data_Ar
Dim Dr = Me.EHS350_Tamp_Data_Dr
Dim Xreg = Me.EHS350_Tamp_Data_Xreg

Result = Vr/Ar+Vr/Dr+(((Xreg)-(Vr^2/(2*Ar)+Vr^2/(2*Dr)))/Vr)
      '   END FORMULA; PROP ID:9693; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Reg_Move_Time", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Run_Home_A_D_Time_Constant() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Run_Home_A_D_Time_Constant").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9694; TYPE:PF
      Result = (Me.EHS350_Tamp_Data_Vf / Me.EHS350_Tamp_Data_Au) + (Me.EHS350_Tamp_Data_Vf / Me.EHS350_Tamp_Data_Du) - ((((Me.EHS350_Tamp_Data_Vf * Me.EHS350_Tamp_Data_Vf) / (2 * Me.EHS350_Tamp_Data_Au)) + ((Me.EHS350_Tamp_Data_Vf * Me.EHS350_Tamp_Data_Vf) / (2 * Me.EHS350_Tamp_Data_Du))) / Me.EHS350_Tamp_Data_Vf)
      '   END FORMULA; PROP ID:9694; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Run_Home_A_D_Time_Constant", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Static_Blast_Wait_Time() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Static_Blast_Wait_Time").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9695; TYPE:PF
      Result = 0.2
      '   END FORMULA; PROP ID:9695; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Static_Blast_Wait_Time", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Vf() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Vf").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9696; TYPE:PF
      Result = 100
      '   END FORMULA; PROP ID:9696; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Vf", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Vr() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Vr").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9697; TYPE:PF
      Result = 20
      '   END FORMULA; PROP ID:9697; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Vr", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Xpp() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Xpp").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9698; TYPE:PF
      Result = 2.25
      '   END FORMULA; PROP ID:9698; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Xpp", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EHS350_Tamp_Data_Xreg() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EHS350_Tamp_Data_Xreg").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9699; TYPE:PF
      Result = 1.875
      '   END FORMULA; PROP ID:9699; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_EHS350_Tamp_Data_Xreg", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9700; TYPE:PF
      Result = Me.My_Print_And_Apply(1).MTBH_Height_Average_IN
      '   END FORMULA; PROP ID:9700; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_MTBH_Height_Average_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9701; TYPE:PF
      Result = Me.My_Print_And_Apply(1).MTBH_Height_Minimum_IN
      '   END FORMULA; PROP ID:9701; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_MTBH_Height_Minimum_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_App_Label_Print_Speed_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("App_Label_Print_Speed_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9702; TYPE:PF
      Result = Me.My_Print_And_Apply(1).App_Label_Print_Speed_IN
      '   END FORMULA; PROP ID:9702; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_App_Label_Print_Speed_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_App_Label_Printed_Length_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("App_Label_Printed_Length_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9703; TYPE:PF
      Result = Me.My_Print_And_Apply(1).App_Label_Printed_Length_IN
      '   END FORMULA; PROP ID:9703; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_App_Label_Printed_Length_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_App_Tamp_Home_Height_Above_Conveyor_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("App_Tamp_Home_Height_Above_Conveyor_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9679; TYPE:PF
      Result = Me.My_Print_And_Apply(1).App_Tamp_Home_Height_Above_Conveyor_IN
      '   END FORMULA; PROP ID:9679; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_EHS350_Data.Formula_App_Tamp_Home_Height_Above_Conveyor_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Ad_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Ar_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Au_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Avg_Height_Stroke_Prepos_Mv_Time_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Dd_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Dr_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Du_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Full_Stroke_Preposition_Move_Time_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Full_Stroke_Run_Home_Time_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Home_variable_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Prepos_variable_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Preposition_A_D_Time_Constant_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Print_Time_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Reg_Move_Time_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Run_Home_A_D_Time_Constant_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Static_Blast_Wait_Time_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Vf_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Vr_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Xpp_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Xreg_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_MTBH_Height_Minimum_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_App_Label_Print_Speed_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_App_Label_Printed_Length_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_App_Tamp_Home_Height_Above_Conveyor_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Ad_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Ar_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Au_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Avg_Height_Stroke_Prepos_Mv_Time_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Dd_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Dr_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Du_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Full_Stroke_Preposition_Move_Time_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Full_Stroke_Run_Home_Time_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Home_variable_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Prepos_variable_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Preposition_A_D_Time_Constant_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Print_Time_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Reg_Move_Time_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Run_Home_A_D_Time_Constant_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Static_Blast_Wait_Time_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Vf_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Vr_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Xpp_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EHS350_Tamp_Data_Xreg_USERCHANGE() as Boolean
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
      Public Function Formula_MTBH_Height_Minimum_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_App_Label_Print_Speed_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_App_Label_Printed_Length_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_App_Tamp_Home_Height_Above_Conveyor_IN_USERCHANGE() as Boolean
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

  