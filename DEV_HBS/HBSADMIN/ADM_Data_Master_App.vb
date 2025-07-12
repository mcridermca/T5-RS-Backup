Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: HBSADMIN
'$ PartFamily: ADM_Data_Master_App
'$ GenerateDate: 07/12/2025 14:08:17

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
    Imports HBSADMIN.swMateType_e
    Imports HBSADMIN.swMateAlign_e
    Imports HBSADMIN.severity

    Public Class [ADM_Data_Master_App]
    
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

    Private this as ADM_Data_Master_App = me

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
      Case "26"
      Select Case processStep
        Case "21"
        Result = Process_DefaultProcess_Introduction_COMMENT()
        
        Case "38"
        Result = Process_DefaultProcess_Engineering_Units_Master_COMMENT()
        
        Case "22"
        Result = Process_DefaultProcess_Pole_Masters_COMMENT()
        
        Case "44"
        Result = Process_DefaultProcess_Application_Masters_COMMENT()
        
        Case "32"
        Result = Process_DefaultProcess_Controller_Family_Masters_COMMENT()
        
        Case "33"
        Result = Process_DefaultProcess_Controller_Special_Features_Masters_COMMENT()
        
        Case "30"
        Result = Process_DefaultProcess_Controller_Protocol_Masters_COMMENT()
        
        Case "34"
        Result = Process_DefaultProcess_CPU_IO_Masters_COMMENT()
        
        Case "45"
        Result = Process_DefaultProcess_Device_Type_Masters_COMMENT()
        
        Case "46"
        Result = Process_DefaultProcess_Parameter_Name_Masters_COMMENT()
        
        Case "47"
        Result = Process_DefaultProcess_Part_Type_Masters_COMMENT()
        
        Case "35"
        Result = Process_DefaultProcess_Point_Type_Masters_COMMENT()
        
        Case "31"
        Result = Process_DefaultProcess_Process_Variable_Masters_COMMENT()
        
        Case "36"
        Result = Process_DefaultProcess_Parts_Accessory_Mapping_Masters_COMMENT()
        
        Case "37"
        Result = Process_DefaultProcess_Standard_Wiring_Detail_Masters_COMMENT()
        
        Case "48"
        Result = Process_DefaultProcess_Standards_Masters_COMMENT()
        
        Case "28"
        Result = Process_DefaultProcess_Signal_Type_Masters_COMMENT()
        
        Case "23"
        Result = Process_DefaultProcess_Voltage_Masters_COMMENT()
        
        Case "43"
        Result = Process_DefaultProcess_RSXLI_PLI_Search_Data_COMMENT()
        End Select
        End Select
      
    Return Result
    End Function

    Public Function GetProcessStepStatus(ByVal processId As String, ByVal processStep As String) As Integer Implements RuleStream.IRsPartFormulas.GetProcessStepStatus
    Dim Result as Integer 'Long
    Select Case processId
      Case "26"
      Select Case processStep
        Case "21"
        Result = Process_DefaultProcess_Introduction_STATUS()
        
        Case "38"
        Result = Process_DefaultProcess_Engineering_Units_Master_STATUS()
        
        Case "22"
        Result = Process_DefaultProcess_Pole_Masters_STATUS()
        
        Case "44"
        Result = Process_DefaultProcess_Application_Masters_STATUS()
        
        Case "32"
        Result = Process_DefaultProcess_Controller_Family_Masters_STATUS()
        
        Case "33"
        Result = Process_DefaultProcess_Controller_Special_Features_Masters_STATUS()
        
        Case "30"
        Result = Process_DefaultProcess_Controller_Protocol_Masters_STATUS()
        
        Case "34"
        Result = Process_DefaultProcess_CPU_IO_Masters_STATUS()
        
        Case "45"
        Result = Process_DefaultProcess_Device_Type_Masters_STATUS()
        
        Case "46"
        Result = Process_DefaultProcess_Parameter_Name_Masters_STATUS()
        
        Case "47"
        Result = Process_DefaultProcess_Part_Type_Masters_STATUS()
        
        Case "35"
        Result = Process_DefaultProcess_Point_Type_Masters_STATUS()
        
        Case "31"
        Result = Process_DefaultProcess_Process_Variable_Masters_STATUS()
        
        Case "36"
        Result = Process_DefaultProcess_Parts_Accessory_Mapping_Masters_STATUS()
        
        Case "37"
        Result = Process_DefaultProcess_Standard_Wiring_Detail_Masters_STATUS()
        
        Case "48"
        Result = Process_DefaultProcess_Standards_Masters_STATUS()
        
        Case "28"
        Result = Process_DefaultProcess_Signal_Type_Masters_STATUS()
        
        Case "23"
        Result = Process_DefaultProcess_Voltage_Masters_STATUS()
        
        Case "43"
        Result = Process_DefaultProcess_RSXLI_PLI_Search_Data_STATUS()
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
    
          Public Property [PartNumber]() As String
      Get
      Return Properties("PartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartNumber").CalculatedValue = Value
      End Set
      End Property
    
      Public ReadOnly Property [Application_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Application_Master")
      End Get
      End Property
    
      Public ReadOnly Property [Controller_Family_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Controller_Family_Master")
      End Get
      End Property
    
      Public ReadOnly Property [Controller_Protocol_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Controller_Protocol_Master")
      End Get
      End Property
    
      Public ReadOnly Property [Controller_Spl_Feature_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Controller_Spl_Feature_Master")
      End Get
      End Property
    
      Public ReadOnly Property [CPU_IO_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("CPU_IO_Master")
      End Get
      End Property
    
      Public ReadOnly Property [Device_Type_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Device_Type_Master")
      End Get
      End Property
    
      Public ReadOnly Property [Engg_Units_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Engg_Units_Master")
      End Get
      End Property
    
      Public ReadOnly Property [Parameter_Name_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Parameter_Name_Master")
      End Get
      End Property
    
      Public ReadOnly Property [Part_Type_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Part_Type_Master")
      End Get
      End Property
    
      Public ReadOnly Property [Parts_Accessory_Mapping_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Parts_Accessory_Mapping_Master")
      End Get
      End Property
    
      Public ReadOnly Property [Point_Type_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Point_Type_Master")
      End Get
      End Property
    
      Public ReadOnly Property [Pole_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Pole_Master")
      End Get
      End Property
    
      Public ReadOnly Property [Process_Variable_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Process_Variable_Master")
      End Get
      End Property
    
      Public ReadOnly Property [RSXLI_PLI_Search_Data]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("RSXLI_PLI_Search_Data")
      End Get
      End Property
    
      Public ReadOnly Property [Signal_Type_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Signal_Type_Master")
      End Get
      End Property
    
      Public ReadOnly Property [Standards_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Standards_Master")
      End Get
      End Property
    
      Public ReadOnly Property [Std_Wiring_Detail_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Std_Wiring_Detail_Master")
      End Get
      End Property
    
      Public ReadOnly Property [Voltage_Master]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Voltage_Master")
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
    InitPart("ADM_Data_Master_App", <a><![CDATA[ADM_Data_Master_App]]></a>.Value, 54, "HBSADMIN",  "", "", True, True, "In Development", "", "Top Level Data Maintenance Application", "", "", "",  "GLOBAL\H601423", "07/11/2025 14:25:59")
    AddProperty("729", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/20/2025 3:39:14 PM")
    
      oSubpart = AddSubpart(127,"Application_Master", <a><![CDATA[Application_Master]]></a>.Value, "FD", "", "Master SubPart Collection", 9999, "", "GLOBAL\H601423", "7/9/2025 10:38:03 AM")
      
        oSubpart.AddVPF (114, "ADM_Application_Master", "ADM_Application_Master")
      
      oSubpart = AddSubpart(104,"Controller_Family_Master", <a><![CDATA[Controller_Family_Master]]></a>.Value, "FD", "The list of Controller_Family_Masters", "Master SubPart Collection", 9999, "HBS", "GLOBAL\H601423", "6/28/2025 1:41:10 PM")
      
        oSubpart.AddVPF (81, "ADM_Controller_Family_Master", "ADM_Controller_Family_Master")
      
      oSubpart = AddSubpart(94,"Controller_Protocol_Master", <a><![CDATA[Controller_Protocol_Master]]></a>.Value, "FD", "The list of Controller_Protocol_Masters", "Master SubPart Collection", 9999, "HBS", "GLOBAL\H601422", "6/27/2025 5:26:21 PM")
      
        oSubpart.AddVPF (69, "ADM_Controller_Protocol_Master", "ADM_Controller_Protocol_Master")
      
      oSubpart = AddSubpart(105,"Controller_Spl_Feature_Master", <a><![CDATA[Controller_Spl_Feature_Master]]></a>.Value, "FD", "The list of Controller_Spl_Feature_Masters", "Master SubPart Collection", 9999, "HBS", "GLOBAL\H601423", "6/28/2025 1:40:41 PM")
      
        oSubpart.AddVPF (72, "ADM_Controller_Spl_Feature_Master", "ADM_Controller_Spl_Feature_Master")
      
      oSubpart = AddSubpart(106,"CPU_IO_Master", <a><![CDATA[CPU_IO_Master]]></a>.Value, "FD", "The list of CPU_IO_Masters", "Master SubPart Collection", 9999, "HBS", "GLOBAL\H601423", "6/28/2025 1:48:52 PM")
      
        oSubpart.AddVPF (66, "ADM_CPU_IO_Master", "ADM_CPU_IO_Master")
      
      oSubpart = AddSubpart(128,"Device_Type_Master", <a><![CDATA[Device_Type_Master]]></a>.Value, "FD", "", "Master SubPart Collection", 9999, "", "GLOBAL\H601423", "7/9/2025 10:39:28 AM")
      
        oSubpart.AddVPF (111, "ADM_Device_Type_Master", "ADM_Device_Type_Master")
      
      oSubpart = AddSubpart(112,"Engg_Units_Master", <a><![CDATA[Engg_Units_Master]]></a>.Value, "FD", "The list of Engg_Units_Masters", "Master SubPart Collection", 9999, "HBS", "GLOBAL\H601423", "6/30/2025 1:32:19 PM")
      
        oSubpart.AddVPF (93, "ADM_Engg_Units_Master", "ADM_Engg_Units_Master")
      
      oSubpart = AddSubpart(129,"Parameter_Name_Master", <a><![CDATA[Parameter_Name_Master]]></a>.Value, "FD", "", "Master SubPart Collection", 9999, "", "GLOBAL\H601423", "7/9/2025 10:44:49 AM")
      
        oSubpart.AddVPF (102, "ADM_Parameter_Name_Master", "ADM_Parameter_Name_Master")
      
      oSubpart = AddSubpart(130,"Part_Type_Master", <a><![CDATA[Part_Type_Master]]></a>.Value, "FD", "", "Master SubPart Collection", 9999, "", "GLOBAL\H601423", "7/9/2025 10:47:31 AM")
      
        oSubpart.AddVPF (105, "ADM_Part_Type_Master", "ADM_Part_Type_Master")
      
      oSubpart = AddSubpart(108,"Parts_Accessory_Mapping_Master", <a><![CDATA[Parts_Accessory_Mapping_Master]]></a>.Value, "FD", "The list of Parts_Accessory_Mapping_Masters", "Master SubPart Collection", 9999, "HBS", "GLOBAL\H601423", "6/28/2025 2:04:06 PM")
      
        oSubpart.AddVPF (78, "ADM_Parts_Accessory_Mapping_Master", "ADM_Parts_Accessory_Mapping_Master")
      
      oSubpart = AddSubpart(107,"Point_Type_Master", <a><![CDATA[Point_Type_Master]]></a>.Value, "FD", "The list of Point_Type_Masters", "Master SubPart Collection", 9999, "HBS", "GLOBAL\H601423", "6/28/2025 1:57:08 PM")
      
        oSubpart.AddVPF (87, "ADM_Point_Type_Master", "ADM_Point_Type_Master")
      
      oSubpart = AddSubpart(76,"Pole_Master", <a><![CDATA[Pole_Master]]></a>.Value, "FD", "The list of Pole_Masters", "Master SubPart Collection", 9999, "HBS", "GLOBAL\H601422", "6/25/2025 2:31:14 AM")
      
        oSubpart.AddVPF (50, "ADM_Pole_Master", "ADM_Pole_Master")
      
      oSubpart = AddSubpart(103,"Process_Variable_Master", <a><![CDATA[Process_Variable_Master]]></a>.Value, "FD", "The list of Process_Variable_Masters", "Master SubPart Collection", 9999, "HBS", "GLOBAL\H601423", "6/28/2025 1:40:58 PM")
      
        oSubpart.AddVPF (90, "ADM_Process_Variable_Master", "ADM_Process_Variable_Master")
      
      oSubpart = AddSubpart(115,"RSXLI_PLI_Search_Data", <a><![CDATA[RSXLI_PLI_Search_Data]]></a>.Value, "FD", "", "Master SubPart Collection", 9999, "HBS", "GLOBAL\H601422", "7/1/2025 2:02:40 AM")
      
        oSubpart.AddVPF (98, "RSXLI_PLI_Search_Data", "RSXLI_PLI_Search_Data")
      
      oSubpart = AddSubpart(83,"Signal_Type_Master", <a><![CDATA[Signal_Type_Master]]></a>.Value, "FD", "The list of Signal_Type_Masters", "Master SubPart Collection", 9999, "HBS", "GLOBAL\H601422", "6/25/2025 2:31:07 AM")
      
        oSubpart.AddVPF (60, "ADM_Signal_Type_Master", "ADM_Signal_Type_Master")
      
      oSubpart = AddSubpart(131,"Standards_Master", <a><![CDATA[Standards_Master]]></a>.Value, "FD", "", "Master SubPart Collection", 9999, "", "GLOBAL\H601423", "7/9/2025 10:50:16 AM")
      
        oSubpart.AddVPF (108, "ADM_Standards_Master", "ADM_Standards_Master")
      
      oSubpart = AddSubpart(109,"Std_Wiring_Detail_Master", <a><![CDATA[Std_Wiring_Detail_Master]]></a>.Value, "FD", "The list of Std_Wiring_Detail_Masters", "Master SubPart Collection", 9999, "HBS", "GLOBAL\H601423", "6/28/2025 2:27:57 PM")
      
        oSubpart.AddVPF (75, "ADM_Std_Wiring_Detail_Master", "ADM_Std_Wiring_Detail_Master")
      
      oSubpart = AddSubpart(74,"Voltage_Master", <a><![CDATA[Voltage_Master]]></a>.Value, "FD", "The list of Voltage_Masters", "Master SubPart Collection", 9999, "HBS", "GLOBAL\H601422", "6/25/2025 2:31:39 AM")
      
        oSubpart.AddVPF (51, "ADM_Voltage_Master", "ADM_Voltage_Master")
      
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Sub Initialize_Process(ByVal lngProcessID as Integer) Implements RuleStream.IRsPartFormulas.InitializeProcess
    Select Case lngProcessID
    
      Case 26
      Process = "DefaultProcess"	
        Initialize_Process_DefaultProcess_Introduction()
        Initialize_Process_DefaultProcess_Engineering_Units_Master()
        Initialize_Process_DefaultProcess_Pole_Masters()
        Initialize_Process_DefaultProcess_Application_Masters()
        Initialize_Process_DefaultProcess_Controller_Family_Masters()
        Initialize_Process_DefaultProcess_Controller_Special_Features_Masters()
        Initialize_Process_DefaultProcess_Controller_Protocol_Masters()
        Initialize_Process_DefaultProcess_CPU_IO_Masters()
        Initialize_Process_DefaultProcess_Device_Type_Masters()
        Initialize_Process_DefaultProcess_Parameter_Name_Masters()
        Initialize_Process_DefaultProcess_Part_Type_Masters()
        Initialize_Process_DefaultProcess_Point_Type_Masters()
        Initialize_Process_DefaultProcess_Process_Variable_Masters()
        Initialize_Process_DefaultProcess_Parts_Accessory_Mapping_Masters()
        Initialize_Process_DefaultProcess_Standard_Wiring_Detail_Masters()
        Initialize_Process_DefaultProcess_Standards_Masters()
        Initialize_Process_DefaultProcess_Signal_Type_Masters()
        Initialize_Process_DefaultProcess_Voltage_Masters()
        Initialize_Process_DefaultProcess_RSXLI_PLI_Search_Data()
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
        Private Sub Initialize_Process_DefaultProcess_Introduction()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(21, "Introduction", "Introduction", 1, 26, 1, 1, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App")
        oProcessStep.AddFilter(1, 54, "System", 0, "PartNumber", 0)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 54, "1", "0", "RsLabel", 0, "", 18, 31, 39, 608, 0, "Component Data  Administration", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.18;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 54, "2", "0", "RsGroupBox", 0, "", 78, 31, 266, 720, 1, "Instructions", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.14;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 54, "3", "2", "RsLabel", 0, "", 30, 26, 26, 422, 2, "Important things to note go here", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Engineering_Units_Master()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(38, "Engineering Units Master", "Engineering Units Masters", 1, 26, 1, 2, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Engg_Units_Master/ADM_Engg_Units_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 93, "1", "0", "RsGrid", 0, "", 50, 12, 492, 1085, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,110,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 93, "2", "1", "RsGridColumn", 0, "Engg_Units_Master_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 93, "3", "1", "RsGridColumn", 0, "Engg_Units_Standard_Ref", 0, 0, 0, 100, 0, "Engg Units Standard Ref", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 93, "4", "1", "RsGridColumn", 0, "Unit_Of_Measure", 0, 0, 0, 150, 0, "Unit of Measure", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 93, "5", "1", "RsGridColumn", 0, "Base_Unit_Name", 0, 0, 0, 125, 0, "Base Unit Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 93, "6", "1", "RsGridColumn", 0, "Base_Unit_Symbol", 0, 0, 0, 60, 0, "Base Unit Symbol", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 93, "7", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 93, "8", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 93, "9", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 93, "10", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 93, "11", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 70, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 93, "12", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 70, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 93, "13", "0", "RsLabel", 0, "", 0, 14, 37, 297, 1, "Engineering Units Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 93, "14", "0", "RsSubForm", 0, "", 576, 0, 253, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,110,Rows")
        oProcessStep.AddCustomLayout(1, 93, "15", "14", "RsGroupBox", 0, "", 120, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 93, "16", "15", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 93, "17", "15", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 93, "18", "15", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 93, "19", "15", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 93, "20", "15", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 93, "21", "15", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 93, "22", "15", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 93, "23", "15", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 93, "24", "15", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 93, "25", "15", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 93, "26", "14", "RsGroupBox", 0, "", 29, 18, 85, 894, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 93, "27", "26", "RsTextbox", 0, "Unit_Of_Measure", 19, 73, 20, 243, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 93, "28", "26", "RsCheckbox", 0, "Deleted", 21, 551, 18, 69, 16, "Deleted", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 93, "29", "26", "RsTextbox", 0, "Sort_Order", 19, 349, 20, 89, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 93, "30", "26", "RsLabel", 0, "", 19, 9, 25, 58, 18, "Unit of Measure:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 93, "31", "26", "RsLabel", 0, "", 19, 302, 25, 41, 19, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 93, "32", "26", "RsActionButton", 0, "", 19, 765, 34, 120, 20, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Engg_Units_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 93, "33", "26", "RsCheckbox", 0, "Is_Active", 19, 456, 18, 77, 21, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 93, "34", "26", "RsTextbox", 0, "Base_Unit_Symbol", 45, 307, 20, 100, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 93, "35", "26", "RsTextbox", 0, "Base_Unit_Name", 45, 105, 20, 100, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 93, "36", "26", "RsLabel", 0, "", 47, 211, 25, 90, 24, "Base Unit Symbol", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 93, "37", "26", "RsLabel", 0, "", 47, 9, 25, 90, 25, "Base Unit Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 93, "38", "0", "RsLabel", 0, "Row_DBKeys", 549, 14, 16, 96, 26, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 93, "39", "0", "RsActionButton", 0, "", 547, 453, 27, 98, 27, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 93, "40", "0", "RsActionButton", 0, "", 547, 587, 23, 75, 28, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 93, "41", "0", "RsActionButton", 0, "", 547, 668, 23, 75, 29, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 93, "42", "0", "RsActionButton", 0, "", 547, 783, 27, 119, 30, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Engg_Units_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Pole_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(22, "Pole Masters", "Pole Masters", 1, 26, 1, 3, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Pole_Master/ADM_Pole_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 50, "1", "0", "RsGrid", 0, "", 59, 20, 492, 920, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,69,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 50, "2", "1", "RsGridColumn", 0, "Pole_Master_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 50, "3", "1", "RsGridColumn", 0, "Pole_Name", 0, 0, 0, 250, 0, "Pole Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 50, "4", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 50, "5", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 50, "6", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 50, "7", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 50, "8", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 70, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 50, "9", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 70, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 50, "10", "0", "RsLabel", 0, "", 9, 22, 37, 297, 1, "Pole Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 50, "11", "0", "RsSubForm", 0, "", 585, 8, 253, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,69,Rows")
        oProcessStep.AddCustomLayout(1, 50, "12", "11", "RsGroupBox", 0, "", 98, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 50, "13", "12", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 50, "14", "12", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 50, "15", "12", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 50, "16", "12", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 50, "17", "12", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 50, "18", "12", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 50, "19", "12", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 50, "20", "12", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 50, "21", "12", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 50, "22", "12", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 50, "23", "11", "RsGroupBox", 0, "", 29, 18, 63, 893, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 50, "24", "23", "RsTextbox", 0, "Pole_Name", 19, 73, 20, 243, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 50, "25", "23", "RsCheckbox", 0, "Deleted", 21, 551, 18, 69, 16, "Deleted", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 50, "26", "23", "RsTextbox", 0, "Sort_Order", 19, 349, 20, 89, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 50, "27", "23", "RsLabel", 0, "", 19, 9, 25, 58, 18, "Pole Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 50, "28", "23", "RsLabel", 0, "", 19, 302, 25, 41, 19, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 50, "29", "23", "RsActionButton", 0, "", 19, 765, 34, 120, 20, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Pole_Master_Save_Selected;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 50, "30", "23", "RsCheckbox", 0, "Is_Active", 19, 456, 18, 77, 21, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 50, "31", "0", "RsLabel", 0, "Row_DBKeys", 558, 22, 16, 96, 22, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 50, "32", "0", "RsActionButton", 0, "", 556, 461, 27, 98, 23, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 50, "33", "0", "RsActionButton", 0, "", 556, 595, 23, 75, 24, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 50, "34", "0", "RsActionButton", 0, "", 556, 676, 23, 75, 25, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 50, "35", "0", "RsActionButton", 0, "", 556, 791, 27, 119, 26, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Pole_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Application_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(44, "Application Masters", "Application Masters", 1, 26, 1, 4, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Application_Master/ADM_Application_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 114, "1", "0", "RsGrid", 0, "", 50, 12, 492, 920, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,125,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 114, "2", "1", "RsGridColumn", 0, "Application_Master_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 114, "3", "1", "RsGridColumn", 0, "Application_Name", 0, 0, 0, 250, 0, "Application Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 114, "4", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 114, "5", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 114, "6", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 114, "7", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 114, "8", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 70, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 114, "9", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 70, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 114, "10", "0", "RsLabel", 0, "", 0, 14, 37, 297, 1, "Application Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 114, "11", "0", "RsSubForm", 0, "", 576, 0, 253, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,125,Rows")
        oProcessStep.AddCustomLayout(1, 114, "12", "11", "RsGroupBox", 0, "", 98, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 114, "13", "12", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 114, "14", "12", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 114, "15", "12", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 114, "16", "12", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 114, "17", "12", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 114, "18", "12", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 114, "19", "12", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 114, "20", "12", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 114, "21", "12", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 114, "22", "12", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 114, "23", "11", "RsGroupBox", 0, "", 29, 18, 63, 893, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 114, "24", "23", "RsTextbox", 0, "Application_Name", 19, 73, 20, 243, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 114, "25", "23", "RsCheckbox", 0, "Deleted", 21, 551, 18, 69, 16, "Deleted", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 114, "26", "23", "RsTextbox", 0, "Sort_Order", 19, 349, 20, 89, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 114, "27", "23", "RsLabel", 0, "", 19, 9, 25, 58, 18, "Application Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 114, "28", "23", "RsLabel", 0, "", 19, 302, 25, 41, 19, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 114, "29", "23", "RsActionButton", 0, "", 19, 765, 34, 120, 20, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Application_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 114, "30", "23", "RsCheckbox", 0, "Is_Active", 19, 456, 18, 77, 21, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 114, "31", "0", "RsLabel", 0, "Row_DBKeys", 549, 14, 16, 96, 22, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 114, "32", "0", "RsActionButton", 0, "", 547, 453, 27, 98, 23, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 114, "33", "0", "RsActionButton", 0, "", 547, 587, 23, 75, 24, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 114, "34", "0", "RsActionButton", 0, "", 547, 668, 23, 75, 25, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 114, "35", "0", "RsActionButton", 0, "", 547, 783, 27, 119, 26, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Application_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Controller_Family_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(32, "Controller Family Masters", "Controller Family Masters", 1, 26, 1, 5, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Controller_Family_Master/ADM_Controller_Family_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 81, "1", "0", "RsGrid", 0, "", 50, 12, 492, 920, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,95,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 81, "2", "1", "RsGridColumn", 0, "Controller_Family_Master_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 81, "3", "1", "RsGridColumn", 0, "Controller_Family_Name", 0, 0, 0, 250, 0, "Controller Family Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 81, "4", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 81, "5", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 81, "6", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 81, "7", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 81, "8", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 70, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 81, "9", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 70, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 81, "10", "0", "RsLabel", 0, "", 0, 14, 37, 297, 1, "Controller Family Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 81, "11", "0", "RsSubForm", 0, "", 576, 0, 253, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,95,Rows")
        oProcessStep.AddCustomLayout(1, 81, "12", "11", "RsGroupBox", 0, "", 98, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 81, "13", "12", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 81, "14", "12", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 81, "15", "12", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 81, "16", "12", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 81, "17", "12", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 81, "18", "12", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 81, "19", "12", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 81, "20", "12", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 81, "21", "12", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 81, "22", "12", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 81, "23", "11", "RsGroupBox", 0, "", 29, 18, 63, 893, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 81, "24", "23", "RsTextbox", 0, "Controller_Family_Name", 19, 91, 20, 243, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 81, "25", "23", "RsCheckbox", 0, "Deleted", 19, 569, 18, 69, 16, "Deleted", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 81, "26", "23", "RsTextbox", 0, "Sort_Order", 19, 367, 20, 89, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 81, "27", "23", "RsLabel", 0, "", 19, 9, 25, 76, 18, "Controller Family Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 81, "28", "23", "RsLabel", 0, "", 19, 320, 25, 41, 19, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 81, "29", "23", "RsActionButton", 0, "", 19, 765, 34, 120, 20, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Controller_Family_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 81, "30", "23", "RsCheckbox", 0, "Is_Active", 19, 474, 18, 77, 21, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 81, "31", "0", "RsLabel", 0, "Row_DBKeys", 549, 14, 16, 96, 22, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 81, "32", "0", "RsActionButton", 0, "", 547, 471, 27, 98, 23, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 81, "33", "0", "RsActionButton", 0, "", 547, 587, 23, 75, 24, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 81, "34", "0", "RsActionButton", 0, "", 547, 668, 23, 75, 25, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 81, "35", "0", "RsActionButton", 0, "", 547, 783, 27, 119, 26, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Controller_Family_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Controller_Special_Features_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(33, "Controller Special Features Masters", "Controller Special Features Masters", 1, 26, 1, 6, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Controller_Spl_Feature_Master/ADM_Controller_Spl_Feature_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 72, "1", "0", "RsGrid", 0, "", 50, 12, 492, 920, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,88,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 72, "2", "1", "RsGridColumn", 0, "Controller_Spl_Feature_Master_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 72, "3", "1", "RsGridColumn", 0, "Special_Feature", 0, 0, 0, 250, 0, "Special Feature", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 72, "4", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 72, "5", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 72, "6", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 72, "7", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 72, "8", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 70, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 72, "9", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 70, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 72, "10", "0", "RsLabel", 0, "", 0, 14, 37, 331, 1, "Controller Special Feature Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 72, "11", "0", "RsSubForm", 0, "", 576, 0, 253, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,88,Rows")
        oProcessStep.AddCustomLayout(1, 72, "12", "11", "RsGroupBox", 0, "", 98, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 72, "13", "12", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 72, "14", "12", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 72, "15", "12", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 72, "16", "12", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 72, "17", "12", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 72, "18", "12", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 72, "19", "12", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 72, "20", "12", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 72, "21", "12", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 72, "22", "12", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 72, "23", "11", "RsGroupBox", 0, "", 29, 18, 63, 893, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 72, "24", "23", "RsTextbox", 0, "Special_Feature", 19, 73, 20, 243, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 72, "25", "23", "RsCheckbox", 0, "Deleted", 19, 551, 18, 69, 16, "Deleted", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 72, "26", "23", "RsTextbox", 0, "Sort_Order", 19, 349, 20, 89, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 72, "27", "23", "RsLabel", 0, "", 19, 9, 25, 58, 18, "Special Feature:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 72, "28", "23", "RsLabel", 0, "", 19, 302, 25, 41, 19, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 72, "29", "23", "RsActionButton", 0, "", 19, 765, 34, 120, 20, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Controller_Spl_Feature_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 72, "30", "23", "RsCheckbox", 0, "Is_Active", 19, 456, 18, 77, 21, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 72, "31", "0", "RsLabel", 0, "Row_DBKeys", 549, 14, 16, 96, 22, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 72, "32", "0", "RsActionButton", 0, "", 547, 453, 27, 98, 23, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 72, "33", "0", "RsActionButton", 0, "", 547, 587, 23, 75, 24, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 72, "34", "0", "RsActionButton", 0, "", 547, 668, 23, 75, 25, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 72, "35", "0", "RsActionButton", 0, "", 547, 783, 27, 119, 26, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Controller_Spl_Feature_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Controller_Protocol_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(30, "Controller Protocol Masters", "", 1, 26, 1, 7, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Controller_Protocol_Master/ADM_Controller_Protocol_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 69, "1", "0", "RsGrid", 0, "", 50, 0, 492, 920, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,86,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 69, "2", "1", "RsGridColumn", 0, "Controller_Protocol_Master_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 69, "3", "1", "RsGridColumn", 0, "Protocol_Type", 0, 0, 0, 250, 0, "Controller Protocol Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 69, "4", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 69, "5", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 69, "6", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 69, "7", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 69, "8", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 50, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 69, "9", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 50, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 69, "10", "0", "RsLabel", 0, "", 0, 2, 37, 297, 1, "Controller Protocol Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 69, "11", "0", "RsLabel", 0, "Row_DBKeys", 549, 2, 16, 96, 2, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 69, "12", "0", "RsActionButton", 0, "", 547, 421, 27, 98, 3, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 69, "13", "0", "RsSubForm", 0, "", 576, 0, 232, 920, 4, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,86,Rows")
        oProcessStep.AddCustomLayout(1, 69, "14", "13", "RsGroupBox", 0, "", 95, 3, 94, 894, 5, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 69, "15", "14", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 6, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 69, "16", "14", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 69, "17", "14", "RsLabel", 0, "", 19, 9, 25, 41, 8, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 69, "18", "14", "RsLabel", 0, "", 51, 401, 21, 101, 9, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 69, "19", "14", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 10, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 69, "20", "14", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 69, "21", "14", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 69, "22", "14", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 69, "23", "14", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 69, "24", "14", "RsLabel", 0, "", 20, 408, 21, 94, 15, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 69, "25", "13", "RsGroupBox", 0, "", 26, 3, 63, 893, 16, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 69, "26", "25", "RsTextbox", 0, "Protocol_Type", 19, 73, 20, 243, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 69, "27", "25", "RsTextbox", 0, "Sort_Order", 14, 371, 20, 99, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 69, "28", "25", "RsLabel", 0, "", 14, 6, 39, 61, 19, "Controller Protocol:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 69, "29", "25", "RsLabel", 0, "", 14, 334, 25, 31, 20, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 69, "30", "25", "RsActionButton", 0, "", 19, 765, 34, 120, 21, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Controller_Protocol_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 69, "31", "25", "RsCheckbox", 0, "Is_Active", 14, 487, 18, 77, 22, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 69, "32", "0", "RsActionButton", 0, "", 547, 561, 23, 75, 23, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 69, "33", "0", "RsActionButton", 0, "", 547, 642, 23, 75, 24, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 69, "34", "0", "RsActionButton", 0, "", 547, 769, 27, 119, 25, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Controller_Protocol_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_CPU_IO_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(34, "CPU IO Masters", "CPU IO Masters", 1, 26, 1, 8, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.CPU_IO_Master/ADM_CPU_IO_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 66, "1", "0", "RsGrid", 0, "", 50, 12, 492, 1161, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,84,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 66, "2", "1", "RsGridColumn", 0, "CPU_IO_Master_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 66, "3", "1", "RsGridColumn", 0, "CPU_IO_Type", 0, 0, 0, 250, 0, "CPU IO Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 66, "4", "1", "RsGridColumn", 0, "CPU_IO_Description", 0, 0, 0, 250, 0, "Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 66, "5", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 66, "6", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 66, "7", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 66, "8", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 66, "9", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 70, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 66, "10", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 70, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 66, "11", "0", "RsLabel", 0, "", 0, 14, 37, 297, 1, "CPU IO Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 66, "12", "0", "RsSubForm", 0, "", 576, 0, 253, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,84,Rows")
        oProcessStep.AddCustomLayout(1, 66, "13", "12", "RsGroupBox", 0, "", 137, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 66, "14", "13", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 66, "15", "13", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 66, "16", "13", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 66, "17", "13", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 66, "18", "13", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 66, "19", "13", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 66, "20", "13", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 66, "21", "13", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 66, "22", "13", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 66, "23", "13", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 66, "24", "12", "RsGroupBox", 0, "", 29, 18, 84, 893, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 66, "25", "24", "RsTextbox", 0, "CPU_IO_Type", 19, 73, 20, 243, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 66, "26", "24", "RsCheckbox", 0, "Deleted", 21, 551, 18, 69, 16, "Deleted", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 66, "27", "24", "RsTextbox", 0, "Sort_Order", 19, 349, 20, 89, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 66, "28", "24", "RsLabel", 0, "", 19, 6, 25, 61, 18, "CPU IO Type:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 66, "29", "24", "RsLabel", 0, "", 19, 302, 25, 41, 19, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 66, "30", "24", "RsActionButton", 0, "", 19, 765, 34, 120, 20, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_CPU_IO_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 66, "31", "24", "RsCheckbox", 0, "Is_Active", 19, 456, 18, 77, 21, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 66, "32", "24", "RsTextbox", 0, "CPU_IO_Description", 45, 73, 20, 243, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 66, "33", "24", "RsLabel", 0, "", 45, 1, 25, 66, 23, "Description:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 66, "34", "0", "RsLabel", 0, "Row_DBKeys", 549, 14, 16, 96, 24, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 66, "35", "0", "RsActionButton", 0, "", 547, 453, 27, 98, 25, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 66, "36", "0", "RsActionButton", 0, "", 547, 587, 23, 75, 26, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 66, "37", "0", "RsActionButton", 0, "", 547, 668, 23, 75, 27, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 66, "38", "0", "RsActionButton", 0, "", 547, 783, 27, 119, 28, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_CPU_IO_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Device_Type_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(45, "Device Type Masters", "Device Type Masters", 1, 26, 1, 9, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Device_Type_Master/ADM_Device_Type_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 111, "1", "0", "RsGrid", 0, "", 50, 12, 492, 920, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,123,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 111, "2", "1", "RsGridColumn", 0, "Device_Type_Master_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 111, "3", "1", "RsGridColumn", 0, "Device_Type", 0, 0, 0, 250, 0, "Device Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 111, "4", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 111, "5", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 111, "6", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 111, "7", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 111, "8", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 70, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 111, "9", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 70, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 111, "10", "0", "RsLabel", 0, "", 0, 14, 37, 297, 1, "Device Type Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 111, "11", "0", "RsSubForm", 0, "", 576, 0, 253, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,123,Rows")
        oProcessStep.AddCustomLayout(1, 111, "12", "11", "RsGroupBox", 0, "", 98, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 111, "13", "12", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 111, "14", "12", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 111, "15", "12", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 111, "16", "12", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 111, "17", "12", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 111, "18", "12", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 111, "19", "12", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 111, "20", "12", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 111, "21", "12", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 111, "22", "12", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 111, "23", "11", "RsGroupBox", 0, "", 29, 18, 63, 893, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 111, "24", "23", "RsTextbox", 0, "Device_Type", 19, 73, 20, 243, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 111, "25", "23", "RsCheckbox", 0, "Deleted", 21, 551, 18, 69, 16, "Deleted", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 111, "26", "23", "RsTextbox", 0, "Sort_Order", 19, 349, 20, 89, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 111, "27", "23", "RsLabel", 0, "", 19, 9, 25, 58, 18, "Device Type:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 111, "28", "23", "RsLabel", 0, "", 19, 302, 25, 41, 19, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 111, "29", "23", "RsActionButton", 0, "", 19, 765, 34, 120, 20, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Device_Type_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 111, "30", "23", "RsCheckbox", 0, "Is_Active", 19, 456, 18, 77, 21, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 111, "31", "0", "RsLabel", 0, "Row_DBKeys", 549, 14, 16, 96, 22, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 111, "32", "0", "RsActionButton", 0, "", 547, 453, 27, 98, 23, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 111, "33", "0", "RsActionButton", 0, "", 547, 587, 23, 75, 24, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 111, "34", "0", "RsActionButton", 0, "", 547, 668, 23, 75, 25, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 111, "35", "0", "RsActionButton", 0, "", 547, 784, 27, 119, 26, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Device_Type_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Parameter_Name_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(46, "Parameter Name Masters", "Parameter Name Masters", 1, 26, 1, 10, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Parameter_Name_Master/ADM_Parameter_Name_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 102, "1", "0", "RsGrid", 0, "", 50, 12, 492, 920, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,117,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 102, "2", "1", "RsGridColumn", 0, "Parameter_Name_Master_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 102, "3", "1", "RsGridColumn", 0, "Parameter_Name_Master", 0, 0, 0, 250, 0, "Parameter Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 102, "4", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 102, "5", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 102, "6", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 102, "7", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 102, "8", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 70, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 102, "9", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 70, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 102, "10", "0", "RsLabel", 0, "", 0, 14, 37, 297, 1, "Parameter Name Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 102, "11", "0", "RsSubForm", 0, "", 576, 0, 253, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,117,Rows")
        oProcessStep.AddCustomLayout(1, 102, "12", "11", "RsGroupBox", 0, "", 98, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 102, "13", "12", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 102, "14", "12", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 102, "15", "12", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 102, "16", "12", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 102, "17", "12", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 102, "18", "12", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 102, "19", "12", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 102, "20", "12", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 102, "21", "12", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 102, "22", "12", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 102, "23", "11", "RsGroupBox", 0, "", 29, 18, 63, 893, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 102, "24", "23", "RsTextbox", 0, "Parameter_Name_Master", 19, 73, 20, 243, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 102, "25", "23", "RsCheckbox", 0, "Deleted", 21, 551, 18, 69, 16, "Deleted", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 102, "26", "23", "RsTextbox", 0, "Sort_Order", 19, 349, 20, 89, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 102, "27", "23", "RsLabel", 0, "", 19, 9, 25, 58, 18, "Parameter Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 102, "28", "23", "RsLabel", 0, "", 19, 302, 25, 41, 19, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 102, "29", "23", "RsActionButton", 0, "", 19, 765, 34, 120, 20, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Parameter_Name_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 102, "30", "23", "RsCheckbox", 0, "Is_Active", 19, 456, 18, 77, 21, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 102, "31", "0", "RsLabel", 0, "Row_DBKeys", 549, 14, 16, 96, 22, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 102, "32", "0", "RsActionButton", 0, "", 547, 453, 27, 98, 23, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 102, "33", "0", "RsActionButton", 0, "", 547, 587, 23, 75, 24, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 102, "34", "0", "RsActionButton", 0, "", 547, 668, 23, 75, 25, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 102, "35", "0", "RsActionButton", 0, "", 547, 784, 27, 119, 26, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Parameter_Name_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Part_Type_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(47, "Part Type Masters", "Part Type Masters", 1, 26, 1, 11, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Part_Type_Master/ADM_Part_Type_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 105, "1", "0", "RsGrid", 0, "", 50, 12, 492, 920, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,119,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 105, "2", "1", "RsGridColumn", 0, "Part_Type_Master_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 105, "3", "1", "RsGridColumn", 0, "Part_Type", 0, 0, 0, 250, 0, "Part Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 105, "4", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 105, "5", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 105, "6", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 105, "7", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 105, "8", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 70, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 105, "9", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 70, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 105, "10", "0", "RsLabel", 0, "", 0, 14, 37, 297, 1, "Part Type Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 105, "11", "0", "RsSubForm", 0, "", 576, 0, 253, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,119,Rows")
        oProcessStep.AddCustomLayout(1, 105, "12", "11", "RsGroupBox", 0, "", 98, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 105, "13", "12", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 105, "14", "12", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 105, "15", "12", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 105, "16", "12", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 105, "17", "12", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 105, "18", "12", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 105, "19", "12", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 105, "20", "12", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 105, "21", "12", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 105, "22", "12", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 105, "23", "11", "RsGroupBox", 0, "", 29, 18, 63, 893, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 105, "24", "23", "RsTextbox", 0, "Part_Type", 19, 73, 20, 243, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 105, "25", "23", "RsCheckbox", 0, "Deleted", 21, 551, 18, 69, 16, "Deleted", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 105, "26", "23", "RsTextbox", 0, "Sort_Order", 19, 349, 20, 89, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 105, "27", "23", "RsLabel", 0, "", 19, 9, 25, 58, 18, "Part Type:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 105, "28", "23", "RsLabel", 0, "", 19, 302, 25, 41, 19, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 105, "29", "23", "RsActionButton", 0, "", 19, 765, 34, 120, 20, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Part_Type_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 105, "30", "23", "RsCheckbox", 0, "Is_Active", 19, 456, 18, 77, 21, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 105, "31", "0", "RsLabel", 0, "Row_DBKeys", 549, 14, 16, 96, 22, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 105, "32", "0", "RsActionButton", 0, "", 547, 453, 27, 98, 23, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 105, "33", "0", "RsActionButton", 0, "", 547, 587, 23, 75, 24, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 105, "34", "0", "RsActionButton", 0, "", 547, 668, 23, 75, 25, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 105, "35", "0", "RsActionButton", 0, "", 547, 783, 27, 119, 26, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Part_Type_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Point_Type_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(35, "Point Type Masters", "Point Type Masters", 1, 26, 1, 12, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Point_Type_Master/ADM_Point_Type_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 87, "1", "0", "RsGrid", 0, "", 50, 12, 492, 920, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,99,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 87, "2", "1", "RsGridColumn", 0, "Point_Type_ID", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 87, "3", "1", "RsGridColumn", 0, "Point_Type", 0, 0, 0, 250, 0, "Point Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 87, "4", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 87, "5", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 87, "6", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 87, "7", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 87, "8", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 70, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 87, "9", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 70, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 87, "10", "0", "RsLabel", 0, "", 0, 14, 37, 297, 1, "Point Type Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 87, "11", "0", "RsSubForm", 0, "", 576, 0, 253, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,99,Rows")
        oProcessStep.AddCustomLayout(1, 87, "12", "11", "RsGroupBox", 0, "", 98, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 87, "13", "12", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 87, "14", "12", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 87, "15", "12", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 87, "16", "12", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 87, "17", "12", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 87, "18", "12", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 87, "19", "12", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 87, "20", "12", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 87, "21", "12", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 87, "22", "12", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 87, "23", "11", "RsGroupBox", 0, "", 29, 18, 63, 893, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 87, "24", "23", "RsTextbox", 0, "Point_Type", 19, 73, 20, 243, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 87, "25", "23", "RsCheckbox", 0, "Deleted", 21, 551, 18, 69, 16, "Deleted", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 87, "26", "23", "RsTextbox", 0, "Sort_Order", 19, 349, 20, 89, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 87, "27", "23", "RsLabel", 0, "", 19, 9, 25, 58, 18, "Point Type:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 87, "28", "23", "RsLabel", 0, "", 19, 302, 25, 41, 19, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 87, "29", "23", "RsActionButton", 0, "", 19, 765, 34, 120, 20, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Point_Type_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 87, "30", "23", "RsCheckbox", 0, "Is_Active", 19, 456, 18, 77, 21, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 87, "31", "0", "RsLabel", 0, "Row_DBKeys", 549, 14, 16, 96, 22, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 87, "32", "0", "RsActionButton", 0, "", 547, 453, 27, 98, 23, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 87, "33", "0", "RsActionButton", 0, "", 547, 587, 23, 75, 24, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 87, "34", "0", "RsActionButton", 0, "", 547, 668, 23, 75, 25, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 87, "35", "0", "RsActionButton", 0, "", 547, 783, 27, 119, 26, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Point_Type_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Process_Variable_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(31, "Process Variable Masters", "Process Variable Masters", 1, 26, 1, 13, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Process_Variable_Master/ADM_Process_Variable_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 90, "1", "0", "RsGrid", 0, "", 50, 12, 492, 920, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,101,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 90, "2", "1", "RsGridColumn", 0, "Process_Variable_Master_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 90, "3", "1", "RsGridColumn", 0, "Process_Variable", 0, 0, 0, 250, 0, "Process Variable", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 90, "4", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 90, "5", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 90, "6", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 90, "7", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 90, "8", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 70, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 90, "9", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 70, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 90, "10", "0", "RsLabel", 0, "", 0, 14, 37, 297, 1, "Process Variable Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 90, "11", "0", "RsSubForm", 0, "", 576, 0, 253, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,101,Rows")
        oProcessStep.AddCustomLayout(1, 90, "12", "11", "RsGroupBox", 0, "", 98, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 90, "13", "12", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 90, "14", "12", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 90, "15", "12", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 90, "16", "12", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 90, "17", "12", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 90, "18", "12", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 90, "19", "12", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 90, "20", "12", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 90, "21", "12", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 90, "22", "12", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 90, "23", "11", "RsGroupBox", 0, "", 29, 18, 63, 893, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 90, "24", "23", "RsTextbox", 0, "Process_Variable", 19, 98, 20, 243, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 90, "25", "23", "RsCheckbox", 0, "Deleted", 19, 569, 18, 69, 16, "Deleted", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 90, "26", "23", "RsTextbox", 0, "Sort_Order", 19, 381, 20, 89, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 90, "27", "23", "RsLabel", 0, "", 19, 9, 25, 83, 18, "Process Variable:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 90, "28", "23", "RsLabel", 0, "", 19, 334, 25, 41, 19, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 90, "29", "23", "RsActionButton", 0, "", 19, 765, 34, 120, 20, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Process_Variable_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 90, "30", "23", "RsCheckbox", 0, "Is_Active", 19, 486, 18, 77, 21, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 90, "31", "0", "RsLabel", 0, "Row_DBKeys", 549, 14, 16, 96, 22, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 90, "32", "0", "RsActionButton", 0, "", 547, 483, 27, 98, 23, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 90, "33", "0", "RsActionButton", 0, "", 547, 587, 23, 75, 24, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 90, "34", "0", "RsActionButton", 0, "", 547, 668, 23, 75, 25, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 90, "35", "0", "RsActionButton", 0, "", 547, 783, 27, 119, 26, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Process_Variable_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Parts_Accessory_Mapping_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(36, "Parts Accessory Mapping Masters", "Parts Accessory Mapping Masters", 1, 26, 1, 14, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Parts_Accessory_Mapping_Master/ADM_Parts_Accessory_Mapping_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 78, "1", "0", "RsGrid", 0, "", 50, 12, 492, 1005, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,92,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 78, "2", "1", "RsGridColumn", 0, "Parts_Accessory_Mapping_Master_Id", 0, 0, 0, 100, 0, "PKID", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 78, "3", "1", "RsGridColumn", 0, "Parts_Master_ID_Ref", 0, 0, 0, 150, 0, "Parts Master ID Reference", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 78, "4", "1", "RsGridColumn", 0, "Accessory", 0, 0, 0, 75, 0, "Accessory", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 78, "5", "1", "RsGridColumn", 0, "Accessory_Qty", 0, 0, 0, 75, 0, "Qty", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 78, "6", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 78, "7", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 78, "8", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 78, "9", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 78, "10", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 70, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 78, "11", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 70, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 78, "12", "0", "RsLabel", 0, "", 0, 14, 37, 320, 1, "Parts Accessory Mapping Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 78, "13", "0", "RsSubForm", 0, "", 582, 0, 247, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,92,Rows")
        oProcessStep.AddCustomLayout(1, 78, "14", "13", "RsGroupBox", 0, "", 134, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 78, "15", "14", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 78, "16", "14", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 78, "17", "14", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 78, "18", "14", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 78, "19", "14", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 78, "20", "14", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 78, "21", "14", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 78, "22", "14", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 78, "23", "14", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 78, "24", "14", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 78, "25", "13", "RsGroupBox", 0, "", 29, 18, 87, 893, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 78, "26", "25", "RsTextbox", 0, "Accessory", 19, 73, 20, 243, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 78, "27", "25", "RsCheckbox", 0, "Deleted", 19, 553, 18, 69, 16, "Deleted", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 78, "28", "25", "RsTextbox", 0, "Sort_Order", 19, 349, 20, 89, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 78, "29", "25", "RsLabel", 0, "", 19, 6, 25, 61, 18, "Accessory:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 78, "30", "25", "RsLabel", 0, "", 19, 302, 25, 41, 19, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 78, "31", "25", "RsActionButton", 0, "", 19, 765, 34, 120, 20, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Parts_Accessory_Mapping_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 78, "32", "25", "RsCheckbox", 0, "Is_Active", 19, 456, 18, 77, 21, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 78, "33", "25", "RsTextbox", 0, "Parts_Master_ID_Ref", 45, 389, 20, 243, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 78, "34", "25", "RsTextbox", 0, "Accessory_Qty", 45, 73, 20, 243, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 78, "35", "25", "RsLabel", 0, "", 45, 322, 25, 61, 24, "Parts Master ID Ref:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 78, "36", "25", "RsLabel", 0, "", 45, 6, 25, 61, 25, "Accessory Quantity:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 78, "37", "0", "RsLabel", 0, "Row_DBKeys", 549, 14, 16, 96, 26, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 78, "38", "0", "RsActionButton", 0, "", 549, 453, 27, 98, 27, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 78, "39", "0", "RsActionButton", 0, "", 547, 587, 23, 75, 28, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 78, "40", "0", "RsActionButton", 0, "", 547, 668, 23, 75, 29, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 78, "41", "0", "RsActionButton", 0, "", 549, 783, 27, 119, 30, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Parts_Accessory_Mapping_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Standard_Wiring_Detail_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(37, "Standard Wiring Detail Masters", "Standard Wiring Detail Masters", 1, 26, 1, 15, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Std_Wiring_Detail_Master/ADM_Std_Wiring_Detail_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 75, "1", "0", "RsGrid", 0, "", 50, 12, 492, 1642, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,90,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 75, "2", "1", "RsGridColumn", 0, "Std_Wiring_Detail_Master_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "3", "1", "RsGridColumn", 0, "Std_Wiring_Detail_Master_Id_String", 0, 0, 0, 60, 0, "Wiring ID", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "4", "1", "RsGridColumn", 0, "Wiring_Std_Detail_Description", 0, 0, 0, 250, 0, "Wiring Standard Detail Description", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "5", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "6", "1", "RsGridColumn", 0, "Point_Type", 0, 0, 0, 75, 0, "Point Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "7", "1", "RsGridColumn", 0, "Do_Type", 0, 0, 0, 75, 0, "Do Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "8", "1", "RsGridColumn", 0, "Wiring_Type", 0, 0, 0, 75, 0, "Wiring Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "9", "1", "RsGridColumn", 0, "No_Of_Terminals", 0, 0, 0, 75, 0, "# Terminals", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "10", "1", "RsGridColumn", 0, "Power_Supply", 0, 0, 0, 100, 0, "Power Supply", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "11", "1", "RsGridColumn", 0, "Wiring_Std_Detail_Dwg", 0, 0, 0, 140, 0, "Wiring Std. Detail Dwg", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "12", "1", "RsGridColumn", 0, "Resistor_Required", 0, 0, 0, 150, 0, "Resistor Required", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "13", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "14", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "15", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 100, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "16", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 70, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "17", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 70, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 75, "18", "0", "RsLabel", 0, "", 0, 14, 37, 320, 1, "Standard Wiring Detail Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 75, "19", "0", "RsSubForm", 0, "", 576, 0, 300, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,90,Rows")
        oProcessStep.AddCustomLayout(1, 75, "20", "19", "RsGroupBox", 0, "", 203, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 75, "21", "20", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 75, "22", "20", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 75, "23", "20", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 75, "24", "20", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 75, "25", "20", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 75, "26", "20", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 75, "27", "20", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 75, "28", "20", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 75, "29", "20", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 75, "30", "20", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 75, "31", "19", "RsGroupBox", 0, "", 29, 18, 168, 893, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 75, "32", "31", "RsLabel", 0, "", 101, 359, 25, 95, 15, "Resistor Required", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 75, "33", "31", "RsLabel", 0, "", 47, 359, 25, 95, 16, "Do Type", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 75, "34", "31", "RsLabel", 0, "", 73, 359, 25, 95, 17, "Number of Terminals", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 75, "35", "31", "RsTextbox", 0, "Wiring_Std_Detail_Description", 19, 110, 20, 243, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 75, "36", "31", "RsTextbox", 0, "Sort_Order", 19, 386, 20, 89, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 75, "37", "31", "RsCheckbox", 0, "Deleted", 19, 588, 18, 69, 20, "Deleted", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 75, "38", "31", "RsLabel", 0, "", 19, 9, 25, 95, 21, "Wiring Standard Detail Description:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 75, "39", "31", "RsLabel", 0, "", 19, 339, 25, 41, 22, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 75, "40", "31", "RsActionButton", 0, "", 19, 765, 34, 120, 23, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Std_Wiring_Detail_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 75, "41", "31", "RsTextbox", 0, "Wiring_Std_Detail_Dwg", 127, 110, 20, 243, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 75, "42", "31", "RsTextbox", 0, "Resistor_Required", 101, 460, 20, 243, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 75, "43", "31", "RsCheckbox", 0, "Is_Active", 19, 493, 18, 77, 26, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 75, "44", "31", "RsLabel", 0, "", 127, 9, 25, 95, 27, "Wiring Standard Detail Drawing", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 75, "45", "31", "RsTextbox", 0, "No_Of_Terminals", 73, 460, 20, 243, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 75, "46", "31", "RsTextbox", 0, "Power_Supply", 101, 110, 20, 243, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 75, "47", "31", "RsLabel", 0, "", 101, 9, 25, 95, 30, "Power Supply", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 75, "48", "31", "RsTextbox", 0, "Do_Type", 47, 460, 20, 243, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 75, "49", "31", "RsLabel", 0, "", 73, 9, 25, 95, 32, "Wiring Type", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 75, "50", "31", "RsTextbox", 0, "Wiring_Type", 73, 110, 20, 243, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 75, "51", "31", "RsLabel", 0, "", 47, 9, 25, 95, 34, "Point Type", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 75, "52", "31", "RsTextbox", 0, "Point_Type", 47, 110, 20, 243, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 75, "53", "0", "RsLabel", 0, "Row_DBKeys", 549, 14, 16, 96, 36, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 75, "54", "0", "RsActionButton", 0, "", 547, 422, 27, 98, 37, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 75, "55", "0", "RsActionButton", 0, "", 547, 587, 23, 75, 38, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 75, "56", "0", "RsActionButton", 0, "", 547, 668, 23, 75, 39, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 75, "57", "0", "RsActionButton", 0, "", 547, 783, 27, 119, 40, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Std_Wiring_Detail_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Standards_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(48, "Standards Masters", "Standards Masters", 1, 26, 1, 16, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Standards_Master/ADM_Standards_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 108, "1", "0", "RsGrid", 0, "", 50, 12, 492, 920, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,121,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 108, "2", "1", "RsGridColumn", 0, "Standards_Master_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 108, "3", "1", "RsGridColumn", 0, "Standards", 0, 0, 0, 250, 0, "Standards", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 108, "4", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 108, "5", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 108, "6", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 108, "7", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 108, "8", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 70, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 108, "9", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 70, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 108, "10", "0", "RsLabel", 0, "", 0, 14, 37, 297, 1, "Standards Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 108, "11", "0", "RsSubForm", 0, "", 576, 0, 253, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,121,Rows")
        oProcessStep.AddCustomLayout(1, 108, "12", "11", "RsGroupBox", 0, "", 98, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 108, "13", "12", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 108, "14", "12", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 108, "15", "12", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 108, "16", "12", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 108, "17", "12", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 108, "18", "12", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 108, "19", "12", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 108, "20", "12", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 108, "21", "12", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 108, "22", "12", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 108, "23", "11", "RsGroupBox", 0, "", 29, 18, 63, 893, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 108, "24", "23", "RsTextbox", 0, "Standards", 19, 73, 20, 243, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 108, "25", "23", "RsCheckbox", 0, "Deleted", 21, 551, 18, 69, 16, "Deleted", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 108, "26", "23", "RsTextbox", 0, "Sort_Order", 19, 349, 20, 89, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 108, "27", "23", "RsLabel", 0, "", 19, 9, 25, 58, 18, "Standards:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 108, "28", "23", "RsLabel", 0, "", 19, 302, 25, 41, 19, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 108, "29", "23", "RsActionButton", 0, "", 19, 765, 34, 120, 20, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Standards_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 108, "30", "23", "RsCheckbox", 0, "Is_Active", 19, 456, 18, 77, 21, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 108, "31", "0", "RsLabel", 0, "Row_DBKeys", 549, 14, 16, 96, 22, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 108, "32", "0", "RsActionButton", 0, "", 547, 453, 27, 98, 23, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 108, "33", "0", "RsActionButton", 0, "", 547, 587, 23, 75, 24, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 108, "34", "0", "RsActionButton", 0, "", 547, 668, 23, 75, 25, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 108, "35", "0", "RsActionButton", 0, "", 547, 783, 27, 119, 26, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Standards_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Signal_Type_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(28, "Signal Type Masters", "", 1, 26, 1, 17, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Signal_Type_Master/ADM_Signal_Type_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 60, "1", "0", "RsGrid", 0, "", 50, 12, 492, 920, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,81,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 60, "2", "1", "RsGridColumn", 0, "Signal_Type_Master_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 60, "3", "1", "RsGridColumn", 0, "Signal_Type", 0, 0, 0, 250, 0, "Signal Type Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 60, "4", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 70, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 60, "5", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 60, 0, "Is_Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 60, "6", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 60, "7", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 60, "8", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 50, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 60, "9", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 50, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 60, "10", "0", "RsLabel", 0, "", 0, 14, 37, 297, 1, "Signal Type Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 60, "11", "0", "RsLabel", 0, "Row_DBKeys", 549, 14, 16, 96, 2, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 60, "12", "0", "RsActionButton", 0, "", 547, 423, 27, 98, 3, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 60, "13", "0", "RsSubForm", 0, "", 582, 12, 226, 920, 4, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,81,Rows")
        oProcessStep.AddCustomLayout(1, 60, "14", "13", "RsGroupBox", 0, "", 95, 3, 94, 894, 5, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 60, "15", "14", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 6, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 60, "16", "14", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 60, "17", "14", "RsLabel", 0, "", 19, 9, 25, 41, 8, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 60, "18", "14", "RsLabel", 0, "", 51, 401, 21, 101, 9, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 60, "19", "14", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 10, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 60, "20", "14", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 60, "21", "14", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 60, "22", "14", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 60, "23", "14", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 60, "24", "14", "RsLabel", 0, "", 20, 408, 21, 94, 15, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 60, "25", "13", "RsGroupBox", 0, "", 26, 3, 63, 893, 16, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 60, "26", "25", "RsTextbox", 0, "Signal_Type", 19, 73, 20, 243, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 60, "27", "25", "RsTextbox", 0, "Sort_Order", 14, 371, 20, 99, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 60, "28", "25", "RsLabel", 0, "", 14, 29, 39, 38, 19, "Signal Type:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 60, "29", "25", "RsLabel", 0, "", 14, 334, 25, 31, 20, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 60, "30", "25", "RsActionButton", 0, "", 19, 765, 34, 120, 21, "Save Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Signal_Type_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 60, "31", "25", "RsCheckbox", 0, "Is_Active", 14, 487, 18, 77, 22, "Is_Active", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 60, "32", "0", "RsActionButton", 0, "", 547, 573, 23, 75, 23, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 60, "33", "0", "RsActionButton", 0, "", 547, 654, 23, 75, 24, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 60, "34", "0", "RsActionButton", 0, "", 547, 780, 27, 119, 25, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Signal_Type_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Voltage_Masters()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(23, "Voltage Masters", "Voltage Masters", 1, 26, 1, 18, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.Voltage_Master/ADM_Voltage_Master")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 51, "1", "0", "RsGrid", 0, "", 59, 22, 492, 886, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,70,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 51, "2", "1", "RsGridColumn", 0, "Voltage_Master_ID", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 51, "3", "1", "RsGridColumn", 0, "Voltage", 0, 0, 0, 250, 0, "Voltage", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 51, "4", "1", "RsGridColumn", 0, "Sort_Order", 0, 0, 0, 100, 0, "Sort_Order", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 51, "5", "1", "RsGridColumn", 0, "Is_Active", 0, 0, 0, 50, 0, "Active", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 51, "6", "1", "RsGridColumn", 0, "Modified_By", 0, 0, 0, 150, 0, "Modified_By", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 51, "7", "1", "RsGridColumn", 0, "Modified_On", 0, 0, 0, 150, 0, "Modified_On", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 51, "8", "1", "RsGridColumn", 0, "Is_Dirty", 0, 0, 0, 50, 0, "Edited", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 51, "9", "1", "RsGridColumn", 0, "Deleted", 0, 0, 0, 50, 0, "Deleted", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 51, "10", "0", "RsLabel", 0, "", 9, 24, 37, 297, 1, "Voltage Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 51, "11", "0", "RsSubForm", 0, "", 585, 10, 253, 932, 2, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,70,Rows")
        oProcessStep.AddCustomLayout(1, 51, "12", "11", "RsGroupBox", 0, "", 98, 18, 94, 894, 3, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 51, "13", "12", "RsCheckbox", 0, "Is_New", 47, 190, 18, 126, 4, "Is_New (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 51, "14", "12", "RsTextbox", 0, "Data_Hash", 19, 56, 19, 214, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 51, "15", "12", "RsLabel", 0, "", 19, 9, 25, 41, 6, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 51, "16", "12", "RsLabel", 0, "", 51, 401, 21, 101, 7, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 51, "17", "12", "RsCheckbox", 0, "Is_Dirty", 47, 56, 18, 128, 8, "Is_Dirty (delete me)", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 51, "18", "12", "RsTextbox", 0, "Modified_On", 47, 675, 20, 209, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 51, "19", "12", "RsTextbox", 0, "Created_On", 20, 675, 20, 209, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 51, "20", "12", "RsTextbox", 0, "Created_By", 21, 508, 20, 161, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 51, "21", "12", "RsTextbox", 0, "Modified_By", 47, 508, 20, 161, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 51, "22", "12", "RsLabel", 0, "", 20, 408, 21, 94, 13, "Created By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 51, "23", "11", "RsGroupBox", 0, "", 29, 18, 63, 893, 14, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 51, "24", "23", "RsTextbox", 0, "Voltage", 19, 73, 20, 214, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 51, "25", "23", "RsTextbox", 0, "Sort_Order", 19, 349, 20, 214, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 51, "26", "23", "RsLabel", 0, "", 19, 9, 25, 58, 17, "Voltage:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 51, "27", "23", "RsLabel", 0, "", 19, 302, 25, 41, 18, "Sort:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 51, "28", "23", "RsActionButton", 0, "", 19, 765, 34, 120, 19, "Save Selected Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_Voltage_Master_Save;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 51, "29", "0", "RsLabel", 0, "Row_DBKeys", 554, 24, 21, 150, 20, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 51, "30", "0", "RsActionButton", 0, "", 557, 446, 27, 98, 21, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 51, "31", "0", "RsActionButton", 0, "", 557, 580, 23, 75, 22, "Add Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Add;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 51, "32", "0", "RsActionButton", 0, "", 557, 661, 23, 75, 23, "Delete Row", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_Master_Row_Delete;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 51, "33", "0", "RsActionButton", 0, "", 557, 776, 27, 119, 24, "Save Changed Row(s)", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:ADM_Voltage_Master_Save_Changed;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_RSXLI_PLI_Search_Data()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(43, "RSXLI_PLI_Search_Data", "", 1, 26, 1, 19, 50, 50)
        oProcessStep.AddPath("ADM_Data_Master_App.RSXLI_PLI_Search_Data/RSXLI_PLI_Search_Data")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 98, "1", "0", "RsGrid", 0, "", 47, 3, 506, 1313, 0, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,113,Rows;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True;SelectedPartPropertyName:Selected_Row")
        oProcessStep.AddCustomLayout(1, 98, "2", "1", "RsGridColumn", 0, "RSXLI_PLI_Search_Data_Id", 0, 0, 0, 50, 0, "ID (PK)", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 98, "3", "1", "RsGridColumn", 0, "Project_ID", 0, 0, 0, 70, 0, "Project ID", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 98, "4", "1", "RsGridColumn", 0, "LineItem_ID", 0, 0, 0, 35, 0, "LI ID", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 98, "5", "1", "RsGridColumn", 0, "Project_Number", 0, 0, 0, 100, 0, "Project Number", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 98, "6", "1", "RsGridColumn", 0, "Project_Name", 0, 0, 0, 220, 0, "Project Name", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 98, "7", "1", "RsGridColumn", 0, "SFDC_Opportunity_ID", 0, 0, 0, 100, 0, "Opportunity ID", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 98, "8", "1", "RsGridColumn", 0, "Pole", 0, 0, 0, 70, 0, "Pole", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 98, "9", "1", "RsGridColumn", 0, "Honeywell_Designer", 0, 0, 0, 150, 0, "Honeywell Designer", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 98, "10", "1", "RsGridColumn", 0, "Honeywell_PM", 0, 0, 0, 150, 0, "Honeywell PM", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:True")
        oProcessStep.AddCustomLayout(1, 98, "11", "1", "RsGridColumn", 0, "SAP_Plant", 0, 0, 0, 60, 0, "SAP Plant", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 98, "12", "1", "RsGridColumn", 0, "Project_Type", 0, 0, 0, 70, 0, "Proj Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 98, "13", "1", "RsGridColumn", 0, "Country", 0, 0, 0, 100, 0, "Country", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 98, "14", "1", "RsGridColumn", 0, "Vertical", 0, 0, 0, 70, 0, "Vertical", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 98, "15", "1", "RsGridColumn", 0, "Region", 0, 0, 0, 70, 0, "Region", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:True;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 98, "16", "0", "RsLabel", 0, "", 7, 12, 37, 335, 1, "RSXLI_PLI Search Data Master", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 98, "17", "0", "RsLabel", 0, "Row_DBKeys", 563, 2, 16, 96, 2, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 98, "18", "0", "RsActionButton", 0, "", 559, 1189, 27, 98, 3, "Refresh", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:;FunctionToCall:Adm_RSXLI_PLI_Search_Data_LoadFromDB;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 98, "19", "0", "RsSubForm", 0, "", 592, 3, 191, 1316, 4, "", 0, 0, 0, 5, 0, "", "", "SubpartConnection:S,113,Rows")
        oProcessStep.AddCustomLayout(1, 98, "20", "19", "RsGroupBox", 0, "", 130, 2, 51, 1300, 5, "Audit / Info", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 98, "21", "20", "RsTextbox", 0, "Data_Hash", 18, 54, 19, 423, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 98, "22", "20", "RsLabel", 0, "", 18, 9, 25, 39, 7, "Hash:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 98, "23", "20", "RsLabel", 0, "", 16, 895, 21, 68, 8, "Modified By:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 98, "24", "20", "RsTextbox", 0, "LastUpdateDate_1", 17, 1136, 20, 158, 9, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 98, "25", "20", "RsTextbox", 0, "LastUpdateUser", 17, 969, 20, 161, 10, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:True;")
        oProcessStep.AddCustomLayout(1, 98, "26", "19", "RsGroupBox", 0, "", 3, 3, 121, 1300, 11, "Data", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 98, "27", "26", "RsLabel", 0, "", 19, 843, 27, 46, 12, "Project Type:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 98, "28", "26", "RsActionButton", 0, "", 19, 1174, 34, 120, 13, "Launch Selected", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:3;Enabled:Is_Dirty;FunctionToCall:ADM_RSXLI_PLI_Search_Data_Launch;ActionButtonBehavior:0;ImmediateReturnMessageTitle:;ImmediateReturnMessageText:;")
        oProcessStep.AddCustomLayout(1, 98, "29", "26", "RsTextbox", 0, "Vertical", 19, 1054, 20, 99, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 98, "30", "26", "RsTextbox", 0, "Project_Name", 24, 54, 20, 631, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 98, "31", "26", "RsTextbox", 0, "SFDC_Opportunity_ID", 53, 586, 20, 99, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 98, "32", "26", "RsTextbox", 0, "Project_ID", 85, 1166, 20, 79, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 98, "33", "26", "RsLabel", 0, "", 19, 9, 37, 38, 18, "Project Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 98, "34", "26", "RsTextbox", 0, "LineItem_ID", 85, 1251, 20, 43, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 98, "35", "26", "RsTextbox", 0, "SAP_Plant", 53, 738, 20, 99, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 98, "36", "26", "RsTextbox", 0, "Pole", 19, 738, 20, 99, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 98, "37", "26", "RsLabel", 0, "", 66, 1166, 20, 128, 22, "Project, LineItem:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 98, "38", "26", "RsLabel", 0, "", 53, 516, 25, 64, 23, "Opportunity ID:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 98, "39", "26", "RsLabel", 0, "", 50, 701, 25, 31, 24, "SAP Plant:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 98, "40", "26", "RsLabel", 0, "", 19, 701, 25, 31, 25, "Pole:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 98, "41", "26", "RsTextbox", 0, "Country", 53, 895, 20, 99, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 98, "42", "26", "RsLabel", 0, "", 53, 843, 25, 46, 27, "Country:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 98, "43", "26", "RsTextbox", 0, "Region", 53, 1054, 20, 99, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 98, "44", "26", "RsTextbox", 0, "Project_Type", 19, 895, 20, 99, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 98, "45", "26", "RsLabel", 0, "", 53, 1000, 25, 48, 30, "Region:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 98, "46", "26", "RsLabel", 0, "", 19, 1000, 25, 48, 31, "Vertical:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        
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
            If Incontext("-1", ctx) Then
          
        InitSubpart("Application_Master", 107, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "7/9/2025 10:38:03 AM", "", "In Development", "N",0,245,244)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Controller_Family_Master", 91, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "6/28/2025 1:34:17 PM", "", "In Development", "N",0,211,210)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Controller_Protocol_Master", 85, "", "", "Y", 0, "-1", "", "GLOBAL\H601422", "6/27/2025 5:26:21 PM", "", "In Development", "N",0,199,198)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Controller_Spl_Feature_Master", 92, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "6/28/2025 1:40:41 PM", "", "In Development", "N",0,213,212)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("CPU_IO_Master", 93, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "6/28/2025 1:48:52 PM", "", "In Development", "N",0,215,214)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Device_Type_Master", 108, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "7/9/2025 10:39:28 AM", "", "In Development", "N",0,247,246)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Engg_Units_Master", 98, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "6/30/2025 1:32:19 PM", "", "In Development", "N",0,225,224)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Parameter_Name_Master", 109, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "7/9/2025 10:44:49 AM", "", "In Development", "N",0,249,248)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Part_Type_Master", 110, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "7/9/2025 10:47:31 AM", "", "In Development", "N",0,251,250)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Parts_Accessory_Mapping_Master", 95, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "6/28/2025 2:04:06 PM", "", "In Development", "N",0,219,218)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Point_Type_Master", 94, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "6/28/2025 1:57:08 PM", "", "In Development", "N",0,217,216)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Pole_Master", 74, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "6/20/2025 4:46:48 PM", "", "In Development", "N",0,175,174)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Process_Variable_Master", 90, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "6/28/2025 12:55:13 PM", "", "In Development", "N",0,209,208)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("RSXLI_PLI_Search_Data", 100, "", "", "Y", 0, "-1", "", "GLOBAL\H601422", "7/1/2025 2:02:40 AM", "", "In Development", "N",0,230,229)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Signal_Type_Master", 79, "", "", "Y", 0, "-1", "", "GLOBAL\H601422", "6/25/2025 2:31:07 AM", "", "In Development", "N",0,186,185)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Standards_Master", 111, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "7/9/2025 10:50:16 AM", "", "In Development", "N",0,253,252)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Std_Wiring_Detail_Master", 96, "", "", "Y", 0, "-1", "", "GLOBAL\H601423", "6/28/2025 2:27:57 PM", "", "In Development", "N",0,221,220)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Voltage_Master", 72, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "6/20/2025 3:54:53 PM", "", "In Development", "N",0,170,169)
        
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
      Public Function Process_DefaultProcess_Introduction_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:21; TYPE:ST
      result = STATUS_ENABLED
      '   END FORMULA; PROC ID:21; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Introduction_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Introduction_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:21; TYPE:CO
      result = ""
      '   END FORMULA; PROC ID:21; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Introduction_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Engineering_Units_Master_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:38; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:38; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Engineering_Units_Master_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Engineering_Units_Master_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:38; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:38; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Engineering_Units_Master_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Pole_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:22; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:22; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Pole_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Pole_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:22; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:22; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Pole_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Application_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:44; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:44; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Application_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Application_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:44; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:44; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Application_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Controller_Family_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:32; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:32; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Controller_Family_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Controller_Family_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:32; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:32; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Controller_Family_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Controller_Special_Features_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:33; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:33; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Controller_Special_Features_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Controller_Special_Features_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:33; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:33; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Controller_Special_Features_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Controller_Protocol_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:30; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:30; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Controller_Protocol_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Controller_Protocol_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:30; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:30; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Controller_Protocol_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_CPU_IO_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:34; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:34; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_CPU_IO_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_CPU_IO_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:34; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:34; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_CPU_IO_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Device_Type_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:45; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:45; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Device_Type_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Device_Type_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:45; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:45; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Device_Type_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Parameter_Name_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:46; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:46; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Parameter_Name_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Parameter_Name_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:46; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:46; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Parameter_Name_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Part_Type_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:47; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:47; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Part_Type_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Part_Type_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:47; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:47; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Part_Type_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Point_Type_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:35; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:35; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Point_Type_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Point_Type_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:35; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:35; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Point_Type_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Process_Variable_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:31; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:31; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Process_Variable_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Process_Variable_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:31; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:31; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Process_Variable_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Parts_Accessory_Mapping_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:36; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:36; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Parts_Accessory_Mapping_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Parts_Accessory_Mapping_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:36; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:36; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Parts_Accessory_Mapping_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Standard_Wiring_Detail_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:37; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:37; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Standard_Wiring_Detail_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Standard_Wiring_Detail_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:37; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:37; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Standard_Wiring_Detail_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Standards_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:48; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:48; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Standards_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Standards_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:48; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:48; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Standards_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Signal_Type_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:28; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:28; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Signal_Type_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Signal_Type_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:28; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:28; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Signal_Type_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Voltage_Masters_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:23; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:23; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Voltage_Masters_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Voltage_Masters_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:23; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:23; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_Voltage_Masters_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_RSXLI_PLI_Search_Data_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:43; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:43; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_RSXLI_PLI_Search_Data_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_RSXLI_PLI_Search_Data_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:43; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:43; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Process_DefaultProcess_RSXLI_PLI_Search_Data_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Application_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:107; TYPE:PN
      
      '   END FORMULA; SUB ID:107; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Application_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Application_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Application_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:107; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:107; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Application_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Application_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Application_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:107; TYPE:OP
      result = "ADM_Application_Master"
      '   END FORMULA; SUB ID:107; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Application_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_Family_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:91; TYPE:PN
      
      '   END FORMULA; SUB ID:91; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Controller_Family_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_Family_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Controller_Family_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:91; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:91; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Controller_Family_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_Family_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Controller_Family_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:91; TYPE:OP
      result = "ADM_Controller_Family_Master"
      '   END FORMULA; SUB ID:91; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Controller_Family_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_Protocol_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:85; TYPE:PN
      
      '   END FORMULA; SUB ID:85; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Controller_Protocol_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_Protocol_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Controller_Protocol_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:85; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:85; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Controller_Protocol_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_Protocol_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Controller_Protocol_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:85; TYPE:OP
      result = "ADM_Controller_Protocol_Master"
      '   END FORMULA; SUB ID:85; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Controller_Protocol_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_Spl_Feature_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:92; TYPE:PN
      
      '   END FORMULA; SUB ID:92; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Controller_Spl_Feature_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_Spl_Feature_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Controller_Spl_Feature_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:92; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:92; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Controller_Spl_Feature_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Controller_Spl_Feature_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Controller_Spl_Feature_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:92; TYPE:OP
      result = "ADM_Controller_Spl_Feature_Master"
      '   END FORMULA; SUB ID:92; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Controller_Spl_Feature_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CPU_IO_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:93; TYPE:PN
      
      '   END FORMULA; SUB ID:93; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_CPU_IO_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CPU_IO_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("CPU_IO_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:93; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:93; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_CPU_IO_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CPU_IO_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("CPU_IO_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:93; TYPE:OP
      result = "ADM_CPU_IO_Master"
      '   END FORMULA; SUB ID:93; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_CPU_IO_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Device_Type_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:108; TYPE:PN
      
      '   END FORMULA; SUB ID:108; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Device_Type_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Device_Type_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Device_Type_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:108; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:108; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Device_Type_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Device_Type_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Device_Type_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:108; TYPE:OP
      result = "ADM_Device_Type_Master"
      '   END FORMULA; SUB ID:108; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Device_Type_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Engg_Units_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:98; TYPE:PN
      
      '   END FORMULA; SUB ID:98; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Engg_Units_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Engg_Units_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Engg_Units_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:98; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:98; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Engg_Units_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Engg_Units_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Engg_Units_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:98; TYPE:OP
      result = "ADM_Engg_Units_Master"
      '   END FORMULA; SUB ID:98; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Engg_Units_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Parameter_Name_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:109; TYPE:PN
      
      '   END FORMULA; SUB ID:109; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Parameter_Name_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Parameter_Name_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Parameter_Name_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:109; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:109; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Parameter_Name_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Parameter_Name_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Parameter_Name_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:109; TYPE:OP
      result = "ADM_Parameter_Name_Master"
      '   END FORMULA; SUB ID:109; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Parameter_Name_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Part_Type_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:110; TYPE:PN
      
      '   END FORMULA; SUB ID:110; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Part_Type_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Part_Type_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Part_Type_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:110; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:110; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Part_Type_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Part_Type_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Part_Type_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:110; TYPE:OP
      result = "ADM_Part_Type_Master"
      '   END FORMULA; SUB ID:110; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Part_Type_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Parts_Accessory_Mapping_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:95; TYPE:PN
      
      '   END FORMULA; SUB ID:95; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Parts_Accessory_Mapping_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Parts_Accessory_Mapping_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Parts_Accessory_Mapping_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:95; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:95; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Parts_Accessory_Mapping_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Parts_Accessory_Mapping_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Parts_Accessory_Mapping_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:95; TYPE:OP
      result = "ADM_Parts_Accessory_Mapping_Master"
      '   END FORMULA; SUB ID:95; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Parts_Accessory_Mapping_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point_Type_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:94; TYPE:PN
      
      '   END FORMULA; SUB ID:94; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Point_Type_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point_Type_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Point_Type_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:94; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:94; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Point_Type_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Point_Type_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Point_Type_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:94; TYPE:OP
      result = "ADM_Point_Type_Master"
      '   END FORMULA; SUB ID:94; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Point_Type_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pole_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:74; TYPE:PN
      
      '   END FORMULA; SUB ID:74; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Pole_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pole_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Pole_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:74; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:74; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Pole_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pole_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Pole_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:74; TYPE:OP
      result = "ADM_Pole_Master"
      '   END FORMULA; SUB ID:74; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Pole_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Process_Variable_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:90; TYPE:PN
      
      '   END FORMULA; SUB ID:90; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Process_Variable_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Process_Variable_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Process_Variable_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:90; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:90; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Process_Variable_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Process_Variable_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Process_Variable_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:90; TYPE:OP
      result = "ADM_Process_Variable_Master"
      '   END FORMULA; SUB ID:90; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Process_Variable_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RSXLI_PLI_Search_Data_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:100; TYPE:PN
      
      '   END FORMULA; SUB ID:100; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_RSXLI_PLI_Search_Data_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RSXLI_PLI_Search_Data_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("RSXLI_PLI_Search_Data").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:100; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:100; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_RSXLI_PLI_Search_Data_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_RSXLI_PLI_Search_Data_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("RSXLI_PLI_Search_Data").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:100; TYPE:OP
      result = "RSXLI_PLI_Search_Data"
      '   END FORMULA; SUB ID:100; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_RSXLI_PLI_Search_Data_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Signal_Type_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:79; TYPE:PN
      
      '   END FORMULA; SUB ID:79; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Signal_Type_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Signal_Type_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Signal_Type_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:79; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:79; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Signal_Type_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Signal_Type_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Signal_Type_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:79; TYPE:OP
      result = "ADM_Signal_Type_Master"
      '   END FORMULA; SUB ID:79; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Signal_Type_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Standards_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:111; TYPE:PN
      
      '   END FORMULA; SUB ID:111; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Standards_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Standards_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Standards_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:111; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:111; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Standards_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Standards_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Standards_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:111; TYPE:OP
      result = "ADM_Standards_Master"
      '   END FORMULA; SUB ID:111; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Standards_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Std_Wiring_Detail_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:96; TYPE:PN
      
      '   END FORMULA; SUB ID:96; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Std_Wiring_Detail_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Std_Wiring_Detail_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Std_Wiring_Detail_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:96; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:96; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Std_Wiring_Detail_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Std_Wiring_Detail_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Std_Wiring_Detail_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:96; TYPE:OP
      result = "ADM_Std_Wiring_Detail_Master"
      '   END FORMULA; SUB ID:96; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Std_Wiring_Detail_Master_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Voltage_Master_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:72; TYPE:PN
      
      '   END FORMULA; SUB ID:72; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Voltage_Master_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Voltage_Master_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Voltage_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:72; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:72; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Voltage_Master_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Voltage_Master_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Voltage_Master").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:72; TYPE:OP
      result = "ADM_Voltage_Master"
      '   END FORMULA; SUB ID:72; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " ADM_Data_Master_App.Formula_Voltage_Master_OPTIMALPARTFAMILY", ex.Message)
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
    
      AddHandler ObjectManager.RsEngineer.RsBeforeSave, AddressOf g_RsEngineer_BeforeSave
      AddHandler ObjectManager.RsEngineer.RsActionButtonClick, AddressOf g_rsEngineer_RsActionButtonClick
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Overrides Sub RemoveRsEventHandlerMappings()
    
      RemoveHandler ObjectManager.RsEngineer.RsBeforeSave, AddressOf g_RsEngineer_BeforeSave
      RemoveHandler ObjectManager.RsEngineer.RsActionButtonClick, AddressOf g_rsEngineer_RsActionButtonClick
    End Sub
    #End Region

    End Class

  