Option Strict Off
Option Explicit On 
Option Infer On

'$ Application: APCTMP01
'$ PartFamily: IGS_AppCalc_App
'$ GenerateDate: 06/12/2025 19:28:00

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
    
      Public ReadOnly Property [Scan_Config]() As Rulestream.Kernel.Subpart
      Get
      Return Subparts("Scan_Config")
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
    InitPart("IGS_AppCalc_App", <a><![CDATA[IGS_AppCalc_App]]></a>.Value, 116, "APCTMP01",  "N", "N", False, False, "In Development", "", "App Calc Top Part", "", "", "",  "GLOBAL\H601424", "03/28/2025 05:17:55")
    AddProperty("1521", "Approved_By", <a><![CDATA[Approved By]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:13:01 AM")
    AddProperty("1522", "Approved_Date", <a><![CDATA[Approved Date]]></a>.Value, "", "Date","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:13:01 AM")
    AddProperty("1518", "Customer_Name", <a><![CDATA[Customer Name]]></a>.Value, "", "String","","General","FD", 9999, "", 0,0, "", "", "GLOBAL\H601424", "3/28/2025 5:13:01 AM")
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
      
      oSubpart = AddSubpart(35,"Scan_Config", <a><![CDATA[Scan_Config]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
        oSubpart.AddVPF (121, "APC_Scan_Config", "APC_Scan_Config")
      
      oSubpart = AddSubpart(33,"Setup", <a><![CDATA[Setup]]></a>.Value, "FD", "", "General", 9999, "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM")
      
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
          InitProperty("Approved_By", "1215", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:13:01 AM", "", "In Development",  0,1305)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Approved_Date", "1216", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:13:01 AM", "", "In Development",  0,1306)
        End If
            If Incontext("-1", ctx) Then
          InitProperty("Customer_Name", "1212", "", "", "N", "N","N", 0, "-1", 0, "", "N","0",  "GLOBAL\H601424", "3/28/2025 5:13:01 AM", "", "In Development",  0,1302)
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
          
        InitSubpart("Scan_Config", 30, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,78,79)
        
          End If
        
            If Incontext("-1", ctx) Then
          
        InitSubpart("Setup", 28, "N", "N", "N", 0, "-1", "", "GLOBAL\H601424", "3/26/2025 1:58:22 AM", "", "In Development", "N",0,74,75)
        
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
      Return False
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
      Public Function Formula_Scan_Config_PARTNAMES() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      '   BEGIN FORMULA; SUB ID:30; TYPE:PN
      
      '   END FORMULA; SUB ID:30; TYPE:PN
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Scan_Config_PARTNAMES", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Config_QUANTITY() as Integer 'Long
      
      Dim Result as Integer = 0 'Long
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Scan_Config").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.QUANTITY_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:30; TYPE:QF
      Result = 1
      '   END FORMULA; SUB ID:30; TYPE:QF
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Scan_Config_QUANTITY", ex.Message)
      If ObjectManager.StopOnErrors Then Stop
      End Try
      Return Result
      End Function

      '*****************************************************************************
      '   Copyright (C) 2024 Siemens. All rights reserved.
      '
      '   Changes to this procedure may only be made within formula comment blocks.
      '*****************************************************************************
      Public Function Formula_Scan_Config_OPTIMALPARTFAMILY() as String
      
      Dim Result as String = ""
      Dim ctx as Object
      Try
      ctx = this
      If Me.Subparts("Scan_Config").GetDebugState(Rulestream.Kernel.Subpart.FormulaDebugTypes.OPF_FORMULA) Then
      Stop
      End If
      '   BEGIN FORMULA; SUB ID:30; TYPE:OP
      result = "APC_Scan_Config"
      '   END FORMULA; SUB ID:30; TYPE:OP
      Catch ex As Exception
      ObjectManager.LogError("Application: " + Me.Application + " IGS_AppCalc_App.Formula_Scan_Config_OPTIMALPARTFAMILY", ex.Message)
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

  