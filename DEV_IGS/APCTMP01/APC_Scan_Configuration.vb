Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: APC_Scan_Configuration
'$ GenerateDate: 07/16/2025 20:14:50

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
    
          Public Property [Configuration_Name]() As String
      Get
      Return Properties("Configuration_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Configuration_Name").CalculatedValue = Value
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
    
          Public Property [GapControlMethod]() As String
      Get
      Return Properties("GapControlMethod").Value
      End Get
      Set(ByVal Value As String)
      Properties("GapControlMethod").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [LaserOmniSideApp]() As Boolean
      Get
      Return Properties("LaserOmniSideApp").Value
      End Get
      Set(ByVal Value As Boolean)
      Properties("LaserOmniSideApp").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [MinGapForScan_IN]() As Double
      Get
      Return Properties("MinGapForScan_IN").Value
      End Get
      Set(ByVal Value As Double)
      Properties("MinGapForScan_IN").CalculatedValue = Value
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
    
          Public Property [ScannerConfig_Image]() As String
      Get
      Return Properties("ScannerConfig_Image").Value
      End Get
      Set(ByVal Value As String)
      Properties("ScannerConfig_Image").CalculatedValue = Value
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
    
      Public ReadOnly Property [My_Setup]() As Rulestream.Kernel.Connection
      Get
      Return Connections("My_Setup")
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
    
      Public ReadOnly Property [Sortation_Master_Config]() As Rulestream.Kernel.Connection
      Get
      Return Connections("Sortation_Master_Config")
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
    InitPart("APC_Scan_Configuration", <a><![CDATA[APC_Scan_Configuration]]></a>.Value, 417, "APCTMP01",  "N", "N", True, False, "In Development", "", "", "", "", "",  "GLOBAL\H601424", "07/16/2025 20:06:05")
    AddProperty("9964", "AppType", <a><![CDATA[AppType]]></a>.Value, "Primary Application Type", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/14/2025 12:41:05 PM")
    AddProperty("9963", "BoxPanelsScanned", <a><![CDATA[BoxPanelsScanned]]></a>.Value, "Count of Box Panels Scanned", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:38:15 PM")
    AddProperty("9962", "CartonPresentation", <a><![CDATA[CartonPresentation]]></a>.Value, "Carton Presentation?", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:36:38 PM")
    AddProperty("10134", "Configuration_Name", <a><![CDATA[Configuration_Name]]></a>.Value, "Config_Letter", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/14/2025 7:33:55 PM")
    AddProperty("9991", "FrontBack_Scanner_Count", <a><![CDATA[FrontBack_Scanner_Count]]></a>.Value, "Count of Front & Back Scanner Positions in Use", "Long","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:31:57 PM")
    AddProperty("10011", "GapControlMethod", <a><![CDATA[GapControlMethod]]></a>.Value, "Active or Passive Gap Control Method? (From Soration Configuration)", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 6:33:28 PM")
    AddProperty("10020", "LaserOmniSideApp", <a><![CDATA[Laser OmniSide App]]></a>.Value, "If Left Scan or Right Scan has Omni Directional Laser, then True, Otherwise False", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 10:08:51 PM")
    AddProperty("10010", "MinGapForScan_IN", <a><![CDATA[MinGapForScan_IN]]></a>.Value, "Min. Gap Allowed for all scans", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 5:41:51 PM")
    AddProperty("9976", "MinGapOverride_Vendor_Provider_IN", <a><![CDATA[MinGapOverride (Inches)]]></a>.Value, "Min. Gap for Scanner Application  (Inch)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:12:36 PM")
    AddProperty("9977", "MinGapOverride_Vendor_Provider_MM", <a><![CDATA[MinGapOverride (mm)]]></a>.Value, "Min. Gap for Scanner Application  (mm)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:13:16 PM")
    AddProperty("9978", "MinGapOverride_Vendor_Provider_User", <a><![CDATA[MinGapOverride_User]]></a>.Value, "Scanner Gap Requirement Override (if vendor supplied)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 5:59:49 PM")
    AddProperty("9965", "MinGapRequired_IN", <a><![CDATA[MinGapRequired]]></a>.Value, "Min. Gap Required for Scanner Application  (Inch)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 10:28:20 PM")
    AddProperty("9966", "MinGapRequired_User", <a><![CDATA[MinGapRequired_User]]></a>.Value, "Min. Gap Required for Scanner Application  (mm)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:11:57 PM")
    AddProperty("9967", "MinGapRequired_User_UOM", <a><![CDATA[MinGapRequired_User_UOM]]></a>.Value, "Scanner Gap Unit Of Measure", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:12:23 PM")
    AddProperty("9979", "ReadWindowSize_IN", <a><![CDATA[ReadWindowSize_IN]]></a>.Value, "Estimated Scanner Read Window Size (Inch)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/16/2025 7:56:35 PM")
    AddProperty("9980", "ReadWindowSize_MM", <a><![CDATA[ReadWindowSize_MM]]></a>.Value, "Estimated Scanner Read Window Size (mm)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:14:59 PM")
    AddProperty("9981", "ReadWindowSize_USER", <a><![CDATA[ReadWindowSize_USER]]></a>.Value, "Estimated Scanner Read Window Size (User UOM)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:15:16 PM")
    AddProperty("9982", "ReadWindowSize_Vendor_Supplied_IN", <a><![CDATA[ReadWindowSize_Vendor_Supplied_IN]]></a>.Value, "Scanner Read Window Size Override (if vendor supplied) (Inch)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:15:40 PM")
    AddProperty("9984", "ReadWindowSize_Vendor_Supplied_MM", <a><![CDATA[ReadWindowSize_Vendor_Supplied_MM]]></a>.Value, "Scanner Read Window Size Override (if vendor supplied) (mm)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:15:57 PM")
    AddProperty("9986", "ReadWindowSize_Vendor_Supplied_USER", <a><![CDATA[ReadWindowSize_Vendor_Supplied_USER]]></a>.Value, "Scanner Read Window Size Override (if vendor supplied) (User UOM)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 5:59:24 PM")
    AddProperty("9960", "ShadowingPotential", <a><![CDATA[ShadowingPotential]]></a>.Value, "Shadowing Issues Possible?", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:34:50 PM")
    AddProperty("10012", "ShadowingStatus", <a><![CDATA[Shadowing Status]]></a>.Value, "Shadowing Allowed?", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/12/2025 7:43:53 PM")
    AddProperty("10150", "Sorter_Selected_Width_IN", <a><![CDATA[Sorter_Selected_Width_IN]]></a>.Value, "Master Sorter Width (From Sortation Object)", "Double","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/15/2025 4:24:03 PM")
    AddProperty("9959", "UsePandAMTBH", <a><![CDATA[UsePandAMTBH]]></a>.Value, "Use PandA MTBH Parameters (Required for PandA Use!)", "Boolean","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/12/2025 1:35:03 PM")
    AddProperty("9997", "User_UOM_System", <a><![CDATA[User UOM System]]></a>.Value, "Default UOM System", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/16/2025 8:06:05 PM")
    AddProperty("10271", "Valid", <a><![CDATA[Valid]]></a>.Value, "Are Plastic Totes Used?", "Boolean","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/15/2025 4:09:53 PM")
    AddProperty("10272", "Valid_Message", <a><![CDATA[Valid_Message]]></a>.Value, "Customer Name (From Salesforce ePRD If Available)", "String","","General","FD", 9999, "", 0,0, "AppCalc Spreadsheet", "", "GLOBAL\H601424", "7/15/2025 4:11:36 PM")
    AddProperty("10298", "ScannerConfig_Image", <a><![CDATA[ScannerConfig_Image]]></a>.Value, "Image for Scanner config", "String","","Image","FD", 9999, "", 0,0, "", "", "GLOBAL\H621516", "7/15/2025 8:18:57 PM")
    AddProperty("10269", "Tool_Name", <a><![CDATA[Tool_Name]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/15/2025 4:25:52 PM")
    AddProperty("10270", "Tool_Status", <a><![CDATA[Tool_Status]]></a>.Value, "", "String","","Mech Install","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/15/2025 4:09:53 PM")
    AddProperty("9940", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "7/11/2025 5:59:25 PM")
    
      AddValidValue("CartonPresentation")
    
      AddValidValue("GapControlMethod")
    
      AddValidValue("ShadowingStatus")
    
      AddValidValue("Sorter_Selected_Width_IN")
    
      AddValidValue("User_UOM_System")
    
      AddValidValue("Tool_Status")
    
      oSubpart = AddSubpart(333,"Panel_Configs", <a><![CDATA[Panel_Configs]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "7/11/2025 6:03:53 PM")
      
        oSubpart.AddVPF (418, "APC_Scan_Panel_Configuration", "APC_Scan_Panel_Configuration")
      
      oConnection = AddConnection("My_PRD", <a><![CDATA[My PRD]]></a>.Value, "", "165", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "7/14/2025 6:11:48 PM")
      
        oConnection.AddVPF(163, "SFD_Salesforce_PRD_Header_Mock")
      
      oConnection = AddConnection("My_Setup", <a><![CDATA[My_Setup]]></a>.Value, "My App Calc Setup Object", "170", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/14/2025 6:12:33 PM")
      
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
      
      oConnection = AddConnection("Sortation_Master_Config", <a><![CDATA[Sortation_Master_Config]]></a>.Value, "Connection / Reference to the Sortation Configuration Object", "176", "OO", 0, "","General", 9999, "", "GLOBAL\H601424", "7/14/2025 10:09:00 PM")
      
        oConnection.AddVPF(120, "APC_Sortation")
      
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
          InitProperty("AppType", "9546", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/14/2025 12:41:05 PM", "Primary Application Type", "In Development",  0,16877)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("BoxPanelsScanned", "9545", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:38:14 PM", "Number of Box Panels Scanned", "In Development",  0,16706)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("CartonPresentation", "9544", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:36:38 PM", "Carton Presentation?", "In Development",  0,16690)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Configuration_Name", "9715", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/14/2025 7:33:50 PM", "Primary Application Type", "In Development",  0,17132)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("FrontBack_Scanner_Count", "9573", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:31:57 PM", "Count of Front & Back Scanner Positions in Use", "In Development",  0,16692)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("GapControlMethod", "9593", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/12/2025 6:23:33 PM", "Carton Presentation?", "In Development",  0,16773)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("LaserOmniSideApp", "9602", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 10:08:51 PM", "", "In Development",  0,16829)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MinGapForScan_IN", "9592", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 5:41:45 PM", "Min. Gap Required for Scanner Application  (Inch)", "In Development",  0,16767)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MinGapOverride_Vendor_Provider_IN", "9558", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:12:36 PM", "Min. Gap for Scanner Application  (Inch)", "In Development",  0,16667)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MinGapOverride_Vendor_Provider_MM", "9559", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:13:16 PM", "Min. Gap for Scanner Application  (mm)", "In Development",  0,16668)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MinGapOverride_Vendor_Provider_User", "9560", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 5:59:49 PM", "Scanner Gap Requirement Override (if vendor supplied)", "In Development",  0,16669)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MinGapRequired_IN", "9547", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 10:28:20 PM", "Min. Gap Required for Scanner Application  (Inch)", "In Development",  0,16834)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MinGapRequired_User", "9548", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:11:57 PM", "Min. Gap Required for Scanner Application  (mm)", "In Development",  0,16649)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("MinGapRequired_User_UOM", "9549", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:12:23 PM", "Scanner Gap Unit Of Measure", "In Development",  0,16650)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ReadWindowSize_IN", "9561", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 7:56:35 PM", "Estimated Scanner Read Window Size (Inch)", "In Development",  0,18216)
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
          InitProperty("ReadWindowSize_Vendor_Supplied_USER", "9568", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 5:59:24 PM", "Scanner Read Window Size Override (if vendor supplied) (User UOM)", "In Development",  0,16678)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ShadowingPotential", "9542", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 1:34:31 PM", "Shadowing Issues Possible?", "In Development",  0,16698)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ShadowingStatus", "9594", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/12/2025 7:43:19 PM", "Carton Presentation?", "In Development",  0,16788)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Sorter_Selected_Width_IN", "9731", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/15/2025 4:24:03 PM", "", "In Development",  0,17483)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("UsePandAMTBH", "9541", "", "", "Y", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/12/2025 12:36:21 PM", "Use PandA MTBH Parameters (Required for PandA Use!)", "In Development",  0,16615)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("User_UOM_System", "9579", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/16/2025 8:06:01 PM", "Default UOM System", "In Development",  0,16710)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Valid", "9850", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/15/2025 4:09:53 PM", "Are Plastic Totes Used?", "In Development",  0,17474)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Valid_Message", "9851", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/15/2025 4:11:36 PM", "Customer Name (From Salesforce ePRD If Available)", "In Development",  0,17477)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("ScannerConfig_Image", "9876", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H621516", "7/15/2025 8:17:56 PM", "", "In Development",  0,17607)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Tool_Name", "9848", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "7/15/2025 4:25:52 PM", "", "In Development",  0,17487)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Tool_Status", "9849", "", "", "Y", "","", 0, "-1", 1, "", "N","0",  "GLOBAL\H601424", "7/15/2025 4:09:53 PM", "", "In Development",  0,17472)
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
          
        InitValidValue("GapControlMethod_ValidValues", "9593", "-1", 16774)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("ShadowingStatus_ValidValues", "9594", "-1", 16789)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Sorter_Selected_Width_IN_ValidValues", "9731", "-1", 17183)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("User_UOM_System_ValidValues", "9579", "-1", 16711)
        End If
            If Incontext("-1", ctx) Then
          
        InitValidValue("Tool_Status_ValidValues", "9849", "-1", 17473)
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
          
        InitConnection("My_PRD", "145", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/14/2025 6:11:48 PM", "", "In Development", "N",268)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitConnection("My_Setup", "150", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/14/2025 6:09:34 PM", "", "In Development", "N",276)
        
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
        
            If Incontext("-1", ctx) Then
          
        InitConnection("Sortation_Master_Config", "156", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/14/2025 10:09:00 PM", "", "In Development", "N",286)
        
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
      Public Function Formula_My_Setup_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:150; TYPE:PF
        Result = Me.Parent.My_Setup(1)
        '   END FORMULA; CON ID:150; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_My_Setup_PARTS", ex.Message)
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
      Public Function Formula_Sortation_Master_Config_PARTS() as Rulestream.Kernel.rsCollection
      
      Dim Result as Object = Nothing
      Dim ctx as Object
      Try
      ctx = this
        '   BEGIN FORMULA; CON ID:156; TYPE:PF
        Result = Me.Parent.Sortation(1)
        '   END FORMULA; CON ID:156; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Sortation_Master_Config_PARTS", ex.Message)
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
      Result = "Uni-Directiona" '=IF(K102>0,IF(OR(EXACT("O",G89:G94)),"Omni-Directional","Uni-Directional"),"")
Dim Is_Omni As Boolean = False
If BoxPanelsScanned > 0 Then
	For Each p As part In Me.Panel_Configs
		If p.properties("Scan_Type").Value.Trim().ToLower() = "O" Then
			Is_Omni = True
			Result = "Omni-Directional"
		End If
	Next p
End If
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
          Public Function Formula_Configuration_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Configuration_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9715; TYPE:PF
      Dim Config_Letter As String = ""
Select Case  Me.SubpartID
	Case 1
		Config_Letter = "A"
	Case 2
		Config_Letter = "B"
	Case 3
		Config_Letter = "C"
	Case 4
		Config_Letter = "D"
	Case Else
		Config_Letter = Me.SubPartId
End Select


Result = $"Configuration : {Config_Letter}"
      '   END FORMULA; PROP ID:9715; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Configuration_Name", ex.Message)
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
          Public Function Formula_GapControlMethod() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("GapControlMethod").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9593; TYPE:PF
      Result = "Passive"
      '   END FORMULA; PROP ID:9593; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_GapControlMethod", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_LaserOmniSideApp() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("LaserOmniSideApp").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9602; TYPE:PF
      Result = False

'=IF(
	'Or(
		' And($C91="Yes",$D91="Laser Omni-Directional"),
		' And($C92="Yes",$D92="Laser Omni-Directional")),
   '"Yes","No")
 ' Evaluation : If Left Scan or Right Scan has Omni Directional Laser, then True, Otherwise False

Dim Left_Scanner_Is_Omni_Laser As Boolean = (Me.Panel_Config_Left(1).Is_Scanned AndAlso Me.Panel_Config_Left(1).Scanner_Selected = "Laser Omni-Directional")
Dim Right_Scanner_Is_Omni_Laser As Boolean = (Me.Panel_Config_Right(1).Is_Scanned AndAlso Me.Panel_Config_Right(1).Scanner_Selected = "Laser Omni-Directional")

If Left_Scanner_Is_Omni_Laser Or Right_Scanner_Is_Omni_Laser Then
	Result = True
End If
      '   END FORMULA; PROP ID:9602; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_LaserOmniSideApp", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_MinGapForScan_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("MinGapForScan_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9592; TYPE:PF
      Result = 6
      '   END FORMULA; PROP ID:9592; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_MinGapForScan_IN", ex.Message)
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
      Result = 0.0

	'=IF(K105>0,K105,MAX(L89:L94))

For Each p As part In Me.Panel_Configs
	If P.Properties("Is_Scanned").Value = True Then
		If P.Properties("Min_Gap_Required").Value > Result Then
			Result = P.Properties("Min_Gap_Required").Value
		End If
	End If
Next p

If MinGapOverride_Vendor_Provider_IN > Result Then
	Result = MinGapOverRide_Vendor_Provider_IN
End If
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
'=IF(K107>0,K107,IF(AND(COUNTIF(C89:C92,"Yes")>0,COUNTIF(C93:C94,"Yes")>1),MAX(T89:T94)+MAX(L93:L94),MAX(T89:T94)))
'=IF(K107>0,K107,IF(AND(COUNTIF(C89:C92,"Yes")>0,COUNTIF(C93:C94,"Yes")>1),MAX(T89:T94)+MAX(L93:L94),MAX(T89:T94)))
For Each p As part In Me.Panel_Configs
	If P.Properties("Is_Scanned").Value = True Then
		If P.Properties("Read_Window_Size").Value > Result Then
			Result = P.Properties("Read_Window_Size").Value
		End If
	End If
Next p

Result = Result + Me.MinGapRequired_IN

If ReadWindowSize_Vendor_Supplied_IN > Result Then
	Result = ReadWindowSize_Vendor_Supplied_IN
End If
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
          Public Function Formula_ShadowingStatus() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ShadowingStatus").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9594; TYPE:PF
      Result = "No"
      '   END FORMULA; PROP ID:9594; TYPE:PF
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
          Public Function Formula_Sorter_Selected_Width_IN() As Double
          Dim Result as Double
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Sorter_Selected_Width_IN").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9731; TYPE:PF
      Result = Me.Parent.Sortation(1).Sorter_Selected_Width_IN
      '   END FORMULA; PROP ID:9731; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Sorter_Selected_Width_IN", ex.Message)
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
          Public Function Formula_Valid() As Boolean
          Dim Result as Boolean
      Dim ctx as Object
      Try
      ctx = this
        '   THIS FORMULA IS INHERITED. CHANGES TO THIS FORMULA WILL BREAK INHERITANCE.
      
      If Me.Properties("Valid").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9850; TYPE:PF
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
      '   END FORMULA; PROP ID:9850; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Valid", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9851; TYPE:PF
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
      '   END FORMULA; PROP ID:9851; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Valid_Message", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_ScannerConfig_Image() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("ScannerConfig_Image").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9876; TYPE:PF
      Result = "Scanner_Config.jpg"
      '   END FORMULA; PROP ID:9876; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_ScannerConfig_Image", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9848; TYPE:PF
      Result = "Scanner Configuration" ' Implement this name
      '   END FORMULA; PROP ID:9848; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Tool_Name", ex.Message)
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
        '   THIS FORMULA IS INHERITED. CHANGES TO THIS FORMULA WILL BREAK INHERITANCE.
      
      If Me.Properties("Tool_Status").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9849; TYPE:PF
      Result = "New"
      '   END FORMULA; PROP ID:9849; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Tool_Status", ex.Message)
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
      Public Function Formula_Configuration_Name_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_GapControlMethod_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LaserOmniSideApp_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MinGapForScan_IN_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Sorter_Selected_Width_IN_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_ScannerConfig_Image_HIDE_CALCULATED_VALUE() as Boolean
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
      Public Function Formula_Configuration_Name_USERCHANGE() as Boolean
      Return False
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
      Public Function Formula_GapControlMethod_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_LaserOmniSideApp_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MinGapForScan_IN_USERCHANGE() as Boolean
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
      Return True
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
      Return True
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
      Public Function Formula_Sorter_Selected_Width_IN_USERCHANGE() as Boolean
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
      Public Function Formula_ScannerConfig_Image_USERCHANGE() as Boolean
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
      Public Function Formula_GapControlMethod_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("GapControlMethod").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9593; TYPE:VV
      Result = MakeValidValues(Array("Active", "Passive"))
      '   END FORMULA; PROP ID:9593; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_GapControlMethod_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9594; TYPE:VV
      Result = MakeValidValues(Array("No", "Parial", "Full"))
      '   END FORMULA; PROP ID:9594; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_ShadowingStatus_ValidValues", ex.Message)
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
      '   BEGIN FORMULA; PROP ID:9731; TYPE:VV
      Result = MakeValidValues(Array(22, 28, 34, 38))
      '   END FORMULA; PROP ID:9731; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Sorter_Selected_Width_IN_ValidValues", ex.Message)
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
      Public Function Formula_Tool_Status_ValidValues() as Rulestream.Kernel.ValidValues
      
      Dim Result as Rulestream.Kernel.ValidValues = Nothing 'HashTable
      Dim ctx as Object
      Try
      ctx = this
        '   THIS FORMULA IS INHERITED. CHANGES TO THIS FORMULA WILL BREAK INHERITANCE.
      
      If Me.Properties("Tool_Status").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALIDVALUES_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:9849; TYPE:VV
      Result = MakeValidValues(Array("New", "Work In Progress", "Approved", "As Sold"))
      '   END FORMULA; PROP ID:9849; TYPE:VV
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " APC_Scan_Configuration.Formula_Tool_Status_ValidValues", ex.Message)
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

  