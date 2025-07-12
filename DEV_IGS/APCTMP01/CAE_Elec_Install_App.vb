Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: CAE_Elec_Install_App
'$ GenerateDate: 07/12/2025 14:40:53

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

    Public Class [CAE_Elec_Install_App]
    
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

    Private this as CAE_Elec_Install_App = me

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
      Case "42"
      Select Case processStep
        Case "53"
        Result = Process_DefaultProcess_Import_COMMENT()
        End Select
        End Select
      
    Return Result
    End Function

    Public Function GetProcessStepStatus(ByVal processId As String, ByVal processStep As String) As Integer Implements RuleStream.IRsPartFormulas.GetProcessStepStatus
    Dim Result as Integer 'Long
    Select Case processId
      Case "42"
      Select Case processStep
        Case "53"
        Result = Process_DefaultProcess_Import_STATUS()
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
    
          Public Property [Elec_Install_Total_Wire_Btn_1_Hole_Lighted_Assy_CS]() As String
      Get
      Return Properties("Elec_Install_Total_Wire_Btn_1_Hole_Lighted_Assy_CS").Value
      End Get
      Set(ByVal Value As String)
      Properties("Elec_Install_Total_Wire_Btn_1_Hole_Lighted_Assy_CS").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EQS_QuantityOfCPs]() As Long
      Get
      Return Properties("EQS_QuantityOfCPs").Value
      End Get
      Set(ByVal Value As Long)
      Properties("EQS_QuantityOfCPs").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [EQS_RawData]() As String
      Get
      Return Properties("EQS_RawData").Value
      End Get
      Set(ByVal Value As String)
      Properties("EQS_RawData").CalculatedValue = Value
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
    
          Public Property [EQS_FileNameAndPath]() As String
      Get
      Return Properties("EQS_FileNameAndPath").Value
      End Get
      Set(ByVal Value As String)
      Properties("EQS_FileNameAndPath").CalculatedValue = Value
      End Set
      End Property
    
      Public ReadOnly Property [Base_Options_Alternates]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Base_Options_Alternates")
      End Get
      End Property
    
      Public ReadOnly Property [Control_Panels]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Control_Panels")
      End Get
      End Property
    
      Public ReadOnly Property [Conveyor_Costing_Elec]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Conveyor_Costing_Elec")
      End Get
      End Property
    
      Public ReadOnly Property [Elec_Install_Metrics]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Elec_Install_Metrics")
      End Get
      End Property
    
      Public ReadOnly Property [PowerFeeds]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("PowerFeeds")
      End Get
      End Property
    
      Public ReadOnly Property [Shuttle_Elec]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Shuttle_Elec")
      End Get
      End Property
    
      Public ReadOnly Property [TTCB_Costing_Elec]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("TTCB_Costing_Elec")
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
    InitPart("CAE_Elec_Install_App", <a><![CDATA[CAE_Elec_Install_App]]></a>.Value, 361, "APCTMP01",  "N", "N", True, True, "In Development", "", "C&E Electrical Install Estimator App", "", "", "",  "GLOBAL\H602502", "07/02/2025 17:16:12")
    AddProperty("3049", "Elec_Install_Total_Wire_Btn_1_Hole_Lighted_Assy_CS", <a><![CDATA[Elec_Install_Total_Wire_Btn_1_Hole_Lighted_Assy_CS]]></a>.Value, "", "String","","Elec Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H611896", "6/13/2025 6:25:32 AM")
    AddProperty("2738", "EQS_QuantityOfCPs", <a><![CDATA[EQS_Quantity Of CPs]]></a>.Value, "", "Long","","EQS Import","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/9/2025 7:31:08 PM")
    AddProperty("2737", "EQS_RawData", <a><![CDATA[EQS_Raw Data]]></a>.Value, "", "String","","EQS Import","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/10/2025 8:02:02 PM")
    AddProperty("5593", "Tool_Name", <a><![CDATA[Tool_Name]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/27/2025 7:51:24 PM")
    AddProperty("5592", "Tool_Status", <a><![CDATA[Tool_Status]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/30/2025 11:43:38 AM")
    AddProperty("2483", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM")
    AddProperty("2730", "EQS_FileNameAndPath", <a><![CDATA[EQS_FileNameAndPath]]></a>.Value, "", "String","","UI Inputs","FD", 9999, "", 0,0, "", "", "GLOBAL\H602502", "6/13/2025 7:41:07 PM")
    
      AddValidValue("Tool_Status")
    
      oSubpart = AddSubpart(284,"Base_Options_Alternates", <a><![CDATA[Base_Options_Alternates]]></a>.Value, "MN", "", "General", 9999, "", "GLOBAL\H602502", "7/1/2025 11:38:28 AM")
      
        oSubpart.AddVPF (365, "CAE_Elec_Install_CP_Comps", "CAE Elec Install CP Comps")
      
      oSubpart = AddSubpart(241,"Control_Panels", <a><![CDATA[Control Panels]]></a>.Value, "MN", "", "General", 9999, "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM")
      
        oSubpart.AddVPF (365, "CAE_Elec_Install_CP_Comps", "CAE Elec Install CP Comps")
      
      oSubpart = AddSubpart(286,"Conveyor_Costing_Elec", <a><![CDATA[Conveyor_Costing_Elec]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "7/1/2025 11:40:55 AM")
      
        oSubpart.AddVPF (393, "CAE_Conveyor_Installs_Elec", "CAE_Conveyor_Installs_Elec")
      
      oSubpart = AddSubpart(262,"Elec_Install_Metrics", <a><![CDATA[Elec_Install_Metrics]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "6/24/2025 6:28:28 PM")
      
        oSubpart.AddVPF (381, "CAE_Elec_Install_Metrics", "CAE_Elec_Install_Metrics")
      
      oSubpart = AddSubpart(291,"PowerFeeds", <a><![CDATA[Power Feeds]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "7/1/2025 5:36:13 PM")
      
        oSubpart.AddVPF (395, "CAE_Power_Feeds", "CAE_Power_Feeds")
      
      oSubpart = AddSubpart(294,"Shuttle_Elec", <a><![CDATA[Shuttle_Elec]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "7/1/2025 5:52:24 PM")
      
        oSubpart.AddVPF (397, "CAE_Shuttle_Elec", "CAE_Shuttle_Elec")
      
      oSubpart = AddSubpart(297,"TTCB_Costing_Elec", <a><![CDATA[TTCB_Costing_Elec]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H602502", "7/2/2025 5:16:12 PM")
      
        oSubpart.AddVPF (402, "CAE_TTCB_Costing_Elec", "CAE_TTCB_Costing_Elec")
      
      oConnection = AddConnection("My_PRD", <a><![CDATA[My PRD]]></a>.Value, "Connection to this line item's PRD", "109", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      oSpec = AddSpec("43","", 34, "EQS_File_Import", "", "GLOBAL\H602502", "2025-06-10T20:23:50.853", "EQS_File_Import")
      oSpec.Attributes.Add("Internal", "FileName", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 3)
      oSpec.Attributes.Add("Internal", "TempFileName", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 3)
      oSpec.Attributes.Add("MAP", "ENABLED", <a><![CDATA[True]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 1)
      oSpec.Attributes.Add("MAP", "Original_File_Name", <a><![CDATA[]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      oSpec.Attributes.Add("MAP", "Unique_File_Name", <a><![CDATA[EQS_FileNameAndPath]]></a>.Value, "",  <a><![CDATA[]]></a>.Value, 0, 0)
      
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Sub Initialize_Process(ByVal lngProcessID as Integer) Implements RuleStream.IRsPartFormulas.InitializeProcess
    Select Case lngProcessID
    
      Case 42
      Process = "DefaultProcess"	
        Initialize_Process_DefaultProcess_Import()
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
        oProcessStep = AddProcessStep(53, "Import", "This process step was created automatically by RuleStream.", 1, 42, 2, 1, 50, 50)
        oProcessStep.AddPath("CAE_Elec_Install_App")
        oProcessStep.AddFilter(1, 361, "System", 0, "PartNumber", 0)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_100A_Disconnect", 1)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_16_Port_Ethernet_Switch", 2)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_2_Door_Control_Panels", 3)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_200A_Disconnect", 4)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_20Amp_Mdr_Power_Supplies", 5)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_24VDC_Power_Supply", 6)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_24VDC_Power_Supply_2", 7)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_24VDC_Power_Supply_3", 8)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_24VDC_Power_Supply_4", 9)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_24VDC_Power_Supply_5", 10)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_3KVA_Transformer", 11)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_3KVA_Transformer_2", 12)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_400A_Disconnect", 13)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_40Amp_Mdr_Power_Supplies", 14)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_5KVA_Transformer", 15)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_5KVA_Transformer_2", 16)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_5KVA_Transformer_3", 17)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_600A_Disconnect", 18)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_600A_Disconnect_2", 19)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_80Amp_Mdr_Power_Supplies", 20)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Advantech_Computers", 21)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_AFE_Area_HMI", 22)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_AG_24Vdc_Power_Supply_Boxes", 23)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Air_Compressor", 24)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Air_Pressure_Switches", 25)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Alarm_Horns", 26)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Altersys_Runtimes_for_RTX", 27)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Altersys_Runtimes_for_Windows", 28)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_and_Terminal_Blocks", 29)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_and_Terminal_Blocks_2", 30)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_and_Terminal_Blocks_3", 31)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_and_Terminal_Blocks_4", 32)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_and_Terminal_Blocks_5", 33)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_ARSAW_Levels", 34)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Beacon_Lights", 35)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_BOSS_Control_Stations_Hoffman_Box", 36)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Braking_Resistors", 37)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Cameras", 38)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Chain_Care_DCP", 39)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Convenience_Duplex_Receptacles", 40)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Convenience_Quad_Receptacles", 41)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Cord_Operated_Stop_Bi_directional", 42)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Cord_Operated_Stop_Uni_directional", 43)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Cord_Pulleys", 44)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_DC_Large_IO_Boxes_40_Inputs_28_Outputs", 45)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_DC_Medium_IO_Boxes_24_Inputs_24_Outputs", 46)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_DCM", 47)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Detail_Intelligrated_Installation", 48)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Detail_Panel_Controls", 49)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Detail_Use_Existing_Spare_IO", 50)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_DeviceNet_Networks", 51)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_DeviceNet_Nodes", 52)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_DeviceNet_Repeaters", 53)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Door_Control_Panels", 54)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Door_Control_Panels_3", 55)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Door_Control_Panels_4", 56)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Door_Control_Panels_5", 57)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Enclosure_with_Drive", 58)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Encoders", 59)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Ethernet_Inputs", 60)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Foot_Switches", 61)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Gapper_Photo_Eyes", 62)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_HMI_with_Pedestal_Pallet_conveyor", 63)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hoffman_Box", 64)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Holds_0_16_Motor_Starters", 65)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Holds_15_44_Motor_Starters", 66)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Holds_45_72_Motor_Starters", 67)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Holds_73_80_Motor_Starters", 68)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Holds_81_100_Motor_Starters", 69)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hole_Button_Assy_10_Lane_Merge_Control_Stati", 70)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hole_Button_Assy_11_Lane_Merge_Control_Stati", 71)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hole_Button_Assy_12_Lane_Merge_Control_Stati", 72)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hole_Button_Assy_4_Lane_Merge_Control_Statio", 73)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hole_Button_Assy_5_Lane_Merge_Control_Statio", 74)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hole_Button_Assy_6_Lane_Merge_Control_Statio", 75)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hole_Button_Assy_7_Lane_Merge_Control_Statio", 76)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hole_Button_Assy_8_Lane_Merge_Control_Statio", 77)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hole_Button_Assy_9_Lane_Merge_Control_Statio", 78)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hole_Button_Assy_Control_Stations", 79)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hole_Button_Assy_Control_Stations_2", 80)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hole_Button_Assy_Control_Stations_3", 81)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hole_Button_Assy_Control_Stations_4", 82)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Hole_Lighted_Button_Assy_Control_Stations", 83)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Intelli_Merge_DCPs_Medium_IO_Box", 84)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Interlocks_Panel_To_Panel", 85)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_FLA_RATING_OF_SYSTEM", 86)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_Four_Pole_disconnect_switches", 87)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_Standard_3_Pole_Disconnects", 88)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_TOTAL_BELDEN_CABLE_IN_FEET", 89)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_TOTAL_DEVICENET_CABLE_IN_FEET", 90)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_TOTAL_NUMBER_OF_ANALOG_INPUTS", 91)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_TOTAL_NUMBER_OF_ANALOG_OUTPUTS", 92)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_TOTAL_NUMBER_OF_DIGITAL_INPUTS", 93)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_TOTAL_NUMBER_OF_DIGITAL_OUTPUTS", 94)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_TOTAL_NUMBER_OF_FIELD_HUBSSWITCHES", 95)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_TOTAL_NUMBER_OF_MOTORS", 96)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_TOTAL_NUMBER_OF_PROFIBUS_NODES", 97)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_TOTAL_PROFIBUS_CABLE_IN_FEET", 98)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_TOTAL_RIBBON_CABLE_IN_FEET", 99)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_COUNT_TOTAL_X2X_CABLE_IN_FEET", 100)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_Modules", 101)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_Modules_2", 102)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_Modules_3", 103)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_Modules_4", 104)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IO_Modules_5", 105)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_IQ_24Vdc_Power_Supply_Boxes", 106)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_KVM_switch", 107)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Laser_Prox_Photo", 108)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Light_Screen_Normal", 109)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Light_Screen_Safety", 110)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Lighted_Pushbuttons", 111)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Lighted_Pushbuttons_2", 112)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Lighted_Pushbuttons_3", 113)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Lighted_Pushbuttons_4", 114)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Lighted_Pushbuttons_5", 115)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Limit_Switches", 116)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Long_Range_Photo_Eyes", 117)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_MC4_Stand_alone_HMI_wpedestal_and_touchscreen", 118)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_MDP_Large_Sized", 119)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_MDP_Medium_Sized", 120)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Mdr_1_Hole_Pb_Station", 121)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Mdr_2_Hole_Pb_Station", 122)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Mdr_Beacon", 123)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Mdr_DeviceNet_Slave_Node", 124)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Mdr_Discharge_Photoeye", 125)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Mdr_Electric_TransfersDiverts", 126)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Mdr_Ethernet_Slave_Node", 127)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Mdr_Footswitch", 128)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Mdr_Infeed_Photoeye", 129)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_MDR_Mix_Module_Discrete", 130)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Mdr_Powered_Gates_Interface_Box_Included", 131)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Mdr_Profibus_Slave_Node", 132)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Mdr_Sound_Module", 133)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Misc", 134)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Misc_2", 135)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Monitor_Keyboard_Mouse", 136)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motor_Disconnects", 137)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_00050", 138)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_00075", 139)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_00100", 140)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_00150", 141)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_00200", 142)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_00300", 143)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_00500", 144)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_00750", 145)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_01000", 146)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_Flux_Vector_VFD_00750HP", 147)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_Sorter_VFD_01000HP", 148)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_Sorter_VFD_01500HP", 149)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_Sorter_VFD_02000HP", 150)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_Sorter_VFD_02500HP", 151)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_Sorter_VFD_03000HP", 152)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_Sorter_VFD_04000HP", 153)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_Sorter_VFD_05000HP", 154)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_Sorter_VFD_06000HP", 155)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_Sorter_VFD_07500HP", 156)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_VFD_00075HP", 157)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_VFD_00100HP", 158)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_VFD_00150HP", 159)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_VFD_00200HP", 160)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_VFD_00300HP", 161)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_VFD_00500HP", 162)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_VFD_00750HP", 163)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_VFD_01000HP", 164)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Motors_VFD_01500HP", 165)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Panel_Light", 166)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Panel_Light_2", 167)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Panel_Light_3", 168)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Panel_Light_4", 169)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Panel_Light_5", 170)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Pc_Control_Stations_Hoffman_Box", 171)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Photo_Array_Eyes", 172)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Photo_Eyes", 173)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Photo_Eyes_DC", 174)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Profibus_Inputs", 175)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Profibus_Repeaters", 176)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Profibus_Terminators", 177)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Prox_Switches_cost_and_io", 178)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Prox_Switches_Provided_by_others_no_cost_just", 179)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Receiving_Unloader_Electrical_Plugs_120V", 180)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Relay_Interface_Boxes", 181)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_RTX_Runtimes", 182)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Safety_Gate_Switches_Pallet_conveyor", 183)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_SendReceive_Photo_Eyes", 184)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Serial_Inputs_From_Scanners", 185)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Servo_BOSS_Wedge", 186)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Servo_Gappers", 187)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Servo_Motor", 188)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Single_Door_Cabinet", 189)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Slam_Lines", 190)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_SmartPack_Areas", 191)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_SmartPack_Lanes", 192)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_SmartPack_Units", 193)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Soft_Starts_00050Hp_To_00500Hp_480V", 194)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Soft_Starts_00750Hp_To_02000Hp_or_575V", 195)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Solenoids", 196)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Sorter_DCPs_Large_IO_Box", 197)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Sorter_Divert_Lanes", 198)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Sorter_Divert_Lanes_NoDCMs", 199)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Sorter_Oilers", 200)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Sorter_Switch_Divert_Solenoid", 201)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Sorter_Switch_Divert_Solenoid_2", 202)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Sorter_Switch_Photo_Eye", 203)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Sorter_Switch_Photo_Eye_2", 204)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Truck_LoadersUnloaders", 205)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Two_Door_Cabinet", 206)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Two_Door_Cabinet_with_a_Single_Door_Slave_Cabn", 207)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Two_Door_Cabinet_with_Two_Door_Slave_Cabnet", 208)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Two_Door_Cabinet_with_Two_Door_Slave_Cabnet_2", 209)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_UPS", 210)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_UPS_for_Firedoor_120VAC_6KVA", 211)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_UPS_for_Firedoor_480VAC_40KVA", 212)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_USS_Machines", 213)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_X2X_Cables_5_meter_length", 214)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_Zim_Module_for_Normal_IQ_Conveyor", 215)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_ZoneFlex_Manager_Devicenet_Kit", 216)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_ZoneFlex_Manager_Ethernet_Node_Kit", 217)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_ZoneFlex_Manager_GPIO_Node_Kit", 218)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_ZoneFlex_Manager_Profibus_Kit", 219)
        oProcessStep.AddFilter(2, 0, "EQS Import", 1, "EQS_ZoneFlex_Power_Supply_Boxes", 220)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddLayout(2, 8, "1;Control_Panels")
        oProcessStep.AddCustomLayout(1, 361, "1", "0", "RsActionButton", 0, "", 244, 373, 27, 83, 0, "Import", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ImportEQSData;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 361, "2", "0", "RsFileImporter", 0, "", 220, 12, 51, 355, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;SpecName:EQS_File_Import")
        oProcessStep.AddCustomLayout(1, 361, "3", "0", "RsGrid", 0, "", 14, 636, 393, 580, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,241,Control_Panels;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 361, "4", "3", "RsGridColumn", 0, "DisplayName", 0, 0, 0, 150, 0, "Display Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 361, "5", "0", "RsAddDeleteCopy", 0, "", 417, 1005, 27, 211, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,241,Control_Panels;CanDelete:;AddPrompt:False;ShowCopy:True")
        oProcessStep.AddCustomLayout(1, 361, "6", "0", "RsPictureBox", 0, "", 1, 1, 191, 628, 4, "", 0, 0, 1, 5, 0, "", "", "Filename:Honeywell Intelligrated Logo.jpg;IsGeneratedImg:False;RsTooltip:;")
        
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
          InitProperty("Elec_Install_Total_Wire_Btn_1_Hole_Lighted_Assy_CS", "2683", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H611896", "6/13/2025 6:25:32 AM", "", "In Development",  0,4015)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EQS_QuantityOfCPs", "2372", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/9/2025 7:31:08 PM", "", "In Development",  0,3694)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EQS_RawData", "2371", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/10/2025 8:02:02 PM", "", "In Development",  0,3890)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Tool_Name", "5205", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/27/2025 7:51:24 PM", "", "In Development",  0,8204)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Tool_Status", "5204", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H602502", "6/30/2025 11:43:38 AM", "", "In Development",  0,8825)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("EQS_FileNameAndPath", "2365", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H602502", "6/13/2025 7:41:07 PM", "", "In Development",  0,4314)
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
          
        InitValidValue("Tool_Status_ValidValues", "5204", "-1", 8826)
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
          
        InitSubpart("Conveyor_Costing_Elec", 212, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "7/1/2025 11:40:55 AM", "", "In Development", "N",0,580,579)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Elec_Install_Metrics", 197, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "6/24/2025 6:28:28 PM", "", "In Development", "N",0,543,541)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("PowerFeeds", 217, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "7/1/2025 5:36:13 PM", "", "In Development", "N",0,590,589)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Shuttle_Elec", 220, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "7/1/2025 5:52:24 PM", "", "In Development", "N",0,596,595)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("TTCB_Costing_Elec", 224, "", "", "Y", 0, "-1", "", "GLOBAL\H602502", "7/2/2025 5:16:12 PM", "", "In Development", "N",0,606,605)
        
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
          
        InitConnection("My_PRD", "89", "N","N", "N", 0, "-1", "", "GLOBAL\H601424", "5/29/2025 6:23:55 PM", "Connection to this line item's PRD", "In Development", "Y",152)
        
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
        '   BEGIN FORMULA; CON ID:89; TYPE:PF
        Result = RootPart.Project_Information(1).Salesforce_Opportunity(1).PRD_Document(1)
        '   END FORMULA; CON ID:89; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_My_PRD_PARTS", ex.Message)
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
      '   BEGIN FORMULA; PROC ID:53; TYPE:ST
      result = STATUS_ENABLED
      '   END FORMULA; PROC ID:53; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Process_DefaultProcess_Import_STATUS", ex.Message)
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
      '   BEGIN FORMULA; PROC ID:53; TYPE:CO
      result = ""
      '   END FORMULA; PROC ID:53; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Process_DefaultProcess_Import_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Elec_Install_Total_Wire_Btn_1_Hole_Lighted_Assy_CS() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Elec_Install_Total_Wire_Btn_1_Hole_Lighted_Assy_CS").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2683; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:2683; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_Elec_Install_Total_Wire_Btn_1_Hole_Lighted_Assy_CS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EQS_QuantityOfCPs() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EQS_QuantityOfCPs").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2372; TYPE:PF
      Dim lst As String() = Me.EQS_RawData.Split("~")

For Each l As String In lst

	If l.length > 0 Then
		Result += 1
	End If
	
Next
      '   END FORMULA; PROP ID:2372; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_EQS_QuantityOfCPs", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EQS_RawData() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EQS_RawData").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2371; TYPE:PF
      'Result = Custom.ElecInstall_GetEQSValues(Me.EQS_FileNameAndPath)

Result = ""
      '   END FORMULA; PROP ID:2371; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_EQS_RawData", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:5205; TYPE:PF
      Result = "Elec Install"
      '   END FORMULA; PROP ID:5205; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_Tool_Name", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:5204; TYPE:PF
      Result = "New"
      '   END FORMULA; PROP ID:5204; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_Tool_Status", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_EQS_FileNameAndPath() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("EQS_FileNameAndPath").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:2365; TYPE:PF
      Result = ""
      '   END FORMULA; PROP ID:2365; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_EQS_FileNameAndPath", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elec_Install_Total_Wire_Btn_1_Hole_Lighted_Assy_CS_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EQS_QuantityOfCPs_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EQS_RawData_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_EQS_FileNameAndPath_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elec_Install_Total_Wire_Btn_1_Hole_Lighted_Assy_CS_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EQS_QuantityOfCPs_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_EQS_RawData_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_EQS_FileNameAndPath_USERCHANGE() as Boolean
      Return True
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
      '   BEGIN FORMULA; PROP ID:5204; TYPE:VV
      Result = MakeValidValues(Array("New", "Work In Progress", "Approved", "As Sold"))
      '   END FORMULA; PROP ID:5204; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_Tool_Status_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Costing_Elec_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:212; TYPE:PN
      
      '   END FORMULA; SUB ID:212; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_Conveyor_Costing_Elec_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Costing_Elec_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Conveyor_Costing_Elec").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:212; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:212; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_Conveyor_Costing_Elec_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Conveyor_Costing_Elec_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Conveyor_Costing_Elec").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:212; TYPE:OP
      result = "CAE_Conveyor_Installs_Elec"
      '   END FORMULA; SUB ID:212; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_Conveyor_Costing_Elec_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elec_Install_Metrics_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:197; TYPE:PN
      
      '   END FORMULA; SUB ID:197; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_Elec_Install_Metrics_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elec_Install_Metrics_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Elec_Install_Metrics").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:197; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:197; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_Elec_Install_Metrics_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Elec_Install_Metrics_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Elec_Install_Metrics").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:197; TYPE:OP
      Result = "CAE_Elec_Install_Metrics"
      '   END FORMULA; SUB ID:197; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_Elec_Install_Metrics_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerFeeds_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:217; TYPE:PN
      
      '   END FORMULA; SUB ID:217; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_PowerFeeds_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerFeeds_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PowerFeeds").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:217; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:217; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_PowerFeeds_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PowerFeeds_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("PowerFeeds").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:217; TYPE:OP
      result = "CAE_Power_Feeds"
      '   END FORMULA; SUB ID:217; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_PowerFeeds_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Shuttle_Elec_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:220; TYPE:PN
      
      '   END FORMULA; SUB ID:220; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_Shuttle_Elec_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Shuttle_Elec_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Shuttle_Elec").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:220; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:220; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_Shuttle_Elec_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Shuttle_Elec_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Shuttle_Elec").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:220; TYPE:OP
      result = "CAE_Shuttle_Elec"
      '   END FORMULA; SUB ID:220; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_Shuttle_Elec_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TTCB_Costing_Elec_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:224; TYPE:PN
      
      '   END FORMULA; SUB ID:224; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_TTCB_Costing_Elec_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TTCB_Costing_Elec_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("TTCB_Costing_Elec").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:224; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:224; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_TTCB_Costing_Elec_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_TTCB_Costing_Elec_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("TTCB_Costing_Elec").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:224; TYPE:OP
      result = "CAE_TTCB_Costing_Elec"
      '   END FORMULA; SUB ID:224; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_Elec_Install_App.Formula_TTCB_Costing_Elec_OPTIMALPARTFAMILY", ex.Message)
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

  