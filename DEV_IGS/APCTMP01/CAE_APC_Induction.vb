Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: CAE_APC_Induction
'$ GenerateDate: 07/24/2025 20:07:04

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

    Public Class [CAE_APC_Induction]
    
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

    Private this as CAE_APC_Induction = me

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
    Select Case processId
      Case "57"
      Select Case processStep
        Case "117"
        Result = Process_DefaultProcess_Step_1_COMMENT()
        End Select
        End Select
      
    Return Result
    End Function

    Public Function GetProcessStepStatus(ByVal processId As String, ByVal processStep As String) As Integer Implements RuleStream.IRsPartFormulas.GetProcessStepStatus
    Dim Result as Integer 'Long
    Select Case processId
      Case "57"
      Select Case processStep
        Case "117"
        Result = Process_DefaultProcess_Step_1_STATUS()
        End Select
        End Select
      
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
    
          Public Property [Belt_Curve_Centerline_Radius_IN]() As Double
      Get
      Return Properties("Belt_Curve_Centerline_Radius_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Belt_Curve_Centerline_Radius_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Belt_Curve_Inside_Radius_Min_IN]() As Double
      Get
      Return Properties("Belt_Curve_Inside_Radius_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Belt_Curve_Inside_Radius_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_2_3rd_Length_Min_IN]() As Double
      Get
      Return Properties("Carton_2_3rd_Length_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Carton_2_3rd_Length_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_Alignment_on_Belt_Curve]() As String
      Get
      Return Properties("Carton_Alignment_on_Belt_Curve").Value
      End Get
      Set(ByVal Value As String)
      Properties("Carton_Alignment_on_Belt_Curve").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_Length_Max_Allowable_IN]() As Double
      Get
      Return Properties("Carton_Length_Max_Allowable_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Carton_Length_Max_Allowable_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_Length_Scanned_Max_Pcnt]() As Long
      Get
      Return Properties("Carton_Length_Scanned_Max_Pcnt").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Carton_Length_Scanned_Max_Pcnt").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_Maximum_Linear_Length_Scanned_In]() As Double
      Get
      Return Properties("Carton_Maximum_Linear_Length_Scanned_In").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Carton_Maximum_Linear_Length_Scanned_In").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_Panels_Scanned_Qty]() As Long
      Get
      Return Properties("Carton_Panels_Scanned_Qty").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Carton_Panels_Scanned_Qty").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Carton_Presentation]() As String
      Get
      Return Properties("Carton_Presentation").Value
      End Get
      Set(ByVal Value As String)
      Properties("Carton_Presentation").CalculatedValue = Value
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
    
          Public Property [Gap_Min_on_Avg_Box_Size_IN]() As Double
      Get
      Return Properties("Gap_Min_on_Avg_Box_Size_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_Min_on_Avg_Box_Size_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gap_Min_on_Box_Size_IN]() As Double
      Get
      Return Properties("Gap_Min_on_Box_Size_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_Min_on_Box_Size_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Gap_Scan_Application_Min_IN]() As Double
      Get
      Return Properties("Gap_Scan_Application_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_Scan_Application_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Head_to_Head_Min_IN]() As Double
      Get
      Return Properties("Head_to_Head_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Head_to_Head_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Host_Response_Max_Time_Sec]() As Double
      Get
      Return Properties("Host_Response_Max_Time_Sec").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Host_Response_Max_Time_Sec").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Induct_Belt_Length_Reqd_Estimated_IN]() As Double
      Get
      Return Properties("Induct_Belt_Length_Reqd_Estimated_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Induct_Belt_Length_Reqd_Estimated_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Induction_Belt_Curve_Exists]() As Boolean
      Get
      Return Properties("Induction_Belt_Curve_Exists").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Induction_Belt_Curve_Exists").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Induction_Routing_Method]() As String
      Get
      Return Properties("Induction_Routing_Method").Value
      End Get
      Set(ByVal Value As String)
      Properties("Induction_Routing_Method").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Induction_Scale_Exists]() As Boolean
      Get
      Return Properties("Induction_Scale_Exists").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Induction_Scale_Exists").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Induction_Scale_Type]() As String
      Get
      Return Properties("Induction_Scale_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Induction_Scale_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Label_Orientation]() As String
      Get
      Return Properties("Label_Orientation").Value
      End Get
      Set(ByVal Value As String)
      Properties("Label_Orientation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Local_LookupTime_Max_Sec]() As Double
      Get
      Return Properties("Local_LookupTime_Max_Sec").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Local_LookupTime_Max_Sec").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MaxBoxHeightWidthDim]() As Double
      Get
      Return Properties("MaxBoxHeightWidthDim").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MaxBoxHeightWidthDim").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MinGapRequired_User]() As Double
      Get
      Return Properties("MinGapRequired_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MinGapRequired_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Radius_Value_Used_for_Speed_Match_IN]() As Double
      Get
      Return Properties("Radius_Value_Used_for_Speed_Match_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Radius_Value_Used_for_Speed_Match_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Rate_Theoretic_Max_BlowThru_at_Avg_Length_CPM]() As Double
      Get
      Return Properties("Rate_Theoretic_Max_BlowThru_at_Avg_Length_CPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Rate_Theoretic_Max_BlowThru_at_Avg_Length_CPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Rate_Theoretic_Max_w_Active_Gapping_Avg_Len_CPM]() As Double
      Get
      Return Properties("Rate_Theoretic_Max_w_Active_Gapping_Avg_Len_CPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Rate_Theoretic_Max_w_Active_Gapping_Avg_Len_CPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ReadWindowSize_IN]() As Double
      Get
      Return Properties("ReadWindowSize_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ReadWindowSize_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ReadWindowSize_MM]() As Double
      Get
      Return Properties("ReadWindowSize_MM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ReadWindowSize_MM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ReadWindowSize_USER]() As Double
      Get
      Return Properties("ReadWindowSize_USER").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ReadWindowSize_USER").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Resulting_Centerline_Speed_of_Curve_FPM]() As Double
      Get
      Return Properties("Resulting_Centerline_Speed_of_Curve_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Resulting_Centerline_Speed_of_Curve_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scale_Bed_Length_IN]() As Double
      Get
      Return Properties("Scale_Bed_Length_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Scale_Bed_Length_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scale_Gap_Multi_Stage_Override_IN]() As Double
      Get
      Return Properties("Scale_Gap_Multi_Stage_Override_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Scale_Gap_Multi_Stage_Override_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scale_Speed_Final_FPM]() As Double
      Get
      Return Properties("Scale_Speed_Final_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Scale_Speed_Final_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scale_Speed_Lower_Limit]() As Double
      Get
      Return Properties("Scale_Speed_Lower_Limit").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Scale_Speed_Lower_Limit").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scale_Speed_Override_FPM]() As Double
      Get
      Return Properties("Scale_Speed_Override_FPM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Scale_Speed_Override_FPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scale_Speed_Upper_Limit]() As Double
      Get
      Return Properties("Scale_Speed_Upper_Limit").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Scale_Speed_Upper_Limit").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scanner_Configuration_Name]() As String
      Get
      Return Properties("Scanner_Configuration_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Scanner_Configuration_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scanner_Data_Transmit_Mode]() As String
      Get
      Return Properties("Scanner_Data_Transmit_Mode").Value
      End Get
      Set(ByVal Value As String)
      Properties("Scanner_Data_Transmit_Mode").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN]() As Double
      Get
      Return Properties("Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ShadowingPotential]() As Boolean
      Get
      Return Properties("ShadowingPotential").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("ShadowingPotential").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ShadowingStatus]() As String
      Get
      Return Properties("ShadowingStatus").Value
      End Get
      Set(ByVal Value As String)
      Properties("ShadowingStatus").CalculatedValue = Value
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
    
          Public Property [Spacing_Type_Required]() As String
      Get
      Return Properties("Spacing_Type_Required").Value
      End Get
      Set(ByVal Value As String)
      Properties("Spacing_Type_Required").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_Ratio_Theoretic_Reqd_for_BlowThru]() As Double
      Get
      Return Properties("Speed_Ratio_Theoretic_Reqd_for_BlowThru").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Speed_Ratio_Theoretic_Reqd_for_BlowThru").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Tracking_Photocell_Dist_From_Scanner_Xmit_Pnt_IN]() As Double
      Get
      Return Properties("Tracking_Photocell_Dist_From_Scanner_Xmit_Pnt_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Tracking_Photocell_Dist_From_Scanner_Xmit_Pnt_IN").CalculatedValue = Value
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
    
      Public ReadOnly Property [My_Belt_Turn]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Belt_Turn")
      End Get
      End Property
    
      Public ReadOnly Property [My_PRD]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_PRD")
      End Get
      End Property
    
      Public ReadOnly Property [My_Scan_Belt]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Scan_Belt")
      End Get
      End Property
    
      Public ReadOnly Property [My_Scanner_Configurations]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Scanner_Configurations")
      End Get
      End Property
    
      Public ReadOnly Property [My_Selected_Scanner_Configuration]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Selected_Scanner_Configuration")
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
    
      Public ReadOnly Property CreationDate() As Date
      Get
      If Properties.ContainsKey("CreationDate") Then
      Return Properties("CreationDate").Value
      Else
      Return "12:00:00 AM"
      End If
      End Get
      End Property

      Public ReadOnly Property CustomerName() As String
      Get
      If Properties.ContainsKey("CustomerName") Then
      Return Properties("CustomerName").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      Public ReadOnly Property UserID() As String
      Get
      If Properties.ContainsKey("UserID") Then
      Return Properties("UserID").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      Public ReadOnly Property UserEmail() As String
      Get
      If Properties.ContainsKey("UserEmail") Then
      Return Properties("UserEmail").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      Public ReadOnly Property UserName() As String
      Get
      If Properties.ContainsKey("UserName") Then
      Return Properties("UserName").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      Public ReadOnly Property ProjectID() As String
      Get
      If Properties.ContainsKey("ProjectID") Then
      Return Properties("ProjectID").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      Public ReadOnly Property LineItem() As Integer
      Get
      If Properties.ContainsKey("LineItem") Then
      Return Properties("LineItem").Value
      Else
      Return 0
      End If
      End Get
      End Property

      Public ReadOnly Property Release() As Integer
      Get
      If Properties.ContainsKey("Release") Then
      Return Properties("Release").Value
      Else
      Return 0
      End If
      End Get
      End Property

      Public ReadOnly Property NumberOfParts() As Integer
      Get
      If Properties.ContainsKey("NumberOfParts") Then
      Return Properties("NumberOfParts").Value
      Else
      Return 0
      End If
      End Get
      End Property

      Public ReadOnly Property CurrentDateTime() As Date
      Get
      If Properties.ContainsKey("CurrentDateTime") Then
      Return Properties("CurrentDateTime").Value
      Else
      Return "12:00:00 AM"
      End If
      End Get
      End Property

      Public ReadOnly Property CurrentProcessStep() As String
      Get
      If Properties.ContainsKey("CurrentProcessStep") Then
      Return Properties("CurrentProcessStep").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      Public ReadOnly Property CurrentProcess() As String
      Get
      If Properties.ContainsKey("CurrentProcess") Then
      Return Properties("CurrentProcess").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      Public ReadOnly Property CurrentDrawing() As String
      Get
      If Properties.ContainsKey("CurrentDrawing") Then
      Return Properties("CurrentDrawing").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      'This is added to handle update Rules error coming for __RSLocale
      Public ReadOnly Property __RSLocale() As String
      Get
      If Properties.ContainsKey("__RSLocale") Then
      Return Properties("__RSLocale").Value
      Else
      Return "en-US"
      End If
      End Get
      End Property

      Public ReadOnly Property __TimeZone() As String
      Get
      If Properties.ContainsKey("__TimeZone") Then
      Return Properties("__TimeZone").Value
      Else
      Return String.Empty
      End If
      End Get
      End Property

      'how to get the UDFs?
    
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
    InitPart("CAE_APC_Induction", <a><![CDATA[CAE_APC_Induction]]></a>.Value, 448, "APCTMP01",  "N", "N", True, True, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/24/2025 19:54:40")
    AddProperty("11270", "Belt_Curve_Centerline_Radius_IN", <a><![CDATA[Belt_Curve_Centerline_Radius_IN]]></a>.Value, "Centerline Radius of Belt Curve", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 3:18:39 PM")
    AddProperty("11269", "Belt_Curve_Inside_Radius_Min_IN", <a><![CDATA[Belt_Curve_Inside_Radius_Min_IN]]></a>.Value, "Min. Inside Radius for Belt Curve", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 3:13:36 PM")
    AddProperty("11244", "Carton_2_3rd_Length_Min_IN", <a><![CDATA[Carton_2_3rd_Length_Min_IN]]></a>.Value, "2/3 of Minimum Carton Length.", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 9:37:48 PM")
    AddProperty("11268", "Carton_Alignment_on_Belt_Curve", <a><![CDATA[Carton_Alignment_on_Belt_Curve]]></a>.Value, "Carton Alignment on Belt Curve?", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/23/2025 8:11:51 PM")
    AddProperty("11309", "Carton_Length_Max_Allowable_IN", <a><![CDATA[Carton_Length_Max_Allowable_IN]]></a>.Value, "Max. Allowable Carton Length", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 3:53:16 PM")
    AddProperty("11242", "Carton_Length_Scanned_Max_Pcnt", <a><![CDATA[Carton_Length_Scanned_Max_Pcnt]]></a>.Value, "% of Maximum Carton Length Scanned (L.E. Xmit Mode Only)  This parameter is only applicable to Lead Edge Transmit mode! Allowable range is 25% to 100%!   In applications where the Barcode Labels are consistently located on the leading portion of the cartons, it may not be necessary to design the system to scan the full length of the Max carton. You may be able to shorten the overall Induction Belt Length Required by making this less than 100%", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 9:30:14 PM")
    AddProperty("11245", "Carton_Maximum_Linear_Length_Scanned_In", <a><![CDATA[Carton_Maximum_Linear_Length_ Scanned_In]]></a>.Value, "Maximum Linear Length of Carton Scanned", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/23/2025 8:08:53 PM")
    AddProperty("11217", "Carton_Panels_Scanned_Qty", <a><![CDATA[Carton_Panels_Scanned_Qty]]></a>.Value, "Number of Carton Panels Scanned from Selected Scanner Configuration", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 7:09:17 PM")
    AddProperty("11219", "Carton_Presentation", <a><![CDATA[Carton_Presentation]]></a>.Value, "Carton Presentation", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 7:31:02 PM")
    AddProperty("11253", "Chosen_Sort_Speed_FPM", <a><![CDATA[Chosen_Sort_Speed_FPM]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 10:05:56 PM")
    AddProperty("11259", "Gap_Min_on_Avg_Box_Size_IN", <a><![CDATA[Gap_Min_on_Avg_ Box_Size_IN]]></a>.Value, "Min. Gap on Avg. Box (Inches - for Active Gapping Only)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 10:52:22 PM")
    AddProperty("11258", "Gap_Min_on_Box_Size_IN", <a><![CDATA[Gap_Min_on_ Box_Size_IN]]></a>.Value, "Min. Gap on Min. Box (Inches - for Passive Gapping Only)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 10:47:54 PM")
    AddProperty("11018", "Gap_Scan_Application_Min_IN", <a><![CDATA[Gap_Scan_Application_Min_IN]]></a>.Value, "Minimum Gap for this Scan Application for Chosen Sanner", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 5:21:03 PM")
    AddProperty("11256", "Head_to_Head_Min_IN", <a><![CDATA[Head_to_Head_Min_IN]]></a>.Value, "Min. Head-to-Head (Inches)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 10:36:38 PM")
    AddProperty("11264", "Host_Response_Max_Time_Sec", <a><![CDATA[Host_Response_Max_Time_Sec]]></a>.Value, "Max Host Resp.Time (Secs)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 11:04:43 PM")
    AddProperty("11266", "Induct_Belt_Length_Reqd_Estimated_IN", <a><![CDATA[Induct_Belt_Length_Reqd_Estimated_IN]]></a>.Value, "Estimated Induct Belt Length Required", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/23/2025 10:41:07 PM")
    AddProperty("11267", "Induction_Belt_Curve_Exists", <a><![CDATA[Induction_Belt_Curve_Exists]]></a>.Value, "Induction Belt Curve Exist?", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 11:11:27 PM")
    AddProperty("11263", "Induction_Routing_Method", <a><![CDATA[Induction_Routing_Method]]></a>.Value, "Induction Routing Method?", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 11:03:09 PM")
    AddProperty("11249", "Induction_Scale_Exists", <a><![CDATA[Induction_Scale_Exists]]></a>.Value, "Induction Scale Exists?", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 9:49:10 PM")
    AddProperty("11250", "Induction_Scale_Type", <a><![CDATA[Induction_Scale_Type]]></a>.Value, "Induction Scale Type", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 9:54:29 PM")
    AddProperty("11218", "Label_Orientation", <a><![CDATA[Label_Orientation]]></a>.Value, "Label Orientation", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 7:12:36 PM")
    AddProperty("11265", "Local_LookupTime_Max_Sec", <a><![CDATA[Local_LookupTime_Max_Sec]]></a>.Value, "Max. Local LookupTime (Secs)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 11:08:18 PM")
    AddProperty("11012", "MaxBoxHeightWidthDim", <a><![CDATA[MaxBoxHeightWidthDim]]></a>.Value, "Max of Global BoxSize_Height_Max and BoxSize_Width_Max from Setup Object", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 7:32:02 PM")
    AddProperty("11220", "MinGapRequired_User", <a><![CDATA[MinGapRequired_User]]></a>.Value, "Min. Gap Required for Scanner Application  (mm)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 7:20:43 PM")
    AddProperty("11271", "Radius_Value_Used_for_Speed_Match_IN", <a><![CDATA[Radius_Value_Used_for_Speed_Match_IN]]></a>.Value, "Radius Value Used for Speed Match", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 3:36:41 PM")
    AddProperty("11261", "Rate_Theoretic_Max_BlowThru_at_Avg_Length_CPM", <a><![CDATA[Rate_Theoretic_Max_ BlowThru_at_Avg_Length_CPM]]></a>.Value, "Max Theoretical Blow-Thru Rate @ Avg Length (CPM)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 10:54:17 PM")
    AddProperty("11262", "Rate_Theoretic_Max_w_Active_Gapping_Avg_Len_CPM", <a><![CDATA[Rate_Theoretic_Max_ w_Active_Gapping_Avg_Len_CPM]]></a>.Value, "Max Theoretical Rate With Active Gapping @ Avg Length (CPM)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 10:57:27 PM")
    AddProperty("11221", "ReadWindowSize_IN", <a><![CDATA[ReadWindowSize_IN]]></a>.Value, "Estimated Scanner Read Window Size (Inch)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 7:24:33 PM")
    AddProperty("11222", "ReadWindowSize_MM", <a><![CDATA[ReadWindowSize_MM]]></a>.Value, "Estimated Scanner Read Window Size (mm)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 7:23:54 PM")
    AddProperty("11223", "ReadWindowSize_USER", <a><![CDATA[ReadWindowSize_USER]]></a>.Value, "Estimated Scanner Read Window Size (User UOM)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 7:23:17 PM")
    AddProperty("11272", "Resulting_Centerline_Speed_of_Curve_FPM", <a><![CDATA[Resulting_Centerline_Speed_of_Curve_FPM]]></a>.Value, "Resulting Centerline Speed of Curve", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 3:39:52 PM")
    AddProperty("11251", "Scale_Bed_Length_IN", <a><![CDATA[Scale_Bed_Length_IN]]></a>.Value, "Scale Bed Length  Scale bed length info should be provided by scale vendor based on requested application parameters we provide. If a multiple stage unit is used, the length of the scale is not relevant to the rate calculations", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 10:19:36 PM")
    AddProperty("11257", "Scale_Gap_Multi_Stage_Override_IN", <a><![CDATA[Scale_Gap_Multi_Stage_Override_IN]]></a>.Value, "Scale Gap Override (Multi-Stage Scales Only)  This allows you to choose your own gap (presumably from the scale vendor).", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 7:54:40 PM")
    AddProperty("11254", "Scale_Speed_Final_FPM", <a><![CDATA[Scale_Speed_Final_FPM]]></a>.Value, "Final Scal Speed Scale (Feet Per Minute)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 7:22:01 PM")
    AddProperty("11375", "Scale_Speed_Lower_Limit", <a><![CDATA[Scale_Speed_Lower_Limit]]></a>.Value, "Scale Speed Validation Lower Limit", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 7:24:46 PM")
    AddProperty("11252", "Scale_Speed_Override_FPM", <a><![CDATA[Scale_Speed_Override_FPM]]></a>.Value, "Scale Speed Override (Feet Per Minute)  This override allows you to choose your own speed to see what happens, but it can't exceed the speed of the sorter.", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 7:21:26 PM")
    AddProperty("11376", "Scale_Speed_Upper_Limit", <a><![CDATA[Scale_Speed_Upper_Limit]]></a>.Value, "Scale Speed Validation Upper Limit", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/24/2025 7:25:20 PM")
    AddProperty("11210", "Scanner_Configuration_Name", <a><![CDATA[Scanner_Configuration_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 7:00:21 PM")
    AddProperty("11234", "Scanner_Data_Transmit_Mode", <a><![CDATA[Scanner_Data_Transmit_Mode]]></a>.Value, "Scanner Data Transmit Mode", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 7:41:13 PM")
    AddProperty("11248", "Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN", <a><![CDATA[Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN]]></a>.Value, "Scanner Min. Xmit Point Downstream of Scan Window", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/23/2025 7:31:15 PM")
    AddProperty("11224", "ShadowingPotential", <a><![CDATA[ShadowingPotential]]></a>.Value, "Shadowing Issues Possible?  Shadowing is possible in 4 and 5 sided applications. If no shadowing is allowed, minimum gap requirement will increase and ma", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 9:28:40 PM")
    AddProperty("11225", "ShadowingStatus", <a><![CDATA[Shadowing Status]]></a>.Value, "Shadowing Allowed?", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/22/2025 7:22:33 PM")
    AddProperty("11226", "Sorter_Selected_Width_IN", <a><![CDATA[Sorter_Selected_Width_IN]]></a>.Value, "Master Sorter Width (From Sortation Object)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 7:31:12 PM")
    AddProperty("11255", "Spacing_Type_Required", <a><![CDATA[Spacing_Type_Required]]></a>.Value, "Spacing Type Required", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 10:18:48 PM")
    AddProperty("11260", "Speed_Ratio_Theoretic_Reqd_for_BlowThru", <a><![CDATA[Speed_Ratio_Theoretic_Reqd_for_BlowThru]]></a>.Value, "Theoretical Speed Ratio Req. for Blow-Thru", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 10:51:46 PM")
    AddProperty("11243", "Tracking_Photocell_Dist_From_Scanner_Xmit_Pnt_IN", <a><![CDATA[Tracking_Photocell_Dist_From_Scanner_Xmit_Pnt_IN]]></a>.Value, "Tracking Photocell Distance From Scanner Xmit Point  Allowable range is 2 inches to 2/3 of Minimum Carton Length.", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/22/2025 9:38:43 PM")
    AddProperty("11227", "Valid", <a><![CDATA[Valid]]></a>.Value, "Are Plastic Totes Used?", "Boolean","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/22/2025 7:20:43 PM")
    AddProperty("11228", "Valid_Message", <a><![CDATA[Valid_Message]]></a>.Value, "Customer Name (From Salesforce ePRD If Available)", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/22/2025 7:20:43 PM")
    AddProperty("11011", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/21/2025 3:55:52 PM")
    
      AddValidValue("Carton_Alignment_on_Belt_Curve")
    
      AddValidValue("Induction_Routing_Method")
    
      AddValidValue("Induction_Scale_Type")
    
      AddValidValue("Scanner_Configuration_Name")
    
      AddValidValue("Scanner_Data_Transmit_Mode")
    
      AddValidValue("ShadowingStatus")
    
      AddValidValue("Sorter_Selected_Width_IN")
    
      oConnection = AddConnection("My_Belt_Turn", <a><![CDATA[My_Belt_Turn]]></a>.Value, "Connection to Related Belt Turn Information", "246", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/24/2025 3:11:57 PM")
      
        oConnection.AddVPF(452, "CAE_APC_Belt_Turn")
      
      oConnection = AddConnection("My_PRD", <a><![CDATA[My PRD]]></a>.Value, "", "224", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "7/21/2025 3:55:52 PM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      
      oConnection = AddConnection("My_Scan_Belt", <a><![CDATA[My_Scan_Belt]]></a>.Value, "", "235", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/23/2025 10:38:39 PM")
      
        oConnection.AddVPF(451, "CAE_APC_Scan_Belt")
      
      oConnection = AddConnection("My_Scanner_Configurations", <a><![CDATA[My_Scanner_Configurations]]></a>.Value, "Connection to All Scan Confgurations", "227", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "7/22/2025 5:47:34 PM")
      
        oConnection.AddVPF(120, "APC_Sortation")
      
      oConnection = AddConnection("My_Selected_Scanner_Configuration", <a><![CDATA[My_Selected_Scanner_Configuration]]></a>.Value, "Connection to the Selected Scan Configuration", "228", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/22/2025 7:05:51 PM")
      
        oConnection.AddVPF(417, "APC_Scan_Configuration")
      
      oConnection = AddConnection("My_Setup", <a><![CDATA[My_Setup]]></a>.Value, "My App Calc Setup Object", "225", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/21/2025 3:55:52 PM")
      
        oConnection.AddVPF(119, "APC_Setup")
      
      oConnection = AddConnection("My_Sortation", <a><![CDATA[My_Sortation]]></a>.Value, "Connection to My Sortation Object", "229", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/22/2025 10:05:07 PM")
      
        oConnection.AddVPF(442, "CAE_APC_Sortation")
      
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Sub Initialize_Process(ByVal lngProcessID as Integer) Implements RuleStream.IRsPartFormulas.InitializeProcess
    Select Case lngProcessID
    
      Case 57
      Process = "DefaultProcess"	
        Initialize_Process_DefaultProcess_Step_1()
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
        Private Sub Initialize_Process_DefaultProcess_Step_1()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(117, "Step 1", "This process step was created automatically by RuleStream.", 1, 57, 1, 1, 50, 50)
        oProcessStep.AddPath("CAE_APC_Induction")
        oProcessStep.AddFilter(1, 448, "System", 0, "PartNumber", 0)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 448, "1", "0", "RsGroupBox", 0, "", 31, 519, 480, 510, 0, "Scale Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "2", "1", "RsTextbox", 0, "Rate_Theoretic_Max_w_Active_Gapping_Avg_Len_CPM", 442, 338, 22, 156, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "3", "1", "RsTextbox", 0, "Scale_Speed_Final_FPM", 131, 338, 22, 156, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "4", "1", "RsTextbox", 0, "Rate_Theoretic_Max_BlowThru_at_Avg_Length_CPM", 416, 338, 22, 156, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "5", "1", "RsLabel", 0, "", 77, 32, 22, 300, 4, "Scale Bed Length:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "6", "1", "RsTextbox", 0, "Scale_Speed_Override_FPM", 103, 338, 22, 156, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "7", "1", "RsTextbox", 0, "Spacing_Type_Required", 159, 338, 22, 156, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "8", "1", "RsCheckbox", 0, "Induction_Scale_Exists", 19, 338, 14, 25, 7, "", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "9", "1", "RsLabel", 0, "", 418, 32, 22, 300, 8, "Max Theoretical Blow-Thru Rate @ Avg Length (CPM):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "10", "1", "RsTextbox", 0, "Gap_Scan_Application_Min_IN", 187, 338, 22, 156, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "11", "1", "RsLabel", 0, "", 105, 32, 22, 300, 10, "Scale Speed Override (FPM):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "12", "1", "RsComboBox", 0, "Induction_Scale_Type", 47, 338, 22, 156, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "13", "1", "RsTextbox", 0, "Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN", 351, 338, 22, 156, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "14", "1", "RsComboBox", 0, "", 241, 338, 22, 156, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "15", "1", "RsLabel", 0, "", 327, 32, 22, 300, 14, "Min. Gap on Avg. Box (Inches - for Active Gapping Only):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "16", "1", "RsLabel", 0, "", 353, 32, 22, 300, 15, "Scanner Min. Xmit Point Downstream of Scan Window :", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "17", "1", "RsTextbox", 0, "Head_to_Head_Min_IN", 213, 338, 22, 156, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "18", "1", "RsTextbox", 0, "Gap_Min_on_Box_Size_IN", 297, 338, 22, 156, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "19", "1", "RsTextbox", 0, "Gap_Min_on_Avg_Box_Size_IN", 325, 338, 22, 156, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "20", "1", "RsLabel", 0, "", 243, 32, 22, 300, 19, "(Missing???)", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "21", "1", "RsLabel", 0, "", 49, 32, 22, 300, 20, "Scale Type:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "22", "1", "RsTextbox", 0, "Speed_Ratio_Theoretic_Reqd_for_BlowThru", 388, 338, 22, 156, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "23", "1", "RsLabel", 0, "", 390, 32, 22, 300, 22, "Theoretical Speed Ratio Req. for Blow-Thru:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "24", "1", "RsLabel", 0, "", 21, 32, 22, 300, 23, "Induction Scaled Present:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "25", "1", "RsLabel", 0, "", 299, 32, 22, 300, 24, "Min. Gap on Min. Box (Inches - for Passive Gapping Only):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "26", "1", "RsLabel", 0, "", 444, 6, 22, 326, 25, "Max Theoretical Rate With Active Gapping @ Avg Length (CPM):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "27", "1", "RsTextbox", 0, "Carton_Length_Scanned_Max_Pcnt", 269, 338, 22, 156, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "28", "1", "RsLabel", 0, "", 189, 32, 22, 300, 27, "Scale Gap Override (Multi-Stage Scales Only):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "29", "1", "RsLabel", 0, "", 215, 32, 22, 300, 28, "Min. Head-to-Head (Inches):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "30", "1", "RsTextbox", 0, "Scale_Bed_Length_IN", 75, 338, 22, 156, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "31", "1", "RsLabel", 0, "", 133, 32, 22, 300, 30, "Scale Speed :", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "32", "1", "RsLabel", 0, "", 161, 32, 22, 300, 31, "Type of Spacing Required:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "33", "1", "RsLabel", 0, "", 271, 32, 22, 300, 32, "% of Maximum Carton Length Scanned (L.E. Xmit Mode Only):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "34", "0", "RsGroupBox", 0, "", 31, 21, 390, 492, 33, "Carton Scanning Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "35", "34", "RsTextbox", 0, "Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN", 351, 312, 22, 156, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "36", "34", "RsComboBox", 0, "Scanner_Configuration_Name", 19, 312, 22, 156, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "37", "34", "RsTextbox", 0, "Carton_Panels_Scanned_Qty", 47, 312, 22, 156, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "38", "34", "RsComboBox", 0, "Scanner_Data_Transmit_Mode", 241, 312, 22, 156, 37, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "39", "34", "RsLabel", 0, "", 213, 74, 22, 232, 38, "Scan Window Length Required (Linear Inches):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "40", "34", "RsLabel", 0, "", 325, 24, 22, 282, 39, "Maximum Linear Length of Carton Scanned:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "41", "34", "RsLabel", 0, "", 351, 24, 22, 282, 40, "Scanner Min. Xmit Point Downstream of Scan Window :", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "42", "34", "RsTextbox", 0, "Carton_Maximum_Linear_Length_Scanned_In", 325, 312, 22, 156, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "43", "34", "RsLabel", 0, "", 131, 190, 22, 116, 42, "Shadowing Potential :", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "44", "34", "RsLabel", 0, "", 19, 92, 22, 214, 43, "Select Pre-defined Scanner Configuration :", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "45", "34", "RsLabel", 0, "", 47, 112, 22, 194, 44, "Number of Carton Panels Scanned:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "46", "34", "RsCheckbox", 0, "ShadowingPotential", 131, 312, 14, 25, 45, "", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "47", "34", "RsTextbox", 0, "ReadWindowSize_IN", 213, 312, 22, 156, 46, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "48", "34", "RsLabel", 0, "", 241, 112, 22, 194, 47, "Scanner Data Transmit Mode:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "49", "34", "RsTextbox", 0, "Label_Orientation", 75, 312, 22, 156, 48, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "50", "34", "RsTextbox", 0, "Gap_Min_on_Avg_Box_Size_IN", 187, 312, 22, 156, 49, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "51", "34", "RsLabel", 0, "", 75, 190, 22, 116, 50, "Label Orientation :", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "52", "34", "RsTextbox", 0, "Tracking_Photocell_Dist_From_Scanner_Xmit_Pnt_IN", 297, 312, 22, 156, 51, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "53", "34", "RsLabel", 0, "", 103, 190, 22, 116, 52, "Carton Presentation:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "54", "34", "RsTextbox", 0, "Carton_Presentation", 103, 312, 22, 156, 53, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "55", "34", "RsLabel", 0, "", 297, 24, 22, 282, 54, "Tracking Photocell Distance From Scanner Xmit Point:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "56", "34", "RsLabel", 0, "", 269, 6, 21, 300, 55, "% of Maximum Carton Length Scanned (L.E. Xmit Mode Only):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "57", "34", "RsTextbox", 0, "ShadowingStatus", 159, 312, 22, 156, 56, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "58", "34", "RsTextbox", 0, "Carton_Length_Scanned_Max_Pcnt", 269, 312, 22, 156, 57, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "59", "34", "RsLabel", 0, "", 159, 190, 22, 116, 58, "Shadowing Allowed:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "60", "34", "RsLabel", 0, "", 187, 112, 22, 194, 59, "Minimum Gap for this Scan Application:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "61", "0", "RsGroupBox", 0, "", 430, 21, 104, 492, 60, "Carton Routing Details", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "62", "61", "RsLabel", 0, "", 19, 92, 22, 214, 61, "Induction Routing Method?", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "63", "61", "RsComboBox", 0, "Induction_Routing_Method", 19, 312, 22, 156, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "64", "61", "RsLabel", 0, "", 47, 112, 22, 194, 63, "Max Host Resp.Time (Secs):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "65", "61", "RsTextbox", 0, "Host_Response_Max_Time_Sec", 47, 312, 22, 156, 64, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "66", "61", "RsTextbox", 0, "Local_LookupTime_Max_Sec", 75, 312, 22, 156, 65, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "67", "61", "RsLabel", 0, "", 75, 148, 22, 158, 66, "Max. Local LookupTime (Secs):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "68", "0", "RsGroupBox", 0, "", 540, 21, 268, 492, 67, "Conveyor Requirements", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "69", "68", "RsLabel", 0, "", 234, 24, 22, 282, 68, "Max. Allowable Carton Length:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "70", "68", "RsComboBox", 0, "Carton_Alignment_on_Belt_Curve", 68, 312, 22, 156, 69, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "71", "68", "RsTextbox", 0, "Belt_Curve_Centerline_Radius_IN", 150, 312, 22, 156, 70, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "72", "68", "RsLabel", 0, "", 150, 74, 22, 232, 71, "Centerline Radius of Belt Curve:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "73", "68", "RsLabel", 0, "", 68, 112, 22, 194, 72, "Carton Alignment on Belt Curve?", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "74", "68", "RsLabel", 0, "", 46, 92, 22, 214, 73, "Induction Belt Curve Exist?:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "75", "68", "RsCheckbox", 0, "Induction_Belt_Curve_Exists", 46, 312, 14, 25, 74, "", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "76", "68", "RsTextbox", 0, "Gap_Scan_Application_Min_IN", 124, 312, 22, 156, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "77", "68", "RsTextbox", 0, "Carton_Length_Max_Allowable_IN", 234, 312, 22, 156, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "78", "68", "RsTextbox", 0, "Resulting_Centerline_Speed_of_Curve_FPM", 206, 312, 22, 156, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "79", "68", "RsLabel", 0, "", 19, 112, 22, 194, 78, "Estimated Induct Belt Length Required:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "80", "68", "RsLabel", 0, "", 206, 24, 22, 282, 79, "Resulting Centerline Speed of Curve:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "81", "68", "RsTextbox", 0, "Radius_Value_Used_for_Speed_Match_IN", 178, 312, 22, 156, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "82", "68", "RsTextbox", 0, "Induct_Belt_Length_Reqd_Estimated_IN", 19, 312, 22, 156, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "83", "68", "RsLabel", 0, "", 96, 112, 22, 194, 82, "Min. Inside Radius for Belt Curve:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "84", "68", "RsLabel", 0, "", 178, 6, 21, 300, 83, "Radius Value Used for Speed Match:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "85", "68", "RsTextbox", 0, "Belt_Curve_Inside_Radius_Min_IN", 96, 312, 22, 156, 84, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "86", "68", "RsLabel", 0, "", 124, 112, 22, 194, 85, "Minimum Gap for this Scan Application:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "87", "0", "RsLabel", 0, "", 0, 27, 22, 524, 86, "Induction", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 448, "88", "0", "RsGroupBox", 0, "ShadowingPotential", 523, 519, 285, 512, 87, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 448, "89", "88", "RsTextbox", 0, "Valid_Message", 36, 13, 237, 481, 88, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 448, "90", "88", "RsCheckbox", 0, "Valid", 12, 415, 18, 54, 89, "Valid", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        
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
          InitProperty("Belt_Curve_Centerline_Radius_IN", "10820", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 3:18:39 PM", "", "In Development",  0,21625)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Belt_Curve_Inside_Radius_Min_IN", "10819", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 3:13:36 PM", "", "In Development",  1,21620)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_2_3rd_Length_Min_IN", "10794", "2", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 9:37:48 PM", "", "In Development",  0,21088)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_Alignment_on_Belt_Curve", "10818", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/23/2025 8:11:51 PM", "", "In Development",  0,21399)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_Length_Max_Allowable_IN", "10859", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 3:53:16 PM", "", "In Development",  0,21657)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_Length_Scanned_Max_Pcnt", "10792", "25", "100", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 9:30:14 PM", "", "In Development",  0,21076)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_Maximum_Linear_Length_Scanned_In", "10795", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/23/2025 8:08:53 PM", "", "In Development",  0,21094)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_Panels_Scanned_Qty", "10767", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 7:08:38 PM", "", "In Development",  0,20985)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Carton_Presentation", "10769", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 7:31:02 PM", "", "In Development",  0,21010)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Chosen_Sort_Speed_FPM", "10803", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 10:05:56 PM", "", "In Development",  0,21114)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Min_on_Avg_Box_Size_IN", "10809", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 10:52:22 PM", "", "In Development",  0,21137)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Min_on_Box_Size_IN", "10808", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 10:47:54 PM", "", "In Development",  0,21136)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Scan_Application_Min_IN", "10570", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 5:20:14 PM", "", "In Development",  0,20960)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Head_to_Head_Min_IN", "10806", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 10:36:38 PM", "", "In Development",  0,21128)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Host_Response_Max_Time_Sec", "10814", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 11:04:43 PM", "", "In Development",  0,21160)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Induct_Belt_Length_Reqd_Estimated_IN", "10816", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/23/2025 10:41:07 PM", "", "In Development",  0,21422)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Induction_Belt_Curve_Exists", "10817", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 11:11:16 PM", "", "In Development",  0,21170)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Induction_Routing_Method", "10813", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/22/2025 11:03:09 PM", "", "In Development",  0,21157)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Induction_Scale_Exists", "10799", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 9:49:10 PM", "", "In Development",  0,21099)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Induction_Scale_Type", "10800", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/22/2025 9:54:04 PM", "", "In Development",  0,21106)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Label_Orientation", "10768", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 7:12:36 PM", "", "In Development",  0,20989)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Local_LookupTime_Max_Sec", "10815", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 11:06:56 PM", "", "In Development",  0,21164)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MaxBoxHeightWidthDim", "10564", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 7:32:02 PM", "", "In Development",  0,20495)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MinGapRequired_User", "10770", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 7:20:43 PM", "Min. Gap Required for Scanner Application  (mm)", "In Development",  0,20992)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Radius_Value_Used_for_Speed_Match_IN", "10821", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 3:36:41 PM", "", "In Development",  0,21644)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Rate_Theoretic_Max_BlowThru_at_Avg_Length_CPM", "10811", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 10:53:27 PM", "", "In Development",  0,21143)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Rate_Theoretic_Max_w_Active_Gapping_Avg_Len_CPM", "10812", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 10:57:27 PM", "", "In Development",  0,21147)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ReadWindowSize_IN", "10771", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 7:24:33 PM", "Estimated Scanner Read Window Size (Inch)", "In Development",  0,21009)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ReadWindowSize_MM", "10772", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 7:23:54 PM", "Estimated Scanner Read Window Size (mm)", "In Development",  0,21008)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ReadWindowSize_USER", "10773", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 7:23:17 PM", "Estimated Scanner Read Window Size (User UOM)", "In Development",  0,21007)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Resulting_Centerline_Speed_of_Curve_FPM", "10822", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 3:39:52 PM", "", "In Development",  0,21654)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scale_Bed_Length_IN", "10801", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 9:58:23 PM", "", "In Development",  0,21109)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scale_Gap_Multi_Stage_Override_IN", "10807", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 7:53:35 PM", "", "In Development",  0,21744)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scale_Speed_Final_FPM", "10804", "Scale_Speed_Lower_Limit", "Scale_Speed_Upper_Limit", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 7:22:01 PM", "", "In Development",  0,21118)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scale_Speed_Lower_Limit", "10920", "60", "1000", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 7:24:46 PM", "", "In Development",  0,21729)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scale_Speed_Override_FPM", "10802", "Scale_Speed_Lower_Limit", "Scale_Speed_Upper_Limit", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 7:21:17 PM", "", "In Development",  0,21115)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scale_Speed_Upper_Limit", "10921", "60", "1000", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/24/2025 7:25:15 PM", "", "In Development",  0,21731)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scanner_Configuration_Name", "10760", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 6:56:49 PM", "", "In Development",  0,20969)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scanner_Data_Transmit_Mode", "10784", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/22/2025 7:41:04 PM", "", "In Development",  0,21028)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN", "10798", "2", "Carton_2_3rd_Length_Min_IN", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/23/2025 7:31:15 PM", "", "In Development",  0,21381)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ShadowingPotential", "10774", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 7:22:53 PM", "Shadowing Issues Possible?", "In Development",  0,21006)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ShadowingStatus", "10775", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/22/2025 7:22:33 PM", "Carton Presentation?", "In Development",  0,21004)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sorter_Selected_Width_IN", "10776", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/22/2025 7:31:12 PM", "", "In Development",  0,20999)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Spacing_Type_Required", "10805", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 10:18:48 PM", "", "In Development",  0,21121)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_Ratio_Theoretic_Reqd_for_BlowThru", "10810", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 10:51:46 PM", "", "In Development",  0,21140)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Tracking_Photocell_Dist_From_Scanner_Xmit_Pnt_IN", "10793", "2", "Carton_2_3rd_Length_Min_IN", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 9:38:43 PM", "", "In Development",  0,21089)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Valid", "10777", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 7:20:43 PM", "Are Plastic Totes Used?", "In Development",  0,21001)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Valid_Message", "10778", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/22/2025 7:20:43 PM", "Customer Name (From Salesforce ePRD If Available)", "In Development",  0,21002)
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
          
        InitValidValue("Carton_Alignment_on_Belt_Curve_ValidValues", "10818", "-1", 21401)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Induction_Routing_Method_ValidValues", "10813", "-1", 21153)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Induction_Scale_Type_ValidValues", "10800", "-1", 21107)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Scanner_Configuration_Name_ValidValues", "10760", "-1", 20981)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Scanner_Data_Transmit_Mode_ValidValues", "10784", "-1", 21030)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ShadowingStatus_ValidValues", "10775", "-1", 20998)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Sorter_Selected_Width_IN_ValidValues", "10776", "-1", 21000)
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
          
        InitConnection("My_Belt_Turn", "225", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/24/2025 3:11:44 PM", "", "In Development", "N",394)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_PRD", "203", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/21/2025 3:55:52 PM", "", "In Development", "N",359)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Scan_Belt", "214", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/23/2025 10:38:39 PM", "", "In Development", "N",382)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Scanner_Configurations", "206", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/22/2025 5:47:13 PM", "", "In Development", "N",366)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Selected_Scanner_Configuration", "207", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/22/2025 7:05:37 PM", "", "In Development", "N",375)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Setup", "204", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/21/2025 3:55:52 PM", "", "In Development", "N",360)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Sortation", "208", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/22/2025 10:04:26 PM", "", "In Development", "N",376)
        
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
      Public Function Formula_My_Belt_Turn_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:225; TYPE:PF
        Result = Me.Parent.Belt_Turn(1)
        '   END FORMULA; CON ID:225; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_My_Belt_Turn_PARTS", ex.Message)
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
        '   BEGIN FORMULA; CON ID:203; TYPE:PF
        Result = Me.Parent.My_Prd(1)
        '   END FORMULA; CON ID:203; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_My_PRD_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Scan_Belt_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:214; TYPE:PF
        Result = Me.Parent.Scan_Belt(1)
        '   END FORMULA; CON ID:214; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_My_Scan_Belt_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Scanner_Configurations_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:206; TYPE:PF
        Result = Me.Parent.Scan_Configurations
        '   END FORMULA; CON ID:206; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_My_Scanner_Configurations_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Selected_Scanner_Configuration_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:207; TYPE:PF
        Result = New rsCollection
For Each p As part In Me.My_Scanner_Configurations
	If P.properties("Configuration_Name").value.ToUpper().Trim() = Me.Scanner_Configuration_Name.ToUpper().Trim() Then
		Result.Add(p)
	End If
Next p
        '   END FORMULA; CON ID:207; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_My_Selected_Scanner_Configuration_PARTS", ex.Message)
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
        '   BEGIN FORMULA; CON ID:204; TYPE:PF
        Result = Me.Parent.My_Setup(1)
        '   END FORMULA; CON ID:204; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_My_Setup_PARTS", ex.Message)
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
        '   BEGIN FORMULA; CON ID:208; TYPE:PF
        Result = Me.Parent.Sortation(1)
        '   END FORMULA; CON ID:208; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_My_Sortation_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Step_1_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:117; TYPE:ST
      result = STATUS_ENABLED
      '   END FORMULA; PROC ID:117; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Process_DefaultProcess_Step_1_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Step_1_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:117; TYPE:CO
      result = ""
      '   END FORMULA; PROC ID:117; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Process_DefaultProcess_Step_1_COMMENT", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10820; TYPE:PF
      '=IF(F54="YES",BTCenterRadius,"")
Result = 0
Result = If(Me.Induction_Belt_Curve_Exists,Me.My_Belt_Turn(1).Belt_Curve_Centerline_Radius_IN,0)
      '   END FORMULA; PROP ID:10820; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Belt_Curve_Centerline_Radius_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Belt_Curve_Inside_Radius_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Belt_Curve_Inside_Radius_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10819; TYPE:PF
      Result = 0
'If(Me.Induction_Belt_Curve_Exists,BTInsideRadius,0)
Result =If(Me.Induction_Belt_Curve_Exists,Me.My_Belt_Turn(1).Belt_Curve_Inside_Radius_IN,0)
      '   END FORMULA; PROP ID:10819; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Belt_Curve_Inside_Radius_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_2_3rd_Length_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_2_3rd_Length_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10794; TYPE:PF
      Result = Me.My_Setup(1).BoxSize_Length_Min_IN / 3 * 2
      '   END FORMULA; PROP ID:10794; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Carton_2_3rd_Length_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_Alignment_on_Belt_Curve() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Alignment_on_Belt_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10818; TYPE:PF
      'Todo: MPC Implement
Result = ""

If Induction_Belt_Curve_Exists Then
	Result = "Please Select"
End If
      '   END FORMULA; PROP ID:10818; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Carton_Alignment_on_Belt_Curve", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_Length_Max_Allowable_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Length_Max_Allowable_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10859; TYPE:PF
      Result = 0
'=If(F54="YES",BTMaxBoxLength,"")
Result = If(Me.Induction_Belt_Curve_Exists,Me.My_Belt_Turn(1).Carton_Length_Allowable_Max_IN,0)
      '   END FORMULA; PROP ID:10859; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Carton_Length_Max_Allowable_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_Length_Scanned_Max_Pcnt() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Length_Scanned_Max_Pcnt").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10792; TYPE:PF
      Result = 100
      '   END FORMULA; PROP ID:10792; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Carton_Length_Scanned_Max_Pcnt", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_Maximum_Linear_Length_Scanned_In() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Maximum_Linear_Length_Scanned_In").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10795; TYPE:PF
      '=IF(F29="Lead Edge",BoxSize_Length_Max_IN*F30,BoxSize_Length_Max_IN)
Result  =If( Me.Scanner_Data_Transmit_Mode = "Lead Edge",Me.My_Setup(1).BoxSize_Length_Max_IN * (Me.Carton_Length_Scanned_Max_Pcnt /100), Me.My_Setup(1).BoxSize_Length_Max_IN)
      '   END FORMULA; PROP ID:10795; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Carton_Maximum_Linear_Length_Scanned_In", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_Panels_Scanned_Qty() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Panels_Scanned_Qty").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10767; TYPE:PF
      Result = me.My_Selected_Scanner_Configuration(1).BoxPanelsScanned
      '   END FORMULA; PROP ID:10767; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Carton_Panels_Scanned_Qty", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Carton_Presentation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Presentation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10769; TYPE:PF
      Result = Me.My_Selected_Scanner_Configuration(1).CartonPresentation
      '   END FORMULA; PROP ID:10769; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Carton_Presentation", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10803; TYPE:PF
      Result = Me.My_Sortation(1).Chosen_Sort_Speed_FPM
      '   END FORMULA; PROP ID:10803; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Chosen_Sort_Speed_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gap_Min_on_Avg_Box_Size_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Min_on_Avg_Box_Size_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10809; TYPE:PF
      Result = 0
'Todo: MPC Implement
 '=If(ScalePresent="Yes",If($F$36="Single Stage",F42-BoxSize_Length_Avg,If($F$41="",18,$F$41)),"")
			
	'=IF(ScalePresent="Yes",IF($F$36="Single Stage",F42-BoxSize_Length_Avg,IF($F$41="",18,$F$41)),"")
      '   END FORMULA; PROP ID:10809; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Gap_Min_on_Avg_Box_Size_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gap_Min_on_Box_Size_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Min_on_Box_Size_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10808; TYPE:PF
      Result = 0

'=IF(ScalePresent="Yes",IF($F$36="Single Stage",F42-MinBoxLength,IF($F$41="",18,$F$41)),"")
Result = If(Me.Induction_Scale_Exists,If(Me.Induction_Scale_Type="Single Stage",Me.Head_to_Head_Min_IN - Me.My_Setup(1).BoxSize_BoxLength_Min_In,If(Me.Scale_Gap_Multi_Stage_Override_IN=0,18,Me.Scale_Gap_Multi_Stage_Override_IN)),0)
      '   END FORMULA; PROP ID:10808; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Gap_Min_on_Box_Size_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gap_Scan_Application_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Scan_Application_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10570; TYPE:PF
      'Todo: MPC Fix  Link to Induction
Result = 0.0

'TODO:  MPC Fix This 
Result =30 ' Default Value for Testing.
      '   END FORMULA; PROP ID:10570; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Gap_Scan_Application_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Head_to_Head_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Head_to_Head_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10806; TYPE:PF
      Result = 0
If Me.Induction_Scale_Exists Then
	'=IF(ScalePresent="Yes",IF(F36="Single Stage",F37+2.5,IF($F$41="",18+MinBoxLength,$F$41+MinBoxLength)),"")
	Result =If(Me.Induction_Scale_Exists,If(Me.Induction_Scale_Type = "Single Stage" ,	Me.Scale_Bed_Length_IN +2.5 , If(Me.Scale_Gap_Multi_Stage_Override_IN =0, 18+ Me.My_Setup(1).BoxSize_Length_Min_IN ,Me.Scale_Gap_Multi_Stage_Override_IN  + Me.My_Setup(1).BoxSize_Length_Min_IN )),"")
End If
      '   END FORMULA; PROP ID:10806; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Head_to_Head_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Host_Response_Max_Time_Sec() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Host_Response_Max_Time_Sec").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10814; TYPE:PF
      'Todo: MPC Implement Dependent on Real Time Host

Result = 0
      '   END FORMULA; PROP ID:10814; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Host_Response_Max_Time_Sec", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Induct_Belt_Length_Reqd_Estimated_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Induct_Belt_Length_Reqd_Estimated_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10816; TYPE:PF
      Result = Me.My_Scan_Belt(1).Belt_Total_Length_Required_IN
      '   END FORMULA; PROP ID:10816; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Induct_Belt_Length_Reqd_Estimated_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Induction_Belt_Curve_Exists() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Induction_Belt_Curve_Exists").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10817; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:10817; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Induction_Belt_Curve_Exists", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Induction_Routing_Method() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Induction_Routing_Method").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10813; TYPE:PF
      'Todo: MPC TEST
Result = "Please Select"
      '   END FORMULA; PROP ID:10813; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Induction_Routing_Method", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Induction_Scale_Exists() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Induction_Scale_Exists").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10799; TYPE:PF
      Result = False
      '   END FORMULA; PROP ID:10799; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Induction_Scale_Exists", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Induction_Scale_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Induction_Scale_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10800; TYPE:PF
      If Me.Induction_Scale_Exists Then
	Result = "Please Select"
Else
	Result = ""
End If
      '   END FORMULA; PROP ID:10800; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Induction_Scale_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Label_Orientation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Label_Orientation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10768; TYPE:PF
      Result = Me.My_Selected_Scanner_Configuration(1).AppType
      '   END FORMULA; PROP ID:10768; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Label_Orientation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Local_LookupTime_Max_Sec() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Local_LookupTime_Max_Sec").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10815; TYPE:PF
      'Todo: MPC Implement Dependent on Local

Result = 0
      '   END FORMULA; PROP ID:10815; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Local_LookupTime_Max_Sec", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MaxBoxHeightWidthDim() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MaxBoxHeightWidthDim").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10564; TYPE:PF
      result = 0.0
Result = MAX( Me.My_Setup(1).BoxSize_Height_Max_IN, Me.My_Setup(1).BoxSize_Width_Max_IN)
      '   END FORMULA; PROP ID:10564; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_MaxBoxHeightWidthDim", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MinGapRequired_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MinGapRequired_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10770; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:10770; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_MinGapRequired_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Radius_Value_Used_for_Speed_Match_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Radius_Value_Used_for_Speed_Match_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10821; TYPE:PF
      Result = 0

'=IF(F54="YES",BTMatchRadius,"")
Result = If(Me.Induction_Belt_Curve_Exists,Me.My_Belt_Turn(1).Speed_Match_Radius_Value_IN,0)
      '   END FORMULA; PROP ID:10821; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Radius_Value_Used_for_Speed_Match_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Rate_Theoretic_Max_BlowThru_at_Avg_Length_CPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Rate_Theoretic_Max_BlowThru_at_Avg_Length_CPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10811; TYPE:PF
      Result = 0
'Todo: MPC Implement
'=IF(AND(ScalePresent="Yes",Sortation!H50="Passive"),$F$42/MinBoxLength,"")
'=IF(AND(ScalePresent="Yes",Sortation!H50="Passive"),$F$42/MinBoxLength,"")
      '   END FORMULA; PROP ID:10811; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Rate_Theoretic_Max_BlowThru_at_Avg_Length_CPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Rate_Theoretic_Max_w_Active_Gapping_Avg_Len_CPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Rate_Theoretic_Max_w_Active_Gapping_Avg_Len_CPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10812; TYPE:PF
      Result = 0
'Todo: MPC Implement
'=If(And(ScalePresent="Yes",Sortation!H50="Active"),If(F36="Single Stage",12*ScaleSpeed/(ScaleBedLength+2.5),12*ScaleSpeed/(BoxSize_Length_Avg+F43)),"")
      '   END FORMULA; PROP ID:10812; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Rate_Theoretic_Max_w_Active_Gapping_Avg_Len_CPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ReadWindowSize_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ReadWindowSize_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10771; TYPE:PF
      Result = Me.My_Selected_Scanner_Configuration(1).ReadWindowSize_IN
      '   END FORMULA; PROP ID:10771; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_ReadWindowSize_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ReadWindowSize_MM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ReadWindowSize_MM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10772; TYPE:PF
      Result = Me.My_Selected_Scanner_Configuration(1).ReadWindowSize_MM
      '   END FORMULA; PROP ID:10772; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_ReadWindowSize_MM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ReadWindowSize_USER() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ReadWindowSize_USER").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10773; TYPE:PF
      Result = Me.My_Selected_Scanner_Configuration(1).ReadWindowSize_USER
      '   END FORMULA; PROP ID:10773; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_ReadWindowSize_USER", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Resulting_Centerline_Speed_of_Curve_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Resulting_Centerline_Speed_of_Curve_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10822; TYPE:PF
      Result = 0
'=IF(F54="YES",BTCenterSpeed,"")
Result = If(Me.Induction_Belt_Curve_Exists,Me.My_Belt_Turn(1).Speed_Belt_Curve_at_Centerline_FPM,0)
      '   END FORMULA; PROP ID:10822; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Resulting_Centerline_Speed_of_Curve_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scale_Bed_Length_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scale_Bed_Length_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10801; TYPE:PF
      Result = 0
If Me.Induction_Scale_Exists Then
	Result = 0
End If
      '   END FORMULA; PROP ID:10801; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scale_Bed_Length_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scale_Gap_Multi_Stage_Override_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scale_Gap_Multi_Stage_Override_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10807; TYPE:PF
      Result = 0
If Me.Induction_Scale_Exists And Me.Induction_Scale_Type = "Multi-Stage" Then
	Result = 0
End If
      '   END FORMULA; PROP ID:10807; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scale_Gap_Multi_Stage_Override_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scale_Speed_Final_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scale_Speed_Final_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10804; TYPE:PF
      Result = 0
If Me.Induction_Scale_Exists Then
	'=IF(AND(F38<=ChosenSortSpeed,F38>0),F38,ChosenSortSpeed)
	Result = If(XlsAnd(Me.Scale_Speed_Override_FPM <= Me.Chosen_Sort_Speed_FPM,Me.Scale_Speed_Override_FPM>0),Me.Scale_Speed_Override_FPM,Me.Chosen_Sort_Speed_FPM)
End If
      '   END FORMULA; PROP ID:10804; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scale_Speed_Final_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scale_Speed_Lower_Limit() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scale_Speed_Lower_Limit").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10920; TYPE:PF
      Result = 0
If Me.Induction_Scale_Exists Then
	Result = 60
End If
      '   END FORMULA; PROP ID:10920; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scale_Speed_Lower_Limit", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scale_Speed_Override_FPM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scale_Speed_Override_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10802; TYPE:PF
      Result = 0
If Me.Induction_Scale_Exists Then
	Result = Me.Chosen_Sort_Speed_FPM
End If
      '   END FORMULA; PROP ID:10802; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scale_Speed_Override_FPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scale_Speed_Upper_Limit() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scale_Speed_Upper_Limit").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10921; TYPE:PF
      Result = 0
If Me.Induction_Scale_Exists Then
	Result = Me.Chosen_Sort_Speed_FPM
End If
      '   END FORMULA; PROP ID:10921; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scale_Speed_Upper_Limit", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scanner_Configuration_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scanner_Configuration_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10760; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:10760; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scanner_Configuration_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scanner_Data_Transmit_Mode() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scanner_Data_Transmit_Mode").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10784; TYPE:PF
      Result = "Please Select"
      '   END FORMULA; PROP ID:10784; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scanner_Data_Transmit_Mode", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10798; TYPE:PF
      '=IF(F29="Trail Edge",4,F32+4)
Result  =If( Me.Scanner_Data_Transmit_Mode = "Trail Edge",4,Me.Carton_Maximum_Linear_Length_Scanned_In + 4)
      '   END FORMULA; PROP ID:10798; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ShadowingPotential() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ShadowingPotential").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10774; TYPE:PF
      Result = Me.My_Selected_Scanner_Configuration(1).ShadowingPotential
      '   END FORMULA; PROP ID:10774; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_ShadowingPotential", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ShadowingStatus() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ShadowingStatus").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10775; TYPE:PF
      Result = Me.My_Selected_Scanner_Configuration(1).ShadowingStatus
      '   END FORMULA; PROP ID:10775; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_ShadowingStatus", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10776; TYPE:PF
      Result = Me.Parent.Sortation(1).Sorter_Selected_Width_IN
      '   END FORMULA; PROP ID:10776; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Sorter_Selected_Width_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Spacing_Type_Required() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Spacing_Type_Required").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10805; TYPE:PF
      '=IF(F36="Single Stage","Head-to-Head","Tail-to-Head")
Result = ""
If Me.Induction_Scale_Exists Then
	Result =If(Me.Induction_Scale_Type = "Single Stage","Head-to-Head","Tail-to-Head")
End If
      '   END FORMULA; PROP ID:10805; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Spacing_Type_Required", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_Ratio_Theoretic_Reqd_for_BlowThru() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_Ratio_Theoretic_Reqd_for_BlowThru").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10810; TYPE:PF
      Result = 0
'Todo: MPC Implement
'=IF(AND(ScalePresent="Yes",Sortation!H50="Passive"),$F$42/MinBoxLength,"")
'=IF(AND(ScalePresent="Yes",Sortation!H50="Passive"),$F$42/MinBoxLength,"")
      '   END FORMULA; PROP ID:10810; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Speed_Ratio_Theoretic_Reqd_for_BlowThru", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Tracking_Photocell_Dist_From_Scanner_Xmit_Pnt_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Tracking_Photocell_Dist_From_Scanner_Xmit_Pnt_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10793; TYPE:PF
      Result = 2
      '   END FORMULA; PROP ID:10793; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Tracking_Photocell_Dist_From_Scanner_Xmit_Pnt_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10777; TYPE:PF
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
      '   END FORMULA; PROP ID:10777; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Valid", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10778; TYPE:PF
      Result = ""

' !!!Attention !!! : This will need to be broken from subscription and implemented specically for the Part Family in Scope

'Error Levels 
'	0 = Info
'	1 = Warning
'	2 = Error
'	3 = Critical (Critical Means Nothing beyond associated process step should be allowed until this is fixed

Dim Show_Errors_Level As Integer = 2 ' Set to Error
Dim Source As String = Me.Name ' Set To Current Property's name, Override If neccessary for more detailed source log info
Dim EList As New Custom.HWErrorList

'Add Error Evaluations in this section

 EList.Add(0, "Warning Message", "ERR000", Source)
 EList.Add(1, "Warning Message", "ERR001", Source)
 EList.Add(2, "Errror Message", "ERR002", Source)
 EList.Add(3, "Critcal Message", "ERR003", Source)

 
EList.Add(3, "Critical, Not Impleented - Warnings and Errors Need Implemented", "ERR003", Me.Name)

Result = EList.ErrorSummary(Show_Errors_Level)
      '   END FORMULA; PROP ID:10778; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Valid_Message", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      Public Function Formula_Belt_Curve_Inside_Radius_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_2_3rd_Length_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Alignment_on_Belt_Curve_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Length_Max_Allowable_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Length_Scanned_Max_Pcnt_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Maximum_Linear_Length_Scanned_In_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Panels_Scanned_Qty_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Presentation_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Gap_Min_on_Avg_Box_Size_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Min_on_Box_Size_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Scan_Application_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Head_to_Head_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Host_Response_Max_Time_Sec_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induct_Belt_Length_Reqd_Estimated_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induction_Belt_Curve_Exists_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induction_Routing_Method_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induction_Scale_Exists_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induction_Scale_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Label_Orientation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Local_LookupTime_Max_Sec_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MaxBoxHeightWidthDim_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MinGapRequired_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Radius_Value_Used_for_Speed_Match_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Rate_Theoretic_Max_BlowThru_at_Avg_Length_CPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Rate_Theoretic_Max_w_Active_Gapping_Avg_Len_CPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ReadWindowSize_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ReadWindowSize_MM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ReadWindowSize_USER_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Resulting_Centerline_Speed_of_Curve_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scale_Bed_Length_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scale_Gap_Multi_Stage_Override_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scale_Speed_Final_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scale_Speed_Lower_Limit_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scale_Speed_Override_FPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scale_Speed_Upper_Limit_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Configuration_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Data_Transmit_Mode_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShadowingPotential_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShadowingStatus_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Spacing_Type_Required_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Ratio_Theoretic_Reqd_for_BlowThru_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Tracking_Photocell_Dist_From_Scanner_Xmit_Pnt_IN_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Belt_Curve_Centerline_Radius_IN_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Belt_Curve_Centerline_Radius_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10820; TYPE:UC
              'Todo: MPC Implement
Result = False
              '   END FORMULA; PROP ID:10820; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Belt_Curve_Centerline_Radius_IN_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belt_Curve_Inside_Radius_Min_IN_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Belt_Curve_Inside_Radius_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10819; TYPE:UC
              'Todo: MPC Implement
Result = False
If Me. Induction_Belt_Curve_Exists Then
	Result = True
End If
              '   END FORMULA; PROP ID:10819; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Belt_Curve_Inside_Radius_Min_IN_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_2_3rd_Length_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Alignment_on_Belt_Curve_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Carton_Alignment_on_Belt_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10818; TYPE:UC
              Result = False
If Induction_Belt_Curve_Exists Then
	Result = True
End If
              '   END FORMULA; PROP ID:10818; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Carton_Alignment_on_Belt_Curve_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Length_Max_Allowable_IN_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Carton_Length_Max_Allowable_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10859; TYPE:UC
              'Todo: MPC Implement
Result = False
              '   END FORMULA; PROP ID:10859; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Carton_Length_Max_Allowable_IN_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Length_Scanned_Max_Pcnt_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Maximum_Linear_Length_Scanned_In_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Panels_Scanned_Qty_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Carton_Presentation_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chosen_Sort_Speed_FPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Min_on_Avg_Box_Size_IN_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Gap_Min_on_Avg_Box_Size_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10809; TYPE:UC
              Result = False
              '   END FORMULA; PROP ID:10809; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Gap_Min_on_Avg_Box_Size_IN_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Min_on_Box_Size_IN_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Gap_Min_on_Box_Size_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10808; TYPE:UC
              Result = False
If Me.Induction_Scale_Exists And Me.Induction_Scale_Type = "Multi-Stage" Then Result = True
              '   END FORMULA; PROP ID:10808; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Gap_Min_on_Box_Size_IN_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Gap_Scan_Application_Min_IN_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Head_to_Head_Min_IN_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Head_to_Head_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10806; TYPE:UC
              Result = False
If Me.Induction_Scale_Exists Then
	Result = True
End If
              '   END FORMULA; PROP ID:10806; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Head_to_Head_Min_IN_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Host_Response_Max_Time_Sec_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Host_Response_Max_Time_Sec").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10814; TYPE:UC
              'Todo: MPC Implement ' Dependent on Real Time Host
Result = False
              '   END FORMULA; PROP ID:10814; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Host_Response_Max_Time_Sec_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induct_Belt_Length_Reqd_Estimated_IN_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Induct_Belt_Length_Reqd_Estimated_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10816; TYPE:UC
              'Todo: MPC Implement
Result = False
              '   END FORMULA; PROP ID:10816; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Induct_Belt_Length_Reqd_Estimated_IN_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induction_Belt_Curve_Exists_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induction_Routing_Method_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induction_Scale_Exists_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induction_Scale_Type_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Induction_Scale_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10800; TYPE:UC
              Result = False
If Me.Induction_Scale_Exists Then
	Result = True
End If
              '   END FORMULA; PROP ID:10800; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Induction_Scale_Type_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Label_Orientation_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Local_LookupTime_Max_Sec_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Local_LookupTime_Max_Sec").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10815; TYPE:UC
              'Todo: MPC Implement ' Dependent on Local
Result = False
              '   END FORMULA; PROP ID:10815; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Local_LookupTime_Max_Sec_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MaxBoxHeightWidthDim_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MinGapRequired_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Radius_Value_Used_for_Speed_Match_IN_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Radius_Value_Used_for_Speed_Match_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10821; TYPE:UC
              'Todo: MPC Implement
Result = False
              '   END FORMULA; PROP ID:10821; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Radius_Value_Used_for_Speed_Match_IN_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Rate_Theoretic_Max_BlowThru_at_Avg_Length_CPM_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Rate_Theoretic_Max_BlowThru_at_Avg_Length_CPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10811; TYPE:UC
              Result = False
              '   END FORMULA; PROP ID:10811; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Rate_Theoretic_Max_BlowThru_at_Avg_Length_CPM_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Rate_Theoretic_Max_w_Active_Gapping_Avg_Len_CPM_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Rate_Theoretic_Max_w_Active_Gapping_Avg_Len_CPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10812; TYPE:UC
              Result = False
              '   END FORMULA; PROP ID:10812; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Rate_Theoretic_Max_w_Active_Gapping_Avg_Len_CPM_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ReadWindowSize_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ReadWindowSize_MM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ReadWindowSize_USER_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Resulting_Centerline_Speed_of_Curve_FPM_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Resulting_Centerline_Speed_of_Curve_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10822; TYPE:UC
              'Todo: MPC Implement
Result = False
              '   END FORMULA; PROP ID:10822; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Resulting_Centerline_Speed_of_Curve_FPM_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scale_Bed_Length_IN_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Scale_Bed_Length_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10801; TYPE:UC
              Result = False
If Me.Induction_Scale_Exists Then
	Result = True
End If
              '   END FORMULA; PROP ID:10801; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scale_Bed_Length_IN_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scale_Gap_Multi_Stage_Override_IN_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Scale_Gap_Multi_Stage_Override_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10807; TYPE:UC
              Result = False
If Me.Induction_Scale_Exists And Me.Induction_Scale_Type = "Multi-Stage" Then Result = True
              '   END FORMULA; PROP ID:10807; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scale_Gap_Multi_Stage_Override_IN_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scale_Speed_Final_FPM_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Scale_Speed_Final_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10804; TYPE:UC
              Result = False
              '   END FORMULA; PROP ID:10804; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scale_Speed_Final_FPM_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scale_Speed_Lower_Limit_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Scale_Speed_Lower_Limit").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10920; TYPE:UC
              Result = False
              '   END FORMULA; PROP ID:10920; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scale_Speed_Lower_Limit_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scale_Speed_Override_FPM_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Scale_Speed_Override_FPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10802; TYPE:UC
              Result = False
If Me.Induction_Scale_Exists Then
	Result = True
End If
              '   END FORMULA; PROP ID:10802; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scale_Speed_Override_FPM_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scale_Speed_Upper_Limit_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Scale_Speed_Upper_Limit").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10921; TYPE:UC
              Result = False
              '   END FORMULA; PROP ID:10921; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scale_Speed_Upper_Limit_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Configuration_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Data_Transmit_Mode_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Min_Xmit_Point_Downstream_Scan_Window_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShadowingPotential_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShadowingStatus_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Selected_Width_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Spacing_Type_Required_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Ratio_Theoretic_Reqd_for_BlowThru_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("Speed_Ratio_Theoretic_Reqd_for_BlowThru").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:10810; TYPE:UC
              Result = False
              '   END FORMULA; PROP ID:10810; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Speed_Ratio_Theoretic_Reqd_for_BlowThru_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Tracking_Photocell_Dist_From_Scanner_Xmit_Pnt_IN_USERCHANGE() as Boolean
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
      Public Function Formula_Carton_Alignment_on_Belt_Curve_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Carton_Alignment_on_Belt_Curve").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10818; TYPE:VV
      'Todo: MPC Implement
If Induction_Belt_Curve_Exists Then
	Result = MakeValidValues(Array("Centered", "Inside","Outside","Random"))
Else
	Result = MakeValidValues(Array(""))
End If
      '   END FORMULA; PROP ID:10818; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Carton_Alignment_on_Belt_Curve_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induction_Routing_Method_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Induction_Routing_Method").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10813; TYPE:VV
      Result = MakeValidValues(Array("Real-Time Host Query", "Local Lookup"))
      '   END FORMULA; PROP ID:10813; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Induction_Routing_Method_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induction_Scale_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Induction_Scale_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10800; TYPE:VV
      Result = Nothing
If Me.Induction_Scale_Exists Then
	Result = MakeValidValues(Array("Single Stage", "Multi-Stage"))

End If
      '   END FORMULA; PROP ID:10800; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Induction_Scale_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Configuration_Name_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scanner_Configuration_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10760; TYPE:VV
      Result = MakeValidValues(Array(""))

For Each p As part In Me.My_Scanner_Configurations
 Result.Add(p.Properties("Configuration_Name").Value)
Next p
      '   END FORMULA; PROP ID:10760; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scanner_Configuration_Name_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scanner_Data_Transmit_Mode_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Scanner_Data_Transmit_Mode").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10784; TYPE:VV
      Result = MakeValidValues(Array("Lead Edge", "Trail Edge"))
      '   END FORMULA; PROP ID:10784; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Scanner_Data_Transmit_Mode_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ShadowingStatus_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ShadowingStatus").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10775; TYPE:VV
      Result = MakeValidValues(Array("No", "Parial", "Full"))
      '   END FORMULA; PROP ID:10775; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_ShadowingStatus_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10776; TYPE:VV
      Result = MakeValidValues(Array(22, 28, 34, 38))
      '   END FORMULA; PROP ID:10776; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Induction.Formula_Sorter_Selected_Width_IN_ValidValues", ex.Message)
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

  