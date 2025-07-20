Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: CAE_APC_Sorter_App_Details
'$ GenerateDate: 07/20/2025 19:33:46

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

    Public Class [CAE_APC_Sorter_App_Details]
    
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

    Private this as CAE_APC_Sorter_App_Details = me

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
    
          Public Property [Check_Width]() As Boolean
      Get
      Return Properties("Check_Width").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Check_Width").CalculatedValue = Value
      End Set
      End Property
    
          Public Shadows Property [DisplayName]() As String
      Get
      Return Properties("DisplayName").Value
      End Get
      Set(ByVal Value As String)
      Properties("DisplayName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Divert_Angle]() As Long
      Get
      Return Properties("Divert_Angle").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Divert_Angle").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Avail]() As Long
      Get
      Return Properties("Faults_Avail").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Avail").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Length_Max]() As Long
      Get
      Return Properties("Faults_Length_Max").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Length_Max").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Length_Min]() As Long
      Get
      Return Properties("Faults_Length_Min").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Length_Min").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Rate]() As Long
      Get
      Return Properties("Faults_Rate").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Rate").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Sides]() As Long
      Get
      Return Properties("Faults_Sides").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Sides").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Temp_Min_Operating_Min]() As Long
      Get
      Return Properties("Faults_Temp_Min_Operating_Min").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Temp_Min_Operating_Min").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Total]() As Long
      Get
      Return Properties("Faults_Total").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Total").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Weight_Max]() As Long
      Get
      Return Properties("Faults_Weight_Max").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Weight_Max").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Weight_Min]() As Long
      Get
      Return Properties("Faults_Weight_Min").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Weight_Min").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Width_Max]() As Long
      Get
      Return Properties("Faults_Width_Max").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Width_Max").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Faults_Width_Min]() As Long
      Get
      Return Properties("Faults_Width_Min").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Faults_Width_Min").CalculatedValue = Value
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
    
          Public Property [Gap_Min_IN]() As Double
      Get
      Return Properties("Gap_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Gap_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Grid_Icon]() As String
      Get
      Return Properties("Grid_Icon").Value
      End Get
      Set(ByVal Value As String)
      Properties("Grid_Icon").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Length_Max_IN]() As Double
      Get
      Return Properties("Length_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Length_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Length_Min_IN]() As Double
      Get
      Return Properties("Length_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Length_Min_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Model]() As String
      Get
      Return Properties("Model").Value
      End Get
      Set(ByVal Value As String)
      Properties("Model").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [OwnerName]() As String
      Get
      Return Properties("OwnerName").Value
      End Get
      Set(ByVal Value As String)
      Properties("OwnerName").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [PK_ID]() As Long
      Get
      Return Properties("PK_ID").Value
      End Get
      Set(ByVal Value As Long)
      Properties("PK_ID").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Rate_Max_Formatted]() As String
      Get
      Return Properties("Rate_Max_Formatted").Value
      End Get
      Set(ByVal Value As String)
      Properties("Rate_Max_Formatted").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Rate_Max_IN]() As Double
      Get
      Return Properties("Rate_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Rate_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Shoe_Set]() As Boolean
      Get
      Return Properties("Shoe_Set").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("Shoe_Set").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sides]() As String
      Get
      Return Properties("Sides").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sides").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Sorter_Type]() As String
      Get
      Return Properties("Sorter_Type").Value
      End Get
      Set(ByVal Value As String)
      Properties("Sorter_Type").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Speed_Max_RPM]() As Long
      Get
      Return Properties("Speed_Max_RPM").Value
      End Get
      Set(ByVal Value As Long)
      Properties("Speed_Max_RPM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Temp_Min_Operating_F]() As Double
      Get
      Return Properties("Temp_Min_Operating_F").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Temp_Min_Operating_F").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Weight_Max_LBS]() As Double
      Get
      Return Properties("Weight_Max_LBS").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Weight_Max_LBS").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Weight_Min_LBS]() As Double
      Get
      Return Properties("Weight_Min_LBS").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Weight_Min_LBS").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Width_Max_IN]() As Double
      Get
      Return Properties("Width_Max_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Width_Max_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Width_Min_IN]() As Double
      Get
      Return Properties("Width_Min_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("Width_Min_IN").CalculatedValue = Value
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
    
      Public ReadOnly Property [dbInfo]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("dbInfo")
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
    InitPart("CAE_APC_Sorter_App_Details", <a><![CDATA[CAE_APC_Sorter_App_Details]]></a>.Value, 443, "APCTMP01",  "N", "N", True, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/20/2025 19:33:41")
    AddProperty("10872", "Check_Width", <a><![CDATA[Check_Width]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 3:08:47 PM")
    AddProperty("10882", "DisplayName", <a><![CDATA[DisplayName]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 4:51:13 PM")
    AddProperty("10870", "Divert_Angle", <a><![CDATA[Divert_Angle]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 3:14:27 PM")
    AddProperty("10824", "Faults_Avail", <a><![CDATA[Faults Avail]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 1:07:41 PM")
    AddProperty("10825", "Faults_Length_Max", <a><![CDATA[Faults Length Max]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 7:33:09 PM")
    AddProperty("10826", "Faults_Length_Min", <a><![CDATA[Faults Length Min]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 7:23:56 PM")
    AddProperty("10827", "Faults_Rate", <a><![CDATA[Faults Rate]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 1:07:41 PM")
    AddProperty("10828", "Faults_Sides", <a><![CDATA[Faults Sides]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 7:42:06 PM")
    AddProperty("10829", "Faults_Temp_Min_Operating_Min", <a><![CDATA[Faults Temp Min Operating Min]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 7:29:56 PM")
    AddProperty("10830", "Faults_Total", <a><![CDATA[Faults Total]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 7:45:53 PM")
    AddProperty("10832", "Faults_Weight_Max", <a><![CDATA[Faults Weight Max]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 7:33:41 PM")
    AddProperty("10833", "Faults_Weight_Min", <a><![CDATA[Faults Weight Min]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 7:33:09 PM")
    AddProperty("10883", "Faults_Width_Max", <a><![CDATA[Faults_Width_Max]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 7:32:26 PM")
    AddProperty("10834", "Faults_Width_Min", <a><![CDATA[Faults Width Min]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 7:26:34 PM")
    AddProperty("10861", "Gap_Design", <a><![CDATA[Gap_Design]]></a>.Value, "Design Gap From Sortation Screen", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 1:45:54 PM")
    AddProperty("10835", "Gap_Min_IN", <a><![CDATA[Gap Min IN]]></a>.Value, "Extra gap required to prevent ""scissoring"". 18"" per Product Management & Sorter Group 3/16/16. Check with Engineering if smaller gaps are needed.", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 7:19:12 PM")
    AddProperty("10920", "Grid_Icon", <a><![CDATA[Grid_Icon]]></a>.Value, "Icon for Grids that represent status of the Item compared to the application", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 2:03:30 PM")
    AddProperty("10836", "Length_Max_IN", <a><![CDATA[Length Max  IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 1:07:41 PM")
    AddProperty("10837", "Length_Min_IN", <a><![CDATA[Length Min IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 1:07:41 PM")
    AddProperty("10868", "Model", <a><![CDATA[Model]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 2:37:42 PM")
    AddProperty("10885", "OwnerName", <a><![CDATA[OwnerName]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 2:22:52 PM")
    AddProperty("10838", "PK_ID", <a><![CDATA[PK_ID]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 8:16:28 PM")
    AddProperty("10922", "Rate_Max_Formatted", <a><![CDATA[Rate_Max_Formatted]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 2:28:57 PM")
    AddProperty("10839", "Rate_Max_IN", <a><![CDATA[Rate Max IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 7:08:00 PM")
    AddProperty("10921", "Shoe_Set", <a><![CDATA[Shoe_Set]]></a>.Value, "", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 3:08:36 PM")
    AddProperty("10871", "Sides", <a><![CDATA[Sides]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 3:15:04 PM")
    AddProperty("10840", "Sorter_Type", <a><![CDATA[Sorter Type]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 1:07:41 PM")
    AddProperty("10841", "Speed_Max_RPM", <a><![CDATA[Speed Max RPM]]></a>.Value, "", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 1:07:41 PM")
    AddProperty("10842", "Temp_Min_Operating_F", <a><![CDATA[Temp Min Operating F]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 1:07:41 PM")
    AddProperty("10939", "Weight_Max_LBS", <a><![CDATA[Weight_Max_LBS]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 7:28:10 PM")
    AddProperty("10940", "Weight_Min_LBS", <a><![CDATA[Weight_Min_LBS]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/20/2025 7:28:17 PM")
    AddProperty("10845", "Width_Max_IN", <a><![CDATA[Width Max  IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 1:07:41 PM")
    AddProperty("10846", "Width_Min_IN", <a><![CDATA[Width Min IN]]></a>.Value, "", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 1:07:41 PM")
    AddProperty("10823", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/19/2025 1:07:41 PM")
    
      oSubpart = AddSubpart(354,"dbInfo", <a><![CDATA[dbInfo]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "7/19/2025 1:10:08 PM")
      
        oSubpart.AddVPF (444, "CAE_APC_Sorter_App_Details_dbInfo", "CAE_APC_Sorter_App_Details_dbInfo")
      
      oConnection = AddConnection("My_PRD", <a><![CDATA[My PRD]]></a>.Value, "", "218", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/19/2025 2:44:02 PM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      
      oConnection = AddConnection("My_Setup", <a><![CDATA[My_Setup]]></a>.Value, "My App Calc Setup Object", "219", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/19/2025 2:44:02 PM")
      
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
          InitProperty("Check_Width", "10426", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 3:08:47 PM", "", "In Development",  0,19524)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("DisplayName", "10436", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 4:51:13 PM", "", "In Development",  0,19572)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Divert_Angle", "10424", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 3:14:27 PM", "", "In Development",  0,19522)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Avail", "10381", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 1:07:41 PM", "", "In Development",  0,19424)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Length_Max", "10382", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 7:33:09 PM", "", "In Development",  0,19662)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Length_Min", "10383", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 7:23:56 PM", "", "In Development",  0,19650)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Rate", "10384", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 1:07:41 PM", "", "In Development",  0,19427)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Sides", "10385", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 7:42:06 PM", "", "In Development",  0,19665)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Temp_Min_Operating_Min", "10386", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 7:29:56 PM", "", "In Development",  0,19658)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Total", "10387", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 7:45:53 PM", "", "In Development",  0,19666)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Weight_Max", "10389", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 7:33:41 PM", "", "In Development",  0,20095)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Weight_Min", "10390", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 7:33:09 PM", "", "In Development",  0,20094)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Width_Max", "10437", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 7:32:26 PM", "", "In Development",  0,19659)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Faults_Width_Min", "10391", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 7:26:34 PM", "", "In Development",  0,19653)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Design", "10417", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 1:44:14 PM", "", "In Development",  0,19490)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Gap_Min_IN", "10392", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 7:16:33 PM", "", "In Development",  0,19648)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Grid_Icon", "10473", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 2:03:30 PM", "", "In Development",  0,20038)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Length_Max_IN", "10393", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 1:07:41 PM", "", "In Development",  0,19436)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Length_Min_IN", "10394", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 1:07:41 PM", "", "In Development",  0,19437)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Model", "10422", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 2:37:42 PM", "", "In Development",  0,19513)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("OwnerName", "10439", "", "", "N", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:17:32 PM", "", "In Development",  0,19671)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("PK_ID", "10395", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 8:16:28 PM", "", "In Development",  0,19670)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Rate_Max_Formatted", "10475", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 2:28:50 PM", "", "In Development",  0,20041)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Rate_Max_IN", "10396", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 7:08:00 PM", "", "In Development",  0,19646)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Shoe_Set", "10474", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 3:08:36 PM", "", "In Development",  0,20043)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sides", "10425", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 3:15:04 PM", "", "In Development",  0,19523)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sorter_Type", "10397", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 1:07:41 PM", "", "In Development",  0,19440)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Speed_Max_RPM", "10398", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 1:07:41 PM", "", "In Development",  0,19441)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Temp_Min_Operating_F", "10399", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 1:07:41 PM", "", "In Development",  0,19442)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Weight_Max_LBS", "10492", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 7:28:10 PM", "", "In Development",  0,20092)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Weight_Min_LBS", "10493", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/20/2025 7:28:17 PM", "", "In Development",  0,20093)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Width_Max_IN", "10402", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 1:07:41 PM", "", "In Development",  0,19445)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Width_Min_IN", "10403", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/19/2025 1:07:41 PM", "", "In Development",  0,19446)
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
            If Incontext("-1", ctx) Then
          
        InitSubpart("dbInfo", 281, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "7/19/2025 1:10:08 PM", "", "In Development", "N",0,780,778)
        
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
          
        InitConnection("My_PRD", "197", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/19/2025 2:44:02 PM", "", "In Development", "N",351)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Setup", "198", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/19/2025 2:44:02 PM", "", "In Development", "N",352)
        
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
        '   BEGIN FORMULA; CON ID:197; TYPE:PF
        Result = Me.Parent.My_Prd(1)
        '   END FORMULA; CON ID:197; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_My_PRD_PARTS", ex.Message)
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
        '   BEGIN FORMULA; CON ID:198; TYPE:PF
        Result = Me.Parent.My_Setup(1)
        '   END FORMULA; CON ID:198; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_My_Setup_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
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
      '   BEGIN FORMULA; PROP ID:10426; TYPE:PF
      Result = False
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10426; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Check_Width", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
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
      '   BEGIN FORMULA; PROP ID:10436; TYPE:PF
      Result = Me.Model
      '   END FORMULA; PROP ID:10436; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_DisplayName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Divert_Angle() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Divert_Angle").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10424; TYPE:PF
      Result = 0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10424; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Divert_Angle", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Avail() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Avail").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10381; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10381; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Faults_Avail", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Length_Max() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Length_Max").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10382; TYPE:PF
      Result =If(Me.My_Setup(1).BoxSize_Length_Max_IN > Me.Length_Max_IN,1,0)
      '   END FORMULA; PROP ID:10382; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Faults_Length_Max", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Length_Min() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Length_Min").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10383; TYPE:PF
      Result =If(Me.My_Setup(1).BoxSize_Length_Min_IN< Me.Length_Min_IN,1,0)
      '   END FORMULA; PROP ID:10383; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Faults_Length_Min", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Rate() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Rate").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10384; TYPE:PF
      Result = 0
      '   END FORMULA; PROP ID:10384; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Faults_Rate", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Sides() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Sides").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10385; TYPE:PF
      Result = 0

If Me.My_Setup(1).Sort_Dual_Sided Then
	If (Me.Sides = "SS") Then Result = 1
Else	
	If (Me.Sides = "DS") Then Result = 1
End If
      '   END FORMULA; PROP ID:10385; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Faults_Sides", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Temp_Min_Operating_Min() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Temp_Min_Operating_Min").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10386; TYPE:PF
      Result = If(Me.My_Setup(1).Temp_Sort_Operating_Min_F < Me.Temp_Min_Operating_F,1,0)
      '   END FORMULA; PROP ID:10386; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Faults_Temp_Min_Operating_Min", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Total() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Total").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10387; TYPE:PF
      Result = Me.Faults_Avail + Me.Faults_Length_Max + Me.Faults_Length_Min + Me.Faults_Rate + Me.Faults_Sides + Me.Faults_Temp_Min_Operating_Min + Me.Faults_Weight_Max + Me.Faults_Weight_Min + Me.Faults_Width_Max + me.Faults_Width_Min
      '   END FORMULA; PROP ID:10387; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Faults_Total", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Weight_Max() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Weight_Max").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10389; TYPE:PF
      Result = If(Me.My_Setup(1).BoxSize_Weight_Max_LBS > Me.Weight_Max_LBS,1,0)
      '   END FORMULA; PROP ID:10389; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Faults_Weight_Max", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Weight_Min() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Weight_Min").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10390; TYPE:PF
      Result = If(Me.My_Setup(1).BoxSize_Weight_Min_Lbs < Me.Weight_Min_LBS,1,0)
      '   END FORMULA; PROP ID:10390; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Faults_Weight_Min", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Width_Max() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Width_Max").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10437; TYPE:PF
      Result = If(Me.My_Setup(1).BoxSize_Width_Max_IN > Me.Width_Max_IN,1,0)
      '   END FORMULA; PROP ID:10437; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Faults_Width_Max", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Faults_Width_Min() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Faults_Width_Min").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10391; TYPE:PF
      Result = If(Me.My_Setup(1).BoxSize_Width_Min_IN< Me.Width_Min_IN,1,0)
      '   END FORMULA; PROP ID:10391; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Faults_Width_Min", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:10417; TYPE:PF
      Result = Me.Parent.Gap_Design
      '   END FORMULA; PROP ID:10417; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Gap_Design", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Gap_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Gap_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10392; TYPE:PF
      Result = 0.0
'This Section  Corresponds to AppCalc Sortation and Lists-1 Sorters Table & Transnorm Tables
' Pull in standard values from Compoenent DB
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If

'Adjust Accordingly
Select Case Me.Sorter_Type
	Case "Shoe Sorters", "Intralox"
		Select Case Me.Model.Trim()
			Case = "Intralox 400" ' Special overides in AppCalc Spreadsheet Sorter Options E26, E28
				Result = My_Setup(1).BoxSize_Width_Avg_IN + 4
			Case = "Intralox DARB" ' Special overides in AppCalc Spreadsheet Sorter Options E26, E28
				Result = My_Setup(1).BoxSize_Width_Max_IN + 4
			Case "",""
			Case "HDS, Dual Sided, 20°"  ' Statically Set in AppCalc Spreadsheet to 17
				Result = Result 
			Case Else
				Result = MAX(Result,Me.Gap_Design)
		End Select
	Case "Wheel"
		Result =If(Me.Parent.Chosen_Sort_Speed_FPM <=180,16,If(Me.Parent.Chosen_Sort_Speed_FPM <=210,16.5,If(Me.Parent.Chosen_Sort_Speed_FPM<=240,17,If(Me.Parent.Chosen_Sort_Speed_FPM<=270,17.5,18))))
	Case "Transnform"
		'List-1 Transnorm Table Transformation
		Dim Endoder_Resolution As Double = 1.50
		Dim Worst_Case_Divert_Shift_IN As Double = ((Me.Speed_Max_RPM *12)/60)
		Dim Selected_Controller_Scan_Time_SEC As Double = .00100
		Dim Encoder_Pulse_Interval_at_Chosen_Speed As Double = 1/((Me.Parent.Chosen_Sort_Speed_FPM * 12)/60) * Selected_Controller_Scan_Time_SEC  '=1/((ChosenSortSpeed*12)/60)*X19
		Dim Worst_Case_Control_Reaction_Time_Distance As Double = Worst_Case_Divert_Shift_IN * Selected_Controller_Scan_Time_SEC  '=((E17*12)/60)*($X$18*2)
		Dim Worst_Case_Gap_At_MaxRPM As Double = Worst_Case_Divert_Shift_IN + Worst_Case_Control_Reaction_Time_Distance + Endoder_Resolution
		Dim Divert_Shifting_Distance As Double =  ((Me.Parent.Chosen_Sort_Speed_FPM  * 12) / 60)
		Dim Control_Reaction_Time_Distance As Double =Divert_Shifting_Distance*(Selected_Controller_Scan_Time_SEC * 2)
		Dim Required_Gap_For_Installation As Double = 0
					
		Select Case Model		
			Case "Transnorm TS4800 90° Single Sided"
				Endoder_Resolution = 0	
				'=((E16*12)/60)*0.6
				Worst_Case_Divert_Shift_IN = Worst_Case_Divert_Shift_IN * 0.6
				Divert_Shifting_Distance = Divert_Shifting_Distance * 0.6
				Worst_Case_Gap_At_MaxRPM = ((Me.My_Setup(1).BoxSize_Length_Max_IN + Me.My_Setup(1).BoxSize_Width_Max_IN)+ Worst_Case_Divert_Shift_IN)-Me.My_Setup(1).BoxSize_Length_Max_IN
				'=MIN(X9,X15)
				'=((BoxSize_Length_Max_IN+BoxSize_Width_Max_IN)+W5)-BoxSize_Length_Max_IN
				Endoder_Resolution = 0
				Control_Reaction_Time_Distance = 0
				Worst_Case_Control_Reaction_Time_Distance = 0
				Required_Gap_For_Installation = Divert_Shifting_Distance
			Case "Transnorm TS4800 45° Single Sided"
				Divert_Shifting_Distance = Divert_Shifting_Distance * 0.2	
				Worst_Case_Divert_Shift_IN = Worst_Case_Divert_Shift_IN * 0.2
			Case "Transnorm TS4800 30° Single Sided"		
				Divert_Shifting_Distance = Divert_Shifting_Distance * 0.15
				Worst_Case_Divert_Shift_IN = Worst_Case_Divert_Shift_IN * 0.2
			Case "Transnorm TS4800 45° Dual Sided"			
				Divert_Shifting_Distance = Divert_Shifting_Distance * 0.4
				Worst_Case_Divert_Shift_IN = Worst_Case_Divert_Shift_IN * 0.2
			Case "Transnorm TS4800 30° Dual Sided"
				Divert_Shifting_Distance = Divert_Shifting_Distance * 0.3
				Worst_Case_Divert_Shift_IN = Worst_Case_Divert_Shift_IN * 0.2
			Case Else
		End Select
		Required_Gap_For_Installation = Divert_Shifting_Distance * Control_Reaction_Time_Distance + Endoder_Resolution
		Result = Min(Required_Gap_For_Installation, Worst_Case_Gap_At_MaxRPM)
	Case Else
		Result = Result
End Select
      '   END FORMULA; PROP ID:10392; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Gap_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Grid_Icon() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Grid_Icon").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10473; TYPE:PF
      Result = "Bad.Icon.png"
If Me.Faults_Total = 0 Then
	Result = "Good.Icon.png"
End If
      '   END FORMULA; PROP ID:10473; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Grid_Icon", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Length_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Length_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10393; TYPE:PF
      result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10393; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Length_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Length_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Length_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10394; TYPE:PF
      result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10394; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Length_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Model() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Model").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10422; TYPE:PF
      result = ""
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10422; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Model", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_OwnerName() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("OwnerName").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10439; TYPE:PF
      Result = Me.Owner.Name
      '   END FORMULA; PROP ID:10439; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_OwnerName", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_PK_ID() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("PK_ID").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10395; TYPE:PF
      If Me.Owner.Name = "Selected_Sorter" Then
	Result = Me.Parent.Chosen_Sorter_ID
Else
	Result = Me.Parent.ValidValues("Sorter_Candidates_dbKeys")(Me.SubpartID-1)
End If
      '   END FORMULA; PROP ID:10395; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_PK_ID", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Rate_Max_Formatted() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Rate_Max_Formatted").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10475; TYPE:PF
      Result = Round(Me.Rate_Max_IN, 2)
      '   END FORMULA; PROP ID:10475; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Rate_Max_Formatted", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Rate_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Rate_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10396; TYPE:PF
      Result = 0.0

       '=Sort Choices'!D18/((E18+BoxSize_Length_Avg)/12)
Result = Me.Speed_Max_RPM /((Me.Gap_Min_In + Me.My_Setup(1).BoxSize_Length_Avg_IN)/12)
      '   END FORMULA; PROP ID:10396; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Rate_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Shoe_Set() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Shoe_Set").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10474; TYPE:PF
      Result = False
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).Value
End If
      '   END FORMULA; PROP ID:10474; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Shoe_Set", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sides() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sides").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10425; TYPE:PF
      result = ""
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10425; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Sides", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Sorter_Type() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sorter_Type").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10397; TYPE:PF
      result = ""
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10397; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Sorter_Type", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Speed_Max_RPM() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Speed_Max_RPM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10398; TYPE:PF
      result = 0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10398; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Speed_Max_RPM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Temp_Min_Operating_F() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Temp_Min_Operating_F").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10399; TYPE:PF
      result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10399; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Temp_Min_Operating_F", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Weight_Max_LBS() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Weight_Max_LBS").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10492; TYPE:PF
      Result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10492; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Weight_Max_LBS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Weight_Min_LBS() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Weight_Min_LBS").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10493; TYPE:PF
      Result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10493; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Weight_Min_LBS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Width_Max_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Width_Max_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10402; TYPE:PF
      result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10402; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Width_Max_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Width_Min_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Width_Min_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:10403; TYPE:PF
      result = 0.0
If Me.dbInfo.Quantity = 1 Then
	Dim MyPropertyName As String  = Me.CurrentProperty.Name
	Result = Me.dbInfo(1).Properties(MyPropertyName).DisplayValue
End If
      '   END FORMULA; PROP ID:10403; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_Width_Min_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
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
      Public Function Formula_DisplayName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Divert_Angle_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Avail_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Length_Max_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Length_Min_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Rate_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Sides_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Temp_Min_Operating_Min_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Total_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Weight_Max_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Weight_Min_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Width_Max_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Width_Min_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Gap_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Grid_Icon_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Model_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_OwnerName_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PK_ID_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Rate_Max_Formatted_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Rate_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Shoe_Set_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sides_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Type_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Max_RPM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_Min_Operating_F_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_Max_LBS_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_Min_LBS_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Width_Max_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Width_Min_IN_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_DisplayName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Divert_Angle_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Avail_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Length_Max_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Length_Min_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Rate_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Sides_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Temp_Min_Operating_Min_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Total_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Weight_Max_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Weight_Min_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Width_Max_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Faults_Width_Min_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_Gap_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Grid_Icon_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_Max_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Length_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Model_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_OwnerName_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_PK_ID_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Rate_Max_Formatted_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Rate_Max_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Shoe_Set_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sides_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sorter_Type_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Speed_Max_RPM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Temp_Min_Operating_F_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_Max_LBS_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Weight_Min_LBS_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Width_Max_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Width_Min_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_dbInfo_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:281; TYPE:PN
      
      '   END FORMULA; SUB ID:281; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_dbInfo_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_dbInfo_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("dbInfo").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:281; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:281; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_dbInfo_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_dbInfo_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("dbInfo").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:281; TYPE:OP
      Result = "CAE_APC_Sorter_App_Details_dbInfo"
      '   END FORMULA; SUB ID:281; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " CAE_APC_Sorter_App_Details.Formula_dbInfo_OPTIMALPARTFAMILY", ex.Message)
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

  