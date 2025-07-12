Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: APC_Scan_Configuration
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

    Public Class [APC_Scan_Configuration]
    
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

    Private this as APC_Scan_Configuration = me

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
    
          Public Property [AppType]() As String
      Get
      Return Properties("AppType").Value
      End Get
      Set(ByVal Value As String)
      Properties("AppType").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [BoxPanelsScanned]() As Long
      Get
      Return Properties("BoxPanelsScanned").Value
      End Get
      Set(ByVal Value As Long)
      Properties("BoxPanelsScanned").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [CartonPresentation]() As String
      Get
      Return Properties("CartonPresentation").Value
      End Get
      Set(ByVal Value As String)
      Properties("CartonPresentation").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [FrontBack_Scanner_Count]() As Long
      Get
      Return Properties("FrontBack_Scanner_Count").Value
      End Get
      Set(ByVal Value As Long)
      Properties("FrontBack_Scanner_Count").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MinGapOverride_Vendor_Provider_IN]() As Double
      Get
      Return Properties("MinGapOverride_Vendor_Provider_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MinGapOverride_Vendor_Provider_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MinGapOverride_Vendor_Provider_MM]() As Double
      Get
      Return Properties("MinGapOverride_Vendor_Provider_MM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MinGapOverride_Vendor_Provider_MM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MinGapOverride_Vendor_Provider_User]() As Double
      Get
      Return Properties("MinGapOverride_Vendor_Provider_User").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MinGapOverride_Vendor_Provider_User").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MinGapRequired_IN]() As Double
      Get
      Return Properties("MinGapRequired_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MinGapRequired_IN").CalculatedValue = Value
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
    
          Public Property [MinGapRequired_User_UOM]() As String
      Get
      Return Properties("MinGapRequired_User_UOM").Value
      End Get
      Set(ByVal Value As String)
      Properties("MinGapRequired_User_UOM").CalculatedValue = Value
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
    
          Public Property [ReadWindowSize_Vendor_Supplied_IN]() As Double
      Get
      Return Properties("ReadWindowSize_Vendor_Supplied_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ReadWindowSize_Vendor_Supplied_IN").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ReadWindowSize_Vendor_Supplied_MM]() As Double
      Get
      Return Properties("ReadWindowSize_Vendor_Supplied_MM").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ReadWindowSize_Vendor_Supplied_MM").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [ReadWindowSize_Vendor_Supplied_USER]() As Double
      Get
      Return Properties("ReadWindowSize_Vendor_Supplied_USER").Value
      End Get
      Set(ByVal Value As Double)
      Properties("ReadWindowSize_Vendor_Supplied_USER").CalculatedValue = Value
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
    
          Public Property [ShadowingStatus]() As Boolean
      Get
      Return Properties("ShadowingStatus").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("ShadowingStatus").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [UsePandAMTBH]() As Boolean
      Get
      Return Properties("UsePandAMTBH").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("UsePandAMTBH").CalculatedValue = Value
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
    
          Public Property [PartNumber]() As String
      Get
      Return Properties("PartNumber").Value
      End Get
      Set(ByVal Value As String)
      Properties("PartNumber").CalculatedValue = Value
      End Set
      End Property
    
      Public ReadOnly Property [Panel_Configs]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Panel_Configs")
      End Get
      End Property
    
      Public ReadOnly Property [My_PRD]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_PRD")
      End Get
      End Property
    
      Public ReadOnly Property [MySetup]() As Rulestream.Kernel.Connection
      Get
      Return Connections("MySetup")
      End Get
      End Property
    
      Public ReadOnly Property [Panel_Config_Back]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Panel_Config_Back")
      End Get
      End Property
    
      Public ReadOnly Property [Panel_Config_Bottom]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Panel_Config_Bottom")
      End Get
      End Property
    
      Public ReadOnly Property [Panel_Config_Front]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Panel_Config_Front")
      End Get
      End Property
    
      Public ReadOnly Property [Panel_Config_Left]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Panel_Config_Left")
      End Get
      End Property
    
      Public ReadOnly Property [Panel_Config_Right]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Panel_Config_Right")
      End Get
      End Property
    
      Public ReadOnly Property [Panel_Config_Top]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Panel_Config_Top")
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
    InitPart("APC_Scan_Configuration", <a><![CDATA[APC_Scan_Configuration]]></a>.Value, 417, "APCTMP01",  "N", "N", True, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/12/2025 13:43:42")
    AddProperty("9964", "AppType", <a><![CDATA[AppType]]></a>.Value, "Primary Application Type", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:11:01 PM")
    AddProperty("9963", "BoxPanelsScanned", <a><![CDATA[BoxPanelsScanned]]></a>.Value, "Count of Box Panels Scanned", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:38:15 PM")
    AddProperty("9962", "CartonPresentation", <a><![CDATA[CartonPresentation]]></a>.Value, "Carton Presentation?", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:36:38 PM")
    AddProperty("9991", "FrontBack_Scanner_Count", <a><![CDATA[FrontBack_Scanner_Count]]></a>.Value, "Count of Front & Back Scanner Positions in Use", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:31:57 PM")
    AddProperty("9976", "MinGapOverride_Vendor_Provider_IN", <a><![CDATA[MinGapOverride (Inches)]]></a>.Value, "Min. Gap for Scanner Application  (Inch)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:12:36 PM")
    AddProperty("9977", "MinGapOverride_Vendor_Provider_MM", <a><![CDATA[MinGapOverride (mm)]]></a>.Value, "Min. Gap for Scanner Application  (mm)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:13:16 PM")
    AddProperty("9978", "MinGapOverride_Vendor_Provider_User", <a><![CDATA[MinGapOverride_User]]></a>.Value, "Scanner Gap Requirement Override (if vendor supplied)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:13:39 PM")
    AddProperty("9965", "MinGapRequired_IN", <a><![CDATA[MinGapRequired]]></a>.Value, "Min. Gap Required for Scanner Application  (Inch)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:11:18 PM")
    AddProperty("9966", "MinGapRequired_User", <a><![CDATA[MinGapRequired_User]]></a>.Value, "Min. Gap Required for Scanner Application  (mm)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:11:57 PM")
    AddProperty("9967", "MinGapRequired_User_UOM", <a><![CDATA[MinGapRequired_User_UOM]]></a>.Value, "Scanner Gap Unit Of Measure", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:12:23 PM")
    AddProperty("9979", "ReadWindowSize_IN", <a><![CDATA[ReadWindowSize_IN]]></a>.Value, "Estimated Scanner Read Window Size (Inch)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:14:17 PM")
    AddProperty("9980", "ReadWindowSize_MM", <a><![CDATA[ReadWindowSize_MM]]></a>.Value, "Estimated Scanner Read Window Size (mm)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:14:59 PM")
    AddProperty("9981", "ReadWindowSize_USER", <a><![CDATA[ReadWindowSize_USER]]></a>.Value, "Estimated Scanner Read Window Size (User UOM)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:15:16 PM")
    AddProperty("9982", "ReadWindowSize_Vendor_Supplied_IN", <a><![CDATA[ReadWindowSize_Vendor_Supplied_IN]]></a>.Value, "Scanner Read Window Size Override (if vendor supplied) (Inch)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:15:40 PM")
    AddProperty("9984", "ReadWindowSize_Vendor_Supplied_MM", <a><![CDATA[ReadWindowSize_Vendor_Supplied_MM]]></a>.Value, "Scanner Read Window Size Override (if vendor supplied) (mm)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:15:57 PM")
    AddProperty("9986", "ReadWindowSize_Vendor_Supplied_USER", <a><![CDATA[ReadWindowSize_Vendor_Supplied_USER]]></a>.Value, "Scanner Read Window Size Override (if vendor supplied) (User UOM)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:16:27 PM")
    AddProperty("9960", "ShadowingPotential", <a><![CDATA[ShadowingPotential]]></a>.Value, "Shadowing Issues Possible?", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:34:50 PM")
    AddProperty("9961", "ShadowingStatus", <a><![CDATA[ShadowingStatus]]></a>.Value, "Shadowing Allowed?", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:34:17 PM")
    AddProperty("9959", "UsePandAMTBH", <a><![CDATA[UsePandAMTBH]]></a>.Value, "Use PandA MTBH Parameters (Required for PandA Use!)", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:35:03 PM")
    AddProperty("9997", "User_UOM_System", <a><![CDATA[User UOM System]]></a>.Value, "Default UOM System", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/12/2025 1:43:37 PM")
    AddProperty("9940", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 5:59:25 PM")
    
      AddValidValue("CartonPresentation")
    
      AddValidValue("User_UOM_System")
    
      oSubpart = AddSubpart(333,"Panel_Configs", <a><![CDATA[Panel_Configs]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "7/11/2025 6:03:53 PM")
      
        oSubpart.AddVPF (418, "APC_Scan_Panel_Configuration", "APC_Scan_Panel_Configuration")
      
      oConnection = AddConnection("My_PRD", <a><![CDATA[My PRD]]></a>.Value, "", "165", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "7/12/2025 1:43:37 PM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      
      oConnection = AddConnection("MySetup", <a><![CDATA[MySetup]]></a>.Value, "Connection to Primary AppCalc Setup Object", "164", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/12/2025 1:41:30 PM")
      
        oConnection.AddVPF(119, "APC_Setup")
      
      oConnection = AddConnection("Panel_Config_Back", <a><![CDATA[Panel_Config_Back]]></a>.Value, "", "163", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/11/2025 7:10:50 PM")
      
        oConnection.AddVPF(418, "APC_Scan_Panel_Configuration")
      
      oConnection = AddConnection("Panel_Config_Bottom", <a><![CDATA[Panel_Config_Bottom]]></a>.Value, "", "159", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/11/2025 7:11:07 PM")
      
        oConnection.AddVPF(418, "APC_Scan_Panel_Configuration")
      
      oConnection = AddConnection("Panel_Config_Front", <a><![CDATA[Panel_Config_Front]]></a>.Value, "", "162", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/11/2025 7:11:45 PM")
      
        oConnection.AddVPF(418, "APC_Scan_Panel_Configuration")
      
      oConnection = AddConnection("Panel_Config_Left", <a><![CDATA[Panel_Config_Left]]></a>.Value, "", "161", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/11/2025 7:11:18 PM")
      
        oConnection.AddVPF(418, "APC_Scan_Panel_Configuration")
      
      oConnection = AddConnection("Panel_Config_Right", <a><![CDATA[Panel_Config_Right]]></a>.Value, "", "160", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/11/2025 7:11:27 PM")
      
        oConnection.AddVPF(418, "APC_Scan_Panel_Configuration")
      
      oConnection = AddConnection("Panel_Config_Top", <a><![CDATA[Panel_Config_Top]]></a>.Value, "", "158", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/11/2025 7:10:58 PM")
      
        oConnection.AddVPF(418, "APC_Scan_Panel_Configuration")
      
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
          InitProperty("AppType", "9546", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:11:01 PM", "Primary Application Type", "In Development",  0,16643)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxPanelsScanned", "9545", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:38:14 PM", "Number of Box Panels Scanned", "In Development",  0,16706)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CartonPresentation", "9544", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:36:38 PM", "Carton Presentation?", "In Development",  0,16690)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FrontBack_Scanner_Count", "9573", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:31:57 PM", "Count of Front & Back Scanner Positions in Use", "In Development",  0,16692)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MinGapOverride_Vendor_Provider_IN", "9558", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:12:36 PM", "Min. Gap for Scanner Application  (Inch)", "In Development",  0,16667)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MinGapOverride_Vendor_Provider_MM", "9559", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:13:16 PM", "Min. Gap for Scanner Application  (mm)", "In Development",  0,16668)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MinGapOverride_Vendor_Provider_User", "9560", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:13:39 PM", "Scanner Gap Requirement Override (if vendor supplied)", "In Development",  0,16669)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MinGapRequired_IN", "9547", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:11:18 PM", "Min. Gap Required for Scanner Application  (Inch)", "In Development",  0,16647)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MinGapRequired_User", "9548", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:11:57 PM", "Min. Gap Required for Scanner Application  (mm)", "In Development",  0,16649)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MinGapRequired_User_UOM", "9549", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:12:23 PM", "Scanner Gap Unit Of Measure", "In Development",  0,16650)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ReadWindowSize_IN", "9561", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:14:17 PM", "Estimated Scanner Read Window Size (Inch)", "In Development",  0,16670)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ReadWindowSize_MM", "9562", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:14:59 PM", "Estimated Scanner Read Window Size (mm)", "In Development",  0,16671)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ReadWindowSize_USER", "9563", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:15:16 PM", "Estimated Scanner Read Window Size (User UOM)", "In Development",  0,16672)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ReadWindowSize_Vendor_Supplied_IN", "9564", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:15:40 PM", "Scanner Read Window Size Override (if vendor supplied) (Inch)", "In Development",  0,16673)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ReadWindowSize_Vendor_Supplied_MM", "9566", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:15:57 PM", "Scanner Read Window Size Override (if vendor supplied) (mm)", "In Development",  0,16675)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ReadWindowSize_Vendor_Supplied_USER", "9568", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:16:27 PM", "Scanner Read Window Size Override (if vendor supplied) (User UOM)", "In Development",  0,16678)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ShadowingPotential", "9542", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:34:31 PM", "Shadowing Issues Possible?", "In Development",  0,16698)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ShadowingStatus", "9543", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:34:17 PM", "Shadowing Allowed?", "In Development",  0,16697)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UsePandAMTBH", "9541", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 12:36:21 PM", "Use PandA MTBH Parameters (Required for PandA Use!)", "In Development",  0,16615)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("User_UOM_System", "9579", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:43:37 PM", "Default UOM System", "In Development",  0,16710)
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
          
        InitValidValue("CartonPresentation_ValidValues", "9544", "-1", 16703)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("User_UOM_System_ValidValues", "9579", "-1", 16711)
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
          
        InitSubpart("Panel_Configs", 260, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "7/11/2025 6:03:53 PM", "", "In Development", "N",0,711,712)
        
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
          
        InitConnection("My_PRD", "145", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/12/2025 1:43:37 PM", "", "In Development", "N",268)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("MySetup", "144", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/12/2025 1:41:12 PM", "", "In Development", "N",267)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Panel_Config_Back", "143", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/11/2025 7:10:50 PM", "", "In Development", "N",261)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Panel_Config_Bottom", "139", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/11/2025 7:11:07 PM", "", "In Development", "N",263)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Panel_Config_Front", "142", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/11/2025 7:11:45 PM", "", "In Development", "N",266)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Panel_Config_Left", "141", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/11/2025 7:11:18 PM", "", "In Development", "N",264)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Panel_Config_Right", "140", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/11/2025 7:11:27 PM", "", "In Development", "N",265)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Panel_Config_Top", "138", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/11/2025 7:10:58 PM", "", "In Development", "N",262)
        
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
        '   BEGIN FORMULA; CON ID:145; TYPE:PF
        Result = Me.Parent.My_Prd(1)
        '   END FORMULA; CON ID:145; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_My_PRD_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MySetup_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:144; TYPE:PF
        Result = Me.Parent.Setup(1)
        '   END FORMULA; CON ID:144; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_MySetup_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Panel_Config_Back_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:143; TYPE:PF
        Result = Me.Panel_Configs(6)
        '   END FORMULA; CON ID:143; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Panel_Config_Back_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Panel_Config_Bottom_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:139; TYPE:PF
        Result = Me.Panel_Configs(2)
        '   END FORMULA; CON ID:139; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Panel_Config_Bottom_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Panel_Config_Front_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:142; TYPE:PF
        Result = Me.Panel_Configs(5)
        '   END FORMULA; CON ID:142; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Panel_Config_Front_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Panel_Config_Left_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:141; TYPE:PF
        Result = Me.Panel_Configs(3)
        '   END FORMULA; CON ID:141; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Panel_Config_Left_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Panel_Config_Right_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:140; TYPE:PF
        Result = Me.Panel_Configs(4)
        '   END FORMULA; CON ID:140; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Panel_Config_Right_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Panel_Config_Top_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:138; TYPE:PF
        Result = Me.Panel_Configs(1)
        '   END FORMULA; CON ID:138; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Panel_Config_Top_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_AppType() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("AppType").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9546; TYPE:PF
      result = "" '=IF(K102>0,IF(OR(EXACT("O",G89:G94)),"Omni-Directional","Uni-Directional"),"")
      '   END FORMULA; PROP ID:9546; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_AppType", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_BoxPanelsScanned() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("BoxPanelsScanned").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9545; TYPE:PF
      result = 0
For Each p As part In Me.Panel_Configs
	If p.Properties("Is_Scanned").Value = True Then
		Result = Result + 1
	End If 
Next P
      '   END FORMULA; PROP ID:9545; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_BoxPanelsScanned", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_CartonPresentation() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CartonPresentation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9544; TYPE:PF
      result = "Please Select"
      '   END FORMULA; PROP ID:9544; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_CartonPresentation", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_FrontBack_Scanner_Count() As Long
          Dim Result as Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("FrontBack_Scanner_Count").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9573; TYPE:PF
      Result = 0
If Me.Panel_Config_Front(1).Is_Scanned Then
	 Result = Result + 1
 End If	 
If Me.Panel_Config_Back(1).Is_Scanned Then
	 Result = Result + 1
 End If
      '   END FORMULA; PROP ID:9573; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_FrontBack_Scanner_Count", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MinGapOverride_Vendor_Provider_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MinGapOverride_Vendor_Provider_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9558; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9558; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_MinGapOverride_Vendor_Provider_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MinGapOverride_Vendor_Provider_MM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MinGapOverride_Vendor_Provider_MM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9559; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9559; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_MinGapOverride_Vendor_Provider_MM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MinGapOverride_Vendor_Provider_User() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MinGapOverride_Vendor_Provider_User").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9560; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9560; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_MinGapOverride_Vendor_Provider_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MinGapRequired_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MinGapRequired_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9547; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9547; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_MinGapRequired_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9548; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9548; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_MinGapRequired_User", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MinGapRequired_User_UOM() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MinGapRequired_User_UOM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9549; TYPE:PF
      result = "IN"
      '   END FORMULA; PROP ID:9549; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_MinGapRequired_User_UOM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9561; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9561; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_ReadWindowSize_IN", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9562; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9562; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_ReadWindowSize_MM", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9563; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9563; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_ReadWindowSize_USER", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ReadWindowSize_Vendor_Supplied_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ReadWindowSize_Vendor_Supplied_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9564; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9564; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_ReadWindowSize_Vendor_Supplied_IN", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ReadWindowSize_Vendor_Supplied_MM() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ReadWindowSize_Vendor_Supplied_MM").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9566; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9566; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_ReadWindowSize_Vendor_Supplied_MM", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ReadWindowSize_Vendor_Supplied_USER() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ReadWindowSize_Vendor_Supplied_USER").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9568; TYPE:PF
      result = 0.0
      '   END FORMULA; PROP ID:9568; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_ReadWindowSize_Vendor_Supplied_USER", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9542; TYPE:PF
      result = false
'=IF(COUNTIF(FrontScanned:BackScanned,"Yes")>0,"Yes","No")
If Me.FrontBack_Scanner_Count > 0 Then 
	Result = True
End If
      '   END FORMULA; PROP ID:9542; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_ShadowingPotential", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ShadowingStatus() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ShadowingStatus").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9543; TYPE:PF
      result = false
      '   END FORMULA; PROP ID:9543; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_ShadowingStatus", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_UsePandAMTBH() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("UsePandAMTBH").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9541; TYPE:PF
      result = false
      '   END FORMULA; PROP ID:9541; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_UsePandAMTBH", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9579; TYPE:PF
      result = "Imperial"
      '   END FORMULA; PROP ID:9579; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_User_UOM_System", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_AppType_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxPanelsScanned_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CartonPresentation_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FrontBack_Scanner_Count_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MinGapOverride_Vendor_Provider_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MinGapOverride_Vendor_Provider_MM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MinGapOverride_Vendor_Provider_User_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MinGapRequired_IN_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_MinGapRequired_User_UOM_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_ReadWindowSize_Vendor_Supplied_IN_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ReadWindowSize_Vendor_Supplied_MM_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ReadWindowSize_Vendor_Supplied_USER_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_UsePandAMTBH_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_AppType_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_BoxPanelsScanned_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_CartonPresentation_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_FrontBack_Scanner_Count_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MinGapOverride_Vendor_Provider_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MinGapOverride_Vendor_Provider_MM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MinGapOverride_Vendor_Provider_User_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MinGapRequired_IN_USERCHANGE() as Boolean
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
      Public Function Formula_MinGapRequired_User_UOM_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_ReadWindowSize_Vendor_Supplied_IN_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ReadWindowSize_Vendor_Supplied_MM_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ReadWindowSize_Vendor_Supplied_USER_USERCHANGE() as Boolean
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
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_UsePandAMTBH_USERCHANGE() as Boolean
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
      Public Function Formula_CartonPresentation_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("CartonPresentation").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9544; TYPE:VV
      Result = MakeValidValues(Array("Edge Aligned", "Random"))
      '   END FORMULA; PROP ID:9544; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_CartonPresentation_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9579; TYPE:VV
      Result = MakeValidValues(Array( "Imperial", "Metric"))
      '   END FORMULA; PROP ID:9579; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_User_UOM_System_ValidValues", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Panel_Configs_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:260; TYPE:PN
      
      '   END FORMULA; SUB ID:260; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Panel_Configs_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Panel_Configs_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Panel_Configs").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:260; TYPE:QF
      Result = 6
      '   END FORMULA; SUB ID:260; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Panel_Configs_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Panel_Configs_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Panel_Configs").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:260; TYPE:OP
      result = "APC_Scan_Panel_Configuration"
      '   END FORMULA; SUB ID:260; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Panel_Configs_OPTIMALPARTFAMILY", ex.Message)
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

  