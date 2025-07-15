Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: IGS_AppCalc_App
'$ GenerateDate: 07/15/2025 13:30:28

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

    Public Class [IGS_AppCalc_App]
    
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

    Private this as IGS_AppCalc_App = me

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
      Case "45"
      Select Case processStep
        Case "56"
        Result = Process_DefaultProcess_Quick_Nav_COMMENT()
        
        Case "60"
        Result = Process_DefaultProcess_Cost_Notes_COMMENT()
        
        Case "58"
        Result = Process_DefaultProcess_Instructions_COMMENT()
        
        Case "61"
        Result = Process_DefaultProcess_Setup_COMMENT()
        
        Case "98"
        Result = Process_DefaultProcess______Setup_Debug_COMMENT()
        
        Case "100"
        Result = Process_DefaultProcess______Scanner_Config_Debug_COMMENT()
        End Select
        End Select
      
    Return Result
    End Function

    Public Function GetProcessStepStatus(ByVal processId As String, ByVal processStep As String) As Integer Implements RuleStream.IRsPartFormulas.GetProcessStepStatus
    Dim Result as Integer 'Long
    Select Case processId
      Case "45"
      Select Case processStep
        Case "56"
        Result = Process_DefaultProcess_Quick_Nav_STATUS()
        
        Case "60"
        Result = Process_DefaultProcess_Cost_Notes_STATUS()
        
        Case "58"
        Result = Process_DefaultProcess_Instructions_STATUS()
        
        Case "61"
        Result = Process_DefaultProcess_Setup_STATUS()
        
        Case "98"
        Result = Process_DefaultProcess______Setup_Debug_STATUS()
        
        Case "100"
        Result = Process_DefaultProcess______Scanner_Config_Debug_STATUS()
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
    
          Public Property [App_Calc_Name]() As String
      Get
      Return Properties("App_Calc_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("App_Calc_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Approved_By]() As String
      Get
      Return Properties("Approved_By").Value
      End Get
      Set(ByVal Value As String)
      Properties("Approved_By").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Approved_Date]() As Date
      Get
      Return Properties("Approved_Date").Value
      End Get
      Set(ByVal Value As Date)
      Properties("Approved_Date").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Customer_Name]() As String
      Get
      Return Properties("Customer_Name").Value
      End Get
      Set(ByVal Value As String)
      Properties("Customer_Name").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Estimated_By]() As String
      Get
      Return Properties("Estimated_By").Value
      End Get
      Set(ByVal Value As String)
      Properties("Estimated_By").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Facility_Location]() As String
      Get
      Return Properties("Facility_Location").Value
      End Get
      Set(ByVal Value As String)
      Properties("Facility_Location").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Product_Identifier]() As String
      Get
      Return Properties("Product_Identifier").Value
      End Get
      Set(ByVal Value As String)
      Properties("Product_Identifier").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Proposal_No]() As String
      Get
      Return Properties("Proposal_No").Value
      End Get
      Set(ByVal Value As String)
      Properties("Proposal_No").CalculatedValue = Value
      End Set
      End Property
    
          Public Property [Revision_No]() As String
      Get
      Return Properties("Revision_No").Value
      End Get
      Set(ByVal Value As String)
      Properties("Revision_No").CalculatedValue = Value
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
    
      Public ReadOnly Property [Advanced_Calcs]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Advanced_Calcs")
      End Get
      End Property
    
      Public ReadOnly Property [Belted_PandA]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Belted_PandA")
      End Get
      End Property
    
      Public ReadOnly Property [Belted_PandA_Layout]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Belted_PandA_Layout")
      End Get
      End Property
    
      Public ReadOnly Property [Continuous_RA_Discharge]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Continuous_RA_Discharge")
      End Get
      End Property
    
      Public ReadOnly Property [Induction]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Induction")
      End Get
      End Property
    
      Public ReadOnly Property [Instructions]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Instructions")
      End Get
      End Property
    
      Public ReadOnly Property [Intellimerge_PSM]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Intellimerge_PSM")
      End Get
      End Property
    
      Public ReadOnly Property [MDR_Misc]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("MDR_Misc")
      End Get
      End Property
    
      Public ReadOnly Property [MDR_Sort]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("MDR_Sort")
      End Get
      End Property
    
      Public ReadOnly Property [Pre_Merge]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Pre_Merge")
      End Get
      End Property
    
      Public ReadOnly Property [Project_Information]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Project_Information")
      End Get
      End Property
    
      Public ReadOnly Property [R_M_Merge]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("R_M_Merge")
      End Get
      End Property
    
      Public ReadOnly Property [Scan_Belt]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Scan_Belt")
      End Get
      End Property
    
      Public ReadOnly Property [Scan_Configurations]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Scan_Configurations")
      End Get
      End Property
    
      Public ReadOnly Property [Setup]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Setup")
      End Get
      End Property
    
      Public ReadOnly Property [Sortation]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Sortation")
      End Get
      End Property
    
      Public ReadOnly Property [Space_Avail_Merge]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Space_Avail_Merge")
      End Get
      End Property
    
      Public ReadOnly Property [Std_Merge]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Std_Merge")
      End Get
      End Property
    
      Public ReadOnly Property [ZFA_Applications]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("ZFA_Applications")
      End Get
      End Property
    
      Public ReadOnly Property [Zipper_Merge]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Zipper_Merge")
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
    InitPart("IGS_AppCalc_App", <a><![CDATA[IGS_AppCalc_App]]></a>.Value, 116, "APCTMP01",  "N", "N", True, True, "In Development", "", "App Calc Top Part", "", "", "",  "GLOBAL\H601424", "07/15/2025 13:08:15")
    AddProperty("4535", "App_Calc_Name", <a><![CDATA[App_Calc_Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/18/2025 8:26:13 PM")
    AddProperty("1521", "Approved_By", <a><![CDATA[Approved By]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:13:01 AM")
    AddProperty("1522", "Approved_Date", <a><![CDATA[Approved Date]]></a>.Value, "", "Date","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:13:01 AM")
    AddProperty("1518", "Customer_Name", <a><![CDATA[Customer Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "6/18/2025 8:09:15 PM")
    AddProperty("1520", "Estimated_By", <a><![CDATA[Estimated By]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:13:01 AM")
    AddProperty("1519", "Facility_Location", <a><![CDATA[Facility Location]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:13:01 AM")
    AddProperty("1526", "Product_Identifier", <a><![CDATA[Product Identifier]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:17:55 AM")
    AddProperty("1523", "Proposal_No", <a><![CDATA[Proposal No]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:13:01 AM")
    AddProperty("1524", "Revision_No", <a><![CDATA[Revision No]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:13:01 AM")
    AddProperty("712", "PartNumber", <a><![CDATA[Part Number]]></a>.Value, "", "String","N","System","MN", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/24/2025 5:32:55 PM")
    
      oSubpart = AddSubpart(56,"Advanced_Calcs", <a><![CDATA[Advanced_Calcs]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (162, "APC_Advanced_Calcs", "APC_Advanced_Calcs")
      
      oSubpart = AddSubpart(43,"Belted_PandA", <a><![CDATA[Belted_PandA]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (129, "APC_Belted_PandA", "APC_Belted_PandA")
      
      oSubpart = AddSubpart(44,"Belted_PandA_Layout", <a><![CDATA[Belted_PandA_Layout]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (130, "APC_Belted_PandA_Layout", "APC_Belted_PandA_Layout")
      
      oSubpart = AddSubpart(47,"Continuous_RA_Discharge", <a><![CDATA[Continuous_RA_Discharge]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (133, "APC_Continuous_RA_Discharge", "APC_Continuous_RA_Discharge")
      
      oSubpart = AddSubpart(36,"Induction", <a><![CDATA[Induction]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (122, "APC_Induction", "APC_Induction")
      
      oSubpart = AddSubpart(32,"Instructions", <a><![CDATA[Instructions]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (118, "APC_Instructions", "APC_Instructions")
      
      oSubpart = AddSubpart(40,"Intellimerge_PSM", <a><![CDATA[Intellimerge_PSM]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (126, "APC_Intellimerge_PSM", "APC_Intellimerge_PSM")
      
      oSubpart = AddSubpart(46,"MDR_Misc", <a><![CDATA[MDR_Misc]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (132, "APC_MDR_Misc", "APC_MDR_Misc")
      
      oSubpart = AddSubpart(45,"MDR_Sort", <a><![CDATA[MDR_Sort]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (131, "APC_MDR_Sort", "APC_MDR_Sort")
      
      oSubpart = AddSubpart(37,"Pre_Merge", <a><![CDATA[Pre_Merge]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (123, "APC_Pre_Merge", "APC_Pre_Merge")
      
      oSubpart = AddSubpart(19,"Project_Information", <a><![CDATA[Project_Information]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/28/2025 4:50:10 AM")
      
        oSubpart.AddVPF (302, "IGS_Opportunity_Data", "IGS_Opportunity_Data")
      
      oSubpart = AddSubpart(39,"R_M_Merge", <a><![CDATA[R_M_Merge]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (125, "APC_R_M_Merge", "APC_R_M_Merge")
      
      oSubpart = AddSubpart(49,"Scan_Belt", <a><![CDATA[Scan_Belt]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (135, "APC_Scan_Belt", "APC_Scan_Belt")
      
      oSubpart = AddSubpart(332,"Scan_Configurations", <a><![CDATA[Scan_Configurations]]></a>.Value, "MN", "", "General", 9999, "", "GLOBAL\H601424", "7/11/2025 7:12:10 PM")
      
        oSubpart.AddVPF (417, "APC_Scan_Configuration", "APC_Scan_Configuration")
      
      oSubpart = AddSubpart(33,"Setup", <a><![CDATA[Setup]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "6/18/2025 8:58:13 PM")
      
        oSubpart.AddVPF (119, "APC_Setup", "APC_Setup")
      
      oSubpart = AddSubpart(34,"Sortation", <a><![CDATA[Sortation]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (120, "APC_Sortation", "APC_Sortation")
      
      oSubpart = AddSubpart(42,"Space_Avail_Merge", <a><![CDATA[Space_Avail_Merge]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (128, "APC_Space_Avail_Merge", "APC_Space_Avail_Merge")
      
      oSubpart = AddSubpart(38,"Std_Merge", <a><![CDATA[Std_Merge]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (124, "APC_Std_Merge", "APC_Std_Merge")
      
      oSubpart = AddSubpart(48,"ZFA_Applications", <a><![CDATA[ZFA_Applications]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (134, "APC_ZFA_Applications", "APC_ZFA_Applications")
      
      oSubpart = AddSubpart(41,"Zipper_Merge", <a><![CDATA[Zipper_Merge]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (127, "APC_Zipper_Merge", "APC_Zipper_Merge")
      
      oConnection = AddConnection("My_PRD", <a><![CDATA[My PRD]]></a>.Value, "Connection to the PRD That controls this App Calc", "114", "OM", 0, "","General", 9999, "", "GLOBAL\H601424", "7/14/2025 5:20:47 PM")
      
        oConnection.AddVPF(162, "APC_Advanced_Calcs")
      
    End Sub

    '*****************************************************************************
    '   Copyright (C) 2024 Siemens. All rights reserved.
    '
    '   Do not modify this procedure. Changes may render this application
    '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
    '*****************************************************************************
    Public Sub Initialize_Process(ByVal lngProcessID as Integer) Implements RuleStream.IRsPartFormulas.InitializeProcess
    Select Case lngProcessID
    
      Case 45
      Process = "DefaultProcess"	
        Initialize_Process_DefaultProcess_Quick_Nav()
        Initialize_Process_DefaultProcess_Cost_Notes()
        Initialize_Process_DefaultProcess_Instructions()
        Initialize_Process_DefaultProcess_Setup()
        Initialize_Process_DefaultProcess______Setup_Debug()
        Initialize_Process_DefaultProcess______Scanner_Config_Debug()
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
        Private Sub Initialize_Process_DefaultProcess_Quick_Nav()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(56, "Quick Nav", "Quick Nav", 1, 45, 1, 1, 50, 50)
        oProcessStep.AddPath("IGS_AppCalc_App")
        oProcessStep.AddFilter(1, 116, "System", 0, "PartNumber", 0)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 116, "1", "0", "RsLabel", 0, "", 26, 36, 36, 384, 0, "Quick Navigation", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 116, "2", "0", "RsNavigateToActionButton", 0, "", 122, 36, 28, 136, 1, "Instructions", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;ProcessStepName:1.;InstanceNr:1.;")
        oProcessStep.AddCustomLayout(1, 116, "3", "0", "RsNavigateToActionButton", 0, "", 156, 36, 28, 136, 2, "Setup", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;ProcessStepName:1.Setup;InstanceNr:1.;")
        oProcessStep.AddCustomLayout(1, 116, "4", "0", "RsNavigateToActionButton", 0, "", 79, 36, 28, 136, 3, "Cost Notes", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;ProcessStepName:1.;InstanceNr:1.;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Cost_Notes()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(60, "Cost Notes", "Cost Notes", 1, 45, 1, 2, 50, 50)
        oProcessStep.AddPath("IGS_AppCalc_App")
        oProcessStep.AddFilter(1, 116, "System", 0, "PartNumber", 0)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 116, "1", "0", "RsLabel", 0, "", 26, 36, 36, 384, 0, "Cost Notes", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 116, "2", "0", "RsNextActionButton", 0, "", 174, 294, 38, 116, 1, "Next", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 116, "3", "0", "RsPrevActionButton", 0, "", 174, 36, 38, 94, 2, "Previous", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Instructions()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(58, "Instructions", "Instructions", 1, 45, 1, 3, 50, 50)
        oProcessStep.AddPath("IGS_AppCalc_App")
        oProcessStep.AddFilter(1, 116, "System", 0, "PartNumber", 0)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 116, "1", "0", "RsLabel", 0, "", 26, 36, 36, 384, 0, "Instructions", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 116, "2", "0", "RsNextActionButton", 0, "", 174, 294, 38, 116, 1, "Next", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 116, "3", "0", "RsPrevActionButton", 0, "", 174, 36, 38, 94, 2, "Previous", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess_Setup()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(61, "Setup", "Setup", 1, 45, 1, 4, 50, 50)
        oProcessStep.AddPath("IGS_AppCalc_App.Setup/APC_Setup")
        oProcessStep.AddFilter(1, 116, "System", 0, "PartNumber", 0)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 119, "1", "0", "RsLabel", 0, "", 9, 26, 36, 384, 0, "Setup", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "2", "0", "RsGroupBox", 0, "", 48, 26, 130, 744, 1, "Site / Customer Information", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 119, "3", "2", "RsTextbox", 0, "Customer_Name", 32, 127, 26, 528, 2, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "4", "2", "RsTextbox", 0, "Customer_Location_CityState", 64, 127, 26, 528, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "5", "2", "RsTextbox", 0, "Proposal_No", 92, 127, 26, 264, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "6", "2", "RsLabel", 0, "", 92, 393, 30, 58, 5, "Date:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "7", "2", "RsSingleDatePicker", 0, "Proposal_Date", 92, 457, 20, 198, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 119, "8", "2", "RsLabel", 0, "", 92, 35, 30, 86, 7, "Proposal #:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "9", "2", "RsLabel", 0, "", 64, 6, 30, 115, 8, "Location (City, St):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "10", "2", "RsLabel", 0, "", 34, 35, 30, 86, 9, "Customer Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "11", "0", "RsGroupBox", 0, "", 184, 26, 106, 744, 10, "Instructions / Notes", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "12", "11", "RsLabel", 0, "", 28, 22, 68, 706, 11, "Use this sheet to setup the General &amp;quot;Material to be Handled&amp;quot; parameters to be used globally throughout the remaining worksheets. Some of the worksheets have the option to use locally defined &amp;quot;Material to be Handled&amp;quot; parameters instead of these &amp;quot;Global&amp;quot; parameters defined on this sheet.  This feature is provided where there is a possibility that these material parameters could be more restrictive than the system as a whole.", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "13", "0", "RsGroupBox", 0, "", 296, 26, 192, 744, 12, "Material Size", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "14", "13", "RsComboBox", 0, "User_UOM_System", 28, 127, 22, 172, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "15", "13", "RsTextbox", 0, "BoxSize_Length_Min_User", 95, 127, 21, 60, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "16", "13", "RsComboBox", 0, "BoxSize_Length_Min_User_UOM", 94, 187, 22, 60, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "17", "13", "RsLabel", 0, "", 127, 40, 16, 78, 16, "Maximum", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "18", "13", "RsTextbox", 0, "BoxSize_Width_Min_User", 95, 253, 21, 60, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "19", "13", "RsComboBox", 0, "BoxSize_Length_Min_User_UOM", 94, 318, 22, 60, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "20", "13", "RsTextbox", 0, "BoxSize_Height_Min_User", 95, 384, 21, 60, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "21", "13", "RsComboBox", 0, "BoxSize_Height_Min_User_UOM", 94, 444, 22, 60, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "22", "13", "RsTextbox", 0, "BoxSize_Weight_Min_User", 95, 510, 21, 60, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "23", "13", "RsComboBox", 0, "BoxSize_Weight_Min_User_UOM", 94, 570, 22, 60, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "24", "13", "RsLabel", 0, "", 28, 34, 16, 78, 23, "Default UOM", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "25", "13", "RsTextbox", 0, "BoxSize_Length_Max_User", 122, 127, 21, 60, 24, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "26", "13", "RsComboBox", 0, "BoxSize_Length_Max_User_UOM", 121, 187, 22, 60, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "27", "13", "RsTextbox", 0, "BoxSize_Width_Max_User", 122, 253, 21, 60, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "28", "13", "RsComboBox", 0, "BoxSize_Length_Max_User_UOM", 121, 318, 22, 60, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "29", "13", "RsTextbox", 0, "BoxSize_Height_Max_User", 122, 384, 21, 60, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "30", "13", "RsComboBox", 0, "BoxSize_Height_Max_User_UOM", 121, 444, 22, 60, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "31", "13", "RsTextbox", 0, "BoxSize_Weight_Max_User", 122, 510, 21, 60, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "32", "13", "RsComboBox", 0, "BoxSize_Weight_Max_User_UOM", 121, 570, 22, 60, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "33", "13", "RsTextbox", 0, "BoxSize_Length_Avg_User", 149, 127, 21, 60, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "34", "13", "RsComboBox", 0, "BoxSize_Length_Avg_User_UOM", 148, 187, 22, 60, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "35", "13", "RsTextbox", 0, "BoxSize_Width_Avg_User", 149, 253, 21, 60, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "36", "13", "RsComboBox", 0, "BoxSize_Length_Avg_User_UOM", 148, 318, 22, 60, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "37", "13", "RsTextbox", 0, "BoxSize_Height_Avg_User", 149, 384, 21, 60, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "38", "13", "RsLabel", 0, "", 75, 384, 16, 134, 37, "Height", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "39", "13", "RsComboBox", 0, "BoxSize_Height_Avg_User_UOM", 148, 444, 22, 60, 38, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "40", "13", "RsTextbox", 0, "BoxSize_Weight_Avg_User", 149, 510, 21, 60, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "41", "13", "RsComboBox", 0, "BoxSize_Weight_Max_User_UOM", 148, 570, 22, 60, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "42", "13", "RsLabel", 0, "", 154, 40, 16, 78, 41, "Average", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "43", "13", "RsLabel", 0, "", 100, 40, 16, 78, 42, "Minimum", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "44", "13", "RsLabel", 0, "", 75, 510, 16, 106, 43, "Weight", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "45", "13", "RsLabel", 0, "", 75, 245, 16, 100, 44, "Width", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "46", "13", "RsLabel", 0, "", 75, 127, 16, 78, 45, "Length", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "47", "0", "RsGroupBox", 0, "", 494, 26, 155, 744, 46, "MTBH Factors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "48", "47", "RsTextbox", 0, "Live_Load_Avg_User", 21, 128, 21, 60, 47, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "49", "47", "RsLabel", 0, "", 20, 44, 16, 78, 48, "Live Load:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "50", "47", "RsComboBox", 0, "Live_Load_Avg_User_UOM", 20, 197, 22, 60, 49, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "51", "47", "RsCheckbox", 0, "Totes_Plastic", 48, 128, 18, 129, 50, "Plastic Totes in Use?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "52", "47", "RsCheckbox", 0, "BoxSize_Height_GRTR_Len_Possible", 72, 128, 18, 298, 51, "Within MTBH Range, Can Product Heights be &amp;gt; Length?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "53", "47", "RsCheckbox", 0, "BoxSize_Other_Known_Issues", 96, 128, 18, 175, 52, "Other Known Stability Issues?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "54", "47", "RsComboBox", 0, "Selected_Sortation_Controls", 120, 128, 22, 140, 53, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "55", "47", "RsLabel", 0, "", 95, 398, 22, 114, 54, "Worst Case H/L Ratio:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "56", "47", "RsTextbox", 0, "Temp_Sort_Operating_Min_User", 18, 518, 21, 74, 55, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "57", "47", "RsComboBox", 0, "Temp_Sort_Operating_Min_User_UOM", 17, 598, 22, 60, 56, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "58", "47", "RsLabel", 0, "", 122, 398, 16, 114, 57, "Max Incline / Decline:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "59", "47", "RsTextbox", 0, "Temp_System_Operating_Min_User", 45, 518, 21, 74, 58, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "60", "47", "RsLabel", 0, "", 122, 584, 22, 60, 59, "Degrees", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "61", "47", "RsComboBox", 0, "Temp_System_Operating_Min_UOM", 44, 598, 22, 60, 60, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "62", "47", "RsTextbox", 0, "BoxSize_Worst_Case_HL_Ratio", 96, 518, 21, 60, 61, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "63", "47", "RsTextbox", 0, "Belt_InclineDecline_Max_Deg", 123, 518, 21, 60, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "64", "47", "RsLabel", 0, "", 120, 44, 16, 78, 63, "Control System:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "65", "47", "RsLabel", 0, "", 17, 346, 18, 166, 64, "Operating Temp Min ( Sorter ):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "66", "47", "RsLabel", 0, "", 48, 346, 18, 166, 65, "Operating Temp Min ( System ):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "67", "47", "RsTextbox", 0, "Temp_Sort_Operating_Min_F", 18, 664, 25, 74, 66, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "68", "47", "RsTextbox", 0, "Temp_System_Operating_Min_F", 44, 664, 25, 74, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "69", "0", "RsGroupBox", 0, "", 655, 26, 200, 744, 68, "General Application Factors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "70", "69", "RsLabel", 0, "", 29, 43, 16, 78, 69, "Product Line:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "71", "69", "RsComboBox", 0, "Conveyor_Product_Line_Used", 29, 127, 22, 140, 70, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "72", "69", "RsLabel", 0, "", 142, 346, 22, 177, 71, "Target Case Length per Minute:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "73", "69", "RsTextbox", 0, "Conveyor_Width_Min_IN", 61, 127, 21, 74, 72, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "74", "69", "RsLabel", 0, "", 29, 282, 18, 316, 73, "Total Skew Length Required for Selected MTBH Width and BF", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "75", "69", "RsTextbox", 0, "Conveyor_Curve_BF_Calc_Min_In", 88, 128, 21, 74, 74, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "76", "69", "RsTextbox", 0, "Conveyor_Curve_BF_Calc_Rcmd_In", 115, 127, 21, 74, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "77", "69", "RsComboBox", 0, "Conveyor_BF_Selected_Min_User", 142, 127, 22, 140, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "78", "69", "RsTextbox", 0, "Material_Gap_Override_User", 167, 529, 21, 60, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "79", "69", "RsComboBox", 0, "Conveyor_BF_Selected_Min_User_UOM", 142, 267, 22, 60, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "80", "69", "RsLabel", 0, "", 64, 6, 18, 115, 79, "Min Converyor Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "81", "69", "RsTextbox", 0, "Conveyor_Skew_Total_Length_MTBH_Width_IN", 26, 604, 21, 74, 80, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "82", "69", "RsTextbox", 0, "Conveyor_Skew_Bed_Length_Min_Reqd_IN", 53, 604, 21, 74, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "83", "69", "RsLabel", 0, "", 114, 346, 22, 177, 82, "Target Sort Rate:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "84", "69", "RsCheckbox", 0, "Sort_Dual_Sided", 80, 584, 18, 129, 83, "Dual Sided Sortation", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "85", "69", "RsLabel", 0, "", 145, 684, 18, 22, 84, "M", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "86", "69", "RsTextbox", 0, "Sort_Rate_Required_CPM", 114, 529, 21, 60, 85, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "87", "69", "RsLabel", 0, "", 166, 418, 22, 105, 86, "Design Gap Override:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "88", "69", "RsLabel", 0, "", 117, 590, 18, 116, 87, "CPM (Cases Per Min)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "89", "69", "RsTextbox", 0, "Case_Length_Per_Minute_Target_FT", 142, 529, 21, 60, 88, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "90", "69", "RsLabel", 0, "", 145, 590, 18, 22, 89, "Ft.", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "91", "69", "RsTextbox", 0, "Case_Length_Per_Minute_Target_M", 142, 618, 21, 60, 90, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "92", "69", "RsLabel", 0, "", 91, 7, 18, 115, 91, "Min Calc Curve Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "93", "69", "RsComboBox", 0, "Material_Gap_Override_User_UOM", 166, 595, 22, 60, 92, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "94", "69", "RsLabel", 0, "", 56, 253, 18, 345, 93, "Minimum Required Skew Bed Length for Selected MTBH Width and BF", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "95", "69", "RsLabel", 0, "", 118, 6, 18, 115, 94, "Min Rcmd Curve Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "96", "69", "RsLabel", 0, "", 29, 684, 18, 22, 95, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "97", "69", "RsLabel", 0, "", 56, 684, 18, 22, 96, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "98", "69", "RsLabel", 0, "", 142, 16, 22, 105, 97, "Selected Min Wdith:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "99", "69", "RsLabel", 0, "", 91, 207, 18, 22, 98, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "100", "69", "RsLabel", 0, "", 64, 207, 18, 22, 99, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "101", "69", "RsLabel", 0, "", 118, 207, 18, 22, 100, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "102", "0", "RsPrevActionButton", 0, "", 861, 26, 38, 94, 101, "Previous", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 119, "103", "0", "RsNextActionButton", 0, "", 861, 648, 38, 116, 102, "Next", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess______Setup_Debug()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(98, "_    Setup Debug", "Setup", 1, 45, 1, 5, 50, 50)
        oProcessStep.AddPath("IGS_AppCalc_App.Setup/APC_Setup")
        oProcessStep.AddFilter(1, 0, "System", 0, "PartNumber", 0)
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 119, "1", "0", "RsLabel", 0, "", 9, 26, 36, 384, 0, "Setup", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "2", "0", "RsLabel", 0, "", 82, 838, 36, 384, 1, "Warnings And Errors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:Firebrick;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "3", "0", "RsGroupBox", 0, "", 48, 26, 130, 744, 2, "Site / Customer Information", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;")
        oProcessStep.AddCustomLayout(1, 119, "4", "3", "RsTextbox", 0, "Customer_Name", 32, 127, 26, 528, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "5", "3", "RsTextbox", 0, "Customer_Location_CityState", 64, 127, 26, 528, 4, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "6", "3", "RsTextbox", 0, "Proposal_No", 92, 127, 26, 264, 5, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "7", "3", "RsLabel", 0, "", 92, 393, 30, 58, 6, "Date:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "8", "3", "RsSingleDatePicker", 0, "Proposal_Date", 92, 457, 20, 198, 7, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;MinDate:1753-01-01;MaxDate:9998-12-31;DateFormat:")
        oProcessStep.AddCustomLayout(1, 119, "9", "3", "RsLabel", 0, "", 92, 35, 30, 86, 8, "Proposal #:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "10", "3", "RsLabel", 0, "", 64, 6, 30, 115, 9, "Location (City, St):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "11", "3", "RsLabel", 0, "", 34, 35, 30, 86, 10, "Customer Name:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "12", "0", "RsGroupBox", 0, "", 184, 26, 106, 744, 11, "Instructions / Notes", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "13", "12", "RsLabel", 0, "", 28, 22, 68, 706, 12, "Use this sheet to setup the General &amp;quot;Material to be Handled&amp;quot; parameters to be used globally throughout the remaining worksheets. Some of the worksheets have the option to use locally defined &amp;quot;Material to be Handled&amp;quot; parameters instead of these &amp;quot;Global&amp;quot; parameters defined on this sheet.  This feature is provided where there is a possibility that these material parameters could be more restrictive than the system as a whole.", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "14", "0", "RsGroupBox", 0, "", 296, 26, 192, 744, 13, "Material Size", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "15", "14", "RsComboBox", 0, "User_UOM_System", 28, 127, 22, 172, 14, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "16", "14", "RsTextbox", 0, "BoxSize_Length_Min_User", 95, 127, 21, 60, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "17", "14", "RsComboBox", 0, "BoxSize_Length_Min_User_UOM", 94, 187, 22, 60, 16, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "18", "14", "RsLabel", 0, "", 127, 40, 16, 78, 17, "Maximum", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "19", "14", "RsTextbox", 0, "BoxSize_Width_Min_User", 95, 253, 21, 60, 18, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "20", "14", "RsComboBox", 0, "BoxSize_Length_Min_User_UOM", 94, 318, 22, 60, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "21", "14", "RsTextbox", 0, "BoxSize_Height_Min_User", 95, 384, 21, 60, 20, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "22", "14", "RsComboBox", 0, "BoxSize_Height_Min_User_UOM", 94, 444, 22, 60, 21, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "23", "14", "RsTextbox", 0, "BoxSize_Weight_Min_User", 95, 510, 21, 60, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "24", "14", "RsComboBox", 0, "BoxSize_Weight_Min_User_UOM", 94, 570, 22, 60, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "25", "14", "RsLabel", 0, "", 28, 34, 16, 78, 24, "Default UOM", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "26", "14", "RsTextbox", 0, "BoxSize_Length_Max_User", 122, 127, 21, 60, 25, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "27", "14", "RsComboBox", 0, "BoxSize_Length_Max_User_UOM", 121, 187, 22, 60, 26, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "28", "14", "RsTextbox", 0, "BoxSize_Width_Max_User", 122, 253, 21, 60, 27, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "29", "14", "RsComboBox", 0, "BoxSize_Length_Max_User_UOM", 121, 318, 22, 60, 28, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "30", "14", "RsTextbox", 0, "BoxSize_Height_Max_User", 122, 384, 21, 60, 29, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "31", "14", "RsComboBox", 0, "BoxSize_Height_Max_User_UOM", 121, 444, 22, 60, 30, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "32", "14", "RsTextbox", 0, "BoxSize_Weight_Max_User", 122, 510, 21, 60, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "33", "14", "RsComboBox", 0, "BoxSize_Weight_Max_User_UOM", 121, 570, 22, 60, 32, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "34", "14", "RsTextbox", 0, "BoxSize_Length_Avg_User", 149, 127, 21, 60, 33, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "35", "14", "RsComboBox", 0, "BoxSize_Length_Avg_User_UOM", 148, 187, 22, 60, 34, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "36", "14", "RsTextbox", 0, "BoxSize_Width_Avg_User", 149, 253, 21, 60, 35, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "37", "14", "RsComboBox", 0, "BoxSize_Length_Avg_User_UOM", 148, 318, 22, 60, 36, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "38", "14", "RsTextbox", 0, "BoxSize_Height_Avg_User", 149, 384, 21, 60, 37, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "39", "14", "RsLabel", 0, "", 75, 384, 16, 134, 38, "Height", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "40", "14", "RsComboBox", 0, "BoxSize_Height_Avg_User_UOM", 148, 444, 22, 60, 39, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "41", "14", "RsTextbox", 0, "BoxSize_Weight_Avg_User", 149, 510, 21, 60, 40, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "42", "14", "RsComboBox", 0, "BoxSize_Weight_Max_User_UOM", 148, 570, 22, 60, 41, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "43", "14", "RsLabel", 0, "", 154, 40, 16, 78, 42, "Average", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "44", "14", "RsLabel", 0, "", 100, 40, 16, 78, 43, "Minimum", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "45", "14", "RsLabel", 0, "", 75, 510, 16, 106, 44, "Weight", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "46", "14", "RsLabel", 0, "", 75, 245, 16, 100, 45, "Width", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "47", "14", "RsLabel", 0, "", 75, 127, 16, 78, 46, "Length", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.1;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "48", "0", "RsGroupBox", 0, "", 494, 26, 155, 744, 47, "MTBH Factors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "49", "48", "RsTextbox", 0, "Live_Load_Avg_User", 21, 128, 21, 60, 48, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "50", "48", "RsLabel", 0, "", 20, 44, 16, 78, 49, "Live Load:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "51", "48", "RsComboBox", 0, "Live_Load_Avg_User_UOM", 20, 197, 22, 60, 50, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "52", "48", "RsCheckbox", 0, "Totes_Plastic", 48, 128, 18, 129, 51, "Plastic Totes in Use?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "53", "48", "RsCheckbox", 0, "BoxSize_Height_GRTR_Len_Possible", 72, 128, 18, 298, 52, "Within MTBH Range, Can Product Heights be &amp;gt; Length?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "54", "48", "RsCheckbox", 0, "BoxSize_Other_Known_Issues", 96, 128, 18, 175, 53, "Other Known Stability Issues?", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "55", "48", "RsComboBox", 0, "Selected_Sortation_Controls", 120, 128, 22, 140, 54, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "56", "48", "RsLabel", 0, "", 95, 398, 22, 114, 55, "Worst Case H/L Ratio:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "57", "48", "RsTextbox", 0, "Temp_Sort_Operating_Min_User", 18, 518, 21, 74, 56, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "58", "48", "RsComboBox", 0, "Temp_Sort_Operating_Min_User_UOM", 17, 598, 22, 60, 57, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "59", "48", "RsLabel", 0, "", 122, 398, 16, 114, 58, "Max Incline / Decline:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "60", "48", "RsTextbox", 0, "Temp_System_Operating_Min_User", 45, 518, 21, 74, 59, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "61", "48", "RsLabel", 0, "", 122, 584, 22, 60, 60, "Degrees", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "62", "48", "RsComboBox", 0, "Temp_System_Operating_Min_UOM", 44, 598, 22, 60, 61, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "63", "48", "RsTextbox", 0, "BoxSize_Worst_Case_HL_Ratio", 96, 518, 21, 60, 62, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "64", "48", "RsTextbox", 0, "Belt_InclineDecline_Max_Deg", 123, 518, 21, 60, 63, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "65", "48", "RsLabel", 0, "", 120, 44, 16, 78, 64, "Control System:", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "66", "48", "RsLabel", 0, "", 17, 346, 18, 166, 65, "Operating Temp Min ( Sorter ):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "67", "48", "RsLabel", 0, "", 48, 346, 18, 166, 66, "Operating Temp Min ( System ):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "68", "48", "RsTextbox", 0, "Temp_Sort_Operating_Min_F", 18, 664, 25, 74, 67, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "69", "48", "RsTextbox", 0, "Temp_System_Operating_Min_F", 44, 664, 25, 74, 68, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "70", "0", "RsGroupBox", 0, "", 655, 26, 200, 744, 69, "General Application Factors", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "71", "70", "RsLabel", 0, "", 29, 43, 16, 78, 70, "Product Line:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "72", "70", "RsComboBox", 0, "Conveyor_Product_Line_Used", 29, 127, 22, 140, 71, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "73", "70", "RsLabel", 0, "", 142, 346, 22, 177, 72, "Target Case Length per Minute:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "74", "70", "RsTextbox", 0, "Conveyor_Width_Min_IN", 61, 127, 21, 74, 73, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "75", "70", "RsLabel", 0, "", 29, 282, 18, 316, 74, "Total Skew Length Required for Selected MTBH Width and BF", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "76", "70", "RsTextbox", 0, "Conveyor_Curve_BF_Calc_Min_In", 88, 128, 21, 74, 75, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "77", "70", "RsTextbox", 0, "Conveyor_Curve_BF_Calc_Rcmd_In", 115, 127, 21, 74, 76, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "78", "70", "RsComboBox", 0, "Conveyor_BF_Selected_Min_User", 142, 127, 22, 140, 77, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "79", "70", "RsTextbox", 0, "Material_Gap_Override_User", 167, 529, 21, 60, 78, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "80", "70", "RsComboBox", 0, "Conveyor_BF_Selected_Min_User_UOM", 142, 267, 22, 60, 79, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "81", "70", "RsLabel", 0, "", 64, 6, 18, 115, 80, "Min Converyor Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "82", "70", "RsTextbox", 0, "Conveyor_Skew_Total_Length_MTBH_Width_IN", 26, 604, 21, 74, 81, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "83", "70", "RsTextbox", 0, "Conveyor_Skew_Bed_Length_Min_Reqd_IN", 53, 604, 21, 74, 82, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "84", "70", "RsLabel", 0, "", 114, 346, 22, 177, 83, "Target Sort Rate:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "85", "70", "RsCheckbox", 0, "Sort_Dual_Sided", 80, 584, 18, 129, 84, "Dual Sided Sortation", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "86", "70", "RsLabel", 0, "", 145, 684, 18, 22, 85, "M", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "87", "70", "RsTextbox", 0, "Sort_Rate_Required_CPM", 114, 529, 21, 60, 86, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "88", "70", "RsLabel", 0, "", 166, 418, 22, 105, 87, "Design Gap Override:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "89", "70", "RsLabel", 0, "", 117, 590, 18, 116, 88, "CPM (Cases Per Min)", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "90", "70", "RsTextbox", 0, "Case_Length_Per_Minute_Target_FT", 142, 529, 21, 60, 89, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "91", "70", "RsLabel", 0, "", 145, 590, 18, 22, 90, "Ft.", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "92", "70", "RsTextbox", 0, "Case_Length_Per_Minute_Target_M", 142, 618, 21, 60, 91, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 119, "93", "70", "RsLabel", 0, "", 91, 7, 18, 115, 92, "Min Calc Curve Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "94", "70", "RsComboBox", 0, "Material_Gap_Override_User_UOM", 166, 595, 22, 60, 93, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 119, "95", "70", "RsLabel", 0, "", 56, 253, 18, 345, 94, "Minimum Required Skew Bed Length for Selected MTBH Width and BF", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "96", "70", "RsLabel", 0, "", 118, 6, 18, 115, 95, "Min Rcmd Curve Width:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "97", "70", "RsLabel", 0, "", 29, 684, 18, 22, 96, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "98", "70", "RsLabel", 0, "", 56, 684, 18, 22, 97, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "99", "70", "RsLabel", 0, "", 142, 16, 22, 105, 98, "Selected Min Wdith:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "100", "70", "RsLabel", 0, "", 91, 207, 18, 22, 99, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "101", "70", "RsLabel", 0, "", 64, 207, 18, 22, 100, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "102", "70", "RsLabel", 0, "", 118, 207, 18, 22, 101, "In.", 0, 2, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.0;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 119, "103", "0", "RsPrevActionButton", 0, "", 861, 26, 38, 94, 102, "Previous", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 119, "104", "0", "RsNextActionButton", 0, "", 861, 648, 38, 116, 103, "Next", 0, 0, 0, 5, 0, "", "", "ImageFileName:1.;DisabledImageFileName:1.;RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;ButtonStyle:2;Enabled:;")
        oProcessStep.AddCustomLayout(1, 119, "105", "0", "RsTextbox", 0, "Valid_Message", 130, 838, 519, 788, 104, "", -1, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        
        End Sub
      
        '*****************************************************************************
        '   Copyright (C) 2024 Siemens. All rights reserved.
        '
        '   Do not modify this procedure. Changes may render this application
        '   inoperable and will not be supported by Siemens Product Lifecycle Management Software Inc.
        '*****************************************************************************
        Private Sub Initialize_Process_DefaultProcess______Scanner_Config_Debug()
        Dim oProcessStep As ProcessStep = Nothing
        oProcessStep = AddProcessStep(100, "_    Scanner Config Debug", "", 1, 45, 1, 6, 50, 50)
        oProcessStep.AddPath("IGS_AppCalc_App.Scan_Configurations/APC_Scan_Configuration")
        oProcessStep.AddLayout(1, 11, "")
        oProcessStep.AddCustomLayout(1, 417, "1", "0", "RsGroupBox", 0, "", 36, 32, 360, 432, 0, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 417, "2", "1", "RsTextbox", 0, "MinGapForScan_IN", 38, 202, 20, 78, 1, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 417, "3", "1", "RsLabel", 0, "", 245, 60, 18, 136, 2, "Minimum Gap Required:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "4", "1", "RsComboBox", 0, "GapControlMethod", 14, 202, 24, 153, 3, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 417, "5", "1", "RsLabel", 0, "", 194, 60, 18, 136, 4, "Primary Application Type:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "6", "1", "RsLabel", 0, "", 16, 6, 22, 190, 5, "Gap Control (From Soratation):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "7", "1", "RsTextbox", 0, "BoxPanelsScanned", 166, 202, 20, 148, 6, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 417, "8", "1", "RsCheckbox", 0, "ShadowingPotential", 88, 202, 18, 125, 7, "Shadowing Possible", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 417, "9", "1", "RsLabel", 0, "", 168, 88, 18, 108, 8, "Qty Panels Scanned:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "10", "1", "RsCheckbox", 0, "UsePandAMTBH", 64, 202, 18, 114, 9, "Use PandA MTBH", 0, 0, 1, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 417, "11", "1", "RsLabel", 0, "", 327, 60, 18, 136, 10, "Vendor Read Window Size", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "12", "1", "RsComboBox", 0, "CartonPresentation", 136, 202, 24, 153, 11, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 417, "13", "1", "RsComboBox", 0, "ShadowingStatus", 106, 202, 24, 153, 12, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 417, "14", "1", "RsComboBox", 0, "User_UOM_System", 218, 202, 24, 153, 13, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 417, "15", "1", "RsLabel", 0, "", 40, 296, 18, 30, 14, "IN", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "16", "1", "RsTextbox", 0, "AppType", 192, 202, 20, 148, 15, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 417, "17", "1", "RsLabel", 0, "", 142, 82, 18, 114, 16, "Carton Presentation:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "18", "1", "RsTextbox", 0, "MinGapRequired_User", 245, 202, 20, 88, 17, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 417, "19", "1", "RsLabel", 0, "", 112, 82, 18, 114, 18, "Shadowing Allowed?", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "20", "1", "RsTextbox", 0, "MinGapOverride_Vendor_Provider_User", 271, 202, 20, 88, 19, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 417, "21", "1", "RsLabel", 0, "", 38, 40, 18, 156, 20, "Min Gap Allowed:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "22", "1", "RsLabel", 0, "", 273, 6, 18, 190, 21, "Min Gap Required (Vendor) Overide:", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "23", "1", "RsTextbox", 0, "ReadWindowSize_Vendor_Supplied_USER", 327, 202, 20, 88, 22, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 417, "24", "1", "RsTextbox", 0, "ReadWindowSize_USER", 300, 202, 20, 148, 23, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;Disabled:False;")
        oProcessStep.AddCustomLayout(1, 417, "25", "1", "RsLabel", 0, "", 300, 20, 18, 176, 24, "Read Window Size (Estimated):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "26", "1", "RsLabel", 0, "", 218, 54, 18, 142, 25, "System (Global Setup):", 0, 1, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "27", "1", "RsLabel", 0, "MinGapRequired_User_UOM", 273, 296, 18, 31, 26, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "28", "1", "RsLabel", 0, "MinGapRequired_User_UOM", 327, 297, 18, 31, 27, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "29", "1", "RsLabel", 0, "MinGapRequired_User_UOM", 245, 296, 18, 31, 28, "", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "30", "0", "RsLabel", 0, "", 9, 32, 30, 384, 29, "Scanner Config", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.16;Font_Style:1.;ForeColor:ControlText;BackColor:Control;URL:;")
        oProcessStep.AddCustomLayout(1, 417, "31", "0", "RsGroupBox", 0, "", 410, 32, 247, 672, 30, "Panel Configuration", 0, 0, 0, 5, 0, "", "", "Font:1.;Font_Size:1.;Font_Style:1.;")
        oProcessStep.AddCustomLayout(1, 417, "32", "31", "RsGrid", 0, "", 19, 4, 222, 663, 31, "", 0, 0, 0, 5, 0, "", "", "RsTooltip:;Font:1.;Font_Size:1.;Font_Style:1.;SubpartConnection:S,333,Panel_Configs;ShowFilter:False;ShowGroups:False;RowIcon:;RowIconSize:70,70;CanDelete:;RowColor:;RowTooltip:;AddPrompt:False;AllowEdit:True;RememberSelectedPart:False;HorizontalScrollbar:0;AllowSorting:True")
        oProcessStep.AddCustomLayout(1, 417, "33", "32", "RsGridColumn", 0, "Panel_ID", 0, 0, 0, 100, 0, "Panel_ID", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 417, "34", "32", "RsGridColumn", 0, "Is_Scanned", 0, 0, 0, 100, 0, "Is_Scanned", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 417, "35", "32", "RsGridColumn", 0, "Scanner_Selected", 0, 0, 0, 150, 0, "Scanner_Selected", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 417, "36", "32", "RsGridColumn", 0, "Scan_Type", 0, 0, 0, 100, 0, "Scan_Type", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 417, "37", "32", "RsGridColumn", 0, "Scanner_CCD_Position", 0, 0, 0, 100, 0, "Scanner_CCD_Position", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 417, "38", "32", "RsGridColumn", 0, "Scan_Angle_Degrees", 0, 0, 0, 100, 0, "Scan Angle Degrees", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 417, "39", "32", "RsGridColumn", 0, "Scan_Head_Location", 0, 0, 0, 100, 0, "Scan Head Location", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 417, "40", "32", "RsGridColumn", 0, "Product_Spacing_Category", 0, 0, 0, 100, 0, "Spacing Category", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        oProcessStep.AddCustomLayout(1, 417, "41", "32", "RsGridColumn", 0, "Min_Gap_Required", 0, 0, 0, 100, 0, "Min_Gap_Reqd", 0, 0, 0, 5, 0, "", "", "AllowRowFiltering:False;HeaderProperty:;WordWrap:False")
        
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
          InitProperty("App_Calc_Name", "4163", "", "", "Y", "","", 3, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 8:09:50 PM", "", "In Development",  0,5704)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Approved_By", "1215", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:13:01 AM", "", "In Development",  0,1305)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Approved_Date", "1216", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:13:01 AM", "", "In Development",  0,1306)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_Name", "1212", "", "", "Y", "","", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "6/18/2025 8:09:15 PM", "", "In Development",  0,1302)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Estimated_By", "1214", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:13:01 AM", "", "In Development",  0,1304)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Facility_Location", "1213", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:13:01 AM", "", "In Development",  0,1303)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Product_Identifier", "1220", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:17:55 AM", "", "In Development",  0,1310)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Proposal_No", "1217", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:13:01 AM", "", "In Development",  0,1307)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Revision_No", "1218", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:13:01 AM", "", "In Development",  0,1308)
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
          
        InitSubpart("Advanced_Calcs", 51, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,120,121)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Belted_PandA", 38, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,94,95)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Belted_PandA_Layout", 39, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,96,97)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Continuous_RA_Discharge", 42, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,102,103)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Induction", 31, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,80,81)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Instructions", 27, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,72,73)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Intellimerge_PSM", 35, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,88,89)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("MDR_Misc", 41, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,100,101)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("MDR_Sort", 40, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,98,99)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Pre_Merge", 32, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,82,83)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Project_Information", 15, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/28/2025 4:50:10 AM", "", "In Development", "Y",0,233,45)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("R_M_Merge", 34, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,86,87)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Scan_Belt", 44, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,106,107)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Scan_Configurations", 259, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "7/11/2025 6:00:36 PM", "", "In Development", "N",0,709,708)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Setup", 28, "", "", "Y", 0, "-1", "", "GLOBAL\H601424", "6/18/2025 8:58:13 PM", "", "In Development", "Y",0,74,75)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Sortation", 29, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,76,77)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Space_Avail_Merge", 37, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,92,93)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Std_Merge", 33, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,84,85)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("ZFA_Applications", 43, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,104,105)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Zipper_Merge", 36, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,90,91)
        
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
          
        InitConnection("My_PRD", "94", "","", "Y", 0, "-1", "", "GLOBAL\H601424", "7/14/2025 5:13:00 PM", "", "In Development", "N",273)
        
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
        '   BEGIN FORMULA; CON ID:94; TYPE:PF
        Result = Nothing
If Me.Parent Is Nothing Then
	'Result = Me.SFDC_PRD_Local 
Else
	Result = Me.Parent.My_Prd(1)
End If
        '   END FORMULA; CON ID:94; TYPE:PF
      
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_My_PRD_PARTS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return ConvertToCollection(Result)
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Quick_Nav_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:56; TYPE:ST
      result = STATUS_ENABLED
      '   END FORMULA; PROC ID:56; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Process_DefaultProcess_Quick_Nav_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Quick_Nav_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:56; TYPE:CO
      result = ""
      '   END FORMULA; PROC ID:56; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Process_DefaultProcess_Quick_Nav_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Cost_Notes_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:60; TYPE:ST
      result = STATUS_ENABLED
      '   END FORMULA; PROC ID:60; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Process_DefaultProcess_Cost_Notes_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Cost_Notes_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:60; TYPE:CO
      result = ""
      '   END FORMULA; PROC ID:60; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Process_DefaultProcess_Cost_Notes_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Instructions_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:58; TYPE:ST
      result = STATUS_ENABLED
      '   END FORMULA; PROC ID:58; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Process_DefaultProcess_Instructions_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Instructions_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:58; TYPE:CO
      result = ""
      '   END FORMULA; PROC ID:58; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Process_DefaultProcess_Instructions_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Setup_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:61; TYPE:ST
      result = STATUS_ENABLED
      '   END FORMULA; PROC ID:61; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Process_DefaultProcess_Setup_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess_Setup_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:61; TYPE:CO
      result = ""
      '   END FORMULA; PROC ID:61; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Process_DefaultProcess_Setup_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess______Setup_Debug_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:98; TYPE:ST
      result = STATUS_ENABLED
      '   END FORMULA; PROC ID:98; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Process_DefaultProcess______Setup_Debug_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess______Setup_Debug_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:98; TYPE:CO
      result = ""
      '   END FORMULA; PROC ID:98; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Process_DefaultProcess______Setup_Debug_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess______Scanner_Config_Debug_STATUS() as Integer 'Long
      Dim Result as Integer = 0 'Long
      Try
      '   BEGIN FORMULA; PROC ID:100; TYPE:ST
      ' Status Formula Result Constants
' -------------------------------
' STATUS_ENABLED = 0
' STATUS_READONLY = 1
' STATUS_COMPLETED = 2
' STATUS_ATTENTION = 3
' STATUS_HIDDEN = 4
' STATUS_DISABLED = 5

result = STATUS_ENABLED
      '   END FORMULA; PROC ID:100; TYPE:ST
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Process_DefaultProcess______Scanner_Config_Debug_STATUS", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Process_DefaultProcess______Scanner_Config_Debug_COMMENT() as String
      Dim Result as String = ""
      Try
      '   BEGIN FORMULA; PROC ID:100; TYPE:CO
      result = String.Empty
      '   END FORMULA; PROC ID:100; TYPE:CO
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Process_DefaultProcess______Scanner_Config_Debug_COMMENT", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_App_Calc_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("App_Calc_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:4163; TYPE:PF
      Result = Me.Name
      '   END FORMULA; PROP ID:4163; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_App_Calc_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Approved_By() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Approved_By").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1215; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1215; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Approved_By", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Approved_Date() As Date
          Dim Result as Date
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Approved_Date").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1216; TYPE:PF
      result = nothing
      '   END FORMULA; PROP ID:1216; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Approved_Date", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Customer_Name() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Customer_Name").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1212; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1212; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Customer_Name", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Estimated_By() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Estimated_By").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1214; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1214; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Estimated_By", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Facility_Location() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Facility_Location").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1213; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1213; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Facility_Location", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Product_Identifier() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Product_Identifier").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1220; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1220; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Product_Identifier", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Proposal_No() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Proposal_No").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1217; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1217; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Proposal_No", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
          '*****************************************************************************
          '   Copyright (C) 2024 Siemens. All rights reserved.
          '
          '   Changes to this procedure may only be made within formula comment blocks.
          '*****************************************************************************
          Public Function Formula_Revision_No() As String
          
          Dim Result as String = String.Empty
        
      Dim ctx as Object
      Try
      ctx = this
      If Me.Properties("Revision_No").GetDebugState(Rulestream.Kernel.PropertySF.FormulaDebugTypes.VALUE_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; PROP ID:1218; TYPE:PF
      result = ""
      '   END FORMULA; PROP ID:1218; TYPE:PF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Revision_No", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_App_Calc_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Approved_By_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Approved_Date_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Name_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Estimated_By_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Facility_Location_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Identifier_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_No_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Revision_No_HIDE_CALCULATED_VALUE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_App_Calc_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Approved_By_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Approved_Date_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Customer_Name_USERCHANGE() as Boolean
      Return True
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Estimated_By_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Facility_Location_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Product_Identifier_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Proposal_No_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Revision_No_USERCHANGE() as Boolean
      Return False
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Advanced_Calcs_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:51; TYPE:PN
      
      '   END FORMULA; SUB ID:51; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Advanced_Calcs_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Advanced_Calcs_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Advanced_Calcs").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:51; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:51; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Advanced_Calcs_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Advanced_Calcs_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Advanced_Calcs").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:51; TYPE:OP
      result = "APC_Advanced_Calcs"
      '   END FORMULA; SUB ID:51; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Advanced_Calcs_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belted_PandA_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:38; TYPE:PN
      
      '   END FORMULA; SUB ID:38; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Belted_PandA_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belted_PandA_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Belted_PandA").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:38; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:38; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Belted_PandA_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belted_PandA_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Belted_PandA").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:38; TYPE:OP
      result = "APC_Belted_PandA"
      '   END FORMULA; SUB ID:38; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Belted_PandA_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belted_PandA_Layout_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:39; TYPE:PN
      
      '   END FORMULA; SUB ID:39; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Belted_PandA_Layout_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belted_PandA_Layout_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Belted_PandA_Layout").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:39; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:39; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Belted_PandA_Layout_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Belted_PandA_Layout_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Belted_PandA_Layout").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:39; TYPE:OP
      result = "APC_Belted_PandA_Layout"
      '   END FORMULA; SUB ID:39; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Belted_PandA_Layout_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Continuous_RA_Discharge_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:42; TYPE:PN
      
      '   END FORMULA; SUB ID:42; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Continuous_RA_Discharge_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Continuous_RA_Discharge_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Continuous_RA_Discharge").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:42; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:42; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Continuous_RA_Discharge_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Continuous_RA_Discharge_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Continuous_RA_Discharge").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:42; TYPE:OP
      result = "APC_Continuous_RA_Discharge"
      '   END FORMULA; SUB ID:42; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Continuous_RA_Discharge_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induction_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:31; TYPE:PN
      
      '   END FORMULA; SUB ID:31; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Induction_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induction_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Induction").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:31; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:31; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Induction_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Induction_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Induction").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:31; TYPE:OP
      result = "APC_Induction"
      '   END FORMULA; SUB ID:31; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Induction_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Instructions_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:27; TYPE:PN
      
      '   END FORMULA; SUB ID:27; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Instructions_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Instructions_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Instructions").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:27; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:27; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Instructions_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Instructions_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Instructions").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:27; TYPE:OP
      result = "APC_Instructions"
      '   END FORMULA; SUB ID:27; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Instructions_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Intellimerge_PSM_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:35; TYPE:PN
      
      '   END FORMULA; SUB ID:35; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Intellimerge_PSM_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Intellimerge_PSM_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Intellimerge_PSM").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:35; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:35; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Intellimerge_PSM_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Intellimerge_PSM_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Intellimerge_PSM").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:35; TYPE:OP
      result = "APC_Intellimerge_PSM"
      '   END FORMULA; SUB ID:35; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Intellimerge_PSM_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_Misc_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:41; TYPE:PN
      
      '   END FORMULA; SUB ID:41; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_MDR_Misc_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_Misc_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("MDR_Misc").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:41; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:41; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_MDR_Misc_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_Misc_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("MDR_Misc").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:41; TYPE:OP
      result = "APC_MDR_Misc"
      '   END FORMULA; SUB ID:41; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_MDR_Misc_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_Sort_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:40; TYPE:PN
      
      '   END FORMULA; SUB ID:40; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_MDR_Sort_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_Sort_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("MDR_Sort").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:40; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:40; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_MDR_Sort_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_MDR_Sort_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("MDR_Sort").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:40; TYPE:OP
      result = "APC_MDR_Sort"
      '   END FORMULA; SUB ID:40; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_MDR_Sort_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pre_Merge_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:32; TYPE:PN
      
      '   END FORMULA; SUB ID:32; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Pre_Merge_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pre_Merge_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Pre_Merge").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:32; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:32; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Pre_Merge_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Pre_Merge_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Pre_Merge").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:32; TYPE:OP
      result = "APC_Pre_Merge"
      '   END FORMULA; SUB ID:32; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Pre_Merge_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Information_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:15; TYPE:PN
      
      '   END FORMULA; SUB ID:15; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Project_Information_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Information_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Project_Information").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:15; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:15; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Project_Information_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Project_Information_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Project_Information").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:15; TYPE:OP
      result = "IGS_Opportunity_Data"
      '   END FORMULA; SUB ID:15; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Project_Information_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_R_M_Merge_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:34; TYPE:PN
      
      '   END FORMULA; SUB ID:34; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_R_M_Merge_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_R_M_Merge_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("R_M_Merge").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:34; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:34; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_R_M_Merge_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_R_M_Merge_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("R_M_Merge").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:34; TYPE:OP
      result = "APC_R_M_Merge"
      '   END FORMULA; SUB ID:34; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_R_M_Merge_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Belt_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:44; TYPE:PN
      
      '   END FORMULA; SUB ID:44; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Scan_Belt_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Belt_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Scan_Belt").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:44; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:44; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Scan_Belt_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Belt_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Scan_Belt").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:44; TYPE:OP
      result = "APC_Scan_Belt"
      '   END FORMULA; SUB ID:44; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Scan_Belt_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Configurations_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:259; TYPE:PN
      
      '   END FORMULA; SUB ID:259; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Scan_Configurations_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Configurations_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Scan_Configurations").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:259; TYPE:QF
      result = 1
      '   END FORMULA; SUB ID:259; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Scan_Configurations_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Configurations_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Scan_Configurations").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:259; TYPE:OP
      result = "APC_Scan_Configuration"
      '   END FORMULA; SUB ID:259; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Scan_Configurations_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Setup_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:28; TYPE:PN
      
      '   END FORMULA; SUB ID:28; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Setup_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Setup_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Setup").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:28; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:28; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Setup_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Setup_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Setup").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:28; TYPE:OP
      result = "APC_Setup"
      '   END FORMULA; SUB ID:28; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Setup_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sortation_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:29; TYPE:PN
      
      '   END FORMULA; SUB ID:29; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Sortation_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sortation_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Sortation").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:29; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:29; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Sortation_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Sortation_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Sortation").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:29; TYPE:OP
      result = "APC_Sortation"
      '   END FORMULA; SUB ID:29; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Sortation_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Space_Avail_Merge_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:37; TYPE:PN
      
      '   END FORMULA; SUB ID:37; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Space_Avail_Merge_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Space_Avail_Merge_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Space_Avail_Merge").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:37; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:37; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Space_Avail_Merge_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Space_Avail_Merge_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Space_Avail_Merge").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:37; TYPE:OP
      result = "APC_Space_Avail_Merge"
      '   END FORMULA; SUB ID:37; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Space_Avail_Merge_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Std_Merge_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:33; TYPE:PN
      
      '   END FORMULA; SUB ID:33; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Std_Merge_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Std_Merge_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Std_Merge").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:33; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:33; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Std_Merge_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Std_Merge_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Std_Merge").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:33; TYPE:OP
      result = "APC_Std_Merge"
      '   END FORMULA; SUB ID:33; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Std_Merge_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ZFA_Applications_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:43; TYPE:PN
      
      '   END FORMULA; SUB ID:43; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_ZFA_Applications_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ZFA_Applications_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("ZFA_Applications").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:43; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:43; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_ZFA_Applications_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_ZFA_Applications_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("ZFA_Applications").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:43; TYPE:OP
      result = "APC_ZFA_Applications"
      '   END FORMULA; SUB ID:43; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_ZFA_Applications_OPTIMALPARTFAMILY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function
    
      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zipper_Merge_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:36; TYPE:PN
      
      '   END FORMULA; SUB ID:36; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Zipper_Merge_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zipper_Merge_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Zipper_Merge").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:36; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:36; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Zipper_Merge_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Zipper_Merge_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Zipper_Merge").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:36; TYPE:OP
      result = "APC_Zipper_Merge"
      '   END FORMULA; SUB ID:36; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Zipper_Merge_OPTIMALPARTFAMILY", ex.Message)
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

  