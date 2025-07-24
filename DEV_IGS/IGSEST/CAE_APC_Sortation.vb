Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: IGSEST
'$ PartFamily: CAE_APC_Sortation
'$ GenerateDate: 07/24/2025 22:14:38

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
    
          Public Property [Capacity_Theoretic_Max_for_Passive_Gap_Control_CPM]() As Double
      Get
      Return Properties("Capacity_Theoretic_Max_for_Passive_Gap_Control_CPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Capacity_Theoretic_Max_for_Passive_Gap_Control_CPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Capacity_Theoretic_MaxPassive_Gap_w10pct_Margin]() As Double
      Get
      Return Properties("Capacity_Theoretic_MaxPassive_Gap_w10pct_Margin").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Capacity_Theoretic_MaxPassive_Gap_w10pct_Margin").CalculatedValue = Value
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
    
          Public Property [Gap_Global_Design_Override_IN]() As Double
      Get
      Return Properties("Gap_Global_Design_Override_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_Global_Design_Override_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gap_Head_to_Head_Spacing_Min_IN]() As Double
      Get
      Return Properties("Gap_Head_to_Head_Spacing_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_Head_to_Head_Spacing_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gap_Highest_Min_IN]() As Double
      Get
      Return Properties("Gap_Highest_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_Highest_Min_IN").CalculatedValue = Value
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
    
          Public Property [Gap_Requirement_Calculated_IN]() As Double
      Get
      Return Properties("Gap_Requirement_Calculated_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_Requirement_Calculated_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gap_Scale_Required_Min_IN]() As Double
      Get
      Return Properties("Gap_Scale_Required_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_Scale_Required_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gap_Scanner_Required_Min_IN]() As Double
      Get
      Return Properties("Gap_Scanner_Required_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_Scanner_Required_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gap_Sorter_Operation_Reqd_Min_IN]() As Double
      Get
      Return Properties("Gap_Sorter_Operation_Reqd_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_Sorter_Operation_Reqd_Min_IN").CalculatedValue = Value
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
    
          Public Property [Gap_ZipperMerge_Required_Min_IN]() As Double
      Get
      Return Properties("Gap_ZipperMerge_Required_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_ZipperMerge_Required_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gapping_Method_If_Active]() As String
      Get
      Return Properties("Gapping_Method_If_Active").Value
      End Get
      Set(ByVal Value As String)
      Properties("Gapping_Method_If_Active").CalculatedValue = Value
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
    
          Public Property [Tool_Name]() As String
      Get
      Return Properties("Tool_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Tool_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Tool_Status]() As String
      Get
      Return Properties("Tool_Status").Value
      End Get
      Set(ByVal Value As String)
      Properties("Tool_Status").CalculatedValue = Value
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
    InitPart("CAE_APC_Sortation", <a><![CDATA[CAE_APC_Sortation]]></a>.Value, 442, "IGSEST",  "N", "N", True, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/24/2025 22:08:43")
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
    AddProperty("11114", "Capacity_Theoretic_Max_for_Passive_Gap_Control_CPM", <a><![CDATA[Capacity_Theoretic_Max_for_Passive_Gap_Control_CPM]]></a>.Value, "Max Theoretical Capacity for Passive Gap Control (CPM)", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/21/2025 6:56:14 PM")
    AddProperty("11115", "Capacity_Theoretic_MaxPassive_Gap_w10pct_Margin", <a><![CDATA[Capacity_Theoretic_Max Passive_Gap_w10pct_Margin]]></a>.Value, "Max Theoretical Capacity for Passive Gap Control (CPM)", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/22/2025 1:21:15 PM")
    AddProperty("10946", "Check_Width", <a><![CDATA[Check_Width]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 9:30:15 PM")
    AddProperty("10879", "Chosen_Sort_Speed_FPM", <a><![CDATA[Chosen_Sort_Speed_FPM]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 8:05:29 PM")
    AddProperty("10880", "Chosen_Sort_Speed_User", <a><![CDATA[Chosen_Sort_Speed_User]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 3:53:41 PM")
    AddProperty("10881", "Chosen_Sort_Speed_User_UOM", <a><![CDATA[Chosen_Sort_Speed_User_UOM]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 4:26:22 PM")
    AddProperty("10936", "Chosen_Sorter_Divert_Angle", <a><![CDATA[Chosen_Sorter_Divert_Angle]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 9:59:32 PM")
    AddProperty("10950", "Chosen_Sorter_Divert_Angle_Radians", <a><![CDATA[Chosen_Sorter_Divert_Angle_Radians]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 9:59:13 PM")
    AddProperty("10884", "Chosen_Sorter_ID", <a><![CDATA[Chosen_Sorter_ID]]></a>.Value, "USer Selected Sorter Model", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 6:42:06 PM")
    AddProperty("10886", "Gap_Control_Method", <a><![CDATA[Gap_Control_Method]]></a>.Value, "Active gapping method -   All active gapping options will utilize a gapping B/M belt with a VFD/Servo drive at the sorter induction. This parameter determines what type of merge arrangement is used upstream of the sorter induction when active gapping is used.   ""Passive"" gap contro -  Generates inter-carton gaps using fixed speed differentials (Blow-Thru). With ""Active"" gap control, gaps are generated via logic/speed control of the induction conveyors.", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 8:18:51 PM")
    AddProperty("10860", "Gap_Design", <a><![CDATA[Gap_Design]]></a>.Value, "Design Gap", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/21/2025 6:50:28 PM")
    AddProperty("11113", "Gap_Global_Design_Override_IN", <a><![CDATA[Gap_Global_Design_Override_IN]]></a>.Value, "Gap Override  From Global setup", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/21/2025 6:47:45 PM")
    AddProperty("10994", "Gap_Head_to_Head_Spacing_Min_IN", <a><![CDATA[Gap_ Head_to_Head_Spacing_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/21/2025 2:29:34 PM")
    AddProperty("11111", "Gap_Highest_Min_IN", <a><![CDATA[Gap_Highest_Min_IN]]></a>.Value, "Largest Gap Required", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/21/2025 6:44:13 PM")
    AddProperty("10947", "Gap_Reqd_Box_Width_Min_IN", <a><![CDATA[Gap_Reqd_Box_Width_Min_IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/20/2025 10:09:26 PM")
    AddProperty("11108", "Gap_Requirement_Calculated_IN", <a><![CDATA[Gap_Requirement_Calculated_IN]]></a>.Value, "Calculated Gap Required", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/21/2025 6:50:46 PM")
    AddProperty("11059", "Gap_Scale_Required_Min_IN", <a><![CDATA[Gap_Scale_Required_Min_IN]]></a>.Value, "Scanner Gap Required", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/22/2025 5:19:13 PM")
    AddProperty("11001", "Gap_Scanner_Required_Min_IN", <a><![CDATA[Gap_Scanner_Required_Min_IN]]></a>.Value, "Scanner Gap Required", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/21/2025 4:30:44 PM")
    AddProperty("11085", "Gap_Sorter_Operation_Reqd_Min_IN", <a><![CDATA[Gap_Sorter_Operation_Reqd_Min_IN]]></a>.Value, "Sorter Gap Required", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/21/2025 6:14:40 PM")
    AddProperty("10887", "Gap_Tolerance", <a><![CDATA[Gap_Tolerance]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 8:30:48 PM")
    AddProperty("11072", "Gap_ZipperMerge_Required_Min_IN", <a><![CDATA[Gap_ZipperMerge_Required_Min_IN]]></a>.Value, "Zipper Merge Gap Required", "Double","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/21/2025 5:41:49 PM")
    AddProperty("11064", "Gapping_Method_If_Active", <a><![CDATA[Gapping_Method_If_Active]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/21/2025 5:34:47 PM")
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
    AddProperty("11277", "Valid", <a><![CDATA[Valid]]></a>.Value, "Are Plastic Totes Used?", "Boolean","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/23/2025 1:07:54 PM")
    AddProperty("11278", "Valid_Message", <a><![CDATA[Valid_Message]]></a>.Value, "Customer Name (From Salesforce ePRD If Available)", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/24/2025 10:08:43 PM")
    AddProperty("11275", "Tool_Name", <a><![CDATA[Tool_Name]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/23/2025 1:07:54 PM")
    AddProperty("11276", "Tool_Status", <a><![CDATA[Tool_Status]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/23/2025 1:07:54 PM")
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
    
      AddValidValue("Gapping_Method_If_Active")
    
      AddValidValue("Sorter_Candidates_dbKeys")
    
      AddValidValue("Sorter_Selected_Width_IN")
    
      AddValidValue("Spur_After_Sort_Exit_Dist_User_UOM")
    
      AddValidValue("Spur_After_Sort_Orientation")
    
      AddValidValue("Spur_After_Sort_Type")
    
      AddValidValue("User_UOM_System")
    
      AddValidValue("Tool_Status")
    
      oSubpart = AddSubpart(356,"Selected_Sorter", <a><![CDATA[Selected_Sorter]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "7/19/2025 8:13:19 PM")
      
        oSubpart.AddVPF (443, "CAE_APC_Sorter_App_Details", "CAE_APC_Sorter_App_Details")
      
      oSubpart = AddSubpart(355,"Sorter_Candidates", <a><![CDATA[Sorter_Candidates]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "7/19/2025 1:16:44 PM")
      
        oSubpart.AddVPF (443, "CAE_APC_Sorter_App_Details", "CAE_APC_Sorter_App_Details")
      
      oConnection = AddConnection("My_Induction", <a><![CDATA[My_Induction]]></a>.Value, "Connection to My Induction Object", "226", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/21/2025 4:14:34 PM")
      
        oConnection.AddVPF(448, "CAE_APC_Induction")
      
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
          InitProperty("Capacity_Theoretic_Max_for_Passive_Gap_Control_CPM", "10666", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/21/2025 6:55:54 PM", "BoxSize Width Max IN", "In Development",  0,20711)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Capacity_Theoretic_MaxPassive_Gap_w10pct_Margin", "10667", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 1:21:15 PM", "BoxSize Width Max IN", "In Development",  0,20826)
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
          InitProperty("Gap_Design", "10416", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/21/2025 6:50:12 PM", "", "In Development",  0,20709)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Global_Design_Override_IN", "10665", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/21/2025 6:47:19 PM", "BoxSize Width Max IN", "In Development",  0,20704)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Head_to_Head_Spacing_Min_IN", "10547", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/21/2025 2:29:34 PM", "BoxSize Width Max IN", "In Development",  0,20406)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Highest_Min_IN", "10663", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/21/2025 6:44:13 PM", "BoxSize Width Max IN", "In Development",  0,20699)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Reqd_Box_Width_Min_IN", "10500", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 10:09:26 PM", "BoxSize Width Max IN", "In Development",  0,20139)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Requirement_Calculated_IN", "10660", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/21/2025 6:45:05 PM", "BoxSize Width Max IN", "In Development",  0,20701)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Scale_Required_Min_IN", "10611", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 5:19:13 PM", "BoxSize Width Max IN", "In Development",  0,20958)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Scanner_Required_Min_IN", "10554", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/21/2025 4:30:44 PM", "BoxSize Width Max IN", "In Development",  0,20521)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Sorter_Operation_Reqd_Min_IN", "10637", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/21/2025 6:12:42 PM", "BoxSize Width Max IN", "In Development",  0,20645)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Tolerance", "10441", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:30:48 PM", "", "In Development",  0,19677)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_ZipperMerge_Required_Min_IN", "10624", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/21/2025 5:41:38 PM", "BoxSize Width Max IN", "In Development",  0,20624)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gapping_Method_If_Active", "10616", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/21/2025 5:34:44 PM", "", "In Development",  0,20610)
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
            If Incontext("-1", ctx) Then
          InitProperty("Valid", "10827", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/23/2025 1:07:54 PM", "Are Plastic Totes Used?", "In Development",  0,21253)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Valid_Message", "10828", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 10:08:43 PM", "Customer Name (From Salesforce ePRD If Available)", "In Development",  0,21763)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Tool_Name", "10825", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/23/2025 1:07:54 PM", "", "In Development",  0,21250)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Tool_Status", "10826", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/23/2025 1:07:54 PM", "", "In Development",  0,21251)
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
          
        InitValidValue("Gapping_Method_If_Active_ValidValues", "10616", "-1", 20607)
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
            If Incontext("-1", ctx) Then
          
        InitValidValue("Tool_Status_ValidValues", "10826", "-1", 21252)
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
          
        InitConnection("My_Induction", "205", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/21/2025 4:14:34 PM", "", "In Development", "N",362)
        
          End If
        
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
      Public Function Formula_My_Induction_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:205; TYPE:PF
        Result = Nothing
If Me.Parent.Induction.Quantity > 0 Then
	Result = Me.Parent.Induction(1)
End If
        '   END FORMULA; CON ID:205; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_My_Induction_PARTS", ex.Message)
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
          Public Function Formula_Capacity_Theoretic_Max_for_Passive_Gap_Control_CPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Capacity_Theoretic_Max_for_Passive_Gap_Control_CPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10666; TYPE:PF
      Result = 0

'=IF($H$50="Passive",(12*ChosenSortSpeed/((BoxSize_Length_Min_IN+DesignGap)/BoxSize_Length_Min_IN))/BoxSize_Length_Avg,"")

Result = If(Me.Gap_Control_Method="Passive",(12*Me.Chosen_Sort_Speed_FPM / ((Me.My_Setup(1).BoxSize_Length_Min_IN + Me.Gap_Design)/Me.My_Setup(1).BoxSize_Length_Min_IN))/Me.My_Setup(1).BoxSize_Length_Avg,0)
      '   END FORMULA; PROP ID:10666; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Capacity_Theoretic_Max_for_Passive_Gap_Control_CPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Capacity_Theoretic_MaxPassive_Gap_w10pct_Margin() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Capacity_Theoretic_MaxPassive_Gap_w10pct_Margin").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10667; TYPE:PF
      Result = 0

'=If($H$50="Passive",H78*0.9,"")
Result = If(Me.Gap_Control_Method="Passive", Capacity_Theoretic_Max_for_Passive_Gap_Control_CPM * 0.9,0)
      '   END FORMULA; PROP ID:10667; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Capacity_Theoretic_MaxPassive_Gap_w10pct_Margin", ex.Message)
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
      '=IF(OverrideGap>0,OverrideGap,CalculatedGap)
Result = If(Me.Gap_Global_Design_Override_IN > 0, Gap_Global_Design_Override_IN , Me.Gap_Requirement_Calculated_IN)
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
          Public Function Formula_Gap_Global_Design_Override_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Global_Design_Override_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10665; TYPE:PF
      Result = Me.My_Setup(1).Material_Gap_Override_IN
      '   END FORMULA; PROP ID:10665; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gap_Global_Design_Override_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gap_Head_to_Head_Spacing_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Head_to_Head_Spacing_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10547; TYPE:PF
      '=IF(H50="Passive",IF(BoxSize_Length_Min_IN<15,15-BoxSize_Length_Min_IN,""),"")
Result = If(Me.Gap_Control_Method="Passive",If(Me.My_Setup(1).BoxSize_Length_Min_IN < 15, 15 - Me.My_Setup(1).BoxSize_Length_Min_IN,0),0)
      '   END FORMULA; PROP ID:10547; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gap_Head_to_Head_Spacing_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gap_Highest_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Highest_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10663; TYPE:PF
      Result = 0

'=MAX(H66:H71,H38)
Result = XLSMax(Me.Gap_Head_to_Head_Spacing_Min_IN, Me.Gap_Head_to_Head_Spacing_Min_IN, Me.Gap_Reqd_Box_Width_Min_IN, Me.Gap_Scale_Required_Min_IN)
Result = XlsMax(Result, Me.Gap_Sorter_Operation_Reqd_Min_IN, Me.Gap_ZipperMerge_Required_Min_IN, Me.Gap_Scanner_Required_Min_IN )
      '   END FORMULA; PROP ID:10663; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gap_Highest_Min_IN", ex.Message)
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
          Public Function Formula_Gap_Requirement_Calculated_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Requirement_Calculated_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10660; TYPE:PF
      Result = 0

'=IF(H49="Standard",IF(H72>10,H72,10),H72)

Result =If (Me.Gap_Tolerance = "Standard",If(Me.Gap_Highest_Min_IN >10,Me.Gap_Highest_Min_IN,10),Me.Gap_Highest_Min_IN)
      '   END FORMULA; PROP ID:10660; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gap_Requirement_Calculated_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gap_Scale_Required_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Scale_Required_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10611; TYPE:PF
      'Todo: MPC Fix  Link to Induction
Result = 0
If Me.My_Induction.Quantity > 0
	
	'Result = Me.My_Induction(1).Gap_Scan_Application_Min_IN
End If
      '   END FORMULA; PROP ID:10611; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gap_Scale_Required_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gap_Scanner_Required_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Scanner_Required_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10554; TYPE:PF
      Result = 0
If Me.My_Induction.Quantity > 0
	Result = Me.My_Induction(1).Gap_Scan_Application_Min_IN
End If
      '   END FORMULA; PROP ID:10554; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gap_Scanner_Required_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gap_Sorter_Operation_Reqd_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Sorter_Operation_Reqd_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10637; TYPE:PF
      Result = 0

'=IF(H49="Standard",MAX(MinGapForType,10),MinGapForType)
Dim Gap_Min_IN = Me.Selected_Sorter(1).Gap_Min_IN
Result = If(Me.Gap_Tolerance="Standard",MAX(Gap_Min_IN,10),Gap_Min_IN)
      '   END FORMULA; PROP ID:10637; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gap_Sorter_Operation_Reqd_Min_IN", ex.Message)
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
          Public Function Formula_Gap_ZipperMerge_Required_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_ZipperMerge_Required_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10624; TYPE:PF
      Result = 0
If Me.My_Induction.Quantity > 0
	' =IF(AND(H52="Zippering Merge",H49="Small"),8,"")
	Result =If(XlsAND(Me.Gapping_Method_If_Active="Zippering Merge",Me.Gap_Tolerance="Small"),8,0)
	
End If
      '   END FORMULA; PROP ID:10624; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gap_ZipperMerge_Required_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gapping_Method_If_Active() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gapping_Method_If_Active").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10616; TYPE:PF
      If Me.Gap_Control_Method = "Active" Then
	Result = "IntelliMerge"
Else
	Result = ""
End If
      '   END FORMULA; PROP ID:10616; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gapping_Method_If_Active", ex.Message)
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
          Public Function Formula_Valid() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Valid").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10827; TYPE:PF
      Result = True
' !!!Attention !!! : This will need to be broken from subscription and reworked for the Part Family in Scope

'Error Levels 
'	0 = Info
'	1 = Warning
'	2 = Error
'	3 = Critical (Critical Means Nothing beyond associated process step should be allowed until this is fixed

Dim InValidity_Trigger_Level As Integer = 2 ' Set to Error
Dim Source As String = Me.Name ' Set To Current Property's name, Override If neccessary for more detailed source log info

'This Section should be a duplicate Of Valid Message

 Dim EList As New Custom.HWErrorList

 EList.Add(0, "Warning Message", "ERR000", Source)
 EList.Add(1, "Warning Message", "ERR001", Source)
 EList.Add(2, "Errror Message", "ERR002", Source)
 EList.Add(3, "Critcal Message", "ERR003", Source)

 ' End Duplicate Section
EList.Add(3, "Critical, Not Impleented - Warnings and Errors Need Implemented", "ERR003", Me.Name)

Result = EList.IsValid(InValidity_Trigger_Level)
      '   END FORMULA; PROP ID:10827; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Valid", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10828; TYPE:PF
      Result = ""

' !!!Attention !!! : This will need to be broken from subscription and implemented specically for the Part Family in Scope

'ErrorLevels 
'	0 = Info
'	1 = Warnings
'	2 = Error2
'	3 = Critical (Critical Means Nothing beyond associated process step should be allowed until this is fixed

Dim Show_Errors_Level As Integer = 2 ' Set to Error
Dim Source As String = Me.Name ' Set To Current Property's name, Override If neccessary for more detailed source log info
Dim EList As New Custom.HWErrorList

'Add Error Evaluations in this section

 'EList.Add(ErrorLevel.Info, "Warning Message", "ERR000", Source)
 'EList.Add(ErrorLevel.Warnings, "Warning Message", "ERR001", Source)
 'EList.Add(ErrorLevel.Errors, "Errror Message", "ERR002", Source)
 'EList.Add(ErrorLevel.Critical, "Critcal Message", "ERR003", Source)

'=IF(AND(SorterType="", Setup!D69>0),"ERROR: VALID SORTER CHOICES ARE AVAILABLE BUT NONE ARE CURRENTLY SELECTED","") 
Dim Available_Sorter_Options As Integer = Me.My_Setup(1).Sorter_Options_Found_Qty
Dim Is_Sorter_Seleted As Boolean = (Selected_Sorter.Quantity > 0)
Dim Chosen_Sorter_Model As String = ""

If Is_Sorter_Seleted Then
	Chosen_Sorter_Model = Me.Selected_Sorter(1).Model
End If

If Not Is_Sorter_Seleted And Available_Sorter_Options > 0 Then
	EList.Add(3, "CRITICAL!: VALID SORTER CHOICES ARE AVAILABLE BUT NONE ARE CURRENTLY SELECTED","APC001", Source) 
End If

'=IF(SorterType<>"",IF(OR(BoxSize_Length_Min_IN<SortMinBoxLength,BoxSize_Width_Min_IN<SortMinBoxWidth,BoxSize_Weight_Min_LBS<SortMinBoxWeight,BoxSize_Length_Max_IN>SortMaxBoxLength,BoxSize_Width_Max_IN>SortMaxBoxWidth,BoxSize_Weight_Max_LBS>SortMaxBoxWeight),"ERROR: CHOSEN SORTER CANNOT HANDLE PRODUCT - DEFINED PRODUCT SIZES EXCEED DESIGN LIMITS OF SORTER",""),"") - K34
If Is_Sorter_Seleted  Then
	If(Custom.XlsOR(BoxSize_Length_Min_IN < BoxSize_Length_Min_User, BoxSize_Width_Min_IN < BoxSize_Width_Min_User, BoxSize_Weight_Min_LBS < BoxSize_Weight_Min_User, BoxSize_Length_Max_IN > BoxSize_Length_Max_User)) Then 'BoxSize_Width_Max_IN > BoxSize_Width_Max_User, BoxSize_Weight_Max_LBS > BoxSize_Weight_Max_User)) Then 
 		EList.Add(2, "ERROR: CHOSEN SORTER CANNOT HANDLE PRODUCT - DEFINED PRODUCT SIZES EXCEED DESIGN LIMITS OF SORTER", "APC002", Source)
	End If
End If

' TODO: VY - MC  7/23/2025  Complete this error , ref Sortation Cell k35
'=IF(Setup!D69<>0,IF(COUNTIF('Sort Choices'!C38:C52,SorterType)=0,"ERROR: SORTER CHOICE IS INCOMPATIABLE WITH APPLICATION AS CONFIGURED. CHECK SORTER ","3"),"ERROR: NO  COMPATIABLE SORTER CHOICE IS AVAILABLE FOR THIS APPLICATION AS DEFINED", "4) - K35
'=IF(Setup!D69<>0,IF(COUNTIF('Sort Choices'!C38:C52,SorterType)=0,"ERROR: SORTER CHOICE IS INCOMPATIABLE WITH APPLICATION AS CONFIGURED. CHECK SORTER ","3"),"ERROR: NO  COMPATIABLE SORTER CHOICE IS AVAILABLE FOR THIS APPLICATION AS DEFINED", "4) - K35



' TODO: VY - MPC  7/23/2025  Complete this error , ref Sortation Cell M36
'=If(Setup!D69<>0,If(COUNTIF('Sort Choices'!C38:C52,SorterType)=0,"CHOICES TAB FOR REASONS, MODIFIY THE APPLICATION REQUIREMENTS OR PICK A DIFFERENT SORTER!","5"),)


' TODO: MPC  7/23/2025  Complete this error , ref Sortation Cell L37
'=IF(SorterType="HDS, Dual Sided, 20°","WARNING: BE ADVISED THAT ALL HDS SORTER APPLICATIONS MUST BE REVIEWED AND APPROVED BY","") - L37
If Chosen_Sorter_Model.StartsWith("HDS") Then
	EList.Add(ErrorLevel.Info, "WARNING: BE ADVISED THAT ALL HDS SORTER APPLICATIONS MUST BE REVIEWED AND APPROVED BY","APC006", Source)
End If

' TODO: MPC  7/23/2025  Complete this error , ref Sortation Cell M38
'=IF(SorterType="HDS, Dual Sided, 20°","THE SORTER ENGINEERING GROUP WITHOUT EXCEPTION!","") - M38
If Chosen_Sorter_Model.StartsWith("HDS, Dual Sided, 20") Then
	EList.Add(ErrorLevel.Warnings, "WARNING: THE SORTER ENGINEERING GROUP WITHOUT EXCEPTION!","APC007", Source)
End If

'=IF(SorterCategory="Transnorm","NOTE! GAP REQUIREMENTS FOR TRANSNORM SORTERS VARY BASED ON SPEED, CARTON SIZE AND GAPPING METHOD","") - M39
If(Me.Selected_Sorter(1).Sorter_Type = "Transnorm") Then
	EList.Add(ErrorLevel.Warnings, "WARNING: NOTE! GAP REQUIREMENTS FOR TRANSNORM SORTERS VARY BASED ON SPEED, CARTON SIZE AND GAPPING METHOD","AP008", Source)
End If

' TODO: MPC  7/23/2025  Complete this error , ref Sortation Cell k40
'=IF(H40>Temp_Sort_Operating_Min,"ERROR: DEFINED SORTATION AREA MINIMUM TEMPERATURE IS BELOW THE SELECTED SORTER'S ALLOWABLE RANGE","")
'If(H40 > Temp_Sort_Operating_Min) Then
	'EList.Add(1, "ERROR: DEFINED SORTATION AREA MINIMUM TEMPERATURE IS BELOW THE SELECTED SORTER'S ALLOWABLE RANGE","", Source)
'End If

' TODO: MPC  7/23/2025  Complete this error , ref Sortation Cell K45
'=IF(AND(SorterWidth<Conveyor_BF_Selected_Min_IN,Conveyor_BF_Selected_Min_IN<40,SorterType<>"HDS, Dual Sided, 20°"),"ERROR - CHOOSEN SORTER WIDTH NARROWER THAN SELECTED SYSTEM B/F!",IF(AND(SorterWidth<>22,SorterType="HDS, Dual Sided, 20°"),"ERROR: HDS SORTER IS ONLY AVAILABLE IN A 22 INCH B/F",""))
'If(Custom.XlsAnd(SorterWidth < Conveyor_BF_Selected_Min_IN, Conveyor_BF_Selected_Min_IN<40,SorterType<>"HDS, Dual Sided, 20°"),"ERROR - CHOOSEN SORTER WIDTH NARROWER THAN SELECTED SYSTEM B/F!", "APC009", Source)
'If(And(SorterWidth<>22, SorterType="HDS, Dual Sided, 20°"),"ERROR: HDS SORTER IS ONLY AVAILABLE IN A 22 INCH B/F","APC0010", Source)
'End If
'End If

' TODO: VY - MC  7/23/2025  Complete this error , ref Sortation Cell K46
'=IF(OR(AND(BoxSize_Width_Max_IN>(SorterWidth-2),Conveyor_Product_Line_Used="Imperial"),AND(BoxSize_Width_Max_MM>(SorterWidthMetric-50.8),Conveyor_Product_Line_Used="Metric")),"ERROR: CHOOSEN SORTER TOO NARROW FOR MATERIAL TO BE HANDLED!","")
'IF(OR(AND(BoxSize_Width_Max_IN>(SorterWidth-2),Conveyor_Product_Line_Used="Imperial"),AND(BoxSize_Width_Max_MM>(SorterWidthMetric-50.8),Conveyor_Product_Line_Used="Metric")),"ERROR: CHOOSEN SORTER TOO NARROW FOR MATERIAL TO BE HANDLED!","APC0010", Source)


' TODO: MPC  7/23/2025  Complete this error , ref Sortation Cell k47
'=IF(OR(AND(Conveyor_Product_Line_Used="Imperial",SorterWidth=38,R48<>38),AND(Conveyor_Product_Line_Used="Metric",SorterWidthMetric=960,S48<>960)),"ERROR: INVALID WIDTH FOR CHOSEN SORTER TYPE","")
'If(Custom.XlsOR(Custom.XlsAND(Conveyor_Product_Line_Used = "Imperial", SorterWidth=38,R48<>38), Custom.XlsAND(Conveyor_Product_Line_Used = "Metric",SorterWidthMetric=960,S48<>960)))
'	EList.Add(2,"ERROR: INVALID WIDTH FOR CHOSEN SORTER TYPE","APC0011", Source)
'End If

' TODO: MPC  7/23/2025  Complete this error , ref Sortation Cell L47
'=IF(OR(AND(Conveyor_Product_Line_Used="Imperial",SorterWidth<>Conveyor_BF_Selected_Min_IN),AND(Conveyor_Product_Line_Used="Metric",SorterWidthMetric<>SelectedMinConvBFMetric)),"WARNING: SORTER WIDTH DOES NOT MATCH SELECTED SYSTEM B/F!","")
'If(Custom.XlsOr(Custom.XlsAnd(Conveyor_Product_Line_Used = "Imperial",SorterWidth<>Conveyor_BF_Selected_Min_IN),Custom.XlsAnd(Conveyor_Product_Line_Used="Metric",SorterWidthMetric<>SelectedMinConvBFMetric)))
'EList.Add(1, "WARNING: SORTER WIDTH DOES NOT MATCH SELECTED SYSTEM B/F!","", Source)
'End If

' TODO: MPC  7/23/2025  Complete this error , ref Sortation Cell K48
'=IF(ChosenSortSpeed>MaxSortSpeed,"ERROR: SELECTED SPEED TOO FAST FOR CHOSEN SORTER","") 
'If(ChosenSortSpeed > MaxSortSpeed) Then
'EList.Add(2,"ERROR: SELECTED SPEED TOO FAST FOR CHOSEN SORTER","", Source)
'End If

'TODO: MPC  7/23/2025  Complete this error , ref Sortation Cell  L50
'IF(AND(GapControlMethod="Active",ActiveGappingMethod="Std Mrg w/ Induct Accum",Case_Length_Per_Ft_Minute_Target>110),"WARNING: ACTIVE GAPPING WITH A STANDARD MERGE WITH INDUCTION ACCUMULATION MUST BE","")
'=IF(Custom.XlsAND(GapControlMethod = "Active", ActiveGappingMethod = "Std Mrg w/ Induct Accum",Case_Length_Per_Ft_Minute_Target>110)) Then
'EList.Add(1, "WARNING: ACTIVE GAPPING WITH A STANDARD MERGE WITH INDUCTION ACCUMULATION MUST BE","", Source)
'End If

'TODO: MPC  7/23/2025  Complete this error , ref Sortation Cell  M51
'=IF(AND(GapControlMethod="Active",ActiveGappingMethod="Std Mrg w/ Induct Accum",Case_Length_Per_Ft_Minute_Target>110),"REVIEWED BY APPLICATIONS ENGINEERING IF ABOVE A 110 CFPM RATE REQUIREMENT!","")
'If(Custom.XlsAnd(GapControlMethod="Active", ActiveGappingMethod = "Std Mrg w/ Induct Accum", Case_Length_Per_Ft_Minute_Target>110)) then
'EList.Add(1, "WARNING: REVIEWED BY APPLICATIONS ENGINEERING IF ABOVE A 110 CFPM RATE REQUIREMENT!","", Source)
'End if

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell K52
'=If(Or(And(ActiveGappingMethod="PLC Slug Merge",Selected_Sortation_Controls<>"PLC"),And(Or(ActiveGappingMethod="Zippering Merge",ActiveGappingMethod="Intellimerge"),Selected_Sortation_Controls="PLC")),"ERROR: THE ACTIVE GAPPING METHOD SELECTED (MERGE TYPE) IS NOT SUPPORTED BY THE SELECTED CONTROL SYSTEM","")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell K53
'=IF(AND(GapControlMethod="Active",ActiveGappingMethod="Zippering Merge",ChosenSortSpeed>600),"ERROR: SORTATION SPEEDS ABOVE 600 FPM ARE NOT CURRENTLY SUPPORTED BY A ZIPPERING MERGE!","")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell K54
'=If(And(H53="Gravity",H54="Horizontal"),"ERROR - GRAVITY CANNOT BE HORIZONTAL!","")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell K55
'=IF(AND(OR(SorterType="WD (Pop-Up Wheel)",SorterCategory="Transnorm"),OR(H53<>"Powered",H54<>"Horizontal")),IF(H53<>"Powered","ERROR: GRAVITY AFTER-SORT SPURS CANNOT BE USED WITH THIS SORTER TYPE!","ERROR: POWERED SPURS MUST BE HORIZONTAL WITH THIS SORTER TYPE!"),"")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell K63
'=IF(H62>MaxSortSpeed,"ERROR - REQUESTED RATE EXCEEDS SELECTED SORTER'S THEORETICAL CAPACITY","")
'If(H62>MaxSortSpeed) Then
'Elist.Add(2, "ERROR - REQUESTED RATE EXCEEDS SELECTED SORTER'S THEORETICAL CAPACITY","", Source)
'End If
	
'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell M64
'=IF(H64="**","CHECK PRODUCT MANUAL FOR STANDARD SPEEDS OF NON-INTELLISORT (SLIDING SHOE) EQUIPMENT","")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell M66
'=IF(BoxSize_Width_Avg_IN>20,"AVERAGE BOX WIDTH GREATER THAN 20 INCHES, USING MAX WIDTH FOR GAP REQUIREMENT!","")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell L74
'=IF(AND(OverrideGap>0,OverrideGap<CalculatedGap),"WARNING: GAP OVERRIDE IS ENABLED AND GAP SELECTED IS SMALLER THAN CALCULATED REQUIREMENT","")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell L79
'=IF(H79<Sort_Rate_Required_CPM,"WARNING: BLOW-THRU WILL NOT MEET TARGET SORTATION RATE !","")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell L82
'=IF(AND(GapControlMethod="Passive",DecoupleStdMergeFromSorterFlag="Yes"),"WARNING: STANDARD MERGE CALCULATIONS HAVE BEEN DECOUPLED FROM THE SORTER!","")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell M83
'=IF(AND(GapControlMethod="Passive",DecoupleStdMergeFromSorterFlag="Yes"),"NO RATE RESULTS WILL BE DISPLAYED FOR SORTATION IN THIS MODE.","")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell L84
'=IF(AND(H84>0,H84<>""),"REVIEW ALL WARNINGS ON STANDARD MERGE CALCULATION SHEET BEFORE USING THIS RATE ESTIMATE!","")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell K85
'=IF(AND(H85>0,H85<>""),"CORRECT ALL ERRORS ON STANDARD MERGE CALCULATION SHEET BEFORE USING THIS ESTIMATE!","")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell L88
'=IF(AND(H88>0,H88<>""),"REVIEW ALL WARNINGS ON RATE MATCHING MERGE CALCULATION SHEET BEFORE USING THIS RATE ESTIMATE!","")

' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell K89
'=If(And(H89>0,H89<>""),"CORRECT ALL ERRORS ON  RATE MATCHING MERGE CALCULATION SHEET BEFORE USING THIS ESTIMATE!","")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell L91
'=IF(AND(TotalPreMrgAvailableCPM<Sort_Rate_Required_CPM,H52="Zippering Merge"),"INSUFFICIENT VOLUME INPUT DEFINED UPSTREAM OF ZIPPER MERGE FOR FULL UTILIZATION!","")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell  L92
'=IF(AND(H92>0,H92<>""),"REVIEW ALL WARNINGS ON ZIPPER MERGE CALCULATION SHEET BEFORE USING THIS RATE ESTIMATE!","")

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell K93
'=IF(AND(H93>0,H93<>""),"CORRECT ALL ERRORS ON ZIPPER MERGE CALCULATION SHEET BEFORE USING THIS ESTIMATE!","")
'If(Custom.XlsAnd(H93>0,H93<>"")) Then
	'EList.Add(1, "Warning: CORRECT ALL ERRORS ON ZIPPER MERGE CALCULATION SHEET BEFORE USING THIS ESTIMATE!","APC00", Source)
'End If

'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell L95
'=If(And(TotalPreMrgAvailableCPM<(Sort_Rate_Required_CPM*1.02),H52="Intellimerge"),"INSUFFICIENT VOLUME INPUT DEFINED! INTELLIMERGE RATE CALCULATION WILL NOT BE ACCURATE!","")
'If(Custom.XlsAnd(TotalPreMrgAvailableCPM<(Sort_Rate_Required_CPM*1.02),H52="Intellimerge")) Then
	'EList.Add(1, "Warning: INSUFFICIENT VOLUME INPUT DEFINED! INTELLIMERGE RATE CALCULATION WILL NOT BE ACCURATE!","APC00", Source)
'End If
	
'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell  L96
'=IF(AND(H96>0,H96<>""),"REVIEW ALL WARNINGS ON INTELLIMERGE CALCULATION SHEET BEFORE USING THIS RATE ESTIMATE!","")
'If(Custom.XlsAnd(H96>0,H96<>"")) Then
	'EList.Add(1, "Warning: REVIEW ALL WARNINGS ON INTELLIMERGE CALCULATION SHEET BEFORE USING THIS RATE ESTIMATE!","APC00", Source)	
'End If
	
'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell K97
'=IF(AND(H97>0,H97<>""),"CORRECT ALL ERRORS ON INTELLIMERGE CALCULATION SHEET BEFORE USING THIS ESTIMATE!","")
'If(Custom.XlsAnd(H97>0,H97<>"")) Then
'EList.Add(1, "Warning: CORRECT ALL ERRORS On INTELLIMERGE CALCULATION SHEET BEFORE Using THIS ESTIMATE!","APC00", Source)
	'End If
'' TODO:  MPC  7/23/2025  Complete this error , ref Sortation Cell L101
'=If(H101<Sort_Rate_Required_CPM,"WARNING: CURRENT APPLICATION CONFIGURATION DOESN'T MEET THE DEFINED RATE REQUIREMENT!","")
'If(H101<Sort_Rate_Required_CPM) Then
'EList.Add(1, "WARNING: CURRENT APPLICATION CONFIGURATION DOESN'T MEET THE DEFINED RATE REQUIREMENT!","APC00", Source)
	
'Result = EList.ErrorSummary(1)
Result = EList.ErrorSummary(Show_Errors_Level)
      '   END FORMULA; PROP ID:10828; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Valid_Message", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Tool_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Tool_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10825; TYPE:PF
      Result = "Tool Name Not Implented" ' Implement this name

'Delete this Section section after implementing Tool Name Above
If Result = "Tool Name Not Implented" Then
	MsgBox ("Error in {Me.Name}. Tool_Name Property Not Implemented")
End If
'End Delete Section
      '   END FORMULA; PROP ID:10825; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Tool_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Tool_Status() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Tool_Status").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10826; TYPE:PF
      Result = "New"
      '   END FORMULA; PROP ID:10826; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Tool_Status", ex.Message)
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
      Public Function Formula_Capacity_Theoretic_Max_for_Passive_Gap_Control_CPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Capacity_Theoretic_MaxPassive_Gap_w10pct_Margin_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Gap_Global_Design_Override_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Head_to_Head_Spacing_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Highest_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Gap_Requirement_Calculated_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Scale_Required_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Scanner_Required_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Sorter_Operation_Reqd_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Gap_ZipperMerge_Required_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gapping_Method_If_Active_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Tool_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Tool_Status_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Capacity_Theoretic_Max_for_Passive_Gap_Control_CPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Capacity_Theoretic_MaxPassive_Gap_w10pct_Margin_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_Gap_Global_Design_Override_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Head_to_Head_Spacing_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Highest_Min_IN_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_Gap_Requirement_Calculated_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Scale_Required_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Scanner_Required_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Sorter_Operation_Reqd_Min_IN_USERCHANGE() as Boolean
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
      Public Function Formula_Gap_ZipperMerge_Required_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gapping_Method_If_Active_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Gapping_Method_If_Active").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10616; TYPE:UC
              If Me.Gap_Control_Method = "Active" Then
	Result = True
Else
	Result = False
End If
              '   END FORMULA; PROP ID:10616; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gapping_Method_If_Active_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
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
      Public Function Formula_Tool_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Tool_Status_USERCHANGE() as Boolean
      Return True
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
      Public Function Formula_Gapping_Method_If_Active_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gapping_Method_If_Active").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10616; TYPE:VV
      If Me.Gap_Control_Method = "Active" Then
	Result = MakeValidValues(Array("Std Mrg w/ Induct Accum", "Rate Matching Merge","Zippering Merge","IntelliMerge","PLC Slug Merge"))
Else
	Result = MakeValidValues(Array(""))
End If
      '   END FORMULA; PROP ID:10616; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Gapping_Method_If_Active_ValidValues", ex.Message)
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
      Public Function Formula_Tool_Status_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Tool_Status").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10826; TYPE:VV
      Result = MakeValidValues(Array("New", "Work In Progress", "Approved", "As Sold"))
      '   END FORMULA; PROP ID:10826; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sortation.Formula_Tool_Status_ValidValues", ex.Message)
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

  