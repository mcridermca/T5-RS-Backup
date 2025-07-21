Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: CAE_Mech_Install_App
'$ GenerateDate: 07/21/2025 12:25:40

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

    Public Class [CAE_Mech_Install_App]
    
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

    Private this as CAE_Mech_Install_App = me

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
      Case "46"
      Select Case processStep
        Case "62"
        Result = Process_DefaultProcess_Import_COMMENT()
        
        Case "99"
        Result = Process_DefaultProcess_Metrics_Table_COMMENT()
        
        Case "102"
        Result = Process_DefaultProcess_Chutes_Test_COMMENT()
        
        Case "110"
        Result = Process_DefaultProcess_Chutes_Grid_test_COMMENT()
        
        Case "114"
        Result = Process_DefaultProcess_Conveyor_costing_COMMENT()
        End Select
        End Select
      
    Return Result
    End Function

    Public Function GetProcessStepStatus(ByVal processId As String, ByVal processStep As String) As Integer Implements RuleStream.IRsPartFormulas.GetProcessStepStatus
    Dim Result as Integer 'Long
    Select Case processId
      Case "46"
      Select Case processStep
        Case "62"
        Result = Process_DefaultProcess_Import_STATUS()
        
        Case "99"
        Result = Process_DefaultProcess_Metrics_Table_STATUS()
        
        Case "102"
        Result = Process_DefaultProcess_Chutes_Test_STATUS()
        
        Case "110"
        Result = Process_DefaultProcess_Chutes_Grid_test_STATUS()
        
        Case "114"
        Result = Process_DefaultProcess_Conveyor_costing_STATUS()
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
    
          Public Property [HCAD_Import_QuantityOfCPs]() As Long
      Get
      Return Properties("HCAD_Import_QuantityOfCPs").Value
      End Get
      Set(ByVal Value As Long)
      Properties("HCAD_Import_QuantityOfCPs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [HCAD_Import_RawData]() As String
      Get
      Return Properties("HCAD_Import_RawData").Value
      End Get
      Set(ByVal Value As String)
      Properties("HCAD_Import_RawData").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [AirPipingFactor]() As Double
      Get
      Return Properties("AirPipingFactor").Value
      End Get
      Set(ByVal Value As Double)
      Properties("AirPipingFactor").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Base_Option_Alternate_Name]() As String
      Get
      Return Properties("Base_Option_Alternate_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Base_Option_Alternate_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [bool_Unique_System_Name]() As Boolean
      Get
      Return Properties("bool_Unique_System_Name").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("bool_Unique_System_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CAE_Customer]() As String
      Get
      Return Properties("CAE_Customer").Value
      End Get
      Set(ByVal Value As String)
      Properties("CAE_Customer").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CAE_Customer_Location]() As String
      Get
      Return Properties("CAE_Customer_Location").Value
      End Get
      Set(ByVal Value As String)
      Properties("CAE_Customer_Location").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CAE_Customer_Project_Number]() As String
      Get
      Return Properties("CAE_Customer_Project_Number").Value
      End Get
      Set(ByVal Value As String)
      Properties("CAE_Customer_Project_Number").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CAE_Quote_Date]() As String
      Get
      Return Properties("CAE_Quote_Date").Value
      End Get
      Set(ByVal Value As String)
      Properties("CAE_Quote_Date").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Labor_Type]() As String
      Get
      Return Properties("PRD_Labor_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_Labor_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Weeks_Comm]() As Double
      Get
      Return Properties("PRD_Weeks_Comm").Value
      End Get
      Set(ByVal Value As Double)
      Properties("PRD_Weeks_Comm").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Weeks_Install]() As Double
      Get
      Return Properties("PRD_Weeks_Install").Value
      End Get
      Set(ByVal Value As Double)
      Properties("PRD_Weeks_Install").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Work_Week_HRS]() As Double
      Get
      Return Properties("PRD_Work_Week_HRS").Value
      End Get
      Set(ByVal Value As Double)
      Properties("PRD_Work_Week_HRS").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PRD_Work_Week_Type]() As String
      Get
      Return Properties("PRD_Work_Week_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("PRD_Work_Week_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Selection_Control_Panel]() As String
      Get
      Return Properties("Selection_Control_Panel").Value
      End Get
      Set(ByVal Value As String)
      Properties("Selection_Control_Panel").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Selection_Control_Panel_Delta]() As String
      Get
      Return Properties("Selection_Control_Panel_Delta").Value
      End Get
      Set(ByVal Value As String)
      Properties("Selection_Control_Panel_Delta").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Selection_System]() As String
      Get
      Return Properties("Selection_System").Value
      End Get
      Set(ByVal Value As String)
      Properties("Selection_System").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Selection_System_Delta]() As String
      Get
      Return Properties("Selection_System_Delta").Value
      End Get
      Set(ByVal Value As String)
      Properties("Selection_System_Delta").CalculatedValue = Value
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
    
          Public Property [HCAD_Import_FileNameAndPath]() As String
      Get
      Return Properties("HCAD_Import_FileNameAndPath").Value
      End Get
      Set(ByVal Value As String)
      Properties("HCAD_Import_FileNameAndPath").CalculatedValue = Value
      End Set
      End Property
    
      Public ReadOnly Property [Air_Piping]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Air_Piping")
      End Get
      End Property
    
      Public ReadOnly Property [Air_Piping_Delta]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Air_Piping_Delta")
      End Get
      End Property
    
      Public ReadOnly Property [Base_Options_Alternates]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Base_Options_Alternates")
      End Get
      End Property
    
      Public ReadOnly Property [Base_Options_Alternates_Delta]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Base_Options_Alternates_Delta")
      End Get
      End Property
    
      Public ReadOnly Property [Chutes]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Chutes")
      End Get
      End Property
    
      Public ReadOnly Property [Control_Panels]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Control_Panels")
      End Get
      End Property
    
      Public ReadOnly Property [Conveyor_Costing_Intelligrated_Suppor_Mech_Install]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Conveyor_Costing_Intelligrated_Suppor_Mech_Install")
      End Get
      End Property
    
      Public ReadOnly Property [Conveyor_Costing_SC_Mech_Install]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Conveyor_Costing_SC_Mech_Install")
      End Get
      End Property
    
      Public ReadOnly Property [Mech_Install_Metrics]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Mech_Install_Metrics")
      End Get
      End Property
    
      Public ReadOnly Property [Shuttle_Mech]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Shuttle_Mech")
      End Get
      End Property
    
      Public ReadOnly Property [Sourcing_Inputs_01]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Sourcing_Inputs_01")
      End Get
      End Property
    
      Public ReadOnly Property [Structures_Platforms]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Structures_Platforms")
      End Get
      End Property
    
      Public ReadOnly Property [TTCB_Costing_Mech]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("TTCB_Costing_Mech")
      End Get
      End Property
    
      Public ReadOnly Property [My_Air_Piping]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Air_Piping")
      End Get
      End Property
    
      Public ReadOnly Property [My_Air_Piping_2]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Air_Piping_2")
      End Get
      End Property
    
      Public ReadOnly Property [My_Air_Piping_Delta]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Air_Piping_Delta")
      End Get
      End Property
    
      Public ReadOnly Property [My_Base_Options_Alternates]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Base_Options_Alternates")
      End Get
      End Property
    
      Public ReadOnly Property [My_Base_Options_Alternates_2]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Base_Options_Alternates_2")
      End Get
      End Property
    
      Public ReadOnly Property [My_Base_Options_Alternates_Delta]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Base_Options_Alternates_Delta")
      End Get
      End Property
    
      Public ReadOnly Property [My_Chute]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Chute")
      End Get
      End Property
    
      Public ReadOnly Property [My_Conveyor_Intelligrated]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Conveyor_Intelligrated")
      End Get
      End Property
    
      Public ReadOnly Property [My_Conveyor_Sub_Contractor]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Conveyor_Sub_Contractor")
      End Get
      End Property
    
      Public ReadOnly Property [My_PRD]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_PRD")
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
    InitPart("CAE_Mech_Install_App", <a><![CDATA[CAE Mech Install App]]></a>.Value, 360, "APCTMP01",  "N", "N", True, True, "In Development", "", "C&E Mechanical Install Estimator App", "", "", "",  "GLOBAL\H617242", "07/21/2025 10:31:16")
    AddProperty("4540", "HCAD_Import_QuantityOfCPs", <a><![CDATA[HCAD_Import_Quantity Of CPs]]></a>.Value, "", "Long","","HCAD Pricing Sheet Import","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/19/2025 7:22:50 PM")
    AddProperty("4539", "HCAD_Import_RawData", <a><![CDATA[HCAD_Import_Raw Data]]></a>.Value, "", "String","","HCAD Pricing Sheet Import","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/18/2025 9:03:56 PM")
    AddProperty("9513", "AirPipingFactor", <a><![CDATA[Air Piping Factor]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/8/2025 7:07:53 PM")
    AddProperty("6163", "Base_Option_Alternate_Name", <a><![CDATA[Base_Option_Alternate_Name]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/1/2025 12:08:29 PM")
    AddProperty("8091", "bool_Unique_System_Name", <a><![CDATA[bool_Unique_System_Name]]></a>.Value, "", "Boolean","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/2/2025 6:26:30 PM")
    AddProperty("9518", "CAE_Customer", <a><![CDATA[CAE_Customer]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 5:24:57 PM")
    AddProperty("9519", "CAE_Customer_Location", <a><![CDATA[CAE_Customer_Location]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 5:25:21 PM")
    AddProperty("9521", "CAE_Customer_Project_Number", <a><![CDATA[CAE_Customer_Project_Number]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 5:26:39 PM")
    AddProperty("9520", "CAE_Quote_Date", <a><![CDATA[CAE_Quote_Date]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/17/2025 11:42:09 AM")
    AddProperty("10675", "PRD_Labor_Type", <a><![CDATA[PRD_Labor_Type]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:46:55 PM")
    AddProperty("10672", "PRD_Weeks_Comm", <a><![CDATA[PRD_Weeks_Comm]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:55:42 PM")
    AddProperty("10673", "PRD_Weeks_Install", <a><![CDATA[PRD_Weeks_Install]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:55:35 PM")
    AddProperty("10671", "PRD_Work_Week_HRS", <a><![CDATA[PRD_Work_Week_HRS]]></a>.Value, "", "Double","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:45:54 PM")
    AddProperty("10674", "PRD_Work_Week_Type", <a><![CDATA[PRD_Work_Week_Type]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/18/2025 2:46:34 PM")
    AddProperty("9497", "Selection_Control_Panel", <a><![CDATA[Selection_Control_Panel]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/8/2025 4:51:10 PM")
    AddProperty("9511", "Selection_Control_Panel_Delta", <a><![CDATA[Selection_Control_Panel_Delta]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/8/2025 6:09:00 PM")
    AddProperty("8092", "Selection_System", <a><![CDATA[Selection_System]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/2/2025 7:10:05 PM")
    AddProperty("8093", "Selection_System_Delta", <a><![CDATA[Selection_System_Delta]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "7/2/2025 7:12:02 PM")
    AddProperty("5594", "Tool_Name", <a><![CDATA[Tool_Name]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 7:53:23 PM")
    AddProperty("5591", "Tool_Status", <a><![CDATA[Tool_Status]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/30/2025 11:43:58 AM")
    AddProperty("2482", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM")
    AddProperty("4538", "HCAD_Import_FileNameAndPath", <a><![CDATA[HCAD_Import_FileNameAndPath]]></a>.Value, "", "String","","UI Control","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/18/2025 8:10:38 PM")
    
      AddValidValue("AirPipingFactor")
    
      AddValidValue("PRD_Labor_Type")
    
      AddValidValue("PRD_Work_Week_Type")
    
      AddValidValue("Selection_Control_Panel")
    
      AddValidValue("Selection_Control_Panel_Delta")
    
      AddValidValue("Selection_System")
    
      AddValidValue("Selection_System_Delta")
    
      AddValidValue("Tool_Status")
    
      oSubpart = AddSubpart(312,"Air_Piping", <a><![CDATA[Air_Piping]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "7/10/2025 1:58:57 PM")
      
        oSubpart.AddVPF (392, "CAE_Air_Piping_Control_Panel", "CAE_Air_Piping_Control_Panel")
      
      oSubpart = AddSubpart(311,"Air_Piping_Delta", <a><![CDATA[Air_Piping_Delta]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "7/10/2025 4:18:00 PM")
      
        oSubpart.AddVPF (392, "CAE_Air_Piping_Control_Panel", "CAE_Air_Piping_Control_Panel")
      
      oSubpart = AddSubpart(285,"Base_Options_Alternates", <a><![CDATA[Base_Options_Alternates]]></a>.Value, "MN", "", "General", 9999, "", "GLOBAL\H602502", "7/2/2025 5:41:35 PM")
      
        oSubpart.AddVPF (399, "CAE_Mech_Install_CP_Comp", "CAE_Mech_Install_CP_Comp")
      
      oSubpart = AddSubpart(299,"Base_Options_Alternates_Delta", <a><![CDATA[Base_Options_Alternates_Delta]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "7/3/2025 6:19:35 PM")
      
        oSubpart.AddVPF (399, "CAE_Mech_Install_CP_Comp", "CAE_Mech_Install_CP_Comp")
      
      oSubpart = AddSubpart(307,"Chutes", <a><![CDATA[Chutes]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H582667", "7/17/2025 9:23:58 AM")
      
        oSubpart.AddVPF (409, "CAE_Chutes", "CAE_Chutes")
      
      oSubpart = AddSubpart(252,"Control_Panels", <a><![CDATA[Control_Panels]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H617242", "7/11/2025 10:54:29 AM")
      
        oSubpart.AddVPF (399, "CAE_Mech_Install_CP_Comp", "CAE_Mech_Install_CP_Comp")
      
      oSubpart = AddSubpart(308,"Conveyor_Costing_Intelligrated_Suppor_Mech_Install", <a><![CDATA[Conveyor_Costing_Intelligrated_Suppor_Mech_Install]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H617242", "7/21/2025 10:12:14 AM")
      
        oSubpart.AddVPF (389, "CAE_Conveyor_Costing", "CAE_Conveyor_Costing")
      
      oSubpart = AddSubpart(309,"Conveyor_Costing_SC_Mech_Install", <a><![CDATA[Conveyor_Costing_SC_Mech_Install]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H617242", "7/21/2025 10:11:32 AM")
      
        oSubpart.AddVPF (389, "CAE_Conveyor_Costing", "CAE_Conveyor_Costing")
      
      oSubpart = AddSubpart(261,"Mech_Install_Metrics", <a><![CDATA[Mech_Install_Metrics]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H617242", "7/18/2025 7:21:01 AM")
      
        oSubpart.AddVPF (382, "CAE_Mech_Install_Metrics", "CAE_Mech_Install_Metrics")
      
      oSubpart = AddSubpart(295,"Shuttle_Mech", <a><![CDATA[Shuttle_Mech]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "7/1/2025 5:54:02 PM")
      
        oSubpart.AddVPF (398, "CAE_Shuttle_Mech", "CAE_Shuttle_Mech")
      
      oSubpart = AddSubpart(346,"Sourcing_Inputs_01", <a><![CDATA[Sourcing_Inputs_01]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "7/17/2025 7:19:36 PM")
      
        oSubpart.AddVPF (432, "CAE_Sourcing_Inputs", "CAE_Sourcing_Inputs")
      
      oSubpart = AddSubpart(271,"Structures_Platforms", <a><![CDATA[Structures_Platforms]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "6/27/2025 11:52:19 AM")
      
        oSubpart.AddVPF (386, "CAE_Structures_Platforms", "CAE_Structures_Platforms")
      
      oSubpart = AddSubpart(296,"TTCB_Costing_Mech", <a><![CDATA[TTCB_Costing_Mech]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H582667", "7/16/2025 6:45:41 AM")
      
        oSubpart.AddVPF (401, "CAE_TTCB_Costing_Mech", "CAE_TTCB_Costing_Mech")
      
      oConnection = AddConnection("My_Air_Piping", <a><![CDATA[My_Air_Piping]]></a>.Value, "", "132", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/10/2025 2:00:07 PM")
      
        oConnection.AddVPF(392, "CAE_Air_Piping_Control_Panel")
      
      oConnection = AddConnection("My_Air_Piping_2", <a><![CDATA[My_Air_Piping_2]]></a>.Value, "", "134", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/10/2025 2:00:26 PM")
      
        oConnection.AddVPF(392, "CAE_Air_Piping_Control_Panel")
      
      oConnection = AddConnection("My_Air_Piping_Delta", <a><![CDATA[My_Air_Piping_Delta]]></a>.Value, "", "133", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/10/2025 4:20:04 PM")
      
        oConnection.AddVPF(392, "CAE_Air_Piping_Control_Panel")
      
      oConnection = AddConnection("My_Base_Options_Alternates", <a><![CDATA[My_Base_Options_Alternates]]></a>.Value, "", "119", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/3/2025 6:27:34 PM")
      
        oConnection.AddVPF(399, "CAE_Mech_Install_CP_Comp")
      
      oConnection = AddConnection("My_Base_Options_Alternates_2", <a><![CDATA[My_Base_Options_Alternates_2]]></a>.Value, "", "121", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/3/2025 6:27:26 PM")
      
        oConnection.AddVPF(399, "CAE_Mech_Install_CP_Comp")
      
      oConnection = AddConnection("My_Base_Options_Alternates_Delta", <a><![CDATA[My_Base_Options_Alternates_Delta]]></a>.Value, "", "120", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/3/2025 6:20:38 PM")
      
        oConnection.AddVPF(399, "CAE_Mech_Install_CP_Comp")
      
      oConnection = AddConnection("My_Chute", <a><![CDATA[My_Chute]]></a>.Value, "", "135", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/17/2025 4:43:37 PM")
      
        oConnection.AddVPF(409, "CAE_Chutes")
      
      oConnection = AddConnection("My_Conveyor_Intelligrated", <a><![CDATA[My_Conveyor_Intelligrated]]></a>.Value, "", "130", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/8/2025 4:31:10 PM")
      
        oConnection.AddVPF(389, "CAE_Conveyor_Costing")
      
      oConnection = AddConnection("My_Conveyor_Sub_Contractor", <a><![CDATA[My_Conveyor_Sub_Contractor]]></a>.Value, "", "129", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/8/2025 4:30:10 PM")
      
        oConnection.AddVPF(389, "CAE_Conveyor_Costing")
      
      oConnection = AddConnection("My_PRD", <a><![CDATA[My PRD]]></a>.Value, "Connection to this line item's PRD", "108", "OO", 0, "","General", 9999, "", "GLOBAL\H602502", "7/7/2025 3:54:17 PM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      oSpec = AddSpec("49","", 34, "HCAD_Import_File_Import", "", "GLOBAL\H602502", "2025-06-18T20:11:37.083", "HCAD_Import_File_Import")
      oSpec.Attributes.Add("Internal", "FileName", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 3)
      oSpec.Attributes.Add("Internal", "TempFileName", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 3)
      oSpec.Attributes.Add("MAP", "ENABLED", <a><![CDATA[True]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("MAP", "Unique_File_Name", <a><![CDATA[HCAD_Import_FileNameAndPath]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Sub Initialize_Process(ByVal lngProcessID as Integer) Implements RuleStream.IRsPartFormulas.InitializeProcess
    Select Case lngProcessID
    
      Case 46
      Process = "DefaultProcess"	
        Initialize_Process_DefaultProcess_Import()
        Initialize_Process_DefaultProcess_Metrics_Table()
        Initialize_Process_DefaultProcess_Chutes_Test()
        Initialize_Process_DefaultProcess_Chutes_Grid_test()
        Initialize_Process_DefaultProcess_Conveyor_costing()
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
        Private Sub Initialize_Process_DefaultProcess_Import()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(62, "Import", "This process step was created automatically by RuleStream.", 1, 46, 2, 1, 50, 50)
        oProcessStep.AddPath("CAE_Mech_Install_App")
        oProcessStep.AddFilter(1, 360, "System", 0, "PartNumber", 0)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_06E_Footage", 1)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_06E_Units", 2)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_06KEINRE_Footage", 3)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_06KEINRE_Units", 4)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_1_Footage", 5)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_1_Units", 6)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_180CRV_Footage", 7)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_180CRV_Units", 8)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_20MJDJ_Footage", 9)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_20MJDJ_Units", 10)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_30CRV_Footage", 11)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_30CRV_Units", 12)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_30MJDJ_Footage", 13)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_30MJDJ_Units", 14)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_30MJMJ_Footage", 15)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_30MJMJ_Units", 16)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_90CRV_Footage", 17)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_90CRV_Units", 18)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_90SCRV_Footage", 19)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_90SCRV_Units", 20)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_BMB_Footage", 21)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_BMB_Units", 22)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_MISC_Footage", 23)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_MISC_Units", 24)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_RB_Footage", 25)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_RB_Units", 26)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_SB_Footage", 27)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_SB_Units", 28)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_SCALE_Footage", 29)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_SCALE_Units", 30)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_SKEW_Footage", 31)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_SKEW_Units", 32)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_SpurCrvCombo_Footage", 33)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_SpurCrvCombo_Units", 34)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_StraightRoller_Footage", 35)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_StraightRoller_Units", 36)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_STRT_Footage", 37)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_STRT_Units", 38)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_x_Footage", 39)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Belt_x_Units", 40)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_06E_Footage", 41)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_06E_Units", 42)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_06KEINRE_Footage", 43)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_06KEINRE_Units", 44)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_1_Footage", 45)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_1_Units", 46)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_180CRV_Footage", 47)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_180CRV_Units", 48)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_20MJDJ_Footage", 49)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_20MJDJ_Units", 50)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_30CRV_Footage", 51)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_30CRV_Units", 52)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_30MJDJ_Footage", 53)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_30MJDJ_Units", 54)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_30MJMJ_Footage", 55)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_30MJMJ_Units", 56)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_90CRV_Footage", 57)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_90CRV_Units", 58)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_90SCRV_Footage", 59)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_90SCRV_Units", 60)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_BMB_Footage", 61)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_BMB_Units", 62)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_MISC_Footage", 63)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_MISC_Units", 64)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_RB_Footage", 65)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_RB_Units", 66)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_SB_Footage", 67)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_SB_Units", 68)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_SCALE_Footage", 69)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_SCALE_Units", 70)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_SKEW_Footage", 71)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_SKEW_Units", 72)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_SpurCrvCombo_Footage", 73)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_SpurCrvCombo_Units", 74)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_StraightRoller_Footage", 75)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_StraightRoller_Units", 76)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_STRT_Footage", 77)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_STRT_Units", 78)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_x_Footage", 79)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeBelt_x_Units", 80)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_06E_Footage", 81)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_06E_Units", 82)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_06KEINRE_Footage", 83)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_06KEINRE_Units", 84)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_1_Footage", 85)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_1_Units", 86)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_180CRV_Footage", 87)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_180CRV_Units", 88)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_20MJDJ_Footage", 89)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_20MJDJ_Units", 90)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_30CRV_Footage", 91)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_30CRV_Units", 92)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_30MJDJ_Footage", 93)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_30MJDJ_Units", 94)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_30MJMJ_Footage", 95)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_30MJMJ_Units", 96)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_90CRV_Footage", 97)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_90CRV_Units", 98)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_90SCRV_Footage", 99)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_90SCRV_Units", 100)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_BMB_Footage", 101)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_BMB_Units", 102)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_MISC_Footage", 103)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_MISC_Units", 104)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_RB_Footage", 105)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_RB_Units", 106)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_SB_Footage", 107)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_SB_Units", 108)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_SCALE_Footage", 109)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_SCALE_Units", 110)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_SKEW_Footage", 111)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_SKEW_Units", 112)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_SpurCrvCombo_Footage", 113)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_SpurCrvCombo_Units", 114)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_StraightRoller_Footage", 115)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_StraightRoller_Units", 116)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_STRT_Footage", 117)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_STRT_Units", 118)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_x_Footage", 119)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_BrakeMeter_x_Units", 120)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_06E_Footage", 121)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_06E_Units", 122)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_06KEINRE_Footage", 123)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_06KEINRE_Units", 124)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_1_Footage", 125)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_1_Units", 126)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_180CRV_Footage", 127)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_180CRV_Units", 128)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_20MJDJ_Footage", 129)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_20MJDJ_Units", 130)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_30CRV_Footage", 131)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_30CRV_Units", 132)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_30MJDJ_Footage", 133)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_30MJDJ_Units", 134)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_30MJMJ_Footage", 135)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_30MJMJ_Units", 136)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_90CRV_Footage", 137)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_90CRV_Units", 138)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_90SCRV_Footage", 139)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_90SCRV_Units", 140)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_BMB_Footage", 141)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_BMB_Units", 142)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_MISC_Footage", 143)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_MISC_Units", 144)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_RB_Footage", 145)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_RB_Units", 146)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_SB_Footage", 147)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_SB_Units", 148)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_SCALE_Footage", 149)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_SCALE_Units", 150)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_SKEW_Footage", 151)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_SKEW_Units", 152)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_SpurCrvCombo_Footage", 153)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_SpurCrvCombo_Units", 154)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_StraightRoller_Footage", 155)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_StraightRoller_Units", 156)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_STRT_Footage", 157)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_STRT_Units", 158)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_x_Footage", 159)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Gravity_x_Units", 160)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_06E_Footage", 161)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_06E_Units", 162)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_06KEINRE_Footage", 163)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_06KEINRE_Units", 164)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_1_Footage", 165)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_1_Units", 166)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_180CRV_Footage", 167)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_180CRV_Units", 168)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_20MJDJ_Footage", 169)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_20MJDJ_Units", 170)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_30CRV_Footage", 171)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_30CRV_Units", 172)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_30MJDJ_Footage", 173)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_30MJDJ_Units", 174)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_30MJMJ_Footage", 175)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_30MJMJ_Units", 176)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_90CRV_Footage", 177)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_90CRV_Units", 178)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_90SCRV_Footage", 179)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_90SCRV_Units", 180)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_BMB_Footage", 181)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_BMB_Units", 182)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_MISC_Footage", 183)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_MISC_Units", 184)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_RB_Footage", 185)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_RB_Units", 186)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_SB_Footage", 187)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_SB_Units", 188)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_SCALE_Footage", 189)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_SCALE_Units", 190)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_SKEW_Footage", 191)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_SKEW_Units", 192)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_SpurCrvCombo_Footage", 193)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_SpurCrvCombo_Units", 194)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_StraightRoller_Footage", 195)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_StraightRoller_Units", 196)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_STRT_Footage", 197)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_STRT_Units", 198)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_x_Footage", 199)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_Intellimerge_x_Units", 200)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_06E_Footage", 201)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_06E_Units", 202)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_06KEINRE_Footage", 203)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_06KEINRE_Units", 204)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_1_Footage", 205)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_1_Units", 206)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_180CRV_Footage", 207)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_180CRV_Units", 208)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_20MJDJ_Footage", 209)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_20MJDJ_Units", 210)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_30CRV_Footage", 211)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_30CRV_Units", 212)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_30MJDJ_Footage", 213)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_30MJDJ_Units", 214)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_30MJMJ_Footage", 215)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_30MJMJ_Units", 216)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_90CRV_Footage", 217)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_90CRV_Units", 218)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_90SCRV_Footage", 219)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_90SCRV_Units", 220)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_BMB_Footage", 221)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_BMB_Units", 222)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_MISC_Footage", 223)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_MISC_Units", 224)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_RB_Footage", 225)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_RB_Units", 226)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_SB_Footage", 227)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_SB_Units", 228)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_SCALE_Footage", 229)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_SCALE_Units", 230)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_SKEW_Footage", 231)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_SKEW_Units", 232)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_SpurCrvCombo_Fo", 233)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_SpurCrvCombo_Un", 234)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_StraightRoller_F", 235)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_StraightRoller_U", 236)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_STRT_Footage", 237)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_STRT_Units", 238)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_x_Footage", 239)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IntelliSortNextGen_x_Units", 240)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_06E_Footage", 241)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_06E_Units", 242)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_06KEINRE_Footage", 243)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_06KEINRE_Units", 244)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_1_Footage", 245)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_1_Units", 246)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_180CRV_Footage", 247)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_180CRV_Units", 248)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_20MJDJ_Footage", 249)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_20MJDJ_Units", 250)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_30CRV_Footage", 251)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_30CRV_Units", 252)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_30MJDJ_Footage", 253)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_30MJDJ_Units", 254)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_30MJMJ_Footage", 255)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_30MJMJ_Units", 256)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_90CRV_Footage", 257)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_90CRV_Units", 258)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_90SCRV_Footage", 259)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_90SCRV_Units", 260)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_BMB_Footage", 261)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_BMB_Units", 262)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_MISC_Footage", 263)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_MISC_Units", 264)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_RB_Footage", 265)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_RB_Units", 266)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_SB_Footage", 267)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_SB_Units", 268)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_SCALE_Footage", 269)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_SCALE_Units", 270)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_SKEW_Footage", 271)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_SKEW_Units", 272)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_SpurCrvCombo_Footage", 273)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_SpurCrvCombo_Units", 274)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_StraightRoller_Footage", 275)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_StraightRoller_Units", 276)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_STRT_Footage", 277)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_STRT_Units", 278)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_x_Footage", 279)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_IQZF_x_Units", 280)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_06E_Footage", 281)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_06E_Units", 282)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_06KEINRE_Footage", 283)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_06KEINRE_Units", 284)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_1_Footage", 285)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_1_Units", 286)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_180CRV_Footage", 287)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_180CRV_Units", 288)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_20MJDJ_Footage", 289)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_20MJDJ_Units", 290)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_30CRV_Footage", 291)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_30CRV_Units", 292)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_30MJDJ_Footage", 293)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_30MJDJ_Units", 294)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_30MJMJ_Footage", 295)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_30MJMJ_Units", 296)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_90CRV_Footage", 297)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_90CRV_Units", 298)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_90SCRV_Footage", 299)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_90SCRV_Units", 300)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_BMB_Footage", 301)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_BMB_Units", 302)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_MISC_Footage", 303)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_MISC_Units", 304)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_RB_Footage", 305)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_RB_Units", 306)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_SB_Footage", 307)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_SB_Units", 308)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_SCALE_Footage", 309)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_SCALE_Units", 310)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_SKEW_Footage", 311)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_SKEW_Units", 312)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_SpurCrvCombo_Footage", 313)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_SpurCrvCombo_Units", 314)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_StraightRoller_Footage", 315)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_StraightRoller_Units", 316)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_STRT_Footage", 317)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_STRT_Units", 318)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_x_Footage", 319)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_MISC_x_Units", 320)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_06E_Footage", 321)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_06E_Units", 322)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_06KEINRE_Footage", 323)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_06KEINRE_Units", 324)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_1_Footage", 325)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_1_Units", 326)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_180CRV_Footage", 327)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_180CRV_Units", 328)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_20MJDJ_Footage", 329)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_20MJDJ_Units", 330)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_30CRV_Footage", 331)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_30CRV_Units", 332)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_30MJDJ_Footage", 333)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_30MJDJ_Units", 334)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_30MJMJ_Footage", 335)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_30MJMJ_Units", 336)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_90CRV_Footage", 337)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_90CRV_Units", 338)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_90SCRV_Footage", 339)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_90SCRV_Units", 340)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_BMB_Footage", 341)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_BMB_Units", 342)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_MISC_Footage", 343)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_MISC_Units", 344)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_RB_Footage", 345)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_RB_Units", 346)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_SB_Footage", 347)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_SB_Units", 348)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_SCALE_Footage", 349)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_SCALE_Units", 350)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_SKEW_Footage", 351)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_SKEW_Units", 352)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_SpurCrvCombo_Footag", 353)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_SpurCrvCombo_Units", 354)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_StraightRoller_Foota", 355)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_StraightRoller_Units", 356)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_STRT_Footage", 357)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_STRT_Units", 358)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_x_Footage", 359)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_PowerBeltCurve_x_Units", 360)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_06E_Footage", 361)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_06E_Units", 362)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_06KEINRE_Footage", 363)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_06KEINRE_Units", 364)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_1_Footage", 365)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_1_Units", 366)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_180CRV_Footage", 367)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_180CRV_Units", 368)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_20MJDJ_Footage", 369)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_20MJDJ_Units", 370)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_30CRV_Footage", 371)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_30CRV_Units", 372)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_30MJDJ_Footage", 373)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_30MJDJ_Units", 374)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_30MJMJ_Footage", 375)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_30MJMJ_Units", 376)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_90CRV_Footage", 377)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_90CRV_Units", 378)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_90SCRV_Footage", 379)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_90SCRV_Units", 380)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_BMB_Footage", 381)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_BMB_Units", 382)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_MISC_Footage", 383)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_MISC_Units", 384)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_RB_Footage", 385)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_RB_Units", 386)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_SB_Footage", 387)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_SB_Units", 388)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_SCALE_Footage", 389)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_SCALE_Units", 390)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_SKEW_Footage", 391)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_SKEW_Units", 392)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_SpurCrvCombo_Footage", 393)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_SpurCrvCombo_Units", 394)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_StraightRoller_Footage", 395)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_StraightRoller_Units", 396)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_STRT_Footage", 397)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_STRT_Units", 398)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_x_Footage", 399)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_StagingBelt_x_Units", 400)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_06E_Footage", 401)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_06E_Units", 402)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_06KEINRE_Footage", 403)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_06KEINRE_Units", 404)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_1_Footage", 405)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_1_Units", 406)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_180CRV_Footage", 407)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_180CRV_Units", 408)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_20MJDJ_Footage", 409)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_20MJDJ_Units", 410)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_30CRV_Footage", 411)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_30CRV_Units", 412)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_30MJDJ_Footage", 413)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_30MJDJ_Units", 414)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_30MJMJ_Footage", 415)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_30MJMJ_Units", 416)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_90CRV_Footage", 417)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_90CRV_Units", 418)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_90SCRV_Footage", 419)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_90SCRV_Units", 420)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_BMB_Footage", 421)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_BMB_Units", 422)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_MISC_Footage", 423)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_MISC_Units", 424)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_RB_Footage", 425)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_RB_Units", 426)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_SB_Footage", 427)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_SB_Units", 428)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_SCALE_Footage", 429)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_SCALE_Units", 430)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_SKEW_Footage", 431)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_SKEW_Units", 432)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_SpurCrvCombo_Footage", 433)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_SpurCrvCombo_Units", 434)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_StraightRoller_Footage", 435)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_StraightRoller_Units", 436)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_STRT_Footage", 437)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_STRT_Units", 438)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_x_Footage", 439)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_VBelt_x_Units", 440)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_06E_Footage", 441)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_06E_Units", 442)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_06KEINRE_Footage", 443)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_06KEINRE_Units", 444)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_1_Footage", 445)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_1_Units", 446)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_180CRV_Footage", 447)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_180CRV_Units", 448)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_20MJDJ_Footage", 449)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_20MJDJ_Units", 450)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_30CRV_Footage", 451)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_30CRV_Units", 452)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_30MJDJ_Footage", 453)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_30MJDJ_Units", 454)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_30MJMJ_Footage", 455)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_30MJMJ_Units", 456)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_90CRV_Footage", 457)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_90CRV_Units", 458)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_90SCRV_Footage", 459)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_90SCRV_Units", 460)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_BMB_Footage", 461)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_BMB_Units", 462)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_MISC_Footage", 463)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_MISC_Units", 464)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_RB_Footage", 465)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_RB_Units", 466)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_SB_Footage", 467)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_SB_Units", 468)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_SCALE_Footage", 469)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_SCALE_Units", 470)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_SKEW_Footage", 471)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_SKEW_Units", 472)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_SpurCrvCombo_Footage", 473)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_SpurCrvCombo_Units", 474)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_StraightRoller_Footage", 475)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_StraightRoller_Units", 476)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_STRT_Footage", 477)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_STRT_Units", 478)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_x_Footage", 479)
        oProcessStep.AddFilter(2, 0, "HCAD Pricing Sheet Import", 1, "HCAD_Import_WheelDivert_x_Units", 480)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddLayout(2, 8, "1;Control_Panels")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsActionButton", 0, "", 243, 372, 27, 83, 0, "Import", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ImportHCADPricingSheetData;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 360, "2", "0", "RsFileImporter", 0, "", 219, 11, 51, 355, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;SpecName:HCAD_Import_File_Import")
        oProcessStep.AddCustomLayout(1, 360, "3", "0", "RsGrid", 0, "", 13, 635, 393, 580, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,252,Control_Panels;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 360, "4", "3", "RsGridColumn", 0, "DisplayName", 0, 0, 0, 150, 0, "Display Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 360, "5", "0", "RsAddDeleteCopy", 0, "", 416, 1004, 27, 211, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,252,Control_Panels;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 360, "6", "0", "RsPictureBox", 0, "", 0, 0, 191, 628, 4, "", 0, 0, 1, 5, 0, "", "", "Filename:Honeywell Intelligrated Logo.jpg;IsGeneratedImg:False;RsTooltip:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Metrics_Table()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(99, "Metrics Table", "", 101, 46, 1, 2, 50, 50)
        oProcessStep.AddPath("CAE_Mech_Install_App.Control_Panels/CAE_Mech_Install_CP_Comp")
        oProcessStep.AddPath("CAE_Mech_Install_App.Conveyor_Costing_SC_Mech_Install/CAE_Conveyor_Costing")
        oProcessStep.AddPath("CAE_Mech_Install_App.Mech_Install_Metrics/CAE_Mech_Install_Metrics")
        oProcessStep.AddPath("CAE_Mech_Install_App.Mech_Install_Metrics/CAE_Mech_Install_Metrics.Misc_Constants/CAE_Misc_Constant")
        oProcessStep.AddFilter(1, 0, "UI Inputs", 2, "Hours_Misc_Dollars", 1)
        oProcessStep.AddFilter(1, 0, "Mech Install Metrics", 1, "Misc_Description", 1)
        oProcessStep.AddFilter(1, 0, "Mech Install Metrics", 1, "Misc_Factor", 2)
        oProcessStep.AddLayout(1, 8, "0;Misc_Constants")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Chutes_Test()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(102, "Chutes_Test", "", 101, 46, 1, 3, 50, 50)
        oProcessStep.AddPath("CAE_Mech_Install_App.Chutes/CAE_Chutes")
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_1_Angle_hrs", 1)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_1_Angle_of_Curve", 2)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_1_Infeed_Conveyor_Type", 21)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_1_Infeed_hrs", 22)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_1_Length_hrs", 24)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_1_Length_in_Feet", 23)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_1_Material_hrs", 26)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_1_Merge_hrs", 27)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_1_Type_of_Material", 25)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_10_Angle_hrs", 3)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_10_Angle_of_Curve", 4)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_10_Infeed_Conveyor_Type", 28)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_10_Infeed_hrs", 29)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_10_Length_hrs", 31)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_10_Length_in_Feet", 30)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_10_Material_hrs", 33)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_10_Type_of_Material", 32)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_2_Angle_hrs", 5)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_2_Angle_of_Curve", 6)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_2_Infeed_Conveyor_Type", 34)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_2_Infeed_hrs", 35)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_2_Length_hrs", 37)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_2_Length_in_Feet", 36)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_2_Material_hrs", 39)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_2_Type_of_Material", 38)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_3_Angle_hrs", 8)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_3_Angle_of_Curve", 7)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_3_Infeed_Conveyor_Type", 40)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_3_Infeed_hrs", 41)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_3_Length_hrs", 43)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_3_Length_in_Feet", 42)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_3_Material_hrs", 45)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_3_Type_of_Material", 44)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_4_Angle_hrs", 10)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_4_Angle_of_Curve", 9)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_4_Infeed_Conveyor_Type", 46)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_4_Infeed_hrs", 47)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_4_Length_hrs", 49)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_4_Length_in_Feet", 48)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_4_Material_hrs", 51)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_4_Type_of_Material", 50)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_5_Angle_hrs", 12)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_5_Angle_of_Curve", 11)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_6_Angle_hrs", 14)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_6_Angle_of_Curve", 13)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_7_Angle_hrs", 16)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_7_Angle_of_Curve", 15)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_8_Angle_hrs", 18)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_8_Angle_of_Curve", 17)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_9_Angle_hrs", 20)
        oProcessStep.AddFilter(1, 409, "Mech Install", 1, "MEI_Chutes_Style_9_Angle_of_Curve", 19)
        oProcessStep.AddLayout(1, 1, "1;2;0")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Chutes_Grid_test()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(110, "Chutes_Grid_test", "", 101, 46, 1, 4, 50, 50)
        oProcessStep.AddPath("CAE_Mech_Install_App")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 360, "1", "0", "RsGrid", 0, "", 0, 0, 319, 697, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,307,Chutes;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 360, "2", "1", "RsGridColumn", 0, "MEI_Chutes_Style_1_Angle_of_Curve", 0, 0, 0, 100, 0, "Angle of Curve", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 360, "3", "1", "RsGridColumn", 0, "MEI_Chutes_Style_1_Length_in_Feet", 0, 0, 0, 100, 0, "Length in Feet", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 360, "4", "1", "RsGridColumn", 0, "MEI_Chutes_Style_1_Type_of_Material", 0, 0, 0, 100, 0, "Type of Material", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 360, "5", "1", "RsGridColumn", 0, "MEI_Chutes_Style_1_Infeed_Conveyor_Type", 0, 0, 0, 100, 0, "Infeed Conveyor Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 360, "6", "1", "RsGridColumn", 0, "MEI_Chutes_Style_1_Number_of_Merging_Lanes", 0, 0, 0, 100, 0, "Number of Merging Lanes", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 360, "7", "1", "RsGridColumn", 0, "MEI_Chutes_Style_1_Number_of_Sorting_Lanes", 0, 0, 0, 100, 0, "Number of Sorting Lanes", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 360, "8", "0", "RsAddDeleteCopy", 0, "", 325, 0, 22, 158, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,307,Chutes;CanDelete:;AddPrompt:False;ShowCopy:True")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Conveyor_costing()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(114, "Conveyor costing", "", 101, 46, 1, 5, 50, 50)
        oProcessStep.AddPath("CAE_Mech_Install_App.Conveyor_Costing_Intelligrated_Suppor_Mech_Install/CAE_Conveyor_Costing")
        oProcessStep.AddPath("CAE_Mech_Install_App.Conveyor_Costing_SC_Mech_Install/CAE_Conveyor_Costing")
        oProcessStep.AddFilter(1, 389, "Conveyor Costing", 1, "Project_Info_Customer", 1)
        oProcessStep.AddFilter(1, 389, "Conveyor Costing", 1, "Project_Info_Description", 2)
        oProcessStep.AddFilter(1, 389, "Conveyor Costing", 1, "Project_Info_Location", 3)
        oProcessStep.AddFilter(1, 389, "Conveyor Costing", 1, "Project_Info_Number", 4)
        oProcessStep.AddFilter(1, 389, "Conveyor Costing", 1, "Project_Info_QuoteDate", 5)
        oProcessStep.AddLayout(1, 1, "1;2;0")
        
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
          InitProperty("HCAD_Import_QuantityOfCPs", "4168", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/19/2025 7:22:50 PM", "", "In Development",  0,5813)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("HCAD_Import_RawData", "4167", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/18/2025 9:03:56 PM", "", "In Development",  0,5707)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("AirPipingFactor", "9093", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/8/2025 7:07:53 PM", "", "In Development",  0,15189)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Base_Option_Alternate_Name", "5769", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/1/2025 12:08:29 PM", "", "In Development",  0,9019)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("bool_Unique_System_Name", "7689", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/2/2025 6:26:30 PM", "", "In Development",  0,11953)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CAE_Customer", "9098", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 5:24:57 PM", "", "In Development",  0,18902)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CAE_Customer_Location", "9099", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 5:25:21 PM", "", "In Development",  0,18903)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CAE_Customer_Project_Number", "9101", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 5:26:39 PM", "", "In Development",  0,18904)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CAE_Quote_Date", "9100", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/17/2025 11:42:09 AM", "", "In Development",  0,18472)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Labor_Type", "10239", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:46:55 PM", "", "In Development",  0,19089)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Weeks_Comm", "10236", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:55:42 PM", "", "In Development",  0,19101)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Weeks_Install", "10237", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:55:35 PM", "", "In Development",  0,19100)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Work_Week_HRS", "10235", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:45:54 PM", "", "In Development",  0,19084)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PRD_Work_Week_Type", "10238", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/18/2025 2:46:34 PM", "", "In Development",  0,19087)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Selection_Control_Panel", "9077", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/8/2025 4:51:10 PM", "", "In Development",  0,15164)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Selection_Control_Panel_Delta", "9091", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/8/2025 6:09:00 PM", "", "In Development",  0,15185)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Selection_System", "7690", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/2/2025 7:10:05 PM", "", "In Development",  0,11957)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Selection_System_Delta", "7691", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "7/2/2025 7:12:02 PM", "", "In Development",  0,11959)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Tool_Name", "5206", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/27/2025 7:53:23 PM", "", "In Development",  0,8206)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Tool_Status", "5203", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "6/30/2025 11:43:58 AM", "", "In Development",  0,8827)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("HCAD_Import_FileNameAndPath", "4166", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/18/2025 8:10:38 PM", "", "In Development",  0,5706)
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
          
        InitValidValue("AirPipingFactor_ValidValues", "9093", "-1", 15190)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PRD_Labor_Type_ValidValues", "10239", "-1", 19090)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("PRD_Work_Week_Type_ValidValues", "10238", "-1", 19088)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Selection_Control_Panel_ValidValues", "9077", "-1", 15165)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Selection_Control_Panel_Delta_ValidValues", "9091", "-1", 15186)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Selection_System_ValidValues", "7690", "-1", 11958)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Selection_System_Delta_ValidValues", "7691", "-1", 11960)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Tool_Status_ValidValues", "5203", "-1", 8828)
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
          
        InitSubpart("Air_Piping", 239, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "7/10/2025 1:58:57 PM", "", "In Development", "N",0,645,697)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Air_Piping_Delta", 238, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "7/10/2025 4:18:00 PM", "", "In Development", "N",0,643,700)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Base_Options_Alternates_Delta", 226, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "7/3/2025 6:19:35 PM", "", "In Development", "N",0,610,609)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Chutes", 234, "", "", "Y", 0, "-1", "", "GLOBAL\H582667", "7/17/2025 9:23:58 AM", "", "In Development", "Y",0,633,748)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Control_Panels", 222, "", "", "Y", 0, "-1", "", "GLOBAL\H617242", "7/11/2025 10:54:29 AM", "", "In Development", "Y",0,602,705)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Conveyor_Costing_Intelligrated_Suppor_Mech_Install", 235, "", "", "Y", 0, "-1", "", "GLOBAL\H617242", "7/21/2025 10:11:48 AM", "", "In Development", "N",0,635,792)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Conveyor_Costing_SC_Mech_Install", 236, "", "", "Y", 0, "-1", "", "GLOBAL\H617242", "7/21/2025 10:11:32 AM", "", "In Development", "N",0,638,791)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Mech_Install_Metrics", 196, "", "", "Y", 0, "-1", "", "GLOBAL\H617242", "7/18/2025 7:21:01 AM", "", "In Development", "N",0,544,539)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Shuttle_Mech", 221, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "7/1/2025 5:54:02 PM", "", "In Development", "N",0,598,597)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Sourcing_Inputs_01", 273, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "7/17/2025 7:19:36 PM", "", "In Development", "N",0,757,756)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Structures_Platforms", 200, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "6/27/2025 11:52:19 AM", "", "In Development", "N",0,550,549)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("TTCB_Costing_Mech", 223, "", "", "Y", 0, "-1", "", "GLOBAL\H582667", "7/16/2025 6:45:41 AM", "", "In Development", "Y",0,604,619)
        
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
          
        InitConnection("My_Air_Piping", "112", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/10/2025 2:00:07 PM", "", "In Development", "N",226)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Air_Piping_2", "114", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/10/2025 2:00:24 PM", "", "In Development", "N",227)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Air_Piping_Delta", "113", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/10/2025 4:20:04 PM", "", "In Development", "N",229)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Base_Options_Alternates", "99", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/3/2025 6:27:34 PM", "", "In Development", "N",188)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Base_Options_Alternates_2", "101", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/3/2025 6:27:26 PM", "", "In Development", "N",187)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Base_Options_Alternates_Delta", "100", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/3/2025 6:20:38 PM", "", "In Development", "N",186)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Chute", "115", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/17/2025 4:43:37 PM", "", "In Development", "Y",326)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Conveyor_Intelligrated", "110", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/8/2025 4:31:10 PM", "", "In Development", "N",204)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Conveyor_Sub_Contractor", "109", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/8/2025 4:30:10 PM", "", "In Development", "N",203)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_PRD", "88", "","", "Y", 0, "-1", "", "GLOBAL\H602502", "7/7/2025 3:54:17 PM", "Connection to this line item's PRD", "In Development", "Y",191)
        
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
      Public Function Formula_My_Air_Piping_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:112; TYPE:PF
        Result = Nothing

Dim count As Integer = Me.Air_Piping.Quantity
Dim i As Integer = 1

While i <= count
	
	If me.Selection_System = Me.Air_Piping(i).DisplayName
		Result = Me.Air_Piping(i)
		Exit While
	End If
	
	i += 1
End While
        '   END FORMULA; CON ID:112; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_My_Air_Piping_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Air_Piping_2_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:114; TYPE:PF
        Result = Nothing

Dim count As Integer = Me.Air_Piping.Quantity
Dim i As Integer = 1

While i <= count
	
	If me.Selection_System_Delta = Me.Air_Piping(i).DisplayName
		Result = Me.Air_Piping(i)
		Exit While
	End If
	
	i += 1
End While
        '   END FORMULA; CON ID:114; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_My_Air_Piping_2_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Air_Piping_Delta_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:113; TYPE:PF
        Result = Me.Air_Piping_Delta(1)
        '   END FORMULA; CON ID:113; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_My_Air_Piping_Delta_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Base_Options_Alternates_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:99; TYPE:PF
        Result = Nothing

Dim count As Integer = Me.Base_Options_Alternates.Quantity
Dim i As Integer = 1

While i <= count
	
	If Me.Selection_System = Me.Base_Options_Alternates(i).DisplayName
		Result = Me.Base_Options_Alternates(i)
		Exit While
	End If
	
	i += 1
End While
        '   END FORMULA; CON ID:99; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_My_Base_Options_Alternates_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Base_Options_Alternates_2_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:101; TYPE:PF
        Result = Nothing

Dim count As Integer = Me.Base_Options_Alternates.Quantity
Dim i As Integer = 1

While i <= count
	
	If Me.Selection_System_Delta = Me.Base_Options_Alternates(i).DisplayName
		Result = Me.Base_Options_Alternates(i)
		Exit While
	End If
	
	i += 1
End While
        '   END FORMULA; CON ID:101; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_My_Base_Options_Alternates_2_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Base_Options_Alternates_Delta_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:100; TYPE:PF
        Result = Me.Base_Options_Alternates_Delta(1)
        '   END FORMULA; CON ID:100; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_My_Base_Options_Alternates_Delta_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Chute_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:115; TYPE:PF
        Result = Nothing

Dim count As Integer = Me.Chutes.Quantity
Dim i As Integer = 1

While i <= count
	
	If Me.Selection_System = Me.Chutes(i).DisplayName
		Result = Me.Chutes(i)
		Exit While
	End If
	
	i += 1
End While
        '   END FORMULA; CON ID:115; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_My_Chute_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Conveyor_Intelligrated_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:110; TYPE:PF
        Result = Nothing

Dim count As Integer = Me.Conveyor_Costing_Intelligrated_Suppor_Mech_Install.Quantity
Dim i As Integer = 1

While i <= count
	
	If Me.Selection_System = Me.Conveyor_Costing_Intelligrated_Suppor_Mech_Install(i).DisplayName
		Result = Me.Conveyor_Costing_Intelligrated_Suppor_Mech_Install(i)
		Exit While
	End If
	
	i += 1
End While
        '   END FORMULA; CON ID:110; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_My_Conveyor_Intelligrated_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_My_Conveyor_Sub_Contractor_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:109; TYPE:PF
        Result = Nothing

Dim count As Integer = Me.Conveyor_Costing_SC_Mech_Install.Quantity
Dim i As Integer = 1

While i <= count
	
	If Me.Selection_System = Me.Conveyor_Costing_SC_Mech_Install(i).DisplayName
		Result = Me.Conveyor_Costing_SC_Mech_Install(i)
		Exit While
	End If
	
	i += 1
End While
        '   END FORMULA; CON ID:109; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_My_Conveyor_Sub_Contractor_PARTS", ex.Message)
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
        '   BEGIN FORMULA; CON ID:88; TYPE:PF
        'Result = RootPart.Project_Information(1).Proposal_Information(1).PRD_Document(1)

Result = me.Parent.Parent
        '   END FORMULA; CON ID:88; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_My_PRD_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Import_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:62; TYPE:ST
      result = STATUS_ENABLED
      '   END FORMULA; PROC ID:62; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Process_DefaultProcess_Import_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Import_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:62; TYPE:CO
      result = ""
      '   END FORMULA; PROC ID:62; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Process_DefaultProcess_Import_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Metrics_Table_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:99; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN
      '   END FORMULA; PROC ID:99; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Process_DefaultProcess_Metrics_Table_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Metrics_Table_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:99; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:99; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Process_DefaultProcess_Metrics_Table_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Chutes_Test_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:102; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN
      '   END FORMULA; PROC ID:102; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Process_DefaultProcess_Chutes_Test_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Chutes_Test_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:102; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:102; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Process_DefaultProcess_Chutes_Test_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Chutes_Grid_test_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:110; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN
      '   END FORMULA; PROC ID:110; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Process_DefaultProcess_Chutes_Grid_test_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Chutes_Grid_test_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:110; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:110; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Process_DefaultProcess_Chutes_Grid_test_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Conveyor_costing_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:114; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

Result = STATUS_HIDDEN
      '   END FORMULA; PROC ID:114; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Process_DefaultProcess_Conveyor_costing_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Conveyor_costing_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:114; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:114; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Process_DefaultProcess_Conveyor_costing_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_HCAD_Import_QuantityOfCPs() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("HCAD_Import_QuantityOfCPs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4168; TYPE:PF
      Dim lst As String() = Me.HCAD_Import_RawData.Split("~")
Dim uniqueVals As New collection

For Each l As String In lst
	
	Dim vals As String() = l.Split(":")
	Dim found As Boolean = False
	
	For Each uniqueVal In uniqueVals
		
		If uniqueVal.Trim() = vals(0).Trim() Then
			found = True
			Exit For
		End If
		
	Next
	
	If Not found Then
		Result += 1
		uniqueVals.Add(vals(0))
	End If
	
Next

Result -= 1 '''Remove for extra delimited item at end of raw data string
      '   END FORMULA; PROP ID:4168; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_HCAD_Import_QuantityOfCPs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_HCAD_Import_RawData() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("HCAD_Import_RawData").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4167; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:4167; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_HCAD_Import_RawData", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_AirPipingFactor() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AirPipingFactor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9093; TYPE:PF
      Result = 0.5
      '   END FORMULA; PROP ID:9093; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_AirPipingFactor", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Base_Option_Alternate_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Base_Option_Alternate_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:5769; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:5769; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Base_Option_Alternate_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_bool_Unique_System_Name() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("bool_Unique_System_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:7689; TYPE:PF
      Result = True

For Each part As Part In Me.Base_Options_Alternates
	If Me.Base_Option_Alternate_Name = part.DisplayName
		Result = False
		Custom.RSMessage("", "System name is already in use")
		Exit For
	End If
Next

If Me.Base_Option_Alternate_Name = "" Then
	Result = False
End If
      '   END FORMULA; PROP ID:7689; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_bool_Unique_System_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CAE_Customer() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CAE_Customer").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9098; TYPE:PF
      Result = Me.My_PRD(1).Proposal_Customer_Name
      '   END FORMULA; PROP ID:9098; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_CAE_Customer", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CAE_Customer_Location() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CAE_Customer_Location").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9099; TYPE:PF
      Result = Me.My_PRD(1).Proposal_City_State
      '   END FORMULA; PROP ID:9099; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_CAE_Customer_Location", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CAE_Customer_Project_Number() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CAE_Customer_Project_Number").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9101; TYPE:PF
      Result = Me.My_PRD(1).Proposal_ID
      '   END FORMULA; PROP ID:9101; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_CAE_Customer_Project_Number", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CAE_Quote_Date() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CAE_Quote_Date").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9100; TYPE:PF
      Result = me.My_PRD(1).Proposal_Date
      '   END FORMULA; PROP ID:9100; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_CAE_Quote_Date", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Labor_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Labor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10239; TYPE:PF
      Result = "Non-Union"
      '   END FORMULA; PROP ID:10239; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_PRD_Labor_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Weeks_Comm() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Weeks_Comm").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10236; TYPE:PF
      Result = 0 '''ToDo - Build reference to PRD part family - TB 18 July, 2025
      '   END FORMULA; PROP ID:10236; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_PRD_Weeks_Comm", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Weeks_Install() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Weeks_Install").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10237; TYPE:PF
      Result = 0 '''ToDo - Build reference to PRD part family - TB 18 July, 2025
      '   END FORMULA; PROP ID:10237; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_PRD_Weeks_Install", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Work_Week_HRS() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Work_Week_HRS").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10235; TYPE:PF
      Result = 58
      '   END FORMULA; PROP ID:10235; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_PRD_Work_Week_HRS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PRD_Work_Week_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Work_Week_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10238; TYPE:PF
      Result = "1st Shift"
      '   END FORMULA; PROP ID:10238; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_PRD_Work_Week_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Selection_Control_Panel() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Selection_Control_Panel").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9077; TYPE:PF
      Select Case Me.Control_Panels.Quantity
	Case 0
		Result = "None"
	Case Else
		Result = Me.Control_Panels(1).DisplayName
End Select
      '   END FORMULA; PROP ID:9077; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Selection_Control_Panel", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Selection_Control_Panel_Delta() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Selection_Control_Panel_Delta").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9091; TYPE:PF
      Select Case Me.Control_Panels.Quantity
	Case 0
		Result = "None"
	Case Else
		Result = Me.Control_Panels(1).DisplayName
End Select
      '   END FORMULA; PROP ID:9091; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Selection_Control_Panel_Delta", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Selection_System() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Selection_System").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:7690; TYPE:PF
      Select Case Me.Base_Options_Alternates.Quantity
	Case 0
		Result = "None"
	Case Else
		Result = Me.Base_Options_Alternates(1).DisplayName
End Select
      '   END FORMULA; PROP ID:7690; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Selection_System", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Selection_System_Delta() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Selection_System_Delta").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:7691; TYPE:PF
      Select Case Me.Base_Options_Alternates.Quantity
	Case 0
		Result = "None"
	Case Else
		Result = Me.Base_Options_Alternates(1).DisplayName
End Select
      '   END FORMULA; PROP ID:7691; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Selection_System_Delta", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:5206; TYPE:PF
      Result = "Mech Install"
      '   END FORMULA; PROP ID:5206; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Tool_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:5203; TYPE:PF
      Result = "New"
      '   END FORMULA; PROP ID:5203; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Tool_Status", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_HCAD_Import_FileNameAndPath() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("HCAD_Import_FileNameAndPath").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4166; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:4166; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_HCAD_Import_FileNameAndPath", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HCAD_Import_QuantityOfCPs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HCAD_Import_RawData_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AirPipingFactor_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Base_Option_Alternate_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_bool_Unique_System_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CAE_Customer_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CAE_Customer_Location_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CAE_Customer_Project_Number_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CAE_Quote_Date_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Labor_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Weeks_Comm_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Weeks_Install_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Work_Week_HRS_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Work_Week_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selection_Control_Panel_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selection_Control_Panel_Delta_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selection_System_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selection_System_Delta_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_HCAD_Import_FileNameAndPath_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HCAD_Import_QuantityOfCPs_USERCHANGE() as Boolean
      
              '/Part_Family/Property_Spec/Property_Constraint/Property_Formula[@Formula_Type = 'UC']
              Dim Result as Boolean = False
              Dim ctx as Object
              Try
              ctx = this
              If Me.Properties("HCAD_Import_QuantityOfCPs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.UI_FORMULA) Then
              Stop
              End If
              '   BEGIN FORMULA; PROP ID:4168; TYPE:UC
              Dim lst As String() = Me.HCAD_Import_RawData.Split("~")

For Each l As String In lst
	
	If l.length > 0 Then
		Result += 1
	End If	
	
Next

Result = 2
              '   END FORMULA; PROP ID:4168; TYPE:UC
              Catch ex As Exception
              ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_HCAD_Import_QuantityOfCPs_USERCHANGE", ex.Message)
              If ObjectManager.DebugMode Then Stop
              End Try
              Return Result
            
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_HCAD_Import_RawData_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AirPipingFactor_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Base_Option_Alternate_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_bool_Unique_System_Name_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CAE_Customer_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CAE_Customer_Location_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CAE_Customer_Project_Number_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CAE_Quote_Date_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Labor_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Weeks_Comm_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Weeks_Install_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Work_Week_HRS_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Work_Week_Type_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selection_Control_Panel_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selection_Control_Panel_Delta_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selection_System_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selection_System_Delta_USERCHANGE() as Boolean
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
      Public Function Formula_HCAD_Import_FileNameAndPath_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AirPipingFactor_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AirPipingFactor").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9093; TYPE:VV
      Result = MakeValidValues(Array(0.5, 1, 1.5))
      '   END FORMULA; PROP ID:9093; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_AirPipingFactor_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Labor_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Labor_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10239; TYPE:VV
      Result = MakeValidValues(Array("Union", "Non-Union"))
      '   END FORMULA; PROP ID:10239; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_PRD_Labor_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PRD_Work_Week_Type_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PRD_Work_Week_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10238; TYPE:VV
      Result = MakeValidValues(Array("1st Shift", "2nd Shift", "3rd Shift", "24/7", "Weekend Only"))
      '   END FORMULA; PROP ID:10238; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_PRD_Work_Week_Type_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selection_Control_Panel_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Selection_Control_Panel").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9077; TYPE:VV
      Select Case Me.Control_Panels.Quantity
	Case 0
		Result = MakeValidValues(Array("None"))
	Case Else
		Dim vv As New ValidValues()
		For Each part As Part In Me.Control_Panels
			vv.add(part.DisplayName)
		Next
		Result = vv
End Select
      '   END FORMULA; PROP ID:9077; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Selection_Control_Panel_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selection_Control_Panel_Delta_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Selection_Control_Panel_Delta").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9091; TYPE:VV
      Select Case Me.Control_Panels.Quantity
	Case 0
		Result = MakeValidValues(Array("None"))
	Case Else
		Dim vv As New ValidValues()
		For Each part As Part In Me.Control_Panels
			vv.add(part.DisplayName)
		Next
		Result = vv
End Select
      '   END FORMULA; PROP ID:9091; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Selection_Control_Panel_Delta_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selection_System_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Selection_System").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:7690; TYPE:VV
      Select Case Me.Base_Options_Alternates.Quantity
	Case 0
		Result = MakeValidValues(Array("None"))
	Case Else
		Dim vv As New ValidValues()
		For Each part As Part In Me.Base_Options_Alternates
			vv.add(part.DisplayName)
		Next
		Result = vv
End Select
      '   END FORMULA; PROP ID:7690; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Selection_System_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Selection_System_Delta_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Selection_System_Delta").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:7691; TYPE:VV
      Select Case Me.Base_Options_Alternates.Quantity
	Case 0
		Result = MakeValidValues(Array("None"))
	Case Else
		Dim vv As New ValidValues()
		For Each part As Part In Me.Base_Options_Alternates
			vv.add(part.DisplayName)
		Next
		Result = vv
End Select
      '   END FORMULA; PROP ID:7691; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Selection_System_Delta_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:5203; TYPE:VV
      Result = MakeValidValues(Array("New", "Work In Progress", "Approved", "As Sold"))
      '   END FORMULA; PROP ID:5203; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Tool_Status_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:239; TYPE:PN
      
      '   END FORMULA; SUB ID:239; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Air_Piping_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Air_Piping").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:239; TYPE:QF
      Result = me.Base_Options_Alternates.Quantity
      '   END FORMULA; SUB ID:239; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Air_Piping_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Air_Piping").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:239; TYPE:OP
      result = "CAE_Air_Piping_Control_Panel"
      '   END FORMULA; SUB ID:239; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Air_Piping_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_Delta_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:238; TYPE:PN
      
      '   END FORMULA; SUB ID:238; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Air_Piping_Delta_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_Delta_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Air_Piping_Delta").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:238; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:238; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Air_Piping_Delta_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Air_Piping_Delta_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Air_Piping_Delta").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:238; TYPE:OP
      result = "CAE_Air_Piping_Control_Panel"
      '   END FORMULA; SUB ID:238; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Air_Piping_Delta_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Base_Options_Alternates_Delta_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:226; TYPE:PN
      
      '   END FORMULA; SUB ID:226; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Base_Options_Alternates_Delta_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Base_Options_Alternates_Delta_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Base_Options_Alternates_Delta").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:226; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:226; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Base_Options_Alternates_Delta_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Base_Options_Alternates_Delta_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Base_Options_Alternates_Delta").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:226; TYPE:OP
      result = "CAE_Mech_Install_CP_Comp"
      '   END FORMULA; SUB ID:226; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Base_Options_Alternates_Delta_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chutes_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:234; TYPE:PN
      
      '   END FORMULA; SUB ID:234; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Chutes_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chutes_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Chutes").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:234; TYPE:QF
      Result = Me.Base_Options_Alternates.Quantity
      '   END FORMULA; SUB ID:234; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Chutes_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Chutes_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Chutes").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:234; TYPE:OP
      result = "CAE_Chutes"
      '   END FORMULA; SUB ID:234; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Chutes_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Control_Panels_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:222; TYPE:PN
      
      '   END FORMULA; SUB ID:222; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Control_Panels_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Control_Panels_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Control_Panels").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:222; TYPE:QF
      Result = 0
      '   END FORMULA; SUB ID:222; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Control_Panels_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Control_Panels_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Control_Panels").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:222; TYPE:OP
      Result = "CAE_Mech_Install_CP_Comp"
      '   END FORMULA; SUB ID:222; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Control_Panels_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Costing_Intelligrated_Suppor_Mech_Install_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:235; TYPE:PN
      
      '   END FORMULA; SUB ID:235; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Conveyor_Costing_Intelligrated_Suppor_Mech_Install_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Costing_Intelligrated_Suppor_Mech_Install_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Conveyor_Costing_Intelligrated_Suppor_Mech_Install").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:235; TYPE:QF
      Result = Me.Base_Options_Alternates.Quantity
      '   END FORMULA; SUB ID:235; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Conveyor_Costing_Intelligrated_Suppor_Mech_Install_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Costing_Intelligrated_Suppor_Mech_Install_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Conveyor_Costing_Intelligrated_Suppor_Mech_Install").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:235; TYPE:OP
      result = "CAE_Conveyor_Costing"
      '   END FORMULA; SUB ID:235; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Conveyor_Costing_Intelligrated_Suppor_Mech_Install_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Costing_SC_Mech_Install_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:236; TYPE:PN
      
      '   END FORMULA; SUB ID:236; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Conveyor_Costing_SC_Mech_Install_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Costing_SC_Mech_Install_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Conveyor_Costing_SC_Mech_Install").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:236; TYPE:QF
      Result = Me.Base_Options_Alternates.Quantity
      '   END FORMULA; SUB ID:236; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Conveyor_Costing_SC_Mech_Install_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Costing_SC_Mech_Install_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Conveyor_Costing_SC_Mech_Install").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:236; TYPE:OP
      Result = "CAE_Conveyor_Costing"
      '   END FORMULA; SUB ID:236; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Conveyor_Costing_SC_Mech_Install_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mech_Install_Metrics_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:196; TYPE:PN
      
      '   END FORMULA; SUB ID:196; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Mech_Install_Metrics_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mech_Install_Metrics_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Mech_Install_Metrics").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:196; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:196; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Mech_Install_Metrics_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Mech_Install_Metrics_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Mech_Install_Metrics").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:196; TYPE:OP
      Result = "CAE_Mech_Install_Metrics"
      '   END FORMULA; SUB ID:196; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Mech_Install_Metrics_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Shuttle_Mech_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:221; TYPE:PN
      
      '   END FORMULA; SUB ID:221; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Shuttle_Mech_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Shuttle_Mech_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Shuttle_Mech").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:221; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:221; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Shuttle_Mech_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Shuttle_Mech_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Shuttle_Mech").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:221; TYPE:OP
      result = "CAE_Shuttle_Mech"
      '   END FORMULA; SUB ID:221; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Shuttle_Mech_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Inputs_01_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:273; TYPE:PN
      
      '   END FORMULA; SUB ID:273; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Sourcing_Inputs_01_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Inputs_01_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Sourcing_Inputs_01").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:273; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:273; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Sourcing_Inputs_01_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sourcing_Inputs_01_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Sourcing_Inputs_01").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:273; TYPE:OP
      Result = "CAE_Sourcing_Inputs"
      '   END FORMULA; SUB ID:273; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Sourcing_Inputs_01_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Structures_Platforms_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:200; TYPE:PN
      
      '   END FORMULA; SUB ID:200; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Structures_Platforms_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Structures_Platforms_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Structures_Platforms").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:200; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:200; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Structures_Platforms_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Structures_Platforms_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Structures_Platforms").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:200; TYPE:OP
      result = "CAE_Structures_Platforms"
      '   END FORMULA; SUB ID:200; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_Structures_Platforms_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TTCB_Costing_Mech_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:223; TYPE:PN
      
      '   END FORMULA; SUB ID:223; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_TTCB_Costing_Mech_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TTCB_Costing_Mech_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("TTCB_Costing_Mech").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:223; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:223; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_TTCB_Costing_Mech_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TTCB_Costing_Mech_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("TTCB_Costing_Mech").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:223; TYPE:OP
      result = "CAE_TTCB_Costing_Mech"
      '   END FORMULA; SUB ID:223; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Mech_Install_App.Formula_TTCB_Costing_Mech_OPTIMALPARTFAMILY", ex.Message)
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
    
      AddHandler ObjectManager.RsEngineer.RsActionButtonClick, AddressOf g_rsEngineer_RsActionButtonClick
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Overrides Sub RemoveRsEventHandlerMappings()
    
      RemoveHandler ObjectManager.RsEngineer.RsActionButtonClick, AddressOf g_rsEngineer_RsActionButtonClick
    End Sub
    #End Region

    End Class

  